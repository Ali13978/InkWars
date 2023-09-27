using UnityEngine;
public class BPTimerIndicator : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image m_icon;
    private UnityEngine.UI.Image m_amplifierPlus;
    private UnityEngine.UI.Image m_amplifierShield;
    private TMPro.TextMeshProUGUI m_timeText;
    private TMPro.TextMeshProUGUI m_precentageText;
    private MotionPanleAnimation m_motionPanel;
    private UnityEngine.UI.Button m_BPAmplifierButton;
    private UnityEngine.CanvasGroup m_BPTimerObj;
    public bool m_updateLock;
    
    // Methods
    private string getRemainingTime()
    {
        ulong val_21;
        var val_22;
        var val_23;
        var val_24;
        System.DateTime val_1 = System.DateTime.Now;
        val_21 = val_1.dateData;
        val_22 = null;
        val_22 = null;
        System.DateTime val_2 = DataStructs.UserDataDictionary.GameSave.BPAmplifierExpireDate;
        System.DateTime val_3 = System.DateTime.FromBinary(dateData:  1152921528640050232);
        System.TimeSpan val_4 = val_3.dateData.Subtract(value:  new System.DateTime() {dateData = val_21});
        val_23 = 0;
        if(val_4._ticks.TotalSeconds <= 0f)
        {
                return (string)+val_7;
        }
        
        string[] val_7 = new string[5];
        val_21 = val_7;
        int val_8 = val_4._ticks.Hours;
        if(val_4._ticks.Days >= 1)
        {
                int val_21 = 24;
            val_21 = val_8 + (val_4._ticks.Days * val_21);
            val_21[0] = val_21.ToString();
            val_24 = ":";
            val_21[1] = ":";
            val_21[2] = val_4._ticks.Minutes.ToString();
            val_21[3] = ":";
            string val_14 = val_4._ticks.Seconds.ToString();
        }
        else
        {
                val_21[0] = val_8.ToString();
            val_24 = ":";
            val_21[1] = ":";
            val_21[2] = val_4._ticks.Minutes.ToString(format:  "00");
            val_21[3] = ":";
        }
        
        val_21[4] = val_4._ticks.Seconds.ToString(format:  "00");
        return (string)+val_7;
    }
    public void GoBack()
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.m_motionPanel.beginPos, y = V8.16B, z = V9.16B});
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.m_motionPanel.panel.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, duration:  this.m_motionPanel.duration, snapping:  false), ease:  this.m_motionPanel.ease));
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void BPTimerIndicator::<GoBack>b__10_0()));
    }
    public void GoFront(string time)
    {
        BPTimerIndicator.<>c__DisplayClass11_0 val_1 = new BPTimerIndicator.<>c__DisplayClass11_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .time = time;
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void BPTimerIndicator.<>c__DisplayClass11_0::<GoFront>b__0()));
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.m_motionPanel.endPos, y = V8.16B, z = V9.16B});
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.m_motionPanel.panel.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, duration:  this.m_motionPanel.duration, snapping:  false), ease:  this.m_motionPanel.ease));
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_2, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void BPTimerIndicator.<>c__DisplayClass11_0::<GoFront>b__1()));
    }
    private void Update()
    {
        var val_15;
        if(this.m_updateLock != false)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedBPAmplifier;
        BPAmplifierItem val_3 = BPAmplifierItem.FromInt(number:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited}));
        if(val_3.amplifierType == 0)
        {
            goto label_8;
        }
        
        if(val_3.amplifierType != 1)
        {
            goto label_9;
        }
        
        if(this.m_amplifierPlus != null)
        {
            goto label_23;
        }
        
        label_24:
        label_23:
        this.m_icon.sprite = 0.sprite;
        this.m_precentageText.text = val_3.precentage.ToString();
        string val_6 = this.m_precentageText.getRemainingTime();
        if(val_6 == null)
        {
            goto label_13;
        }
        
        this.GoFront(time:  val_6);
        return;
        label_8:
        DG.Tweening.Sequence val_7 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.m_motionPanel.beginPos, y = V8.16B, z = V9.16B});
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.m_motionPanel.panel.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, duration:  this.m_motionPanel.duration, snapping:  false), ease:  this.m_motionPanel.ease));
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_7, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void BPTimerIndicator::<Update>b__12_0()));
        return;
        label_9:
        if(this.m_amplifierShield != null)
        {
            goto label_23;
        }
        
        goto label_24;
        label_13:
        this.GoBack();
    }
    public BPTimerIndicator()
    {
    
    }
    private void <GoBack>b__10_0()
    {
        var val_9;
        int val_10;
        this.m_BPAmplifierButton.gameObject.SetActive(value:  true);
        this.m_BPTimerObj.alpha = 0f;
        UnityEngine.AudioSource val_4 = GameAudio.sound.PlayOneShot(clip:  BattleEnhancerCollection.GetSFX(state:  2), volume:  1f);
        val_9 = null;
        val_9 = null;
        BPAmplifierItem val_5 = null;
        val_10 = val_5;
        val_5 = new BPAmplifierItem();
        if(val_10 != null)
        {
                InkWars.Model.BPAmplifierType val_8 = (BPAmplifierItem)[1152921528641174544].amplifierType;
            val_8 = (BPAmplifierItem)[1152921528641174544].precentage | (val_8 << 7);
            val_10 = val_8 << 20;
        }
        
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_10);
        DataStructs.UserDataDictionary.Settings.SelectedBPAmplifier = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited};
        System.DateTime val_7 = System.DateTime.Now;
        DataStructs.UserDataDictionary.GameSave.BPAmplifierExpireDate = new System.DateTime() {dateData = val_7.dateData};
    }
    private void <Update>b__12_0()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.m_BPAmplifierButton)) != false)
        {
                this.m_BPAmplifierButton.gameObject.SetActive(value:  true);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.m_BPTimerObj)) == false)
        {
                return;
        }
        
        this.m_BPTimerObj.alpha = 0f;
    }

}
