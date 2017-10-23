#Region "Imports"
Imports System.Xml
Imports System.IO
Imports System.Net
Imports System.Data.SqlClient
Imports System.Text
Imports System.Net.Sockets
Imports System
Imports System.Configuration
Imports System.Reflection
Imports System.Collections.Generic
Imports System.Resources
Imports System.Globalization
Imports System.Threading
#End Region

Module modMain

#Region "Public's"
    Public gCN As SqlClient.SqlConnection

    Public gAPPNAME As String = "humansDO"
    Public gAPPVER As String = "0.0.2b"
    Public gDATABASE As String
    'Public gDATABASE As String
    Public gDATABASEname As String
    Public gLogin As String
    Public gManualPath = Application.StartupPath + "\MISC\upute"

    Public gActiveTime As Integer

    Public gLOGGPATH As String = Application.StartupPath + "\LOGG"
    Public gTEMPPATH As String = Application.StartupPath + "\TEMP"
    Public gLOGGname As String
    Public gMYDOCS As String
    Public gSETUP As String
    Public gInput As String
    Public gUser As String
    Public gOperater As String
    Public gPravaOpis As String
    Public gIP As String
    Public gSKIN As String
    Public gJEZIK As String

    Public gOper As Integer
    Public gPrava As Integer         ''(VRSTE=2 / 1=Voditelj, 2=Programer, 3=Operater, 4 = Tester, 12=Gost)
    Public gIzvrsenje As Integer
    Public gZadatak As Integer
    Public gProjekt As Integer

    Public gSpecialPrava As Integer
    Public gOutput As Integer = -1

    Public gValue As Object

    Public gFlgCustomPrava As Boolean = False
    Public gPopUp As Boolean
    Public flgClient As Boolean
    Public flgServer As Boolean
    Public flgAktivIzvr As Boolean = False
    Public flgAdmin As Boolean = False
    Public ALERTON As Boolean = False
    Public ALERTONerr As Boolean = False
    Public ServerWasStopped As Boolean
    Dim CM As New SqlCommand
    Dim DR As SqlDataReader

    'komunikacija
    Public ServerClientSocket As Socket
    Public ServerSocket As Socket
    Public ASCII As New ASCIIEncoding


    Public Delegate Sub NoParamsDelegate()
    Public Delegate Sub OneStringDelegate(ByVal Data As String)
    Dim config As Configuration
    Public rm As New ResourceManager("humansDo.Resource", [Assembly].GetExecutingAssembly())
#End Region


#Region "INITIALIZE SETUP"

    Public Sub Main()

    End Sub

    Public Function initSetup()
        gSETUP = ReadSetting("setup")

        If gSETUP = "True" Then
            initSetup = True

            'logg
            gLOGGname = ReadSetting("logg")
            folderExists(Application.StartupPath + "\LOGG", True)
            gLOGGPATH = Application.StartupPath + "\LOGG\" + gLOGGname.ToString

            If fileExists(gLOGGPATH, True) = False Then
                instantiateXML()
            End If

            'jezik
            gJEZIK = ReadSetting("jezik").ToString
            Dim objCI As New CultureInfo(gJEZIK)
            Thread.CurrentThread.CurrentCulture = objCI
            Thread.CurrentThread.CurrentUICulture = objCI
            rm = New ResourceManager("humansDo.Resource", [Assembly].GetExecutingAssembly())

        Else
            initSetup = False
        End If
    End Function
#End Region


#Region "INITALIZE SYSTEM"

    Public Sub initializeSystem()

        gLOGGname = ReadSetting("logg")
        gLOGGPATH = Application.StartupPath + "\LOGG\" + gLOGGname.ToString
        If fileExists(gLOGGPATH, True) = False Then
            instantiateXML()
        End If


        gDATABASE = ReadSetting("cn").ToString
        gDATABASE = decryptString(gDATABASE).ToString
        gDATABASEname = GetDatabaseName(gDATABASE)


        gSKIN = ReadSetting("skin").ToString
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(gSKIN)


        gJEZIK = ReadSetting("jezik").ToString
        Dim objCI As New CultureInfo(gJEZIK)
        Thread.CurrentThread.CurrentCulture = objCI
        Thread.CurrentThread.CurrentUICulture = objCI
        rm = New ResourceManager("humansDo.Resource", [Assembly].GetExecutingAssembly())


        gMYDOCS = Application.StartupPath + "\MOJI DOKUMENTI"

        folderExists(Application.StartupPath + "\LOGG", True)
        folderExists(Application.StartupPath + "\TEMP", True)
        folderExists(Application.StartupPath + "\MOJI DOKUMENTI", True)

        gCN = New SqlClient.SqlConnection(gDATABASE)
        gCN.Open()

    End Sub

