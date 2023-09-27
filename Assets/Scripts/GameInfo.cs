using UnityEngine;
public static class GameInfo
{
    // Fields
    public const int CPU_BATTLE_LEVEL_COUNT = 12;
    public const int PUZZLE_LEVEL_COUNT = 11;
    public static readonly InGameInfo inGame;
    public static readonly GameResultInfo afterGame;
    public static readonly MusicInfo music;
    public static readonly StageInfo stage;
    
    // Methods
    private static GameInfo()
    {
        GameInfo.inGame = new InGameInfo();
        GameInfo.afterGame = new GameResultInfo();
        GameInfo.music = new MusicInfo();
        GameInfo.stage = new StageInfo();
    }

}
