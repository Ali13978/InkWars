using UnityEngine;
public class RPCPlayerInformationMessage : MessageBase
{
    // Fields
    public string playerName;
    public int onlinePVPTime;
    public long wins;
    public int losses;
    public int draws;
    public int musicIndex;
    public int shells;
    
    // Methods
    public RPCPlayerInformationMessage()
    {
    
    }
    public override void Serialize(UnityEngine.Networking.NetworkWriter writer)
    {
        int val_1;
        if(writer != null)
        {
                writer.Write(value:  this.playerName);
            writer.WritePackedUInt32(value:  this.onlinePVPTime);
            writer.WritePackedUInt64(value:  this.wins);
            writer.WritePackedUInt32(value:  this.losses);
            writer.WritePackedUInt32(value:  this.draws);
            writer.WritePackedUInt32(value:  this.musicIndex);
            val_1 = this.shells;
        }
        else
        {
                0.Write(value:  this.playerName);
            0.WritePackedUInt32(value:  this.onlinePVPTime);
            0.WritePackedUInt64(value:  this.wins);
            0.WritePackedUInt32(value:  this.losses);
            0.WritePackedUInt32(value:  this.draws);
            0.WritePackedUInt32(value:  this.musicIndex);
            val_1 = this.shells;
        }
        
        writer.WritePackedUInt32(value:  val_1);
    }
    public override void Deserialize(UnityEngine.Networking.NetworkReader reader)
    {
        if(reader != null)
        {
                this.playerName = reader.ReadString();
            this.onlinePVPTime = reader.ReadPackedUInt32();
            this.wins = reader.ReadPackedUInt64();
            this.losses = reader.ReadPackedUInt32();
            this.draws = reader.ReadPackedUInt32();
            this.musicIndex = reader.ReadPackedUInt32();
        }
        else
        {
                this.playerName = 0.ReadString();
            this.onlinePVPTime = 0.ReadPackedUInt32();
            this.wins = 0.ReadPackedUInt64();
            this.losses = 0.ReadPackedUInt32();
            this.draws = 0.ReadPackedUInt32();
            this.musicIndex = 0.ReadPackedUInt32();
        }
        
        this.shells = reader.ReadPackedUInt32();
    }

}
