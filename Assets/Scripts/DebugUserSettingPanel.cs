using UnityEngine;
public class DebugUserSettingPanel : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.InputField nameInput;
    public UnityEngine.UI.InputField ppInput;
    public CharacterSelectScrollView selectionView;
    public UnityEngine.UI.InputField bpInput;
    public UnityEngine.UI.Dropdown rankDropdown;
    public UnityEngine.UI.Button backButton;
    public UnityEngine.UI.Toggle celebToggle;
    public UnityEngine.UI.Toggle badVersionToggle;
    public UnityEngine.UI.Dropdown MatchEndRankDropdown;
    public UnityEngine.UI.Dropdown MatchBeginRankPopupDropdown;
    public UnityEngine.UI.Dropdown MatchEndUnlockCollection;
    public static DebugUserSettingPanel.ObjectAppearanceBehaviour UnlockCollectionBehaviour;
    public static DebugUserSettingPanel.RankOutcomeBehaviour MatchEndRank;
    public static DebugUserSettingPanel.RankOutcomeBehaviour MatchBeginRankPopup;
    private bool celebLocked;
    private bool changeRankWithSetBP;
    private static DebugUserSettingPanel inst;
    
    // Methods
    public static void Show()
    {
        var val_4 = null;
        DebugUserSettingPanel.inst = UnityEngine.Object.Instantiate<DebugUserSettingPanel>(original:  UnityEngine.Resources.Load<DebugUserSettingPanel>(path:  "DynamicUI/DebugPanel"));
        DialogManager.ShowCustomDialog(dialog:  DebugUserSettingPanel.inst.GetComponent<UnityEngine.RectTransform>());
    }
    public static void Hide()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(0 == DebugUserSettingPanel.inst)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        UnityEngine.Object.Destroy(obj:  DebugUserSettingPanel.inst.gameObject);
    }
    public DebugUserSettingPanel()
    {
        this.changeRankWithSetBP = true;
    }
    private static DebugUserSettingPanel()
    {
    
    }

}
