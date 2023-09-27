using UnityEngine;

namespace CodeStage.AntiCheat.Detectors
{
    public class InjectionDetector : ActDetectorBase
    {
        // Fields
        internal const string COMPONENT_NAME = "Injection Detector";
        internal const string FINAL_LOG_PREFIX = "[ACTk] Injection Detector: ";
        protected UnityEngine.Events.UnityAction<string> detectionActionWithArgument;
        private static int instancesInScene;
        private bool signaturesAreNotGenuine;
        private CodeStage.AntiCheat.Detectors.InjectionDetector.AllowedAssembly[] allowedAssemblies;
        private string[] hexTable;
        private static CodeStage.AntiCheat.Detectors.InjectionDetector <Instance>k__BackingField;
        
        // Properties
        public static CodeStage.AntiCheat.Detectors.InjectionDetector Instance { get; set; }
        private static CodeStage.AntiCheat.Detectors.InjectionDetector GetOrCreateInstance { get; }
        
        // Methods
        public static void StartDetection()
        {
            if((CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField) != 0)
            {
                    CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField.StartDetectionInternal(callback:  0, callbackWithArgument:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "[ACTk] Injection Detector: can\'t be started since it doesn\'t exists in scene or not yet initialized!");
        }
        public static void StartDetection(UnityEngine.Events.UnityAction callback)
        {
            CodeStage.AntiCheat.Detectors.InjectionDetector.GetOrCreateInstance.StartDetectionInternal(callback:  callback, callbackWithArgument:  0);
        }
        public static void StartDetection(UnityEngine.Events.UnityAction<string> callback)
        {
            CodeStage.AntiCheat.Detectors.InjectionDetector.GetOrCreateInstance.StartDetectionInternal(callback:  0, callbackWithArgument:  callback);
        }
        public static void StopDetection()
        {
            CodeStage.AntiCheat.Detectors.InjectionDetector val_7 = CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField;
            if(val_7 == 0)
            {
                    return;
            }
            
            val_7 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.InjectionDetector).__il2cppRuntimeField_1C8;
        }
        public static void Dispose()
        {
            CodeStage.AntiCheat.Detectors.InjectionDetector val_7 = CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField;
            if(val_7 == 0)
            {
                    return;
            }
            
            val_7 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.InjectionDetector).__il2cppRuntimeField_188;
        }
        public static CodeStage.AntiCheat.Detectors.InjectionDetector get_Instance()
        {
            return (CodeStage.AntiCheat.Detectors.InjectionDetector)CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField;
        }
        private static void set_Instance(CodeStage.AntiCheat.Detectors.InjectionDetector value)
        {
            CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField = value;
        }
        private static CodeStage.AntiCheat.Detectors.InjectionDetector get_GetOrCreateInstance()
        {
            CodeStage.AntiCheat.Detectors.InjectionDetector val_5 = CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField;
            if(val_5 != 0)
            {
                    return (CodeStage.AntiCheat.Detectors.InjectionDetector)CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField;
            }
            
            if(CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer == 0)
            {
                    UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  "Anti-Cheat Toolkit Detectors");
                CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer = val_3;
            }
            
