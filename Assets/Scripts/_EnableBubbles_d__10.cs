using UnityEngine;
private sealed class Generator.<EnableBubbles>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Generator <>4__this;
    private UnityEngine.ParticleSystem <particle>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Generator.<EnableBubbles>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_11;
        var val_12;
        int val_13;
        System.Collections.Generic.List<UnityEngine.ParticleSystem> val_14;
        var val_15;
        object val_16;
        int val_17;
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
        if((this.<>4__this) != null)
        {
            goto label_4;
        }
        
        val_11 = 5.053295E-37f;
        goto label_5;
        label_1:
        this.<>1__state = 0;
        label_20:
        UnityEngine.Vector3 val_2 = 0.GenerateRandomPosition();
        mem[this.<particle>5__2].transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        mem[this.<particle>5__2].Play();
        if((this.<>4__this) != null)
        {
            goto label_18;
        }
        
        val_12 = 36;
        mem[36] = 1;
        val_13 = mem[36];
        goto label_11;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_12;
        }
        
        val_14 = this.<>4__this.m_PooledParticlesList;
        goto label_13;
        label_3:
        val_15 = 0;
        return (bool)val_15;
        label_12:
        val_14 = 0;
        label_13:
        UnityEngine.ParticleSystem val_3 = val_14.Item[this.<>4__this.m_ParticleIndex];
        val_12 = this;
        this.<particle>5__2 = val_3;
        if(0 == val_3)
        {
            goto label_18;
        }
        
        if((this.<particle>5__2.isPlaying) == false)
        {
            goto label_20;
        }
        
        val_16 = 0;
        val_17 = 2;
        goto label_21;
        label_18:
        val_12 = this.<>4__this;
        val_13 = (this.<>4__this.m_ParticleIndex) + 1;
        mem2[0] = val_13;
        label_11:
        if(val_13 > ((this.<>4__this.m_PooledParticlesList.Count) - 1))
        {
                mem2[0] = 0;
        }
        
        this.<particle>5__2 = 0;
        label_4:
        val_11 = this.<>4__this.m_RandomSpawnRate;
        label_5:
        UnityEngine.WaitForSeconds val_9 = null;
        val_16 = val_9;
        val_9 = new UnityEngine.WaitForSeconds(seconds:  UnityEngine.Random.Range(min:  val_11, max:  val_2.y));
        val_17 = 1;
        label_21:
        val_15 = 1;
        this.<>2__current = val_16;
        this.<>1__state = val_17;
        return (bool)val_15;
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