#End Region


#Region "LOGG"
    Public Sub instantiateXML()
        Dim writer As XmlTextWriter = New XmlTextWriter(gLOGGPATH, Nothing)
        writer.WriteStartDocument()
        writer.WriteStartElement("logs", "")
        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()
    End Sub


    Public Sub logg(ByVal mess As String)
        Dim xmlDoc As New System.Xml.XmlDocument()
        Dim root As Xml.XmlElement
        Dim loggOper As Xml.XmlElement
        Dim loggMess As Xml.XmlElement
        Dim attChkSum As Xml.XmlAttribute
        Dim sOper As String = "SYSTEM"

        If IsNothing(gLOGGPATH) = True Then
            gLOGGname = ReadSetting("logg").ToString
        End If

        If IsNothing(gOperater) Or gOperater = "" Then
            sOper = "SYSTEM"
        Else
            sOper = gOperater
        End If

        sOper = Replace(sOper, " ", "")
        sOper = Replace(sOper, "č", "c")
        sOper = Replace(sOper, "ć", "c")
        sOper = sOper.ToString + "_"

        xmlDoc.Load(gLOGGPATH)

        root = xmlDoc.DocumentElement
        If root.HasChildNodes = True Then
            For i = 0 To root.ChildNodes.Count - 1
                If root.ChildNodes(i).Name = sOper Then
                    loggOper = root.ChildNodes(i)
                    Exit For
                Else
                    loggOper = xmlDoc.CreateElement(sOper)
                End If
            Next i
        Else
            loggOper = xmlDoc.CreateElement(sOper)
            root.AppendChild(loggOper)
        End If

        Dim text As String = "_" + Today.Day.ToString.PadLeft(2, "0") + "." + Today.Month.ToString.PadLeft(2, "0") + "." + Today.Year.ToString.PadLeft(2, "0") + "-" + Now.Hour.ToString.PadLeft(2, "0") + Now.Minute.ToString.PadLeft(2, "0") + Now.Second.ToString.PadLeft(2, "0") + Now.Millisecond.ToString.PadLeft(2, "0")
        loggMess = xmlDoc.CreateElement(text)
        loggMess.InnerText = mess
        attChkSum = xmlDoc.CreateAttribute("check")
        attChkSum.Value = chksm(text)
        loggMess.Attributes.Append(attChkSum)

        loggOper.AppendChild(loggMess)
        xmlDoc.Save(gLOGGPATH)

    End Sub
#End Region


