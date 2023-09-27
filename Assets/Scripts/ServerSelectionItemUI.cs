using UnityEngine;
public class ServerSelectionItemUI : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI serverNameText;
    private UnityEngine.UI.Text regionText;
    private FontResponser serverNameFontResponser;
    private UnityEngine.UI.Toggle toggle;
    private GameServerInfo <serverInfo>k__BackingField;
    private ServerSelectionPanel serverSelectionPanel;
    
    // Properties
    public GameServerInfo serverInfo { get; set; }
    
    // Methods
    public GameServerInfo get_serverInfo()
    {
        return (GameServerInfo)this.<serverInfo>k__BackingField;
    }
    private void set_serverInfo(GameServerInfo value)
    {
        this.<serverInfo>k__BackingField = value;
    }
    public void Setup(ServerSelectionPanel panel, GameServerInfo gameServerInfo)
    {
        this.<serverInfo>k__BackingField = gameServerInfo;
        this.serverSelectionPanel = panel;
        if(gameServerInfo.GetLocalization() != null)
        {
                this.serverNameText.text = val_1.name;
            if(this.regionText != null)
        {
            goto label_5;
        }
        
        }
        else
        {
                this.serverNameText.text = gameServerInfo.id;
        }
        
        label_5:
        this.serverNameFontResponser.Refresh();
        this.toggle.onValueChanged.RemoveAllListeners();
        this.toggle.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void ServerSelectionItemUI::OnToggleValueChanged(bool isOn)));
    }
    private void OnToggleValueChanged(bool isOn)
    {
        if(isOn == false)
        {
                return;
        }
        
        this.serverSelectionPanel.OnSelectServer(server:  this.<serverInfo>k__BackingField);
    }
    public ServerSelectionItemUI()
    {
    
    }

}
