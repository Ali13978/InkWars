using UnityEngine;
public class ButtonToggle : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Toggle m_toggleButton;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    private void OnButtonLicked()
    {
        this.m_toggleButton.GetComponent<UnityEngine.UI.Toggle>().isOn = true;
    }
    private void OnEnable()
    {
        this.GetComponentInChildren<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ButtonToggle::OnButtonLicked()));
    }
    public ButtonToggle()
    {
    
    }

}
