using UnityEngine;
public class Manager : Singleton<Manager>
{
    // Fields
    public string myGlobalVar;
    
    // Methods
    protected Manager()
    {
        this.myGlobalVar = "whatever";
    }

}
