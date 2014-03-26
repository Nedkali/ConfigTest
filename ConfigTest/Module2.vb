Module Module2

    ' this module will be deleted when app completed - just junk code

    Sub MySub(ByRef mystr, ByVal x) 'code helper didnt quite work the way i hoped lol far to exessive coding as result

        Dim temp = mystr.Split("""")
        x = x + 1

        ' Form1.RichTextBox2.AppendText("If mystr.contains(" & Chr(34) & temp(1) & Chr(34) & ") = True And mystr.contains(" & Chr(34) & "//" & Chr(34) & ") = False Then Form1.CheckBox" & x & ".Checked = True : Return" & vbCrLf)




    End Sub

    Sub MySub1() 'used for creating chkbox array

        Dim i As Integer
        Dim count As Integer = 0
        Dim count2 As Integer = 0

        Form2.RichTextBox1.Text = "cmbobox = {"


        For i = 1 To TorF.Length - 1

            Form2.RichTextBox1.AppendText("ComboBox" & i & ", ")

        Next

        Form2.RichTextBox1.AppendText("}" & vbCrLf)
    End Sub

    Sub MySub3() 'used for creating etalscripts array
        Dim arr() As String
        Dim i As Integer
        Dim temp() As String
        arr = Split(Form1.RichTextBox1.Text, vbLf)
        Form2.RichTextBox1.Text = "EtalScripts = {"
        For i = 0 To UBound(arr)

            If arr(i).Contains("NTConfig_Script.push") = True Then
                temp = arr(i).Split(";")
                Dim temp1 = temp(0).Split("""")
                Form2.RichTextBox1.AppendText(", " & Chr(34) & temp1(1) & Chr(34))
            End If
        Next
        Form2.RichTextBox1.AppendText("}" & vbCrLf)

    End Sub



    Sub MySub5() 'combine char files

        Dim myfile = "C:\Users\Mal\Desktop\Etal\D2NT\scripts\NTBot\char_configs\NTConfig_Amazon.ntl"

        Form2.RichTextBox1.LoadFile(myfile, RichTextBoxStreamType.PlainText)

        myfile = "C:\Users\Mal\Desktop\Etal\D2NT\scripts\NTBot\char_configs\NTConfig_Assassin.ntl"
        readfiles(myfile, "Assassin")

        myfile = "C:\Users\Mal\Desktop\Etal\D2NT\scripts\NTBot\char_configs\NTConfig_Barbarian.ntl"
        readfiles(myfile, "Barbarian")

        myfile = "C:\Users\Mal\Desktop\Etal\D2NT\scripts\NTBot\char_configs\NTConfig_Druid.ntl"
        readfiles(myfile, "Druid")

        myfile = "C:\Users\Mal\Desktop\Etal\D2NT\scripts\NTBot\char_configs\NTConfig_Necromancer.ntl"
        readfiles(myfile, "Necromancer")

        myfile = "C:\Users\Mal\Desktop\Etal\D2NT\scripts\NTBot\char_configs\NTConfig_Paladin.ntl"
        readfiles(myfile, "Paladin")

        myfile = "C:\Users\Mal\Desktop\Etal\D2NT\scripts\NTBot\char_configs\NTConfig_Sorceress.ntl"
        readfiles(myfile, "Sorceress")


    End Sub

    Sub readfiles(ByRef fname, ByVal chartype)
        Dim temp As String
        
        Form2.RichTextBox1.AppendText(vbCrLf & "//   " & chartype & vbCrLf & vbCrLf)
        Dim Reader = My.Computer.FileSystem.OpenTextFileReader(fname)
        Do
            If Reader.EndOfStream = True Then Exit Do
            temp = Reader.ReadLine()
            If Form2.RichTextBox1.Text.Contains(temp) = False Then Form2.RichTextBox1.AppendText(temp & vbCrLf)
        Loop


    End Sub

    Sub MySub6()
        Dim myfile = "C:\Users\Mal\Desktop\Etal\D2NT\scripts\NTBot\char_configs\NTConfig_Amazon.ntl"

        Form1.RichTextBox1.LoadFile(myfile, RichTextBoxStreamType.PlainText)
        Form1.RemoveSpaceErrors()
    End Sub

End Module
