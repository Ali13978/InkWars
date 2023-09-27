using UnityEngine;

namespace Lean.Touch
{
    public class LeanTouch : MonoBehaviour
    {
        // Fields
        public static System.Collections.Generic.List<Lean.Touch.LeanTouch> Instances;
        public static System.Collections.Generic.List<Lean.Touch.LeanFinger> Fingers;
        public static System.Collections.Generic.List<Lean.Touch.LeanFinger> InactiveFingers;
        public static System.Action<Lean.Touch.LeanFinger> OnFingerDown;
        public static System.Action<Lean.Touch.LeanFinger> OnFingerSet;
        public static System.Action<Lean.Touch.LeanFinger> OnFingerUp;
        public static System.Action<Lean.Touch.LeanFinger> OnFingerTap;
        public static System.Action<Lean.Touch.LeanFinger> OnFingerSwipe;
        public static System.Action<System.Collections.Generic.List<Lean.Touch.LeanFinger>> OnGesture;
        public float TapThreshold;
        public const float DefaultTapThreshold = 0.5;
        public float SwipeThreshold;
        public const float DefaultSwipeThreshold = 50;
        public int ReferenceDpi;
        public const int DefaultReferenceDpi = 200;
        public UnityEngine.LayerMask GuiLayers;
        public bool RecordFingers;
        public float RecordThreshold;
        public float RecordLimit;
        public bool SimulateMultiFingers;
        public UnityEngine.KeyCode PinchTwistKey;
        public UnityEngine.KeyCode MultiDragKey;
        public UnityEngine.Texture2D FingerTexture;
        private static int highestMouseButton;
        private static System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> tempRaycastResults;
        private static System.Collections.Generic.List<Lean.Touch.LeanFinger> filteredFingers;
        private static UnityEngine.EventSystems.PointerEventData tempPointerEventData;
        private static UnityEngine.EventSystems.EventSystem tempEventSystem;
        
        // Properties
        public static float CurrentTapThreshold { get; }
        public static float CurrentSwipeThreshold { get; }
        public static int CurrentReferenceDpi { get; }
        public static UnityEngine.LayerMask CurrentGuiLayers { get; }
        public static Lean.Touch.LeanTouch Instance { get; }
        public static float ScalingFactor { get; }
        public static bool AnyMouseButtonSet { get; }
        public static bool GuiInUse { get; }
        