            val_5 = val_3.AddComponent<CodeStage.AntiCheat.Detectors.InjectionDetector>();
            CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField = val_5;
            return (CodeStage.AntiCheat.Detectors.InjectionDetector)CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField;
        }
        private InjectionDetector()
        {
            mem[1152921526002620520] = 257;
            mem[1152921526002620522] = 1;
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void Awake()
        {
            int val_3 = CodeStage.AntiCheat.Detectors.InjectionDetector.instancesInScene;
            val_3 = val_3 + 1;
            CodeStage.AntiCheat.Detectors.InjectionDetector.instancesInScene = val_3;
            if((this.Init(instance:  CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField, detectorName:  "Injection Detector")) != false)
            {
                    CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField = this;
            }
            
            UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.InjectionDetector::OnLevelWasLoadedNew(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)));
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            int val_1 = CodeStage.AntiCheat.Detectors.InjectionDetector.instancesInScene;
            val_1 = val_1 - 1;
            CodeStage.AntiCheat.Detectors.InjectionDetector.instancesInScene = val_1;
        }
        private void OnLevelWasLoadedNew(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
        {
            this.OnLevelLoadedCallback();
        }
        private void OnLevelLoadedCallback()
        {
            if(CodeStage.AntiCheat.Detectors.InjectionDetector.instancesInScene <= 1)
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
            
                if((CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField) == this)
            {
                    return;
            }
            
            }
            
            this = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.InjectionDetector).__il2cppRuntimeField_188;
        }
        private void StartDetectionInternal(UnityEngine.Events.UnityAction callback, UnityEngine.Events.UnityAction<string> callbackWithArgument)
        {
            object val_6;
            string val_7;
            string val_2 = 0;
            if(true == 0)
            {
                goto label_1;
            }
            
            val_6 = "[ACTk] Injection Detector: already running!";
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
            
            UnityEngine.Debug.LogWarning(message:  "[ACTk] Injection Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", context:  this);
            goto label_10;
            label_5:
            val_6 = "[ACTk] Injection Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!";
            label_4:
            UnityEngine.Debug.LogWarning(message:  val_6, context:  this);
            return;
            label_6:
            if(true == 0)
            {
                goto label_13;
            }
            
            label_10:
            mem[1152921526003254856] = callback;
            this.detectionActionWithArgument = callbackWithArgument;
            mem[1152921526003254865] = 257;
            if(this.allowedAssemblies == null)
            {
                    this.LoadAndParseAllowedAssemblies();
            }
            
            if(this.signaturesAreNotGenuine == false)
            {
                goto label_15;
            }
            
            val_7 = "signatures";
            goto label_16;
            label_15:
            if((this.FindInjectionInCurrentAssemblies(cause: out  val_2)) == false)
            {
                goto label_17;
            }
            
            val_7 = val_2;
            label_16:
            this.OnCheatingDetected(cause:  val_7);
            return;
            label_17:
            System.AppDomain.CurrentDomain.add_AssemblyLoad(value:  new System.AssemblyLoadEventHandler(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.InjectionDetector::OnNewAssemblyLoaded(object sender, System.AssemblyLoadEventArgs args)));
            return;
            label_13:
            UnityEngine.Debug.LogWarning(message:  "[ACTk] Injection Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", context:  this);
            this.enabled = false;
        }
        protected override void StartDetectionAutomatically()
        {
            this.StartDetectionInternal(callback:  0, callbackWithArgument:  0);
        }
        protected override void PauseDetector()
        {
            mem[1152921526003540305] = 0;
            System.AppDomain.CurrentDomain.remove_AssemblyLoad(value:  new System.AssemblyLoadEventHandler(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.InjectionDetector::OnNewAssemblyLoaded(object sender, System.AssemblyLoadEventArgs args)));
        }
        protected override void ResumeDetector()
        {
            if((true == 0) && (this.detectionActionWithArgument == null))
            {
                    if(this.detectionActionWithArgument == null)
            {
                    return;
            }
            
            }
            
            mem[1152921526003672785] = 1;
            System.AppDomain.CurrentDomain.add_AssemblyLoad(value:  new System.AssemblyLoadEventHandler(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.InjectionDetector::OnNewAssemblyLoaded(object sender, System.AssemblyLoadEventArgs args)));
        }
        protected override void StopDetectionInternal()
        {
            if(true == 0)
            {
                    return;
            }
            
            System.AppDomain.CurrentDomain.remove_AssemblyLoad(value:  new System.AssemblyLoadEventHandler(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.InjectionDetector::OnNewAssemblyLoaded(object sender, System.AssemblyLoadEventArgs args)));
            mem[1152921526003805256] = 0;
            this.detectionActionWithArgument = 0;
            mem[1152921526003805265] = 0;
        }
        protected override void DisposeInternal()
        {
            UnityEngine.Object val_2 = this;
            this.DisposeInternal();
            if((CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField) != this)
            {
                    return;
            }
            
            CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField = 0;
        }
        private void OnCheatingDetected(string cause)
        {
            if(this.detectionActionWithArgument != null)
            {
                    this.detectionActionWithArgument.Invoke(arg0:  cause);
            }
            
            this.OnCheatingDetected();
        }
        private void OnNewAssemblyLoaded(object sender, System.AssemblyLoadEventArgs args)
        {
            if((this.AssemblyAllowed(ass:  args.LoadedAssembly)) != false)
            {
                    return;
            }
            
            this.OnCheatingDetected(cause:  args.LoadedAssembly);
        }
        private bool FindInjectionInCurrentAssemblies(out string cause)
        {
            var val_4;
            cause = 0;
            if(val_2.Length == 0)
            {
                goto label_3;
            }
            
            if(val_2.Length < 1)
            {
                goto label_4;
            }
            
            label_7:
            System.Reflection.Assembly val_5 = System.AppDomain.CurrentDomain.GetAssemblies()[0];
            if((this.AssemblyAllowed(ass:  val_5)) == false)
            {
                goto label_6;
            }
            
            if((0 + 1) < val_2.Length)
            {
                goto label_7;
            }
            
            label_4:
            val_4 = 0;
            return (bool)val_4;
            label_3:
            val_4 = 1;
            cause = "no assemblies";
            return (bool)val_4;
            label_6:
            cause = val_5;
            val_4 = 1;
            return (bool)val_4;
        }
        private bool AssemblyAllowed(System.Reflection.Assembly ass)
        {
            var val_5;
            var val_6;
            val_5 = 0;
            goto label_3;
            label_10:
            AllowedAssembly val_5 = this.allowedAssemblies[0];
            if((System.String.op_Equality(a:  this.allowedAssemblies[0x0][0].name, b:  ass.Name)) != false)
            {
                    if((System.Array.IndexOf<System.Int32>(array:  this.allowedAssemblies[0x0][0].hashes, value:  this.GetAssemblyHash(ass:  ass))) != 1)
            {
                goto label_8;
            }
            
            }
            
            val_5 = 1;
            label_3:
            if(val_5 < this.allowedAssemblies.Length)
            {
                goto label_10;
            }
            
            val_6 = 0;
            return (bool)val_6;
            label_8:
            val_6 = 1;
            return (bool)val_6;
        }
        private void LoadAndParseAllowedAssemblies()
        {
            System.IO.MemoryStream val_20;
            var val_21;
            UnityEngine.Object val_22;
            System.IO.BinaryReader val_23;
            var val_24;
            var val_25;
            AllowedAssembly val_26;
            System.String[] val_27;
            val_21 = this;
            val_22 = UnityEngine.Resources.Load(path:  "fndid", systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            if(val_22 != null)
            {
                    val_22 = 0;
            }
            
            if(val_22 == 0)
            {
                    this.signaturesAreNotGenuine = true;
                return;
            }
            
            string[] val_6 = new string[1];
            val_6[0] = ":";
            System.IO.MemoryStream val_8 = new System.IO.MemoryStream(buffer:  val_22.bytes);
            System.IO.BinaryReader val_9 = null;
            val_23 = val_9;
            val_9 = new System.IO.BinaryReader(input:  val_8);
            val_24 = val_23;
            val_25 = 0;
            this.allowedAssemblies = new AllowedAssembly[-76510544];
            goto label_16;
            label_31:
            val_26 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.EncryptDecrypt(value:  val_9, key:  "Elina").Split(separator:  val_6, options:  1);
            if(val_12.Length < 2)
            {
                goto label_21;
            }
            
            int val_13 = val_12.Length - 1;
            int[] val_14 = new int[0];
            var val_23 = 0;
            do
            {
                var val_16 = val_23 + 1;
                val_16 = val_16 - 1;
                val_23 = val_23 + 1;
                val_14[0] = System.Int32.Parse(s:  null);
            }
            while((val_16 + 2) != (val_12.Length & 4294967295));
            
            val_21 = val_21;
            InjectionDetector.AllowedAssembly val_19 = null;
            val_24 = 0;
            val_26 = val_19;
            val_19 = new InjectionDetector.AllowedAssembly();
            .name = val_26[0];
            .hashes = val_14;
            if((val_26 != null) && (val_26 == null))
            {
                    val_24 = 0;
            }
            
            if(val_25 >= this.allowedAssemblies.Length)
            {
                    val_24 = 0;
            }
            
            this.allowedAssemblies[0] = val_26;
            val_23 = val_23;
            val_25 = 1;
            label_16:
            if(val_25 < val_23)
            {
                goto label_31;
            }
            
            UnityEngine.Resources.UnloadAsset(assetToUnload:  val_22);
            val_27 = new string[256];
            this.hexTable = val_27;
            goto label_33;
            label_40:
            val_27 = this.hexTable;
            label_33:
            string val_21 = 0.ToString(format:  "x2");
            if(val_27 == null)
            {
                goto label_34;
            }
            
            if(val_21 != null)
            {
                goto label_35;
            }
            
            goto label_38;
            label_34:
            if(val_21 == null)
            {
                goto label_38;
            }
            
            label_35:
            label_38:
            val_20 = 0;
            val_27[val_20] = val_21;
            if(1 <= 255)
            {
                goto label_40;
            }
            
            return;
            label_21:
            this.signaturesAreNotGenuine = true;
            val_20 = val_8;
        }
        private int GetAssemblyHash(System.Reflection.Assembly ass)
        {
            System.Byte[] val_8;
            string val_9;
            var val_10;
            val_8 = ass.GetPublicKeyToken();
            val_9 = ass.Name;
            if(val_1.Length >= 8)
            {
                    val_9 = val_9 + this.PublicKeyTokenToString(bytes:  val_8)(this.PublicKeyTokenToString(bytes:  val_8));
            }
            
            int val_5 = val_9.Length;
            if(val_5 >= 1)
            {
                    do
            {
                char val_7 = 0 + val_9.Chars[0];
                val_8 = 0 + 1;
                val_7 = val_7 + (val_7 << 10);
            }
            while(val_5 != val_8);
            
                val_10 = 0;
                return 0;
            }
            
            val_10 = 0;
            return 0;
        }
        private string PublicKeyTokenToString(byte[] bytes)
        {
            var val_3 = 0;
            do
            {
                val_3 = val_3 + 1;
            }
            while(val_3 != 8);
            
            return (string)"" + this.hexTable[null];
        }
    
    }

}
