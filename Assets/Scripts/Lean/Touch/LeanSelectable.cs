using UnityEngine;

namespace Lean.Touch
{
    public class LeanSelectable : MonoBehaviour
    {
        // Fields
        public bool HideWithFinger;
        public Lean.Touch.LeanFinger SelectingFinger;
        public Lean.Touch.LeanSelectable.LeanFingerEvent OnSelect;
        public Lean.Touch.LeanSelectable.LeanFingerEvent OnSelectUp;
        public UnityEngine.Events.UnityEvent OnDeselect;
        private bool isSelected;
        
        // Properties
        public bool IsSelected { get; }
        
        // Methods
        public bool get_IsSelected()
        {
            bool val_2 = this.isSelected;
            if((this.HideWithFinger == false) || (val_2 == false))
            {
                    return (bool)(val_2 != 0) ? 1 : 0;
            }
            
            if(this.SelectingFinger != null)
            {
                    return false;
            }
            
            val_2 = 1;
            return (bool)(val_2 != 0) ? 1 : 0;
        }
        public void Select()
        {
            this.Select(finger:  0);
        }
        public void Select(Lean.Touch.LeanFinger finger)
        {
            this.isSelected = true;
            this.SelectingFinger = finger;
            this.OnSelect.Invoke(arg0:  finger);
        }
        public void Deselect()
        {
            if(this.SelectingFinger != null)
            {
                    this.OnSelectUp.Invoke(arg0:  this.SelectingFinger);
                this.SelectingFinger = 0;
            }
            
            this.isSelected = false;
            this.OnDeselect.Invoke();
        }
        protected virtual void OnEnable()
        {
            var val_4;
            System.Action<Lean.Touch.LeanFinger> val_5;
            val_4 = null;
            val_4 = null;
            if(((System.Delegate.Combine(a:  Lean.Touch.LeanTouch.OnFingerUp, b:  new System.Action<Lean.Touch.LeanFinger>(object:  this, method:  System.Void Lean.Touch.LeanSelectable::OnFingerUp(Lean.Touch.LeanFinger finger)))) != null) && (null != null))
            {
                    val_5 = 0;
            }
            
            Lean.Touch.LeanTouch.OnFingerUp = val_5;
        }
        protected virtual void OnDisable()
        {
            var val_4;
            System.Action<Lean.Touch.LeanFinger> val_5;
            val_4 = null;
            val_4 = null;
            if(((System.Delegate.Remove(source:  Lean.Touch.LeanTouch.OnFingerUp, value:  new System.Action<Lean.Touch.LeanFinger>(object:  this, method:  System.Void Lean.Touch.LeanSelectable::OnFingerUp(Lean.Touch.LeanFinger finger)))) != null) && (null != null))
            {
                    val_5 = 0;
            }
            
            Lean.Touch.LeanTouch.OnFingerUp = val_5;
        }
        private void OnFingerUp(Lean.Touch.LeanFinger finger)
        {
            if(this.SelectingFinger != finger)
            {
                    return;
            }
            
            this.OnSelectUp.Invoke(arg0:  finger);
            this.SelectingFinger = 0;
        }
        public LeanSelectable()
        {
        
        }
    
    }

}
