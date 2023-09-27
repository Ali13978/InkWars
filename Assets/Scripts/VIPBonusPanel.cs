using UnityEngine;
public class VIPBonusPanel : DynamicUISingleton<VIPBonusPanel>
{
    // Fields
    private VIPMedal medalCtrl;
    private VIPItemGroup items;
    private TMPro.TextMeshProUGUI descTxt;
    private UnityEngine.AudioClip giftSFX;
    
    // Methods
    protected override void OnShow()
    {
        this.OnShow();
        this.Setup();
        if(0 == this.giftSFX)
        {
                return;
        }
        
        UnityEngine.AudioSource val_3 = GameAudio.sound.PlayOneShot(clip:  this.giftSFX, volume:  1f);
    }
    public void Setup()
    {
        VIPPromo val_1 = VIPCollection.GetPromoData();
        bool val_2 = VIPCollection.IsPopular(level:  val_1.levelForNewUserGiftVIP);
        this.medalCtrl.SetVIPMedal(level:  val_1.levelForNewUserGiftVIP, popular:  false);
        this.medalCtrl.SetLocalPosY(y:  -24f);
        this.items.SetVIPItems(level:  val_1.levelForNewUserGiftVIP, spaceForEmptyItems:  false);
        object[] val_3 = new object[5];
        val_3[0] = "<color=#1FC641>";
        val_3[1] = "</color>";
        VIPPromo val_4 = VIPCollection.GetPromoData();
        val_3[2] = val_4.freeDaysForNewUserGiftVIP;
        val_3[3] = "<color=#1FC641>";
        val_3[4] = "</color>";
        this.descTxt.text = LanguageManager.GetTextFormat(key:  "LK.VIP.BONUS.DESC", list:  val_3);
        this.descTxt.fontSizeMax = 28f;
        this.descTxt.fontSize = 28f;
    }
    public VIPBonusPanel()
    {
    
    }

}
