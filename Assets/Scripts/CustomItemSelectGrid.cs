using UnityEngine;
public class CustomItemSelectGrid : MonoBehaviour
{
    // Fields
    public const int MAX_ITEM_COUNT = 256;
    private static int <selectItemId>k__BackingField;
    private UnityEngine.UI.GridLayoutGroup grid;
    private CustomItemSelectGridItem template;
    private System.Collections.Generic.List<CustomItemSelectGridItem> items;
    private CustomItemSelectGridItem equippedItem;
    private bool init;
    
    // Properties
    public static int selectItemId { get; set; }
    
    // Methods
    public static int get_selectItemId()
    {
        return (int)CustomItemSelectGrid.<selectItemId>k__BackingField;
    }
    protected static void set_selectItemId(int value)
    {
        CustomItemSelectGrid.<selectItemId>k__BackingField = value;
    }
    public void Refresh()
    {
        if(this.init != true)
        {
                this.CreateInitObjects();
            this.init = true;
        }
        
        this.RebuildItems();
        this.RefreshEquippedItem();
    }
    public void RefreshSelectItem()
    {
        var val_4 = null;
        if((CustomItemSelectGrid.<>c.<>9__11_0) == null)
        {
            goto label_3;
        }
        
        label_13:
        CustomItemSelectGridItem val_1 = this.items.Find(match:  CustomItemSelectGrid.<>c.<>9__11_0);
        if(0 == val_1)
        {
                return;
        }
        
        val_1.Setup(id:  CustomItemSelectGrid.<selectItemId>k__BackingField);
        return;
        label_3:
        CustomItemSelectGrid.<>c.<>9__11_0 = new System.Predicate<CustomItemSelectGridItem>(object:  CustomItemSelectGrid.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CustomItemSelectGrid.<>c::<RefreshSelectItem>b__11_0(CustomItemSelectGridItem x));
        if(this.items != null)
        {
            goto label_13;
        }
        
        goto label_13;
    }
    public void RefreshEquippedItem()
    {
        if(0 == this.equippedItem)
        {
                return;
        }
        
        this.equippedItem.Setup(id:  CustomItemCanvas.<itemGroup>k__BackingField);
    }
    public void CleanEquippedIcon()
    {
        List.Enumerator<T> val_1 = this.items.GetEnumerator();
        label_4:
        if((2117547096 & 1) == 0)
        {
            goto label_2;
        }
        
        0.InitialType.SetEquippedIconEnable(eanble:  false);
        goto label_4;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<CustomItemSelectGridItem>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    public void OnItemSelect(int id)
    {
        CustomItemSelectGrid.<selectItemId>k__BackingField = id;
        CustomItemCanvas.infoPanel.Refresh();
    }
    private void RebuildItems()
    {
        var val_7;
        this.Clear();
        System.Collections.Generic.List<System.Int32> val_1 = this.GetSortedList();
        val_7 = 0;
        goto label_8;
        label_18:
        this.items.Item[0].Setup(id:  val_1.Item[0]);
        this.items.Item[0].gameObject.SetActive(value:  true);
        val_7 = 1;
        label_8:
        if(val_7 < val_1.Count)
        {
            goto label_18;
        }
    
    }
    public void SelectFirstItem()
    {
        CustomItemSelectGridItem val_1 = this.GetComponentInChildren<CustomItemSelectGridItem>();
        if(0 == val_1)
        {
                return;
        }
        
        val_1.OnSelect();
    }
    private System.Collections.Generic.List<int> GetSortedList()
    {
        var val_6;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
        System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
        var val_6 = 0;
        do
        {
            if((((CustomItemCanvas.<itemGroup>k__BackingField) & 1) != 0) && (((CustomItemCanvas.<itemGroup>k__BackingField) & 1) != 0))
        {
                if(((CustomItemCanvas.<itemGroup>k__BackingField) & 1) != 0)
        {
                val_6 = public System.Void System.Collections.Generic.List<System.Int32>::Add(System.Int32 item);
        }
        else
        {
                val_6 = public System.Void System.Collections.Generic.List<System.Int32>::Add(System.Int32 item);
        }
        
            val_2.Add(item:  0);
        }
        
            val_6 = val_6 + 1;
        }
        while(val_6 != 256);
        
        val_1.Sort(comparison:  new System.Comparison<System.Int32>(object:  this, method:  System.Int32 CustomItemSelectGrid::CompareItem(int id1, int id2)));
        val_2.Sort(comparison:  new System.Comparison<System.Int32>(object:  this, method:  System.Int32 CustomItemSelectGrid::CompareItem(int id1, int id2)));
        if(val_3 != null)
        {
                val_3.AddRange(collection:  val_1);
        }
        else
        {
                val_3.AddRange(collection:  val_1);
        }
        
        val_3.AddRange(collection:  val_2);
        return val_3;
    }
    private int CompareItem(int id1, int id2)
    {
        var val_2;
        if(id1 == id2)
        {
                val_2 = 0;
            return (int)(id1 <= id2) ? (-0) : 0;
        }
        
        if((CustomItemCanvas.<itemGroup>k__BackingField) > (CustomItemCanvas.<itemGroup>k__BackingField))
        {
                val_2 = 0;
            return (int)(id1 <= id2) ? (-0) : 0;
        }
        
        if((CustomItemCanvas.<itemGroup>k__BackingField) >= (CustomItemCanvas.<itemGroup>k__BackingField))
        {
                return (int)(id1 <= id2) ? (-0) : 0;
        }
        
        val_2 = 1;
        return (int)(id1 <= id2) ? (-0) : 0;
    }
    private CustomItemSelectGridItem CreateItem(int id)
    {
        CustomItemSelectGridItem val_3 = UnityEngine.Object.Instantiate<CustomItemSelectGridItem>(original:  this.template, parent:  this.template.transform.parent);
        if(0 == val_3)
        {
                return val_3;
        }
        
        val_3.Setup(id:  id);
        return val_3;
    }
    private void CreateInitObjects()
    {
        this.Clean_Hard();
        var val_3 = 256;
        do
        {
            CustomItemSelectGridItem val_1 = this.CreateItem(id:  0);
            val_1.parentGrid = this;
            if(0 != val_1)
        {
                this.items.Add(item:  val_1);
        }
        
            val_3 = val_3 - 1;
        }
        while(val_3 != 0);
    
    }
    private void Clean_Hard()
    {
        T[] val_2 = this.grid.gameObject.GetComponentsInChildren<CustomItemSelectGridItem>();
        if(val_2 == null)
        {
                return;
        }
        
        if(val_2.Length < 1)
        {
                return;
        }
        
        do
        {
            UnityEngine.Object.Destroy(obj:  val_2[0]);
        }
        while((0 + 1) < val_2.Length);
    
    }
    public void Clear()
    {
        var val_5;
        var val_6;
        val_5 = 0;
        val_6 = 0;
        goto label_1;
        label_10:
        CustomItemSelectGridItem val_1 = this.items.Item[0];
        if(0 != val_1)
        {
                if(val_1 != null)
        {
                val_1.Setup(id:  0);
        }
        else
        {
                val_1.Setup(id:  0);
        }
        
            val_1.gameObject.SetActive(value:  false);
        }
        
        val_5 = 1;
        val_6 = -1;
        label_1:
        if(val_5 < this.items.Count)
        {
            goto label_10;
        }
    
    }
    public CustomItemSelectGrid()
    {
        this.items = new System.Collections.Generic.List<CustomItemSelectGridItem>();
    }

}
