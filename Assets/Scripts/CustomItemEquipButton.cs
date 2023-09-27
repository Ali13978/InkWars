using UnityEngine;
public class CustomItemEquipButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button equipButton;
    private TMPro.TextMeshProUGUI equipTitleTxt;
    private UnityEngine.AudioClip equipClip;
    
    // Methods
    public void Refresh()
    {
        this.equipButton.interactable = (~(CustomItemCanvas.<itemGroup>k__BackingField)) & 1;
        this.equipTitleTxt.text = LanguageManager.GetText(key:  (this.equipButton.interactable != true) ? "LK.EQUIP" : "LK.EQUIPED");
    }
    private void OnEnable()
    {
        this.equipButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CustomItemEquipButton::OnEquip()));
        this.equipButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CustomItemEquipButton::OnEquip()));
    }
    private void OnDisable()
    {
        this.equipButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CustomItemEquipButton::OnEquip()));
    }
    private void OnEquip()
    {
        CustomItemCanvas.selectionGrid.CleanEquippedIcon();
        UnityEngine.AudioSource val_3 = GameAudio.sound.PlayOneShot(clip:  this.equipClip, volume:  1f);
        CustomItemCanvas.selectionGrid.RefreshSelectItem();
        CustomItemCanvas.selectionGrid.RefreshEquippedItem();
        this.Refresh();
    }
    public CustomItemEquipButton()
    {
    
    }

}
