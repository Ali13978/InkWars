using UnityEngine;

namespace SimpleJSON
{
    public class JSONArray : JSONNode, IEnumerable
    {
        // Fields
        private System.Collections.Generic.List<SimpleJSON.JSONNode> m_List;
        
        // Properties
        public override SimpleJSON.JSONNode Item { get; set; }
        public override SimpleJSON.JSONNode Item { get; set; }
        public override int Count { get; }
        public override System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> Childs { get; }
        
        // Methods
        public override SimpleJSON.JSONNode get_Item(int aIndex)
        {
            var val_4;
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_List.Count > aIndex)
            {
                    val_4 = this.m_List.Item[aIndex];
                return (SimpleJSON.JSONNode)val_4;
            }
            
            }
            
            SimpleJSON.JSONLazyCreator val_3 = null;
            val_4 = val_3;
            val_3 = new SimpleJSON.JSONLazyCreator();
            .m_Node = this;
            .m_Key = 0;
            return (SimpleJSON.JSONNode)val_4;
        }
        public override void set_Item(int aIndex, SimpleJSON.JSONNode value)
        {
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_List.Count > aIndex)
            {
                    this.m_List.set_Item(index:  aIndex, value:  value);
                return;
            }
            
            }
            
            this.m_List.Add(item:  value);
        }
        public override SimpleJSON.JSONNode get_Item(string aKey)
        {
            .m_Node = this;
            .m_Key = 0;
            return (SimpleJSON.JSONNode)new SimpleJSON.JSONLazyCreator();
        }
        public override void set_Item(string aKey, SimpleJSON.JSONNode value)
        {
            this.m_List.Add(item:  value);
        }
        public override int get_Count()
        {
            if(this.m_List != null)
            {
                    return this.m_List.Count;
            }
            
            return this.m_List.Count;
        }
        public override void Add(string aKey, SimpleJSON.JSONNode aItem)
        {
            this.m_List.Add(item:  aItem);
        }
        public override SimpleJSON.JSONNode Remove(int aIndex)
        {
            var val_3;
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_List.Count > aIndex)
            {
                    val_3 = this.m_List.Item[aIndex];
                this.m_List.RemoveAt(index:  aIndex);
                return (SimpleJSON.JSONNode)val_3;
            }
            
            }
            
            val_3 = 0;
            return (SimpleJSON.JSONNode)val_3;
        }
        public override SimpleJSON.JSONNode Remove(SimpleJSON.JSONNode aNode)
        {
            bool val_1 = this.m_List.Remove(item:  aNode);
            return (SimpleJSON.JSONNode)aNode;
        }
        public override System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> get_Childs()
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            .<>4__this = this;
            return (System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>)new JSONArray.<get_Childs>d__13();
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new JSONArray.<GetEnumerator>d__14();
        }
        public override string ToString()
        {
            string val_7;
            string val_8;
            string val_9;
            val_7 = "[ ";
            List.Enumerator<T> val_1 = this.m_List.GetEnumerator();
            label_8:
            if(((-159435752) & 1) == 0)
            {
                goto label_2;
            }
            
            System.Type val_2 = 0.InitialType;
            val_8 = 0;
            if(Length >= 3)
            {
                goto label_4;
            }
            
            val_9 = val_7;
            if(val_2 != null)
            {
                goto label_7;
            }
            
            goto label_6;
            label_4:
            val_8 = ", ";
            val_9 = val_7 + val_8;
            if(val_2 != null)
            {
                goto label_7;
            }
            
            label_6:
            label_7:
            string val_5 = val_9 + val_2;
            goto label_8;
            label_2:
            0.Add(driver:  public System.Void List.Enumerator<SimpleJSON.JSONNode>::Dispose(), rectTransform:  null, drivenProperties:  null);
            return (string)val_7 + " ]";
        }
        public override string ToString(string aPrefix)
        {
            System.Collections.Generic.List<SimpleJSON.JSONNode> val_9;
            string val_10;
            string val_11;
            val_9 = this.m_List;
            val_10 = "[ ";
            List.Enumerator<T> val_1 = val_9.GetEnumerator();
            label_6:
            if(((-159270456) & 1) == 0)
            {
                goto label_2;
            }
            
            if(Length >= 4)
            {
                    val_11 = val_10 + ", ";
            }
            
            string val_6 = aPrefix + "   ";
            string val_7 = val_11 + "\n" + aPrefix + "   "(val_11 + "\n" + aPrefix + "   ") + 0.InitialType;
            goto label_6;
            label_2:
            0.Add(driver:  public System.Void List.Enumerator<SimpleJSON.JSONNode>::Dispose(), rectTransform:  null, drivenProperties:  null);
            return (string)val_10 + "\n" + aPrefix + "]";
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            var val_4;
            int val_1 = this.m_List.Count;
            val_4 = 0;
            goto label_3;
            label_7:
            SimpleJSON.JSONNode val_2 = this.m_List.Item[0];
            val_4 = 1;
            label_3:
            if(val_4 < this.m_List.Count)
            {
                goto label_7;
            }
        
        }
        public JSONArray()
        {
            this.m_List = new System.Collections.Generic.List<SimpleJSON.JSONNode>();
            this = new System.Object();
        }
    
    }

}
