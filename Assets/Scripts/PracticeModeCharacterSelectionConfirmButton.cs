using UnityEngine;
public class PracticeModeCharacterSelectionConfirmButton : MonoBehaviour
{
    // Fields
    private CharacterSelectPanel panel;
    private UnityEngine.RectTransform backButton;
    private UnityEngine.UI.Button btn;
    private UnityEngine.Vector3 originScale;
    private DG.Tweening.Tweener tw;
    private CharacterNameID[] characterList;
    
    // Methods
    private void Awake()
    {
        this.btn = this.GetComponent<UnityEngine.UI.Button>();
        UnityEngine.Vector3 val_3 = this.transform.localScale;
        this.originScale = val_3;
        mem[1152921528991501428] = val_3.y;
        mem[1152921528991501432] = val_3.z;
        this.btn.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PracticeModeCharacterSelectionConfirmButton::OnClick()));
    }
    private void OnEnable()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.backButton.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        this.panel.OnCharacterChanged.AddListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  System.Void PracticeModeCharacterSelectionConfirmButton::OnSelectionChanged(CharacterNameID selection)));
        this.panel.OnEntryDone.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PracticeModeCharacterSelectionConfirmButton::OnEnterDone()));
    }
    private void OnEnterDone()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.backButton, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.8f), ease:  27);
    }
    private void OnDisable()
    {
        this.panel.OnCharacterChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  System.Void PracticeModeCharacterSelectionConfirmButton::OnSelectionChanged(CharacterNameID selection)));
        this.panel.OnEntryDone.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PracticeModeCharacterSelectionConfirmButton::OnEnterDone()));
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
        var val_14;
        string val_16;
        var val_17;
        var val_18;
        var val_19;
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
        GameAudio.PlayButtonSound();
        CharacterInfo val_4 = Character_GlobalInfo.GetMainPlayer();
        if(val_2 == 0)
        {
            goto label_15;
        }
        
        CharacterInfo val_5 = Character_GlobalInfo.GetMainPlayer();
        if(val_2 != 1)
        {
            goto label_32;
        }
        
        val_12 = null;
        val_12 = null;
        if(DataStructs.UserDataDictionary.GameSave.isTakoStoryStartPlayed == true)
        {
            goto label_32;
        }
        
        val_13 = null;
        val_13 = null;
        DataStructs.UserDataDictionary.GameSave.isTakoStoryStartPlayed = true;
        val_14 = null;
        val_14 = null;
        val_16 = "Tako_Start";
        goto label_28;
        label_15:
        val_17 = null;
        val_17 = null;
        if(DataStructs.UserDataDictionary.GameSave.isIkaStoryStartPlayed == true)
        {
            goto label_32;
        }
        
        val_18 = null;
        val_18 = null;
        DataStructs.UserDataDictionary.GameSave.isIkaStoryStartPlayed = true;
        val_19 = null;
        val_19 = null;
        val_16 = "Ika_Start";
        label_28:
        StoryPanelScript.keyForStory = val_16;
        label_32:
        UnityEngine.Coroutine val_8 = this.StartCoroutine(methodName:  "LoadGame");
    }
    private System.Collections.IEnumerator LoadGame()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new PracticeModeCharacterSelectionConfirmButton.<LoadGame>d__10();
    }
    private void OnClick()
    {
        if(this.tw != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.tw, complete:  false);
        }
        
        this.btn.interactable = false;
        this.panel.interactable = false;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.DelayLockPlayer());
    }
    private System.Collections.IEnumerator DelayLockPlayer()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new PracticeModeCharacterSelectionConfirmButton.<DelayLockPlayer>d__12();
    }
    private void OnSelectionChanged(CharacterNameID selection)
    {
        var val_8;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        Character_GlobalInfo.SetLeftPlayer(nameID:  selection);
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
        
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.tw, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void PracticeModeCharacterSelectionConfirmButton::<OnSelectionChanged>b__13_0()));
    }
    public PracticeModeCharacterSelectionConfirmButton()
    {
        this.characterList = new CharacterNameID[39];
    }
    private void <OnSelectionChanged>b__13_0()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.originScale, y = V9.16B, z = V8.16B}, d:  1.2f);
        this.tw = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), loops:  0, loopType:  1);
    }

}
