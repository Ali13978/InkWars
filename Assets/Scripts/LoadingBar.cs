using UnityEngine;
public class LoadingBar : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform loadingBar;
    private UnityEngine.UI.Image filledLoadingImage;
    public float percent;
    public float pixelMaxVelocity;
    private float tolerance;
    private float maxWidth;
    private UnityEngine.Vector2 targetDimensions;
    private float lastSeenPercentage;
    
    // Properties
    public float animatedPercentage { get; }
    
    // Methods
    public float get_animatedPercentage()
    {
        UnityEngine.Vector2 val_1 = this.loadingBar.sizeDelta;
        val_1.x = val_1.x / this.maxWidth;
        val_1.x = val_1.x * 100f;
        float val_2 = UnityEngine.Mathf.Clamp(value:  val_1.x, min:  0f, max:  100f);
        val_2 = ((System.Single.IsNaN(f:  val_2)) != true) ? 0f : (val_2);
        return (float)val_2;
    }
    private void OnEnable()
    {
        UnityEngine.Rect val_3 = this.gameObject.GetComponent<UnityEngine.RectTransform>().rect;
        this.maxWidth = val_3.m_XMin;
        UnityEngine.Vector2 val_4 = this.GetPercentToVector2(percent:  this.percent);
        this.loadingBar.sizeDelta = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.Animate());
    }
    private void OnDisable()
    {
        this.StopCoroutine(routine:  this.Animate());
    }
    public void SetActive(bool yes)
    {
        this.gameObject.SetActive(value:  yes);
    }
    private System.Collections.IEnumerator Animate()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LoadingBar.<Animate>d__13();
    }
    public void setWidth(int percent)
    {
        UnityEngine.Vector2 val_1 = this.GetPercentToVector2(percent:  (float)percent);
        this.loadingBar.sizeDelta = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    private bool AlmostSame(UnityEngine.Vector2 a, UnityEngine.Vector2 b)
    {
        return (bool)((System.Math.Abs(a.x - b.x)) < 0) ? 1 : 0;
    }
    private UnityEngine.Vector2 GetPercentToVector2(float percent)
    {
        UnityEngine.Vector2 val_1 = this.loadingBar.sizeDelta;
        float val_4 = 100f;
        val_4 = (this.maxWidth * percent) / val_4;
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_4, y:  val_1.y);
        return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
    }
    public LoadingBar()
    {
        this.percent = 10f;
        this.pixelMaxVelocity = 10f;
        this.tolerance = 5f;
    }

}
