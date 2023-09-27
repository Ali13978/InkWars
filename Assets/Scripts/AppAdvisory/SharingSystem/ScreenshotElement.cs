using UnityEngine;

namespace AppAdvisory.SharingSystem
{
    public class ScreenshotElement : MonoBehaviour
    {
        // Fields
        public UnityEngine.RectTransform m_rect;
        public UnityEngine.CanvasGroup parent;
        public UnityEngine.UI.Button button;
        public UnityEngine.UI.Image image;
        public UnityEngine.UI.Text text;
        public UnityEngine.Vector2 defaultPosition;
        public UnityEngine.Quaternion defaultRotation;
        public UnityEngine.Vector2 defaultSizeDelta;
        
        // Properties
        public UnityEngine.RectTransform rect { get; }
        public UnityEngine.Quaternion rotation { get; set; }
        public UnityEngine.Vector2 localPosition { get; set; }
        public UnityEngine.Vector2 sizeDelta { get; set; }
        public UnityEngine.Vector2 localScale { get; set; }
        
        // Methods
        public UnityEngine.RectTransform get_rect()
        {
            return this.GetComponent<UnityEngine.RectTransform>();
        }
        private void Awake()
        {
            UnityEngine.Quaternion val_1 = this.rotation;
            this.defaultRotation = val_1;
            mem[1152921529128022556] = val_1.y;
            mem[1152921529128022560] = val_1.z;
            mem[1152921529128022564] = val_1.w;
            UnityEngine.Vector2 val_2 = this.localPosition;
            this.defaultPosition = val_2;
            mem[1152921529128022548] = val_2.y;
            UnityEngine.Vector2 val_3 = this.sizeDelta;
            this.defaultSizeDelta = val_3;
            mem[1152921529128022572] = val_3.y;
        }
        public UnityEngine.Quaternion get_rotation()
        {
            UnityEngine.RectTransform val_1 = this.rect;
            if(val_1 != null)
            {
                    return val_1.rotation;
            }
            
            return val_1.rotation;
        }
        public void set_rotation(UnityEngine.Quaternion value)
        {
            this.rect.rotation = new UnityEngine.Quaternion() {x = value.x, y = value.y, z = value.z, w = value.w};
        }
        public UnityEngine.Vector2 get_localPosition()
        {
            UnityEngine.Vector3 val_2 = this.rect.localPosition;
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public void set_localPosition(UnityEngine.Vector2 value)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = value.x, y = value.y});
            this.rect.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public UnityEngine.Vector2 get_sizeDelta()
        {
            UnityEngine.RectTransform val_1 = this.rect;
            if(val_1 != null)
            {
                    return val_1.sizeDelta;
            }
            
            return val_1.sizeDelta;
        }
        public void set_sizeDelta(UnityEngine.Vector2 value)
        {
            this.rect.sizeDelta = new UnityEngine.Vector2() {x = value.x, y = value.y};
        }
        public UnityEngine.Vector2 get_localScale()
        {
            UnityEngine.Vector3 val_2 = this.rect.localScale;
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public void set_localScale(UnityEngine.Vector2 value)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = value.x, y = value.y});
            this.rect.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public ScreenshotElement()
        {
        
        }
    
    }

}
