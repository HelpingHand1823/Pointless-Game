Public Class Form2
    Dim Test As Boolean

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Form1.Cookies >= 5000 Then
            Form1.MultiplierActive = True
            Form1.Cookies -= 5000
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Button1.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
		Button2.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
		Button3.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
	End Sub
End Class