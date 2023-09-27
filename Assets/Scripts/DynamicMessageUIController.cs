using UnityEngine;
[Serializable]
public class DynamicMessageUIController : MonoBehaviour
{
    // Fields
    private PlayerMessage m_Player;
    private bool m_LeftPlayer;
    private DynamicMessageUIConstants _constants;
    private int ClipIndex;
    private DynamicMessageUIController.DynamicMessageData m_PlayerData;
    private System.Collections.IEnumerator HideMainCoroutine;
    private System.Collections.IEnumerator HideTechniqueCoroutine;
    
    // Properties
    private DynamicMessageUIConstants m_Constants { get; }
    
    // Methods
    private DynamicMessageUIConstants get_m_Constants()
    {
        DynamicMessageUIConstants val_3;
        if(0 == this._constants)
        {
                this._constants = UnityEngine.Resources.Load<DynamicMessageUIConstants>(path:  "DynamicUI/DynamicMessageUISettings");
            return val_3;
        }
        
        val_3 = this._constants;
        return val_3;
    }
    private void Awake()
    {
        null = null;
        if(Character_GlobalInfo.gameMode == 3)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        
        DynamicMessageUIConstants val_2 = this.m_Constants;
        this.m_PlayerData.Initialize();
        this.InitializeMessageData(_data:  this.m_PlayerData);
        this.InitializeTechniqueData(_data:  this.m_PlayerData);
    }
    private void OnEnable()
    {
        InkWars.Model.Model_Events.Instance.add_OnComboPop(value:  new Model_Events.OnPlayerMessageDelegate(object:  this, method:  public System.Void DynamicMessageUIController::OnComboPop(PlayerMessage message)));
        InkWars.Model.Model_Events.Instance.add_OnStunBreak(value:  new Model_Events.OnStunBreakDelegate(object:  this, method:  public System.Void DynamicMessageUIController::OnStunBreak(InkWars.Model.Player playerId, float revengeSuperLevel, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)));
        InkWars.Model.Model_Events.Instance.add_OnStunned(value:  new Model_Events.OnStunnedDelegate(object:  this, method:  System.Void DynamicMessageUIController::OnStunned(InkWars.Model.Player playerId, float stunLevel, bool isRevengeStun)));
        InkWars.Model.Model_Events.Instance.add_OnRevengeSuper(value:  new Model_Events.OnRevengeSuperDelegate(object:  this, method:  System.Void DynamicMessageUIController::OnRevengeSuper(InkWars.Model.Player id, InkWars.Model.BubbleTypes revengeSuperType, InkWars.Model.RevengeSuperEventState state)));
        InkWars.Model.Model_Events.Instance.add_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void DynamicMessageUIController::OnGameResult(InkWars.Model.GameResult result, bool isFinished)));
        InkWars.Model.Model_Events.Instance.add_OnBattleEnhancer(value:  new Model_Events.OnBattleEnhancerDelegate(object:  this, method:  System.Void DynamicMessageUIController::OnBattleEnhancer(float timeStamp, InkWars.Model.Player playerId, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)));
    }
    private void OnDisable()
    {
        if(InkWars.Model.Model_Events.Instance == 0)
        {
                return;
        }
        
        InkWars.Model.Model_Events.Instance.remove_OnComboPop(value:  new Model_Events.OnPlayerMessageDelegate(object:  this, method:  public System.Void DynamicMessageUIController::OnComboPop(PlayerMessage message)));
        InkWars.Model.Model_Events.Instance.remove_OnStunBreak(value:  new Model_Events.OnStunBreakDelegate(object:  this, method:  public System.Void DynamicMessageUIController::OnStunBreak(InkWars.Model.Player playerId, float revengeSuperLevel, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)));
        InkWars.Model.Model_Events.Instance.remove_OnStunned(value:  new Model_Events.OnStunnedDelegate(object:  this, method:  System.Void DynamicMessageUIController::OnStunned(InkWars.Model.Player playerId, float stunLevel, bool isRevengeStun)));
        InkWars.Model.Model_Events.Instance.remove_OnRevengeSuper(value:  new Model_Events.OnRevengeSuperDelegate(object:  this, method:  System.Void DynamicMessageUIController::OnRevengeSuper(InkWars.Model.Player id, InkWars.Model.BubbleTypes revengeSuperType, InkWars.Model.RevengeSuperEventState state)));
        InkWars.Model.Model_Events.Instance.remove_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void DynamicMessageUIController::OnGameResult(InkWars.Model.GameResult result, bool isFinished)));
        InkWars.Model.Model_Events.Instance.remove_OnBattleEnhancer(value:  new Model_Events.OnBattleEnhancerDelegate(object:  this, method:  System.Void DynamicMessageUIController::OnBattleEnhancer(float timeStamp, InkWars.Model.Player playerId, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)));
    }
    public void InitializeMessageData(DynamicMessageUIController.DynamicMessageData _data)
    {
        if(_data != null)
        {
                _data.IsShowingPanel = false;
        }
        else
        {
                mem[32] = 0;
        }
        
        _data.Transparency.alpha = 0f;
        if(this.m_LeftPlayer == false)
        {
            goto label_3;
        }
        
        if(_data.HitCountPanel != null)
        {
            goto label_9;
        }
        
        label_10:
        label_9:
        UnityEngine.Vector2 val_1 = _data.HitCountPanel.anchoredPosition;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  -_data.hitCountImageWidth, y:  val_1.y);
        _data.HitCountPanel.anchoredPosition = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        if(this.m_LeftPlayer == false)
        {
            goto label_6;
        }
        
        if(_data.ReactionPanel != null)
        {
            goto label_11;
        }
        
        label_12:
        label_11:
        UnityEngine.Vector2 val_3 = _data.ReactionPanel.anchoredPosition;
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  -_data.reactionImageWidth, y:  val_3.y);
        _data.ReactionPanel.anchoredPosition = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        return;
        label_3:
        if(_data.HitCountPanel != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_6:
        if(_data.ReactionPanel != null)
        {
            goto label_11;
        }
        
        goto label_12;
    }
    public void InitializeTechniqueData(DynamicMessageUIController.DynamicMessageData _data)
    {
        if(_data != null)
        {
                _data.IsShowingTechnique = false;
        }
        else
        {
                mem[33] = 0;
        }
        
        _data.TransparencyTechnique.alpha = 0f;
        if(this.m_LeftPlayer == false)
        {
            goto label_3;
        }
        
        if(_data.TechniquePanel != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        UnityEngine.Vector2 val_1 = _data.TechniquePanel.anchoredPosition;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  -_data.techniqueImageWidth, y:  val_1.y);
        _data.TechniquePanel.anchoredPosition = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        return;
        label_3:
        if(_data.TechniquePanel != null)
        {
            goto label_6;
        }
        
        goto label_7;
    }
    private void AssignVariables(PlayerMessage _player, DynamicMessageUIController.DynamicMessageData _data)
    {
        object val_20;
        string val_21;
        string val_23;
        val_20 = "";
        if(_player.HitCount >= 1)
        {
                _data.HitCountText.text = _player + 20.ToString();
            val_21 = _player;
            var val_2 = (_player.ComboType == 0) ? 1 : 0;
        }
        else
        {
                val_21 = _player;
            var val_3 = (_player.ComboType == 0) ? 1 : 0;
        }
        
        if(_data.HitCountComboNameText == null)
        {
            goto label_7;
        }
        
        if((val_3 & 1) == 0)
        {
            goto label_8;
        }
        
        label_10:
        val_23 = "";
        goto label_9;
        label_7:
        if((val_3 & 1) != 0)
        {
            goto label_10;
        }
        
        label_8:
        _data.HitCountComboNameText.text = "<color #";
        var val_20 = _player + 24;
        val_20 = val_20 - 1;
        if(val_20 > 3)
        {
            goto label_11;
        }
        
        var val_21 = 40827552 + ((_player + 24 - 1)) << 2;
        val_21 = val_21 + 40827552;
        goto (40827552 + ((_player + 24 - 1)) << 2 + 40827552);
        label_11:
        val_21 = _data.HitCountComboNameText.text;
        val_23 = val_21 + System.String.Format(format:  ">{0}", arg0:  null)(System.String.Format(format:  ">{0}", arg0:  null));
        label_9:
        _data.HitCountComboNameText.text = val_23;
        UnityEngine.Vector2 val_17 = _data.ImageHitsPanel.anchoredPosition;
        if((_player + 20) < 10)
        {
            
        }
        
        UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  50f, y:  val_17.y);
        _data.ImageHitsPanel.anchoredPosition = new UnityEngine.Vector2() {x = val_18.x, y = val_18.y};
        _data.ReactionText.text = this.DetermineReactionName(player:  _player);
    }
    private void AssignTechnique(PlayerMessage _player, DynamicMessageUIController.DynamicMessageData _data)
    {
        _data.TechniqueText.text = this.DetermineTechniqueName(player:  _player);
        if(_data.TechniqueText.text.Length >= 1)
        {
                UnityEngine.Color val_4 = UnityEngine.Color.white;
        }
        else
        {
                UnityEngine.Color val_5 = UnityEngine.Color.clear;
        }
        
        _data.TechniqueImage.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
    }
    private void ProcessDynamicMessage(DynamicMessageUIController.DynamicMessageData _data)
    {
        if(_data.IsShowingPanel != false)
        {
                this.StopCoroutine(routine:  this.HideMainCoroutine);
            this.HideDynamicMessage(_data:  this.m_PlayerData, _tween:  true);
        }
        else
        {
                this.AssignVariables(_player:  this.m_Player, _data:  this.m_PlayerData);
            this.ShowDynamicMessage(_player:  this.m_Player, _data:  this.m_PlayerData);
        }
        
        bool val_1 = _data.IsShowingPanel;
        val_1 = val_1 ^ 1;
        _data.IsShowingPanel = val_1;
    }
    private void ProcessTechniqueMessage(DynamicMessageUIController.DynamicMessageData _data)
    {
        if(_data.IsShowingTechnique != false)
        {
                this.StopCoroutine(routine:  this.HideTechniqueCoroutine);
            this.HideTechniqueMessage(_data:  this.m_PlayerData, _tween:  true);
        }
        else
        {
                this.AssignTechnique(_player:  this.m_Player, _data:  this.m_PlayerData);
            this.ShowTechniqueMessage(_data:  this.m_PlayerData);
        }
        
        bool val_1 = _data.IsShowingTechnique;
        val_1 = val_1 ^ 1;
        _data.IsShowingTechnique = val_1;
    }
    private void ShowDynamicMessage(PlayerMessage _player, DynamicMessageUIController.DynamicMessageData _data)
    {
        if(_data.IsShowingPanel != false)
        {
                return;
        }
        
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  _data.Transparency, endValue:  1f, duration:  0.45f);
        Techniques val_13 = _player.ComboTechnique;
        if(val_13 > 8)
        {
            goto label_5;
        }
        
        val_13 = 1 << val_13;
        val_13 = val_13 & 322;
        if(val_13 == 0)
        {
            goto label_5;
        }
        
        label_14:
        System.Collections.IEnumerator val_2 = this.HideMainPanelAfterSeconds();
        this.HideMainCoroutine = val_2;
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  val_2);
        return;
        label_5:
        if(_player.HitCount < 3)
        {
            goto label_14;
        }
        
        DynamicMessageUIConstants val_4 = this.m_Constants;
        DynamicMessageUIConstants val_6 = this.m_Constants;
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  _data.HitCountPanel, endValue:  _data.hitCountTargetPosX, duration:  val_4.HitCountAnimationInLength, snapping:  false), ease:  val_6.HitCountAnimationEase);
        DynamicMessageUIConstants val_8 = this.m_Constants;
        DynamicMessageUIConstants val_10 = this.m_Constants;
        DG.Tweening.Tweener val_11 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  _data.ReactionPanel, endValue:  _data.reactionTargetPosX, duration:  val_8.ReactionAnimationInLength, snapping:  false), ease:  val_10.ReactionAnimationEase);
        DynamicMessageUIConstants val_12 = this.m_Constants;
        this.DelayPlayVoice(clip:  val_12.AudioClips[this.ClipIndex]);
        goto label_14;
    }
    private void ShowTechniqueMessage(DynamicMessageUIController.DynamicMessageData _data)
    {
        if(_data.IsShowingTechnique != false)
        {
                return;
        }
        
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  _data.TransparencyTechnique, endValue:  1f, duration:  0.45f);
        DynamicMessageUIConstants val_2 = this.m_Constants;
        DynamicMessageUIConstants val_4 = this.m_Constants;
        DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  _data.TechniquePanel, endValue:  _data.techniqueTargetPosX, duration:  val_2.TechniqueAnimationInLength, snapping:  false), ease:  val_4.TechniqueAnimationEase);
        System.Collections.IEnumerator val_6 = this.HideTechniqueAfterSeconds();
        this.HideTechniqueCoroutine = val_6;
        UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  val_6);
    }
    private System.Collections.IEnumerator HideMainPanelAfterSeconds()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DynamicMessageUIController.<HideMainPanelAfterSeconds>d__21();
    }
    private System.Collections.IEnumerator HideTechniqueAfterSeconds()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DynamicMessageUIController.<HideTechniqueAfterSeconds>d__22();
    }
    private void HideDynamicMessage(DynamicMessageUIController.DynamicMessageData _data, bool _tween)
    {
        float val_16;
        float val_17;
        if(_tween == false)
        {
            goto label_2;
        }
        
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  _data.Transparency, endValue:  0f, duration:  0.25f);
        if(this.m_LeftPlayer == false)
        {
            goto label_3;
        }
        
        val_16 = -_data.hitCountImageWidth;
        goto label_4;
        label_2:
        _data.Transparency.alpha = 0f;
        if(this.m_LeftPlayer == false)
        {
            goto label_6;
        }
        
        if(_data.HitCountPanel != null)
        {
            goto label_16;
        }
        
        label_17:
        label_16:
        UnityEngine.Vector2 val_2 = _data.HitCountPanel.anchoredPosition;
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  -_data.hitCountImageWidth, y:  val_2.y);
        _data.HitCountPanel.anchoredPosition = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        if(this.m_LeftPlayer == false)
        {
            goto label_9;
        }
        
        if(_data.ReactionPanel != null)
        {
            goto label_18;
        }
        
        label_19:
        label_18:
        UnityEngine.Vector2 val_4 = _data.ReactionPanel.anchoredPosition;
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  -_data.reactionImageWidth, y:  val_4.y);
        _data.ReactionPanel.anchoredPosition = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        return;
        label_3:
        val_16 = 40f;
        label_4:
        DynamicMessageUIConstants val_6 = this.m_Constants;
        DynamicMessageUIConstants val_9 = this.m_Constants;
        DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  _data.HitCountPanel, endValue:  val_16, duration:  val_6.HitCountAnimationOutLength * 0.5f, snapping:  false), ease:  val_9.HitCountAnimationEase);
        if(this.m_LeftPlayer == false)
        {
            goto label_14;
        }
        
        val_17 = -_data.reactionImageWidth;
        goto label_15;
        label_6:
        if(_data.HitCountPanel != null)
        {
            goto label_16;
        }
        
        goto label_17;
        label_9:
        if(_data.ReactionPanel != null)
        {
            goto label_18;
        }
        
        goto label_19;
        label_14:
        val_17 = 40f;
        label_15:
        DynamicMessageUIConstants val_11 = this.m_Constants;
        DynamicMessageUIConstants val_14 = this.m_Constants;
        DG.Tweening.Tweener val_15 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  _data.ReactionPanel, endValue:  val_17, duration:  val_11.ReactionAnimationOutLength * 0.5f, snapping:  false), ease:  val_14.ReactionAnimationEase);
    }
    private void HideTechniqueMessage(DynamicMessageUIController.DynamicMessageData _data, bool _tween)
    {
        float val_8;
        if(_tween == false)
        {
            goto label_2;
        }
        
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  _data.TransparencyTechnique, endValue:  0f, duration:  0.25f);
        if(this.m_LeftPlayer == false)
        {
            goto label_3;
        }
        
        val_8 = -_data.techniqueImageWidth;
        goto label_4;
        label_2:
        _data.TransparencyTechnique.alpha = 0f;
        if(this.m_LeftPlayer == false)
        {
            goto label_6;
        }
        
        if(_data.TechniquePanel != null)
        {
            goto label_11;
        }
        
        label_12:
        label_11:
        UnityEngine.Vector2 val_2 = _data.TechniquePanel.anchoredPosition;
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  -_data.techniqueImageWidth, y:  val_2.y);
        _data.TechniquePanel.anchoredPosition = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        return;
        label_3:
        val_8 = 40f;
        label_4:
        DynamicMessageUIConstants val_4 = this.m_Constants;
        float val_8 = 0.5f;
        val_8 = val_4.TechniqueAnimationOutLength * val_8;
        DynamicMessageUIConstants val_6 = this.m_Constants;
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  _data.TechniquePanel, endValue:  val_8, duration:  val_8, snapping:  false), ease:  val_6.TechniqueAnimationEase);
        return;
        label_6:
        if(_data.TechniquePanel != null)
        {
            goto label_11;
        }
        
        goto label_12;
    }
    private void ShowMessage(PlayerMessage _message)
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if(Character_GlobalInfo.gameMode > 10)
        {
            goto label_16;
        }
        
        var val_4 = 1;
        val_4 = val_4 << Character_GlobalInfo.gameMode;
        val_4 = val_4 & 1366;
        if(val_4 == 0)
        {
            goto label_4;
        }
        
        UnityEngine.Debug.Log(message:  "---- BEGIN SHOW MESSAGE ----");
        _message.LogMessage();
        UnityEngine.Debug.Log(message:  "---- END SHOW MESSAGE ----");
        InkWars.Model.Model_Manager val_1 = InkWars.Model.Model_Manager.Instance;
        if(val_1.Model.PlayersFlippedLocally == false)
        {
            goto label_11;
        }
        
        if(_message.PlayerID == 0)
        {
            goto label_18;
        }
        
        if(_message.PlayerID == 1)
        {
            goto label_21;
        }
        
        goto label_25;
        label_4:
        if(Character_GlobalInfo.gameMode == 3)
        {
                return;
        }
        
        if(Character_GlobalInfo.gameMode != 5)
        {
            goto label_16;
        }
        
        if(_message.PlayerID == 1)
        {
            goto label_18;
        }
        
        if(_message.PlayerID == 0)
        {
            goto label_21;
        }
        
        goto label_25;
        label_11:
        if(_message.PlayerID == 0)
        {
            goto label_21;
        }
        
        if(_message.PlayerID != 1)
        {
            goto label_25;
        }
        
        label_18:
        if(this.m_LeftPlayer == true)
        {
                return;
        }
        
        goto label_25;
        label_21:
        if(this.m_LeftPlayer == true)
        {
            goto label_25;
        }
        
        return;
        label_16:
        val_5 = null;
        val_5 = null;
        _message.PlayerID = (DataStructs.UserDataDictionary.Settings.FlipNegateX != 1) ? 1 : 0;
        label_25:
        this.m_Player = _message;
        if(this.m_PlayerData.IsShowingPanel != false)
        {
                this.StopCoroutine(routine:  this.HideMainCoroutine);
            this.HideDynamicMessage(_data:  this.m_PlayerData, _tween:  false);
        }
        
        this.InitializeMessageData(_data:  this.m_PlayerData);
        this.AssignVariables(_player:  this.m_Player, _data:  this.m_PlayerData);
        this.ProcessDynamicMessage(_data:  this.m_PlayerData);
    }
    private void ShowTechnique(PlayerMessage _message)
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if(Character_GlobalInfo.gameMode > 10)
        {
            goto label_16;
        }
        
        var val_4 = 1;
        val_4 = val_4 << Character_GlobalInfo.gameMode;
        val_4 = val_4 & 1366;
        if(val_4 == 0)
        {
            goto label_4;
        }
        
        UnityEngine.Debug.Log(message:  "---- BEGIN SHOW MESSAGE ----");
        _message.LogMessage();
        UnityEngine.Debug.Log(message:  "---- END SHOW MESSAGE ----");
        InkWars.Model.Model_Manager val_1 = InkWars.Model.Model_Manager.Instance;
        if(val_1.Model.PlayersFlippedLocally == false)
        {
            goto label_11;
        }
        
        if(_message.PlayerID == 0)
        {
            goto label_18;
        }
        
        if(_message.PlayerID == 1)
        {
            goto label_21;
        }
        
        goto label_25;
        label_4:
        if(Character_GlobalInfo.gameMode == 3)
        {
                return;
        }
        
        if(Character_GlobalInfo.gameMode != 5)
        {
            goto label_16;
        }
        
        if(_message.PlayerID == 1)
        {
            goto label_18;
        }
        
        if(_message.PlayerID == 0)
        {
            goto label_21;
        }
        
        goto label_25;
        label_11:
        if(_message.PlayerID == 0)
        {
            goto label_21;
        }
        
        if(_message.PlayerID != 1)
        {
            goto label_25;
        }
        
        label_18:
        if(this.m_LeftPlayer == true)
        {
                return;
        }
        
        goto label_25;
        label_21:
        if(this.m_LeftPlayer == true)
        {
            goto label_25;
        }
        
        return;
        label_16:
        val_5 = null;
        val_5 = null;
        _message.PlayerID = (DataStructs.UserDataDictionary.Settings.FlipNegateX != 1) ? 1 : 0;
        label_25:
        this.m_Player = _message;
        this.InitializeTechniqueData(_data:  this.m_PlayerData);
        this.AssignTechnique(_player:  this.m_Player, _data:  this.m_PlayerData);
        this.ProcessTechniqueMessage(_data:  this.m_PlayerData);
    }
    public void OnComboPop(PlayerMessage message)
    {
        this.ShowMessage(_message:  message);
        if(message.ComboTechnique == 0)
        {
                return;
        }
        
        this.ShowTechnique(_message:  message);
    }
    private void OnStunned(InkWars.Model.Player playerId, float stunLevel, bool isRevengeStun)
    {
        UnityEngine.Debug.Log(message:  ">>>> STUNNED - ID: "(">>>> STUNNED - ID: ") + playerId);
        this.ShowTechnique(_message:  new PlayerMessage(PlayerID:  playerId, HitCount:  0, ComboType:  0, ComboTechnique:  5));
    }
    public void OnStunBreak(InkWars.Model.Player playerId, float revengeSuperLevel, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)
    {
        this.ShowTechnique(_message:  new PlayerMessage(PlayerID:  playerId, HitCount:  0, ComboType:  0, ComboTechnique:  10));
    }
    private void OnRevengeSuper(InkWars.Model.Player id, InkWars.Model.BubbleTypes revengeSuperType, InkWars.Model.RevengeSuperEventState state)
    {
        var val_6;
        GameMode val_7;
        var val_8;
        val_6 = null;
        val_6 = null;
        val_7 = Character_GlobalInfo.gameMode;
        if(val_7 != 6)
        {
            goto label_3;
        }
        
        if(id == 1)
        {
                return;
        }
        
        if(state == 1)
        {
            goto label_5;
        }
        
        return;
        label_3:
        val_7 = Character_GlobalInfo.gameMode;
        var val_1 = (val_7 != 10) ? 1 : 0;
        if(state != 1)
        {
                return;
        }
        
        val_1 = val_1 | ((id != 1) ? 1 : 0);
        if((val_1 & 1) == 0)
        {
                return;
        }
        
        label_5:
        if(revengeSuperType == 10)
        {
            goto label_11;
        }
        
        if(revengeSuperType != 8)
        {
            goto label_12;
        }
        
        val_8 = 1;
        goto label_14;
        label_11:
        val_8 = 3;
        goto label_14;
        label_12:
        val_8 = 2;
        label_14:
        .customInfo = "Lv " + val_8.ToString();
        this.ShowTechnique(_message:  new PlayerMessage(PlayerID:  id, HitCount:  0, ComboType:  0, ComboTechnique:  11));
    }
    private void OnBattleEnhancer(float timeStamp, InkWars.Model.Player playerId, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)
    {
        var val_4;
        GameMode val_5;
        val_4 = null;
        val_4 = null;
        val_5 = Character_GlobalInfo.gameMode;
        if(val_5 != 6)
        {
            goto label_3;
        }
        
        if(playerId == 1)
        {
                return;
        }
        
        if(state == 1)
        {
            goto label_5;
        }
        
        return;
        label_3:
        val_5 = Character_GlobalInfo.gameMode;
        var val_1 = (val_5 != 10) ? 1 : 0;
        if(state != 1)
        {
                return;
        }
        
        val_1 = val_1 | ((playerId != 1) ? 1 : 0);
        if((val_1 & 1) == 0)
        {
                return;
        }
        
        label_5:
        this.ShowTechnique(_message:  new PlayerMessage(PlayerID:  playerId, HitCount:  0, ComboType:  0, ComboTechnique:  12));
    }
    private void OnGameResult(InkWars.Model.GameResult result, bool isFinished)
    {
        if(isFinished == false)
        {
                return;
        }
        
        this.m_PlayerData.Transparency.alpha = 0f;
    }
    private string DetermineReactionName(PlayerMessage player)
    {
        string val_2 = "";
        if((player.HitCount - 3) > 36)
        {
                return (string);
        }
        
        var val_2 = 40827568 + ((player.HitCount - 3)) << 2;
        val_2 = val_2 + 40827568;
        goto (40827568 + ((player.HitCount - 3)) << 2 + 40827568);
    }
    private string DetermineTechniqueName(PlayerMessage player)
    {
        string val_1 = "<color #";
        if(player.ComboTechnique > 12)
        {
                return (string);
        }
        
        var val_1 = 40827716 + (player.ComboTechnique) << 2;
        val_1 = val_1 + 40827716;
        goto (40827716 + (player.ComboTechnique) << 2 + 40827716);
    }
    private void DelayPlayVoice(UnityEngine.AudioClip clip)
    {
        bool val_1 = UnityEngine.Object.op_Equality(x:  0, y:  clip);
        if(val_1 != false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  val_1.DelayPlaySound(clip:  clip));
    }
    private System.Collections.IEnumerator DelayPlaySound(UnityEngine.AudioClip clip)
    {
        .<>1__state = 0;
        .clip = clip;
        return (System.Collections.IEnumerator)new DynamicMessageUIController.<DelayPlaySound>d__36();
    }
    public DynamicMessageUIController()
    {
        this.m_PlayerData = new DynamicMessageUIController.DynamicMessageData();
    }

}
