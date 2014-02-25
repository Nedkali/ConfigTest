Module Module1
    Public CharFile As String = ""


    Public myTextBox As TextBox()
    Public chkbox As CheckBox()


    Public script As List(Of String) = New List(Of String)

    Sub MySub(ByRef mystr, ByVal x) 'code helper

        Dim temp = mystr.Split("""")
        x = x + 1

        Form1.RichTextBox2.AppendText("If mystr.contains(" & Chr(34) & temp(1) & Chr(34) & ") = True And mystr.contains(" & Chr(34) & "//" & Chr(34) & ") = False Then Form1.CheckBox" & x & ".Checked = True : Return" & vbCrLf)




    End Sub

    Sub MyScriptCheck(ByRef mystr)
        Form1.RichTextBox2.AppendText(mystr & vbCrLf)
        If mystr.contains("ConfigCheck.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox1.Checked = True : Return
        If mystr.contains("NTCloneHunter.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox2.Checked = True : Return
        If mystr.contains("NTAuraStacking.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox3.Checked = True : Return
        If mystr.contains("NTLeechCows.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox4.Checked = True : Return
        If mystr.contains("NTTravLeech.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox5.Checked = True : Return
        If mystr.contains("NTUniversalDiabloLeech.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox6.Checked = True : Return
        If mystr.contains("NTUniversalBaalLeech.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox7.Checked = True : Return
        If mystr.contains("NTBloodMoor.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox8.Checked = True : Return
        If mystr.contains("NTColdPlains.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox9.Checked = True : Return
        If mystr.contains("NTBurialGrounds.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox10.Checked = True : Return
        If mystr.contains("NTStonyField.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox11.Checked = True : Return
        If mystr.contains("NTUndergroundPassage.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox12.Checked = True : Return
        If mystr.contains("NTDarkWood.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox13.Checked = True : Return
        If mystr.contains("NTBlackMarsh.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox14.Checked = True : Return
        If mystr.contains("NTTamoeHighland.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox15.Checked = True : Return
        If mystr.contains("NTOuterCloister.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox16.Checked = True : Return
        If mystr.contains("NTBarracks.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox17.Checked = True : Return
        If mystr.contains("NTJail.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox18.Checked = True : Return
        If mystr.contains("NTInnerCloister.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox19.Checked = True : Return
        If mystr.contains("NTCatacombs.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox20.Checked = True : Return
        If mystr.contains("NTMooMooFarm.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox21.Checked = True : Return
        If mystr.contains("NTSewersRad.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox22.Checked = True : Return
        If mystr.contains("NTRockyWaste.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox23.Checked = True : Return
        If mystr.contains("NTDryHills.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox24.Checked = True : Return
        If mystr.contains("NTFarOasis.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox25.Checked = True : Return
        If mystr.contains("NTLostCity.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox26.Checked = True : Return
        If mystr.contains("NTClawViperTemple.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox27.Checked = True : Return
        If mystr.contains("NTHaremToCellar.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox28.Checked = True : Return
        If mystr.contains("NTArcaneSanctuary.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox29.Checked = True : Return
        If mystr.contains("NTCanyonOfMagi.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox30.Checked = True : Return
        If mystr.contains("NTSpiderForest.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox31.Checked = True : Return
        If mystr.contains("NTGreatMarsh.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox32.Checked = True : Return
        If mystr.contains("NTFlayerJungle.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox33.Checked = True : Return
        If mystr.contains("NTLowerKurast.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox34.Checked = True : Return
        If mystr.contains("NTKurastBazaar.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox35.Checked = True : Return
        If mystr.contains("NTUpperKurast.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox36.Checked = True : Return
        If mystr.contains("NTTravincal.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox37.Checked = True : Return
        If mystr.contains("NTDuranceOfHate.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox38.Checked = True : Return
        If mystr.contains("NTOutterSteppes.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox39.Checked = True : Return
        If mystr.contains("NTPlainsOfDespair.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox40.Checked = True : Return
        If mystr.contains("NTCityOfDamned.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox41.Checked = True : Return
        If mystr.contains("NTRiverOfFlame.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox42.Checked = True : Return
        If mystr.contains("NTChaosSanctuary.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox43.Checked = True : Return
        If mystr.contains("NTBloodyFoothills.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox44.Checked = True : Return
        If mystr.contains("NTFrigidHighlands.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox45.Checked = True : Return
        If mystr.contains("NTArreatPlateau.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox46.Checked = True : Return
        If mystr.contains("NTCrystallinePassage.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox47.Checked = True : Return
        If mystr.contains("NTNihlathaksTemple.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox48.Checked = True : Return
        If mystr.contains("NTGlacialTrail.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox49.Checked = True : Return
        If mystr.contains("NTFrozenTundra.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox50.Checked = True : Return
        If mystr.contains("NTAncientsWay.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox51.Checked = True : Return
        If mystr.contains("NTWorldstoneKeep.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox52.Checked = True : Return
        If mystr.contains("NTWPGrabber.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox53.Checked = True : Return
        If mystr.contains("WpGiver.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox54.Checked = True : Return
        If mystr.contains("mulelogger.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox55.Checked = True : Return
        If mystr.contains("TLNipCheck.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox56.Checked = True : Return
        If mystr.contains("TLInventory.ntj") = True And mystr.contains("//") = False Then Form1.CheckBox57.Checked = True : Return




    End Sub





End Module
