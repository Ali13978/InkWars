using UnityEngine;
public static class CharacterSelectBuyButton
{
    // Methods
    public static UnityEngine.GameObject SetupBuyButton(CharacterNameID cid, UnityEngine.Transform root, UnityEngine.Events.UnityAction OnPurchaseDone)
    {
        var val_23;
        var val_24;
        var val_25;
        DataStructs.Items val_26;
        var val_27;
        IAPItemIds val_28;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_29;
        var val_30;
        val_23 = 0;
        if(NetworkManager_Custom.IsNetwork == true)
        {
                return (UnityEngine.GameObject)val_23;
        }
        
        val_24 = null;
        val_24 = null;
        if(Character_GlobalInfo.isOfflineMode == false)
        {
            goto label_4;
        }
        
        label_23:
        val_23 = 0;
        return (UnityEngine.GameObject)val_23;
        label_4:
        val_25 = null;
        val_25 = null;
        val_26 = DataStructs.UserDataDictionary.Items;
        if(val_26 == null)
        {
            goto label_23;
        }
        
        val_26 = DataStructs.UserDataDictionary.Items;
        if(val_26 == null)
        {
                val_26 = 0;
        }
        
        if((val_26.IsCharacterLocked(id:  cid)) == false)
        {
                return (UnityEngine.GameObject)val_23;
        }
        
        UnityEngine.RectTransform val_3 = CharacterHelper.GetUnlockButtonPrefab(id:  cid);
        if(0 != val_3)
        {
            goto label_16;
        }
        
        object[] val_5 = new object[1];
        val_5[0] = cid;
        UnityEngine.Debug.LogErrorFormat(format:  "Cannot load unlock button prefab for {0}", args:  val_5);
        goto label_23;
        label_16:
        UnityEngine.GameObject val_7 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  val_3, parent:  root).gameObject;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        val_7.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        if(0 == (val_7.GetComponent<ExpressCharacterBuyButton>()))
        {
            goto label_33;
        }
        
        ExpressCharacterBuyButton val_12 = val_7.GetComponent<ExpressCharacterBuyButton>();
        CharacterData val_13 = CharacterDataManager.Get(id:  cid);
        if(val_12 == null)
        {
            goto label_37;
        }
        
        mem2[0] = val_13.iapId;
        mem2[0] = 1;
        val_27 = val_12;
        goto label_38;
        label_33:
        if(0 != (val_7.GetComponent<TwitterFollowButton>()))
        {
                val_7.GetComponent<TwitterFollowButton>().enabled = false;
            return (UnityEngine.GameObject)val_23;
        }
        
        if(0 == (val_7.GetComponent<PearlBuyButton>()))
        {
                return (UnityEngine.GameObject)val_23;
        }
        
        CharacterData val_20 = CharacterDataManager.Get(id:  cid);
        if(val_20 == null)
        {
            goto label_53;
        }
        
        val_28 = val_20.iapId;
        val_29 = val_20.virtualPrice;
        goto label_54;
        label_37:
        mem[24] = val_13.iapId;
        mem[42] = 1;
        val_27 = 0;
        label_38:
        val_27.ResetButton();
        if(OnPurchaseDone == null)
        {
                return (UnityEngine.GameObject)val_23;
        }
        
        if(64 != 0)
        {
            goto label_62;
        }
        
        label_63:
        label_62:
        64.AddListener(call:  OnPurchaseDone);
        return (UnityEngine.GameObject)val_23;
        label_53:
        val_28 = 5;
        val_29 = 0;
        val_30 = 0;
        label_54:
        val_7.GetComponent<PearlBuyButton>().Setup(aNewItemName:  val_20.localizedText.name, aNewItem:  val_28, aNewPrice:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {hiddenValue = 49046232, inited = true}, aNewCurrency:  val_20.virtualCurrency);
        if(OnPurchaseDone == null)
        {
                return (UnityEngine.GameObject)val_23;
        }
        
        if(val_19.OnPurchaseDone != null)
        {
            goto label_62;
        }
        
        goto label_63;
    }

}
