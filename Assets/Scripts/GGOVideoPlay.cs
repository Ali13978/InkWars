using UnityEngine;
public class GGOVideoPlay : MonoBehaviour
{
    // Fields
    private UnityEngine.Video.VideoPlayer player;
    private UnityEngine.GameObject toBeEnabled;
    
    // Methods
    private void OnEnable()
    {
        this.player.add_loopPointReached(value:  new VideoPlayer.EventHandler(object:  this, method:  System.Void GGOVideoPlay::EndPlayer(UnityEngine.Video.VideoPlayer p)));
    }
    private void OnDisable()
    {
        this.player.remove_loopPointReached(value:  new VideoPlayer.EventHandler(object:  this, method:  System.Void GGOVideoPlay::EndPlayer(UnityEngine.Video.VideoPlayer p)));
    }
    private void EndPlayer(UnityEngine.Video.VideoPlayer p)
    {
        this.toBeEnabled.SetActive(value:  true);
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public GGOVideoPlay()
    {
    
    }

}
