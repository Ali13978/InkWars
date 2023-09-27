using UnityEngine;
public class TargetBallDemo : MonoBehaviour
{
    // Fields
    public bool isCPUBall;
    private int flag;
    private int position;
    public float destroyLag;
    private bool triggerFlag;
    private int entryTriggerDestroyer;
    public UnityEngine.GameObject popAnimation;
    public UnityEngine.GameObject popAnimationPlayer;
    public static string popTag;
    private string playerBallTag;
    private string popBallTag;
    private int playerNegateX;
    private int ballEntry;
    private int entryTrigger;
    public UnityEngine.GameObject crossForWrongHit;
    public bool isForDemo;
    
    // Methods
    private void Start()
    {
        var val_1;
        this.isForDemo = false;
        this.entryTrigger = 0;
        val_1 = null;
        val_1 = null;
        this.flag = -4294967296;
        this.position = -1;
        this.triggerFlag = true;
        this.entryTriggerDestroyer = 0;
        this.playerNegateX = InstanceAnimator.playerNegateX;
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        string val_56;
        string val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_62;
        var val_63;
        if(this.isCPUBall != false)
        {
                System.Console.WriteLine(value:  "CPUBall");
        }
        
        DemoManager val_1 = DemoManager.Instance;
        string val_3 = other.gameObject.tag;
        val_56 = val_3;
        bool val_4 = System.String.op_Equality(a:  val_3, b:  "EntryColliders");
        if(val_1.IsAdvancedTutorialMode == false)
        {
            goto label_9;
        }
        
        if(val_4 == true)
        {
            goto label_10;
        }
        
        if((System.String.op_Equality(a:  val_56, b:  "ExitColliders")) == true)
        {
            goto label_54;
        }
        
        if(this.triggerFlag == false)
        {
                return;
        }
        
        this.BallHide(other:  other);
        if((System.String.op_Equality(a:  this.gameObject.tag, b:  other.gameObject.tag)) == true)
        {
            goto label_16;
        }
        
        val_57 = this.gameObject;
        if((System.String.op_Equality(a:  val_57.tag, b:  "Rainbow_Bubble")) == false)
        {
            goto label_18;
        }
        
        label_16:
        this.gameObject.tag = other.gameObject.tag;
        label_78:
        this.BallHit();
        return;
        label_9:
        if(val_4 == false)
        {
            goto label_22;
        }
        
        label_10:
        this.HandleBallEntry();
        return;
        label_22:
        val_56 = other.gameObject;
        if((System.String.op_Equality(a:  val_56.tag, b:  "ExitColliders")) == false)
        {
            goto label_25;
        }
        
        val_58 = null;
        val_58 = null;
        if((System.String.op_Equality(a:  DemoManager.currentSequence, b:  "Recharging")) == false)
        {
            goto label_28;
        }
        
        TutorialDataManager val_22 = TutorialDataManager.Instance;
        val_56 = val_22.PopClip[5];
        UnityEngine.AudioSource val_23 = GameAudio.sound.PlayOneShot(clip:  val_56, volume:  1f);
        val_59 = this.gameObject;
        goto label_37;
        label_25:
        if(this.triggerFlag == false)
        {
                return;
        }
        
        this.BallHide(other:  other);
        val_60 = null;
        val_60 = null;
        if(DemoManager.touchBoolForDemo != false)
        {
                if(this.isForDemo == false)
        {
            goto label_42;
        }
        
        }
        
        TutorialDataManager val_26 = TutorialDataManager.Instance;
        UnityEngine.AudioSource val_27 = GameAudio.sound.PlayOneShot(clip:  val_26.PopClip[5], volume:  1f);
        label_91:
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        return;
        label_28:
        val_62 = null;
        val_62 = null;
        if(((System.String.op_Equality(a:  DemoManager.currentSequence, b:  "TrashABubble")) == false) || (this.ballEntry == 0))
        {
            goto label_54;
        }
        
        TutorialDataManager val_31 = TutorialDataManager.Instance;
        UnityEngine.AudioSource val_32 = GameAudio.sound.PlayOneShot(clip:  val_31.PopClip[5], volume:  1f);
        val_56 = this.gameObject.transform;
        UnityEngine.Vector3 val_35 = val_56.position;
        UnityEngine.Quaternion val_36 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_37 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.crossForWrongHit, position:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, rotation:  new UnityEngine.Quaternion() {x = val_36.x, y = val_36.y, z = val_36.z, w = val_36.w});
        label_37:
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        label_54:
        this.HandleBallExit();
        return;
        label_42:
        if((System.String.op_Equality(a:  DemoManager.currentSequence, b:  "HowToShoot")) != false)
        {
                if(this.ballEntry != 2)
        {
            goto label_70;
        }
        
        }
        
        val_63 = null;
        val_63 = null;
        if(((System.String.op_Equality(a:  DemoManager.currentSequence, b:  "TrashABubble")) != false) && (this.ballEntry != 0))
        {
                return;
        }
        
        val_57 = this.gameObject.tag;
        if((System.String.op_Inequality(a:  val_57, b:  other.gameObject.tag)) == false)
        {
            goto label_78;
        }
        
