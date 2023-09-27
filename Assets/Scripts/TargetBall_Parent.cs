using UnityEngine;
public class TargetBall_Parent : MonoBehaviour
{
    // Fields
    internal bool shouldHavePoppedEnemyBubble;
    internal bool shouldHaveSavedOwnBubble;
    internal bool bridgeLink;
    internal bool crossLink;
    internal int currentPops;
    internal bool pushedNewBubble;
    
    // Methods
    public void SetPredictions(UnityEngine.GameObject[] theirRingOuter, UnityEngine.GameObject[] theirRingMiddle, UnityEngine.GameObject[] theirRingInner, UnityEngine.GameObject[] ourRingOuter, UnityEngine.GameObject[] ourRingMiddle, UnityEngine.GameObject[] ourRingInner, int ballEntry)
    {
        var val_15;
        var val_16;
        UnityEngine.GameObject val_17;
        var val_18;
        var val_19;
        var val_20;
        val_15 = ourRingInner;
        val_16 = ourRingMiddle;
        val_17 = ourRingOuter;
        val_18 = theirRingInner;
        this.shouldHavePoppedEnemyBubble = false;
        this.shouldHaveSavedOwnBubble = false;
        if(ballEntry == 0)
        {
                return;
        }
        
        string val_2 = this.gameObject.tag;
        bool val_3 = System.String.op_Equality(a:  val_2, b:  "Rainbow_Bubble");
        if((ballEntry - 3) < 2)
        {
            goto label_6;
        }
        
        if(ballEntry == 2)
        {
            goto label_4;
        }
        
        val_15 = val_16;
        val_18 = theirRingMiddle;
        if(ballEntry == 5)
        {
            goto label_6;
        }
        
        val_15 = val_17;
        val_18 = theirRingOuter;
        goto label_6;
        label_4:
        val_15 = val_16;
        val_18 = theirRingMiddle;
        label_6:
        if(ballEntry > 3)
        {
            goto label_7;
        }
        
        val_16 = 1152921504858337280;
        val_19 = 0;
        goto label_8;
        label_14:
        val_17 = val_18[0];
        if(val_17 != 0)
        {
            goto label_12;
        }
        
        val_19 = 1;
        label_8:
        if(val_19 < theirRingMiddle.Length)
        {
            goto label_14;
        }
        
        goto label_17;
        label_7:
        label_21:
        val_16 = theirRingMiddle.Length - 1;
        if((val_16 & 2147483648) != 0)
        {
            goto label_17;
        }
        
        val_18[theirRingMiddle.Length - 1][40] = (val_18[theirRingMiddle.Length - 1][40]) - 8;
        if(1152921508657404416 == 0)
        {
            goto label_21;
        }
        
        if(val_3 == true)
        {
            goto label_36;
        }
        
        if(null != null)
        {
            goto label_38;
        }
        
        goto label_25;
        label_17:
        if(val_3 == true)
        {
                return;
        }
        
        if(ballEntry > 3)
        {
            goto label_27;
        }
        
        val_18 = 0;
        goto label_28;
        label_34:
        if(val_15[0] != 0)
        {
            goto label_32;
        }
        
        val_18 = 1;
        label_28:
        if(val_18 < ourRingMiddle.Length)
        {
            goto label_34;
        }
        
        return;
        label_12:
        if(val_3 == true)
        {
            goto label_36;
        }
        
        val_15 = mem[theirRingMiddle[0x0] + 32];
        val_15 = theirRingMiddle[0x0] + 32;
        if(val_15 != 0)
        {
            goto label_38;
        }
        
        label_25:
        label_38:
        if((System.String.op_Equality(a:  val_15.tag, b:  val_2)) == false)
        {
                return;
        }
        
        label_36:
        this.shouldHavePoppedEnemyBubble = true;
        return;
        label_27:
        int val_16 = ourRingMiddle.Length;
        do
        {
            val_16 = val_16 - 1;
            if((val_16 & 2147483648) != 0)
        {
                return;
        }
        
            val_15[val_16 - 1][40] = (val_15[val_16 - 1][40]) - 8;
        }
        while(1152921508657404416 == 0);
        
        if(null != null)
        {
            goto label_50;
        }
        
        goto label_48;
        label_32:
        val_20 = mem[ourRingMiddle[0x0] + 32];
        val_20 = ourRingMiddle[0x0] + 32;
        if(val_20 != 0)
        {
            goto label_50;
        }
        
        label_48:
        label_50:
        if((System.String.op_Inequality(a:  val_20.tag, b:  val_2)) == false)
        {
                return;
        }
        
        this.shouldHaveSavedOwnBubble = true;
    }
    public void SendMessage(InkWars.Model.Player playerId, bool isOwnGrid)
    {
        var val_16;
        PlayerMessage val_17;
        Techniques val_18;
        InkWars.Model.Player val_19;
        var val_20;
        HitComboType val_21;
        if(playerId == 1)
        {
                if(NetworkManager_Custom.IsNetwork == true)
        {
                return;
        }
        
        }
        
        if(isOwnGrid == false)
        {
            goto label_3;
        }
        
        if(this.pushedNewBubble == false)
        {
            goto label_4;
        }
        
        val_16 = InkWars.Model.Model_Events.Instance;
        val_17 = new PlayerMessage();
        val_18 = 1;
        label_16:
        val_19 = playerId;
        goto label_5;
        label_3:
        if((this.shouldHavePoppedEnemyBubble == false) || (this.currentPops != 0))
        {
            goto label_7;
        }
        
        InkWars.Model.Model_Events.Instance.Event_Message(message:  new PlayerMessage(PlayerID:  playerId, HitCount:  0, ComboType:  0, ComboTechnique:  7));
        val_16 = InkWars.Model.Model_Events.Instance;
        val_17 = new PlayerMessage();
        val_19 = 1 - playerId;
        val_18 = 2;
        goto label_9;
        label_7:
        if(this.currentPops < 3)
        {
                return;
        }
        
        val_16 = InkWars.Model.Model_Events.Instance;
        val_17 = new PlayerMessage();
        val_19 = playerId;
        val_20 = this.currentPops;
        val_21 = (this.bridgeLink == false) ? ((this.crossLink == true) ? (1 + 1) : 1) : ((this.crossLink == true) ? (3 + 1) : 3);
        val_18 = 0;
        goto label_11;
        label_4:
        if(this.currentPops < 1)
        {
                return;
        }
        
        if(this.shouldHaveSavedOwnBubble == false)
        {
            goto label_16;
        }
        
        new PlayerMessage() = new PlayerMessage(PlayerID:  playerId, HitCount:  0, ComboType:  0, ComboTechnique:  8);
        InkWars.Model.Model_Events.Instance.Event_Message(message:  new PlayerMessage());
        val_16 = InkWars.Model.Model_Events.Instance;
        val_17 = new PlayerMessage();
        val_19 = 1 - playerId;
        val_18 = 3;
        label_9:
        label_5:
        val_20 = 0;
        val_21 = 0;
        label_11:
        val_17 = new PlayerMessage(PlayerID:  val_19, HitCount:  0, ComboType:  val_21, ComboTechnique:  val_18);
        val_16.Event_Message(message:  new PlayerMessage());
    }
    public TargetBall_Parent()
    {
    
    }

}
