using UnityEngine;
public class OptionCanvasLoader : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button executer;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    private void Awake()
    {
        this.executer = this.GetComponent<UnityEngine.UI.Button>();
    }
    private void OnEnable()
    {
        if(0 == this.executer)
        {
                return;
        }
        
        this.executer.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void OptionCanvasLoader::Show()));
    }
    private void OnDisable()
    {
        if(0 == this.executer)
        {
                return;
        }
        
        this.executer.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void OptionCanvasLoader::Show()));
    }
    private void Show()
    {
        GameAudio.PlayButtonSound();
        PopupCanvas<OptionCanvasForSuponic>.Show();
    }
    public OptionCanvasLoader()
    {
    
    }

}
