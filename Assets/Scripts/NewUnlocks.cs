using UnityEngine;
public class NewUnlocks
{
    // Fields
    public static NewUnlocks NewUnlocksThisCheck;
    public static CharacterNameID CharacterUsedForUnlocks;
    public System.Collections.Generic.List<Avatars_Specific_Key> AvatarSpecifics;
    public System.Collections.Generic.List<Avatars_Common_Key> AvatarCommons;
    public System.Collections.Generic.List<Titles_Specific_Key> TitleSpecifics;
    public System.Collections.Generic.List<Titles_Common_Key> TitleCommons;
    
    // Methods
    public static void ResetNewUnlockData(CharacterNameID charID)
    {
        var val_2 = null;
        NewUnlocks.NewUnlocksThisCheck = new NewUnlocks();
        NewUnlocks.CharacterUsedForUnlocks = charID;
    }
    public NewUnlocks()
    {
        this.AvatarSpecifics = new System.Collections.Generic.List<Avatars_Specific_Key>();
        this.AvatarCommons = new System.Collections.Generic.List<Avatars_Common_Key>();
        this.TitleSpecifics = new System.Collections.Generic.List<Titles_Specific_Key>();
        this.TitleCommons = new System.Collections.Generic.List<Titles_Common_Key>();
    }
    public void Add(Avatars_Specific_Key key)
    {
        this.AvatarSpecifics.Add(item:  key);
    }
    public void Add(Avatars_Common_Key key)
    {
        this.AvatarCommons.Add(item:  key);
    }
    public void Add(Titles_Specific_Key key)
    {
        this.TitleSpecifics.Add(item:  key);
    }
    public void Add(Titles_Common_Key key)
    {
        this.TitleCommons.Add(item:  key);
    }
    private static NewUnlocks()
    {
        NewUnlocks.NewUnlocksThisCheck = new NewUnlocks();
    }

}
