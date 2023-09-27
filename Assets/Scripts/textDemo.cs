using UnityEngine;
public class textDemo : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject blowingText;
    private UnityEngine.Transform target;
    public float speed;
    
    // Methods
    private void Start()
    {
        UnityEngine.GameObject val_1 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "BlowingText");
        this.blowingText = val_1;
        val_1.SetActive(value:  false);
        this.blowingText.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if(UnityEngine.Camera.main.aspect < 0)
        {
                UnityEngine.Vector2 val_10 = this.blowingText.gameObject.GetComponent<UnityEngine.RectTransform>().anchoredPosition;
            UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  -89f, y:  val_10.y);
            this.blowingText.gameObject.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
        }
        
        this.target = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "Target").transform;
        this.Invoke(methodName:  "activeThis", time:  3.2f);
        this.Invoke(methodName:  "textInstantiate", time:  3.5f);
        this.Invoke(methodName:  "scaleText", time:  3.2f);
        this.Invoke(methodName:  "scaleDown", time:  4.2f);
    }
    public void textInstantiate()
    {
        object[] val_1 = new object[6];
        val_1[0] = "x";
        UnityEngine.Vector3 val_3 = this.target.transform.position;
        val_1[1] = val_3.x;
        val_1[2] = "y";
        UnityEngine.Vector3 val_5 = this.target.transform.position;
        val_1[3] = val_5.y;
        val_1[4] = "time";
        val_1[5] = 1;
        iTween.MoveTo(target:  this.blowingText, args:  iTween.Hash(args:  val_1));
    }
    public void activeThis()
    {
        this.blowingText.gameObject.SetActive(value:  true);
    }
    public void scaleText()
    {
        object[] val_1 = new object[6];
        val_1[0] = "x";
        val_1[1] = 1.7;
        val_1[2] = "y";
        val_1[3] = 1.7;
        val_1[4] = "time";
        val_1[5] = 0.5;
        iTween.ScaleTo(target:  this.blowingText, args:  iTween.Hash(args:  val_1));
    }
    public void scaleDown()
    {
        object[] val_1 = new object[6];
        val_1[0] = "x";
        val_1[1] = 1.2;
        val_1[2] = "y";
        val_1[3] = 1.2;
        val_1[4] = "time";
        val_1[5] = -0.1;
        iTween.ScaleTo(target:  this.blowingText, args:  iTween.Hash(args:  val_1));
    }
    public textDemo()
    {
    
    }

}
