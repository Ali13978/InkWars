using UnityEngine;
public class ToggleButtonSound : MonoBehaviour
{
    // Fields
    public bool playWhenOn;
    public bool playWhenOff;
    private bool canPlaySFX;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.UI.Toggle val_1 = this.GetComponent<UnityEngine.UI.Toggle>();
        val_1.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void ToggleButtonSound::OnValueChanged(bool isOn)));
    }
    private void OnDisable()
    {
        UnityEngine.UI.Toggle val_1 = this.GetComponent<UnityEngine.UI.Toggle>();
        val_1.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void ToggleButtonSound::OnValueChanged(bool isOn)));
    }
    private void Start()
    {
        this.Invoke(methodName:  "EnableSFX", time:  0.5f);
    }
    private void EnableSFX()
    {
        this.canPlaySFX = true;
    }
    private void OnValueChanged(bool isOn)
    {
        if(this.canPlaySFX == false)
        {
                return;
        }
        
        if(isOn == false)
        {
            goto label_2;
        }
        
        if(this.playWhenOn == false)
        {
                return;
        }
        
        label_6:
        GameAudio.PlayButtonSound();
        return;
        label_2:
        if(this.playWhenOff == true)
        {
            goto label_6;
        }
    
    }
    public ToggleButtonSound()
    {
        this.playWhenOn = true;
    }

}
