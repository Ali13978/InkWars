using UnityEngine;
public class CharacterSelectButtonController : MonoBehaviour
{
    // Fields
    public CharacterNameID charNameID;
    public CharacterAvatarController avatarTemplate;
    private CharacterAssetLoader assetLoader;
    private CharacterAvatarLockIcon lockIconScript;
    private CharacterSelectPanel parentPanel;
    
    // Methods
    private void Awake()
    {
    
    }
    public void SetButtonInteractable(bool enable, bool enableExPurchase)
    {
        bool val_3;
        var val_4;
        val_3 = enable;
        if((val_3 != false) && (enableExPurchase != true))
        {
                val_4 = null;
            val_4 = null;
            CharacterNameID val_3 = this.charNameID;
            val_3 = (DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  val_3)) ^ 1;
        }
        
        val_3 = val_3;
        this.GetComponent<UnityEngine.UI.Button>().interactable = val_3;
    }
    private void InitParentPanel()
    {
        UnityEngine.Object val_8 = this.transform;
        goto label_1;
        label_9:
        if(0 != (val_8.GetComponent<CharacterSelectPanel>()))
        {
            goto label_5;
        }
        
        val_8 = val_8.parent;
        label_1:
        if(0 != val_8)
        {
            goto label_9;
        }
        
        label_5:
        if(0 == val_8)
        {
                return;
        }
        
        this.parentPanel = val_8.GetComponent<CharacterSelectPanel>();
    }
    private void DeleteAllChildren()
    {
        var val_13;
        var val_14;
        System.Collections.IEnumerator val_2 = this.transform.GetEnumerator();
        label_21:
        var val_13 = 0;
        val_13 = val_13 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_13 = val_2.Current;
        if(val_13 != null)
        {
                val_13 = 0;
        }
        
        UnityEngine.Object.Destroy(obj:  val_13.gameObject);
        goto label_21;
        label_7:
        val_14 = 0;
        if(val_2 != null)
        {
                var val_15 = 0;
            val_15 = val_15 + 1;
            val_2.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public void Refresh()
    {
        this.OnEnable();
    }
    private void OnEnable()
    {
        this.DeleteAllChildren();
        if(0 != this.lockIconScript)
        {
                UnityEngine.Object.Destroy(obj:  this.lockIconScript);
        }
        
        this.InitParentPanel();
        if(this.charNameID != 999999)
        {
                if((CharacterHelper.IsHidden(cid:  this.charNameID)) == false)
        {
            goto label_9;
        }
        
        }
        
        UnityEngine.UI.Image val_3 = this.GetComponent<UnityEngine.UI.Image>();
        if(0 != val_3)
        {
                val_3.enabled = false;
        }
        
        this = this.GetComponent<UnityEngine.UI.Button>();
        if(0 == this)
        {
                return;
        }
        
        this.enabled = false;
        return;
        label_9:
        UnityEngine.UI.Button val_8 = this.gameObject.GetComponent<UnityEngine.UI.Button>();
        val_8.gameObject.SetActive(value:  true);
        val_8.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void CharacterSelectButtonController::SelectCharacter()));
        val_8.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void CharacterSelectButtonController::SelectCharacter()));
        UnityEngine.UI.Image val_15 = this.gameObject.GetComponent<UnityEngine.UI.Image>();
        if(val_15 != 0)
        {
                UnityEngine.Color val_17 = UnityEngine.Color.clear;
            val_15.color = new UnityEngine.Color() {r = val_17.r, g = val_17.g, b = val_17.b, a = val_17.a};
        }
        
        CharacterAvatarController val_19 = UnityEngine.Object.Instantiate<CharacterAvatarController>(original:  this.avatarTemplate, parent:  this.transform);
        if(val_19 != null)
        {
                val_19.Init(cid:  this.charNameID, aNewMaskType:  0, reloadAvatar:  true, isFaceLeft:  false);
        }
        else
        {
                val_19.Init(cid:  this.charNameID, aNewMaskType:  0, reloadAvatar:  true, isFaceLeft:  false);
        }
        
        val_19.SetScale(scale:  1.35f);
        this.lockIconScript = this.gameObject.AddComponent<CharacterAvatarLockIcon>();
        val_21.charNameID = this.charNameID;
        this.lockIconScript.UpdateIconLockStatus();
        if(0 == this.lockIconScript.lockIconObject)
        {
                return;
        }
        
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(d:  0.6f, a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        this.lockIconScript.lockIconObject.transform.localScale = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
    }
    public void SelectCharacter()
    {
        this.parentPanel.SetSelect(buttonController:  this);
    }
    public CharacterSelectButtonController()
    {
    
    }

}
