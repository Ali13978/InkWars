using UnityEngine;
private sealed class Scene_CharacterSelection_Adventure.<PlayRollAnimation>d__59 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Scene_CharacterSelection_Adventure <>4__this;
    private float <rollTime>5__2;
    private float <fraction>5__3;
    private int <i>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Scene_CharacterSelection_Adventure.<PlayRollAnimation>d__59(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_9;
        DataStructs.GameSave val_10;
        int val_11;
        CharacterNameID[] val_12;
        var val_13;
        var val_14;
        object val_15;
        val_9 = 0;
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
                return (bool)val_9;
        }
        
        this.<i>5__4 = 0;
        val_10 = 0;
        this.<>1__state = 0;
        mem[1152921528759586408] = 1050253722;
        if((this.<>4__this) != null)
        {
            goto label_23;
        }
        
        goto label_5;
        label_2:
        this.<>1__state = 0;
        goto label_21;
        label_1:
        val_11 = 0;
        goto label_7;
        label_25:
        if(X22 <= 3)
        {
            goto label_8;
        }
        
        var val_8 = mem[53678272] + 24;
        val_8 = val_8 - 4;
        if(X22 >= val_8)
        {
            goto label_10;
        }
        
        this.<fraction>5__3 = 0.03f;
        goto label_27;
        label_8:
        float val_9 = this.<rollTime>5__2;
        val_9 = val_9 - (this.<fraction>5__3);
        label_28:
        this.<rollTime>5__2 = val_9;
        this.<fraction>5__3 = (this.<fraction>5__3) + 0.01f;
        label_27:
        val_12 = 1152921505151520768;
        val_13 = null;
        val_13 = null;
        if(DataStructs.UserDataDictionary.GameSave.playCharacterRollAnim != false)
        {
            
        }
        else
        {
                this.<rollTime>5__2 = 0f;
        }
        
        StartRoll(rollTime:  0f);
        var val_3 = static_value_033310E0 + 1;
        var val_4 = (val_3 >= (static_value_033310C8 + 24)) ? 0 : (val_3);
        val_14 = null;
        val_14 = null;
        val_10 = DataStructs.UserDataDictionary.GameSave;
        if(val_10.playCharacterRollAnim == false)
        {
            goto label_21;
        }
        
        UnityEngine.WaitForSeconds val_6 = null;
        val_15 = val_6;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  this.<rollTime>5__2);
        val_11 = 1;
        goto label_22;
        label_21:
        val_10 = (this.<i>5__4) + 1;
        mem2[0] = val_10;
        if((this.<>4__this) != null)
        {
            goto label_23;
        }
        
        label_5:
        label_23:
        val_12 = this.<>4__this.allClanCharactersInOrder;
        if(val_10 < (this.<>4__this.allClanCharactersInOrder.Length))
        {
            goto label_25;
        }
        
        UnityEngine.WaitForSeconds val_7 = null;
        val_15 = val_7;
        val_7 = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        val_11 = 2;
        label_22:
        val_9 = 1;
        this.<>2__current = val_15;
        label_7:
        this.<>1__state = val_11;
        return (bool)val_9;
        label_10:
        var val_10 = mem[53678272] + 24;
        val_10 = val_10 - 4;
        if(X22 < val_10)
        {
            goto label_27;
        }
        
        float val_11 = this.<rollTime>5__2;
        val_11 = val_11 + (this.<fraction>5__3);
        goto label_28;
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
