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
        XmlManager.WriteXMLUsing(persons)
    End Sub

    Private Sub readBtn_Click(sender As Object, e As EventArgs) Handles readBtn.Click
        'XmlManager.LoadXML()
        setComboBox()
    End Sub

    Private Sub appendBtn_Click(sender As Object, e As EventArgs) Handles appendBtn.Click
        Dim personCount = XmlManager.LoadXML.Count
        Dim person = New Person
        With person
            .ID = personCount.ToString + "ASDF"
            .Name = "Nombre" + personCount.ToString
            .eMail = .Name + "@email.com"
        End With
        Dim persons = New List(Of Person)
        persons.Add(person)
        XmlManager.WriteXMLUsing(persons)

    End Sub

    Private Sub setComboBox()
        Dim persons = XmlManager.LoadXML
        ComboBox1.DataSource = New BindingSource(persons, Nothing)
        ComboBox1.DisplayMember = "Name"
        ComboBox1.ValueMember = "ID"
    End Sub
End Class
