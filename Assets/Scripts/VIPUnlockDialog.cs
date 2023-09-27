using UnityEngine;
public class VIPUnlockDialog : DynamicUISingleton<VIPUnlockDialog>
{
    // Fields
    private VIPMedal medalCtrl;
    private TMPro.TextMeshProUGUI expireTxt;
    private TMPro.TextMeshProUGUI characterInfoTxt;
    private UnityEngine.AudioClip giftSFX;
    
    // Methods
    public static void Show(int vipLevel)
    {
        UnityEngine.Object val_5;
        if(vipLevel < 1)
        {
                return;
        }
        
        if(vipLevel > 4)
        {
                return;
        }
        
        val_5 = DynamicUISingleton<VIPUnlockDialog>.instance;
        if(val_5 != null)
        {
                val_5 = 0;
        }
        
        if(0 != val_5)
        {
                this.Setup(vipLevel:  vipLevel);
        }
        
        DynamicUISingleton<VIPUnlockDialog>.Show();
    }
    public void Setup(int vipLevel)
    {
        bool val_1 = VIPCollection.IsPopular(level:  vipLevel);
        this.medalCtrl.SetVIPMedal(level:  vipLevel, popular:  false);
        this.medalCtrl.SetLocalPosY(y:  0f);
        object[] val_2 = new object[1];
        string val_3 = VIP.GetLocalExpireDateString();
        if(val_2 == null)
        {
            goto label_7;
        }
        
        if(val_3 != null)
        {
            goto label_8;
        }
        
        goto label_11;
        label_7:
        if(val_3 == null)
        {
            goto label_11;
        }
        
        label_8:
        label_11:
        val_2[0] = val_3;
        this.expireTxt.text = LanguageManager.GetTextFormat(key:  "LK.VIP.UNLOCK.EXPIRE_DATE", list:  val_2);
        object[] val_5 = new object[6];
        val_5[0] = "<br>";
        val_5[1] = "<color=white>";
        val_5[2] = "<size=22>";
        val_5[3] = (VIP.GetUnlockedCharacterCountByLevel(targetLevel:  vipLevel, isCeleb:  true, includeDefaults:  true)) + (VIP.GetUnlockedCharacterCountByLevel(targetLevel:  vipLevel, isCeleb:  false, includeDefaults:  true));
        val_5[4] = "</size>";
        val_5[5] = "</color>";
        this.characterInfoTxt.text = "<size=21>"("<size=21>") + LanguageManager.GetTextFormat(key:  "LK.VIP.UNLOCK.CHARACTER_INFO", list:  val_5)(LanguageManager.GetTextFormat(key:  "LK.VIP.UNLOCK.CHARACTER_INFO", list:  val_5)) + "</size>"("</size>");
        this.characterInfoTxt.fontSize = 21f;
        this.characterInfoTxt.fontSizeMax = 21f;
    }
    public VIPUnlockDialog()
    {
    
    }

}
