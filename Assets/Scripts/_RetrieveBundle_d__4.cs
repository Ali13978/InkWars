using UnityEngine;
private sealed class CharacterAssetLoader.<RetrieveBundle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public CharacterAssetLoader <>4__this;
    public CharacterNameID inputCharID;
    public UnityEngine.Events.UnityAction<CharacterAssetLoader> callback;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharacterAssetLoader.<RetrieveBundle>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        CharacterNameID val_9;
        var val_10;
        int val_11;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_3;
        }
        
        val_8 = this.<>4__this;
        this.<>4__this.bundle = 0;
        mem2[0] = 0;
        val_9 = (this.<>4__this + 32) - 4;
        mem2[0] = this.inputCharID;
        val_10 = CharBundleManager.GetInstance();
        goto label_4;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.bundle = CharBundleManager.GetInstance().GetAssetBundle(charID:  this.<>4__this.charID, loaderRef:  this.<>4__this, firstCall:  false);
        goto label_10;
        label_3:
        mem[24] = 0;
        val_8 = 32;
        mem[32] = 0;
        val_9 = 28;
        mem[28] = this.inputCharID;
        val_10 = CharBundleManager.GetInstance();
        label_4:
        UnityEngine.AssetBundle val_5 = val_10.GetAssetBundle(charID:  val_9, loaderRef:  this.<>4__this, firstCall:  true);
        if((this.<>4__this) != null)
        {
                mem[32] = val_5;
        }
        else
        {
                mem[32] = val_5;
        }
        
        label_10:
        if((this.<>4__this.bundle) == 0)
        {
                val_11 = 1;
            this.<>2__current = 0;
            this.<>1__state = val_11;
            return (bool)val_11;
        }
        
        this.<>4__this.ready = true;
        val_11 = this.callback;
        if(val_11 == null)
        {
                return (bool)val_11;
        }
        
        val_11.Invoke(arg0:  this.<>4__this);
        label_2:
        val_11 = 0;
        return (bool)val_11;
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
