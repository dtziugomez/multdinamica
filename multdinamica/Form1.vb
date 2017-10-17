Public Class Form1
    Dim fil1 As Integer = 0
    Dim col1 As Integer = 0
    Dim col2 As Integer = 0
    Dim band As Boolean = False
    Dim aux As Integer = 0
    Dim primeramatriz() As TextBox
    Dim segundamatriz() As TextBox
    Dim terceramatriz() As TextBox
    Dim posx, posy As Integer
    Dim lblmultiplicacion As New Label
    Dim numelementos1 As Integer
    Dim numelementos2 As Integer
    Dim numelementos3 As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ClientSize = New System.Drawing.Size(600, 600)
        'lblmultiplicacion.Text = "*"
        'lblmultiplicacion.Location = New Point(291, 170)
        'lblmultiplicacion.Parent = Me
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        fil1 = Integer.Parse(TextBox1.Text)
        col1 = Integer.Parse(TextBox2.Text)
        numelementos1 = fil1 * col1

        posx = 20
        posy = 170
        ReDim Preserve primeramatriz(numelementos1)
        For i As Integer = 0 To numelementos1 - 1
            primeramatriz(i) = New TextBox
            primeramatriz(i).Height = 20
            primeramatriz(i).Width = 20
            primeramatriz(i).Location = New Point(posx, posy)
            posx += 290 \ col1
            If posx >= 290 Then
                posx = 20
                posy = posy + 40
            End If

        Next
        Me.Controls.AddRange(primeramatriz)
        posy = posy + 40

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        
        posy = 170
        posx = 360
        col2 = Integer.Parse(TextBox3.Text)
        numelementos2 = col1 * col2
        'Dim posx2 As Integer = 198
        ' Dim posy As Integer = 170
        ReDim Preserve segundamatriz(numelementos2)
        For i As Integer = 0 To numelementos2 - 1
            segundamatriz(i) = New TextBox
            segundamatriz(i).Height = 20
            segundamatriz(i).Width = 20
            segundamatriz(i).Location = New Point(posx, posy)
            ' posx += 40
            posx += 290 \ col2
            If posx >= 580 Then
                posx = 360
                posy = posy + 40
            End If

        Next
        Me.Controls.AddRange(segundamatriz)
        posy = posy + 40
    End Sub

    
    

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        posy = 380
        posx = 20
        numelementos3 = fil1 * col2
        ReDim Preserve terceramatriz(numelementos3)
        For i As Integer = 0 To numelementos3 - 1
            terceramatriz(i) = New TextBox
            terceramatriz(i).Height = 20
            terceramatriz(i).Width = 20
            terceramatriz(i).Location = New Point(posx, posy)
            ' posx += 40
            posx += 290 \ col2
            If posx >= 290 Then
                posx = 20
                posy = posy + 40
            End If

        Next
        Me.Controls.AddRange(terceramatriz)
        posy = posy + 40
        'Dim k As Integer

        'For k = 0 To fil1 - 1
        '    Dim j As Integer
        '    For j = 0 To col2 - 1
        '        Dim sum As Integer
        '        Dim i As Integer
        '        For i = 0 To col1 - 1
        '            sum = sum + matriz1(k, i) * matriz2(i, j)
        '        Next
        '        mult(k, j) = sum
        '        sum = 0
        '    Next
        'Next

        'terceramatriz(i).Text = Integer.Parse(primeramatriz(i).Text) * Integer.Parse(segundamatriz(i).Text)

    End Sub

End Class
