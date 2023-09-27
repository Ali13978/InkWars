using UnityEngine;
public class InkUpTutorialScript : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject inkUpFinger;
    private int buttonCounter;
    public UnityEngine.GameObject textInkUpFinger;
    public UnityEngine.GameObject inkFingerArrowText;
    public UnityEngine.GameObject buttonTick;
    public UnityEngine.UI.Text inkTimerText;
    private float inkCountdown;
    public UnityEngine.GameObject inkMeterMiddleFull;
    public UnityEngine.GameObject inkMeterMiddleFullAnim;
    public UnityEngine.UI.Text textScore;
    public UnityEngine.UI.Text stageText;
    public UnityEngine.UI.Image redArrow;
    public UnityEngine.GameObject flipper;
    public UnityEngine.GameObject inkMeterArrowText;
    public UnityEngine.GameObject redArrowOriginal;
    
    // Methods
    private void Start()
    {
        var val_10;
        UnityEngine.GameObject val_14;
        this.redArrowOriginal.SetActive(value:  false);
        val_10 = null;
        val_10 = null;
        if(DataStructs.UserDataDictionary.Settings.FlipNegateX == 1)
        {
                UnityEngine.Vector3 val_3 = this.flipper.transform.localScale;
            this.flipper.transform.localScale = new UnityEngine.Vector3() {x = -val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_6 = this.inkFingerArrowText.transform.localScale;
            val_14 = this.inkFingerArrowText;
        }
        else
        {
                UnityEngine.Vector3 val_8 = this.inkMeterArrowText.transform.localScale;
            val_14 = this.inkMeterArrowText;
        }
        
        val_14.transform.localScale = new UnityEngine.Vector3() {x = -val_8.x, y = val_8.y, z = val_8.z};
        this.inkMeterMiddleFull.SetActive(value:  false);
        this.inkMeterMiddleFullAnim.SetActive(value:  true);
        this.buttonCounter = 0;
        this.textInkUpFinger.SetActive(value:  false);
    }
    private System.Collections.IEnumerator CountDown()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new InkUpTutorialScript.<CountDown>d__16();
    }
    public void onButtonDown()
    {
        var val_3;
        var val_191;
        var val_192;
        UnityEngine.Object val_193;
        float val_198;
        UnityEngine.Object val_199;
        float val_200;
        float val_201;
        float val_202;
        float val_207;
        float val_208;
        float val_213;
        float val_214;
        float val_215;
        float val_216;
        string val_217;
        var val_218;
        float val_219;
        var val_220;
        var val_221;
        var val_224;
        var val_227;
        var val_233;
        var val_234;
        var val_237;
        if(this.buttonCounter == 0)
        {
                this.textInkUpFinger.SetActive(value:  true);
        }
        
        UnityEngine.Object[] val_2 = UnityEngine.Object.FindObjectsOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_191 = 1152921504845025280;
        val_192 = 0;
        goto label_45;
        label_79:
        val_193 = val_2[0];
        if((val_193 != null) && (null != null))
        {
                val_193 = 0;
        }
        
        if(this.buttonCounter > 2)
        {
            goto label_11;
        }
        
        bool val_5 = UnityEngine.Object.op_Implicit(exists:  val_193.GetComponent<UnityEngine.SpriteRenderer>());
        if(val_193 == 0)
        {
            goto label_15;
        }
        
        if(val_5 == false)
        {
            goto label_16;
        }
        
        label_29:
        UnityEngine.Color val_7 = val_193.GetComponent<UnityEngine.SpriteRenderer>().color;
        UnityEngine.Vector4 val_8 = UnityEngine.Color.op_Implicit(c:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a});
        val_198 = val_8.w;
        val_199 = val_193.GetComponent<UnityEngine.SpriteRenderer>();
        val_200 = 0.2f;
        val_201 = 0.2f;
        val_202 = 0.2f;
        goto label_19;
        label_11:
        bool val_11 = UnityEngine.Object.op_Implicit(exists:  val_193.GetComponent<UnityEngine.SpriteRenderer>());
        if(val_193 == 0)
        {
            goto label_23;
        }
        
        if(val_11 == false)
        {
            goto label_24;
        }
        
        label_37:
        UnityEngine.Color val_13 = val_193.GetComponent<UnityEngine.SpriteRenderer>().color;
        UnityEngine.Vector4 val_14 = UnityEngine.Color.op_Implicit(c:  new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a});
        val_198 = val_14.w;
        val_199 = val_193.GetComponent<UnityEngine.SpriteRenderer>();
        val_200 = 1f;
        val_201 = 1f;
        val_202 = 1f;
        label_19:
        UnityEngine.Color val_16 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = val_200, y = val_201, z = val_202, w = val_198});
        val_207 = val_16.r;
        val_208 = val_16.b;
        val_199.color = new UnityEngine.Color() {r = val_207, g = val_16.g, b = val_208, a = val_16.a};
        goto label_73;
        label_15:
        if(val_5 == true)
        {
            goto label_29;
        }
        
        label_16:
        bool val_18 = UnityEngine.Object.op_Implicit(exists:  val_193.GetComponent<UnityEngine.UI.Image>());
        if(val_193 == 0)
        {
            goto label_32;
        }
        
        if(val_18 == false)
        {
            goto label_33;
        }
        
        label_46:
        UnityEngine.Color val_20 = val_193.GetComponent<UnityEngine.UI.Image>().color;
        UnityEngine.Vector4 val_21 = UnityEngine.Color.op_Implicit(c:  new UnityEngine.Color() {r = val_20.r, g = val_20.g, b = val_20.b, a = val_20.a});
        val_213 = val_21.w;
        label_61:
        val_199 = val_193.GetComponent<UnityEngine.UI.Image>();
        val_214 = 0.2f;
        val_215 = 0.2f;
        val_216 = 0.2f;
        goto label_36;
        label_23:
        if(val_11 == true)
        {
            goto label_37;
        }
        
        label_24:
        bool val_24 = UnityEngine.Object.op_Implicit(exists:  val_193.GetComponent<UnityEngine.UI.Image>());
        if(val_193 == 0)
        {
            goto label_40;
        }
        
        if(val_24 == false)
        {
            goto label_41;
        }
        
        label_62:
        UnityEngine.Color val_26 = val_193.GetComponent<UnityEngine.UI.Image>().color;
        UnityEngine.Vector4 val_27 = UnityEngine.Color.op_Implicit(c:  new UnityEngine.Color() {r = val_26.r, g = val_26.g, b = val_26.b, a = val_26.a});
        val_213 = val_27.w;
        label_77:
        val_199 = val_193.GetComponent<UnityEngine.UI.Image>();
        val_214 = 1f;
        val_215 = 1f;
        val_216 = 1f;
        label_36:
        UnityEngine.Color val_29 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = val_214, y = val_215, z = val_216, w = val_213});
        val_207 = val_29.r;
        val_208 = val_29.b;
        val_199.color = new UnityEngine.Color() {r = val_207, g = val_29.g, b = val_208, a = val_29.a};
        label_73:
        val_192 = 1;
        goto label_45;
        label_32:
        if(val_18 == true)
        {
            goto label_46;
        }
        
        label_33:
        if((((UnityEngine.Object.op_Implicit(exists:  val_193.GetComponent<UnityEngine.UI.Text>())) == false) || (val_193 == this.textScore.gameObject)) || (val_193 == this.stageText.gameObject))
        {
            goto label_73;
        }
        
        UnityEngine.Color val_37 = val_193.GetComponent<UnityEngine.UI.Text>().color;
        UnityEngine.Vector4 val_38 = UnityEngine.Color.op_Implicit(c:  new UnityEngine.Color() {r = val_37.r, g = val_37.g, b = val_37.b, a = val_37.a});
        if(val_193 != 0)
        {
            goto label_61;
        }
        
        goto label_61;
        label_40:
        if(val_24 == true)
        {
            goto label_62;
        }
        
        label_41:
        if((((UnityEngine.Object.op_Implicit(exists:  val_193.GetComponent<UnityEngine.UI.Text>())) == false) || (val_193 == this.textScore.gameObject)) || (val_193 == this.stageText.gameObject))
        {
            goto label_73;
        }
        
        UnityEngine.Color val_46 = val_193.GetComponent<UnityEngine.UI.Text>().color;
        UnityEngine.Vector4 val_47 = UnityEngine.Color.op_Implicit(c:  new UnityEngine.Color() {r = val_46.r, g = val_46.g, b = val_46.b, a = val_46.a});
        if(val_193 != 0)
        {
            goto label_77;
        }
        
        goto label_77;
        label_45:
        if(val_192 < val_2.Length)
        {
            goto label_79;
        }
        
        val_217 = "Ink_Timer";
        val_218 = 0;
        val_219 = 1f;
        goto label_80;
        label_398:
        val_199 = val_2[0];
        if((val_199 != null) && (null != null))
        {
                val_199 = 0;
        }
        
        if(this.buttonCounter == 0)
        {
            goto label_84;
        }
        
        label_275:
        if(this.buttonCounter != 1)
        {
            goto label_284;
        }
        
        if((System.String.op_Equality(a:  val_199.name, b:  "InkUpFingerText")) != false)
        {
                val_199.SetActive(value:  false);
        }
        
        if((System.String.op_Equality(a:  val_199.name, b:  "Ink_Timer")) != true)
        {
                if((System.String.op_Equality(a:  val_199.name, b:  "Button_Tick")) == false)
        {
            goto label_179;
        }
        
        }
        
        bool val_55 = UnityEngine.Object.op_Implicit(exists:  val_199.GetComponent<UnityEngine.SpriteRenderer>());
        if(val_199 == 0)
        {
            goto label_96;
        }
        
        if(val_55 == false)
        {
            goto label_97;
        }
        
        label_123:
        val_3 = 0;
        UnityEngine.Color val_57 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_207 = val_57.g;
        val_208 = val_57.a;
        val_199.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_57.r, g = val_207, b = val_57.b, a = val_208};
        if(val_199 != 0)
        {
            goto label_182;
        }
        
        goto label_100;
        label_84:
        if(((System.String.op_Equality(a:  val_199.name, b:  "Player")) != true) && ((System.String.op_Equality(a:  val_199.name, b:  "Button_Tick")) != true))
        {
                if((System.String.op_Equality(a:  val_199.name, b:  "Finger_Ink_Up")) != true)
        {
                if((System.String.op_Equality(a:  val_199.name, b:  "InkUpFingerText")) == false)
        {
            goto label_132;
        }
        
        }
        
        }
        
        bool val_67 = UnityEngine.Object.op_Implicit(exists:  val_199.GetComponent<UnityEngine.SpriteRenderer>());
        if(val_199 == 0)
        {
            goto label_112;
        }
        
        if(val_67 == false)
        {
            goto label_113;
        }
        
        label_117:
        val_3 = 0;
        UnityEngine.Color val_69 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_207 = val_69.g;
        val_208 = val_69.a;
        val_199.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_69.r, g = val_207, b = val_69.b, a = val_208};
        if(val_199 != 0)
        {
            goto label_135;
        }
        
        goto label_116;
        label_112:
        if(val_67 == true)
        {
            goto label_117;
        }
        
        label_113:
        bool val_71 = UnityEngine.Object.op_Implicit(exists:  val_199.GetComponent<UnityEngine.UI.Image>());
        if(val_199 == 0)
        {
            goto label_120;
        }
        
        if(val_71 == false)
        {
            goto label_121;
        }
        
        label_129:
        val_220 = 1152921526047750352;
        goto label_122;
        label_96:
        if(val_55 == true)
        {
            goto label_123;
        }
        
        label_97:
        bool val_73 = UnityEngine.Object.op_Implicit(exists:  val_199.GetComponent<UnityEngine.UI.Image>());
        if(val_199 == 0)
        {
            goto label_126;
        }
        
        if(val_73 == false)
        {
            goto label_127;
        }
        
        label_176:
        val_221 = 1152921526047750352;
        goto label_128;
        label_120:
        if(val_71 == true)
        {
            goto label_129;
        }
        
        label_121:
        if((UnityEngine.Object.op_Implicit(exists:  val_199.GetComponent<UnityEngine.UI.Text>())) == false)
        {
            goto label_132;
        }
        
        val_220 = 1152921526128259760;
        label_122:
        val_3 = 0;
        UnityEngine.Color val_77 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_207 = val_77.g;
        val_208 = val_77.a;
        val_199.GetComponent<UnityEngine.UI.Text>().color = new UnityEngine.Color() {r = val_77.r, g = val_207, b = val_77.b, a = val_208};
        label_132:
        if(val_199 != 0)
        {
            goto label_135;
        }
        
        label_116:
        label_135:
        if((System.String.op_Equality(a:  val_199.name, b:  "InkUpFingerText")) == false)
        {
            goto label_392;
        }
        
        System.Collections.IEnumerator val_81 = val_199.transform.GetEnumerator();
        goto label_167;
        label_174:
        var val_197 = 0;
        val_197 = val_197 + 1;
        object val_83 = val_81.Current;
        val_191 = 1;
        if((UnityEngine.Object.op_Implicit(exists:  0.GetComponent<UnityEngine.SpriteRenderer>())) != false)
        {
                val_3 = 0;
            UnityEngine.Color val_89 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_207 = val_89.g;
            val_208 = val_89.a;
            0.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_89.r, g = val_207, b = val_89.b, a = val_208};
        }
        else
        {
                if((UnityEngine.Object.op_Implicit(exists:  0.GetComponent<UnityEngine.UI.Image>())) != false)
        {
                val_3 = 0;
            UnityEngine.Color val_93 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_207 = val_93.g;
            val_208 = val_93.a;
            0.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_93.r, g = val_207, b = val_93.b, a = val_208};
        }
        else
        {
                if((UnityEngine.Object.op_Implicit(exists:  0.GetComponent<UnityEngine.UI.Text>())) != false)
        {
                val_3 = 0;
            UnityEngine.Color val_97 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_207 = val_97.g;
            val_208 = val_97.a;
            0.GetComponent<UnityEngine.UI.Text>().color = new UnityEngine.Color() {r = val_97.r, g = val_207, b = val_97.b, a = val_208};
        }
        
        }
        
        }
        
        label_167:
        var val_198 = 0;
        val_198 = val_198 + 1;
        if(val_81.MoveNext() == true)
        {
            goto label_174;
        }
        
        val_224 = 0;
        goto label_175;
        label_126:
        if(val_73 == true)
        {
            goto label_176;
        }
        
        label_127:
        if((UnityEngine.Object.op_Implicit(exists:  val_199.GetComponent<UnityEngine.UI.Text>())) == false)
        {
            goto label_179;
        }
        
        val_221 = 1152921526128259760;
        label_128:
        val_3 = 0;
        UnityEngine.Color val_103 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_207 = val_103.g;
        val_208 = val_103.a;
        val_199.GetComponent<UnityEngine.UI.Text>().color = new UnityEngine.Color() {r = val_103.r, g = val_207, b = val_103.b, a = val_208};
        label_179:
        if(val_199 != 0)
        {
            goto label_182;
        }
        
        label_100:
        label_182:
        if((System.String.op_Equality(a:  val_199.name, b:  "Ink_Timer")) == false)
        {
            goto label_392;
        }
        
        val_199.transform.GetChild(index:  1).gameObject.SetActive(value:  true);
        System.Collections.IEnumerator val_110 = val_199.transform.GetEnumerator();
        goto label_218;
        label_225:
        var val_199 = 0;
        val_199 = val_199 + 1;
        object val_112 = val_110.Current;
        val_191 = 1;
        if((UnityEngine.Object.op_Implicit(exists:  0.GetComponent<UnityEngine.SpriteRenderer>())) != false)
        {
                val_3 = 0;
            UnityEngine.Color val_118 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_207 = val_118.g;
            val_208 = val_118.a;
            0.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_118.r, g = val_207, b = val_118.b, a = val_208};
        }
        else
        {
                if((UnityEngine.Object.op_Implicit(exists:  0.GetComponent<UnityEngine.UI.Image>())) != false)
        {
                val_3 = 0;
            UnityEngine.Color val_122 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_207 = val_122.g;
            val_208 = val_122.a;
            0.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_122.r, g = val_207, b = val_122.b, a = val_208};
        }
        else
        {
                if((UnityEngine.Object.op_Implicit(exists:  0.GetComponent<UnityEngine.UI.Text>())) != false)
        {
                val_3 = 0;
            UnityEngine.Color val_126 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_207 = val_126.g;
            val_208 = val_126.a;
            0.GetComponent<UnityEngine.UI.Text>().color = new UnityEngine.Color() {r = val_126.r, g = val_207, b = val_126.b, a = val_208};
        }
        
        }
        
        }
        
        label_218:
        var val_200 = 0;
        val_200 = val_200 + 1;
        if(val_110.MoveNext() == true)
        {
            goto label_225;
        }
        
        val_227 = 0;
        goto label_226;
        label_175:
        if(val_110 != null)
        {
                var val_201 = 0;
            val_201 = val_201 + 1;
            val_110.Dispose();
        }
        
        var val_203 = 2;
        if((val_203 == 1) || (2404 != 2404))
        {
            goto label_275;
        }
        
        var val_202 = 0;
        val_202 = val_202 ^ 0;
        val_203 = val_203 + val_202;
        val_217 = "Ink_Timer";
        goto label_392;
        label_226:
        if(val_110 != null)
        {
                var val_204 = 0;
            val_204 = val_204 + 1;
            val_110.Dispose();
        }
        
        val_233 = val_203;
        if(val_233 == 1)
        {
            goto label_283;
        }
        
        val_217 = "Ink_Timer";
        if((47036416 + ((2 + (0 ^ 0))) << 2) != 2404)
        {
            goto label_284;
        }
        
        goto label_285;
        label_283:
        val_217 = "Ink_Timer";
        label_284:
        if(this.buttonCounter != 2)
        {
            goto label_389;
        }
        
        if((System.String.op_Equality(a:  val_199.name, b:  val_217)) != false)
        {
                val_199.transform.GetChild(index:  1).gameObject.SetActive(value:  false);
        }
        
        if((System.String.op_Equality(a:  val_199.tag, b:  "InkMeter")) != true)
        {
                if((System.String.op_Equality(a:  val_199.name, b:  "Button_Tick")) == false)
        {
            goto label_314;
        }
        
        }
        
        bool val_141 = UnityEngine.Object.op_Implicit(exists:  val_199.GetComponent<UnityEngine.SpriteRenderer>());
        if(val_199 == 0)
        {
            goto label_300;
        }
        
        if(val_141 == false)
        {
            goto label_301;
        }
        
        label_305:
        val_3 = 0;
        UnityEngine.Color val_143 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_207 = val_143.g;
        val_208 = val_143.a;
        val_199.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_143.r, g = val_207, b = val_143.b, a = val_208};
        if(val_199 != 0)
        {
            goto label_317;
        }
        
        goto label_304;
        label_300:
        if(val_141 == true)
        {
            goto label_305;
        }
        
        label_301:
        bool val_145 = UnityEngine.Object.op_Implicit(exists:  val_199.GetComponent<UnityEngine.UI.Image>());
        if(val_199 == 0)
        {
            goto label_308;
        }
        
        if(val_145 == false)
        {
            goto label_309;
        }
        
        label_311:
        val_234 = 1152921526047750352;
        goto label_310;
        label_308:
        if(val_145 == true)
        {
            goto label_311;
        }
        
        label_309:
        if((UnityEngine.Object.op_Implicit(exists:  val_199.GetComponent<UnityEngine.UI.Text>())) == false)
        {
            goto label_314;
        }
        
        val_234 = 1152921526128259760;
        label_310:
        val_3 = 0;
        UnityEngine.Color val_149 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_207 = val_149.g;
        val_208 = val_149.a;
        val_199.GetComponent<UnityEngine.UI.Text>().color = new UnityEngine.Color() {r = val_149.r, g = val_207, b = val_149.b, a = val_208};
        label_314:
        if(val_199 != 0)
        {
            goto label_317;
        }
        
        label_304:
        label_317:
        if((System.String.op_Equality(a:  val_199.tag, b:  "InkMeter")) == false)
        {
            goto label_392;
        }
        
        val_199.transform.GetChild(index:  5).gameObject.SetActive(value:  true);
        System.Collections.IEnumerator val_156 = val_199.transform.GetEnumerator();
        goto label_353;
        label_360:
        var val_205 = 0;
        val_205 = val_205 + 1;
        object val_158 = val_156.Current;
        val_191 = 1;
        if((UnityEngine.Object.op_Implicit(exists:  0.GetComponent<UnityEngine.SpriteRenderer>())) != false)
        {
                val_3 = 0;
            UnityEngine.Color val_164 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_207 = val_164.g;
            val_208 = val_164.a;
            0.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_164.r, g = val_207, b = val_164.b, a = val_208};
        }
        else
        {
                if((UnityEngine.Object.op_Implicit(exists:  0.GetComponent<UnityEngine.UI.Image>())) != false)
        {
                val_3 = 0;
            UnityEngine.Color val_168 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_207 = val_168.g;
            val_208 = val_168.a;
            0.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_168.r, g = val_207, b = val_168.b, a = val_208};
        }
        else
        {
                if((UnityEngine.Object.op_Implicit(exists:  0.GetComponent<UnityEngine.UI.Text>())) != false)
        {
                val_3 = 0;
            UnityEngine.Color val_172 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_207 = val_172.g;
            val_208 = val_172.a;
            0.GetComponent<UnityEngine.UI.Text>().color = new UnityEngine.Color() {r = val_172.r, g = val_207, b = val_172.b, a = val_208};
        }
        
        }
        
        }
        
        label_353:
        var val_206 = 0;
        val_206 = val_206 + 1;
        if(val_156.MoveNext() == true)
        {
            goto label_360;
        }
        
        val_237 = 0;
        if(val_156 != null)
        {
                var val_207 = 0;
            val_207 = val_207 + 1;
            val_156.Dispose();
        }
        
        val_233 = 1;
        if(val_233 == 1)
        {
            goto label_388;
        }
        
        val_217 = "Ink_Timer";
        if(2404 != 2404)
        {
            goto label_389;
        }
        
        label_285:
        var val_208 = 0;
        val_208 = val_208 ^ 0;
        val_233 = val_233 + val_208;
        goto label_392;
        label_388:
        val_217 = "Ink_Timer";
        label_389:
        if((System.String.op_Equality(a:  val_199.tag, b:  "InkMeter")) != false)
        {
                val_199 = val_199.transform.GetChild(index:  5).gameObject;
            val_199.SetActive(value:  false);
        }
        
        label_392:
        val_218 = 1;
        label_80:
        if(val_218 < val_2.Length)
        {
            goto label_398;
        }
        
        if(this.buttonCounter <= 3)
        {
                var val_209 = 40826604 + (this.buttonCounter) << 2;
            val_209 = val_209 + 40826604;
        }
        else
        {
                int val_210 = this.buttonCounter;
            val_210 = val_210 + 1;
            this.buttonCounter = val_210;
        }
    
    }
    public InkUpTutorialScript()
    {
        this.inkCountdown = 10f;
    }

}