        // Methods
        public static float get_CurrentTapThreshold()
        {
            var val_3;
            int val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = Lean.Touch.LeanTouch.DefaultReferenceDpi;
            if(val_4.Count >= 1)
            {
                    val_5 = null;
                val_5 = null;
                val_4 = Lean.Touch.LeanTouch.DefaultReferenceDpi.Item[0];
                if(val_4 != null)
            {
                    return 0.5f;
            }
            
                return 0.5f;
            }
            
            return 0.5f;
        }
        public static float get_CurrentSwipeThreshold()
        {
            var val_3;
            int val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = Lean.Touch.LeanTouch.DefaultReferenceDpi;
            if(val_4.Count >= 1)
            {
                    val_5 = null;
                val_5 = null;
                val_4 = Lean.Touch.LeanTouch.DefaultReferenceDpi.Item[0];
                if(val_4 != null)
            {
                    return 50f;
            }
            
                return 50f;
            }
            
            return 50f;
        }
        public static int get_CurrentReferenceDpi()
        {
            var val_3;
            int val_4;
            var val_5;
            int val_6;
            val_3 = null;
            val_3 = null;
            val_4 = Lean.Touch.LeanTouch.DefaultReferenceDpi;
            if(val_4.Count >= 1)
            {
                    val_5 = null;
                val_5 = null;
                val_4 = Lean.Touch.LeanTouch.DefaultReferenceDpi.Item[0];
                val_6 = val_2.ReferenceDpi;
                return 200;
            }
            
            val_6 = 200;
            return 200;
        }
        public static UnityEngine.LayerMask get_CurrentGuiLayers()
        {
            var val_4;
            int val_5;
            var val_6;
            UnityEngine.LayerMask val_7;
            val_4 = null;
            val_4 = null;
            val_5 = Lean.Touch.LeanTouch.DefaultReferenceDpi;
            if(val_5.Count > 0)
            {
                    val_6 = null;
                val_6 = null;
                val_5 = Lean.Touch.LeanTouch.DefaultReferenceDpi.Item[0];
                val_7 = val_2.GuiLayers;
            }
            else
            {
                    val_7 = -5;
                UnityEngine.LayerMask val_3 = UnityEngine.LayerMask.op_Implicit(intVal:  -5);
            }
            
            val_3.m_Mask = val_3.m_Mask & 4294967295;
            return (UnityEngine.LayerMask)val_3.m_Mask;
        }
        public static Lean.Touch.LeanTouch get_Instance()
        {
            var val_3;
            int val_4;
            var val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            val_4 = Lean.Touch.LeanTouch.DefaultReferenceDpi;
            if(val_4.Count >= 1)
            {
                    val_5 = null;
                val_5 = null;
                val_4 = Lean.Touch.LeanTouch.DefaultReferenceDpi;
                Lean.Touch.LeanTouch val_2 = val_4.Item[0];
                return (Lean.Touch.LeanTouch)val_6;
            }
            
            val_6 = 0;
            return (Lean.Touch.LeanTouch)val_6;
        }
        public static float get_ScalingFactor()
        {
            var val_3;
            float val_4;
            float val_5;
            float val_1 = UnityEngine.Screen.dpi;
            if(val_1 <= 0f)
            {
                    return 1f;
            }
            
            val_3 = null;
            if(S9 >= _TYPE_MAX_)
            {
                    val_4 = (float)Lean.Touch.LeanTouch.CurrentReferenceDpi;
            }
            
            if((float)Lean.Touch.LeanTouch.CurrentReferenceDpi >= _TYPE_MAX_)
            {
                    val_5 = val_1;
            }
            
            val_5 = val_4 / val_5;
            return 1f;
        }
        public static bool get_AnyMouseButtonSet()
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = 0;
            label_4:
            val_3 = null;
            val_3 = null;
            if(val_2 >= Lean.Touch.LeanTouch.highestMouseButton)
            {
                goto label_3;
            }
            
            val_2 = val_2 + 1;
            if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
            {
                goto label_4;
            }
            
