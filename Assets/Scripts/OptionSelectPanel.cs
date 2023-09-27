using UnityEngine;
public class OptionSelectPanel : MonoBehaviour
{
    // Fields
    private int _select;
    public System.Collections.Generic.List<OptionSelectPanel.OptionData> optionList;
    public OptionSelectPanel.SelectionChangeEvent OnSelectionChanged;
    private UnityEngine.UI.Button leftButton;
    private UnityEngine.UI.Button rightButton;
    private TMPro.TextMeshProUGUI titleTxt;
    
    // Properties
    public int selection { get; set; }
    
    // Methods
    public int get_selection()
    {
        return (int)this._select;
    }
    public void set_selection(int value)
    {
        int val_3 = UnityEngine.Mathf.Clamp(value:  value, min:  0, max:  this.optionList.Count - 1);
        this._select = val_3;
        OptionData val_4 = this.optionList.Item[val_3];
        if(val_4 == null)
        {
            goto label_5;
        }
        
        object[] val_5 = new object[1];
        val_5[0] = val_4.value;
        if(this.titleTxt != null)
        {
            goto label_15;
        }
        
        label_16:
        label_15:
        this.titleTxt.text = LanguageManager.GetTextFormat(key:  "Lk.Shop.Enhanser.Enh.Pack", list:  val_5);
        this.leftButton.interactable = (this._select != 0) ? 1 : 0;
        this.rightButton.interactable = ((this.optionList.Count - 1) != this._select) ? 1 : 0;
        this.OnSelectionChanged.Invoke(arg0:  val_4);
        return;
        label_5:
        if(this.titleTxt != null)
        {
            goto label_15;
        }
        
        goto label_16;
    }
    private void Awake()
    {
        var val_3 = null;
        if((OptionSelectPanel.<>c.<>9__11_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        int val_1 = this.optionList.RemoveAll(match:  OptionSelectPanel.<>c.<>9__11_0);
        return;
        label_3:
        OptionSelectPanel.<>c.<>9__11_0 = new System.Predicate<OptionData>(object:  OptionSelectPanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean OptionSelectPanel.<>c::<Awake>b__11_0(OptionSelectPanel.OptionData x));
        if(this.optionList != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    private void OnEnable()
    {
        this.leftButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void OptionSelectPanel::Prev()));
        this.rightButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void OptionSelectPanel::Next()));
    }
    private void OnDisable()
    {
        this.leftButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void OptionSelectPanel::Prev()));
        this.rightButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void OptionSelectPanel::Next()));
    }
    private void Start()
    {
        this.selection = 0;
    }
    private void Next()
    {
        GameAudio.PlayButtonSound();
        this.selection = this._select + 1;
    }
    private void Prev()
    {
        GameAudio.PlayButtonSound();
        this.selection = this._select - 1;
    }
    public OptionSelectPanel()
    {
        this.optionList = new System.Collections.Generic.List<OptionData>();
        this.OnSelectionChanged = new OptionSelectPanel.SelectionChangeEvent();
    }

}
