using UnityEngine;
public class bossBattlePingPong : MonoBehaviour
{
    // Methods
    private void Start()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "PingPong");
    }
    private void Ping()
    {
        float val_3 = UnityEngine.Time.time;
        val_3 = val_3 * 20f;
        float val_4 = UnityEngine.Mathf.PingPong(t:  val_3, length:  1f);
        float val_5 = UnityEngine.Time.time;
        val_5 = val_5 * 20f;
        float val_6 = UnityEngine.Mathf.PingPong(t:  val_5, length:  1f);
        float val_7 = UnityEngine.Time.time;
        val_7 = val_7 * 20f;
        float val_8 = UnityEngine.Mathf.PingPong(t:  val_7, length:  1f);
        UnityEngine.Color val_9 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a};
    }
    private System.Collections.IEnumerator PingPong()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new bossBattlePingPong.<PingPong>d__2();
    }
    public bossBattlePingPong()
    {
    
    }

}
