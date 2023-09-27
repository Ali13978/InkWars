using UnityEngine;

namespace Lean.Touch
{
    public class LeanSnapshot
    {
        // Fields
        public float Age;
        public UnityEngine.Vector2 ScreenPosition;
        public static System.Collections.Generic.List<Lean.Touch.LeanSnapshot> InactiveSnapshots;
        
        // Methods
        public UnityEngine.Vector3 GetWorldPosition(float distance, UnityEngine.Camera camera)
        {
            float val_4;
            UnityEngine.Camera val_5;
            val_4 = distance;
            val_5 = this;
            UnityEngine.Camera val_1 = camera;
            if((Lean.Touch.LeanTouch.GetCamera(camera: ref  val_1, gameObject:  0)) == false)
            {
                    return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            }
            
            val_5 = val_1;
            val_4 = 0f;
            UnityEngine.Vector3 val_3 = val_5.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_4, y = 0f, z = 0f});
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public static Lean.Touch.LeanSnapshot Pop()
        {
            var val_5;
            System.Collections.Generic.List<Lean.Touch.LeanSnapshot> val_6;
            var val_7;
            var val_8;
            val_5 = null;
            val_5 = null;
            val_6 = Lean.Touch.LeanSnapshot.InactiveSnapshots;
            val_7 = null;
            if(val_6.Count >= 1)
            {
                    val_7 = null;
                val_6 = Lean.Touch.LeanSnapshot.InactiveSnapshots.Count - 1;
                val_8 = Lean.Touch.LeanSnapshot.InactiveSnapshots.Item[val_6];
                Lean.Touch.LeanSnapshot.InactiveSnapshots.RemoveAt(index:  val_6);
                return (Lean.Touch.LeanSnapshot)val_8;
            }
            
            Lean.Touch.LeanSnapshot val_4 = null;
            val_8 = val_4;
            val_4 = new Lean.Touch.LeanSnapshot();
            return (Lean.Touch.LeanSnapshot)val_8;
        }
        public static bool TryGetScreenPosition(System.Collections.Generic.List<Lean.Touch.LeanSnapshot> snapshots, float targetAge, ref UnityEngine.Vector2 screenPosition)
        {
            var val_13;
            float val_14;
            var val_15;
            var val_16;
            val_14 = targetAge;
            if((snapshots == null) || (snapshots.Count < 1))
            {
                goto label_2;
            }
            
            val_13 = snapshots.Item[0];
            if(val_2.Age >= val_14)
            {
                goto label_6;
            }
            
            val_13 = snapshots.Item[snapshots.Count - 1];
            if(val_5.Age <= val_14)
            {
                goto label_6;
            }
            
            int val_6 = Lean.Touch.LeanSnapshot.GetLowerIndex(snapshots:  snapshots, targetAge:  val_14);
            int val_7 = val_6 + 1;
            val_13 = snapshots.Item[val_6];
            val_15 = val_13;
            if(val_7 < snapshots.Count)
            {
                    val_15 = snapshots.Item[val_7];
            }
            
            val_14 = UnityEngine.Mathf.InverseLerp(a:  val_8.Age, b:  val_10.Age, value:  val_14);
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = val_8.ScreenPosition, y = val_10.Age}, b:  new UnityEngine.Vector2() {x = val_10.ScreenPosition, y = val_8.Age}, t:  val_14);
            screenPosition.x = val_12.x;
            screenPosition.y = val_12.y;
            goto label_16;
            label_2:
            val_16 = 0;
            return (bool)val_16;
            label_6:
            screenPosition.x = val_2.ScreenPosition;
            screenPosition.y = ;
            label_16:
            val_16 = 1;
            return (bool)val_16;
        }
        public static bool TryGetSnapshot(System.Collections.Generic.List<Lean.Touch.LeanSnapshot> snapshots, int index, ref float age, ref UnityEngine.Vector2 screenPosition)
        {
            int val_3 = index;
            if((val_3 & 2147483648) != 0)
            {
                    return true;
            }
            
            if(snapshots.Count <= val_3)
            {
                    return true;
            }
            
            val_3 = snapshots.Item[val_3];
            if(val_3 != null)
            {
                    age = val_2.Age;
            }
            else
            {
                    age = 1.68059E-38f;
            }
            
            screenPosition.x = val_2.ScreenPosition;
            screenPosition.y = ;
            return true;
        }
        public static int GetLowerIndex(System.Collections.Generic.List<Lean.Touch.LeanSnapshot> snapshots, float targetAge)
        {
            int val_3;
            if(snapshots == null)
            {
                goto label_1;
            }
            
            int val_1 = snapshots.Count;
            if(val_1 < 1)
            {
                goto label_3;
            }
            
            label_5:
            if(val_1 <= 0)
            {
                goto label_3;
            }
            
            val_3 = val_1 - 1;
            Lean.Touch.LeanSnapshot val_2 = snapshots.Item[val_3];
            if(val_2.Age > targetAge)
            {
                goto label_5;
            }
            
            return (int)val_3;
            label_3:
            val_3 = 0;
            return (int)val_3;
            label_1:
            val_3 = 0;
            return (int)val_3;
        }
        public LeanSnapshot()
        {
        
        }
        private static LeanSnapshot()
        {
            Lean.Touch.LeanSnapshot.InactiveSnapshots = new System.Collections.Generic.List<Lean.Touch.LeanSnapshot>(capacity:  232);
        }
    
    }

}
