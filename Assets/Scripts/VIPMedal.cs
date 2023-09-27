using UnityEngine;
public class VIPMedal : MonoBehaviour
{
    // Fields
    private int vipLevel;
    private UnityEngine.GameObject popularTagObject;
    private UnityEngine.UI.Image medalImg;
    private TMPro.TextMeshProUGUI titleTxt;
    
    // Methods
    public static void SetupVIPSquareIcon(UnityEngine.UI.Image img, int level, float alpha = 1)
    {
        UnityEngine.Color val_1 = img.color;
        img.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = alpha};
        img.sprite = VIPCollection.GetSquareIconSpriteFromLevel(level:  level);
    }
    public static void SetupVIPLongIcon(UnityEngine.UI.Image img, int level, float alpha = 1)
    {
        UnityEngine.Color val_1 = img.color;
        img.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = alpha};
        img.sprite = VIPCollection.GetLongIconSpriteFromLevel(level:  level);
    }
    public void SetVIPMedal(int level, bool popular)
    {
        int val_1 = UnityEngine.Mathf.Clamp(value:  level, min:  1, max:  4);
        this.vipLevel = val_1;
        this.SetupFromVIPData(data:  VIPCollection.GetVipDataFromLevel(level:  val_1));
    }
    public void SetBundleMedal()
    {
        this.vipLevel = 0;
        this.SetupFromVIPData(data:  VIPCollection.GetBundleData());
    }
    private void SetupFromVIPData(VIPData data)
    {
        if(data == null)
        {
                return;
        }
        
        this.medalImg.sprite = VIPCollection.GetMedalSpriteFromName(name:  data.medalImgName);
        this.medalImg.GetComponent<UnityEngine.RectTransform>().sizeDelta = new UnityEngine.Vector2() {x = data.medalImgSize, y = V9.16B};
        object[] val_3 = new object[1];
        val_3[0] = "<br>";
        this.titleTxt.text = LanguageManager.TryGetTextWithFormat(key:  data.title, list:  val_3);
        this.titleTxt.gameObject.SetActive(value:  (~(System.String.IsNullOrWhiteSpace(value:  this.titleTxt.text))) & 1);
        this.SetLocalPosY(y:  data.medalImgPosY);
        this.SetPopular(isPopular:  data.isPopular);
    }
    public void SetPopular(bool isPopular)
    {
        if(0 == this.popularTagObject)
        {
                return;
        }
        
        this.popularTagObject.SetActive(value:  isPopular);
    }
    public void SetLocalPosY(float y)
    {
        UnityEngine.Vector3 val_2 = this.GetComponent<UnityEngine.RectTransform>().localPosition;
        this.GetComponent<UnityEngine.RectTransform>().localPosition = new UnityEngine.Vector3() {x = val_2.x, y = y, z = val_2.z};
    }
    public VIPMedal()
    {
    
    }

}
