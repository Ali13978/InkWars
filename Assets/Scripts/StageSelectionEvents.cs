using UnityEngine;
[Serializable]
public class StageSelectionController.StageSelectionEvents
{
    // Fields
    public CMS.Events.UnityEvent_Bool OnSelectionOwnedChanged;
    public CMS.Events.UnityEvent_Int OnSelectionChanged;
    
    // Methods
    public StageSelectionController.StageSelectionEvents()
    {
        this.OnSelectionOwnedChanged = new CMS.Events.UnityEvent_Bool();
        this.OnSelectionChanged = new CMS.Events.UnityEvent_Int();
    }

}
