using UnityEngine;
[Serializable]
public class GameServerInfo
{
    // Fields
    public string id;
    public string IP;
    public string protocol;
    public int RESTPort;
    public int TCPPort;
    public bool display;
    public int order;
    public System.Collections.Generic.List<GameServerInfo.GameServerLocalization> localization;
    
    // Properties
    public GameServerInfo.GameServerLocalization English { get; }
    public string RestUrl { get; }
    public string RestUrlWithPort { get; }
    
    // Methods
    public GameServerInfo.GameServerLocalization GetLocalization()
    {
        System.Collections.Generic.List<GameServerLocalization> val_5;
        var val_6;
        var val_8;
        val_5 = this;
        val_6 = null;
        val_6 = null;
        if((GameServerInfo.<>c.<>9__9_0) == null)
        {
            goto label_3;
        }
        
        label_13:
        if((this.localization.Find(match:  GameServerInfo.<>c.<>9__9_0)) != null)
        {
                return (GameServerLocalization)val_8;
        }
        
        if(this.localization.Count < 1)
        {
            goto label_7;
        }
        
        val_5 = this.localization;
        GameServerLocalization val_3 = val_5.Item[0];
        return (GameServerLocalization)val_8;
        label_3:
        GameServerInfo.<>c.<>9__9_0 = new System.Predicate<GameServerLocalization>(object:  GameServerInfo.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameServerInfo.<>c::<GetLocalization>b__9_0(GameServerInfo.GameServerLocalization x));
        if(this.localization != null)
        {
            goto label_13;
        }
        
        goto label_13;
        label_7:
        val_8 = 0;
        return (GameServerLocalization)val_8;
    }
    public GameServerInfo.GameServerLocalization GetLocalization(UnityEngine.SystemLanguage language)
    {
        System.Collections.Generic.List<GameServerLocalization> val_6;
        var val_7;
        val_6 = this;
        .language = language;
        if((this.localization.Find(match:  new System.Predicate<GameServerLocalization>(object:  new GameServerInfo.<>c__DisplayClass10_0(), method:  System.Boolean GameServerInfo.<>c__DisplayClass10_0::<GetLocalization>b__0(GameServerInfo.GameServerLocalization x)))) != null)
        {
                return (GameServerLocalization)val_7;
        }
        
        if(this.localization.Count >= 1)
        {
                val_6 = this.localization;
            GameServerLocalization val_5 = val_6.Item[0];
            return (GameServerLocalization)val_7;
        }
        
        val_7 = 0;
        return (GameServerLocalization)val_7;
    }
    public GameServerInfo.GameServerLocalization get_English()
    {
        return this.GetLocalization(language:  10);
    }
    public string get_RestUrl()
    {
        return System.String.Format(format:  "{0}://{1}", arg0:  this.protocol, arg1:  this.IP);
    }
    public string get_RestUrlWithPort()
    {
        return (string)System.String.Format(format:  "{0}://{1}:{2}", arg0:  this.protocol, arg1:  this.IP, arg2:  this.RESTPort);
    }
    public override string ToString()
    {
        object[] val_1 = new object[5];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(this.id != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(this.id == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = this.id;
        val_1[1] = this.RestUrlWithPort;
        val_1[2] = this.TCPPort;
        val_1[3] = this.display;
        val_1[4] = this.order;
        return (string)System.String.Format(format:  "[GameServerInfo id: {0}, url: {1}, TCP Port: {1}, display: {2}, order: {3}]", args:  val_1);
    }
    public string ToJson()
    {
        return UnityEngine.JsonUtility.ToJson(obj:  this);
    }
    public GameServerInfo()
    {
        this.display = true;
        this.protocol = "http";
        this.RESTPort = 8080;
        this.TCPPort = 14001;
        this.localization = new System.Collections.Generic.List<GameServerLocalization>();
    }

}
