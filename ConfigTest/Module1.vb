Module Module1
    Public CharFile As String = ""


    Public myTextBox As TextBox()
    Public chkbox As CheckBox()
    Public cmbobox As ComboBox()

    Public EtalScripts() As String = {"ConfigCheck.ntj", "NTCloneHunter.ntj", "NTAuraStacking.ntj", "NTLeechCows.ntj", "NTTravLeech.ntj", "NTUniversalDiabloLeech.ntj",
                                      "NTUniversalBaalLeech.ntj", "NTBloodMoor.ntj", "NTColdPlains.ntj", "NTBurialGrounds.ntj", "NTStonyField.ntj", "NTUndergroundPassage.ntj",
                                      "NTDarkWood.ntj", "NTBlackMarsh.ntj", "NTTamoeHighland.ntj", "NTOuterCloister.ntj", "NTBarracks.ntj", "NTJail.ntj", "NTInnerCloister.ntj", "NTCatacombs.ntj",
                                      "NTMooMooFarm.ntj", "NTSewersRad.ntj", "NTRockyWaste.ntj", "NTDryHills.ntj", "NTFarOasis.ntj", "NTLostCity.ntj", "NTClawViperTemple.ntj", "NTHaremToCellar.ntj",
                                      "NTArcaneSanctuary.ntj", "NTCanyonOfMagi.ntj", "NTSpiderForest.ntj", "NTGreatMarsh.ntj", "NTFlayerJungle.ntj", "NTLowerKurast.ntj", "NTKurastBazaar.ntj",
                                      "NTUpperKurast.ntj", "NTTravincal.ntj", "NTDuranceOfHate.ntj", "NTOutterSteppes.ntj", "NTPlainsOfDespair.ntj", "NTCityOfDamned.ntj", "NTRiverOfFlame.ntj",
                                      "NTChaosSanctuary.ntj", "NTBloodyFoothills.ntj", "NTFrigidHighlands.ntj", "NTArreatPlateau.ntj", "NTCrystallinePassage.ntj", "NTNihlathaksTemple.ntj",
                                      "NTGlacialTrail.ntj", "NTFrozenTundra.ntj", "NTAncientsWay.ntj", "NTWorldstoneKeep.ntj", "NTWPGrabber.ntj", "WpGiver.ntj", "mulelogger.ntj", "TLNipCheck.ntj",
                                      "TLInventory.ntj", "NTTravLeader.ntj", "NTHelper.ntj"}

    Public TorF() As String = {"NTConfig_JustAHunter", "NTConfig_Announcer", "NTConfig_LogIt", "NTConfig_PartyOnlyLeader", "NTConfig_LeechBo", "NTConfig_UseChatCommandPortal",
                               "NTConfig_LeechPrecast", "NTConfig_TeleEachWaveHelper", "NTConfig_FollowtoWorldStone", "NTConfig_ClearAroundShrine", "NTConfig_LeechHolyBoltBaal", "NTConfig_LeechWalkAround",
                               "NTConfig_ClearBloodMoor", "NTConfig_DenOfEvil", "NTConfig_ClearDenTwice", "NTConfig_CPSpecialChest", "NTConfig_ClearPassageLevel2", "NTConfig_ClearAndarielThrone",
                               "NTConfig_RadSewerStairs", "NTConfig_WalkFromGohlein", "NTConfig_OpenSummonerChests", "NTConfig_LowerChests", "NTConfig_BazaarChests", "NTConfig_UpperChests",
                               "NTConfig_KillDuryCouncil", "NTConfig_KillMeph", "NTConfig_RedPortal", "NTConfig_Dodge", "NTConfig_FastChaos", "NTConfig_EvenFasterChaos", "NTConfig_Entrance",
                               "NTConfig_LeechSupport", "NTConfig_KillEldritch", "NTConfig_KillSharptooth", "NTConfig_KillEyeBack", "NTConfig_ArreatEvilUrn", "NTConfig_UseTemplePortal",
                               "NTConfig_KillPindleskin", "NTConfig_KillNihlathak", "NTConfig_CheckVipers", "NTConfig_MakeWSK3TP", "NTConfig_CheckSoulKillers", "NTConfig_MakeHotTP", "NTConfig_PreWaveTele",
                               "NTConfig_HolyBoltBaal", "NTConfig_WalkAround", "NTConfig_Wave2PSNCheck", "NTConfig_TownBeforeBaal", "NTConfig_KillBaal", "NTThrone_Announce",
                               "NTConfig_TLInventory_SkipEquipped", "NTConfig_HostileHandler", "RunFromHostiles", "KillHostiler", "TauntHostile", "NTConfig_UseStatPoints", "NTConfig_UseSkillPoints",
                               "NTConfig_MakeRunewords", "NTConfig_Cubing", "NTConfig_Gamble", "NTConfig_GC", "NTConfig_PublicMode", "NTConfig_CheckCloneDiablo", "NTConfig_FastPickit", "NTConfig_UseMerc",
                               "NTConfig_ResetEnigma", "NTConfig_ClearPosition", "NTConfig_PrioritizeWeakerFoes", "NTConfig_SwitchTele", "NTConfig_PreBuffFade", "NTConfig_StopIfStashInventoryFull",
                               "NTConfig_SkipRegularMonsters", "NTConfig_DropExtraRejuvs", "NTConfig_CheckPassword", "NTConfig_GoWestFromLut", "NTConfig_AutoMule", "NTConfig_FinishRun",
                               "NTConfig_UseKeysForPlaceHolder", "NTConfig_MercStats", "NTConfig_VoyageToMissingWps", "NTConfig_ChatRecording", "NTConfig_WhisperToManager", "NTConfig_UseXMLItemlog",
                               "NTConfig_IndependantLog", "NTConfig_LogSoldItems", "NTConfig_LogIgnoredItems", "NTConfig_LogCraftedItems", "NTConfig_LogShrines", "NTConfig_LogCraftingString",
                               "NTConfig_SkipSingle[0]", "NTConfig_SkipSingle[1]", "NTConfig_SkipSingle[2]", "NTConfig_SkipSingle[3]", "NTConfig_SkipSingle[4]", "NTConfig_SkipSingle[5]",
                               "NTConfig_SkipDual[0]", "NTConfig_SkipDual[1]", "NTConfig_SkipDual[2]", "NTConfig_SkipDual[3]", "NTConfig_SkipDual[4]", "NTConfig_SkipDual[5]", "NTConfig_SkipDual[6]",
                               "NTConfig_SkipDual[7]", "NTConfig_SkipDual[8]", "NTConfig_SkipDual[9]", "NTConfig_SkipDual[10]", "NTConfig_SkipDual[11]", "NTConfig_SkipDual[12]", "NTConfig_SkipDual[13]",
                               "NTConfig_SkipDual[14]", "NTConfig_IdInField", "NTConfig_AnnounceDroppedItems", "NTConfig_IdentAtCain", "NTConfig_AlwaysUseCain", "NTConfig_DropCainItems", "DPSMeter",
                               "miniDPSDisplay", "NTConfig_OpenChest", "NTConfig_CheckChestid", "NTConfig_OpenChestsInAreaClearing", "NTConfig_ShareExpShrine", "NTconfig_HighMaxAttack",
                               "NTConfig_AttackingThis", "NTConfig_OnlySmiteStationary"}

    Sub Textboxfill(ByVal mystring, ByVal x)

        Dim temp = mystring.Split("""")
        myTextBox(x).Text = temp(1)

    End Sub

    Sub MyScriptCheck(ByRef mystr) ' for filling enable checkboxes

        Dim temp = mystr.Split("""")

        For index = 0 To EtalScripts.Length - 1
            If EtalScripts(index) = temp(1) And mystr.contains("//") = False Then
                chkbox(index).Checked = True
                Exit For
            End If
        Next


    End Sub

    Sub MyTorFCheck(ByRef mystr) ' for filling enable checkboxes

        Dim temp = mystr.Split(";")
        Dim temp1 = temp(0).Split("= ")
        Dim str2 = Replace(temp1(0), vbTab, "")
        str2 = RTrim(str2)

        For index = 0 To 11 'TorF.Length - 1
            If TorF(index) = str2 Then
                If temp1(1) = " true" Then cmbobox(index).SelectedIndex = 0 : Exit For
                If temp1(1) = " false" Then cmbobox(index).SelectedIndex = 1 : Exit For

                Form2.RichTextBox1.AppendText(temp1(1) & vbCrLf)
            End If
        Next

    End Sub

    Sub FixSimpleErrors()
        Form2.RichTextBox1.Clear()
        Dim arr() As String
        arr = Split(Form1.RichTextBox1.Text, vbLf)
        For i = 0 To UBound(arr)

            If LCase(arr(i)).Contains("= true") = True And arr(i).Contains("= true") = False Then
                Dim temp = arr(i).Split(";")
                Dim temp1 = temp(0).Split("= ")
                Form1.RichTextBox1.Text = Replace(Form1.RichTextBox1.Text, temp1(1), " true")
                Form2.RichTextBox1.AppendText("correction on line " & i + 1)
            End If

            If LCase(arr(i)).Contains("= false") = True And arr(i).Contains("= false") = False Then
                Dim temp = arr(i).Split(";")
                Dim temp1 = temp(0).Split("= ")
                Form1.RichTextBox1.Text = Replace(Form1.RichTextBox1.Text, temp1(1), " false")
                Form2.RichTextBox1.AppendText("correction on line " & i + 1)
            End If



        Next


    End Sub



End Module
