using UnityEngine;
public class Movingwallpaper : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image template;
    private float speed;
    private int ind;
    private System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.UI.Image>> imagesList;
    
    // Methods
    private void Populate()
    {
        System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.UI.Image>> val_27;
        float val_28;
        float val_29;
        val_27 = 1152921525069039472;
        UnityEngine.Rect val_2 = this.template.GetComponent<UnityEngine.RectTransform>().rect;
        UnityEngine.Rect val_4 = this.template.GetComponent<UnityEngine.RectTransform>().rect;
        val_28 = val_4.m_XMin;
        int val_5 = UnityEngine.Screen.height;
        val_29 = val_28 * 0f;
        if(val_29 >= 0)
        {
                return;
        }
        
        var val_27 = 0;
        do
        {
            val_27 = this.imagesList;
            val_27.Add(item:  new System.Collections.Generic.List<UnityEngine.UI.Image>());
            int val_7 = UnityEngine.Screen.width;
            if((-val_2.m_XMin) < 0)
        {
                var val_26 = 0;
            do
        {
            int val_8 = UnityEngine.Screen.width;
            int val_9 = UnityEngine.Screen.height;
            var val_10 = (val_8 < 0) ? (val_8 + 1) : (val_8);
            val_10 = val_10 >> 1;
            float val_24 = (float)val_10;
            float val_25 = (float)((val_9 < 0) ? (val_9 + 1) : (val_9)) >> 1;
            val_24 = (-val_2.m_XMin) - val_24;
            val_25 = val_29 - val_25;
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.identity;
            val_27 = UnityEngine.Object.Instantiate<UnityEngine.UI.Image>(original:  this.template, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w}, parent:  this.transform);
            val_27.gameObject.SetActive(value:  true);
            val_27.GetComponent<UnityEngine.CanvasGroup>().alpha = 0.3f;
            val_27.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.one;
            val_27.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
            this.imagesList.Item[0].Add(item:  val_27);
            int val_22 = UnityEngine.Screen.width;
            val_26 = val_26 + 1;
            val_28 = val_2.m_XMin * 0f;
        }
        while(val_28 < 0);
        
        }
        
            val_27 = val_27 + 1;
            int val_23 = UnityEngine.Screen.height;
            val_29 = val_28 * (float)val_27;
        }
        while(val_29 < 0);
    
    }
    private void CheckForEdge()
    {
        var val_7;
        var val_35;
        UnityEngine.UI.Image val_36;
        float val_37;
        float val_38;
        float val_39;
        UnityEngine.UI.Image val_40;
        val_35 = this;
        val_36 = 1152921525069039472;
        UnityEngine.Rect val_2 = this.template.GetComponent<UnityEngine.RectTransform>().rect;
        val_37 = val_2.m_XMin;
        UnityEngine.Rect val_4 = this.template.GetComponent<UnityEngine.RectTransform>().rect;
        val_38 = val_4.m_XMin;
        List.Enumerator<T> val_5 = this.imagesList.GetEnumerator();
        val_39 = 0.3f;
        goto label_6;
        label_31:
        val_36 = val_7.InitialType;
        val_40 = public UnityEngine.UI.Image System.Collections.Generic.List<UnityEngine.UI.Image>::get_Item(int index);
        UnityEngine.Vector3 val_11 = val_36.Item[0].transform.localPosition;
        val_38 = val_11.x;
        int val_12 = UnityEngine.Screen.width;
        var val_14 = ((-val_12) < 0) ? (1 - val_12) : (-val_12);
        val_14 = val_14 >> 1;
        if(val_38 >= (float)val_14)
        {
                UnityEngine.Object.Destroy(obj:  val_36.Item[val_36.Count - 1]);
            val_36.RemoveAt(index:  val_36.Count - 1);
            int val_20 = UnityEngine.Screen.width;
            int val_21 = UnityEngine.Screen.height;
            var val_22 = (val_20 < 0) ? (val_20 + 1) : (val_20);
            val_22 = val_22 >> 1;
            float val_24 = val_37 * 0f;
            float val_35 = (float)val_22;
            val_35 = (-val_38) - val_35;
            val_24 = val_24 - ((float)((val_21 < 0) ? (val_21 + 1) : (val_21)) >> 1);
            UnityEngine.Quaternion val_26 = UnityEngine.Quaternion.identity;
            val_36 = UnityEngine.Object.Instantiate<UnityEngine.UI.Image>(original:  this.template, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_26.x, y = val_26.y, z = val_26.z, w = val_26.w}, parent:  this.transform);
            val_36.gameObject.SetActive(value:  true);
            val_39 = val_39;
            val_36.GetComponent<UnityEngine.CanvasGroup>().alpha = val_39;
            val_36.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.one;
            val_38 = val_33.x;
            val_36.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = val_38, y = val_33.y, z = val_33.z};
            val_37 = val_37;
            val_40 = val_36;
            this.imagesList.Item[0].Insert(index:  0, item:  val_40);
        }
        
        label_6:
        if(((-1316710192) & 1) != 0)
        {
            goto label_31;
        }
        
        val_7.Add(driver:  public System.Void List.Enumerator<System.Collections.Generic.List<UnityEngine.UI.Image>>::Dispose(), rectTransform:  val_40, drivenProperties:  public System.Void System.Collections.Generic.List<UnityEngine.UI.Image>::Insert(int index, UnityEngine.UI.Image item));
    }
    private void MoveImages()
    {
        var val_3;
        var val_17;
        var val_18;
        val_17 = this;
        List.Enumerator<T> val_1 = this.imagesList.GetEnumerator();
        var val_18 = 0;
        label_24:
        if(((-1316503952) & 1) == 0)
        {
            goto label_2;
        }
        
        List.Enumerator<T> val_5 = val_3.InitialType.GetEnumerator();
        label_11:
        if(((-1316503984) & 1) == 0)
        {
            goto label_4;
        }
        
        System.Type val_6 = val_3.InitialType;
        UnityEngine.Vector3 val_8 = val_6.transform.localPosition;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  UnityEngine.Time.deltaTime * this.speed);
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        val_6.transform.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        goto label_11;
        label_4:
        val_18 = val_18 + 1;
        val_18 = 0;
        mem2[0] = 111;
        val_3.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Image>::Dispose(), rectTransform:  null, drivenProperties:  null);
        if(val_18 != 1)
        {
                var val_15 = ((1152921529060146720 + ((0 + 1)) << 2) == 111) ? 1 : 0;
            val_15 = ((val_18 >= 0) ? 1 : 0) & val_15;
            val_18 = val_18 - val_15;
        }
        
        this.CheckForEdge();
        goto label_24;
        label_2:
        var val_17 = val_18 + 1;
        mem2[0] = 142;
        val_3.Add(driver:  public System.Void List.Enumerator<System.Collections.Generic.List<UnityEngine.UI.Image>>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    private void Start()
    {
        this.Populate();
    }
    private void Update()
    {
        this.MoveImages();
    }
    public Movingwallpaper()
    {
        this.speed = 5f;
        this.ind = 2;
        this.imagesList = new System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.UI.Image>>();
    }

}
