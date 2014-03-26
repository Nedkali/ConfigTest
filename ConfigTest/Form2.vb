Imports System.Text.RegularExpressions

Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedoption = ComboBox300.SelectedItem

        Select Case selectedoption
            Case "NTConfig_Script.push"
                CreateArrayList1(NumericUpDown300.Value)
            Case "ComboBox"
                CreateArrayList2(NumericUpDown300.Value)
            Case "NumBox"
                CreateArrayList3(NumericUpDown300.Value)
        End Select

    End Sub
    Sub CreateArrayList1(linelength) 'used for creating script list array
        RichTextBox1.Clear()
        RichTextBox1.Text = "I'm here ready to process"
        Dim arr() As String
        Dim i As Integer
        Dim count As Integer = 0
        Dim temp() As String
        arr = Split(Form1.RichTextBox1.Text, vbLf)
        If arr.Length < 100 Then
            RichTextBox1.Text = "load a config file first"
            Return
        End If
        RichTextBox1.Text = "Public EtalScripts() As String = {"
        For i = 0 To UBound(arr)

            If arr(i).Contains("NTConfig_Script.push") = True Then

                temp = arr(i).Split(";")
                Dim temp1 = temp(0).Split("""")
                If count > 0 Then
                    RichTextBox1.AppendText(", ")
                End If
                RichTextBox1.AppendText(Chr(34) & temp1(1) & Chr(34))
                count = count + 1

                If count Mod linelength = 0 Then
                    RichTextBox1.AppendText(vbCrLf & vbTab & vbTab & vbTab)
                End If
            End If
        Next
        RichTextBox1.AppendText("}" & vbCrLf)

    End Sub
    Sub CreateArrayList2(linelength) 'used for creating ComboBox array
        RichTextBox1.Clear()
        Dim arr() As String
        Dim i As Integer
        Dim count As Integer = 0
        Dim temp() As String
        arr = Split(Form1.RichTextBox1.Text, vbLf)
        If arr.Length < 100 Then
            RichTextBox1.Text = "load a config file first"
            Return
        End If
        RichTextBox1.Text = "CBox = {"
        For i = 0 To UBound(arr)

            If arr(i).Contains("NTConfig_") = True Then

                temp = arr(i).Split(";")
                Dim temp1 = temp(0)

                If temp1.Contains("true") = True Or temp1.Contains("false") = True Then
                    If count > 0 Then
                        RichTextBox1.AppendText(", ")
                    End If
                    count = count + 1
                    RichTextBox1.AppendText("ComboBox" & count)
                    If count Mod linelength = 0 Then
                        RichTextBox1.AppendText(vbCrLf & vbTab & vbTab & vbTab)
                    End If
                End If

            End If
        Next
        RichTextBox1.AppendText("}" & vbCrLf)
    End Sub

    Sub CreateArrayList3(linelength) 'used for creating numBox array
        RichTextBox1.Clear()
        Dim arr() As String
        Dim i As Integer
        Dim count As Integer = 0
        Dim temp() As String
        arr = Split(Form1.RichTextBox1.Text, vbLf)
        If arr.Length < 100 Then
            RichTextBox1.Text = "load a config file first"
            Return
        End If
        RichTextBox1.Text = "NumBox = {"
        For i = 0 To UBound(arr)

            If arr(i).Contains("NTConfig_") = True Then
                temp = arr(i).Split(";")
                Dim temp1 = temp(0)
                temp1 = temp1.Replace(vbTab, "")
                'temp1 = temp1.Replace(" ", "")
                Dim temp2 = Regex.Replace(temp1, "[^0-9]", "")
                If IsNumeric(temp2) = True Then
                    If count > 0 Then
                        RichTextBox1.AppendText(", ")
                    End If
                    count = count + 1
                    RichTextBox1.AppendText("NumBox" & count)
                    If count Mod linelength = 0 Then
                        RichTextBox1.AppendText(vbCrLf & vbTab & vbTab & vbTab)
                    End If
                End If

            End If
        Next
        RichTextBox1.AppendText("}" & vbCrLf)
    End Sub
End Class