using UnityEngine;
private sealed class RevengeAnimationController.<LoadAvatarDynamicPose>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public CharacterAssetLoader _cl;
    public CharacterNameID _ID;
    public RevengeAnimationController <>4__this;
    public UnityEngine.UI.Image _image;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RevengeAnimationController.<LoadAvatarDynamicPose>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.UI.Image val_4;
        CharacterAssetLoader val_5;
        CharacterNameID val_6;
        int val_7;
        val_4 = this;
        if((this.<>1__state) == 1)
        {
            goto label_0;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_1;
        }
        
        val_5 = val_4;
        this.<>1__state = 0;
        this._cl.charID = this._ID;
        if(this._cl == null)
        {
            goto label_3;
        }
        
        val_6 = this._cl.charID;
        goto label_4;
        label_0:
        val_5 = this._cl;
        this.<>1__state = 0;
        goto label_5;
        label_3:
        val_6 = 0;
        label_4:
        UnityEngine.Coroutine val_2 = this.<>4__this.StartCoroutine(routine:  this._cl.RetrieveBundle(inputCharID:  val_6, callback:  0));
        label_5:
        if(this._cl.ready == false)
        {
            goto label_8;
        }
        
        val_4 = this._image;
        val_4.sprite = this._cl.LoadPose_Dynamic();
        label_1:
        val_7 = 0;
        return (bool)val_7;
        label_8:
        val_7 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_7;
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
