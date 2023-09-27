using UnityEngine;
public class Utility
{
    // Methods
    public static void SetBoldTextWithBlackOutline(UnityEngine.UI.Text txtObj)
    {
        UnityEngine.Color val_1 = UnityEngine.Color.black;
        Utility.SetBoldTextWithOutline(txtOjb:  txtObj, outlineColor:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
    }
    public static void SetBoldTextWithOutline(UnityEngine.UI.Text txtOjb, UnityEngine.Color outlineColor)
    {
        UnityEngine.Object val_6;
        if(0 == txtOjb)
        {
                return;
        }
        
        val_6 = txtOjb.GetComponent<UnityEngine.UI.Outline>();
        if(0 == val_6)
        {
                val_6 = txtOjb.gameObject.AddComponent<UnityEngine.UI.Outline>();
        }
        
        val_6.effectColor = new UnityEngine.Color() {r = outlineColor.r, g = outlineColor.g, b = outlineColor.b, a = outlineColor.a};
        txtOjb.fontStyle = 1;
    }
    public Utility()
    {
    
    }

}
