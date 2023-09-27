using UnityEngine;
public class Swipe_CharacterSelection_Adventure : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector2 startPos;
    private UnityEngine.Vector2 endPos;
    private UnityEngine.Vector2 diff;
    public float sensitivity;
    private float distance;
    private bool isCallOnce;
    public Swipe_CharacterSelection_Adventure.SwipeDirection swipeDir;
    public static Swipe_CharacterSelection_Adventure instance;
    public static bool touchBoolClan;
    private bool touchBool;
    public Scene_CharacterSelection_Adventure sceneScript;
    
    // Methods
    private void Start()
    {
        this.touchBool = false;
        Swipe_CharacterSelection_Adventure.touchBoolClan = false;
        Swipe_CharacterSelection_Adventure.instance = this;
    }
    private void Update()
    {
        float val_13;
        float val_14;
        float val_15;
        float val_16;
        if(Swipe_CharacterSelection_Adventure.touchBoolClan == false)
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
            mem[1152921528832158748] = val_3.y;
            this.touchBool = true;
        }
        
        if(((UnityEngine.Input.GetMouseButton(button:  0)) != false) && (this.touchBool != false))
        {
                UnityEngine.Vector3 val_5 = UnityEngine.Input.mousePosition;
            val_16 = val_5.y;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_16, z = val_5.z});
            this.endPos = val_6;
            mem[1152921528832158756] = val_6.y;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = this.startPos});
            this.diff = val_7;
            mem[1152921528832158764] = val_7.y;
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
        
        Swipe_CharacterSelection_Adventure.touchBoolClan = false;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.zero;
        this.diff = val_10;
        mem[1152921528832158764] = val_10.y;
        this.endPos = val_10;
        mem[1152921528832158756] = val_10.y;
        this.startPos = val_10;
        mem[1152921528832158748] = val_10.y;
        this.isCallOnce = false;
        this.swipeDir = 0;
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  this.DelayTouch());
    }
    private System.Collections.IEnumerator DelayTouch()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new Swipe_CharacterSelection_Adventure.<DelayTouch>d__14();
    }
    private void FindSwipeDirection()
    {
        UnityEngine.Vector2 val_3;
        var val_4;
        this.isCallOnce = true;
        val_3 = this.diff;
        val_3 = this.diff;
        float val_3 = System.Math.Abs(S1 / val_3);
        if((val_3 < 0) && (val_3 > 1f))
        {
                this.sceneScript.rightSwipe();
            val_4 = 2;
        }
        else
        {
                if((val_3 < 0) && (val_3 < 0))
        {
                this.sceneScript.leftSwipe();
            val_4 = 1;
        }
        else
        {
                if((val_3 > 1f) && (val_3 > 1f))
        {
                val_4 = 3;
        }
        
        }
        
        }
        
        this.swipeDir = (val_3 > 1f) ? 4 : 0;
    }
    public Swipe_CharacterSelection_Adventure()
    {
        this.sensitivity = 5f;
    }

}
