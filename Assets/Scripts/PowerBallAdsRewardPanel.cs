using UnityEngine;
public class PowerBallAdsRewardPanel : DynamicUISingleton<PowerBallAdsRewardPanel>
{
    // Fields
    private InkWars.ExpressStore.Unlockable rewardSetting;
    private UnityEngine.RectTransform watchAdsPanel;
    private UnityEngine.RectTransform adsRewardPanel;
    private UnityEngine.UI.Text rewardCountTxt;
    private UnityEngine.UI.Text ballNameTxt;
    private UnityEngine.UI.Image ballImage;
    private DG.Tweening.Tweener ballPunchScaleTW;
    
    // Methods
    public static void ShowWithCustomRewards(eInkUnlockable item, int count)
    {
        UnityEngine.Object val_5 = DynamicUISingleton<PowerBallAdsRewardPanel>.instance;
        if(val_5 != null)
        {
                val_5 = 0;
        }
        
        if(0 != val_5)
        {
                this.SetRewards(item:  item, count:  count);
        }
        
        DynamicUISingleton<PowerBallAdsRewardPanel>.Show();
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        this.adsRewardPanel.gameObject.SetActive(value:  false);
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        if(this.ballPunchScaleTW == null)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.ballPunchScaleTW, complete:  false);
    }
    public void SetRewards(eInkUnlockable item, int count)
    {
        this.rewardSetting.unlockable = item;
        this.rewardSetting.quantity = count;
    }
    private void InitRewardPanel()
    {
        string val_2 = "<size=120%>x </size>"("<size=120%>x </size>") + this.rewardSetting.quantity.ToString();
        string val_3 = AdventureLevelDataCollection.GetRewardItemName(type:  this.rewardSetting.unlockable);
        this.ballImage.sprite = AdventureLevelDataCollection.GetRewardItemSprite(type:  this.rewardSetting.unlockable);
        if(this.ballPunchScaleTW != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.ballPunchScaleTW, complete:  false);
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.15f);
        this.ballPunchScaleTW = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOPunchScale(target:  this.ballImage.GetComponent<UnityEngine.RectTransform>(), punch:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.5f, vibrato:  1, elasticity:  1f), loops:  0, loopType:  1);
    }
    public PowerBallAdsRewardPanel()
    {
        this.rewardSetting = new InkWars.ExpressStore.Unlockable();
    }

}
