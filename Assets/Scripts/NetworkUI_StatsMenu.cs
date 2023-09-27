using UnityEngine;
public class NetworkUI_StatsMenu : NetworkUIMenu
{
    // Fields
    private UnityEngine.RectTransform userInfoPanel;
    private UnityEngine.UI.Button playerButton;
    private UnityEngine.UI.Button charButton;
    private UnityEngine.RectTransform playerPanel;
    private UnityEngine.RectTransform charPanel;
    private TMPro.TextMeshProUGUI playerTitle;
    private TMPro.TextMeshProUGUI charTitle;
    private UserDataScrollView characterDataView;
    private UserDataScrollView playerDataView;
    
    // Methods
    private void OnEnable()
    {
        this.playerButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkUI_StatsMenu::OnPlayerClick()));
        this.charButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkUI_StatsMenu::OnCharacterClick()));
    }
    private void OnDisable()
    {
        this.playerButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkUI_StatsMenu::OnPlayerClick()));
        this.charButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkUI_StatsMenu::OnCharacterClick()));
    }
    private void OnPlayerClick()
    {
        if(true != 0)
        {
                GameAudio.PlayButtonSound();
        }
        
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        this.playerPanel.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.charPanel.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.playerTitle.alpha = 1f;
        this.charTitle.alpha = 0.5f;
    }
    private void OnCharacterClick()
    {
        if(true != 0)
        {
                GameAudio.PlayButtonSound();
        }
        
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.playerPanel.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        this.charPanel.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.playerTitle.alpha = 0.5f;
        this.charTitle.alpha = 1f;
    }
    protected override void OnShow()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.userInfoPanel.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        this.OnCharacterClick();
        this.OnPlayerClick();
        this.characterDataView.Init();
        this.playerDataView.Init();
    }
    protected override void OnHide()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        this.userInfoPanel.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    public NetworkUI_StatsMenu()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
