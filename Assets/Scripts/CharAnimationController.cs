using UnityEngine;
public class CharAnimationController : MonoBehaviour
{
    // Fields
    private CharacterNameID charID;
    public CharacterAssetLoader assetLoader;
    public bool animationsLoaded;
    public bool autoSetLayer;
    public bool invertOffsetX3D;
    public float offsetScale2D;
    private bool rightSideOfScreen;
    private bool playingAnimation;
    private bool hasFX;
    private CharacterAllAnimations charAllAnims;
    private AnimationData currentAnimation;
    public CharacterAnimationName currentAnimationName;
    private int currentAnimationIndex;
    private int currentAnimationMaxIndex;
    private int currentAnimationIndex_FX;
    private int currentAnimationMaxIndex_FX;
    private float currentBodyTime;
    private float currentFXTime;
    public float postAttackAnimDuration;
    private bool holdLastFX;
    public UnityEngine.SpriteRenderer image_Body;
    public UnityEngine.SpriteRenderer image_FX;
    public bool inkemUp;
    public bool pause;
    public bool receiveDamageAnimEnded;
    public bool attackAnimEnded;
    private CharAudioController audioController;
    
    // Properties
    public UnityEngine.Color color { get; set; }
    
    // Methods
    public UnityEngine.Color get_color()
    {
        if(this.image_Body != null)
        {
                return this.image_Body.color;
        }
        
        return this.image_Body.color;
    }
    public void set_color(UnityEngine.Color value)
    {
        this.image_Body.color = new UnityEngine.Color() {r = value.r, g = value.g, b = value.b, a = value.a};
        this.image_FX.color = new UnityEngine.Color() {r = value.r, g = value.g, b = value.b, a = value.a};
    }
    private void OnEnable()
    {
        InkWars.Model.Model_Events.Instance.add_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void CharAnimationController::OnGameResult(InkWars.Model.GameResult result, bool isFinished)));
    }
    private void OnDisable()
    {
        InkWars.Model.Model_Events.Instance.remove_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void CharAnimationController::OnGameResult(InkWars.Model.GameResult result, bool isFinished)));
    }
    private void OnGameResult(InkWars.Model.GameResult result, bool isFinished)
    {
        CharacterAnimationName val_2 = this.currentAnimationName;
        val_2 = val_2 - 1;
        if(val_2 > 1)
        {
                return;
        }
        
        bool val_1 = this.SetCurrentAnimation(animName:  8);
        this.Update();
    }
    public void SetLosePoseInked()
    {
        this.image_Body.sprite = this.assetLoader.LoadPose_LoseInked();
        this.pause = true;
    }
    public void RetrieveCharacterBundle(CharacterNameID charNameID)
    {
        CharacterAssetLoader val_6;
        this.charID = charNameID;
        if(this.assetLoader == 0)
        {
                val_6 = this.gameObject.AddComponent<CharacterAssetLoader>();
            this.assetLoader = val_6;
        }
        else
        {
                val_6 = this.assetLoader;
        }
        
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  val_6.RetrieveBundle(inputCharID:  this.charID, callback:  0));
    }
    private void SetupCharacterOffset()
    {
    
    }
    public System.Collections.IEnumerator LoadAnimations_Gameplay()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new CharAnimationController.<LoadAnimations_Gameplay>d__36();
    }
    public System.Collections.IEnumerator LoadAnimations_CharacterSelect()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new CharAnimationController.<LoadAnimations_CharacterSelect>d__37();
    }
    public void PlayAnimation(CharacterAnimationName newAnimName, bool forceOverride = False)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        AnimationData val_14;
        if(this.animationsLoaded == false)
        {
                return;
        }
        
        if(newAnimName > 16)
        {
            goto label_2;
        }
        
        var val_10 = 40836568;
        val_10 = (40836568 + (newAnimName) << 2) + val_10;
        goto (40836568 + (newAnimName) << 2 + 40836568);
        label_2:
        val_10 = 0;
        val_11 = 0;
        if(this.currentAnimationName <= 16)
        {
                val_12 = mem[40837760 + (this.currentAnimationName) << 2];
            val_12 = 40837760 + (this.currentAnimationName) << 2;
        }
        else
        {
                val_12 = 0;
        }
        
        if( > val_12)
        {
                val_13 = 1;
        }
        else
        {
                bool val_11 = this.playingAnimation;
            val_11 = val_11 ^ 1;
            val_13 = val_11 & 255;
        }
        
         =  | forceOverride;
         =  | val_13;
        if( == false)
        {
                return;
        }
        
        if((this.SetCurrentAnimation(animName:  newAnimName)) == false)
        {
                return;
        }
        
        val_14 = this.currentAnimation;
        if(val_14 == null)
        {
            goto label_19;
        }
        
        this.holdLastFX = this.currentAnimation.holdLastFX;
        goto label_20;
        label_19:
        val_14 = this.currentAnimation;
        this.holdLastFX = this.currentAnimation.holdLastFX;
        if(this.currentAnimation == null)
        {
            goto label_21;
        }
        
        label_20:
        AnimationFrameData val_4 = this.currentAnimation.bodyFrameData.Item[0];
        float val_5 = UnityEngine.Mathf.Max(a:  this.currentAnimation.speed, b:  0.1f);
        val_5 = val_4.duration / val_5;
        this.currentBodyTime = val_5;
        this.currentAnimationIndex = 0;
        this.currentAnimationMaxIndex = this.currentAnimation.bodyFrameData.Count - 1;
        AnimationFrameData val_8 = this.currentAnimation.bodyFrameData.Item[this.currentAnimationIndex];
        this.image_Body.sprite = val_8.sprite;
        this.CheckForFXTrigger();
        this.SetupAnimation();
        this.playingAnimation = true;
        this.pause = false;
        this.audioController.Play(audioName:  this.currentAnimationName, inkingSequence:  (this.inkemUp == true) ? 1 : 0);
        return;
        label_21:
    }
    public float GetAnimationDuration(CharacterAnimationName anim)
    {
        var val_6;
        UnityEngine.Object val_7;
        float val_8;
        val_7 = this.GetAnimation(animName:  anim);
        val_8 = 0f;
        if(0 == val_7)
        {
                return (float)val_8;
        }
        
        List.Enumerator<T> val_3 = val_1.bodyFrameData.GetEnumerator();
        val_6 = 1152921526029562208;
        val_8 = 0f;
        goto label_6;
        label_8:
        System.Type val_4 = 0.InitialType;
        val_8 = val_8 + (S0 / val_1.speed);
        label_6:
        if(((-25207096) & 1) != 0)
        {
            goto label_8;
        }
        
        0.Add(driver:  public System.Void List.Enumerator<AnimationFrameData>::Dispose(), rectTransform:  0, drivenProperties:  null);
        return (float)val_8;
    }
    public void SetSideOfScreen(bool rightSide)
    {
        this.rightSideOfScreen = rightSide;
        rightSide = (~rightSide) & 1;
        this.image_Body.flipX = rightSide;
        this.image_FX.flipX = (this.rightSideOfScreen == false) ? 1 : 0;
    }
    public void SetScale(UnityEngine.Vector2 inputScale)
    {
        this.GetComponent<UnityEngine.RectTransform>().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.SetSideOfScreen(rightSide:  this.rightSideOfScreen);
    }
    public void SetPosition(UnityEngine.Vector2 pos)
    {
        this.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public void SetSortingLayer(InkWars.Model.SortingLayerOrder _sortingLayer)
    {
        if(this.autoSetLayer == false)
        {
                return;
        }
        
        this.image_Body.sortingOrder = _sortingLayer;
        this.image_FX.sortingOrder = _sortingLayer;
    }
    private void Awake()
    {
        this.playingAnimation = false;
        this.audioController = this.gameObject.AddComponent<CharAudioController>();
        this.SetSortingLayer(_sortingLayer:  9);
    }
    public void Clear()
    {
        this.image_Body.sprite = 0;
        this.image_FX.sprite = 0;
    }
    private void Update()
    {
        if(this.pause != false)
        {
                if(this.holdLastFX == true)
        {
                return;
        }
        
            this.image_FX.enabled = false;
            return;
        }
        
        if(this.animationsLoaded == false)
        {
                return;
        }
        
        this.UpdateAnimation();
    }
    private void UpdateAnimation()
    {
        float val_12;
        int val_13;
        int val_14;
        if(this.playingAnimation == false)
        {
                return;
        }
        
        if(this.hasFX == false)
        {
            goto label_8;
        }
        
        if(this.currentFXTime <= 0f)
        {
            goto label_3;
        }
        
        val_12 = this.currentFXTime - UnityEngine.Time.deltaTime;
        this.currentFXTime = val_12;
        goto label_8;
        label_3:
        if(this.currentAnimationIndex_FX != this.currentAnimationMaxIndex_FX)
        {
            goto label_5;
        }
        
        if(this.holdLastFX == true)
        {
            goto label_8;
        }
        
        this.image_FX.enabled = false;
        goto label_8;
        label_5:
        val_13 = this.currentAnimationIndex_FX + 1;
        this.currentAnimationIndex_FX = val_13;
        if(this.currentAnimation == null)
        {
                val_13 = this.currentAnimationIndex_FX;
        }
        
        AnimationEffectFrameData val_2 = this.currentAnimation.fxFrameData.Item[val_13];
        float val_3 = UnityEngine.Mathf.Max(a:  this.currentAnimation.speed, b:  0.1f);
        val_3 = S10 / val_3;
        val_12 = this.currentFXTime + val_3;
        this.currentFXTime = val_12;
        this.image_FX.sprite = this.currentAnimation.fxFrameData.Item[this.currentAnimationIndex_FX];
        label_8:
        if(this.currentBodyTime > 0f)
        {
                float val_5 = UnityEngine.Time.deltaTime;
            val_5 = this.currentBodyTime - val_5;
            this.currentBodyTime = val_5;
            return;
        }
        
        if(this.currentAnimationIndex == this.currentAnimationMaxIndex)
        {
                this.AnimationHasReachedEnd();
            return;
        }
        
        val_14 = this.currentAnimationIndex + 1;
        this.currentAnimationIndex = val_14;
        if(this.currentAnimation == null)
        {
                val_14 = this.currentAnimationIndex;
        }
        
        AnimationFrameData val_6 = this.currentAnimation.bodyFrameData.Item[val_14];
        float val_7 = UnityEngine.Mathf.Max(a:  this.currentAnimation.speed, b:  0.1f);
        val_7 = val_6.duration / val_7;
        val_7 = this.currentBodyTime + val_7;
        this.currentBodyTime = val_7;
        AnimationFrameData val_8 = this.currentAnimation.bodyFrameData.Item[this.currentAnimationIndex];
        this.image_Body.sprite = val_8.sprite;
        this.CheckForFXTrigger();
    }
    private void AnimationHasReachedEnd()
    {
        int val_14;
        CharacterAnimationName val_15;
        var val_16;
        if((this.inkemUp != false) && (this.currentAnimationName == 0))
        {
                this.PlayAnimation(newAnimName:  8, forceOverride:  true);
        }
        
        if(this.currentAnimation.frameEndType != 0)
        {
                if(this.currentAnimation.frameEndType != 1)
        {
                return;
        }
        
            AnimationFrameData val_1 = this.currentAnimation.bodyFrameData.Item[0];
            float val_2 = UnityEngine.Mathf.Max(a:  this.currentAnimation.speed, b:  0.1f);
            val_2 = val_1.duration / val_2;
            val_14 = 0;
            val_2 = this.currentBodyTime + val_2;
            this.currentBodyTime = val_2;
            this.currentAnimationIndex = 0;
            if(this.currentAnimation == null)
        {
                val_14 = this.currentAnimationIndex;
        }
        
            AnimationFrameData val_3 = this.currentAnimation.bodyFrameData.Item[val_14];
            this.image_Body.sprite = val_3.sprite;
            this.CheckForFXTrigger();
            return;
        }
        
        if(this.currentAnimationName <= 16)
        {
                var val_14 = 40836772 + (this.currentAnimationName) << 2;
            val_14 = val_14 + 40836772;
        }
        else
        {
                val_15 = 8;
            val_16 = 1;
            ???.PlayAnimation(newAnimName:  null, forceOverride:  false);
        }
    
    }
    private int GetAnimationPriorityValue(CharacterAnimationName anim)
    {
        if(anim > 16)
        {
                return 0;
        }
        
        return (int)40837760 + (anim) << 2;
    }
    private bool SetCurrentAnimation(CharacterAnimationName animName)
    {
        CharacterAnimationName val_25;
        var val_26;
        val_25 = animName;
        this.currentAnimationName = val_25;
        if(val_25 > 16)
        {
            goto label_1;
        }
        
        var val_25 = 40836500 + (animName) << 2;
        val_25 = val_25 + 40836500;
        goto (40836500 + (animName) << 2 + 40836500);
        label_97:
        this.currentAnimation = UnityEngine.Object.__il2cppRuntimeField_cctor_finished;
        val_26 = 1;
        return (bool)val_26;
        label_1:
        if(6418 == 0)
        {
            goto label_96;
        }
        
        goto label_97;
        label_96:
        val_26 = 0;
        this.currentAnimationName = this.currentAnimationName;
        return (bool)val_26;
    }
    private void CheckForFXTrigger()
    {
        if(this.currentAnimation.fxFrameData.Count >= 1)
        {
                AnimationEffectFrameData val_2 = this.currentAnimation.fxFrameData.Item[0];
            if(this.currentAnimationIndex != val_2.baseFrameIndex)
        {
                return;
        }
        
            this.image_FX.enabled = true;
            this.hasFX = true;
            this.currentAnimationIndex_FX = 0;
            this.currentAnimationMaxIndex_FX = this.currentAnimation.fxFrameData.Count - 1;
            this.image_FX.sprite = this.currentAnimation.fxFrameData.Item[this.currentAnimationIndex_FX];
            AnimationEffectFrameData val_6 = this.currentAnimation.fxFrameData.Item[this.currentAnimationIndex_FX];
            float val_7 = UnityEngine.Mathf.Max(a:  this.currentAnimation.speed, b:  0.1f);
            val_7 = S9 / val_7;
            this.currentFXTime = val_7;
            this.SetupAnimation();
            return;
        }
        
        this.image_FX.enabled = false;
        this.hasFX = false;
        this.currentFXTime = 0f;
    }
    public AnimationData GetCurrentAnimation()
    {
        return (AnimationData)this.currentAnimation;
    }
    public AnimationData GetAnimation(CharacterAnimationName animName)
    {
        if(animName > 16)
        {
                return 0;
        }
        
        var val_1 = 40836704 + (animName) << 2;
        val_1 = val_1 + 40836704;
        goto (40836704 + (animName) << 2 + 40836704);
    }
    private void SetupAnimation()
    {
        if(0 != (this.GetComponent<UnityEngine.RectTransform>()))
        {
                if(0 != (this.image_Body.GetComponent<UnityEngine.RectTransform>()))
        {
                if(0 != (this.image_FX.GetComponent<UnityEngine.RectTransform>()))
        {
            goto label_11;
        }
        
        }
        
        }
        
        this.SetupFrame_3D();
        return;
        label_11:
        this.SetupForUICanvas();
        this.SetupFrame_2D();
    }
    private void SetupForUICanvas()
    {
        float val_29;
        float val_30;
        UnityEngine.Object val_31;
        UnityEngine.Vector2 val_4 = this.GetComponent<UnityEngine.RectTransform>().sizeDelta;
        val_29 = val_4.x;
        if(0 != this.image_Body.sprite)
        {
                UnityEngine.Rect val_8 = this.image_Body.sprite.rect;
            UnityEngine.Rect val_10 = this.image_Body.sprite.rect;
            val_10.m_YMin = val_4.y / val_10.m_YMin;
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_29 / val_8.m_XMin, y:  val_10.m_YMin);
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, d:  this.image_Body.sprite.pixelsPerUnit);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
            val_30 = val_16.x;
            this.image_Body.GetComponent<UnityEngine.RectTransform>().localScale = new UnityEngine.Vector3() {x = val_30, y = val_16.y, z = val_16.z};
        }
        
        val_31 = this.image_FX.sprite;
        if(0 == val_31)
        {
                return;
        }
        
        UnityEngine.Rect val_20 = this.image_FX.sprite.rect;
        val_31 = this.image_FX.sprite;
        UnityEngine.Rect val_22 = val_31.rect;
        val_22.m_YMin = val_4.y / val_22.m_YMin;
        UnityEngine.Vector2 val_24 = new UnityEngine.Vector2(x:  val_29 / val_20.m_XMin, y:  val_22.m_YMin);
        UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y}, d:  this.image_FX.sprite.pixelsPerUnit);
        UnityEngine.Vector3 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y});
        val_29 = val_28.x;
        val_30 = val_28.z;
        this.image_FX.GetComponent<UnityEngine.RectTransform>().localScale = new UnityEngine.Vector3() {x = val_29, y = val_28.y, z = val_30};
    }
    private void SetupFrame_2D()
    {
        float val_13;
        float val_14;
        float val_15;
        float val_16;
        if(0 == (CharacterDataManager.Get(id:  this.charID)))
        {
                return;
        }
        
        if(0 != this.image_Body)
        {
                UnityEngine.RectTransform val_4 = this.image_Body.GetComponent<UnityEngine.RectTransform>();
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_1.animationOffset, y = V8.16B}, d:  this.offsetScale2D);
            val_4.offsetMin = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_1.animationOffset, y = V8.16B}, d:  this.offsetScale2D);
            if(val_4 != null)
        {
                val_13 = val_6.x;
            val_14 = val_6.y;
            val_4.offsetMax = new UnityEngine.Vector2() {x = val_13, y = val_14};
        }
        else
        {
                val_13 = val_6.x;
            val_14 = val_6.y;
            val_4.offsetMax = new UnityEngine.Vector2() {x = val_13, y = val_14};
        }
        
            UnityEngine.Vector3 val_7 = val_4.localScale;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  val_1.scale);
            val_4.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        
        if(0 == this.image_FX)
        {
                return;
        }
        
        UnityEngine.RectTransform val_10 = this.image_FX.GetComponent<UnityEngine.RectTransform>();
        if(val_10 != null)
        {
                val_10.offsetMin = new UnityEngine.Vector2() {x = val_1.animationOffset, y = V8.16B};
            val_15 = val_1.animationOffset;
            val_16 = V8.16B;
            val_10.offsetMax = new UnityEngine.Vector2() {x = val_15, y = val_16};
        }
        else
        {
                val_10.offsetMin = new UnityEngine.Vector2() {x = val_1.animationOffset, y = V8.16B};
            val_15 = val_1.animationOffset;
            val_16 = V8.16B;
            val_10.offsetMax = new UnityEngine.Vector2() {x = val_15, y = val_16};
        }
        
        UnityEngine.Vector3 val_11 = val_10.localScale;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  val_1.scale);
        val_10.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
    }
    private void SetupFrame_3D()
    {
        var val_25;
        float val_26;
        float val_27;
        UnityEngine.SpriteRenderer val_28;
        val_25 = this;
        if(0 == (CharacterDataManager.Get(id:  this.charID)))
        {
                return;
        }
        
        if(0 != this.image_Body)
        {
                if(0 != this.image_Body.sprite)
        {
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  this.image_Body.sprite.pixelsPerUnit);
            val_8.x = val_8.x * ((this.invertOffsetX3D == true) ? -1f : 1f);
            this.image_Body.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  val_1.scale);
            val_27 = val_13.x;
            this.image_Body.transform.localScale = new UnityEngine.Vector3() {x = val_27, y = val_13.y, z = val_13.z};
        }
        
        }
        
        val_28 = this.image_FX;
        if(0 == val_28)
        {
                return;
        }
        
        val_28 = this.image_FX.sprite;
        if(0 == val_28)
        {
                return;
        }
        
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  this.image_FX.sprite.pixelsPerUnit);
        val_19.x = val_19.x * ((this.invertOffsetX3D == true) ? -1f : 1f);
        val_28 = this.image_FX.transform;
        val_28.localPosition = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        val_25 = this.image_FX.transform;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  val_1.scale);
        val_26 = val_24.x;
        val_27 = val_24.z;
        val_25.localScale = new UnityEngine.Vector3() {x = val_26, y = val_24.y, z = val_27};
    }
    public CharAnimationController()
    {
        this.autoSetLayer = true;
        this.offsetScale2D = 1f;
        this.rightSideOfScreen = true;
    }

}
