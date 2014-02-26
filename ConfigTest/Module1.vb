Module Module1
    Public CharFile As String = ""


    Public myTextBox As TextBox()
    Public chkbox As CheckBox()
    Public EtalScripts() As String = {"ConfigCheck.ntj", "NTCloneHunter.ntj", "NTAuraStacking.ntj", "NTLeechCows.ntj", "NTTravLeech.ntj", "NTUniversalDiabloLeech.ntj",
                                      "NTUniversalBaalLeech.ntj", "NTHelper.ntj", "NTBloodMoor.ntj", "NTColdPlains.ntj", "NTBurialGrounds.ntj", "NTStonyField.ntj", "NTUndergroundPassage.ntj",
                                      "NTDarkWood.ntj", "NTBlackMarsh.ntj", "NTTamoeHighland.ntj", "NTOuterCloister.ntj", "NTBarracks.ntj", "NTJail.ntj", "NTInnerCloister.ntj", "NTCatacombs.ntj",
                                      "NTMooMooFarm.ntj", "NTSewersRad.ntj", "NTRockyWaste.ntj", "NTDryHills.ntj", "NTFarOasis.ntj", "NTLostCity.ntj", "NTClawViperTemple.ntj", "NTHaremToCellar.ntj",
                                      "NTArcaneSanctuary.ntj", "NTCanyonOfMagi.ntj", "NTSpiderForest.ntj", "NTGreatMarsh.ntj", "NTFlayerJungle.ntj", "NTLowerKurast.ntj", "NTKurastBazaar.ntj",
                                      "NTUpperKurast.ntj", "NTTravincal.ntj", "NTDuranceOfHate.ntj", "NTOutterSteppes.ntj", "NTPlainsOfDespair.ntj", "NTCityOfDamned.ntj", "NTRiverOfFlame.ntj",
                                      "NTChaosSanctuary.ntj", "NTBloodyFoothills.ntj", "NTFrigidHighlands.ntj", "NTArreatPlateau.ntj", "NTCrystallinePassage.ntj", "NTNihlathaksTemple.ntj",
                                      "NTGlacialTrail.ntj", "NTFrozenTundra.ntj", "NTAncientsWay.ntj", "NTWorldstoneKeep.ntj", "NTWPGrabber.ntj", "WpGiver.ntj", "mulelogger.ntj", "TLNipCheck.ntj",
                                      "TLInventory.ntj", "NTTravLeader.ntj"}




    Sub MySub(ByRef mystr, ByVal x) 'code helper

        Dim temp = mystr.Split("""")
        x = x + 1

        ' Form1.RichTextBox2.AppendText("If mystr.contains(" & Chr(34) & temp(1) & Chr(34) & ") = True And mystr.contains(" & Chr(34) & "//" & Chr(34) & ") = False Then Form1.CheckBox" & x & ".Checked = True : Return" & vbCrLf)




    End Sub

    Sub MySub1()

        Dim i As Integer
        Dim count As Integer = 0
        Dim count2 As Integer = 0

        Form1.RichTextBox2.Text = "chkbox = {"


        For i = 1 To 52

            Form1.RichTextBox2.AppendText("checkbox" & i & ", ")

        Next

        Form1.RichTextBox2.AppendText("}" & vbCrLf)
    End Sub
    Sub MySub3()
        Dim arr() As String
        Dim i As Integer
        Dim temp() As String
        arr = Split(Form1.RichTextBox1.Text, vbLf)
        Form1.RichTextBox2.Text = "EtalScripts = {"
        For i = 0 To UBound(arr)

            If arr(i).Contains("NTConfig_Script.push") = True Then
                temp = arr(i).Split(";")
                Dim temp1 = temp(0).Split("""")
                Form1.RichTextBox2.AppendText(", " & Chr(34) & temp1(1) & Chr(34))
            End If
        Next
        Form1.RichTextBox2.AppendText("}" & vbCrLf)

    End Sub


    Sub MyScriptCheck(ByRef mystr)

        Dim temp = mystr.Split("""")

        For index = 0 To EtalScripts.Length - 1
            If EtalScripts(index) = temp(1) And mystr.contains("//") = False Then
                chkbox(index).Checked = True
                ' Form1.RichTextBox2.AppendText(mystr & " " & index & " " & chkbox(index).Name & vbCrLf)
                Exit For
            End If
        Next


    End Sub





End Module
