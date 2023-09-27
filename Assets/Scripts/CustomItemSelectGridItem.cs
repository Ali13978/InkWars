using UnityEngine;
public class CustomItemSelectGridItem : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image thumbnailsImg;
    private UnityEngine.UI.Button button;
    private UnityEngine.UI.Image vipIconImg;
    private UnityEngine.UI.Image equippedIconImg;
    public CustomItemSelectGrid parentGrid;
    private int itemId;
    
    // Properties
    public int id { get; }
    
    // Methods
    public int get_id()
    {
        return (int)this.itemId;
    }
    private void OnEnable()
    {
        this.button.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void CustomItemSelectGridItem::OnSelect()));
    }
    private void OnDisable()
    {
        this.button.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void CustomItemSelectGridItem::OnSelect()));
    }
    public void OnSelect()
    {
        if(0 == this.parentGrid)
        {
                return;
        }
        
        0.OnItemSelect(id:  this.itemId);
    }
    public void Setup(int id)
    {
        this.itemId = id;
        if(((id & 2147483648) == 0) && (((CustomItemCanvas.<itemGroup>k__BackingField) & 1) != 0))
        {
                this.SetupThumbnails(id:  id);
            this.SetupVIPIcon(id:  id);
            this.SetEquippedIconEnable(eanble:  (CustomItemCanvas.<itemGroup>k__BackingField) & 1);
            return;
        }
        
        this.gameObject.name = id.ToString();
        this.thumbnailsImg.sprite = 0;
        this.vipIconImg.sprite = 0;
        this.gameObject.SetActive(value:  false);
    }
    public void SetEquippedIconEnable(bool eanble)
    {
        if(0 == this.equippedIconImg)
        {
                return;
        }
        
        this.equippedIconImg.gameObject.SetActive(value:  eanble);
    }
    private void SetupThumbnails(int id)
    {
        this.thumbnailsImg.sprite = CustomItemCanvas.<itemGroup>k__BackingField;
        CustomItemCanvas.<itemGroup>k__BackingField.SetAlpha(img:  this.thumbnailsImg, alpha:  ((CustomItemCanvas.<itemGroup>k__BackingField) != 1) ? 1f : 0.5f);
        UnityEngine.Object val_5 = this.thumbnailsImg.sprite;
        val_5 = UnityEngine.Object.op_Inequality(x:  0, y:  val_5);
        this.gameObject.SetActive(value:  val_5);
    }
    private void SetupVIPIcon(int id)
    {
        CustomItemGroupBase val_6;
        var val_7;
        bool val_8;
        if(((CustomItemCanvas.<itemGroup>k__BackingField) & 1) != 0)
        {
                val_7 = this.vipIconImg.gameObject;
            val_8 = 0;
        }
        else
        {
                val_6 = CustomItemCanvas.<itemGroup>k__BackingField;
            VIPMedal.SetupVIPSquareIcon(img:  this.vipIconImg, level:  CustomItemCanvas.<itemGroup>k__BackingField, alpha:  (val_6 != 1) ? 1f : 0.5f);
            val_7 = this.vipIconImg.gameObject;
            val_8 = UnityEngine.Object.op_Inequality(x:  0, y:  this.vipIconImg.sprite);
        }
        
        val_7.SetActive(value:  val_8);
    }
    private void SetAlpha(UnityEngine.UI.Image img, float alpha)
    {
        UnityEngine.Color val_1 = img.color;
        img.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = alpha};
    }
    public CustomItemSelectGridItem()
    {
        this.itemId = 0;
    }

}
