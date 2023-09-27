using UnityEngine;
public class CharacterStore_Controller : MonoBehaviour
{
    // Fields
    private static bool muteFirstButtonSoundForInit;
    public static UnityEngine.Sprite backgroundIka;
    public static UnityEngine.Sprite backgroundTako;
    public CharacterNameID charNameID;
    public bool loaded;
    public int displayPriority;
    private CharacterAvatarController avatarController;
    private UnityEngine.GameObject promoGroup;
    private UnityEngine.UI.Text pearlTxt;
    private UnityEngine.UI.Image pearlIcon;
    private UnityEngine.UI.Text shellTxt;
    private UnityEngine.UI.Image shellIcon;
    private UnityEngine.UI.HorizontalLayoutGroup promoInfoLayout;
    private CharacterAssetLoader assetLoader;
    private UnityEngine.Sprite spriteDynamicPose;
    private CharacterData charData;
    private UnityEngine.Sprite celebPhoto;
    private bool GOTITscale;
    private UnityEngine.Vector3 GOTITscaleoriginal;
    private UnityEngine.CanvasGroup canvasGroup;
    
    // Methods
    public void Initialize()
    {
        DG.Tweening.IDOTweenInit val_1 = DG.Tweening.DOTween.Init(recycleAllByDefault:  new System.Nullable<System.Boolean>() {HasValue = false}, useSafeMode:  new System.Nullable<System.Boolean>() {HasValue = false}, logBehaviour:  new System.Nullable<DG.Tweening.LogBehaviour>() {HasValue = false});
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.LoadResources());
        this.OnPromoGiftChanged();
    }
    private void Awake()
    {
        this.canvasGroup = this.GetComponent<UnityEngine.CanvasGroup>();
    }
    private void OnEnable()
    {
        null = null;
        GGPPurchasingManager.OnPurchaseSuccess.AddListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void CharacterStore_Controller::OnPurchased(IAPItemIds id)));
        IAPCharacterPromoGift.AddGiftUpdateListener(listener:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterStore_Controller::OnPromoGiftChanged()));
    }
    private void OnDisable()
    {
        null = null;
        GGPPurchasingManager.OnPurchaseSuccess.RemoveListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void CharacterStore_Controller::OnPurchased(IAPItemIds id)));
        IAPCharacterPromoGift.RemoveGiftUpdateListener(listener:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterStore_Controller::OnPromoGiftChanged()));
    }
    private void OnPromoGiftChanged()
    {
        var val_25;
        this.promoGroup.gameObject.SetActive(value:  false);
        val_25 = null;
        val_25 = null;
        if((DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  this.charNameID)) == false)
        {
                return;
        }
        
        CharacterPromoGiftData val_3 = IAPCharacterPromoGift.Get(character:  this.charNameID);
        if(val_3 == null)
        {
                return;
        }
        
        if(val_3.IsActive == false)
        {
                return;
        }
        
        this.pearlTxt.gameObject.SetActive(value:  val_3.HasBoth);
        this.pearlIcon.gameObject.SetActive(value:  val_3.HasPearl);
        if(val_3.HasBoth != false)
        {
                string val_12 = val_3.ShortPearlString;
        }
        else
        {
                string val_13 = val_3.pearl.ToString();
        }
        
        this.shellTxt.gameObject.SetActive(value:  val_3.HasShell);
        this.shellIcon.gameObject.SetActive(value:  val_3.HasShell);
        if(val_3.HasBoth != false)
        {
                string val_21 = val_3.ShortShellString;
        }
        else
        {
                string val_22 = val_3.shell.ToString();
        }
        
        this.promoGroup.gameObject.SetActive(value:  true);
        UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(layoutRoot:  this.promoInfoLayout.GetComponent<UnityEngine.RectTransform>());
        this.promoInfoLayout.enabled = false;
        this.promoInfoLayout.enabled = true;
    }
    private void OnPurchased(IAPItemIds id)
    {
        CharacterData val_6;
        var val_7;
        var val_8;
        if(0 != this.charData)
        {
            goto label_3;
        }
        
        val_6 = CharacterDataManager.Get(id:  this.charNameID);
        this.charData = val_6;
        if(val_6 != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_3:
        val_6 = this.charData;
        if(val_6 != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        if(this.charData.iapId != id)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if(this != sceneCharacters.instance.currentCharacterController)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        DataStructs.Items val_6 = DataStructs.UserDataDictionary.Items;
        val_6 = (~(val_6.IsCharacterLocked(id:  this.charNameID))) & 1;
        this.SetUnlocked(unlocked:  val_6);
        this.SetImage_GotIt(active:  val_6, bounceIn:  val_6);
        this.promoGroup.gameObject.SetActive(value:  false);
    }
    private System.Collections.IEnumerator LoadResources()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new CharacterStore_Controller.<LoadResources>d__26();
    }
    public void SelectCharacterStart()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.SelectCharacter());
    }
    private System.Collections.IEnumerator SelectCharacter()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new CharacterStore_Controller.<SelectCharacter>d__28();
    }
    private void FadeInImage(UnityEngine.UI.Image image)
    {
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  image, endValue:  1f, duration:  1f);
    }
    private void SetUnlocked(bool unlocked)
    {
        var val_14;
        CharacterData val_15;
        IAPItemIds val_16;
        var val_17;
        val_14 = null;
        val_14 = null;
        gameObject.SetActive(value:  true);
        characterId = this.charNameID;
        gameObject.SetActive(value:  false);
        gameObject.SetActive(value:  false);
        if(this.charData.unlockType != 8)
        {
            goto label_12;
        }
        
        val_15 = this.charData;
        if(this.charData != null)
        {
            goto label_15;
        }
        
        val_15 = this.charData;
        if(val_15 == null)
        {
            goto label_16;
        }
        
        label_15:
        val_16 = this.charData.iapId;
        Setup(aNewItemName:  this.charData.localizedText.name, aNewItem:  val_16, aNewPrice:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.charData.virtualPrice, hiddenValue = this.charData.virtualPrice, fakeValue = X25, inited = X25}, aNewCurrency:  this.charData.virtualCurrency);
        val_17 = gameObject;
        val_17.SetActive(value:  true);
        if(unlocked == true)
        {
            goto label_21;
        }
        
        label_31:
        UnityEngine.GameObject val_7 = gameObject;
        goto label_23;
        label_12:
        gameObject.SetActive(value:  true);
        ShopBuyButton val_9 = GetComponent<ShopBuyButton>();
        val_16 = this.charData.iapId;
        val_9.itemId = val_16;
        val_17 = GetComponent<ShopBuyButton>();
        val_17.ResetButton();
        if(unlocked == false)
        {
            goto label_31;
        }
        
        label_21:
        gameObject.SetActive(value:  false);
        gameObject.SetActive(value:  false);
        label_23:
        this.promoGroup.gameObject.SetActive(value:  false);
        return;
        label_16:
    }
    private void SetImage_GotIt(bool active, bool bounceIn = False)
    {
        var val_27;
        System.Collections.IEnumerator val_3 = this.gameObject.transform.GetEnumerator();
        label_39:
        var val_27 = 0;
        val_27 = val_27 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_8;
        }
        
        var val_28 = 0;
        val_28 = val_28 + 1;
        object val_8 = val_3.Current;
        if(((System.String.op_Equality(a:  0.name, b:  "GOT_IT")) == false) || (this.loaded == false))
        {
            goto label_39;
        }
        
        0.gameObject.SetActive(value:  active);
        0.gameObject.transform.SetAsLastSibling();
        if(bounceIn == false)
        {
            goto label_39;
        }
        
        if(this.GOTITscale == false)
        {
            goto label_25;
        }
        
        if(1 != 0)
        {
            goto label_26;
        }
        
        goto label_32;
        label_25:
        UnityEngine.Vector3 val_18 = 0.gameObject.GetComponent<UnityEngine.RectTransform>().localScale;
        this.GOTITscaleoriginal = val_18;
        mem[1152921526050792760] = val_18.y;
        mem[1152921526050792764] = val_18.z;
        this.GOTITscale = true;
        if(1 == 0)
        {
            goto label_32;
        }
        
        label_26:
        label_32:
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.zero;
        0.gameObject.GetComponent<UnityEngine.RectTransform>().localScale = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
        DG.Tweening.Tweener val_25 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  0.gameObject.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = this.GOTITscaleoriginal, y = val_21.y, z = val_21.z}, duration:  1f), ease:  30);
        goto label_39;
        label_8:
        val_27 = 0;
        if(val_3 != null)
        {
                var val_29 = 0;
            val_29 = val_29 + 1;
            val_3.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public CharacterStore_Controller()
    {
        this.charNameID = 999999;
    }
    private static CharacterStore_Controller()
    {
        CharacterStore_Controller.muteFirstButtonSoundForInit = true;
    }
    private void <LoadResources>b__26_0()
    {
        null = null;
        CharacterNameID val_2 = this.charNameID;
        val_2 = (~(DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  val_2))) & 1;
        this.SetImage_GotIt(active:  val_2, bounceIn:  true);
    }

}
