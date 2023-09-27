using UnityEngine;
public class RPCFunctionsMessage : MessageBase
{
    // Fields
    public LanPlaySceneManager.function functionNumber;
    public int[] intVariables;
    public string string1;
    
    // Methods
    public RPCFunctionsMessage()
    {
    
    }
    public override void Serialize(UnityEngine.Networking.NetworkWriter writer)
    {
        writer.Write(value:  this.functionNumber);
        Unity.GeneratedNetworkCode._WriteArrayInt32_None(writer:  writer, value:  this.intVariables);
        writer.Write(value:  this.string1);
    }
    public override void Deserialize(UnityEngine.Networking.NetworkReader reader)
    {
        if(reader != null)
        {
                this.functionNumber = reader.ReadInt32();
            this.intVariables = Unity.GeneratedNetworkCode._ReadArrayInt32_None(reader:  reader);
        }
        else
        {
                this.functionNumber = 0.ReadInt32();
            this.intVariables = Unity.GeneratedNetworkCode._ReadArrayInt32_None(reader:  0);
        }
        
        this.string1 = reader.ReadString();
    }

}
