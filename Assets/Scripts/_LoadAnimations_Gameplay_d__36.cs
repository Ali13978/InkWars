using UnityEngine;
private sealed class CharAnimationController.<LoadAnimations_Gameplay>d__36 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public CharAnimationController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharAnimationController.<LoadAnimations_Gameplay>d__36(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        CharacterAssetLoader val_9;
        int val_10;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_9;
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
        val_9 = this.<>4__this.assetLoader;
        if((UnityEngine.Object.op_Implicit(exists:  val_9)) == false)
        {
            goto label_9;
        }
        
        label_6:
        val_9 = this.<>4__this.assetLoader;
        if((this.<>4__this.assetLoader.ready) == false)
        {
            goto label_11;
        }
        
        CharacterAllAnimations val_2 = this.<>4__this.assetLoader.LoadAnimations_All();
        this.<>4__this.postAttackAnimDuration = 0f;
        if(0 == (this.<>4__this.assetLoader))
        {
            goto label_27;
        }
        
        List.Enumerator<T> val_4 = this.<>4__this.assetLoader.GetEnumerator();
        goto label_20;
        label_22:
        System.Type val_5 = 0.InitialType;
        this.<>4__this.postAttackAnimDuration = (this.<>4__this.postAttackAnimDuration) + S0;
        label_20:
        if(((-21638152) & 1) != 0)
        {
            goto label_22;
        }
        
        0.Add(driver:  public System.Void List.Enumerator<AnimationFrameData>::Dispose(), rectTransform:  0, drivenProperties:  null);
        goto label_27;
        label_11:
        val_10 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_10;
        return (bool)val_10;
        label_27:
        this.<>4__this.playingAnimation = false;
        this.<>4__this.animationsLoaded = true;
        this.<>4__this.PlayAnimation(newAnimName:  8, forceOverride:  false);
        val_9 = this.<>4__this.assetLoader;
        UnityEngine.Coroutine val_8 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.audioController.LoadAudio_Gameplay(assetLoader:  val_9));
        label_9:
        val_10 = 0;
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
