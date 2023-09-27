using UnityEngine;
public class CharacterSelectNetworkPVPController : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioClip bgm;
    private UnityEngine.GameObject eventSystemObj;
    
    // Methods
    private void OnEnable()
    {
        GameAudio.SwitchMusic(clip:  this.bgm, customLoopStartTime:  0f, customLoopEndTime:  0f, forcePlay:  false);
        this.eventSystemObj.SetActive(value:  false);
        this.Invoke(methodName:  "EnableEventSystem", time:  2.5f);
    }
    private void EnableEventSystem()
    {
        this.eventSystemObj.SetActive(value:  true);
    }
    public CharacterSelectNetworkPVPController()
    {
    
    }

}
