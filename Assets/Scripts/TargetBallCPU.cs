using UnityEngine;
public class TargetBallCPU : MonoBehaviour
{
    // Fields
    private int flag;
    private int position;
    public float destroyLag;
    public UnityEngine.AudioClip popClip;
    private bool triggerFlag;
    private bool isInnerBridgeRunning;
    private bool isMiddleBridgeRunning;
    private bool isOuterBridgeRunning;
    private int entryTriggerDestroyer;
    public UnityEngine.GameObject popAnimation;
    public UnityEngine.GameObject popAnimationCPU;
    public static string popTag;
    public static string popTagCPU;
    private int currentPops;
    private int cpuNegateX;
    
    // Methods
    private void Awake()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
                this.GetComponent<TargetBallVs>().enabled = true;
            this.enabled = false;
        }
        
        val_3 = null;
        val_3 = null;
        this.flag = -4294967296;
        this.position = -1;
        this.triggerFlag = true;
        mem[1152921526345614151] = 0;
        mem[1152921526345614149] = 0;
        this.cpuNegateX = InstanceAnimator.cpuNegateX;
        this.isInnerBridgeRunning = false;
        this.isMiddleBridgeRunning = false;
        this.isOuterBridgeRunning = false;
        this.entryTriggerDestroyer = 0;
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        var val_13;
        var val_134;
        int val_135;
        var val_138;
        var val_139;
        var val_140;
        var val_141;
        var val_142;
        var val_143;
        var val_144;
        var val_145;
        var val_146;
        var val_147;
        UnityEngine.GameObject[] val_148;
        UnityEngine.GameObject[] val_149;
        UnityEngine.GameObject[] val_150;
        int val_151;
        var val_152;
        var val_153;
        var val_154;
        var val_155;
        var val_156;
        var val_157;
        var val_158;
        var val_159;
        var val_160;
        var val_161;
        var val_162;
        var val_163;
        var val_164;
        var val_165;
        var val_166;
        var val_167;
        var val_168;
        var val_169;
        var val_170;
        var val_171;
        var val_172;
        var val_173;
        var val_174;
        var val_175;
        var val_176;
        var val_177;
        var val_178;
        var val_179;
        var val_180;
        var val_181;
        var val_182;
        var val_183;
        var val_184;
        var val_185;
        var val_186;
        var val_187;
        var val_188;
        var val_189;
        val_134 = null;
        val_134 = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
                return;
        }
        
        if((other.gameObject.CompareTag(tag:  "ExitColliders")) == false)
        {
            goto label_6;
        }
        
        val_135 = this.entryTriggerDestroyer + 1;
        this.entryTriggerDestroyer = val_135;
        if(this.entryTriggerDestroyer != 0)
        {
            goto label_7;
        }
        
        System.Collections.IEnumerator val_5 = this.gameObject.transform.GetEnumerator();
        label_28:
        var val_139 = 0;
        val_139 = val_139 + 1;
        if(val_5.MoveNext() == false)
        {
            goto label_15;
        }
        
        var val_140 = 0;
        val_140 = val_140 + 1;
        val_138 = val_5.Current;
        if(val_138 != null)
        {
                val_138 = 0;
        }
        
        val_138.gameObject.SetActive(value:  false);
        goto label_28;
        label_6:
        if((other.gameObject.CompareTag(tag:  "EntryColliders")) == true)
        {
                return;
        }
        
        if(this.triggerFlag == false)
        {
                return;
        }
        
        this.gameObject.transform.Find(n:  "TrailNormal").gameObject.SetActive(value:  false);
        this.triggerFlag = false;
        TargetBallCPU.popTag = other.gameObject.tag;
        TargetBallCPU.popTagCPU = this.gameObject.tag;
        if((System.String.op_Inequality(a:  this.gameObject.tag, b:  "Iron_Ball")) != false)
        {
                val_13 = 0;
            this.gameObject.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.gameObject.GetComponent<UnityEngine.CircleCollider2D>().enabled = false;
        }
        
        var val_141 = 0;
        int val_142 = 0;
        label_373:
        val_139 = static_value_032DD328;
        val_139 = static_value_032DD328;
        val_140 = null;
        val_140 = null;
        if((InstanceAnimator.outerRingBalls.Length + 32) == 0)
        {
            goto label_55;
        }
        
        val_141 = null;
        val_141 = null;
        if(other.gameObject == (InstanceAnimator.outerRingBalls.Length + 32.gameObject))
        {
            goto label_64;
        }
        
        label_55:
        val_142 = null;
        val_142 = null;
        if((InstanceAnimator.playerOuterRingBalls.Length + 32) == 0)
        {
            goto label_80;
        }
        
        val_143 = null;
        val_143 = null;
        if(other.gameObject != (InstanceAnimator.playerOuterRingBalls.Length + 32.gameObject))
        {
            goto label_80;
        }
        
        label_64:
        this.flag = 1;
        this.position = val_142;
        val_144 = null;
        val_144 = null;
        if((InstanceAnimator.outerRingBalls.Length + 32) == 0)
        {
            goto label_349;
        }
        
        val_145 = null;
        val_145 = null;
        if(InstanceAnimator.outerRingBalls != null)
        {
            goto label_306;
        }
        
        label_307:
        label_306:
        if((InstanceAnimator.outerRingBalls.Length + 32) != 0)
        {
            goto label_355;
        }
        
        label_356:
        label_355:
        if(other.gameObject != (InstanceAnimator.outerRingBalls.Length + 32.gameObject))
        {
            goto label_349;
        }
        
        val_146 = 0;
        if((this.gameObject.CompareTag(tag:  "Rainbow_Bubble")) != false)
        {
                val_146 = 0;
            if((System.String.op_Inequality(a:  other.gameObject.tag, b:  "SPD")) != false)
        {
                val_146 = 0;
            if((System.String.op_Inequality(a:  other.gameObject.tag, b:  "SPD1")) != false)
        {
                val_146 = 0;
            if((System.String.op_Inequality(a:  other.gameObject.tag, b:  "SPD2")) != false)
        {
                val_146 = 0;
            this.gameObject.tag = other.gameObject.tag;
        }
        
        }
        
        }
        
        }
        
        val_147 = null;
        val_147 = null;
        val_148 = InstanceAnimator.outerRingBalls;
        val_149 = InstanceAnimator.middleRingBalls;
        val_150 = InstanceAnimator.innerRingBalls;
        val_151 = -this.cpuNegateX;
        goto label_113;
        label_80:
        val_152 = static_value_032DD328;
        val_152 = static_value_032DD328;
        val_153 = null;
        val_153 = null;
        var val_58 = val_141 + 16;
        if((InstanceAnimator.outerRingBalls.Length + 160) == 0)
        {
            goto label_123;
        }
        
        val_154 = null;
        val_154 = null;
        if(other.gameObject == (InstanceAnimator.outerRingBalls.Length + 160.gameObject))
        {
            goto label_132;
        }
        
        label_123:
        val_155 = null;
        val_155 = null;
        if((InstanceAnimator.playerOuterRingBalls.Length + 160) == 0)
        {
            goto label_148;
        }
        
        val_156 = null;
        val_156 = null;
        if(other.gameObject != (InstanceAnimator.playerOuterRingBalls.Length + 160.gameObject))
        {
            goto label_148;
        }
        
        label_132:
        this.flag = 2;
        this.position = val_141 + 16;
        val_157 = null;
        val_157 = null;
        if((InstanceAnimator.outerRingBalls.Length + 160) == 0)
        {
            goto label_349;
        }
        
        UnityEngine.GameObject val_69 = other.gameObject;
        val_158 = null;
        val_158 = null;
        if((InstanceAnimator.outerRingBalls.Length + 160) != 0)
        {
            goto label_355;
        }
        
        goto label_356;
        label_148:
        if(val_142 > 12)
        {
            goto label_342;
        }
        
        val_159 = static_value_032DD328;
        val_159 = static_value_032DD328;
        val_160 = null;
        val_160 = null;
        if((InstanceAnimator.middleRingBalls.Length + 32) == 0)
        {
            goto label_173;
        }
        
        val_161 = null;
        val_161 = null;
        if(other.gameObject == (InstanceAnimator.middleRingBalls.Length + 32.gameObject))
        {
            goto label_182;
        }
        
        label_173:
        val_162 = null;
        val_162 = null;
        if((InstanceAnimator.playerMiddleRingBalls.Length + 32) == 0)
        {
            goto label_198;
        }
        
        val_163 = null;
        val_163 = null;
        if(other.gameObject != (InstanceAnimator.playerMiddleRingBalls.Length + 32.gameObject))
        {
            goto label_198;
        }
        
        label_182:
        this.flag = 3;
        this.position = val_142;
        val_164 = null;
        val_164 = null;
        if((InstanceAnimator.middleRingBalls.Length + 32) == 0)
        {
            goto label_349;
        }
        
        UnityEngine.GameObject val_79 = other.gameObject;
        val_165 = null;
        val_165 = null;
        if(InstanceAnimator.middleRingBalls != null)
        {
            goto label_306;
        }
        
        goto label_307;
        label_198:
        val_166 = static_value_032DD328;
        val_166 = static_value_032DD328;
        val_167 = null;
        val_167 = null;
        if((InstanceAnimator.middleRingBalls.Length + 128) == 0)
        {
            goto label_220;
        }
        
        val_168 = null;
        val_168 = null;
        if(other.gameObject == (InstanceAnimator.middleRingBalls.Length + 128.gameObject))
        {
            goto label_229;
        }
        
        label_220:
        val_169 = null;
        val_169 = null;
        if((InstanceAnimator.playerMiddleRingBalls.Length + 128) == 0)
        {
            goto label_245;
        }
        
        val_170 = null;
        val_170 = null;
        if(other.gameObject != (InstanceAnimator.playerMiddleRingBalls.Length + 128.gameObject))
        {
            goto label_245;
        }
        
        label_229:
        this.flag = 4;
        this.position = val_141 + 12;
        val_171 = null;
        val_171 = null;
        if((InstanceAnimator.middleRingBalls.Length + 128) == 0)
        {
            goto label_349;
        }
        
        UnityEngine.GameObject val_90 = other.gameObject;
        val_172 = null;
        val_172 = null;
        if((InstanceAnimator.middleRingBalls.Length + 128) != 0)
        {
            goto label_355;
        }
        
        goto label_356;
        label_245:
        if(val_142 > 8)
        {
            goto label_342;
        }
        
        val_173 = static_value_032DD328;
        val_173 = static_value_032DD328;
        val_174 = null;
        val_174 = null;
        if((InstanceAnimator.innerRingBalls.Length + 32) == 0)
        {
            goto label_270;
        }
        
        val_175 = null;
        val_175 = null;
        if(other.gameObject == (InstanceAnimator.innerRingBalls.Length + 32.gameObject))
        {
            goto label_279;
        }
        
        label_270:
        val_176 = null;
        val_176 = null;
        if((InstanceAnimator.playerInnerRingBalls.Length + 32) == 0)
        {
            goto label_295;
        }
        
        val_177 = null;
        val_177 = null;
        if(other.gameObject != (InstanceAnimator.playerInnerRingBalls.Length + 32.gameObject))
        {
            goto label_295;
        }
        
        label_279:
        this.flag = 5;
        this.position = val_142;
        val_178 = null;
        val_178 = null;
        if((InstanceAnimator.innerRingBalls.Length + 32) == 0)
        {
            goto label_349;
        }
        
        UnityEngine.GameObject val_100 = other.gameObject;
        val_179 = null;
        val_179 = null;
        if(InstanceAnimator.innerRingBalls != null)
        {
            goto label_306;
        }
        
        goto label_307;
        label_295:
        val_180 = static_value_032DD328;
        val_180 = static_value_032DD328;
        val_181 = null;
        val_181 = null;
        if((InstanceAnimator.innerRingBalls.Length + 96) == 0)
        {
            goto label_317;
        }
        
        val_182 = null;
        val_182 = null;
        if(other.gameObject == (InstanceAnimator.innerRingBalls.Length + 96.gameObject))
        {
            goto label_326;
        }
        
        label_317:
        val_183 = null;
        val_183 = null;
        if((InstanceAnimator.playerInnerRingBalls.Length + 96) == 0)
        {
            goto label_342;
        }
        
        val_184 = null;
        val_184 = null;
        if(other.gameObject != (InstanceAnimator.playerInnerRingBalls.Length + 96.gameObject))
        {
            goto label_342;
        }
        
        label_326:
        this.flag = 6;
        this.position = val_141 + 8;
        val_185 = null;
        val_185 = null;
        if((InstanceAnimator.innerRingBalls.Length + 96) == 0)
        {
            goto label_349;
        }
        
        UnityEngine.GameObject val_111 = other.gameObject;
        val_186 = null;
        val_186 = null;
        if((InstanceAnimator.innerRingBalls.Length + 96) != 0)
        {
            goto label_355;
        }
        
        goto label_356;
        label_349:
        val_187 = 0;
        if((this.gameObject.CompareTag(tag:  "Rainbow_Bubble")) != false)
        {
                val_187 = 0;
            if((System.String.op_Inequality(a:  other.gameObject.tag, b:  "SPD")) != false)
        {
                val_187 = 0;
            if((System.String.op_Inequality(a:  other.gameObject.tag, b:  "SPD1")) != false)
        {
                val_187 = 0;
            if((System.String.op_Inequality(a:  other.gameObject.tag, b:  "SPD2")) != false)
        {
                val_187 = 0;
            this.gameObject.tag = other.gameObject.tag;
        }
        
        }
        
        }
        
        }
        
        val_188 = null;
        val_188 = null;
        val_151 = this.cpuNegateX;
        val_148 = InstanceAnimator.playerOuterRingBalls;
        val_149 = InstanceAnimator.playerMiddleRingBalls;
        val_150 = InstanceAnimator.playerInnerRingBalls;
        label_113:
        UnityEngine.Coroutine val_127 = this.StartCoroutine(routine:  this.DestroyTarget(outerRingBalls:  val_148, middleRingBalls:  val_149, innerRingBalls:  val_150, negateX:  val_151));
        label_342:
        val_141 = val_141 - 1;
        val_142 = val_142 + 1;
        if(val_141 != 17)
        {
            goto label_373;
        }
        
        return;
        label_15:
        val_189 = 0;
        if(val_5 != null)
        {
                var val_143 = 0;
            val_143 = val_143 + 1;
            val_5.Dispose();
        }
        
        val_135 = this.entryTriggerDestroyer;
        label_7:
        if(val_135 != 2)
        {
                return;
        }
        
        UnityEngine.AudioSource val_130 = GameAudio.sound.PlayOneShot(clip:  this.popClip, volume:  1f);
        TargetBallCPU.popTagCPU = this.gameObject.tag;
        UnityEngine.Vector3 val_135 = this.gameObject.transform.position;
        UnityEngine.Quaternion val_136 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_137 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationCPU, position:  new UnityEngine.Vector3() {x = val_135.x, y = val_135.y, z = val_135.z}, rotation:  new UnityEngine.Quaternion() {x = val_136.x, y = val_136.y, z = val_136.z, w = val_136.w});
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private System.Collections.IEnumerator DestroyTarget(UnityEngine.GameObject[] outerRingBalls, UnityEngine.GameObject[] middleRingBalls, UnityEngine.GameObject[] innerRingBalls, int negateX)
    {
        TargetBallCPU.<DestroyTarget>d__17 val_1 = new TargetBallCPU.<DestroyTarget>d__17();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .outerRingBalls = outerRingBalls;
            .middleRingBalls = middleRingBalls;
            .innerRingBalls = innerRingBalls;
        }
        else
        {
                mem[32] = this;
            mem[40] = outerRingBalls;
            mem[56] = middleRingBalls;
            mem[64] = innerRingBalls;
        }
        
        .negateX = negateX;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator BridgeThroughMiddleRing(UnityEngine.GameObject[] middleRingBalls)
    {
        TargetBallCPU.<BridgeThroughMiddleRing>d__18 val_1 = new TargetBallCPU.<BridgeThroughMiddleRing>d__18();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .middleRingBalls = middleRingBalls;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator BridgeThroughInnerRing(UnityEngine.GameObject[] innerRingBalls)
    {
        TargetBallCPU.<BridgeThroughInnerRing>d__19 val_1 = new TargetBallCPU.<BridgeThroughInnerRing>d__19();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .innerRingBalls = innerRingBalls;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator BridgeThroughOuterRing(UnityEngine.GameObject[] outerRingBalls)
    {
        TargetBallCPU.<BridgeThroughOuterRing>d__20 val_1 = new TargetBallCPU.<BridgeThroughOuterRing>d__20();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .outerRingBalls = outerRingBalls;
        return (System.Collections.IEnumerator)val_1;
    }
    public void camShake()
    {
        UnityEngine.GameObject.Find(name:  "-camerashake").GetComponent<CameraShake>().enabled = true;
    }
    public TargetBallCPU()
    {
    
    }

}
