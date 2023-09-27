using UnityEngine;
private sealed class LineControllerP2.<LoadResources>d__109 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineControllerP2 <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerP2.<LoadResources>d__109(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        CharacterNameID val_7;
        BattleVSGates val_57;
        int val_58;
        UnityEngine.GameObject val_59;
        var val_60;
        float val_61;
        UnityEngine.Sprite val_62;
        var val_63;
        UnityEngine.Sprite val_64;
        float val_65;
        UnityEngine.Sprite val_66;
        var val_67;
        int val_68;
        CharacterClan val_69;
        UnityEngine.Sprite val_70;
        var val_71;
        CharAnimationController_Physical val_72;
        val_57 = this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_129;
        }
        
        this.<>1__state = 0;
        this.<>4__this.iconPlayerActive.SetActive(value:  false);
        val_58 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.2f);
        this.<>1__state = val_58;
        return (bool)val_58;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_2:
        this.<>1__state = 0;
        this.<>4__this.cpuBridge = UnityEngine.GameObject.FindWithTag(tag:  "PlayerBridge");
        UnityEngine.GameObject val_3 = UnityEngine.GameObject.FindWithTag(tag:  "CpuBridge");
        if((this.<>4__this) != null)
        {
                val_59 = this.<>4__this.playerBridge;
            this.<>4__this.playerBridge = val_3;
        }
        else
        {
                val_59 = 464;
            mem[464] = val_3;
        }
        
        this.<>4__this.specialBallButtonArrow.interactable = true;
        if((this.<>4__this.modeName) == 3)
        {
                val_60 = 0;
        }
        else
        {
                CpuBridgeScript val_4 = mem[464].GetComponent<CpuBridgeScript>();
            val_60 = 1;
        }
        
        val_4.alienFull.SetActive(value:  true);
        CpuBridgeScript val_5 = this.<>4__this.cpuBridge.GetComponent<CpuBridgeScript>();
        val_5.alienFull.SetActive(value:  true);
        if((this.<>4__this.tempCharType) != 1)
        {
            goto label_21;
        }
        
        CharacterInfo val_6 = Character_GlobalInfo.GetOpponentPlayer();
        val_61 = 0.4f;
        if((CharacterHelper.GetAttackSpeed(cid:  val_7)) != val_61)
        {
            goto label_26;
        }
        
        LineController val_9 = this.<>4__this.GetComponent<LineController>();
        val_62 = val_9.iconsActiveTako[3];
        goto label_67;
        label_21:
        CharacterInfo val_10 = Character_GlobalInfo.GetOpponentPlayer();
        CharacterClan val_11 = Character_GlobalInfo.GetClan(characterId:  val_7);
        var val_12 = (val_11 == 0) ? 1 : 0;
        LineController val_13 = this.<>4__this.GetComponent<LineController>();
        var val_14 = (val_11 == 0) ? val_13.iconsActiveIka : val_13.iconsActiveMermaid;
        CharacterInfo val_15 = Character_GlobalInfo.GetOpponentPlayer();
        float val_17 = CharacterHelper.GetAttackSpeed(cid:  val_7);
        val_61 = 0.4f;
        if(val_17 != val_61)
        {
            goto label_38;
        }
        
        val_64 = mem[val_11 == null ? val_13.iconsActiveIka : val_13.iconsActiveMermaid + 56];
        val_64 = val_11 == null ? val_13.iconsActiveIka : val_13.iconsActiveMermaid + 56;
        goto label_75;
        label_26:
        CharacterInfo val_19 = Character_GlobalInfo.GetOpponentPlayer();
        val_61 = 1f;
        if((CharacterHelper.GetAttackSpeed(cid:  val_7)) != val_61)
        {
            goto label_46;
        }
        
        LineController val_21 = this.<>4__this.GetComponent<LineController>();
        val_62 = val_21.iconsActiveTako[2];
        goto label_67;
        label_38:
        CharacterInfo val_22 = Character_GlobalInfo.GetOpponentPlayer();
        float val_23 = CharacterHelper.GetAttackSpeed(cid:  val_7);
        val_61 = 1f;
        if(val_23 != val_61)
        {
            goto label_55;
        }
        
        val_64 = mem[val_11 == null ? val_13.iconsActiveIka : val_13.iconsActiveMermaid + 48];
        val_64 = val_11 == null ? val_13.iconsActiveIka : val_13.iconsActiveMermaid + 48;
        goto label_75;
        label_46:
        CharacterInfo val_25 = Character_GlobalInfo.GetOpponentPlayer();
        LineController val_27 = this.<>4__this.GetComponent<LineController>();
        val_65 = 1.5f;
        if((CharacterHelper.GetAttackSpeed(cid:  val_7)) != val_65)
        {
            goto label_65;
        }
        
        val_62 = val_27.iconsActiveTako[1];
        goto label_67;
        label_55:
        CharacterInfo val_28 = Character_GlobalInfo.GetOpponentPlayer();
        val_65 = 1.5f;
        val_63 = ((val_11 == 0) ? 1 : 0) & ((val_17 != val_61) ? 1 : 0);
        if((CharacterHelper.GetAttackSpeed(cid:  val_7)) != val_65)
        {
            goto label_73;
        }
        
        val_64 = mem[val_11 == null ? val_13.iconsActiveIka : val_13.iconsActiveMermaid + 40];
        val_64 = val_11 == null ? val_13.iconsActiveIka : val_13.iconsActiveMermaid + 40;
        goto label_75;
        label_65:
        val_62 = val_27.iconsActiveTako[0];
        label_67:
        this.<>4__this.SetIconPlayerActive(sprite:  val_62);
        System.Type val_54 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_31 = UnityEngine.Resources.Load(path:  "Icon_Tako_Inactive", systemTypeInstance:  val_54);
        if(val_31 != null)
        {
                val_54 = (null == null) ? (val_31) : 0;
        }
        else
        {
                val_66 = 0;
        }
        
        this.<>4__this.SetIconPlayerInactive(sprite:  val_66);
        CharacterInfo val_32 = Character_GlobalInfo.GetMainPlayer();
        this.<>4__this.cpuStunVariable = CharacterHelper.GetStunTime(cid:  val_7);
        if((this.<>4__this.modeName) == 3)
        {
            goto label_85;
        }
        
        if((this.<>4__this.modeName) != 5)
        {
            goto label_86;
        }
        
        CharacterInfo val_34 = Character_GlobalInfo.GetOpponentPlayer();
        val_67 = null;
        goto label_89;
        label_86:
        val_68 = Character_GlobalInfo.stage_CurrentLevel - 1;
        val_69 = 1;
        goto label_94;
        label_73:
        val_63 = val_63 & ((val_23 != val_61) ? 1 : 0);
        val_64 = mem[val_11 == null ? val_13.iconsActiveIka : val_13.iconsActiveMermaid + 32];
        val_64 = val_11 == null ? val_13.iconsActiveIka : val_13.iconsActiveMermaid + 32;
        label_75:
        this.<>4__this.SetIconPlayerActive(sprite:  val_64);
        System.Type val_55 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_38 = UnityEngine.Resources.Load(path:  (val_63 == 0) ? "Icon_Mermaid_Inactive" : "Icon_Ika_Inactive", systemTypeInstance:  val_55);
        if(val_38 != null)
        {
                val_55 = (null == null) ? (val_38) : 0;
        }
        else
        {
                val_70 = 0;
        }
        
        this.<>4__this.SetIconPlayerInactive(sprite:  val_70);
        CharacterInfo val_39 = Character_GlobalInfo.GetMainPlayer();
        this.<>4__this.cpuStunVariable = CharacterHelper.GetStunTime(cid:  val_7);
        if((this.<>4__this.modeName) != 3)
        {
            goto label_104;
        }
        
        label_85:
        this.<>4__this.characterReloadVariable = 0.05714286f;
        goto label_105;
        label_104:
        if((this.<>4__this.modeName) != 5)
        {
            goto label_106;
        }
        
        CharacterInfo val_41 = Character_GlobalInfo.GetOpponentPlayer();
        val_67 = null;
        label_89:
        val_71 = val_7;
        goto label_111;
        label_106:
        val_68 = Character_GlobalInfo.stage_CurrentLevel - 1;
        val_69 = 0;
        label_94:
        label_111:
        float val_44 = CharacterHelper.GetAttackSpeed(cid:  CharacterHelper.GetStageCPUCharacterId(levelId0to11:  val_68, CPUClan:  val_69));
        val_44 = val_44 + 0.6f;
        val_44 = val_44 * 25f;
        val_61 = 1f;
        val_65 = val_61 / val_44;
        this.<>4__this.characterReloadVariable = val_65;
        label_105:
        this.<>4__this.iconPlayerActive.SetActive(value:  true);
        CharacterInfo val_45 = Character_GlobalInfo.GetRightPlayer();
        this.<>4__this.animController.RetrieveCharacterBundle(charNameID:  val_7);
        UnityEngine.Coroutine val_47 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.animController.LoadAnimations_Gameplay());
        UnityEngine.Vector3 val_49 = this.<>4__this.playerChar.transform.position;
        this.<>4__this.characterPos = val_49;
        mem2[0] = val_49.y;
        mem2[0] = val_49.z;
        label_8:
        val_72 = this.<>4__this.animController;
        if((this.<>4__this.animController.animationsLoaded) == false)
        {
            goto label_124;
        }
        
        val_72 = 1152921505081339904;
        val_57 = BattleVSGates.instance;
        if(val_57 != 0)
        {
            goto label_127;
        }
        
        if(NetworkManager_Custom.IsNetwork == true)
        {
            goto label_129;
        }
        
        UnityEngine.Coroutine val_53 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.startDefenceSequence());
        goto label_129;
        label_124:
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_58 = 1;
        return (bool)val_58;
        label_127:
        val_57 = BattleVSGates.instance;
        val_57.SetLoaded_Scene(leftSide:  false);
        label_129:
        val_58 = 0;
        return (bool)val_58;
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
