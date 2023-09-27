using UnityEngine;
public class Text_AuthInfo : MonoBehaviour
{
    // Methods
    private void Start()
    {
        TMPro.TextMeshProUGUI val_1 = this.GetComponent<TMPro.TextMeshProUGUI>();
        if(0 == val_1)
        {
                return;
        }
        
        val_1.text = System.String.Format(format:  "UID: {0}\n\rDEVICEID: {1}", arg0:  "Auth not initalized", arg1:  UnityEngine.SystemInfo.deviceUniqueIdentifier);
    }
    public Text_AuthInfo()
    {
    
    }

}
