using UnityEngine;
private sealed class DemoCanvas.<LoadCharacterResources>d__50 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DemoCanvas <>4__this;
    public CharacterNameID nameID;
    public CharacterAvatarController avatar;
    public UnityEngine.UI.Image typeIcon;
    private CharacterAssetLoader <assetLoader>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DemoCanvas.<LoadCharacterResources>d__50(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Sprite val_7;
        CharacterAssetLoader val_8;
        System.Collections.IEnumerator val_9;
        int val_10;
        val_7 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        CharacterAssetLoader val_2 = this.<>4__this.gameObject.AddComponent<CharacterAssetLoader>();
        val_8 = val_7;
        this.<assetLoader>5__2 = val_2;
        val_9 = val_2.RetrieveBundle(inputCharID:  this.nameID, callback:  0);
        UnityEngine.Coroutine val_4 = this.<>4__this.StartCoroutine(routine:  val_9);
        goto label_7;
        label_1:
        val_8 = this.<assetLoader>5__2;
        this.<>1__state = 0;
        label_7:
        if((mem[this.<assetLoader>5__2] + 24) == 0)
        {
            goto label_9;
        }
        
        this.avatar.characterID = this.nameID;
        val_9 = this.<assetLoader>5__2.LoadAvatar_Main();
        this.avatar.SetAvatar(sp:  val_9);
        this.avatar.SetMask(aNewBgType:  0, updateAvatarMask:  false);
        this.avatar.AutoSetBg();
        val_7 = CharacterAssetLoader.LoadResource_CharacterStatTypeIcon(charNameID:  this.nameID);
        this.typeIcon.sprite = val_7;
        label_2:
        val_10 = 0;
        return (bool)val_10;
        label_9:
        val_10 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_10;
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
