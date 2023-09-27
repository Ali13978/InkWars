using UnityEngine;
public class CustomItemVIPPromoPanel : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI promoTxt1;
    private TMPro.TextMeshProUGUI promoTxt2;
    private TMPro.TextMeshProUGUI promoTxt3;
    
    // Methods
    public void Refresh()
    {
        object[] val_1 = new object[3];
        val_1[0] = "<color=#9954AB><size=130%>";
        val_1[1] = VIP.GetTitleString(vipLevel:  CustomItemCanvas.<itemGroup>k__BackingField);
        val_1[2] = "</size></color>";
        this.promoTxt1.text = LanguageManager.GetTextFormat(key:  "LK.VIP.CUSTOM_ITEM.PROMO.TITLE1", list:  val_1);
        object[] val_4 = new object[3];
        val_4[0] = "<color=#9954AB><size=130%>";
        val_4[1] = VIP.GetUnlockedItemCountByLevel(targetLevel:  CustomItemCanvas.<itemGroup>k__BackingField, includeDefaults:  false);
        val_4[2] = "</size></color>";
        this.promoTxt2.text = LanguageManager.GetTextFormat(key:  "LK.VIP.CUSTOM_ITEM.PROMO.TITLE2", list:  val_4);
        object[] val_7 = new object[3];
        val_7[0] = "<color=#03CC9E>";
        val_7[1] = VIP.BasicDays;
        val_7[2] = "</color>";
        this.promoTxt3.text = LanguageManager.GetTextFormat(key:  "LK.VIP.CUSTOM_ITEM.PROMO.TITLE3", list:  val_7);
    }
    public CustomItemVIPPromoPanel()
    {
    
    }

}
