using UnityEngine;

namespace SeventyOneSquared
{
    [Serializable]
    public class PDUnity : MonoBehaviour
    {
        // Fields
        public UnityEngine.TextAsset EmitterFile;
        public UnityEngine.Texture texture;
        public UnityEngine.GameObject emitterOrigin;
        public bool Running;
        public bool AutoLoop;
        public bool RunInEditor;
        public float scale;
        public int blendSource;
        public int blendDestination;
        private UnityEngine.TextAsset currentEmitterFile;
        private UnityEngine.Texture currentTexture;
        private int currentBlendSource;
        private int currentBlendDestination;
        public SeventyOneSquared.PDUnity.PDUnityParticleEmitter emitterConfig;
        private UnityEngine.Material material;
        private UnityEngine.Mesh mesh;
        private UnityEngine.MeshFilter meshFilter;
        private UnityEngine.MeshRenderer meshRenderer;
        private SeventyOneSquared.PDUnity.Particle[] particles;
        private bool initialized;
        
        // Methods
        private void Start()
        {
            this.Initialize();
            this.loadEmitterFile();
            this.AutoLoop = false;
        }
        private void Initialize()
        {
            UnityEngine.MeshFilter val_26;
            var val_27;
            UnityEngine.Mesh val_28;
            UnityEngine.Mesh val_29;
            UnityEngine.Material val_30;
            if(this.initialized == true)
            {
                    return;
            }
            
            if((this.gameObject.GetComponent<UnityEngine.MeshFilter>()) == 0)
            {
                    val_26 = this;
                this.meshFilter = this.gameObject.AddComponent<UnityEngine.MeshFilter>();
            }
            else
            {
                    val_26 = this.meshFilter;
            }
            
            UnityEngine.MeshFilter val_6 = this.GetComponent<UnityEngine.MeshFilter>();
            this.meshFilter = val_6;
            val_6.hideFlags = 2;
            bool val_7 = UnityEngine.Application.isEditor;
            if(mem[this.meshFilter] == 0)
            {
                goto label_9;
            }
            
            if(val_7 == false)
            {
                goto label_10;
            }
            
            label_15:
            UnityEngine.Mesh val_8 = mem[this.meshFilter].sharedMesh;
            val_27 = this;
            this.mesh = val_8;
            if(val_8 != 0)
            {
                goto label_13;
            }
            
            UnityEngine.Mesh val_10 = null;
            val_28 = val_10;
            val_10 = new UnityEngine.Mesh();
            mem[1152921529343238872] = val_28;
            goto label_14;
            label_9:
            if(val_7 == true)
            {
                goto label_15;
            }
            
            label_10:
            UnityEngine.Mesh val_11 = mem[this.meshFilter].mesh;
            val_27 = this;
            this.mesh = val_11;
            if(val_11 != 0)
            {
                goto label_18;
            }
            
            UnityEngine.Mesh val_13 = null;
            val_29 = val_13;
            val_13 = new UnityEngine.Mesh();
            mem[1152921529343238872] = val_29;
            goto label_19;
            label_13:
            val_28 = mem[1152921529343238872];
            label_14:
            mem[this.meshFilter].sharedMesh = val_13;
            goto label_21;
            label_18:
            val_29 = mem[1152921529343238872];
            label_19:
            mem[this.meshFilter].mesh = val_13;
            label_21:
            val_13.MarkDynamic();
            if((this.gameObject.GetComponent<UnityEngine.MeshRenderer>()) == 0)
            {
                    UnityEngine.MeshRenderer val_18 = this.gameObject.AddComponent<UnityEngine.MeshRenderer>();
            }
            
            UnityEngine.MeshRenderer val_19 = this.GetComponent<UnityEngine.MeshRenderer>();
            this.meshRenderer = val_19;
            val_19.hideFlags = 2;
            UnityEngine.Shader val_20 = UnityEngine.Shader.Find(name:  "PDUnityShader");
            if(UnityEngine.Application.isEditor == false)
            {
                goto label_30;
            }
            
            UnityEngine.Material val_22 = this.meshRenderer.sharedMaterial;
            this.material = val_22;
            if(val_22 != 0)
            {
                goto label_34;
            }
            
            UnityEngine.Material val_24 = new UnityEngine.Material(shader:  val_20);
            this.material = val_24;
            val_24.hideFlags = 61;
            goto label_36;
            label_30:
            UnityEngine.Material val_25 = null;
            val_30 = val_25;
            val_25 = new UnityEngine.Material(shader:  val_20);
            this.material = val_30;
            this.meshRenderer.material = val_25;
            goto label_38;
            label_34:
            this.material.shader = val_20;
            label_36:
            val_30 = this.material;
            this.meshRenderer.sharedMaterial = val_30;
            label_38:
            this.initialized = true;
        }
        private void loadTexture()
        {
            UnityEngine.Material val_5;
            UnityEngine.Texture2D val_6;
            if(this.texture != 0)
            {
                goto label_3;
            }
            
            if((this.emitterConfig == null) || (this.emitterConfig.texture == 0))
            {
                goto label_7;
            }
            
            val_5 = this.material;
            val_6 = this.emitterConfig.texture;
            if(val_5 != null)
            {
                goto label_11;
            }
            
            goto label_10;
            label_3:
            val_5 = this.material;
            val_6 = this.texture;
            this.currentTexture = val_6;
            if(val_5 != null)
            {
                goto label_11;
            }
            
            label_10:
            label_11:
            val_5.mainTexture = val_6;
            label_7:
            if(this.material.mainTexture == 0)
            {
                    return;
            }
            
            this.setMaterialProperties();
        }
        private void loadEmitterFile()
        {
            this.parseBinaryFile();
            this.currentEmitterFile = this.EmitterFile;
            this.setupData();
            this.loadTexture();
        }
        private void setMaterialProperties()
        {
            int val_3;
            int val_4;
            if(this.emitterConfig == null)
            {
                    return;
            }
            
            if(this.blendSource != 0)
            {
                    val_3 = this.blendSource - 1;
            }
            else
            {
                    val_3 = this.emitterConfig.blendFuncSource;
            }
            
            if(this.blendDestination != 0)
            {
                    val_4 = this.blendDestination - 1;
            }
            else
            {
                    val_4 = this.emitterConfig.blendFuncDestination;
            }
            
            if(this.currentBlendSource == val_3)
            {
                    if(this.currentBlendDestination == val_4)
            {
                    return;
            }
            
            }
            
            this.material.SetInt(name:  "_BlendSrcMode", value:  val_3);
            this.material.SetInt(name:  "_BlendDstMode", value:  val_4);
            this.material.SetInt(name:  "_OpacityModifyRGB", value:  this.emitterConfig.opacityModifyRGB);
            this.currentBlendSource = val_3;
            this.currentBlendDestination = val_4;
        }
        private void OnEnable()
        {
            this.Initialize();
            this.loadEmitterFile();
        }
        private void OnDisable()
        {
            this.emitterConfig = 0;
            this.initialized = false;
        }
        private void Reset()
        {
            if(this.mesh == 0)
            {
                    return;
            }
            
            this.mesh.Clear();
        }
        private void LateUpdate()
        {
            if(UnityEngine.Application.isEditor != false)
            {
                    return;
            }
            
            this.UpdateWithDelta(aDelta:  UnityEngine.Time.fixedDeltaTime);
        }
        private void UpdateWithDelta(float aDelta)
        {
            float val_7;
            float val_10;
            float val_11;
            float val_13;
            float val_15;
            float val_17;
            float val_18;
            float val_19;
            float val_20;
            float val_21;
            float val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            float val_29;
            float val_30;
            float val_88;
            float val_90;
            float val_91;
            float val_92;
            float val_93;
            float val_96;
            float val_97;
            float val_102;
            float val_103;
            UnityEngine.Mesh val_114;
            PDUnityParticleEmitter val_115;
            PDUnityParticleEmitter val_116;
            float val_117;
            PDUnityParticleEmitter val_118;
            float val_119;
            float val_120;
            float val_121;
            PDUnityParticleEmitter val_122;
            PDUnityParticleEmitter val_123;
            float val_124;
            float val_125;
            PDUnityParticleEmitter val_126;
            UnityEngine.Vector3[] val_127;
            var val_128;
            var val_129;
            float val_130;
            float val_131;
            float val_132;
            var val_133;
            float val_136;
            float val_137;
            float val_138;
            float val_139;
            var val_143;
            int val_144;
            int val_145;
            int val_146;
            float val_147;
            float val_148;
            UnityEngine.Mesh val_149;
            val_114 = this;
            if(this.emitterConfig == null)
            {
                    return;
            }
            
            if(this.material == 0)
            {
                    return;
            }
            
            this.setMaterialProperties();
            if((this.Running == false) || (this.emitterConfig.emissionRate <= 0f))
            {
                goto label_30;
            }
            
            val_115 = this.emitterConfig;
            if(val_115 == null)
            {
                goto label_8;
            }
            
            val_116 = val_115;
            val_117 = 1f / this.emitterConfig.emissionRate;
            goto label_11;
            label_8:
            val_116 = this.emitterConfig;
            val_117 = 1f / this.emitterConfig.emissionRate;
            if(val_116 == null)
            {
                goto label_10;
            }
            
            val_115 = val_116;
            goto label_11;
            label_10:
            val_118 = this.emitterConfig;
            if(val_118 == null)
            {
                goto label_29;
            }
            
            label_11:
            if(this.emitterConfig.particleCount >= this.emitterConfig.maxParticles)
            {
                goto label_13;
            }
            
            if(this.emitterConfig != null)
            {
                    val_119 = this.emitterConfig.emitCounter;
                val_120 = this.emitterConfig.emitCounter;
            }
            else
            {
                    val_120 = 260;
                val_119 = 0f;
            }
            
            val_121 = val_119 + aDelta;
            goto label_16;
            label_23:
            bool val_2 = this.addParticle();
            if(this.emitterConfig != null)
            {
                    val_119 = this.emitterConfig.emitCounter;
                val_120 = this.emitterConfig.emitCounter;
            }
            else
            {
                    val_120 = 260;
                val_119 = 0f;
            }
            
            val_121 = val_119 - val_117;
            label_16:
            mem[260] = val_121;
            label_13:
            val_122 = this.emitterConfig;
            val_123 = val_122;
            if(val_122 != null)
            {
                goto label_19;
            }
            
            val_123 = this.emitterConfig;
            if(val_123 == null)
            {
                goto label_29;
            }
            
            label_19:
            if(this.emitterConfig.particleCount < this.emitterConfig.maxParticles)
            {
                    if(this.emitterConfig.emitCounter > val_117)
            {
                goto label_23;
            }
            
            }
            
            if(this.emitterConfig != null)
            {
                    val_124 = this.emitterConfig.elapsedTime;
                val_125 = this.emitterConfig.elapsedTime;
            }
            else
            {
                    val_125 = 264;
                val_124 = 5.044674E-44f;
            }
            
            mem[264] = val_124 + aDelta;
            if(this.emitterConfig.duration == (-1f))
            {
                goto label_30;
            }
            
            val_122 = this.emitterConfig;
            val_126 = val_122;
            if(val_122 != null)
            {
                goto label_28;
            }
            
            val_126 = this.emitterConfig;
            if(val_126 == null)
            {
                goto label_29;
            }
            
            label_28:
            if(this.emitterConfig.duration < 0)
            {
                    this.Running = false;
                return;
            }
            
            label_30:
            val_127 = this.mesh.vertices;
            val_122 = this.mesh.colors32;
            val_128 = 0;
            val_129 = 100;
            goto label_73;
            label_114:
            float val_106 = X22 + 100;
            label_113:
            val_106 = (S15 - S9) + val_106;
            val_106 = val_106 * aDelta;
            float val_8 = S12 * S14;
            val_106 = val_106 + val_7;
            val_8 = val_8 + (S11 * S13);
            val_8 = val_8 + (3.458688E-37f);
            val_8 = val_8 * aDelta;
            val_8 = val_8 + val_10;
            val_7 = val_106;
            val_10 = val_8;
            val_106 = val_106 * aDelta;
            float val_12 = val_106 + val_11;
            val_11 = val_12;
            val_8 = val_8 * aDelta;
            float val_14 = val_8 + val_13;
            val_13 = val_14;
            val_130 = V10.16B;
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_12, y = val_14}, b:  new UnityEngine.Vector2() {x = val_15, y = val_130});
            label_107:
            val_11 = val_16.x;
            val_13 = val_16.y;
            float val_107 = val_17;
            val_107 = val_107 * aDelta;
            val_107 = val_18 + val_107;
            val_18 = val_107;
            float val_108 = val_19;
            val_108 = val_108 * aDelta;
            val_108 = val_20 + val_108;
            val_20 = val_108;
            float val_109 = val_21;
            val_109 = val_109 * aDelta;
            val_109 = val_22 + val_109;
            val_22 = val_109;
            float val_110 = val_23;
            val_110 = val_110 * aDelta;
            val_110 = val_24 + val_110;
            val_24 = val_110;
            float val_111 = val_26;
            val_111 = val_111 * aDelta;
            float val_27 = val_25 + val_111;
            val_25 = val_27;
            float val_28 = System.Math.Max(val1:  0f, val2:  val_27);
            float val_112 = val_30;
            val_25 = val_28;
            val_112 = val_112 * aDelta;
            val_112 = val_29 + val_112;
            val_131 = 0.5f;
            val_132 = val_28 * val_131;
            val_29 = val_112;
            if(val_112 == 0f)
            {
                    float val_31 = val_11 - val_132;
                float val_32 = val_13 - val_132;
                val_15 = val_32;
                UnityEngine.Vector2 val_33 = new UnityEngine.Vector2(x:  val_31, y:  val_32);
                UnityEngine.Vector3 val_34 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_33.x, y = val_33.y});
                var val_35 = W23 << 2;
                val_133 = (long)val_35;
                var val_113 = 12;
                val_113 = val_127 + (val_133 * val_113);
                mem2[0] = val_34.x;
                mem2[0] = val_34.y;
                float val_36 = val_132 + val_13;
                mem2[0] = val_34.z;
                UnityEngine.Vector2 val_37 = new UnityEngine.Vector2(x:  val_31, y:  val_36);
                UnityEngine.Vector3 val_38 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_37.x, y = val_37.y});
                val_35 = val_133 | 1;
                var val_114 = 12;
                val_114 = val_127 + ((long)val_35 * val_114);
                mem2[0] = val_38.x;
                mem2[0] = val_38.y;
                mem2[0] = val_38.z;
                UnityEngine.Vector2 val_40 = new UnityEngine.Vector2(x:  val_132 + val_11, y:  val_36);
                UnityEngine.Vector3 val_41 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_40.x, y = val_40.y});
                val_136 = val_41.y;
                val_137 = val_41.z;
                var val_115 = 12;
                val_115 = val_127 + (((long)val_133 | 2) * val_115);
                mem2[0] = val_41.x;
                mem2[0] = val_136;
                mem2[0] = val_137;
            }
            else
            {
                    val_15 = val_13;
                float val_43 = val_112 * 0.01745329f;
                float val_116 = -val_132;
                float val_117 = System.Convert.ToSingle(value:  val_43);
                float val_45 = System.Convert.ToSingle(value:  val_43);
                val_43 = val_117 * val_116;
                val_116 = val_45 * val_116;
                float val_46 = val_132 * val_45;
                val_45 = val_43 - val_116;
                val_45 = val_11 + val_45;
                val_131 = val_15;
                val_112 = val_43 + val_116;
                val_112 = val_131 + val_112;
                val_117 = val_132 * val_117;
                UnityEngine.Vector2 val_47 = new UnityEngine.Vector2(x:  val_45, y:  val_112);
                val_138 = val_47.y;
                float val_48 = val_117 - val_116;
                val_132 = val_43 + val_46;
                UnityEngine.Vector3 val_49 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_47.x, y = val_138});
                val_130 = val_49.x;
                if(val_127 == null)
            {
                    val_131 = val_49.z;
                val_130 = val_130;
                val_138 = val_49.y;
            }
            
                var val_50 = W23 << 2;
                val_48 = val_11 + val_48;
                val_139 = val_117 + val_46;
                val_133 = (long)val_50;
                val_132 = val_15 + val_132;
                if(val_50 >= val_4.Length)
            {
                    val_139 = val_139;
                val_138 = val_138;
                val_131 = val_131;
                val_130 = val_130;
            }
            
                val_46 = val_43 - val_46;
                var val_118 = 12;
                val_118 = val_127 + (val_133 * val_118);
                float val_119 = val_15;
                val_117 = val_117 + val_116;
                val_119 = val_119 + val_139;
                mem2[0] = val_130;
                mem2[0] = val_138;
                mem2[0] = val_131;
                UnityEngine.Vector2 val_53 = new UnityEngine.Vector2(x:  val_48, y:  val_132);
                UnityEngine.Vector3 val_54 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_53.x, y = val_53.y});
                val_50 = val_133 | 1;
                val_132 = val_54.y;
                var val_120 = 12;
                val_120 = val_127 + ((long)val_50 * val_120);
                mem2[0] = val_54.x;
                mem2[0] = val_132;
                mem2[0] = val_54.z;
                val_136 = val_15 + val_117;
                UnityEngine.Vector2 val_56 = new UnityEngine.Vector2(x:  val_11 + (val_117 - val_46), y:  val_119);
                UnityEngine.Vector3 val_57 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_56.x, y = val_56.y});
                val_137 = val_57.z;
                var val_121 = 12;
                val_121 = val_127 + (((long)val_133 | 2) * val_121);
                mem2[0] = val_57.x;
                mem2[0] = val_57.y;
                mem2[0] = val_137;
            }
            
            UnityEngine.Vector2 val_59 = new UnityEngine.Vector2(x:  val_11 + val_46, y:  val_136);
            UnityEngine.Vector3 val_60 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_59.x, y = val_59.y});
            val_119 = val_60.y;
            var val_122 = 12;
            val_122 = val_127 + (((long)val_133 | 3) * val_122);
            mem2[0] = val_60.x;
            mem2[0] = val_119;
            mem2[0] = val_60.z;
            var val_62 = W23 << 2;
            var val_123 = 12;
            val_123 = val_127 + ((long)val_62 * val_123);
            float val_124 = ((long)(int)((W23 << 2)) * 12) + val_4 + 32;
            val_124 = val_124 * this.scale;
            mem2[0] = val_124;
            var val_125 = 12;
            val_125 = val_127 + ((long)val_62 * val_125);
            float val_126 = ((long)(int)((W23 << 2)) * 12) + val_4 + 36;
            val_62 = (long)val_62 | 1;
            val_143 = (long)val_62;
            val_126 = val_126 * this.scale;
            mem2[0] = val_126;
            var val_127 = 12;
            val_127 = val_127 + (val_143 * val_127);
            float val_128 = ((long)(int)(((long)(int)((W23 << 2)) | 1)) * 12) + val_4 + 32;
            val_128 = val_128 * this.scale;
            mem2[0] = val_128;
            var val_129 = 12;
            val_129 = val_127 + (val_143 * val_129);
            float val_130 = ((long)(int)(((long)(int)((W23 << 2)) | 1)) * 12) + val_4 + 36;
            val_130 = val_130 * this.scale;
            mem2[0] = val_130;
            var val_131 = 12;
            val_131 = val_127 + (((long)(long)val_62 | 2) * val_131);
            float val_132 = ((long)(int)(((long)(int)((W23 << 2)) | 2)) * 12) + val_4 + 32;
            val_132 = val_132 * this.scale;
            mem2[0] = val_132;
            var val_133 = 12;
            val_133 = val_127 + (((long)(long)val_62 | 2) * val_133);
            float val_134 = ((long)(int)(((long)(int)((W23 << 2)) | 2)) * 12) + val_4 + 36;
            val_134 = val_134 * this.scale;
            mem2[0] = val_134;
            var val_135 = 12;
            val_135 = val_127 + (((long)(long)val_62 | 3) * val_135);
            float val_136 = ((long)(int)(((long)(int)((W23 << 2)) | 3)) * 12) + val_4 + 32;
            val_136 = val_136 * this.scale;
            mem2[0] = val_136;
            var val_137 = 12;
            val_137 = val_127 + (((long)(long)val_62 | 3) * val_137);
            float val_138 = this.scale;
            val_138 = (((long)(int)(((long)(int)((W23 << 2)) | 3)) * 12) + val_4 + 36) * val_138;
            mem2[0] = val_138;
            float val_139 = val_18;
            float val_140 = val_20;
            float val_141 = val_22;
            float val_142 = val_24;
            val_139 = val_139 * 255f;
            val_140 = val_140 * 255f;
            val_141 = val_141 * 255f;
            var val_65 = (val_139 < 0) ? ((int)val_139) : ((int)val_139);
            val_142 = val_142 * 255f;
            var val_66 = (val_140 < 0) ? ((int)val_140) : ((int)val_140);
            var val_67 = (val_141 < 0) ? ((int)val_141) : ((int)val_141);
            var val_68 = (val_142 < 0) ? ((int)val_142) : ((int)val_142);
            val_122[(long)(long)val_62 | 3] = 0;
            val_122[(long)(long)val_62 | 2] = 0;
            val_122[val_143] = 0;
            val_122[(long)val_62] = 0;
            var val_70 = (this.particles + (X23 * 100)) + 32;
            val_128 = W23 + 1;
            goto label_73;
            label_99:
            Particle val_143 = this.particles[29];
            val_143 = val_143 - 1;
            if((long)val_128 != val_143)
            {
                    val_144 = this.particles.Length;
                int val_71 = this.emitterConfig.particleCount - 1;
                if(val_71 >= val_144)
            {
                    val_144 = this.particles.Length;
            }
            
                val_71 = this.particles + ((long)val_71 * 100);
                var val_72 = val_71 + 32;
                var val_74 = (this.particles + ((long)val_128 * 100)) + 32;
            }
            
            int val_144 = this.emitterConfig.particleCount;
            UnityEngine.Vector2 val_75 = new UnityEngine.Vector2(x:  0f, y:  0f);
            UnityEngine.Vector3 val_76 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_75.x, y = val_75.y});
            val_119 = val_76.y;
            val_144 = val_144 << 2;
            var val_78 = val_127 + (((long)val_144 - 1) * 12);
            mem2[0] = val_76.x;
            mem2[0] = val_119;
            mem2[0] = val_76.z;
            val_143 = (long)val_144 - 2;
            var val_80 = val_127 + (val_143 * 12);
            mem2[0] = val_76.x;
            mem2[0] = val_119;
            mem2[0] = val_76.z;
            var val_83 = val_127 + (((long)val_144 - 3) * 12);
            mem2[0] = val_76.x;
            mem2[0] = val_119;
            mem2[0] = val_76.z;
            var val_84 = val_127 + (((long)val_144 - 4) * 12);
            mem2[0] = val_76.x;
            mem2[0] = val_119;
            mem2[0] = val_76.z;
            val_122[(long)val_144 - 1] = 0;
            val_122[val_143] = 0;
            val_122[(long)val_144 - 3] = 0;
            val_122[(long)val_144 - 4] = 0;
            if(this.emitterConfig != null)
            {
                    val_145 = this.emitterConfig.particleCount;
                val_146 = this.emitterConfig.particleCount;
            }
            else
            {
                    val_145 = 0;
                val_146 = 268;
            }
            
            val_129 = 100;
            mem[268] = val_145 - 1;
            label_73:
            if((long)val_128 >= this.emitterConfig.particleCount)
            {
                goto label_95;
            }
            
            var val_87 = (this.particles + ((long)val_128 * 100)) + 32;
            float val_89 = val_88 - aDelta;
            val_88 = val_89;
            if(val_89 <= 0f)
            {
                goto label_99;
            }
            
            if(this.emitterConfig.emitterType != 1)
            {
                goto label_100;
            }
            
            float val_145 = val_91;
            val_145 = val_145 * aDelta;
            val_147 = val_90 + val_145;
            float val_146 = val_93;
            val_90 = val_147;
            val_146 = val_146 * aDelta;
            val_146 = val_92 + val_146;
            val_92 = val_146;
            if(this.emitterConfig == null)
            {
                    val_147 = val_90;
            }
            
            float val_147 = val_147;
            val_147 = val_147 * val_92;
            val_147 = this.emitterConfig.sourcePosition - val_147;
            float val_94 = System.Convert.ToSingle(value:  val_147);
            float val_148 = val_90;
            val_148 = val_148 * val_92;
            val_148 = this.emitterConfig.sourcePosition - val_148;
            float val_95 = System.Convert.ToSingle(value:  val_148);
            goto label_107;
            label_100:
            UnityEngine.Vector2 val_98 = new UnityEngine.Vector2(x:  0f, y:  0f);
            UnityEngine.Vector2 val_99 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_96, y = val_97}, b:  new UnityEngine.Vector2() {x = val_98.x, y = val_98.y});
            val_119 = val_99.y;
            val_15 = val_99.x;
            UnityEngine.Vector2 val_100 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_11, y = val_13}, b:  new UnityEngine.Vector2() {x = val_99.x, y = val_119});
            val_11 = val_100.x;
            val_13 = val_100.y;
            if(val_100.x != 0f)
            {
                goto label_110;
            }
            
            val_148 = 0f;
            val_136 = 0f;
            if(val_100.y == 0f)
            {
                goto label_111;
            }
            
            label_110:
            UnityEngine.Vector2 val_101 = val_11.normalized;
            val_148 = val_101.x;
            val_136 = val_101.y;
            label_111:
            val_132 = val_102;
            if(this.emitterConfig == null)
            {
                goto label_112;
            }
            
            val_101.y = (val_148 * val_132) - (val_136 * val_103);
            goto label_113;
            label_112:
            if(this.emitterConfig != null)
            {
                goto label_114;
            }
            
            label_29:
            label_95:
            if((this.emitterConfig.particleCount == 0) && (this.AutoLoop != false))
            {
                    this.reset();
            }
            
            this.mesh.vertices = val_127;
            val_149 = this.mesh;
            val_149.colors32 = val_122;
            val_114 = this.mesh;
            val_114.RecalculateBounds();
        }
        public bool addParticle()
        {
            int val_75;
            PDUnityParticleEmitter val_76;
            float val_77;
            float val_78;
            float val_79;
            UnityEngine.Vector2 val_80;
            var val_81;
            PDUnityParticleEmitter val_82;
            PDUnityParticleEmitter val_83;
            PDUnityParticleEmitter val_84;
            PDUnityParticleEmitter val_85;
            PDUnityParticleEmitter val_86;
            float val_87;
            float val_88;
            float val_89;
            float val_90;
            float val_91;
            float val_92;
            float val_93;
            float val_94;
            float val_95;
            float val_96;
            float val_97;
            float val_98;
            float val_99;
            float val_100;
            float val_101;
            float val_102;
            float val_103;
            float val_104;
            float val_105;
            float val_106;
            float val_107;
            float val_108;
            int val_109;
            val_75 = this;
            val_76 = this.emitterConfig;
            if(this.emitterOrigin != 0)
            {
                    UnityEngine.Vector3 val_3 = this.emitterOrigin.transform.position;
                UnityEngine.Vector3 val_6 = this.gameObject.transform.position;
                val_77 = val_6.y;
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_77, z = val_6.z});
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  this.scale);
                val_78 = val_8.z;
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_78});
                val_79 = val_9.x;
                this.emitterConfig.sourcePosition = val_9;
                mem2[0] = val_9.y;
            }
            else
            {
                    this.emitterConfig.sourcePosition = 0;
            }
            
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            if(this.emitterConfig.particleCount >= this.emitterConfig.maxParticles)
            {
                goto label_17;
            }
            
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            if(this.emitterConfig == null)
            {
                goto label_25;
            }
            
            val_80 = this.emitterConfig.sourcePosition;
            goto label_26;
            label_17:
            val_81 = 0;
            return (bool)val_81;
            label_25:
            val_80 = this.emitterConfig.sourcePosition;
            if(this.emitterConfig == null)
            {
                goto label_28;
            }
            
            label_26:
            label_78:
            label_79:
            float val_59 = UnityEngine.Random.Range(min:  -1f, max:  1f);
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            val_59 = this.emitterConfig.angle + (this.emitterConfig.angleVariance * val_59);
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            float val_60 = 1f;
            float val_15 = UnityEngine.Random.Range(min:  -1f, max:  val_60);
            val_15 = this.emitterConfig.lifeSpanVariance * val_15;
            val_60 = this.emitterConfig.lifeSpan + val_15;
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            float val_61 = UnityEngine.Random.Range(min:  -1f, max:  1f);
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            val_61 = this.emitterConfig.startParticleSize + (this.emitterConfig.startParticleSizeVariance * val_61);
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            float val_27 = UnityEngine.Random.Range(min:  -1f, max:  1f);
            val_27 = this.emitterConfig.startColorVariance * val_27;
            val_27 = this.emitterConfig.startColor + val_27;
            float val_28 = UnityEngine.Mathf.Clamp(value:  val_27, min:  0f, max:  1f);
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            float val_29 = UnityEngine.Random.Range(min:  -1f, max:  1f);
            val_29 = this.emitterConfig.startColorVariance * val_29;
            val_29 = this.emitterConfig.startColor + val_29;
            float val_30 = UnityEngine.Mathf.Clamp(value:  val_29, min:  0f, max:  1f);
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            float val_31 = UnityEngine.Random.Range(min:  -1f, max:  1f);
            val_31 = this.emitterConfig.startColorVariance * val_31;
            val_31 = this.emitterConfig.startColor + val_31;
            float val_32 = UnityEngine.Mathf.Clamp(value:  val_31, min:  0f, max:  1f);
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            float val_33 = UnityEngine.Random.Range(min:  -1f, max:  1f);
            val_33 = this.emitterConfig.startColorVariance * val_33;
            val_33 = this.emitterConfig.startColor + val_33;
            float val_34 = UnityEngine.Mathf.Clamp(value:  val_33, min:  0f, max:  1f);
            if(this.emitterConfig == null)
            {
                    if(this.emitterConfig == null)
            {
                goto label_72;
            }
            
            }
            
            float val_35 = UnityEngine.Random.Range(min:  -1f, max:  1f);
            val_35 = this.emitterConfig.finishColorVariance * val_35;
            val_35 = this.emitterConfig.finishColor + val_35;
            val_82 = this.emitterConfig;
            if(this.emitterConfig != null)
            {
                goto label_63;
            }
            
            val_82 = this.emitterConfig;
            if(val_82 == null)
            {
                goto label_72;
            }
            
            label_63:
            float val_37 = UnityEngine.Random.Range(min:  -1f, max:  1f);
            val_37 = this.emitterConfig.finishColorVariance * val_37;
            val_37 = this.emitterConfig.finishColor + val_37;
            val_83 = this.emitterConfig;
            if(this.emitterConfig != null)
            {
                goto label_65;
            }
            
            val_83 = this.emitterConfig;
            if(val_83 == null)
            {
                goto label_72;
            }
            
            label_65:
            float val_39 = UnityEngine.Random.Range(min:  -1f, max:  1f);
            val_39 = this.emitterConfig.finishColorVariance * val_39;
            val_39 = this.emitterConfig.finishColor + val_39;
            val_84 = this.emitterConfig;
            if(this.emitterConfig != null)
            {
                goto label_67;
            }
            
            val_84 = this.emitterConfig;
            if(val_84 == null)
            {
                goto label_72;
            }
            
            label_67:
            float val_41 = UnityEngine.Random.Range(min:  -1f, max:  1f);
            val_41 = this.emitterConfig.finishColorVariance * val_41;
            val_41 = this.emitterConfig.finishColor + val_41;
            val_85 = this.emitterConfig;
            if(this.emitterConfig != null)
            {
                goto label_69;
            }
            
            val_85 = this.emitterConfig;
            if(val_85 == null)
            {
                goto label_72;
            }
            
            label_69:
            float val_66 = this.emitterConfig.rotationStart;
            val_86 = this.emitterConfig;
            if(this.emitterConfig != null)
            {
                goto label_71;
            }
            
            val_86 = this.emitterConfig;
            if(val_86 == null)
            {
                goto label_72;
            }
            
            label_71:
            float val_62 = this.emitterConfig.speedVariance;
            val_62 = val_62 * (UnityEngine.Random.Range(min:  -1f, max:  1f));
            float val_63 = this.emitterConfig.minRadiusVariance;
            float val_45 = this.emitterConfig.maxRadius + (this.emitterConfig.maxRadiusVariance * (UnityEngine.Random.Range(min:  -1f, max:  1f)));
            val_63 = val_63 * (UnityEngine.Random.Range(min:  -1f, max:  1f));
            float val_67 = this.emitterConfig.rotationEndVariance;
            float val_64 = this.emitterConfig.finishParticleSizeVariance;
            float val_65 = this.emitterConfig.finishParticleSize;
            val_64 = val_64 * (UnityEngine.Random.Range(min:  -1f, max:  1f));
            val_65 = val_65 + val_64;
            val_66 = val_66 + (this.emitterConfig.rotationStartVariance * (UnityEngine.Random.Range(min:  -1f, max:  1f)));
            float val_49 = UnityEngine.Random.Range(min:  -1f, max:  1f);
            val_49 = val_67 * val_49;
            val_67 = this.emitterConfig.rotationEnd + val_49;
            val_87 = (this.emitterConfig.minRadius + val_63) - val_45;
            val_88 = 0.01745329f;
            val_89 = val_67 - val_66;
            val_90 = val_66;
            float val_52 = this.emitterConfig.speed + val_62;
            val_91 = this.emitterConfig.angleVariance * (UnityEngine.Random.Range(min:  -1f, max:  1f));
            val_92 = this.emitterConfig.rotatePerSecond + (this.emitterConfig.rotatePerSecondVariance * (UnityEngine.Random.Range(min:  -1f, max:  1f)));
            val_93 = this.emitterConfig.radialAccelerationVariance * (UnityEngine.Random.Range(min:  -1f, max:  1f));
            val_94 = (UnityEngine.Mathf.Clamp(value:  val_35, min:  0f, max:  1f)) - val_28;
            val_95 = (UnityEngine.Mathf.Clamp(value:  val_37, min:  0f, max:  1f)) - val_30;
            val_96 = (UnityEngine.Mathf.Clamp(value:  val_39, min:  0f, max:  1f)) - val_32;
            val_97 = (UnityEngine.Mathf.Clamp(value:  val_41, min:  0f, max:  1f)) - val_34;
            val_98 = val_45;
            if(this.particles == null)
            {
                    val_93 = val_93;
                val_88 = val_88;
                val_92 = val_92;
                val_91 = val_91;
                val_87 = val_87;
                val_94 = val_94;
                val_97 = val_97;
                val_89 = val_89;
                val_98 = val_98;
                val_96 = val_96;
                val_95 = val_95;
            }
            
            val_99 = val_92 * val_88;
            val_100 = this.emitterConfig.sourcePosition + (this.emitterConfig.sourcePositionVariance * (UnityEngine.Random.Range(min:  -1f, max:  1f)));
            val_101 = (???) + ((???) * (UnityEngine.Random.Range(min:  -1f, max:  1f)));
            val_102 = val_52 * val_59;
            val_78 = System.Math.Max(val1:  0f, val2:  val_60);
            val_103 = this.emitterConfig.angle + val_91;
            val_104 = val_87 / val_78;
            val_105 = (val_65 - val_61) / val_78;
            val_106 = val_94 / val_78;
            val_107 = this.emitterConfig.radialAcceleration + val_93;
            val_77 = val_97 / val_78;
            val_79 = val_89 / val_78;
            val_108 = this.emitterConfig.tangentialAcceleration + (this.emitterConfig.tangentialAccelerationVariance * (UnityEngine.Random.Range(min:  -1f, max:  1f)));
            if(this.emitterConfig.particleCount >= this.particles.Length)
            {
                    val_106 = val_106;
                val_101 = val_101;
                val_100 = val_100;
                val_108 = val_108;
                val_107 = val_107;
                val_99 = val_99;
                val_105 = val_105;
                val_103 = val_103;
                val_104 = val_104;
                val_90 = val_90;
                val_98 = val_98;
                val_102 = val_102;
            }
            
            int val_58 = this.particles + (this.emitterConfig.particleCount * 100);
            mem2[0] = val_100;
            mem2[0] = val_101;
            mem2[0] = val_102;
            mem2[0] = val_52 * val_59;
            mem2[0] = val_80;
            mem2[0] = this.emitterConfig;
            mem2[0] = val_28;
            mem2[0] = val_30;
            mem2[0] = val_32;
            mem2[0] = val_95 / val_78;
            mem2[0] = val_96 / val_78;
            mem2[0] = val_77;
            mem2[0] = val_90;
            mem2[0] = val_79;
            mem2[0] = val_107;
            mem2[0] = val_34;
            mem2[0] = val_106;
            mem2[0] = val_108;
            mem2[0] = val_98;
            mem2[0] = val_104;
            mem2[0] = val_103;
            mem2[0] = val_99;
            mem2[0] = val_78;
            mem2[0] = System.Math.Max(val1:  0f, val2:  val_61);
            mem2[0] = val_105;
            if(this.emitterConfig != null)
            {
                    val_109 = this.emitterConfig.particleCount;
                val_75 = this.emitterConfig.particleCount;
            }
            else
            {
                    val_75 = 268;
                val_109 = 0;
            }
            
            val_81 = 1;
            mem[268] = 1;
            return (bool)val_81;
            label_28:
            if(this.emitterConfig != null)
            {
                goto label_78;
            }
            
            if(this.emitterConfig != null)
            {
                goto label_79;
            }
            
            label_72:
        }
        public void reset()
        {
            var val_1;
            UnityEngine.Debug.Log(message:  "Reset");
            this.Running = true;
            val_1 = 0;
            this.emitterConfig.elapsedTime = 0f;
            goto label_4;
            label_8:
            val_1 = 1;
            label_4:
            if(val_1 < this.emitterConfig.particleCount)
            {
                goto label_8;
            }
            
            this.emitterConfig.emitCounter = 0f;
        }
        public void setupData()
        {
            var val_15;
            SeventyOneSquared.PDUnity val_16;
            UnityEngine.Vector3[] val_17;
            var val_18;
            int val_19;
            var val_20;
            var val_21;
            val_16 = this;
            if(this.emitterConfig == null)
            {
                    return;
            }
            
            int val_1 = this.emitterConfig.maxParticles << 2;
            UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
            val_17 = val_2;
            int val_3 = this.emitterConfig.maxParticles << 2;
            UnityEngine.Vector2[] val_4 = new UnityEngine.Vector2[0];
            int val_19 = this.emitterConfig.maxParticles;
            val_19 = val_19 + (val_19 << 1);
            int val_5 = val_19 << 1;
            int[] val_6 = new int[0];
            int val_7 = this.emitterConfig.maxParticles << 2;
            UnityEngine.Color32[] val_8 = new UnityEngine.Color32[0];
            val_18 = 0;
            goto label_5;
            label_24:
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  0f, y:  0f);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            mem[1152921529346133348] = val_10.x;
            mem[1152921529346133352] = val_10.y;
            mem[1152921529346133356] = val_10.z;
            mem[1152921529346133336] = val_10.x;
            mem[1152921529346133340] = val_10.y;
            mem[1152921529346133344] = val_10.z;
            val_19 = 0;
            mem[1152921529346133324] = val_10.x;
            mem[1152921529346133328] = val_10.y;
            mem[1152921529346133332] = val_10.z;
            mem[1152921529346133312] = val_10.x;
            mem[1152921529346133316] = val_10.y;
            mem[1152921529346133320] = val_10.z;
            UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  0f, y:  0f);
            val_4[0] = val_11.x;
            val_4[0] = val_11.y;
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  0f, y:  1f);
            val_4[1] = val_12.x;
            val_4[1] = val_12.y;
            UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  1f, y:  1f);
            val_4[2] = val_13.x;
            val_4[2] = val_13.y;
            UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  1f, y:  0f);
            val_4[3] = val_14.x;
            val_4[3] = val_14.y;
            val_17 = val_17;
            UnityEngine.Color32[] val_15 = val_8 + 0;
            mem2[0] = 0;
            UnityEngine.Color32[] val_16 = val_8 + 4;
            mem2[0] = 0;
            UnityEngine.Color32[] val_17 = val_8 + 8;
            mem2[0] = 0;
            UnityEngine.Color32[] val_18 = val_8 + 12;
            mem2[0] = 0;
            val_16 = val_16;
            val_18 = 1;
            label_5:
            if(val_18 < this.emitterConfig.maxParticles)
            {
                goto label_24;
            }
            
            val_20 = 0;
            val_21 = 5;
            goto label_25;
            label_34:
            val_6[0] = 0;
            val_6[4] = 1;
            val_19 = 2;
            val_6[8] = val_19;
            val_6[12] = 0;
            val_6[16] = val_19;
            val_20 = 1;
            val_6[20] = 3;
            val_21 = 11;
            label_25:
            if(val_20 < this.emitterConfig.maxParticles)
            {
                goto label_34;
            }
            
            mem[1152921529346097288].Clear();
            mem[1152921529346097288].vertices = val_2;
            mem[1152921529346097288].colors32 = val_8;
            mem[1152921529346097288].uv = val_4;
            val_15 = mem[1152921529346097288];
            val_15.triangles = val_6;
        }
        public void EditorUpdate()
        {
            if(this.EmitterFile != this.currentEmitterFile)
            {
                    this.emitterConfig = 0;
                this.initialized = false;
                this.currentEmitterFile = 0;
                if(this.EmitterFile != 0)
            {
                    this.loadEmitterFile();
            }
            
            }
            
            if(this.texture != this.currentTexture)
            {
                    this.currentTexture = 0;
                this.material.mainTexture = 0;
                this.loadTexture();
            }
            
            if(this.RunInEditor == false)
            {
                    return;
            }
            
            this.UpdateWithDelta(aDelta:  UnityEngine.Time.fixedDeltaTime);
        }
        private void ClearDown()
        {
            this.emitterConfig = 0;
            this.initialized = false;
        }
        private void parseBinaryFile()
        {
            PDUnityParticleEmitter val_54;
            System.Byte[] val_55;
            int val_56;
            int val_57;
            PDUnityParticleEmitter val_58;
            PDUnityParticleEmitter val_59;
            val_54 = this;
            if(this.EmitterFile == 0)
            {
                    return;
            }
            
            this.emitterConfig = new PDUnity.PDUnityParticleEmitter();
            val_55 = this.EmitterFile.bytes;
            System.IO.MemoryStream val_4 = new System.IO.MemoryStream(buffer:  val_55);
            if((SeventyOneSquared.PDUnity.ReadULong(fs:  val_4)) != 1)
            {
                    return;
            }
            
            this.emitterConfig.textureName = SeventyOneSquared.PDUnity.ReadString(fs:  val_4);
            if((SeventyOneSquared.PDUnity.ReadLong(fs:  val_4)) == 1)
            {
                    this.emitterConfig.textureData = SeventyOneSquared.PDUnity.ReadData(fs:  val_4);
            }
            
            this.emitterConfig.opacityModifyRGB = System.Convert.ToBoolean(value:  SeventyOneSquared.PDUnity.ReadLong(fs:  val_4));
            int val_12 = SeventyOneSquared.PDUnity.ReadLong(fs:  val_4);
            if((val_12 - 768) > 8)
            {
                goto label_12;
            }
            
            var val_54 = 40828284 + ((val_12 - 768)) << 2;
            val_54 = val_54 + 40828284;
            goto (40828284 + ((val_12 - 768)) << 2 + 40828284);
            label_12:
            if(val_12 != 1)
            {
                goto label_15;
            }
            
            val_56 = 1;
            if(this.emitterConfig != null)
            {
                goto label_34;
            }
            
            goto label_33;
            label_15:
            val_56 = 0;
            if(this.emitterConfig != null)
            {
                goto label_34;
            }
            
            label_33:
            label_34:
            this.emitterConfig.blendFuncSource = val_56;
            int val_14 = SeventyOneSquared.PDUnity.ReadLong(fs:  val_4);
            if((val_14 - 768) > 8)
            {
                goto label_35;
            }
            
            var val_55 = 40828320 + ((val_14 - 768)) << 2;
            val_55 = val_55 + 40828320;
            goto (40828320 + ((val_14 - 768)) << 2 + 40828320);
            label_35:
            if(val_14 != 1)
            {
                goto label_38;
            }
            
            val_57 = 1;
            if(this.emitterConfig != null)
            {
                goto label_57;
            }
            
            goto label_56;
            label_38:
            val_57 = 0;
            if(this.emitterConfig != null)
            {
                goto label_57;
            }
            
            label_56:
            label_57:
            this.emitterConfig.blendFuncDestination = val_57;
            this.emitterConfig.positionType = SeventyOneSquared.PDUnity.ReadLong(fs:  val_4);
            this.emitterConfig.yScale = SeventyOneSquared.PDUnity.ReadLong(fs:  val_4);
            UnityEngine.Vector2 val_18 = SeventyOneSquared.PDUnity.ReadVector2(fs:  val_4);
            this.emitterConfig.sourcePosition = val_18;
            mem2[0] = val_18.y;
            UnityEngine.Vector2 val_19 = SeventyOneSquared.PDUnity.ReadVector2(fs:  val_4);
            this.emitterConfig.sourcePositionVariance = val_19;
            mem2[0] = val_19.y;
            this.emitterConfig.sourcePosition = 0;
            this.emitterConfig.speed = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.speedVariance = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.lifeSpan = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.lifeSpanVariance = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            double val_24 = SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            val_24 = (float)val_24 * 0.01745329f;
            this.emitterConfig.angle = val_24;
            double val_25 = SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            val_25 = (float)val_25 * 0.01745329f;
            this.emitterConfig.angleVariance = val_25;
            UnityEngine.Vector2 val_26 = SeventyOneSquared.PDUnity.ReadVector2(fs:  val_4);
            this.emitterConfig.gravity = val_26;
            mem2[0] = val_26.y;
            this.emitterConfig.radialAcceleration = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.tangentialAcceleration = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.radialAccelerationVariance = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.tangentialAccelerationVariance = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            UnityEngine.Color val_31 = SeventyOneSquared.PDUnity.ReadColor(fs:  val_4);
            this.emitterConfig.startColor = val_31;
            mem2[0] = val_31.g;
            mem2[0] = val_31.b;
            mem2[0] = val_31.a;
            UnityEngine.Color val_32 = SeventyOneSquared.PDUnity.ReadColor(fs:  val_4);
            this.emitterConfig.startColorVariance = val_32;
            mem2[0] = val_32.g;
            mem2[0] = val_32.b;
            mem2[0] = val_32.a;
            UnityEngine.Color val_33 = SeventyOneSquared.PDUnity.ReadColor(fs:  val_4);
            this.emitterConfig.finishColor = val_33;
            mem2[0] = val_33.g;
            mem2[0] = val_33.b;
            mem2[0] = val_33.a;
            UnityEngine.Color val_34 = SeventyOneSquared.PDUnity.ReadColor(fs:  val_4);
            this.emitterConfig.finishColorVariance = val_34;
            mem2[0] = val_34.g;
            mem2[0] = val_34.b;
            mem2[0] = val_34.a;
            this.emitterConfig.maxParticles = SeventyOneSquared.PDUnity.ReadLong(fs:  val_4);
            this.emitterConfig.startParticleSize = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.startParticleSizeVariance = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.finishParticleSize = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.finishParticleSizeVariance = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.duration = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.emitterType = SeventyOneSquared.PDUnity.ReadLong(fs:  val_4);
            this.emitterConfig.maxRadius = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.maxRadiusVariance = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.minRadius = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.minRadiusVariance = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.rotatePerSecond = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.rotatePerSecondVariance = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.rotationStart = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.rotationStartVariance = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.rotationEnd = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.rotationEndVariance = (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  val_4);
            this.emitterConfig.texture = new UnityEngine.Texture2D(width:  2, height:  2, textureFormat:  12, mipChain:  false);
            val_58 = this.emitterConfig;
            if(this.emitterConfig != null)
            {
                goto label_96;
            }
            
            val_58 = this.emitterConfig;
            if(val_58 == null)
            {
                goto label_101;
            }
            
            label_96:
            bool val_53 = UnityEngine.ImageConversion.LoadImage(tex:  this.emitterConfig.texture, data:  this.emitterConfig.textureData);
            val_55 = this.emitterConfig.texture;
            this.material.mainTexture = val_55;
            val_59 = this.emitterConfig;
            if(this.emitterConfig != null)
            {
                goto label_100;
            }
            
            val_59 = this.emitterConfig;
            if(val_59 == null)
            {
                goto label_101;
            }
            
            label_100:
            float val_56 = (float)this.emitterConfig.maxParticles;
            val_56 = val_56 / this.emitterConfig.lifeSpan;
            this.emitterConfig.emissionRate = val_56;
            val_54 = this.emitterConfig;
            this.emitterConfig.emitCounter = 0f;
            return;
            label_101:
        }
        private static string ReadString(System.IO.MemoryStream fs)
        {
            uint val_2 = (SeventyOneSquared.PDUnity.ReadULong(fs:  fs)) + 1;
            byte[] val_3 = new byte[0];
            if(System.Text.Encoding.UTF8 == null)
            {
                
            }
        
        }
        private static byte[] ReadData(System.IO.MemoryStream fs)
        {
            uint val_1 = SeventyOneSquared.PDUnity.ReadULong(fs:  fs);
            if(fs != null)
            {
                    return (System.Byte[])new byte[0];
            }
            
            return (System.Byte[])new byte[0];
        }
        private static ushort ReadChar(System.IO.MemoryStream fs, int characters)
        {
            string[] val_1 = new string[0];
            byte val_3 = (System.Convert.ToByte(value:  val_1.Length)) & 255;
            byte[] val_4 = new byte[0];
            return System.BitConverter.ToUInt16(value:  SeventyOneSquared.PDUnity.ReadAndSwap(fs:  fs, size:  val_4.Length), startIndex:  0);
        }
        private static ushort ReadByte(System.IO.MemoryStream fs)
        {
            byte[] val_1 = new byte[11];
            return System.BitConverter.ToUInt16(value:  SeventyOneSquared.PDUnity.ReadAndSwap(fs:  fs, size:  val_1.Length), startIndex:  0);
        }
        private static ushort ReadUShort(System.IO.MemoryStream fs)
        {
            byte[] val_1 = new byte[2];
            return System.BitConverter.ToUInt16(value:  SeventyOneSquared.PDUnity.ReadAndSwap(fs:  fs, size:  val_1.Length), startIndex:  0);
        }
        private static uint ReadULong(System.IO.MemoryStream fs)
        {
            byte[] val_1 = new byte[4];
            return System.BitConverter.ToUInt32(value:  SeventyOneSquared.PDUnity.ReadAndSwap(fs:  fs, size:  val_1.Length), startIndex:  0);
        }
        private static short ReadShort(System.IO.MemoryStream fs)
        {
            byte[] val_1 = new byte[2];
            return System.BitConverter.ToInt16(value:  SeventyOneSquared.PDUnity.ReadAndSwap(fs:  fs, size:  val_1.Length), startIndex:  0);
        }
        private static int ReadLong(System.IO.MemoryStream fs)
        {
            byte[] val_1 = new byte[4];
            return System.BitConverter.ToInt32(value:  SeventyOneSquared.PDUnity.ReadAndSwap(fs:  fs, size:  val_1.Length), startIndex:  0);
        }
        private static UnityEngine.Color ReadColor(System.IO.MemoryStream fs)
        {
            double val_1 = SeventyOneSquared.PDUnity.ReadDouble(fs:  fs);
            double val_2 = SeventyOneSquared.PDUnity.ReadDouble(fs:  fs);
            double val_3 = SeventyOneSquared.PDUnity.ReadDouble(fs:  fs);
            double val_4 = SeventyOneSquared.PDUnity.ReadDouble(fs:  fs);
            return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        private static UnityEngine.Vector2 ReadVector2(System.IO.MemoryStream fs)
        {
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  fs), y:  (float)SeventyOneSquared.PDUnity.ReadDouble(fs:  fs));
            return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
        private static float ReadFloat(System.IO.MemoryStream fs)
        {
            return (float)(float)SeventyOneSquared.PDUnity.ReadDouble(fs:  fs);
        }
        private static double ReadDouble(System.IO.MemoryStream fs)
        {
            byte[] val_1 = new byte[8];
            return System.BitConverter.ToDouble(value:  SeventyOneSquared.PDUnity.ReadAndSwap(fs:  fs, size:  val_1.Length), startIndex:  0);
        }
        private static byte[] ReadAndSwap(System.IO.MemoryStream fs, int size)
        {
            byte[] val_1 = new byte[0];
            if(val_1 != null)
            {
                    if(fs == null)
            {
                    return (System.Byte[])val_1;
            }
            
                return (System.Byte[])val_1;
            }
            
            if(fs != null)
            {
                    return (System.Byte[])val_1;
            }
            
            return (System.Byte[])val_1;
        }
        private int UnityBlendModeForGLBlendMode(int GLBlendMode)
        {
            if((GLBlendMode - 768) <= 8)
            {
                    var val_2 = 40828356 + ((GLBlendMode - 768)) << 2;
                val_2 = val_2 + 40828356;
            }
            else
            {
                    if(GLBlendMode != 1)
            {
                    return 0;
            }
            
                return 1;
            }
        
        }
        public PDUnity()
        {
            this.Running = true;
            this.AutoLoop = true;
            this.RunInEditor = true;
            this.scale = 0.04f;
            this.particles = new Particle[2000];
        }
    
    }

}
