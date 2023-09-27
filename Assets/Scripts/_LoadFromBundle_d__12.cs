using UnityEngine;
private sealed class InGameAvatarSetter.<LoadFromBundle>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public InGameAvatarSetter <>4__this;
    public CharacterNameID charNameID;
    public bool inked;
    public CharacterAvatarController avatar;
    private CharacterAssetLoader <assetLoader>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InGameAvatarSetter.<LoadFromBundle>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        CharacterAssetLoader val_10;
        CharacterAvatarController val_11;
        int val_13;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_20;
        }
        
        this.<>1__state = 0;
        CharacterAssetLoader val_2 = this.<>4__this.gameObject.AddComponent<CharacterAssetLoader>();
        val_10 = this;
        this.<assetLoader>5__2 = val_2;
        UnityEngine.Coroutine val_4 = this.<>4__this.StartCoroutine(routine:  val_2.RetrieveBundle(inputCharID:  this.charNameID, callback:  0));
        goto label_7;
        label_1:
        val_10 = this.<assetLoader>5__2;
        this.<>1__state = 0;
        label_7:
        val_11 = mem[this.<assetLoader>5__2];
        if((mem[this.<assetLoader>5__2] + 24) == 0)
        {
            goto label_9;
        }
        
        if((this.<assetLoader>5__2) == null)
        {
            goto label_10;
        }
        
        if(this.inked == false)
        {
            goto label_11;
        }
        
        label_14:
        UnityEngine.Sprite val_5 = this.<assetLoader>5__2.LoadAvatar_MainInked();
        goto label_12;
        label_9:
        val_13 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_13;
        return (bool)val_13;
        label_10:
        if(this.inked == true)
        {
            goto label_14;
        }
        
        label_11:
        label_12:
        this.avatar.characterID = this.charNameID;
        this.avatar.SetAvatar(sp:  this.<assetLoader>5__2.LoadAvatar_Main());
        val_11 = this.avatar;
        val_11.AutoSetBg();
        CharacterInfo val_7 = Character_GlobalInfo.GetOpponentPlayer();
        if(val_8 == this.charNameID)
        {
                val_13 = 0;
            this.<>4__this.inkedOpponentAvatar = mem[this.<assetLoader>5__2].LoadAvatar_MainInked();
            return (bool)val_13;
        }
        
        label_20:
        val_13 = 0;
        return (bool)val_13;
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
