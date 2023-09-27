using UnityEngine;
public class ActivateInputField : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button m_activationButton;
    private TMPro.TMP_InputField m_inputField;
    
    // Methods
    private void OnEnable()
    {
        this.m_activationButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ActivateInputField::OnClickButton()));
    }
    private void OnDisable()
    {
        this.m_activationButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ActivateInputField::OnClickButton()));
    }
    private void OnClickButton()
    {
        this.m_inputField.Select();
        this.m_inputField.ActivateInputField();
    }
    public ActivateInputField()
    {
    
    }

}
