Imports System.ComponentModel
Imports System.IO
Module Module1

    Public itemPos As Integer
    Public currentItemId As String
    Public SelectedItem As String

    Public currentDir As String = CurDir.Replace("bin\Debug", "Inventories\")
    Public DEFAULT_FILE As String = currentDir + "\PRODUCTS.txt"
    Public filepath As String = DEFAULT_FILE


    ' CREATE ITEM
    Public Sub CreateItem(item As String)
        If Not String.IsNullOrEmpty(item) Then
            File.AppendAllText(filepath, item)
        End If
    End Sub

    ' READ ITEMS
    Public Function Readitems() As String()
        Return File.ReadAllLines(filepath)
    End Function

    ' READ ITEM
    Public Function ReadItem(id As String) As String
        If String.IsNullOrEmpty(id) Or Not IsNumeric(id) Then
            Return ""
        End If

        Dim datas As String() = Readitems()
        Dim i As Integer = 0
        Dim item As String = ""

        While i < datas.Length
            Dim lineId As String = datas(i).Split("=")(0)
            If lineId = id Then
                item = datas(i).Split("=")(1)
                Return item
            End If
            i += 1
        End While
        Return item
    End Function

    ' UPDATE ITEM
    Public Sub Updateitems(text As String, id As Integer)

        If String.IsNullOrEmpty(id) Or Not IsNumeric(id) Then
            Return
        End If

        Dim datas As ArrayList = New ArrayList(Readitems())
        Dim i = 0

        While i < datas.Count
            Dim lineId As String = datas(i).Split("=")(0)
            If lineId = id Then

                datas(i) = text
                Dim new_datas As String() = datas.ToArray(GetType(String))
                File.WriteAllLines(filepath, new_datas)

                Return
            End If
            i += 1
        End While
    End Sub

    ' DELETE ITEM
    Public Sub DeleteItem(id As String)
        If String.IsNullOrEmpty(id) Or Not IsNumeric(id) Then
            Return
        End If

        Dim datas As ArrayList = New ArrayList(Readitems())
        Dim i = 0

        While i < datas.Count
            Dim lineId As String = datas(i).Split("=")(0)
            If lineId = id Then

                datas.RemoveAt(i)
                Dim new_datas As String() = datas.ToArray(GetType(String))
                File.WriteAllLines(filepath, new_datas)

                Return
            End If
            i += 1
        End While
    End Sub

    ' SEARCH ITEMS
    Public Function SearchItems(keyword As String) As String()
        If String.IsNullOrEmpty(keyword) Then
            Return Readitems()
        End If
        Dim datas As String() = Readitems()
        Dim items As ArrayList = New ArrayList()
        For i As Integer = 0 To datas.Length - 1
            Dim item As String = datas(i).Split("=")(1)
            If item.Contains(keyword.Trim) Then
                items.Add(datas(i))
            End If
        Next
        Return items.ToArray(GetType(String))
    End Function

    ' LOAD GRID
    Public Sub GridFile(ByRef grid As DataGridView)
        Dim datas As String() = Readitems()
        If Not datas.Length - grid.RowCount = 1 Then
            grid.Rows.Clear()
        End If
        For row As Integer = grid.RowCount To datas.Count - 1
            Dim item As String() = datas(row).Split("=")(1).Split(",")
            grid.Rows.Add(item)
        Next
    End Sub

    Public Function IndexFromGrid(grid As DataGridView, id As Integer) As Integer
        Dim i = 0
        While i < grid.Rows.Count
            If grid.Rows(i).Cells(0).Value = id Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function ConcatStrings(str As String()) As String
        Dim result As String = ""
        For Each s In str
            result += s + ","
        Next
        Return result.Remove(result.Length - 1)
    End Function

    Public Function GetInputs(ByRef inputs As TextBox()) As String()
        Dim datas As New ArrayList

        For Each t In inputs
            datas.Add(t.Text)
        Next
        Return datas.ToArray(GetType(String))
    End Function

    Public Function IsEmptyInputs(ByRef inputs As TextBox()) As Boolean
        For Each t In inputs
            If String.IsNullOrEmpty(t.Text) Then
                Dim msg As String = "Found missing value: " & t.Name.Substring(3)
                MsgBox(msg, MsgBoxStyle.Exclamation, "Please fill all the fields")
                Return True
            End If
        Next
        Return False
    End Function

    Public Function IsValidNumbers(ByRef inputs As TextBox()) As Boolean
        For Each t In inputs
            If Not IsNumeric(t.Text) Then
                Dim msg As String = "Found invalid value: " & t.Name.Substring(3)
                MsgBox(msg, MsgBoxStyle.Exclamation, "Invalid Value")
                t.Focus()
                Return False
            End If
        Next
        Return True
    End Function

    Public Sub NewInventory(name As String)
        If String.IsNullOrEmpty(name) Then
            name = DEFAULT_FILE
        Else
            name = currentDir + name
        End If
        If Not name.EndsWith(".txt") Then
            name += ".txt"
        End If

        If Not File.Exists(name) Then
            File.Create(name).Dispose()
            MsgBox("File Created Successfully", MsgBoxStyle.Information, "Success")
        End If
        filepath = name
    End Sub


End Module
