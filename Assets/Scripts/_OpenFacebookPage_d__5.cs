using UnityEngine;
private sealed class FacebookPage.<OpenFacebookPage>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public FacebookPage <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FacebookPage.<OpenFacebookPage>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        int val_4;
        val_3 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.Application.OpenURL(url:  "fb://page/"("fb://page/") + this.<>4__this.facebookPageID(this.<>4__this.facebookPageID));
        val_4 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = val_4;
        return (bool)val_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_5;
        }
        
        val_3 = this.<>4__this;
        if((this.<>4__this.leftApp) == false)
        {
            goto label_6;
        }
        
        label_8:
        val_4 = 0;
        mem2[0] = 0;
        return (bool)val_4;
        label_5:
        val_3 = 48;
        if(0 != 0)
        {
            goto label_8;
        }
        
        label_6:
        UnityEngine.Application.OpenURL(url:  this.<>4__this.facebookPageLink);
        label_2:
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
