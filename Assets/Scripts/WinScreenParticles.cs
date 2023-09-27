using UnityEngine;
public class WinScreenParticles : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject[] stars;
    public UnityEngine.AudioClip[] starClips;
    public bool canPlayWinSound;
    
    // Methods
    public void setActiveStar1()
    {
    
    }
    public void setActiveStar2()
    {
    
    }
    public void setActiveStar3()
    {
    
    }
    public void setActiveCoinBurst()
    {
    
    }
    public void PlayWinSound()
    {
        if(this.canPlayWinSound == false)
        {
                return;
        }
        
        GameAudio.PlayPurchaseSound();
    }
    public WinScreenParticles()
    {
        this.canPlayWinSound = true;
    }

}
