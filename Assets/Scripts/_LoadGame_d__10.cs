using UnityEngine;
private sealed class PracticeModeCharacterSelectionConfirmButton.<LoadGame>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public PracticeModeCharacterSelectionConfirmButton <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PracticeModeCharacterSelectionConfirmButton.<LoadGame>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        var val_5;
        int val_6;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_4 = null;
        val_4 = null;
        Character_GlobalInfo.gameMode = 8;
        QuickPlayAiSettings.SetupQuickPlayBot();
        if((this.<>4__this) == null)
        {
            goto label_7;
        }
        
        if((this.<>4__this.characterList) != null)
        {
            goto label_17;
        }
        
        label_18:
        label_17:
        int val_1 = UnityEngine.Random.Range(min:  0, max:  this.<>4__this.characterList.Length);
        Character_GlobalInfo.SetRightPlayer(nameID:  this.<>4__this.characterList[((long)(int)(val_1)) << 2]);
        float val_2 = UnityEngine.Random.value;
        val_5 = null;
        val_5 = null;
        UnityEngine.Object.Destroy(obj:  MainTitleBackMusicHandler.instance.gameObject);
        val_6 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_6;
        return (bool)val_6;
        label_1:
        this.<>1__state = 0;
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "MVC_GameScene", minimumDelayInSeconds:  0f, autoHideLoadingScreen:  true);
        label_2:
        val_6 = 0;
        return (bool)val_6;
        label_7:
        if(0 != 0)
        {
            goto label_17;
        }
        
        goto label_18;
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
