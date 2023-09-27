using UnityEngine;
public class VIPPanelGroup : MonoBehaviour
{
    // Fields
    private VIPPanel template;
    private System.Collections.Generic.List<VIPPanel> panelList;
    private bool savedStats;
    
    // Methods
    public void ShowPromo()
    {
        DynamicUISingleton<VIPPromoDialog>.Show();
    }
    public void Refresh()
    {
        this.Setup();
    }
    public void Setup()
    {
        this.Clear();
        var val_7 = 0;
        do
        {
            VIPPanel val_3 = UnityEngine.Object.Instantiate<VIPPanel>(original:  this.template, parent:  this.template.transform.parent);
            val_3.parent = this;
            if(val_7 != 0)
        {
                val_3.SetVip(level:  0, popular:  VIPCollection.IsPopular(level:  0));
        }
        else
        {
                val_3.SetBundle();
        }
        
            val_3.gameObject.SetActive(value:  true);
            this.panelList.Add(item:  val_3);
            val_7 = val_7 + 1;
        }
        while(val_7 != 5);
    
    }
    private void Clear()
    {
        if(this.panelList == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = this.panelList.GetEnumerator();
        label_9:
        if(((-1335136232) & 1) == 0)
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
        0.Add(driver:  public System.Void List.Enumerator<VIPPanel>::Dispose(), rectTransform:  null, drivenProperties:  null);
        this = this.panelList;
        this.Clear();
    }
    private void OnEnable()
    {
        this.RefreshAndSave();
    }
    private void RefreshAndSave()
    {
        var val_3;
        this.Setup();
        val_3 = null;
        this.savedStats = VIP.isVipActived;
    }
    private void Update()
    {
        var val_3 = null;
        var val_2 = (this.savedStats == true) ? 1 : 0;
        val_2 = VIP.isVipActived ^ val_2;
        if(val_2 == false)
        {
                return;
        }
        
        this.RefreshAndSave();
    }
    public VIPPanelGroup()
    {
        this.panelList = new System.Collections.Generic.List<VIPPanel>();
    }

}
