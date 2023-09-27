using UnityEngine;
public class AvatarGridView : UnlockableGridView<AvatarGridViewItem, ProfileUnlockables_Avatar>
{
    // Methods
    protected override void OnSelectionChanged(CharacterNameID cid)
    {
        mem[1152921528847793712] = cid;
        this.OnSelectionChanged(cid:  cid);
        if(cid == 999999)
        {
                System.Collections.Generic.List<ProfileUnlockables_Avatar> val_1 = AvatarCollection.GetCommonAvatars();
        }
        
        this.SetItems(newItems:  AvatarCollection.GetAvatars(cid:  cid));
    }
    public override void SetCommonItems()
    {
        this.SetItems(newItems:  AvatarCollection.GetCommonAvatars());
    }
    protected override AvatarGridViewItem OnItemAdd(ProfileUnlockables_Avatar data)
    {
        AvatarGridViewItem val_1 = UnityEngine.Object.Instantiate<AvatarGridViewItem>(original:  static_value_03330000);
        val_1.gameObject.SetActive(value:  true);
        val_1.gameObject.name = X23;
        val_1.transform.SetParent(p:  X23.transform);
        val_1.Setup(aNewData:  data, aNewParent:  this);
        return val_1;
    }
    protected override void ShowUnlockDesc(ProfileUnlockables_Avatar data)
    {
        var val_23;
        string val_24;
        string val_25;
        var val_26;
        DataStructs.Items val_27;
        var val_28;
        var val_29;
        AvatarGridView.<>c__DisplayClass3_0 val_1 = new AvatarGridView.<>c__DisplayClass3_0();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .data = data;
        mem[1152921528848300456] = this;
        if(data != null)
        {
            goto label_43;
        }
        
        label_44:
        label_43:
        if((System.String.IsNullOrEmpty(value:  0)) == false)
        {
            goto label_3;
        }
        
        val_23 = "";
        if("" != null)
        {
            goto label_8;
        }
        
        goto label_5;
        label_3:
        val_23 = LanguageManager.GetText(key:  mem[data + 32]);
        if(val_23 != null)
        {
            goto label_8;
        }
        
        label_5:
        label_8:
        val_24 = val_23.Replace(oldValue:  "{0}", newValue:  "<br>").Replace(oldValue:  "{1}", newValue:  "<size=80%>").Replace(oldValue:  "{2}", newValue:  "</size>");
        if((mem[data + 24]) != 999999)
        {
                val_24 = val_24.Replace(oldValue:  "{c}", newValue:  CharacterHelper.GetLocalizedClanAndName(cid:  mem[data + 24]));
        }
        
        if((System.String.IsNullOrEmpty(value:  mem[data + 40])) == false)
        {
            goto label_21;
        }
        
        val_25 = "";
        if(val_1 != null)
        {
            goto label_26;
        }
        
        goto label_23;
        label_21:
        val_25 = LanguageManager.GetText(key:  mem[data + 40]);
        if(val_1 != null)
        {
            goto label_26;
        }
        
        label_23:
        label_26:
        if((System.String.IsNullOrEmpty(value:  val_24)) != false)
        {
                if(((System.String.IsNullOrEmpty(value:  val_25)) != false) && ((mem[data + 24]) != 999999))
        {
                object[] val_14 = new object[1];
            val_14[0] = CharacterHelper.GetLocalizedClanAndName(cid:  mem[data + 24]);
            val_24 = LanguageManager.GetTextFormat(key:  "LK.UnlockCondition.Unlock", list:  val_14);
        }
        
        }
        
        if(val_1 == null)
        {
            goto label_41;
        }
        
        val_26 = val_1;
        .dialog = 0;
        goto label_42;
        label_1:
        mem[16] = data;
        mem[24] = this;
        if(mem[16] != 0)
        {
            goto label_43;
        }
        
        goto label_44;
        label_41:
        val_26 = 32;
        mem[32] = 0;
        label_42:
        mem[32] = AvatarTitleUnlockDialog.Show(msg1:  val_24, msg2:  val_25, andOrText:  .data.localizedLogicText, currency:  mem[data + 52], price:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = mem[data + 56], hiddenValue = mem[data + 56], fakeValue = mem[data + 56 + 8], inited = mem[data + 56 + 8]}), purchaseDoneAction:  new System.Action(object:  val_1, method:  System.Void AvatarGridView.<>c__DisplayClass3_0::<ShowUnlockDesc>b__0()));
        if((System.String.IsNullOrEmpty(value:  val_24)) == false)
        {
            goto label_51;
        }
        
        val_27 = 0;
        if(val_1 != null)
        {
            goto label_56;
        }
        
        goto label_53;
        label_51:
        if(val_1 != null)
        {
            goto label_56;
        }
        
        label_53:
        label_56:
        if((((mem[data + 48]) != 2) ? 1 : 0) == 0)
        {
            goto label_59;
        }
        
        val_28 = null;
        val_28 = null;
        val_27 = DataStructs.UserDataDictionary.Items;
        val_29 = val_27.IsAvatarEligibleForPurchase(avatar:  .data);
        if((val_19 + 80 + 24) != 0)
        {
            goto label_66;
        }
        
        goto label_65;
        label_59:
        val_29 = 1;
        if((val_19 + 80 + 24) != 0)
        {
            goto label_66;
        }
        
        label_65:
        label_66:
        val_19 + 80 + 24.interactable = true;
    }
    public AvatarGridView()
    {
    
    }

}
