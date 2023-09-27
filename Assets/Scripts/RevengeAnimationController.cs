using UnityEngine;
public class RevengeAnimationController : Control_Base<RevengeAnimationController>
{
    // Fields
    private RevengeCharacterInformation m_RevengeCharacterInformationDB;
    private PlayerCharacterUIController m_PlayerControllerReference;
    private InkWars.Model.BubbleTypes m_PlayerBubble;
    internal RevengeAnimationController.Data m_Data;
    private DG.Tweening.Sequence m_AnimationSequence;
    private bool m_FirstDoubleTapAnimation;
    
    // Methods
    internal override void Start()
    {
        this.Start();
    }
    private void OnEnable()
    {
        InkWars.Model.Model_Events.Instance.add_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void RevengeAnimationController::OnGameResult(InkWars.Model.GameResult result, bool isFinished)));
        InkWars.Model.Model_Events.Instance.add_OnRevengeSuper(value:  new Model_Events.OnRevengeSuperDelegate(object:  this, method:  System.Void RevengeAnimationController::OnRevengeSuper(InkWars.Model.Player id, InkWars.Model.BubbleTypes revengeSuperType, InkWars.Model.RevengeSuperEventState state)));
        InkWars.Model.Model_Events.Instance.add_OnStunBreak(value:  new Model_Events.OnStunBreakDelegate(object:  this, method:  public System.Void RevengeAnimationController::OnStunBreak(InkWars.Model.Player playerId, float revengeSuperLevel, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)));
        InkWars.Model.Model_Events.Instance.add_OnStunned(value:  new Model_Events.OnStunnedDelegate(object:  this, method:  System.Void RevengeAnimationController::OnStunned(InkWars.Model.Player playerId, float stunLevel, bool isRevengeStun)));
        InkWars.Model.Model_Events.Instance.add_OnModelStart(value:  new Model_Events.BasicDelegate(object:  this, method:  System.Void RevengeAnimationController::InitializeVariables()));
    }
    private void OnDisable()
    {
        if(InkWars.Model.Model_Events.Instance == 0)
        {
                return;
        }
        
        InkWars.Model.Model_Events.Instance.remove_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void RevengeAnimationController::OnGameResult(InkWars.Model.GameResult result, bool isFinished)));
        InkWars.Model.Model_Events.Instance.remove_OnRevengeSuper(value:  new Model_Events.OnRevengeSuperDelegate(object:  this, method:  System.Void RevengeAnimationController::OnRevengeSuper(InkWars.Model.Player id, InkWars.Model.BubbleTypes revengeSuperType, InkWars.Model.RevengeSuperEventState state)));
        InkWars.Model.Model_Events.Instance.remove_OnStunBreak(value:  new Model_Events.OnStunBreakDelegate(object:  this, method:  public System.Void RevengeAnimationController::OnStunBreak(InkWars.Model.Player playerId, float revengeSuperLevel, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)));
        InkWars.Model.Model_Events.Instance.remove_OnStunned(value:  new Model_Events.OnStunnedDelegate(object:  this, method:  System.Void RevengeAnimationController::OnStunned(InkWars.Model.Player playerId, float stunLevel, bool isRevengeStun)));
        InkWars.Model.Model_Events.Instance.remove_OnModelStart(value:  new Model_Events.BasicDelegate(object:  this, method:  System.Void RevengeAnimationController::InitializeVariables()));
    }
    private System.Collections.IEnumerator LoadAvatarDynamicPose(UnityEngine.UI.Image _image, CharacterNameID _ID, CharacterAssetLoader _cl)
    {
        RevengeAnimationController.<LoadAvatarDynamicPose>d__10 val_1 = new RevengeAnimationController.<LoadAvatarDynamicPose>d__10();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            ._image = _image;
            ._ID = _ID;
        }
        else
        {
                mem[48] = this;
            mem[56] = _image;
            mem[40] = _ID;
        }
        
        ._cl = _cl;
        return (System.Collections.IEnumerator)val_1;
    }
    private void InitializeVariables()
    {
        RevengeAnimationController val_19;
        Data val_20;
        GradientInformation val_21;
        Data val_22;
        GradientInformation val_23;
        val_19 = this;
        InkWars.Model.Model_Player val_2 = this.m_PlayerControllerReference.PlayerModel;
        View_Objects val_3 = View_Core.Instance.GetViewObjectsByPlayerId_Flip(aNewPlayerId:  val_2.ID);
        val_3.RevengeAnimationController = val_19;
        UnityEngine.Vector2 val_4 = this.m_Data.RectPanel.anchoredPosition;
        this.m_Data.OriginalRectPanelPosition = val_4;
        mem2[0] = val_4.y;
        val_20 = this.m_Data;
        if(this.m_Data != null)
        {
            goto label_7;
        }
        
        val_20 = this.m_Data;
        if(val_20 == null)
        {
            goto label_34;
        }
        
        label_7:
        UnityEngine.Vector2 val_5 = this.m_Data.RectPanel.anchoredPosition;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  0f, y:  val_5.y);
        this.m_Data.RectPanel.anchoredPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        InkWars.Model.Model_Player val_7 = this.m_PlayerControllerReference.PlayerModel;
        CharacterData val_8 = CharacterDataManager.Get(id:  val_7.Name);
        CharacterAssetLoader val_9 = this.m_PlayerControllerReference.AssetLoader;
        UnityEngine.Coroutine val_11 = val_9.StartCoroutine(routine:  this.LoadAvatarDynamicPose(_image:  this.m_Data.AvatarImage, _ID:  val_8.characterId, _cl:  val_9));
        UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_8.revengeSuperAvatarLocation, y:  V9.16B);
        this.m_Data.AvatarImage.rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_13.x, y = val_13.y};
        var val_15 = (CharacterDataManager.__il2cppRuntimeField_cctor_finished != 0) ? (-S10) : (S10);
        this.m_Data.AvatarImage.rectTransform.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_21 = this.m_Data.AvatarImage.rectTransform;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8.revengeSuperAvatarScale, y = val_8.revengeSuperAvatarLocation});
        val_21.localScale = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        if(val_8.realPersonCharacter == false)
        {
            goto label_29;
        }
        
        val_21 = this.m_RevengeCharacterInformationDB.m_Gradients.Purple;
        this.m_Data.GradientColors = val_21;
        val_22 = this.m_Data;
        if(this.m_Data != null)
        {
            goto label_33;
        }
        
        val_22 = this.m_Data;
        if(val_22 == null)
        {
            goto label_34;
        }
        
        label_33:
        val_19 = this.m_Data.GradientColors;
        val_19.ApplyPropertiesToMaterial(_material:  this.m_Data.BackgroundMaterial);
        return;
        label_29:
        InkWars.Model.Model_Player val_18 = this.m_PlayerControllerReference.PlayerModel;
        if(val_18.Clan == 2)
        {
            goto label_39;
        }
        
        if(val_18.Clan == 1)
        {
            goto label_40;
        }
        
        if(val_18.Clan != 0)
        {
                return;
        }
        
        val_19 = this.m_Data;
        val_23 = this.m_RevengeCharacterInformationDB.m_Gradients.Red;
        if(val_19 != null)
        {
            goto label_51;
        }
        
        goto label_52;
        label_39:
        val_19 = this.m_Data;
        val_23 = this.m_RevengeCharacterInformationDB.m_Gradients.Teal;
        if(val_19 != null)
        {
            goto label_51;
        }
        
        label_52:
        label_51:
        this.m_Data.GradientColors = val_23;
        return;
        label_40:
        if(this.m_Data != null)
        {
            goto label_51;
        }
        
        goto label_52;
        label_34:
    }
    public void BeginAnimation()
    {
        Data val_7;
        UnityEngine.RectTransform val_8;
        Data val_9;
        if(this.m_AnimationSequence != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.m_AnimationSequence, complete:  false);
        }
        
        this.m_AnimationSequence = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.DOTween.Sequence(), isIndependentUpdate:  true);
        this.m_RevengeCharacterInformationDB.Show();
        val_7 = this.m_Data;
        if(val_7 == null)
        {
            goto label_5;
        }
        
        val_8 = this.m_Data.RectPanel;
        val_9 = val_7;
        goto label_8;
        label_5:
        val_9 = this.m_Data;
        val_8 = this.m_Data.RectPanel;
        if(val_9 == null)
        {
            goto label_7;
        }
        
        val_7 = val_9;
        goto label_8;
        label_7:
        val_7 = this.m_Data;
        if(val_7 == null)
        {
            goto label_9;
        }
        
        label_8:
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.m_AnimationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  val_8, endValue:  new UnityEngine.Vector2() {x = this.m_Data.OriginalRectPanelPosition, y = V8.16B}, duration:  this.m_Data.AnimationSettings.duration, snapping:  false), ease:  this.m_Data.AnimationSettings.ease), isIndependentUpdate:  true));
        this.RevengeSuperFlash();
        return;
        label_9:
    }
    internal void RevengeSuperFlash()
    {
        this.m_Data.IsFlashing = true;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.FlashHelper(delay:  this.m_Data.FlashingDelay));
    }
    public void StopAnimation()
    {
        Data val_5;
        Data val_6;
        if(this.m_AnimationSequence != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.m_AnimationSequence, complete:  false);
        }
        
        this.m_RevengeCharacterInformationDB.Hide();
        this.m_Data.IsFlashing = false;
        val_5 = this.m_Data;
        if(this.m_Data != null)
        {
            goto label_4;
        }
        
        val_5 = this.m_Data;
        if(val_5 == null)
        {
            goto label_8;
        }
        
        label_4:
        this.m_Data.GradientColors.ApplyPropertiesToMaterial(_material:  this.m_Data.BackgroundMaterial);
        val_6 = this.m_Data;
        if(this.m_Data != null)
        {
            goto label_7;
        }
        
        val_6 = this.m_Data;
        if(val_6 == null)
        {
            goto label_8;
        }
        
        label_7:
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  0f, y:  null);
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.m_Data.RectPanel, endValue:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, duration:  this.m_Data.AnimationSettings.duration, snapping:  false), ease:  this.m_Data.AnimationSettings.ease), isIndependentUpdate:  true);
        return;
        label_8:
    }
    private void OnRevengeSuper(InkWars.Model.Player id, InkWars.Model.BubbleTypes revengeSuperType, InkWars.Model.RevengeSuperEventState state)
    {
        System.Object[] val_10;
        CharAnimationController val_11;
        var val_12;
        InkWars.Model.BubbleTypes val_13;
        val_10 = state;
        val_11 = this;
        InkWars.Model.Model_Player val_1 = this.m_PlayerControllerReference.PlayerModel;
        if(val_1.ID != id)
        {
                return;
        }
        
        object[] val_2 = new object[1];
        val_2[0] = id;
        UnityEngine.Debug.LogFormat(format:  ">> RAC OnRevengeSuper - Player ID: {0}", args:  val_2);
        val_12 = View_Core.Instance;
        View_Objects val_5 = val_12.GetViewObjectsByPlayerId_Flip(aNewPlayerId:  id);
        if(val_10 == 2)
        {
            goto label_12;
        }
        
        if(val_10 == 3)
        {
            goto label_13;
        }
        
        if(val_10 != 4)
        {
                return;
        }
        
        this.StopAnimation();
        val_11 = val_5.PlayerAnimator;
        val_11.SetSortingLayer(_sortingLayer:  9);
        val_3.TryShoot = true;
        return;
        label_12:
        object[] val_6 = new object[3];
        val_10 = val_6;
        val_10[0] = this.m_PlayerControllerReference.PlayerModel;
        val_12 = 1152921505153011712;
        val_10[1] = val_3.LoadedBubble;
        val_10[2] = val_3.SpareBubble;
        UnityEngine.Debug.LogFormat(format:  "Player: {0}, Bubbles - {1}::{2}", args:  val_6);
        if((GenericFunctions.IsSuperType(bubbleType:  val_3.SpareBubble)) == false)
        {
            goto label_32;
        }
        
        val_13 = val_3.SpareBubble;
        goto label_33;
        label_13:
        this.BeginAnimation();
        val_5.PlayerAnimator.SetSortingLayer(_sortingLayer:  16);
        val_11 = GameAudio.sound;
        UnityEngine.AudioSource val_9 = val_11.PlayOneShot(clip:  this.m_RevengeCharacterInformationDB.m_RevengeClips.RevengeSuperFire, volume:  1f);
        return;
        label_32:
        val_13 = val_3.LoadedBubble;
        label_33:
        this.m_PlayerBubble = val_13;
    }
    private void OnStunned(InkWars.Model.Player playerId, float stunLevel, bool isRevengeStun)
    {
        var val_24;
        RevengeAnimationController.<>c__DisplayClass16_0 val_25;
        var val_26;
        val_24 = isRevengeStun;
        RevengeAnimationController.<>c__DisplayClass16_0 val_1 = null;
        val_25 = val_1;
        val_1 = new RevengeAnimationController.<>c__DisplayClass16_0();
        InkWars.Model.Model_Player val_2 = this.m_PlayerControllerReference.PlayerModel;
        if(val_2.ID != playerId)
        {
                return;
        }
        
        InkWars.Model.Model_Player val_3 = this.m_PlayerControllerReference.PlayerModel;
        .player = View_Core.Instance.GetViewObjectsByPlayerId_Flip(aNewPlayerId:  playerId);
        if(this.m_FirstDoubleTapAnimation != false)
        {
                RevengeAnimationController.<>c__DisplayClass16_1 val_6 = new RevengeAnimationController.<>c__DisplayClass16_1();
            if(val_6 != null)
        {
                val_26 = val_6;
            .CS$<>8__locals1 = val_25;
            mem[1152921528464229728] = 1;
            mem[1152921528464229736] = "Double-Tap";
        }
        else
        {
                val_26 = 32;
            mem[32] = val_25;
            mem[16] = 1;
            mem[24] = "Double-Tap";
        }
        
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  1.3f);
            val_25 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_5.StunBreakDoubleTapTransparency.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.25f), loops:  0, loopType:  1);
            DG.Tweening.Tweener val_13 = DG.Tweening.TweenSettingsExtensions.OnStepComplete<DG.Tweening.Tweener>(t:  val_25, action:  new DG.Tweening.TweenCallback(object:  val_6, method:  System.Void RevengeAnimationController.<>c__DisplayClass16_1::<OnStunned>b__0()));
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  1.3f);
            DG.Tweening.Tweener val_18 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_5.NoStunBreakDoubleTapTransparency.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, duration:  0.25f), loops:  0, loopType:  1);
            this.m_FirstDoubleTapAnimation = false;
        }
        
        if(val_24 != false)
        {
                val_24 = GameAudio.sound;
            UnityEngine.AudioSource val_20 = val_24.PlayOneShot(clip:  this.m_RevengeCharacterInformationDB.m_RevengeClips.StunnerShock, volume:  1f);
        }
        
        UnityEngine.Color val_21 = UnityEngine.Color.red;
        UnityEngine.Coroutine val_23 = this.StartCoroutine(routine:  this.CharacterFlashHelper(firstColor:  new UnityEngine.Color() {r = val_21.r, g = val_21.g, b = val_21.b, a = val_21.a}, duration:  val_3.StunnedTime));
    }
    public void OnStunBreak(InkWars.Model.Player playerId, float revengeSuperLevel, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)
    {
        InkWars.Model.Player val_29 = playerId;
        InkWars.Model.Model_Player val_1 = this.m_PlayerControllerReference.PlayerModel;
        if(val_1.ID != val_29)
        {
                return;
        }
        
        val_29 = View_Core.Instance.GetViewObjectsByPlayerId_Flip(aNewPlayerId:  val_29 = playerId);
        val_4.StunBreakDoubleTapTransparency.alpha = 0f;
        val_4.ActiveBaseColorFlash.StopFlash();
        if((int)revengeSuperLevel == (1.401298E-43f))
        {
                return;
        }
        
        UnityEngine.Color val_5 = UnityEngine.Color.green;
        UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.CharacterFlashHelper(firstColor:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a}, duration:  1f));
        UnityEngine.RectTransform val_8 = val_4.ActiveBase.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Vector3 val_10 = val_8.position;
        UnityEngine.Quaternion val_11 = val_8.rotation;
        UnityEngine.GameObject val_13 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_4.ActiveBase.gameObject, position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, rotation:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w}, parent:  val_8.parent);
        UnityEngine.Vector3 val_15 = val_8.localScale;
        val_13.transform.localScale = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        UnityEngine.Vector3 val_17 = val_8.position;
        UnityEngine.Quaternion val_18 = val_8.rotation;
        UnityEngine.GameObject val_20 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_4.ActiveBase.gameObject, position:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, rotation:  new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w}, parent:  val_8.parent);
        UnityEngine.Vector3 val_22 = val_8.localScale;
        val_20.transform.localScale = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
        UnityEngine.Coroutine val_25 = this.StartCoroutine(routine:  View_Core.Instance.StunBreaker_ExpandThenDestroy(obj:  val_13, speed:  6f));
        this.StartCoroutine(routine:  View_Core.Instance.StunBreaker_ExpandThenDestroy(obj:  val_20, speed:  3.5f)).ResetCharacter(player:  val_29);
        val_29.SetBaseReloadPercentage(playerModel:  this.m_PlayerControllerReference.PlayerModel);
    }
    private void ResetCharacter(View_Objects player)
    {
        if(player != null)
        {
                player.ResetBase();
        }
        else
        {
                0.ResetBase();
        }
        
        player.CharacterShake_Reset();
    }
    private void StopFlash()
    {
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.m_PlayerControllerReference.FlashPlayer.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        this.m_PlayerControllerReference.FlashPlayer.StopFlash();
    }
    private System.Collections.IEnumerator FlashHelper(float delay)
    {
        RevengeAnimationController.<FlashHelper>d__20 val_1 = new RevengeAnimationController.<FlashHelper>d__20();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .delay = delay;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator CharacterFlashHelper(UnityEngine.Color firstColor, float duration)
    {
        RevengeAnimationController.<CharacterFlashHelper>d__21 val_1 = new RevengeAnimationController.<CharacterFlashHelper>d__21();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .firstColor = firstColor;
        mem[1152921528465170676] = firstColor.g;
        mem[1152921528465170680] = firstColor.b;
        mem[1152921528465170684] = firstColor.a;
        .duration = duration;
        return (System.Collections.IEnumerator)val_1;
    }
    private void OnGameResult(InkWars.Model.GameResult result, bool isFinished)
    {
        this.StopAllCoroutines();
        this.StopFlash();
        View_Core.Instance.ResetCharacter(player:  val_1.LeftPlayer);
        View_Core.Instance.ResetCharacter(player:  val_2.RightPlayer);
    }
    public RevengeAnimationController()
    {
        this.m_Data = new RevengeAnimationController.Data();
        this.m_FirstDoubleTapAnimation = true;
    }

}
