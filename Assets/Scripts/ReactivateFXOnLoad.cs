using UnityEngine;
public class ReactivateFXOnLoad : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject postEffect;
    public UnityEngine.GameObject preEffect;
    
    // Methods
    private void Start()
    {
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.postEffect.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0f, snapping:  false);
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.preEffect.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0f, snapping:  false);
        UnityEngine.Debug.Log(message:  "Running particles");
        SeventyOneSquared.PDUnity val_5 = this.postEffect.GetComponentInChildren<SeventyOneSquared.PDUnity>();
        val_5.Running = true;
        SeventyOneSquared.PDUnity val_6 = this.preEffect.GetComponentInChildren<SeventyOneSquared.PDUnity>();
        val_6.Running = true;
    }
    public void ResetPosition()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.postEffect.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0f, snapping:  false);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.preEffect.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0f, snapping:  false);
    }
    public ReactivateFXOnLoad()
    {
    
    }

}
