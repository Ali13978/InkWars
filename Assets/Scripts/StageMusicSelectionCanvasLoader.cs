using UnityEngine;
public class StageMusicSelectionCanvasLoader : MonoBehaviour
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
        
        this.executer.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void StageMusicSelectionCanvasLoader::Show()));
    }
    private void OnDisable()
    {
        if(0 == this.executer)
        {
                return;
        }
        
        this.executer.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void StageMusicSelectionCanvasLoader::Show()));
    }
    private void Show()
    {
        StageMusicSelectionCanvas.Show();
    }
    public StageMusicSelectionCanvasLoader()
    {
    
    }

}
