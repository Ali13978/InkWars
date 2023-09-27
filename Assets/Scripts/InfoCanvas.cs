using UnityEngine;
public class InfoCanvas : PopupCanvas<InfoCanvas>
{
    // Fields
    private UnityEngine.UI.Button CreditButton;
    
    // Methods
    protected void OnEnable()
    {
        this.OnEnable();
        this.CreditButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void InfoCanvas::GotoCredit()));
        LanguageManager.InvokeLanguageChage();
    }
    protected void OnDisable()
    {
        this.OnDisable();
        this.CreditButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void InfoCanvas::GotoCredit()));
    }
    private void GotoCredit()
    {
        var val_11;
        DG.Tweening.TweenCallback val_13;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  PopupCanvas<InfoCanvas>.instance.Close());
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  OptionCanvas.Hide());
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  OptionCanvasForSuponic.Hide());
        val_11 = null;
        val_11 = null;
        val_13 = InfoCanvas.<>c.<>9__3_0;
        if(val_13 == null)
        {
                DG.Tweening.TweenCallback val_9 = null;
            val_13 = val_9;
            val_9 = new DG.Tweening.TweenCallback(object:  InfoCanvas.<>c.__il2cppRuntimeField_static_fields, method:  System.Void InfoCanvas.<>c::<GotoCredit>b__3_0());
            InfoCanvas.<>c.<>9__3_0 = val_13;
        }
        
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  val_9);
    }
    public InfoCanvas()
    {
    
    }

}
