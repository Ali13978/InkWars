using UnityEngine;
public class UserCountryDropdown : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Dropdown dropdownCountry;
    private UnityEngine.UI.Image imageFlag;
    private System.Collections.Generic.List<DataStructs.Flag> flagList;
    
    // Properties
    public DataStructs.Flag selection { get; set; }
    
    // Methods
    public DataStructs.Flag get_selection()
    {
        return (DataStructs.Flag)this.flagList.Item[this.dropdownCountry.value];
    }
    private void set_selection(DataStructs.Flag value)
    {
        .value = value;
        this.dropdownCountry.value = UnityEngine.Mathf.Max(a:  0, b:  this.flagList.FindIndex(match:  new System.Predicate<DataStructs.Flag>(object:  new UserCountryDropdown.<>c__DisplayClass5_0(), method:  System.Boolean UserCountryDropdown.<>c__DisplayClass5_0::<set_selection>b__0(DataStructs.Flag x))));
    }
    private void Awake()
    {
        var val_3;
        this.dropdownCountry.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Int32>(object:  this, method:  public System.Void UserCountryDropdown::DropdownCountryFlagLoad(int selection)));
        this.DropdownCountryFormat();
        val_3 = null;
        val_3 = null;
        this.selection = SignUpInstructionController.userCountry;
    }
    private void OnDestroy()
    {
        this.dropdownCountry.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Int32>(object:  this, method:  public System.Void UserCountryDropdown::DropdownCountryFlagLoad(int selection)));
    }
    public void DropdownCountryFlagLoad(int selection)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        DataStructs.Flag val_1 = this.flagList.Item[selection];
        this.imageFlag.sprite = NetworkUtils.GetCountry(_flag:  val_1);
        val_4 = null;
        val_4 = null;
        SignUpInstructionController.userCountry = val_1;
    }
    private void DropdownCountryFormat()
    {
        var val_19;
        var val_22;
        var val_23;
        System.Collections.Generic.List<DataStructs.Flag> val_26;
        this.flagList.Clear();
        this.dropdownCountry.ClearOptions();
        System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_22:
        var val_21 = 0;
        val_21 = val_21 + 1;
        val_19 = 0;
        if(val_3.MoveNext() == false)
        {
            goto label_13;
        }
        
        var val_22 = 0;
        val_22 = val_22 + 1;
        val_19 = 1;
        val_3.Current.Add(driver:  public System.Object System.Collections.IEnumerator::get_Current(), rectTransform:  null, drivenProperties:  null);
        this.flagList.Add(item:  1152921504628039680);
        goto label_22;
        label_13:
        val_22 = 0;
        val_23 = 0;
        if(val_3 != null)
        {
                var val_23 = 0;
            val_23 = val_23 + 1;
            val_3.Dispose();
        }
        
        if( != 1)
        {
                var val_10 = (96 == 96) ? 1 : 0;
            val_10 = (( >= 0) ? 1 : 0) & val_10;
            val_10 =  - val_10;
            val_10 = val_10 + 1;
        }
        
        bool val_12 = this.flagList.Remove(item:  0);
        bool val_13 = this.flagList.Remove(item:  161);
        this.flagList.Insert(index:  0, item:  161);
        bool val_14 = this.flagList.Remove(item:  125);
        this.flagList.Insert(index:  1, item:  125);
        bool val_15 = this.flagList.Remove(item:  186);
        this.flagList.Insert(index:  2, item:  186);
        System.Collections.Generic.List<System.String> val_16 = new System.Collections.Generic.List<System.String>();
        val_26 = this.flagList;
        List.Enumerator<T> val_17 = val_26.GetEnumerator();
        label_53:
        if(((-2114652928) & 1) == 0)
        {
            goto label_47;
        }
        
        int val_18 = 0.GetHashCode();
        if(val_18 != 41)
        {
            goto label_48;
        }
        
        val_16.Add(item:  "Cote d\'Ivorie");
        goto label_53;
        label_48:
        val_18.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  186, drivenProperties:  public System.Void System.Collections.Generic.List<DataStructs.Flag>::Insert(int index, DataStructs.Flag item));
        val_16.Add(item:  NetworkUtils.InsertSpacesInCamelCasingNaming(_string:  val_18.ToString()));
        goto label_53;
        label_47:
        0.Add(driver:  public System.Void List.Enumerator<DataStructs.Flag>::Dispose(), rectTransform:  186, drivenProperties:  public System.Void System.Collections.Generic.List<DataStructs.Flag>::Insert(int index, DataStructs.Flag item));
        this.dropdownCountry.AddOptions(options:  val_16);
    }
    public UserCountryDropdown()
    {
        this.flagList = new System.Collections.Generic.List<DataStructs.Flag>();
    }

}
