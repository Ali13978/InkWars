using UnityEngine;
public abstract class UnlockableGridViewItem<DATA_TYPE, PARENT_TYPE> : MonoBehaviour
{
    // Fields
    protected DATA_TYPE data;
    protected PARENT_TYPE parent;
    protected UnityEngine.UI.Button button;
    
    // Methods
    protected virtual void OnEnable()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    public void Setup(DATA_TYPE aNewData, PARENT_TYPE aNewParent)
    {
        UnityEngine.UI.Button val_8;
        mem[1152921528858182936] = aNewData;
        mem[1152921528858182944] = aNewParent;
        UnityEngine.UI.Button val_1 = this.GetComponent<UnityEngine.UI.Button>();
        mem[1152921528858182952] = val_1;
        if(0 != val_1)
        {
            goto label_4;
        }
        
        val_8 = this.gameObject.AddComponent<UnityEngine.UI.Button>();
        mem[1152921528858182952] = val_8;
        if(val_8 != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_4:
        if(val_1 != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        ButtonClickedEvent val_5 = val_1.onClick;
        val_5.RemoveAllListeners();
        val_5.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  typeof(UnlockableGridViewItem<DATA_TYPE, PARENT_TYPE>).__il2cppRuntimeField_190));
        goto typeof(UnlockableGridViewItem<DATA_TYPE, PARENT_TYPE>).__il2cppRuntimeField_178;
    }
    protected abstract void OnSetup(DATA_TYPE aNewData, PARENT_TYPE aNewParent); // 0
    public abstract void OnClick(); // 0
    protected UnlockableGridViewItem<DATA_TYPE, PARENT_TYPE>()
    {
        if(this != null)
        {
                return;
        }
    
    }

}
