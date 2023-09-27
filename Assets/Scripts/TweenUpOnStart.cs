using UnityEngine;
public class TweenUpOnStart : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector3 WhereToTweenTo;
    private UnityEngine.Vector3 WhereToTweenToTablet;
    private float TweenTime;
    
    // Methods
    private void Start()
    {
        float val_5;
        UnityEngine.GameObject val_6;
        UnityEngine.GameObject val_3 = this.gameObject;
        if((double)UnityEngine.Camera.main.aspect < 1.7)
        {
                val_5 = this.TweenTime;
            val_6 = val_3;
        }
        else
        {
                val_6 = val_3;
        }
        
        iTween.MoveTo(target:  val_6, position:  new UnityEngine.Vector3() {x = this.WhereToTweenTo, y = V10.16B, z = (double)UnityEngine.Camera.main.aspect}, time:  this.TweenTime);
    }
    public TweenUpOnStart()
    {
        this.WhereToTweenTo = 0;
        mem[1152921528845774224] = 0;
        this.WhereToTweenToTablet = 0;
        mem[1152921528845774236] = 0;
        this.TweenTime = 4f;
    }

}
