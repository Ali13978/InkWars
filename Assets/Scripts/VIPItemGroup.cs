using UnityEngine;
public class VIPItemGroup : MonoBehaviour
{
    // Fields
    private VIPItemTxtGroup itemTemplate;
    private System.Collections.Generic.List<VIPItemTxtGroup> items;
    
    // Methods
    public void SetVIPItems(int level, bool spaceForEmptyItems = True)
    {
        var val_10;
        var val_11;
        string val_12;
        var val_13;
        string val_14;
        var val_15;
        string val_16;
        val_10 = spaceForEmptyItems;
        this.Clear();
        if((VIPCollection.GetVipDataFromLevel(level:  level)) == null)
        {
                return;
        }
        
        if(val_1.unlockCharacters == false)
        {
            goto label_4;
        }
        
        val_11 = VIP.GetUnlockedCharacterCountByLevel(targetLevel:  level, isCeleb:  false, includeDefaults:  false);
        val_12 = LanguageManager.GetText(key:  "LK.VIP.ITEM.CHARACTERS");
        goto label_7;
        label_4:
        if(val_10 == false)
        {
            goto label_8;
        }
        
        val_12 = 0;
        val_11 = 0;
        label_7:
        this.AddItem(title:  val_12, count:  0, info:  0);
        label_8:
        if(val_1.unlockCelebs == false)
        {
            goto label_9;
        }
        
        val_13 = VIP.GetUnlockedCharacterCountByLevel(targetLevel:  level, isCeleb:  true, includeDefaults:  false);
        val_14 = LanguageManager.GetText(key:  "LK.VIP.ITEM.CELEBS");
        goto label_12;
        label_9:
        if(val_10 == false)
        {
            goto label_13;
        }
        
        val_14 = 0;
        val_13 = 0;
        label_12:
        this.AddItem(title:  val_14, count:  0, info:  0);
        label_13:
        if(val_1.unlockCustomizableItems != false)
        {
                this.AddItem(title:  LanguageManager.GetText(key:  "LK.VIP.ITEM.EQUIPS"), count:  VIP.GetUnlockedItemCountByLevel(targetLevel:  level, includeDefaults:  false), info:  0);
            val_10 = LanguageManager.GetText(key:  "LK.VIP.ITEM.BATTLE_BONUS");
            val_15 = VIP.GetUnlockedItemCountByLevel(targetLevel:  level, includeDefaults:  false);
            val_16 = val_10;
        }
        else
        {
                if(val_10 == false)
        {
                return;
        }
        
            this.AddItem(title:  0, count:  0, info:  0);
            val_16 = 0;
            val_15 = 0;
        }
        
        this.AddItem(title:  val_16, count:  0, info:  0);
    }
    public void SetBundleItems()
    {
        string val_5;
        var val_6;
        string val_7;
        this.Clear();
        if(VIPCollection.GetBundleData() == null)
        {
                return;
        }
        
        if(val_1.unlockBundle != false)
        {
                this.AddItem(title:  LanguageManager.GetText(key:  "LK.VIP.ITEM.CHARACTERS"), count:  3, info:  0);
            val_5 = LanguageManager.GetText(key:  "LK.VIP.ITEM.POWER_UPS.INFO");
            val_6 = 3;
            val_7 = LanguageManager.GetText(key:  "LK.VIP.ITEM.POWER_UPS");
        }
        else
        {
                this.AddItem(title:  0, count:  0, info:  0);
            val_7 = 0;
            val_6 = 0;
            val_5 = 0;
        }
        
        this.AddItem(title:  val_7, count:  0, info:  val_5);
        this.AddItem(title:  0, count:  0, info:  0);
        this.AddItem(title:  0, count:  0, info:  0);
    }
    public void AddItem(string title, int count, string info)
    {
        VIPItemTxtGroup val_7;
        object val_8;
        val_7 = this.itemTemplate;
        if(0 != val_7)
        {
            goto label_3;
        }
        
        val_8 = "Add VIP Item Fail: No VIP Item Template";
        goto label_6;
        label_3:
        val_7 = UnityEngine.Object.Instantiate<VIPItemTxtGroup>(original:  this.itemTemplate, parent:  this.itemTemplate.transform.parent);
        if(0 != val_7)
        {
            goto label_11;
        }
        
        val_8 = "Add VIP Item Fail: Create from template fail";
        label_6:
        UnityEngine.Debug.LogError(message:  val_8);
        return;
        label_11:
        if(val_7 != null)
        {
                val_7.SetTexts(title:  title, count:  count, info:  info);
        }
        else
        {
                val_7.SetTexts(title:  title, count:  count, info:  info);
        }
        
        val_7.gameObject.SetActive(value:  true);
        this.items.Add(item:  val_7);
    }
    private void OnDisable()
    {
        this.Clear();
    }
    private void Clear()
    {
        if(this.items == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = this.items.GetEnumerator();
        label_9:
        if(((-1339514840) & 1) == 0)
        {
            goto label_2;
        }
        
        System.Type val_2 = 0.InitialType;
        if(0 == val_2)
        {
            goto label_9;
        }
        
        UnityEngine.Object.Destroy(obj:  val_2.gameObject);
        goto label_9;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<VIPItemTxtGroup>::Dispose(), rectTransform:  null, drivenProperties:  null);
        this = this.items;
        this.Clear();
    }
    public VIPItemGroup()
    {
        this.items = new System.Collections.Generic.List<VIPItemTxtGroup>();
    }

}
