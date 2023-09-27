using UnityEngine;
public class UnlockableRewardPanel : DynamicUISingleton<UnlockableRewardPanel>
{
    // Fields
    private UnityEngine.Sprite characterBG;
    private UnityEngine.Sprite shellBG;
    private UnityEngine.Sprite pearlBG;
    private UnityEngine.UI.Image BGImage;
    private UnityEngine.UI.Image itemImage;
    private UnityEngine.UI.Image charPoseImage;
    private UnityEngine.UI.Text itemNameTxt;
    private UnityEngine.UI.Text unlockTitleTxt;
    private UnityEngine.AudioClip sfx;
    private System.Action onCloseCallback;
    
    // Methods
    public static void ShowWithCustomRewards(RewardData reward, System.Action onClose)
    {
        UnityEngine.Object val_5 = DynamicUISingleton<UnlockableRewardPanel>.instance;
        if(val_5 != null)
        {
                val_5 = 0;
        }
        
        if(0 != val_5)
        {
                if(val_5 != 0)
        {
                this.SetRewards(reward:  reward);
        }
        else
        {
                this.SetRewards(reward:  reward);
        }
        
            mem[112] = onClose;
        }
        
        DynamicUISingleton<UnlockableRewardPanel>.Show();
    }
    protected override void PlayHideAnim()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), ease:  26), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void UnlockableRewardPanel::<PlayHideAnim>b__11_0()));
    }
    private void SetRewards(RewardData reward)
    {
        var val_16;
        eInkUnlockable val_17;
        var val_18;
        UnityEngine.Sprite val_19;
        UnityEngine.UI.Text val_20;
        string val_21;
        string val_22;
        if(reward != null)
        {
                val_16 = reward;
            val_17 = reward.item;
            val_18 = val_17;
        }
        else
        {
                val_16 = 24;
            val_18 = 10260432;
            val_17 = 10260432;
        }
        
        if(val_17 == 3)
        {
                val_19 = this.characterBG;
        }
        else
        {
                if(val_16 == 1)
        {
                val_19 = this.shellBG;
        }
        else
        {
                val_19 = this.pearlBG;
        }
        
        }
        
        this.BGImage.sprite = mem[this.pearlBG];
        this.charPoseImage.gameObject.SetActive(value:  (val_18 == 3) ? 1 : 0);
        this.itemImage.gameObject.SetActive(value:  (val_18 != 3) ? 1 : 0);
        if(val_18 == 3)
        {
                UnityEngine.Color val_5 = UnityEngine.Color.clear;
            this.charPoseImage.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
            CharacterAssetLoader.Get(id:  reward.character, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  this, method:  System.Void UnlockableRewardPanel::<SetRewards>b__12_0(CharacterAssetLoader loader)));
            string val_7 = CharacterHelper.GetLocalizedClanAndName(cid:  reward.character);
            val_20 = this.unlockTitleTxt;
            val_21 = "LK.UnlockMsg.HaveUnlocked";
        }
        else
        {
                this.itemImage.sprite = AdventureLevelDataCollection.GetRewardItemSprite(type:  10260432);
            if(reward != null)
        {
                val_22 = reward.quantity.ToString();
        }
        else
        {
                val_22 = 28.ToString();
        }
        
            string val_12 = val_22 + " " + AdventureLevelDataCollection.GetRewardItemName(type:  10260432)(AdventureLevelDataCollection.GetRewardItemName(type:  10260432));
            val_20 = this.unlockTitleTxt;
            val_21 = "LK.UnlockMsg.HaveEarned";
        }
        
        string val_13 = LanguageManager.GetText(key:  val_21);
        UnityEngine.AudioSource val_15 = GameAudio.sound.PlayOneShot(clip:  this.sfx, volume:  1f);
    }
    public UnlockableRewardPanel()
    {
    
    }
    private void <PlayHideAnim>b__11_0()
    {
        if(this.onCloseCallback != null)
        {
                this.onCloseCallback.Invoke();
        }
        
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void <SetRewards>b__12_0(CharacterAssetLoader loader)
    {
        this.charPoseImage.sprite = loader.LoadPose_Dynamic();
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.charPoseImage.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
    }

}
