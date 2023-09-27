using UnityEngine;
public class CharacterSelectConfirmButton : MonoBehaviour
{
    // Fields
    private CharacterSelectPanel panel;
    private UnityEngine.UI.Button enhancerButton;
    private UnityEngine.UI.Button btn;
    private UnityEngine.Vector3 originScale;
    private DG.Tweening.Tweener tw;
    
    // Methods
    private void Awake()
    {
        this.btn = this.GetComponent<UnityEngine.UI.Button>();
        UnityEngine.Vector3 val_3 = this.transform.localScale;
        this.originScale = val_3;
        mem[1152921528908360484] = val_3.y;
        mem[1152921528908360488] = val_3.z;
        this.btn.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectConfirmButton::OnClick()));
    }
    private void OnEnable()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.panel.OnCharacterChanged.AddListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  System.Void CharacterSelectConfirmButton::OnSelectionChanged(CharacterNameID selection)));
    }
    private void OnDisable()
    {
        this.panel.OnCharacterChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  System.Void CharacterSelectConfirmButton::OnSelectionChanged(CharacterNameID selection)));
        if(this.tw == null)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.tw, complete:  false);
    }
    private void OnClick()
    {
        if(this.tw != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.tw, complete:  false);
        }
        
        this.btn.interactable = false;
        this.panel.interactable = false;
        this.enhancerButton.interactable = false;
        BattleEnhancerInventory.Hide();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.DelayLockPlayer());
    }
    private System.Collections.IEnumerator DelayLockPlayer()
    {
        return (System.Collections.IEnumerator)new CharacterSelectConfirmButton.<DelayLockPlayer>d__9(<>1__state:  0);
    }
    private void OnSelectionChanged(CharacterNameID selection)
    {
        var val_8;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        if(this.tw != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.tw, complete:  false);
        }
        
        this.tw = DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = this.originScale, y = val_2.y, z = val_2.z}, duration:  0.3f);
        val_8 = null;
        val_8 = null;
        CharacterNameID val_8 = selection;
        bool val_5 = DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  val_8);
        val_8 = (~val_5) & 1;
        this.btn.interactable = val_8;
        if(val_5 != false)
        {
                return;
        }
        
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.tw, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void CharacterSelectConfirmButton::<OnSelectionChanged>b__10_0()));
    }
    public CharacterSelectConfirmButton()
    {
    
    }
    private void <OnSelectionChanged>b__10_0()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.originScale, y = V9.16B, z = V8.16B}, d:  1.2f);
        this.tw = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), loops:  0, loopType:  1);
    }

}
