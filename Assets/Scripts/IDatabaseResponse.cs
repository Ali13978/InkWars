using UnityEngine;
public class NFJson_Database.IDatabaseResponse
{
    // Fields
    public bool success;
    public string message;
    
    // Methods
    public NFJson_Database.IDatabaseResponse()
    {
        this.success = false;
        this.message = "";
    }
    public NFJson_Database.IDatabaseResponse(bool success, string message)
    {
        val_1 = new System.Object();
        this.success = success;
        this.message = val_1;
    }

}
