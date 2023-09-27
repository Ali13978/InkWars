using UnityEngine;
public class NFConfig
{
    // Fields
    private System.Xml.XmlDocument xmldoc;
    private System.Xml.XmlNode root;
    private System.Collections.ArrayList aWorldList;
    
    // Methods
    public void Load()
    {
        this.xmldoc = new System.Xml.XmlDocument();
        this.root = this.xmldoc.SelectSingleNode(xpath:  "XML");
    }
    public System.Collections.ArrayList GetServerList()
    {
        System.Collections.ArrayList val_7;
        string val_8;
        var val_9;
        val_7 = this.aWorldList;
        if(val_7 != null)
        {
                return val_7;
        }
        
        this.aWorldList = new System.Collections.ArrayList();
        val_8 = "Server";
        System.Xml.XmlNodeList val_3 = this.root.SelectSingleNode(xpath:  "Servers").SelectNodes(xpath:  val_8);
        val_9 = 0;
        goto label_4;
        label_12:
        val_8 = val_3.ItemOf["IP"] + ":"(":") + val_3.ItemOf["Port"];
        val_9 = 1;
        label_4:
        if(val_9 < val_3)
        {
            goto label_12;
        }
        
        val_7 = this.aWorldList;
        return val_7;
    }
    public bool GetSelectServer(ref string strIP, ref int nPort)
    {
        var val_6;
        var val_7;
        var val_8;
        val_7 = this.GetServerList();
        if(val_7 == null)
        {
                return (bool)val_6;
        }
        
        if(val_7 >= 1)
        {
                val_8 = val_7;
            char[] val_2 = new char[1];
            val_2[0] = ':';
            if(val_8 != null)
        {
                val_8 = 0;
        }
        
            val_7 = val_8.Split(separator:  val_2);
            if(val_4.Length == 2)
        {
                strIP = val_7[0];
            nPort = System.Int32.Parse(s:  val_7[1]);
            val_6 = 1;
            return (bool)val_6;
        }
        
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    public string GetDataPath()
    {
        if((this.root.SelectSingleNode(xpath:  "Evironment").SelectSingleNode(xpath:  "DataPath").ItemOf["ID"]) == null)
        {
            
        }
    
    }
    public NFConfig()
    {
    
    }

}
