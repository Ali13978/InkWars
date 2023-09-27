using UnityEngine;
public class RedCrossForDemoAnimation : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector3 currentPos;
    public UnityEngine.AudioClip incorrectActionClip;
    
    // Methods
    private void Start()
    {
        var val_11;
        var val_12;
        var val_13;
        float val_14;
        UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.incorrectActionClip, volume:  1f);
        UnityEngine.Vector3 val_5 = this.gameObject.transform.position;
        this.currentPos = val_5;
        mem[1152921526201894044] = val_5.y;
        mem[1152921526201894048] = val_5.z;
        val_11 = null;
        val_11 = null;
        object[] val_8 = new object[12];
        val_8[0] = "x";
        UnityEngine.Vector3 val_11 = this.currentPos;
        if(DataStructs.UserDataDictionary.Settings.FlipNegateX == 1)
        {
                val_12 = 1152921504623566848;
            val_11 = val_11 + 0.2f;
            val_8[1] = val_11;
            val_8[2] = "y";
            val_13 = null;
            val_14 = val_11 + 0.2f;
        }
        else
        {
                val_12 = 1152921504623566848;
            val_11 = val_11 + (-0.2f);
            val_8[1] = val_11;
            val_8[2] = "y";
            val_13 = null;
            val_14 = val_11 + 0.2f;
        }
        
        val_8[3] = val_14;
        val_8[4] = "time";
        val_8[5] = 1f;
        val_8[6] = "easetype";
        val_8[7] = 21;
        val_8[8] = "oncompletetarget";
        val_8[9] = this.gameObject;
        val_8[10] = "oncomplete";
        val_8[11] = "destroyCross";
        iTween.MoveTo(target:  this.gameObject, args:  iTween.Hash(args:  val_8));
    }
    private void destroyCross()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public RedCrossForDemoAnimation()
    {
    
    }

}
