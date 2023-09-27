using UnityEngine;
public class View_Bubble : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject template_PopAnim;
    public UnityEngine.GameObject template_PopAnim_StunEffect;
    public UnityEngine.GameObject template_ScoreAnim;
    public UnityEngine.SpriteRenderer spriteRenderer;
    public UnityEngine.Animator trailGO_SpecialAnimator;
    private BubbleLayerCollection bubbleLayers;
    private TrailColorCollection overrideableTrailColors;
    private TrailRendererCollection trailRenderers;
    private TrailAnimatorCollection animatorClipNames;
    private System.Collections.Generic.List<BubbleEffectData> effects;
    private BubbleSFXCollection shootSounds;
    private BubbleSFXCollection hitSounds;
    private BubbleSFXCollection popSounds;
    private System.Collections.Generic.List<BubbleEffectData> activedEffects;
    private InkWars.Model.BubbleTypes _bubbleType;
    public View_Objects Player_ScoreTarget;
    public InkWars.Model.Model_Bubble modelBubble;
    private UnityEngine.GameObject trailGO_LastUsed;
    private System.Nullable<UnityEngine.Vector3> LastPos;
    private int _PositionState;
    private bool SpecialTrailActive;
    private float TrailAlpha;
    public UnityEngine.Sprite InkEmUp_InkBlob_Small;
    public UnityEngine.Sprite InkEmUp_InkBlob_Large;
    public UnityEngine.AudioClip InkEmUp_Audio_InkHitSmall;
    public UnityEngine.AudioClip InkEmUp_Audio_InkHitLarge;
    public InkStates InkEmUp_InkState;
    private View_Bubble.TargetValues InkEmUp_Target;
    private float InkEmUp_Speed;
    private float InkEmUp_Radius;
    private float InkEmUp_Radius_Start;
    private float InkEmUp_Angle;
    private float InkEmUp_Lerp;
    private bool InkEmUp_IsFinalInk;
    private System.Collections.Generic.Queue<BubbleEffectEventQueueItem> customBubbleEffectEventQueue;
    
    // Properties
    public InkWars.Model.BubbleTypes bubbleType { get; }
    public int PositionState { get; }
    
    // Methods
    public InkWars.Model.BubbleTypes get_bubbleType()
    {
        return (InkWars.Model.BubbleTypes)this._bubbleType;
    }
    public int get_PositionState()
    {
        return (int)this._PositionState;
    }
    public void SetPosition(UnityEngine.Vector3 pos, int posState)
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        this.LastPos = 0;
        mem[1152921528330756928] = 0;
        this.transform.position = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
        this._PositionState = posState;
    }
    private void Update()
    {
        var val_45 = this;
        if(this._bubbleType != 11)
        {
                return;
        }
        
        InkStates val_43 = this.InkEmUp_InkState;
        val_43 = val_43 - 1;
        if(val_43 > 5)
        {
                return;
        }
        
        var val_44 = 40825336 + ((this.InkEmUp_InkState - 1)) << 2;
        val_44 = val_44 + 40825336;
        goto (40825336 + ((this.InkEmUp_InkState - 1)) << 2 + 40825336);
    }
    public void ShootAsInk(bool FinalBubble = False)
    {
        var val_6;
        TargetValues val_7;
        this.InkEmUp_InkState = 4;
        this.InkEmUp_IsFinalInk = FinalBubble;
        this.InkEmUp_Lerp = 0f;
        View_Core val_2 = View_Core.Instance;
        UnityEngine.Vector3 val_3 = val_2.InkEmUp_Player_Loser.CenterPoint.position;
        TargetValues val_5 = this.GetTarget(point:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, random:  (this.InkEmUp_IsFinalInk == false) ? 1 : 0);
        mem[1152921528331275752] = val_6;
        this.InkEmUp_Target = val_7;
    }
    private View_Bubble.TargetValues GetTarget(UnityEngine.Vector3 point, bool random = True)
    {
        float val_6;
        float val_7;
        TargetValues val_0;
        val_6 = point.y;
        val_7 = point.x;
        UnityEngine.Vector3 val_2 = this.transform.position;
        if(random != false)
        {
                val_7 = val_7 + (UnityEngine.Random.Range(min:  -0.5f, max:  0.5f));
            val_6 = val_6 + (UnityEngine.Random.Range(min:  -0.5f, max:  0.5f));
        }
        
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7, y = val_6, z = point.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        val_0.OriginalPos.x = val_2.x;
        val_0.OriginalPos.y = val_2.y;
        val_0.OriginalPos.z = val_2.z;
        val_0.TargetPos.x = val_7;
        val_0.TargetPos.y = val_6;
        val_0.TargetPos.z = point.z;
        val_0.Distance = System.Math.Abs(val_5.x);
        return val_0;
    }
    private System.Collections.IEnumerator DelayPop(InkWars.Model.BubbleTypes type)
    {
        View_Bubble.<DelayPop>d__43 val_1 = new View_Bubble.<DelayPop>d__43();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .type = type;
        return (System.Collections.IEnumerator)val_1;
    }
    private void CreatePopAnim(InkWars.Model.BubbleTypes type, string customPopType, int sortingOrder)
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        UnityEngine.Quaternion val_4 = this.transform.rotation;
        UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.template_PopAnim, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}).GetComponent<View_PopAnimations>().Initialize(type:  type, customAnimKey:  customPopType, basedLayer:  sortingOrder);
    }
    private void CreateScorePopUp()
    {
        if(this.modelBubble.Score == 0)
        {
                return;
        }
        
        View_Core val_2 = View_Core.Instance;
        InkWars.Model.Model_Manager val_7 = InkWars.Model.Model_Manager.Instance;
        InkWars.Model.Model_Player val_8 = val_7.Model.LeftPlayer;
        View_Core val_9 = View_Core.Instance;
        UnityEngine.Vector3 val_13 = this.transform.position;
        UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.template_ScoreAnim, parent:  val_2.canvas_UI.transform).GetComponent<View_ScorePopUp>().Initialize(score:  this.modelBubble.Score, pos:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, size:  0, playerScoreTarget:  (this.modelBubble.scoreTargetID == val_8.ID) ? val_9.LeftPlayer : val_9.RightPlayer, comboType:  this.modelBubble.ComboType);
        this = this.modelBubble;
        this.modelBubble.ComboType = 0;
    }
    public void SetBubble(InkWars.Model.BubbleTypes type, bool bubbleAddedToGrid = False)
    {
        bool val_1 = bubbleAddedToGrid;
        if(this._bubbleType == type)
        {
                this.RedirectBubbleEffectOrientation();
            return;
        }
        
        this.SetBubbleObjectNameToType(aNewBubbleType:  type);
        if((type != 0) || (val_1 == true))
        {
            goto label_4;
        }
        
        if((this.modelBubble.Health & 2147483648) != 0)
        {
            goto label_6;
        }
        
        this.ResetBubble();
        goto label_7;
        label_4:
        if(type == 0)
        {
            goto label_8;
        }
        
        val_1 = this.modelBubble;
        this._bubbleType = type;
        if(this.modelBubble.activeTypeSwitchAnim == false)
        {
            goto label_10;
        }
        
        this.SwitchBubbleWithAnim();
        return;
        label_8:
        this.ResetBubble();
        return;
        label_6:
        this.StartDelayPopCoroutine();
        label_7:
        this._bubbleType = 0;
        return;
        label_10:
        this.SetupBubble();
    }
    private void StartDelayPopCoroutine()
    {
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        if(this.gameObject.activeSelf == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.DelayPop(type:  this._bubbleType));
    }
    public void SwitchBubbleWithAnim()
    {
        if((this.PlayEffects(type:  0, customAnimKey:  "BubbleChange")) != false)
        {
                return;
        }
        
        this.SetupBubble();
    }
    public void OnSwitchBubbleType()
    {
        this.SetupBubble();
    }
    private void SetupBubble()
    {
        this.ShowBubble();
        this.SetBubbleSprite(aNewBubbleType:  this._bubbleType);
        bool val_1 = this.PlayEffects(type:  this._bubbleType, customAnimKey:  0);
        this.PlayBubbleSound(aNewBubbleType:  this._bubbleType);
        this.SetBubbleTrail(bubbleType:  this._bubbleType);
        if(this._bubbleType == 11)
        {
                this.InitInkBubble();
        }
        
        this.RedirectBubbleEffectOrientation();
        this.ScaleGameObjects();
    }
    private void ScaleGameObjects()
    {
        var val_20;
        var val_21;
        UnityEngine.Rect val_2 = this.spriteRenderer.sprite.rect;
        float val_21 = val_2.m_XMin;
        float val_20 = 0.0078125f;
        val_20 = val_21 * val_20;
        val_21 = val_20 / ((this.modelBubble.BubbleState == 1) ? 0.78f : 1f);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        float val_22 = 0.9f;
        val_22 = val_22 / val_21;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  val_22, a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        this.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        System.Collections.IEnumerator val_8 = this.transform.GetEnumerator();
        label_27:
        var val_23 = 0;
        val_23 = val_23 + 1;
        if(val_8.MoveNext() == false)
        {
            goto label_13;
        }
        
        var val_24 = 0;
        val_24 = val_24 + 1;
        val_20 = val_8.Current;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(d:  val_21, a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        if(val_20 != null)
        {
                val_20 = 0;
        }
        
        val_20.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        goto label_27;
        label_13:
        val_21 = 0;
        if(val_8 != null)
        {
                var val_25 = 0;
            val_25 = val_25 + 1;
            val_8.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    private void SetBubbleObjectNameToType(InkWars.Model.BubbleTypes aNewBubbleType)
    {
        aNewBubbleType.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        this.gameObject.name = aNewBubbleType.ToString();
    }
    private void ShowBubble()
    {
        View_Core val_2 = View_Core.Instance;
        this.gameObject.SetActive(value:  (val_2.enableBubbleDisplay == true) ? 1 : 0);
    }
    private void SetBubbleSprite(InkWars.Model.BubbleTypes aNewBubbleType)
    {
        var val_6;
        View_Core val_1 = View_Core.Instance;
        val_6 = null;
        val_6 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Settings.SelectedBubble;
        this.spriteRenderer.sprite = val_1.m_bubblesCollection.GetBubbleSpriteByFamilyAndType(family:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited}), type:  aNewBubbleType);
        this.spriteRenderer.sortingOrder = this.bubbleLayers.Get(aNewKey:  aNewBubbleType);
    }
    private void PlayBubbleSound(InkWars.Model.BubbleTypes aNewBubbleType)
    {
        BubbleSFXCollection val_6;
        if(this.modelBubble.BubbleState == 1)
        {
                SoundList val_1 = GameAudio.sound;
            val_6 = this.shootSounds;
        }
        else
        {
                if(this.modelBubble.BubbleState != 2)
        {
                return;
        }
        
            val_6 = this.hitSounds;
        }
        
        UnityEngine.AudioSource val_4 = GameAudio.sound.PlayOneShot(clip:  val_6.Get(aNewKey:  aNewBubbleType), volume:  1f);
    }
    private void InitInkBubble()
    {
        var val_11;
        TargetValues val_12;
        this.InkEmUp_InkState = 1;
        this.InkEmUp_Lerp = 0f;
        View_Core val_1 = View_Core.Instance;
        UnityEngine.Vector3 val_2 = val_1.InkEmUp_Player_Winner.InkPool.position;
        UnityEngine.Vector3 val_4 = this.transform.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  -0.5f, a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Vector3 val_8 = this.transform.position;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        TargetValues val_10 = this.GetTarget(point:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, random:  false);
        mem[1152921528333647912] = val_11;
        this.InkEmUp_Target = val_12;
        UnityEngine.Vector3 val_15 = this.gameObject.transform.localScale;
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        float val_21 = 0.7f;
        val_16.x = val_16.x * val_21;
        val_21 = val_16.y * val_21;
        UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  val_16.x, y:  val_21);
        UnityEngine.Vector3 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
        this.gameObject.transform.localScale = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        this.modelBubble.customPopType = 0;
    }
    public bool PlayEffects(InkWars.Model.BubbleTypes type, string customAnimKey)
    {
        UnityEngine.RectTransform val_13;
        UnityEngine.Object val_14;
        var val_30;
        var val_31;
        var val_32;
        UnityEngine.DrivenTransformProperties val_33;
        UnityEngine.RectTransform val_34;
        UnityEngine.Object val_35;
        var val_36;
        var val_37;
        var val_38;
        System.Predicate<BubbleEffectEventData> val_40;
        val_30 = this;
        View_Bubble.<>c__DisplayClass57_0 val_1 = new View_Bubble.<>c__DisplayClass57_0();
        if(val_1 != null)
        {
                .type = type;
        }
        else
        {
                mem[16] = type;
        }
        
        .customAnimKey = customAnimKey;
        val_31 = 1152921504616218624;
        System.Predicate<BubbleEffectData> val_2 = null;
        val_32 = 1152921528333802192;
        val_33 = public System.Void System.Predicate<BubbleEffectData>::.ctor(object object, IntPtr method);
        val_2 = new System.Predicate<BubbleEffectData>(object:  val_1, method:  System.Boolean View_Bubble.<>c__DisplayClass57_0::<PlayEffects>b__0(BubbleEffectData x));
        val_34 = public System.Collections.Generic.List<T> System.Collections.Generic.List<BubbleEffectData>::FindAll(System.Predicate<T> match);
        val_35 = this.effects.FindAll(match:  val_2);
        if(val_35 != null)
        {
                if(val_35.Count != 0)
        {
            goto label_5;
        }
        
        }
        
        System.Predicate<BubbleEffectData> val_5 = null;
        val_33 = public System.Void System.Predicate<BubbleEffectData>::.ctor(object object, IntPtr method);
        val_5 = new System.Predicate<BubbleEffectData>(object:  val_1, method:  System.Boolean View_Bubble.<>c__DisplayClass57_0::<PlayEffects>b__1(BubbleEffectData x));
        val_34 = public System.Collections.Generic.List<T> System.Collections.Generic.List<BubbleEffectData>::FindAll(System.Predicate<T> match);
        val_35 = this.effects.FindAll(match:  val_5);
        if(val_35 == null)
        {
            goto label_7;
        }
        
        label_5:
        if(val_35.Count != 0)
        {
            goto label_8;
        }
        
        label_7:
        System.Predicate<BubbleEffectData> val_8 = null;
        val_33 = public System.Void System.Predicate<BubbleEffectData>::.ctor(object object, IntPtr method);
        val_8 = new System.Predicate<BubbleEffectData>(object:  val_1, method:  System.Boolean View_Bubble.<>c__DisplayClass57_0::<PlayEffects>b__2(BubbleEffectData x));
        val_34 = public System.Collections.Generic.List<T> System.Collections.Generic.List<BubbleEffectData>::FindAll(System.Predicate<T> match);
        val_35 = this.effects.FindAll(match:  val_8);
        if(val_35 == null)
        {
                return (bool)val_36;
        }
        
        label_8:
        val_36 = val_35;
        if(val_36.Count == 0)
        {
                return (bool)val_36;
        }
        
        List.Enumerator<T> val_11 = val_35.GetEnumerator();
        val_32 = 1152921528333837008;
        val_31 = 1152921504858337280;
        val_37 = 0;
        goto label_14;
        label_45:
        0.Add(driver:  public System.Void List.Enumerator<BubbleEffectEventData>::Dispose(), rectTransform:  val_34, drivenProperties:  val_33);
        if(as. 
           
           
          
        
        
        
         != 0)
        {
                val_34 = 0;
        }
        
        val_37 = 0;
        if( != 1)
        {
                var val_15 = ((1152921528333930720 + (val_14) << 2) == 437) ? 1 : 0;
            val_15 = (( >= 0) ? 1 : 0) & val_15;
            val_37 =  - val_15;
        }
        
        label_14:
        val_14 = val_37;
        label_33:
        if(((-2042719952) & 1) == 0)
        {
            goto label_15;
        }
        
        if(0 == )
        {
            goto label_33;
        }
        
        if(this.modelBubble.BubbleState == 2)
        {
                if(this.modelBubble.BubbleState == 0)
        {
            goto label_33;
        }
        
        }
        
        if(this.modelBubble.BubbleState != 1)
        {
                if(this.modelBubble.BubbleState != 1)
        {
            goto label_26;
        }
        
        }
        
        if(this.modelBubble.BubbleState == 0)
        {
            goto label_33;
        }
        
        label_26:
        UnityEngine.GameObject val_19 = this.modelBubble.gameObject;
        val_19.SetActive(value:  true);
        InkWars.Model.SortingLayerOrder val_21 = this.bubbleLayers.Get(aNewKey:  this._bubbleType);
        val_21.PlayAllEffectsFromGameObject(rootObject:  val_19.gameObject, layer:  this.modelBubble.BubbleState + val_21);
        this.activedEffects.Add(item:  val_13.InitialType);
        if(this.activedEffects == null)
        {
            goto label_33;
        }
        
        val_38 = null;
        val_38 = null;
        val_40 = View_Bubble.<>c.<>9__57_3;
        if(val_40 == null)
        {
                val_40 = null;
            val_40 = new System.Predicate<BubbleEffectEventData>(object:  View_Bubble.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean View_Bubble.<>c::<PlayEffects>b__57_3(BubbleEffectEventData x));
            View_Bubble.<>c.<>9__57_3 = val_40;
        }
        
        int val_24 = this.activedEffects.RemoveAll(match:  null);
        List.Enumerator<T> val_25 = this.activedEffects.GetEnumerator();
        label_44:
        if(((-2042719984) & 1) == 0)
        {
            goto label_40;
        }
        
        new BubbleEffectEventQueueItem() = new BubbleEffectEventQueueItem();
        if(new BubbleEffectEventQueueItem() != null)
        {
                .particle = 1152921528333225616;
        }
        else
        {
                mem[16] = 1152921528333225616;
        }
        
        .eventData = val_13.InitialType;
        this.customBubbleEffectEventQueue.Enqueue(item:  new BubbleEffectEventQueueItem());
        goto label_44;
        label_40:
        var val_28 = val_14 + 1;
        mem2[0] = 437;
        goto label_45;
        label_15:
        var val_29 = val_14;
        val_29 = val_29 + 1;
        mem2[0] = 465;
        val_13.Add(driver:  public System.Void List.Enumerator<BubbleEffectData>::Dispose(), rectTransform:  val_34, drivenProperties:  val_33);
        val_36 = 1;
        return (bool)val_36;
    }
    private void PlayAllEffectsFromGameObject(UnityEngine.GameObject rootObject, int layer)
    {
        T val_17;
        var val_18;
        if(0 == rootObject)
        {
                return;
        }
        
        if(0 != (rootObject.GetComponent<UnityEngine.ParticleSystemRenderer>()))
        {
                rootObject.GetComponent<UnityEngine.ParticleSystemRenderer>().sortingOrder = layer;
            if(0 != (rootObject.GetComponent<UnityEngine.ParticleSystem>()))
        {
                if((rootObject.GetComponent<UnityEngine.ParticleSystem>().isPlaying) != true)
        {
                rootObject.GetComponent<UnityEngine.ParticleSystem>().Play();
        }
        
        }
        
        }
        
        val_17 = 1152921528334175312;
        if((rootObject.GetComponentsInChildren<UnityEngine.ParticleSystemRenderer>()) == null)
        {
                return;
        }
        
        val_18 = 0;
        goto label_22;
        label_35:
        val_17 = rootObject.GetComponentsInChildren<UnityEngine.ParticleSystemRenderer>()[0];
        if(val_17 != 0)
        {
                val_17.sortingOrder = layer;
        }
        else
        {
                0.sortingOrder = layer;
        }
        
        if(0 != (val_17.GetComponent<UnityEngine.ParticleSystem>()))
        {
                if((val_17.GetComponent<UnityEngine.ParticleSystem>().isPlaying) != true)
        {
                val_17 = val_17.GetComponent<UnityEngine.ParticleSystem>();
            val_17.Play();
        }
        
        }
        
        val_18 = 1;
        label_22:
        if(val_18 < val_11.Length)
        {
            goto label_35;
        }
    
    }
    private void FixedUpdate()
    {
        System.Collections.Generic.Queue<BubbleEffectEventQueueItem> val_6;
        var val_7;
        val_6 = this.customBubbleEffectEventQueue;
        if(val_6 == null)
        {
            goto label_1;
        }
        
        val_7 = 0;
        if(val_6 != null)
        {
            goto label_12;
        }
        
        goto label_3;
        label_1:
        if(0.Count < 1)
        {
                return;
        }
        
        val_7 = 0;
        goto label_5;
        label_13:
        BubbleEffectEventQueueItem val_2 = this.customBubbleEffectEventQueue.Dequeue();
        if((val_2 != null) && (val_2.valid != false))
        {
                if(val_2.canTrigger != false)
        {
                val_2.TriggerEvent();
        }
        else
        {
                this.customBubbleEffectEventQueue.Enqueue(item:  val_2);
        }
        
        }
        
        val_7 = 1;
        label_5:
        val_6 = this.customBubbleEffectEventQueue;
        if(val_6 != null)
        {
            goto label_12;
        }
        
        label_3:
        label_12:
        if(val_7 < val_6.Count)
        {
            goto label_13;
        }
    
    }
    public void ResetBubble()
    {
        var val_4;
        this.spriteRenderer.sortingOrder = 5;
        this.LastPos = 0;
        mem[1152921528334690752] = 0;
        this._PositionState = 0;
        this._bubbleType = 0;
        this.gameObject.SetActive(value:  false);
        this.ResetTrail();
        List.Enumerator<T> val_2 = this.effects.GetEnumerator();
        label_12:
        if(((-2041972272) & 1) == 0)
        {
            goto label_4;
        }
        
        System.Type val_5 = val_4.InitialType;
        if((val_5 == null) || (0 == X21))
        {
            goto label_12;
        }
        
        X21.Stop();
        val_5.gameObject.SetActive(value:  false);
        goto label_12;
        label_4:
        val_4.Add(driver:  public System.Void List.Enumerator<BubbleEffectData>::Dispose(), rectTransform:  0, drivenProperties:  null);
        this.activedEffects.Clear();
    }
    private void ResetTrail()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.trailGO_LastUsed)) != false)
        {
                this.trailGO_LastUsed.SetActive(value:  false);
        }
        
        this.SpecialTrailActive = false;
        this.trailGO_SpecialAnimator.gameObject.SetActive(value:  false);
    }
    private void SetBubbleTrail(InkWars.Model.BubbleTypes bubbleType)
    {
        this.ResetTrail();
        UnityEngine.TrailRenderer val_1 = this.trailRenderers.Get(aNewKey:  bubbleType);
        if(0 == val_1)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = val_1.gameObject;
        this.trailGO_LastUsed = val_3;
        val_3.SetActive(value:  true);
        this.SetTrailColor(bubbleType:  bubbleType);
        this.SetTrailAnimator(bubbleType:  bubbleType);
    }
    private void SetTrailAnimator(InkWars.Model.BubbleTypes bubbleType)
    {
        string val_1 = this.animatorClipNames.Get(aNewKey:  bubbleType);
        bool val_2 = System.String.IsNullOrWhiteSpace(value:  val_1);
        this.trailGO_SpecialAnimator.gameObject.SetActive(value:  val_2 ^ 1);
        if(val_2 != false)
        {
                return;
        }
        
        this.trailGO_SpecialAnimator.Play(stateName:  val_1);
        this.trailGO_SpecialAnimator.GetComponent<UnityEngine.SpriteRenderer>().sortingOrder = this.bubbleLayers.Get(aNewKey:  bubbleType);
    }
    private void SetTrailColor(InkWars.Model.BubbleTypes bubbleType)
    {
        UnityEngine.TrailRenderer val_1 = this.trailRenderers.Get(aNewKey:  bubbleType);
        if(0 == val_1)
        {
                return;
        }
        
        val_1.sortingOrder = 4;
        UnityEngine.Color val_3 = this.overrideableTrailColors.Get(aNewKey:  bubbleType);
        if(val_3.a <= 0.0006f)
        {
                return;
        }
        
        val_1.material.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
    }
    private void RedirectBubbleEffectOrientation()
    {
        var val_5;
        var val_6;
        var val_16;
        InkWars.Model.Model_Bubble val_17;
        float val_18;
        val_16 = this;
        if((this.LastPos & 1) == 0)
        {
                return;
        }
        
        val_17 = this.modelBubble;
        if(this.modelBubble.BubbleState == 2)
        {
                return;
        }
        
        val_17 = this.modelBubble;
        if(this.modelBubble.BubbleState == 0)
        {
                return;
        }
        
        val_17 = this.transform;
        UnityEngine.Vector3 val_2 = val_17.position;
        val_18 = val_2.x;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_18, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        if(val_3.x <= 0f)
        {
                return;
        }
        
        val_18 = val_3.y * 57.29578f;
        List.Enumerator<T> val_4 = this.activedEffects.GetEnumerator();
        label_23:
        if(((-2041143024) & 1) == 0)
        {
            goto label_13;
        }
        
        System.Type val_7 = val_6.InitialType;
        if((((val_7 == null) || (val_5 == 0)) || (0 == val_17)) || (val_17.isPlaying == false))
        {
            goto label_23;
        }
        
        val_6 = 0;
        val_7.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_23;
        label_13:
        val_6.Add(driver:  public System.Void List.Enumerator<BubbleEffectData>::Dispose(), rectTransform:  null, drivenProperties:  null);
        val_6 = 0;
        this.trailGO_SpecialAnimator.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if(0 == this.trailGO_LastUsed)
        {
                return;
        }
        
        val_16 = this.trailGO_LastUsed.transform;
        float val_14 = val_18 + (-90f);
        val_6 = 0;
        val_16.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public View_Bubble()
    {
        this.bubbleLayers = new BubbleLayerCollection();
        this.overrideableTrailColors = new TrailColorCollection();
        this.trailRenderers = new TrailRendererCollection();
        this.animatorClipNames = new TrailAnimatorCollection();
        this.effects = new System.Collections.Generic.List<BubbleEffectData>();
        this.shootSounds = new BubbleSFXCollection();
        this.hitSounds = new BubbleSFXCollection();
        this.popSounds = new BubbleSFXCollection();
        this.activedEffects = new System.Collections.Generic.List<BubbleEffectData>();
        this.TrailAlpha = 0.5f;
        this.InkEmUp_Speed = 2f;
        this.customBubbleEffectEventQueue = new System.Collections.Generic.Queue<BubbleEffectEventQueueItem>();
    }

}
