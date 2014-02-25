Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        myTextBox = {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5}
        chkbox = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6}
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "C:\Users\Mal\Desktop\Etal\D2NT\scripts\NTBot\char_configs\"
        openFileDialog1.Filter = "char files (*.ntl)|NTConfig_?*_*.ntl|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then Return

        CharFile = openFileDialog1.FileName
        Try
            RichTextBox1.LoadFile(CharFile, RichTextBoxStreamType.UnicodePlainText)
        Catch ex As Exception
            MessageBox.Show("error opening file")
            Return
        End Try


        Dim temp = CharFile.Split("\")
        Dim temp1 = temp(temp.Length - 1)
        temp1 = Replace(temp1, ".ntl", "")
        temp = temp1.Split("_")
        CharClassBox.Text = temp(1)
        CharNameBox.Text = temp(2)


        RemoveSpaceErrors()

        FillBoxes()

    End Sub



    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        If WordWrapToolStripMenuItem.Checked = False Then
            WordWrapToolStripMenuItem.Checked = True
            RichTextBox1.WordWrap = True
            Return
        End If

        If WordWrapToolStripMenuItem.Checked = True Then
            WordWrapToolStripMenuItem.Checked = False
            RichTextBox1.WordWrap = False
        End If

    End Sub
    Sub RemoveSpaceErrors()
        For index = 1 To 3

            RichTextBox1.Text = Replace(RichTextBox1.Text, " " & vbTab, " ")
            RichTextBox1.Text = Replace(RichTextBox1.Text, vbTab & " ", " ")
            RichTextBox1.Text = Replace(RichTextBox1.Text, "=" & vbTab, "=")
            RichTextBox1.Text = Replace(RichTextBox1.Text, vbTab & "=", "=")
            RichTextBox1.Text = Replace(RichTextBox1.Text, "; ", ";" & vbTab)
            RichTextBox1.Text = Replace(RichTextBox1.Text, " //", vbTab & "//")

        Next

    End Sub

    Private Sub EOLTrimToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EOLTrimToolStripMenuItem.Click
        Dim arr() As String
        Dim i As Integer
        Dim count As Integer = 0
        Dim temp As String
        arr = Split(RichTextBox1.Text, vbLf)

        For i = 0 To UBound(arr)

            temp = RTrim(arr(i))
            If temp <> arr(i) Then
                RichTextBox1.Text = Replace(RichTextBox1.Text, arr(i), temp)
                count = count + 1
            End If

        Next

        ToolStripLabel3.Text = "changes = " & count
    End Sub



    Sub FillBoxes()


        Dim arr() As String
        Dim i As Integer
        Dim count As Integer = 0
        Dim count2 As Integer = 0
        Dim temp() As String
        arr = Split(RichTextBox1.Text, vbLf)

        For i = 0 To UBound(arr)

            If arr(i).Contains("NTConfig_Leader = ") = True Then Textboxfill(arr(i), count) : count = count + 1 : Continue For
            If arr(i).Contains("NTConfig_TakeTpTravincal = ") = True Then Textboxfill(arr(i), count) : count = count + 1 : Continue For
            If arr(i).Contains("NTConfig_TakeTpDiablo = ") = True Then Textboxfill(arr(i), count) : count = count + 1 : Continue For
            If arr(i).Contains("NTConfig_TakeTpBaal = ") = True Then Textboxfill(arr(i), count) : count = count + 1 : Continue For
            ' add scripts to an array
            If arr(i).Contains("AutoTeleport.ntj") = True Then Continue For
            If arr(i).Contains("NTTravLeader.ntj") = True Then Continue For
            If arr(i).Contains("NTConfig_Script.push") = True Then temp = arr(i).Split(";") : script.Add(temp(0)) : MyScriptCheck(temp(0)) : count2 = count2 + 1

        Next
        'ToolStripLabel3.Text = script(1)

    End Sub

    Sub Textboxfill(ByVal mystring, ByVal x)

        Dim temp = mystring.Split("""")
        myTextBox(x).Text = temp(1)

    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click


        Dim arr() As String
        Dim i As Integer
        Dim count As Integer = 0
        arr = Split(RichTextBox1.Text, vbLf)

        For i = 0 To UBound(arr)

            If arr(i).Contains("NTConfig_Leader = ") = True Then UpdateRaw(arr(i), "NTConfig_Leader = ", count) : count = count + 1 : Continue For
            If arr(i).Contains("NTConfig_TakeTpTravincal = ") = True Then UpdateRaw(arr(i), "NTConfig_TakeTpTravincal = ", count) : count = count + 1 : Continue For
            If arr(i).Contains("NTConfig_TakeTpDiablo = ") = True Then UpdateRaw(arr(i), "NTConfig_TakeTpDiablo = ", count) : count = count + 1 : Continue For
            If arr(i).Contains("NTConfig_TakeTpBaal = ") = True Then UpdateRaw(arr(i), "NTConfig_TakeTpBaal = ", count) : count = count + 1 : Continue For

        Next




    End Sub


    Sub UpdateRaw(ByVal mystr1, ByVal mystr2, ByVal x)

        Dim temp = mystr1.Split(";")

        mystr2 = vbTab & mystr2 & Chr(34) & myTextBox(x).Text & Chr(34)
        If temp(0).contains(vbTab & vbTab) = True Then
            mystr2 = vbTab & mystr2
        End If
        RichTextBox1.Text = Replace(RichTextBox1.Text, temp(0), mystr2)
    End Sub


End Class
