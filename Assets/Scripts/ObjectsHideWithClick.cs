using UnityEngine;
public class ObjectsHideWithClick : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.GameObject> m_toBeDisabled;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        if(UnityEngine.Input.anyKeyDown == false)
        {
                return;
        }
        
        this = this.m_toBeDisabled;
        List.Enumerator<T> val_2 = this.GetEnumerator();
        label_6:
        if(((-1651867416) & 1) == 0)
        {
            goto label_3;
        }
        
        0.InitialType.gameObject.SetActive(value:  false);
        goto label_6;
        label_3:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.GameObject>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    public ObjectsHideWithClick()
    {
    
    }

}
