using UnityEngine;
public class UIParticleSystem : MaskableGraphic
{
    // Fields
    public UnityEngine.Texture particleTexture;
    public UnityEngine.Sprite particleSprite;
    public bool enableReplaceParticleTexture;
    private UnityEngine.Transform _transform;
    private UnityEngine.ParticleSystem _particleSystem;
    private UnityEngine.ParticleSystem.Particle[] _particles;
    private UnityEngine.UIVertex[] _quad;
    private UnityEngine.Vector4 _uv;
    private UnityEngine.ParticleSystem.TextureSheetAnimationModule _textureSheetAnimation;
    private int _textureSheetAnimationFrames;
    private UnityEngine.Vector2 _textureSheedAnimationFrameSize;
    
    // Properties
    public override UnityEngine.Texture mainTexture { get; }
    
    // Methods
    public override UnityEngine.Texture get_mainTexture()
    {
        UnityEngine.Sprite val_4;
        UnityEngine.Texture val_5;
        val_4 = this;
        if((UnityEngine.Object.op_Implicit(exists:  this.particleTexture)) != false)
        {
                val_5 = this.particleTexture;
            return (UnityEngine.Texture)val_4.texture;
        }
        
        val_5 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  this.particleSprite)) == false)
        {
                return (UnityEngine.Texture)val_4.texture;
        }
        
        val_4 = this.particleSprite;
        return (UnityEngine.Texture)val_4.texture;
    }
    protected bool Initialize()
    {
        UnityEngine.ParticleSystem val_33;
        UnityEngine.Object val_34;
        var val_35;
        var val_36;
        if(this._transform == 0)
        {
                this._transform = this.transform;
        }
        
        val_33 = this._particleSystem;
        val_34 = this.GetComponent<UnityEngine.ParticleSystemRenderer>();
        if(val_33 != 0)
        {
            goto label_6;
        }
        
        val_33 = this.GetComponent<UnityEngine.ParticleSystem>();
        this._particleSystem = val_33;
        if(val_33 != 0)
        {
            goto label_9;
        }
        
        val_36 = 0;
        return (bool)val_36;
        label_6:
        if(UnityEngine.Application.isPlaying == false)
        {
            goto label_31;
        }
        
        val_33 = val_34.material;
        if(val_33 == 0)
        {
            goto label_15;
        }
        
        goto label_31;
        label_9:
        if(val_34 == 0)
        {
                val_34 = this._particleSystem.gameObject.AddComponent<UnityEngine.ParticleSystemRenderer>();
        }
        
        UnityEngine.Material val_13 = val_34.sharedMaterial;
        if((UnityEngine.Object.op_Implicit(exists:  val_13)) != false)
        {
                if(((val_13.HasProperty(name:  "_MainTex")) != false) && (this.enableReplaceParticleTexture != false))
        {
                this.particleTexture = val_13.mainTexture;
        }
        
        }
        
        val_33 = this._particleSystem;
        val_33.scalingMode = 1;
        this._particles = 0;
        label_15:
        if(UnityEngine.Application.isPlaying != false)
        {
                val_33 = this.material;
            val_34.material = val_33;
        }
        
        label_31:
        if(this._particles == null)
        {
                int val_19 = this._particleSystem.maxParticles;
            this._particles = new Particle[0];
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.particleTexture)) != false)
        {
                val_35 = 0;
            this._uv = 0;
            mem[1152921529101008876] = val_35;
            mem[1152921529101008884] = 0;
        }
        else
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.particleSprite)) != false)
        {
                UnityEngine.Vector4 val_23 = UnityEngine.Sprites.DataUtility.GetOuterUV(sprite:  this.particleSprite);
            this._uv = val_23;
            mem[1152921529101008876] = val_23.y;
            mem[1152921529101008880] = val_23.z;
            mem[1152921529101008884] = val_23.w;
        }
        
        }
        
        TextureSheetAnimationModule val_24 = this._particleSystem.textureSheetAnimation;
        this._textureSheetAnimation = val_24.m_ParticleSystem;
        this._textureSheetAnimationFrames = 0;
        UnityEngine.Vector2 val_25 = UnityEngine.Vector2.zero;
        this._textureSheedAnimationFrameSize = val_25;
        mem[1152921529101008904] = val_25.y;
        if(this._textureSheetAnimation.enabled != false)
        {
                this._textureSheetAnimationFrames = this._textureSheetAnimation.numTilesY * this._textureSheetAnimation.numTilesX;
            val_33 = this._textureSheetAnimation.numTilesX;
            float val_33 = (float)val_33;
            float val_34 = 1f;
            val_33 = val_34 / val_33;
            val_34 = val_34 / (float)this._textureSheetAnimation.numTilesY;
            UnityEngine.Vector2 val_32 = new UnityEngine.Vector2(x:  val_33, y:  val_34);
            this._textureSheedAnimationFrameSize = val_32.x;
            mem[1152921529101008904] = val_32.y;
        }
        
        val_36 = 1;
        return (bool)val_36;
    }
    protected override void Awake()
    {
        this.Awake();
        if(this.Initialize() != false)
        {
                return;
        }
        
        this.enabled = false;
    }
    protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
    {
        UnityEngine.ParticleSystem val_64;
        int val_65;
        float val_66;
        float val_69;
        float val_70;
        UnityEngine.Vector4 val_71;
        float val_72;
        float val_73;
        float val_74;
        float val_75;
        UnityEngine.UIVertex[] val_78;
        float val_79;
        float val_80;
        vh.Clear();
        val_64 = this.gameObject;
        if(val_64.activeInHierarchy == false)
        {
                return;
        }
        
        val_64 = this._particleSystem;
        int val_3 = val_64.GetParticles(particles:  this._particles);
        if(val_3 < 1)
        {
                return;
        }
        
        var val_65 = 0;
        val_64 = this._textureSheetAnimation;
        val_65 = val_3;
        var val_66 = 32;
        label_82:
        if(this._particleSystem.simulationSpace != 0)
        {
                UnityEngine.Vector3 val_5 = this._transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 1.570796f, y = V1.16B, z = V2.16B});
        }
        
        val_66 = V2.16B;
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 1.570796f, y = V1.16B, z = val_66});
        val_69 = val_6.x;
        val_70 = val_6.y;
        if(this._particleSystem.scalingMode == 2)
        {
                val_66 = this.canvas.scaleFactor;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_69, y = val_70}, d:  val_66);
            val_69 = val_10.x;
            val_70 = val_10.y;
        }
        
        val_71 = this._uv;
        if(val_64.enabled == false)
        {
            goto label_19;
        }
        
        float val_59 = val_10.x;
        val_10.x = val_59 / val_10.x;
        val_59 = 1f - val_10.x;
        float val_60 = (float)val_64.cycleCount;
        val_60 = val_59 * val_60;
        float val_13 = UnityEngine.Mathf.Repeat(t:  val_60, length:  1f);
        UnityEngine.ParticleSystemAnimationType val_14 = val_64.animation;
        if(val_14 == 1)
        {
            goto label_22;
        }
        
        if(val_14 != 0)
        {
            goto label_23;
        }
        
        float val_61 = (float)this._textureSheetAnimationFrames;
        val_61 = val_13 * val_61;
        int val_15 = UnityEngine.Mathf.FloorToInt(f:  val_61);
        goto label_29;
        label_22:
        float val_62 = (float)val_64.numTilesX;
        val_62 = val_13 * val_62;
        int val_18 = val_64.numTilesX;
        val_18 = (UnityEngine.Mathf.FloorToInt(f:  val_62)) + (val_18 * val_64);
        goto label_29;
        label_23:
        label_29:
        int val_63 = this._textureSheetAnimationFrames;
        int val_20 = 0 - ((0 / val_63) * val_63);
        int val_21 = val_64.numTilesX;
        val_63 = val_20 / val_21;
        val_63 = val_20 - (val_63 * val_21);
        val_71 = this._textureSheedAnimationFrameSize * (float)val_63;
        val_65 = val_65;
        val_66 = (float)UnityEngine.Mathf.FloorToInt(f:  (float)val_20 / val_64.numTilesX);
        val_72 = ((float)val_20 / val_64.numTilesX) * val_66;
        val_74 = val_71 + this._textureSheedAnimationFrameSize;
        val_73 = ((float)val_20 / val_64.numTilesX) + val_72;
        label_19:
        this._quad[0] = ;
        UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  val_71, y:  val_72);
        this._quad[0] = val_25.x;
        this._quad[0] = val_25.y;
        this._quad[1] = ;
        UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  val_71, y:  val_73);
        this._quad[1] = val_26.x;
        this._quad[1] = val_26.y;
        this._quad[2] = ;
        UnityEngine.Vector2 val_27 = new UnityEngine.Vector2(x:  val_74, y:  val_73);
        this._quad[2] = val_27.x;
        this._quad[2] = val_27.y;
        this._quad[3] = ;
        float val_28 = val_6.x * (-0.01745329f);
        UnityEngine.Vector2 val_29 = new UnityEngine.Vector2(x:  val_74, y:  val_72);
        float val_64 = 0.5f;
        val_75 = val_6.x * val_64;
        this._quad[3] = val_29.x;
        this._quad[3] = val_29.y;
        if(val_28 == 0f)
        {
                val_64 = val_69 - val_75;
            UnityEngine.Vector2 val_31 = new UnityEngine.Vector2(x:  val_64, y:  val_70 - val_75);
            UnityEngine.Vector2 val_34 = new UnityEngine.Vector2(x:  val_75 + val_69, y:  val_75 + val_70);
            UnityEngine.Vector2 val_35 = new UnityEngine.Vector2(x:  val_31.x, y:  val_31.y);
            UnityEngine.Vector3 val_36 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_35.x, y = val_35.y});
            this._quad[0] = val_36.x;
            this._quad[0] = val_36.y;
            this._quad[0] = val_36.z;
            UnityEngine.Vector2 val_37 = new UnityEngine.Vector2(x:  val_31.x, y:  val_34.y);
            UnityEngine.Vector3 val_38 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_37.x, y = val_37.y});
            this._quad[1] = val_38.x;
            this._quad[1] = val_38.y;
            this._quad[1] = val_38.z;
            UnityEngine.Vector2 val_39 = new UnityEngine.Vector2(x:  val_34.x, y:  val_34.y);
            UnityEngine.Vector3 val_40 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_39.x, y = val_39.y});
            this._quad[2] = val_40.x;
            this._quad[2] = val_40.y;
            this._quad[2] = val_40.z;
            val_78 = this._quad;
            UnityEngine.Vector2 val_41 = new UnityEngine.Vector2(x:  val_34.x, y:  val_31.y);
            val_79 = val_41.x;
            val_80 = val_41.y;
        }
        else
        {
                float val_42 = val_28 + 1.570796f;
            UnityEngine.Vector2 val_43 = new UnityEngine.Vector2(x:  val_28, y:  val_28);
            UnityEngine.Vector2 val_44 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_43.x, y = val_43.y}, d:  val_75);
            UnityEngine.Vector2 val_45 = new UnityEngine.Vector2(x:  val_42, y:  val_42);
            UnityEngine.Vector2 val_46 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_45.x, y = val_45.y}, d:  val_75);
            val_75 = val_46.x;
            UnityEngine.Vector2 val_47 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_69, y = val_70}, b:  new UnityEngine.Vector2() {x = val_44.x, y = val_44.y});
            UnityEngine.Vector2 val_48 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_47.x, y = val_47.y}, b:  new UnityEngine.Vector2() {x = val_75, y = val_46.y});
            UnityEngine.Vector3 val_49 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_48.x, y = val_48.y});
            this._quad[0] = val_49.x;
            this._quad[0] = val_49.y;
            this._quad[0] = val_49.z;
            UnityEngine.Vector2 val_50 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_69, y = val_70}, b:  new UnityEngine.Vector2() {x = val_44.x, y = val_44.y});
            UnityEngine.Vector2 val_51 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_50.x, y = val_50.y}, b:  new UnityEngine.Vector2() {x = val_75, y = val_46.y});
            UnityEngine.Vector3 val_52 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_51.x, y = val_51.y});
            this._quad[1] = val_52.x;
            this._quad[1] = val_52.y;
            this._quad[1] = val_52.z;
            UnityEngine.Vector2 val_53 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_69, y = val_70}, b:  new UnityEngine.Vector2() {x = val_44.x, y = val_44.y});
            UnityEngine.Vector2 val_54 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_53.x, y = val_53.y}, b:  new UnityEngine.Vector2() {x = val_75, y = val_46.y});
            UnityEngine.Vector3 val_55 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_54.x, y = val_54.y});
            val_74 = val_55.y;
            this._quad[2] = val_55.x;
            this._quad[2] = val_74;
            this._quad[2] = val_55.z;
            val_78 = this._quad;
            val_80 = val_70;
            val_79 = val_69;
            UnityEngine.Vector2 val_56 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_79, y = val_80}, b:  new UnityEngine.Vector2() {x = val_44.x, y = val_44.y});
            val_66 = val_75;
            UnityEngine.Vector2 val_57 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_56.x, y = val_56.y}, b:  new UnityEngine.Vector2() {x = val_66, y = val_46.y});
        }
        
        UnityEngine.Vector3 val_58 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_57.x, y = val_57.y});
        val_78[3] = val_58.x;
        val_78[3] = val_58.y;
        val_78[3] = val_58.z;
        vh.AddUIVertexQuad(verts:  this._quad);
        val_65 = val_65 + 1;
        val_66 = val_66 + 124;
        if(val_65 != val_65)
        {
            goto label_82;
        }
    
    }
    private void Update()
    {
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        this._particleSystem.Simulate(t:  UnityEngine.Time.unscaledDeltaTime, withChildren:  false, restart:  false);
        this.SetAllDirty();
    }
    public UIParticleSystem()
    {
        this.enableReplaceParticleTexture = true;
        this._quad = new UnityEngine.UIVertex[4];
        UnityEngine.Vector4 val_2 = UnityEngine.Vector4.zero;
        this._uv = val_2;
        mem[1152921529103377932] = val_2.y;
        mem[1152921529103377936] = val_2.z;
        mem[1152921529103377940] = val_2.w;
    }

}
