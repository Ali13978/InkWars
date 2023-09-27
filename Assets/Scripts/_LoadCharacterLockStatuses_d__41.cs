using UnityEngine;
private sealed class Scene_CharacterSelection_Adventure.<LoadCharacterLockStatuses>d__41 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Scene_CharacterSelection_Adventure <>4__this;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Scene_CharacterSelection_Adventure.<LoadCharacterLockStatuses>d__41(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_46;
        int val_47;
        var val_48;
        var val_49;
        var val_50;
        int val_51;
        UnityEngine.Vector4 val_52;
        var val_53;
        var val_54;
        var val_55;
        UnityEngine.Vector4 val_56;
        var val_57;
        var val_58;
        var val_59;
        UnityEngine.Vector4 val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return false;
        }
        
        val_46 = this;
        this.<i>5__2 = 0;
        val_47 = 0;
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_17;
        }
        
        goto label_4;
        label_1:
        val_46 = this.<i>5__2;
        this.<>1__state = 0;
        goto label_12;
        label_19:
        val_48 = null;
        val_48 = null;
        if(((DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  this.<>4__this.allClanCharactersInOrder[(this.<i>5__2) << 2])) == true) || (val_46 < 1))
        {
            goto label_12;
        }
        
        val_49 = null;
        val_49 = null;
        if(DataStructs.UserDataDictionary.GameSave.IsStatsInstructionDisplayed == false)
        {
            goto label_16;
        }
        
        label_12:
        val_47 = val_46 + 1;
        mem2[0] = val_47;
        if((this.<>4__this) != null)
        {
            goto label_17;
        }
        
        label_4:
        label_17:
        if(val_47 < (this.<>4__this.allClanCharactersInOrder.Length))
        {
            goto label_19;
        }
        
        this.<>4__this.DarkenAtStart();
        this.<>4__this.iconsHolder.SetActive(value:  true);
        val_50 = null;
        val_50 = null;
        DataStructs.AdventureProgress val_3 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressByID(cid:  this.<>4__this.allClanCharactersInOrder[0]);
        this.<>4__this.puzzleFill.fillAmount = val_3.GetPassedLevelProgress(mode:  1);
        this.<>4__this.battleFill.fillAmount = val_3.GetPassedLevelProgress(mode:  0);
        this.<>4__this.exBattleFill.fillAmount = val_3.GetPassedLevelProgress(mode:  2);
        Swipe_CharacterSelection_Adventure.touchBoolClan = true;
        val_51 = (this.<>4__this.charCenterIndex) - 1;
        if((val_51 & 2147483648) != 0)
        {
                val_46 = this.<>4__this.characterDynamicPoses;
            val_51 = (this.<>4__this.characterDynamicPoses.Length) - 1;
        }
        
        if((this.<>4__this.GetUnlockStatus(id:  val_51)) != false)
        {
                val_52 = this.<>4__this.fade_Locked;
            val_53 = (this.<>4__this) + 256;
            val_54 = (this.<>4__this) + 260;
            val_55 = (this.<>4__this) + 264;
        }
        else
        {
                val_52 = this.<>4__this.fadeSide_Unlocked;
            val_53 = (this.<>4__this) + 288;
            val_54 = (this.<>4__this) + 292;
            val_55 = (this.<>4__this) + 296;
        }
        
        UnityEngine.Color val_11 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = this.<>4__this.fadeSide_Unlocked.x, y = 2.113612E-20f, z = 2.113612E-20f, w = 2.113612E-20f});
        this.<>4__this.displayImages.Item[0].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a};
        if((this.<>4__this.GetUnlockStatus(id:  this.<>4__this.charCenterIndex)) != false)
        {
                val_56 = this.<>4__this.fade_Locked;
            val_57 = (this.<>4__this) + 256;
            val_58 = (this.<>4__this) + 260;
            val_59 = (this.<>4__this) + 264;
        }
        else
        {
                val_56 = this.<>4__this.fadeCenter_Unlocked;
            val_57 = (this.<>4__this) + 272;
            val_58 = (this.<>4__this) + 276;
            val_59 = (this.<>4__this) + 280;
        }
        
        UnityEngine.Color val_16 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = this.<>4__this.fadeCenter_Unlocked.x, y = 2.113612E-20f, z = 2.113612E-20f, w = 2.113612E-20f});
        this.<>4__this.displayImages.Item[1].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_16.r, g = val_16.g, b = val_16.b, a = val_16.a};
        int val_20 = (this.<>4__this.charCenterIndex) + 1;
        if((this.<>4__this.GetUnlockStatus(id:  (val_20 >= (this.<>4__this.characterDynamicPoses.Length)) ? 0 : (val_20))) != false)
        {
                val_60 = this.<>4__this.fade_Locked;
            val_61 = (this.<>4__this) + 256;
            val_62 = (this.<>4__this) + 260;
            val_63 = (this.<>4__this) + 264;
        }
        else
        {
                val_60 = this.<>4__this.fadeSide_Unlocked;
            val_61 = (this.<>4__this) + 288;
            val_62 = (this.<>4__this) + 292;
            val_63 = (this.<>4__this) + 296;
        }
        
        UnityEngine.Color val_23 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = this.<>4__this.fadeSide_Unlocked.x, y = 2.113612E-20f, z = 2.113612E-20f, w = 2.113612E-20f});
        this.<>4__this.displayImages.Item[2].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_23.r, g = val_23.g, b = val_23.b, a = val_23.a};
        return false;
        label_16:
        val_64 = null;
        val_64 = null;
        DataStructs.UserDataDictionary.GameSave.IsStatsInstructionDisplayed = true;
        this.<>4__this.instructionalPanel.SetActive(value:  true);
        UnityEngine.Time.timeScale = 0f;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.04f);
        this.<>1__state = 1;
        return false;
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
