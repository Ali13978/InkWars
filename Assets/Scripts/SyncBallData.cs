using UnityEngine;
[Serializable]
public class SyncState.SyncBallData
{
    // Fields
    public int t;
    public UnityEngine.Vector3 v;
    
    // Methods
    public SyncState.SyncBallData()
    {
    
    }
    public SyncState.SyncBallData(UnityEngine.GameObject gameObject)
    {
        UnityEngine.GameObject val_5;
        var val_6;
        if(gameObject == 0)
        {
                val_5 = 0;
        }
        else
        {
                UnityEngine.Vector3 val_3 = gameObject.transform.position;
            this.v = val_3;
            mem[1152921528231524664] = val_3.y;
            mem[1152921528231524668] = val_3.z;
            val_6 = null;
            val_6 = null;
            float val_5 = (float)InstanceAnimator.playerNegateX;
            val_5 = val_3.x * val_5;
            this.v = val_5;
            val_5 = gameObject;
        }
        
        this.t = SyncState.BallToInt(go:  val_5);
    }

}
