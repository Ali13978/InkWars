using UnityEngine;
public class BattleEnhancerIndicator : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image m_EnhancerIcon;
    private TMPro.TextMeshProUGUI m_level;
    public PlayerType m_playerType;
    public UnityEngine.Vector3 beginPos;
    public UnityEngine.Vector3 endPos;
    public float duration;
    public DG.Tweening.Ease ease;
    private BattleEnhancerItem lastItem;
    private MotionPanleAnimation m_motionPanel;
    private bool m_update;
    private bool _onlyApplyForNetworkPVP;
    
    // Properties
    public bool onlyApplyForNetworkPVP { get; set; }
    
    // Methods
    public bool get_onlyApplyForNetworkPVP()
    {
        return (bool)this._onlyApplyForNetworkPVP;
    }
    public void set_onlyApplyForNetworkPVP(bool value)
    {
        var val_3;
        GameMode val_4;
        var val_5;
        this._onlyApplyForNetworkPVP = value;
        if(value == false)
        {
            goto label_1;
        }
        
        val_3 = null;
        val_3 = null;
        val_4 = Character_GlobalInfo.gameMode;
        if(val_4 != 6)
        {
            goto label_4;
        }
        
        label_1:
        val_5 = 1;
        goto label_5;
        label_4:
        val_4 = Character_GlobalInfo.gameMode;
        bool val_2 = (val_4 == 10) ? 1 : 0;
        label_5:
        this.m_motionPanel.panel.SetActive(value:  val_2);
        this.m_update = val_2;
    }
    public void ShowUsedEnhancer(InkWars.Model.BattleEnhancerType type, int level, bool showIn)
    {
        this.m_update = false;
        if(type == 0)
        {
            goto label_1;
        }
        
        this.m_EnhancerIcon.sprite = BattleEnhancerCollection.GetIcon(type:  type, isOpponent:  false);
        this.m_level.SetText(text:  "Lv " + level.ToString());
        if(showIn == false)
        {
            goto label_6;
        }
        
        this.Show();
        return;
        label_1:
        this.Hide();
        return;
        label_6:
        this.Hide();
    }
    private void Update()
    {
        int val_8;
        var val_9;
        InkWars.Model.BattleEnhancerType val_10;
        if(this.m_update == false)
        {
                return;
        }
        
        if(this.m_playerType != 0)
        {
                NetworkUserInfo val_1 = CloudOpponent.current;
            val_8 = val_1.enhancerID;
        }
        else
        {
                val_9 = null;
            val_9 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Settings.SelectedBattleEnhancer;
            val_8 = val_2.currentCryptoKey;
        }
        
        BattleEnhancerItem val_4 = BattleEnhancerItem.FromInt(number:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_8, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited}));
        val_10 = val_4.enhancerType;
        if(val_10 != 0)
        {
                if(val_10 == this.lastItem.enhancerType)
        {
                val_10 = val_4.level;
            if(val_10 == this.lastItem.level)
        {
                return;
        }
        
        }
        
            this.lastItem = val_4;
            this.m_EnhancerIcon.sprite = BattleEnhancerCollection.GetIcon(type:  val_4.enhancerType, isOpponent:  false);
            val_10 = "Lv " + val_4.level.ToString();
            this.m_level.SetText(text:  val_10);
            this.Show();
            return;
        }
        
        this.lastItem = val_4;
        this.Hide();
    }
    private void ShowIn(bool showIn)
    {
        if(showIn != false)
        {
                this.Show();
            return;
        }
        
        this.Hide();
    }
    private void Show()
    {
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.m_motionPanel.endPos, y = V8.16B, z = V9.16B});
        DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.m_motionPanel.panel.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, duration:  this.m_motionPanel.duration, snapping:  false), ease:  this.m_motionPanel.ease), isIndependentUpdate:  true);
    }
    private void Hide()
    {
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.m_motionPanel.beginPos, y = V8.16B, z = V9.16B});
        DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.m_motionPanel.panel.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, duration:  this.m_motionPanel.duration, snapping:  false), ease:  this.m_motionPanel.ease), isIndependentUpdate:  true);
    }
    public BattleEnhancerIndicator()
    {
        this.duration = 0.5f;
        this.lastItem = new BattleEnhancerItem();
        this.m_update = true;
    }

}
