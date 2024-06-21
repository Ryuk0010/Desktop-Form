Public Class Create_New_Submission
    Dim ss, tt, vv As Integer
    Dim check As Integer
    Dim Id As Integer = 0 ' Initialize Id to 0

    Private Sub Create_New_Submission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Any initialization code goes here
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ToggleTimer()
    End Sub

    Private Sub ToggleTimer()
        If check = 0 Then
            Timer1.Enabled = True
            check = 1
        ElseIf check = 1 Then
            Timer1.Enabled = False
            check = 0
        End If
    End Sub
    Dim timer As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timer = Format(ss, "0") & ":" & Format(tt, "0") & ":" & Format(vv, "0")
        Label6.Text = Format(ss, "0  :") & Format(tt, "  0  :") & Format(vv, "  0")
        vv += 1
        If vv > 59 Then
            vv = 0
            tt += 1
        End If
        If tt = 2 Then
            vv = 0
            tt = 0
            Label6.Text = "0 : 0 : 0"
            Timer1.Enabled = False
            MessageBox.Show("Time Enabled")
            check = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SubmitForm()
    End Sub

    Private Sub SubmitForm()
        Timer1.Enabled = False
        Id = Id + 1 ' Increment Id
        Submission_Data.DataGridView1.Rows.Add(Id, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, timer)

        MessageBox.Show("Form Submitted")
    End Sub

    ' Override the ProcessCmdKey method to handle key combinations
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.T) Then
            ToggleTimer()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.S) Then
            SubmitForm()
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    ' Event handlers for other controls can go here if needed
End Class
