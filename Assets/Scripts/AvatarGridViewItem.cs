using UnityEngine;
public class AvatarGridViewItem : UnlockableGridViewItem<ProfileUnlockables_Avatar, AvatarGridView>
{
    // Methods
    public override void OnClick()
    {
        if(0 == static_value_03330000)
        {
                return;
        }
        
        this = ???;
        goto static_value_03330000 + 456;
    }
    protected override void OnSetup(ProfileUnlockables_Avatar aNewData, AvatarGridView aNewParent)
    {
        UnityEngine.UI.Image val_5 = this.GetComponent<UnityEngine.UI.Image>();
        if(0 == val_5)
        {
                val_5 = this.gameObject.AddComponent<UnityEngine.UI.Image>();
        }
        
        val_5.sprite = aNewData.Sprite_Avatar;
        if((aNewData & 1) != 0)
        {
                return;
        }
        
        val_5.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    public AvatarGridViewItem()
    {
    
    }

}
