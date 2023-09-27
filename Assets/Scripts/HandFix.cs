using UnityEngine;
public class HandFix : MonoBehaviour
{
    // Fields
    public bool FlipThis;
    public System.Collections.Generic.List<UnityEngine.GameObject> Unflip;
    public string TextSwap;
    public UnityEngine.Sprite ImageSwap;
    public bool isLeftHandOnly;
    public bool isRightHandOnly;
    
    // Methods
    private void Start()
    {
        var val_15;
        System.Collections.Generic.List<UnityEngine.GameObject> val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        UnityEngine.RectTransform val_27;
        val_22 = this;
        if(this.isLeftHandOnly != false)
        {
                val_23 = null;
            val_23 = null;
            if(DataStructs.UserDataDictionary.Settings.FlipNegateX == 1)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        
        }
        
        if(this.isRightHandOnly != false)
        {
                val_24 = null;
            val_24 = null;
            if(DataStructs.UserDataDictionary.Settings.FlipNegateX == 1)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        
        }
        
        val_25 = null;
        val_25 = null;
        if(DataStructs.UserDataDictionary.Settings.FlipNegateX == 1)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.TextSwap)) != true)
        {
                val_26 = this.GetComponent<UnityEngine.UI.Text>();
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.ImageSwap)) != false)
        {
                val_26 = this.GetComponent<UnityEngine.UI.Image>();
            val_27 = 0;
            val_26.sprite = this.ImageSwap;
        }
        
        if(this.FlipThis == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_11 = this.transform.localScale;
        this.transform.localScale = new UnityEngine.Vector3() {x = -val_11.x, y = val_11.y, z = val_11.z};
        val_22 = this.Unflip;
        List.Enumerator<T> val_13 = val_22.GetEnumerator();
        val_26 = 1152921528222554640;
        label_37:
        if((2140898432 & 1) == 0)
        {
            goto label_29;
        }
        
        System.Type val_16 = val_15.InitialType;
        if(val_16 == 0)
        {
            goto label_37;
        }
        
        UnityEngine.Vector3 val_19 = val_16.transform.localScale;
        val_16.transform.localScale = new UnityEngine.Vector3() {x = -val_19.x, y = val_19.y, z = val_19.z};
        goto label_37;
        label_29:
        val_15.Add(driver:  public System.Void List.Enumerator<UnityEngine.GameObject>::Dispose(), rectTransform:  val_27, drivenProperties:  null);
    }
    public HandFix()
    {
    
    }

}
