using UnityEngine;
private sealed class SelectStageController.<LockStatus>d__28 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool isStageBought;
    public SelectStageController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SelectStageController.<LockStatus>d__28(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_15;
        int val_16;
        var val_17;
        val_15 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_16 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.4f);
        this.<>1__state = val_16;
        return (bool)val_16;
        label_1:
        this.<>1__state = 0;
        UnityEngine.Transform val_2 = this.<>4__this.middleStage.transform;
        if(val_2 == null)
        {
            goto label_6;
        }
        
        if(this.isStageBought == false)
        {
            goto label_7;
        }
        
        label_17:
        val_2.GetChild(index:  1).gameObject.SetActive(value:  true);
        this.<>4__this.middleStage.transform.GetChild(index:  0).gameObject.SetActive(value:  false);
        val_15 = this.<>4__this.ConfirmMapButton.gameObject;
        val_17 = 1;
        goto label_16;
        label_6:
        if(this.isStageBought == true)
        {
            goto label_17;
        }
        
        label_7:
        val_2.GetChild(index:  0).gameObject.SetActive(value:  true);
        this.<>4__this.middleStage.transform.GetChild(index:  1).gameObject.SetActive(value:  false);
        val_15 = this.<>4__this.ConfirmMapButton.gameObject;
        val_17 = 0;
        label_16:
        val_15.SetActive(value:  false);
        label_2:
        val_16 = 0;
        return (bool)val_16;
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
