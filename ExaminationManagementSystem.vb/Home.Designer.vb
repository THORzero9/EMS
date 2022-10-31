<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.components = New System.ComponentModel.Container
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.STUDENTDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StudentformToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FACULTYDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FACULTYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RESULTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RESULTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MASTERENTRYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EXAMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MATERIALSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SEATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button1 = New System.Windows.Forms.Button
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MASTERENTRYToolStripMenuItem, Me.STUDENTDETAILSToolStripMenuItem, Me.FACULTYDETAILSToolStripMenuItem, Me.RESULTToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(727, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'STUDENTDETAILSToolStripMenuItem
        '
        Me.STUDENTDETAILSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentformToolStripMenuItem})
        Me.STUDENTDETAILSToolStripMenuItem.Name = "STUDENTDETAILSToolStripMenuItem"
        Me.STUDENTDETAILSToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.STUDENTDETAILSToolStripMenuItem.Text = "STUDENT DETAILS"
        '
        'StudentformToolStripMenuItem
        '
        Me.StudentformToolStripMenuItem.Name = "StudentformToolStripMenuItem"
        Me.StudentformToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.StudentformToolStripMenuItem.Text = "STUDENT FORM"
        '
        'FACULTYDETAILSToolStripMenuItem
        '
        Me.FACULTYDETAILSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FACULTYToolStripMenuItem})
        Me.FACULTYDETAILSToolStripMenuItem.Name = "FACULTYDETAILSToolStripMenuItem"
        Me.FACULTYDETAILSToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.FACULTYDETAILSToolStripMenuItem.Text = "FACULTY DETAILS"
        '
        'FACULTYToolStripMenuItem
        '
        Me.FACULTYToolStripMenuItem.Name = "FACULTYToolStripMenuItem"
        Me.FACULTYToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.FACULTYToolStripMenuItem.Text = "FACULTY"
        '
        'RESULTToolStripMenuItem
        '
        Me.RESULTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RESULTToolStripMenuItem1})
        Me.RESULTToolStripMenuItem.Name = "RESULTToolStripMenuItem"
        Me.RESULTToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.RESULTToolStripMenuItem.Text = "RESULT DETAILS"
        '
        'RESULTToolStripMenuItem1
        '
        Me.RESULTToolStripMenuItem1.Name = "RESULTToolStripMenuItem1"
        Me.RESULTToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.RESULTToolStripMenuItem1.Text = "RESULT"
        '
        'MASTERENTRYToolStripMenuItem
        '
        Me.MASTERENTRYToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EXAMToolStripMenuItem, Me.MATERIALSToolStripMenuItem, Me.SEATToolStripMenuItem})
        Me.MASTERENTRYToolStripMenuItem.Name = "MASTERENTRYToolStripMenuItem"
        Me.MASTERENTRYToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MASTERENTRYToolStripMenuItem.Text = "MASTER ENTRY"
        '
        'EXAMToolStripMenuItem
        '
        Me.EXAMToolStripMenuItem.Name = "EXAMToolStripMenuItem"
        Me.EXAMToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EXAMToolStripMenuItem.Text = "EXAM"
        '
        'MATERIALSToolStripMenuItem
        '
        Me.MATERIALSToolStripMenuItem.Name = "MATERIALSToolStripMenuItem"
        Me.MATERIALSToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MATERIALSToolStripMenuItem.Text = "MATERIALS"
        '
        'SEATToolStripMenuItem
        '
        Me.SEATToolStripMenuItem.Name = "SEATToolStripMenuItem"
        Me.SEATToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SEATToolStripMenuItem.Text = "SEAT"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(568, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "LOGOUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EMS.vb.My.Resources.Resources.home
        Me.ClientSize = New System.Drawing.Size(727, 488)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Home"
        Me.Text = "Home"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents STUDENTDETAILSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentformToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FACULTYDETAILSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FACULTYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RESULTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RESULTToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MASTERENTRYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXAMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MATERIALSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SEATToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
