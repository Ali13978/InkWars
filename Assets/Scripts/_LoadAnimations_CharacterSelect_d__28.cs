using UnityEngine;
private sealed class CharAnimationController_Physical.<LoadAnimations_CharacterSelect>d__28 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public CharAnimationController_Physical <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharAnimationController_Physical.<LoadAnimations_CharacterSelect>d__28(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return false;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_3;
        }
        
        this.<>4__this.animationsLoaded = false;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_3:
        mem[40] = 0;
        label_4:
        if((UnityEngine.Object.op_Implicit(exists:  this.<>4__this.assetLoader)) == false)
        {
                return false;
        }
        
        label_6:
        if((this.<>4__this.assetLoader.ready) != false)
        {
                mem2[0] = this.<>4__this.assetLoader.LoadAnimation(animationName:  8);
            mem2[0] = this.<>4__this.assetLoader.LoadAnimation(animationName:  15);
            mem2[0] = this.<>4__this.assetLoader.LoadAnimation(animationName:  16);
            AnimationFrameData val_5 = this.<>4__this.assetLoader.Item[0];
            this.<>4__this.SetSizeBasedOnSprite(sprite:  val_5.sprite);
            this.<>4__this.playingAnimation = false;
            this.<>4__this.animationsLoaded = true;
            this.<>4__this.PlayAnimation(newAnimName:  8, forceOverride:  true);
            UnityEngine.Coroutine val_7 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.audioController.LoadAudio_CharacterSelect(assetLoader:  this.<>4__this.assetLoader));
            return false;
        }
        
        this.<>2__current = 0;
        this.<>1__state = 1;
        return false;
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
