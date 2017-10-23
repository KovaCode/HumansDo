#Region "Imports"
Imports System.Security.Cryptography
Imports System.IO
Imports System.Management
Imports DevExpress.XtraBars.Alerter
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
#End Region

Module modApp

#Region "Dim's & Enum's"

    Dim hashMD5 As Object
    Dim eProvider As Object
    Dim strEncrKey As String = "pasSw03d"


    Public Sub CopyFiles(ByVal sourcePath As String, ByVal DestinationPath As String)
        If (Directory.Exists(sourcePath)) Then
            For Each fName As String In Directory.GetFiles(sourcePath)
                If File.Exists(fName) Then
                    Dim dFile As String = String.Empty
                    dFile = Path.GetFileName(fName)
                    Dim dFilePath As String = String.Empty
                    dFilePath = DestinationPath + dFile
                    File.Copy(fName, dFilePath, True)
                End If
            Next
        End If
    End Sub

    Public Sub MoveFiles(ByVal sourcePath As String, ByVal DestinationPath As String)
        If (Directory.Exists(sourcePath)) Then
            For Each fName As String In Directory.GetFiles(sourcePath)
                If File.Exists(fName) Then
                    Dim dFile As String = String.Empty
                    dFile = Path.GetFileName(fName)
                    Dim dFilePath As String = String.Empty
                    dFilePath = DestinationPath + dFile
                    File.Move(fName, dFilePath)
                End If
            Next
        End If
    End Sub




#End Region

#Region "Class cmbVal"

    ''***********************************************OPIS***********************************************
    ''popunjavanje combo-a s vrijednosti i itemData-om, kako bi se mogla dodati još koja vrijednost uz samu
    ''vrijednost teksta! (npr. "Ime i prezime" + item data ="1")
    ''***********************************************PRIMJER UPOTERBE***********************************************
    'While DR.Read()
    '   cmb.Items.Add(New ValueDescriptionPair(DR("kratica"), DR("naziv").ToString))
    'End While

    Public Class cmbVal
        Public Value As Object
        Public Description As String

        Public ReadOnly Property getValue() As Object
            Get
                Return Value
            End Get
        End Property

        Public ReadOnly Property getDescription() As String
            Get
                Return Description
            End Get
        End Property

        Public Sub New(ByVal NewValue As Object, ByVal NewDescription As String)
            Value = NewValue
            Description = NewDescription
        End Sub

        Public Overrides Function ToString() As String
            Return Description
        End Function




    End Class
#End Region


#Region "Class cmbVal2"
    Public Class cmbVal2
        Public id As Object
        Public val As Object

        Public Sub New(ByVal id As String, ByVal val As String)
            Me.id = id
            Me.val = val
        End Sub 'New

        Public ReadOnly Property _id() As String
            Get
                Return id
            End Get
        End Property

        Public ReadOnly Property _val() As String
            Get
                Return val
            End Get
        End Property

    End Class
#End Region


