using UnityEngine;
public class CharacterPromoMark : MonoBehaviour
{
    // Fields
    private DG.Tweening.Tweener tw;
    
    // Methods
    private void OnEnable()
    {
        IAPCharacterPromoGift.AddGiftUpdateListener(listener:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterPromoMark::SetupPromoMark()));
        IAPCharacterPromoGift.CheckPromoGift(showLoadingWhenProc:  false);
    }
    private void OnDisable()
    {
        IAPCharacterPromoGift.RemoveGiftUpdateListener(listener:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterPromoMark::SetupPromoMark()));
        if(this.tw == null)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.tw, complete:  false);
    }
    private void SetupPromoMark()
    {
        this.gameObject.SetActive(value:  IAPCharacterPromoGift.HasPromoGift());
        if(IAPCharacterPromoGift.HasPromoGift() == false)
        {
                return;
        }
        
        if(0 == this.transform.parent)
        {
                return;
        }
        
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  0.2f);
        this.tw = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOPunchScale(target:  this.transform.parent, punch:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, duration:  0.7f, vibrato:  1, elasticity:  1f), loops:  0, loopType:  0);
    }
    public CharacterPromoMark()
    {
    
    }

}
