using UnityEngine;

namespace CodeStage.AntiCheat.Detectors
{
    public abstract class ActDetectorBase : MonoBehaviour
    {
        // Fields
        protected const string CONTAINER_NAME = "Anti-Cheat Toolkit Detectors";
        protected const string MENU_PATH = "Code Stage/Anti-Cheat Toolkit/";
        protected const string GAME_OBJECT_MENU_PATH = "GameObject/Create Other/Code Stage/Anti-Cheat Toolkit/";
        protected static UnityEngine.GameObject detectorsContainer;
        public bool autoStart;
        public bool keepAlive;
        public bool autoDispose;
        protected UnityEngine.Events.UnityEvent detectionEvent;
        protected UnityEngine.Events.UnityAction detectionAction;
        protected bool detectionEventHasListener;
        protected bool isRunning;
        protected bool started;
        
        // Methods
        private void Start()
        {
            UnityEngine.Object val_6 = 0;
            if(CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer == val_6)
            {
                    val_6 = "Anti-Cheat Toolkit Detectors";
                if((System.String.op_Equality(a:  this.gameObject.name, b:  val_6)) != false)
            {
                    val_6 = 0;
                CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer = this.gameObject;
            }
            
            }
            
            if(this.autoStart == false)
            {
                    return;
            }
            
            if(this.started == false)
            {
                goto typeof(CodeStage.AntiCheat.Detectors.ActDetectorBase).__il2cppRuntimeField_1B8;
            }
        
        }
        private void OnEnable()
        {
            if(this.started == false)
            {
                    return;
            }
            
            if((this.detectionEventHasListener != true) && (this.detectionAction == null))
            {
                    if((this & 1) == 0)
            {
                    return;
            }
            
            }
        
        }
        private void OnDisable()
        {
            if(this.started == false)
            {
                    return;
            }
            
            goto typeof(CodeStage.AntiCheat.Detectors.ActDetectorBase).__il2cppRuntimeField_1D8;
        }
        private void OnApplicationQuit()
        {
            goto typeof(CodeStage.AntiCheat.Detectors.ActDetectorBase).__il2cppRuntimeField_188;
        }
        protected virtual void OnDestroy()
        {
            if(this.transform.childCount != 0)
            {
                goto label_2;
            }
            
            T[] val_3 = this.GetComponentsInChildren<UnityEngine.Component>();
            if(val_3.Length <= 2)
            {
                goto label_4;
            }
            
            label_2:
            if((System.String.op_Equality(a:  this.name, b:  "Anti-Cheat Toolkit Detectors")) == false)
            {
                    return;
            }
            
            T[] val_6 = this.GetComponentsInChildren<CodeStage.AntiCheat.Detectors.ActDetectorBase>();
            if(val_6.Length > 1)
            {
                    return;
            }
            
            label_4:
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        protected virtual bool Init(CodeStage.AntiCheat.Detectors.ActDetectorBase instance, string detectorName)
        {
            UnityEngine.Object val_7;
            UnityEngine.Object val_8;
            var val_9;
            val_8 = this;
            if(instance != 0)
            {
                    if((instance != this) && (instance.keepAlive != false))
            {
                    val_7 = this.gameObject;
                UnityEngine.Debug.LogWarning(message:  "[ACTk] " + this.name + ": self-destroying, other instance already exists & only one instance allowed!"(": self-destroying, other instance already exists & only one instance allowed!"), context:  val_7);
                UnityEngine.Object.Destroy(obj:  this);
                val_9 = 0;
                return (bool)val_9;
            }
            
            }
            
            val_8 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  val_8);
            val_9 = 1;
            return (bool)val_9;
        }
        protected virtual void DisposeInternal()
        {
            UnityEngine.Object.Destroy(obj:  this);
        }
        protected virtual bool DetectorHasAdditionalCallbacks()
        {
            return false;
        }
        internal virtual void OnCheatingDetected()
        {
            var val_1;
            if(this.detectionAction != null)
            {
                    val_1 = 0;
                this.detectionAction.Invoke();
            }
            
            if(this.detectionEventHasListener != false)
            {
                    val_1 = 0;
                this.detectionEvent.Invoke();
            }
            
            if(this.autoDispose != false)
            {
                
            }
        
        }
        protected abstract void StartDetectionAutomatically(); // 0
        protected abstract void StopDetectionInternal(); // 0
        protected abstract void PauseDetector(); // 0
        protected abstract void ResumeDetector(); // 0
        protected ActDetectorBase()
        {
            this.autoStart = true;
            this.keepAlive = true;
            this.autoDispose = true;
        }
    
    }

}
