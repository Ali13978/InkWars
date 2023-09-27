using UnityEngine;
public class AdventureModeCharacterSelectionConfirmButton : MonoBehaviour
{
    // Fields
    private CharacterSelectPanel panel;
    private UnityEngine.RectTransform backButton;
    private UnityEngine.UI.Button btn;
    private UnityEngine.Vector3 originScale;
    private DG.Tweening.Tweener tw;
    
    // Methods
    private void Awake()
    {
        this.btn = this.GetComponent<UnityEngine.UI.Button>();
        UnityEngine.Vector3 val_3 = this.transform.localScale;
        this.originScale = val_3;
        mem[1152921528894011188] = val_3.y;
        mem[1152921528894011192] = val_3.z;
        this.btn.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void AdventureModeCharacterSelectionConfirmButton::OnClick()));
    }
    private void OnEnable()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.backButton.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        this.panel.OnCharacterChanged.AddListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  System.Void AdventureModeCharacterSelectionConfirmButton::OnSelectionChanged(CharacterNameID selection)));
        this.panel.OnEntryDone.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void AdventureModeCharacterSelectionConfirmButton::OnEnterDone()));
    }
    private void OnEnterDone()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.backButton, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.8f), ease:  27);
    }
    private void OnDisable()
    {
        this.panel.OnCharacterChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  System.Void AdventureModeCharacterSelectionConfirmButton::OnSelectionChanged(CharacterNameID selection)));
        this.panel.OnEntryDone.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void AdventureModeCharacterSelectionConfirmButton::OnEnterDone()));
        if(this.tw == null)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.tw, complete:  false);
    }
    public void ButtonPress_Next()
    {
        var val_2;
        string val_9;
        string val_10;
        var val_11;
        var val_12;
        var val_13;
        string val_14;
        var val_15;
        string val_16;
        var val_17;
        CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
        if(val_2 != 1)
        {
            goto label_3;
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  "ika", value:  "no");
        val_9 = "tako";
        val_10 = "yes";
        goto label_4;
        label_3:
        CharacterInfo val_3 = Character_GlobalInfo.GetMainPlayer();
        if(val_2 != 0)
        {
            goto label_7;
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  "ika", value:  "yes");
        val_9 = "tako";
        val_10 = "no";
        label_4:
        UnityEngine.PlayerPrefs.SetString(key:  val_9, value:  val_10);
        label_7:
        val_11 = null;
        val_11 = null;
        DataStructs.UserDataDictionary.GameSave.SetCurrentCharacterUsed(used:  true);
        CharacterInfo val_4 = Character_GlobalInfo.GetMainPlayer();
        if(val_2 == 0)
        {
            goto label_13;
        }
        
        CharacterInfo val_5 = Character_GlobalInfo.GetMainPlayer();
        if(val_2 != 1)
        {
            goto label_20;
        }
        
        val_12 = null;
        val_12 = null;
        if(DataStructs.UserDataDictionary.GameSave.isTakoStoryStartPlayed == true)
        {
            goto label_20;
        }
        
        val_13 = null;
        val_13 = null;
        DataStructs.UserDataDictionary.GameSave.isTakoStoryStartPlayed = true;
        val_14 = "Tako_Start";
        goto label_26;
        label_13:
        val_15 = null;
        val_15 = null;
        if(DataStructs.UserDataDictionary.GameSave.isIkaStoryStartPlayed == false)
        {
            goto label_30;
        }
        
        label_20:
        val_16 = "LoadStageSelect";
        goto label_31;
        label_30:
        val_17 = null;
        val_17 = null;
        DataStructs.UserDataDictionary.GameSave.isIkaStoryStartPlayed = true;
        val_14 = "Ika_Start";
        label_26:
        StoryPanelScript.keyForStory = val_14;
        val_16 = "LoadStoryPanels";
        label_31:
        UnityEngine.Coroutine val_8 = this.StartCoroutine(methodName:  val_16);
    }
    private System.Collections.IEnumerator LoadStoryPanels()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new AdventureModeCharacterSelectionConfirmButton.<LoadStoryPanels>d__10();
    }
    private System.Collections.IEnumerator LoadStageSelect()
    {
        object val_1 = static_value_032DD220;
        val_1 = new System.Object();
        mem2[0] = 0;
        return (System.Collections.IEnumerator)val_1;
    }
    private void OnClick()
    {
        if(this.tw != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.tw, complete:  false);
        }
        
        this.btn.interactable = false;
        this.panel.interactable = false;
        GameAudio.PlayButtonSound();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.DelayLockPlayer());
    }
    private System.Collections.IEnumerator DelayLockPlayer()
    {
        object val_1 = static_value_032DD228;
        val_1 = new System.Object();
        mem2[0] = 0;
        mem2[0] = this;
        return (System.Collections.IEnumerator)val_1;
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
        
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.tw, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void AdventureModeCharacterSelectionConfirmButton::<OnSelectionChanged>b__14_0()));
    }
    public AdventureModeCharacterSelectionConfirmButton()
    {
    
    }
    private void <OnSelectionChanged>b__14_0()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.originScale, y = V9.16B, z = V8.16B}, d:  1.2f);
        this.tw = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), loops:  0, loopType:  1);
    }

}
