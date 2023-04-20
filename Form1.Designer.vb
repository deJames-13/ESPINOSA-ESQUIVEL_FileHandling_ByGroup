<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtclear = New System.Windows.Forms.Button()
        Me.btnread = New System.Windows.Forms.Button()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.inventName = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.dgrid1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prices = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totals = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnNewInvent = New System.Windows.Forms.Button()
        Me.openFile = New System.Windows.Forms.OpenFileDialog()
        Me.inventoryName = New System.Windows.Forms.Label()
        Me.txtids = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnamess = New System.Windows.Forms.TextBox()
        Me.txtqtyss = New System.Windows.Forms.TextBox()
        Me.txtprices = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttots = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.GroupBox1.Controls.Add(Me.txtclear)
        Me.GroupBox1.Controls.Add(Me.txttots)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnread)
        Me.GroupBox1.Controls.Add(Me.btncreate)
        Me.GroupBox1.Controls.Add(Me.btndel)
        Me.GroupBox1.Controls.Add(Me.btnupdate)
        Me.GroupBox1.Controls.Add(Me.txtprices)
        Me.GroupBox1.Controls.Add(Me.txtqtyss)
        Me.GroupBox1.Controls.Add(Me.txtnamess)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.inventName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtids)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 68)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(394, 365)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtclear
        '
        Me.txtclear.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtclear.Location = New System.Drawing.Point(263, 298)
        Me.txtclear.Margin = New System.Windows.Forms.Padding(2)
        Me.txtclear.Name = "txtclear"
        Me.txtclear.Size = New System.Drawing.Size(99, 31)
        Me.txtclear.TabIndex = 9
        Me.txtclear.Text = "CLEAR"
        Me.txtclear.UseVisualStyleBackColor = True
        '
        'btnread
        '
        Me.btnread.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnread.Location = New System.Drawing.Point(142, 242)
        Me.btnread.Margin = New System.Windows.Forms.Padding(2)
        Me.btnread.Name = "btnread"
        Me.btnread.Size = New System.Drawing.Size(99, 31)
        Me.btnread.TabIndex = 6
        Me.btnread.Text = "READ"
        Me.btnread.UseVisualStyleBackColor = True
        '
        'btncreate
        '
        Me.btncreate.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btncreate.Location = New System.Drawing.Point(18, 242)
        Me.btncreate.Margin = New System.Windows.Forms.Padding(2)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(99, 31)
        Me.btncreate.TabIndex = 5
        Me.btncreate.Text = "CREATE"
        Me.btncreate.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btndel.Location = New System.Drawing.Point(19, 298)
        Me.btndel.Margin = New System.Windows.Forms.Padding(2)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(99, 31)
        Me.btndel.TabIndex = 7
        Me.btndel.Text = "DELETE"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnupdate.Location = New System.Drawing.Point(142, 298)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(99, 31)
        Me.btnupdate.TabIndex = 8
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'inventName
        '
        Me.inventName.AutoSize = True
        Me.inventName.Location = New System.Drawing.Point(15, 64)
        Me.inventName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.inventName.Name = "inventName"
        Me.inventName.Size = New System.Drawing.Size(0, 13)
        Me.inventName.TabIndex = 2
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnsearch.Location = New System.Drawing.Point(436, 31)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(99, 31)
        Me.btnsearch.TabIndex = 11
        Me.btnsearch.Text = "SEARCH"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'dgrid1
        '
        Me.dgrid1.AllowUserToAddRows = False
        Me.dgrid1.AllowUserToDeleteRows = False
        Me.dgrid1.AllowUserToResizeColumns = False
        Me.dgrid1.AllowUserToResizeRows = False
        Me.dgrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrid1.BackgroundColor = System.Drawing.Color.MediumSeaGreen
        Me.dgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.prices, Me.totals, Me.Column3})
        Me.dgrid1.Location = New System.Drawing.Point(436, 68)
        Me.dgrid1.Margin = New System.Windows.Forms.Padding(2)
        Me.dgrid1.Name = "dgrid1"
        Me.dgrid1.ReadOnly = True
        Me.dgrid1.RowHeadersWidth = 51
        Me.dgrid1.RowTemplate.Height = 24
        Me.dgrid1.Size = New System.Drawing.Size(483, 365)
        Me.dgrid1.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "NAME"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'prices
        '
        Me.prices.HeaderText = "QUANTITY"
        Me.prices.MinimumWidth = 6
        Me.prices.Name = "prices"
        Me.prices.ReadOnly = True
        '
        'totals
        '
        Me.totals.HeaderText = "PRICE"
        Me.totals.MinimumWidth = 6
        Me.totals.Name = "totals"
        Me.totals.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "TOTAL"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Location = New System.Drawing.Point(539, 34)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(243, 25)
        Me.txtSearch.TabIndex = 18
        '
        'btnNewInvent
        '
        Me.btnNewInvent.Font = New System.Drawing.Font("Garamond", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewInvent.Location = New System.Drawing.Point(801, 29)
        Me.btnNewInvent.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNewInvent.Name = "btnNewInvent"
        Me.btnNewInvent.Size = New System.Drawing.Size(118, 31)
        Me.btnNewInvent.TabIndex = 12
        Me.btnNewInvent.Text = "New Inventory"
        Me.btnNewInvent.UseVisualStyleBackColor = True
        '
        'openFile
        '
        Me.openFile.FileName = "OpenFileDialog1"
        '
        'inventoryName
        '
        Me.inventoryName.AutoSize = True
        Me.inventoryName.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.inventoryName.Location = New System.Drawing.Point(30, 37)
        Me.inventoryName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.inventoryName.Name = "inventoryName"
        Me.inventoryName.Size = New System.Drawing.Size(126, 18)
        Me.inventoryName.TabIndex = 18
        Me.inventoryName.Text = "Inventory Name:"
        '
        'txtids
        '
        Me.txtids.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtids.Location = New System.Drawing.Point(234, 21)
        Me.txtids.Margin = New System.Windows.Forms.Padding(2)
        Me.txtids.Name = "txtids"
        Me.txtids.Size = New System.Drawing.Size(127, 25)
        Me.txtids.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRODUCT ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(15, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PRODUCT QUANTITY:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(15, 154)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "PRODUCT PRICE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(15, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "NAME:"
        '
        'txtnamess
        '
        Me.txtnamess.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtnamess.Location = New System.Drawing.Point(234, 64)
        Me.txtnamess.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnamess.Name = "txtnamess"
        Me.txtnamess.Size = New System.Drawing.Size(127, 25)
        Me.txtnamess.TabIndex = 1
        '
        'txtqtyss
        '
        Me.txtqtyss.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtqtyss.Location = New System.Drawing.Point(234, 109)
        Me.txtqtyss.Margin = New System.Windows.Forms.Padding(2)
        Me.txtqtyss.Name = "txtqtyss"
        Me.txtqtyss.Size = New System.Drawing.Size(127, 25)
        Me.txtqtyss.TabIndex = 2
        '
        'txtprices
        '
        Me.txtprices.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtprices.Location = New System.Drawing.Point(234, 148)
        Me.txtprices.Margin = New System.Windows.Forms.Padding(2)
        Me.txtprices.Name = "txtprices"
        Me.txtprices.Size = New System.Drawing.Size(127, 25)
        Me.txtprices.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(15, 193)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "TOTAL:"
        '
        'txttots
        '
        Me.txttots.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txttots.Location = New System.Drawing.Point(234, 187)
        Me.txttots.Margin = New System.Windows.Forms.Padding(2)
        Me.txttots.Name = "txttots"
        Me.txttots.Size = New System.Drawing.Size(127, 25)
        Me.txttots.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(948, 466)
        Me.Controls.Add(Me.inventoryName)
        Me.Controls.Add(Me.btnNewInvent)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsearch)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Espinosa - Esquivel Basic CRUD SYSTEM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btndel As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents inventName As Label
    Friend WithEvents dgrid1 As DataGridView
    Friend WithEvents btnread As Button
    Friend WithEvents btncreate As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents prices As DataGridViewTextBoxColumn
    Friend WithEvents totals As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents txtclear As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnNewInvent As Button
    Friend WithEvents openFile As OpenFileDialog
    Friend WithEvents inventoryName As Label
    Friend WithEvents txttots As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtprices As TextBox
    Friend WithEvents txtqtyss As TextBox
    Friend WithEvents txtnamess As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtids As TextBox
End Class
