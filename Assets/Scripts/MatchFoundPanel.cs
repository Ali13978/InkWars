using UnityEngine;
public class MatchFoundPanel : MonoBehaviour
{
    // Fields
    public TMPro.TextMeshProUGUI ChallengeDialogPlayerPoints;
    public TMPro.TextMeshProUGUI ChallengeDialogPlayerWins;
    public TMPro.TextMeshProUGUI ChallengeDialogPlayerLosses;
    public TMPro.TextMeshProUGUI ChallengeDialogPlayerDraws;
    public UnityEngine.UI.Image ChallengeDialogFlag;
    public UnityEngine.UI.Image ChallengeDialogAvatar;
    public CustomTitle ChallengeDialogueTitle;
    
    // Methods
    public void SetUp(NetworkUserInfo sharedPlayerData)
    {
        this.ChallengeDialogPlayerPoints.text = sharedPlayerData.playerPoint.ToString();
        this.ChallengeDialogPlayerWins.text = sharedPlayerData.win.ToString();
        this.ChallengeDialogPlayerLosses.text = sharedPlayerData.lose.ToString();
        this.ChallengeDialogPlayerDraws.text = sharedPlayerData.draw.ToString();
        this.ChallengeDialogFlag.sprite = NetworkUtils.GetCountry(_flag:  sharedPlayerData.flag);
        this.ChallengeDialogAvatar.sprite = AvatarCollection.GetAvatarSpriteFromIntId(id:  sharedPlayerData.avatarID);
        this.ChallengeDialogueTitle.Setup(title:  TitleCollection.GetTitleFromIntId(id:  sharedPlayerData.titleID));
    }
    public MatchFoundPanel()
    {
    
    }

}
