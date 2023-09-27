using UnityEngine;
private sealed class LineController.<LoadResources>d__192 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineController.<LoadResources>d__192(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_12;
        CharacterNameID val_14;
        CharacterNameID val_19;
        LineController val_56;
        int val_57;
        var val_58;
        var val_59;
        float val_60;
        UnityEngine.Sprite val_61;
        float val_62;
        var val_63;
        UnityEngine.Sprite val_64;
        UnityEngine.Sprite val_65;
        var val_66;
        var val_67;
        int val_68;
        CharacterClan val_69;
        UnityEngine.Sprite val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        bool val_76;
        var val_77;
        CharAnimationController_Physical val_78;
        val_56 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_57 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_57;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_56 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  0.2f);
        val_57 = 1;
        this.<>2__current = val_56;
        this.<>1__state = val_57;
        return (bool)val_57;
        label_1:
        this.<>1__state = 0;
        if(val_56 != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this.modeName) == 5)
        {
                UnityEngine.GameObject val_3 = instructionMenuHandler.gameTimer.gameObject;
            if(PlayerPrefsManager.OnlinePVPTime != 1)
        {
                val_3.SetActive(value:  true);
            string val_5 = PlayerPrefsManager.OnlinePVPTime.ToString(format:  "D3");
            if(instructionMenuHandler.gameTimer != null)
        {
            goto label_13;
        }
        
        }
        else
        {
                val_3.SetActive(value:  false);
            instructionMenuHandler.infinityTimer.gameObject.SetActive(value:  true);
        }
        
        }
        
        label_13:
        this.<>4__this.cpuBridge = UnityEngine.GameObject.FindWithTag(tag:  "CpuBridge");
        this.<>4__this.playerBridge = UnityEngine.GameObject.FindWithTag(tag:  "PlayerBridge");
        this.<>4__this.specialBallButtonArrow.interactable = true;
        if((this.<>4__this.modeName) == 3)
        {
                val_58 = 0;
        }
        else
        {
                CpuBridgeScript val_9 = this.<>4__this.playerBridge.GetComponent<CpuBridgeScript>();
            val_58 = 1;
        }
        
        val_9.alienFull.SetActive(value:  true);
        CpuBridgeScript val_10 = this.<>4__this.cpuBridge.GetComponent<CpuBridgeScript>();
        val_10.alienFull.SetActive(value:  true);
        CharacterInfo val_11 = Character_GlobalInfo.GetMainPlayer();
        if(val_12 != 1)
        {
            goto label_27;
        }
        
        CharacterInfo val_13 = Character_GlobalInfo.GetMainPlayer();
        val_59 = 1152921505065472000;
        float val_15 = CharacterHelper.GetAttackSpeed(cid:  val_14);
        val_60 = 0.4f;
        if(val_15 != val_60)
        {
            goto label_32;
        }
        
        val_61 = this.<>4__this.iconsActiveTako[3];
        goto label_55;
        label_27:
        CharacterInfo val_16 = Character_GlobalInfo.GetMainPlayer();
        val_59 = 1152921505065472000;
        float val_17 = CharacterHelper.GetAttackSpeed(cid:  val_14);
        CharacterInfo val_18 = Character_GlobalInfo.GetMainPlayer();
        CharacterClan val_20 = Character_GlobalInfo.GetClan(characterId:  val_19);
        val_62 = 0.4f;
        var val_21 = (val_20 == 0) ? this.<>4__this.iconsActiveIka : this.<>4__this.iconsActiveMermaid;
        if(val_17 != val_62)
        {
            goto label_40;
        }
        
        val_64 = mem[val_20 == null ? this.<>4__this.iconsActiveIka : this.<>4__this.iconsActiveMermaid + 56];
        val_64 = val_20 == null ? this.<>4__this.iconsActiveIka : this.<>4__this.iconsActiveMermaid + 56;
        goto label_59;
        label_32:
        val_62 = 1f;
        if(val_15 != val_62)
        {
            goto label_44;
        }
        
        val_61 = this.<>4__this.iconsActiveTako[2];
        goto label_55;
        label_40:
        val_62 = 1f;
        if(val_17 != val_62)
        {
            goto label_48;
        }
        
        val_64 = mem[val_20 == null ? this.<>4__this.iconsActiveIka : this.<>4__this.iconsActiveMermaid + 48];
        val_64 = val_20 == null ? this.<>4__this.iconsActiveIka : this.<>4__this.iconsActiveMermaid + 48;
        goto label_59;
        label_44:
        val_62 = 1.5f;
        if(val_15 != val_62)
        {
            goto label_53;
        }
        
        val_61 = this.<>4__this.iconsActiveTako[1];
        goto label_55;
        label_48:
        val_62 = 1.5f;
        val_63 = ((val_20 == 0) ? 1 : 0) & ((val_17 != val_62) ? 1 : 0);
        if(val_17 != val_62)
        {
            goto label_57;
        }
        
        val_64 = mem[val_20 == null ? this.<>4__this.iconsActiveIka : this.<>4__this.iconsActiveMermaid + 40];
        val_64 = val_20 == null ? this.<>4__this.iconsActiveIka : this.<>4__this.iconsActiveMermaid + 40;
        goto label_59;
        label_53:
        val_61 = this.<>4__this.iconsActiveTako[0];
        label_55:
        val_56.SetIconPlayerActive(sprite:  val_61);
        System.Type val_56 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_26 = UnityEngine.Resources.Load(path:  "Icon_Tako_Inactive", systemTypeInstance:  val_56);
        if(val_26 != null)
        {
                val_56 = (null == null) ? (val_26) : 0;
        }
        else
        {
                val_65 = 0;
        }
        
        val_56.SetIconPlayerInactive(sprite:  val_65);
        val_66 = null;
        val_66 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_29 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetCurrentLevelData().InkPercentage;
        val_67 = null;
        val_67 = null;
        LineController.inkBubblesHitOnCurrentCharacter = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_29.currentCryptoKey, hiddenValue = val_29.hiddenValue, fakeValue = val_29.fakeValue, inited = val_29.inited});
        if((this.<>4__this.modeName) == 5)
        {
            goto label_74;
        }
        
        val_68 = this.<>4__this.stageNumber;
        val_69 = 0;
        goto label_77;
        label_57:
        val_63 = val_63 & ((val_17 != val_62) ? 1 : 0);
        val_64 = mem[val_20 == null ? this.<>4__this.iconsActiveIka : this.<>4__this.iconsActiveMermaid + 32];
        val_64 = val_20 == null ? this.<>4__this.iconsActiveIka : this.<>4__this.iconsActiveMermaid + 32;
        label_59:
        val_56.SetIconPlayerActive(sprite:  val_64);
        System.Type val_57 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_33 = UnityEngine.Resources.Load(path:  (val_63 == 0) ? "Icon_Mermaid_Inactive" : "Icon_Ika_Inactive", systemTypeInstance:  val_57);
        if(val_33 != null)
        {
                val_57 = (null == null) ? (val_33) : 0;
        }
        else
        {
                val_70 = 0;
        }
        
        val_56.SetIconPlayerInactive(sprite:  val_70);
        val_71 = null;
        val_71 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_36 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetCurrentLevelData().InkPercentage;
        val_72 = null;
        val_72 = null;
        LineController.inkBubblesHitOnCurrentCharacter = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_36.currentCryptoKey, hiddenValue = val_36.hiddenValue, fakeValue = val_36.fakeValue, inited = val_36.inited});
        if((this.<>4__this.modeName) != 5)
        {
            goto label_92;
        }
        
        label_74:
        CharacterInfo val_38 = Character_GlobalInfo.GetRightPlayer();
        val_73 = val_14;
        goto label_97;
        label_92:
        val_69 = 1;
        val_68 = this.<>4__this.stageNumber;
        label_77:
        label_97:
        this.<>4__this.cpuStunVariable = CharacterHelper.GetStunTime(cid:  CharacterHelper.GetStageCPUCharacterId(levelId0to11:  val_68, CPUClan:  val_69));
        if((this.<>4__this.modeName) == 3)
        {
                this.<>4__this.characterReloadVariable = 0.05714286f;
        }
        else
        {
                if((this.<>4__this.modeName) == 5)
        {
                CharacterInfo val_41 = Character_GlobalInfo.GetLeftPlayer();
        }
        else
        {
                CharacterInfo val_42 = Character_GlobalInfo.GetMainPlayer();
        }
        
            float val_43 = CharacterHelper.GetAttackSpeed(cid:  val_14);
            val_43 = val_43 + 0.6f;
            val_43 = val_43 * 25f;
            val_60 = 1f;
            val_62 = val_60 / val_43;
            this.<>4__this.characterReloadVariable = val_62;
        }
        
        val_74 = null;
        val_74 = null;
        if(LineController.inkBubblesHitOnCurrentCharacter < 100)
        {
                val_76 = 1;
        }
        else
        {
                val_76 = false;
        }
        
        LineController.inkMeterAnimationFlag = val_76;
        val_77 = null;
        val_77 = null;
        if((Character_GlobalInfo.gameMode - 3) >= 2)
        {
                if(Character_GlobalInfo.gameMode == 5)
        {
            goto label_121;
        }
        
        }
        
        CharacterInfo val_45 = Character_GlobalInfo.GetMainPlayer();
        label_140:
        this.<>4__this.animController.RetrieveCharacterBundle(charNameID:  val_14);
        UnityEngine.Coroutine val_47 = val_56.StartCoroutine(routine:  mem[this.<>4__this.animController].LoadAnimations_Gameplay());
        UnityEngine.Vector3 val_49 = this.<>4__this.playerChar.transform.position;
        this.<>4__this.characterPos = val_49;
        mem2[0] = val_49.y;
        mem2[0] = val_49.z;
        label_6:
        val_78 = this.<>4__this.animController;
        if((this.<>4__this.animController.animationsLoaded) == false)
        {
            goto label_129;
        }
        
        val_78 = 1152921505081339904;
        if(BattleVSGates.instance != 0)
        {
            goto label_132;
        }
        
        if(NetworkManager_Custom.IsNetwork == false)
        {
            goto label_133;
        }
        
        System.Collections.IEnumerator val_52 = val_56.startDefenceSequenceNetwork();
        goto label_134;
        label_129:
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_57 = 1;
        return (bool)val_57;
        label_132:
        val_56 = BattleVSGates.instance;
        val_56.SetLoaded_Scene(leftSide:  true);
        goto label_137;
        label_133:
        label_134:
        UnityEngine.Coroutine val_54 = val_56.StartCoroutine(routine:  val_56.startDefenceSequence());
        label_137:
        val_57 = 0;
        return (bool)val_57;
        label_121:
        CharacterInfo val_55 = Character_GlobalInfo.GetLeftPlayer();
        goto label_140;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
