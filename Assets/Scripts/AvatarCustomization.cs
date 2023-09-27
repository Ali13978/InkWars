using UnityEngine;
public class AvatarCustomization : MonoBehaviour
{
    // Fields
    private AvatarGridView m_avatarGridView;
    private UnityEngine.UI.Image m_Avatar;
    private UnityEngine.AudioClip onEquipSound;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    private void OnEnable()
    {
        this.m_avatarGridView.AddListener(call:  new UnityEngine.Events.UnityAction<ProfileUnlockables_Avatar>(object:  this, method:  System.Void AvatarCustomization::OnAvatarEquip(ProfileUnlockables_Avatar data)));
    }
    private void OnDisable()
    {
        this.m_avatarGridView.RemoveListener(call:  new UnityEngine.Events.UnityAction<ProfileUnlockables_Avatar>(object:  this, method:  System.Void AvatarCustomization::OnAvatarEquip(ProfileUnlockables_Avatar data)));
    }
    private void OnAvatarEquip(ProfileUnlockables_Avatar data)
    {
        this.OnAvatarEquipSFX(data:  data, enableSound:  true);
    }
    private void OnAvatarEquipSFX(ProfileUnlockables_Avatar data, bool enableSound)
    {
        var val_5;
        var val_6;
        this.m_Avatar.sprite = data.Sprite_Avatar;
        val_5 = null;
        val_5 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  data.GetIntId());
        DataStructs.UserDataDictionary.Settings.SelectedAvatar = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited};
        val_6 = null;
        val_6 = null;
        AvatarAndTitleUpdater.OnAvatarAndTitleChangedEvent.Invoke();
        if(enableSound == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_4 = GameAudio.sound.PlayOneShot(clip:  this.onEquipSound, volume:  1f);
    }
    public AvatarCustomization()
    {
    
    }

}
