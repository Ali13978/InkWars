using UnityEngine;
public class CharacterSelect_CharacterController : MonoBehaviour
{
    // Fields
    public CharacterNameID charNameID;
    public bool leftSide;
    private CharacterAvatarController avatarTemplate;
    private CharacterSelect charSelectScript;
    private CharacterAssetLoader assetLoader;
    private CharAnimationController animController;
    private CharacterAvatarLockIcon lockIconScript;
    private static bool clanSymbolsLoaded;
    private static UnityEngine.Sprite clanSymbol_Ika;
    private static UnityEngine.Sprite clanSymbol_Tako;
    private static UnityEngine.Sprite clanSymbol_Mermaid;
    private static UnityEngine.Sprite clanSymbol_IronShark;
    
    // Methods
    public void SelectCharacter()
    {
        bool val_22;
        CharacterNameID val_23;
        CharacterSelect val_24;
        CharacterNameID val_25;
        CharacterSelect val_26;
        var val_27;
        var val_28;
        if(this.charSelectScript.canSelect == false)
        {
                return;
        }
        
        val_22 = this.leftSide;
        if(val_22 == false)
        {
            goto label_3;
        }
        
        if(this.charSelectScript.leftLocked == false)
        {
            goto label_5;
        }
        
        val_22 = this.leftSide;
        label_3:
        if(val_22 == true)
        {
                return;
        }
        
        if(this.charSelectScript.rightLocked == false)
        {
            goto label_8;
        }
        
        return;
        label_5:
        if(this.charSelectScript == null)
        {
            goto label_9;
        }
        
        val_23 = this.charSelectScript.LeftCurrentSelection;
        val_24 = this.charSelectScript;
        goto label_10;
        label_8:
        if(this.charSelectScript == null)
        {
            goto label_11;
        }
        
        val_25 = this.charSelectScript.RightCurrentSelection;
        val_26 = this.charSelectScript;
        goto label_12;
        label_9:
        val_24 = this.charSelectScript;
        val_23 = this.charSelectScript.LeftCurrentSelection;
        if(val_24 == null)
        {
            goto label_13;
        }
        
        label_10:
        label_51:
        if((this.SetSideBasedObjects(leftSide:  true, currentSelection: ref  val_23, nameController:  this.charSelectScript.LeftCurrentSelectionName, currentSelectionStatsImage:  this.charSelectScript.LeftCurrentSelectionStats, clanSymbolImage:  this.charSelectScript.LeftClanSymbol)) == false)
        {
            goto label_26;
        }
        
        this.charSelectScript.MoveGlow(leftSide:  true, ga:  this.gameObject);
        this.charSelectScript.SetGlowEnable(leftSide:  true, enable:  (~(CharacterHelper.IsHidden(cid:  this.charNameID))) & 1);
        this.charSelectScript.leftSelectedCharacterController = this;
        this.charSelectScript.leftDetailedStats.gameObject.SetActive(value:  false);
        this.charSelectScript.SetITweenCharacterLeft();
        goto label_26;
        label_11:
        val_26 = this.charSelectScript;
        val_25 = this.charSelectScript.RightCurrentSelection;
        if(val_26 == null)
        {
            goto label_25;
        }
        
        label_12:
        label_53:
        if((this.SetSideBasedObjects(leftSide:  false, currentSelection: ref  val_25, nameController:  this.charSelectScript.RightCurrentSelectionName, currentSelectionStatsImage:  this.charSelectScript.RightCurrentSelectionStats, clanSymbolImage:  this.charSelectScript.RightClanSymbol)) != false)
        {
                this.charSelectScript.MoveGlow(leftSide:  false, ga:  this.gameObject);
            this.charSelectScript.SetGlowEnable(leftSide:  false, enable:  (~(CharacterHelper.IsHidden(cid:  this.charNameID))) & 1);
            this.charSelectScript.rightSelectedCharacterController = this;
            this.charSelectScript.rightDetailedStats.gameObject.SetActive(value:  false);
            this.charSelectScript.SetITweenCharacterRight();
        }
        
        label_26:
        this.animController.RetrieveCharacterBundle(charNameID:  this.charNameID);
        UnityEngine.Coroutine val_14 = this.StartCoroutine(routine:  this.animController.LoadAnimations_CharacterSelect());
        UnityEngine.Color val_15 = UnityEngine.Color.white;
        val_27 = null;
        val_27 = null;
        this.animController.color = new UnityEngine.Color() {r = val_15.r, g = val_15.g, b = val_15.b, a = ((DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  this.charNameID)) != true) ? 0.5f : 1f};
        this.charSelectScript.SetupBuyButton(isLeft:  (this.leftSide == true) ? 1 : 0, cid:  this.charNameID, selectController:  this);
        val_28 = null;
        val_28 = null;
        this.charSelectScript.SetConfirmButtonInteractable(isLeftSide:  (this.leftSide == true) ? 1 : 0, enable:  (~(DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  this.charNameID))) & 1);
        return;
        label_13:
        if(this.charSelectScript == null)
        {
            goto label_47;
        }
        
        goto label_51;
        label_25:
        if(this.charSelectScript == null)
        {
            goto label_49;
        }
        
        goto label_53;
        label_47:
        if(this.charSelectScript != null)
        {
            goto label_51;
        }
        
        goto label_52;
        label_49:
        if(this.charSelectScript != null)
        {
            goto label_53;
        }
        
        label_52:
    }
    public void RefreshButton()
    {
        if(this != this.charSelectScript.leftSelectedCharacterController)
        {
                if(this != this.charSelectScript.rightSelectedCharacterController)
        {
            goto label_8;
        }
        
        }
        
        this.SelectCharacter();
        label_8:
        CharacterAvatarLockIcon val_4 = this.gameObject.GetComponent<CharacterAvatarLockIcon>();
        if(0 == val_4)
        {
                return;
        }
        
        val_4.UpdateIconLockStatus();
    }
    public bool ConfirmCharacter()
    {
        var val_4;
        var val_5;
        bool val_6;
        var val_7;
        val_4 = this;
        val_5 = null;
        val_5 = null;
        if((DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  this.charNameID)) == false)
        {
            goto label_4;
        }
        
        if(NetworkManager_Custom.IsNetwork == false)
        {
            goto label_5;
        }
        
        val_6 = this.leftSide;
        val_7 = 0;
        if(val_6 == true)
        {
                return (bool)val_7;
        }
        
        goto label_7;
        label_4:
        val_6 = this.leftSide;
        label_7:
        if(val_6 == false)
        {
            goto label_8;
        }
        
        Character_GlobalInfo.SetLeftPlayer(nameID:  this.charNameID);
        this.charSelectScript.animControllerLeft.PlayAnimation(newAnimName:  15, forceOverride:  false);
        this.charSelectScript.leftLocked = true;
        if(this.charSelectScript.leftDetailedStats != null)
        {
            goto label_24;
        }
        
        label_25:
        label_24:
        val_4 = this.charSelectScript.leftDetailedStats.gameObject;
        val_4.SetActive(value:  false);
        val_7 = 1;
        return (bool)val_7;
        label_5:
        val_7 = 0;
        return (bool)val_7;
        label_8:
        Character_GlobalInfo.SetRightPlayer(nameID:  this.charNameID);
        this.charSelectScript.animControllerRight.PlayAnimation(newAnimName:  15, forceOverride:  false);
        this.charSelectScript.rightLocked = true;
        if(this.charSelectScript.rightDetailedStats != null)
        {
            goto label_24;
        }
        
        goto label_25;
    }
    private bool SetSideBasedObjects(bool leftSide, ref CharacterNameID currentSelection, CharacterNameController nameController, UnityEngine.UI.Image currentSelectionStatsImage, UnityEngine.UI.Image clanSymbolImage)
    {
        var val_3;
        if(currentSelection == this.charNameID)
        {
                val_3 = 0;
            return (bool)val_3;
        }
        
        currentSelection = this.charNameID;
        this.SetNameText(nameController:  nameController);
        currentSelectionStatsImage.sprite = CharacterAssetLoader.LoadResource_CharacterStatType(charNameID:  this.charNameID, left:  leftSide);
        this.SetClanSymbol(clanSymbolImage:  clanSymbolImage);
        val_3 = 1;
        return (bool)val_3;
    }
    private void SetClanSymbol(UnityEngine.UI.Image clanSymbolImage)
    {
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        if(this.charNameID == 42)
        {
            goto label_1;
        }
        
        if(this.charNameID != 34)
        {
            goto label_2;
        }
        
        val_2 = null;
        val_2 = null;
        if(clanSymbolImage != null)
        {
            goto label_18;
        }
        
        label_19:
        label_18:
        clanSymbolImage.sprite = CharacterSelect_CharacterController.clanSymbol_Mermaid;
        return;
        label_1:
        val_3 = null;
        val_3 = null;
        if(clanSymbolImage != null)
        {
            goto label_18;
        }
        
        goto label_19;
        label_2:
        CharacterClan val_1 = CharNameIDConverter.GetClan(nameID:  this.charNameID);
        if(val_1 == 1)
        {
            goto label_10;
        }
        
        if(val_1 != 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(clanSymbolImage != null)
        {
            goto label_18;
        }
        
        goto label_19;
        label_10:
        val_5 = null;
        val_5 = null;
        if(clanSymbolImage != null)
        {
            goto label_18;
        }
        
        goto label_19;
    }
    public UnityEngine.Sprite GetCharacterType()
    {
        return CharacterAssetLoader.LoadResource_CharacterStatType(charNameID:  this.charNameID, left:  true);
    }
    public void SetNameText(CharacterNameController nameController)
    {
        nameController.characterId = this.charNameID;
    }
    private void SelectCharacterNetworked()
    {
        NetworkBehaviour_CharacterSelect.instance.SendCharacterSelectMessage(selection:  this.charNameID);
    }
    private void OnEnable()
    {
    
    }
    private void OnDisable()
    {
    
    }
    private void Start()
    {
        UnityEngine.Object val_44;
        CharacterNameID val_45;
        var val_48;
        var val_49;
        val_44 = this;
        this.lockIconScript = this.gameObject.GetComponent<CharacterAvatarLockIcon>();
        val_2.charNameID = this.charNameID;
        this.lockIconScript.UpdateIconLockStatus();
        if(this.charNameID == 999999)
        {
                UnityEngine.UI.Image val_3 = this.GetComponent<UnityEngine.UI.Image>();
            val_45 = 1152921504858337280;
            if(0 != val_3)
        {
                val_3.enabled = false;
        }
        
            val_44 = this.GetComponent<UnityEngine.UI.Button>();
            if(0 == val_44)
        {
                return;
        }
        
            val_44.enabled = false;
            return;
        }
        
        this.charSelectScript = CharacterSelect.instance;
        bool val_46 = ~(this.gameObject.GetComponent<ButtonBounce>().isRightSideCharacter);
        val_46 = val_46 & 1;
        this.leftSide = val_46;
        UnityEngine.UI.Button val_11 = this.gameObject.GetComponent<UnityEngine.UI.Button>();
        val_11.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void CharacterSelect_CharacterController::SelectCharacter()));
        if(this.leftSide != false)
        {
                if(NetworkManager_Custom.IsNetwork != false)
        {
                val_11.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelect_CharacterController::SelectCharacterNetworked()));
        }
        
        }
        
        UnityEngine.UI.Image val_18 = this.gameObject.GetComponent<UnityEngine.UI.Image>();
        if(val_18 != 0)
        {
                UnityEngine.Color val_20 = UnityEngine.Color.clear;
            val_18.color = new UnityEngine.Color() {r = val_20.r, g = val_20.g, b = val_20.b, a = val_20.a};
        }
        
        this.animController = (this.leftSide == true) ? this.charSelectScript.animControllerLeft : this.charSelectScript.animControllerRight;
        CharacterAvatarController val_23 = UnityEngine.Object.Instantiate<CharacterAvatarController>(original:  this.avatarTemplate, parent:  this.transform);
        if(val_23 != null)
        {
                val_23.Init(cid:  this.charNameID, aNewMaskType:  0, reloadAvatar:  true, isFaceLeft:  (this.leftSide == false) ? 1 : 0);
        }
        else
        {
                val_23.Init(cid:  this.charNameID, aNewMaskType:  0, reloadAvatar:  true, isFaceLeft:  (this.leftSide == false) ? 1 : 0);
        }
        
        val_23.SetRoundAvatarScale();
        val_45 = this.charNameID;
        this.lockIconScript = this.gameObject.GetComponent<CharacterAvatarLockIcon>();
        val_27.charNameID = val_45;
        this.lockIconScript.lockIconObject.transform.SetAsLastSibling();
        this.lockIconScript.UpdateIconLockStatus();
        this.lockIconScript.LoadClanSymbols();
        if((CharacterHelper.IsHidden(cid:  this.charNameID)) == false)
        {
                return;
        }
        
        UnityEngine.UI.Image val_30 = this.GetComponent<UnityEngine.UI.Image>();
        if(0 != val_30)
        {
                val_30.enabled = false;
        }
        
        UnityEngine.UI.Button val_32 = this.GetComponent<UnityEngine.UI.Button>();
        if(0 != val_32)
        {
                val_32.enabled = false;
        }
        
        System.Collections.IEnumerator val_35 = this.transform.GetEnumerator();
        label_68:
        var val_47 = 0;
        val_47 = val_47 + 1;
        if(val_35.MoveNext() == false)
        {
            goto label_55;
        }
        
        var val_48 = 0;
        val_48 = val_48 + 1;
        val_48 = val_35.Current;
        if(val_48 != null)
        {
                val_48 = 0;
        }
        
        val_48.gameObject.SetActive(value:  false);
        goto label_68;
        label_55:
        val_49 = 0;
        val_45 = 1152921504621170688;
        val_44 = val_35;
        if(val_44 != null)
        {
                var val_49 = 0;
            val_49 = val_49 + 1;
            val_44.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    private void LoadClanSymbols()
    {
        var val_5 = null;
        if(CharacterSelect_CharacterController.clanSymbolsLoaded == true)
        {
                return;
        }
        
        CharacterSelect_CharacterController.clanSymbolsLoaded = true;
        CharacterSelect_CharacterController.clanSymbol_Ika = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "Characters/ClanSymbols/Ika_Inked");
        CharacterSelect_CharacterController.clanSymbol_Tako = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "Characters/ClanSymbols/Tako_Inked");
        CharacterSelect_CharacterController.clanSymbol_Mermaid = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "Characters/ClanSymbols/Mermaid_Inked");
        CharacterSelect_CharacterController.clanSymbol_IronShark = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "Characters/ClanSymbols/Shark_Inked");
    }
    private void OnInviteUnlock()
    {
        if(this.charNameID != 0)
        {
                return;
        }
        
        if(this.leftSide == false)
        {
            goto label_1;
        }
        
        if(this.charSelectScript.LeftCurrentSelection == 0)
        {
            goto label_3;
        }
        
        if(this.leftSide == true)
        {
                return;
        }
        
        label_1:
        if(this.charNameID != this.charSelectScript.RightCurrentSelection)
        {
                return;
        }
        
        label_3:
        this.SelectCharacter();
    }
    public CharacterSelect_CharacterController()
    {
    
    }
    private static CharacterSelect_CharacterController()
    {
    
    }

}
