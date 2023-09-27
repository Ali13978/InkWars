using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public class SoftMaskScript : MonoBehaviour
    {
        // Fields
        private UnityEngine.Material mat;
        private UnityEngine.Canvas canvas;
        public UnityEngine.RectTransform MaskArea;
        private UnityEngine.RectTransform myRect;
        public UnityEngine.RectTransform maskScalingRect;
        public UnityEngine.Texture AlphaMask;
        public float CutOff;
        public bool HardBlend;
        public bool FlipAlphaMask;
        public bool DontClipMaskScalingRect;
        private UnityEngine.Vector3[] worldCorners;
        private UnityEngine.Vector2 AlphaUV;
        private UnityEngine.Vector2 min;
        private UnityEngine.Vector2 max;
        private UnityEngine.Vector2 p;
        private UnityEngine.Vector2 siz;
        private UnityEngine.Rect maskRect;
        private UnityEngine.Rect contentRect;
        private UnityEngine.Vector2 centre;
        private bool isText;
        
        // Methods
        private void Start()
        {
            this.myRect = this.GetComponent<UnityEngine.RectTransform>();
            if((UnityEngine.Object.op_Implicit(exists:  this.MaskArea)) != true)
            {
                    this.MaskArea = this.myRect;
            }
            
            if((this.myRect.GetComponent<UnityEngine.UI.Graphic>()) != 0)
            {
                    this.mat = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "UI Extensions/SoftMaskShader"));
                UnityEngine.UI.Graphic val_7 = this.GetComponent<UnityEngine.UI.Graphic>();
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.GetComponent<UnityEngine.UI.Text>())) == false)
            {
                    return;
            }
            
            this.isText = true;
            this.mat = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "UI Extensions/SoftMaskShaderText"));
            this.GetComponent<UnityEngine.UI.Text>().material = this.mat;
            this.GetCanvas();
            if((this.transform.parent.GetComponent<UnityEngine.UI.Mask>()) == 0)
            {
                    UnityEngine.UI.Mask val_20 = this.transform.parent.gameObject.AddComponent<UnityEngine.UI.Mask>();
            }
            
            this.transform.parent.GetComponent<UnityEngine.UI.Mask>().enabled = false;
        }
        private void GetCanvas()
        {
            var val_7;
            UnityEngine.Transform val_1 = this.transform;
            val_7 = 0;
            goto label_1;
            label_11:
            if((val_1 & 1) == 0)
            {
                    return;
            }
            
            UnityEngine.Canvas val_3 = val_1.gameObject.GetComponent<UnityEngine.Canvas>();
            this.canvas = val_3;
            if(val_3 == 0)
            {
                    UnityEngine.Transform val_5 = val_1.parent;
            }
            
            val_7 = 1;
            label_1:
            bool val_6 = UnityEngine.Object.op_Equality(x:  this.canvas, y:  0);
            if(val_7 <= 99)
            {
                goto label_11;
            }
        
        }
        private UnityEngine.Transform GetParentTranform(UnityEngine.Transform t)
        {
            if(t != null)
            {
                    return t.parent;
            }
            
            return t.parent;
        }
        private void Update()
        {
            this.SetMask();
        }
        private void SetMask()
        {
            UnityEngine.Vector2 val_61;
            float val_62;
            var val_63;
            float val_66;
            float val_67;
            float val_68;
            float val_69;
            float val_70;
            float val_74;
            UnityEngine.Rect val_1 = this.MaskArea.rect;
            this.maskRect = val_1;
            mem[1152921529149513156] = val_1.m_YMin;
            mem[1152921529149513160] = val_1.m_Width;
            mem[1152921529149513164] = val_1.m_Height;
            UnityEngine.Rect val_2 = this.myRect.rect;
            this.contentRect = val_2;
            mem[1152921529149513172] = val_2.m_YMin;
            mem[1152921529149513176] = val_2.m_Width;
            mem[1152921529149513180] = val_2.m_Height;
            if(this.isText != false)
            {
                    this.maskScalingRect = 0;
                if((this.canvas.renderMode == 0) && (UnityEngine.Application.isPlaying != false))
            {
                    UnityEngine.Vector3 val_7 = this.MaskArea.transform.position;
                UnityEngine.Vector3 val_8 = this.canvas.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
                this.p = val_9;
                mem[1152921529149513140] = val_9.y;
                UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_9.x, y:  val_9.x);
                val_61 = this.p;
                this.siz = val_10.x;
                mem[1152921529149513148] = val_10.y;
                val_63 = val_10.y;
            }
            else
            {
                    UnityEngine.Vector3[] val_11 = new UnityEngine.Vector3[4];
                this.worldCorners = val_11;
                this.MaskArea.GetWorldCorners(fourCornersArray:  val_11);
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.worldCorners[2], y = this.worldCorners[2], z = this.worldCorners[2]}, b:  new UnityEngine.Vector3() {x = this.worldCorners[0], y = this.worldCorners[0], z = this.worldCorners[0]});
                UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                this.siz = val_13;
                mem[1152921529149513148] = val_13.y;
                UnityEngine.Vector3 val_15 = this.MaskArea.transform.position;
                UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
                val_61 = val_16.x;
                val_62 = val_16.y;
                this.p = val_16;
                mem[1152921529149513140] = val_62;
            }
            
                UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  this.siz, y:  val_16.y);
                UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y}, d:  0.5f);
                UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_61, y = val_62}, b:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
                this.min = val_19;
                mem[1152921529149513124] = val_19.y;
                UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  this.siz, y:  val_18.y);
                UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y}, d:  0.5f);
                val_66 = val_21.x;
                val_67 = val_21.y;
                val_68 = this.p;
                val_69 = val_62;
            }
            else
            {
                    if(this.maskScalingRect != 0)
            {
                    UnityEngine.Rect val_23 = this.maskScalingRect.rect;
                this.maskRect = val_23;
                mem[1152921529149513156] = val_23.m_YMin;
                mem[1152921529149513160] = val_23.m_Width;
                mem[1152921529149513164] = val_23.m_Height;
            }
            
                UnityEngine.Vector3 val_26 = this.MaskArea.transform.position;
                UnityEngine.Vector3 val_27 = this.myRect.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
                val_70 = val_27.x;
                UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_70, y = val_27.y, z = val_27.z});
                this.centre = val_28;
                mem[1152921529149513188] = val_28.y;
                if(this.maskScalingRect != 0)
            {
                    UnityEngine.Vector3 val_32 = this.maskScalingRect.transform.position;
                UnityEngine.Vector3 val_33 = this.myRect.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
                val_70 = val_33.x;
                UnityEngine.Vector2 val_34 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_70, y = val_33.y, z = val_33.z});
                this.centre = val_34;
                mem[1152921529149513188] = val_34.y;
            }
            
                float val_35 = val_34.x / val_34.x;
                UnityEngine.Vector2 val_37 = new UnityEngine.Vector2(x:  val_35, y:  val_34.x / val_34.x);
                this.AlphaUV = val_37.x;
                mem[1152921529149513116] = val_37.y;
                this.min = this.centre;
                mem[1152921529149513124] = ???;
                this.max = this.centre;
                mem[1152921529149513132] = ???;
                UnityEngine.Vector2 val_38 = new UnityEngine.Vector2(x:  val_35, y:  val_35);
                UnityEngine.Vector2 val_39 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_38.x, y = val_38.y}, d:  0.5f);
                this.siz = val_39;
                mem[1152921529149513148] = val_39.y;
                UnityEngine.Vector2 val_40 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.min, y = val_39.y}, b:  new UnityEngine.Vector2() {x = val_39.x, y = val_39.y});
                this.min = val_40;
                mem[1152921529149513124] = val_40.y;
                UnityEngine.Vector2 val_41 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = this.max, y = V5.16B}, b:  new UnityEngine.Vector2() {x = this.siz, y = val_39.y});
                this.max = val_41;
                mem[1152921529149513132] = val_41.y;
                UnityEngine.Vector2 val_44 = new UnityEngine.Vector2(x:  this.min / val_41.x, y:  S11 / val_41.x);
                UnityEngine.Vector2 val_45 = new UnityEngine.Vector2(x:  0.5f, y:  0.5f);
                UnityEngine.Vector2 val_46 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_44.x, y = val_44.y}, b:  new UnityEngine.Vector2() {x = val_45.x, y = val_45.y});
                this.min = val_46;
                mem[1152921529149513124] = val_46.y;
                UnityEngine.Vector2 val_49 = new UnityEngine.Vector2(x:  this.max / val_46.x, y:  S11 / val_46.x);
                UnityEngine.Vector2 val_50 = new UnityEngine.Vector2(x:  0.5f, y:  0.5f);
                val_68 = val_49.x;
                val_69 = val_49.y;
                val_66 = val_50.x;
                val_67 = val_50.y;
            }
            
            UnityEngine.Vector2 val_51 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_68, y = val_69}, b:  new UnityEngine.Vector2() {x = val_66, y = val_67});
            this.max = val_51;
            mem[1152921529149513132] = val_51.y;
            float val_52 = (this.HardBlend == true) ? 1f : 0f;
            this.mat.SetFloat(name:  "_HardBlend", value:  val_52);
            UnityEngine.Vector4 val_53 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = this.min, y = val_52});
            this.mat.SetVector(name:  "_Min", value:  new UnityEngine.Vector4() {x = val_53.x, y = val_53.y, z = val_53.z, w = val_53.w});
            UnityEngine.Vector4 val_54 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = this.max, y = val_53.y});
            val_74 = val_54.z;
            this.mat.SetVector(name:  "_Max", value:  new UnityEngine.Vector4() {x = val_54.x, y = val_54.y, z = val_74, w = val_54.w});
            this.mat.SetTexture(name:  "_AlphaMask", value:  this.AlphaMask);
            this.mat.SetInt(name:  "_FlipAlphaMask", value:  this.FlipAlphaMask);
            if(this.DontClipMaskScalingRect == false)
            {
                goto label_56;
            }
            
            UnityEngine.RectTransform val_63 = this.maskScalingRect;
            val_63 = UnityEngine.Object.op_Inequality(x:  val_63, y:  0);
            if(this.mat != null)
            {
                goto label_65;
            }
            
            label_66:
            label_65:
            this.mat.SetInt(name:  "_NoOuterClip", value:  val_63);
            if(this.isText != true)
            {
                    UnityEngine.Vector4 val_56 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = this.AlphaUV, y = val_54.x});
                val_74 = val_56.z;
                this.mat.SetVector(name:  "_AlphaUV", value:  new UnityEngine.Vector4() {x = val_56.x, y = val_56.y, z = val_74, w = val_56.w});
            }
            
            this.mat.SetFloat(name:  "_CutOff", value:  this.CutOff);
            return;
            label_56:
            if(this.mat != null)
            {
                goto label_65;
            }
            
            goto label_66;
        }
        public SoftMaskScript()
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.one;
            this.max = val_1;
            mem[1152921529149834060] = val_1.y;
        }
    
    }

}
