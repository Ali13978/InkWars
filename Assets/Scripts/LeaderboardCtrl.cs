using UnityEngine;
public class LeaderboardCtrl : MonoBehaviour
{
    // Fields
    public DataStructs.LeaderboardType initType;
    public bool loadAtStart;
    private bool <isFetchingData>k__BackingField;
    private LeaderBoardScrollView leaderboardView;
    private CharacterSelectScrollView charSelectionView;
    private UnityEngine.UI.Button allButton;
    private UnityEngine.UI.Toggle worldButton;
    private UnityEngine.UI.Toggle regionButton;
    private UnityEngine.GameObject loadingPanel;
    private DataStructs.LeaderboardType currentType;
    private bool enableFetchData;
    
    // Properties
    public bool isFetchingData { get; set; }
    
    // Methods
    public bool get_isFetchingData()
    {
        return (bool)this.<isFetchingData>k__BackingField;
    }
    protected void set_isFetchingData(bool value)
    {
        this.<isFetchingData>k__BackingField = value;
    }
    private void Awake()
    {
        this.currentType = this.initType;
        mem[1152921528956815312] = ???;
    }
    private void Start()
    {
        this.OnWorldClick(isOn:  (W8 == 0) ? 1 : 0);
        bool val_2 = (W8 != 0) ? 1 : 0;
        this.OnRegionClick(isOn:  val_2);
        this.OnCharSelectionChanged(cid:  val_2);
        this.enableFetchData = true;
        if(this.loadAtStart == false)
        {
                return;
        }
        
        this.FetchLeaderboardData(type:  new DataStructs.LeaderboardType() {scoreType = this.currentType, region = this.currentType, character = this.currentType});
    }
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction<T0> val_11;
        if(0 != this.charSelectionView)
        {
                this.charSelectionView.selectDefaultAtStart = false;
            UnityEngine.Events.UnityAction<System.Int32Enum> val_2 = null;
            val_11 = val_2;
            val_2 = new UnityEngine.Events.UnityAction<System.Int32Enum>(object:  this, method:  System.Void LeaderboardCtrl::OnCharSelectionChanged(CharacterNameID cid));
            this.charSelectionView.OnSelectionChanged.AddListener(call:  val_2);
        }
        
