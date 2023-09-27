using UnityEngine;
private sealed class VSSHARE.<>c__DisplayClass76_0
{
    // Fields
    public AppAdvisory.SharingSystem.VSSHARE <>4__this;
    public System.Action callback;
    
    // Methods
    public VSSHARE.<>c__DisplayClass76_0()
    {
    
    }
    internal void <DoFlash>b__0()
    {
        this.<>4__this.isAnimating = true;
    }
    internal void <DoFlash>b__1()
    {
        this.<>4__this.isAnimating = true;
        if(this.callback == null)
        {
                return;
        }
        
        this.callback.Invoke();
    }

}
