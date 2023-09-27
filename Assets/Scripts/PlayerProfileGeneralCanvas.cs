using UnityEngine;
public class PlayerProfileGeneralCanvas : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image m_avatar;
    private UnityEngine.UI.Text m_userName;
    private TMPro.TextMeshProUGUI m_wins;
    private TMPro.TextMeshProUGUI m_loose;
    private TMPro.TextMeshProUGUI m_draw;
    private TMPro.TextMeshProUGUI m_PPCount;
    private UnityEngine.UI.Image m_flag;
    private TMPro.TextMeshProUGUI m_currentStreak;
    private TMPro.TextMeshProUGUI m_highScore;
    private TMPro.TextMeshProUGUI m_BestBattlePoints;
    private TMPro.TextMeshProUGUI m_BPToNextRank;
    private TMPro.TextMeshProUGUI m_BPToNextRankText;
    private UnityEngine.UI.Image m_rank;
    private UnityEngine.UI.Image m_bestCharacter;
    
    // Methods
    private void OnEnable()
    {
        var val_46;
        var val_47;
        float val_52;
        float val_53;
        var val_54;
        val_46 = null;
        val_46 = null;
        string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  DataStructs.UserDataDictionary.Settings.UserName);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Stats.PlayerPoints;
        this.m_PPCount.text = val_3.currentCryptoKey.ToString();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Stats.AllTimeHighScore;
        this.m_highScore.text = val_5.currentCryptoKey.ToString();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = DataStructs.UserDataDictionary.Stats.WinStreak_Current;
        this.m_currentStreak.text = val_7.currentCryptoKey.ToString();
        DataStructs.CharacterStats val_9 = DataStructs.UserDataDictionary.Stats.GetHighestRank();
        if(val_9 != null)
        {
                val_47 = val_9.characterName;
        }
        else
        {
                val_47 = 0.characterName;
        }
        
        if(val_9.characterName == 999999)
        {
            goto label_16;
        }
        
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_13 = val_9.Bp;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_13.currentCryptoKey, hiddenValue = val_13.hiddenValue, fakeValue = val_13.fakeValue, inited = val_13.inited})) != 0)
        {
            goto label_20;
        }
        
        label_16:
        val_47 = 20;
        label_20:
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_15 = val_9.Bp;
        int val_17 = RankingCollection.BPtoNextRank(currentBP:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_15.currentCryptoKey, hiddenValue = val_15.hiddenValue, fakeValue = val_15.fakeValue, inited = val_15.inited}));
        UnityEngine.GameObject val_18 = this.m_BPToNextRank.gameObject;
        if(val_17 != 1)
        {
                val_18.SetActive(value:  true);
            this.m_BPToNextRankText.text = LanguageManager.GetText(key:  "LK.Profile.General.TillNextRank");
            this.m_BPToNextRank.text = val_17.ToString();
            UnityEngine.Vector2 val_22 = this.m_BPToNextRankText.GetComponent<UnityEngine.RectTransform>().anchoredPosition;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
            UnityEngine.RectTransform val_24 = this.m_BPToNextRankText.GetComponent<UnityEngine.RectTransform>();
            val_52 = val_23.x;
            val_53 = val_23.y;
        }
        else
        {
                val_18.SetActive(value:  false);
            this.m_BPToNextRankText.text = LanguageManager.GetText(key:  "LK.Profile.General.MaxRankReached");
            UnityEngine.Vector2 val_27 = this.m_BPToNextRankText.GetComponent<UnityEngine.RectTransform>().anchoredPosition;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y});
            val_52 = val_28.x;
            val_53 = val_28.y;
        }
        
        UnityEngine.Vector2 val_30 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_52, y = val_53, z = val_28.z});
        this.m_BPToNextRankText.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_30.x, y = val_30.y};
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_31 = val_9.Bp;
        this.m_BestBattlePoints.text = val_31.currentCryptoKey.ToString();
        this.m_rank.sprite = RankingCollection.GetRankSprite(rank:  val_9.BPRank);
        CharacterAssetLoader.Get(id:  20, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  this, method:  System.Void PlayerProfileGeneralCanvas::<OnEnable>b__14_0(CharacterAssetLoader loader)));
        val_54 = null;
        val_54 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_36 = DataStructs.UserDataDictionary.Stats.NetworkWins;
        this.m_wins.text = val_36.currentCryptoKey.ToString();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_38 = DataStructs.UserDataDictionary.Stats.NetworkLoses;
        this.m_loose.text = val_38.currentCryptoKey.ToString();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_40 = DataStructs.UserDataDictionary.Stats.NetworkDraws;
        this.m_draw.text = val_40.currentCryptoKey.ToString();
        this.m_flag.sprite = NetworkUtils.GetCountry(_flag:  DataStructs.UserDataDictionary.Settings.UserFlag);
        DataStructs.UserDataDictionary.OnUserDataChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String, System.Object>(object:  this, method:  System.Void PlayerProfileGeneralCanvas::OnUserDataChanged(string key, object value)));
        DataStructs.UserDataDictionary.OnUserDataChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.String, System.Object>(object:  this, method:  System.Void PlayerProfileGeneralCanvas::OnUserDataChanged(string key, object value)));
    }
    private void OnDisable()
    {
        null = null;
        DataStructs.UserDataDictionary.OnUserDataChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String, System.Object>(object:  this, method:  System.Void PlayerProfileGeneralCanvas::OnUserDataChanged(string key, object value)));
    }
    private void OnUserDataChanged(string key, object value)
    {
        this.OnEnable();
    }
    public PlayerProfileGeneralCanvas()
    {
    
    }
    private void <OnEnable>b__14_0(CharacterAssetLoader loader)
    {
        this.m_bestCharacter.sprite = loader.LoadPoseCollection().GetPose(result:  1, isLocalPlayer:  true, isDraw2KoSame:  false);
    }

}
