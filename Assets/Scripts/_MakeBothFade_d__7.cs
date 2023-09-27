using UnityEngine;
private sealed class popTextScript.<MakeBothFade>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public popTextScript <>4__this;
    private float <tempTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public popTextScript.<MakeBothFade>d__7(int <>1__state)
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
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.7f);
        this.<>1__state = val_9;
        return (bool)val_9;
        label_1:
        this.<>1__state = 0;
        UnityEngine.Object.Destroy(obj:  this.<>4__this.popBlob);
        val_10 = this;
        if((this.<tempTime>5__2) >= 0f)
        {
            goto label_10;
        }
        
        label_3:
        val_9 = 0;
        return (bool)val_9;
        label_2:
        val_10 = this;
        this.<tempTime>5__2 = 1f;
        this.<>1__state = 0;
        label_10:
        UnityEngine.Color val_3 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.<>4__this.popBlobText.GetComponent<UnityEngine.UI.Text>().color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        UnityEngine.Color val_5 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.<>4__this.popBlobText.GetComponent<UnityEngine.UI.Outline>().effectColor = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
        UnityEngine.Color val_7 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.<>4__this.popBlobImage.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
        float val_9 = this.<tempTime>5__2;
        val_9 = val_9 + (-0.02f);
        this.<tempTime>5__2 = val_9;
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
