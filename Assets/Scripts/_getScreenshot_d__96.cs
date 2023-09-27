using UnityEngine;
private sealed class VSSHARE.<getScreenshot>d__96 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public AppAdvisory.SharingSystem.VSSHARE <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VSSHARE.<getScreenshot>d__96(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        AppAdvisory.SharingSystem.VSSHARE val_6;
        int val_7;
        val_6 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if(val_6 == null)
        {
            goto label_3;
        }
        
        val_6.SetVisibilityToShowOnScreenshot(_isVisible:  true);
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if((System.IO.File.Exists(path:  val_6.FilePath)) != false)
        {
                System.IO.File.Delete(path:  val_6.FilePath);
        }
        
        val_6.DoFlash(callback:  new System.Action(object:  val_6, method:  System.Void AppAdvisory.SharingSystem.VSSHARE::<getScreenshot>b__96_0()));
        label_2:
        val_7 = 0;
        return (bool)val_7;
        label_3:
        0.SetVisibilityToShowOnScreenshot(_isVisible:  true);
        label_4:
        val_6.SetVisibilityToHideOnScreenshot(_isVisible:  false);
        UnityEngine.WaitForEndOfFrame val_5 = null;
        val_6 = val_5;
        val_5 = new UnityEngine.WaitForEndOfFrame();
        val_7 = 1;
        this.<>2__current = val_6;
        this.<>1__state = val_7;
        return (bool)val_7;
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
