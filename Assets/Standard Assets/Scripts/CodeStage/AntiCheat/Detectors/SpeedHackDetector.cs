using UnityEngine;

namespace CodeStage.AntiCheat.Detectors
{
    public class SpeedHackDetector : ActDetectorBase
    {
        // Fields
        internal const string COMPONENT_NAME = "Speed Hack Detector";
        internal const string FINAL_LOG_PREFIX = "[ACTk] Speed Hack Detector: ";
        private const long TICKS_PER_SECOND = 10000000;
        private const int THRESHOLD = 5000000;
        private static int instancesInScene;
        public float interval;
        public byte maxFalsePositives;
        public int coolDown;
        private byte currentFalsePositives;
        private int currentCooldownShots;
        private long ticksOnStart;
        private long vulnerableTicksOnStart;
        private long prevTicks;
        private long prevIntervalTicks;
        private static CodeStage.AntiCheat.Detectors.SpeedHackDetector <Instance>k__BackingField;
        
        // Properties
        public static CodeStage.AntiCheat.Detectors.SpeedHackDetector Instance { get; set; }
        private static CodeStage.AntiCheat.Detectors.SpeedHackDetector GetOrCreateInstance { get; }
        
        // Methods
        public static void StartDetection()
        {
            float val_2;
            byte val_3;
            if((CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField) == 0)
            {
                goto label_4;
            }
            
            if((CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField) == null)
            {
                goto label_6;
            }
            
            val_2 = mem[CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField + 52];
            val_2 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField.interval;
            goto label_10;
            label_4:
            UnityEngine.Debug.LogError(message:  "[ACTk] Speed Hack Detector: can\'t be started since it doesn\'t exists in scene or not yet initialized!");
            return;
            label_6:
            val_2 = mem[CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField + 52];
            val_2 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField.interval;
            label_10:
            if((CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField) != null)
            {
                    val_3 = mem[CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField + 56];
                val_3 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField.maxFalsePositives;
            }
            else
            {
                    val_3 = mem[CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField + 56];
                val_3 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField.maxFalsePositives;
            }
            
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField.StartDetectionInternal(callback:  0, checkInterval:  val_2, falsePositives:  val_3, shotsTillCooldown:  CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField.coolDown);
        }
        public static void StartDetection(UnityEngine.Events.UnityAction callback)
        {
            CodeStage.AntiCheat.Detectors.SpeedHackDetector val_1 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.GetOrCreateInstance;
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.StartDetection(callback:  callback, interval:  val_1.interval);
        }
        public static void StartDetection(UnityEngine.Events.UnityAction callback, float interval)
        {
            CodeStage.AntiCheat.Detectors.SpeedHackDetector val_1 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.GetOrCreateInstance;
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.StartDetection(callback:  callback, interval:  interval, maxFalsePositives:  val_1.maxFalsePositives);
        }
        public static void StartDetection(UnityEngine.Events.UnityAction callback, float interval, byte maxFalsePositives)
        {
            CodeStage.AntiCheat.Detectors.SpeedHackDetector val_1 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.GetOrCreateInstance;
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.StartDetection(callback:  callback, interval:  interval, maxFalsePositives:  maxFalsePositives, coolDown:  val_1.coolDown);
        }
        public static void StartDetection(UnityEngine.Events.UnityAction callback, float interval, byte maxFalsePositives, int coolDown)
        {
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.GetOrCreateInstance.StartDetectionInternal(callback:  callback, checkInterval:  interval, falsePositives:  maxFalsePositives, shotsTillCooldown:  coolDown);
        }
        public static void StopDetection()
        {
            CodeStage.AntiCheat.Detectors.SpeedHackDetector val_7 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField;
            if(val_7 == 0)
            {
                    return;
            }
            
            val_7 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.SpeedHackDetector).__il2cppRuntimeField_1C8;
        }
        public static void Dispose()
        {
            CodeStage.AntiCheat.Detectors.SpeedHackDetector val_7 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField;
            if(val_7 == 0)
            {
                    return;
            }
            
            val_7 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.SpeedHackDetector).__il2cppRuntimeField_188;
        }
        public static CodeStage.AntiCheat.Detectors.SpeedHackDetector get_Instance()
        {
            return (CodeStage.AntiCheat.Detectors.SpeedHackDetector)CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField;
        }
        private static void set_Instance(CodeStage.AntiCheat.Detectors.SpeedHackDetector value)
        {
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField = value;
        }
        private static CodeStage.AntiCheat.Detectors.SpeedHackDetector get_GetOrCreateInstance()
        {
            CodeStage.AntiCheat.Detectors.SpeedHackDetector val_5 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField;
            if(val_5 != 0)
            {
                    return (CodeStage.AntiCheat.Detectors.SpeedHackDetector)CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField;
            }
            
            if(CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer == 0)
            {
                    UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  "Anti-Cheat Toolkit Detectors");
                CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer = val_3;
            }
            
            val_5 = val_3.AddComponent<CodeStage.AntiCheat.Detectors.SpeedHackDetector>();
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField = val_5;
            return (CodeStage.AntiCheat.Detectors.SpeedHackDetector)CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField;
        }
        private SpeedHackDetector()
        {
            this.interval = 1f;
            this.maxFalsePositives = 3;
            this.coolDown = 30;
            mem[1152921526009491416] = 257;
            mem[1152921526009491418] = 1;
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void Awake()
        {
            int val_3 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.instancesInScene;
            val_3 = val_3 + 1;
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.instancesInScene = val_3;
            if((this.Init(instance:  CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField, detectorName:  "Speed Hack Detector")) != false)
            {
                    CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField = this;
            }
            
            UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.SpeedHackDetector::OnLevelWasLoadedNew(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)));
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            int val_1 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.instancesInScene;
            val_1 = val_1 - 1;
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.instancesInScene = val_1;
        }
        private void OnLevelWasLoadedNew(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
        {
            this.OnLevelLoadedCallback();
        }
        private void OnLevelLoadedCallback()
        {
            if(CodeStage.AntiCheat.Detectors.SpeedHackDetector.instancesInScene <= 1)
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
            
                if((CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField) == this)
            {
                    return;
            }
            
            }
            
            this = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.SpeedHackDetector).__il2cppRuntimeField_188;
        }
        private void OnApplicationPause(bool pause)
        {
            if(pause != false)
            {
                    return;
            }
            
            this.ResetStartTicks();
        }
        private void Update()
        {
            if(true == 0)
            {
                    return;
            }
            
            System.DateTime val_1 = System.DateTime.UtcNow;
            long val_2 = val_1.dateData.Ticks;
            long val_6 = this.prevTicks;
            val_6 = val_2 - val_6;
            if(val_6 >= 10000001)
            {
                goto label_4;
            }
            
            float val_7 = this.interval;
            long val_8 = this.prevIntervalTicks;
            this.prevTicks = val_2;
            val_7 = val_7 * (1E+07f);
            val_8 = val_2 - val_8;
            if(val_8 < (long)val_7)
            {
                    return;
            }
            
            int val_3 = System.Environment.TickCount;
            long val_5 = 10000 - (this.vulnerableTicksOnStart + val_2);
            val_5 = val_5 + this.ticksOnStart;
            byte val_10 = this.currentFalsePositives;
            if(System.Math.Abs((float)val_5) <= 5000000f)
            {
                goto label_8;
            }
            
            val_10 = val_10 + 1;
            this.currentFalsePositives = val_10;
            if(this.maxFalsePositives >= val_10)
            {
                goto label_9;
            }
            
            this.OnCheatingDetected();
            goto label_15;
            label_4:
            this.ResetStartTicks();
            return;
            label_8:
            if((val_10 == 0) || (this.coolDown < 1))
            {
                goto label_15;
            }
            
            int val_11 = this.currentCooldownShots;
            val_11 = val_11 + 1;
            this.currentCooldownShots = val_11;
            if(val_11 < this.coolDown)
            {
                goto label_15;
            }
            
            this.currentFalsePositives = 0;
            goto label_15;
            label_9:
            this.currentCooldownShots = 0;
            this.ResetStartTicks();
            label_15:
            this.prevIntervalTicks = val_2;
        }
        private void StartDetectionInternal(UnityEngine.Events.UnityAction callback, float checkInterval, byte falsePositives, int shotsTillCooldown)
        {
            object val_2;
            if(true == 0)
            {
                goto label_1;
            }
            
            val_2 = "[ACTk] Speed Hack Detector: already running!";
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
            
            UnityEngine.Debug.LogWarning(message:  "[ACTk] Speed Hack Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", context:  this);
            goto label_10;
            label_5:
            val_2 = "[ACTk] Speed Hack Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!";
            label_4:
            UnityEngine.Debug.LogWarning(message:  val_2, context:  this);
            return;
            label_6:
            if(true == 0)
            {
                goto label_13;
            }
            
            label_10:
            mem[1152921526010298472] = callback;
            this.interval = checkInterval;
            this.maxFalsePositives = falsePositives;
            this.coolDown = shotsTillCooldown;
            this.ResetStartTicks();
            this.currentFalsePositives = 0;
            this.currentCooldownShots = 0;
            mem[1152921526010298481] = 257;
            return;
            label_13:
            UnityEngine.Debug.LogWarning(message:  "[ACTk] Speed Hack Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", context:  this);
            this.enabled = false;
        }
        protected override void StartDetectionAutomatically()
        {
            this.StartDetectionInternal(callback:  0, checkInterval:  this.interval, falsePositives:  this.maxFalsePositives, shotsTillCooldown:  this.coolDown);
        }
        protected override void PauseDetector()
        {
            mem[1152921526010526577] = 0;
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
            
            mem[1152921526010638577] = 1;
        }
        protected override void StopDetectionInternal()
        {
            if(W8 == 0)
            {
                    return;
            }
            
            mem[1152921526010750568] = 0;
            mem[1152921526010750577] = 0;
        }
        protected override void DisposeInternal()
        {
            UnityEngine.Object val_2 = this;
            this.DisposeInternal();
            if((CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField) != this)
            {
                    return;
            }
            
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField = 0;
        }
        private void ResetStartTicks()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            this.ticksOnStart = val_1.dateData.Ticks;
            int val_3 = System.Environment.TickCount;
            this.vulnerableTicksOnStart = 10000;
            this.prevTicks = this.ticksOnStart;
            this.prevIntervalTicks = this.ticksOnStart;
        }
    
    }

}
