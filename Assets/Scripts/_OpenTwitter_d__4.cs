using UnityEngine;
private sealed class TwitterPage.<OpenTwitter>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TwitterPage <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TwitterPage.<OpenTwitter>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        int val_5;
        val_4 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.Application.OpenURL(url:  "twitter:///user?screen_name="("twitter:///user?screen_name=") + this.<>4__this.userName(this.<>4__this.userName));
        val_5 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = val_5;
        return (bool)val_5;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_5;
        }
        
        val_4 = this.<>4__this;
        if((this.<>4__this.leftApp) == false)
        {
            goto label_6;
        }
        
        label_8:
        val_5 = 0;
        mem2[0] = 0;
        return (bool)val_5;
        label_5:
        val_4 = 40;
        if(104 != 0)
        {
            goto label_8;
        }
        
        label_6:
        UnityEngine.Application.OpenURL(url:  "http://www.twitter.com/"("http://www.twitter.com/") + this.<>4__this.userName(this.<>4__this.userName));
        label_2:
        val_5 = 0;
        return (bool)val_5;
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
