using UnityEngine;
private sealed class UserPanelInTitle.<RefreshLayout>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UserPanelInTitle <>4__this;
    private UnityEngine.UI.HorizontalLayoutGroup <layout>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UserPanelInTitle.<RefreshLayout>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_6;
        }
        
        this.<>1__state = 0;
        UnityEngine.UI.HorizontalLayoutGroup val_1 = this.<>4__this.GetComponent<UnityEngine.UI.HorizontalLayoutGroup>();
        this.<layout>5__2 = val_1;
        if(0 == val_1)
        {
            goto label_6;
        }
        
        this.<layout>5__2.enabled = false;
        val_4 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_4;
        return (bool)val_4;
        label_1:
        this.<>1__state = 0;
        this.<layout>5__2.enabled = true;
        label_6:
        val_4 = 0;
        return (bool)val_4;
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
