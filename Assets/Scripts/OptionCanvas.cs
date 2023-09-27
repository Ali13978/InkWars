using UnityEngine;
public class OptionCanvas : PopupCanvas<OptionCanvas>
{
    // Fields
    private UnityEngine.UI.Button emailButton;
    
    // Methods
    protected override void OnEnable()
    {
        this.OnEnable();
        this.emailButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void OptionCanvas::OnEmailClick()));
        this.emailButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void OptionCanvas::OnEmailClick()));
    }
    private void OnEmailClick()
    {
        DialogPanel val_1 = DialogManager.Show(title:  "FOR SUPPORT", message:  "please contact us on:<br><color=#EED58EFF>support@dolcegame.com.au</color>", cancelButtonTitle:  0, onCancelCallback:  0);
    }
    public static DG.Tweening.Sequence Hide()
    {
        OptionCanvas val_1 = PopupCanvas<OptionCanvas>.instance;
        if(val_1 != null)
        {
                return val_1.Close();
        }
        
        return val_1.Close();
    }
    public OptionCanvas()
    {
    
    }

}
