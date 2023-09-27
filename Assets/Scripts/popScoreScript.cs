using UnityEngine;
public class popScoreScript : MonoBehaviour
{
    // Fields
    private string textSign;
    public int scoreCounter;
    
    // Methods
    private void Start()
    {
        UnityEngine.Object val_18;
        var val_19;
        var val_20;
        val_18 = this;
        val_19 = null;
        val_19 = null;
        if(Character_GlobalInfo.gameMode == 4)
        {
                UnityEngine.Color val_3 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            this.gameObject.GetComponent<UnityEngine.UI.Text>().color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        }
        
        UnityEngine.Color val_6 = this.gameObject.GetComponent<UnityEngine.UI.Text>().color;
        UnityEngine.Vector3 val_9 = this.gameObject.GetComponent<UnityEngine.RectTransform>().position;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        UnityEngine.Vector3 val_13 = this.gameObject.GetComponent<UnityEngine.RectTransform>().localScale;
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        val_20 = null;
        val_20 = null;
        if(Character_GlobalInfo.gameMode == 3)
        {
                val_18 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  val_18);
            return;
        }
        
        UnityEngine.Coroutine val_17 = this.StartCoroutine(routine:  this.AnimateText(pos:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, size:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y}));
    }
    private System.Collections.IEnumerator AnimateText(UnityEngine.Vector2 pos, UnityEngine.Vector2 size)
    {
        popScoreScript.<AnimateText>d__3 val_1 = new popScoreScript.<AnimateText>d__3();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .pos = pos;
            mem[1152921526342759468] = pos.y;
        }
        else
        {
                mem[32] = this;
            mem[40] = pos.x;
            mem[1152921526342759468] = pos.y;
        }
        
        .size = size;
        mem[1152921526342759476] = size.y;
        return (System.Collections.IEnumerator)val_1;
    }
    public popScoreScript()
    {
    
    }

}
