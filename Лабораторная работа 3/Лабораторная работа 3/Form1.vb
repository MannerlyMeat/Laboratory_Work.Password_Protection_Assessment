Imports System.Text


Public Class Form1
    Public upper_Case_latin As String = "QWERTYUIOPASDFGHJKLZXCVBNM"
    Public lower_Case_latin As String = "qwertyuiopasdfghjklzxcvbnm"
    Public upper_Case_kir As String = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ"
    Public lower_Case_kir As String = "йцукенгшщзхъфывапролджэячсмитьбю"
    Public simbols As String = "+-*/=><[]()@{}.,:;'#$^ "
    Public nums As String = "1234567890"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = CDec(10 ^ -6)
        Label9.Text = Math.Abs(CInt(TextBox2.Text) * CInt(TextBox3.Text)) / CDec(TextBox1.Text)
        Label10.Text = 0
        Label11.Text = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pass_Cont As String = ""
        For i = 1 To 10
            If CInt(Label9.Text) <= CInt(Label10.Text) ^ i Then
                Label11.Text = i
                If CheckBox1.Checked = True Then
                    pass_Cont += upper_Case_latin
                End If
                If CheckBox2.Checked = True Then
                    pass_Cont += lower_Case_latin
                End If
                If CheckBox3.Checked = True Then
                    pass_Cont += upper_Case_kir
                End If
                If CheckBox4.Checked = True Then
                    pass_Cont += lower_Case_kir
                End If
                If CheckBox5.Checked = True Then
                    pass_Cont += simbols
                End If
                If CheckBox6.Checked = True Then
                    pass_Cont += nums
                End If
                Dim rand As New Random
                Dim sBuilder As New StringBuilder
                For crPass = 1 To i
                    Dim ind As Integer = rand.Next(0, pass_Cont.Length)
                    sBuilder.Append(pass_Cont.Substring(ind, 1))
                Next
                Label5.Text = sBuilder.ToString
            End If
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label10.Text += upper_Case_latin.Length
        Else
            Label10.Text -= upper_Case_latin.Length
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Label10.Text += lower_Case_latin.Length
        Else
            Label10.Text -= lower_Case_latin.Length
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Label10.Text += upper_Case_kir.Length
        Else
            Label10.Text -= upper_Case_kir.Length
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Label10.Text += lower_Case_kir.Length
        Else
            Label10.Text -= lower_Case_kir.Length
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            Label10.Text += simbols.Length
        Else
            Label10.Text -= simbols.Length
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            Label10.Text += nums.Length
        Else
            Label10.Text -= nums.Length
        End If
    End Sub
End Class
