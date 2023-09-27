using UnityEngine;
public class MotionPanel : MonoBehaviour
{
    // Fields
    public UnityEngine.Vector3 beginPos;
    public UnityEngine.Vector3 endPos;
    public float duration;
    public DG.Tweening.Ease ease;
    private DG.Tweening.Tweener anim;
    
    // Methods
    public void MoveTo(UnityEngine.Vector2 pos, float duration, DG.Tweening.Ease ease)
    {
        if(this.anim != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.anim, complete:  false);
        }
        
        this.anim = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector2() {x = pos.x, y = pos.y}, duration:  duration, snapping:  false), ease:  ease);
    }
    public void MoveToBegin()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.beginPos, y = V8.16B, z = V9.16B});
        this.MoveTo(pos:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, duration:  this.duration, ease:  this.ease);
    }
    public void MoveToEnd()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.endPos, y = V8.16B, z = V9.16B});
        this.MoveTo(pos:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, duration:  this.duration, ease:  this.ease);
    }
    public MotionPanel()
    {
        this.duration = 0.5f;
    }

}
