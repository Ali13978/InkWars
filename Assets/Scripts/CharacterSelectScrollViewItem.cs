using UnityEngine;
public class CharacterSelectScrollViewItem : MonoBehaviour
{
    // Fields
    public CharacterNameID charNameId;
    private CharacterSelectScrollView <parent>k__BackingField;
    private CharacterAvatarController avatarTemplate;
    private UnityEngine.CanvasGroup avatarBG;
    private CharacterAvatarController avatarController;
    private UnityEngine.UI.Button button;
    private DG.Tweening.Tweener bgFadeTw;
    
    // Properties
    public CharacterSelectScrollView parent { get; set; }
    
    // Methods
    public CharacterSelectScrollView get_parent()
    {
        return (CharacterSelectScrollView)this.<parent>k__BackingField;
    }
    private void set_parent(CharacterSelectScrollView value)
    {
        this.<parent>k__BackingField = value;
    }
    private void OnEnable()
    {
        if(0 != this.avatarController)
        {
                UnityEngine.Object.Destroy(obj:  this.avatarController.gameObject);
        }
        
        CharacterAvatarController val_4 = UnityEngine.Object.Instantiate<CharacterAvatarController>(original:  this.avatarTemplate, parent:  this.transform);
        this.avatarController = val_4;
        val_4.Init(cid:  this.charNameId, aNewMaskType:  0, reloadAvatar:  true, isFaceLeft:  false);
        UnityEngine.UI.Button val_6 = this.avatarController.gameObject.AddComponent<UnityEngine.UI.Button>();
        this.button = val_6;
        val_6.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectScrollViewItem::OnButtonClick()));
    }
    private void OnDisable()
    {
        this.button.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectScrollViewItem::OnButtonClick()));
    }
    public void EnableBG(bool enabled)
    {
        if(this.bgFadeTw != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.bgFadeTw, complete:  false);
        }
        
        this.bgFadeTw = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.avatarBG, endValue:  (enabled != true) ? 1f : 0f, duration:  0.5f);
    }
    private void OnButtonClick()
    {
        this.<parent>k__BackingField.ChangeSelection(item:  this);
    }
    public void Select()
    {
        this.EnableBG(enabled:  true);
    }
    public void Unselect()
    {
        this.EnableBG(enabled:  false);
    }
    public void SetParentView(CharacterSelectScrollView view)
    {
        this.<parent>k__BackingField = view;
    }
    public CharacterSelectScrollViewItem()
    {
    
    }

}
