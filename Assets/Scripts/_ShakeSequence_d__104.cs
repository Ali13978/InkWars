using UnityEngine;
private sealed class InteractiveTutorialManager.<ShakeSequence>d__104 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TutorialDataManager.PlayerData player;
    public InteractiveTutorialManager <>4__this;
    public float shake;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InteractiveTutorialManager.<ShakeSequence>d__104(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_8;
        float val_9;
        int val_10;
        if((this.<>1__state) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        UnityEngine.Transform val_1 = this.player.gameObject.transform;
        UnityEngine.Vector3 val_2 = this.player.originalPosition;
        val_8 = val_2.y;
        val_9 = val_2.z;
        if(this.shake > 0f)
        {
            goto label_5;
        }
        
        val_1.position = new UnityEngine.Vector3() {x = val_2.x, y = val_8, z = val_9};
        label_1:
        val_10 = 0;
        return (bool)val_10;
        label_5:
        UnityEngine.Vector3 val_3 = UnityEngine.Random.insideUnitSphere;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  this.<>4__this.shakeAmount);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_8, z = val_9}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        val_9 = val_5.z;
        val_1.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_9};
        val_8 = this.shake;
        float val_6 = UnityEngine.Time.deltaTime;
        val_6 = val_6 * (this.<>4__this.decreaseFactor);
        val_6 = val_8 - val_6;
        this.shake = val_6;
        val_10 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_10;
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
