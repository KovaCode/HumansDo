Imports System
Imports System.Xml
Imports System.Configuration
Imports System.Reflection


Public Module modConfig

    Public Function ReadSetting(ByVal key As String) As String
        Return ConfigurationSettings.AppSettings(key)
    End Function



    Public Function saveconfig(ByVal MyKey As String, ByVal MyValue As String) As String

        Dim XmlDocument As New XmlDocument
        Dim XmlNode As XmlNode
        Dim XmlRoot As XmlNode
        Dim XmlKey As XmlNode
        Dim XmlValue As XmlNode

        saveconfig = ""
        XmlDocument.Load(getConfigFilePath)
        XmlNode = XmlDocument.DocumentElement.SelectSingleNode("/configuration/appSettings/add[@key=""" & MyKey & """]")

        If XmlNode Is Nothing Then

            ' The node does not exist, let's create it

            XmlNode = XmlDocument.CreateNode(XmlNodeType.Element, "add", "")

            ' Adding the Key attribute to the node, keep in mind, Xml tokens are case sensitive
            ' We should use 'key' instead of 'Key'

            XmlKey = XmlDocument.CreateNode(XmlNodeType.Attribute, "key", "")
            XmlKey.Value = MyKey
            XmlNode.Attributes.SetNamedItem(XmlKey)

            ' Adding the key value, once again, remember that Xml tokens are case sensitive

            XmlValue = XmlDocument.CreateNode(XmlNodeType.Attribute, "value", "")
            XmlValue.Value = MyValue
            XmlNode.Attributes.SetNamedItem(XmlValue)

            ' Add the new node to the root

            XmlRoot = XmlDocument.DocumentElement.SelectSingleNode("/configuration/appSettings")
            If Not XmlRoot Is Nothing Then
                XmlRoot.AppendChild(XmlNode)
            Else
                saveconfig = "ERROR"
            End If
        Else
            '
            ' The node exist, save the new value
            '
            XmlNode.Attributes.GetNamedItem("value").Value = MyValue

        End If
        XmlDocument.Save(Application.ExecutablePath & ".config")

        XmlDocument = Nothing


    End Function

    Public Sub WriteSetting(ByVal key As String, ByVal value As String)
        ' load config document for current assembly
        Dim doc As XmlDocument = loadConfigDocument()

        ' retrieve appSettings node
        Dim node As XmlNode = doc.SelectSingleNode("//appSettings")

        If node Is Nothing Then
            Throw New InvalidOperationException("appSettings section not found in config file.")
        End If

        Try
            ' select the 'add' element that contains the key
            Dim elem As XmlElement = DirectCast(node.SelectSingleNode(String.Format("//add[@key='{0}']", key)), XmlElement)

            If elem Is Nothing Then
                ' add value for key
                elem.SetAttribute("value", value)
            Else
                ' key was not found so create the 'add' element
                ' and set it's key/value attributes
                elem = doc.CreateElement("add")
                elem.SetAttribute("key", key)
                elem.SetAttribute("value", value)
                node.AppendChild(elem)
            End If
            doc.Save(getConfigFilePath())
        Catch
            Throw
        End Try
    End Sub

    Public Sub RemoveSetting(ByVal key As String)
        ' load config document for current assembly
        Dim doc As XmlDocument = loadConfigDocument()

        ' retrieve appSettings node
        Dim node As XmlNode = doc.SelectSingleNode("//appSettings")

        Try
            If node Is Nothing Then
                Throw New InvalidOperationException("appSettings section not found in config file.")
            Else
                ' remove 'add' element with coresponding key
                node.RemoveChild(node.SelectSingleNode(String.Format("//add[@key='{0}']", key)))
                doc.Save(getConfigFilePath())
            End If
        Catch e As NullReferenceException
            Throw New Exception(String.Format("The key {0} does not exist.", key), e)
        End Try
    End Sub

    Private Function loadConfigDocument() As XmlDocument
        Dim doc As XmlDocument = Nothing
        Try
            doc = New XmlDocument
            doc.Load(getConfigFilePath())
            Return doc
        Catch e As System.IO.FileNotFoundException
            Throw New Exception("No configuration file found.", e)
        End Try
    End Function


    Private Function getConfigFilePath() As String
        Return System.Reflection.Assembly.GetExecutingAssembly().Location + ".config"
    End Function


End Module
