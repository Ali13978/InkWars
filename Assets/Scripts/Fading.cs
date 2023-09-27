using UnityEngine;
public class Fading : MonoBehaviour
{
    // Fields
    public UnityEngine.Texture2D fadeOutTexture;
    public float fadeSpeed;
    private int drawDepth;
    public float alpha;
    private int fadeDir;
    private static System.Collections.Generic.List<Fading> allInstances;
    private static string ignoreFadeSceneName;
    
    // Properties
    public bool isFading { get; }
    public static bool isAnyFading { get; }
    
    // Methods
    public bool get_isFading()
    {
        return (bool)((this.alpha > 0.0001f) ? 1 : 0) & ((this.alpha < 0) ? 1 : 0);
    }
    public static bool get_isAnyFading()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        List.Enumerator<T> val_1 = Fading.allInstances.GetEnumerator();
        label_7:
        if(((-2135409512) & 1) == 0)
        {
            goto label_4;
        }
        
        System.Type val_2 = 0.InitialType;
        if((S0 <= 0.0001f) || (S0 >= 0))
        {
            goto label_7;
        }
        
        val_4 = 1;
        goto label_8;
        label_4:
        val_4 = 0;
        label_8:
        0.Add(driver:  public System.Void List.Enumerator<Fading>::Dispose(), rectTransform:  null, drivenProperties:  null);
        return (bool);
    }
    public static void StopFadeInScene(string name)
    {
        null = null;
        Fading.ignoreFadeSceneName = name;
    }
    public System.Collections.IEnumerator Start()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new Fading.<Start>d__12();
    }
    private void OnDestroy()
    {
        null = null;
        bool val_1 = Fading.allInstances.Remove(item:  this);
    }
    private void OnGUI()
    {
        float val_9 = this.fadeSpeed;
        float val_1 = UnityEngine.Time.deltaTime;
        float val_8 = (float)this.fadeDir;
        val_8 = val_9 * val_8;
        val_1 = val_8 * val_1;
        val_9 = this.alpha + val_1;
        this.alpha = val_9;
        this.alpha = UnityEngine.Mathf.Clamp01(value:  val_9);
        UnityEngine.Color val_3 = UnityEngine.GUI.color;
        UnityEngine.Color val_4 = UnityEngine.GUI.color;
        UnityEngine.Color val_5 = UnityEngine.GUI.color;
        UnityEngine.GUI.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        UnityEngine.GUI.depth = this.drawDepth;
        int val_6 = UnityEngine.Screen.width;
        int val_7 = UnityEngine.Screen.height;
        UnityEngine.GUI.DrawTexture(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, image:  this.fadeOutTexture);
    }
    public float BeginFade(int direction)
    {
        this.fadeDir = direction;
        return (float)this.fadeSpeed;
    }
    public void StopFade()
    {
        this.alpha = 0f;
        this.fadeDir = 0;
    }
    public Fading()
    {
        this.fadeSpeed = 0.7976562f;
        this.drawDepth = 64536;
        this.alpha = 1f;
    }
    private static Fading()
    {
        Fading.allInstances = new System.Collections.Generic.List<Fading>();
    }

}
