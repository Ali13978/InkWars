using UnityEngine;
public class IconGlowEffect : MonoBehaviour
{
    // Fields
    public UnityEngine.Color color;
    
    // Methods
    private void Update()
    {
        float val_3 = UnityEngine.Time.time;
        val_3 = val_3 + val_3;
        float val_4 = UnityEngine.Mathf.PingPong(t:  val_3, length:  1f);
        UnityEngine.Color val_5 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.gameObject.GetComponent<UnityEngine.UI.Outline>().effectColor = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
    }
    public IconGlowEffect()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.color = val_1;
        mem[1152921528418258268] = val_1.g;
        mem[1152921528418258272] = val_1.b;
        mem[1152921528418258276] = val_1.a;
    }

}
