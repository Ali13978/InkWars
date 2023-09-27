using UnityEngine;
public class UserInfoPanel : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image avatar;
    private UnityEngine.UI.Text nameTxt;
    private TMPro.TextMeshProUGUI ppTxt;
    private TMPro.TextMeshProUGUI highScoreTxt;
    private TMPro.TextMeshProUGUI winCount;
    private TMPro.TextMeshProUGUI loseCount;
    private TMPro.TextMeshProUGUI drawCount;
    private CustomTitle title;
    private PlayerType playerType;
    
    // Methods
    public void Setup(NetworkUserInfo data)
    {
        this.ppTxt.text = data.playerPoint.ToString();
        if(0 != this.winCount)
        {
                this.winCount.text = data.win.ToString();
        }
        
        if(0 != this.loseCount)
        {
                this.loseCount.text = data.lose.ToString();
        }
        
        if(0 == this.drawCount)
        {
                return;
        }
        
        this.drawCount.text = data.draw.ToString();
    }
    private void SetBasicInfo(NetworkUserInfo data)
    {
        CustomTitle val_5;
        this.avatar.sprite = AvatarCollection.GetAvatarSpriteFromIntId(id:  data.avatarID);
        Utility.SetBoldTextWithBlackOutline(txtObj:  this.nameTxt);
        val_5 = this.title;
        if(0 != val_5)
        {
                val_5 = this.title;
            val_5.Setup(title:  TitleCollection.GetTitleFromIntId(id:  data.titleID));
        }
        
        this.highScoreTxt.text = data.allTimeHighScore.ToString();
    }
    private void OnEnable()
    {
        if(this.playerType != 0)
        {
                this.Setup(data:  CloudOpponent.current);
            NetworkUserInfo val_2 = CloudOpponent.current;
        }
        
        this.SetBasicInfo(data:  DataStructs.UserDataDictionary.ToNetworkUserInfo());
    }
    private void OnDisable()
    {
    
    }
    public DG.Tweening.Sequence PlayHighScoreAnim(int prevHighScore, int highScore)
    {
        UserInfoPanel.<>c__DisplayClass13_0 val_1 = new UserInfoPanel.<>c__DisplayClass13_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .highScore = highScore;
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        .rt = this.highScoreTxt.GetComponent<UnityEngine.RectTransform>();
        this.highScoreTxt.text = prevHighScore.ToString();
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  3f);
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (UserInfoPanel.<>c__DisplayClass13_0)[1152921528263349648].rt, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.5f), ease:  27));
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions.DOShakePosition(target:  (UserInfoPanel.<>c__DisplayClass13_0)[1152921528263349648].rt, duration:  0.5f, strength:  10f, vibrato:  30, randomness:  90f, snapping:  false, fadeOut:  false));
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void UserInfoPanel.<>c__DisplayClass13_0::<PlayHighScoreAnim>b__0()));
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  1.5f);
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (UserInfoPanel.<>c__DisplayClass13_0)[1152921528263349648].rt, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  0.5f), ease:  30));
        return val_2;
    }
    public UserInfoPanel()
    {
    
    }

}
