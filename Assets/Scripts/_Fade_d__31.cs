using UnityEngine;
private sealed class SelectStageController.<Fade>d__31 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float duration;
    public UnityEngine.UI.Image mat;
    public UnityEngine.Color startColor;
    public UnityEngine.Color endColor;
    private float <start>5__2;
    private float <elapsed>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SelectStageController.<Fade>d__31(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_6;
        int val_7;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<start>5__2 = UnityEngine.Time.time;
        this.<elapsed>5__3 = 0f;
        val_6 = 0f;
        goto label_3;
        label_1:
        val_6 = this.<elapsed>5__3;
        this.<>1__state = 0;
        label_3:
        if(val_6 < 0)
        {
            goto label_4;
        }
        
        label_2:
        val_7 = 0;
        return (bool)val_7;
        label_4:
        float val_2 = UnityEngine.Time.time;
        float val_3 = val_2 - (this.<start>5__2);
        this.<elapsed>5__3 = val_3;
        val_2 = val_3 / this.duration;
        UnityEngine.Color val_5 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.startColor, g = 0f, b = 1f}, b:  new UnityEngine.Color() {r = this.endColor}, t:  UnityEngine.Mathf.Clamp(value:  val_2, min:  0f, max:  1f));
        this.mat.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
        val_7 = 1;
        this.<>2__current = 0;
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
