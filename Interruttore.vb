Imports System.Drawing
Imports System.ComponentModel

<ToolboxBitmap("Interruttore.bmp")>
<DefaultEvent("SwitchOFF")>
Public Class Interruttore

    <Description("Event generated when the switch changes state to ON")>
    Public Event SwitchON()
    <Description("Event generated when the switch changes state to OFF")>
    Public Event SwitchOFF()

    Private _state As String = "OFF"
    ''' <summary>
    ''' Gets or sets the status of the control
    ''' </summary>
    <Category("Appearance"),
    Description("Gets or sets the status of the control")>
    Public Property State As String
        Get
            Return _state
        End Get
        Set(value As String)
            _state = value
            Me.Invalidate()
        End Set
    End Property

    Private _NoTextState As Boolean
    ''' <summary>
    ''' Displays or hides the control status text
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("Appearance"),
    Description("Displays or hides the control status text"),
    DefaultValue("False")>
    Public Property NoTextState As Boolean
        Get
            Return _NoTextState
        End Get
        Set(value As Boolean)
            _NoTextState = value
        End Set
    End Property

    Private _cursor As Windows.Forms.Cursor = Windows.Forms.Cursors.Hand
    <Browsable(False)>
    Public Overrides Property Cursor As Windows.Forms.Cursor
        Get
            Return _cursor
        End Get
        Set(value As Windows.Forms.Cursor)
            MyBase.Cursor = _cursor
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Initialize the color of the green for the background
        Dim myColor As Color
        myColor = Color.FromArgb(105, 247, 71)
        Dim myBrush As SolidBrush
        myBrush = New SolidBrush(myColor)

        Dim stateControl As String
        stateControl = Me.State

        If State = "OFF" Then
            Me.Height = 20
            Me.Width = 60
            Dim graphics As Graphics = e.Graphics
            'rectangle of the control
            graphics.FillRectangle(myBrush, 0, 0, Width, Height)
            'white rectangle that acts as a switch
            graphics.FillRectangle(Brushes.Gray, 0, 0, 30, 19)
            'edge of the rectangle that acts as a switch
            graphics.DrawRectangle(Pens.Black, New Rectangle(0, 0, 29, 19))
            'part of the white rectangle for the background OFF
            graphics.FillRectangle(Brushes.White, New Rectangle(30, 0, 30, 20))
            'write your status OFF
            If Me.NoTextState = True Then
                Exit Sub
            Else
                graphics.DrawString("OFF", New Font("Arial", 10, FontStyle.Italic), Brushes.Black, 30, 2)
            End If

        End If

        If State = "ON" Then
            Me.Height = 20
            Me.Width = 60
            Dim graphics As Graphics = e.Graphics
            'rectangle of the control
            graphics.FillRectangle(myBrush, 0, 0, Width, Height)
            'white rectangle that acts as a switch
            graphics.FillRectangle(Brushes.Gray, 30, 0, 30, 19)
            'edge of the rectangle that acts as a switch
            graphics.DrawRectangle(Pens.Black, New Rectangle(30, 0, 29, 19))
            'write your status OFF
            If Me.NoTextState = True Then
            Else
                graphics.DrawString("ON", New Font("Arial", 10, FontStyle.Italic), Brushes.Black, 2, 2)
            End If
        End If
    End Sub

    Private Sub Interruttore_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim evArgs As New InterruttoreEventArgs
        'Event of CustomSwitch
        If Me.State = "ON" Then
            Me.State = "OFF"
            evArgs.state = "OFF"
            RaiseEvent SwitchOFF()
        ElseIf Me.State = "OFF" Then
            Me.State = "ON"
            evArgs.state = "ON"
            RaiseEvent SwitchON()
        End If
    End Sub
End Class

