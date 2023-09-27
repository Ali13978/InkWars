using UnityEngine;
public class MVCTutorialPart : MonoBehaviour
{
    // Fields
    public static MVCTutorialPart CurrentTutorialPart;
    public bool ShowFlash;
    public bool ShowDemoText;
    public bool ShowNowYouTryButton;
    public float WaitTime;
    public bool ResetModel;
    public CharacterNameID HumanPlayer;
    public CharacterNameID CPUPlayer;
    public bool isFinished;
    
    // Methods
    private void OnEnable()
    {
        this.isFinished = false;
    }
    public System.Collections.IEnumerator PlayPart()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new MVCTutorialPart.<PlayPart>d__10();
    }
    public void SetHand(bool RightHand)
    {
        this.isFinished = true;
    }
    public MVCTutorialPart()
    {
        this.HumanPlayer = 20;
    }

}
