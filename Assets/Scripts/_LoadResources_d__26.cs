using UnityEngine;
private sealed class CharacterStore_Controller.<LoadResources>d__26 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public CharacterStore_Controller <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharacterStore_Controller.<LoadResources>d__26(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        CharacterAssetLoader val_20;
        CharacterAssetLoader val_21;
        var val_22;
        int val_23;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_20 = this.<>4__this.gameObject.AddComponent<CharacterAssetLoader>();
        if((this.<>4__this) == null)
        {
            goto label_5;
        }
        
        this.<>4__this.assetLoader = val_20;
        goto label_6;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_5:
        mem[96] = val_20;
        val_20 = mem[96];
        label_6:
        UnityEngine.Coroutine val_4 = this.<>4__this.StartCoroutine(routine:  val_20.RetrieveBundle(inputCharID:  this.<>4__this.charNameID, callback:  0));
        this.<>4__this.canvasGroup.alpha = 0f;
        label_8:
        val_21 = this.<>4__this.assetLoader;
        if((this.<>4__this.assetLoader.ready) == false)
        {
            goto label_12;
        }
        
        this.<>4__this.charData = this.<>4__this.assetLoader.LoadCharacterData();
        if((Character_GlobalInfo.GetClan(characterId:  this.<>4__this.charNameID)) == 0)
        {
            goto label_16;
        }
        
        val_22 = 0;
        goto label_17;
        label_12:
        val_23 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_23;
        return (bool)val_23;
        label_16:
        label_17:
        this.<>4__this.avatarController.Init(cid:  this.<>4__this.charNameID, aNewMaskType:  1, reloadAvatar:  false, isFaceLeft:  ((this.<>4__this.charData.realPersonCharacter) == false) ? 1 : 0);
        this.<>4__this.avatarController.SetAvatar(sp:  this.<>4__this.assetLoader.LoadAvatar_Main());
        this.<>4__this.spriteDynamicPose = this.<>4__this.assetLoader.LoadPose_Dynamic();
        if((this.<>4__this.charData.realPersonCharacter) != false)
        {
                this.<>4__this.celebPhoto = this.<>4__this.assetLoader.LoadAvatar_Photo();
        }
        
        this.<>4__this.gameObject.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this.<>4__this, method:  public System.Void CharacterStore_Controller::SelectCharacterStart()));
        this.<>4__this.gameObject.GetComponent<UnityEngine.UI.Button>().interactable = true;
        this.<>4__this.loaded = true;
        DG.Tweening.TweenCallback val_18 = null;
        val_21 = val_18;
        val_18 = new DG.Tweening.TweenCallback(object:  this.<>4__this, method:  System.Void CharacterStore_Controller::<LoadResources>b__26_0());
        DG.Tweening.Tweener val_19 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.canvasGroup, endValue:  1f, duration:  1f), action:  val_18);
        label_2:
        val_23 = 0;
        return (bool)val_23;
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
