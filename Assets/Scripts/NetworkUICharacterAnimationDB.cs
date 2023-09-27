using UnityEngine;
public class NetworkUICharacterAnimationDB : MonoBehaviour
{
    // Fields
    private InkBrushCharacterAnimationSerializableData[] m_CharacterAnimationDataDB;
    private InkBrushCharacterAnimationSerializableData[] m_CharacterAnimationDataMatchDB;
    private InkBrushCharacterAnimationSerializableData[] m_CharacterAnimationDataLeaderboardsDB;
    private InkBrushCharacterAnimationSerializableData[] m_CharacterAnimationDataProfileEditDB;
    private int random;
    
    // Properties
    public InkBrushCharacterAnimationSerializableData[] CharacterAnimationDataDB { get; }
    
    // Methods
    public InkBrushCharacterAnimationSerializableData[] get_CharacterAnimationDataDB()
    {
        return (InkBrushCharacterAnimationSerializableData[])this.m_CharacterAnimationDataDB;
    }
    public void Randomize()
    {
        object val_6;
        int val_1 = this.m_CharacterAnimationDataDB.Length - 1;
        this.random = UnityEngine.Random.Range(min:  0, max:  val_1);
        object[] val_3 = new object[3];
        if(val_3 == null)
        {
            goto label_2;
        }
        
        if(val_1 != 0)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_1 == 0)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_3[0] = val_1;
        val_3[1] = val_1;
        val_6 = this.random;
        val_3[2] = val_6;
        UnityEngine.Debug.LogFormat(format:  "Max Length: {0}, Max Length - 1: {1}, Random: {2}", args:  val_3);
        int val_6 = this.random;
        var val_4 = (val_6 < 0) ? (val_6 + 1) : (val_6);
        val_4 = val_4 & 4294967294;
        val_6 = val_6 - val_4;
        if(val_6 != 1)
        {
                return;
        }
        
        object[] val_5 = new object[2];
        val_5[0] = this.random;
        int val_7 = this.random;
        val_7 = val_7 + 1;
        val_6 = val_7;
        val_5[1] = val_6;
        UnityEngine.Debug.LogFormat(format:  "Random is odd number {0}, it is now {1}", args:  val_5);
        int val_8 = this.random;
        val_8 = val_8 + 1;
        this.random = val_8;
    }
    public InkBrushCharacterAnimationSerializableData GetCurrentPairLeft()
    {
        return (InkBrushCharacterAnimationSerializableData)this.m_CharacterAnimationDataDB[this.random];
    }
    public InkBrushCharacterAnimationSerializableData GetCurrentPairRight()
    {
        return (InkBrushCharacterAnimationSerializableData)this.m_CharacterAnimationDataDB[(long)this.random + 1];
    }
    public InkBrushCharacterAnimationSerializableData GetRandomMatchCharacter()
    {
        return (InkBrushCharacterAnimationSerializableData)this.m_CharacterAnimationDataMatchDB[(long)UnityEngine.Random.Range(min:  0, max:  this.m_CharacterAnimationDataMatchDB.Length)];
    }
    public InkBrushCharacterAnimationSerializableData GetRandomLeaderboardCharacter()
    {
        return (InkBrushCharacterAnimationSerializableData)this.m_CharacterAnimationDataLeaderboardsDB[(long)UnityEngine.Random.Range(min:  0, max:  this.m_CharacterAnimationDataLeaderboardsDB.Length)];
    }
    public InkBrushCharacterAnimationSerializableData GetRandomProfileCharacter()
    {
        return (InkBrushCharacterAnimationSerializableData)this.m_CharacterAnimationDataProfileEditDB[(long)UnityEngine.Random.Range(min:  0, max:  this.m_CharacterAnimationDataProfileEditDB.Length)];
    }
    public NetworkUICharacterAnimationDB()
    {
    
    }

}
