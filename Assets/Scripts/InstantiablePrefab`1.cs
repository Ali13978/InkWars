using UnityEngine;
public abstract class InstantiablePrefab<T> : InteractiveUIElement
{
    // Fields
    protected static T m_Instance;
    protected DG.Tweening.Sequence m_AnimationSequence;
    
    // Methods
    public virtual void Show(float _duration = -1)
    {
        if((__RuntimeMethodHiddenParam + 24 + 192) != 0)
        {
                mem2[0] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem2[0] = _duration;
        if(this != null)
        {
                this.InitializeSequence();
            Variables val_1 = this.Options;
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  X22, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  val_1.Transparency, endValue:  1f, duration:  0.35f));
            if((__RuntimeMethodHiddenParam + 24 + 192 + 24) >= 0)
        {
                return;
        }
        
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this, action:  new DG.Tweening.TweenCallback(object:  __RuntimeMethodHiddenParam + 24 + 192, method:  __RuntimeMethodHiddenParam + 24 + 192 + 16));
            return;
        }
    
    }
    public override void Hide()
    {
        Variables val_1 = this.Options;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_1.Transparency, endValue:  0f, duration:  0.15f);
    }
    public void FadeOutAndDestroy(float _delay = 0)
    {
        if(0 == (__RuntimeMethodHiddenParam + 24 + 192 + 24 + 184))
        {
                return;
        }
        
        Variables val_2 = this.Options;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  val_2.Transparency, endValue:  0f, duration:  0.15f), delay:  _delay), action:  new DG.Tweening.TweenCallback(object:  this, method:  __RuntimeMethodHiddenParam + 24 + 192 + 40));
    }
    public static void FadeOutAndDestroyWithDelayFromOutsideOfClass(float _delay = 0)
    {
        var val_2;
        var val_3;
        var val_4;
        if(0 == (__RuntimeMethodHiddenParam + 24 + 192 + 24 + 184))
        {
                return;
        }
        
        val_2 = mem[__RuntimeMethodHiddenParam + 24 + 294];
        val_2 = __RuntimeMethodHiddenParam + 24 + 294;
        val_3 = __RuntimeMethodHiddenParam + 24;
        if((val_2 & 1) == 0)
        {
                val_3 = mem[__RuntimeMethodHiddenParam + 24];
            val_3 = __RuntimeMethodHiddenParam + 24;
            val_2 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_2 = __RuntimeMethodHiddenParam + 24 + 294;
        }
        
        val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 48];
        val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 48;
        if((val_2 & 1) == 0)
        {
                val_4 = val_4;
        }
    
    }
    public void DestroyComponent()
    {
        this.StopAnimation();
        UnityEngine.Object.Destroy(obj:  this);
    }
    public void DestroyInstance()
    {
        if(this != null)
        {
                this.StopAnimation();
        }
        else
        {
                this.StopAnimation();
        }
        
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    protected InstantiablePrefab<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    private void <FadeOutAndDestroy>b__4_0()
    {
        if(this == null)
        {
            
        }
    
    }

}
