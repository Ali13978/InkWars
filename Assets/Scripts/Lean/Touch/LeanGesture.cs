using UnityEngine;

namespace Lean.Touch
{
    public static class LeanGesture
    {
        // Methods
        public static UnityEngine.Vector2 GetScreenCenter()
        {
            null = null;
            bool val_1 = Lean.Touch.LeanGesture.TryGetScreenCenter(fingers:  Lean.Touch.LeanTouch.Fingers, center: ref  new UnityEngine.Vector2() {x = 0f, y = 0f});
            return new UnityEngine.Vector2() {x = 0f, y = 0f};
        }
        public static UnityEngine.Vector2 GetScreenCenter(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers)
        {
            bool val_1 = Lean.Touch.LeanGesture.TryGetScreenCenter(fingers:  fingers, center: ref  new UnityEngine.Vector2() {x = 0f, y = 0f});
            return new UnityEngine.Vector2() {x = 0f, y = 0f};
        }
        public static bool TryGetScreenCenter(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, ref UnityEngine.Vector2 center)
        {
            var val_6;
            float val_9;
            float val_10;
            var val_11;
            var val_12;
            if(fingers == null)
            {
                goto label_9;
            }
            
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            val_9 = val_1.x;
            val_10 = val_1.y;
            int val_2 = fingers.Count;
            val_11 = 0;
            goto label_5;
            label_8:
            if(fingers.Item[val_2] != null)
            {
                    UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_9, y = val_10}, b:  new UnityEngine.Vector2() {x = val_3.ScreenPosition, y = V10.16B});
                val_9 = val_4.x;
                val_10 = val_4.y;
                val_11 = 1;
            }
            
            label_5:
            val_6 = val_2 - 1;
            if((val_6 & 2147483648) == 0)
            {
                goto label_8;
            }
            
