using UnityEngine;
public static class IAPCharacterPromoGift
{
    // Fields
    private const string CHARACTER_PROMO_GIFT_CONFIG_KEY = "data.CharacterPromoConfig";
    private static UnityEngine.Events.UnityEvent CharacterPromoGiftUpdateEvent;
    private static CharacterPromoGiftRemoteSettingData promoData;
    
    // Methods
    public static CharacterPromoGiftData Get(CharacterNameID character)
    {
        null = null;
        if(IAPCharacterPromoGift.promoData != null)
        {
                return IAPCharacterPromoGift.promoData.Get(characterId:  character);
        }
        
        return IAPCharacterPromoGift.promoData.Get(characterId:  character);
    }
    public static void ApplyGift(CharacterNameID character)
    {
        if((IAPCharacterPromoGift.Get(character:  character)) == null)
        {
                return;
        }
        
        IAPCharacterPromoGift.Get(character:  character).ApplyGift();
    }
    public static void AddGiftUpdateListener(UnityEngine.Events.UnityAction listener)
    {
        null = null;
        IAPCharacterPromoGift.CharacterPromoGiftUpdateEvent.AddListener(call:  listener);
    }
    public static void RemoveGiftUpdateListener(UnityEngine.Events.UnityAction listener)
    {
        null = null;
        IAPCharacterPromoGift.CharacterPromoGiftUpdateEvent.RemoveListener(call:  listener);
    }
    public static void CheckPromoGift(bool showLoadingWhenProc = False)
    {
        if(showLoadingWhenProc != false)
        {
                DialogManager.ShowLoading();
        }
        
        AzureRemoteConfig.FetchRemote(callback:  new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  0, method:  static System.Void IAPCharacterPromoGift::OnPromoGiftFetchDone(bool success, string error)));
    }
    public static bool HasPromoGift()
    {
        null = null;
        if(IAPCharacterPromoGift.promoData != null)
        {
                return IAPCharacterPromoGift.promoData.HasPromo();
        }
        
        return IAPCharacterPromoGift.promoData.HasPromo();
    }
    private static void OnPromoGiftFetchDone(bool success, string error)
    {
        var val_3;
        DialogManager.HideLoading();
        if(success == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        IAPCharacterPromoGift.promoData = UnityEngine.JsonUtility.FromJson<CharacterPromoGiftRemoteSettingData>(json:  AzureRemoteConfig.GetString(key:  "data.CharacterPromoConfig", defaultValue:  ""));
        val_3 = null;
        IAPCharacterPromoGift.CharacterPromoGiftUpdateEvent.Invoke();
    }
    private static void SetFetchEnable(bool enable)
    {
        if(enable != false)
        {
                DialogManager.ShowLoading();
            return;
        }
        
        DialogManager.HideLoading();
    }
    private static IAPCharacterPromoGift()
    {
        IAPCharacterPromoGift.CharacterPromoGiftUpdateEvent = new UnityEngine.Events.UnityEvent();
        IAPCharacterPromoGift.promoData = new CharacterPromoGiftRemoteSettingData();
    }

}
