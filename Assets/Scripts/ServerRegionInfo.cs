using UnityEngine;
public class ServerRegionInfo : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI m_server;
    private ServerRegionInfo.ServerRegionInfoLocation m_location;
    
    // Methods
    private void OnEnable()
    {
        var val_14;
        string val_15;
        TMPro.TextMeshProUGUI val_16;
        object val_18;
        val_14 = 1152921505115418624;
        if(NFUser.current.Server == null)
        {
                return;
        }
        
        GameServerLocalization val_5 = NFUser.current.Server.GetLocalization();
        val_15 = val_5.name;
        GameServerLocalization val_8 = NFUser.current.Server.GetLocalization();
        if(this.m_location != 1)
        {
                if(this.m_location != 0)
        {
                return;
        }
        
            val_16 = this.m_server;
            string val_9 = System.String.Format(format:  "{0} {1}", arg0:  val_15, arg1:  val_8.region);
        }
        else
        {
                val_16 = this.m_server;
            object[] val_10 = new object[4];
            val_10[0] = "<color=#FFFF00FF>";
            val_10[1] = val_15;
            val_10[2] = val_8.region.Replace(oldValue:  "(", newValue:  "").Replace(oldValue:  ")", newValue:  "");
            val_18 = "</color>";
            val_10[3] = val_18;
        }
        
        val_16.text = LanguageManager.GetTextFormat(key:  "LK.ServerInfoUI.YourServer2", list:  val_10);
    }
    public ServerRegionInfo()
    {
    
    }

}
