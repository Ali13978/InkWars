using UnityEngine;
public class InfoCanvasLoader : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button m_infoCanvasButton;
    
    // Methods
    private void OnEnable()
    {
        this.m_infoCanvasButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void InfoCanvasLoader::LoadbattleEnhancer()));
    }
    private void OnDisable()
    {
        this.m_infoCanvasButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void InfoCanvasLoader::LoadbattleEnhancer()));
    }
    private void LoadbattleEnhancer()
    {
        PopupCanvas<InfoCanvas>.Show();
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    public InfoCanvasLoader()
    {
    
    }

}
