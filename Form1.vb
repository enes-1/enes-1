Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f, sayi1, sayi2, j, i As Integer
        sayi1 = TextBox1.Text
        sayi2 = TextBox2.Text

        For i = sayi1 To sayi2
            For j = 2 To i - 1
                If i Mod j = 0 Then
                    f = 1
                End If
            Next
            If f = 1 Then
                f = 0
            Else
                ListBox1.Items.Add(i)
            End If
        Next

    End Sub
End Class
