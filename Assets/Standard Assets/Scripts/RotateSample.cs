using UnityEngine;
public class RotateSample : MonoBehaviour
{
    // Methods
    private void Start()
    {
        object[] val_2 = new object[8];
        val_2[0] = "x";
        val_2[1] = 0.25;
        val_2[2] = "easeType";
        val_2[3] = "easeInOutBack";
        val_2[4] = "loopType";
        val_2[5] = "pingPong";
        val_2[6] = "delay";
        val_2[7] = -0.4;
        iTween.RotateBy(target:  this.gameObject, args:  iTween.Hash(args:  val_2));
    }
    public RotateSample()
    {
    
    }

}
