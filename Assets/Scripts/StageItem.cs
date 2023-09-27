using UnityEngine;
public class StageItem : MonoBehaviour
{
    // Fields
    public TMPro.TextMeshProUGUI stageNameText;
    public LanguageTextResponser stageNameTextResponser;
    public UnityEngine.UI.Image stageImage;
    public UnityEngine.GameObject stageLockObject;
    public UnityEngine.GameObject stageUnlockObject;
    public ShopBuyButton buyButton;
    public PearlBuyButton pearlBuyButton;
    private int currentStageId;
    private UnityEngine.RectTransform _rectTrasform;
    private UnityEngine.CanvasGroup _canvasGroup;
    
    // Properties
    public UnityEngine.RectTransform rectTrasform { get; }
    public UnityEngine.UI.Image image { get; }
    public UnityEngine.CanvasGroup canvasGroup { get; }
    
    // Methods
    public UnityEngine.RectTransform get_rectTrasform()
    {
        UnityEngine.RectTransform val_3;
        if(0 == this._rectTrasform)
        {
                this._rectTrasform = this.GetComponent<UnityEngine.RectTransform>();
            return val_3;
        }
        
        val_3 = this._rectTrasform;
        return val_3;
    }
    public UnityEngine.UI.Image get_image()
    {
        return (UnityEngine.UI.Image)this.stageImage;
    }
    public UnityEngine.CanvasGroup get_canvasGroup()
    {
        UnityEngine.CanvasGroup val_3;
        if(0 == this._canvasGroup)
        {
                this._canvasGroup = this.GetComponent<UnityEngine.CanvasGroup>();
            return val_3;
        }
        
        val_3 = this._canvasGroup;
        return val_3;
    }
    public void SetAlpha(float alpha)
    {
        this.canvasGroup.alpha = alpha;
    }
    public void SetupStage(int stageId)
    {
        var val_20;
        string val_21;
        var val_22;
        var val_23;
        if(this.currentStageId == stageId)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        StageData val_1 = GameInfo.stage.GetItemDataById(uniqueId:  stageId);
        if(val_1 == null)
        {
                return;
        }
        
        this.currentStageId = stageId;
        if(0 != this.stageNameTextResponser)
        {
                val_21 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  X22);
            this.stageNameTextResponser.textKey = val_21;
        }
        
        if(0 != this.stageImage)
        {
                val_21 = val_1.LoadStageSprite();
            this.stageImage.sprite = val_21;
        }
        
        val_22 = null;
        val_22 = null;
        bool val_7 = DataStructs.UserDataDictionary.Items.IsStageUnlock(id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = X23, hiddenValue = X23, fakeValue = val_21, inited = val_21}));
        if(0 != this.stageLockObject)
        {
                bool val_9 = val_7 ^ 1;
            this.stageLockObject.SetActive(value:  val_9);
        }
        
        if(0 != this.stageUnlockObject)
        {
                this.stageUnlockObject.SetActive(value:  val_7);
        }
        
        int val_13 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7, hiddenValue = val_7, fakeValue = this.stageUnlockObject, inited = this.stageUnlockObject});
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.__il2cppRuntimeField_cctor_finished, hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.__il2cppRuntimeField_cctor_finished, fakeValue = this.stageUnlockObject, inited = this.stageUnlockObject})) == 0)
        {
            goto label_31;
        }
        
        this.pearlBuyButton.Setup(aNewItemName:  LanguageManager.GetText(key:  "Lk.Shop.Bg." + CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_9)(CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_9))), aNewItem:  val_13, aNewPrice:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_9, hiddenValue = val_9, fakeValue = 1152921504858337280, inited = false}, aNewCurrency:  val_1);
        if(this.pearlBuyButton != null)
        {
            goto label_40;
        }
        
        label_41:
        label_40:
        val_23 = null;
        val_23 = null;
        this.pearlBuyButton.gameObject.SetActive(value:  (Character_GlobalInfo.isOfflineMode == false) ? 1 : 0);
        return;
        label_31:
        this.buyButton.itemId = val_13;
        if(this.buyButton != null)
        {
            goto label_40;
        }
        
        goto label_41;
    }
    private System.Collections.IEnumerator LoadTextureAsync(string resourcePath)
    {
        StageItem.<LoadTextureAsync>d__18 val_1 = new StageItem.<LoadTextureAsync>d__18();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .resourcePath = resourcePath;
        return (System.Collections.IEnumerator)val_1;
    }
    public StageItem()
    {
        this.currentStageId = 0;
    }

}
