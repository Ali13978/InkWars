using UnityEngine;
private sealed class LineControllerAI.<CPUAttack>d__61 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineControllerAI <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerAI.<CPUAttack>d__61(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_187;
        int val_190;
        var val_199;
        var val_214;
        var val_215;
        var val_216;
        var val_217;
        var val_218;
        var val_219;
        var val_220;
        var val_221;
        var val_222;
        var val_223;
        var val_224;
        var val_225;
        var val_226;
        var val_227;
        var val_228;
        var val_229;
        var val_230;
        var val_231;
        var val_232;
        var val_233;
        var val_234;
        var val_235;
        var val_236;
        var val_237;
        var val_238;
        var val_239;
        var val_240;
        var val_241;
        var val_242;
        var val_243;
        var val_244;
        var val_245;
        var val_246;
        var val_247;
        float val_248;
        var val_249;
        var val_250;
        var val_251;
        var val_252;
        var val_253;
        var val_254;
        var val_255;
        var val_256;
        var val_257;
        var val_258;
        var val_259;
        var val_260;
        var val_261;
        var val_262;
        var val_263;
        var val_264;
        var val_270;
        var val_271;
        var val_272;
        var val_273;
        var val_274;
        var val_275;
        var val_276;
        var val_277;
        var val_278;
        var val_279;
        var val_280;
        float val_281;
        var val_282;
        float val_283;
        var val_284;
        var val_285;
        var val_286;
        var val_287;
        var val_288;
        var val_289;
        var val_290;
        var val_291;
        float val_292;
        var val_293;
        var val_294;
        var val_295;
        var val_296;
        var val_297;
        var val_298;
        var val_299;
        var val_300;
        var val_302;
        var val_303;
        var val_307;
        var val_308;
        var val_309;
        string val_310;
        val_187 = this;
        if((this.<>1__state) > 6)
        {
            goto label_1;
        }
        
        var val_189 = 40840288 + (this.<>1__state) << 2;
        val_189 = val_189 + 40840288;
        goto (40840288 + (this.<>1__state) << 2 + 40840288);
        label_1:
        val_190 = 0;
        return (bool)val_190;
        label_564:
        this.<>1__state = ;
        val_190 = 1;
        return (bool)val_190;
        label_241:
        val_215 = static_value_032DD328;
        val_215 = static_value_032DD328;
        mem2[0] = UnityEngine.Random.Range(min:  1, max:  7);
        val_216 = null;
        val_216 = null;
        ???.CalculateBallEntryUp(ringArray:  InstanceAnimator.playerOuterRingBalls, arrayLength:  17);
        val_217 = null;
        val_217 = null;
        ???.CalculateBallEntryUp(ringArray:  InstanceAnimator.playerMiddleRingBalls, arrayLength:  13);
        val_218 = static_value_032DD328;
        val_218 = static_value_032DD328;
        val_219 = null;
        val_219 = null;
        ???.CalculateBallEntryUp(ringArray:  InstanceAnimator.playerInnerRingBalls, arrayLength:  9);
        val_220 = static_value_032DD328;
        val_220 = static_value_032DD328;
        val_221 = null;
        val_221 = null;
        ???.CalculateBallEntryDown(ringArray:  InstanceAnimator.playerOuterRingBalls, arrayLength:  17);
        val_222 = static_value_032DD328;
        val_222 = static_value_032DD328;
        val_223 = null;
        val_223 = null;
        ???.CalculateBallEntryDown(ringArray:  InstanceAnimator.playerMiddleRingBalls, arrayLength:  13);
        val_224 = static_value_032DD328;
        val_224 = static_value_032DD328;
        val_225 = null;
        val_225 = null;
        ???.CalculateBallEntryDown(ringArray:  InstanceAnimator.playerInnerRingBalls, arrayLength:  9);
        val_226 = static_value_032DD328;
        val_227 = mem[static_value_032DD328 + 294];
        val_227 = static_value_032DD328 + 294;
        val_226 = static_value_032DD328;
        val_227 = mem[static_value_032DD328 + 294];
        val_227 = static_value_032DD328 + 294;
        val_228 = 0;
        val_229 = static_value_032DD328;
        mem2[0] = ;
        if((???) == 1)
        {
            goto label_180;
        }
        
        if((???) != 0)
        {
            goto label_219;
        }
        
        val_230 = mem[static_value_032DD328 + 294];
        val_230 = static_value_032DD328 + 294;
        val_231 = static_value_032DD328;
        val_230 = mem[static_value_032DD328 + 294];
        val_230 = static_value_032DD328 + 294;
        val_232 = mem[static_value_032DD328 + 184];
        val_232 = static_value_032DD328 + 184;
        val_233 = mem[static_value_032DD328 + 184 + 8];
        val_233 = static_value_032DD328 + 184 + 8;
        val_233 = mem[static_value_032DD328 + 184 + 8];
        val_233 = static_value_032DD328 + 184 + 8;
        var val_41 = (val_233 == 0) ? 0 : 3;
        goto label_219;
        label_180:
        val_234 = mem[static_value_032DD328 + 294];
        val_234 = static_value_032DD328 + 294;
        val_235 = static_value_032DD328;
        val_234 = mem[static_value_032DD328 + 294];
        val_234 = static_value_032DD328 + 294;
        val_236 = mem[static_value_032DD328 + 184];
        val_236 = static_value_032DD328 + 184;
        ??? + 128.GetComponent<BallSwipeCPU>().OnButtonDown();
        mem2[0] = new UnityEngine.WaitForSeconds(seconds:  ??? + 192);
        goto label_564;
        label_219:
        val_214 =  + 1;
        if(val_214 < 2)
        {
            goto label_241;
        }
        
        val_199 = static_value_032DD328;
        val_237 = mem[static_value_032DD328 + 294];
        val_237 = static_value_032DD328 + 294;
        val_199 = static_value_032DD328;
        val_237 = mem[static_value_032DD328 + 294];
        val_237 = static_value_032DD328 + 294;
        val_238 = mem[static_value_032DD328 + 184];
        val_238 = static_value_032DD328 + 184;
        val_239 = mem[static_value_032DD328 + 184 + 8];
        val_239 = static_value_032DD328 + 184 + 8;
        if(val_239 != 3)
        {
            goto label_244;
        }
        
        val_240 = mem[static_value_032DD328 + 184];
        val_240 = static_value_032DD328 + 184;
        val_241 = val_240.transform;
        if((???) == 0)
        {
            goto label_248;
        }
        
        val_242 = mem[??? + 264];
        val_242 = ??? + 264;
        goto label_249;
        label_244:
        val_199 = static_value_032DD328;
        val_243 = mem[static_value_032DD328 + 184];
        val_243 = static_value_032DD328 + 184;
        val_237 = mem[static_value_032DD328 + 294];
        val_237 = static_value_032DD328 + 294;
        val_239 = mem[static_value_032DD328 + 184 + 8];
        val_239 = static_value_032DD328 + 184 + 8;
        if(val_239 != 2)
        {
            goto label_252;
        }
        
        val_244 = mem[static_value_032DD328 + 184];
        val_244 = static_value_032DD328 + 184;
        val_241 = val_244.transform;
        if((???) == 0)
        {
            goto label_256;
        }
        
        val_242 = mem[??? + 264];
        val_242 = ??? + 264;
        goto label_257;
        label_252:
        val_199 = static_value_032DD328;
        val_245 = mem[static_value_032DD328 + 184];
        val_245 = static_value_032DD328 + 184;
        val_237 = mem[static_value_032DD328 + 294];
        val_237 = static_value_032DD328 + 294;
        val_239 = mem[static_value_032DD328 + 184 + 8];
        val_239 = static_value_032DD328 + 184 + 8;
        if(val_239 != 1)
        {
            goto label_260;
        }
        
        val_246 = mem[static_value_032DD328 + 184];
        val_246 = static_value_032DD328 + 184;
        val_241 = val_246.transform;
        if((???) == 0)
        {
            goto label_264;
        }
        
        val_242 = mem[??? + 264];
        val_242 = ??? + 264;
        goto label_265;
        label_248:
        val_242 = 36;
        label_249:
        val_247 = 1152921505075376128;
        val_248 = mem[??? + 292];
        val_248 = ??? + 292;
        goto label_275;
        label_260:
        val_199 = static_value_032DD328;
        val_249 = mem[static_value_032DD328 + 184];
        val_249 = static_value_032DD328 + 184;
        val_237 = mem[static_value_032DD328 + 294];
        val_237 = static_value_032DD328 + 294;
        val_239 = mem[static_value_032DD328 + 184 + 8];
        val_239 = static_value_032DD328 + 184 + 8;
        if(val_239 != 4)
        {
            goto label_269;
        }
        
        val_250 = mem[static_value_032DD328 + 184];
        val_250 = static_value_032DD328 + 184;
        UnityEngine.Transform val_67 = val_250.transform;
        if((???) == 0)
        {
            goto label_273;
        }
        
        val_251 = mem[??? + 264];
        val_251 = ??? + 264;
        goto label_274;
        label_256:
        val_242 = 36;
        label_257:
        val_247 = 1152921505075376128;
        val_248 = mem[??? + 296];
        val_248 = ??? + 296;
        goto label_275;
        label_269:
        val_199 = static_value_032DD328;
        val_252 = mem[static_value_032DD328 + 184];
        val_252 = static_value_032DD328 + 184;
        val_237 = mem[static_value_032DD328 + 294];
        val_237 = static_value_032DD328 + 294;
        val_239 = mem[static_value_032DD328 + 184 + 8];
        val_239 = static_value_032DD328 + 184 + 8;
        if(val_239 != 5)
        {
            goto label_278;
        }
        
        val_253 = mem[static_value_032DD328 + 184];
        val_253 = static_value_032DD328 + 184;
        UnityEngine.Transform val_68 = val_253.transform;
        if((???) == 0)
        {
            goto label_282;
        }
        
        val_251 = mem[??? + 264];
        val_251 = ??? + 264;
        goto label_283;
        label_264:
        val_242 = 36;
        label_265:
        val_247 = 1152921505075376128;
        val_248 = mem[??? + 300];
        val_248 = ??? + 300;
        label_275:
        val_254 = null;
        float val_197 = (float)-InstanceAnimator.playerNegateX;
        val_197 = val_248 * val_197;
        float val_69 = val_197 + 36f;
        label_509:
        val_241.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_478:
        label_479:
        ??? + 320.PlayAnimation(newAnimName:  0, forceOverride:  false);
        val_255 = null;
        val_255 = null;
        VoiceManager.instance.PlayAttackSound(Left:  0, SoundType:  0, modifiers:  0);
        val_256 = static_value_032DD328;
        val_256 = static_value_032DD328;
        if((static_value_032DD328 + 184.gameObject.CompareTag(tag:  "Iron_Ball")) == true)
        {
            goto label_300;
        }
        
        val_257 = static_value_032DD328;
        val_257 = static_value_032DD328;
        if((static_value_032DD328 + 184.gameObject.CompareTag(tag:  "Stunner_Ball")) == true)
        {
            goto label_300;
        }
        
        val_258 = static_value_032DD328;
        val_258 = static_value_032DD328;
        if((static_value_032DD328 + 184.gameObject.CompareTag(tag:  "Rainbow_Bubble")) == false)
        {
            goto label_305;
        }
        
        label_300:
        val_259 = static_value_032DD328;
        val_259 = static_value_032DD328;
        static_value_032DD328 + 184.gameObject.transform.Find(n:  "TrailNormal").gameObject.SetActive(value:  false);
        val_260 = static_value_032DD328;
        if((static_value_032DD328 + 184.gameObject.CompareTag(tag:  "Iron_Ball")) == false)
        {
            goto label_315;
        }
        
        val_261 = static_value_032DD328;
        static_value_032DD328 + 184.gameObject.transform.GetChild(index:  4).gameObject.SetActive(value:  true);
        val_262 = null;
        val_262 = null;
        UnityEngine.AudioSource val_86 = VoiceManager.instance.Source;
        if(val_86 != null)
        {
            goto label_414;
        }
        
        label_415:
        label_414:
        val_86.PlayOneShot(clip:  ??? + 216 + 64, volumeScale:  1f);
        label_401:
        val_263 = static_value_032DD328;
        val_263 = static_value_032DD328;
        UnityEngine.Transform val_89 = static_value_032DD328 + 184.gameObject.transform.GetChild(index:  0);
        val_89.gameObject.SetActive(value:  true);
        val_89.gameObject.GetComponent<UnityEngine.Animator>().Play(stateName:  static_value_032DD328 + 184.gameObject.tag);
        label_473:
        val_264 = static_value_032DD328;
        val_264 = static_value_032DD328;
        static_value_032DD328 + 184.gameObject.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        UnityEngine.Vector3 val_98 = static_value_032DD328 + 184.transform.right;
        UnityEngine.Vector3 val_99 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_98.x, y = val_98.y, z = val_98.z}, d:  -(??? + 32));
        UnityEngine.Vector2 val_100 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_99.x, y = val_99.y, z = val_99.z});
        static_value_032DD328 + 184.AddRelativeForce(relativeForce:  new UnityEngine.Vector2() {x = val_100.x, y = val_100.y}, mode:  0);
        UnityEngine.Vector3 val_102 = static_value_032DD328 + 184.transform.localEulerAngles;
        UnityEngine.Vector3 val_103 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_102.x, y = val_102.y, z = val_102.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        System.Collections.IEnumerator val_105 = static_value_032DD328 + 184.transform.GetEnumerator();
        goto label_369;
        label_376:
        var val_198 = 0;
        val_198 = val_198 + 1;
        if(val_105.Current != null)
        {
            
        }
        
        UnityEngine.Vector3 val_109 = 0.localEulerAngles;
        UnityEngine.Vector3 val_110 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_109.x, y = val_109.y, z = val_109.z}, b:  new UnityEngine.Vector3() {x = val_103.x, y = val_103.y, z = val_103.z});
        0.localEulerAngles = new UnityEngine.Vector3() {x = val_110.x, y = val_110.y, z = val_110.z};
        label_369:
        var val_199 = 0;
        val_199 = val_199 + 1;
        if(val_105.MoveNext() == true)
        {
            goto label_376;
        }
        
        val_270 = 0;
        goto label_377;
        label_315:
        val_271 = static_value_032DD328;
        val_272 = static_value_032DD328;
        if((static_value_032DD328 + 184.gameObject.CompareTag(tag:  "Stunner_Ball")) == false)
        {
            goto label_382;
        }
        
        val_273 = static_value_032DD328;
        static_value_032DD328 + 184.gameObject.transform.GetChild(index:  5).gameObject.SetActive(value:  true);
        val_274 = null;
        val_274 = null;
        if(VoiceManager.instance.Source != null)
        {
            goto label_414;
        }
        
        goto label_415;
        label_382:
        val_275 = static_value_032DD328;
        if((static_value_032DD328 + 184.gameObject.CompareTag(tag:  "Rainbow_Bubble")) == false)
        {
            goto label_401;
        }
        
        val_276 = static_value_032DD328;
        val_276 = static_value_032DD328;
        static_value_032DD328 + 184.gameObject.transform.GetChild(index:  2).gameObject.SetActive(value:  true);
        val_277 = null;
        val_277 = null;
        if(VoiceManager.instance.Source != null)
        {
            goto label_414;
        }
        
        goto label_415;
        label_305:
        val_278 = static_value_032DD328;
        val_278 = static_value_032DD328;
        static_value_032DD328 + 184.gameObject.transform.Find(n:  "TrailNormal").gameObject.SetActive(value:  true);
        val_279 = static_value_032DD328;
        if((static_value_032DD328 + 184.gameObject.CompareTag(tag:  "Red")) == false)
        {
            goto label_425;
        }
        
        val_280 = static_value_032DD328;
        val_281 = 0.6f;
        val_282 = static_value_032DD328 + 184.gameObject.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        val_283 = 0f;
        goto label_529;
        label_425:
        val_284 = static_value_032DD328;
        val_285 = static_value_032DD328;
        if((static_value_032DD328 + 184.gameObject.CompareTag(tag:  "Yellow")) == false)
        {
            goto label_438;
        }
        
        val_286 = static_value_032DD328;
        val_283 = 0.92f;
        val_281 = 0.6f;
        val_282 = static_value_032DD328 + 184.gameObject.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_529;
        label_278:
        val_199 = static_value_032DD328;
        val_287 = mem[static_value_032DD328 + 184];
        val_287 = static_value_032DD328 + 184;
        val_237 = mem[static_value_032DD328 + 294];
        val_237 = static_value_032DD328 + 294;
        val_239 = mem[static_value_032DD328 + 184 + 8];
        val_239 = static_value_032DD328 + 184 + 8;
        if(val_239 != 6)
        {
            goto label_449;
        }
        
        val_287 = mem[static_value_032DD328 + 184];
        val_287 = static_value_032DD328 + 184;
        UnityEngine.Transform val_145 = val_287.transform;
        if((???) == 0)
        {
            goto label_453;
        }
        
        val_251 = mem[??? + 264];
        val_251 = ??? + 264;
        goto label_454;
        label_438:
        val_288 = static_value_032DD328;
        val_289 = static_value_032DD328;
        if((static_value_032DD328 + 184.gameObject.CompareTag(tag:  "Blue")) == false)
        {
            goto label_459;
        }
        
        val_290 = static_value_032DD328;
        val_281 = 0.6f;
        val_282 = static_value_032DD328 + 184.gameObject.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        val_283 = 0f;
        label_529:
        UnityEngine.Color val_153 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_282.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = val_153.r, g = val_153.g, b = val_153.b, a = val_153.a});
        label_521:
        UnityEngine.AudioSource val_155 = GameAudio.sound.PlayOneShot(clip:  ??? + 216 + 32, volume:  1f);
        goto label_473;
        label_273:
        val_251 = 36;
        label_274:
        val_291 = 1152921505075376128;
        val_292 = mem[??? + 292];
        val_292 = ??? + 292;
        goto label_493;
        label_449:
        val_293 = mem[static_value_032DD328 + 184];
        val_293 = static_value_032DD328 + 184;
        val_239 = mem[static_value_032DD328 + 184 + 8];
        val_239 = static_value_032DD328 + 184 + 8;
        if((???) != 0)
        {
            goto label_478;
        }
        
        goto label_479;
        label_459:
        val_294 = static_value_032DD328;
        val_295 = static_value_032DD328;
        if((static_value_032DD328 + 184.gameObject.CompareTag(tag:  "Green")) == false)
        {
            goto label_484;
        }
        
        val_296 = static_value_032DD328;
        UnityEngine.Material val_162 = static_value_032DD328 + 184.gameObject.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_529;
        label_282:
        val_251 = 36;
        label_283:
        val_291 = 1152921505075376128;
        val_292 = mem[??? + 296];
        val_292 = ??? + 296;
        goto label_493;
        label_484:
        val_297 = static_value_032DD328;
        val_298 = static_value_032DD328;
        if((static_value_032DD328 + 184.gameObject.CompareTag(tag:  "Orange")) == false)
        {
            goto label_498;
        }
        
        val_299 = static_value_032DD328;
        UnityEngine.Material val_169 = static_value_032DD328 + 184.gameObject.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_529;
        label_453:
        val_251 = 36;
        label_454:
        val_291 = 1152921505075376128;
        val_292 = mem[??? + 300];
        val_292 = ??? + 300;
        label_493:
        val_300 = null;
        float val_200 = (float)-InstanceAnimator.playerNegateX;
        val_200 = val_292 * val_200;
        float val_170 = 36f - val_200;
        goto label_509;
        label_498:
        val_302 = static_value_032DD328;
        if((static_value_032DD328 + 184.gameObject.CompareTag(tag:  "Purple")) == false)
        {
            goto label_521;
        }
        
        val_303 = static_value_032DD328;
        val_303 = static_value_032DD328;
        UnityEngine.Material val_178 = static_value_032DD328 + 184.gameObject.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_529;
        label_377:
        if(val_178 != null)
        {
                var val_202 = 0;
            val_202 = val_202 + 1;
            val_178.Dispose();
        }
        
        val_307 = static_value_032DD328;
        val_307 = static_value_032DD328;
        static_value_032DD328 + 184.transform.rotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        val_308 = mem[static_value_032DD328 + 184];
        val_308 = static_value_032DD328 + 184;
        val_309 = mem[static_value_032DD328 + 184];
        val_309 = static_value_032DD328 + 184;
        mem2[0] = val_309.gameObject.tag;
        val_310 = "ActivateCollider";
        UnityEngine.Coroutine val_187 = ???.StartCoroutine(methodName:  null);
        mem2[0] = new UnityEngine.WaitForSeconds(seconds:  0f);
        goto label_564;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
