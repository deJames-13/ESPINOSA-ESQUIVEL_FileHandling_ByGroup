Imports System.IO

Public Class Form1

    ' CREATE
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        If IsEmptyInputs({txtids, txtnamess, txtprices, txtqtyss}) Then
            Return
        End If
        If Not IsValidNumbers({txtprices, txtqtyss}) Then
            Return
        End If

        txttots.Text = (CDec(txtprices.Text) * CDec(txtqtyss.Text)).ToString("f2")

        Dim datas As String() = GetInputs({txtids, txtnamess, txtprices, txtqtyss, txttots})
        If datas Is Nothing Then
            Return
        End If

        Dim item As String = txtids.Text + "=" + ConcatStrings(datas)
        CreateItem(item + vbCrLf)
        GridFile(dgrid1)
    End Sub

    ' READ
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles btnread.Click
        If Not SelectItem() Then
            Return
        End If
        Dim item As String() = SelectedItem.Split(",")
        ShowData(item, {txtids, txtnamess, txtprices, txtqtyss, txttots})
    End Sub

    ' UPDATE
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If Not SelectItem() Then
            Return
        End If

        If IsEmptyInputs({txtids, txtnamess, txtprices, txtqtyss}) Then
            Return
        End If
        If Not IsValidNumbers({txtprices, txtqtyss}) Then
            Return
        End If

        txttots.Text = (CDec(txtprices.Text) * CDec(txtqtyss.Text)).ToString("f2")

        Dim datas As String() = GetInputs({txtids, txtnamess, txtprices, txtqtyss, txttots})
        If datas Is Nothing Then
            Return
        End If

        Dim item As String = txtids.Text + "=" + ConcatStrings(datas)

        Updateitems(item, currentItemId)
        dgrid1.Rows.RemoveAt(itemPos)
        dgrid1.Rows.Insert(itemPos)
        GridFile(dgrid1)
    End Sub

    ' DELETE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btndel.Click

        Dim id As String
        Dim pos As Integer

        If dgrid1.SelectedRows.Count > 0 Then
            id = dgrid1.SelectedRows(0).Cells(0).Value
            pos = dgrid1.SelectedRows(0).Index
        Else
            id = InputBox("Enter Item ID", "Delete Item")
            If String.IsNullOrEmpty(id) Then
                Return
            End If
            pos = IndexFromGrid(dgrid1, id)
            If pos < 0 Then
                MsgBox("Item Not Found", MsgBoxStyle.Critical, "Error")
                Return
            End If
        End If

        ' Confirm Delete
        Dim m As Integer = MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNo, "Confirm Delete")
        If m = MsgBoxResult.No Then
            Return
        End If

        DeleteItem(id)
        dgrid1.Rows.RemoveAt(pos)
    End Sub

    ' SEARCH
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click, txtSearch.TextChanged
        Dim item As String() = SearchItems(txtSearch.Text)
        If item Is Nothing Then
            Return
        End If
        dgrid1.Rows.Clear()
        For Each i As String In item
            Dim data As String() = i.Split("=")(1).Split(",")
            dgrid1.Rows.Add(data)
        Next
    End Sub

    ' NEW INVENTORY
    Private Sub btnNewInvent_Click(sender As Object, e As EventArgs) Handles btnNewInvent.Click
        openFile.InitialDirectory = currentDir
        Dim name As String

        Dim choose As String = MsgBox("Do you want to open an existing inventory or create a new one?", MsgBoxStyle.YesNoCancel, "New Inventory")
        If choose = MsgBoxResult.Yes Then

            If openFile.ShowDialog() = DialogResult.OK Then
                name = openFile.SafeFileName
            Else
                Return
            End If

        ElseIf choose = MsgBoxResult.No Then
            name = InputBox("Enter Inventory Name", "New Inventory")
        Else
            Return
        End If
        NewInventory(name)
        dgrid1.Rows.Clear()
        GridFile(dgrid1)
        inventoryName.Text = "Inventory Name: " & filepath.Split("\").Last
    End Sub

    Private Sub txtclear_Click(sender As Object, e As EventArgs) Handles txtclear.Click
        txtids.Clear()
        txtnamess.Clear()
        txtqtyss.Clear()
        txtprices.Clear()
        txttots.Clear()
    End Sub


    Private Sub dgrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrid1.CellClick
        If dgrid1.SelectedCells.Count >= 0 Then
            Dim row As DataGridViewRow = dgrid1.Rows(dgrid1.SelectedCells(0).RowIndex)
            row.Selected = True
            row.DefaultCellStyle.SelectionBackColor = Color.LightBlue
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewInventory("")
        inventoryName.Text = "Inventory Name: " & filepath.Split("\").Last
        GridFile(dgrid1)
    End Sub


    Public Function SelectItem() As Boolean
        Dim id As String
        If dgrid1.SelectedRows.Count > 0 Then
            id = dgrid1.SelectedRows(0).Cells(0).Value
        Else
            id = InputBox("Enter Item ID", "Get Item")
            If String.IsNullOrEmpty(id) Then
                Return 0
            End If
        End If

        itemPos = IndexFromGrid(dgrid1, id)
        If itemPos < 0 Then
            MsgBox("Item Not Found", MsgBoxStyle.Critical, "Error")
            Return 0
        End If
        currentItemId = id
        SelectedItem = ReadItem(currentItemId)
        Return 1
    End Function

    Public Sub ShowData(data As String(), texts As TextBox())
        For i As Integer = 0 To texts.Length - 1
            texts(i).Text = data(i)
        Next
    End Sub
End Class
