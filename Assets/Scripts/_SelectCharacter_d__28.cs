using UnityEngine;
private sealed class CharacterStore_Controller.<SelectCharacter>d__28 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public CharacterStore_Controller <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharacterStore_Controller.<SelectCharacter>d__28(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        CharacterStore_Controller val_10;
        var val_11;
        var val_12;
        int val_14;
        var val_15;
        CharacterNameID val_16;
        if((this.<>1__state) >= 2)
        {
            goto label_1;
        }
        
        val_10 = this.<>4__this;
        this.<>1__state = 0;
        if((this.<>4__this.loaded) == false)
        {
            goto label_3;
        }
        
        val_11 = null;
        val_11 = null;
        sceneCharacters.instance.currentCharacterController = val_10;
        val_12 = null;
        val_12 = null;
        if(CharacterStore_Controller.muteFirstButtonSoundForInit == false)
        {
            goto label_9;
        }
        
        CharacterStore_Controller.muteFirstButtonSoundForInit = false;
        goto label_12;
        label_3:
        val_14 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_14;
        return (bool)val_14;
        label_9:
        GameAudio.PlayButtonSound();
        label_12:
        sprite = this.<>4__this.spriteDynamicPose;
        sprite = CharacterAssetLoader.LoadResource_CharacterStatType(charNameID:  this.<>4__this.charNameID, left:  true);
        gameObject.SetActive(value:  true);
        text = this.<>4__this.charData.localizedText.nickName;
        val_15 = null;
        val_15 = null;
        val_16 = this.<>4__this.charNameID;
        CharacterNameID val_10 = val_16;
        val_10 = (~(DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  val_10))) & 1;
        val_10.SetUnlocked(unlocked:  val_10);
        if((this.<>4__this.charData.realPersonCharacter) != false)
        {
                SetActive(value:  true);
            val_10 = this.<>4__this.celebPhoto;
            val_16 = this.<>4__this.charData.localizedText.realPersonDescription;
            SetCelebInfo(photoSprite:  val_10, text:  val_16);
        }
        
        DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOFade(target:  sceneCharacters.instance.defaultCharacters, endValue:  1f, duration:  1f);
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions46.DOFade(target:  sceneCharacters.instance.defaultPower, endValue:  1f, duration:  1f);
        label_1:
        val_14 = 0;
        return (bool)val_14;
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
