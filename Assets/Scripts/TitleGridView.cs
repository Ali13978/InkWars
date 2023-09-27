using UnityEngine;
public class TitleGridView : UnlockableGridView<TitleGridViewItem, ProfileUnlockables_Title>
{
    // Methods
    protected override void OnSelectionChanged(CharacterNameID cid)
    {
        this.OnSelectionChanged(cid:  cid);
        if(cid == 999999)
        {
                System.Collections.Generic.List<ProfileUnlockables_Title> val_1 = TitleCollection.GetCommon();
        }
        
        this.SetItems(newItems:  TitleCollection.GetSpecific(cid:  cid));
    }
    public override void SetCommonItems()
    {
        this.SetItems(newItems:  TitleCollection.GetCommon());
    }
    protected override TitleGridViewItem OnItemAdd(ProfileUnlockables_Title data)
    {
        TitleGridViewItem val_1 = UnityEngine.Object.Instantiate<TitleGridViewItem>(original:  static_value_03330000);
        val_1.gameObject.SetActive(value:  true);
        val_1.transform.SetParent(p:  X23.transform);
        val_1.Setup(aNewData:  data, aNewParent:  this);
        return val_1;
    }
    protected override void ShowUnlockDesc(ProfileUnlockables_Title data)
    {
        string val_14;
        var val_15;
        TitleGridView.<>c__DisplayClass3_0 val_1 = new TitleGridView.<>c__DisplayClass3_0();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .data = data;
        mem[1152921528855758024] = this;
        if(data != null)
        {
            goto label_31;
        }
        
        label_32:
        label_31:
        if((System.String.IsNullOrEmpty(value:  0)) == false)
        {
            goto label_3;
        }
        
        val_14 = "";
        if(val_1 != null)
        {
            goto label_8;
        }
        
        goto label_5;
        label_3:
        val_14 = LanguageManager.GetText(key:  mem[data + 32]);
        if(val_1 != null)
        {
            goto label_8;
        }
        
        label_5:
        label_8:
        if((mem[data + 24]) != 999999)
        {
                val_14 = val_14.Replace(oldValue:  "{0}", newValue:  CharacterHelper.GetLocalizedClanAndName(cid:  mem[data + 24]));
        }
        
        if((System.String.IsNullOrEmpty(value:  val_14)) != false)
        {
                if(((System.String.IsNullOrEmpty(value:  "")) != false) && ((mem[data + 24]) != 999999))
        {
                object[] val_8 = new object[1];
            val_8[0] = CharacterHelper.GetLocalizedClanAndName(cid:  mem[data + 24]);
            val_14 = LanguageManager.GetTextFormat(key:  "LK.UnlockCondition.Unlock", list:  val_8);
        }
        
        }
        
        if(val_1 == null)
        {
            goto label_29;
        }
        
        val_15 = val_1;
        .dialog = 0;
        goto label_30;
        label_1:
        mem[16] = data;
        mem[24] = this;
        if(mem[16] != 0)
        {
            goto label_31;
        }
        
        goto label_32;
        label_29:
        val_15 = 32;
        mem[32] = 0;
        label_30:
        mem[32] = AvatarTitleUnlockDialog.Show(msg1:  val_14, msg2:  "", andOrText:  "", currency:  mem[data + 52], price:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = mem[data + 56], hiddenValue = mem[data + 56], fakeValue = mem[data + 56 + 8], inited = mem[data + 56 + 8]}), purchaseDoneAction:  new System.Action(object:  val_1, method:  System.Void TitleGridView.<>c__DisplayClass3_0::<ShowUnlockDesc>b__0()));
    }
    public TitleGridView()
    {
    
    }

}
