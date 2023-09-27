using UnityEngine;
private sealed class playSceneCanvas.<HideEffect>d__37 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public playSceneCanvas.<HideEffect>d__37(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        WinScreenParticleManager val_6;
        int val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_6 = this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_7 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
        this.<>1__state = 0;
        val_7 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_7;
        return (bool)val_7;
        label_1:
        this.<>1__state = 0;
        val_8 = null;
        val_8 = null;
        if(WinScreenParticleManager.instance.starsEarned >= 1)
        {
                val_9 = null;
            val_9 = null;
            UnityEngine.GameObject[].__il2cppRuntimeField_byval_arg.SetActive(value:  false);
        }
        
        val_10 = null;
        val_10 = null;
        if(WinScreenParticleManager.instance.starsEarned >= 2)
        {
                val_11 = null;
            val_11 = null;
            typeof(UnityEngine.GameObject[]).__il2cppRuntimeField_28.SetActive(value:  false);
        }
        
        val_12 = null;
        val_12 = null;
        val_6 = WinScreenParticleManager.instance;
        if(WinScreenParticleManager.instance.starsEarned < 3)
        {
            goto label_42;
        }
        
        val_13 = null;
        val_13 = null;
        UnityEngine.GameObject[].__il2cppRuntimeField_this_arg.SetActive(value:  false);
        goto label_42;
        label_2:
        this.<>1__state = 0;
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_2.m_Handle.name, b:  "PlayScene")) != false)
        {
                val_14 = null;
            val_14 = null;
            if(WinScreenParticleManager.instance.isWinScreenShown != false)
        {
                val_15 = null;
            val_15 = null;
            if(WinScreenParticleManager.instance.starsEarned >= 1)
        {
                val_16 = null;
            val_16 = null;
            UnityEngine.GameObject[].__il2cppRuntimeField_byval_arg.SetActive(value:  false);
        }
        
            val_17 = null;
            val_17 = null;
            if(WinScreenParticleManager.instance.starsEarned >= 2)
        {
                val_18 = null;
            val_18 = null;
            typeof(UnityEngine.GameObject[]).__il2cppRuntimeField_28.SetActive(value:  false);
        }
        
            val_19 = null;
            val_19 = null;
            if(WinScreenParticleManager.instance.starsEarned >= 3)
        {
                val_20 = null;
            val_20 = null;
            UnityEngine.GameObject[].__il2cppRuntimeField_this_arg.SetActive(value:  false);
        }
        
            this.<>2__current = new UnityEngine.WaitForEndOfFrame();
            this.<>1__state = 2;
            val_7 = 1;
            return (bool)val_7;
        }
        
        }
        
        label_42:
        val_7 = 0;
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
