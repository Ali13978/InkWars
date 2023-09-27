using UnityEngine;
private sealed class instructionMenuHandler.<instantiateObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public instructionMenuHandler <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public instructionMenuHandler.<instantiateObjects>d__52(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        var val_6;
        CharacterNameID val_11;
        instructionMenuHandler val_13;
        ActivateOnStart val_14;
        UnityEngine.Sprite val_15;
        int val_16;
        UnityEngine.Sprite val_17;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        val_13 = this.<>4__this;
        val_14 = ActivateOnStart.Instance;
        if(ActivateOnStart.Instance.sceneHolderReady == false)
        {
            goto label_3;
        }
        
        CharacterInfo val_2 = Character_GlobalInfo.GetMainPlayer();
        if(val_3 == 2)
        {
            goto label_9;
        }
        
        if(val_3 == 1)
        {
            goto label_8;
        }
        
        if(val_3 != 0)
        {
            goto label_9;
        }
        
        val_15 = this.<>4__this.ikaStrip;
        goto label_14;
        label_1:
        if((this.<>1__state) != 0)
        {
            goto label_11;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_4 = null;
        val_13 = val_4;
        val_4 = new UnityEngine.WaitForSeconds(seconds:  0.01f);
        val_16 = 1;
        this.<>2__current = val_13;
        this.<>1__state = val_16;
        return (bool)val_16;
        label_3:
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_16 = 1;
        return (bool)val_16;
        label_9:
        val_15 = this.<>4__this.mermaidStrip;
        goto label_14;
        label_8:
        val_15 = this.<>4__this.takoStrip;
        label_14:
        this.<>4__this.Player1Bar.sprite = mem[this.<>4__this.takoStrip];
        CharacterInfo val_5 = Character_GlobalInfo.GetOpponentPlayer();
        if(val_6 == 2)
        {
            goto label_18;
        }
        
        if(val_6 == 1)
        {
            goto label_17;
        }
        
        if(val_6 != 0)
        {
            goto label_18;
        }
        
        val_17 = this.<>4__this.ikaStrip;
        goto label_20;
        label_18:
        val_17 = this.<>4__this.mermaidStrip;
        goto label_20;
        label_17:
        val_17 = this.<>4__this.takoStrip;
        label_20:
        this.<>4__this.Player2Bar.sprite = mem[this.<>4__this.takoStrip];
        if(NetworkManager_Custom.IsNetwork != false)
        {
                string val_8 = PlayerPrefsManager.PlayerName;
            string val_9 = PlayerPrefsManager.Player2Name;
            if((this.<>4__this.Player2Name) != null)
        {
            goto label_25;
        }
        
        }
        
        label_25:
        CharacterInfo val_10 = Character_GlobalInfo.GetMainPlayer();
        UnityEngine.Events.UnityAction<CharacterAssetLoader> val_12 = null;
        val_14 = val_12;
        val_12 = new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  val_13, method:  System.Void instructionMenuHandler::<instantiateObjects>b__52_0(CharacterAssetLoader loader));
        CharacterAssetLoader.Get(id:  val_11, callback:  val_12);
        label_11:
        val_16 = 0;
        return (bool)val_16;
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
