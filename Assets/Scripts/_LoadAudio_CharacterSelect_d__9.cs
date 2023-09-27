using UnityEngine;
private sealed class CharAudioController.<LoadAudio_CharacterSelect>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public CharAudioController <>4__this;
    public CharacterAssetLoader assetLoader;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharAudioController.<LoadAudio_CharacterSelect>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        CharacterAssetLoader val_3;
        CharacterAssetLoader val_4;
        var val_5;
        int val_6;
        val_3 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>4__this.audioLoaded = false;
        val_4 = val_3;
        if((UnityEngine.Object.op_Implicit(exists:  this.assetLoader)) == true)
        {
            goto label_6;
        }
        
        goto label_7;
        label_1:
        val_4 = this.assetLoader;
        this.<>1__state = 0;
        label_6:
        if((mem[this.assetLoader] + 24) == 0)
        {
            goto label_9;
        }
        
        if((this.<>4__this) == null)
        {
            goto label_10;
        }
        
        label_7:
        val_5 = 0;
        goto label_11;
        label_2:
        val_6 = 0;
        return (bool)val_6;
        label_9:
        val_6 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_6;
        return (bool)val_6;
        label_10:
        val_5 = 1;
        label_11:
        val_3 = this.assetLoader;
        mem2[0] = val_3.LoadAudio(audioName:  16);
        val_6 = 0;
        this.<>4__this.audioLoaded = true;
        return (bool)val_6;
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
