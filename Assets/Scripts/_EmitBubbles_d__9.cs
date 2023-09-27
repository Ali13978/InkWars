using UnityEngine;
private sealed class Generator.<EmitBubbles>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Generator <>4__this;
    private Generator.<>c__DisplayClass9_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Generator.<EmitBubbles>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Generator.<>c__DisplayClass9_0 val_8;
        UnityEngine.Vector2 val_9;
        int val_10;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        val_8 = this.<>8__1;
        this.<>1__state = 0;
        goto label_3;
        label_1:
        val_8 = this;
        this.<>1__state = 0;
        this.<>8__1.particle = 0;
        this.<>4__this.m_PooledParticlesList.ForEach(action:  new System.Action<UnityEngine.ParticleSystem>(object:  null, method:  System.Void Generator.<>c__DisplayClass9_0::<EmitBubbles>b__0(UnityEngine.ParticleSystem obj)));
        if(0 != (this.<>8__1.particle))
        {
                UnityEngine.Transform val_3 = this.<>8__1.particle.transform;
            UnityEngine.Vector3 val_4 = val_3.GenerateRandomPosition();
            val_3.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            this.<>8__1.particle.Play();
        }
        
        this.<>8__1 = 0;
        label_3:
        this.<>8__1 = new Generator.<>c__DisplayClass9_0();
        if((this.<>4__this) == null)
        {
            goto label_16;
        }
        
        val_9 = this.<>4__this.m_RandomSpawnRate;
        goto label_17;
        label_2:
        val_10 = 0;
        return (bool)val_10;
        label_16:
        val_9 = 5.053295E-37f;
        label_17:
        val_10 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  UnityEngine.Random.Range(min:  val_9, max:  val_4.y));
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
