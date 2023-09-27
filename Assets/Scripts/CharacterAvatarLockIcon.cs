using UnityEngine;
public class CharacterAvatarLockIcon : MonoBehaviour
{
    // Fields
    public CharacterNameID charNameID;
    private static bool lockIconsLoaded;
    private static UnityEngine.Sprite lockIcon_Ika;
    private static UnityEngine.Sprite lockIcon_Tako;
    public UnityEngine.GameObject lockIconObject;
    
    // Methods
    private void Awake()
    {
        this.LoadLockIcons();
    }
    private void LoadLockIcons()
    {
        var val_3 = null;
        if(CharacterAvatarLockIcon.lockIconsLoaded == true)
        {
                return;
        }
        
        CharacterAvatarLockIcon.lockIconsLoaded = true;
        CharacterAvatarLockIcon.lockIcon_Ika = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "Characters/LockIcons/LockIcon_Ika");
        CharacterAvatarLockIcon.lockIcon_Tako = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "Characters/LockIcons/LockIcon_Tako");
    }
    private void OnEnable()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        GGPPurchasingManager.OnPurchaseSuccess.AddListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void CharacterAvatarLockIcon::OnPurchaseDone(IAPItemIds itemId)));
        val_4 = null;
        val_4 = null;
        CharacterHelper.OnCelebLockStateChanged.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void CharacterAvatarLockIcon::UpdateIconLockStatus()));
    }
    private void OnDisable()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        GGPPurchasingManager.OnPurchaseSuccess.RemoveListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void CharacterAvatarLockIcon::OnPurchaseDone(IAPItemIds itemId)));
        val_4 = null;
        val_4 = null;
        CharacterHelper.OnCelebLockStateChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void CharacterAvatarLockIcon::UpdateIconLockStatus()));
    }
    private void OnPurchaseDone(IAPItemIds itemId)
    {
        this.UpdateIconLockStatus();
    }
    private void OnInviteUnlock()
    {
        if(this.charNameID != 0)
        {
                return;
        }
        
        this.UpdateIconLockStatus();
    }
    public void UpdateIconLockStatus()
    {
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        GameMode val_21;
        val_17 = null;
        val_17 = null;
        if(DataStructs.UserDataDictionary.Items != null)
        {
                val_18 = DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  this.charNameID);
        }
        else
        {
                val_18 = 1;
        }
        
        UnityEngine.UI.Button val_2 = this.GetComponent<UnityEngine.UI.Button>();
        if(NetworkManager_Custom.IsNetwork == true)
        {
            goto label_10;
        }
        
        val_19 = 1152921505064992768;
        val_20 = null;
        val_20 = null;
        val_21 = Character_GlobalInfo.gameMode;
        if(val_21 == 6)
        {
            goto label_10;
        }
        
        val_21 = Character_GlobalInfo.gameMode;
        if(val_21 != 10)
        {
            goto label_13;
        }
        
        label_10:
        label_27:
        val_2.interactable = (val_18 == 0) ? 1 : 0;
        if(NetworkManager_Custom.IsNetwork != false)
        {
                ButtonBounce val_6 = this.GetComponent<ButtonBounce>();
            if(val_6 != null)
        {
                var val_8 = (val_6.isRightSideCharacter != true) ? 0 : (val_18);
        }
        else
        {
                var val_10 = (val_6.isRightSideCharacter != true) ? 0 : (val_18);
        }
        
            val_19 = val_6.isRightSideCharacter;
            val_2.interactable = ((val_10 == 0) ? 1 : 0) & val_19 ^ 1;
        }
        
        if(0 == this.lockIconObject)
        {
                this.CreateLockObject();
        }
        
        if(val_10 == 0)
        {
                this.lockIconObject.SetActive(value:  false);
        }
        
        if(this.charNameID != 999999)
        {
                return;
        }
        
        this.lockIconObject.SetActive(value:  false);
        return;
        label_13:
        if(val_2 != null)
        {
            goto label_27;
        }
        
        goto label_27;
    }
    private void CreateLockObject()
    {
        var val_13;
        var val_14;
        UnityEngine.Sprite val_15;
        var val_16;
        UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  CharNameIDConverter.ToString(enumID:  this.charNameID)(CharNameIDConverter.ToString(enumID:  this.charNameID)) + "_Lock_Icon");
        this.lockIconObject = val_3;
        UnityEngine.RectTransform val_4 = val_3.AddComponent<UnityEngine.RectTransform>();
        val_4.SetParent(p:  this.transform);
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.one;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        val_4.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        if(val_4 != null)
        {
                val_4.anchoredPosition3D = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        else
        {
                val_4.anchoredPosition3D = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        
        val_4.rotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        UnityEngine.UI.Image val_9 = val_3.AddComponent<UnityEngine.UI.Image>();
        UnityEngine.Color val_10 = val_9.color;
        val_9.color = new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = 0.65f};
        CharacterClan val_11 = CharNameIDConverter.GetClan(nameID:  this.charNameID);
        if(((val_11 - 2) >= 2) && (val_11 != 1))
        {
                if(val_11 != 0)
        {
                return;
        }
        
            val_13 = 1152921505130487808;
            val_14 = null;
            val_14 = null;
            val_15 = CharacterAvatarLockIcon.lockIcon_Ika;
        }
        else
        {
                val_13 = 1152921505130487808;
            val_16 = null;
            val_16 = null;
            val_15 = CharacterAvatarLockIcon.lockIcon_Tako;
        }
        
        val_9.sprite = val_15;
    }
    public CharacterAvatarLockIcon()
    {
    
    }
    private static CharacterAvatarLockIcon()
    {
    
    }

}
