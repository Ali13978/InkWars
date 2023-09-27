using UnityEngine;
public class MovingAwardText : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI start;
    private TMPro.TextMeshProUGUI end;
    private int amount;
    private float gapBetweenText;
    private float AnimationTime;
    private float WaitingTimeTime;
    private System.Collections.Generic.List<UnityEngine.GameObject> LearpPoints;
    private MovingAwardType type;
    private TMPro.TextMeshProUGUI text;
    private UnityEngine.Transform parent;
    private System.Collections.Generic.List<TMPro.TextMeshProUGUI> textList;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    private void Awake()
    {
    
    }
    public void StartAnim()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "Animate");
    }
    private System.Collections.IEnumerator Animate()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new MovingAwardText.<Animate>d__15();
    }
    public MovingAwardText()
    {
        this.WaitingTimeTime = 5f;
    }

}
