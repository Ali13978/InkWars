using UnityEngine;
public class CharacterSelectPage : MonoBehaviour
{
    // Fields
    public CharacterNameID initSelection;
    public bool enableExPurchase;
    private System.Collections.Generic.List<ChainBounce> chainBounceList;
    private System.Collections.Generic.List<CharacterSelectButtonController> buttonList;
    private DG.Tweening.Sequence animSeq;
    
    // Methods
    public DG.Tweening.Sequence ShowPage(float duration = 0.2, float delay = 0.05)
    {
        return this.PlayPageAnimation(from:  0f, to:  1f, duration:  duration, delay:  delay);
    }
    public DG.Tweening.Sequence HidePage(float duration = 0.1, float delay = 0.05)
    {
        return this.PlayPageAnimation(from:  1f, to:  0f, duration:  duration, delay:  delay);
    }
    private void Awake()
    {
        var val_4 = null;
        if((CharacterSelectPage.<>c.<>9__7_0) == null)
        {
            goto label_3;
        }
        
        label_9:
        int val_1 = this.chainBounceList.RemoveAll(match:  CharacterSelectPage.<>c.<>9__7_0);
        this.buttonList.AddRange(collection:  this.GetComponentsInChildren<CharacterSelectButtonController>(includeInactive:  true));
        return;
        label_3:
        CharacterSelectPage.<>c.<>9__7_0 = new System.Predicate<ChainBounce>(object:  CharacterSelectPage.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CharacterSelectPage.<>c::<Awake>b__7_0(ChainBounce x));
        if(this.chainBounceList != null)
        {
            goto label_9;
        }
        
        goto label_9;
    }
    public void Refresh()
    {
        List.Enumerator<T> val_1 = this.buttonList.GetEnumerator();
        label_4:
        if(((-1462240568) & 1) == 0)
        {
            goto label_2;
        }
        
        0.InitialType.Refresh();
        goto label_4;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<CharacterSelectButtonController>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    public void SetInteractable(bool interactable)
    {
        var val_7;
        var val_8;
        val_7 = this;
        val_8 = null;
        val_8 = null;
        if((CharacterSelectPage.<>c.<>9__9_0) == null)
        {
            goto label_3;
        }
        
        label_12:
        int val_1 = this.buttonList.RemoveAll(match:  CharacterSelectPage.<>c.<>9__9_0);
        List.Enumerator<T> val_2 = this.buttonList.GetEnumerator();
        label_8:
        if(((-1462100936) & 1) == 0)
        {
            goto label_6;
        }
        
        0.InitialType.SetButtonInteractable(enable:  interactable, enableExPurchase:  (this.enableExPurchase == true) ? 1 : 0);
        goto label_8;
        label_3:
        CharacterSelectPage.<>c.<>9__9_0 = new System.Predicate<CharacterSelectButtonController>(object:  CharacterSelectPage.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CharacterSelectPage.<>c::<SetInteractable>b__9_0(CharacterSelectButtonController x));
        if(this.buttonList != null)
        {
            goto label_12;
        }
        
        goto label_12;
        label_6:
        0.Add(driver:  public System.Void List.Enumerator<CharacterSelectButtonController>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<CharacterSelectButtonController>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
    }
    private void EnableButtonInteractable()
    {
        this.SetInteractable(interactable:  true);
    }
    private void OnEnable()
    {
        List.Enumerator<T> val_1 = this.chainBounceList.GetEnumerator();
        label_4:
        if(((-1461852344) & 1) == 0)
        {
            goto label_2;
        }
        
        0.InitialType.SetInitScale(initScale:  0f);
        goto label_4;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<ChainBounce>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    public DG.Tweening.Sequence PlayPageAnimation(float from = 0, float to = 0.1, float duration = 0.5, float delay = 0.1)
    {
        if(this.animSeq != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.animSeq, complete:  false);
        }
        
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        this.animSeq = val_1;
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<DG.Tweening.Sequence>(t:  val_1);
        this.SetInteractable(interactable:  false);
        List.Enumerator<T> val_3 = this.chainBounceList.GetEnumerator();
        label_7:
        if(((-1461672808) & 1) == 0)
        {
            goto label_5;
        }
        
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.animSeq, t:  0.InitialType.PlayAnimation(fromScale:  from, toScale:  to, duration:  duration, delay:  delay));
        goto label_7;
        label_5:
        0.Add(driver:  public System.Void List.Enumerator<ChainBounce>::Dispose(), rectTransform:  0, drivenProperties:  null);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.OnKill<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.animSeq, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void CharacterSelectPage::EnableButtonInteractable())), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void CharacterSelectPage::EnableButtonInteractable()));
        return (DG.Tweening.Sequence)this.animSeq;
    }
    public CharacterSelectButtonController GetButtonControllerByCharacterId(CharacterNameID cid)
    {
        .cid = cid;
        if(this.buttonList != null)
        {
                return this.buttonList.Find(match:  new System.Predicate<CharacterSelectButtonController>(object:  new CharacterSelectPage.<>c__DisplayClass13_0(), method:  System.Boolean CharacterSelectPage.<>c__DisplayClass13_0::<GetButtonControllerByCharacterId>b__0(CharacterSelectButtonController x)));
        }
        
        return this.buttonList.Find(match:  new System.Predicate<CharacterSelectButtonController>(object:  new CharacterSelectPage.<>c__DisplayClass13_0(), method:  System.Boolean CharacterSelectPage.<>c__DisplayClass13_0::<GetButtonControllerByCharacterId>b__0(CharacterSelectButtonController x)));
    }
    public CharacterSelectButtonController GetDefaultButtonController()
    {
        if(this.buttonList != null)
        {
                return this.buttonList.Find(match:  new System.Predicate<CharacterSelectButtonController>(object:  this, method:  System.Boolean CharacterSelectPage::<GetDefaultButtonController>b__14_0(CharacterSelectButtonController x)));
        }
        
        return this.buttonList.Find(match:  new System.Predicate<CharacterSelectButtonController>(object:  this, method:  System.Boolean CharacterSelectPage::<GetDefaultButtonController>b__14_0(CharacterSelectButtonController x)));
    }
    public CharacterSelectPage()
    {
        this.initSelection = 20;
        this.chainBounceList = new System.Collections.Generic.List<ChainBounce>();
        this.buttonList = new System.Collections.Generic.List<CharacterSelectButtonController>();
    }
    private bool <GetDefaultButtonController>b__14_0(CharacterSelectButtonController x)
    {
        return (bool)(x.charNameID == this.initSelection) ? 1 : 0;
    }

}
