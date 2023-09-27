using UnityEngine;
public static class MMOCUser
{
    // Fields
    private static MMOCClientUser _curr;
    private static MMOCClientUser _AIUser;
    
    // Properties
    public static MMOCClientUser current { get; }
    public static MMOCClientUser AIUser { get; }
    
    // Methods
    public static MMOCClientUser get_current()
    {
        MMOCClientUser val_2;
        MMOCClientUser val_3 = MMOCUser._curr;
        if(val_3 != null)
        {
                return val_3;
        }
        
        MMOCClientUser val_1 = null;
        val_2 = val_1;
        val_1 = new MMOCClientUser();
        MMOCUser._curr = val_2;
        val_3 = MMOCUser._curr;
        return val_3;
    }
    public static MMOCClientUser get_AIUser()
    {
        MMOCClientUser val_2;
        MMOCClientUser val_3 = MMOCUser._AIUser;
        if(val_3 != null)
        {
                return val_3;
        }
        
        MMOCClientUser val_1 = null;
        val_2 = val_1;
        val_1 = new MMOCClientUser();
        MMOCUser._AIUser = val_2;
        val_3 = MMOCUser._AIUser;
        return val_3;
    }
    public static void Logout()
    {
        MMOCUser._curr = 0;
        MMOCUser._AIUser = 0;
    }

}
