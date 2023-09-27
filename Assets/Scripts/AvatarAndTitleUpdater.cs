using UnityEngine;
public class AvatarAndTitleUpdater : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image m_avatar;
    private CustomTitle m_title;
    public static UnityEngine.Events.UnityEvent OnAvatarAndTitleChangedEvent;
    
    // Methods
    private void OnAvatarAndTitleChange()
    {
        this.UpdateAvatarAndTitle();
    }
    private void OnEnable()
    {
        var val_2;
        this.UpdateAvatarAndTitle();
        val_2 = null;
        val_2 = null;
        AvatarAndTitleUpdater.OnAvatarAndTitleChangedEvent.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void AvatarAndTitleUpdater::OnAvatarAndTitleChange()));
    }
    private void OnDisable()
    {
        null = null;
        AvatarAndTitleUpdater.OnAvatarAndTitleChangedEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void AvatarAndTitleUpdater::OnAvatarAndTitleChange()));
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    public void UpdateAvatarAndTitle()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedTitle;
        this.m_title.Setup(title:  TitleCollection.GetTitleFromIntId(id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited})));
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = DataStructs.UserDataDictionary.Settings.SelectedAvatar;
        this.m_avatar.sprite = AvatarCollection.GetAvatarSpriteFromIntId(id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited}));
    }
    public AvatarAndTitleUpdater()
    {
    
    }
    private static AvatarAndTitleUpdater()
    {
        AvatarAndTitleUpdater.OnAvatarAndTitleChangedEvent = new UnityEngine.Events.UnityEvent();
    }

}
