using UnityEngine;
private sealed class bossBattlePingPong.<PingPong>d__2 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bossBattlePingPong <>4__this;
    private float <startTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public bossBattlePingPong.<PingPong>d__2(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        var val_11;
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
        this.<>4__this.InvokeRepeating(methodName:  "Ping", time:  0f, repeatRate:  0.02f);
        val_10 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1.5f);
        this.<>1__state = val_10;
        return (bool)val_10;
        label_1:
        val_11 = this;
        this.<>1__state = 0;
        if((this.<startTime>5__2) <= 1.01f)
        {
            goto label_6;
        }
        
        label_3:
        val_10 = 0;
        return (bool)val_10;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
                this.<>4__this.CancelInvoke(methodName:  "Ping");
        }
        else
        {
                0.CancelInvoke(methodName:  "Ping");
        }
        
        UnityEngine.Color val_4 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.<>4__this.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
        val_11 = this;
        this.<startTime>5__2 = 0f;
        label_6:
        float val_7 = UnityEngine.Mathf.Lerp(a:  1f, b:  0f, t:  this.<startTime>5__2);
        UnityEngine.Color val_8 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.<>4__this.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a};
        float val_10 = this.<startTime>5__2;
        val_10 = val_10 + 0.01f;
        this.<startTime>5__2 = val_10;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.05f);
        this.<>1__state = 2;
        val_10 = 1;
        return (bool)val_10;
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
