using UnityEngine;
public class swipepenl : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector2 startPos;
    private UnityEngine.Vector2 endPos;
    private UnityEngine.Vector2 diff;
    public float sensitivity;
    private float distance;
    private bool isCallOnce;
    public swipepenl.SwipeDirection swipeDir;
    public static swipepenl instance;
    
    // Methods
    private void Start()
    {
        swipepenl.instance = this;
    }
    private void Update()
    {
        float val_11;
        float val_12;
        float val_13;
        float val_14;
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            val_11 = val_2.x;
            val_12 = val_11;
            val_13 = val_2.y;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_2.z});
            this.startPos = val_3;
            mem[1152921528840074780] = val_3.y;
        }
        
        if((UnityEngine.Input.GetMouseButton(button:  0)) != false)
        {
                UnityEngine.Vector3 val_5 = UnityEngine.Input.mousePosition;
            val_14 = val_5.y;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_14, z = val_5.z});
            this.endPos = val_6;
            mem[1152921528840074788] = val_6.y;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = this.startPos});
            this.diff = val_7;
            mem[1152921528840074796] = val_7.y;
            val_7.x = val_7.x * val_7.x;
            val_7.y = val_7.y * val_7.y;
            val_7.x = val_7.x + val_7.y;
            if(val_7.x >= _TYPE_MAX_)
        {
                val_11 = val_7.x;
        }
        
            this.distance = val_11;
            val_13 = (float)UnityEngine.Screen.width;
            val_12 = val_13 / this.sensitivity;
            if(val_11 < 0)
        {
                return;
        }
        
            if(this.isCallOnce != true)
        {
                this.FindSwipeDirection();
        }
        
        }
        
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
        {
                return;
        }
        
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.zero;
        this.diff = val_10;
        mem[1152921528840074796] = val_10.y;
        this.endPos = val_10;
        mem[1152921528840074788] = val_10.y;
        this.startPos = val_10;
        mem[1152921528840074780] = val_10.y;
        this.isCallOnce = false;
        this.swipeDir = 0;
    }
    private void FindSwipeDirection()
    {
        UnityEngine.Vector2 val_5;
        var val_6;
        this.isCallOnce = true;
        val_5 = this.diff;
        val_5 = this.diff;
        float val_5 = System.Math.Abs(S1 / val_5);
        if((val_5 < 0) && (val_5 > 1f))
        {
                val_6 = 2;
        }
        else
        {
                if((val_5 < 0) && (val_5 < 0))
        {
                UnityEngine.GameObject.FindWithTag(tag:  "instrunction").GetComponent<mainTitle>().nextButton();
            val_6 = 1;
        }
        else
        {
                if((val_5 > 1f) && (val_5 > 1f))
        {
                val_6 = 3;
        }
        
        }
        
        }
        
        this.swipeDir = (val_5 > 1f) ? 4 : 0;
    }
    public swipepenl()
    {
        this.sensitivity = 5f;
    }

}
