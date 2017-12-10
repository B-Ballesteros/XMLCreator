Public Class Form1
    Private Sub generateBtn_Click(sender As Object, e As EventArgs) Handles generateBtn.Click
        Dim persons = New List(Of Person)
        For index As Integer = 0 To 10
            Dim person = New Person
            With person
                .ID = index.ToString + "ASDF"
                .Name = "Nombre" + index.ToString
                .eMail = .Name + "@email.com"
            End With

            persons.Add(person)
        Next
        XmlManager.writeXMLUsing(persons)
    End Sub
End Class
