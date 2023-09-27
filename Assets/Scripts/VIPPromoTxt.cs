using UnityEngine;
public class VIPPromoTxt : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI promoTxt;
    private UnityEngine.GameObject bonusObject;
    private TMPro.TextMeshProUGUI bonusTxt;
    
    // Methods
    public void SetPromoTxt(string promoInfo)
    {
        if(0 == this.promoTxt)
        {
                return;
        }
        
        this.promoTxt.text = promoInfo;
    }
    public void EnablePromoBonus(bool enabled)
    {
        if(0 == this.bonusObject)
        {
                return;
        }
        
        this.bonusObject.SetActive(value:  enabled);
    }
    public void SetPromoBonus(string bonusInfo)
    {
        if(0 == this.bonusTxt)
        {
                return;
        }
        
        this.bonusTxt.text = bonusInfo;
    }
    public VIPPromoTxt()
    {
    
    }

}
