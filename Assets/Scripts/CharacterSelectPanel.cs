using UnityEngine;
public class CharacterSelectPanel : MonoBehaviour
{
    // Fields
    private CharacterNameID <selection>k__BackingField;
    private CharacterSelectPage <currentPage>k__BackingField;
    private System.Collections.Generic.List<CharacterSelectPage> pageList;
    private UnityEngine.RectTransform grid;
    private UnityEngine.UI.Image clanSymbol;
    private UnityEngine.UI.Image glow;
    private CharAnimationController animController;
    private UnityEngine.Transform buyButtonRoot;
    private UnityEngine.UI.Button confirmButton;
    private bool enableExPurchase;
    private TwitterFollowButton twitterController;
    private UnityEngine.GameObject currBuyButton;
    public CharacterSelectPanel.OnCharacterChangedEvent OnCharacterChanged;
    public UnityEngine.Events.UnityEvent OnEntryDone;
    public UnityEngine.Events.UnityEvent OnPageChangeDone;
    private bool _interactable;
    private static bool clanSymbolsLoaded;
    private static UnityEngine.Sprite clanSymbol_Ika;
    private static UnityEngine.Sprite clanSymbol_Tako;
    private static UnityEngine.Sprite clanSymbol_Mermaid;
    private UnityEngine.Vector3 originAnimControllerScale;
    
    // Properties
    public CharacterNameID selection { get; set; }
    public int currentPageId { get; }
    public CharacterSelectPage currentPage { get; set; }
    public bool interactable { get; set; }
    
