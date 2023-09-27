using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
    internal class PostEffectsHelper : MonoBehaviour
    {
        // Methods
        private void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination)
        {
            UnityEngine.Debug.Log(message:  "OnRenderImage in Helper called ...");
        }
        private static void DrawLowLevelPlaneAlignedWithCamera(float dist, UnityEngine.RenderTexture source, UnityEngine.RenderTexture dest, UnityEngine.Material material, UnityEngine.Camera cameraForProjectionMatrix)
        {
            float val_2;
            float val_3;
            float val_4;
            float val_5;
            var val_15;
            UnityEngine.RenderTexture.active = dest;
            material.SetTexture(name:  "_MainTex", value:  source);
            UnityEngine.GL.PushMatrix();
            UnityEngine.GL.LoadIdentity();
            UnityEngine.Matrix4x4 val_1 = cameraForProjectionMatrix.projectionMatrix;
            UnityEngine.GL.LoadProjectionMatrix(mat:  new UnityEngine.Matrix4x4() {m00 = val_4, m10 = val_4, m20 = val_4, m30 = val_4, m01 = val_5, m11 = val_5, m21 = val_5, m31 = val_5, m02 = val_2, m12 = val_2, m22 = val_2, m32 = val_2, m03 = val_3, m13 = val_3, m23 = val_3, m33 = val_3});
            float val_6 = cameraForProjectionMatrix.fieldOfView;
            float val_16 = 0.5f;
            val_6 = val_6 * val_16;
            float val_7 = val_6 * 0.01745329f;
            float val_15 = val_7;
            val_15 = val_15 / val_7;
            float val_8 = cameraForProjectionMatrix.aspect;
            float val_17 = -val_15;
            val_16 = val_8 / val_15;
            val_8 = val_8 / val_17;
            val_17 = 1f / val_17;
            val_15 = 0;
            val_15 = val_16 * dist;
            float val_10 = val_8 * dist;
            float val_11 = val_17 * dist;
            float val_12 = (1f / val_15) * dist;
            goto label_7;
            label_10:
            bool val_13 = material.SetPass(pass:  0);
            UnityEngine.GL.Begin(mode:  7);
            UnityEngine.GL.TexCoord2(x:  0f, y:  1f);
            UnityEngine.GL.Vertex3(x:  val_10, y:  val_11, z:  -dist);
            UnityEngine.GL.TexCoord2(x:  1f, y:  1f);
            UnityEngine.GL.Vertex3(x:  val_15, y:  val_11, z:  -dist);
            UnityEngine.GL.TexCoord2(x:  1f, y:  0f);
            UnityEngine.GL.Vertex3(x:  val_15, y:  val_12, z:  -dist);
            UnityEngine.GL.TexCoord2(x:  0f, y:  0f);
            UnityEngine.GL.Vertex3(x:  val_10, y:  val_12, z:  -dist);
            UnityEngine.GL.End();
            val_15 = 1;
            label_7:
            if(val_15 < material.passCount)
            {
                goto label_10;
            }
            
            UnityEngine.GL.PopMatrix();
        }
        private static void DrawBorder(UnityEngine.RenderTexture dest, UnityEngine.Material material)
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
        private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, UnityEngine.RenderTexture source, UnityEngine.RenderTexture dest, UnityEngine.Material material)
        {
            var val_3;
            UnityEngine.RenderTexture.active = dest;
            material.SetTexture(name:  "_MainTex", value:  source);
            UnityEngine.GL.PushMatrix();
            UnityEngine.GL.LoadOrtho();
            val_3 = 0;
            goto label_2;
            label_5:
            bool val_1 = material.SetPass(pass:  0);
            UnityEngine.GL.Begin(mode:  7);
            UnityEngine.GL.TexCoord2(x:  0f, y:  1f);
            UnityEngine.GL.Vertex3(x:  x1, y:  y1, z:  0.1f);
            UnityEngine.GL.TexCoord2(x:  1f, y:  1f);
            UnityEngine.GL.Vertex3(x:  x2, y:  y1, z:  0.1f);
            UnityEngine.GL.TexCoord2(x:  1f, y:  0f);
            UnityEngine.GL.Vertex3(x:  x2, y:  y2, z:  0.1f);
            UnityEngine.GL.TexCoord2(x:  0f, y:  0f);
            UnityEngine.GL.Vertex3(x:  x1, y:  y2, z:  0.1f);
            UnityEngine.GL.End();
            val_3 = 1;
            label_2:
            if(val_3 < material.passCount)
            {
                goto label_5;
            }
            
            UnityEngine.GL.PopMatrix();
        }
        public PostEffectsHelper()
        {
        
        }
    
    }

}
