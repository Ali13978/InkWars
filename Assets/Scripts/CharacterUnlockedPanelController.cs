using UnityEngine;
public class CharacterUnlockedPanelController : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.GameObject> firstTimeTutorialPanel;
    
    // Methods
    public void ShowTutorialPanel(bool enable)
    {
        bool val_4;
        List.Enumerator<T> val_1 = this.firstTimeTutorialPanel.GetEnumerator();
        val_4 = enable;
        label_4:
        if(((-1452241176) & 1) == 0)
        {
            goto label_2;
        }
        
        0.InitialType.SetActive(value:  val_4);
        goto label_4;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.GameObject>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    public CharacterUnlockedPanelController()
    {
        this.firstTimeTutorialPanel = new System.Collections.Generic.List<WagerData>();
    }

}
