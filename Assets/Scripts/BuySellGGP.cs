using UnityEngine;
public class BuySellGGP : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button AddSellGGPButton;
    
    // Methods
    private void OnEnable()
    {
        this.AddSellGGPButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BuySellGGP::BuySellGGPClicked()));
    }
    private void OnDisable()
    {
        this.AddSellGGPButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BuySellGGP::BuySellGGPClicked()));
    }
    private void BuySellGGPClicked()
    {
        UnityEngine.Application.OpenURL(url:  "https://dolcegame.com.au");
    }
    private void OnApplicationPause(bool pause)
    {
        var val_3;
        if(pause != false)
        {
                return;
        }
        
        MMOCClientUser val_1 = MMOCUser.current;
        val_3 = null;
        val_3 = null;
        if((BuySellGGP.<>c.<>9__4_0) == null)
        {
            goto label_4;
        }
        
        label_9:
        val_1.GetUserProfile(onGetUserProfileDone:  BuySellGGP.<>c.<>9__4_0);
        return;
        label_4:
        BuySellGGP.<>c.<>9__4_0 = new UnityEngine.Events.UnityAction<MMOCUserProfile>(object:  BuySellGGP.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BuySellGGP.<>c::<OnApplicationPause>b__4_0(MMOCClientUser.MMOCUserProfile profile));
        if(val_1 != null)
        {
            goto label_9;
        }
        
        goto label_9;
    }
    public BuySellGGP()
    {
    
    }

}
