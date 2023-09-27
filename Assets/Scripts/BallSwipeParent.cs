using UnityEngine;
public abstract class BallSwipeParent : MonoBehaviour
{
    // Fields
    public UnityEngine.Sprite[] specialBallSprites;
    public UnityEngine.GameObject[] playerBalls;
    public UnityEngine.GameObject swiper;
    
    // Methods
    public void EquipSuperBubble(InkWars.Model.BubbleTypes bubbleType)
    {
        var val_2 = (bubbleType == 8) ? 2 : ((bubbleType == 9) ? 1 : 0);
        this.playerBalls[1].gameObject.GetComponent<UnityEngine.UI.Image>().sprite = this.specialBallSprites[val_2];
        this.playerBalls[1].gameObject.tag = this.specialBallSprites[val_2].name;
        bool val_9 = System.String.op_Inequality(a:  this.playerBalls[1].gameObject.tag, b:  "Iron_Ball");
        UnityEngine.Animator val_11 = this.playerBalls[1].gameObject.GetComponent<UnityEngine.Animator>();
        if(val_11 == null)
        {
            goto label_23;
        }
        
        if(val_9 == false)
        {
            goto label_24;
        }
        
        label_34:
        val_11.enabled = true;
        this.playerBalls[1].gameObject.GetComponent<UnityEngine.Animator>().Play(stateName:  this.playerBalls[1].gameObject.tag + "_Anim");
        return;
        label_23:
        if(val_9 == true)
        {
            goto label_34;
        }
        
        label_24:
        val_11.enabled = false;
    }
    protected BallSwipeParent()
    {
    
    }

}
