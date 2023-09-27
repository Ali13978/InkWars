using UnityEngine;
public class MainTitleBackMusicHandler : MonoBehaviour
{
    // Fields
    public static MainTitleBackMusicHandler instance;
    public UnityEngine.AudioClip backGroundMusic;
    public bool isTitleScreen;
    
    // Methods
    private void Awake()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if(MainTitleBackMusicHandler.instance != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        else
        {
                val_5 = null;
            val_5 = null;
            MainTitleBackMusicHandler.instance = this;
        }
        
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    private void Start()
    {
        var val_6;
        var val_7;
        val_6 = 0f;
        val_7 = 0f;
        GameAudio.SwitchMusic(clip:  this.backGroundMusic, customLoopStartTime:  (this.isTitleScreen == true) ? 0f : 8.02f, customLoopEndTime:  (this.isTitleScreen == true) ? 0f : 38.2f, forcePlay:  false);
    }
    public static void Play()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(0 == MainTitleBackMusicHandler.instance)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        MainTitleBackMusicHandler.instance.Start();
    }
    public MainTitleBackMusicHandler()
    {
    
    }
    private static MainTitleBackMusicHandler()
    {
    
    }

}
