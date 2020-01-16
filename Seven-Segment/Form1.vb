Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        t.Text += 1

        If t.Text = 1 Then
            a.BackColor = Color.Gray
            b.BackColor = Color.DarkRed
            c.BackColor = Color.DarkRed
            d.BackColor = Color.Gray
            e.BackColor = Color.Gray
            f.BackColor = Color.Gray
            g.BackColor = Color.Gray

        ElseIf t.Text = 2 Then
            a.BackColor = Color.DarkRed
            b.BackColor = Color.DarkRed
            c.BackColor = Color.Gray
            d.BackColor = Color.DarkRed
            e.BackColor = Color.DarkRed
            f.BackColor = Color.Gray
            g.BackColor = Color.DarkRed

        ElseIf t.Text = 3 Then
            a.BackColor = Color.DarkRed
            b.BackColor = Color.DarkRed
            c.BackColor = Color.DarkRed
            d.BackColor = Color.DarkRed
            e.BackColor = Color.Gray
            f.BackColor = Color.Gray
            g.BackColor = Color.DarkRed

        ElseIf t.Text = 4 Then
            a.BackColor = Color.Gray
            b.BackColor = Color.DarkRed
            c.BackColor = Color.DarkRed
            d.BackColor = Color.Gray
            e.BackColor = Color.Gray
            f.BackColor = Color.DarkRed
            g.BackColor = Color.DarkRed

        ElseIf t.Text = 5 Then
            a.BackColor = Color.DarkRed
            b.BackColor = Color.Gray
            c.BackColor = Color.DarkRed
            d.BackColor = Color.DarkRed
            e.BackColor = Color.Gray
            f.BackColor = Color.DarkRed
            g.BackColor = Color.DarkRed

        ElseIf t.Text = 6 Then
            a.BackColor = Color.DarkRed
            b.BackColor = Color.Gray
            c.BackColor = Color.DarkRed
            d.BackColor = Color.DarkRed
            e.BackColor = Color.DarkRed
            f.BackColor = Color.DarkRed
            g.BackColor = Color.DarkRed

        ElseIf t.Text = 7 Then
            a.BackColor = Color.DarkRed
            b.BackColor = Color.DarkRed
            c.BackColor = Color.DarkRed
            d.BackColor = Color.Gray
            e.BackColor = Color.Gray
            f.BackColor = Color.Gray
            g.BackColor = Color.Gray

        ElseIf t.Text = 8 Then
            a.BackColor = Color.DarkRed
            b.BackColor = Color.DarkRed
            c.BackColor = Color.DarkRed
            d.BackColor = Color.DarkRed
            e.BackColor = Color.DarkRed
            f.BackColor = Color.DarkRed
            g.BackColor = Color.DarkRed

        ElseIf t.Text = 9 Then
            a.BackColor = Color.DarkRed
            b.BackColor = Color.DarkRed
            c.BackColor = Color.DarkRed
            d.BackColor = Color.DarkRed
            e.BackColor = Color.Gray
            f.BackColor = Color.DarkRed
            g.BackColor = Color.DarkRed

        Else
            t.Text = 0
            a.BackColor = Color.DarkRed
            b.BackColor = Color.DarkRed
            c.BackColor = Color.DarkRed
            d.BackColor = Color.DarkRed
            e.BackColor = Color.DarkRed
            f.BackColor = Color.DarkRed
            g.BackColor = Color.Gray
        End If

    End Sub
End Class
