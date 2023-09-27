using UnityEngine;
public class SpriteScaler : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject LeftChar;
    private UnityEngine.GameObject RightChar;
    
    // Methods
    private void Start()
    {
        float val_11;
        var val_12;
        if((double)UnityEngine.Camera.main.aspect >= 1.7)
        {
            goto label_2;
        }
        
        if(UnityEngine.Camera.main.aspect >= 1.5f)
        {
            goto label_4;
        }
        
        UnityEngine.Debug.Log(message:  "4:3");
        val_11 = 0.12f;
        this.LeftChar.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_12 = this.RightChar.transform;
        goto label_10;
        label_2:
        UnityEngine.Debug.Log(message:  "16:9");
        this.LeftChar.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_12 = this.RightChar.transform;
        val_12.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return;
        label_4:
        UnityEngine.Debug.Log(message:  "3:2");
        val_11 = 0.12f;
        this.LeftChar.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_12 = this.RightChar.transform;
        label_10:
        val_12.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public SpriteScaler()
    {
    
    }

}
