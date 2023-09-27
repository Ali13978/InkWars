using UnityEngine;
public class OptionCanvasForSuponic : PopupCanvas<OptionCanvasForSuponic>
{
    // Fields
    private UnityEngine.UI.Button emailButton;
    
    // Methods
    protected override void OnEnable()
    {
        this.OnEnable();
        this.emailButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void OptionCanvasForSuponic::OnEmailClick()));
        this.emailButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void OptionCanvasForSuponic::OnEmailClick()));
    }
    private void OnEmailClick()
    {
        object[] val_2 = new object[4];
        val_2[0] = "<br>";
        val_2[1] = "<color=#EED58EFF>";
        val_2[2] = "support@dolcegame.com.au";
        val_2[3] = "</color>";
        DialogPanel val_4 = DialogManager.Show(title:  LanguageManager.GetText(key:  "LK.Option.Email1"), message:  LanguageManager.GetTextFormat(key:  "LK.Option.Email2", list:  val_2), cancelButtonTitle:  0, onCancelCallback:  0);
    }
    public static DG.Tweening.Sequence Hide()
    {
        OptionCanvasForSuponic val_1 = PopupCanvas<OptionCanvasForSuponic>.instance;
        if(val_1 != null)
        {
                return val_1.Close();
        }
        
        return val_1.Close();
    }
    public OptionCanvasForSuponic()
    {
    
    }

}