    // Methods
    public CharacterNameID get_selection()
    {
        return (CharacterNameID)this.<selection>k__BackingField;
    }
    private void set_selection(CharacterNameID value)
    {
        this.<selection>k__BackingField = value;
    }
    public int get_currentPageId()
    {
        if(this.pageList != null)
        {
                return this.pageList.FindIndex(match:  new System.Predicate<CharacterSelectPage>(object:  this, method:  System.Boolean CharacterSelectPanel::<get_currentPageId>b__5_0(CharacterSelectPage x)));
        }
        
        return this.pageList.FindIndex(match:  new System.Predicate<CharacterSelectPage>(object:  this, method:  System.Boolean CharacterSelectPanel::<get_currentPageId>b__5_0(CharacterSelectPage x)));
    }
    public CharacterSelectPage get_currentPage()
    {
        return (CharacterSelectPage)this.<currentPage>k__BackingField;
    }
    private void set_currentPage(CharacterSelectPage value)
    {
        this.<currentPage>k__BackingField = value;
    }
    public bool get_interactable()
    {
        return (bool)this._interactable;
    }
    public void set_interactable(bool value)
    {
        var val_5 = this;
        this._interactable = value;
        List.Enumerator<T> val_2 = this.pageList.GetEnumerator();
        label_4:
        if(((-1459503560) & 1) == 0)
        {
            goto label_2;
        }
        
        0.InitialType.SetInteractable(interactable:  (this._interactable == true) ? 1 : 0);
        goto label_4;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<CharacterSelectPage>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    private void ScaleByScreen()
    {
        float val_6 = UnityEngine.Camera.main.aspect;
        val_6 = 1.78f - val_6;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        float val_7 = 0.6f;
        val_7 = val_6 * val_7;
        val_7 = val_7 + 1f;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  val_7, a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        this.grid.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    private void OnEnable()
    {
        var val_12;
        UnityEngine.Events.UnityAction val_14;
        UnityEngine.Vector3 val_2 = this.animController.transform.localScale;
        this.originAnimControllerScale = val_2;
        mem[1152921528917490952] = val_2.y;
        mem[1152921528917490956] = val_2.z;
        this.animController.pause = true;
        this.animController.Clear();
        this.ScaleByScreen();
        val_12 = null;
        val_12 = null;
        if((CharacterSelectPanel.<>c.<>9__34_0) == null)
        {
            goto label_7;
        }
        
        label_17:
        int val_3 = this.pageList.RemoveAll(match:  CharacterSelectPanel.<>c.<>9__34_0);
        List.Enumerator<T> val_4 = this.pageList.GetEnumerator();
        goto label_10;
        label_12:
        System.Type val_5 = 0.InitialType;
        mem2[0] = this.enableExPurchase;
        label_10:
        if(((-1459172040) & 1) != 0)
        {
            goto label_12;
        }
        
        0.Add(driver:  public System.Void List.Enumerator<CharacterSelectPage>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<CharacterSelectPage>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
        goto label_20;
        label_7:
        CharacterSelectPanel.<>c.<>9__34_0 = new System.Predicate<CharacterSelectPage>(object:  CharacterSelectPanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CharacterSelectPanel.<>c::<OnEnable>b__34_0(CharacterSelectPage x));
        if(this.pageList != null)
        {
            goto label_17;
        }
        
        goto label_17;
        label_20:
        this.<currentPage>k__BackingField = this.pageList.Item[0];
        this.PlayEntryAnimation();
        UnityEngine.Events.UnityAction val_9 = null;
        val_14 = val_9;
        val_9 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectPanel::OnConfirmButtonClick());
        this.confirmButton.onClick.AddListener(call:  val_9);
        if(0 == this.twitterController)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction val_11 = null;
        val_14 = val_11;
        val_11 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectPanel::Refresh());
        this.twitterController.OnTwitterFollowSuccess.AddListener(call:  val_11);
    }
    private System.Collections.IEnumerator PickRandomCharacter()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new CharacterSelectPanel.<PickRandomCharacter>d__35();
    }
    private void OnDisable()
    {
        this.confirmButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectPanel::OnConfirmButtonClick()));
        if(0 == this.twitterController)
        {
                return;
        }
        
        this.twitterController.OnTwitterFollowSuccess.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectPanel::Refresh()));
    }
    private void OnConfirmButtonClick()
    {
        this.animController.PlayAnimation(newAnimName:  15, forceOverride:  false);
    }
    private void PlayEntryAnimation()
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.glow, endValue:  0f, duration:  0f));
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.clanSymbol, endValue:  0f, duration:  0f));
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this.grid, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  1f, mode:  0)), ease:  30));
        UnityEngine.Vector2 val_10 = this.grid.anchoredPosition;
        UnityEngine.Vector3 val_11 = this.grid.localScale;
        val_11.x = val_11.x * (-640f);
        val_11.x = val_10.x + val_11.x;
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.grid, endValue:  val_11.x, duration:  1f, snapping:  false)), ease:  30));
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.05f);
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.PrependCallback(s:  this.<currentPage>k__BackingField.PlayPageAnimation(from:  0f, to:  1f, duration:  0.5f, delay:  0.05f), callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void CharacterSelectPanel::<PlayEntryAnimation>b__38_0())));
        DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void CharacterSelectPanel::<PlayEntryAnimation>b__38_1()));
    }
    private void SelectDefaultCharacter()
    {
        this.SetSelect(buttonController:  this.<currentPage>k__BackingField.GetDefaultButtonController());
    }
    public void NextPage()
    {
        int val_2 = this.currentPageId + 1;
        DG.Tweening.Sequence val_6 = this.PlaySwitchPageAnimation(nextPage:  this.pageList.Item[(val_2 < this.pageList.Count) ? (val_2) : 0]);
    }
    private DG.Tweening.Sequence PlaySwitchPageAnimation(CharacterSelectPage nextPage)
    {
        CharacterSelectPanel.<>c__DisplayClass41_0 val_1 = new CharacterSelectPanel.<>c__DisplayClass41_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .nextPage = nextPage;
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.<currentPage>k__BackingField.PlayPageAnimation(from:  1f, to:  0f, duration:  0.1f, delay:  0.05f));
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.2f, t:  (CharacterSelectPanel.<>c__DisplayClass41_0)[1152921528918765552].nextPage.PlayPageAnimation(from:  0f, to:  1f, duration:  0.2f, delay:  0.05f));
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_2, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void CharacterSelectPanel.<>c__DisplayClass41_0::<PlaySwitchPageAnimation>b__0()));
        return val_2;
    }
    private void Refresh()
    {
        if(0 == (this.<currentPage>k__BackingField))
        {
                return;
        }
        
        this.<currentPage>k__BackingField.Refresh();
    }
    public void SetSelect(CharacterSelectButtonController buttonController)
    {
        CharacterNameID val_15;
        CharacterSelectPanel.<>c__DisplayClass43_0 val_1 = new CharacterSelectPanel.<>c__DisplayClass43_0();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .buttonController = buttonController;
        mem[1152921528919158528] = this;
        if(buttonController != null)
        {
            goto label_30;
        }
        
        label_31:
        label_30:
        this.<selection>k__BackingField = buttonController.charNameID;
        UnityEngine.Debug.Log(message:  buttonController.charNameID);
        UnityEngine.Vector3 val_4 = .buttonController.transform.position;
        this.SetGlow(enable:  (~(CharacterHelper.IsHidden(cid:  this.<selection>k__BackingField))) & 1, pos:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        this.LoadCharacterAnimation(cid:  this.<selection>k__BackingField);
        this.SetClanSymbol(cid:  this.<selection>k__BackingField);
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.clanSymbol, endValue:  0.5f, duration:  0f);
        if(0 != this.currBuyButton)
        {
                UnityEngine.Object.Destroy(obj:  this.currBuyButton);
        }
        
        val_15 = this.<selection>k__BackingField;
        UnityEngine.GameObject val_9 = CharacterSelectBuyButton.SetupBuyButton(cid:  val_15, root:  this.buyButtonRoot, OnPurchaseDone:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void CharacterSelectPanel.<>c__DisplayClass43_0::<SetSelect>b__0()));
        this.currBuyButton = val_9;
        if((0 != val_9) && (0 != (this.currBuyButton.GetComponent<TwitterFollowButton>())))
        {
                if(0 != this.twitterController)
        {
                val_15 = this.currBuyButton.GetComponent<UnityEngine.UI.Button>();
            this.twitterController.twitterButtons.Add(item:  val_15);
            this.twitterController.RefreshButtonCallbacks();
        }
        
        }
        
        this.OnCharacterChanged.Invoke(arg0:  this.<selection>k__BackingField);
        return;
        label_1:
        mem[16] = this;
        mem[24] = buttonController;
        if(mem[24] != 0)
        {
            goto label_30;
        }
        
        goto label_31;
    }
    private void SetClanSymbol(CharacterNameID cid)
    {
        var val_2;
        var val_3;
        var val_4;
        this.LoadClanSymbols();
        CharacterClan val_1 = CharNameIDConverter.GetClan(nameID:  cid);
        if(val_1 == 2)
        {
            goto label_1;
        }
        
        if(val_1 == 1)
        {
            goto label_2;
        }
        
        if(val_1 != 0)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        if(this.clanSymbol != null)
        {
            goto label_13;
        }
        
        label_14:
        label_13:
        this.clanSymbol.sprite = CharacterSelectPanel.clanSymbol_Ika;
        return;
        label_1:
        val_3 = null;
        val_3 = null;
        if(this.clanSymbol != null)
        {
            goto label_13;
        }
        
        goto label_14;
        label_2:
        val_4 = null;
        val_4 = null;
        if(this.clanSymbol != null)
        {
            goto label_13;
        }
        
        goto label_14;
    }
    private void LoadCharacterAnimation(CharacterNameID cid)
    {
        var val_11;
        this.animController.RetrieveCharacterBundle(charNameID:  cid);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.animController.LoadAnimations_CharacterSelect());
        this.animController.pause = false;
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        val_11 = null;
        val_11 = null;
        this.animController.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = ((DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  this.<selection>k__BackingField)) != true) ? 0.5f : 1f};
        this.animController.transform.localScale = new UnityEngine.Vector3() {x = this.originAnimControllerScale, y = val_3.g, z = val_3.b};
        DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScaleX(target:  this.animController.transform, endValue:  0f, duration:  0.2f)), ease:  27);
    }
    private void SetGlow(bool enable, UnityEngine.Vector3 pos)
    {
        this.glow.transform.position = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
        if(enable != false)
        {
                UnityEngine.Color val_2 = UnityEngine.Color.white;
        }
        else
        {
                UnityEngine.Color val_3 = UnityEngine.Color.clear;
        }
        
        this.glow.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
    }
    private void LoadClanSymbols()
    {
        var val_4 = null;
        if(CharacterSelectPanel.clanSymbolsLoaded == true)
        {
                return;
        }
        
        CharacterSelectPanel.clanSymbolsLoaded = true;
        CharacterSelectPanel.clanSymbol_Ika = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "Characters/ClanSymbols/Ika_Inked");
        CharacterSelectPanel.clanSymbol_Tako = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "Characters/ClanSymbols/Tako_Inked");
        CharacterSelectPanel.clanSymbol_Mermaid = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "Characters/ClanSymbols/Mermaid_Inked");
    }
    public CharacterSelectPanel()
    {
        this.pageList = new System.Collections.Generic.List<CharacterSelectPage>();
        this.OnCharacterChanged = new CharacterSelectPanel.OnCharacterChangedEvent();
        this.OnEntryDone = new UnityEngine.Events.UnityEvent();
        this.OnPageChangeDone = new UnityEngine.Events.UnityEvent();
        this._interactable = true;
    }
    private static CharacterSelectPanel()
    {
    
    }
    private bool <get_currentPageId>b__5_0(CharacterSelectPage x)
    {
        return UnityEngine.Object.op_Equality(x:  x, y:  this.<currentPage>k__BackingField);
    }
    private void <PlayEntryAnimation>b__38_0()
    {
        this.<currentPage>k__BackingField.SetInteractable(interactable:  false);
    }
    private void <PlayEntryAnimation>b__38_1()
    {
        this.SelectDefaultCharacter();
        this.interactable = true;
        this.OnEntryDone.Invoke();
        if(MVC_Bot_Base.NetworkControlMode == 0)
        {
                return;
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.PickRandomCharacter());
    }

}
