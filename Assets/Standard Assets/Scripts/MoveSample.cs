using UnityEngine;
public class MoveSample : MonoBehaviour
{
    // Methods
    private void Start()
    {
        object[] val_2 = new object[8];
        val_2[0] = "x";
        val_2[1] = 2;
        val_2[2] = "easeType";
        val_2[3] = "easeInOutExpo";
        val_2[4] = "loopType";
        val_2[5] = "pingPong";
        val_2[6] = "delay";
        val_2[7] = -0.1;
        iTween.MoveBy(target:  this.gameObject, args:  iTween.Hash(args:  val_2));
    }
    public MoveSample()
    {
    
    }

}
