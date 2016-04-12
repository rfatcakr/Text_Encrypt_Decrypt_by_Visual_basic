Public Class Form1

    Private Sub EncryptDecrypt()
        Dim I As Integer, Character As Char, Temp1 As String = ""
        For I = 0 To txtText.TextLength - 1
            Character = txtText.Text.Chars(I)
            Temp1 += Chr(Asc(Character) Xor 128)
        Next I
        txtText.Text = Temp1
    End Sub

    ' txtText is the textbox that the encrypted message is showed. You can change this of course
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        EncryptDecrypt()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Shell("özel.exe")
    End Sub
End Class