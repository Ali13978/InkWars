using UnityEngine;
[Serializable]
public class TutorialDataManager.PlayerData
{
    // Fields
    public CharacterNameID charNameID;
    public float CharacterSpeedInSeconds;
    public float StunAttributeTime;
    public bool IsTako;
    public int RainbowFrequency;
    public int RainbowEvery;
    public int MissEvery;
    private int rainbowCounter;
    private int missEveryCounter;
    internal bool isReloading;
    internal bool isStunned;
    public UnityEngine.GameObject gameObject;
    private System.Nullable<UnityEngine.Vector3> _originalPosition;
    
    // Properties
    public bool isWaiting { get; }
    public UnityEngine.Vector3 originalPosition { get; }
    public string JSON { get; }
    public bool NextRainbow { get; }
    public bool NextMatch { get; }
    
    // Methods
    public bool get_isWaiting()
    {
        if(this.isReloading == false)
        {
                return (bool)(this.isStunned == true) ? 1 : 0;
        }
        
        return true;
    }
    public UnityEngine.Vector3 get_originalPosition()
    {
        if((this._originalPosition & 1) != 0)
        {
                return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        
        UnityEngine.Vector3 val_2 = this.gameObject.transform.position;
        this._originalPosition = 0;
        mem[1152921528233283816] = 0;
        return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    public string get_JSON()
    {
        return CharNameIDConverter.CharNameIdToJSonId(charNameID:  this.charNameID)(CharNameIDConverter.CharNameIdToJSonId(charNameID:  this.charNameID)) + ".json";
    }
    public bool get_NextRainbow()
    {
        int val_1 = this.rainbowCounter;
        val_1 = val_1 - 1;
        this.rainbowCounter = val_1;
        if(val_1 > 0)
        {
                return false;
        }
        
        this.rainbowCounter = this.RainbowEvery;
        return true;
    }
    public bool get_NextMatch()
    {
        int val_1 = this.missEveryCounter;
        val_1 = val_1 - 1;
        this.missEveryCounter = val_1;
        if(val_1 > 0)
        {
                return true;
        }
        
        this.missEveryCounter = this.MissEvery;
        return false;
    }
    public TutorialDataManager.PlayerData()
    {
    
    }

}
