using UnityEngine;
public static class AvatarTitleUnlockChecker
{
    // Methods
    public static NewUnlocks CheckUnlocks_Adventure(CharacterNameID charID, bool victorious, bool resetPrevResult = True)
    {
        DataStructs.Items val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_35;
        var val_36;
        Titles_Common_Key val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        val_23 = resetPrevResult;
        if(val_23 != false)
        {
                NewUnlocks.ResetNewUnlockData(charID:  charID);
        }
        
        if(victorious == false)
        {
            goto label_113;
        }
        
        val_24 = null;
        val_24 = null;
        if(Character_GlobalInfo.gameMode == 2)
        {
                val_25 = null;
            val_25 = null;
            val_23 = DataStructs.UserDataDictionary.Items;
            val_23.SetAvatarUnlocked(key:  2, characterId:  charID, isUnlock:  true);
        }
        
        CharacterClan val_1 = CharNameIDConverter.GetClan(nameID:  charID);
        if(val_1 == 2)
        {
            goto label_13;
        }
        
        if(val_1 == 1)
        {
            goto label_14;
        }
        
        if(val_1 != 0)
        {
            goto label_36;
        }
        
        val_26 = null;
        val_26 = null;
        if((Character_GlobalInfo.gameMode - 1) < 2)
        {
            goto label_18;
        }
        
        if(Character_GlobalInfo.gameMode == 3)
        {
            goto label_19;
        }
        
        if(Character_GlobalInfo.gameMode != 4)
        {
            goto label_36;
        }
        
        val_27 = 10;
        goto label_48;
        label_13:
        val_28 = null;
        val_28 = null;
        if((Character_GlobalInfo.gameMode - 1) < 2)
        {
            goto label_27;
        }
        
        if(Character_GlobalInfo.gameMode == 3)
        {
            goto label_28;
        }
        
        if(Character_GlobalInfo.gameMode != 4)
        {
            goto label_36;
        }
        
        val_27 = 14;
        goto label_48;
        label_14:
        val_29 = null;
        val_29 = null;
        if((Character_GlobalInfo.gameMode - 1) < 2)
        {
            goto label_34;
        }
        
        if(Character_GlobalInfo.gameMode == 3)
        {
            goto label_35;
        }
        
        if(Character_GlobalInfo.gameMode != 4)
        {
            goto label_36;
        }
        
        val_27 = 6;
        goto label_48;
        label_18:
        val_27 = 8;
        goto label_48;
        label_27:
        val_27 = 12;
        goto label_48;
        label_34:
        val_27 = 4;
        goto label_48;
        label_35:
        val_27 = 5;
        goto label_48;
        label_19:
        val_27 = 9;
        goto label_48;
        label_28:
        val_27 = 13;
        label_48:
        DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(key:  13, isUnlock:  true);
        label_36:
        val_30 = null;
        val_30 = null;
        GameMode val_23 = Character_GlobalInfo.gameMode;
        val_23 = val_23 - 1;
        if(val_23 > 3)
        {
            goto label_79;
        }
        
        var val_24 = 40829652 + ((Character_GlobalInfo.gameMode - 1)) << 2;
        val_24 = val_24 + 40829652;
        goto (40829652 + ((Character_GlobalInfo.gameMode - 1)) << 2 + 40829652);
        label_79:
        val_35 = null;
        val_35 = null;
        if((Character_GlobalInfo.gameMode - 1) < 2)
        {
            goto label_83;
        }
        
        if(Character_GlobalInfo.gameMode == 3)
        {
            goto label_84;
        }
        
        if(Character_GlobalInfo.gameMode != 4)
        {
            goto label_113;
        }
        
        CharacterClan val_14 = CharNameIDConverter.GetClan(nameID:  charID);
        if(val_14 == 1)
        {
            goto label_86;
        }
        
        if(val_14 != 0)
        {
            goto label_113;
        }
        
        val_36 = null;
        val_36 = null;
        if((DataStructs.UserDataDictionary.GameSave.GetUniqueGameModePlayed(mode:  2, clan:  0).Count) < 8)
        {
            goto label_113;
        }
        
        val_37 = 8;
        goto label_108;
        label_83:
        val_38 = null;
        val_38 = null;
        val_23 = DataStructs.UserDataDictionary.GameSave;
        if((val_23.GetAdventureProgressByID(cid:  charID).GetPassedLevelCount(mode:  0)) < 8)
        {
            goto label_113;
        }
        
        val_37 = 5;
        goto label_108;
        label_84:
        val_39 = null;
        val_39 = null;
        if((DataStructs.UserDataDictionary.GameSave.GetUniqueGameModePlayed(mode:  1).Count) < 8)
        {
            goto label_113;
        }
        
        val_37 = 6;
        goto label_108;
        label_86:
        val_40 = null;
        val_40 = null;
        if((DataStructs.UserDataDictionary.GameSave.GetUniqueGameModePlayed(mode:  2, clan:  1).Count) < 8)
        {
            goto label_113;
        }
        
        val_37 = 7;
        label_108:
        DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  val_37, isUnlock:  true);
        label_113:
        val_41 = null;
        val_41 = null;
        return (NewUnlocks)NewUnlocks.NewUnlocksThisCheck;
    }
    public static NewUnlocks CheckUnlocks_PVP_Local(InkWars.Model.GameResult result, bool resetPrevResult = True)
    {
        var val_9;
        var val_10;
        var val_11;
        Titles_Common_Key val_12;
        var val_13;
        val_9 = null;
        val_9 = null;
        if(resetPrevResult != false)
        {
                NewUnlocks.ResetNewUnlockData(charID:  63);
            val_9 = null;
        }
        
        val_9 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Stats.LocalPvPMatches;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited})) >= 1)
        {
                DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(key:  16, isUnlock:  true);
        }
        
        val_10 = null;
        val_10 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Stats.LocalPvPMatches;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited})) >= 4)
        {
                DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  11, isUnlock:  true);
        }
        
        val_11 = null;
        val_11 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Stats.LocalPvPMatches;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited})) >= 8)
        {
                DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  12, isUnlock:  true);
        }
        
        if((result - 4) < 2)
        {
            goto label_27;
        }
        
        if(result == 3)
        {
            goto label_28;
        }
        
        if(result != 6)
        {
            goto label_29;
        }
        
        DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  13, isUnlock:  true);
        label_27:
        val_12 = 15;
        goto label_32;
        label_28:
        val_12 = 14;
        label_32:
        DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  val_12, isUnlock:  true);
        label_29:
        InkWars.Model.Model_Manager val_8 = InkWars.Model.Model_Manager.Instance;
        if(val_8.Model.InkEmUp_CurrentPhase != 0)
        {
                DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  16, isUnlock:  true);
        }
        
        val_13 = null;
        val_13 = null;
        return (NewUnlocks)NewUnlocks.NewUnlocksThisCheck;
    }
    public static NewUnlocks CheckUnlocks_PVP_NetworkRanked(CharacterNameID charID, CharacterNameID opponentCharID, string opponentPlayerID, InkWars.Model.GameResult result, bool resetPrevResult = True)
    {
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        InkWars.Model.Model_Core val_44;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        val_39 = null;
        val_39 = null;
        if(resetPrevResult != false)
        {
                NewUnlocks.ResetNewUnlockData(charID:  charID);
            val_39 = null;
        }
        
        val_39 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Stats.NetworkPvPMatchesPlayed;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited})) >= 1)
        {
                DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  28, isUnlock:  true);
        }
        
        if((DataStructs.UserDataDictionary.Items.GetTitleUnlocked(key:  32)) != true)
        {
                val_40 = null;
            val_40 = null;
            if((DataStructs.UserDataDictionary.Stats.HasPlayedWithPlayer(userId:  opponentPlayerID)) != true)
        {
                val_41 = null;
            val_41 = null;
            DataStructs.UserDataDictionary.Stats.SetPlayedWithPlayer(userId:  opponentPlayerID);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Stats.GetUniquePlayerCount();
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited})) >= 10)
        {
                DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  32, isUnlock:  true);
        }
        
        }
        
        }
        
        if(RankingController.NewRank == 3)
        {
                DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  29, isUnlock:  true);
        }
        
        val_42 = null;
        val_42 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = DataStructs.UserDataDictionary.Stats.CurrentCharacterBP;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_7.fakeValue, inited = val_7.inited})) >= 888)
        {
                DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(key:  6, characterId:  charID, isUnlock:  true);
        }
        
        val_43 = null;
        val_43 = null;
        val_44 = DataStructs.UserDataDictionary.Stats.GetHighestRank();
        if(val_44.BPRank >= 16)
        {
                DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(key:  22, isUnlock:  true);
        }
        
        if((result - 1) <= 5)
        {
                var val_39 = 40829668 + ((result - 1)) << 2;
            val_39 = val_39 + 40829668;
        }
        else
        {
                val_54 = null;
            val_54 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_27 = DataStructs.UserDataDictionary.Stats.WinStreak_Current;
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_27.currentCryptoKey, hiddenValue = val_27.hiddenValue, fakeValue = val_27.fakeValue, inited = val_27.inited})) >= 5)
        {
                DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  43, isUnlock:  true);
        }
        
            val_55 = null;
            val_55 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_29 = DataStructs.UserDataDictionary.Stats.WinStreak_Current;
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_29.currentCryptoKey, hiddenValue = val_29.hiddenValue, fakeValue = val_29.fakeValue, inited = val_29.inited})) >= 10)
        {
                DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  44, isUnlock:  true);
        }
        
            val_56 = null;
            val_56 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_31 = DataStructs.UserDataDictionary.Stats.WinStreak_Current;
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_31.currentCryptoKey, hiddenValue = val_31.hiddenValue, fakeValue = val_31.fakeValue, inited = val_31.inited})) >= 20)
        {
                DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  45, isUnlock:  true);
        }
        
            val_57 = null;
            val_57 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_33 = DataStructs.UserDataDictionary.Stats.WinStreak_Current;
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_33.currentCryptoKey, hiddenValue = val_33.hiddenValue, fakeValue = val_33.fakeValue, inited = val_33.inited})) >= 30)
        {
                DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  46, isUnlock:  true);
        }
        
            val_58 = null;
            val_58 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_35 = DataStructs.UserDataDictionary.Stats.NetworkDraws;
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_35.currentCryptoKey, hiddenValue = val_35.hiddenValue, fakeValue = val_35.fakeValue, inited = val_35.inited})) >= 8)
        {
                DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(key:  4, characterId:  charID, isUnlock:  true);
        }
        
            val_59 = null;
            val_59 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_37 = DataStructs.UserDataDictionary.Stats.NetworkDraws;
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_37.currentCryptoKey, hiddenValue = val_37.hiddenValue, fakeValue = val_37.fakeValue, inited = val_37.inited})) >= 80)
        {
                DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(key:  5, characterId:  charID, isUnlock:  true);
        }
        
            val_60 = null;
            val_60 = null;
            return (NewUnlocks)NewUnlocks.NewUnlocksThisCheck;
        }
    
    }
    public static void UnlockCharacterDefaults(CharacterNameID charID)
    {
        var val_1;
        NewUnlocks.ResetNewUnlockData(charID:  charID);
        AvatarTitleUnlockChecker.SetDefaults_SpecificAvatars_Single(cid:  charID);
        AvatarTitleUnlockChecker.SetDefaults_SpecificTitles_Single(cid:  charID);
        if(charID != 34)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(key:  11, isUnlock:  true);
    }
    public static void SetDefaultUnlocks()
    {
        AvatarTitleUnlockChecker.SetDefaults_SpecificAvatars();
        AvatarTitleUnlockChecker.SetDefaults_CommonAvatars();
        AvatarTitleUnlockChecker.SetDefaults_SpecificTitles();
        AvatarTitleUnlockChecker.SetDefaults_CommonTitles();
    }
    public static void SetDefaults_SpecificAvatars()
    {
        var val_17;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        val_17 = 1152921505065684992;
        label_22:
        var val_19 = 0;
        val_19 = val_19 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_20 = 0;
        val_20 = val_20 + 1;
        object val_7 = val_3.Current;
        if(null == 999999)
        {
            goto label_22;
        }
        
        val_20 = null;
        val_20 = null;
        if((DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  1152921504628039680)) == true)
        {
            goto label_22;
        }
        
        AvatarTitleUnlockChecker.SetDefaults_SpecificAvatars_Single(cid:  1152921504628039680);
        goto label_22;
        label_11:
        val_21 = 0;
        val_22 = 1152921504621170688;
        val_23 = val_3;
        if(val_23 != null)
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            val_23.Dispose();
        }
        
        if( == false)
        {
                return;
        }
        
        val_23 = ???;
        val_22 = ???;
        val_17 = ???;
    }
    public static void SetDefaults_SpecificAvatars_Single(CharacterNameID cid)
    {
        null = null;
        if(DataStructs.UserDataDictionary.Items != null)
        {
                DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(key:  1, characterId:  cid, isUnlock:  true);
        }
        else
        {
                0.SetAvatarUnlocked(key:  1, characterId:  cid, isUnlock:  true);
        }
        
        DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(key:  3, characterId:  cid, isUnlock:  true);
    }
    public static void SetDefaults_CommonAvatars()
    {
        null = null;
        if(DataStructs.UserDataDictionary.Items != null)
        {
                DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(key:  1, isUnlock:  true);
            DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(key:  2, isUnlock:  true);
            DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(key:  3, isUnlock:  true);
            DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(key:  7, isUnlock:  true);
            DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(key:  15, isUnlock:  true);
        }
        else
        {
                0.SetAvatarUnlocked(key:  1, isUnlock:  true);
            0.SetAvatarUnlocked(key:  2, isUnlock:  true);
            0.SetAvatarUnlocked(key:  3, isUnlock:  true);
            0.SetAvatarUnlocked(key:  7, isUnlock:  true);
            0.SetAvatarUnlocked(key:  15, isUnlock:  true);
        }
        
        DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(key:  19, isUnlock:  true);
    }
    public static void SetDefaults_SpecificTitles()
    {
        var val_17;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        val_17 = 1152921505065684992;
        label_22:
        var val_19 = 0;
        val_19 = val_19 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_20 = 0;
        val_20 = val_20 + 1;
        object val_7 = val_3.Current;
        if(null == 999999)
        {
            goto label_22;
        }
        
        val_20 = null;
        val_20 = null;
        if((DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  1152921504628039680)) == true)
        {
            goto label_22;
        }
        
        AvatarTitleUnlockChecker.SetDefaults_SpecificTitles_Single(cid:  1152921504628039680);
        goto label_22;
        label_11:
        val_21 = 0;
        val_22 = 1152921504621170688;
        val_23 = val_3;
        if(val_23 != null)
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            val_23.Dispose();
        }
        
        if( == false)
        {
                return;
        }
        
        val_23 = ???;
        val_22 = ???;
        val_17 = ???;
    }
    public static void SetDefaults_SpecificTitles_Single(CharacterNameID cid)
    {
        null = null;
        if(DataStructs.UserDataDictionary.Items != null)
        {
                DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  1, characterId:  cid, isUnlock:  true);
        }
        else
        {
                0.SetTitleUnlocked(key:  1, characterId:  cid, isUnlock:  true);
        }
        
        DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  2, characterId:  cid, isUnlock:  true);
    }
    public static void SetDefaults_CommonTitles()
    {
        null = null;
        if(DataStructs.UserDataDictionary.Items != null)
        {
                DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  1, isUnlock:  true);
            DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  2, isUnlock:  true);
            DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  3, isUnlock:  true);
            DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  4, isUnlock:  true);
            DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  9, isUnlock:  true);
            DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  10, isUnlock:  true);
            DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  17, isUnlock:  true);
            DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  18, isUnlock:  true);
            DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  25, isUnlock:  true);
        }
        else
        {
                0.SetTitleUnlocked(key:  1, isUnlock:  true);
            0.SetTitleUnlocked(key:  2, isUnlock:  true);
            0.SetTitleUnlocked(key:  3, isUnlock:  true);
            0.SetTitleUnlocked(key:  4, isUnlock:  true);
            0.SetTitleUnlocked(key:  9, isUnlock:  true);
            0.SetTitleUnlocked(key:  10, isUnlock:  true);
            0.SetTitleUnlocked(key:  17, isUnlock:  true);
            0.SetTitleUnlocked(key:  18, isUnlock:  true);
            0.SetTitleUnlocked(key:  25, isUnlock:  true);
        }
        
        DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  26, isUnlock:  true);
    }
    public static void SetUnlockAllAvaratAndTitle(bool isUnlock)
    {
        var val_47;
        var val_48;
        var val_51;
        var val_52;
        var val_54;
        var val_57;
        var val_58;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_67;
        var val_70;
        var val_71;
        var val_74;
        var val_77;
        var val_78;
        val_48 = null;
        val_48 = null;
        System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_20:
        var val_56 = 0;
        val_56 = val_56 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_13;
        }
        
        var val_57 = 0;
        val_57 = val_57 + 1;
        object val_7 = val_3.Current;
        DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(key:  1152921504628039680, isUnlock:  isUnlock);
        goto label_20;
        label_13:
        val_51 = 0;
        val_52 = 0;
        if(val_3 != null)
        {
                var val_58 = 0;
            val_58 = val_58 + 1;
            val_3.Dispose();
        }
        
        if( != 1)
        {
                var val_10 = (76 == 76) ? 1 : 0;
            val_10 = (( >= 0) ? 1 : 0) & val_10;
            val_54 =  - val_10;
        }
        else
        {
                val_54 = 0;
        }
        
        System.Collections.IEnumerator val_14 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_51:
        var val_59 = 0;
        val_59 = val_59 + 1;
        if(val_14.MoveNext() == false)
        {
            goto label_44;
        }
        
        var val_60 = 0;
        val_60 = val_60 + 1;
        object val_18 = val_14.Current;
        DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  1152921504628039680, isUnlock:  isUnlock);
        goto label_51;
        label_44:
        var val_20 = 0 + 1;
        mem2[0] = 148;
        val_57 = 1152921504618827776;
        val_58 = 0;
        if(val_14 != null)
        {
                var val_61 = 0;
            val_61 = val_61 + 1;
            val_14.Dispose();
        }
        
        if(val_20 != 1)
        {
                var val_22 = ((1152921528254101216 + ((0 + 1)) << 2) == 148) ? 1 : 0;
            val_22 = ((val_20 >= 0) ? 1 : 0) & val_22;
            val_60 = val_20 - val_22;
        }
        else
        {
                val_60 = 0;
        }
        
        val_61 = 1152921505065684992;
        val_62 = 1152921505093693440;
        val_63 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        goto label_137;
        label_143:
        var val_62 = 0;
        val_62 = val_62 + 1;
        object val_28 = val_63.Current;
        if(null == 999999)
        {
            goto label_137;
        }
        
        System.Collections.IEnumerator val_31 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_94:
        var val_63 = 0;
        val_63 = val_63 + 1;
        if(val_31.MoveNext() == false)
        {
            goto label_87;
        }
        
        var val_64 = 0;
        val_64 = val_64 + 1;
        object val_35 = val_31.Current;
        DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(key:  1152921504628039680, characterId:  1152921504628039680, isUnlock:  isUnlock);
        goto label_94;
        label_87:
        val_67 = 0;
        mem[80] = 277;
        if(val_31 != null)
        {
                var val_65 = 0;
            val_65 = val_65 + 1;
            val_31.Dispose();
        }
        
        if(1 != 1)
        {
                var val_38 = (mem[80] == 277) ? 1 : 0;
            val_38 = ((1 >= 0) ? 1 : 0) & val_38;
            val_70 = 1 - val_38;
        }
        else
        {
                val_70 = 0;
        }
        
        val_71 = 1152921504621170688;
        System.Collections.IEnumerator val_42 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_125:
        var val_66 = 0;
        val_66 = val_66 + 1;
        if(val_42.MoveNext() == false)
        {
            goto label_118;
        }
        
        var val_67 = 0;
        val_67 = val_67 + 1;
        object val_46 = val_42.Current;
        DataStructs.UserDataDictionary.Items.SetTitleUnlocked(key:  1152921504628039680, characterId:  1152921504628039680, isUnlock:  isUnlock);
        goto label_125;
        label_118:
        var val_68 = val_70;
        val_74 = 0;
        val_68 = val_68 + 1;
        mem2[0] = 355;
        if(val_42 != null)
        {
                var val_69 = 0;
            val_69 = val_69 + 1;
            val_42.Dispose();
        }
        
        val_62 = 1152921505093693440;
        val_60 = 0;
        if(val_68 != 1)
        {
                var val_49 = ((76 + ((val_70 + 1)) << 2) == 355) ? 1 : 0;
            val_49 = ((val_68 >= 0) ? 1 : 0) & val_49;
            val_60 = val_68 - val_49;
        }
        
        label_137:
        var val_70 = 0;
        val_70 = val_70 + 1;
        if(val_63.MoveNext() == true)
        {
            goto label_143;
        }
        
        var val_53 = val_60 + 1;
        mem2[0] = 385;
        val_77 = 1152921504621170688;
        val_78 = 0;
        if(val_63 != null)
        {
                var val_71 = 0;
            val_71 = val_71 + 1;
            val_63.Dispose();
        }
        
        if( != false)
        {
                val_47 = ???;
            val_78 = ???;
            val_63 = ???;
            val_62 = ???;
            val_77 = ???;
            val_61 = ???;
        }
        
        var val_55 = val_47 - 80;
    }
    public static void UnlockAll()
    {
        AvatarTitleUnlockChecker.SetUnlockAllAvaratAndTitle(isUnlock:  true);
    }
    public static void LockAll()
    {
        AvatarTitleUnlockChecker.SetUnlockAllAvaratAndTitle(isUnlock:  false);
    }

}
