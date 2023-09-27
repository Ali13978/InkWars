using UnityEngine;
public class BEPACanvasController : MonoBehaviour
{
    // Fields
    public static string PreviousScene;
    public static bool GotoBattleAmplifierCanvas;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Toggle BEToggle;
    private UnityEngine.UI.Toggle PAToggle;
    
    // Methods
    private void OnEnable()
    {
        var val_3;
        UnityEngine.UI.Toggle val_4;
        var val_5;
        this.closeButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BEPACanvasController::Close()));
        val_3 = null;
        val_3 = null;
        if(this.BEToggle == null)
        {
            goto label_5;
        }
        
        if(BEPACanvasController.GotoBattleAmplifierCanvas == false)
        {
            goto label_6;
        }
        
        label_9:
        this.BEToggle.isOn = false;
        val_4 = this.PAToggle;
        val_5 = 1;
        goto label_8;
        label_5:
        if(BEPACanvasController.GotoBattleAmplifierCanvas == true)
        {
            goto label_9;
        }
        
        label_6:
        this.BEToggle.isOn = true;
        val_4 = this.PAToggle;
        val_5 = 0;
        label_8:
        val_4.isOn = false;
    }
    private void Close()
    {
        null = null;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  BEPACanvasController.PreviousScene);
    }
    public BEPACanvasController()
    {
    
    }
    private static BEPACanvasController()
    {
        BEPACanvasController.PreviousScene = "Shop_Scene";
        BEPACanvasController.GotoBattleAmplifierCanvas = false;
    }

}
