Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        myTextBox = {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5}
        chkbox = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6, CheckBox7, CheckBox8, CheckBox9, CheckBox10,
                  CheckBox11, CheckBox12, CheckBox13, CheckBox14, CheckBox15, CheckBox16, CheckBox17, CheckBox18, CheckBox19, CheckBox20,
                  CheckBox21, CheckBox22, CheckBox23, CheckBox24, CheckBox25, CheckBox26, CheckBox27, CheckBox28, CheckBox29, CheckBox30,
                  CheckBox31, CheckBox32, CheckBox33, CheckBox34, CheckBox35, CheckBox36, CheckBox37, CheckBox38, CheckBox39, CheckBox40,
                  CheckBox41, CheckBox42, CheckBox43, CheckBox44, CheckBox45, CheckBox46, CheckBox47, CheckBox48, CheckBox49, CheckBox50,
                  CheckBox51, CheckBox52}
        cmbobox = {ComboBox1, ComboBox2, ComboBox3, ComboBox4, ComboBox5, ComboBox6, ComboBox7, ComboBox8, ComboBox9, ComboBox10, ComboBox11, ComboBox12}
        ', ComboBox13, ComboBox14, ComboBox15, ComboBox16, ComboBox17, ComboBox18, ComboBox19, ComboBox20,
        'ComboBox21, ComboBox22, ComboBox23, ComboBox24, ComboBox25, ComboBox26, ComboBox27, ComboBox28, ComboBox29, ComboBox30, ComboBox31,
        'ComboBox32, ComboBox33, ComboBox34, ComboBox35, ComboBox36, ComboBox37, ComboBox38, ComboBox39, ComboBox40, ComboBox41, ComboBox42,
        'ComboBox43, ComboBox44, ComboBox45, ComboBox46, ComboBox47, ComboBox48, ComboBox49, ComboBox50, ComboBox51, ComboBox52, ComboBox53,
        'ComboBox54, ComboBox55, ComboBox56, ComboBox57, ComboBox58, ComboBox59, ComboBox60, ComboBox61, ComboBox62, ComboBox63, ComboBox64,
        'ComboBox65, ComboBox66, ComboBox67, ComboBox68, ComboBox69, ComboBox70, ComboBox71, ComboBox72, ComboBox73, ComboBox74, ComboBox75,
        'ComboBox76, ComboBox77, ComboBox78, ComboBox79, ComboBox80, ComboBox81, ComboBox82, ComboBox83, ComboBox84, ComboBox85, ComboBox86,
        'ComboBox87, ComboBox88, ComboBox89, ComboBox90, ComboBox91, ComboBox92, ComboBox93, ComboBox94, ComboBox95, ComboBox96, ComboBox97,
        'ComboBox98, ComboBox99, ComboBox100, ComboBox101, ComboBox102, ComboBox103, ComboBox104, ComboBox105, ComboBox106, ComboBox107,
        'ComboBox108, ComboBox109, ComboBox110, ComboBox111, ComboBox112, ComboBox113, ComboBox114, ComboBox115, ComboBox116, ComboBox117,
        'ComboBox118, ComboBox119, ComboBox120, ComboBox121, ComboBox122, ComboBox123}

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click




        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "C:\Users\Mal\Desktop\Etal\D2NT\scripts\NTBot\char_configs\"
        'openFileDialog1.Filter = "char files (*.ntl)|NTConfig_?*_*.ntl|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then Return

        CharFile = openFileDialog1.FileName

        Dim Reader = My.Computer.FileSystem.OpenTextFileReader(CharFile)


        While (Reader.EndOfStream = False)
            RichTextBox1.AppendText(Reader.ReadLine() & vbCrLf)
        End While

        Reader.Close()
        'Try
        '    RichTextBox1.LoadFile(CharFile, RichTextBoxStreamType.PlainText)
        'Catch ex As Exception
        '    MessageBox.Show("error opening file")
        '    Return
        'End Try

        Try
            RichTextBox1.LoadFile(CharFile, RichTextBoxStreamType.PlainText)
        Catch ex As Exception
            MessageBox.Show("error opening file")
            Return
        End Try



        Dim temp = CharFile.Split("\")
        Dim temp1 = temp(temp.Length - 1)
        temp1 = Replace(temp1, ".ntl", "")
        temp = temp1.Split("_")
        CharClassBox.Text = temp(1)
        ' CharNameBox.Text = temp(2)


        RemoveSpaceErrors()

        ' FillBoxes()

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
        For index = 1 To 5
            RichTextBox1.Text = Replace(RichTextBox1.Text, "  ", " ")
            RichTextBox1.Text = Replace(RichTextBox1.Text, " " & vbTab, " ")
            RichTextBox1.Text = Replace(RichTextBox1.Text, vbTab & " ", " ")
            RichTextBox1.Text = Replace(RichTextBox1.Text, "=" & vbTab, "=")
            RichTextBox1.Text = Replace(RichTextBox1.Text, vbTab & "=", "=")
            RichTextBox1.Text = Replace(RichTextBox1.Text, "; ", ";" & vbTab)
            RichTextBox1.Text = Replace(RichTextBox1.Text, " //", vbTab & "//")
            RichTextBox1.Text = Replace(RichTextBox1.Text, vbTab & "=", "=")
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
            If arr(i).Contains("NTConfig_Script.push") = True Then temp = arr(i).Split(";") : MyScriptCheck(temp(0))
            If arr(i).Contains("= true") = True Or arr(i).Contains("= false") = True Then temp = arr(i).Split(";") : MyTorFCheck(temp(0))
        Next


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


    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        MessageBox.Show("Saving file - " & CharFile)
        RichTextBox1.SaveFile(CharFile, RichTextBoxStreamType.PlainText)
    End Sub


    Sub sorttabspacing() ' crappy attempt to even out tab spacings

        Dim arr = Split(RichTextBox1.Text, vbLf)

        For i = 0 To UBound(arr)

            If arr(i).Contains(";" & vbTab) = True Then
                Dim temp = arr(i).Split(";")
                Dim lefttext = temp(0)
                Dim righttext = temp(1).Replace(vbTab, "")
                Dim temp1 = temp(0).Replace(vbTab, "")
                Dim b As Decimal = (temp1.Length / 8)
                Dim a As Integer = (temp1.Length \ 8)
                If b > a Then a = a + 1
                If lefttext.Contains(vbTab & vbTab) = True Then a = a + 1
                Dim myText = temp(0) & ";"
                For index = a To 9
                    myText = myText & vbTab
                Next


                RichTextBox1.Text = Replace(RichTextBox1.Text, arr(i), myText & righttext)

            End If


        Next


    End Sub

    Private Sub ToolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub
End Class
