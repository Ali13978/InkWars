using UnityEngine;
public class InstructionCanvas : MonoBehaviour
{
    // Fields
    private static InstructionCanvas _inst;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button nextButton;
    private UnityEngine.UI.Image instructionImage;
    
    // Properties
    public static InstructionCanvas Instance { get; }
    
    // Methods
    public static InstructionCanvas get_Instance()
    {
        InstructionCanvas val_4 = InstructionCanvas._inst;
        if(0 != val_4)
        {
                return (InstructionCanvas)InstructionCanvas._inst;
        }
        
        val_4 = UnityEngine.Resources.Load<InstructionCanvas>(path:  "DynamicUI/NetworkInstructionCanvas");
        InstructionCanvas._inst = UnityEngine.Object.Instantiate<InstructionCanvas>(original:  val_4);
        return (InstructionCanvas)InstructionCanvas._inst;
    }
    private void OnEnable()
    {
        this.closeButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void InstructionCanvas::CloseButtonAction()));
    }
    private void OnDisable()
    {
        this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void InstructionCanvas::CloseButtonAction()));
    }
    private void CloseButtonAction()
    {
        this.Close(onClose:  0);
    }
    public void Show()
    {
    
    }
    private void OnNext()
    {
        this.Close(onClose:  0);
    }
    public void Close(System.Action onClose)
    {
        UnityEngine.Object.Destroy(obj:  InstructionCanvas._inst.gameObject);
        InstructionCanvas._inst = 0;
        if(onClose == null)
        {
                return;
        }
        
        onClose.Invoke();
    }
    public InstructionCanvas()
    {
    
    }

}
