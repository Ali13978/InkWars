using UnityEngine;
public class PostDisconnectionBehaviour : InstantiablePrefab<PostDisconnectionBehaviour>
{
    // Fields
    private CharacterAssetLoader m_CharacterAssetLoader;
    private PostDisconnectionBehaviour.VisualData m_Data;
    private string m_MatchOutcomeDescription;
    private string m_MatchOutcomePenaltyText;
    private InkWars.Model.MVC_Multiplayer_Manager_Base.MatchStates m_MatchState;
    private UnityEngine.AudioClip m_audioClipRed;
    private UnityEngine.AudioClip m_audioClipGreen;
    private bool m_ShowRank;
    
    // Properties
    public static PostDisconnectionBehaviour Instance { get; }
    
    // Methods
    public static PostDisconnectionBehaviour get_Instance()
    {
        T val_4 = InstantiablePrefab<T>.m_Instance;
        if(0 != val_4)
        {
                return (PostDisconnectionBehaviour)InstantiablePrefab<T>.m_Instance;
        }
        
        val_4 = UnityEngine.Resources.Load<PostDisconnectionBehaviour>(path:  "DynamicUI/PostDisconnection");
        InstantiablePrefab<T>.m_Instance = UnityEngine.Object.Instantiate<PostDisconnectionBehaviour>(original:  val_4);
        return (PostDisconnectionBehaviour)InstantiablePrefab<T>.m_Instance;
    }
    public static void Setup(InkWars.Model.MVC_Multiplayer_Manager_Base.MatchStates _state)
    {
        MatchStates val_19;
        string val_21;
        var val_22;
        var val_23;
        UnityEngine.AudioClip val_24;
        val_19 = _state;
        if(val_19 == 1)
        {
            goto label_1;
        }
        
        if(val_19 != 3)
        {
                if(val_19 != 2)
        {
                return;
        }
        
        }
        
        PostDisconnectionBehaviour val_1 = PostDisconnectionBehaviour.Instance;
        val_1.m_MatchOutcomeDescription = "OPPONENT HAS TERMINATED NETWORK MATCH";
        if(PostDisconnectionBehaviour.Instance == null)
        {
            goto label_8;
        }
        
        val_21 = "<color=#98EC8DFF>NO POINTS WILL BE DEDUCTED</color>";
        val_22 = 0;
        goto label_6;
        label_1:
        PostDisconnectionBehaviour val_3 = PostDisconnectionBehaviour.Instance;
        val_3.m_MatchOutcomeDescription = "YOU TERMINATED THE PREVIOUS NETWORK MATCH";
        if(PostDisconnectionBehaviour.Instance == null)
        {
            goto label_8;
        }
        
        val_21 = "<color=#BC4F4FFF>POINTS WILL BE DEDUCTED</color>";
        val_22 = 1;
        label_6:
        val_4.m_MatchOutcomePenaltyText = val_21;
        PostDisconnectionBehaviour val_5 = PostDisconnectionBehaviour.Instance;
        val_5.m_MatchState = val_19;
        PostDisconnectionBehaviour val_6 = PostDisconnectionBehaviour.Instance;
        if(val_22 == 0)
        {
            goto label_11;
        }
        
        val_23 = GameAudio.sound;
        PostDisconnectionBehaviour val_8 = PostDisconnectionBehaviour.Instance;
        val_24 = val_8.m_audioClipRed;
        if(val_23 != null)
        {
            goto label_20;
        }
        
        goto label_16;
        label_11:
        val_23 = GameAudio.sound;
        PostDisconnectionBehaviour val_10 = PostDisconnectionBehaviour.Instance;
        val_24 = val_10.m_audioClipGreen;
        if(val_23 != null)
        {
            goto label_20;
        }
        
        label_16:
        label_20:
        UnityEngine.AudioSource val_11 = val_23.PlayOneShot(clip:  val_24, volume:  1f);
        PostDisconnectionBehaviour val_12 = PostDisconnectionBehaviour.Instance;
        PostDisconnectionBehaviour val_13 = PostDisconnectionBehaviour.Instance;
        val_19 = ???;
        goto typeof(PostDisconnectionBehaviour).__il2cppRuntimeField_1A8;
        label_8:
    }
    private System.Collections.IEnumerator LoadPlayerAvatar(UnityEngine.UI.Image _image, CharacterNameID _ID, CharacterAssetLoader _cl)
    {
        PostDisconnectionBehaviour.<LoadPlayerAvatar>d__12 val_1 = new PostDisconnectionBehaviour.<LoadPlayerAvatar>d__12();
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
    public override void Animate()
    {
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  53669888, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_Data.AvatarImage.rectTransform, endValue:  1f, duration:  0.5f), ease:  27));
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  53669888, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_Data.PlayerPointsPanel, endValue:  1f, duration:  0.75f), ease:  27));
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Join(s:  53669888, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_Data.BattlePointsPanel, endValue:  1f, duration:  0.75f), ease:  27));
        if(this.m_ShowRank == false)
        {
                return;
        }
        
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  this, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_Data.RankPanel, endValue:  1f, duration:  0.75f), ease:  18));
    }
    public override void InitializeLocalVariables()
    {
        VisualData val_65;
        UnityEngine.RectTransform val_66;
        VisualData val_67;
        UnityEngine.RectTransform val_68;
        var val_69;
        var val_70;
        string val_71;
        var val_72;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        this.m_Data.MatchOutcomeDescriptionText.text = this.m_MatchOutcomeDescription;
        this.m_Data.MatchOutcomePenaltyDescriptionText.text = this.m_MatchOutcomePenaltyText;
        val_65 = this.m_Data;
        if(val_65 == null)
        {
            goto label_5;
        }
        
        val_66 = this.m_Data.PlayerPointsPanel;
        val_67 = val_65;
        goto label_8;
        label_5:
        val_67 = this.m_Data;
        val_66 = this.m_Data.PlayerPointsPanel;
        if(val_67 == null)
        {
            goto label_7;
        }
        
        val_65 = val_67;
        goto label_8;
        label_7:
        val_65 = this.m_Data;
        if(val_65 == null)
        {
            goto label_9;
        }
        
        label_8:
        val_68 = this.m_Data.RankPanel;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        val_68.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.m_Data.AvatarImage.rectTransform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.m_Data.BattlePointsPanel.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        val_66.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        val_69 = null;
        val_69 = null;
        CharacterNameID val_3 = DataStructs.UserDataDictionary.GameSave.LastPlayedPVPCharacter;
        UnityEngine.Coroutine val_5 = this.m_CharacterAssetLoader.StartCoroutine(routine:  this.LoadPlayerAvatar(_image:  this.m_Data.AvatarImage, _ID:  val_3, _cl:  this.m_CharacterAssetLoader));
        if(this.m_MatchState != 1)
        {
            goto label_22;
        }
        
        val_70 = null;
        val_70 = null;
        DataStructs.CharacterStats val_6 = DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  val_3);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = val_6.Bp;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = DataStructs.UserDataDictionary.GameSave.QuitLoss_BattleP;
        int val_11 = UnityEngine.Mathf.Abs(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_9.currentCryptoKey, hiddenValue = val_9.hiddenValue, fakeValue = val_9.fakeValue, inited = val_9.inited}));
        val_11 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_7.fakeValue, inited = val_7.inited})) - val_11;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_11);
        if(val_6 == null)
        {
            goto label_32;
        }
        
        val_6.Bp = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_12.currentCryptoKey, hiddenValue = val_12.hiddenValue, fakeValue = val_12.fakeValue, inited = val_12.inited};
        goto label_33;
        label_22:
        this.m_Data.DeductedPlayerPointsText.text = "0";
        this.m_Data.DeductedBattlePointsText.text = "0";
        goto label_38;
        label_32:
        0.Bp = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_12.currentCryptoKey, hiddenValue = val_12.hiddenValue, fakeValue = val_12.fakeValue, inited = val_12.inited};
        label_33:
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_13 = val_6.Loss;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_14 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_13.currentCryptoKey, hiddenValue = val_13.hiddenValue, fakeValue = val_13.fakeValue, inited = val_13.inited});
        val_6.Loss = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_14.currentCryptoKey, hiddenValue = val_14.hiddenValue, fakeValue = val_14.fakeValue, inited = val_14.inited};
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_15 = DataStructs.UserDataDictionary.Stats.PlayerPoints;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_17 = DataStructs.UserDataDictionary.GameSave.QuitLoss_PlayerP;
        int val_19 = UnityEngine.Mathf.Abs(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_17.currentCryptoKey, hiddenValue = val_17.hiddenValue, fakeValue = val_17.fakeValue, inited = val_17.inited}));
        val_19 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_15.currentCryptoKey, hiddenValue = val_15.hiddenValue, fakeValue = val_15.fakeValue, inited = val_15.inited})) - val_19;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_20 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_19);
        DataStructs.UserDataDictionary.Stats.PlayerPoints = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_20.currentCryptoKey, hiddenValue = val_20.hiddenValue, fakeValue = val_20.fakeValue, inited = val_20.inited};
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_21 = DataStructs.UserDataDictionary.Stats.PlayerPoints;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_24 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  System.Math.Max(val1:  0, val2:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_21.currentCryptoKey, hiddenValue = val_21.hiddenValue, fakeValue = val_21.fakeValue, inited = val_21.inited})));
        DataStructs.UserDataDictionary.Stats.PlayerPoints = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_24.currentCryptoKey, hiddenValue = val_24.hiddenValue, fakeValue = val_24.fakeValue, inited = val_24.inited};
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_25 = DataStructs.UserDataDictionary.GameSave.QuitLoss_PlayerP;
        int val_27 = UnityEngine.Mathf.Abs(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_25.currentCryptoKey, hiddenValue = val_25.hiddenValue, fakeValue = val_25.fakeValue, inited = val_25.inited}));
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_28 = DataStructs.UserDataDictionary.GameSave.QuitLoss_BattleP;
        if(val_27 <= 0)
        {
            goto label_50;
        }
        
        if(this.m_Data.DeductedPlayerPointsText != null)
        {
            goto label_124;
        }
        
        label_125:
        label_124:
        this.m_Data.DeductedPlayerPointsText.text = "-"("-") + (float)val_27.ToString();
        if(((float)UnityEngine.Mathf.Abs(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_28.currentCryptoKey, hiddenValue = val_28.hiddenValue, fakeValue = val_28.fakeValue, inited = val_28.inited}))) <= 0f)
        {
            goto label_53;
        }
        
        val_71 = "-"("-") + (float)UnityEngine.Mathf.Abs(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_28.currentCryptoKey, hiddenValue = val_28.hiddenValue, fakeValue = val_28.fakeValue, inited = val_28.inited})).ToString()((float)UnityEngine.Mathf.Abs(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_28.currentCryptoKey, hiddenValue = val_28.hiddenValue, fakeValue = val_28.fakeValue, inited = val_28.inited})).ToString());
        if(this.m_Data.DeductedBattlePointsText != null)
        {
            goto label_56;
        }
        
        goto label_55;
        label_53:
        val_71 = "0";
        if(this.m_Data.DeductedBattlePointsText != null)
        {
            goto label_56;
        }
        
        label_55:
        label_56:
        this.m_Data.DeductedBattlePointsText.text = val_71;
        val_72 = null;
        val_72 = null;
        RankingConstraints val_37 = RankingCollection.Get(rank:  DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  val_3).BPRank);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_39 = DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  val_3).Bp;
        DataStructs.PlayerRank val_41 = RankingController.DetermineUserRank(_rank:  val_37, _battlePoints:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_39.currentCryptoKey, hiddenValue = val_39.hiddenValue, fakeValue = val_39.fakeValue, inited = val_39.inited}));
        object[] val_42 = new object[2];
        val_42[0] = val_37;
        val_42[1] = val_41;
        UnityEngine.Debug.LogFormat(format:  "Ranking Constraints: {0} - New Rank: {1}", args:  val_42);
        val_73 = null;
        if(val_41 < (DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  val_3).BPRank))
        {
                val_74 = null;
            DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  val_3).BPRank = val_41;
            object[] val_46 = new object[1];
            val_46[0] = DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  val_3).BPRank;
            UnityEngine.Debug.LogFormat(format:  "UPDATED USER RANK: {0}", args:  val_46);
            NetworkUtils.SetImageSpriteWithSpriteSize(_i:  this.m_Data.RankImage, _s:  RankingCollection.GetRankSprite(rank:  DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  val_3).BPRank));
            this.m_ShowRank = true;
        }
        else
        {
                val_75 = null;
            if(val_41 == (DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  val_3).BPRank))
        {
                this.m_ShowRank = false;
        }
        
        }
        
        val_68 = 1152921511491540576;
        UnityEngine.Debug.LogFormat(format:  "#### START PDB", args:  System.Array.Empty<System.Object>());
        NetworkUICharacterInformationPanel val_55 = UnityEngine.Object.FindObjectOfType<NetworkUICharacterInformationPanel>();
        if(0 != val_55)
        {
                val_55.Setup();
        }
        
        val_76 = null;
        val_76 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_57 = DataStructs.UserDataDictionary.Stats.PlayerPoints;
        NetworkUICharacterInformationPanel.UpdatePP(_val:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_57.currentCryptoKey, hiddenValue = val_57.hiddenValue, fakeValue = val_57.fakeValue, inited = val_57.inited}));
        UnityEngine.Debug.LogFormat(format:  "#### END PDB 1", args:  System.Array.Empty<System.Object>());
        label_38:
        val_77 = null;
        val_77 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_60 = DataStructs.UserDataDictionary.Stats.PlayerPoints;
        this.m_Data.TotalPlayerPointsText.text = val_60.currentCryptoKey.ToString();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_63 = DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  val_3).Bp;
        this.m_Data.TotalBattlePointsText.text = val_63.currentCryptoKey.ToString();
        return;
        label_50:
        if(this.m_Data.DeductedPlayerPointsText != null)
        {
            goto label_124;
        }
        
        goto label_125;
        label_9:
    }
    public PostDisconnectionBehaviour()
    {
    
    }

}
