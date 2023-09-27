using UnityEngine;
public class TurnSinglePlayerElementsOff : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject ScoreText;
    public UnityEngine.GameObject ScoreBorder;
    public UnityEngine.GameObject SpecialBallHolder;
    private bool moved;
    
    // Methods
    private void Awake()
    {
        null = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
                UnityEngine.Vector3 val_2 = this.SpecialBallHolder.transform.position;
            UnityEngine.Vector3 val_4 = this.SpecialBallHolder.transform.position;
            UnityEngine.Vector3 val_6 = this.SpecialBallHolder.transform.position;
            float val_7 = val_4.y + (-500f);
            iTween.MoveTo(target:  this.SpecialBallHolder, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, time:  1f);
        }
        
        this.Invoke(methodName:  "Start1", time:  0.1f);
    }
    private void Start1()
    {
        this.ScoreBorder.SetActive(value:  false);
    }
    private void Update()
    {
        if(this.moved != false)
        {
                return;
        }
        
        this.moved = true;
    }
    public TurnSinglePlayerElementsOff()
    {
    
    }

}
