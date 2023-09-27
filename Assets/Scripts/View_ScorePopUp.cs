using UnityEngine;
public class View_ScorePopUp : MonoBehaviour
{
    // Fields
    public TMPro.TextMeshPro TextMesh;
    public UnityEngine.Color Color_Positive;
    public UnityEngine.Color Color_Negative;
    private View_Objects Player_ScoreTarget;
    private int Score;
    private HitComboType ComboType;
    private float LifeSpan;
    private float EndOffsetX;
    private float EndOffsetY;
    private float EndScaleMuliplier;
    private float Speed;
    
    // Methods
    public void Initialize(int score, UnityEngine.Vector3 pos, ScoreSize size, View_Objects playerScoreTarget, HitComboType comboType)
    {
        UnityEngine.Color val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        float val_23;
        this.ComboType = comboType;
        this.TextMesh.text = (score >= 0) ? "+" : "";
        this.TextMesh.text = this.TextMesh.text + score.ToString();
        this.Player_ScoreTarget = playerScoreTarget;
        this.Score = score;
        if(score > 0)
        {
                val_18 = this.Color_Positive;
            val_19 = 1152921528385499860;
            val_20 = 1152921528385499864;
            val_21 = 1152921528385499868;
        }
        else
        {
                val_18 = this.Color_Negative;
            val_19 = 1152921528385499876;
            val_20 = 1152921528385499880;
            val_21 = 1152921528385499884;
        }
        
        View_Core val_6 = View_Core.Instance;
        UnityEngine.Vector2 val_8 = val_6.canvas_UI.GetComponent<UnityEngine.RectTransform>().sizeDelta;
        UnityEngine.Vector3 val_10 = UnityEngine.Camera.main.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z});
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        float val_18 = 0.5f;
        val_11.x = val_8.x * val_11.x;
        val_11.y = val_8.y * val_11.y;
        val_18 = val_8.y * val_18;
        val_11.x = val_11.x - (val_8.x * val_18);
        val_11.y = val_11.y - val_18;
        UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_11.x, y:  val_11.y);
        this.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_13.x, y = val_13.y};
        this.TextMesh.GetComponent<UnityEngine.Renderer>().sortingOrder = 14;
        val_22 = 0;
        goto label_16;
        label_20:
        this.GetComponentsInChildren<UnityEngine.ParticleSystemRenderer>(includeInactive:  true)[0].sortingOrder = 14;
        val_22 = 1;
        label_16:
        if(val_22 < val_15.Length)
        {
            goto label_20;
        }
        
        if(size == 1)
        {
            goto label_21;
        }
        
        if(size != 0)
        {
            goto label_22;
        }
        
        val_23 = 1.2f;
        goto label_23;
        label_21:
        val_23 = 2f;
        label_23:
        this.EndScaleMuliplier = val_23;
        label_22:
        UnityEngine.Coroutine val_17 = this.StartCoroutine(routine:  this.Animate());
    }
    private System.Collections.IEnumerator Animate()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new View_ScorePopUp.<Animate>d__12();
    }
    private System.Collections.IEnumerator FlyToPlayerScore()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new View_ScorePopUp.<FlyToPlayerScore>d__13();
    }
    public View_ScorePopUp()
    {
        this.Speed = 30f;
        this.LifeSpan = ;
        this.EndOffsetX = ;
        this.EndOffsetY = 15f;
        this.EndScaleMuliplier = 1f;
    }

}
