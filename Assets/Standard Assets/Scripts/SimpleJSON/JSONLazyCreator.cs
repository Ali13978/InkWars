using UnityEngine;

namespace SimpleJSON
{
    internal class JSONLazyCreator : JSONNode
    {
        // Fields
        private SimpleJSON.JSONNode m_Node;
        private string m_Key;
        
        // Properties
        public override SimpleJSON.JSONNode Item { get; set; }
        public override SimpleJSON.JSONNode Item { get; set; }
        public override int AsInt { get; set; }
        public override float AsFloat { get; set; }
        public override double AsDouble { get; set; }
        public override bool AsBool { get; set; }
        public override SimpleJSON.JSONArray AsArray { get; }
        public override SimpleJSON.JSONClass AsObject { get; }
        
        // Methods
        public JSONLazyCreator(SimpleJSON.JSONNode aNode)
        {
            val_1 = new System.Object();
            this.m_Node = aNode;
            this.m_Key = 0;
        }
        public JSONLazyCreator(SimpleJSON.JSONNode aNode, string aKey)
        {
            val_1 = new System.Object();
            this.m_Node = aNode;
            this.m_Key = val_1;
        }
        private void Set(SimpleJSON.JSONNode aVal)
        {
            if(this.m_Key != null)
            {
                    if(this.m_Node != null)
            {
                goto label_2;
            }
            
            }
            
            label_2:
            this.m_Node = 0;
        }
        public override SimpleJSON.JSONNode get_Item(int aIndex)
        {
            .m_Node = this;
            .m_Key = 0;
            return (SimpleJSON.JSONNode)new SimpleJSON.JSONLazyCreator();
        }
        public override void set_Item(int aIndex, SimpleJSON.JSONNode value)
        {
            SimpleJSON.JSONArray val_1 = new SimpleJSON.JSONArray();
            val_1.Add(aItem:  value);
            this.Set(aVal:  val_1);
        }
        public override SimpleJSON.JSONNode get_Item(string aKey)
        {
            .m_Node = this;
            .m_Key = aKey;
            return (SimpleJSON.JSONNode)new SimpleJSON.JSONLazyCreator();
        }
        public override void set_Item(string aKey, SimpleJSON.JSONNode value)
        {
            this.Set(aVal:  new SimpleJSON.JSONClass());
        }
        public override void Add(SimpleJSON.JSONNode aItem)
        {
            SimpleJSON.JSONArray val_1 = new SimpleJSON.JSONArray();
            val_1.Add(aItem:  aItem);
            this.Set(aVal:  val_1);
        }
        public override void Add(string aKey, SimpleJSON.JSONNode aItem)
        {
            this.Set(aVal:  new SimpleJSON.JSONClass());
        }
        public static bool op_Equality(SimpleJSON.JSONLazyCreator a, object b)
        {
            a = ((b == 0) ? 1 : 0) | ((a == b) ? 1 : 0);
            return (bool)a;
        }
        public static bool op_Inequality(SimpleJSON.JSONLazyCreator a, object b)
        {
            a = ((a != b) ? 1 : 0) & ((b != 0) ? 1 : 0);
            return (bool)a;
        }
        public override bool Equals(object obj)
        {
            this = ((obj == 0) ? 1 : 0) | ((this == obj) ? 1 : 0);
            return (bool)this;
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        public override string ToString()
        {
            return "";
        }
        public override string ToString(string aPrefix)
        {
            return "";
        }
        public override int get_AsInt()
        {
            SimpleJSON.JSONData val_1 = new SimpleJSON.JSONData();
            val_1.AsInt = 0;
            this.Set(aVal:  val_1);
            return 0;
        }
        public override void set_AsInt(int value)
        {
            SimpleJSON.JSONData val_1 = new SimpleJSON.JSONData();
            val_1.AsInt = value;
            this.Set(aVal:  val_1);
        }
        public override float get_AsFloat()
        {
            SimpleJSON.JSONData val_1 = new SimpleJSON.JSONData();
            val_1.AsFloat = 0f;
            this.Set(aVal:  val_1);
            return 0f;
        }
        public override void set_AsFloat(float value)
        {
            SimpleJSON.JSONData val_1 = new SimpleJSON.JSONData();
            val_1.AsFloat = value;
            this.Set(aVal:  val_1);
        }
        public override double get_AsDouble()
        {
            SimpleJSON.JSONData val_1 = new SimpleJSON.JSONData();
            val_1.AsDouble = 0;
            this.Set(aVal:  val_1);
            return 0;
        }
        public override void set_AsDouble(double value)
        {
            SimpleJSON.JSONData val_1 = new SimpleJSON.JSONData();
            val_1.AsDouble = value;
            this.Set(aVal:  val_1);
        }
        public override bool get_AsBool()
        {
            SimpleJSON.JSONData val_1 = new SimpleJSON.JSONData();
            val_1.AsBool = false;
            this.Set(aVal:  val_1);
            return false;
        }
        public override void set_AsBool(bool value)
        {
            SimpleJSON.JSONData val_1 = new SimpleJSON.JSONData();
            val_1.AsBool = value;
            this.Set(aVal:  val_1);
        }
        public override SimpleJSON.JSONArray get_AsArray()
        {
            SimpleJSON.JSONArray val_1 = new SimpleJSON.JSONArray();
            this.Set(aVal:  val_1);
            return val_1;
        }
        public override SimpleJSON.JSONClass get_AsObject()
        {
            SimpleJSON.JSONClass val_1 = new SimpleJSON.JSONClass();
            this.Set(aVal:  val_1);
            return val_1;
        }
    
    }

}
