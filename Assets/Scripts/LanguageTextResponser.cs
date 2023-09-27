using UnityEngine;
public class LanguageTextResponser : MonoBehaviour
{
    // Fields
    private string textID;
    public bool isFormatedText;
    public string[] list;
    private TMPro.TextMeshProUGUI tmTxt;
    private UnityEngine.UI.Text unityTxt;
    
    // Properties
    public string textKey { get; set; }
    
    // Methods
    public string get_textKey()
    {
        return (string)this.textID;
    }
    public void set_textKey(string value)
    {
        this.textID = value;
        this.OnLanguageChanged();
    }
    private void Awake()
    {
        this.OnLanguageChanged();
    }
    private void OnEnable()
    {
        mem[1152921526164091744] = this;
        mem[1152921526164091752] = System.Void LanguageTextResponser::OnLanguageChanged();
        mem[1152921526164091728] = System.Void LanguageTextResponser::OnLanguageChanged();
        LanguageManager.add_OnLanguageChanged(value:  new LanguageManager.LanguageMgrHandler());
        this.OnLanguageChanged();
    }
    private void OnDisable()
    {
        mem[1152921526164211936] = this;
        mem[1152921526164211944] = System.Void LanguageTextResponser::OnLanguageChanged();
        mem[1152921526164211920] = System.Void LanguageTextResponser::OnLanguageChanged();
        LanguageManager.remove_OnLanguageChanged(value:  new LanguageManager.LanguageMgrHandler());
    }
    public void Refresh()
    {
        this.OnLanguageChanged();
    }
    private void OnLanguageChanged()
    {
        var val_15;
        UnityEngine.UI.Text val_17;
        val_15 = this;
        if(0 == this.tmTxt)
        {
                this.tmTxt = this.GetComponent<TMPro.TextMeshProUGUI>();
        }
        
        if(0 == this.unityTxt)
        {
                this.unityTxt = this.GetComponent<UnityEngine.UI.Text>();
        }
        
        if(this.isFormatedText != false)
        {
                string val_5 = LanguageManager.GetTextFormat(key:  this.textID, list:  this.list);
        }
        
        if(0 != this.tmTxt)
        {
                this.tmTxt.text = LanguageManager.GetText(key:  this.textID);
        }
        
        val_17 = this.unityTxt;
        if(0 == val_17)
        {
                return;
        }
        
        val_15 = ???;
        val_17 = ???;
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5B8;
    }
    public LanguageTextResponser()
    {
        this.textID = "LK.EMPTY";
    }

}
