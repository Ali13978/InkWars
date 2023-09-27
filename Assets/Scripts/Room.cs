using UnityEngine;
[Serializable]
public class NFClientUser.Room
{
    // Fields
    public string poolID;
    public string matchID;
    public string hostUsername;
    public string guestUsername;
    public string creationDate;
    public decimal wager;
    public bool started;
    public NFClientUser.RoomExtraData extraData;
    
    // Methods
    public NFClientUser.Room()
    {
    
    }

}
