using UnityEngine;
public class WhirlpoolPlayer : MonoBehaviour
{
    // Fields
    public static bool whirlpoolFlag;
    public static bool isForDefense;
    private bool flag;
    public UnityEngine.AudioClip whirlpoolVortexShort;
    public UnityEngine.AudioClip whirlpoolVotexLarge;
    private UnityEngine.GameObject particleEffect;
    
    // Methods
    public void Start()
    {
        UnityEngine.GameObject val_3 = this.transform.GetChild(index:  0).gameObject;
        this.particleEffect = val_3;
        val_3.GetComponent<UnityEngine.MeshRenderer>().sortingOrder = 10;
        UnityEngine.Color val_7 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.gameObject.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
        WhirlpoolPlayer.whirlpoolFlag = false;
        WhirlpoolPlayer.isForDefense = false;
        this.flag = true;
        this.gameObject.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.InvokeRepeating(methodName:  "WhirlpoolFlagUpdater", time:  0.05f, repeatRate:  0.05f);
    }
    private void WhirlpoolFlagUpdater()
    {
        if(WhirlpoolPlayer.whirlpoolFlag == false)
        {
                return;
        }
        
        if(this.flag == false)
        {
                return;
        }
        
        if(this.isActiveAndEnabled == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(methodName:  "whirlpool");
        this.flag = false;
    }
    private System.Collections.IEnumerator whirlpool()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new WhirlpoolPlayer.<whirlpool>d__8();
    }
    public WhirlpoolPlayer()
    {
    
    }

}
