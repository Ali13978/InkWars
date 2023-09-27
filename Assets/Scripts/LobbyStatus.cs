using UnityEngine;
public class LobbyStatus : MonoBehaviour
{
    // Fields
    public static string Status;
    private TMPro.TextMeshProUGUI statusText;
    
    // Methods
    private void Awake()
    {
        this.statusText = this.GetComponent<TMPro.TextMeshProUGUI>();
    }
    private void Update()
    {
        string val_5;
        if(0 == this.statusText)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  LobbyStatus.Status)) == false)
        {
            goto label_4;
        }
        
        val_5 = "";
        if(this.statusText != null)
        {
            goto label_11;
        }
        
        goto label_6;
        label_4:
        object[] val_3 = new object[1];
        val_3[0] = LobbyStatus.Status;
        val_5 = LanguageManager.GetTextFormat(key:  "LK.Lobby.Status2", list:  val_3);
        if(this.statusText != null)
        {
            goto label_11;
        }
        
        label_6:
        label_11:
        this.statusText.text = val_5;
    }
    public LobbyStatus()
    {
    
    }

}