        if(0 != this.allButton)
        {
                UnityEngine.Events.UnityAction val_5 = null;
            val_11 = val_5;
            val_5 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LeaderboardCtrl::OnAllClick());
            this.allButton.onClick.AddListener(call:  val_5);
        }
        
        if(0 != this.worldButton)
        {
                UnityEngine.Events.UnityAction<System.Boolean> val_7 = null;
            val_11 = val_7;
            val_7 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void LeaderboardCtrl::OnWorldClick(bool isOn));
            this.worldButton.onValueChanged.AddListener(call:  val_7);
        }
        
        if(0 != this.regionButton)
        {
                UnityEngine.Events.UnityAction<System.Boolean> val_9 = null;
            val_11 = val_9;
            val_9 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void LeaderboardCtrl::OnRegionClick(bool isOn));
            this.regionButton.onValueChanged.AddListener(call:  val_9);
        }
        
        if(0 == this.loadingPanel)
        {
                return;
        }
        
        this.loadingPanel.SetActive(value:  false);
    }
    private void OnDisable()
    {
        UnityEngine.Events.UnityAction val_10;
        if(0 != this.allButton)
        {
                UnityEngine.Events.UnityAction val_3 = null;
            val_10 = val_3;
            val_3 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LeaderboardCtrl::OnAllClick());
            this.allButton.onClick.RemoveListener(call:  val_3);
        }
        
        if(0 != this.worldButton)
        {
                UnityEngine.Events.UnityAction<System.Boolean> val_5 = null;
            val_10 = val_5;
            val_5 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void LeaderboardCtrl::OnWorldClick(bool isOn));
            this.worldButton.onValueChanged.RemoveListener(call:  val_5);
        }
        
        if(0 != this.regionButton)
        {
                UnityEngine.Events.UnityAction<System.Boolean> val_7 = null;
            val_10 = val_7;
            val_7 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void LeaderboardCtrl::OnRegionClick(bool isOn));
            this.regionButton.onValueChanged.RemoveListener(call:  val_7);
        }
        
        if(0 == this.charSelectionView)
        {
                return;
        }
        
        this.charSelectionView.OnSelectionChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  System.Void LeaderboardCtrl::OnCharSelectionChanged(CharacterNameID cid)));
    }
    private void OnAllClick()
    {
        if(0 != this.charSelectionView)
        {
                this.charSelectionView.CancelSelection();
        }
        
        mem[1152921528957562320] = 999999;
        if(this.enableFetchData == false)
        {
                return;
        }
        
        this.FetchLeaderboardData(type:  new DataStructs.LeaderboardType() {scoreType = this.currentType, region = this.currentType, character = this.currentType});
    }
    private void OnWorldClick(bool isOn)
    {
        if(isOn == false)
        {
                return;
        }
        
        if(0 != this.worldButton)
        {
                if(this.worldButton.isOn == false)
        {
            goto label_6;
        }
        
        }
        
        GameAudio.PlayButtonSound();
        mem[1152921528957694796] = 0;
        if(this.enableFetchData == false)
        {
                return;
        }
        
        this.FetchLeaderboardData(type:  new DataStructs.LeaderboardType() {scoreType = this.currentType, region = this.currentType, character = this.currentType});
        return;
        label_6:
        this.worldButton.isOn = true;
    }
    private void OnRegionClick(bool isOn)
    {
        var val_4;
        if(isOn == false)
        {
                return;
        }
        
        if(0 != this.regionButton)
        {
                if(this.regionButton.isOn == false)
        {
            goto label_6;
        }
        
        }
        
        GameAudio.PlayButtonSound();
        val_4 = null;
        val_4 = null;
        mem[1152921528957835468] = DataStructs.UserDataDictionary.Settings.Region;
        if(this.enableFetchData == false)
        {
                return;
        }
        
        this.FetchLeaderboardData(type:  new DataStructs.LeaderboardType() {scoreType = this.currentType, region = this.currentType, character = this.currentType});
        return;
        label_6:
        this.regionButton.isOn = true;
    }
    private void OnCharSelectionChanged(CharacterNameID cid)
    {
        if(0 != this.charSelectionView)
        {
                if(this.charSelectionView.selection != cid)
        {
            goto label_5;
        }
        
        }
        
        GameAudio.PlayButtonSound();
        mem[1152921528957984336] = cid;
        if(this.enableFetchData == false)
        {
                return;
        }
        
        this.FetchLeaderboardData(type:  new DataStructs.LeaderboardType() {scoreType = this.currentType, region = this.currentType, character = this.currentType});
        return;
        label_5:
        this.charSelectionView.selection = cid;
    }
    private void UpdateLeaderboard()
    {
        if(this.enableFetchData == false)
        {
                return;
        }
        
        this.FetchLeaderboardData(type:  new DataStructs.LeaderboardType() {scoreType = this.currentType, region = this.currentType, character = this.currentType});
    }
    private void FetchLeaderboardData(DataStructs.LeaderboardType type)
    {
        System.Runtime.CompilerServices.AsyncVoidMethodBuilder val_1 = System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Create();
    }
    private void ShowLoading(bool enable)
    {
        if(0 == this.loadingPanel)
        {
                return;
        }
        
        this.loadingPanel.SetActive(value:  enable);
    }
    private System.Collections.Generic.List<DataStructs.LeaderBoardItemData> GetFakeData(CharacterNameID cid, DataStructs.LeaderboardType type)
    {
        CharacterNameID val_10;
        var val_11;
        var val_12;
        System.Collections.Generic.List<DataStructs.LeaderBoardItemData> val_1 = new System.Collections.Generic.List<DataStructs.LeaderBoardItemData>();
        int val_13 = 0;
        var val_2 = (0 == 0) ? 0 : 33;
        do
        {
            val_10 = cid;
            if(cid == 999999)
        {
                do
        {
            val_10 = 0;
        }
        while((CharacterHelper.IsHidden(cid:  val_10)) == true);
        
        }
        
            DataStructs.LeaderBoardItemData val_4 = new DataStructs.LeaderBoardItemData();
            var val_5 = 30000 + (val_13 * 299);
            if(val_4 != null)
        {
                var val_11 = val_2;
            val_11 = val_5 - val_11;
            .score = (long)val_11;
        }
        else
        {
                var val_12 = val_2;
            val_12 = val_5 - val_12;
            .score = (long)val_12;
        }
        
            val_13 = val_13 + 1;
            .leaderboardPlacing = val_13;
            string val_7 = "Ink Wars Player " + val_13.ToString();
            if(val_4 != null)
        {
                .username = val_7;
        }
        else
        {
                mem[24] = val_7;
        }
        
            .character = val_10;
            if(==0)
        {
                val_11 = 1;
            int val_8 = UnityEngine.Random.Range(min:  1, max:  195);
        }
        else
        {
                val_12 = null;
            val_12 = null;
        }
        
            .flag = DataStructs.UserDataDictionary.Settings.UserFlag;
            .rank = RankingCollection.GetRankByBP(bp:  (DataStructs.LeaderBoardItemData)[1152921528958645168].score);
            val_1.Add(item:  val_4);
        }
        while(val_13 != 300);
        
        return val_1;
    }
    public void Reposition()
    {
        this.leaderboardView.Reposition();
    }
    public LeaderboardCtrl()
    {
        this.loadAtStart = true;
        this.initType = 0;
        mem[1152921528958865872] = 0;
        this.currentType = 0;
        mem[1152921528958865936] = 0;
    }
    private void <FetchLeaderboardData>b__23_0(IResponse response)
    {
        this.<isFetchingData>k__BackingField = false;
        this.ShowLoading(enable:  false);
        this.leaderboardView.Init(source:  new System.Collections.Generic.List<ILeaderBoardResponse>(collection:  Newtonsoft.Json.JsonConvert.DeserializeObject<ILeaderBoardResponse[]>(value:  response.msg)));
    }

}
