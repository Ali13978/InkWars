using UnityEngine;
private sealed class MMOCClientUser.<>c__DisplayClass63_2
{
    // Fields
    public string info;
    
    // Methods
    public MMOCClientUser.<>c__DisplayClass63_2()
    {
    
    }
    internal void <GetUserProfile>b__4(bool has, string msg)
    {
        if(has != false)
        {
                DialogPanel val_1 = DialogManager.Show(title:  "Error in refresh code. Please relogin", message:  this.info, cancelButtonTitle:  0, onCancelCallback:  0);
            return;
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "OfflineTitleScreen");
    }

}
