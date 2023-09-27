using UnityEngine;
public class CharacterSelectGameDruation : MonoBehaviour
{
    // Fields
    private int lastGameDuration;
    private CharacterSelectPanel panel;
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.CanvasGroup BattleEnhancercanvasGroup;
    private TMPro.TextMeshProUGUI durationText;
    private UnityEngine.CanvasGroup BattleEnhancerButton;
    private UnityEngine.CanvasGroup middleSuperCanvas;
    
    // Methods
    private void OnEnable()
    {
        this.canvasGroup.alpha = 0f;
        this.BattleEnhancercanvasGroup.alpha = 0f;
        this.OnTextChanged();
        this.panel.OnEntryDone.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectGameDruation::OnPanelEnterDone()));
    }
    private void OnDisable()
    {
        this.panel.OnEntryDone.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectGameDruation::OnPanelEnterDone()));
    }
    private void OnPanelEnterDone()
    {
        DG.Tweening.Tweener val_2 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  1f, duration:  0.8f), ease:  30);
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.BattleEnhancercanvasGroup, endValue:  1f, duration:  0.8f), ease:  30);
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.BattleEnhancerButton, endValue:  1f, duration:  0.8f), ease:  30);
        this.BattleEnhancerButton.GetComponent<UnityEngine.UI.Button>().interactable = true;
        DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.middleSuperCanvas, endValue:  1f, duration:  0.8f), ease:  30);
    }
    private void Update()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        if(this.lastGameDuration == Character_GlobalInfo.gameDuration)
        {
                return;
        }
        
        this.OnTextChanged();
        val_2 = null;
        val_2 = null;
        this.lastGameDuration = Character_GlobalInfo.gameDuration;
    }
    private void OnTextChanged()
    {
        var val_3;
        string val_5;
        val_3 = null;
        val_3 = null;
        if((Character_GlobalInfo.gameDuration & 2147483648) == 0)
        {
                val_5 = ToString() + " SEC";
        }
        else
        {
                val_5 = "UNLIMITED";
        }
        
        this.durationText.text = val_5;
    }
    public CharacterSelectGameDruation()
    {
        this.lastGameDuration = 998;
    }

}
