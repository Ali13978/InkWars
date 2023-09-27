using UnityEngine;
public class SingleStageSelectionMenu : MonoBehaviour
{
    // Fields
    private StageItem m_StageItem;
    private System.Collections.Generic.List<int> m_StageList;
    private int m_StageIndex;
    private UnityEngine.UI.Image m_FlashingImage;
    private DG.Tweening.Sequence m_FlashSequence;
    
    // Properties
    public System.Collections.Generic.List<int> StageList { get; }
    
    // Methods
    public System.Collections.Generic.List<int> get_StageList()
    {
        System.Collections.Generic.List<System.Int32> val_2;
        var val_3;
        val_2 = this.m_StageList;
        if(val_2 != null)
        {
                return val_1;
        }
        
        val_3 = null;
        val_3 = null;
        System.Collections.Generic.List<System.Int32> val_1 = GameInfo.stage.GetAllUniqueIds();
        this.m_StageList = val_1;
        return val_1;
    }
    private void Awake()
    {
        this.m_StageItem.gameObject.SetActive(value:  true);
        this.m_StageItem.SetupStage(stageId:  this.StageList.Item[0]);
    }
    private void OnEnable()
    {
        var val_8;
        var val_9;
        var val_10;
        val_8 = null;
        val_8 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedBackgroundImage;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited})) == 0)
        {
                val_9 = null;
            val_9 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  this.StageList.Item[this.m_StageIndex]);
            DataStructs.UserDataDictionary.Settings.SelectedBackgroundImage = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited};
        }
        
        val_10 = null;
        val_10 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = DataStructs.UserDataDictionary.Settings.SelectedBackgroundImage;
        this.m_StageItem.SetupStage(stageId:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited}));
    }
    public void SelectLeft()
    {
        var val_7;
        do
        {
            int val_7 = this.m_StageIndex;
            val_7 = val_7 - 1;
            this.m_StageIndex = val_7;
            if((val_7 & 2147483648) != 0)
        {
                this.m_StageIndex = this.StageList.Count - 1;
        }
        
            val_7 = null;
            val_7 = null;
        }
        while((DataStructs.UserDataDictionary.Items.IsStageUnlock(id:  this.StageList.Item[this.m_StageIndex])) == false);
        
        this.AnimateFlash();
    }
    public void SelectRight()
    {
        var val_7;
        do
        {
            int val_1 = this.m_StageIndex + 1;
            this.m_StageIndex = val_1;
            if(val_1 >= this.StageList.Count)
        {
                this.m_StageIndex = 0;
        }
        
            val_7 = null;
            val_7 = null;
        }
        while((DataStructs.UserDataDictionary.Items.IsStageUnlock(id:  this.StageList.Item[this.m_StageIndex])) == false);
        
        this.AnimateFlash();
    }
    private void SelectById()
    {
        this.AnimateFlash();
    }
    private void SetStage(int _id)
    {
        this.m_StageItem.SetupStage(stageId:  this.StageList.Item[_id]);
    }
    private void AnimateFlash()
    {
        if(this.m_FlashSequence != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.m_FlashSequence, complete:  false);
        }
        
        this.m_FlashSequence = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.DOTween.Sequence(), isIndependentUpdate:  true);
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        this.m_FlashingImage.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = 0f};
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.m_FlashSequence, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_FlashingImage, endValue:  1f, duration:  0.1f), ease:  3), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void SingleStageSelectionMenu::<AnimateFlash>b__13_0())));
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.m_FlashSequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_FlashingImage, endValue:  0f, duration:  0.1f), ease:  2));
    }
    public void Apply()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  this.StageList.Item[this.m_StageIndex]);
        DataStructs.UserDataDictionary.Settings.SelectedBackgroundImage = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
    }
    public SingleStageSelectionMenu()
    {
    
    }
    private void <AnimateFlash>b__13_0()
    {
        this.SetStage(_id:  this.m_StageIndex);
    }

}