            val_4 = 1;
            return (bool)val_4;
            label_3:
            val_4 = 0;
            return (bool)val_4;
        }
        public static bool get_GuiInUse()
        {
            var val_4;
            var val_5;
            var val_6;
            if(UnityEngine.GUIUtility.hotControl <= 0)
            {
                    val_5 = null;
                val_5 = null;
                System.Collections.Generic.List<Lean.Touch.LeanFinger> val_4 = Lean.Touch.LeanTouch.Fingers;
                val_4 = val_4.Count - 1;
                do
            {
                if((val_4 & 2147483648) != 0)
            {
                    return true;
            }
            
                val_6 = null;
                val_6 = null;
                Lean.Touch.LeanFinger val_3 = Lean.Touch.LeanTouch.Fingers.Item[val_4];
                val_4 = val_4 - 1;
            }
            while(val_3.StartedOverGui == false);
            
            }
            
            return true;
        }
        public static bool GetCamera(ref UnityEngine.Camera camera, UnityEngine.GameObject gameObject)
        {
            UnityEngine.Camera val_6;
            if(camera != 0)
            {
                    return UnityEngine.Object.op_Inequality(x:  camera = UnityEngine.Camera.main, y:  0);
            }
            
            if(gameObject != 0)
            {
                    val_6 = gameObject.GetComponent<UnityEngine.Camera>();
                camera = val_6;
            }
            else
            {
                    val_6 = camera;
            }
            
            if(val_6 != 0)
            {
                    return UnityEngine.Object.op_Inequality(x:  camera, y:  0);
            }
            
            return UnityEngine.Object.op_Inequality(x:  camera, y:  0);
        }
        public static float GetDampenFactor(float dampening, float deltaTime)
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return 1f;
            }
            
            dampening = -(dampening * deltaTime);
            dampening = 1f - dampening;
            return 1f;
        }
        public static bool PointOverGui(UnityEngine.Vector2 screenPosition)
        {
            return (bool)((Lean.Touch.LeanTouch.RaycastGui(screenPosition:  new UnityEngine.Vector2() {x = screenPosition.x, y = screenPosition.y}).Count) > 0) ? 1 : 0;
        }
        public static System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> RaycastGui(UnityEngine.Vector2 screenPosition)
        {
            var val_2 = null;
            UnityEngine.LayerMask val_1 = Lean.Touch.LeanTouch.CurrentGuiLayers;
            val_1.m_Mask = val_1.m_Mask & 4294967295;
            return Lean.Touch.LeanTouch.RaycastGui(screenPosition:  new UnityEngine.Vector2() {x = screenPosition.x, y = screenPosition.y}, layerMask:  new UnityEngine.LayerMask() {m_Mask = val_1.m_Mask});
        }
        public static System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> RaycastGui(UnityEngine.Vector2 screenPosition, UnityEngine.LayerMask layerMask)
        {
            int val_12;
            var val_13;
            System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> val_14;
            var val_15;
            var val_16;
            UnityEngine.EventSystems.PointerEventData val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            val_12 = layerMask.m_Mask;
            val_13 = null;
            val_13 = null;
            Lean.Touch.LeanTouch.tempRaycastResults.Clear();
            UnityEngine.EventSystems.EventSystem val_1 = UnityEngine.EventSystems.EventSystem.current;
            val_14 = 1152921504858337280;
            if(val_1 == 0)
            {
                goto label_32;
            }
            
            val_15 = null;
            val_15 = null;
            if(val_1 == Lean.Touch.LeanTouch.tempEventSystem)
            {
                goto label_20;
            }
            
            val_16 = null;
            val_16 = null;
            Lean.Touch.LeanTouch.tempEventSystem = val_1;
            val_18 = Lean.Touch.LeanTouch.tempPointerEventData;
            if(val_18 == null)
            {
                goto label_16;
            }
            
            val_18 = Lean.Touch.LeanTouch.tempPointerEventData;
            if(val_18 == null)
            {
                goto label_19;
            }
            
            val_18.Reset();
            goto label_20;
            label_16:
            UnityEngine.EventSystems.PointerEventData val_4 = new UnityEngine.EventSystems.PointerEventData(eventSystem:  Lean.Touch.LeanTouch.tempEventSystem);
            Lean.Touch.LeanTouch.tempPointerEventData = val_4;
            label_20:
            val_19 = null;
            val_19 = null;
            val_4.position = new UnityEngine.Vector2() {x = screenPosition.x, y = screenPosition.y};
            val_1.RaycastAll(eventData:  val_4, raycastResults:  Lean.Touch.LeanTouch.tempRaycastResults);
            val_14 = 1152921529362954400;
            if(Lean.Touch.LeanTouch.tempRaycastResults.Count >= 1)
            {
                    val_20 = null;
                val_20 = null;
                System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> val_12 = Lean.Touch.LeanTouch.tempRaycastResults;
                val_12 = val_12.Count - 1;
                if((val_12 & 2147483648) == 0)
            {
                    val_12 = val_12 & 4294967295;
                do
            {
                val_21 = null;
                val_21 = null;
                UnityEngine.EventSystems.RaycastResult val_7 = Lean.Touch.LeanTouch.tempRaycastResults.Item[val_12];
                val_14 = InitialType.layer;
                int val_11 = val_14 & 31;
                val_11 = 1 << val_11;
                val_11 = val_11 & (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = val_12}));
                if(val_11 == 0)
            {
                    val_22 = null;
                val_22 = null;
                val_14 = Lean.Touch.LeanTouch.tempRaycastResults;
                val_14.RemoveAt(index:  val_12);
            }
            
                val_12 = val_12 - 1;
            }
            while((val_12 & 2147483648) == 0);
            
            }
            
            }
            
            label_32:
            val_23 = null;
            val_23 = null;
            return (System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>)Lean.Touch.LeanTouch.tempRaycastResults;
            label_19:
        }
        public static System.Collections.Generic.List<Lean.Touch.LeanFinger> GetFingers(bool ignoreGuiFingers, int requiredFingerCount = 0, Lean.Touch.LeanSelectable requiredSelectable)
        {
            UnityEngine.Object val_5;
            System.Collections.Generic.List<Lean.Touch.LeanFinger> val_6;
            var val_7;
            Lean.Touch.LeanFinger val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            System.Collections.Generic.List<Lean.Touch.LeanFinger> val_14;
            val_5 = requiredSelectable;
            val_6 = requiredFingerCount;
            val_7 = null;
            val_7 = null;
            Lean.Touch.LeanTouch.filteredFingers.Clear();
            if(val_5 == 0)
            {
                goto label_8;
            }
            
            val_8 = requiredSelectable.SelectingFinger;
            if(val_8 == null)
            {
                goto label_8;
            }
            
            val_9 = null;
            val_9 = null;
            val_8 = requiredSelectable.SelectingFinger;
            val_6 = Lean.Touch.LeanTouch.filteredFingers;
            val_6.Add(item:  val_8);
            goto label_33;
            label_8:
            val_5 = 0;
            goto label_13;
            label_26:
            val_10 = null;
            val_10 = null;
            if(ignoreGuiFingers != false)
            {
                    if(val_2.StartedOverGui == true)
            {
                goto label_19;
            }
            
            }
            
            val_11 = null;
            val_11 = null;
            Lean.Touch.LeanTouch.filteredFingers.Add(item:  Lean.Touch.LeanTouch.Fingers.Item[0]);
            label_19:
            val_5 = 1;
            label_13:
            val_12 = null;
            val_12 = null;
            if(val_5 < Lean.Touch.LeanTouch.Fingers.Count)
            {
                goto label_26;
            }
            
            if(val_6 < 1)
            {
                goto label_27;
            }
            
            val_13 = null;
            val_13 = null;
            if(Lean.Touch.LeanTouch.filteredFingers.Count != val_6)
            {
                goto label_31;
            }
            
            label_27:
            label_33:
            val_14 = Lean.Touch.LeanTouch.filteredFingers;
            return (System.Collections.Generic.List<Lean.Touch.LeanFinger>)val_14;
            label_31:
            val_14 = 0;
            return (System.Collections.Generic.List<Lean.Touch.LeanFinger>)val_14;
        }
        protected virtual void Awake()
        {
        
        }
        protected virtual void OnEnable()
        {
            null = null;
            Lean.Touch.LeanTouch.DefaultReferenceDpi.Add(item:  this);
        }
        protected virtual void OnDisable()
        {
            null = null;
            bool val_1 = Lean.Touch.LeanTouch.DefaultReferenceDpi.Remove(item:  this);
        }
        protected virtual void Update()
        {
            null = null;
            bool val_2 = UnityEngine.Object.op_Equality(x:  Lean.Touch.LeanTouch.DefaultReferenceDpi.Item[0], y:  this);
            if(val_2 == false)
            {
                    return;
            }
            
            val_2.BeginFingers();
            this.PollFingers();
            this.EndFingers();
            this.UpdateEvents();
        }
        protected virtual void OnGUI()
        {
            var val_11;
            UnityEngine.Texture2D val_12;
            var val_13;
            var val_14;
            if(this.FingerTexture == 0)
            {
                    return;
            }
            
            if(UnityEngine.Input.touchCount != 0)
            {
                    return;
            }
            
            val_11 = null;
            val_11 = null;
            val_12 = 1152921529354462240;
            if(Lean.Touch.LeanTouch.Fingers.Count < 2)
            {
                    return;
            }
            
            val_13 = null;
            val_13 = null;
            System.Collections.Generic.List<Lean.Touch.LeanFinger> val_11 = Lean.Touch.LeanTouch.Fingers;
            val_11 = val_11.Count - 1;
            if((val_11 & 2147483648) != 0)
            {
                    return;
            }
            
            label_24:
            val_14 = null;
            val_14 = null;
            val_12 = Lean.Touch.LeanTouch.Fingers.Item[val_11];
            if(val_5.Set == false)
            {
                goto label_17;
            }
            
            label_23:
            int val_6 = this.FingerTexture.width;
            int val_7 = this.FingerTexture.height;
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_5.ScreenPosition, y:  (float)UnityEngine.Screen.height - S9);
            val_12 = this.FingerTexture;
            UnityEngine.GUI.DrawTexture(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, image:  val_12);
            goto label_22;
            label_17:
            if(val_5.LastSet == false)
            {
                goto label_23;
            }
            
            label_22:
            val_11 = val_11 - 1;
            if((val_11 & 2147483648) == 0)
            {
                goto label_24;
            }
        
        }
        private void BeginFingers()
        {
            var val_7;
            System.Collections.Generic.List<Lean.Touch.LeanFinger> val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            float val_13;
            float val_14;
            var val_15;
            int val_16;
            var val_17;
            var val_18;
            val_7 = null;
            val_7 = null;
            System.Collections.Generic.List<Lean.Touch.LeanFinger> val_7 = Lean.Touch.LeanTouch.InactiveFingers;
            val_8 = 1152921529354462240;
            val_9 = null;
            val_7 = val_7.Count - 1;
            val_10 = (uint)(((uint)((Lean.Touch.LeanTouch.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
            if((val_7 & 2147483648) == 0)
            {
                    val_11 = 1152921529354463264;
                do
            {
                val_12 = null;
                if(Lean.Touch.LeanTouch.InactiveFingers.Item[val_7] != null)
            {
                    val_13 = val_2.Age;
                val_14 = UnityEngine.Time.unscaledDeltaTime;
            }
            else
            {
                    val_13 = val_2.Age;
                float val_4 = UnityEngine.Time.unscaledDeltaTime;
                val_14 = val_4;
            }
            
                val_4 = val_14 + val_13;
                mem2[0] = val_4;
                val_15 = null;
                val_7 = val_7 - 1;
                val_10 = (uint)(((uint)((Lean.Touch.LeanTouch.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
            }
            while((val_7 & 2147483648) == 0);
            
            }
            
            val_15 = null;
            val_16 = Lean.Touch.LeanTouch.Fingers.Count - 1;
            if((val_16 & 2147483648) != 0)
            {
                    return;
            }
            
            val_11 = 1152921529354463264;
            label_26:
            val_17 = null;
            val_17 = null;
            Lean.Touch.LeanFinger val_6 = Lean.Touch.LeanTouch.Fingers.Item[val_16];
            if(val_6.Set == false)
            {
                goto label_19;
            }
            
            label_21:
            val_6.LastSet = val_6.Set;
            val_6.Set = false;
            val_6.Tap = false;
            val_6.LastScreenPosition = val_6.ScreenPosition;
            mem2[0] = ???;
            goto label_20;
            label_19:
            if(val_6.LastSet == false)
            {
                goto label_21;
            }
            
            val_18 = null;
            val_18 = null;
            Lean.Touch.LeanTouch.Fingers.RemoveAt(index:  val_16);
            val_8 = Lean.Touch.LeanTouch.InactiveFingers;
            val_8.Add(item:  val_6);
            val_6.Age = 0f;
            val_6.ClearSnapshots(count:  0);
            label_20:
            val_16 = val_16 - 1;
            if((val_16 & 2147483648) == 0)
            {
                goto label_26;
            }
        
        }
        private void EndFingers()
        {
            var val_6;
            var val_7;
            val_6 = null;
            val_6 = null;
            System.Collections.Generic.List<Lean.Touch.LeanFinger> val_6 = Lean.Touch.LeanTouch.Fingers;
            val_6 = val_6.Count - 1;
            if((val_6 & 2147483648) != 0)
            {
                    return;
            }
            
            goto label_21;
            label_19:
            UnityEngine.Vector2 val_2 = X21.SwipeScreenDelta;
            float val_3 = Lean.Touch.LeanTouch.ScalingFactor;
            val_3 = val_2.x * val_3;
            if(val_3 >= 0)
            {
                goto label_8;
            }
            
            var val_7 = X21 + 28;
            mem2[0] = 1;
            val_7 = val_7 + 1;
            mem2[0] = val_7;
            goto label_20;
            label_8:
            mem2[0] = 0;
            mem2[0] = 1;
            goto label_20;
            label_21:
            val_7 = null;
            val_7 = null;
            Lean.Touch.LeanFinger val_4 = Lean.Touch.LeanTouch.Fingers.Item[val_6];
            if(val_4.Set == false)
            {
                goto label_15;
            }
            
            if(val_4.LastSet == true)
            {
                goto label_18;
            }
            
            goto label_20;
            label_15:
            if(val_4.LastSet == false)
            {
                goto label_18;
            }
            
            if(val_4.Age <= this.TapThreshold)
            {
                goto label_19;
            }
            
            val_4.TapCount = 0;
            goto label_20;
            label_18:
            float val_5 = UnityEngine.Time.unscaledDeltaTime;
            val_5 = val_4.Age + val_5;
            val_4.Age = val_5;
            label_20:
            val_6 = val_6 - 1;
            if((val_6 & 2147483648) == 0)
            {
                goto label_21;
            }
        
        }
        private void PollFingers()
        {
            var val_18;
            float val_19;
            var val_22;
            if(UnityEngine.Input.touchCount >= 1)
            {
                    if(UnityEngine.Input.touchCount < 1)
            {
                    return;
            }
            
                var val_18 = 0;
                do
            {
                UnityEngine.Touch val_3 = UnityEngine.Input.GetTouch(index:  0);
                this.AddFinger(index:  fingerId, screenPosition:  new UnityEngine.Vector2());
                val_18 = val_18 + 1;
            }
            while(val_18 < UnityEngine.Input.touchCount);
            
                return;
            }
            
            val_18 = null;
            if(Lean.Touch.LeanTouch.AnyMouseButtonSet == false)
            {
                    return;
            }
            
            int val_7 = UnityEngine.Screen.width;
            int val_8 = UnityEngine.Screen.height;
            UnityEngine.Vector3 val_9 = UnityEngine.Input.mousePosition;
            val_19 = val_9.z;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_19});
            if(((-1012262936) & 1) == 0)
            {
                    return;
            }
            
            this.AddFinger(index:  0, screenPosition:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
            if(this.SimulateMultiFingers == false)
            {
                    return;
            }
            
            if((UnityEngine.Input.GetKey(key:  this.PinchTwistKey)) != false)
            {
                    float val_19 = (float)UnityEngine.Screen.width;
                float val_20 = 0.5f;
                val_19 = val_19 * val_20;
                val_20 = (float)UnityEngine.Screen.height * val_20;
                UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  val_19, y:  val_20);
                val_19 = val_14.x;
                UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, b:  new UnityEngine.Vector2() {x = val_19, y = val_14.y});
                UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_19, y = val_14.y}, b:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
                val_22 = 1;
            }
            else
            {
                    if((UnityEngine.Input.GetKey(key:  this.MultiDragKey)) == false)
            {
                    return;
            }
            
                val_22 = 1;
            }
            
            this.AddFinger(index:  1, screenPosition:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        }
        private void UpdateEvents()
        {
            var val_3;
            var val_4;
            var val_5;
            System.Action<Lean.Touch.LeanFinger> val_6;
            var val_7;
            System.Action<Lean.Touch.LeanFinger> val_8;
            var val_9;
            System.Action<Lean.Touch.LeanFinger> val_10;
            var val_11;
            System.Action<Lean.Touch.LeanFinger> val_12;
            var val_13;
            System.Action<Lean.Touch.LeanFinger> val_14;
            var val_15;
            val_3 = null;
            val_3 = null;
            int val_1 = Lean.Touch.LeanTouch.Fingers.Count;
            if(val_1 < 1)
            {
                    return;
            }
            
            val_4 = null;
            var val_3 = 0;
            label_46:
            val_4 = null;
            Lean.Touch.LeanFinger val_2 = Lean.Touch.LeanTouch.Fingers.Item[0];
            if(val_2.Set == false)
            {
                goto label_17;
            }
            
            if(val_2.LastSet != true)
            {
                    val_5 = null;
                val_5 = null;
                val_6 = Lean.Touch.LeanTouch.OnFingerDown;
                if(val_6 != null)
            {
                    val_6 = Lean.Touch.LeanTouch.OnFingerDown;
                if(val_6 == null)
            {
                    val_6 = 0;
            }
            
                val_6.Invoke(obj:  val_2);
            }
            
            }
            
            if(val_2.Set == false)
            {
                goto label_17;
            }
            
            val_7 = null;
            val_7 = null;
            val_8 = Lean.Touch.LeanTouch.OnFingerSet;
            if(val_8 != null)
            {
                    val_8 = Lean.Touch.LeanTouch.OnFingerSet;
                if(val_8 == null)
            {
                    val_8 = 0;
            }
            
                val_8.Invoke(obj:  val_2);
            }
            
            if(val_2.Set == true)
            {
                goto label_28;
            }
            
            label_17:
            if(val_2.LastSet != false)
            {
                    val_9 = null;
                val_9 = null;
                val_10 = Lean.Touch.LeanTouch.OnFingerUp;
                if(val_10 != null)
            {
                    val_10 = Lean.Touch.LeanTouch.OnFingerUp;
                if(val_10 == null)
            {
                    val_10 = 0;
            }
            
                val_10.Invoke(obj:  val_2);
            }
            
            }
            
            label_28:
            if(val_2.Tap != false)
            {
                    val_11 = null;
                val_11 = null;
                val_12 = Lean.Touch.LeanTouch.OnFingerTap;
                if(val_12 != null)
            {
                    val_12 = Lean.Touch.LeanTouch.OnFingerTap;
                if(val_12 == null)
            {
                    val_12 = 0;
            }
            
                val_12.Invoke(obj:  val_2);
            }
            
            }
            
            if(val_2.Swipe != false)
            {
                    val_13 = null;
                val_13 = null;
                val_14 = Lean.Touch.LeanTouch.OnFingerSwipe;
                if(val_14 != null)
            {
                    val_14 = Lean.Touch.LeanTouch.OnFingerSwipe;
                if(val_14 == null)
            {
                    val_14 = 0;
            }
            
                val_14.Invoke(obj:  val_2);
            }
            
            }
            
            val_15 = null;
            val_3 = val_3 + 1;
            if(val_1 != val_3)
            {
                goto label_46;
            }
            
            val_15 = null;
            if(Lean.Touch.LeanTouch.OnGesture == null)
            {
                    return;
            }
            
            Lean.Touch.LeanTouch.filteredFingers.Clear();
            Lean.Touch.LeanTouch.filteredFingers.AddRange(collection:  Lean.Touch.LeanTouch.Fingers);
            Lean.Touch.LeanTouch.OnGesture.Invoke(obj:  Lean.Touch.LeanTouch.filteredFingers);
        }
        private void AddFinger(int index, UnityEngine.Vector2 screenPosition)
        {
            float val_12;
            Lean.Touch.LeanFinger val_13;
            var val_14;
            var val_15;
            System.Collections.Generic.List<Lean.Touch.LeanFinger> val_16;
            val_12 = screenPosition.y;
            Lean.Touch.LeanFinger val_1 = this.FindFinger(index:  index);
            val_13 = val_1;
            if(val_13 == null)
            {
                    int val_2 = val_1.FindInactiveFingerIndex(index:  index);
                if((val_2 & 2147483648) == 0)
            {
                    val_14 = null;
                val_14 = null;
                val_13 = Lean.Touch.LeanTouch.InactiveFingers.Item[val_2];
                Lean.Touch.LeanTouch.InactiveFingers.RemoveAt(index:  val_2);
                if(val_3.Age > this.TapThreshold)
            {
                    val_3.TapCount = 0;
            }
            
                val_3.Age = 0f;
                val_3.Set = false;
                val_3.LastSet = false;
                val_3.Tap = false;
                val_3.Swipe = false;
            }
            else
            {
                    Lean.Touch.LeanFinger val_4 = null;
                val_13 = val_4;
                val_4 = new Lean.Touch.LeanFinger();
                .Index = index;
            }
            
                .StartScreenPosition = screenPosition;
                mem[1152921529364716488] = val_12;
                .LastScreenPosition = screenPosition;
                mem[1152921529364716496] = val_12;
                .ScreenPosition = screenPosition;
                mem[1152921529364716504] = val_12;
                .StartedOverGui = val_4.IsOverGui;
                val_15 = null;
                val_15 = null;
                val_16 = Lean.Touch.LeanTouch.Fingers;
                val_16.Add(item:  val_4);
            }
            
            .Set = true;
            .ScreenPosition = screenPosition;
            mem[1152921529364716504] = val_12;
            if(this.RecordFingers == false)
            {
                    return;
            }
            
            if(this.RecordLimit > 0f)
            {
                    val_12 = this.RecordLimit;
                if(val_4.SnapshotDuration > val_12)
            {
                    val_16 = (Lean.Touch.LeanFinger)[1152921529364716448].Snapshots;
                val_4.ClearSnapshots(count:  Lean.Touch.LeanSnapshot.GetLowerIndex(snapshots:  val_16, targetAge:  (Lean.Touch.LeanFinger)[1152921529364716448].Age - val_12));
            }
            
            }
            
            if(this.RecordThreshold > 0f)
            {
                    val_16 = (Lean.Touch.LeanFinger)[1152921529364716448].Snapshots;
                if(val_16.Count != 0)
            {
                    UnityEngine.Vector2 val_11 = val_4.LastSnapshotScreenDelta;
                if(val_11.x < this.RecordThreshold)
            {
                    return;
            }
            
            }
            
            }
            
            val_4.RecordSnapshot();
        }
        private Lean.Touch.LeanFinger FindFinger(int index)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            System.Collections.Generic.List<Lean.Touch.LeanFinger> val_3 = Lean.Touch.LeanTouch.Fingers;
            val_3 = val_3.Count - 1;
            label_9:
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_4 = null;
            val_4 = null;
            val_5 = Lean.Touch.LeanTouch.Fingers.Item[val_3];
            val_3 = val_3 - 1;
            if(val_2.Index != index)
            {
                goto label_9;
            }
            
            return (Lean.Touch.LeanFinger)val_5;
            label_4:
            val_5 = 0;
            return (Lean.Touch.LeanFinger)val_5;
        }
        private int FindInactiveFingerIndex(int index)
        {
            var val_3;
            int val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            label_9:
            val_4 = Lean.Touch.LeanTouch.InactiveFingers.Count - 1;
            if((val_4 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = null;
            val_5 = null;
            Lean.Touch.LeanFinger val_2 = Lean.Touch.LeanTouch.InactiveFingers.Item[val_4];
            if(val_2.Index != index)
            {
                goto label_9;
            }
            
            return (int)val_4;
            label_4:
            val_4 = 0;
            return (int)val_4;
        }
        public LeanTouch()
        {
            this.TapThreshold = 0.5f;
            this.SwipeThreshold = 2.658456E+38f;
            this.ReferenceDpi = 200;
            UnityEngine.LayerMask val_1 = UnityEngine.LayerMask.op_Implicit(intVal:  -5);
            this.GuiLayers = val_1;
            this.RecordFingers = true;
            this.RecordThreshold = 5f;
            this.RecordLimit = 10f;
            this.SimulateMultiFingers = true;
            this.PinchTwistKey = 306;
        }
        private static LeanTouch()
        {
            Lean.Touch.LeanTouch.DefaultReferenceDpi = new System.Collections.Generic.List<Lean.Touch.LeanTouch>();
            Lean.Touch.LeanTouch.Fingers = new System.Collections.Generic.List<Lean.Touch.LeanFinger>(capacity:  10);
            Lean.Touch.LeanTouch.InactiveFingers = new System.Collections.Generic.List<Lean.Touch.LeanFinger>(capacity:  10);
            Lean.Touch.LeanTouch.highestMouseButton = 7;
            Lean.Touch.LeanTouch.tempRaycastResults = new System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>(capacity:  10);
            Lean.Touch.LeanTouch.filteredFingers = new System.Collections.Generic.List<Lean.Touch.LeanFinger>(capacity:  10);
        }
    
    }

}
