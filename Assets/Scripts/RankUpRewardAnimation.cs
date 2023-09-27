using UnityEngine;
public class RankUpRewardAnimation : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform countPanel;
    private UnityEngine.RectTransform shellPanel;
    private TMPro.TextMeshProUGUI countTxt;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.countPanel.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.shellPanel.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    public DG.Tweening.Sequence PlayRankRewardAnim()
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  val_1, isIndependentUpdate:  true);
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.1f);
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void RankUpRewardAnimation::<PlayRankRewardAnim>b__4_0()));
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  0, method:  public static System.Void GameAudio::PlayPurchaseSound()));
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.shellPanel, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  0.5f), ease:  27));
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.countPanel, endValue:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, duration:  0.5f), ease:  27));
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  2f);
        return val_1;
    }
    public RankUpRewardAnimation()
    {
    
    }
    private void <PlayRankRewardAnim>b__4_0()
    {
        RankingConstraints val_1 = RankingCollection.Get(rank:  RankingController.NewRank);
        this.countTxt.text = val_1.m_Shells.ToString();
    }

}
