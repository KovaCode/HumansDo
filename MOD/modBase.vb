#Region "Imports"
Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.SqlServer.Management.Common
Imports System.IO
Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraBars
#End Region

Module modBase

#Region "Dim's"

    Dim btn1 As AlertButton

    Dim ID As Long
    Dim CN As SqlClient.SqlConnection
    Dim CM As SqlClient.SqlCommand
    Dim DR As SqlClient.SqlDataReader
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim DT As DataTable
    Dim CB As SqlCommandBuilder
#End Region


#Region "FINALIZE - čišćenje :)"

    Public Sub logOUT()
        Dim currentSkin As DevExpress.Skins.Skin = DevExpress.Skins.CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
        Dim skin As String = currentSkin.Name

            If skin <> ReadSetting("skin").ToString Then
                If alerter.SHOW(alerter.icona.upit, alerter.naslov.Izlaz, rm.GetString("mess24") + "" + skin.ToString + """", alerter.button.DaNe) = 0 Then
                    CreateWaitDialog(rm.GetString("waitCaption13"), rm.GetString("waitTitle"))
                    saveconfig("skin", skin)
                    CloseWaitDialog()
                End If
        End If

        If gJEZIK <> ReadSetting("jezik").ToString Then
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Izlaz, rm.GetString("mess25") + "" + gJEZIK + "", alerter.button.DaNe) = 0 Then
                CreateWaitDialog(rm.GetString("waitCaption14"), rm.GetString("waitTitle"))
                saveconfig("jezik", gJEZIK)
                CloseWaitDialog()
            End If
        End If

        gCN.Close() : gCN.Dispose()
        clearTEMP()
        End
    End Sub

    Public Sub clearTEMP()
        Dim s As String
        For Each s In System.IO.Directory.GetFiles(Application.StartupPath + "\TEMP")
            System.IO.File.Delete(s)
        Next s
    End Sub
#End Region


#Region "STORED-ice"
    Public Function startIzvrsenje(ByVal izadatak As Integer, ByVal sOpis As String, ByVal sDetOpis As String, Optional ByVal posto As Integer = 0, Optional test As Integer = 0) As Integer
        Dim id As Integer
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        'CN = New SqlConnection()
        'CN.Open()

        Try
            CM.CommandText = "startIzvr"
            CM.Connection = gCN 'Active Connection
            CM.CommandType = CommandType.StoredProcedure 'Setup Command Type

            CM.Parameters.Add("@iZadatak", SqlDbType.Int) : CM.Parameters("@iZadatak").Value = izadatak
            CM.Parameters.Add("@naziv", SqlDbType.VarChar, 50) : CM.Parameters("@naziv").Value = sOpis.ToString
            CM.Parameters.Add("@detopis", SqlDbType.VarChar, 500) : CM.Parameters("@detopis").Value = "test"
            CM.Parameters.Add("@operater", SqlDbType.Int) : CM.Parameters("@operater").Value = gOper
            CM.Parameters.Add("@posto", SqlDbType.Int) : CM.Parameters("@posto").Value = posto
            CM.Parameters.Add("@test", SqlDbType.Bit) : CM.Parameters("@test").Value = 0
            CM.Parameters.Add("@ID", SqlDbType.Int) : CM.Parameters("@ID").Value = id : CM.Parameters("@ID").Direction = ParameterDirection.InputOutput

            'CM.CommandText = "declare @id bigint " _
            '                + " exec dbo.startIzvr " + izadatak.ToString + ",'" + sOpis.ToString + "','" + sDetOpis.ToString + "'," + gOper.ToString + " ," + posto.ToString + "," + test.ToString + ", " _
            '                + " @id OUTPUT"
            DR = CM.ExecuteReader

        Catch ex As SqlException
            alerter.showErr(ex.Message)
        End Try

        While DR.Read
            id = DR("id")
            flgAktivIzvr = True
        End While

        DR.Close() : DR.Dispose()
        CN.Close()
        CM.Parameters.Clear() : CM.Dispose()

        Return id
    End Function


    Public Sub krajIzvrsenje(ByVal id As Integer, ByVal detOpis As String, posto As Integer)
        'CN.ConnectionString = gDATABASE
        'CN.Open()

        'CM.Connection = gCN
        'CM.CommandType = CommandType.Text
        'CM.CommandText = "execute dbo.krajIzvr " + id.ToString + ", '" + detOpis.ToString + "', " + posto.ToString
        'CM.ExecuteNonQuery()

        'flgAktivIzvr = False
        'CN.Close()


        Dim CM As New SqlCommand

        'CN = New SqlConnection()
        'CN.Open()

        Try
            CM.CommandText = "krajIzvr"
            CM.Connection = gCN 'Active Connection
            CM.CommandType = CommandType.StoredProcedure 'Setup Command Type

            CM.Parameters.Add("@id", SqlDbType.Int) : CM.Parameters("@id").Value = id
            CM.Parameters.Add("@opis", SqlDbType.VarChar, 500) : CM.Parameters("@opis").Value = detOpis.ToString
            CM.Parameters.Add("@posto", SqlDbType.Int) : CM.Parameters("@posto").Value = posto


            'CM.CommandText = "declare @id bigint " _
            '                + " exec dbo.startIzvr " + izadatak.ToString + ",'" + sOpis.ToString + "','" + sDetOpis.ToString + "'," + gOper.ToString + " ," + posto.ToString + "," + test.ToString + ", " _
            '                + " @id OUTPUT"
            CM.ExecuteNonQuery()
            'setStatusZad(24, izadatak)

        Catch ex As SqlException
            alerter.showErr(ex)
        End Try

        DR.Close() : DR.Dispose()
        CN.Close()
        CM.Parameters.Clear() : CM.Dispose()
    End Sub

    Public Sub setStatusZad(ByVal status As Integer, ByVal zadatak As Integer, Optional komentar As String = "")
        Dim CM2 As SqlCommand
        CN = New SqlConnection(gDATABASE)
        CN.Open()

        CM2 = New SqlCommand()
        CM2.CommandText = "setStatusZ"
        CM2.Connection = CN 'Active Connection
        CM2.CommandType = CommandType.StoredProcedure 'Setup Command Type

        CM2.Parameters.Add("@status", SqlDbType.Int) : CM2.Parameters("@status").Value = status
        CM2.Parameters.Add("@oper", SqlDbType.Int) : CM2.Parameters("@oper").Value = gOper
        CM2.Parameters.Add("@zadatak", SqlDbType.Int) : CM2.Parameters("@zadatak").Value = zadatak
        CM2.Parameters.Add("@komentar", SqlDbType.VarChar, 500) : CM2.Parameters("@komentar").Value = komentar.ToString
        CM2.ExecuteReader()
        CM2.Dispose()

    End Sub

    Public Sub setStatusProjekt(ByVal status As Integer, ByVal projekt As Integer, Optional komentar As String = "")
        Dim CM2 As SqlCommand
        CN = New SqlConnection(gDATABASE)
        CN.Open()

        CM2 = New SqlCommand()
        CM2.CommandText = "setStatusP"
        CM2.Connection = CN 'Active Connection
        CM2.CommandType = CommandType.StoredProcedure 'Setup Command Type

        CM2.Parameters.Add("@id", SqlDbType.Int) : CM2.Parameters("@id").Value = projekt
        CM2.Parameters.Add("@status", SqlDbType.Int) : CM2.Parameters("@status").Value = status
        CM2.Parameters.Add("@komentar", SqlDbType.VarChar, 500) : CM2.Parameters("@komentar").Value = komentar.ToString
        CM2.ExecuteReader()
        CM2.Dispose()
    End Sub


    Public Function getIzvrsenjeTime(ByVal iZadatak As Integer) As String
        Dim s As String

        CN = New SqlConnection(gDATABASE)
        CN.Open()

        CM = New SqlCommand()
        CM.CommandText = "ukupVrijemeIzvr"
        CM.Connection = CN 'Active Connection
        CM.CommandType = CommandType.StoredProcedure 'Setup Command Type

        CM.Parameters.Add("@iZadatak", SqlDbType.Int) : CM.Parameters("@iZadatak").Value = iZadatak
        CM.Parameters.Add("@totalVrijeme", SqlDbType.VarChar) : CM.Parameters("@totalVrijeme").Value = "00:00:00" : CM.Parameters("@totalVrijeme").Direction = ParameterDirection.InputOutput
        DR = CM.ExecuteReader()

        If DR.HasRows Then
            While DR.Read
                s = iNullTime(DR("total"))
                s = FormatDateTime(s, DateFormat.LongTime)
            End While
        End If
        DR.Close()

        getIzvrsenjeTime = s

        CN.Close()
        CM.Parameters.Clear() : CM.Dispose()
    End Function


    Public Function getProjektTime(ByVal iProjekt As Integer) As String
        Dim s As String

        CN = New SqlConnection(gDATABASE)
        CN.Open()

        CM = New SqlCommand()
        CM.CommandText = "ukupvrijemeProjekt"
        CM.Connection = CN 'Active Connection
        CM.CommandType = CommandType.StoredProcedure 'Setup Command Type

        CM.Parameters.Add("@iProjekt", SqlDbType.Int) : CM.Parameters("@iProjekt").Value = iProjekt
        CM.Parameters.Add("@totalVrijeme", SqlDbType.VarChar) : CM.Parameters("@totalVrijeme").Value = "00:00:00" : CM.Parameters("@totalVrijeme").Direction = ParameterDirection.InputOutput
        DR = CM.ExecuteReader()

        If DR.HasRows Then
            While DR.Read
                s = iNullTime(DR("total"))
                s = FormatDateTime(s, DateFormat.LongTime)
            End While
        End If
        DR.Close()

        getProjektTime = s

        CN.Close()
        CM.Dispose()
    End Function
#End Region


#Region "FUNKCIJE - get"


    Public Function getOsobaJMBG(jmbg As String) As Integer
        If jmbg.Length = 13 Then
            Dim DA As New SqlDataAdapter("Select id from operateri where jmbg='" + jmbg.ToString + "'", gCN)
            Dim DS As New DataSet

            DA.Fill(DS, "getOsobaJMBG")

            getOsobaJMBG = DS.Tables("getOsobaJMBG").Rows(0)("id").ToString
            DA.Dispose()
            DS.Clear() : DS.Dispose()
        Else
            getOsobaJMBG = 0
        End If

    End Function

    Public Function getOsobaOIB(OIB As String) As Integer
        If OIB.Length = 11 Then
            Dim DA As New SqlDataAdapter("Select id from operateri where oib='" + OIB.ToString + "'", gCN)
            Dim DS As New DataSet

            DA.Fill(DS, "getOsobaJMBG")

            getOsobaOIB = DS.Tables("getOsobaJMBG").Rows(0)("id").ToString
            DA.Dispose()
            DS.Clear() : DS.Dispose()
        Else
            getOsobaOIB = 0
        End If

    End Function

    Public Function Izvrsenje2Zad(gIzvrsenje As Integer) As Integer
        Dim DA As New SqlDataAdapter("Select dbo.getizvrsenje2zadatak(" + gIzvrsenje.ToString + ")as gZadatak", gCN)
        Dim DS As New DataSet

        DA.Fill(DS, "getizvrsenje2zadatak")

        Izvrsenje2Zad = DS.Tables("getizvrsenje2zadatak").Rows(0)("gZadatak").ToString
        DA.Dispose()
        DS.Clear() : DS.Dispose()

    End Function

    Public Function zadatak2Projekt(gZadatak As Integer) As Integer
        Dim DA As New SqlDataAdapter("select dbo.getZad2Projekt(" + gZadatak.ToString + ") as gProjekt, " _
                                   + "dbo.getProjekt(dbo.getZad2Projekt(" + gZadatak.ToString + ")) as gProjekt", gCN)
        Dim DS As New DataSet

        DA.Fill(DS, "pro2zad")

        zadatak2Projekt = DS.Tables("pro2zad").Rows(0)("gProjekt").ToString
        DA.Dispose()
        DS.Clear() : DS.Dispose()

    End Function


    Public Function getPTT(iMjesto As Integer) As String
        If iMjesto > 0 Then
            Dim DA As New SqlDataAdapter("Select ptt from mjesta where ID=" + iMjesto.ToString, gCN)
            Dim DS As New DataSet

            DA.Fill(DS, "getPTT")

            getPTT = DS.Tables("getPTT").Rows(0)("ptt").ToString
            DA.Dispose()
            DS.Clear() : DS.Dispose()
        Else
            getPTT = 0
        End If

    End Function

    Public Function getPravaOpis(ByVal vrsta As Integer) As String
        CN = New SqlConnection(gDATABASE)
        CN.Open()

        CM = New SqlCommand("select naziv from vrste where tip=2 and tezina= " + vrsta.ToString, CN)
        DR = CM.ExecuteReader

        While DR.Read
            getPravaOpis = DR("naziv")
        End While


        DR.Close()
        CM.Dispose()
        CN.Close()
    End Function

    Public Function getOperater(id As Integer) As String
        Dim DA As New SqlDataAdapter("Select dbo.getOsoba(" + id.ToString + ")as osoba", gCN)
        Dim DS As New DataSet

        DA.Fill(DS, "oper")

        getOperater = DS.Tables("oper").Rows(0)("osoba").ToString
        DA.Dispose()
        DS.Clear() : DS.Dispose()
    End Function

    Public Function getProjekt(ByVal idProjekt As Integer) As String
        Dim DA As New SqlDataAdapter("select dbo.getProjekt (" + idProjekt.ToString + ")as sOpis", gCN)
        Dim DS As New DataSet

        If DS.Tables.IndexOf("getProjekt") > -1 Then
            DS.Tables("getProjekt").Clear()
        End If

        Try
            DA.Fill(DS, "getProjekt")
        Catch ex As Exception
            alerter.SHOW("x", "Greška", ex.Message)
        End Try

        getProjekt = DS.Tables("getProjekt").Rows(0)("sOpis").ToString

        DA.Dispose()
        DS.Clear() : DS.Dispose()

    End Function

    Public Function getZadatak(ByVal idZad As Integer) As String
        Dim DA As New SqlDataAdapter("select dbo.getZadatak (" + idZad.ToString + ")as sOpis", gCN)
        Dim DS As New DataSet

        If DS.Tables.IndexOf("getZadatak") > -1 Then
            DS.Tables("getZadatak").Clear()
        End If

        Try
            DA.Fill(DS, "getZadatak")
        Catch ex As Exception
            alerter.SHOW("x", "Greška", ex.Message)
        End Try

        getZadatak = DS.Tables("getZadatak").Rows(0)("sOpis").ToString

        DA.Dispose()
        DS.Clear() : DS.Dispose()

    End Function

    Public Function GetFileSize(ByVal MyFilePath As String) As Long
        Dim MyFile As New FileInfo(MyFilePath)
        Dim FileSize As Long = MyFile.Length

        FileSize = FileSize / 1024

        Return FileSize
    End Function


    Public Function getPicDB(ByRef imageID As String) As Object
        Try

            CN = New SqlConnection(gDATABASE)
            CN.Open()

            CM = CN.CreateCommand()
            CM.CommandText = "SELECT Image,tip FROM images WHERE id = " + imageID.ToString

            DR = CM.ExecuteReader

            If DR.Read Then
                Dim imgByteArray() As Byte

                Try
                    imgByteArray = CType(DR(0), Byte())
                    Dim stream As New MemoryStream(imgByteArray)

                    Select Case DR("tip")
                        Case "ico"
                            Dim ico As New Icon(stream)
                            stream.Close()
                            Return ico

                        Case Else
                            Dim bmp As New Bitmap(stream)
                            stream.Close()
                            Return bmp
                    End Select


                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Return Nothing
                End Try
            End If

            DR.Close()
            CN.Close()

            CM.Dispose()
            CN.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
#End Region


#Region "save/get BLOB"
    Public Function saveFileSQL(ByVal filePath As String, ByVal veza As Integer, Optional ByVal tip As String = "*")
        Dim cn As New SqlConnection(gDATABASE)
        Dim da As New SqlDataAdapter("Select * From images", cn)
        Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)
        Dim ds As New DataSet()
        Dim ext As String
        Dim nazivFile As String
        Dim sizeKb As Long

        'da.MissingSchemaAction = MissingSchemaAction.AddWithKey

        Dim fs As New FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read)
        Dim MyData(fs.Length) As Byte
        fs.Read(MyData, 0, fs.Length)
        fs.Close()
        cn.Open()
        da.Fill(ds, "MyImages")

        ext = Right(filePath, 3)
        nazivFile = IO.Path.GetFileName(filePath)
        sizeKb = GetFileSize(filePath)

        AddHandler da.RowUpdated, AddressOf da_handle_rowupdated

        Dim row As DataRow
        row = ds.Tables("MyImages").NewRow()
        row("image") = MyData
        row("tip") = ext
        row("oper") = gOper
        row("datum") = Now.ToShortTimeString
        row("naziv") = nazivFile
        row("veza") = veza
        row("sizeKB") = sizeKb
        row("vrsta") = tip

        'ds.Tables("image").Rows.Add(row)
        'da.Update(ds, "image")

        ds.Tables("MyImages").Rows.Add(row)
        da.Update(ds, "MyImages")

        Return ID

        fs = Nothing
        MyCB = Nothing
        ds = Nothing
        da = Nothing

        cn.Close() : cn = Nothing
        'MsgBox("Image saved to database")
    End Function

    Public Function loadFileSQL(ByVal id As Integer, Optional flgOpenFile As Boolean = True) As String
        Dim cn As New SqlConnection(gDATABASE)
        Dim da As New SqlDataAdapter("Select * From images where id=" + id.ToString, cn)
        Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)
        Dim ds As New DataSet()

        cn.Open()
        Try
            da.Fill(ds, "MyImages")
        Catch ex As Exception
            alerter.SHOW("x", "Greška", ex.Message)
        End Try

        Dim myRow As DataRow
        myRow = ds.Tables("MyImages").Rows(0)

        Dim MyData() As Byte
        MyData = myRow("image")
        Dim K As Long
        K = UBound(MyData)

        Dim fs As New FileStream(Application.StartupPath + "\TEMP\" + ds.Tables("myImages").Rows(0)("naziv").ToString(), FileMode.OpenOrCreate, FileAccess.Write)
        fs.Write(MyData, 0, K)
        fs.Close()

        Dim sTempFileName As String = Application.StartupPath + "\TEMP\" + ds.Tables("myImages").Rows(0)("naziv").ToString()
        If flgOpenFile = True Then
            System.Diagnostics.Process.Start(sTempFileName)
        End If


        loadFileSQL = sTempFileName

        fs = Nothing
        MyCB = Nothing
        ds = Nothing
        da = Nothing

        cn.Close() : cn = Nothing
        'MsgBox("Image retrieved")
    End Function
#End Region


#Region "FUNKCIJE - check"

    Public Function checkFileRTF(veza As Integer, vrsta As String, Optional oper As Integer = 0) As Integer
        Dim DA As New SqlDataAdapter()
        Dim DS As New DataSet

        If oper = 0 Then
            DA = New SqlDataAdapter("Select id from images where veza=" + veza.ToString + " and oper =" + gOper.ToString + " and vrsta = '" + vrsta.ToString + "'", gCN)
        Else
            DA = New SqlDataAdapter("Select id from images where veza=" + veza.ToString + " and oper =" + oper.ToString + " and vrsta = '" + vrsta.ToString + "'", gCN)
        End If

        Try
            DA.Fill(DS, "chkFile")
        Catch ex As Exception
            alerter.SHOW("x", "Greška", ex.Message)
        End Try

        checkFileRTF = DS.Tables("chkFile").Rows(0)("ID")
        DA.Dispose()
        DS.Clear() : DS.Dispose()
    End Function







    Public Function task2Activate() As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet

        DA = New SqlDataAdapter("SELECT z.id,z.naziv,z.voditelj,vz.zadStatus FROM zadaci z JOIN vezaZadOper vz " _
                              + " ON z.id=vz.zadatak where vz.zadStatus = -201 and vz.oper = " + gOper.ToString, gCN)
        Try
            DA.Fill(DS, "taskA")
        Catch e As Exception
            MsgBox(e.Message)
            alerter.SHOW("x", "Greška", e.Message, "Nastavak")
        End Try

        If DS.Tables("taskA").Rows.Count > 0 Then
            task2Activate = True
        End If

        DA.Dispose() : DS.Clear()
    End Function

    Public Function task2Validate(Optional zadatak As Integer = 0) As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet

        task2Validate = False

        DA = New SqlDataAdapter("SELECT z.id,z.naziv,z.voditelj,vz.zadStatus " _
                                + " FROM zadaci z JOIN vezaZadOper vz ON z.id=vz.zadatak " _
                                + "  where vz.zadStatus in (-202,-100) and z.voditelj=" + gOper.ToString + " " _
                                + " and z.ID=" + zadatak.ToString, gCN)

        Try
            DA.Fill(DS, "taskV")
        Catch e As Exception
            MsgBox(e.Message)
            alerter.SHOW("x", "Greška", e.Message, "Nastavak")
        End Try

        If DS.Tables("taskV").Rows.Count > 0 Then
            task2Validate = True
        End If

        DA.Dispose() : DS.Clear()
    End Function


    Public Function checkDocCount(ByVal id As Integer, vrsta As String) As Integer
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim ukDoc As Integer = 0

        If DS.Tables.IndexOf("document") > -1 Then
            DS.Tables("document").Clear()
            DS.Tables("document").Reset()
        End If

        DA = New SqlDataAdapter("select id from images where veza=" + id.ToString + " and vrsta='" + vrsta.ToString + "'", gCN)
        Try
            DA.Fill(DS, "document")
        Catch ex As Exception
            alerter.SHOW("x", "Greška", ex.Message)
        End Try
        ukDoc = DS.Tables("document").Rows.Count



        DA.Dispose()
        checkDocCount = ukDoc
    End Function


#End Region


    '#Region "PopUp"

    '    Public Enum popUpnaslov
    '        Obavijest = 0
    '        NoviZadatak = 1
    '        Validacija = 2
    '        Završetak = 3
    '        Testiranje = 4
    '    End Enum

    '    Public Enum popUpTipke
    '        None = 0
    '        Otvori = 1
    '    End Enum

    '    Public Enum popUpicona
    '        info = 0
    '        upozorenje = 1
    '        upit = 2
    '        zabrana = 3
    '        greška = 4
    '        system = 5
    '    End Enum


    '    ''srediti
    '    'Private Sub alertControl1_ButtonDownChanged(ByVal sender As Object, ByVal e As AlertButtonDownChangedEventArgs)
    '    '    If e.ButtonName = "buttonOpen" Then
    '    '        '...
    '    '    End If
    '    'End Sub

    '    'Private Sub alertControl1_ButtonClick(ByVal sender As Object, ByVal e As AlertButtonClickEventArgs)
    '    '    If e.ButtonName = "buttonAlert" Then
    '    '        '...
    '    '    End If
    '    'End Sub

    '    Public Sub createPopUp2(Optional Naslov As popUpnaslov = popUpnaslov.Obavijest, Optional ByVal text As String = "", Optional ByVal hyperText As String = "", Optional ByVal tipke As popUpTipke = popUpTipke.None, Optional ByVal icon As popUpicona = popUpicona.info)
    '        Dim images As Image
    '        'Dim parts As String() = buttons.Split(New Char() {"|"c})
    '        Dim info As AlertInfo


    '        Select Case tipke
    '            Case popUpTipke.None

    '            Case popUpTipke.Otvori
    '                images = My.Resources.Security___Alert_432
    '                btn1 = New AlertButton(images)
    '                btn1.Hint = "Open file"
    '                btn1.Name = "buttonOpen"
    '                frmMainNew.AlertControl1.Buttons.Add(btn1)
    '                AddHandler frmMainNew.AlertControl1.ButtonClick, AddressOf alertControl1_ButtonClick
    '                AddHandler frmMainNew.AlertControl1.ButtonDownChanged, AddressOf alertControl1_ButtonDownChanged
    '        End Select



    '        'Dim part As String
    '        'For Each part In parts
    '        '    Select Case part
    '        '        Case "ok"
    '        '            Dim btnOK As AlertButton = New AlertButton(Image.FromFile("C:\Users\Ivan Kovačić\Desktop\HumansDo\HumansDo\MISC\Icons\check.png"))
    '        '            btnOK.Hint = "OK"
    '        '            btnOK.Name = "okButton"
    '        '            btnOK.Style = AlertButtonStyle.Button
    '        '            AlertControl1.Buttons.Add(btnOK)

    '        '        Case "cancel"
    '        '            Dim btnCancel As AlertButton = New AlertButton(Image.FromFile("C:\Users\Ivan Kovačić\Desktop\HumansDo\HumansDo\MISC\Icons\delete.png"))
    '        '            btnCancel.Hint = "Cancel"
    '        '            btnCancel.Name = "cancelButton"
    '        '            btnCancel.Style = AlertButtonStyle.Button
    '        '            AlertControl1.Buttons.Add(btnCancel)

    '        '        Case "setup"
    '        '            Dim btnSetup As AlertButton = New AlertButton(Image.FromFile("C:\Users\Ivan Kovačić\Desktop\HumansDo\HumansDo\bin\Debug\MISC\Icons\run_16.png"))
    '        '            btnSetup.Hint = "Open file"
    '        '            btnSetup.Name = "Setup"
    '        '            btnSetup.Style = AlertButtonStyle.CheckButton
    '        '            AlertControl1.Buttons.Add(btnSetup)
    '        '    End Select
    '        'Next

    '        AddHandler frmMainNew.AlertControl1.ButtonClick, AddressOf alertControl1_ButtonClick
    '        AddHandler frmMainNew.AlertControl1.ButtonDownChanged, _
    '        AddressOf alertControl1_ButtonDownChanged

    '        Select Case icon
    '            Case popUpicona.info
    '                images = My.Resources.Security___Alert_432
    '            Case popUpicona.upozorenje
    '                images = My.Resources.Security___Alert_436
    '            Case popUpicona.upit
    '                images = My.Resources.Security___Alert_446
    '            Case popUpicona.greška
    '                images = My.Resources.Security___Alert_440
    '            Case popUpicona.system
    '                images = My.Resources.humansDO
    '            Case popUpicona.zabrana

    '        End Select
    '        'frmMain.AlertControl1.Buttons.PinButton.State = AlertButtonState.NormalChecked

    '        info = New AlertInfo(Naslov, text, hyperText, images)
    '        frmMainNew.AlertControl1.Show(frmMainNew, info)
    '        frmMainNew.AlertControl1.Dispose()
    '    End Sub


    '    Private Sub alertControl1_ButtonDownChanged(ByVal sender As Object, ByVal e As AlertButtonDownChangedEventArgs)
    '        If e.ButtonName = "buttonOpen" Then
    '            MsgBox("open")
    '        End If
    '    End Sub

    '    Private Sub alertControl1_ButtonClick(ByVal sender As Object, ByVal e As AlertButtonClickEventArgs)
    '        If e.ButtonName = "buttonAlert" Then
    '            '...
    '        End If
    '    End Sub
    '#End Region


#Region "OSTALO"
    Private Sub da_handle_rowupdated(ByVal sender As Object, ByVal e As SqlRowUpdatedEventArgs)
        If e.Status = UpdateStatus.Continue And e.StatementType = StatementType.Insert Then
            e.Row("id") = getidentity(e.Command.Connection)
            e.Row.AcceptChanges()
            ID = e.Row("id")
        End If
    End Sub

    Private Function getidentity(ByRef cnn As SqlConnection) As Integer
        Dim ocmd As New SqlCommand("select @@identity", cnn)
        Dim x As Object = ocmd.ExecuteScalar()
        Return CInt(x)
    End Function

#End Region




End Module


