using UnityEngine;
public class SwipeSceneSelect : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector2 startPos;
    private UnityEngine.Vector2 endPos;
    private UnityEngine.Vector2 diff;
    public float sensitivity;
    private float distance;
    private bool isCallOnce;
    private int nameCounter;
    public UnityEngine.GameObject iconsHolder;
    public UnityEngine.GameObject imageNew;
    public SwipeSceneSelect.SwipeDirection swipeDir;
    public static SwipeSceneSelect instance;
    public UnityEngine.GameObject ikaSelection;
    public static bool touchBoolIka;
    private bool touchBool;
    
    // Methods
    private void Start()
    {
        this.touchBool = false;
        SwipeSceneSelect.touchBoolIka = false;
        this.imageNew.SetActive(value:  false);
        this.nameCounter = 0;
        SwipeSceneSelect.instance = this;
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "CharacterStatus");
    }
    private System.Collections.IEnumerator AnimationAtStart()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new SwipeSceneSelect.<AnimationAtStart>d__16();
    }
    private System.Collections.IEnumerator CharacterStatus()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new SwipeSceneSelect.<CharacterStatus>d__17();
    }
    private void Update()
    {
        float val_13;
        float val_14;
        float val_15;
        float val_16;
        if(SwipeSceneSelect.touchBoolIka == false)
        {
                return;
        }
        
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            val_13 = val_2.x;
            val_14 = val_13;
            val_15 = val_2.y;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_2.z});
            this.startPos = val_3;
            mem[1152921528840805244] = val_3.y;
            this.touchBool = true;
        }
        
        if(((UnityEngine.Input.GetMouseButton(button:  0)) != false) && (this.touchBool != false))
        {
                UnityEngine.Vector3 val_5 = UnityEngine.Input.mousePosition;
            val_16 = val_5.y;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_16, z = val_5.z});
            this.endPos = val_6;
            mem[1152921528840805252] = val_6.y;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = this.startPos});
            this.diff = val_7;
            mem[1152921528840805260] = val_7.y;
            val_7.x = val_7.x * val_7.x;
            val_7.y = val_7.y * val_7.y;
            val_7.x = val_7.x + val_7.y;
            if(val_7.x >= _TYPE_MAX_)
        {
                val_13 = val_7.x;
        }
        
            this.distance = val_13;
            val_15 = (float)UnityEngine.Screen.width;
            val_14 = val_15 / this.sensitivity;
            if(val_13 < 0)
        {
                return;
        }
        
            if(this.isCallOnce != true)
        {
                this.FindSwipeDirection();
        }
        
            this.touchBool = false;
        }
        
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
        {
                return;
        }
        
        SwipeSceneSelect.touchBoolIka = false;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.zero;
        this.diff = val_10;
        mem[1152921528840805260] = val_10.y;
        this.endPos = val_10;
        mem[1152921528840805252] = val_10.y;
        this.startPos = val_10;
        mem[1152921528840805244] = val_10.y;
        this.isCallOnce = false;
        this.swipeDir = 0;
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  this.DelayTouch());
    }
    private System.Collections.IEnumerator DelayTouch()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new SwipeSceneSelect.<DelayTouch>d__19();
    }
    private void FindSwipeDirection()
    {
        UnityEngine.Vector2 val_10;
        var val_11;
        this.isCallOnce = true;
        val_10 = this.diff;
        val_10 = this.diff;
        float val_10 = System.Math.Abs(S1 / val_10);
        if((val_10 < 0) && (val_10 > 1f))
        {
                UnityEngine.GameObject.FindWithTag(tag:  "ikaLeftRight").GetComponent<SelectStageController>().rightSwipe();
            int val_11 = this.nameCounter;
            val_11 = val_11 - 1;
            this.nameCounter = (val_11 >= 0) ? (val_11) : 11;
            val_11 = 2;
        }
        else
        {
                if((val_10 < 0) && (val_10 < 0))
        {
                UnityEngine.GameObject.FindWithTag(tag:  "ikaLeftRight").GetComponent<SelectStageController>().leftSwipe();
            this.nameCounter = ((this.nameCounter + 1) >= 12) ? 0 : (this.nameCounter + 1);
            val_11 = 1;
        }
        else
        {
                if((val_10 > 1f) && (val_10 > 1f))
        {
                val_11 = 3;
        }
        
        }
        
        }
        
        this.swipeDir = (val_10 > 1f) ? 4 : 0;
    }
    public SwipeSceneSelect()
    {
        this.sensitivity = 5f;
    }

}
