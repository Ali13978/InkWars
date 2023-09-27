using UnityEngine;
public class TutorialFingerAnim : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject lineRenderer;
    private UnityEngine.Animator lineAnim;
    private CharAnimationController animController;
    public UnityEngine.GameObject playerChar;
    private float angle11;
    private float angle22;
    private float angle33;
    
    // Methods
    private void Start()
    {
        var val_6;
        this.animController = this.playerChar.GetComponent<CharAnimationController>();
        this.lineAnim = this.lineRenderer.GetComponent<UnityEngine.Animator>();
        val_6 = null;
        val_6 = null;
        this.angle11 = (InstanceAnimator.UniversalX == 4.46f) ? 11f : 14.4f;
        this.angle22 = (InstanceAnimator.UniversalX == 4.46f) ? 18f : 23f;
        this.angle33 = (InstanceAnimator.UniversalX == 4.46f) ? 25f : 31.5f;
    }
    public void touchInStarting()
    {
        var val_10;
        var val_14;
        var val_19;
        var val_20;
        var val_21;
        this.animController.PlayAnimation(newAnimName:  1, forceOverride:  false);
        System.Collections.IEnumerator val_2 = this.lineRenderer.transform.GetEnumerator();
        label_29:
        var val_19 = 0;
        val_19 = val_19 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_9;
        }
        
        var val_20 = 0;
        val_20 = val_20 + 1;
        val_19 = val_2.Current;
        UnityEngine.AnimatorStateInfo val_7 = this.lineAnim.GetCurrentAnimatorStateInfo(layerIndex:  0);
        val_20 = 0;
        if(( & 1) != 0)
        {
                if(val_19 != null)
        {
                val_19 = 0;
        }
        
            val_20 = val_19;
        }
        else
        {
                this.lineAnim.Play(stateName:  "MiddleWhite", layer:  0, normalizedTime:  0f);
        }
        
        val_14 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_10 = 0;
        UnityEngine.Color val_17 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_20.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_17.r, g = val_17.g, b = val_17.b, a = val_17.a};
        goto label_29;
        label_9:
        val_21 = 0;
        if(val_2 != null)
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            val_2.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public void fingerAnim(int Entry)
    {
        var val_15 = this;
        if(Entry > 6)
        {
                return;
        }
        
        var val_14 = 40824848 + (Entry) << 2;
        val_14 = val_14 + 40824848;
        goto (40824848 + (Entry) << 2 + 40824848);
    }
    public void shootInTrashABubble()
    {
        UnityEngine.Object.FindObjectOfType<InteractiveTutorialManager>().onTrashABubbleShoot();
    }
    public void shootInHowToShoot()
    {
        UnityEngine.Object.FindObjectOfType<InteractiveTutorialManager>().onTutorialFingerShoot();
    }
    public TutorialFingerAnim()
    {
    
    }

}