            if(val_11 >= 1)
            {
                    UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_9, y = val_10}, d:  1f);
                val_12 = 1;
                center.x = val_5.x;
                center.y = val_5.y;
                return (bool)val_12;
            }
            
            label_9:
            val_12 = 0;
            return (bool)val_12;
        }
        public static UnityEngine.Vector2 GetLastScreenCenter()
        {
            null = null;
            bool val_1 = Lean.Touch.LeanGesture.TryGetLastScreenCenter(fingers:  Lean.Touch.LeanTouch.Fingers, center: ref  new UnityEngine.Vector2() {x = 0f, y = 0f});
            return new UnityEngine.Vector2() {x = 0f, y = 0f};
        }
        public static UnityEngine.Vector2 GetLastScreenCenter(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers)
        {
            bool val_1 = Lean.Touch.LeanGesture.TryGetLastScreenCenter(fingers:  fingers, center: ref  new UnityEngine.Vector2() {x = 0f, y = 0f});
            return new UnityEngine.Vector2() {x = 0f, y = 0f};
        }
        public static bool TryGetLastScreenCenter(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, ref UnityEngine.Vector2 center)
        {
            var val_6;
            float val_9;
            float val_10;
            var val_11;
            var val_12;
            if(fingers == null)
            {
                goto label_9;
            }
            
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            val_9 = val_1.x;
            val_10 = val_1.y;
            int val_2 = fingers.Count;
            val_11 = 0;
            goto label_5;
            label_8:
            if(fingers.Item[val_2] != null)
            {
                    UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_9, y = val_10}, b:  new UnityEngine.Vector2() {x = val_3.LastScreenPosition, y = V10.16B});
                val_9 = val_4.x;
                val_10 = val_4.y;
                val_11 = 1;
            }
            
            label_5:
            val_6 = val_2 - 1;
            if((val_6 & 2147483648) == 0)
            {
                goto label_8;
            }
            
            if(val_11 >= 1)
            {
                    UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_9, y = val_10}, d:  1f);
                val_12 = 1;
                center.x = val_5.x;
                center.y = val_5.y;
                return (bool)val_12;
            }
            
            label_9:
            val_12 = 0;
            return (bool)val_12;
        }
        public static UnityEngine.Vector2 GetScreenDelta()
        {
            null = null;
            bool val_1 = Lean.Touch.LeanGesture.TryGetScreenDelta(fingers:  Lean.Touch.LeanTouch.Fingers, delta: ref  new UnityEngine.Vector2() {x = 0f, y = 0f});
            return new UnityEngine.Vector2() {x = 0f, y = 0f};
        }
        public static UnityEngine.Vector2 GetScreenDelta(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers)
        {
            bool val_1 = Lean.Touch.LeanGesture.TryGetScreenDelta(fingers:  fingers, delta: ref  new UnityEngine.Vector2() {x = 0f, y = 0f});
            return new UnityEngine.Vector2() {x = 0f, y = 0f};
        }
        public static bool TryGetScreenDelta(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, ref UnityEngine.Vector2 delta)
        {
            var val_7;
            float val_10;
            float val_11;
            var val_12;
            var val_13;
            if(fingers == null)
            {
                goto label_9;
            }
            
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            val_10 = val_1.x;
            val_11 = val_1.y;
            int val_2 = fingers.Count;
            val_12 = 0;
            goto label_5;
            label_8:
            Lean.Touch.LeanFinger val_3 = fingers.Item[val_2];
            if(val_3 != null)
            {
                    UnityEngine.Vector2 val_4 = val_3.ScreenDelta;
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_10, y = val_11}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
                val_10 = val_5.x;
                val_11 = val_5.y;
                val_12 = 1;
            }
            
            label_5:
            val_7 = val_2 - 1;
            if((val_7 & 2147483648) == 0)
            {
                goto label_8;
            }
            
            if(val_12 >= 1)
            {
                    UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_10, y = val_11}, d:  1f);
                val_13 = 1;
                delta.x = val_6.x;
                delta.y = val_6.y;
                return (bool)val_13;
            }
            
            label_9:
            val_13 = 0;
            return (bool)val_13;
        }
        public static UnityEngine.Vector2 GetScaledDelta()
        {
            UnityEngine.Vector2 val_1 = Lean.Touch.LeanGesture.GetScreenDelta();
            return UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  Lean.Touch.LeanTouch.ScalingFactor);
        }
        public static UnityEngine.Vector2 GetScaledDelta(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers)
        {
            bool val_1 = Lean.Touch.LeanGesture.TryGetScreenDelta(fingers:  fingers, delta: ref  new UnityEngine.Vector2() {x = 0f, y = 0f});
            return UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 0f, y = 0f}, d:  Lean.Touch.LeanTouch.ScalingFactor);
        }
        public static bool TryGetScaledDelta(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, ref UnityEngine.Vector2 delta)
        {
            var val_4;
            if((Lean.Touch.LeanGesture.TryGetScreenDelta(fingers:  fingers, delta: ref  new UnityEngine.Vector2() {x = delta.x, y = delta.y})) != false)
            {
                    UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = delta.x, y = delta.y}, d:  Lean.Touch.LeanTouch.ScalingFactor);
                val_4 = 1;
                delta.x = val_3.x;
                delta.y = val_3.y;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public static UnityEngine.Vector3 GetWorldDelta(float distance, UnityEngine.Camera camera)
        {
            null = null;
            bool val_1 = Lean.Touch.LeanGesture.TryGetWorldDelta(fingers:  Lean.Touch.LeanTouch.Fingers, distance:  distance, delta: ref  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, camera:  camera);
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public static UnityEngine.Vector3 GetWorldDelta(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, float distance, UnityEngine.Camera camera)
        {
            bool val_1 = Lean.Touch.LeanGesture.TryGetWorldDelta(fingers:  fingers, distance:  distance, delta: ref  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, camera:  camera);
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public static bool TryGetWorldDelta(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, float distance, ref UnityEngine.Vector3 delta, UnityEngine.Camera camera)
        {
            var val_9;
            var val_10;
            float val_14;
            float val_15;
            float val_16;
            var val_17;
            UnityEngine.Camera val_1 = camera;
            val_10 = 0;
            if(fingers == null)
            {
                    return (bool)val_10;
            }
            
            if((Lean.Touch.LeanTouch.GetCamera(camera: ref  val_1, gameObject:  0)) == false)
            {
                    return (bool)val_10;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_14 = val_3.x;
            val_15 = val_3.y;
            val_16 = val_3.z;
            int val_4 = fingers.Count;
            val_17 = 0;
            goto label_8;
            label_11:
            Lean.Touch.LeanFinger val_5 = fingers.Item[val_4];
            if(val_5 != null)
            {
                    UnityEngine.Vector3 val_6 = val_5.GetWorldDelta(lastDistance:  distance, distance:  distance, camera:  val_1);
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
                val_14 = val_7.x;
                val_15 = val_7.y;
                val_16 = val_7.z;
                val_17 = 1;
            }
            
            label_8:
            val_9 = val_4 - 1;
            if((val_9 & 2147483648) == 0)
            {
                goto label_11;
            }
            
            if(val_17 >= 1)
            {
                    UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16}, d:  1f);
                val_10 = 1;
                delta.x = val_8.x;
                delta.y = val_8.y;
                delta.z = val_8.z;
                return (bool)val_10;
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        public static float GetScreenDistance()
        {
            null = null;
            return Lean.Touch.LeanGesture.GetScreenDistance(fingers:  Lean.Touch.LeanTouch.Fingers);
        }
        public static float GetScreenDistance(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers)
        {
            if((Lean.Touch.LeanGesture.TryGetScreenCenter(fingers:  fingers, center: ref  new UnityEngine.Vector2() {x = 0f, y = 0f})) == false)
            {
                    return 0f;
            }
            
            bool val_3 = Lean.Touch.LeanGesture.TryGetScreenDistance(fingers:  fingers, center:  new UnityEngine.Vector2() {x = 0f, y = 0f}, distance: ref  float val_2 = -173.3356f);
            return 0f;
        }
        public static float GetScreenDistance(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, UnityEngine.Vector2 center)
        {
            bool val_2 = Lean.Touch.LeanGesture.TryGetScreenDistance(fingers:  fingers, center:  new UnityEngine.Vector2() {x = center.x, y = center.y}, distance: ref  float val_1 = -175.1696f);
            return 0f;
        }
        public static bool TryGetScreenDistance(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, UnityEngine.Vector2 center, ref float distance)
        {
            var val_4;
            var val_5;
            float val_6;
            var val_7;
            if(fingers == null)
            {
                goto label_5;
            }
            
            int val_1 = fingers.Count;
            val_5 = 0;
            val_6 = 0f;
            goto label_3;
            label_4:
            Lean.Touch.LeanFinger val_2 = fingers.Item[val_1];
            if(val_2 != null)
            {
                    val_6 = val_6 + (val_2.GetScreenDistance(point:  new UnityEngine.Vector2() {x = center.x, y = center.y}));
                val_5 = 1;
            }
            
            label_3:
            val_4 = val_1 - 1;
            if((val_4 & 2147483648) == 0)
            {
                goto label_4;
            }
            
            if(val_5 >= 1)
            {
                    float val_4 = 1f;
                val_4 = val_6 / val_4;
                val_7 = 1;
                distance = val_4;
                return (bool)val_7;
            }
            
            label_5:
            val_7 = 0;
            return (bool)val_7;
        }
        public static float GetScaledDistance()
        {
            float val_2 = Lean.Touch.LeanTouch.ScalingFactor;
            val_2 = Lean.Touch.LeanGesture.GetScreenDistance() * val_2;
            return (float)val_2;
        }
        public static float GetScaledDistance(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers)
        {
            float val_2 = Lean.Touch.LeanTouch.ScalingFactor;
            val_2 = (Lean.Touch.LeanGesture.GetScreenDistance(fingers:  fingers)) * val_2;
            return (float)val_2;
        }
        public static float GetScaledDistance(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, UnityEngine.Vector2 center)
        {
            bool val_2 = Lean.Touch.LeanGesture.TryGetScreenDistance(fingers:  fingers, center:  new UnityEngine.Vector2() {x = center.x, y = center.y}, distance: ref  float val_1 = -182.6281f);
            float val_3 = Lean.Touch.LeanTouch.ScalingFactor;
            val_3 = 0f * val_3;
            return (float)val_3;
        }
        public static bool TryGetScaledDistance(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, UnityEngine.Vector2 center, ref float distance)
        {
            float val_4;
            var val_5;
            val_4 = center.y;
            if((Lean.Touch.LeanGesture.TryGetScreenDistance(fingers:  fingers, center:  new UnityEngine.Vector2() {x = center.x, y = val_4}, distance: ref  -185.2583f)) != false)
            {
                    val_4 = distance;
                float val_3 = Lean.Touch.LeanTouch.ScalingFactor;
                val_3 = val_4 * val_3;
                val_5 = 1;
                distance = val_3;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        public static float GetLastScreenDistance()
        {
            null = null;
            return Lean.Touch.LeanGesture.GetLastScreenDistance(fingers:  Lean.Touch.LeanTouch.Fingers);
        }
        public static float GetLastScreenDistance(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers)
        {
            if((Lean.Touch.LeanGesture.TryGetLastScreenCenter(fingers:  fingers, center: ref  new UnityEngine.Vector2() {x = 0f, y = 0f})) == false)
            {
                    return 0f;
            }
            
            bool val_3 = Lean.Touch.LeanGesture.TryGetLastScreenDistance(fingers:  fingers, center:  new UnityEngine.Vector2() {x = 0f, y = 0f}, distance: ref  float val_2 = -188.1286f);
            return 0f;
        }
        public static float GetLastScreenDistance(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, UnityEngine.Vector2 center)
        {
            bool val_2 = Lean.Touch.LeanGesture.TryGetLastScreenDistance(fingers:  fingers, center:  new UnityEngine.Vector2() {x = center.x, y = center.y}, distance: ref  float val_1 = -189.9626f);
            return 0f;
        }
        public static bool TryGetLastScreenDistance(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, UnityEngine.Vector2 center, ref float distance)
        {
            var val_4;
            var val_5;
            float val_6;
            var val_7;
            if(fingers == null)
            {
                goto label_5;
            }
            
            int val_1 = fingers.Count;
            val_5 = 0;
            val_6 = 0f;
            goto label_3;
            label_4:
            Lean.Touch.LeanFinger val_2 = fingers.Item[val_1];
            if(val_2 != null)
            {
                    val_6 = val_6 + (val_2.GetLastScreenDistance(point:  new UnityEngine.Vector2() {x = center.x, y = center.y}));
                val_5 = 1;
            }
            
            label_3:
            val_4 = val_1 - 1;
            if((val_4 & 2147483648) == 0)
            {
                goto label_4;
            }
            
            if(val_5 >= 1)
            {
                    float val_4 = 1f;
                val_4 = val_6 / val_4;
                val_7 = 1;
                distance = val_4;
                return (bool)val_7;
            }
            
            label_5:
            val_7 = 0;
            return (bool)val_7;
        }
        public static float GetLastScaledDistance()
        {
            float val_2 = Lean.Touch.LeanTouch.ScalingFactor;
            val_2 = Lean.Touch.LeanGesture.GetLastScreenDistance() * val_2;
            return (float)val_2;
        }
        public static float GetLastScaledDistance(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers)
        {
            float val_2 = Lean.Touch.LeanTouch.ScalingFactor;
            val_2 = (Lean.Touch.LeanGesture.GetLastScreenDistance(fingers:  fingers)) * val_2;
            return (float)val_2;
        }
        public static float GetLastScaledDistance(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, UnityEngine.Vector2 center)
        {
            bool val_2 = Lean.Touch.LeanGesture.TryGetLastScreenDistance(fingers:  fingers, center:  new UnityEngine.Vector2() {x = center.x, y = center.y}, distance: ref  float val_1 = -197.4211f);
            float val_3 = Lean.Touch.LeanTouch.ScalingFactor;
            val_3 = 0f * val_3;
            return (float)val_3;
        }
        public static bool TryGetLastScaledDistance(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, UnityEngine.Vector2 center, ref float distance)
        {
            float val_4;
            var val_5;
            val_4 = center.y;
            if((Lean.Touch.LeanGesture.TryGetLastScreenDistance(fingers:  fingers, center:  new UnityEngine.Vector2() {x = center.x, y = val_4}, distance: ref  -200.0513f)) != false)
            {
                    val_4 = distance;
                float val_3 = Lean.Touch.LeanTouch.ScalingFactor;
                val_3 = val_4 * val_3;
                val_5 = 1;
                distance = val_3;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        public static float GetPinchScale(float wheelSensitivity = 0)
        {
            null = null;
            return Lean.Touch.LeanGesture.GetPinchScale(fingers:  Lean.Touch.LeanTouch.Fingers, wheelSensitivity:  wheelSensitivity);
        }
        public static float GetPinchScale(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, float wheelSensitivity = 0)
        {
            bool val_1 = Lean.Touch.LeanGesture.TryGetScreenCenter(fingers:  fingers, center: ref  new UnityEngine.Vector2() {x = 0f, y = 0f});
            bool val_2 = Lean.Touch.LeanGesture.TryGetLastScreenCenter(fingers:  fingers, center: ref  new UnityEngine.Vector2() {x = 0f, y = 0f});
            bool val_4 = Lean.Touch.LeanGesture.TryGetPinchScale(fingers:  fingers, center:  new UnityEngine.Vector2() {x = 0f, y = 0f}, lastCenter:  new UnityEngine.Vector2() {x = 0f, y = 0f}, scale: ref  float val_3 = -202.921f, wheelSensitivity:  wheelSensitivity);
            return 1f;
        }
        public static bool TryGetPinchScale(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, UnityEngine.Vector2 center, UnityEngine.Vector2 lastCenter, ref float scale, float wheelSensitivity = 0)
        {
            var val_6;
            bool val_2 = Lean.Touch.LeanGesture.TryGetScreenDistance(fingers:  fingers, center:  new UnityEngine.Vector2() {x = center.x, y = center.y}, distance: ref  float val_1 = -204.8168f);
            bool val_4 = Lean.Touch.LeanGesture.TryGetLastScreenDistance(fingers:  fingers, center:  new UnityEngine.Vector2() {x = lastCenter.x, y = lastCenter.y}, distance: ref  float val_3 = -204.8168f);
            float val_6 = 0f;
            if(val_6 <= 0f)
            {
                goto label_0;
            }
            
            val_6 = 0f / val_6;
            label_6:
            val_6 = 1;
            scale = val_6;
            return (bool)val_6;
            label_0:
            if(wheelSensitivity != 0f)
            {
                goto label_2;
            }
            
            label_5:
            val_6 = 0;
            return (bool)val_6;
            label_2:
            UnityEngine.Vector2 val_5 = UnityEngine.Input.mouseScrollDelta;
            if(val_5.y <= 0f)
            {
                goto label_3;
            }
            
            float val_7 = 1f;
            val_7 = val_7 - wheelSensitivity;
            goto label_6;
            label_3:
            if(val_5.y >= 0)
            {
                goto label_5;
            }
            
            float val_8 = 1f;
            val_8 = wheelSensitivity + val_8;
            goto label_6;
        }
        public static float GetPinchRatio(float wheelSensitivity = 0)
        {
            null = null;
            return Lean.Touch.LeanGesture.GetPinchRatio(fingers:  Lean.Touch.LeanTouch.Fingers, wheelSensitivity:  wheelSensitivity);
        }
        public static float GetPinchRatio(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, float wheelSensitivity = 0)
        {
            bool val_1 = Lean.Touch.LeanGesture.TryGetScreenCenter(fingers:  fingers, center: ref  new UnityEngine.Vector2() {x = 0f, y = 0f});
            bool val_2 = Lean.Touch.LeanGesture.TryGetLastScreenCenter(fingers:  fingers, center: ref  new UnityEngine.Vector2() {x = 0f, y = 0f});
            bool val_4 = Lean.Touch.LeanGesture.TryGetPinchRatio(fingers:  fingers, center:  new UnityEngine.Vector2() {x = 0f, y = 0f}, lastCenter:  new UnityEngine.Vector2() {x = 0f, y = 0f}, ratio: ref  float val_3 = -208.4219f, wheelSensitivity:  wheelSensitivity);
            return 1f;
        }
        public static bool TryGetPinchRatio(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, UnityEngine.Vector2 center, UnityEngine.Vector2 lastCenter, ref float ratio, float wheelSensitivity = 0)
        {
            var val_6;
            bool val_2 = Lean.Touch.LeanGesture.TryGetScreenDistance(fingers:  fingers, center:  new UnityEngine.Vector2() {x = center.x, y = center.y}, distance: ref  float val_1 = -210.3177f);
            bool val_4 = Lean.Touch.LeanGesture.TryGetLastScreenDistance(fingers:  fingers, center:  new UnityEngine.Vector2() {x = lastCenter.x, y = lastCenter.y}, distance: ref  float val_3 = -210.3178f);
            if(0f <= 0f)
            {
                goto label_0;
            }
            
            float val_6 = 0f;
            val_6 = val_6 / 0f;
            label_6:
            val_6 = 1;
            ratio = val_6;
            return (bool)val_6;
            label_0:
            if(wheelSensitivity != 0f)
            {
                goto label_2;
            }
            
            label_5:
            val_6 = 0;
            return (bool)val_6;
            label_2:
            UnityEngine.Vector2 val_5 = UnityEngine.Input.mouseScrollDelta;
            if(val_5.y <= 0f)
            {
                goto label_3;
            }
            
            float val_7 = 1f;
            val_7 = wheelSensitivity + val_7;
            goto label_6;
            label_3:
            if(val_5.y >= 0)
            {
                goto label_5;
            }
            
            float val_8 = 1f;
            val_8 = val_8 - wheelSensitivity;
            goto label_6;
        }
        public static float GetTwistDegrees()
        {
            null = null;
            float val_1 = Lean.Touch.LeanGesture.GetTwistRadians(fingers:  Lean.Touch.LeanTouch.Fingers);
            val_1 = val_1 * 57.29578f;
            return (float)val_1;
        }
        public static float GetTwistDegrees(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers)
        {
            float val_1 = Lean.Touch.LeanGesture.GetTwistRadians(fingers:  fingers);
            val_1 = val_1 * 57.29578f;
            return (float)val_1;
        }
        public static float GetTwistDegrees(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, UnityEngine.Vector2 center, UnityEngine.Vector2 lastCenter)
        {
            bool val_2 = Lean.Touch.LeanGesture.TryGetTwistRadians(fingers:  fingers, center:  new UnityEngine.Vector2() {x = center.x, y = center.y}, lastCenter:  new UnityEngine.Vector2() {x = lastCenter.x, y = lastCenter.y}, radians: ref  float val_1 = -215.7575f);
            float val_3 = 0f;
            val_3 = val_3 * 57.29578f;
            return (float)val_3;
        }
        public static bool TryGetTwistDegrees(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, UnityEngine.Vector2 center, UnityEngine.Vector2 lastCenter, ref float degrees)
        {
            var val_3;
            if((Lean.Touch.LeanGesture.TryGetTwistRadians(fingers:  fingers, center:  new UnityEngine.Vector2() {x = center.x, y = center.y}, lastCenter:  new UnityEngine.Vector2() {x = lastCenter.x, y = lastCenter.y}, radians: ref  float val_1 = -218.3875f)) != false)
            {
                    float val_3 = degrees;
                val_3 = 1;
                val_3 = val_3 * 57.29578f;
                degrees = val_3;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public static float GetTwistRadians()
        {
            null = null;
            return Lean.Touch.LeanGesture.GetTwistRadians(fingers:  Lean.Touch.LeanTouch.Fingers);
        }
        public static float GetTwistRadians(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers)
        {
            bool val_1 = Lean.Touch.LeanGesture.TryGetScreenCenter(fingers:  fingers, center: ref  new UnityEngine.Vector2() {x = 0f, y = 0f});
            bool val_2 = Lean.Touch.LeanGesture.TryGetLastScreenCenter(fingers:  fingers, center: ref  new UnityEngine.Vector2() {x = 0f, y = 0f});
            bool val_4 = Lean.Touch.LeanGesture.TryGetTwistRadians(fingers:  fingers, center:  new UnityEngine.Vector2() {x = 0f, y = 0f}, lastCenter:  new UnityEngine.Vector2() {x = 0f, y = 0f}, radians: ref  float val_3 = -221.2579f);
            return 0f;
        }
        public static float GetTwistRadians(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, UnityEngine.Vector2 center, UnityEngine.Vector2 lastCenter)
        {
            bool val_2 = Lean.Touch.LeanGesture.TryGetTwistRadians(fingers:  fingers, center:  new UnityEngine.Vector2() {x = center.x, y = center.y}, lastCenter:  new UnityEngine.Vector2() {x = lastCenter.x, y = lastCenter.y}, radians: ref  float val_1 = -223.092f);
            return 0f;
        }
        public static bool TryGetTwistRadians(System.Collections.Generic.List<Lean.Touch.LeanFinger> fingers, UnityEngine.Vector2 center, UnityEngine.Vector2 lastCenter, ref float radians)
        {
            var val_4;
            var val_5;
            float val_6;
            var val_7;
            if(fingers == null)
            {
                goto label_5;
            }
            
            int val_1 = fingers.Count;
            val_5 = 0;
            val_6 = 0f;
            goto label_3;
            label_4:
            Lean.Touch.LeanFinger val_2 = fingers.Item[val_1];
            if(val_2 != null)
            {
                    val_6 = val_6 + (val_2.GetDeltaRadians(referencePoint:  new UnityEngine.Vector2() {x = center.x, y = center.y}, lastReferencePoint:  new UnityEngine.Vector2() {x = lastCenter.x, y = lastCenter.y}));
                val_5 = 1;
            }
            
            label_3:
            val_4 = val_1 - 1;
            if((val_4 & 2147483648) == 0)
            {
                goto label_4;
            }
            
            if(val_5 >= 1)
            {
                    float val_4 = 1f;
                val_4 = val_6 / val_4;
                val_7 = 1;
                radians = val_4;
                return (bool)val_7;
            }
            
            label_5:
            val_7 = 0;
            return (bool)val_7;
        }
    
    }

}
