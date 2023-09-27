using UnityEngine;
private sealed class CreditsScroll.<scrollRect>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public CreditsScroll <>4__this;
    private float <flag>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CreditsScroll.<scrollRect>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        var val_10;
        UnityEngine.Object val_11;
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
        
        this.<>1__state = 0;
        val_9 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = val_9;
        return (bool)val_9;
        label_1:
        val_10 = this;
        this.<>1__state = 0;
        if((this.<flag>5__2) >= 0.01f)
        {
            goto label_5;
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu_Title_Screen");
        label_3:
        val_9 = 0;
        return (bool)val_9;
        label_2:
        val_10 = this;
        this.<flag>5__2 = 1f;
        this.<>1__state = 0;
        label_5:
        this.<>4__this.scrollbarCredit.value = this.<flag>5__2;
        val_11 = this.<>4__this.panelText.transform;
        if(((this.<>4__this.inkwarImage.transform.parent) != val_11) && ((this.<flag>5__2) <= 0.94f))
        {
                val_11 = this.<>4__this.panelText.transform;
            this.<>4__this.inkwarImage.transform.parent = val_11;
        }
        
        float val_9 = this.<flag>5__2;
        val_9 = val_9 + (-0.0006f);
        this.<flag>5__2 = val_9;
        this.<>2__current = new UnityEngine.WaitForFixedUpdate();
        this.<>1__state = 2;
        val_9 = 1;
        return (bool)val_9;
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
