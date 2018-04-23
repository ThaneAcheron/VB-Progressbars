Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = "true"
        Button2.BringToFront()




    End Sub
    Private Sub Splitter1_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.BringToFront()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Static count
        
        count = (Label1.Text + 1)
        Label1.Text = count

        Dim textbox As String

        textbox = TextBox1.Text()


        If textbox = "1" Then




            If count = 1 Then
                PictureBox3.BringToFront()
                ProgressBar1.Value = ProgressBar1.Value + 10
            End If
            If count = 2 Then
                PictureBox4.BringToFront()

            End If

            If count = 3 Then
                PictureBox5.BringToFront()
            End If

            If count = 4 Then
                PictureBox5.BringToFront()

            End If

            If count = 5 Then
                PictureBox6.BringToFront()

            End If

            If count = 6 Then
                PictureBox7.BringToFront()

            End If
            If count = 7 Then
                PictureBox8.BringToFront()

            End If
            If count = 8 Then
                PictureBox9.BringToFront()

            End If
            If count = 9 Then
                PictureBox10.BringToFront()

            End If

            If count = 10 Then
                PictureBox11.BringToFront()

            End If
            If count = 11 Then
                PictureBox12.BringToFront()

            End If






        Else


            If count = 1 Then
                PictureBox13.BringToFront()

            End If
            If count = 2 Then
                PictureBox14.BringToFront()

            End If

            If count = 3 Then
                PictureBox15.BringToFront()
            End If

            If count = 4 Then
                PictureBox15.BringToFront()

            End If

            If count = 5 Then
                PictureBox16.BringToFront()

            End If

            If count = 6 Then
                PictureBox17.BringToFront()

            End If
            If count = 7 Then
                PictureBox18.BringToFront()

            End If
            If count = 8 Then
                PictureBox19.BringToFront()

            End If
            If count = 9 Then
                PictureBox20.BringToFront()

            End If

            If count = 10 Then
                PictureBox21.BringToFront()

            End If
            If count = 11 Then
                PictureBox22.BringToFront()

            End If

            If count = 12 Then
                PictureBox23.BringToFront()

            End If

            If count = 13 Then
                PictureBox24.BringToFront()

            End If

            If count = 14 Then
                PictureBox25.BringToFront()

            End If

            If count = 15 Then
                PictureBox26.BringToFront()

            End If

            If count = 16 Then
                PictureBox27.BringToFront()

            End If





        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Enabled = "false"
        Button1.BringToFront()
        TextBox1.Text = ""
        Label1.Text = 0

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

    End Sub
End Class
