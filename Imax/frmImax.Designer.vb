<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImax
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        lblDisplayCost = New Label()
        btnClearForm = New Button()
        btnTicketCost = New Button()
        txtTickets = New TextBox()
        lblTickets = New Label()
        cboIMAXTickets = New ComboBox()
        lblHeading = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblDisplayCost)
        Panel1.Controls.Add(btnClearForm)
        Panel1.Controls.Add(btnTicketCost)
        Panel1.Controls.Add(txtTickets)
        Panel1.Controls.Add(lblTickets)
        Panel1.Controls.Add(cboIMAXTickets)
        Panel1.Controls.Add(lblHeading)
        Panel1.Dock = DockStyle.Right
        Panel1.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(436, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(364, 450)
        Panel1.TabIndex = 0
        ' 
        ' lblDisplayCost
        ' 
        lblDisplayCost.AutoSize = True
        lblDisplayCost.BackColor = Color.DodgerBlue
        lblDisplayCost.ForeColor = Color.White
        lblDisplayCost.Location = New Point(73, 354)
        lblDisplayCost.Name = "lblDisplayCost"
        lblDisplayCost.Size = New Size(73, 23)
        lblDisplayCost.TabIndex = 6
        lblDisplayCost.Text = "Label1"
        lblDisplayCost.Visible = False
        ' 
        ' btnClearForm
        ' 
        btnClearForm.BackColor = Color.DodgerBlue
        btnClearForm.ForeColor = Color.White
        btnClearForm.Location = New Point(102, 284)
        btnClearForm.Name = "btnClearForm"
        btnClearForm.Size = New Size(160, 31)
        btnClearForm.TabIndex = 5
        btnClearForm.Text = "Clear Form"
        btnClearForm.UseVisualStyleBackColor = False
        btnClearForm.Visible = False
        ' 
        ' btnTicketCost
        ' 
        btnTicketCost.BackColor = Color.DodgerBlue
        btnTicketCost.ForeColor = Color.White
        btnTicketCost.Location = New Point(102, 225)
        btnTicketCost.Name = "btnTicketCost"
        btnTicketCost.Size = New Size(160, 31)
        btnTicketCost.TabIndex = 4
        btnTicketCost.Text = "Ticket Cost"
        btnTicketCost.UseVisualStyleBackColor = False
        btnTicketCost.Visible = False
        ' 
        ' txtTickets
        ' 
        txtTickets.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        txtTickets.Location = New Point(161, 148)
        txtTickets.Name = "txtTickets"
        txtTickets.Size = New Size(43, 31)
        txtTickets.TabIndex = 3
        txtTickets.TextAlign = HorizontalAlignment.Center
        txtTickets.Visible = False
        ' 
        ' lblTickets
        ' 
        lblTickets.AutoSize = True
        lblTickets.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        lblTickets.Location = New Point(73, 113)
        lblTickets.Name = "lblTickets"
        lblTickets.Size = New Size(242, 23)
        lblTickets.TabIndex = 2
        lblTickets.Text = "Number of Ticket(s): "
        lblTickets.Visible = False
        ' 
        ' cboIMAXTickets
        ' 
        cboIMAXTickets.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        cboIMAXTickets.FormattingEnabled = True
        cboIMAXTickets.Items.AddRange(New Object() {"Matinee $16", "Evening $27"})
        cboIMAXTickets.Location = New Point(86, 60)
        cboIMAXTickets.Name = "cboIMAXTickets"
        cboIMAXTickets.Size = New Size(193, 31)
        cboIMAXTickets.TabIndex = 1
        cboIMAXTickets.Text = "Select Ticket:"
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.BackColor = Color.DodgerBlue
        lblHeading.Font = New Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.ForeColor = Color.White
        lblHeading.Location = New Point(13, 9)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(338, 32)
        lblHeading.TabIndex = 0
        lblHeading.Text = "IMAX Theater Tickets"
        ' 
        ' frmImax
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Imax
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "frmImax"
        Text = "Purchase IMAX Theater Tickets"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTickets As Label
    Friend WithEvents cboIMAXTickets As ComboBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblDisplayCost As Label
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnTicketCost As Button
    Friend WithEvents txtTickets As TextBox

End Class
