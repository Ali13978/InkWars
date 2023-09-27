using UnityEngine;
private sealed class CharacterAvatarController.<>c__DisplayClass27_0
{
    // Fields
    public bool isInked;
    public CharacterAvatarController <>4__this;
    
    // Methods
    public CharacterAvatarController.<>c__DisplayClass27_0()
    {
    
    }
    internal void <LoadAvatar>b__0(CharacterAssetLoader loader)
    {
        if(loader == null)
        {
            goto label_1;
        }
        
        if(this.isInked == false)
        {
            goto label_2;
        }
        
        label_4:
        UnityEngine.Sprite val_1 = loader.LoadAvatar_MainInked();
        goto label_3;
        label_1:
        if(this.isInked == true)
        {
            goto label_4;
        }
        
        label_2:
        UnityEngine.Sprite val_2 = loader.LoadAvatar_Main();
        label_3:
        val_2.SetImageSprite(img:  this.<>4__this.avatar, sp:  val_2);
        this.<>4__this.linkedLoader = loader;
    }

}
