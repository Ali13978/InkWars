using UnityEngine;
public class ButtonBounce : MonoBehaviour
{
    // Fields
    public bool IsTutorialButton;
    public float startDelay;
    private bool bouncing;
    private bool startBounce;
    private UnityEngine.Vector3 MeToBe;
    private UnityEngine.Vector3 MeWas;
    private float changeTimer;
    public UnityEngine.GameObject NextNode;
    public float waitToStart;
    private bool grow1;
    private bool grow2;
    private bool grow3;
    private bool shrink1;
    private bool shrink2;
    private bool nextBounce;
    private bool initialSetupFinished;
    private bool RightHandSideCharacter;
    
    // Properties
    public bool isRightSideCharacter { get; }
    
    // Methods
    public bool get_isRightSideCharacter()
    {
        return (bool)this.RightHandSideCharacter;
    }
    private void Start()
    {
        UnityEngine.Vector3 val_2 = this.transform.localScale;
        this.MeToBe = val_2;
        mem[1152921526025834792] = val_2.y;
        mem[1152921526025834796] = val_2.z;
        UnityEngine.Vector3 val_4 = this.transform.localScale;
        this.MeWas = val_4;
        mem[1152921526025834804] = val_4.y;
        mem[1152921526025834808] = val_4.z;
        if((UnityEngine.Object.op_Implicit(exists:  this.gameObject.GetComponent<UnityEngine.UI.Button>())) != false)
        {
                this.gameObject.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void ButtonBounce::TaskOnClick()));
        }
        
        if(this.IsTutorialButton == true)
        {
                return;
        }
        
        if(this.RightHandSideCharacter != false)
        {
            
        }
        else
        {
            
        }
        
        this.MeToBe = 0;
        mem[1152921526025834796] = 0;
    }
    private void OnEnable()
    {
        if(this.IsTutorialButton == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.delayStart(seconds:  this.startDelay));
    }
    private System.Collections.IEnumerator delayStart(float seconds)
    {
        ButtonBounce.<delayStart>d__21 val_1 = new ButtonBounce.<delayStart>d__21();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .seconds = seconds;
        return (System.Collections.IEnumerator)val_1;
    }
    public void TaskOnClick()
    {
        if(this.IsTutorialButton == false)
        {
                return;
        }
        
        DemoManager.Instance.finishTutorial();
    }
    private void Update()
    {
        if(this.waitToStart <= 0f)
        {
                if(this.nextBounce == false)
        {
            goto label_2;
        }
        
        }
        
        if((this.waitToStart <= 0f) || (this.bouncing == false))
        {
            goto label_11;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.waitToStart - val_1;
        this.waitToStart = val_1;
        goto label_11;
        label_2:
        this.nextBounce = true;
        if(this.NextNode != 0)
        {
                ButtonBounce val_3 = this.NextNode.GetComponent<ButtonBounce>();
            if(val_3.startBounce != true)
        {
                val_3.bouncing = true;
            val_3.startBounce = true;
        }
        
        }
        
        label_11:
        if(this.bouncing != false)
        {
                this.FixMySize();
            return;
        }
        
        if((System.String.op_Equality(a:  this.gameObject.name, b:  "Left")) != true)
        {
                if((System.String.op_Equality(a:  this.gameObject.name, b:  "Right")) != true)
        {
                if(this.IsTutorialButton == false)
        {
                return;
        }
        
        }
        
        }
        
        if(this.initialSetupFinished == false)
        {
                return;
        }
        
        if((this.GetComponent<UnityEngine.UI.Button>().interactable) == false)
        {
                return;
        }
        
        float val_13 = UnityEngine.Camera.main.aspect;
        float val_20 = 3f;
        val_20 = UnityEngine.Time.time * val_20;
        val_20 = val_20 * 0.2f;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.one;
        float val_21 = 1f;
        val_21 = (UnityEngine.Mathf.PingPong(t:  val_20, length:  0.2f)) + val_21;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(d:  val_21, a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        this.gameObject.transform.localScale = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
    }
    public void TurnOffInteractable()
    {
        goto label_2;
        label_7:
        this = this.NextNode.GetComponent<ButtonBounce>();
        label_2:
        this.GetComponent<UnityEngine.UI.Button>().interactable = false;
        if(val_1.NextNode != 0)
        {
            goto label_7;
        }
    
    }
    public void StartBounce()
    {
        if(this.startBounce != false)
        {
                return;
        }
        
        this.bouncing = true;
        this.startBounce = true;
    }
    private void FixMySize()
    {
        UnityEngine.Vector3 val_18;
        float val_21;
        float val_22;
        float val_23;
        if(this.grow1 != false)
        {
                float val_1 = UnityEngine.Time.deltaTime;
            val_1 = val_1 * 5f;
            val_1 = this.changeTimer + val_1;
            this.changeTimer = val_1;
            val_18 = this.MeToBe;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.LerpUnclamped(a:  new UnityEngine.Vector3() {x = this.MeWas, y = V14.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = val_18, y = V11.16B, z = this.changeTimer}, t:  this.changeTimer);
            val_21 = val_3.x;
            val_22 = val_3.z;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_21, y = val_3.y, z = val_22};
            val_23 = this.changeTimer;
            if(val_23 >= 1f)
        {
                this.grow1 = false;
            this.shrink1 = true;
            mem[1152921526026828888] = UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished;
            this.changeTimer = 0f;
            this.MeWas = this.MeToBe;
            if(this.RightHandSideCharacter != false)
        {
                val_23 = -0.7f;
        }
        else
        {
                val_23 = 0.7f;
        }
        
            this.MeToBe = 0;
            mem[1152921526026828876] = 0;
        }
        
        }
        
        if(this.shrink1 != false)
        {
                float val_4 = UnityEngine.Time.deltaTime;
            val_4 = val_4 * 5f;
            val_4 = this.changeTimer + val_4;
            this.changeTimer = val_4;
            val_18 = this.MeToBe;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.LerpUnclamped(a:  new UnityEngine.Vector3() {x = this.MeWas, y = V14.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = val_18, y = V11.16B, z = this.changeTimer}, t:  this.changeTimer);
            val_21 = val_6.x;
            val_22 = val_6.z;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_21, y = val_6.y, z = val_22};
            val_23 = this.changeTimer;
            if(val_23 >= 1f)
        {
                this.shrink1 = false;
            this.grow2 = true;
            mem[1152921526026828888] = UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished;
            this.changeTimer = 0f;
            this.MeWas = this.MeToBe;
            if(this.RightHandSideCharacter != false)
        {
                val_23 = -1.2f;
        }
        else
        {
                val_23 = 1.2f;
        }
        
            this.MeToBe = 0;
            mem[1152921526026828876] = 0;
        }
        
        }
        
        if(this.grow2 != false)
        {
                float val_7 = UnityEngine.Time.deltaTime;
            val_7 = val_7 * 5f;
            val_7 = this.changeTimer + val_7;
            this.changeTimer = val_7;
            val_18 = this.MeToBe;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.LerpUnclamped(a:  new UnityEngine.Vector3() {x = this.MeWas, y = V14.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = val_18, y = V11.16B, z = this.changeTimer}, t:  this.changeTimer);
            val_21 = val_9.x;
            val_22 = val_9.z;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_21, y = val_9.y, z = val_22};
            val_23 = this.changeTimer;
            if(val_23 >= 1f)
        {
                this.grow2 = false;
            this.shrink2 = true;
            mem[1152921526026828888] = UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished;
            this.changeTimer = 0f;
            this.MeWas = this.MeToBe;
            if(this.RightHandSideCharacter != false)
        {
                val_23 = -0.9f;
        }
        else
        {
                val_23 = 0.9f;
        }
        
            this.MeToBe = 0;
            mem[1152921526026828876] = 0;
        }
        
        }
        
        if(this.shrink2 != false)
        {
                float val_10 = UnityEngine.Time.deltaTime;
            val_10 = val_10 * 5f;
            val_10 = this.changeTimer + val_10;
            this.changeTimer = val_10;
            val_18 = this.MeToBe;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.LerpUnclamped(a:  new UnityEngine.Vector3() {x = this.MeWas, y = V14.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = val_18, y = V11.16B, z = this.changeTimer}, t:  this.changeTimer);
            val_21 = val_12.x;
            val_22 = val_12.z;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_21, y = val_12.y, z = val_22};
            val_23 = this.changeTimer;
            if(val_23 >= 1f)
        {
                this.shrink2 = false;
            this.grow3 = true;
            mem[1152921526026828888] = UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished;
            this.changeTimer = 0f;
            this.MeWas = this.MeToBe;
            if(this.RightHandSideCharacter != false)
        {
                val_23 = -1f;
        }
        else
        {
                val_23 = 1f;
        }
        
            this.MeToBe = 0;
            mem[1152921526026828876] = 0;
        }
        
        }
        
        if(this.grow3 == false)
        {
                return;
        }
        
        float val_13 = UnityEngine.Time.deltaTime;
        val_13 = val_13 * 5f;
        val_13 = this.changeTimer + val_13;
        this.changeTimer = val_13;
        val_18 = this.MeToBe;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.LerpUnclamped(a:  new UnityEngine.Vector3() {x = this.MeWas, y = V14.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = val_18, y = V11.16B, z = this.changeTimer}, t:  this.changeTimer);
        val_21 = val_15.x;
        val_22 = val_15.z;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_21, y = val_15.y, z = val_22};
        if(this.changeTimer < 1f)
        {
                return;
        }
        
        this.grow3 = false;
        this.changeTimer = 0f;
        this.bouncing = false;
        this.initialSetupFinished = true;
    }
    public ButtonBounce()
    {
        this.startDelay = 7f;
        this.grow1 = true;
    }

}
