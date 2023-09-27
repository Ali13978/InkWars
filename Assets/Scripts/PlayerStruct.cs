using UnityEngine;
public struct NetworkBehaviour_PlayScene.PlayerStruct
{
    // Fields
    public bool ready;
    public bool gridBallsReady;
    public bool fireBubbleReady;
    
    // Methods
    public NetworkBehaviour_PlayScene.PlayerStruct(bool ready, bool gridBallsReady, bool fireBubbleReady)
    {
        mem[1152921526179523584] = ready;
        mem[1152921526179523585] = gridBallsReady;
        mem[1152921526179523586] = fireBubbleReady;
    }

}
