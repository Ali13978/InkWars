using UnityEngine;
public class PostMatchPvPWinStarAnimationController : MonoBehaviour
{
    // Fields
    private SeventyOneSquared.PDUnity starAnim1;
    private SeventyOneSquared.PDUnity starAnim2;
    public UnityEngine.Camera renderCamera;
    
    // Methods
    public void PlayAnimation(UnityEngine.Vector3 worldPosition)
    {
        DG.Tweening.TweenCallback val_20;
        var val_21;
        var val_22;
        SeventyOneSquared.PDUnity val_23;
        if(0 != UnityEngine.Camera.main)
        {
                this.renderCamera.orthographicSize = UnityEngine.Camera.main.orthographicSize;
        }
        
        val_20 = 1152921505143427072;
        val_21 = null;
        val_21 = null;
        if(0 == WinStarAnimation3D.instance)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        if(WinStarAnimation3D.instance == null)
        {
                val_22 = null;
        }
        
        val_23 = mem[WinStarAnimation3D.instance + 24];
        val_23 = WinStarAnimation3D.instance.starAnim1;
        this.starAnim1 = val_23;
        if(WinStarAnimation3D.instance == null)
        {
                val_23 = this.starAnim1;
        }
        
        this.starAnim2 = WinStarAnimation3D.instance.starAnim2;
        UnityEngine.Vector3 val_7 = val_23.transform.position;
        this.starAnim1.transform.position = new UnityEngine.Vector3() {x = worldPosition.x, y = worldPosition.y, z = val_7.z};
        this.starAnim2.transform.position = new UnityEngine.Vector3() {x = worldPosition.x, y = worldPosition.y, z = val_7.z};
        UnityEngine.Vector3 val_11 = this.starAnim1.transform.position;
        UnityEngine.Debug.Log(message:  val_11.z.ToString());
        DG.Tweening.Sequence val_13 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  val_13, isIndependentUpdate:  true);
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_13, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void PostMatchPvPWinStarAnimationController::<PlayAnimation>b__3_0()));
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_13, interval:  0.5f);
        DG.Tweening.TweenCallback val_18 = null;
        val_20 = val_18;
        val_18 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void PostMatchPvPWinStarAnimationController::<PlayAnimation>b__3_1());
        DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_13, callback:  val_18);
    }
    public PostMatchPvPWinStarAnimationController()
    {
    
    }
    private void <PlayAnimation>b__3_0()
    {
        this.starAnim1.Running = true;
    }
    private void <PlayAnimation>b__3_1()
    {
        this.starAnim2.Running = true;
    }

}
