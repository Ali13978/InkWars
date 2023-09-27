using UnityEngine;
public class PanelTutorialScript : MonoBehaviour
{
    // Fields
    public static int TutorialPanelImageCounter;
    public UnityEngine.UI.Image defaultImage;
    public UnityEngine.Sprite[] instructionImages;
    
    // Methods
    public void Start()
    {
        var val_3 = null;
        this.defaultImage.GetComponent<UnityEngine.UI.Image>().sprite = InstructionCollection.GetById(id:  PanelTutorialScript.TutorialPanelImageCounter);
    }
    public void optionTutorialExit()
    {
        UnityEngine.Time.timeScale = 1f;
        GameAudio.PlayButtonSound();
        this.gameObject.SetActive(value:  false);
    }
    public void nextButton()
    {
        UnityEngine.Time.timeScale = 1f;
        GameAudio.PlayButtonSound();
        this.gameObject.SetActive(value:  false);
    }
    public PanelTutorialScript()
    {
    
    }
    private static PanelTutorialScript()
    {
    
    }

}
