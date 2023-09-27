using UnityEngine;
public class TitleCustomization : MonoBehaviour
{
    // Fields
    private TitleGridView m_titleGridView;
    private CustomTitle m_Title;
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
        this.m_titleGridView.AddListener(call:  new UnityEngine.Events.UnityAction<ProfileUnlockables_Title>(object:  this, method:  System.Void TitleCustomization::OnTitleEquip(ProfileUnlockables_Title data)));
    }
    private void OnDisable()
    {
        this.m_titleGridView.RemoveListener(call:  new UnityEngine.Events.UnityAction<ProfileUnlockables_Title>(object:  this, method:  System.Void TitleCustomization::OnTitleEquip(ProfileUnlockables_Title data)));
    }
    private void OnTitleEquip(ProfileUnlockables_Title data)
    {
        this.OnTitleEquipSFX(data:  data, enableSound:  true);
    }
    private void OnTitleEquipSFX(ProfileUnlockables_Title data, bool enableSound)
    {
        var val_5;
        var val_6;
        this.m_Title.Setup(title:  data);
        val_5 = null;
        val_5 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  data.GetIntId());
        DataStructs.UserDataDictionary.Settings.SelectedTitle = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited};
        val_6 = null;
        val_6 = null;
        AvatarAndTitleUpdater.OnAvatarAndTitleChangedEvent.Invoke();
        if(enableSound == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_4 = GameAudio.sound.PlayOneShot(clip:  this.onEquipSound, volume:  1f);
    }
    public TitleCustomization()
    {
    
    }

}
