using UnityEngine;
[Serializable]
public class GGPPurchasingManager.GGPPurchaseItem
{
    // Fields
    public string id;
    public string name;
    public GGPPurchasingManager.GGPPurchaseCategory category;
    public string price;
    public bool purchased;
    public int quantity;
    public string expires;
    public string app_id;
    
    // Methods
    public GGPPurchasingManager.GGPPurchaseItem()
    {
    
    }

}
