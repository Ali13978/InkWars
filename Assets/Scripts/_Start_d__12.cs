using UnityEngine;
private sealed class Fading.<Start>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Fading <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Fading.<Start>d__12(int <>1__state)
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
        string val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_10 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_10;
        }
        
        this.<>1__state = 0;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_11 = 1152921505088102400;
        val_12 = val_1.m_Handle.name;
        val_13 = null;
        val_13 = null;
        if((System.String.op_Equality(a:  val_12, b:  Fading.ignoreFadeSceneName)) == false)
        {
            goto label_7;
        }
        
        if((this.<>4__this) == null)
        {
            goto label_8;
        }
        
        this.<>4__this.alpha = 0f;
        this.<>4__this.fadeDir = 0;
        goto label_9;
        label_1:
        this.<>1__state = 0;
        label_31:
        val_12 = 1152921505123246080;
        val_14 = null;
        val_14 = null;
        if(Scene_CharacterSelection_Adventure.ready == true)
        {
            goto label_12;
        }
        
        val_10 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_10;
        return (bool)val_10;
        label_7:
        val_15 = null;
        val_15 = null;
        if((Fading.allInstances.Contains(item:  this.<>4__this)) != true)
        {
                val_16 = null;
            val_16 = null;
            Fading.allInstances.Add(item:  this.<>4__this);
        }
        
        val_11 = 1152921504858337280;
        val_12 = BattleVSGates.instance;
        if(val_12 == 0)
        {
            goto label_25;
        }
        
        val_12 = BattleVSGates.instance;
        if(val_12.shutGates == false)
        {
            goto label_25;
        }
        
        UnityEngine.Object.Destroy(obj:  this.<>4__this);
        goto label_28;
        label_25:
        UnityEngine.SceneManagement.Scene val_7 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_7.m_Handle.name, b:  "Scene_CharacterSelection_Adventure")) == true)
        {
            goto label_31;
        }
        
        label_12:
        val_10 = 0;
        this.<>4__this.fadeDir = 0;
        return (bool)val_10;
        label_8:
        mem[44] = 0;
        mem[40] = 0;
        label_9:
        this.<>4__this.enabled = false;
        label_28:
        val_10 = 0;
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
