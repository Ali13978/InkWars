using UnityEngine;
public class AdventureBossRessurectionEffect : DynamicUISingleton<AdventureBossRessurectionEffect>
{
    // Fields
    private UnityEngine.ParticleSystem bubbleEffect;
    private UnityEngine.AudioClip effectSFX;
    
    // Methods
    public static void ShowAtPlayerSide(InkWars.Model.Player targetPlayer, DG.Tweening.TweenCallback onDone)
    {
        UnityEngine.Object val_5;
        DynamicUISingleton<AdventureBossRessurectionEffect>.Show();
        val_5 = DynamicUISingleton<AdventureBossRessurectionEffect>.instance;
        if(val_5 != null)
        {
                val_5 = 0;
        }
        
        if(0 == val_5)
        {
                return;
        }
        
        this.PlayEffectAtPlayer(targetPlayer:  targetPlayer, onDone:  onDone);
    }
    private void PlayEffectAtPlayer(InkWars.Model.Player targetPlayer, DG.Tweening.TweenCallback onDone)
    {
        AdventureBossRessurectionEffect.<>c__DisplayClass3_0 val_1 = new AdventureBossRessurectionEffect.<>c__DisplayClass3_0();
        .<>4__this = this;
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        .playerViewObj = View_Core.Instance.GetViewObjectsByPlayerId_Flip(aNewPlayerId:  targetPlayer);
        UnityEngine.Vector3 val_7 = (AdventureBossRessurectionEffect.<>c__DisplayClass3_0)[1152921528420388336].playerViewObj.ActiveBase.transform.position;
        this.bubbleEffect.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void AdventureBossRessurectionEffect.<>c__DisplayClass3_0::<PlayEffectAtPlayer>b__0()));
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.5f);
        .flashDuration = 0.08f;
        .flashLoop = UnityEngine.Mathf.RoundToInt(f:  62.5f);
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void AdventureBossRessurectionEffect.<>c__DisplayClass3_0::<PlayEffectAtPlayer>b__1()));
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  1f);
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void AdventureBossRessurectionEffect.<>c__DisplayClass3_0::<PlayEffectAtPlayer>b__2()));
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  1.5f);
        DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void AdventureBossRessurectionEffect.<>c__DisplayClass3_0::<PlayEffectAtPlayer>b__3()));
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  2.5f);
        if(onDone != null)
        {
                DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  onDone);
        }
        
        DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  0, method:  public static System.Void DynamicUISingleton<AdventureBossRessurectionEffect>::Hide()));
    }
    protected override void PlayShowAnim()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    protected override void PlayHideAnim()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public AdventureBossRessurectionEffect()
    {
    
    }

}
