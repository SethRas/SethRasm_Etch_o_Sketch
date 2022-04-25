Option Strict On
Option Explicit On
Imports System.Math

Public Class SethRas_Etcho_A_Sketch
    Dim currentColor As Color
    Dim currentPenSize As Integer
    'Upon Startup make the pen black and a size of 2
    Private Sub SethRas_Etcho_A_Sketch_Load(sender As Object, e As EventArgs) Handles Me.Load
        currentColor = Color.Black
        currentPenSize = 1
    End Sub
    'Start the program and tell it you want to draw something with the Graphics function
    'Draw on the picturebox and not the rest of the form
    'recall pensize
    'When drawing there needs to be a starting point and an endpoint define them
    'When done get rid of the pen and stop the graphics
    Sub Sketch(startX As Integer, startY As Integer, endX As Integer, endY As Integer)
        Dim g As Graphics = DrawPictureBox.CreateGraphics
        Dim pen As New Pen(Me.currentColor)
        pen.Width = currentPenSize
        g.DrawLine(pen, startX, startY, endX, endY)
        g.Dispose()
        pen.Dispose()
    End Sub

    'Place a colorDialog on the Form 
    'Use it to pick the pen color, we will call this with another button under mouse functions
    Sub PickPenColor()
        ColorDialog1.ShowDialog()
        Me.currentColor = ColorDialog1.Color
    End Sub

    'Here we select what button draws so the form doesnt draw with the mouse move but with the left button
    'Call the middle mouse button as the color pallet selector
    'have the draw function draw from old to new coordinates
    Private Sub GraphicsForm_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawPictureBox.MouseMove, DrawPictureBox.MouseDown
        Static oldX, oldY As Integer
        Me.Text = $"({e.X},{e.Y}) Button:{e.Button.ToString()}"
        Select Case e.Button.ToString
            Case "Left"
                Sketch(oldX, oldY, e.X, e.Y)
            Case "Middle"
                PickPenColor()
        End Select
        oldX = e.X
        oldY = e.Y
    End Sub

    'Refresh the picture box on clear
    Sub Clear()
        DrawPictureBox.Refresh()
    End Sub
    'move the form slightly to add an 'animation' of shaking
    Sub shake()
        Dim offset As Integer = 30
        For i = 0 To 10
            Me.Left += offset
            Me.Top += offset
            offset *= -1 'invert offset
            System.Threading.Thread.Sleep(200) ' wait 200ms
        Next
    End Sub
    'Assign clear subs to the clear button
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        shake()
        Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = CStr(currentPenSize)
        Try
            currentPenSize = CInt(TextBox1.Text)
        Catch ex As Exception
        End Try
    End Sub



    Sub DrawSinWave()
        Dim x, y, ymax, oldY, oldX As Integer
        Dim oldColor As Color = Me.currentColor
        Me.currentColor = Color.LightGreen
        ymax = 100
        x = 45
        oldY = ymax
        For x = 0 To 360 Step 1

            'use system.math
            'degrees must be converted to radians deg * (PI/180)
            'Draw sin
            y = CInt(ymax * Sin(x * (PI / 180)) * -1) + ymax + 25
            'y = CInt(Round(ymax * Sin(x * (PI / 180))) * -1) + ymax
            'y = CInt(Ceiling(ymax * Sin(x * (PI / 180))) * -1) + ymax
            'y = CInt(Floor(ymax * Sin(x * (PI / 180))) * -1) + ymax

            Sketch(oldX, oldY, x, y)
            'Console.WriteLine($"({x},{y})")
            oldX = x
            oldY = y

        Next
        Me.currentColor = oldColor

    End Sub

    Private Sub DrawSINButton_Click(sender As Object, e As EventArgs) Handles DrawSINButton.Click
        Dim g As Graphics = DrawPictureBox.CreateGraphics
        Dim pen As New Pen(Me.currentColor)
        pen.Width = currentPenSize
        g.Dispose()
        pen.Dispose()
        DrawSinWave()
    End Sub

    Sub DrawCosWave()
        Dim x, y, ymax, oldY, oldX As Integer
        Dim oldColor As Color = Me.currentColor
        Me.currentColor = Color.LightBlue
        ymax = 100
        x = 45
        oldY = ymax
        For x = 0 To 360 Step 1

            'use system.math
            'degrees must be converted to radians deg * (PI/180)

            'Draw cos
            y = CInt(ymax * Cos(x * (PI / 180)) * -1) + ymax + 25

            Sketch(oldX, oldY, x, y)
            'Console.WriteLine($"({x},{y})")
            oldX = x
            oldY = y

        Next
        Me.currentColor = oldColor

    End Sub

    Private Sub DRAWCOSBUTTON_CLICK(sender As Object, e As EventArgs) Handles DrawCOSButton.Click
        Dim g As Graphics = DrawPictureBox.CreateGraphics
        Dim pen As New Pen(Me.currentColor)
        pen.Width = currentPenSize
        g.Dispose()
        pen.Dispose()
        DrawCosWave()
    End Sub

    Sub DrawTanWave()
        Dim x, y, ymax, oldY, oldX As Integer
        Dim oldColor As Color = Me.currentColor
        Me.currentColor = Color.Red
        ymax = 100
        x = 45
        oldY = ymax

        For x = 0 To 360 Step 1
            'use system.math
            'degrees must be converted to radians deg * (PI/180)

            'Draw tan
            Try
                'don't crash on +- infinite
                y = CInt(ymax * Tan(x * (PI / 180)) * -1) + ymax + 25
                Sketch(oldX, oldY, x, y)
                oldY = y
                oldX = x
            Catch ex As Exception
                'Console.WriteLine($"oops infinite is too hard to handle!")
                'Console.WriteLine(ex.Message)
            End Try

        Next
        Me.currentColor = oldColor

    End Sub
    Private Sub DRAWTANBUTTON_CLICK(sender As Object, e As EventArgs) Handles DrawTANButton.Click
        Dim g As Graphics = DrawPictureBox.CreateGraphics
        Dim pen As New Pen(Me.currentColor)
        pen.Width = currentPenSize
        g.Dispose()
        pen.Dispose()
        DrawTanWave()
    End Sub
End Class
