Imports System.IO
Imports System.Reflection
Imports System.Xml

Public Class XmlManager

    ''' <summary>
    ''' This Property is used to get the main path of the exe file
    ''' </summary>
    ''' <returns>Path from where the app is being executed</returns>
    Private Shared ReadOnly Property AssemblyPath
        Get
            Return Path.GetDirectoryName(Assembly.GetExecutingAssembly.Location)
        End Get
    End Property

    ''' <summary>
    ''' Creates or overwrittes the xml file
    ''' </summary>
    ''' <param name="persons">Lsit of persons that will be stored in the xml file</param>
    Public Shared Sub writeXMLUsing(ByVal persons As List(Of Person))
        Dim filePath = Path.Combine(AssemblyPath, "people.xml")
        If File.Exists(filePath) Then
        Else
            createXmlFrom(filePath, persons)
        End If
    End Sub


    ''' <summary>
    ''' This function is in charge to create the xml file if such file doesn't existts
    ''' </summary>
    ''' <param name="path">Full path where the file will be saved</param>
    ''' <param name="withPersons">List of persons that will be written to the file</param>
    Private Shared Sub createXmlFrom(ByVal path As String, ByVal withPersons As List(Of Person))
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
End Class
