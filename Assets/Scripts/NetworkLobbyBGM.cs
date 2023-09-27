using UnityEngine;
public class NetworkLobbyBGM : MonoBehaviour
{
    // Fields
    private UnityEngine.AudioClip m_audioClip;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    private void OnEnable()
    {
        GameAudio.SwitchMusic(clip:  this.m_audioClip, customLoopStartTime:  0f, customLoopEndTime:  0f, forcePlay:  false);
    }
    public NetworkLobbyBGM()
    {
    
    }

}
