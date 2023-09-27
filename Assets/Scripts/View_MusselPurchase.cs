using UnityEngine;
public class View_MusselPurchase : MonoBehaviour
{
    // Fields
    public BuyMussels MusselAmount;
    public View_Panel_OutOfMussels OutOfMusselsScript;
    
    // Methods
    public void Purchase()
    {
        this.OutOfMusselsScript.Button_BuyMussels(mussels:  this.MusselAmount);
    }
    public View_MusselPurchase()
    {
    
    }

}
