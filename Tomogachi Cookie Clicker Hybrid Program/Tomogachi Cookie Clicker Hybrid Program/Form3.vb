Public Class Form3
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        If Form1.Cookies >= 3000 Then
            Form1.Cookies -= 3000
            PictureBox1.Image = Image.FromFile("C:\Users\jerem\Downloads\Christmas Pattern.png")
            Form1.PictureBox1.Image = Image.FromFile("C:\Users\jerem\Downloads\Christmas Pattern.png")
			Form2.PictureBox1.Image = Image.FromFile("C:\Users\jerem\Downloads\Christmas Pattern.png")
			Form1.Label1.Text = Form1.Cookies
		End If
    End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
		If Form1.Cookies >= 3000 Then
			Form1.Cookies -= 3000
			PictureBox1.Image = Image.FromFile("C:\Users\jerem\OneDrive\Desktop\Video Game Controller.jpg")
			Form1.PictureBox1.Image = Image.FromFile("C:\Users\jerem\OneDrive\Desktop\Video Game Controller.jpg")
			Form2.PictureBox1.Image = Image.FromFile("C:\Users\jerem\OneDrive\Desktop\Video Game Controller.jpg")
			Form1.Label1.Text = Form1.Cookies
		End If
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


		If Form1.Cookies >= 3000 Then
			Form1.Cookies -= 3000
			PictureBox1.Image = Image.FromFile("C:\Users\jerem\OneDrive\Desktop\Cookies.jpg")
			Form1.PictureBox1.Image = Image.FromFile("C:\Users\jerem\OneDrive\Desktop\Cookies.jpg")
			Form2.PictureBox1.Image = Image.FromFile("C:\Users\jerem\OneDrive\Desktop\Cookies.jpg")
			Form1.Label1.Text = Form1.Cookies
		End If
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

		If Form1.Cookies >= 3000 Then
			Form1.Cookies -= 3000
			PictureBox1.Image = Image.FromFile("C:\Users\jerem\OneDrive\Desktop\Rainbow Theme.jpg")
			Form1.PictureBox1.Image = Image.FromFile("C:\Users\jerem\OneDrive\Desktop\Rainbow Theme.jpg")
			Form2.PictureBox1.Image = Image.FromFile("C:\Users\jerem\OneDrive\Desktop\Rainbow Theme.jpg")
			Form1.Label1.Text = Form1.Cookies

		End If

	End Sub
End Class