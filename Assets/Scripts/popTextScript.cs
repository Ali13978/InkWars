using UnityEngine;
public class popTextScript : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject popBlob;
    public UnityEngine.GameObject popBlobImage;
    public UnityEngine.GameObject popBlobText;
    
    // Methods
    private void Start()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_8 = null;
        val_8 = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
                val_9 = 1152921505077932032;
            val_10 = null;
            val_10 = null;
            val_11 = this.gameObject.GetComponent<UnityEngine.UI.Text>();
            if(LineControllerP2.receiveDamageFlag != true)
        {
                val_9 = 1152921505075642368;
        }
        
            val_12 = null;
        }
        else
        {
                val_11 = this.gameObject.GetComponent<UnityEngine.UI.Text>();
            val_13 = static_value_032DD328;
            val_13 = static_value_032DD328;
        }
        
        string val_7 = "pop\nX" + (static_value_032DD328 + 184) + 16.ToString()((static_value_032DD328 + 184) + 16.ToString()) + "!"("!");
        this.shakeText();
    }
    private void shakeText()
    {
        this.Invoke(methodName:  "pushBlob", time:  0.1f);
        object[] val_1 = new object[6];
        val_1[0] = "x";
        val_1[1] = 0.2f;
        val_1[2] = "y";
        val_1[3] = 0.2f;
        val_1[4] = "time";
        val_1[5] = 0.7f;
        iTween.ShakePosition(target:  this.popBlobText, args:  iTween.Hash(args:  val_1));
    }
    private void pushBlob()
    {
        object[] val_1 = new object[12];
        val_1[0] = "x";
        val_1[1] = 1.5f;
        val_1[2] = "y";
        val_1[3] = 1.5f;
        val_1[4] = "time";
        val_1[5] = 0.2f;
        val_1[6] = "easeType";
        val_1[7] = 27;
        val_1[8] = "oncompletetarget";
        val_1[9] = this.gameObject;
        val_1[10] = "oncomplete";
        val_1[11] = "makeFade";
        iTween.ScaleTo(target:  this.popBlobImage, args:  iTween.Hash(args:  val_1));
    }
    private void makeFade()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "MakeBothFade");
    }
    private System.Collections.IEnumerator MakeBothFade()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new popTextScript.<MakeBothFade>d__7();
    }
    private void DestroyBlob()
    {
        UnityEngine.Object.Destroy(obj:  this.popBlob);
    }
    public popTextScript()
    {
    
    }

}
