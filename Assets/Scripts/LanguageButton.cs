using UnityEngine;
public class LanguageButton : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<LanguageInfo> m_Languages;
    private UnityEngine.UI.Button left;
    private UnityEngine.UI.Button right;
    private TMPro.TextMeshProUGUI text;
    private UnityEngine.UI.Image flag;
    private int index;
    
    // Methods
    private void OnEnable()
    {
        var val_15;
        System.Collections.Generic.List<LanguageInfo> val_1 = LanguageManager.GetAllLanguageInfo();
        this.m_Languages = val_1;
        val_15 = null;
        val_15 = null;
        if((LanguageButton.<>c.<>9__7_0) == null)
        {
            goto label_3;
        }
        
        label_18:
        int val_2 = val_1.FindIndex(match:  LanguageButton.<>c.<>9__7_0);
        this.index = val_2 & (~(val_2 >> 31));
        this.left.gameObject.SetActive(value:  (this.m_Languages.Count > 1) ? 1 : 0);
        this.right.gameObject.SetActive(value:  (this.m_Languages.Count > 1) ? 1 : 0);
        this.UpdateInfo();
        this.left.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LanguageButton::ClickedLeft()));
        this.right.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LanguageButton::ClickedRight()));
        return;
        label_3:
        LanguageButton.<>c.<>9__7_0 = new System.Predicate<LanguageInfo>(object:  LanguageButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LanguageButton.<>c::<OnEnable>b__7_0(LanguageInfo x));
        if(val_1 != null)
        {
            goto label_18;
        }
        
        goto label_18;
    }
    private void OnDisable()
    {
        this.left.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LanguageButton::ClickedLeft()));
        this.right.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LanguageButton::ClickedRight()));
    }
    private void UpdateInfo()
    {
        var val_7;
        LanguageInfo val_1 = this.m_Languages.Item[this.index];
        bool val_2 = LanguageManager.SetLanguage(language:  val_1.language);
        LanguageInfo val_3 = this.m_Languages.Item[this.index];
        this.flag.sprite = NetworkUtils.GetCountry(_flag:  val_3.flag);
        LanguageInfo val_5 = this.m_Languages.Item[this.index];
        this.text.text = val_5.localizedLanguageName;
        val_7 = null;
        val_7 = null;
        LanguageInfo val_6 = this.m_Languages.Item[this.index];
        DataStructs.UserDataDictionary.Settings.Language = val_6.language;
    }
    private void ClickedLeft()
    {
        int val_3 = this.index - 1;
        this.index = val_3;
        if((val_3 & 2147483648) != 0)
        {
                val_3 = this.m_Languages.Count - 1;
        }
        
        this.index = val_3;
        this.UpdateInfo();
    }
    private void ClickedRight()
    {
        int val_4;
        int val_1 = this.index + 1;
        this.index = val_1;
        if(val_1 > (this.m_Languages.Count - 1))
        {
                val_4 = 0;
        }
        else
        {
                val_4 = this.index;
        }
        
        this.index = val_4;
        this.UpdateInfo();
    }
    public LanguageButton()
    {
    
    }

}
