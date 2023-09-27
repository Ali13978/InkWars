using UnityEngine;
public class HostTemplate : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Text PlayerName;
    public UnityEngine.UI.Text Timer;
    public UnityEngine.UI.Text Wins;
    public UnityEngine.UI.Text Losses;
    public UnityEngine.UI.Text Draws;
    public UnityEngine.UI.Image EvenRowBG;
    public HostData Value;
    
    // Methods
    internal void SetData(HostData value, bool isEvenRow)
    {
        HostData val_8;
        string val_9;
        val_8 = value;
        this.Value = val_8;
        if(val_8 != null)
        {
                val_9 = value.PlayerName;
        }
        else
        {
                val_9 = 53212264;
        }
        
        string val_1 = val_9 + " " + value.version;
        string val_2 = value.Wins.ToString();
        string val_3 = value.Losses.ToString();
        string val_4 = value.Draws.ToString();
        if(value.Timer > 0)
        {
                val_8 = value + 48.ToString();
            if(this.Timer != null)
        {
            goto label_9;
        }
        
        }
        
        label_9:
        this.EvenRowBG.gameObject.SetActive(value:  isEvenRow);
    }
    public void Clicked()
    {
        NetworkLobby_Network_Select_Screen val_4;
        if((VersionText.CompareVersion(v1:  this.Value.version, v2:  VersionText.GetVersionString(format:  "{0}.{1}"))) != 1)
        {
            goto label_4;
        }
        
        val_4 = NetworkLobby_Network_Select_Screen.instance;
        if(NetworkLobby_Network_Select_Screen.instance == null)
        {
                val_4 = NetworkLobby_Network_Select_Screen.instance;
        }
        
        if(NetworkLobby_Network_Select_Screen.instance.TEST_ONLINE_MODE == false)
        {
            goto label_6;
        }
        
        val_4.JoinMatch(data:  this.Value);
        goto label_8;
        label_4:
        DialogPanel val_3 = DialogManager.Show(title:  "Sorry", message:  "Same game version is required for LAN PVP.", cancelButtonTitle:  "OK", onCancelCallback:  0);
        return;
        label_6:
        text = this.Value.IPAddress;
        NetworkLobby_Network_Select_Screen.instance.GuestConfirmHostButtonClicked();
        label_8:
        NetworkLobby_Network_Select_Screen.instance.SetScreen(screen:  3);
    }
    public HostTemplate()
    {
    
    }

}
