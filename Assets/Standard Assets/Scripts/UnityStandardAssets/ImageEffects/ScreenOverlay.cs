using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
    public class ScreenOverlay : PostEffectsBase
    {
        // Fields
        public UnityStandardAssets.ImageEffects.ScreenOverlay.OverlayBlendMode blendMode;
        public float intensity;
        public UnityEngine.Texture2D texture;
        public UnityEngine.Shader overlayShader;
        private UnityEngine.Material overlayMaterial;
        
        // Methods
        public override bool CheckResources()
        {
            var val_4;
            bool val_1 = this.CheckSupport(needDepth:  false);
            this.overlayMaterial = this.CheckShaderAndCreateMaterial(s:  this.overlayShader, m2Create:  this.overlayMaterial);
            if(W8 != 0)
            {
                    val_4 = 1;
                return (bool)(W8 != 0) ? 1 : 0;
            }
            
            this.ReportAutoDisable();
            return (bool)(W8 != 0) ? 1 : 0;
        }
        private void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination)
        {
            OverlayBlendMode val_1 = this;
            if((val_1 & 1) != 0)
            {
                    this.overlayMaterial.SetVector(name:  "_UV_Transform", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
                this.overlayMaterial.SetFloat(name:  "_Intensity", value:  this.intensity);
                this.overlayMaterial.SetTexture(name:  "_Overlay", value:  this.texture);
                val_1 = this.blendMode;
                UnityEngine.Graphics.Blit(source:  source, dest:  destination, mat:  this.overlayMaterial, pass:  val_1);
                return;
            }
            
            UnityEngine.Graphics.Blit(source:  source, dest:  destination);
        }
        public ScreenOverlay()
        {
            this.blendMode = 3;
            mem[1152921525911927896] = 1;
            mem[1152921525911927898] = 1;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