#Region "funkcije"

    Public Function CheckJMBG(ByVal s As String) As Boolean
        Dim i As Long
        Dim z As Long

        CheckJMBG = False
        If Len(s) <> 13 Then Exit Function
        If Not IsNumeric(s) Then Exit Function

        '' DODATNA PROVJERA -----------------
        If Val(Mid(s, 5, 3)) < 900 And Val(Mid(s, 5, 3)) > 100 Then Exit Function
        If Val(Mid(s, 3, 2)) > 12 Then Exit Function
        '' ----------------------------------

        z = 0
        For i = 1 To 6
            z = z + (Val(Mid$(s, i, 1)) + Val(Mid$(s, i + 6, 1))) * (8 - i)
        Next i
        z = (11 - (z Mod 11)) Mod 11
        If z = 10 Then Exit Function
        CheckJMBG = Right$(s, 1) = z

    End Function

    Public Function CheckMB(ByVal s As String) As Boolean
        Dim i As Long
        Dim z As Long

        CheckMB = False
        '  If Len(s) > 8 Then s = Left$(s, Len(s) - 4)
        s = Right$("0000" & s, 8)
        If Len(s) = 12 Then s = Right$(s, 8)
        If Len(s) <> 8 Then Exit Function
        z = 0
        For i = 1 To 7
            z = z + (Val(Mid$(s, i, 1))) * (9 - i)
        Next i
        z = 11 - (z Mod 11)
        If z = 11 Then Exit Function
        CheckMB = Right$(s, 1) = z Mod 10
    End Function

    Public Function CheckOIB(ByVal oib As String) As Boolean
        Dim i As Integer
        Dim znamenka As Integer
        Dim zbroj As Integer
        Dim medjuOstatak As Integer
        Dim ostatak As Integer
        Dim umnozak As Integer
        Dim KontrolniBr As Integer


        CheckOIB = False

        If Len(oib) = 0 Then Exit Function
        If Len(oib) <> 11 Then Exit Function

        ostatak = 10

        For i = 0 To 9
            znamenka = Val(Mid(oib, i + 1, 1))
            zbroj = znamenka + ostatak
            medjuOstatak = zbroj Mod 10

            If medjuOstatak = 0 Then
                medjuOstatak = 10
            End If

            umnozak = medjuOstatak * 2
            ostatak = umnozak Mod 11
        Next i

        KontrolniBr = 11 - ostatak

        If KontrolniBr = 10 Then KontrolniBr = 0
        If KontrolniBr = Val(Right$(oib, 1)) Then CheckOIB = True
    End Function

    Function GetDatabaseName(ByVal connString As String) As String
        Dim lcConnString = connString.ToLower()
        ' if this is a Jet database, find the index of the "data source" setting
        Dim startIndex As Integer
        If lcConnString.IndexOf("jet.oledb") > -1 Then
            startIndex = lcConnString.IndexOf("data source=")
            If startIndex > -1 Then startIndex += 12
        Else
            ' if this is a SQL Server database, find the index of the "initial 
            ' catalog" or "database" setting
            startIndex = lcConnString.IndexOf("initial catalog=")
            If startIndex > -1 Then
                startIndex += 16
            Else ' if the "Initial Catalog" setting is not found,
                ' try with "Database"
                startIndex = lcConnString.IndexOf("database=")
                If startIndex > -1 Then startIndex += 9
            End If
        End If
        ' if the "database", "data source" or "initial catalog" values are not 
        ' found, return an empty string
        If startIndex = -1 Then Return ""
        ' find where the database name/path ends
        Dim endIndex As Integer = lcConnString.IndexOf(";", startIndex)
        If endIndex = -1 Then endIndex = lcConnString.Length
        ' return the substring with the database name/path
        Return connString.Substring(startIndex, endIndex - startIndex)
    End Function

    Public Function fileExists(ByVal fullPath As String, Optional ByVal createFile As Boolean = False) As Boolean
        If File.Exists(fullPath) Then
            Return True
        Else
            If createFile = True Then
                Dim fs As FileStream
                fs = New FileStream(fullPath, FileMode.Create, FileAccess.ReadWrite)
                fs.Close()
            End If

            Return False
        End If
    End Function

    Public Function folderExists(ByVal fullPath As String, Optional ByVal createFile As Boolean = False) As Boolean
        Dim di As DirectoryInfo = New DirectoryInfo(fullPath)
        Try
            If di.Exists Then
                Console.WriteLine("That path exists already.")
                Return False
            End If
            di.Create()
            Console.WriteLine("The directory was created successfully.")

        Catch e As Exception
            Console.WriteLine("The process failed: {0}", e.ToString())
        End Try
    End Function

    Public Function PassWordPolicy(passPolicy As Integer, ByVal password As String, ByRef tip As String) As Boolean
        Dim CM As SqlClient.SqlCommand
        Dim CN As SqlClient.SqlConnection
        Dim DR As SqlClient.SqlDataReader

        Dim upperCount As Integer = 0
        Dim lowerCount As Integer = 0
        Dim digitCount As Integer = 0
        Dim symbolCount As Integer = 0

        PassWordPolicy = True

        For i = 0 To password.Length - 1
            If Char.IsUpper(password(i)) Then
                upperCount += 1
            ElseIf Char.IsLetter(password(i)) Then
                lowerCount += 1
            ElseIf Char.IsDigit(password(i)) Then
                digitCount += 1
            ElseIf Char.IsSymbol(password(i)) Then
                symbolCount += 1
            End If
        Next

        CN = New SqlClient.SqlConnection(gDATABASE)
        CN.Open()

        CM = New SqlClient.SqlCommand("select * from passPolicy where id =1", CN)
        DR = CM.ExecuteReader

        If DR.HasRows Then
            While DR.Read
                If upperCount < DR("upper") Then
                    PassWordPolicy = False
                ElseIf lowerCount < DR("lower") Then
                    PassWordPolicy = False
                ElseIf digitCount < DR("digit") Then
                    PassWordPolicy = False
                ElseIf symbolCount < DR("symbol") Then
                    PassWordPolicy = False
                ElseIf password.Length < DR("lenght") Then
                    PassWordPolicy = False
                End If
                tip = DR("tip")
            End While
        End If
        DR.Close()
    End Function

    Public Function getExternalIP(Optional ByVal webPath As String = "http://whatismyip.org/") As String
        Dim output As String = ""
        Dim webReq As New System.Net.WebClient
        Try
            output = System.Text.Encoding.ASCII.GetString((webReq.DownloadData(webPath)))
        Catch
            alerter.SHOW("x", "Greška", "Nije moguće resolvoirati vanjsku IP adresu.|Pokušajte ponovno!")
        End Try
        webReq.Dispose()
        Return output
    End Function

    Public Function getIP() As String
        Dim LocalHostName As String
        LocalHostName = Dns.GetHostName()
        Dim ipEnter As IPHostEntry = Dns.GetHostByName(LocalHostName)
        Dim IpAdd() As IPAddress = ipEnter.AddressList

        Return ipEnter.AddressList(0).ToString
    End Function

    Public Function getPozivni(ByVal ptt As String) As String
        Dim Pozivni As String

        Pozivni = "0" + ptt.Substring(0, 2)
        If Pozivni = "010" Then
            Pozivni = "01"
        End If

        Return Pozivni
    End Function

    Public Function validateEmail(ByVal email As String) As Boolean
        If System.Text.RegularExpressions.Regex.IsMatch(email, "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$") Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region


