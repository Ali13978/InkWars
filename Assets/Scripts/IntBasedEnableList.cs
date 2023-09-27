using UnityEngine;
[Serializable]
public class IntBasedEnableList
{
    // Fields
    public System.Collections.Generic.List<int> enabledData;
    
    // Methods
    public bool IsEnabled(int id)
    {
        if(this.enabledData == null)
        {
                return (bool)this.enabledData;
        }
        
        return this.enabledData.Contains(item:  id);
    }
    public void SetEnabled(int id, bool enable)
    {
        System.Collections.Generic.List<System.Int32> val_5 = this.enabledData;
        if(val_5 == null)
        {
            goto label_1;
        }
        
        if(enable == false)
        {
            goto label_2;
        }
        
        label_6:
        if((val_5.Contains(item:  id)) == true)
        {
                return;
        }
        
        this.enabledData.Add(item:  id);
        return;
        label_1:
        System.Collections.Generic.List<System.Int32> val_2 = null;
        val_5 = val_2;
        val_2 = new System.Collections.Generic.List<System.Int32>();
        this.enabledData = val_5;
        if(enable == true)
        {
            goto label_6;
        }
        
        label_2:
        if((val_2.Contains(item:  id)) == false)
        {
                return;
        }
        
        bool val_4 = this.enabledData.Remove(item:  id);
    }
    public void SetDefault(System.Collections.Generic.List<int> aNewSource)
    {
        System.Collections.Generic.List<System.Int32> val_2 = aNewSource;
        if((val_2 == null) && (this.enabledData == null))
        {
                System.Collections.Generic.List<System.Int32> val_1 = null;
            val_2 = val_1;
            val_1 = new System.Collections.Generic.List<System.Int32>();
        }
        
        this.enabledData = val_2;
    }
    public override string ToString()
    {
        var val_5;
        string val_2 = this.GetType() + ": ["(": [");
        List.Enumerator<T> val_3 = this.enabledData.GetEnumerator();
        label_4:
        if(((-1295852112) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_8 = val_2 + val_5.GetHashCode().ToString() + ", ";
        goto label_4;
        label_3:
        val_5.Add(driver:  public System.Void List.Enumerator<System.Int32>::Dispose(), rectTransform:  0, drivenProperties:  null);
        return (string)val_2 + "]";
    }
    public IntBasedEnableList()
    {
        this.enabledData = new System.Collections.Generic.List<System.Int32>();
    }

}
