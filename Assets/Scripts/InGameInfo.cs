using UnityEngine;
public class InGameInfo
{
    // Methods
    public int GetPlayerBallCount(PlayerId pid)
    {
        var val_7;
        var val_8;
        UnityEngine.GameObject[] val_9;
        var val_10;
        val_7 = pid;
        if(val_7 == 1)
        {
            goto label_1;
        }
        
        if(val_7 != 0)
        {
            goto label_2;
        }
        
        val_8 = null;
        val_8 = null;
        int val_1 = GetBallCountInLine(ringArray:  InstanceAnimator.playerOuterRingBalls, length:  17);
        val_7 = val_1;
        int val_2 = val_1.GetBallCountInLine(ringArray:  InstanceAnimator.playerMiddleRingBalls, length:  13);
        val_9 = InstanceAnimator.playerInnerRingBalls;
        goto label_5;
        label_1:
        val_8 = null;
        val_8 = null;
        int val_3 = GetBallCountInLine(ringArray:  InstanceAnimator.outerRingBalls, length:  17);
        val_7 = val_3;
        int val_4 = val_3.GetBallCountInLine(ringArray:  InstanceAnimator.middleRingBalls, length:  13);
        val_9 = InstanceAnimator.innerRingBalls;
        label_5:
        val_10 = (val_4 + val_7) + (val_4.GetBallCountInLine(ringArray:  val_9, length:  9));
        return (int)val_10;
        label_2:
        val_10 = 0;
        return (int)val_10;
    }
    private int GetBallCountInLine(UnityEngine.GameObject[] ringArray, int length)
    {
        var val_3;
        var val_4;
        val_3 = length;
        if(val_3 >= 1)
        {
                var val_3 = 0;
            do
        {
            val_3 = val_3 + 1;
            val_4 = 0 + (UnityEngine.Object.op_Inequality(x:  1152921508657404416, y:  0));
        }
        while(val_3 != val_3);
        
            return (int)val_4;
        }
        
        val_4 = 0;
        return (int)val_4;
    }
    public InGameInfo()
    {
    
    }

}
