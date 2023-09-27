using UnityEngine;

namespace Lean.Touch
{
    public class LeanFinger
    {
        // Fields
        public int Index;
        public float Age;
        public bool Set;
        public bool LastSet;
        public bool Tap;
        public int TapCount;
        public bool Swipe;
        public UnityEngine.Vector2 StartScreenPosition;
        public UnityEngine.Vector2 LastScreenPosition;
        public UnityEngine.Vector2 ScreenPosition;
        public bool StartedOverGui;
        public System.Collections.Generic.List<Lean.Touch.LeanSnapshot> Snapshots;
        
        // Properties
        public bool IsActive { get; }
        public float SnapshotDuration { get; }
        public bool IsOverGui { get; }
        public bool Down { get; }
        public bool Up { get; }
        public UnityEngine.Vector2 LastSnapshotScreenDelta { get; }
        public UnityEngine.Vector2 LastSnapshotScaledDelta { get; }
        public UnityEngine.Vector2 ScreenDelta { get; }
        public UnityEngine.Vector2 ScaledDelta { get; }
        public UnityEngine.Vector2 SwipeScreenDelta { get; }
        public UnityEngine.Vector2 SwipeScaledDelta { get; }
        
        // Methods
        public bool get_IsActive()
        {
            null = null;
            if(Lean.Touch.LeanTouch.Fingers != null)
            {
                    return Lean.Touch.LeanTouch.Fingers.Contains(item:  this);
            }
            
            return Lean.Touch.LeanTouch.Fingers.Contains(item:  this);
        }
        public float get_SnapshotDuration()
        {
            if(this.Snapshots.Count < 1)
            {
                    return 0f;
            }
            
            this = this.Snapshots.Item[0];
            float val_3 = val_2.Age;
            val_3 = this.Age - val_3;
            return 0f;
        }
        public bool get_IsOverGui()
        {
            return Lean.Touch.LeanTouch.PointOverGui(screenPosition:  new UnityEngine.Vector2() {x = this.ScreenPosition, y = V8.16B});
        }
        public bool get_Down()
        {
            if(this.Set == false)
            {
                    return false;
            }
            
            return (bool)(this.LastSet == false) ? 1 : 0;
        }
        public bool get_Up()
        {
            if(this.Set == false)
            {
                    return (bool)(this.LastSet == true) ? 1 : 0;
            }
            
            return false;
        }
        public UnityEngine.Vector2 get_LastSnapshotScreenDelta()
        {
            System.Collections.Generic.List<Lean.Touch.LeanSnapshot> val_3 = this.Snapshots;
            val_3 = val_3.Count - 1;
            if()
            {
                    return UnityEngine.Vector2.zero;
            }
            
            if(this.Snapshots.Item[val_3] == null)
            {
                    return UnityEngine.Vector2.zero;
            }
            
            return UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.ScreenPosition, y = V10.16B}, b:  new UnityEngine.Vector2() {x = val_2.ScreenPosition, y = V8.16B});
        }
        public UnityEngine.Vector2 get_LastSnapshotScaledDelta()
        {
            UnityEngine.Vector2 val_1 = this.LastSnapshotScreenDelta;
            return UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  Lean.Touch.LeanTouch.ScalingFactor);
        }
        public UnityEngine.Vector2 get_ScreenDelta()
        {
            return UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.ScreenPosition, y = V10.16B}, b:  new UnityEngine.Vector2() {x = this.LastScreenPosition, y = V8.16B});
        }
        public UnityEngine.Vector2 get_ScaledDelta()
        {
            UnityEngine.Vector2 val_1 = this.ScreenDelta;
            return UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  Lean.Touch.LeanTouch.ScalingFactor);
        }
        public UnityEngine.Vector2 get_SwipeScreenDelta()
        {
            return UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.ScreenPosition, y = V10.16B}, b:  new UnityEngine.Vector2() {x = this.StartScreenPosition, y = V8.16B});
        }
        public UnityEngine.Vector2 get_SwipeScaledDelta()
        {
            UnityEngine.Vector2 val_1 = this.SwipeScreenDelta;
            return UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  Lean.Touch.LeanTouch.ScalingFactor);
        }
        public UnityEngine.Ray GetRay(UnityEngine.Camera camera)
        {
            UnityEngine.Ray val_0;
            UnityEngine.Camera val_1 = camera;
            if((Lean.Touch.LeanTouch.GetCamera(camera: ref  val_1, gameObject:  0)) != false)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.ScreenPosition, y = V8.16B});
                if(val_1 != 0)
            {
                    return val_1.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            }
            
                return val_1.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            }
            
            val_0.m_Origin.z = 0f;
            val_0.m_Direction.x = 0f;
            val_0.m_Direction.y = 0f;
            val_0.m_Direction.z = 0f;
            val_0.m_Origin.x = 0f;
            val_0.m_Origin.y = 0f;
            return val_0;
        }
        public UnityEngine.Ray GetStartRay(UnityEngine.Camera camera)
        {
            UnityEngine.Ray val_0;
            UnityEngine.Camera val_1 = camera;
            if((Lean.Touch.LeanTouch.GetCamera(camera: ref  val_1, gameObject:  0)) != false)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.StartScreenPosition, y = V8.16B});
                if(val_1 != 0)
            {
                    return val_1.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            }
            
                return val_1.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            }
            
            val_0.m_Origin.z = 0f;
            val_0.m_Direction.x = 0f;
            val_0.m_Direction.y = 0f;
            val_0.m_Direction.z = 0f;
            val_0.m_Origin.x = 0f;
            val_0.m_Origin.y = 0f;
            return val_0;
        }
        public UnityEngine.Vector2 GetSnapshotScreenDelta(float deltaTime)
        {
            float val_2 = this.Age;
            val_2 = val_2 - deltaTime;
            UnityEngine.Vector2 val_1 = this.GetSnapshotScreenPosition(targetAge:  val_2);
            return UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.ScreenPosition, y = V8.16B}, b:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        }
        public UnityEngine.Vector2 GetSnapshotScaledDelta(float deltaTime)
        {
            UnityEngine.Vector2 val_1 = this.GetSnapshotScreenDelta(deltaTime:  deltaTime);
            return UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  Lean.Touch.LeanTouch.ScalingFactor);
        }
        public UnityEngine.Vector2 GetSnapshotScreenPosition(float targetAge)
        {
            bool val_1 = Lean.Touch.LeanSnapshot.TryGetScreenPosition(snapshots:  this.Snapshots, targetAge:  targetAge, screenPosition: ref  new UnityEngine.Vector2() {x = this.ScreenPosition, y = ???});
            return new UnityEngine.Vector2() {x = this.ScreenPosition, y = ???};
        }
        public UnityEngine.Vector3 GetSnapshotWorldPosition(float targetAge, float distance, UnityEngine.Camera camera)
        {
            float val_5;
            UnityEngine.Camera val_6;
            val_5 = distance;
            val_6 = this;
            UnityEngine.Camera val_1 = camera;
            if((Lean.Touch.LeanTouch.GetCamera(camera: ref  val_1, gameObject:  0)) == false)
            {
                    return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            }
            
            UnityEngine.Vector2 val_3 = this.GetSnapshotScreenPosition(targetAge:  targetAge);
            val_6 = val_1;
            val_5 = 0f;
            UnityEngine.Vector3 val_4 = val_6.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_5, y = 0f, z = 0f});
            return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public float GetRadians(UnityEngine.Vector2 referencePoint)
        {
            referencePoint.x = this.ScreenPosition - referencePoint.x;
            referencePoint.y = S10 - referencePoint.y;
        }
        public float GetDegrees(UnityEngine.Vector2 referencePoint)
        {
            float val_1 = this.GetRadians(referencePoint:  new UnityEngine.Vector2() {x = referencePoint.x, y = referencePoint.y});
            val_1 = val_1 * 57.29578f;
            return (float)val_1;
        }
        public float GetLastRadians(UnityEngine.Vector2 referencePoint)
        {
            referencePoint.x = this.LastScreenPosition - referencePoint.x;
            referencePoint.y = S10 - referencePoint.y;
        }
        public float GetLastDegrees(UnityEngine.Vector2 referencePoint)
        {
            float val_1 = this.GetLastRadians(referencePoint:  new UnityEngine.Vector2() {x = referencePoint.x, y = referencePoint.y});
            val_1 = val_1 * 57.29578f;
            return (float)val_1;
        }
        public float GetDeltaRadians(UnityEngine.Vector2 referencePoint)
        {
            return this.GetDeltaRadians(referencePoint:  new UnityEngine.Vector2() {x = referencePoint.x, y = referencePoint.y}, lastReferencePoint:  new UnityEngine.Vector2() {x = referencePoint.x, y = referencePoint.y});
        }
        public float GetDeltaRadians(UnityEngine.Vector2 referencePoint, UnityEngine.Vector2 lastReferencePoint)
        {
            float val_2 = this.GetRadians(referencePoint:  new UnityEngine.Vector2() {x = referencePoint.x, y = referencePoint.y});
            val_2 = (this.GetLastRadians(referencePoint:  new UnityEngine.Vector2() {x = lastReferencePoint.x, y = lastReferencePoint.y})) - val_2;
            float val_3 = UnityEngine.Mathf.Repeat(t:  val_2, length:  6.283185f);
            float val_4 = -6.283185f;
            val_4 = val_3 + val_4;
            val_3 = (val_3 > 3.141593f) ? (val_4) : (val_3);
            return (float)val_3;
        }
        public float GetDeltaDegrees(UnityEngine.Vector2 referencePoint)
        {
            float val_1 = this.GetDeltaRadians(referencePoint:  new UnityEngine.Vector2() {x = referencePoint.x, y = referencePoint.y}, lastReferencePoint:  new UnityEngine.Vector2() {x = referencePoint.x, y = referencePoint.y});
            val_1 = val_1 * 57.29578f;
            return (float)val_1;
        }
        public float GetDeltaDegrees(UnityEngine.Vector2 referencePoint, UnityEngine.Vector2 lastReferencePoint)
        {
            float val_1 = this.GetDeltaRadians(referencePoint:  new UnityEngine.Vector2() {x = referencePoint.x, y = referencePoint.y}, lastReferencePoint:  new UnityEngine.Vector2() {x = lastReferencePoint.x, y = lastReferencePoint.y});
            val_1 = val_1 * 57.29578f;
            return (float)val_1;
        }
        public float GetScreenDistance(UnityEngine.Vector2 point)
        {
            return UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = this.ScreenPosition, y = V10.16B}, b:  new UnityEngine.Vector2() {x = point.x, y = point.y});
        }
        public float GetScaledDistance(UnityEngine.Vector2 point)
        {
            float val_2 = Lean.Touch.LeanTouch.ScalingFactor;
            val_2 = (this.GetScreenDistance(point:  new UnityEngine.Vector2() {x = point.x, y = point.y})) * val_2;
            return (float)val_2;
        }
        public float GetLastScreenDistance(UnityEngine.Vector2 point)
        {
            return UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = this.LastScreenPosition, y = V10.16B}, b:  new UnityEngine.Vector2() {x = point.x, y = point.y});
        }
        public float GetLastScaledDistance(UnityEngine.Vector2 point)
        {
            float val_2 = Lean.Touch.LeanTouch.ScalingFactor;
            val_2 = (this.GetLastScreenDistance(point:  new UnityEngine.Vector2() {x = point.x, y = point.y})) * val_2;
            return (float)val_2;
        }
        public UnityEngine.Vector3 GetStartWorldPosition(float distance, UnityEngine.Camera camera)
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
        public UnityEngine.Vector3 GetLastWorldPosition(float distance, UnityEngine.Camera camera)
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
        public UnityEngine.Vector3 GetWorldDelta(float distance, UnityEngine.Camera camera)
        {
            return this.GetWorldDelta(lastDistance:  distance, distance:  distance, camera:  camera);
        }
        public UnityEngine.Vector3 GetWorldDelta(float lastDistance, float distance, UnityEngine.Camera camera)
        {
            float val_6 = lastDistance;
            UnityEngine.Camera val_1 = camera;
            if((Lean.Touch.LeanTouch.GetCamera(camera: ref  val_1, gameObject:  0)) == false)
            {
                    return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            }
            
            UnityEngine.Vector3 val_3 = this.GetWorldPosition(distance:  distance, camera:  val_1);
            UnityEngine.Vector3 val_4 = this.GetLastWorldPosition(distance:  val_6 = lastDistance, camera:  val_1);
            val_6 = val_4.x;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_6, y = val_4.y, z = val_4.z});
            return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public void ClearSnapshots(int count = -1)
        {
            var val_3;
            var val_4;
            if(count >= 1)
            {
                    if(this.Snapshots.Count < count)
            {
                    return;
            }
            
                var val_3 = 0;
                do
            {
                val_3 = null;
                val_3 = null;
                Lean.Touch.LeanSnapshot.InactiveSnapshots.Add(item:  this.Snapshots.Item[0]);
                val_3 = val_3 + 1;
            }
            while(count != val_3);
            
                this.Snapshots.RemoveRange(index:  0, count:  count);
                return;
            }
            
            if(count == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            Lean.Touch.LeanSnapshot.InactiveSnapshots.AddRange(collection:  this.Snapshots);
            this.Snapshots.Clear();
        }
        public void RecordSnapshot()
        {
            UnityEngine.Vector2 val_2;
            Lean.Touch.LeanSnapshot val_1 = Lean.Touch.LeanSnapshot.Pop();
            if(val_1 != null)
            {
                    val_1.Age = this.Age;
                val_2 = this.ScreenPosition;
            }
            else
            {
                    val_1.Age = this.Age;
                val_2 = this.ScreenPosition;
            }
            
            val_1.ScreenPosition = val_2;
            mem2[0] = ???;
            this.Snapshots.Add(item:  val_1);
        }
        public LeanFinger()
        {
            this.Snapshots = new System.Collections.Generic.List<Lean.Touch.LeanSnapshot>(capacity:  232);
        }
    
    }

}
