using UnityEngine;
public class RankUpAnimation : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image rankImg;
    private System.Collections.Generic.List<UnityEngine.RectTransform> rankUpObjectList;
    private System.Collections.Generic.List<UnityEngine.RectTransform> rankDownObjectList;
    private UnityEngine.AudioClip rankUpSFX;
    private UnityEngine.AudioClip rankDownSFX;
    private DG.Tweening.Sequence anim;
    
    // Methods
    private void OnEnable()
    {
        this.rankImg.sprite = RankingCollection.GetRankSprite(rank:  RankingController.OriginalRank);
        this.rankImg.InitObjList(list:  this.rankUpObjectList);
        this.rankImg.InitObjList(list:  this.rankDownObjectList);
    }
    private void OnDisable()
    {
        if(this.anim != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.anim, complete:  false);
        }
        
        this.anim.InitObjList(list:  this.rankUpObjectList);
        this.anim.InitObjList(list:  this.rankDownObjectList);
    }
    public DG.Tweening.Sequence CreateRankChangeAnimation()
    {
        RankUpAnimation.<>c__DisplayClass8_0 val_1 = new RankUpAnimation.<>c__DisplayClass8_0();
        .<>4__this = this;
        if(this.anim != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.anim, complete:  false);
        }
        
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        this.anim = val_2;
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  val_2, isIndependentUpdate:  true);
        if(RankingController.OriginalRank == RankingController.NewRank)
        {
                return (DG.Tweening.Sequence)this.anim;
        }
        
        .rankUp = (RankingController.NewRank > RankingController.OriginalRank) ? 1 : 0;
        .objList = (RankingController.NewRank > RankingController.OriginalRank) ? this.rankUpObjectList : this.rankDownObjectList;
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.anim, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RankUpAnimation.<>c__DisplayClass8_0::<CreateRankChangeAnimation>b__0()));
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.anim, interval:  0.05f);
        UnityEngine.RectTransform val_9 = this.rankImg.GetComponent<UnityEngine.RectTransform>();
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.anim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOShakeAnchorPos(target:  val_9, duration:  1f, strength:  10f, vibrato:  30, randomness:  90f, snapping:  false, fadeOut:  false), ease:  20));
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.anim, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RankUpAnimation.<>c__DisplayClass8_0::<CreateRankChangeAnimation>b__1()));
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  8f);
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.anim, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_9, endValue:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, duration:  0.01f));
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.anim, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RankUpAnimation.<>c__DisplayClass8_0::<CreateRankChangeAnimation>b__2()));
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.one;
        DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.anim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_9, endValue:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, duration:  1f), ease:  30));
        if(((RankUpAnimation.<>c__DisplayClass8_0)[1152921528695623440].rankUp) == true)
        {
                return (DG.Tweening.Sequence)this.anim;
        }
        
        DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.anim, interval:  2f);
        return (DG.Tweening.Sequence)this.anim;
    }
    private void InitObjList(System.Collections.Generic.List<UnityEngine.RectTransform> list)
    {
        var val_6;
        var val_7;
        System.Predicate<UnityEngine.RectTransform> val_9;
        val_6 = list;
        if(val_6 == null)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        val_9 = RankUpAnimation.<>c.<>9__9_0;
        if(val_9 == null)
        {
                System.Predicate<UnityEngine.RectTransform> val_1 = null;
            val_9 = val_1;
            val_1 = new System.Predicate<UnityEngine.RectTransform>(object:  RankUpAnimation.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean RankUpAnimation.<>c::<InitObjList>b__9_0(UnityEngine.RectTransform x));
            RankUpAnimation.<>c.<>9__9_0 = val_9;
        }
        
        int val_2 = val_6.RemoveAll(match:  val_1);
        List.Enumerator<T> val_3 = val_6.GetEnumerator();
        label_10:
        if(((-1680815000) & 1) == 0)
        {
            goto label_7;
        }
        
        0.InitialType.gameObject.SetActive(value:  false);
        goto label_10;
        label_7:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.RectTransform>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<UnityEngine.RectTransform>::RemoveAll(System.Predicate<T> match), drivenProperties:  public System.Void System.Predicate<UnityEngine.RectTransform>::.ctor(object object, IntPtr method));
    }
    public RankUpAnimation()
    {
        this.rankUpObjectList = new System.Collections.Generic.List<UnityEngine.RectTransform>();
        this.rankDownObjectList = new System.Collections.Generic.List<UnityEngine.RectTransform>();
    }

}
