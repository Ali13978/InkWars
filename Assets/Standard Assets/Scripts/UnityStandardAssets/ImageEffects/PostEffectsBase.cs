using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
    public class PostEffectsBase : MonoBehaviour
    {
        // Fields
        protected bool supportHDRTextures;
        protected bool supportDX11;
        protected bool isSupported;
        
        // Methods
        protected UnityEngine.Material CheckShaderAndCreateMaterial(UnityEngine.Shader s, UnityEngine.Material m2Create)
        {
            UnityEngine.Object val_15;
            UnityEngine.Object val_16;
            UnityEngine.Object val_17;
            var val_18;
            var val_19;
            var val_20;
            val_15 = m2Create;
            val_16 = s;
            val_17 = this;
            if((UnityEngine.Object.op_Implicit(exists:  val_16)) == false)
            {
                goto label_3;
            }
            
            if(val_16.isSupported != false)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  val_15)) != false)
            {
                    if(val_15.shader == val_16)
            {
                goto label_12;
            }
            
            }
            
            }
            
            if(val_16.isSupported == false)
            {
                goto label_14;
            }
            
            UnityEngine.Material val_7 = null;
            val_17 = val_7;
            val_7 = new UnityEngine.Material(shader:  val_16);
            val_7.hideFlags = 52;
            var val_9 = ((UnityEngine.Object.op_Implicit(exists:  val_7)) != true) ? (val_17) : 0;
            return (UnityEngine.Material)val_18;
            label_3:
            UnityEngine.Debug.Log(message:  "Missing shader in " + m2Create.ToString());
            this.enabled = false;
            goto label_21;
            label_14:
            this.enabled = false;
            this.isSupported = false;
            val_19 = 5;
            string[] val_12 = new string[5];
            if("The shader " == null)
            {
                    val_19 = 0;
            }
            
            if(val_12.Length == 0)
            {
                    val_19 = 0;
            }
            
            val_12[0] = "The shader ";
            if((val_16 != null) && (val_16 == null))
            {
                    val_20 = 0;
            }
            
            if(val_12.Length <= 1)
            {
                    val_20 = 0;
            }
            
            val_12[1] = val_16;
            if(" on effect " == null)
            {
                    val_20 = 0;
            }
            
            val_16 = " on effect ";
            if(val_12.Length <= 2)
            {
                    val_20 = 0;
            }
            
            val_12[2] = val_16;
            val_12[3] = this.ToString();
            val_12[4] = " is not supported on this platform!";
            val_17 = +val_12;
            UnityEngine.Debug.Log(message:  val_17);
            label_21:
            val_15 = 0;
            label_12:
            val_18 = val_15;
            return (UnityEngine.Material)val_18;
        }
        protected UnityEngine.Material CreateMaterial(UnityEngine.Shader s, UnityEngine.Material m2Create)
        {
            UnityEngine.Object val_12;
            UnityEngine.Object val_13;
            UnityEngine.Object val_14;
            var val_15;
            val_12 = m2Create;
            val_13 = s;
            val_14 = this;
            if((UnityEngine.Object.op_Implicit(exists:  val_13)) == false)
            {
                goto label_3;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  val_12)) != false)
            {
                    val_14 = val_12.shader;
                if(val_14 == val_13)
            {
                    if(val_13.isSupported == true)
            {
                goto label_14;
            }
            
            }
            
            }
            
            val_12 = 0;
            if(val_13.isSupported == false)
            {
                goto label_14;
            }
            
            UnityEngine.Material val_7 = new UnityEngine.Material(shader:  val_13);
            val_7.hideFlags = 52;
            var val_9 = ((UnityEngine.Object.op_Implicit(exists:  val_7)) != true) ? (val_7) : 0;
            return (UnityEngine.Material)val_15;
            label_3:
            val_13 = "Missing shader in " + m2Create.ToString();
            UnityEngine.Debug.Log(message:  val_13);
            val_12 = 0;
            label_14:
            val_15 = val_12;
            return (UnityEngine.Material)val_15;
        }
        private void OnEnable()
        {
            this.isSupported = true;
        }
        protected bool CheckSupport()
        {
            return this.CheckSupport(needDepth:  false);
        }
        public virtual bool CheckResources()
        {
            UnityEngine.Debug.LogWarning(message:  "CheckResources () for " + this.ToString() + " should be overwritten.");
            return (bool)this.isSupported;
        }
        protected void Start()
        {
            goto typeof(UnityStandardAssets.ImageEffects.PostEffectsBase).__il2cppRuntimeField_168;
        }
        protected bool CheckSupport(bool needDepth)
        {
            var val_12;
            bool val_13;
            var val_14;
            var val_15;
            val_12 = this;
            this.isSupported = true;
            this.supportHDRTextures = UnityEngine.SystemInfo.SupportsRenderTextureFormat(format:  2);
            if(UnityEngine.SystemInfo.graphicsShaderLevel < 50)
            {
                    val_13 = 0;
            }
            else
            {
                    val_13 = UnityEngine.SystemInfo.supportsComputeShaders;
            }
            
            this.supportDX11 = val_13;
            if(UnityEngine.SystemInfo.supportsImageEffects == false)
            {
                goto label_5;
            }
            
            if(needDepth == false)
            {
                goto label_4;
            }
            
            if((UnityEngine.SystemInfo.SupportsRenderTextureFormat(format:  1)) == false)
            {
                goto label_5;
            }
            
            val_12 = this.GetComponent<UnityEngine.Camera>();
            if(val_12 == null)
            {
                goto label_6;
            }
            
            val_14 = val_12.depthTextureMode;
            goto label_7;
            label_5:
            this.enabled = false;
            val_15 = 0;
            this.isSupported = false;
            return (bool)val_15;
            label_6:
            val_14 = val_12.depthTextureMode;
            label_7:
            val_12.depthTextureMode = val_14 | 1;
            label_4:
            val_15 = 1;
            return (bool)val_15;
        }
        protected bool CheckSupport(bool needDepth, bool needHdr)
        {
            var val_3;
            if(((this.CheckSupport(needDepth:  needDepth)) != false) && (needHdr != false))
            {
                    if(this.supportHDRTextures != false)
            {
                    val_3 = 1;
            }
            else
            {
                    this.enabled = false;
                val_3 = 0;
                this.isSupported = false;
            }
            
            }
            
            val_3 = val_3 & 1;
            return (bool)val_3;
        }
        public bool Dx11Support()
        {
            return (bool)this.supportDX11;
        }
        protected void ReportAutoDisable()
        {
            UnityEngine.Debug.LogWarning(message:  "The image effect " + this.ToString() + " has been disabled as it\'s not supported on the current platform.");
        }
        private bool CheckShader(UnityEngine.Shader s)
        {
            var val_5;
            var val_6;
            val_5 = 5;
            string[] val_1 = new string[5];
            if("The shader " == null)
            {
                    val_5 = 0;
            }
            
            if(val_1.Length == 0)
            {
                    val_5 = 0;
            }
            
            val_1[0] = "The shader ";
            if((s != null) && (s == null))
            {
                    val_6 = 0;
            }
            
            if(val_1.Length <= 1)
            {
                    val_6 = 0;
            }
            
            val_1[1] = s;
            if(" on effect " == null)
            {
                    val_6 = 0;
            }
            
            if(val_1.Length <= 2)
            {
                    val_6 = 0;
            }
            
            val_1[2] = " on effect ";
            val_1[3] = this.ToString();
            val_1[4] = " is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.";
            UnityEngine.Debug.Log(message:  +val_1);
            if(s.isSupported == true)
            {
                    return false;
            }
            
            this.enabled = false;
            this.isSupported = false;
            return false;
        }
        protected void NotSupported()
        {
            this.enabled = false;
            this.isSupported = false;
        }
        protected void DrawBorder(UnityEngine.RenderTexture dest, UnityEngine.Material material)
        {
            var val_7;
            UnityEngine.RenderTexture.active = dest;
            UnityEngine.GL.PushMatrix();
            UnityEngine.GL.LoadOrtho();
            val_7 = 0;
            goto label_0;
            label_7:
            bool val_1 = material.SetPass(pass:  0);
            float val_7 = (float)dest;
            val_7 = 1f / val_7;
            float val_2 = val_7 + 0f;
            UnityEngine.GL.Begin(mode:  7);
            UnityEngine.GL.TexCoord2(x:  0f, y:  1f);
            UnityEngine.GL.Vertex3(x:  0f, y:  0f, z:  0.1f);
            UnityEngine.GL.TexCoord2(x:  1f, y:  1f);
            UnityEngine.GL.Vertex3(x:  val_2, y:  0f, z:  0.1f);
            UnityEngine.GL.TexCoord2(x:  1f, y:  0f);
            UnityEngine.GL.Vertex3(x:  val_2, y:  1f, z:  0.1f);
            UnityEngine.GL.TexCoord2(x:  0f, y:  0f);
            UnityEngine.GL.Vertex3(x:  0f, y:  1f, z:  0.1f);
            UnityEngine.GL.TexCoord2(x:  0f, y:  1f);
            float val_8 = (float)dest;
            val_8 = 1f / val_8;
            float val_3 = 1f - val_8;
            UnityEngine.GL.Vertex3(x:  val_3, y:  0f, z:  0.1f);
            UnityEngine.GL.TexCoord2(x:  1f, y:  1f);
            UnityEngine.GL.Vertex3(x:  1f, y:  0f, z:  0.1f);
            UnityEngine.GL.TexCoord2(x:  1f, y:  0f);
            UnityEngine.GL.Vertex3(x:  1f, y:  1f, z:  0.1f);
            UnityEngine.GL.TexCoord2(x:  0f, y:  0f);
            UnityEngine.GL.Vertex3(x:  val_3, y:  1f, z:  0.1f);
            float val_9 = (float)dest;
            val_9 = 1f / val_9;
            float val_4 = val_9 + 0f;
            UnityEngine.GL.TexCoord2(x:  0f, y:  1f);
            UnityEngine.GL.Vertex3(x:  0f, y:  0f, z:  0.1f);
            UnityEngine.GL.TexCoord2(x:  1f, y:  1f);
            UnityEngine.GL.Vertex3(x:  1f, y:  0f, z:  0.1f);
            UnityEngine.GL.TexCoord2(x:  1f, y:  0f);
            UnityEngine.GL.Vertex3(x:  1f, y:  val_4, z:  0.1f);
            UnityEngine.GL.TexCoord2(x:  0f, y:  0f);
            UnityEngine.GL.Vertex3(x:  0f, y:  val_4, z:  0.1f);
            float val_10 = (float)dest;
            val_10 = 1f / val_10;
            float val_5 = 1f - val_10;
            UnityEngine.GL.TexCoord2(x:  0f, y:  1f);
            UnityEngine.GL.Vertex3(x:  0f, y:  val_5, z:  0.1f);
            UnityEngine.GL.TexCoord2(x:  1f, y:  1f);
            UnityEngine.GL.Vertex3(x:  1f, y:  val_5, z:  0.1f);
            UnityEngine.GL.TexCoord2(x:  1f, y:  0f);
            UnityEngine.GL.Vertex3(x:  1f, y:  1f, z:  0.1f);
            UnityEngine.GL.TexCoord2(x:  0f, y:  0f);
            UnityEngine.GL.Vertex3(x:  0f, y:  1f, z:  0.1f);
            UnityEngine.GL.End();
            val_7 = 1;
            label_0:
            if(val_7 < material.passCount)
            {
                goto label_7;
            }
            
            UnityEngine.GL.PopMatrix();
        }
        public PostEffectsBase()
        {
            this.supportHDRTextures = true;
            this.isSupported = true;
        }
    
    }

}
