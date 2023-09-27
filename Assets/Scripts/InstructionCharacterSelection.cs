using UnityEngine;
public class InstructionCharacterSelection : MonoBehaviour
{
    // Fields
    private int imageCounter;
    public UnityEngine.UI.Image defaultImage;
    public UnityEngine.GameObject backButton;
    
    // Methods
    private void Start()
    {
        this.imageCounter = 9;
        this.defaultImage.GetComponent<UnityEngine.UI.Image>().sprite = InstructionCollection.GetById(id:  this.imageCounter);
    }
    public void optionTutorialExit()
    {
        UnityEngine.Time.timeScale = 1f;
        GameAudio.PlayButtonSound();
        this.gameObject.SetActive(value:  false);
    }
    public void nextButton()
    {
        int val_4;
        GameAudio.PlayButtonSound();
        val_4 = this.imageCounter + 1;
        this.imageCounter = val_4;
        if(val_4 == 9)
        {
                this.backButton.SetActive(value:  false);
            val_4 = this.imageCounter;
        }
        
        if(val_4 == 10)
        {
                this.backButton.SetActive(value:  true);
            val_4 = this.imageCounter;
        }
        
        if(val_4 == 13)
        {
                UnityEngine.Time.timeScale = 1f;
            this.gameObject.SetActive(value:  false);
            return;
        }
        
        this.defaultImage.GetComponent<UnityEngine.UI.Image>().sprite = InstructionCollection.GetById(id:  this.imageCounter);
    }
    public void instructionBackButton()
    {
        GameAudio.PlayButtonSound();
        int val_3 = this.imageCounter;
        val_3 = val_3 - 1;
        this.imageCounter = val_3;
        if(val_3 == 9)
        {
                this.backButton.SetActive(value:  false);
        }
        
        this.defaultImage.GetComponent<UnityEngine.UI.Image>().sprite = InstructionCollection.GetById(id:  this.imageCounter);
    }
    public InstructionCharacterSelection()
    {
    
    }

}
