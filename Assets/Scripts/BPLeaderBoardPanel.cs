using UnityEngine;
public class BPLeaderBoardPanel : MonoBehaviour
{
    // Fields
    public DataStructs.LeaderboardType leaderboardType;
    private LeaderBoardScrollView leaderboardView;
    private CharacterSelectScrollView charSelectionView;
    private UnityEngine.UI.Button allButton;
    private UnityEngine.UI.Button worldButton;
    private UnityEngine.UI.Button regionButton;
    private UnityEngine.GameObject loadingPanel;
    private bool enableOnEnable;
    
    // Methods
    private void Start()
    {
        this.OnWorldClick();
        this.OnEnable();
        this.OnAllClick();
        this.OnCharSelectionChanged(cid:  63);
    }
    private void OnEnable()
    {
        this.charSelectionView.selectDefaultAtStart = false;
        this.allButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BPLeaderBoardPanel::OnAllClick()));
        this.worldButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BPLeaderBoardPanel::OnWorldClick()));
        this.regionButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BPLeaderBoardPanel::OnRegionClick()));
        this.charSelectionView.OnSelectionChanged.AddListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  System.Void BPLeaderBoardPanel::OnCharSelectionChanged(CharacterNameID cid)));
    }
    private void OnDisable()
    {
        this.allButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BPLeaderBoardPanel::OnAllClick()));
        this.worldButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BPLeaderBoardPanel::OnWorldClick()));
        this.regionButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BPLeaderBoardPanel::OnRegionClick()));
        this.charSelectionView.OnSelectionChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  System.Void BPLeaderBoardPanel::OnCharSelectionChanged(CharacterNameID cid)));
    }
    private void OnAllClick()
    {
        this.charSelectionView.CancelSelection();
    }
    private void OnWorldClick()
    {
        mem[1152921528955063628] = 0;
        this.OnCharSelectionChanged(cid:  this.charSelectionView.selection);
        this.SetButtonAlpha(btn:  this.worldButton, alpha:  1f);
        this.SetButtonAlpha(btn:  this.regionButton, alpha:  0.5f);
    }
    private void OnRegionClick()
    {
        null = null;
        mem[1152921528955212492] = DataStructs.UserDataDictionary.Settings.Region;
        this.OnCharSelectionChanged(cid:  this.charSelectionView.selection);
        this.SetButtonAlpha(btn:  this.worldButton, alpha:  0.5f);
        this.SetButtonAlpha(btn:  this.regionButton, alpha:  1f);
    }
    private void SetButtonAlpha(UnityEngine.UI.Button btn, float alpha)
    {
        UnityEngine.CanvasGroup val_1 = btn.GetComponent<UnityEngine.CanvasGroup>();
        if(0 == val_1)
        {
                return;
        }
        
        val_1.alpha = alpha;
    }
    private void OnCharSelectionChanged(CharacterNameID cid)
    {
        if(this.enableOnEnable == false)
        {
                return;
        }
        
        if(this.loadingPanel.gameObject.activeInHierarchy != false)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = this.loadingPanel.gameObject;
        val_3.SetActive(value:  true);
        mem[1152921528955493840] = cid;
        val_3.FetchLeaderboardData(type:  new DataStructs.LeaderboardType() {scoreType = this.leaderboardType, region = this.leaderboardType, character = this.leaderboardType});
    }
    private void FetchLeaderboardData(DataStructs.LeaderboardType type)
    {
        System.Runtime.CompilerServices.AsyncVoidMethodBuilder val_1 = System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Create();
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
            .rank = RankingCollection.GetRankByBP(bp:  (DataStructs.LeaderBoardItemData)[1152921528955914352].score);
            val_1.Add(item:  val_4);
        }
        while(val_13 != 300);
        
        return val_1;
    }
    public void Reposition()
    {
        if(this.enableOnEnable != true)
        {
                this.enableOnEnable = true;
            this.OnCharSelectionChanged(cid:  63);
        }
        
        this.leaderboardView.Reposition();
    }
    public BPLeaderBoardPanel()
    {
        this.leaderboardType = 0;
        mem[1152921528956135056] = 0;
    }

}
