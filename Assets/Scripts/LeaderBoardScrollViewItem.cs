using UnityEngine;
public class LeaderBoardScrollViewItem : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image rankImage;
    private TMPro.TextMeshProUGUI rankNumTxt;
    private UnityEngine.UI.Text nameTxt;
    private UnityEngine.UI.Image flagImage;
    private CharacterAvatarController avatarController;
    private TMPro.TextMeshProUGUI bpTxt;
    private UnityEngine.CanvasGroup canvasGroup;
    
    // Methods
    public void Setup(ILeaderBoardResponse data, int place)
    {
        CharacterAvatarController val_13;
        string val_14;
        val_13 = this.gameObject;
        val_13.SetActive(value:  (data != 0) ? 1 : 0);
        if(data != null)
        {
                bool val_4 = System.Enum.TryParse<CharacterNameID>(value:  data.character, result: out  999999);
            bool val_6 = System.Enum.TryParse<DataStructs.Flag>(value:  data.flag, result: out  125);
            DataStructs.PlayerRank val_7 = 1;
            bool val_8 = System.Enum.TryParse<DataStructs.PlayerRank>(value:  data.rank, result: out  val_7);
            this.canvasGroup.alpha = 1f;
            this.rankImage.sprite = RankingCollection.GetRankSpriteSmall(rank:  val_7);
            this.rankNumTxt.text = 0.ToString();
            this.flagImage.sprite = NetworkUtils.GetCountry(_flag:  125);
            val_13 = this.avatarController;
            val_13.Init(cid:  63, aNewMaskType:  0, reloadAvatar:  true, isFaceLeft:  false);
            val_14 = data.bp.ToString();
            this.bpTxt.text = val_14;
            return;
        }
        
        val_14 = this.canvasGroup;
        val_14.alpha = 0f;
    }
    public LeaderBoardScrollViewItem()
    {
    
    }

}
