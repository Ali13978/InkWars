using UnityEngine;
public class VersusStageSelect : MonoBehaviour
{
    // Fields
    public static VersusStageSelect instance;
    private StageSelectionController selectStageController;
    private UnityEngine.UI.Button confirmMapButton;
    private UnityEngine.GameObject shellPanel;
    public UnityEngine.GameObject template_GameSceneActivator;
    private MVC_GameScene_Activator GameSceneActivator;
    
    // Methods
    private void Awake()
    {
        if(0 == this.confirmMapButton)
        {
                return;
        }
        
        if(0 == this.selectStageController)
        {
                return;
        }
        
        this.selectStageController.events.OnSelectionOwnedChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void VersusStageSelect::<Awake>b__6_0(bool isOwnedStage)));
        this.confirmMapButton.interactable = this.selectStageController.isSelectionOwned;
    }
    private void Start()
    {
        var val_7;
        if((UnityEngine.Object.op_Implicit(exists:  VersusStageSelect.instance)) != false)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        else
        {
                VersusStageSelect.instance = this;
        }
        
        this.GameSceneActivator = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.template_GameSceneActivator).GetComponent<MVC_GameScene_Activator>();
        val_7 = null;
        val_7 = null;
        this.shellPanel.gameObject.SetActive(value:  (Character_GlobalInfo.isOfflineMode == false) ? 1 : 0);
    }
    private void OnEnable()
    {
        null = null;
        GGPPurchasingManager.OnPurchaseSuccess.AddListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void VersusStageSelect::OnPurchaseSuccess(IAPItemIds iapId)));
    }
    private void OnDisable()
    {
        null = null;
        GGPPurchasingManager.OnPurchaseSuccess.RemoveListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void VersusStageSelect::OnPurchaseSuccess(IAPItemIds iapId)));
    }
    private void OnPurchaseSuccess(IAPItemIds iapId)
    {
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = X22, hiddenValue = X22, fakeValue = this.selectStageController.selectedStageData, inited = this.selectStageController.selectedStageData})) != iapId)
        {
                return;
        }
        
        this.confirmMapButton.interactable = true;
    }
    public void ConfirmStageSelect()
    {
        StageData val_1 = this.selectStageController.selectedStageData;
        Character_GlobalInfo.stage_CurrentLevel = val_1.levelId + 1;
        GameAudio.PlayButtonSound();
        this.GameSceneActivator.TriggerLoading(ShowBattleGates:  true, onCloseDone:  0, onOpenDone:  0);
    }
    public VersusStageSelect()
    {
    
    }
    private void <Awake>b__6_0(bool isOwnedStage)
    {
        isOwnedStage = isOwnedStage;
        this.confirmMapButton.interactable = isOwnedStage;
    }

}
