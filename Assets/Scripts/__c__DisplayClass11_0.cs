using UnityEngine;
private sealed class StarSpinAnim.<>c__DisplayClass11_0
{
    // Fields
    public StarSpinAnim <>4__this;
    public DG.Tweening.Sequence anim;
    public UnityEngine.SpriteRenderer star;
    
    // Methods
    public StarSpinAnim.<>c__DisplayClass11_0()
    {
    
    }
    internal void <SpinStar>b__0()
    {
        bool val_1 = this.<>4__this.animList.Remove(item:  this.anim);
        bool val_3 = this.<>4__this.starList.Remove(item:  this.star.gameObject);
        UnityEngine.Object.Destroy(obj:  this.star.gameObject);
    }

}
