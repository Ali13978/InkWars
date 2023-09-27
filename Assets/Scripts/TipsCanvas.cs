using UnityEngine;
public class TipsCanvas : PopupCanvas<TipsCanvas>
{
    // Fields
    private TipsScroller tipsScroller;
    
    // Methods
    public static void Show(int tip)
    {
        TipsCanvas val_1 = PopupCanvas<TipsCanvas>.instance;
        val_1.tipsScroller.m_index = tip;
        val_1.tipsScroller.EnableTip(ind:  tip);
        DialogManager.ShowCustomDialog(dialog:  PopupCanvas<TipsCanvas>.instance.GetComponent<UnityEngine.RectTransform>());
    }
    public TipsCanvas()
    {
    
    }

}
