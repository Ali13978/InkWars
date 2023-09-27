using UnityEngine;
private sealed class playSceneCanvas.<Start>d__31 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public playSceneCanvas <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public playSceneCanvas.<Start>d__31(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        playSceneCanvas val_16;
        int val_17;
        ActivateOnStart val_18;
        var val_19;
        UnityEngine.Sprite val_20;
        var val_21;
        val_17 = 0;
        if((this.<>1__state) >= 2)
        {
                return (bool)val_17;
        }
        
        this.<>1__state = 0;
        val_16 = this.<>4__this;
        val_18 = ActivateOnStart.Instance;
        if(ActivateOnStart.Instance.sceneHolderReady == false)
        {
            goto label_3;
        }
        
        GameAudio.sound.UnPause();
        this.<>4__this.LifeBox.SetActive(value:  false);
        this.<>4__this.shellBox.SetActive(value:  false);
        UnityEngine.Coroutine val_2 = val_16.StartCoroutine(methodName:  "instantiateObjects");
        this.<>4__this.restartPanel.SetActive(value:  false);
        this.<>4__this.outOfLives.SetActive(value:  false);
        this.<>4__this.instructionScreen.SetActive(value:  false);
        this.<>4__this.PanelOption.SetActive(value:  false);
        this.<>4__this.panelOptionBack.SetActive(value:  false);
        val_19 = null;
        val_19 = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
            goto label_17;
        }
        
        UnityEngine.GameObject val_3 = UnityEngine.GameObject.Find(name:  "Button_Pause");
        if((UnityEngine.Object.op_Implicit(exists:  val_3)) == false)
        {
            goto label_23;
        }
        
        if(NetworkManager_Custom.IsNetwork == false)
        {
            goto label_22;
        }
        
        val_3.SetActive(value:  false);
        goto label_23;
        label_3:
        val_17 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_17;
        return (bool)val_17;
        label_22:
        System.Type val_16 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_8 = UnityEngine.Resources.Load(path:  "PVP_Button_Pause", systemTypeInstance:  val_16);
        if(val_8 != null)
        {
                val_16 = (null == null) ? (val_8) : 0;
        }
        else
        {
                val_20 = 0;
        }
        
        val_3.GetComponent<UnityEngine.UI.Image>().sprite = val_20;
        label_23:
        val_18 = this.<>4__this.VsPlayerObjectsToActivate;
        val_21 = 0;
        goto label_30;
        label_37:
        UnityEngine.GameObject val_17 = val_18[0];
        if((UnityEngine.Object.op_Implicit(exists:  val_17)) != false)
        {
                val_17.SetActive(value:  true);
        }
        
        val_21 = 1;
        label_30:
        if(val_21 < (this.<>4__this.VsPlayerObjectsToActivate.Length))
        {
            goto label_37;
        }
        
        label_17:
        if(val_16 != null)
        {
                val_16.InvokeRepeating(methodName:  "LifeTimer", time:  0f, repeatRate:  0.1f);
        }
        else
        {
                val_16.InvokeRepeating(methodName:  "LifeTimer", time:  0f, repeatRate:  0.1f);
        }
        
        val_16.HideAdButtons();
        val_16 = 1152921504864088064;
        UnityEngine.SceneManagement.Scene val_10 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if(((System.String.op_Equality(a:  val_10.m_Handle.name, b:  "PlaySceneVs")) != false) && (NetworkManager_Custom.IsNetwork != false))
        {
                if(PlayerPrefsManager.Shells > 0)
        {
                int val_15 = PlayerPrefsManager.Shells;
            val_15 = val_15 - 1;
            playSceneCanvas.Shells = val_15;
        }
        else
        {
                UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "NetworkReset");
        }
        
        }
        
        val_17 = 0;
        return (bool)val_17;
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
