using UnityEngine;
public class LobbyHint : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.GameObject> m_hints;
    private UnityEngine.GameObject speachBubble;
    private int m_precentage;
    private int m_waitingTime;
    private UnityEngine.Vector3 actualSize;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Vector3 val_2 = this.speachBubble.GetComponent<UnityEngine.RectTransform>().localScale;
        this.actualSize = val_2;
        mem[1152921528645198020] = val_2.y;
        mem[1152921528645198024] = val_2.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.speachBubble.GetComponent<UnityEngine.RectTransform>().localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    private void OnEnable()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "DoAnimations");
    }
    private void OnDisable()
    {
        var val_5 = null;
        if((LobbyHint.<>c.<>9__7_0) == null)
        {
            goto label_3;
        }
        
        label_14:
        this.m_hints.ForEach(action:  LobbyHint.<>c.<>9__7_0);
        this.speachBubble.gameObject.SetActive(value:  false);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.speachBubble.GetComponent<UnityEngine.RectTransform>().localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        return;
        label_3:
        LobbyHint.<>c.<>9__7_0 = new System.Action<UnityEngine.GameObject>(object:  LobbyHint.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LobbyHint.<>c::<OnDisable>b__7_0(UnityEngine.GameObject x));
        if(this.m_hints != null)
        {
            goto label_14;
        }
        
        goto label_14;
    }
    private System.Collections.IEnumerator DoAnimations()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LobbyHint.<DoAnimations>d__8();
    }
    public LobbyHint()
    {
        this.m_precentage = 51;
        this.m_waitingTime = 3;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        this.actualSize = val_1;
        mem[1152921528645731108] = val_1.y;
        mem[1152921528645731112] = val_1.z;
    }

}
