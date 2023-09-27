using UnityEngine;
public class ExpressPowerBallPurchaseCanvas : DynamicUISingleton<ExpressPowerBallPurchaseCanvas>
{
    // Fields
    private InkWars.ExpressStore.Unlockable stunnerSetting;
    private InkWars.ExpressStore.Unlockable cannonSetting;
    private InkWars.ExpressStore.Unlockable eraserSetting;
    private SoftCurrencyBuyButton buyStunnerButton;
    private SoftCurrencyBuyButton buyCannonButton;
    private SoftCurrencyBuyButton buyEraserButton;
    private MoveAfterSeconds panel;
    
    // Methods
    private void Start()
    {
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  this.stunnerSetting.price);
        this.buyStunnerButton.Setup(aNewItemName:  "", aNewPrice:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited}, aNewCurrency:  this.stunnerSetting.currency, purchaseDoneCallback:  new System.Action(object:  this, method:  System.Void ExpressPowerBallPurchaseCanvas::<Start>b__7_0()), customTitle:  0, customMessage:  0);
        this.buyStunnerButton.confirmPurchase = false;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  this.cannonSetting.price);
        this.buyCannonButton.Setup(aNewItemName:  "", aNewPrice:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited}, aNewCurrency:  this.cannonSetting.currency, purchaseDoneCallback:  new System.Action(object:  this, method:  System.Void ExpressPowerBallPurchaseCanvas::<Start>b__7_1()), customTitle:  0, customMessage:  0);
        this.buyCannonButton.confirmPurchase = false;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  this.eraserSetting.price);
        this.buyEraserButton.Setup(aNewItemName:  "", aNewPrice:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited}, aNewCurrency:  this.eraserSetting.currency, purchaseDoneCallback:  new System.Action(object:  this, method:  System.Void ExpressPowerBallPurchaseCanvas::<Start>b__7_2()), customTitle:  0, customMessage:  0);
        this.buyEraserButton.confirmPurchase = false;
    }
    private void PlayButtonScaleAnim(UnityEngine.Transform buttonTransform)
    {
        if(0 == buttonTransform)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.5f);
        buttonTransform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.05f);
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOPunchScale(target:  buttonTransform, punch:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.3f, vibrato:  0, elasticity:  0f), ease:  18);
    }
    protected override void PlayShowAnim()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.panel.MoveToTargetPosition(onDone:  0);
    }
    protected override void PlayHideAnim()
    {
        this.panel.MoveToOriginalPosition(onDone:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void ExpressPowerBallPurchaseCanvas::<PlayHideAnim>b__10_0()));
    }
    public ExpressPowerBallPurchaseCanvas()
    {
        this.stunnerSetting = new InkWars.ExpressStore.Unlockable();
        this.cannonSetting = new InkWars.ExpressStore.Unlockable();
        this.eraserSetting = new InkWars.ExpressStore.Unlockable();
    }
    private void <Start>b__7_0()
    {
        this.stunnerSetting.AssignRewards();
        UnityEngine.Transform val_1 = this.buyStunnerButton.transform;
        val_1.PlayButtonScaleAnim(buttonTransform:  val_1);
    }
    private void <Start>b__7_1()
    {
        this.cannonSetting.AssignRewards();
        UnityEngine.Transform val_1 = this.buyCannonButton.transform;
        val_1.PlayButtonScaleAnim(buttonTransform:  val_1);
    }
    private void <Start>b__7_2()
    {
        this.eraserSetting.AssignRewards();
        UnityEngine.Transform val_1 = this.buyEraserButton.transform;
        val_1.PlayButtonScaleAnim(buttonTransform:  val_1);
    }
    private void <PlayHideAnim>b__10_0()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
