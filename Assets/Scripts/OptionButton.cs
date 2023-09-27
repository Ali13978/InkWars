using UnityEngine;
public abstract class OptionButton : MonoBehaviour
{
    // Fields
    protected System.Collections.Generic.List<OptionButton.OptionStatus> statusList;
    protected bool showButtonTitle;
    protected OptionButton.OptionStatus currStatus;
    private UnityEngine.UI.Button targetButton;
    private UnityEngine.UI.Image tragetImage;
    private TMPro.TextMeshProUGUI titleText;
    
    // Methods
    protected abstract float GetBindingDataValue(); // 0
    protected abstract void SetBindingDataValue(float value); // 0
    protected virtual void Awake()
    {
        var val_11;
        TMPro.TextMeshProUGUI val_13;
        val_11 = null;
        val_11 = null;
        if((OptionButton.<>c.<>9__9_0) == null)
        {
            goto label_3;
        }
        
        label_20:
        int val_1 = this.statusList.RemoveAll(match:  OptionButton.<>c.<>9__9_0);
        UnityEngine.UI.Button val_2 = this.GetComponent<UnityEngine.UI.Button>();
        this.targetButton = val_2;
        val_2.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  typeof(OptionButton).__il2cppRuntimeField_1B0));
        if(0 == this.titleText)
        {
                val_13 = this.targetButton.GetComponentInChildren<TMPro.TextMeshProUGUI>();
            this.titleText = val_13;
        }
        else
        {
                val_13 = this.titleText;
        }
        
        if(0 == val_13)
        {
                return;
        }
        
        this.titleText.gameObject.SetActive(value:  (this.showButtonTitle == true) ? 1 : 0);
        return;
        label_3:
        OptionButton.<>c.<>9__9_0 = new System.Predicate<OptionStatus>(object:  OptionButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean OptionButton.<>c::<Awake>b__9_0(OptionButton.OptionStatus x));
        if(this.statusList != null)
        {
            goto label_20;
        }
        
        goto label_20;
    }
    protected virtual void OnEnable()
    {
        var val_9;
        OptionButton.<>c__DisplayClass10_0 val_1 = new OptionButton.<>c__DisplayClass10_0();
        if(val_1 != null)
        {
                val_9 = val_1;
            .value = V0.16B;
        }
        else
        {
                val_9 = 16;
            mem[16] = V0.16B;
        }
        
        UnityEngine.Debug.Log(message:  "Value " + mem[16].ToString() + " " + this.gameObject.name);
        LanguageManager.add_OnLanguageChanged(value:  new LanguageManager.LanguageMgrHandler(object:  this, method:  System.Void OptionButton::OnLanguageChanged()));
        this.SetStatus(aNewStatus:  this.statusList.Find(match:  new System.Predicate<OptionStatus>(object:  val_1, method:  System.Boolean OptionButton.<>c__DisplayClass10_0::<OnEnable>b__0(OptionButton.OptionStatus x))));
    }
    private void OnDisable()
    {
        LanguageManager.remove_OnLanguageChanged(value:  new LanguageManager.LanguageMgrHandler(object:  this, method:  System.Void OptionButton::OnLanguageChanged()));
    }
    private void OnLanguageChanged()
    {
        TMPro.TextMeshProUGUI val_8;
        if(0 == this.titleText)
        {
                val_8 = this.targetButton.GetComponentInChildren<TMPro.TextMeshProUGUI>();
            this.titleText = val_8;
        }
        else
        {
                val_8 = this.titleText;
        }
        
        if(0 != val_8)
        {
                this.titleText.gameObject.SetActive(value:  (this.showButtonTitle == true) ? 1 : 0);
        }
        
        if(0 == this.titleText)
        {
                return;
        }
        
        if(this.currStatus == null)
        {
                return;
        }
        
        if(this.currStatus.title == null)
        {
                return;
        }
        
        this.titleText.text = LanguageManager.GetText(key:  this.currStatus.title);
    }
    protected virtual void OnButtonClick()
    {
        if(this.NextStatus() == null)
        {
            
        }
    
    }
    protected void SetStatus(OptionButton.OptionStatus aNewStatus)
    {
        TMPro.TextMeshProUGUI val_5;
        if(aNewStatus == null)
        {
                return;
        }
        
        if(0 != aNewStatus.sprite)
        {
                this.tragetImage.sprite = aNewStatus.sprite;
        }
        
        val_5 = this.titleText;
        if(0 != val_5)
        {
                if((System.String.IsNullOrEmpty(value:  aNewStatus.title)) != true)
        {
                val_5 = this.titleText;
            val_5.text = LanguageManager.GetText(key:  aNewStatus.title);
        }
        
        }
        
        this.currStatus = aNewStatus;
    }
    protected OptionButton.OptionStatus NextStatus()
    {
        int val_3 = (this.statusList.FindIndex(match:  new System.Predicate<OptionStatus>(object:  this, method:  System.Boolean OptionButton::<NextStatus>b__15_0(OptionButton.OptionStatus x)))) + 1;
        OptionStatus val_6 = this.statusList.Item[(this.statusList.Count > val_3) ? (val_3) : 0];
        this.SetStatus(aNewStatus:  val_6);
        return val_6;
    }
    protected OptionButton()
    {
        this.statusList = new System.Collections.Generic.List<OptionStatus>();
    }
    private bool <NextStatus>b__15_0(OptionButton.OptionStatus x)
    {
        return (bool)(this.currStatus == x) ? 1 : 0;
    }

}
