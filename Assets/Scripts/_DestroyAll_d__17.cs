using UnityEngine;
private sealed class DemoCollision.<DestroyAll>d__17 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DemoCollision <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DemoCollision.<DestroyAll>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_12;
        var val_13;
        int val_14;
        val_12 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_13 = this.<>4__this.gameObject;
        if((System.String.op_Equality(a:  val_13.name, b:  "Demo")) != false)
        {
                this.<>4__this.popPrefab.GetComponent<UnityEngine.Animator>().Play(stateName:  "Red", layer:  0, normalizedTime:  0f);
            this.<>4__this.popPrefab1.GetComponent<UnityEngine.Animator>().Play(stateName:  "Green", layer:  0, normalizedTime:  0f);
            this.<>4__this.popPrefab2.GetComponent<UnityEngine.Animator>().Play(stateName:  "Yellow", layer:  0, normalizedTime:  0f);
            this.<>4__this.popPrefab3.GetComponent<UnityEngine.Animator>().Play(stateName:  "Blue", layer:  0, normalizedTime:  0f);
            val_13 = this.<>4__this.popPrefab4.GetComponent<UnityEngine.Animator>();
            val_13.Play(stateName:  "Orange", layer:  0, normalizedTime:  0f);
            this.<>4__this.popPrefab5.GetComponent<UnityEngine.Animator>().Play(stateName:  "Purple", layer:  0, normalizedTime:  0f);
        }
        
        val_14 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  2f);
        this.<>1__state = val_14;
        return (bool)val_14;
        label_1:
        this.<>1__state = 0;
        val_12 = this.<>4__this.gameObject;
        UnityEngine.Object.Destroy(obj:  val_12);
        label_2:
        val_14 = 0;
        return (bool)val_14;
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
