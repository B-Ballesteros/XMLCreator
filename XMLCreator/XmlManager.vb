Imports System.IO
Imports System.Reflection
Imports System.Xml

Public Class XmlManager

    ''' <summary>
    ''' This Property is used to get the path where the xml will be stored
    ''' </summary>
    ''' <returns>Path where xml file will be stored</returns>
    Private Shared ReadOnly Property FilePath
        Get
            Dim dirPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly.Location)
            Return Path.Combine(dirPath, "people.xml")
        End Get
    End Property

    ''' <summary>
    ''' Creates or overwrittes the xml file
    ''' </summary>
    ''' <param name="persons">Lsit of persons that will be stored in the xml file</param>
    Public Shared Sub WriteXMLUsing(ByVal persons As List(Of Person))
        If File.Exists(FilePath) Then
        Else
            CreateXmlFrom(FilePath, persons)
        End If
    End Sub


    ''' <summary>
    ''' This function is in charge to create the xml file if such file doesn't existts
    ''' </summary>
    ''' <param name="path">Full path where the file will be saved</param>
    ''' <param name="withPersons">List of persons that will be written to the file</param>
    Private Shared Sub CreateXmlFrom(ByVal path As String, ByVal withPersons As List(Of Person))
        ''Setting to save the xml document with identation (make it pretty and easy to read)
        Dim settings = New XmlWriterSettings
        settings.Indent = True

        Using writter = XmlWriter.Create(path, settings)
            writter.WriteStartDocument() 'Document Start
            writter.WriteStartElement("Persons") 'Document root element

            'Loop over all the persons
            For Each person As Person In withPersons
                writter.WriteStartElement("Person")
                writter.WriteElementString("ID", person.ID)
                writter.WriteElementString("Name", person.Name)
                writter.WriteElementString("eMail", person.eMail)
                writter.WriteEndElement()
            Next

            'End Document
            writter.WriteEndElement()
            writter.WriteEndDocument()
        End Using
    End Sub

    ''' <summary>
    ''' This function reads the xml stored withn this project as a list of persons
    ''' </summary>
    ''' <returns>List of persons stored in the xml document</returns>
    Public Shared Function LoadXML() As List(Of Person)
        Try
            Dim persons = New List(Of Person)
            'Open the xml document
            Dim xmlDocument = New XmlDocument
            xmlDocument.Load(FilePath)
            Dim elements As XmlNodeList = xmlDocument.GetElementsByTagName("Person")
            For Each element As XmlElement In elements
                Try 'try to parse the document and ingonre failures
                    Dim person = New Person
                    With person
                        .ID = element.SelectSingleNode("ID").InnerText
                        .Name = element.SelectSingleNode("Name").InnerText
                        .eMail = element.SelectSingleNode("eMail").InnerText
                    End With
                    persons.Add(person)
                Catch ex As Exception
                End Try
            Next
            Return persons
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
