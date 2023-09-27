using UnityEngine;
private sealed class LoadingScreenController.<Init>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LoadingScreenController <>4__this;
    private UnityEngine.RectTransform <rt>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LoadingScreenController.<Init>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_10;
        float val_11;
        int val_12;
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
        
        this.<>1__state = 0;
        UnityEngine.RectTransform val_1 = this.<>4__this.animPanel.GetComponent<UnityEngine.RectTransform>();
        this.<rt>5__2 = val_1;
        UnityEngine.Vector2 val_2 = val_1.anchoredPosition;
        val_11 = val_2.x;
        this.<rt>5__2.anchoredPosition = new UnityEngine.Vector2() {x = val_11, y = -99999f};
        val_12 = 1;
        this.<>4__this.animPanel.gameObject.SetActive(value:  true);
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_12;
        return (bool)val_12;
        label_1:
        this.<>1__state = 0;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
        this.<rt>5__2.anchoredPosition = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
        this.<rt>5__2.offsetMax = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
        val_11 = val_7.x;
        this.<rt>5__2.offsetMin = new UnityEngine.Vector2() {x = val_11, y = val_7.y};
        val_10 = this.<>4__this.animPanel.gameObject;
        val_10.SetActive(value:  false);
        label_3:
        val_12 = 0;
        return (bool)val_12;
        label_2:
        this.<>1__state = 0;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = 2;
        val_12 = 1;
        return (bool)val_12;
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
