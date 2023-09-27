using UnityEngine;
public class RewardTracker : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<DayReward> rewardsPerDay;
    private DayReward selectedDailyReward;
    private bool m_IsSelectedDailyRewardUnlockable;
    public UnityEngine.RectTransform PanelReward;
    public UnityEngine.CanvasGroup PanelRewardCG;
    public UnityEngine.UI.Image ImageRewardIcon;
    public UnityEngine.UI.Image ImageRewardIconMini;
    public UnityEngine.UI.Image ImageRewardText;
    public UnityEngine.UI.Image ImageBG;
    public UnityEngine.RectTransform RewardPanelWoodenBG;
    public UnityEngine.RectTransform NextDay;
    public UnityEngine.UI.Text NextDayText;
    public UnityEngine.RectTransform PreviousDay;
    public UnityEngine.UI.Text PreviousDayText;
    public UnityEngine.UI.Text CurrentDayText;
    private int rewardDay;
    public UnityEngine.RectTransform ImageWhiteRays;
    public UnityEngine.RectTransform ImageYouWon;
    public UnityEngine.RectTransform ImageCongratulations;
    public UnityEngine.UI.Button ButtonGetReward;
    public UnityEngine.AudioClip openPanelSound;
    public UnityEngine.AudioClip rewardSound;
    private DG.Tweening.Sequence m_Sequence;
    
    // Methods
    private void Start()
    {
        var val_6;
        this.PanelReward.gameObject.SetActive(value:  true);
        this.PanelRewardCG.alpha = 0f;
        this.PanelRewardCG.blocksRaycasts = false;
        DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this.ImageWhiteRays.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  15f, mode:  3), loops:  0, loopType:  0), ease:  1);
        val_6 = null;
        val_6 = null;
        if(mainTitle.ShowModeSelectImmediately == true)
        {
                return;
        }
        
        this.CheckForReward();
    }
    public void CheckForReward()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = TimeTracker.rewardReady, hiddenValue = TimeTracker.rewardReady, fakeValue = TimeTracker.rewardPanelOpenDate.__il2cppRuntimeField_1C, fakeValueChanged = TimeTracker.rewardPanelOpenDate.__il2cppRuntimeField_1C, inited = TimeTracker.rewardPanelOpenDate.__il2cppRuntimeField_1C})) == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.GameSave.DailyRewardCounter;
        int val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited});
        this.rewardDay = val_3;
        if((val_3 & 2147483648) == 0)
        {
                this.ShowRewardPanel();
            return;
        }
        
        UnityEngine.Debug.Log(message:  "ERROR: Reward Day #0 - No reward for this day");
    }
    private void ResetVariables()
    {
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.ImageRewardText.rectTransform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        this.ImageRewardIcon.rectTransform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        this.ImageRewardIcon.sprite = this.selectedDailyReward.icon;
        this.ImageRewardIconMini.sprite = this.selectedDailyReward.iconMini;
        NetworkUtils.SetImageSpriteWithSpriteSize(_i:  this.ImageRewardText, _s:  this.selectedDailyReward.text);
        this.ImageRewardText.sprite = this.selectedDailyReward.text;
        if(this.m_Sequence != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.m_Sequence, complete:  false);
        }
        
        this.m_Sequence = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.DOTween.Sequence(), isIndependentUpdate:  true);
    }
    public void ShowRewardPanel()
    {
        var val_27;
        this.selectedDailyReward = this.rewardsPerDay.Item[this.rewardDay];
        this.ResetVariables();
        this.CheckIfRewardIsUnlockable();
        this.DetermineClickableDays();
        val_27 = null;
        val_27 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.GameSave.DailyRewardCounter;
        if(this.rewardDay == (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited})))
        {
                UnityEngine.AudioSource val_5 = GameAudio.sound.PlayOneShot(clip:  this.openPanelSound, volume:  1f);
        }
        
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.m_Sequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.ImageRewardIcon.rectTransform, endValue:  0.5f, duration:  0.65f), ease:  27));
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.m_Sequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.ImageRewardText.rectTransform, endValue:  0.5f, duration:  0.65f), ease:  27));
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.m_Sequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.CurrentDayText.rectTransform, endValue:  1.25f, duration:  0.5f), ease:  12));
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  1.25f);
        DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.m_Sequence, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.CurrentDayText.rectTransform, endValue:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, duration:  0.1f));
        DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.m_Sequence, atPosition:  0f, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.PanelRewardCG, endValue:  1f, duration:  0.5f));
        DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.m_Sequence, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void RewardTracker::<ShowRewardPanel>b__26_0()));
    }
    public void HideRewardPanel()
    {
        UnityEngine.Debug.Log(message:  "Hiding reward panel");
        this.selectedDailyReward = 0;
        this.PanelRewardCG.blocksRaycasts = false;
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.DOTween.Sequence(), isIndependentUpdate:  true);
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.ImageBG, endValue:  0f, duration:  0.5f), ease:  1));
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.ImageBG.rectTransform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.25f));
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_2, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void RewardTracker::<HideRewardPanel>b__27_0()));
    }
    public void CollectReward()
    {
        if(this.selectedDailyReward == null)
        {
            goto label_1;
        }
        
        if((this.rewardDay > this.rewardsPerDay.Count) || ((this.rewardDay & 2147483648) != 0))
        {
            goto label_4;
        }
        
        UnityEngine.Debug.Log(message:  "Collecting reward: "("Collecting reward: ") + this.selectedDailyReward.unlockable.ToString() + " x" + this.selectedDailyReward.unlockable.quantity.ToString());
        this.selectedDailyReward.unlockable.AssignRewards();
        TimeTracker.SetRewardedDate();
        UnityEngine.AudioSource val_6 = GameAudio.sound.PlayOneShot(clip:  this.rewardSound, volume:  1f);
        goto label_18;
        label_1:
        UnityEngine.Debug.Log(message:  "Can\'t collect reward: selectedDailyReward is null");
        label_18:
        this.HideRewardPanel();
        return;
        label_4:
        UnityEngine.Debug.Log(message:  "ERROR - Can receive reward but counter is not correct: "("ERROR - Can receive reward but counter is not correct: ") + this.rewardDay);
        this.HideRewardPanel();
    }
    private void CheckIfRewardIsUnlockable()
    {
        var val_24;
        int val_25;
        UnityEngine.UI.Button val_26;
        var val_27;
        val_24 = null;
        val_24 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.GameSave.DailyRewardCounter;
        val_25 = val_1.fakeValue;
        if(this.rewardDay == (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_25, inited = val_1.inited})))
        {
                this.m_IsSelectedDailyRewardUnlockable = true;
            this.ImageYouWon.gameObject.SetActive(value:  true);
            this.ImageCongratulations.gameObject.SetActive(value:  true);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.m_Sequence, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.ImageYouWon, endValue:  0.5f, duration:  0.5f));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.m_Sequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.ImageCongratulations, endValue:  250f, duration:  0.5f, snapping:  false), ease:  27));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.m_Sequence, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.ImageWhiteRays.transform, endValue:  0.5f, duration:  0.5f));
            val_25 = this.ImageWhiteRays.transform;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  0.3f);
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.m_Sequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_25, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  1f), loops:  0, loopType:  1), ease:  1));
            this.ImageWhiteRays.gameObject.SetActive(value:  true);
            val_26 = this.ButtonGetReward;
            val_27 = 1;
        }
        else
        {
                this.m_IsSelectedDailyRewardUnlockable = false;
            this.ImageYouWon.gameObject.SetActive(value:  false);
            this.ImageCongratulations.gameObject.SetActive(value:  false);
            this.ImageWhiteRays.gameObject.SetActive(value:  false);
            val_26 = this.ButtonGetReward;
            val_27 = 0;
        }
        
        val_26.interactable = false;
    }
    private void DetermineClickableDays()
    {
        float val_22;
        float val_23;
        UnityEngine.RectTransform val_24;
        string val_2 = System.String.Format(format:  "Day {0}", arg0:  this.rewardDay.ToString());
        int val_22 = this.rewardDay;
        val_22 = val_22 + 1;
        string val_4 = System.String.Format(format:  "Day {0}", arg0:  val_22.ToString());
        object[] val_5 = new object[1];
        int val_23 = this.rewardDay;
        val_23 = val_23 + 2;
        val_5[0] = val_23.ToString();
        string val_7 = LanguageManager.GetTextFormat(key:  "LK.DailyRewardsDays", list:  val_5);
        if(this.rewardDay != 0)
        {
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  1.25f);
            val_22 = 0f;
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.m_Sequence, atPosition:  val_22, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.PreviousDay, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.5f), ease:  12));
        }
        else
        {
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
            val_23 = val_13.x;
            val_22 = val_23;
            this.PreviousDay.localScale = new UnityEngine.Vector3() {x = val_22, y = val_13.y, z = val_13.z};
        }
        
        if(this.rewardDay == (this.rewardsPerDay.Count - 1))
        {
                val_24 = this.NextDay;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
            val_23 = val_16.x;
            val_24.localScale = new UnityEngine.Vector3() {x = val_23, y = val_16.y, z = val_16.z};
            return;
        }
        
        val_24 = this.NextDay;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  1.25f);
        DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.m_Sequence, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_24, endValue:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, duration:  0.5f), ease:  12));
    }
    public void ClickNextDay()
    {
        int val_1 = this.rewardDay + 1;
        this.rewardDay = val_1;
        this.selectedDailyReward = this.rewardsPerDay.Item[val_1];
        this.ShowRewardPanel();
        GameAudio.PlayButtonSound();
    }
    public void ClickPreviousDay()
    {
        int val_1 = this.rewardDay - 1;
        this.rewardDay = val_1;
        this.selectedDailyReward = this.rewardsPerDay.Item[val_1];
        this.ShowRewardPanel();
        GameAudio.PlayButtonSound();
    }
    public RewardTracker()
    {
        this.rewardsPerDay = new System.Collections.Generic.List<DayReward>();
    }
    private void <ShowRewardPanel>b__26_0()
    {
        this.PanelRewardCG.blocksRaycasts = true;
    }
    private void <HideRewardPanel>b__27_0()
    {
        this.PanelRewardCG.alpha = 0f;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.one;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        this.ImageBG.rectTransform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.one;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        this.PanelReward.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
