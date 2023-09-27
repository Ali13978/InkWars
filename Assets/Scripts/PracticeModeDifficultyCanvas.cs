using UnityEngine;
public class PracticeModeDifficultyCanvas : PopupCanvas<PracticeModeDifficultyCanvas>
{
    // Fields
    private UnityEngine.UI.Button m_easy;
    private UnityEngine.UI.Button m_medium;
    private UnityEngine.UI.Button m_hard;
    private System.Action<Practice_Mode_Difficulty> m_action;
    
    // Methods
    public static void Show(System.Action<Practice_Mode_Difficulty> action)
    {
        PracticeModeDifficultyCanvas val_1 = PopupCanvas<PracticeModeDifficultyCanvas>.instance;
        val_1.m_action = action;
        DialogManager.ShowCustomDialog(dialog:  PopupCanvas<PracticeModeDifficultyCanvas>.instance.GetComponent<UnityEngine.RectTransform>());
    }
    public static DG.Tweening.Sequence Hide()
    {
        PracticeModeDifficultyCanvas val_1 = PopupCanvas<PracticeModeDifficultyCanvas>.instance;
        if(val_1 != null)
        {
                return val_1.Close();
        }
        
        return val_1.Close();
    }
    private void OnEnable()
    {
        this.OnEnable();
        this.m_easy.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PracticeModeDifficultyCanvas::Easy()));
        this.m_medium.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PracticeModeDifficultyCanvas::Medium()));
        this.m_hard.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PracticeModeDifficultyCanvas::Hard()));
    }
    private void OnDisable()
    {
        this.OnDisable();
        this.m_easy.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PracticeModeDifficultyCanvas::Easy()));
        this.m_medium.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PracticeModeDifficultyCanvas::Medium()));
        this.m_hard.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PracticeModeDifficultyCanvas::Hard()));
    }
    private void Easy()
    {
        GameAudio.PlayButtonSound();
        if(this.m_action == null)
        {
                return;
        }
        
        this.m_action.Invoke(obj:  0);
    }
    private void Medium()
    {
        GameAudio.PlayButtonSound();
        if(this.m_action == null)
        {
                return;
        }
        
        this.m_action.Invoke(obj:  5);
    }
    private void Hard()
    {
        GameAudio.PlayButtonSound();
        if(this.m_action == null)
        {
                return;
        }
        
        this.m_action.Invoke(obj:  11);
    }
    public PracticeModeDifficultyCanvas()
    {
    
    }

}
