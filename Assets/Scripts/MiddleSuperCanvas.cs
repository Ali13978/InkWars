using UnityEngine;
public class MiddleSuperCanvas : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image m_typeImage;
    private TMPro.TextMeshProUGUI m_level;
    private BubblesCollection m_bubbleCollection;
    private CharacterSelectPanel panel;
    private DG.Tweening.Tweener tw;
    private UnityEngine.Vector3 originScale;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Vector3 val_2 = this.transform.localScale;
        this.originScale = val_2;
        mem[1152921528973275572] = val_2.y;
        mem[1152921528973275576] = val_2.z;
    }
    public void Setup(InkWars.Model.BubbleTypes superType, int level)
    {
        var val_6;
        DataStructs.Settings val_7;
        val_6 = null;
        val_6 = null;
        val_7 = DataStructs.UserDataDictionary.Settings;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_7 = DataStructs.UserDataDictionary.Settings;
        if(val_7 == null)
        {
                val_7 = 0;
        }
        
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = val_7.SelectedBubble;
        if(this.m_bubbleCollection != null)
        {
            goto label_16;
        }
        
        label_17:
        label_16:
        this.m_typeImage.sprite = this.m_bubbleCollection.GetBubbleSpriteByFamilyAndType(family:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited}), type:  superType);
        object[] val_4 = new object[1];
        val_4[0] = 2;
        this.m_level.text = LanguageManager.GetTextFormat(key:  "LK.MiddleSuper.Level", list:  val_4);
        return;
        label_3:
        if(this.m_bubbleCollection != null)
        {
            goto label_16;
        }
        
        goto label_17;
    }
    private void OnEnable()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        if(0 == this.panel)
        {
                return;
        }
        
        this.panel.OnCharacterChanged.AddListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  public System.Void MiddleSuperCanvas::OnSelectionChanged(CharacterNameID selection)));
    }
    private void OnDisable()
    {
        if(0 != this.panel)
        {
                this.panel.OnCharacterChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  public System.Void MiddleSuperCanvas::OnSelectionChanged(CharacterNameID selection)));
        }
        
        if(this.tw == null)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.tw, complete:  false);
    }
    public void OnSelectionChanged(CharacterNameID selection)
    {
        CharacterData val_1 = CharacterDataManager.Get(id:  selection);
        this.Setup(superType:  val_1.middleSuper, level:  0);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        if(this.tw != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.tw, complete:  false);
        }
        
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = this.originScale, y = val_3.y, z = val_3.z}, duration:  0.3f);
        this.tw = val_5;
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  val_5, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void MiddleSuperCanvas::<OnSelectionChanged>b__10_0()));
    }
    public MiddleSuperCanvas()
    {
    
    }
    private void <OnSelectionChanged>b__10_0()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.originScale, y = V9.16B, z = V8.16B}, d:  1.2f);
        this.tw = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), isIndependentUpdate:  true);
    }

}
