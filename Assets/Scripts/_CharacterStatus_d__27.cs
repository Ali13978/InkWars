using UnityEngine;
private sealed class swipeika.<CharacterStatus>d__27 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public swipeika <>4__this;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public swipeika.<CharacterStatus>d__27(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_10;
        int val_11;
        var val_12;
        int val_13;
        bool val_14;
        var val_15;
        var val_16;
        var val_17;
        val_10 = this;
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
            goto label_3;
        }
        
        val_11 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_11;
        return (bool)val_11;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_33;
        }
        
        label_34:
        label_33:
        val_12 = val_10;
        label_26:
        UnityEngine.Color val_2 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.<>4__this.ikaSelectionComp.testimages[this.<i>5__2].GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        val_13 = (this.<i>5__2) + 1;
        this.<i>5__2 = val_13;
        goto label_11;
        label_2:
        val_12 = val_10;
        this.<i>5__2 = 0;
        val_13 = 0;
        this.<>1__state = 0;
        label_11:
        if(val_13 >= 14)
        {
                this.<>4__this.ikaSelectionComp.DarkenAtStart();
            val_10 = this.<>4__this.iconsHolder;
            val_14 = true;
            val_10.SetActive(value:  true);
            val_11 = 0;
            swipeika.touchBoolIka = val_14;
            return (bool)val_11;
        }
        
        val_15 = null;
        val_15 = null;
        if((DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  CharNameIDConverter.JSonIdToCharNameId(JsonID:  "Ika_" + this.<i>5__2.ToString()(this.<i>5__2.ToString())))) == false)
        {
            goto label_20;
        }
        
        UnityEngine.UI.Image val_7 = this.<>4__this.ikaSelectionComp.testimages[this.<i>5__2].GetComponent<UnityEngine.UI.Image>();
        goto label_26;
        label_3:
        val_11 = 0;
        return (bool)val_11;
        label_20:
        if((this.<i>5__2) < 1)
        {
            goto label_28;
        }
        
        val_16 = null;
        val_16 = null;
        if(DataStructs.UserDataDictionary.GameSave.IsStatsInstructionDisplayed == false)
        {
            goto label_32;
        }
        
        label_28:
        if((this.<>4__this) != null)
        {
            goto label_33;
        }
        
        goto label_34;
        label_32:
        val_17 = null;
        val_17 = null;
        DataStructs.UserDataDictionary.GameSave.IsStatsInstructionDisplayed = true;
        val_11 = 1;
        this.<>4__this.instructionalPanel.SetActive(value:  true);
        UnityEngine.Time.timeScale = 0f;
        UnityEngine.WaitForSeconds val_9 = null;
        val_14 = val_9;
        val_9 = new UnityEngine.WaitForSeconds(seconds:  0.04f);
        this.<>2__current = val_14;
        this.<>1__state = 2;
        return (bool)val_11;
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
