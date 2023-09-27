using UnityEngine;
private sealed class TitleGridView.<>c__DisplayClass3_0
{
    // Fields
    public ProfileUnlockables_Title data;
    public TitleGridView <>4__this;
    public AvatarTitleUnlockDialog dialog;
    
    // Methods
    public TitleGridView.<>c__DisplayClass3_0()
    {
    
    }
    internal void <ShowUnlockDesc>b__0()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        DataStructs.UserDataDictionary.Items.SetTitleUnlocked(title:  this.data, isUnlock:  true);
        if((this.<>4__this) != null)
        {
            
        }
        else
        {
                val_2 = 48980696;
        }
        
        this.dialog.Close();
    }

}
