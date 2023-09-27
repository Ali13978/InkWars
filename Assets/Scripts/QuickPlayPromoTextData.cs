using UnityEngine;
public class QuickPlayPromoTextData : MonoBehaviour
{
    // Fields
    public string text;
    public System.Collections.Generic.List<UnityEngine.Transform> subObjects;
    
    // Methods
    private void OnEnable()
    {
        this.text = this.text.Replace(oldValue:  "<CharacterCount>", newValue:  CharacterDataManager.GetCharacterCount().ToString());
    }
    public QuickPlayPromoTextData()
    {
        this.subObjects = new System.Collections.Generic.List<UnityEngine.Transform>();
    }

}
