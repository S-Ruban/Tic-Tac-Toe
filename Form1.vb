Public Class Form1
    Dim a, b, c, d, x, f, g, h, i As String
    Dim p1, p2 As String
    Dim count As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        count = 0
        p1 = InputBox("Enter the name of Player 1", "Player 1", "player1")
        p2 = InputBox("Enter the name of Player 2", "Player 2", "player2")
        Label3.Text = p1
        Label6.Text = p2
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        count += 1
        Button1.Visible = False
        If count Mod 2 = 1 Then
            PictureBox1.Load("X.png")
            a = "X"
        Else
            PictureBox1.Load("O.png")
            a = "O"
        End If
        If a = "X" And b = "X" And c = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And d = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And x = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And f = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "X" And x = "X" And f = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "X" And h = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And b = "O" And c = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And d = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And x = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And f = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "O" And x = "O" And f = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "O" And h = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        count += 1
        Button2.Visible = False
        If count Mod 2 = 1 Then
            PictureBox2.Load("X.png")
            b = "X"
        Else
            PictureBox2.Load("O.png")
            b = "O"
        End If
        If a = "X" And b = "X" And c = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And d = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And x = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And f = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "X" And x = "X" And f = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "X" And h = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And b = "O" And c = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And d = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And x = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And f = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "O" And x = "O" And f = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "O" And h = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        count += 1
        Button3.Visible = False
        If count Mod 2 = 1 Then
            PictureBox3.Load("X.png")
            c = "X"
        Else
            PictureBox3.Load("O.png")
            c = "O"
        End If
        If a = "X" And b = "X" And c = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And d = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And x = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And f = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "X" And x = "X" And f = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "X" And h = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And b = "O" And c = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And d = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And x = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And f = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "O" And x = "O" And f = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "O" And h = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        count += 1
        Button4.Visible = False
        If count Mod 2 = 1 Then
            PictureBox4.Load("X.png")
            d = "X"
        Else
            PictureBox4.Load("O.png")
            d = "O"
        End If
        If a = "X" And b = "X" And c = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And d = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And x = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And f = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "X" And x = "X" And f = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "X" And h = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And b = "O" And c = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And d = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And x = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And f = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "O" And x = "O" And f = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "O" And h = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        count += 1
        Button5.Visible = False
        If count Mod 2 = 1 Then
            PictureBox5.Load("X.png")
            x = "X"
        Else
            PictureBox5.Load("O.png")
            x = "O"
        End If
        If a = "X" And b = "X" And c = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And d = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And x = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And f = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "X" And x = "X" And f = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "X" And h = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And b = "O" And c = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And d = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And x = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And f = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "O" And x = "O" And f = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "O" And h = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        count += 1
        Button6.Visible = False
        If count Mod 2 = 1 Then
            PictureBox6.Load("X.png")
            f = "X"
        Else
            PictureBox6.Load("O.png")
            f = "O"
        End If
        If a = "X" And b = "X" And c = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And d = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And x = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And f = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "X" And x = "X" And f = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "X" And h = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And b = "O" And c = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And d = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And x = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And f = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "O" And x = "O" And f = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "O" And h = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        count += 1
        Button7.Visible = False
        If count Mod 2 = 1 Then
            PictureBox7.Load("X.png")
            g = "X"
        Else
            PictureBox7.Load("O.png")
            g = "O"
        End If
        If a = "X" And b = "X" And c = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And d = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And x = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And f = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "X" And x = "X" And f = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "X" And h = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And b = "O" And c = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And d = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And x = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And f = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "O" And x = "O" And f = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "O" And h = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        count += 1
        Button8.Visible = False
        If count Mod 2 = 1 Then
            PictureBox8.Load("X.png")
            h = "X"
        Else
            PictureBox8.Load("O.png")
            h = "O"
        End If
        If a = "X" And b = "X" And c = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And d = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And x = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And f = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "X" And x = "X" And f = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "X" And h = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And b = "O" And c = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And d = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And x = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And f = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "O" And x = "O" And f = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "O" And h = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        count += 1
        Button9.Visible = False
        If count Mod 2 = 1 Then
            PictureBox9.Load("X.png")
            i = "X"
        Else
            PictureBox9.Load("O.png")
            i = "O"
        End If
        If a = "X" And b = "X" And c = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And d = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "X" And x = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And x = "X" And g = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "X" And f = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "X" And x = "X" And f = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "X" And h = "X" And i = "X" Then
            MsgBox(p1 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And b = "O" And c = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = b) And (Not a = c) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And d = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = d) And (Not a = g) Then
            MsgBox("Its a Draw!")
        End If
        If a = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not a = x) And (Not a = i) Then
            MsgBox("Its a Draw!")
        End If
        If b = "O" And x = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not b = x) And (Not b = i) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And x = "O" And g = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = x) And (Not c = g) Then
            MsgBox("Its a Draw!")
        End If
        If c = "O" And f = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not c = f) And (Not c = i) Then
            MsgBox("Its a Draw!")
        End If
        If d = "O" And x = "O" And f = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not d = x) And (Not d = i) Then
            MsgBox("Its a Draw!")
        End If
        If g = "O" And h = "O" And i = "O" Then
            MsgBox(p2 & " Won!")
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        ElseIf count = 9 And (Not g = h) And (Not g = i) Then
            MsgBox("Its a Draw!")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        count = 0
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = True
        Button6.Visible = True
        Button7.Visible = True
        Button8.Visible = True
        Button9.Visible = True
        a = ""
        b = ""
        c = ""
        d = ""
        x = ""
        f = ""
        g = ""
        h = ""
        i = ""
    End Sub
End Class
