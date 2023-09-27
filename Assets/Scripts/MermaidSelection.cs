using UnityEngine;
public class MermaidSelection : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image lockImg;
    
    // Methods
    private void Awake()
    {
        var val_8;
        this.gameObject.AddComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void MermaidSelection::OnSelectMermaid()));
        val_8 = null;
        val_8 = null;
        this.lockImg.gameObject.SetActive(value:  DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  34));
    }
    public void OnSelectMermaid()
    {
        var val_5;
        var val_6;
        UnityEngine.Events.UnityAction val_8;
        var val_9;
        GameAudio.PlayButtonSound();
        val_5 = null;
        val_5 = null;
        if((DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  34)) != false)
        {
                val_6 = null;
            val_6 = null;
            val_8 = MermaidSelection.<>c.<>9__2_0;
            if(val_8 == null)
        {
                UnityEngine.Events.UnityAction val_2 = null;
            val_8 = val_2;
            val_2 = new UnityEngine.Events.UnityAction(object:  MermaidSelection.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MermaidSelection.<>c::<OnSelectMermaid>b__2_0());
            MermaidSelection.<>c.<>9__2_0 = val_8;
        }
        
            DialogPanel val_3 = DialogManager.ShowConfirmDialog(title:  "Character Locked!", message:  "Purchase Mermaid Brandee to play as her in Adventure mode!", confirmButtonTitle:  "Purchase", cancelButtonTitle:  "Cancel", onConfirmCallback:  val_2, onCancelCallback:  0);
            return;
        }
        
        Character_GlobalInfo.SetMainPlayer(nameID:  34);
        val_9 = null;
        val_9 = null;
        UnityEngine.Object.Destroy(obj:  MainTitleBackMusicHandler.instance.gameObject);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_LoadLevels");
    }
    public MermaidSelection()
    {
    
    }

}
