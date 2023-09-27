using UnityEngine;
public class StoryMovieCtrl : MonoBehaviour
{
    // Fields
    private const string videoDir = "Video/";
    private float interval;
    private static StoryMovieCtrl.VideoType videoType;
    private static string prevScene;
    private UnityEngine.Video.VideoPlayer player;
    private UnityEngine.AudioSource audioSource;
    private UnityEngine.AudioClip OPBGM2;
    private UnityEngine.UI.Button skipButton;
    private string videoFileName;
    private string nextScene;
    
    // Methods
    public static void SetOP()
    {
        StoryMovieCtrl.videoType = 0;
    }
    public static void SetED()
    {
        StoryMovieCtrl.videoType = 1;
    }
    public static void PlayOP()
    {
        StoryMovieCtrl.videoType = 0;
        StoryMovieCtrl.MoveToStoryVideoScene();
    }
    public static void PlayED()
    {
        StoryMovieCtrl.videoType = 1;
        StoryMovieCtrl.MoveToStoryVideoScene();
    }
    public static void MoveToStoryVideoScene()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Inequality(a:  val_1.m_Handle.name, b:  "StoryVideo")) == false)
        {
                return;
        }
        
        UnityEngine.SceneManagement.Scene val_4 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        StoryMovieCtrl.prevScene = val_4.m_Handle.name;
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "StoryVideo", minimumDelayInSeconds:  0f, autoHideLoadingScreen:  true);
    }
    private void Awake()
    {
        string val_11;
        string val_12;
        if(StoryMovieCtrl.videoType == 1)
        {
            goto label_1;
        }
        
        if(StoryMovieCtrl.videoType != 0)
        {
            goto label_2;
        }
        
        val_11 = "StoryOP";
        this.videoFileName = val_11;
        val_12 = "QuickPlay";
        goto label_4;
        label_1:
        val_11 = "StoryED";
        this.videoFileName = val_11;
        val_12 = "Credits";
        goto label_4;
        label_2:
        val_11 = this.videoFileName;
        val_12 = 1152921505107329032;
        label_4:
        this.nextScene = val_12;
        this.player.clip = UnityEngine.Resources.Load<UnityEngine.Video.VideoClip>(path:  "Video/"("Video/") + val_11);
        if(0 == this.player.clip)
        {
            goto label_9;
        }
        
        GameAudio.music.Stop();
        this.player.add_loopPointReached(value:  new VideoPlayer.EventHandler(object:  this, method:  System.Void StoryMovieCtrl::OnVideoEnd(UnityEngine.Video.VideoPlayer vp)));
        this.player.SetTargetAudioSource(trackIndex:  0, source:  this.audioSource);
        this.player.Play();
        if(StoryMovieCtrl.videoType != 0)
        {
            goto label_17;
        }
        
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.SwitchOPSound());
        goto label_17;
        label_9:
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  this.nextScene, minimumDelayInSeconds:  0f, autoHideLoadingScreen:  true);
        label_17:
        this.skipButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void StoryMovieCtrl::OnSkip()));
    }
    private System.Collections.IEnumerator SwitchOPSound()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new StoryMovieCtrl.<SwitchOPSound>d__17(<>1__state:  0);
    }
    private void OnVideoEnd(UnityEngine.Video.VideoPlayer vp)
    {
        vp.remove_loopPointReached(value:  new VideoPlayer.EventHandler(object:  this, method:  System.Void StoryMovieCtrl::OnVideoEnd(UnityEngine.Video.VideoPlayer vp)));
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  this.nextScene, minimumDelayInSeconds:  0f, autoHideLoadingScreen:  true);
    }
    private void OnSkip()
    {
        this.player.Pause();
        DialogPanel val_3 = DialogManager.ShowConfirmDialog(title:  "LK.SkipVideoTitle", message:  "LK.SkipVideoMessage", confirmButtonTitle:  "LK.No", cancelButtonTitle:  "LK.Skip", onConfirmCallback:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void StoryMovieCtrl::<OnSkip>b__19_0()), onCancelCallback:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void StoryMovieCtrl::<OnSkip>b__19_1()));
    }
    public StoryMovieCtrl()
    {
        this.interval = 3f;
    }
    private void <OnSkip>b__19_0()
    {
        this.player.Play();
    }
    private void <OnSkip>b__19_1()
    {
        this.OnVideoEnd(vp:  this.player);
    }

}
