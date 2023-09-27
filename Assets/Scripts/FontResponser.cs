using UnityEngine;
public class FontResponser : MonoBehaviour
{
    // Fields
    public FontSubStyle subStyle;
    private TMPro.TextMeshProUGUI tmTxt;
    
    // Methods
    private void Awake()
    {
        this.tmTxt = this.GetComponent<TMPro.TextMeshProUGUI>();
    }
    private void OnEnable()
    {
        this.OnLanguageChanged();
        LanguageManager.add_OnLanguageChanged(value:  new LanguageManager.LanguageMgrHandler(object:  this, method:  System.Void FontResponser::OnLanguageChanged()));
    }
    private void OnDisable()
    {
        LanguageManager.remove_OnLanguageChanged(value:  new LanguageManager.LanguageMgrHandler(object:  this, method:  System.Void FontResponser::OnLanguageChanged()));
    }
    public void Refresh()
    {
        this.OnLanguageChanged();
    }
    private void OnLanguageChanged()
    {
        this.ReloadFontAsset(language:  LanguageManager.currentLanguage);
        this.ReloadFontMaterial(subStyle:  this.subStyle);
    }
    public void ReloadFontAsset(UnityEngine.SystemLanguage language)
    {
        TMPro.TextMeshProUGUI val_4;
        if(0 == this.tmTxt)
        {
                val_4 = this.GetComponent<TMPro.TextMeshProUGUI>();
            this.tmTxt = val_4;
        }
        else
        {
                val_4 = this.tmTxt;
        }
        
        val_4.font = LanguageManager.GetBoldFont(language:  language);
    }
    public void ReloadFontMaterial(FontSubStyle subStyle)
    {
        TMPro.TextMeshProUGUI val_14 = this.tmTxt;
        if(0 == val_14)
        {
                this.tmTxt = this.GetComponent<TMPro.TextMeshProUGUI>();
        }
        
        if((subStyle != 0) && (this.ReloadMaterial_CustomData() != true))
        {
                this.ReloadMaterial();
        }
        
        if(0 == this.tmTxt.fontMaterial)
        {
                return;
        }
        
        if(0 == this.tmTxt.font)
        {
                return;
        }
        
        TMPro.TMP_FontAsset val_10 = this.tmTxt.font;
        val_14 = val_10.atlas;
        if(this.tmTxt.fontMaterial.mainTexture == val_14)
        {
                return;
        }
        
        TMPro.TMP_FontAsset val_13 = this.tmTxt.font;
        this.tmTxt.fontMaterial.mainTexture = val_13.atlas;
    }
    private void ReloadMaterial()
    {
        UnityEngine.Material val_1 = FontSubStyleCollection.GetMaterial(style:  this.subStyle);
        if(0 == val_1)
        {
                return;
        }
        
        this.tmTxt.fontMaterial = val_1;
    }
    private bool ReloadMaterial_CustomData()
    {
        TMPro.TextMeshProUGUI val_4;
        var val_5;
        val_4 = this;
        if((FontSubStyleCollection.GetMaterialData(style:  this.subStyle)) == null)
        {
                return (bool)val_5;
        }
        
        UnityEngine.Material val_2 = UnityEngine.Resources.Load<UnityEngine.Material>(path:  "LanguageFonts/BoldFontMaterial");
        if(0 != this.tmTxt)
        {
                val_4 = this.tmTxt;
            val_4.fontMaterial = val_2;
        }
        
        val_2.SetFloat(name:  "_FaceDilate", value:  val_1.dilate);
        val_2.SetColor(name:  "_OutlineColor", value:  new UnityEngine.Color() {r = val_1.outlineColor, g = V9.16B, b = V10.16B, a = V11.16B});
        val_2.SetFloat(name:  "_OutlineWidth", value:  val_1.outlineThickness);
        val_5 = 1;
        return (bool)val_5;
    }
    public static string GetObjectPath(UnityEngine.GameObject obj)
    {
        string val_9;
        if(obj != null)
        {
                val_9 = obj.name;
        }
        else
        {
                val_9 = 0.name;
        }
        
        UnityEngine.Transform val_3 = obj.transform;
        if(val_3 != null)
        {
            goto label_7;
        }
        
        goto label_7;
        label_10:
        val_9 = val_3.gameObject.name + "/"("/") + val_9;
        label_7:
        if(0 != val_3.parent)
        {
            goto label_10;
        }
        
        return (string)val_9;
    }
    public FontResponser()
    {
    
    }

}