#Region "iNull-ovi"
    Function iNull(ByVal v As Object) As String
        If IsNothing(v) Then
            iNull = vbNullString
        Else
            If IsDBNull(v) Then
                iNull = vbNullString
            Else
                iNull = v.ToString.Trim
            End If
        End If
    End Function

    Function isNull(ByVal v As Object, ByVal replace As Object) As String
        If IsNothing(v) Or IsDBNull(v) Then
            isNull = replace
        Else

            isNull = v.ToString.Trim
        End If
    End Function


    Function iNull0(ByVal v As Object) As Decimal
        If IsDBNull(v) Or IsNothing(v) Then
            iNull0 = 0
        Else
            iNull0 = v
        End If
    End Function

    Function iNullDate(ByVal v As Object) As String
        If IsDBNull(v) Then
            iNullDate = Date.Today.ToString
        Else
            iNullDate = v.ToString
        End If
    End Function

    Function iNullTime(ByVal v As Object) As String
        If IsDBNull(v) Or IsNothing(v) Then
            iNullTime = "0:00:00"
        Else
            iNullTime = v.ToString
        End If
    End Function

    Function iNullvi(ByVal v As Object, ByVal d As Integer) As Integer
        If IsDBNull(v) Then
            iNullvi = d
        Else
            iNullvi = Val(v)
        End If
    End Function
#End Region


#Region "formatiranja"
    Function SQLDate(ByVal d As Date) As String
        Dim s As String
        s = d
        s = Format(d, "yyyy.MM.dd")
        s = s.Replace(".", "/")
        SQLDate = s
    End Function

    Function SQLTime(ByVal d As DateTime) As String
        Dim s As String
        s = d
        s = Format(d, "yyyy.MM.dd HH:mm:ss")
        s = s.Replace(".", "-")
        SQLTime = s
    End Function

    Function GetReal(ByVal s As String) As Double
        GetReal = 0
        If Len(s) = 0 Then Exit Function

        s = Replace(s, ".", vbNullString)
        s = Replace(s, ",", ".")

        GetReal = Val(Replace(s, "%", vbNullString))
    End Function

    Function GetRealCul(ByVal s As String, ByVal cul As String) As Double
        GetRealCul = 0
        If Len(s) = 0 Then Exit Function

        If cul = "English (United Kingdom)" Then
            s = Replace(s, ",", vbNullString)
        Else
            s = Replace(s, ".", vbNullString)
            s = Replace(s, ",", ".")
        End If
        GetRealCul = s
    End Function

    Function insc(ByVal p As Long, ByVal s As String, ByVal c As Integer) As Long
        For insc = p To Len(s)
            If Mid(s, insc, 1) = Chr(c) Then
                insc = insc + 1 - 1
                Exit Function
            End If
        Next
        insc = 0
    End Function


    Public Function GetFromDate(ByVal value As DateTime) As DateTime
        Return New DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second)
    End Function
#End Region



End Module

