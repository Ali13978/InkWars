using UnityEngine;
public class DeeplinkingExample : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject Panel;
    public UnityEngine.GameObject Reference;
    public UnityEngine.GameObject InstructionText;
    
    // Methods
    private void Start()
    {
        this.SetupUi();
        ImaginationOverflow.UniversalDeepLinking.DeepLinkManager.Instance.add_LinkActivated(value:  new ImaginationOverflow.UniversalDeepLinking.LinkActivationHandler(object:  this, method:  System.Void DeeplinkingExample::Instance_LinkActivated(ImaginationOverflow.UniversalDeepLinking.LinkActivation s)));
    }
    private void SetupUi()
    {
        this.Reference.SetActive(value:  false);
    }
    private void Instance_LinkActivated(ImaginationOverflow.UniversalDeepLinking.LinkActivation s)
    {
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.Reference, parent:  this.Panel.transform);
        UnityEngine.UI.Text val_5 = val_2.transform.GetChild(index:  0).GetComponent<UnityEngine.UI.Text>();
        System.DateTime val_6 = System.DateTime.Now;
        UnityEngine.UI.Text val_9 = val_2.transform.GetChild(index:  1).GetComponent<UnityEngine.UI.Text>();
        string val_10 = s.Uri;
        val_2.SetActive(value:  true);
        this.InstructionText.SetActive(value:  false);
        this.UpdateContentSize();
    }
    private void UpdateContentSize()
    {
        float val_6;
        UnityEngine.RectTransform val_1 = this.Panel.GetComponent<UnityEngine.RectTransform>();
        if(val_1 != null)
        {
                UnityEngine.Vector2 val_2 = val_1.sizeDelta;
            val_6 = val_2.x;
        }
        else
        {
                UnityEngine.Vector2 val_3 = val_1.sizeDelta;
            val_6 = val_3.x;
        }
        
        UnityEngine.Vector2 val_4 = val_1.sizeDelta;
        val_4.y = val_4.y + 112f;
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_6, y:  val_4.y);
        val_1.sizeDelta = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
    }
    public DeeplinkingExample()
    {
    
    }

}