#Region "procedure i funkcije"

    Public Function chklog(s As String) As Long
        Dim p As Long
        Dim i As Integer
        Dim seed As Long

        chklog = 0
        seed = Val(Mid(s, 2))
        seed = seed / 1000000

        p = InStr(1, s, "] ", vbTextCompare)
        If p < 1 Then Exit Function
        s = Right$(s, Len(s) - p - 1)

        For i = 1 To Len(s)
            chklog = chklog + Asc(Mid(s, i, 1)) + seed
        Next i
        chklog = chklog + seed
        chklog = 1000000 * seed + chklog
    End Function


    Public Function chksm(s As String) As Long
        Dim i As Integer
        Dim seed As Long
        seed = Rnd() * 9
        seed = Int(seed + 1)
        chksm = 0
        For i = 1 To Len(s)
            chksm = chksm + Asc(Mid(s, i, 1)) + seed
        Next i
        chksm = chksm + seed
        chksm = 1000000 * seed + chksm
    End Function

    Public Function getGridVal(g As DevExpress.XtraGrid.Views.Grid.GridView, col As DevExpress.XtraGrid.Columns.GridColumn) As Object
        getGridVal = g.GetRowCellValue(g.FocusedRowHandle(), col)
    End Function

    Public Function getGridVal(g As DevExpress.XtraGrid.Views.Grid.GridView, colName As String) As Object
        getGridVal = g.GetRowCellValue(g.FocusedRowHandle(), colName)
    End Function

    Public Function getGridVal(g As DevExpress.XtraGrid.Views.Grid.GridView, index As Integer, col As DevExpress.XtraGrid.Columns.GridColumn) As Object
        getGridVal = g.GetRowCellValue(index, col)
    End Function


    Public Function checkSpecial(tipka As Control) As Boolean
        checkSpecial = True
        Dim flgNew As Boolean = False
        Dim flgSave As Boolean = False
        Dim flgDelete As Boolean = False
        Dim flgPrint As Boolean = False

        If tipka.Name = "cmdNew" Or tipka.Name = "cmdSave" Or tipka.Name = "cmdDelete" Or tipka.Name = "cmdPrint" Then

            Select Case gSpecialPrava
                Case 1
                    flgNew = True  '1

                Case 2
                    flgSave = True '2

                Case 3
                    flgNew = True  '1
                    flgSave = True  '2

                Case 4
                    flgDelete = True   '4

                Case 5
                    flgNew = True  '1
                    flgDelete = True   '4

                Case 6
                    flgSave = True '2
                    flgDelete = True   '4

                Case 7
                    flgNew = True  '1
                    flgSave = True '2
                    flgDelete = True   '4

                Case 8
                    flgPrint = True    '8

                Case 9
                    flgNew = True  '1
                    flgPrint = True    '8

                Case 10
                    flgSave = True '2
                    flgPrint = True    '8

                Case 11
                    flgNew = True  '1
                    flgSave = True  '2
                    flgPrint = True    '8

                Case 12
                    flgDelete = True   '4
                    flgPrint = True    '8

                Case 13
                    flgNew = True  '1
                    flgDelete = True   '4
                    flgPrint = True    '8

                Case 14
                    flgSave = True '2
                    flgDelete = True   '4
                    flgPrint = True    '8

                Case 15
                    flgNew = True  '1
                    flgSave = True '2
                    flgDelete = True   '4
                    flgPrint = True    '8

            End Select


            Select Case tipka.Name
                Case "cmdNew"
                    If flgNew = True Then
                        checkSpecial = True
                    Else
                        checkSpecial = False
                    End If

                Case "cmdSave"
                    If flgSave = True Then
                        checkSpecial = True
                    Else
                        checkSpecial = False
                    End If

                Case "cmdDelete"
                    If flgDelete = True Then
                        checkSpecial = True
                    Else
                        checkSpecial = False
                    End If

                Case "cmdPrint"
                    If flgPrint = True Then
                        checkSpecial = True
                    Else
                        checkSpecial = False
                    End If

            End Select
        End If

    End Function

    Public Function GetTime(ByVal Time As Integer) As String
        Dim Hrs As Integer  'number of hours   '
        Dim Min As Integer  'number of Minutes '
        Dim Sec As Integer  'number of Sec     '
        'Seconds'
        Sec = Time Mod 60
        'Minutes'
        Min = ((Time - Sec) / 60) Mod 60
        'Hours'
        Hrs = ((Time - (Sec + (Min * 60))) / 3600) Mod 60

        Return Format(Hrs, "00") & ":" & Format(Min, "00") & ":" & Format(Sec, "00")
    End Function

#End Region


#Region "CustomEvent class"
    Public Class CustomEvent
        Implements IEditableObject
        Private fStartTime As DateTime
        Private fEndTime As DateTime
        Private fSubject As String
        Private fStatus As Integer
        Private fDescription As String
        Private fLabel As Long
        Private fLocation As String
        Private fAllday As Boolean
        Private fEventType As Integer
        Private fRecurrenceInfo As String
        Private fReminderInfo As String
        Private fOwnerId As Object

        Private events As CustomEventList
        Private committed As Boolean = False

        Public Sub New(ByVal events As CustomEventList)
            Me.events = events
        End Sub

        Private Sub OnListChanged()
            Dim index As Integer = events.IndexOf(Me)
            events.OnListChanged(New ListChangedEventArgs(ListChangedType.ItemChanged, index))
        End Sub

        Public Property StartTime() As DateTime
            Get
                Return fStartTime
            End Get
            Set(ByVal value As DateTime)
                fStartTime = value
            End Set
        End Property
        Public Property EndTime() As DateTime
            Get
                Return fEndTime
            End Get
            Set(ByVal value As DateTime)
                fEndTime = value
            End Set
        End Property
        Public Property Subject() As String
            Get
                Return fSubject
            End Get
            Set(value As String)
                fSubject = value
            End Set
        End Property
        Public Property Status() As Integer
            Get
                Return fStatus
            End Get
            Set(value As Integer)
                fStatus = value
            End Set
        End Property
        Public Property Description() As String
            Get
                Return fDescription
            End Get
            Set(value As String)
                fDescription = value
            End Set
        End Property
        Public Property Label() As Long
            Get
                Return fLabel
            End Get
            Set(value As Long)
                fLabel = value
            End Set
        End Property
        Public Property Location() As String
            Get
                Return fLocation
            End Get
            Set(value As String)
                fLocation = value
            End Set
        End Property
        Public Property AllDay() As Boolean
            Get
                Return fAllday
            End Get
            Set(value As Boolean)
                fAllday = value
            End Set
        End Property
        Public Property EventType() As Integer
            Get
                Return fEventType
            End Get
            Set(value As Integer)
                fEventType = value
            End Set
        End Property
        Public Property RecurrenceInfo() As String
            Get
                Return fRecurrenceInfo
            End Get
            Set(value As String)
                fRecurrenceInfo = value
            End Set
        End Property
        Public Property ReminderInfo() As String
            Get
                Return fReminderInfo
            End Get
            Set(value As String)
                fReminderInfo = value
            End Set
        End Property
        Public Property OwnerId() As Object
            Get
                Return fOwnerId
            End Get
            Set(value As Object)
                fOwnerId = value
            End Set
        End Property

        Public Sub BeginEdit() Implements IEditableObject.BeginEdit
        End Sub
        Public Sub CancelEdit() Implements IEditableObject.CancelEdit
            If (Not committed) Then
                CType(events, IList).Remove(Me)
            End If
        End Sub
        Public Sub EndEdit() Implements IEditableObject.EndEdit
            committed = True
        End Sub
    End Class

