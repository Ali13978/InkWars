using UnityEngine;
private sealed class MMOCClientUser.<>c__DisplayClass63_1
{
    // Fields
    public string info;
    
    // Methods
    public MMOCClientUser.<>c__DisplayClass63_1()
    {
    
    }
    internal void <GetUserProfile>b__2(bool has, string msg)
    {
        if(has != false)
        {
                DialogPanel val_1 = DialogManager.Show(title:  "Error", message:  this.info, cancelButtonTitle:  0, onCancelCallback:  0);
            return;
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "OfflineTitleScreen");
    }

}
