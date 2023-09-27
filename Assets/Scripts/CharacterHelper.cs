using UnityEngine;
public static class CharacterHelper
{
    // Fields
    public static CharacterNameID[] showingCharacters;
    public static CharacterNameID[] hiddenCharacters;
    public static UnityEngine.Events.UnityEvent OnCelebLockStateChanged;
    
    // Methods
    public static string GetLocalizedClanAndName(CharacterNameID cid)
    {
        CharacterData val_1 = CharacterDataManager.Get(id:  cid);
        System.Globalization.CultureInfo val_2 = new System.Globalization.CultureInfo(name:  "en-US", useUserOverride:  false);
        if(val_2 != null)
        {
                return val_2.ToTitleCase(str:  System.String.Format(format:  "{0} {1}", arg0:  val_1.localizedText.clan, arg1:  val_1.localizedText.name).ToLower());
        }
        
        return val_2.ToTitleCase(str:  System.String.Format(format:  "{0} {1}", arg0:  val_1.localizedText.clan, arg1:  val_1.localizedText.name).ToLower());
    }
    public static UnityEngine.RectTransform GetUnlockButtonPrefab(CharacterNameID id)
    {
        if(0 == (CharacterDataManager.Get(id:  id)))
        {
                return (UnityEngine.RectTransform)UnityEngine.Resources.Load<UnityEngine.RectTransform>(path:  null);
        }
        
        0 = 0;
        if(val_1.unlockType > 8)
        {
                return (UnityEngine.RectTransform)UnityEngine.Resources.Load<UnityEngine.RectTransform>(path:  null);
        }
        
        var val_4 = 40837444 + (val_1.unlockType) << 2;
        val_4 = val_4 + 40837444;
        goto (40837444 + (val_1.unlockType) << 2 + 40837444);
    }
    public static int GetMinBubbleCountForInkSequence(CharacterNameID winnerId)
    {
        var val_2;
        CharacterNameID val_6;
        var val_7;
        val_6 = winnerId;
        CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
        if(val_2 == 40)
        {
            goto label_3;
        }
        
        CharacterInfo val_3 = Character_GlobalInfo.GetOpponentPlayer();
        if(val_2 != 40)
        {
            goto label_6;
        }
        
        label_3:
        val_7 = 0;
        return 20;
        label_6:
        val_6 = CharacterDataManager.Get(id:  val_6);
        if(0 != val_6)
        {
                val_6 = val_4.status;
            int val_6 = val_4.status.defence;
            val_6 = val_6 - 1;
            if(val_6 <= 3)
        {
                val_7 = mem[40838088 + ((val_4.status.defence - 1)) << 2];
            val_7 = 40838088 + ((val_4.status.defence - 1)) << 2;
            return 20;
        }
        
        }
        
        val_7 = 20;
        return 20;
    }
    public static CharacterNameID GetStageCPUCharacterId(int levelId0to11, CharacterClan CPUClan)
    {
        int val_7;
        var val_8;
        CharacterNameID val_9;
        val_7 = levelId0to11;
        .CPUClan = CPUClan;
        val_8 = null;
        val_8 = null;
        val_9 = 983040;
        val_9 = 15;
        if((GameInfo.stage.GetStageDataByLevelId(levelId:  val_7)) == null)
        {
                return val_9;
        }
        
        .stageId = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = GameInfo.stage, hiddenValue = GameInfo.stage, fakeValue = val_7, inited = val_7});
        System.Predicate<CharacterData> val_4 = null;
        val_7 = val_4;
        val_4 = new System.Predicate<CharacterData>(object:  new CharacterHelper.<>c__DisplayClass3_0(), method:  System.Boolean CharacterHelper.<>c__DisplayClass3_0::<GetStageCPUCharacterId>b__0(CharacterData x));
        if(0 == (CharacterDataManager.Find(match:  val_4)))
        {
                return val_9;
        }
        
        val_9 = val_5.characterId;
        return val_9;
    }
    public static float GetAttackSpeed(CharacterNameID cid)
    {
        CharacterData val_3 = CharacterDataManager.Get(id:  cid);
        if(0 == val_3)
        {
                return 1.3f;
        }
        
        val_3 = val_1.status;
        int val_3 = val_1.status.speed;
        val_3 = val_3 - 1;
        if(val_3 > 3)
        {
                return 1.3f;
        }
        
        return 1.3f;
    }
    public static float GetStunTime(CharacterNameID cid)
    {
        CharacterData val_3 = CharacterDataManager.Get(id:  cid);
        if(0 == val_3)
        {
                return 0.3f;
        }
        
        val_3 = val_1.status;
        int val_3 = val_1.status.attack;
        val_3 = val_3 - 2;
        if(val_3 > 2)
        {
                return 0.3f;
        }
        
        return 0.3f;
    }
    public static int GetRainbowPercentageLevel(CharacterNameID cid)
    {
        UnityEngine.Object val_3;
        int val_4;
        val_3 = CharacterDataManager.Get(id:  cid);
        if(0 == val_3)
        {
                val_4 = 0;
            return val_4;
        }
        
        val_3 = val_1.status;
        val_4 = val_1.status.attack;
        return val_4;
    }
    public static float GetSecondaryAttackPercent(CharacterNameID cid)
    {
        CharacterData val_3 = CharacterDataManager.Get(id:  cid);
        if(0 == val_3)
        {
                return 36f;
        }
        
        val_3 = val_1.status;
        int val_3 = val_1.status.attack;
        val_3 = val_3 - 1;
        if(val_3 > 3)
        {
                return 36f;
        }
        
        return 36f;
    }
    public static bool IsHidden(CharacterNameID cid)
    {
        CharacterNameID val_9;
        var val_10;
        CharacterNameID[] val_11;
        var val_12;
        var val_13;
        val_9 = cid;
        if(val_9 < 27)
        {
            goto label_1;
        }
        
        System.Collections.Generic.List<CharacterNameID> val_1 = new System.Collections.Generic.List<CharacterNameID>();
        val_10 = null;
        val_10 = null;
        val_11 = CharacterHelper.showingCharacters;
        if(val_1 != null)
        {
                val_1.AddRange(collection:  val_11);
        }
        else
        {
                val_1.AddRange(collection:  val_11);
        }
        
        if((val_1.Contains(item:  val_9)) == false)
        {
            goto label_6;
        }
        
        label_1:
        val_12 = 0;
        goto label_19;
        label_6:
        val_1.Clear();
        val_13 = null;
        val_13 = null;
        val_11 = CharacterHelper.hiddenCharacters;
        if(val_1 != null)
        {
                val_1.AddRange(collection:  val_11);
        }
        else
        {
                val_1.AddRange(collection:  val_11);
        }
        
        if((val_1.Contains(item:  val_9)) == true)
        {
            goto label_13;
        }
        
        val_9 = CharacterDataManager.Get(id:  val_9);
        if(0 != val_9)
        {
            goto label_18;
        }
        
        label_13:
        val_12 = 1;
        goto label_19;
        label_18:
        bool val_7 = VersionText.SameOrHigherVersion(v1:  VersionText.GetVersionString(format:  "{0}.{1}"), v2:  val_4.version);
        val_12 = val_7 ^ 1;
        label_19:
        val_7 = val_12;
        return (bool)val_7;
    }
    public static void SetCelebLocked(bool locked)
    {
    
    }
    private static CharacterHelper()
    {
        CharacterHelper.showingCharacters = new CharacterNameID[0];
        CharacterHelper.hiddenCharacters = new CharacterNameID[3];
        CharacterHelper.OnCelebLockStateChanged = new UnityEngine.Events.UnityEvent();
    }

}
