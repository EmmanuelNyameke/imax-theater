' Program Name: IMAX Theater Tickets
' Date: November 11, 2024
' Author: K Bola
' Purpose: This application computes the cost of martinee and evening tickets with varying base and data plans
Public Class frmImax
    Private Sub cboIMAXTickets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIMAXTickets.SelectedIndexChanged
        Dim intIMAXTickets As Integer
        intIMAXTickets = cboIMAXTickets.SelectedIndex
        If (intIMAXTickets = 0 Or intIMAXTickets = 1) Then
            ' Making items visible
            lblTickets.Visible = True
            txtTickets.Visible = True
            btnTicketCost.Visible = True
            btnClearForm.Visible = True
            lblDisplayCost.Visible = True
        End If
    End Sub

    'Function Procedure to validate the number of tickets
    Private Function ValidateNumberOfTickets() As Boolean
        ' This procedure validates the number of tickets entered
        Dim intTickets As Integer
        Dim blnValidityCheck As Boolean = False
        Dim strNumberOfTicketsMessage As String = "Please enter a valid value."
        Dim strErrorMessage As String = "Invalid Input."
        Try
            intTickets = Convert.ToInt32(txtTickets.Text)
            If (intTickets > 0 And IsNumeric(intTickets)) Then
                blnValidityCheck = True
            Else
                MsgBox(strNumberOfTicketsMessage, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, strErrorMessage)
                txtTickets.Clear()
                txtTickets.Focus()
            End If
        Catch ex As Exception
            MsgBox(strNumberOfTicketsMessage, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, strErrorMessage)
            txtTickets.Clear()
            txtTickets.Focus()
        End Try
        Return blnValidityCheck
    End Function

    ' Function procedure to validate whether a user selected a ticket type
    Private Function ValidateTicketsType(ByRef blnTicket As Boolean, ByRef strTicket As String) As Integer
        ' This function ensures that user selected a ticket type
        Dim intTicket As Integer
        Try
            intTicket = Convert.ToInt32(cboIMAXTickets.SelectedIndex)
            strTicket = cboIMAXTickets.SelectedItem.ToString()
            blnTicket = True
        Catch ex As Exception
            ' Detecting if a ticket type is not selected
            MsgBox("Select a ticket type", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Invalid Entry")
            blnTicket = False
        End Try
        Return intTicket
    End Function
    ' Function procedures to be called for the tickets to be computed and pass back the cost of the total ticket cost
    Private Function MartineeCost() As Decimal
        Const _cdecMartineeCost As Decimal = 16D
        Dim decTotalCost As Decimal
        Dim intTicket As Integer = Convert.ToInt32(txtTickets.Text)
        Dim intTicketType As Integer
        intTicketType = Convert.ToInt32(cboIMAXTickets.SelectedIndex)
        If (intTicketType = 0) Then
            decTotalCost = _cdecMartineeCost * intTicket
        End If
        Return decTotalCost
    End Function
    Private Function EveningCost() As Decimal
        Const _cdecEveningCost As Decimal = 27D
        Dim decTotalCost As Decimal
        Dim intTickets = Convert.ToInt32(txtTickets.Text)
        Dim intTicketType As Integer = Convert.ToInt32(cboIMAXTickets.SelectedIndex)
        If (intTicketType = 1) Then
            decTotalCost = _cdecEveningCost * intTickets
        End If
        Return decTotalCost
    End Function

    Private Sub btnTicketCost_Click(sender As Object, e As EventArgs) Handles btnTicketCost.Click
        Dim intTickets As Integer
        Dim blnNumberOfTickets As Boolean = False
        Dim blnTicketIsSelected As Boolean = False
        Dim intTicketChoice As Integer
        Dim strSelectedTeam As String = ""
        Dim intIMAXChoice As Integer
        Dim decTotalCost As Decimal
        ' Calling a function to ensure the number of tickets entered
        blnNumberOfTickets = ValidateNumberOfTickets()
        ' Calling a function to ensure the ticket type was selected
        intTicketChoice = ValidateTicketsType(blnTicketIsSelected, strSelectedTeam)
        If (blnNumberOfTickets And blnTicketIsSelected) Then
            intTickets = Convert.ToInt32(txtTickets.Text)
            intIMAXChoice = cboIMAXTickets.SelectedIndex
            Select Case intIMAXChoice
                Case 0
                    decTotalCost = MartineeCost()
                Case 1
                    decTotalCost = EveningCost()
            End Select
            ' Displaying the cost of the ticket
            lblDisplayCost.Text = decTotalCost.ToString("C") & " for the tickets."
        End If
    End Sub

    Private Sub frmImax_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(4000)
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        cboIMAXTickets.Text = "Select Ticket:"
        ' Making items invisible
        lblTickets.Visible = False
        txtTickets.Visible = False
        btnTicketCost.Visible = False
        btnClearForm.Visible = False
        lblDisplayCost.Visible = False
    End Sub
End Class
