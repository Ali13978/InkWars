using UnityEngine;
public class VideoPlayCtrl : MonoBehaviour
{
    // Fields
    private UnityEngine.Video.VideoPlayer player;
    public System.Collections.Generic.List<UnityEngine.Video.VideoClip> videoList;
    public string NavigateToSceneWhenDone;
    public bool playAtStart;
    
    // Methods
    private void Start()
    {
        if(this.playAtStart == false)
        {
                return;
        }
        
        this.PlayList();
    }
    public void PlayList()
    {
        var val_5;
        UnityEngine.Video.VideoClip val_7;
        val_5 = 42639;
        if(((0 & 2) != 0) && ((-329054208) == 0))
        {
                val_5 = null;
        }
        
        if((VideoPlayCtrl.<>c.<>9__5_0) == null)
        {
            goto label_3;
        }
        
        label_12:
        int val_1 = this.videoList.RemoveAll(match:  VideoPlayCtrl.<>c.<>9__5_0);
        if(this.videoList.Count == 0)
        {
            goto label_6;
        }
        
        val_7 = this.videoList.Item[0];
        goto label_8;
        label_3:
        VideoPlayCtrl.<>c.<>9__5_0 = new System.Predicate<UnityEngine.Video.VideoClip>(object:  VideoPlayCtrl.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean VideoPlayCtrl.<>c::<PlayList>b__5_0(UnityEngine.Video.VideoClip x));
        if(this.videoList != null)
        {
            goto label_12;
        }
        
        goto label_12;
        label_6:
        val_7 = 0;
        label_8:
        this.Play(clip:  val_7);
    }
    private void Play(UnityEngine.Video.VideoClip clip)
    {
        GameAudio.music.Stop();
        this.player.remove_loopPointReached(value:  new VideoPlayer.EventHandler(object:  this, method:  System.Void VideoPlayCtrl::OnVideoEnd(UnityEngine.Video.VideoPlayer vp)));
        this.player.Stop();
        this.player.clip = clip;
        if(0 != this.player.clip)
        {
                this.player.add_loopPointReached(value:  new VideoPlayer.EventHandler(object:  this, method:  System.Void VideoPlayCtrl::OnVideoEnd(UnityEngine.Video.VideoPlayer vp)));
            this.player.SetTargetAudioSource(trackIndex:  0, source:  GameAudio.music);
            this.player.Play();
            return;
        }
        
        this.OnVideoEnd(vp:  this.player);
    }
    private void OnVideoEnd(UnityEngine.Video.VideoPlayer vp)
    {
        if(0 != vp.clip)
        {
                int val_8 = this.videoList.IndexOf(item:  vp.clip);
            if(val_8 < (this.videoList.Count - 1))
        {
                val_8 = val_8 + 1;
            this.Play(clip:  this.videoList.Item[val_8]);
            return;
        }
        
        }
        
        this.OnAllPlayed();
    }
    private void OnAllPlayed()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  this.NavigateToSceneWhenDone);
    }
    public VideoPlayCtrl()
    {
        this.videoList = new System.Collections.Generic.List<UnityEngine.Video.VideoClip>();
    }

}
