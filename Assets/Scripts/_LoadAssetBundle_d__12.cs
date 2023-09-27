using UnityEngine;
private sealed class CharBundleManager.<LoadAssetBundle>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public CharBundleManager <>4__this;
    public CharacterNameID charID;
    private UnityEngine.WWW <www>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharBundleManager.<LoadAssetBundle>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        string val_7;
        UnityEngine.WWW val_8;
        int val_9;
        val_6 = 0;
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
                return (bool)val_6;
        }
        
        this.<>1__state = 0;
        val_7 = 0.GetBundlePath(charID:  this.charID);
        UnityEngine.WWW val_2 = null;
        val_8 = val_2;
        val_2 = new UnityEngine.WWW(url:  val_7);
        this.<www>5__2 = val_8;
        if(val_8 != null)
        {
            goto label_8;
        }
        
        goto label_6;
        label_1:
        val_9 = 0;
        goto label_7;
        label_2:
        val_8 = this.<www>5__2;
        this.<>1__state = 0;
        if(val_8 != null)
        {
            goto label_8;
        }
        
        label_6:
        label_8:
        if(val_8.isDone != false)
        {
                val_7 = CharBundleManager.charBundles;
            UnityEngine.AssetBundle[] val_5 = val_7 + ((this.charID) << 3);
            (CharBundleManager.charBundles + (this.charID) << 3).__unknownFiledOffset_20 = this.<www>5__2.assetBundle;
            val_9 = 2;
        }
        else
        {
                val_9 = 1;
        }
        
        val_6 = 1;
        this.<>2__current = 0;
        label_7:
        this.<>1__state = val_9;
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
