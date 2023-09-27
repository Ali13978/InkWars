using UnityEngine;
public class PinEntered : MonoBehaviour
{
    // Fields
    private TMPro.TMP_InputField pin;
    
    // Methods
    private void OnEnable()
    {
        this.pin.onEndEdit.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void PinEntered::OnPinEnter(string pin)));
    }
    private void OnDisable()
    {
        this.pin.onEndEdit.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void PinEntered::OnPinEnter(string pin)));
    }
    private void OnPinEnter(string pin)
    {
        null = null;
        Character_GlobalInfo.isCryptoMMOCMode = true;
        MultiplayerConnector val_1 = MultiplayerConnector.Instance;
        val_1.m_multiplayerManager.Input_EnterPin(pin:  pin);
    }
    public PinEntered()
    {
    
    }

}
