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
        Me.txtKeyEntry = New System.Windows.Forms.TextBox()
        Me.txtValueEntry = New System.Windows.Forms.TextBox()
        Me.lstKeys = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemoveKey = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstValues = New System.Windows.Forms.ListBox()
        Me.btnRemoveVal = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SortGamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.fdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.lblLoaded = New System.Windows.Forms.Label()
        Me.lblTotalGames = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtKeyEntry
        '
        Me.txtKeyEntry.Location = New System.Drawing.Point(12, 48)
        Me.txtKeyEntry.Name = "txtKeyEntry"
        Me.txtKeyEntry.Size = New System.Drawing.Size(100, 20)
        Me.txtKeyEntry.TabIndex = 0
        '
        'txtValueEntry
        '
        Me.txtValueEntry.Location = New System.Drawing.Point(12, 98)
        Me.txtValueEntry.Name = "txtValueEntry"
        Me.txtValueEntry.Size = New System.Drawing.Size(100, 20)
        Me.txtValueEntry.TabIndex = 1
        '
        'lstKeys
        '
        Me.lstKeys.FormattingEnabled = True
        Me.lstKeys.Location = New System.Drawing.Point(118, 48)
        Me.lstKeys.Name = "lstKeys"
        Me.lstKeys.Size = New System.Drawing.Size(120, 160)
        Me.lstKeys.TabIndex = 2
        Me.lstKeys.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(528, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateFileToolStripMenuItem, Me.OpenFileToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CreateFileToolStripMenuItem
        '
        Me.CreateFileToolStripMenuItem.Name = "CreateFileToolStripMenuItem"
        Me.CreateFileToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CreateFileToolStripMenuItem.Text = "Save File"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenFileToolStripMenuItem.Text = "Open File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SortToolStripMenuItem, Me.SortGamesToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.ToolsToolStripMenuItem.Text = "&Edit"
        '
        'SortToolStripMenuItem
        '
        Me.SortToolStripMenuItem.Name = "SortToolStripMenuItem"
        Me.SortToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SortToolStripMenuItem.Text = "Sort Consoles"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 124)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 27)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.TabStop = False
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemoveKey
        '
        Me.btnRemoveKey.Location = New System.Drawing.Point(244, 48)
        Me.btnRemoveKey.Name = "btnRemoveKey"
        Me.btnRemoveKey.Size = New System.Drawing.Size(75, 48)
        Me.btnRemoveKey.TabIndex = 5
        Me.btnRemoveKey.TabStop = False
        Me.btnRemoveKey.Text = "Remove Selected &Console"
        Me.btnRemoveKey.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Enter Console"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(9, 82)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(63, 13)
        Me.lblValue.TabIndex = 7
        Me.lblValue.Text = "Enter Game"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Consoles"
        '
        'lstValues
        '
        Me.lstValues.FormattingEnabled = True
        Me.lstValues.Location = New System.Drawing.Point(325, 48)
        Me.lstValues.Name = "lstValues"
        Me.lstValues.Size = New System.Drawing.Size(189, 160)
        Me.lstValues.TabIndex = 9
        Me.lstValues.TabStop = False
        '
        'btnRemoveVal
        '
        Me.btnRemoveVal.Location = New System.Drawing.Point(244, 102)
        Me.btnRemoveVal.Name = "btnRemoveVal"
        Me.btnRemoveVal.Size = New System.Drawing.Size(75, 48)
        Me.btnRemoveVal.TabIndex = 10
        Me.btnRemoveVal.TabStop = False
        Me.btnRemoveVal.Text = "Remove Selected &Game"
        Me.btnRemoveVal.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(323, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Games"
        '
        'SortGamesToolStripMenuItem
        '
        Me.SortGamesToolStripMenuItem.Name = "SortGamesToolStripMenuItem"
        Me.SortGamesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SortGamesToolStripMenuItem.Text = "Sort Games"
        '
        'fdOpen
        '
        Me.fdOpen.FileName = "OpenFileDialog1"
        '
        'lblLoaded
        '
        Me.lblLoaded.AutoSize = True
        Me.lblLoaded.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoaded.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblLoaded.Location = New System.Drawing.Point(9, 166)
        Me.lblLoaded.Name = "lblLoaded"
        Me.lblLoaded.Size = New System.Drawing.Size(108, 17)
        Me.lblLoaded.TabIndex = 12
        Me.lblLoaded.Text = "Games Loaded!"
        Me.lblLoaded.Visible = False
        '
        'lblTotalGames
        '
        Me.lblTotalGames.AutoSize = True
        Me.lblTotalGames.Location = New System.Drawing.Point(9, 183)
        Me.lblTotalGames.Name = "lblTotalGames"
        Me.lblTotalGames.Size = New System.Drawing.Size(79, 13)
        Me.lblTotalGames.TabIndex = 13
        Me.lblTotalGames.Text = "Total Games: 0"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 214)
        Me.Controls.Add(Me.lblTotalGames)
        Me.Controls.Add(Me.lblLoaded)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRemoveVal)
        Me.Controls.Add(Me.lstValues)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemoveKey)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstKeys)
        Me.Controls.Add(Me.txtValueEntry)
        Me.Controls.Add(Me.txtKeyEntry)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Game Collection Tool"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKeyEntry As TextBox
    Friend WithEvents txtValueEntry As TextBox
    Friend WithEvents lstKeys As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemoveKey As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstValues As ListBox
    Friend WithEvents btnRemoveVal As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents SortGamesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents fdOpen As OpenFileDialog
    Friend WithEvents lblLoaded As Label
    Friend WithEvents lblTotalGames As Label
End Class
