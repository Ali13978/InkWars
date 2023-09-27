using UnityEngine;

namespace CodeStage.AntiCheat.Detectors
{
    public class ObscuredCheatingDetector : ActDetectorBase
    {
        // Fields
        internal const string COMPONENT_NAME = "Obscured Cheating Detector";
        internal const string FINAL_LOG_PREFIX = "[ACTk] Obscured Cheating Detector: ";
        private static int instancesInScene;
        public float floatEpsilon;
        public float vector2Epsilon;
        public float vector3Epsilon;
        public float quaternionEpsilon;
        private static CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector <Instance>k__BackingField;
        
        // Properties
        public static CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector Instance { get; set; }
        private static CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector GetOrCreateInstance { get; }
        internal static bool IsRunning { get; }
        
        // Methods
        public static void StartDetection()
        {
            if((CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField) != 0)
            {
                    CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField.StartDetectionInternal(callback:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "[ACTk] Obscured Cheating Detector: can\'t be started since it doesn\'t exists in scene or not yet initialized!");
        }
        public static void StartDetection(UnityEngine.Events.UnityAction callback)
        {
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.GetOrCreateInstance.StartDetectionInternal(callback:  callback);
        }
        public static void StopDetection()
        {
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector val_7 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField;
            if(val_7 == 0)
            {
                    return;
            }
            
            val_7 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector).__il2cppRuntimeField_1C8;
        }
        public static void Dispose()
        {
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector val_7 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField;
            if(val_7 == 0)
            {
                    return;
            }
            
            val_7 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector).__il2cppRuntimeField_188;
        }
        public static CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector get_Instance()
        {
            return (CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector)CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField;
        }
        private static void set_Instance(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector value)
        {
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField = value;
        }
        private static CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector get_GetOrCreateInstance()
        {
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector val_5 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField;
            if(val_5 != 0)
            {
                    return (CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector)CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField;
            }
            
            if(CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer == 0)
            {
                    UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  "Anti-Cheat Toolkit Detectors");
                CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer = val_3;
            }
            
            val_5 = val_3.AddComponent<CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector>();
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField = val_5;
            return (CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector)CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField;
        }
        internal static bool get_IsRunning()
        {
            var val_2;
            if((CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField) != null)
            {
                    var val_1 = ((CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField + 49) != 0) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        private ObscuredCheatingDetector()
        {
            mem[1152921526007020792] = 257;
            this.floatEpsilon = ;
            this.vector2Epsilon = ;
            this.vector3Epsilon = 0.1f;
            this.quaternionEpsilon = 0.1f;
            mem[1152921526007020794] = 1;
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void Awake()
        {
            int val_3 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.instancesInScene;
            val_3 = val_3 + 1;
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.instancesInScene = val_3;
            if((this.Init(instance:  CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField, detectorName:  "Obscured Cheating Detector")) != false)
            {
                    CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField = this;
            }
            
            UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector::OnLevelWasLoadedNew(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)));
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            int val_1 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.instancesInScene;
            val_1 = val_1 - 1;
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.instancesInScene = val_1;
        }
        private void OnLevelWasLoadedNew(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
        {
            this.OnLevelLoadedCallback();
        }
        private void OnLevelLoadedCallback()
        {
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.instancesInScene <= 1)
            {
                    if(W9 != 0)
            {
                    return;
            }
            
            }
            else
            {
                    if(W9 != 0)
            {
                    return;
            }
            
                if((CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField) == this)
            {
                    return;
            }
            
            }
            
            this = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector).__il2cppRuntimeField_188;
        }
        private void StartDetectionInternal(UnityEngine.Events.UnityAction callback)
        {
            object val_2;
            if(true == 0)
            {
                goto label_1;
            }
            
            val_2 = "[ACTk] Obscured Cheating Detector: already running!";
            goto label_4;
            label_1:
            if(this.enabled == false)
            {
                goto label_5;
            }
            
            if(callback == null)
            {
                goto label_6;
            }
            
            if(true == 0)
            {
                goto label_10;
            }
            
            UnityEngine.Debug.LogWarning(message:  "[ACTk] Obscured Cheating Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", context:  this);
            goto label_10;
            label_5:
            val_2 = "[ACTk] Obscured Cheating Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!";
            label_4:
            UnityEngine.Debug.LogWarning(message:  val_2, context:  this);
            return;
            label_6:
            if(true == 0)
            {
                goto label_13;
            }
            
            label_10:
            mem[1152921526007603912] = callback;
            mem[1152921526007603921] = 257;
            return;
            label_13:
            UnityEngine.Debug.LogWarning(message:  "[ACTk] Obscured Cheating Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", context:  this);
            this.enabled = false;
        }
        protected override void StartDetectionAutomatically()
        {
            this.StartDetectionInternal(callback:  0);
        }
        protected override void PauseDetector()
        {
            mem[1152921526007832017] = 0;
        }
        protected override void ResumeDetector()
        {
            if(X8 == 0)
            {
                    if(W8 == 0)
            {
                    return;
            }
            
            }
            
            mem[1152921526007944017] = 1;
        }
        protected override void StopDetectionInternal()
        {
            if(W8 == 0)
            {
                    return;
            }
            
            mem[1152921526008056008] = 0;
            mem[1152921526008056017] = 0;
        }
        protected override void DisposeInternal()
        {
            UnityEngine.Object val_2 = this;
            this.DisposeInternal();
            if((CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField) != this)
            {
                    return;
            }
            
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField = 0;
        }
    
    }

}
