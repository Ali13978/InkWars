using UnityEngine;
private sealed class Scene_CharacterSelection_Adventure.<AnimationAtStart>d__58 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Scene_CharacterSelection_Adventure <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Scene_CharacterSelection_Adventure.<AnimationAtStart>d__58(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Scene_CharacterSelection_Adventure val_11;
        var val_12;
        DataStructs.GameSave val_13;
        int val_14;
        var val_15;
        System.Collections.IEnumerator val_16;
        var val_17;
        var val_18;
        val_11 = this.<>4__this;
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
            goto label_55;
        }
        
        this.<>1__state = 0;
        val_12 = null;
        val_12 = null;
        val_13 = DataStructs.UserDataDictionary.GameSave;
        if(val_13.playCharacterRollAnim == false)
        {
            goto label_7;
        }
        
        UnityEngine.WaitForSeconds val_2 = null;
        val_11 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        val_14 = 1;
        this.<>2__current = val_11;
        this.<>1__state = val_14;
        return (bool)val_14;
        label_1:
        this.<>1__state = 0;
        label_7:
        val_15 = null;
        val_15 = null;
        if(DataStructs.UserDataDictionary.GameSave.playCharacterRollAnim == false)
        {
            goto label_12;
        }
        
        if(val_11 != null)
        {
            goto label_13;
        }
        
        val_16 = 0.LoadCharacterLockStatuses();
        goto label_14;
        label_2:
        this.<>1__state = 0;
        this.<>2__current = val_11.PlayRollAnimation();
        this.<>1__state = 2;
        val_14 = 1;
        return (bool)val_14;
        label_12:
        if(val_11 != null)
        {
                val_11.ActiveNameTag();
        }
        else
        {
                0.ActiveNameTag();
        }
        
        object[] val_6 = new object[10];
        val_13 = val_6;
        val_13[0] = "x";
        val_13[1] = 1f;
        val_13[2] = "y";
        val_13[3] = 1f;
        val_13[4] = "easeType";
        val_13[5] = 21;
        val_13[6] = "delay";
        val_13[7] = 0.2f;
        val_13[8] = "time";
        val_13[9] = 0.2f;
        iTween.ScaleTo(target:  this.<>4__this.nextButton, args:  iTween.Hash(args:  val_6));
        label_13:
        val_16 = val_11.LoadCharacterLockStatuses();
        label_14:
        UnityEngine.Coroutine val_9 = val_11.StartCoroutine(routine:  val_16);
        val_17 = null;
        val_17 = null;
        val_11 = DataStructs.UserDataDictionary.GameSave;
        if(val_11.playCharacterRollAnim != false)
        {
                val_18 = null;
            val_18 = null;
            val_11 = DataStructs.UserDataDictionary.GameSave;
            val_11.playCharacterRollAnim = false;
        }
        
        label_55:
        val_14 = 0;
        return (bool)val_14;
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
