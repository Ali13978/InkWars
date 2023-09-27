using UnityEngine;
public class CustomItemPreview : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image gridImg;
    private UnityEngine.UI.Image switcherImg;
    private System.Collections.Generic.List<UnityEngine.UI.Image> bubbleImgs;
    
    // Methods
    public void Refresh()
    {
        if((CustomItemCanvas.<itemGroup>k__BackingField) == 4)
        {
            goto label_2;
        }
        
        if((CustomItemCanvas.<itemGroup>k__BackingField) == 3)
        {
            goto label_3;
        }
        
        if((CustomItemCanvas.<itemGroup>k__BackingField) != 1)
        {
                return;
        }
        
        this.SetupGrid();
        return;
        label_2:
        this.SetupBubble();
        return;
        label_3:
        this.SetupSwitcher();
    }
    private void SetupGrid()
    {
        this.CleanAll();
        this.gridImg.sprite = CustomItemCanvas.<itemGroup>k__BackingField;
        UnityEngine.Object val_4 = this.gridImg.sprite;
        val_4 = UnityEngine.Object.op_Inequality(x:  0, y:  val_4);
        this.gridImg.gameObject.SetActive(value:  val_4);
    }
    private void SetupSwitcher()
    {
        this.CleanAll();
        this.switcherImg.sprite = CustomItemCanvas.<itemGroup>k__BackingField;
        UnityEngine.Object val_4 = this.switcherImg.sprite;
        val_4 = UnityEngine.Object.op_Inequality(x:  0, y:  val_4);
        this.switcherImg.gameObject.SetActive(value:  val_4);
    }
    private void SetupBubble()
    {
        var val_10;
        this.CleanAll();
        val_10 = 0;
        goto label_6;
        label_20:
        if(0 == this.bubbleImgs.Item[0])
        {
                val_10 = 1;
        }
        else
        {
                this.bubbleImgs.Item[0].sprite = CustomItemCanvas.<itemGroup>k__BackingField;
            UnityEngine.Object val_10 = this.bubbleImgs.Item[0].sprite;
            val_10 = UnityEngine.Object.op_Inequality(x:  0, y:  val_10);
            this.bubbleImgs.Item[0].gameObject.SetActive(value:  val_10);
            val_10 = 1;
        }
        
        label_6:
        if(val_10 < this.bubbleImgs.Count)
        {
            goto label_20;
        }
    
    }
    private void CleanAll()
    {
        System.Collections.Generic.List<UnityEngine.UI.Image> val_7;
        this.gridImg.gameObject.SetActive(value:  false);
        this.switcherImg.gameObject.SetActive(value:  false);
        val_7 = this.bubbleImgs;
        List.Enumerator<T> val_3 = val_7.GetEnumerator();
        label_12:
        if((2116668888 & 1) == 0)
        {
            goto label_6;
        }
        
        System.Type val_4 = 0.InitialType;
        if(0 == val_4)
        {
            goto label_12;
        }
        
        val_4.gameObject.SetActive(value:  false);
        goto label_12;
        label_6:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Image>::Dispose(), rectTransform:  0, drivenProperties:  null);
    }
    public CustomItemPreview()
    {
        this.bubbleImgs = new System.Collections.Generic.List<UnityEngine.UI.Image>();
    }

}
