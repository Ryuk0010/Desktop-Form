Public Class View_Submission
    Private currentIndex As Integer = 0

    Private Sub View_Submission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCurrentRow()
        UpdateButtonStates()
    End Sub

    Private Sub DisplayCurrentRow()
        Try
            If currentIndex >= 0 AndAlso currentIndex < Submission_Data.DataGridView1.Rows.Count Then
                Dim row As DataGridViewRow = Submission_Data.DataGridView1.Rows(currentIndex)
                TextBox1.Text = row.Cells("Column1").Value.ToString()
                TextBox2.Text = row.Cells("Column2").Value.ToString()
                TextBox3.Text = row.Cells("Column3").Value.ToString()
                TextBox4.Text = row.Cells("Column4").Value.ToString()
                TextBox5.Text = row.Cells("Column5").Value.ToString()
                'Label6.Text = row.Cells("Column6").Value.ToString()
            End If
        Catch ex As Exception
            ' Handle the exception, e.g., show an error message or log the error
            MessageBox.Show("An error occurred while displaying the row: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        If currentIndex < Submission_Data.DataGridView1.Rows.Count - 1 Then
            currentIndex += 1
            DisplayCurrentRow()
            UpdateButtonStates()
        End If
    End Sub

    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplayCurrentRow()
            UpdateButtonStates()
        End If
    End Sub

    Private Sub UpdateButtonStates()
        ButtonNext.Enabled = (currentIndex < Submission_Data.DataGridView1.Rows.Count - 1)
        ButtonPrevious.Enabled = (currentIndex > 0)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