#End Region


#Region "CustomEventList class"
    Public Class CustomEventList
        Inherits CollectionBase
        Implements IBindingList
        Default Public ReadOnly Property Item(ByVal idx As Integer) As CustomEvent
            Get
                Return CType(MyBase.List(idx), CustomEvent)
            End Get
        End Property

        Public Shadows Sub Clear()
            MyBase.Clear()
            OnListChanged(New ListChangedEventArgs(ListChangedType.Reset, -1))
        End Sub
        Public Sub Add(ByVal appointment As CustomEvent)
            MyBase.List.Add(appointment)
        End Sub
        Public Function IndexOf(ByVal appointment As CustomEvent) As Integer
            Return List.IndexOf(appointment)
        End Function
        Public Function AddNew() As Object Implements IBindingList.AddNew
            Dim app As CustomEvent = New CustomEvent(Me)
            List.Add(app)
            Return app
        End Function
        Public ReadOnly Property AllowEdit() As Boolean Implements IBindingList.AllowEdit
            Get
                Return True
            End Get
        End Property
        Public ReadOnly Property AllowNew() As Boolean Implements IBindingList.AllowNew
            Get
                Return True
            End Get
        End Property
        Public ReadOnly Property AllowRemove() As Boolean Implements IBindingList.AllowRemove
            Get
                Return True
            End Get
        End Property

        Private Event listChangedHandler As ListChangedEventHandler
        Public Custom Event ListChanged As ListChangedEventHandler Implements IBindingList.ListChanged
            AddHandler(ByVal value As ListChangedEventHandler)
                AddHandler listChangedHandler, value
            End AddHandler
            RemoveHandler(ByVal value As ListChangedEventHandler)
                RemoveHandler listChangedHandler, value
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs)
            End RaiseEvent
        End Event
        Friend Sub OnListChanged(ByVal args As ListChangedEventArgs)
            If Not listChangedHandlerEvent Is Nothing Then
                RaiseEvent listChangedHandler(Me, args)
            End If
        End Sub
        Protected Overrides Sub OnRemoveComplete(ByVal index As Integer, ByVal value As Object)
            OnListChanged(New ListChangedEventArgs(ListChangedType.ItemDeleted, index))
        End Sub
        Protected Overrides Sub OnInsertComplete(ByVal index As Integer, ByVal value As Object)
            OnListChanged(New ListChangedEventArgs(ListChangedType.ItemAdded, index))
        End Sub

        Public Sub AddIndex(ByVal pd As PropertyDescriptor) Implements IBindingList.AddIndex
            Throw New NotSupportedException()
        End Sub
        Public Sub ApplySort(ByVal pd As PropertyDescriptor, ByVal dir As ListSortDirection) Implements IBindingList.ApplySort
            Throw New NotSupportedException()
        End Sub
        Public Function Find(ByVal [property] As PropertyDescriptor, ByVal key As Object) As Integer Implements IBindingList.Find
            Throw New NotSupportedException()
        End Function
        Public ReadOnly Property IsSorted() As Boolean Implements IBindingList.IsSorted
            Get
                Return False
            End Get
        End Property
        Public Sub RemoveIndex(ByVal pd As PropertyDescriptor) Implements IBindingList.RemoveIndex
            Throw New NotSupportedException()
        End Sub
        Public Sub RemoveSort() Implements IBindingList.RemoveSort
            Throw New NotSupportedException()
        End Sub
        Public ReadOnly Property SortDirection() As ListSortDirection Implements IBindingList.SortDirection
            Get
                Throw New NotSupportedException()
            End Get
        End Property
        Public ReadOnly Property SortProperty() As PropertyDescriptor Implements IBindingList.SortProperty
            Get
                Throw New NotSupportedException()
            End Get
        End Property
        Public ReadOnly Property SupportsChangeNotification() As Boolean Implements IBindingList.SupportsChangeNotification
            Get
                Return True
            End Get
        End Property
        Public ReadOnly Property SupportsSearching() As Boolean Implements IBindingList.SupportsSearching
            Get
                Return False
            End Get
        End Property
        Public ReadOnly Property SupportsSorting() As Boolean Implements IBindingList.SupportsSorting
            Get
                Return False
            End Get
        End Property
    End Class

#End Region

End Module