        label_18:
        this.PopOnAndDestroy(target:  this.gameObject);
        return;
        label_70:
        TutorialDataManager val_48 = TutorialDataManager.Instance;
        UnityEngine.AudioSource val_49 = GameAudio.sound.PlayOneShot(clip:  val_48.PopClip[5], volume:  1f);
        UnityEngine.Vector3 val_52 = this.gameObject.transform.position;
        UnityEngine.Quaternion val_53 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_54 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.crossForWrongHit, position:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z}, rotation:  new UnityEngine.Quaternion() {x = val_53.x, y = val_53.y, z = val_53.z, w = val_53.w});
        UnityEngine.GameObject val_55 = this.gameObject;
        goto label_91;
    }
    private void BallHide(UnityEngine.Collider2D other)
    {
        this.entryTriggerDestroyer = 0;
        this.triggerFlag = false;
        string val_2 = other.gameObject.tag;
        this.popBallTag = val_2;
        TargetBallDemo.popTag = val_2;
        this.gameObject.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    private void BallHit()
    {
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_17 = null;
        if(this.isCPUBall != false)
        {
                val_17 = null;
            val_18 = 1152921505075380272;
        }
        else
        {
                val_17 = null;
            val_18 = 1152921505075380248;
        }
        
        if(this.isCPUBall != false)
        {
                val_17 = null;
            val_19 = 1152921505075380280;
        }
        else
        {
                val_17 = null;
            val_19 = 1152921505075380256;
        }
        
        if(this.isCPUBall != false)
        {
                val_20 = null;
            val_21 = 1152921505075380288;
        }
        else
        {
                val_22 = null;
            val_21 = 1152921505075380264;
        }
        
        var val_17 = 7;
        val_17 = val_17 - this.ballEntry;
        this.gameObject.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().enabled = false;
        if((((this.isCPUBall == true) ? (val_17) : this.ballEntry) - 1) > 5)
        {
                return;
        }
        
        var val_18 = 40838968 + ((this.isCPUBall == true ? (7 - this.ballEntry) : this.ballEntry - 1)) << 2;
        val_18 = val_18 + 40838968;
        goto (40838968 + ((this.isCPUBall == true ? (7 - this.ballEntry) : this.ballEntry - 1)) << 2 + 40838968);
    }
    private void BallMiss()
    {
        this.PopOnAndDestroy(target:  this.gameObject);
    }
    private void HandleBallExit()
    {
        int val_21;
        var val_24;
        var val_25;
        val_21 = this.entryTriggerDestroyer + 1;
        this.entryTriggerDestroyer = val_21;
        if(this.entryTriggerDestroyer != 0)
        {
            goto label_1;
        }
        
        System.Collections.IEnumerator val_3 = this.gameObject.transform.GetEnumerator();
        label_22:
        var val_22 = 0;
        val_22 = val_22 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_9;
        }
        
        var val_23 = 0;
        val_23 = val_23 + 1;
        val_24 = val_3.Current;
        if(val_24 != null)
        {
                val_24 = 0;
        }
        
        val_24.gameObject.SetActive(value:  false);
        goto label_22;
        label_9:
        val_25 = 0;
        if(val_3 != null)
        {
                var val_24 = 0;
            val_24 = val_24 + 1;
            val_3.Dispose();
        }
        
        if((System.String.op_Equality(a:  this.gameObject.tag, b:  "Rainbow_Bubble")) != false)
        {
                this.gameObject.transform.Find(n:  "TrailRainbow").gameObject.SetActive(value:  false);
        }
        
        val_21 = this.entryTriggerDestroyer;
        label_1:
        if(val_21 != 2)
        {
                return;
        }
        
        this.PopOnAndDestroy(target:  this.gameObject);
    }
    private void PopOnAndDestroy(UnityEngine.GameObject target)
    {
        TutorialDataManager val_2 = TutorialDataManager.Instance;
        UnityEngine.AudioSource val_3 = GameAudio.sound.PlayOneShot(clip:  val_2.PopClip[5], volume:  1f);
        UnityEngine.Vector3 val_5 = target.transform.position;
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_7 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, rotation:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w});
        PlayerAnimDestroyer val_8 = val_7.GetComponent<PlayerAnimDestroyer>();
        val_8.overrideAnimation = this.playerBallTag;
        val_7.GetComponent<PlayerAnimDestroyer>().Start();
        UnityEngine.Object.Destroy(obj:  target);
    }
    private void HandleBallEntry()
    {
        this.entryTrigger = this.entryTrigger + 1;
        if(this.entryTrigger != 0)
        {
                return;
        }
        
        this.ballEntry = InteractiveTutorialManager.ballEntry;
        this.playerBallTag = this.gameObject.tag;
    }
    private System.Collections.IEnumerator DestroyTarget(UnityEngine.GameObject[] ringBalls, int negateX)
    {
        TargetBallDemo.<DestroyTarget>d__24 val_1 = new TargetBallDemo.<DestroyTarget>d__24();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .ringBalls = ringBalls;
        return (System.Collections.IEnumerator)val_1;
    }
    private bool CanPop(UnityEngine.GameObject[] ringBalls, string tag, int index)
    {
        var val_3;
        DemoManager val_1 = DemoManager.Instance;
        if(val_1.IsAdvancedTutorialMode != false)
        {
                if(((index & 2147483648) == 0) && (ringBalls.Length > index))
        {
                return System.String.op_Equality(a:  tag, b:  ringBalls[(long)index].tag);
        }
        
            val_3 = 0;
            return (bool)val_3;
        }
        
        val_3 = 1;
        return (bool)val_3;
    }
    private bool DestroyBubble(UnityEngine.GameObject[] ringBalls, int index)
    {
        var val_2;
        if(ringBalls[(long)index] == 0)
        {
                val_2 = 0;
            return (bool)val_2;
        }
        
        this.PopOnAndDestroy(target:  ringBalls[(long)(int)(index)] + 32);
        val_2 = 1;
        return (bool)val_2;
    }
    internal void SetBall(UnityEngine.GameObject otherBall)
    {
        var val_68;
        string val_69;
        float val_70;
        var val_71;
        float val_72;
        this.gameObject.tag = otherBall.gameObject.tag;
        this.GetComponent<UnityEngine.SpriteRenderer>().sprite = otherBall.GetComponent<UnityEngine.UI.Image>().sprite;
        this.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        UnityEngine.Transform val_10 = this.gameObject.transform.GetChild(index:  0);
        bool val_12 = this.gameObject.CompareTag(tag:  "Rainbow_Bubble");
        UnityEngine.Transform val_14 = this.gameObject.transform;
        if(val_14 == null)
        {
            goto label_12;
        }
        
        if(val_12 == false)
        {
            goto label_13;
        }
        
        label_29:
        val_14.GetChild(index:  2).gameObject.SetActive(value:  true);
        TutorialDataManager val_18 = TutorialDataManager.Instance;
        UnityEngine.AudioSource val_19 = GameAudio.sound.PlayOneShot(clip:  val_18.PopClip[1], volume:  1f);
        val_68 = val_10.gameObject;
        val_68.SetActive(value:  true);
        val_69 = this.gameObject.tag;
        val_10.gameObject.GetComponent<UnityEngine.Animator>().Play(stateName:  val_69);
        return;
        label_12:
        if(val_12 == true)
        {
            goto label_29;
        }
        
        label_13:
        val_14.Find(n:  "TrailNormal").gameObject.SetActive(value:  true);
        val_68 = this.gameObject.CompareTag(tag:  "Red");
        UnityEngine.GameObject val_29 = this.gameObject;
        if(val_29 == null)
        {
            goto label_33;
        }
        
        if(val_68 == false)
        {
            goto label_34;
        }
        
        label_39:
        val_70 = 0.4f;
        val_71 = val_29.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        val_72 = 0f;
        goto label_77;
        label_33:
        if(val_68 == true)
        {
            goto label_39;
        }
        
        label_34:
        val_68 = val_29.CompareTag(tag:  "Yellow");
        UnityEngine.GameObject val_35 = this.gameObject;
        if(val_35 == null)
        {
            goto label_40;
        }
        
        if(val_68 == false)
        {
            goto label_41;
        }
        
        label_46:
        val_72 = 0.92f;
        val_70 = 0.4f;
        val_71 = val_35.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_77;
        label_40:
        if(val_68 == true)
        {
            goto label_46;
        }
        
        label_41:
        val_68 = val_35.CompareTag(tag:  "Blue");
        UnityEngine.GameObject val_41 = this.gameObject;
        if(val_41 == null)
        {
            goto label_47;
        }
        
        if(val_68 == false)
        {
            goto label_48;
        }
        
        label_59:
        val_70 = 0.4f;
        val_71 = val_41.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        val_72 = 0f;
        label_77:
        UnityEngine.Color val_46 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_71.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = val_46.r, g = val_46.g, b = val_46.b, a = val_46.a});
        label_72:
        val_69 = GameAudio.sound;
        TutorialDataManager val_48 = TutorialDataManager.Instance;
        UnityEngine.AudioSource val_49 = val_69.PlayOneShot(clip:  val_48.PopClip[0], volume:  1f);
        return;
        label_47:
        if(val_68 == true)
        {
            goto label_59;
        }
        
        label_48:
        UnityEngine.GameObject val_51 = this.gameObject;
        if((val_41.CompareTag(tag:  "Green")) == false)
        {
            goto label_61;
        }
        
        UnityEngine.Material val_55 = val_51.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_77;
        label_61:
        UnityEngine.GameObject val_57 = this.gameObject;
        if((val_51.CompareTag(tag:  "Orange")) == false)
        {
            goto label_67;
        }
        
        UnityEngine.Material val_61 = val_57.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_77;
        label_67:
        if((val_57.CompareTag(tag:  "Purple")) == false)
        {
            goto label_72;
        }
        
        UnityEngine.Material val_67 = this.gameObject.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_77;
    }
    public TargetBallDemo()
    {
    
    }

}
