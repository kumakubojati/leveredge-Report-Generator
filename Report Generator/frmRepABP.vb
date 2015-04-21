Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class frmRepABP

    Dim sqlcon As New SqlClient.SqlConnection
    Dim readdata As String

    Private Sub Get_dbCon()
        Dim strfile As String = My.Application.Info.DirectoryPath & "\Conf.ini"
        Dim sr As New StreamReader(strfile)
        readdata = sr.ReadToEnd
        Dim constring As String
        constring = readdata
        sqlcon.ConnectionString = constring
        Try
            Using sqlcon
                If ConnectionState.Closed Then
                    sqlcon.Open()
                ElseIf ConnectionState.Open Then
                    Exit Sub
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Get_dbCon Error on Connection : " & ex.Message.ToString, "SQL Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function dgvTods(ByVal dgv As DataGridView) As DataSet
        Dim ds As New DataSet
        Try
            ds.Tables.Add("dtHeadRep2")
            Dim col As DataColumn
            For Each dgridcol As DataGridViewColumn In dgv.Columns
                col = New DataColumn(dgridcol.Name)
                ds.Tables("dtHeadRep2").Columns.Add(col)
            Next

            Dim row As DataRow
            Dim colcount As Integer = dgv.Columns.Count - 1
            For i As Integer = 0 To dgv.Rows.Count - 2
                row = ds.Tables("dtHeadRep2").Rows.Add
                For Each column As DataGridViewColumn In dgv.Columns
                    If dgv.Rows.Item(i).Cells(column.Index).Value = Nothing Then
                        dgv.Rows.Item(i).Cells(column.Index).Value = "0"
                    End If
                    row.Item(column.Index) = dgv.Rows.Item(i).Cells(column.Index).Value
                Next
            Next
            dtHeadRep2BindingSource.DataSource = ds
            Return ds
        Catch ex As Exception
            MessageBox.Show("Error Data")
        End Try
    End Function

    Private Sub frmRepABP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmABP.GetDataABP()
        dgvTods(frmABP.dgridSKU)
        Me.rvABP.RefreshReport()
    End Sub

End Class