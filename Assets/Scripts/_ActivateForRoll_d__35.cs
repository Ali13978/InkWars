using UnityEngine;
private sealed class SelectStageController.<ActivateForRoll>d__35 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SelectStageController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SelectStageController.<ActivateForRoll>d__35(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_14;
        int val_15;
        var val_16;
        var val_17;
        var val_18;
        val_14 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_15 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = val_15;
        return (bool)val_15;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.iconHolder.SetActive(value:  true);
        val_16 = null;
        val_16 = null;
        val_17 = null;
        val_17 = null;
        bool val_4 = DataStructs.UserDataDictionary.Items.IsStageUnlock(id:  GameInfo.stage.GetAllUniqueIds().Item[this.<>4__this.middleCounter]);
        UnityEngine.Transform val_5 = this.<>4__this.middleStage.transform;
        if(val_5 == null)
        {
            goto label_14;
        }
        
        if(val_4 == false)
        {
            goto label_15;
        }
        
        label_21:
        val_5.GetChild(index:  1).gameObject.SetActive(value:  true);
        UnityEngine.Transform val_8 = this.<>4__this.middleStage.transform;
        val_18 = 0;
        goto label_20;
        label_14:
        if(val_4 == true)
        {
            goto label_21;
        }
        
        label_15:
        val_5.GetChild(index:  0).gameObject.SetActive(value:  true);
        val_18 = 1;
        label_20:
        val_14 = this.<>4__this.middleStage.transform.GetChild(index:  1).gameObject;
        val_14.SetActive(value:  false);
        label_2:
        val_15 = 0;
        return (bool)val_15;
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
