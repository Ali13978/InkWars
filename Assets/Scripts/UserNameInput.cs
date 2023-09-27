using UnityEngine;
public class UserNameInput : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.InputField userNameInput;
    private UnityEngine.UI.Image errorIcon;
    private TMPro.TextMeshProUGUI errorText;
    private UnityEngine.Sprite incorrectFieldSprite;
    private UnityEngine.Sprite correctFieldSprite;
    private UnityEngine.UI.Button nextButton;
    private bool canCheckError;
    
    // Methods
    private void OnEnable()
    {
        this.userNameInput.onEndEdit.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  public System.Void UserNameInput::CheckForError(string aNewInput)));
        this.userNameInput.onEndEdit.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  public System.Void UserNameInput::CheckForError(string aNewInput)));
        this.nextButton.interactable = false;
        UnityEngine.Color val_5 = UnityEngine.Color.clear;
        this.errorIcon.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
        if(this.canCheckError == false)
        {
                return;
        }
        
        string val_6 = this.userNameInput.text;
        this.CheckForError(aNewInput:  0);
    }
    private void Start()
    {
        this.canCheckError = true;
    }
    private void OnDisable()
    {
        this.userNameInput.onEndEdit.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  public System.Void UserNameInput::CheckForError(string aNewInput)));
    }
    public void CheckForError(string aNewInput)
    {
        var val_17;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.errorIcon.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        this.errorIcon.sprite = this.incorrectFieldSprite;
        this.nextButton.interactable = false;
        if(this.userNameInput.text.Length >= 3)
        {
                if(this.userNameInput.text.Length < 21)
        {
            goto label_9;
        }
        
        }
        
        label_21:
        label_26:
        this.errorText.text = LanguageManager.GetText(key:  "LK.SIGNUP.ERROR.NAME_TOO_SHORT");
        return;
        label_9:
        if((System.String.IsNullOrEmpty(value:  this.userNameInput.text)) == false)
        {
            goto label_12;
        }
        
        goto label_21;
        label_12:
        if((this.userNameInput.text.Contains(value:  "  ")) == false)
        {
            goto label_16;
        }
        
        goto label_21;
        label_16:
        if((this.userNameInput.text.StartsWith(value:  " ")) == false)
        {
            goto label_20;
        }
        
        goto label_21;
        label_20:
        if((this.userNameInput.text.EndsWith(value:  " ")) == false)
        {
            goto label_24;
        }
        
        string val_15 = LanguageManager.GetText(key:  "LK.SIGNUP.ERROR.NAME_END_SPACE");
        if(this.errorText != null)
        {
            goto label_26;
        }
        
        goto label_26;
        label_24:
        this.errorText.text = "";
        this.errorIcon.sprite = this.correctFieldSprite;
        this.nextButton.interactable = true;
        val_17 = null;
        val_17 = null;
        SignUpInstructionController.userName = this.userNameInput.text;
    }
    public UserNameInput()
    {
    
    }

}
