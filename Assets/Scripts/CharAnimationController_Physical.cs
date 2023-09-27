using UnityEngine;
public class CharAnimationController_Physical : MonoBehaviour
{
    // Fields
    private CharacterNameID charID;
    public CharacterAssetLoader assetLoader;
    public bool animationsLoaded;
    private bool rightSideOfScreen;
    private bool playingAnimation;
    private CharacterAllAnimations charAllAnims;
    private AnimationData currentAnimation;
    public CharacterAnimationName currentAnimationName;
    private int currentAnimationIndex;
    private int currentAnimationMaxIndex;
    private int currentAnimationIndex_FX;
    private int currentAnimationMaxIndex_FX;
    private bool hasFX;
    public UnityEngine.UI.Image image_Body;
    public UnityEngine.UI.Image image_FX;
    private float currentBodyTime;
    private float currentFXTime;
    public bool inkemUp;
    public bool pause;
    public bool receiveDamageAnimEnded;
    public bool attackAnimEnded;
    public float postAttackAnimDuration;
    private CharAudioController audioController;
    
    // Methods
    public void SetLosePoseInked()
    {
        this.image_Body.sprite = this.assetLoader.LoadPose_LoseInked();
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
    public float GetAnimationDuration(CharacterAnimationName anim)
    {
        var val_5;
        var val_6;
        float val_8;
        val_5 = anim;
        val_6 = 0;
        if(val_5 > 16)
        {
            goto label_1;
        }
        
        var val_5 = 40836840 + (anim) << 2;
        val_5 = val_5 + 40836840;
        goto (40836840 + (anim) << 2 + 40836840);
        label_1:
        val_8 = 0f;
        if(0 == 1152921505066430464)
        {
                return (float)val_8;
        }
        
        List.Enumerator<T> val_2 = typeof(CharAnimationController_Physical).__il2cppRuntimeField_28.GetEnumerator();
        val_5 = 1152921526029562208;
        val_8 = 0f;
        goto label_22;
        label_24:
        System.Type val_3 = 0.InitialType;
        val_8 = val_8 + (S0 / CharAnimationController_Physical.__il2cppRuntimeField_byval_arg);
        label_22:
        if(((-19927512) & 1) != 0)
        {
            goto label_24;
        }
        
        0.Add(driver:  public System.Void List.Enumerator<AnimationFrameData>::Dispose(), rectTransform:  0, drivenProperties:  null);
        return (float)val_8;
    }
    private void SetupCharacterOffset()
    {
        if(0 == (CharacterDataManager.Get(id:  this.charID)))
        {
                return;
        }
        
        if(0 != this.image_Body)
        {
                UnityEngine.RectTransform val_4 = this.image_Body.GetComponent<UnityEngine.RectTransform>();
            if(val_4 != null)
        {
                val_4.offsetMin = new UnityEngine.Vector2() {x = val_1.animationOffset, y = V8.16B};
        }
        else
        {
                val_4.offsetMin = new UnityEngine.Vector2() {x = val_1.animationOffset, y = V8.16B};
        }
        
            val_4.offsetMax = new UnityEngine.Vector2() {x = val_1.animationOffset, y = V8.16B};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  val_1.scale, a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            val_4.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        
        if(0 == this.image_FX)
        {
                return;
        }
        
        UnityEngine.RectTransform val_8 = this.image_FX.GetComponent<UnityEngine.RectTransform>();
        if(val_8 != null)
        {
                val_8.offsetMin = new UnityEngine.Vector2() {x = val_1.animationOffset, y = V8.16B};
        }
        else
        {
                val_8.offsetMin = new UnityEngine.Vector2() {x = val_1.animationOffset, y = V8.16B};
        }
        
        val_8.offsetMax = new UnityEngine.Vector2() {x = val_1.animationOffset, y = V8.16B};
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(d:  val_1.scale, a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        val_8.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
    }
    public System.Collections.IEnumerator LoadAnimations_Gameplay()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new CharAnimationController_Physical.<LoadAnimations_Gameplay>d__27();
    }
    public System.Collections.IEnumerator LoadAnimations_CharacterSelect()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new CharAnimationController_Physical.<LoadAnimations_CharacterSelect>d__28();
    }
    public void PlayAnimation(CharacterAnimationName newAnimName, bool forceOverride = False)
    {
        var val_8;
        var val_9;
        if(this.animationsLoaded == false)
        {
                return;
        }
        
        if((this.playingAnimation != false) && (forceOverride != true))
        {
                if(newAnimName <= 16)
        {
                val_8 = mem[40837840 + (newAnimName) << 2];
            val_8 = 40837840 + (newAnimName) << 2;
        }
        else
        {
                val_8 = 0;
        }
        
            if(this.currentAnimationName <= 16)
        {
                val_9 = mem[40837840 + (this.currentAnimationName) << 2];
            val_9 = 40837840 + (this.currentAnimationName) << 2;
        }
        else
        {
                val_9 = 0;
        }
        
            if(val_8 <= val_9)
        {
                return;
        }
        
        }
        
        bool val_1 = this.SetCurrentAnimation(animName:  newAnimName);
        AnimationFrameData val_2 = this.currentAnimation.bodyFrameData.Item[0];
        float val_3 = UnityEngine.Mathf.Max(a:  this.currentAnimation.speed, b:  0.1f);
        val_3 = val_2.duration / val_3;
        this.currentBodyTime = val_3;
        this.currentAnimationIndex = 0;
        this.currentAnimationMaxIndex = this.currentAnimation.bodyFrameData.Count - 1;
        AnimationFrameData val_6 = this.currentAnimation.bodyFrameData.Item[this.currentAnimationIndex];
        this.image_Body.sprite = val_6.sprite;
        this.CheckForFXTrigger();
        this.playingAnimation = true;
        this.audioController.Play(audioName:  this.currentAnimationName, inkingSequence:  (this.inkemUp == true) ? 1 : 0);
    }
    public void SetSideOfScreen(bool rightSide)
    {
        this.rightSideOfScreen = rightSide;
        UnityEngine.RectTransform val_2 = this.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Vector3 val_3 = val_2.localScale;
        float val_6 = val_3.x;
        float val_5 = System.Math.Abs(val_6);
        val_6 = (this.rightSideOfScreen == true) ? (val_5) : (-val_5);
        UnityEngine.Vector3 val_4 = val_2.localScale;
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
    private void Awake()
    {
        this.playingAnimation = false;
        this.audioController = this.gameObject.AddComponent<CharAudioController>();
    }
    private UnityEngine.UI.Image AddImage(UnityEngine.GameObject gameObject)
    {
        UnityEngine.UI.Image val_1 = gameObject.AddComponent<UnityEngine.UI.Image>();
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  0f, y:  0f);
        val_1.rectTransform.anchorMin = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  1f, y:  1f);
        val_1.rectTransform.anchorMax = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  0f, y:  0f);
        val_1.rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
        UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  0.5f, y:  0.5f);
        val_1.rectTransform.pivot = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.one;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
        val_1.rectTransform.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        return val_1;
    }
    private void Start()
    {
    
    }
    private void Update()
    {
        if(this.pause != false)
        {
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
        
        if(this.hasFX != false)
        {
                if(this.currentFXTime > 0f)
        {
                val_12 = this.currentFXTime - UnityEngine.Time.deltaTime;
            this.currentFXTime = val_12;
        }
        else
        {
                if(this.currentAnimationIndex_FX == this.currentAnimationMaxIndex_FX)
        {
                this.image_FX.enabled = false;
        }
        else
        {
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
        }
        
        }
        
        }
        
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
    private System.Collections.IEnumerator DelaySettingAttackAnimEnded(float imageDuration)
    {
        CharAnimationController_Physical.<DelaySettingAttackAnimEnded>d__38 val_1 = new CharAnimationController_Physical.<DelaySettingAttackAnimEnded>d__38();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .imageDuration = imageDuration;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator DelaySettingRecieveDamageAnimEnded(float imageDuration)
    {
        CharAnimationController_Physical.<DelaySettingRecieveDamageAnimEnded>d__39 val_1 = new CharAnimationController_Physical.<DelaySettingRecieveDamageAnimEnded>d__39();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .imageDuration = imageDuration;
        return (System.Collections.IEnumerator)val_1;
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
                var val_14 = 40837044 + (this.currentAnimationName) << 2;
            val_14 = val_14 + 40837044;
        }
        else
        {
                val_15 = 8;
            val_16 = 1;
            ???.PlayAnimation(newAnimName:  null, forceOverride:  true);
        }
    
    }
    private int GetAnimationPriorityValue(CharacterAnimationName anim)
    {
        if(anim > 16)
        {
                return 0;
        }
        
        return (int)40837840 + (anim) << 2;
    }
    private bool SetCurrentAnimation(CharacterAnimationName animName)
    {
        var val_27;
        this.currentAnimationName = animName;
        if(animName <= 16)
        {
                var val_25 = 40836976 + (animName) << 2;
            val_25 = val_25 + 40836976;
        }
        else
        {
                if(animName != 0)
        {
                val_27 = 0;
            this.currentAnimation = UnityEngine.Object.__il2cppRuntimeField_cctor_finished;
            return (bool)val_27;
        }
        
            val_27 = 0;
            return (bool)val_27;
        }
    
    }
    private void CheckForFXTrigger()
    {
        AnimationData val_8;
        float val_9;
        val_8 = 1152921526058211904;
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
            val_8 = this.currentAnimation;
            val_9 = S9 / (UnityEngine.Mathf.Max(a:  this.currentAnimation.speed, b:  0.1f));
        }
        else
        {
                this.image_FX.enabled = false;
            val_9 = 0f;
            this.hasFX = false;
        }
        
        this.currentFXTime = val_9;
    }
    private void SetSizeBasedOnSprite(UnityEngine.Sprite sprite)
    {
        if(sprite != 0)
        {
                UnityEngine.Rect val_3 = sprite.rect;
            UnityEngine.Rect val_4 = sprite.rect;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_3.m_XMin, y:  val_4.m_XMin);
            this.GetComponent<UnityEngine.RectTransform>().sizeDelta = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
            this.image_Body.rectTransform.offsetMin = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.zero;
            this.image_Body.rectTransform.offsetMax = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.zero;
            this.image_FX.rectTransform.offsetMin = new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.zero;
            this.image_FX.rectTransform.offsetMax = new UnityEngine.Vector2() {x = val_13.x, y = val_13.y};
        }
        
        this.SetupCharacterOffset();
    }
    public bool CheckAnimationExists(CharacterAnimationName animName)
    {
        this.currentAnimation = this.currentAnimation;
        return (bool)this.SetCurrentAnimation(animName:  animName);
    }
    public AnimationData GetAnimation(CharacterAnimationName animName)
    {
        var val_1 = 0;
        if(animName > 16)
        {
                return 1152921505066430464;
        }
        
        var val_1 = 40836908 + (animName) << 2;
        val_1 = val_1 + 40836908;
        goto (40836908 + (animName) << 2 + 40836908);
    }
    public CharAnimationController_Physical()
    {
        this.rightSideOfScreen = true;
    }

}
