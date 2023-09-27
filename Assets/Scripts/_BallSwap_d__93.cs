using UnityEngine;
private sealed class DemoManager.<BallSwap>d__93 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DemoManager <>4__this;
    public UnityEngine.Vector2 pos1;
    public UnityEngine.Vector2 pos2;
    public UnityEngine.Vector2 size1;
    public UnityEngine.Vector2 size2;
    private float <startTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DemoManager.<BallSwap>d__93(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_41;
        float val_42;
        InteractiveTutorialManager val_43;
        float val_44;
        float val_45;
        var val_46;
        var val_47;
        int val_48;
        val_41 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<startTime>5__2 = 0f;
        this.<>1__state = 0;
        val_42 = 0f;
        if((this.<>4__this) != null)
        {
            goto label_5;
        }
        
        goto label_4;
        label_1:
        val_42 = this.<startTime>5__2;
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_5;
        }
        
        label_4:
        label_5:
        UnityEngine.GameObject val_41 = this.<>4__this.demoLineController.playerBallsSwipe[0];
        if(val_42 <= 1.2f)
        {
            goto label_10;
        }
        
        val_43 = this.<>4__this.demoLineController;
        if((this.<>4__this.demoLineController) != null)
        {
            goto label_11;
        }
        
        val_43 = this.<>4__this.demoLineController;
        if(val_43 == null)
        {
            goto label_12;
        }
        
        label_11:
        this.<>4__this.demoLineController.playerBallsSwipe[0] = this.<>4__this.demoLineController.playerBallsSwipe[1].gameObject;
        this.<>4__this.demoLineController.playerBallsSwipe[1] = val_41.gameObject.gameObject;
        UnityEngine.Color val_5 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.<>4__this.tapHere.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
        val_41 = this.<>4__this.tapHere.transform.GetChild(index:  0).GetComponent<UnityEngine.UI.Image>();
        UnityEngine.Color val_9 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_44 = val_9.r;
        val_45 = val_9.b;
        val_41.color = new UnityEngine.Color() {r = val_44, g = val_9.g, b = val_45, a = val_9.a};
        if((this.<>4__this.swipeCounter) == 1)
        {
            goto label_32;
        }
        
        if((this.<>4__this.swipeCounter) != 0)
        {
            goto label_33;
        }
        
        this.<>4__this.tapHere.transform.GetChild(index:  1).gameObject.SetActive(value:  false);
        val_46 = this.<>4__this.tapHere.transform;
        val_47 = 2;
        goto label_40;
        label_2:
        val_48 = 0;
        return (bool)val_48;
        label_10:
        UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos1, b:  this.pos2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
        val_41.transform.position = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos2, b:  this.pos1, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos1, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
        this.<>4__this.demoLineController.playerBallsSwipe[1].transform.position = new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z};
        UnityEngine.Vector2 val_27 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size1, b:  this.size2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y});
        this.<>4__this.demoLineController.playerBallsSwipe[0].transform.localScale = new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z};
        UnityEngine.Vector2 val_32 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size2, b:  this.size1, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size1, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_33 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_32.x, y = val_32.y});
        val_44 = val_33.x;
        val_45 = val_33.z;
        this.<>4__this.demoLineController.playerBallsSwipe[1].transform.localScale = new UnityEngine.Vector3() {x = val_44, y = val_33.y, z = val_45};
        float val_46 = this.<startTime>5__2;
        val_46 = val_46 + 0.2f;
        this.<startTime>5__2 = val_46;
        val_48 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_48;
        return (bool)val_48;
        label_32:
        this.<>4__this.tapHere.transform.GetChild(index:  2).gameObject.SetActive(value:  false);
        val_46 = this.<>4__this.tapHere.transform;
        val_47 = 3;
        label_40:
        val_41 = val_46.GetChild(index:  3).gameObject;
        val_41.SetActive(value:  true);
        label_33:
        int val_47 = this.<>4__this.swipeCounter;
        val_48 = 0;
        val_47 = val_47 + 1;
        this.<>4__this.swipeCounter = val_47;
        return (bool)val_48;
        label_12:
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
