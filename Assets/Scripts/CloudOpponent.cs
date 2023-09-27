using UnityEngine;
public class CloudOpponent
{
    // Fields
    private static NetworkUserInfo _curr;
    
    // Properties
    public static NetworkUserInfo current { get; set; }
    
    // Methods
    public static NetworkUserInfo get_current()
    {
        int val_5;
        NetworkUserInfo val_6;
        var val_7;
        val_6 = CloudOpponent._curr;
        if(val_6 != null)
        {
                return val_6;
        }
        
        CloudOpponent._curr = new NetworkUserInfo();
        val_7 = null;
        if(CloudOpponent._curr == null)
        {
                val_7 = null;
        }
        
        mem[1152921529080067248] = "Ink Wars Player Two";
        mem[1152921529080067272] = AvatarCollection.GetAvatarIntId(key:  5, cid:  1);
        mem[1152921529080067276] = TitleCollection.GetTitleIntId(key:  10, cid:  10);
        val_5 = UnityEngine.Random.Range(min:  1, max:  190);
        mem[1152921529080067260] = val_5;
        val_6 = CloudOpponent._curr;
        return val_6;
    }
    public static void set_current(NetworkUserInfo value)
    {
        CloudOpponent._curr = value;
    }
    public CloudOpponent()
    {
    
    }

}
