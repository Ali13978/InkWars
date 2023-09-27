using UnityEngine;
public class CharacterSelectAvatar : MonoBehaviour
{
    // Fields
    private CharacterSelectPanel panel;
    private UnityEngine.UI.Image avatar;
    private UnityEngine.RectTransform avatarRt;
    private UnityEngine.UI.Image light;
    private UnityEngine.UI.Image woodBoard;
    private UnityEngine.RectTransform rankingGroup;
    private UnityEngine.UI.Image rankingImage;
    private TMPro.TextMeshProUGUI bpText;
    private DG.Tweening.Tweener lightTw;
    
    // Methods
    private void Awake()
    {
        this.avatarRt = this.avatar.GetComponent<UnityEngine.RectTransform>();
    }
    private void OnEnable()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.clear;
        this.avatar.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        UnityEngine.Color val_2 = UnityEngine.Color.clear;
        this.light.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        UnityEngine.Color val_3 = UnityEngine.Color.clear;
        this.woodBoard.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.rankingGroup.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        this.panel.OnCharacterChanged.AddListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  System.Void CharacterSelectAvatar::OnSelectionChanged(CharacterNameID selection)));
        this.panel.OnEntryDone.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectAvatar::OnPanelEnterDone()));
    }
    private void OnDisable()
    {
        this.panel.OnCharacterChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  System.Void CharacterSelectAvatar::OnSelectionChanged(CharacterNameID selection)));
        this.panel.OnEntryDone.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectAvatar::OnPanelEnterDone()));
    }
    private void OnPanelEnterDone()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOColor(target:  this.woodBoard, endValue:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a}, duration:  0.5f);
    }
    private void OnSelectionChanged(CharacterNameID selection)
    {
        if(this.lightTw != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.lightTw, complete:  false);
        }
        
        UnityEngine.Color val_1 = UnityEngine.Color.clear;
        this.avatar.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        UnityEngine.Color val_2 = UnityEngine.Color.clear;
        this.light.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.rankingGroup.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        Character_GlobalInfo.SetLeftPlayer(nameID:  selection);
        CharacterAssetLoader.Get(id:  selection, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  this, method:  System.Void CharacterSelectAvatar::<OnSelectionChanged>b__13_0(CharacterAssetLoader loader)));
    }
    public CharacterSelectAvatar()
    {
    
    }
    private void <OnSelectionChanged>b__13_0(CharacterAssetLoader loader)
    {
        var val_18;
        this.avatar.sprite = loader.LoadPose_Dynamic();
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.avatar.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        this.avatarRt.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScaleX(target:  this.avatarRt, endValue:  0f, duration:  0.3f)), ease:  27);
        val_18 = null;
        val_18 = null;
        this.rankingImage.sprite = RankingCollection.GetRankSprite(rank:  DataStructs.UserDataDictionary.Stats.CurrentCharacterRank);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = DataStructs.UserDataDictionary.Stats.CurrentCharacterBP;
        this.bpText.text = val_9.currentCryptoKey.ToString();
        UnityEngine.Color val_11 = UnityEngine.Color.white;
        this.lightTw = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOColor(target:  this.light, endValue:  new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a}, duration:  0.5f), ease:  30);
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
        this.rankingGroup.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        DG.Tweening.Tweener val_17 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScaleY(target:  this.rankingGroup, endValue:  0f, duration:  0.5f)), ease:  27);
    }

}
