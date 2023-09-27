using UnityEngine;
public class InkingSequenceBubbleAnim : MonoBehaviour
{
    // Fields
    private bool inkSequence;
    public UnityEngine.GameObject bubbles;
    private bool bubbleFlag;
    public UnityEngine.GameObject individualScoreAnimation;
    public UnityEngine.GameObject inkBlobSmall;
    public UnityEngine.GameObject inkBlobLarge;
    public UnityEngine.GameObject popAnimationPlayer;
    private UnityEngine.GameObject popAnim;
    private UnityEngine.Animator popAnimHolder;
    private float randomPos;
    private UnityEngine.GameObject popText;
    private float randTimeToStart;
    public static bool shallTranslate;
    public bool shallHit;
    private float randPosUpDown;
    public bool swap;
    
    // Methods
    private void Start()
    {
        var val_40;
        float val_41;
        float val_42;
        this.shallHit = false;
        InkingSequenceBubbleAnim.shallTranslate = false;
        this.bubbleFlag = false;
        this.inkSequence = false;
        float val_40 = 0.1f;
        val_40 = ((float)UnityEngine.Random.Range(min:  0, max:  20)) * val_40;
        this.randTimeToStart = val_40;
        bool val_3 = this.gameObject.CompareTag(tag:  "Red");
        UnityEngine.GameObject val_4 = this.gameObject;
        if(val_4 == null)
        {
            goto label_2;
        }
        
        if(val_3 == false)
        {
            goto label_3;
        }
        
        label_8:
        val_40 = val_4.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        val_41 = 1f;
        val_42 = 0f;
        goto label_7;
        label_2:
        if(val_3 == true)
        {
            goto label_8;
        }
        
        label_3:
        bool val_9 = val_4.CompareTag(tag:  "Yellow");
        UnityEngine.GameObject val_10 = this.gameObject;
        if(val_10 == null)
        {
            goto label_9;
        }
        
        if(val_9 == false)
        {
            goto label_10;
        }
        
        label_15:
        val_42 = 0.92f;
        val_40 = val_10.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        val_41 = 1f;
        label_7:
        label_41:
        UnityEngine.Color val_15 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_40.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = val_15.r, g = val_15.g, b = val_15.b, a = val_15.a});
        return;
        label_9:
        if(val_9 == true)
        {
            goto label_15;
        }
        
        label_10:
        bool val_16 = val_10.CompareTag(tag:  "Blue");
        UnityEngine.GameObject val_17 = this.gameObject;
        if(val_17 == null)
        {
            goto label_16;
        }
        
        if(val_16 == false)
        {
            goto label_17;
        }
        
        label_22:
        UnityEngine.Material val_21 = val_17.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_41;
        label_16:
        if(val_16 == true)
        {
            goto label_22;
        }
        
        label_17:
        bool val_22 = val_17.CompareTag(tag:  "Green");
        UnityEngine.GameObject val_23 = this.gameObject;
        if(val_23 == null)
        {
            goto label_23;
        }
        
        if(val_22 == false)
        {
            goto label_24;
        }
        
        label_29:
        UnityEngine.Material val_27 = val_23.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_41;
        label_23:
        if(val_22 == true)
        {
            goto label_29;
        }
        
        label_24:
        UnityEngine.GameObject val_29 = this.gameObject;
        if((val_23.CompareTag(tag:  "Orange")) == false)
        {
            goto label_31;
        }
        
        UnityEngine.Material val_33 = val_29.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_7;
        label_31:
        if((val_29.CompareTag(tag:  "Purple")) == false)
        {
                return;
        }
        
        UnityEngine.Material val_39 = this.gameObject.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_41;
    }
    public void DestroyAnim(string winnerScore)
    {
        string val_19 = this.gameObject.tag;
        UnityEngine.Color val_7 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
        UnityEngine.PlayerPrefs.SetInt(key:  winnerScore, value:  (UnityEngine.PlayerPrefs.GetInt(key:  winnerScore)) + 200);
        UnityEngine.Vector3 val_12 = this.gameObject.transform.position;
        UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.identity;
        this.popAnim = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, rotation:  new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w});
        if((System.String.op_Equality(a:  val_19 = this.gameObject.tag, b:  "SPD")) != true)
        {
                if((System.String.op_Equality(a:  val_19, b:  "SPD1")) == false)
        {
            goto label_13;
        }
        
        }
        
        val_19 = "SPD2";
        label_13:
        UnityEngine.Animator val_18 = this.popAnim.gameObject.GetComponent<UnityEngine.Animator>();
        this.popAnimHolder = val_18;
        val_18.Play(stateName:  val_19, layer:  0, normalizedTime:  0f);
        this.Invoke(methodName:  "DestroyObject", time:  1f);
    }
    private void DestroyInk()
    {
        var val_54;
        var val_55;
        var val_56;
        float val_60;
        float val_61;
        float val_62;
        var val_63;
        float val_64;
        float val_65;
        bool val_66;
        var val_67;
        var val_68;
        float val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        val_54 = null;
        val_54 = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
            goto label_3;
        }
        
        val_55 = null;
        val_55 = null;
        val_56 = this.gameObject.transform;
        UnityEngine.Vector3 val_4 = this.transform.right;
        val_60 = val_4.z;
        if(LineControllerP2.player2Lose == false)
        {
            goto label_8;
        }
        
        val_61 = val_4.x;
        val_62 = val_4.y;
        goto label_11;
        label_3:
        val_56 = this.gameObject.transform;
        UnityEngine.Vector3 val_8 = this.transform.right;
        val_60 = val_8.z;
        val_61 = val_8.x;
        val_62 = val_8.y;
        label_11:
        label_61:
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_61, y = val_62, z = val_60}, d:  0.4f);
        val_63 = null;
        val_63 = null;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  (float)InstanceAnimator.playerNegateX);
        val_56.Translate(translation:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        UnityEngine.Vector3 val_14 = this.transform.up;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  this.randPosUpDown);
        val_64 = val_15.z;
        this.gameObject.transform.Translate(translation:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_64});
        UnityEngine.Vector3 val_20 = this.gameObject.transform.localPosition;
        val_65 = val_20.x;
        val_66 = this.gameObject.transform;
        UnityEngine.Vector3 val_23 = val_66.localPosition;
        this.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_67 = null;
        val_67 = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
            goto label_30;
        }
        
        val_68 = null;
        val_68 = null;
        val_66 = LineControllerP2.player2Lose;
        UnityEngine.Vector3 val_26 = this.gameObject.transform.position;
        val_69 = this.randomPos;
        if(val_66 == false)
        {
            goto label_35;
        }
        
        if(val_26.x < val_69)
        {
                return;
        }
        
        this.CancelInvoke(methodName:  "DestroyInk");
        val_70 = 1152921505079742464;
        val_71 = null;
        TargetBallScript.scoreCounter = 400;
        val_72 = null;
        val_72 = null;
        goto label_39;
        label_30:
        if(this.bubbleFlag == true)
        {
                return;
        }
        
        val_66 = 1152921505075642368;
        val_73 = null;
        val_73 = null;
        if(LineController.InkingSequence == false)
        {
                return;
        }
        
        val_74 = null;
        val_74 = null;
        if(InstanceAnimator.playerNegateX != 1)
        {
            goto label_46;
        }
        
        UnityEngine.Vector3 val_29 = this.gameObject.transform.position;
        val_69 = this.randomPos;
        if(val_29.x >= val_69)
        {
            goto label_49;
        }
        
        val_74 = null;
        label_46:
        val_74 = null;
        if(InstanceAnimator.playerNegateX != 1)
        {
                return;
        }
        
        UnityEngine.Vector3 val_32 = this.gameObject.transform.position;
        val_69 = this.randomPos;
        if(val_32.x > val_69)
        {
                return;
        }
        
        label_49:
        this.CancelInvoke(methodName:  "DestroyInk");
        val_70 = 1152921505079742464;
        val_71 = null;
        TargetBallScript.scoreCounter = 400;
        val_72 = null;
        val_72 = null;
        label_39:
        int val_54 = TargetBallScript.scoreCounter;
        val_54 = val_54 + LineController.userScore;
        LineController.userScore = val_54;
        goto label_58;
        label_8:
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_60});
        goto label_61;
        label_35:
        if(val_26.x > val_69)
        {
                return;
        }
        
        this.CancelInvoke(methodName:  "DestroyInk");
        val_70 = 1152921505080061952;
        TargetBallVs.scoreCounter = 400;
        UnityEngine.PlayerPrefs.SetInt(key:  "Score2", value:  TargetBallScript.scoreCounter + (UnityEngine.PlayerPrefs.GetInt(key:  "Score2")));
        label_58:
        UnityEngine.Vector3 val_38 = this.gameObject.transform.position;
        UnityEngine.Quaternion val_39 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_40 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, rotation:  new UnityEngine.Quaternion() {x = val_39.x, y = val_39.y, z = val_39.z, w = val_39.w});
        this.popText = val_40;
        val_40.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
        UnityEngine.Vector3 val_47 = this.gameObject.transform.position;
        this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z};
        popScoreScript val_48 = this.popText.GetComponent<popScoreScript>();
        val_66 = TargetBallVs.scoreCounter;
        val_48.scoreCounter = val_66;
        this.placeBubbles();
        this.bubbleFlag = true;
        UnityEngine.Color val_53 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_65 = val_53.r;
        val_64 = val_53.b;
        this.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_65, g = val_53.g, b = val_64, a = val_53.a};
        this.Invoke(methodName:  "DestroyObject", time:  0.1f);
    }
    public void HitInk()
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = null;
        val_6 = null;
        float val_6 = -0.8f;
        float val_7 = 0.1f;
        val_6 = InstanceAnimator.UniversalX + val_6;
        val_7 = ((float)UnityEngine.Random.Range(min:  0, max:  17)) * val_7;
        val_6 = val_6 * (float)InstanceAnimator.playerNegateX;
        val_7 = val_7 * (float)InstanceAnimator.playerNegateX;
        val_6 = val_6 + val_7;
        this.randomPos = val_6;
        val_7 = null;
        val_7 = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
                val_8 = null;
            val_8 = null;
            if(LineControllerP2.player2Lose != false)
        {
                float val_2 = LineControllerP2.Getinkpos();
        }
        
            this.randomPos = LineController.Getinkposp1();
        }
        
        float val_8 = 0.005f;
        val_8 = ((float)(UnityEngine.Random.Range(min:  0, max:  8)) - 4) * val_8;
        this.randPosUpDown = val_8;
        this.StopCoroutine(methodName:  "RandomTranslation");
        this.InvokeRepeating(methodName:  "DestroyInk", time:  0f, repeatRate:  0.02f);
    }
    public void InkSequence()
    {
        UnityEngine.Coroutine val_3 = this.gameObject.GetComponent<InkingSequenceBubbleAnim>().StartCoroutine(methodName:  "RandomTranslation");
    }
    private System.Collections.IEnumerator RandomTranslation()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new InkingSequenceBubbleAnim.<RandomTranslation>d__21();
    }
    private void placeBubbles()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        UnityEngine.GameObject val_21;
        var val_22;
        var val_23;
        var val_24;
        UnityEngine.Vector3 val_1 = this.GeneratedPosition();
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.bubbles, position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
        val_12 = null;
        val_12 = null;
        val_13 = null;
        if(this.gameObject != (LineController.inkBubbles + 32.gameObject))
        {
                val_14 = null;
            CameraShake.shake = 0.2f;
            val_15 = null;
            val_15 = null;
            CanvasShake.shake = 0.2f;
            CameraShake.shakeAmount = 0.2f;
            CanvasShake.shakeAmount = 0.2f;
            UnityEngine.Vector3 val_7 = this.GeneratedPosition();
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_9 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.inkBlobSmall, position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, rotation:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w});
            return;
        }
        
        val_16 = null;
        CameraShake.shake = 2f;
        val_17 = null;
        val_17 = null;
        CanvasShake.shake = 2f;
        CameraShake.shakeAmount = 0.5f;
        CanvasShake.shakeAmount = 0.23f;
        val_18 = null;
        val_18 = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
            goto label_25;
        }
        
        val_19 = null;
        val_19 = null;
        val_20 = 1152921505075376128;
        val_21 = this.inkBlobLarge;
        val_22 = null;
        if(LineControllerP2.player2Lose == false)
        {
            goto label_28;
        }
        
        goto label_32;
        label_25:
        val_20 = 1152921505075376128;
        val_21 = this.inkBlobLarge;
        val_23 = null;
        label_32:
        float val_12 = (float)InstanceAnimator.playerNegateX;
        val_12 = InstanceAnimator.UniversalX * val_12;
        label_39:
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_11 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_21, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w});
        return;
        label_28:
        val_24 = null;
        float val_13 = InstanceAnimator.UniversalX;
        val_13 = val_13 * ((float)-InstanceAnimator.playerNegateX);
        goto label_39;
    }
    private UnityEngine.Vector3 GeneratedPosition()
    {
        UnityEngine.Vector3 val_3 = this.gameObject.transform.position;
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void DestroyObject()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public InkingSequenceBubbleAnim()
    {
    
    }

}
