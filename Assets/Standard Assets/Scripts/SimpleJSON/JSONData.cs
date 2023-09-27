using UnityEngine;

namespace SimpleJSON
{
    public class JSONData : JSONNode
    {
        // Fields
        private string m_Data;
        
        // Properties
        public override string Value { get; set; }
        
        // Methods
        public override string get_Value()
        {
            return (string)this.m_Data;
        }
        public override void set_Value(string value)
        {
            this.m_Data = value;
        }
        public JSONData(string aData)
        {
            val_1 = new System.Object();
            this.m_Data = aData;
        }
        public JSONData(float aData)
        {
            val_1 = new System.Object();
            val_1.AsFloat = aData;
        }
        public JSONData(double aData)
        {
            val_1 = new System.Object();
            val_1.AsDouble = aData;
        }
        public JSONData(bool aData)
        {
            val_1 = new System.Object();
            val_1.AsBool = aData;
        }
        public JSONData(int aData)
        {
            val_1 = new System.Object();
            val_1.AsInt = aData;
        }
        public override string ToString()
        {
            return "\"" + SimpleJSON.JSONNode.Escape(aText:  this.m_Data)(SimpleJSON.JSONNode.Escape(aText:  this.m_Data)) + "\"";
        }
        public override string ToString(string aPrefix)
        {
            return "\"" + SimpleJSON.JSONNode.Escape(aText:  this.m_Data)(SimpleJSON.JSONNode.Escape(aText:  this.m_Data)) + "\"";
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_11;
            var val_15;
            var val_16;
            var val_17;
            var val_19;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            val_31 = aWriter;
            val_32 = this;
            SimpleJSON.JSONData val_1 = null;
            val_33 = val_1;
            val_1 = new SimpleJSON.JSONData();
            .m_Data = "";
            val_1.AsInt = this.AsInt;
            if((System.String.op_Equality(a:  (SimpleJSON.JSONData)[1152921525930223440].m_Data, b:  this.m_Data)) == false)
            {
                goto label_3;
            }
            
            int val_4 = this.AsInt;
            label_14:
            val_34 = ???;
            val_32 = ???;
            val_31 = ???;
            val_33 = ???;
            goto typeof(System.IO.BinaryWriter).__il2cppRuntimeField_248;
            label_3:
            if((System.String.op_Equality(a:  val_33 + 16, b:  val_32 + 16)) == false)
            {
                goto label_6;
            }
            
            val_34 = val_7;
            val_32 = val_8;
            val_31 = val_9;
            val_33 = val_11;
            goto val_31 + 648;
            label_6:
            if((System.String.op_Equality(a:  val_11 + 16, b:  val_8 + 16)) == false)
            {
                goto label_9;
            }
            
            val_34 = val_15;
            val_32 = val_16;
            val_31 = val_17;
            val_33 = val_19;
            goto val_9 + 536;
            label_9:
            var val_21 = val_32 & 1;
            if((System.String.op_Equality(a:  val_19 + 16, b:  val_16 + 16)) == false)
            {
                goto val_17 + 664;
            }
            
            var val_23 = val_32 & 1;
            goto label_14;
        }
    
    }

}
