using UnityEngine;
public class RadioPanelGroup : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<RadioPanelGroup.RadioPanel> panelList;
    
    // Methods
    public void InitPanelList()
    {
        var val_4;
        object val_10;
        var val_11;
        val_10 = this;
        val_11 = null;
        val_11 = null;
        if((RadioPanelGroup.<>c.<>9__2_0) == null)
        {
            goto label_3;
        }
        
        label_21:
        int val_1 = this.panelList.RemoveAll(match:  RadioPanelGroup.<>c.<>9__2_0);
        List.Enumerator<T> val_2 = this.panelList.GetEnumerator();
        label_17:
        if(((-1863221408) & 1) == 0)
        {
            goto label_6;
        }
        
        UnityEngine.Events.UnityAction<System.Boolean> val_6 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void RadioPanelGroup::OnToggleChanged(bool isOn));
        mem[val_5._impl + 240].RemoveListener(call:  null);
        val_5._impl.isOn = false;
        UnityEngine.Events.UnityAction<System.Boolean> val_7 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void RadioPanelGroup::OnToggleChanged(bool isOn));
        mem[val_5._impl + 240].AddListener(call:  null);
        if(0 == (mem[val_5._impl + 240]))
        {
            goto label_17;
        }
        
        val_4.InitialType.alpha = 0f;
        goto label_17;
        label_3:
        RadioPanelGroup.<>c.<>9__2_0 = new System.Predicate<RadioPanel>(object:  RadioPanelGroup.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean RadioPanelGroup.<>c::<InitPanelList>b__2_0(RadioPanelGroup.RadioPanel x));
        if(this.panelList != null)
        {
            goto label_21;
        }
        
        goto label_21;
        label_6:
        val_4.Add(driver:  public System.Void List.Enumerator<RadioPanel>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<RadioPanel>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
    }
    private void OnToggleChanged(bool isOn)
    {
    
    }
    public RadioPanelGroup()
    {
        this.panelList = new System.Collections.Generic.List<RadioPanel>();
    }

}
