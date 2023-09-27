using UnityEngine;
public class CustomItemBattleBonusInfoPanel : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI itemNameTxt;
    private TMPro.TextMeshProUGUI bonusDescTxt;
    private TMPro.TextMeshProUGUI totalBonusTitleTxt;
    private TMPro.TextMeshProUGUI itemBonusValueTxt;
    private TMPro.TextMeshProUGUI totalBonusValueTxt;
    private UnityEngine.UI.Image bonusIconImg;
    private BattleBonusCollection battleBonusCollection;
    
    // Methods
    private void Awake()
    {
        this.battleBonusCollection = BattleBonusCollection.Get();
    }
    public void Refresh()
    {
        this.itemNameTxt.text = CustomItemCanvas.<itemGroup>k__BackingField;
        this.bonusDescTxt.text = BattleBonusConfig.GetTypeString(type:  CustomItemCanvas.<itemGroup>k__BackingField);
        this.itemBonusValueTxt.text = BattleBonusConfig.GetFormatValueString(type:  CustomItemCanvas.<itemGroup>k__BackingField, value:  CustomItemCanvas.<itemGroup>k__BackingField);
        this.totalBonusValueTxt.text = BattleBonusConfig.GetFormatValueString(type:  CustomItemCanvas.<itemGroup>k__BackingField, value:  BattleBonusConfig.GetBonusValueForLocalPlayer(type:  CustomItemCanvas.<itemGroup>k__BackingField));
        this.totalBonusTitleTxt.text = LanguageManager.GetText(key:  "LK.CURRENT_ADVANTAGE");
        this.bonusIconImg.sprite = this.battleBonusCollection.GetSpriteByType(type:  CustomItemCanvas.<itemGroup>k__BackingField);
        UnityEngine.Object val_10 = this.bonusIconImg.sprite;
        val_10 = UnityEngine.Object.op_Inequality(x:  0, y:  val_10);
        this.bonusIconImg.gameObject.SetActive(value:  val_10);
    }
    public CustomItemBattleBonusInfoPanel()
    {
    
    }

}
