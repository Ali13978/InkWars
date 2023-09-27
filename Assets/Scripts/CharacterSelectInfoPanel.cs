using UnityEngine;
public class CharacterSelectInfoPanel : MonoBehaviour
{
    // Fields
    private CharacterSelectPanel panel;
    private CharacterNameController nameController;
    private UnityEngine.UI.Image tagImage;
    private UnityEngine.UI.Image puzzleFill;
    private UnityEngine.UI.Image battleFill;
    private UnityEngine.UI.Image exBattleFill;
    private UnityEngine.GameObject progressBars;
    private UnityEngine.Vector3 originPos;
    private UnityEngine.Vector3 originNameScale;
    private UnityEngine.Vector3 originTagScale;
    private UnityEngine.Vector3 originFillScale;
    private UnityEngine.RectTransform rt;
    
    // Methods
    private void Awake()
    {
        UnityEngine.RectTransform val_1 = this.GetComponent<UnityEngine.RectTransform>();
        this.rt = val_1;
        UnityEngine.Vector3 val_2 = val_1.anchoredPosition3D;
        this.originPos = val_2;
        mem[1152921528912294484] = val_2.y;
        mem[1152921528912294488] = val_2.z;
        UnityEngine.Vector3 val_4 = this.nameController.GetComponent<UnityEngine.RectTransform>().localScale;
        this.originNameScale = val_4;
        mem[1152921528912294496] = val_4.y;
        mem[1152921528912294500] = val_4.z;
        UnityEngine.Vector3 val_6 = this.tagImage.transform.localScale;
        this.originTagScale = val_6;
        mem[1152921528912294508] = val_6.y;
        mem[1152921528912294512] = val_6.z;
        if(0 == this.progressBars)
        {
                return;
        }
        
        UnityEngine.Vector3 val_9 = this.progressBars.transform.localScale;
        this.originFillScale = val_9;
        mem[1152921528912294520] = val_9.y;
        mem[1152921528912294524] = val_9.z;
    }
    private void OnEnable()
    {
        this.rt.anchoredPosition3D = new UnityEngine.Vector3() {x = this.originPos, y = V9.16B, z = V10.16B};
        UnityEngine.Color val_1 = UnityEngine.Color.clear;
        this.tagImage.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        if(0 != this.progressBars)
        {
                this.progressBars.gameObject.SetActive(value:  false);
        }
        
        this.nameController.characterId = 63;
        this.panel.OnCharacterChanged.AddListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  System.Void CharacterSelectInfoPanel::OnSelectionChanged(CharacterNameID selection)));
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos3D(target:  this.rt, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  2f, snapping:  false), ease:  30);
    }
    private void OnDisable()
    {
        this.panel.OnCharacterChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  System.Void CharacterSelectInfoPanel::OnSelectionChanged(CharacterNameID selection)));
    }
    private void OnEntryDone()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOAnchorPos3D(target:  this.rt, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  1f, snapping:  false);
    }
    private void OnSelectionChanged(CharacterNameID selection)
    {
        UnityEngine.UI.Image val_30;
        var val_31;
        this.nameController.characterId = selection;
        UnityEngine.Vector2 val_2 = this.nameController.GetComponent<UnityEngine.RectTransform>().sizeDelta;
        this.nameController.GetComponent<UnityEngine.RectTransform>().sizeDelta = new UnityEngine.Vector2() {x = 500f, y = val_2.y};
        this.nameController.GetComponent<UnityEngine.RectTransform>().localScale = new UnityEngine.Vector3() {x = this.originNameScale, y = V10.16B, z = V11.16B};
        DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScaleX(target:  this.nameController.GetComponent<UnityEngine.RectTransform>(), endValue:  0f, duration:  0.5f)), ease:  27);
        this.tagImage.transform.localScale = new UnityEngine.Vector3() {x = this.originTagScale, y = V10.16B, z = V11.16B};
        this.tagImage.sprite = CharacterAssetLoader.LoadResource_CharacterStatType(charNameID:  selection, left:  false);
        UnityEngine.Color val_11 = UnityEngine.Color.white;
        this.tagImage.color = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a};
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_16 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tagImage.transform, endValue:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, duration:  0.5f)), ease:  27);
        val_30 = this.puzzleFill;
        if(val_30 == 0)
        {
                return;
        }
        
        val_30 = this.battleFill;
        if(val_30 == 0)
        {
                return;
        }
        
        val_30 = this.exBattleFill;
        if(val_30 == 0)
        {
                return;
        }
        
        Character_GlobalInfo.SetMainPlayer(nameID:  selection);
        val_31 = null;
        val_31 = null;
        this.progressBars.gameObject.SetActive(value:  true);
        UnityEngine.Vector2 val_23 = this.progressBars.GetComponent<UnityEngine.RectTransform>().sizeDelta;
        this.progressBars.GetComponent<UnityEngine.RectTransform>().sizeDelta = new UnityEngine.Vector2() {x = 500f, y = val_23.y};
        this.progressBars.GetComponent<UnityEngine.RectTransform>().localScale = new UnityEngine.Vector3() {x = this.originFillScale, y = val_23.y, z = val_11.g};
        DG.Tweening.Tweener val_29 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScaleX(target:  this.progressBars.GetComponent<UnityEngine.RectTransform>(), endValue:  0f, duration:  0.5f)), ease:  27);
        this.SetupAdventureProgressData(data:  DataStructs.UserDataDictionary.GameSave.GetAdventureProgressByID(cid:  selection));
    }
    private void SetupAdventureProgressData(DataStructs.AdventureProgress data)
    {
        this.puzzleFill.fillAmount = data.GetPassedLevelProgress(mode:  1);
        this.battleFill.fillAmount = data.GetPassedLevelProgress(mode:  0);
        this.exBattleFill.fillAmount = data.GetPassedLevelProgress(mode:  2);
    }
    public CharacterSelectInfoPanel()
    {
    
    }

}
