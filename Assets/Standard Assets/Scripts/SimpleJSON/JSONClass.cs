using UnityEngine;

namespace SimpleJSON
{
    public class JSONClass : JSONNode, IEnumerable
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, SimpleJSON.JSONNode> m_Dict;
        
        // Properties
        public override SimpleJSON.JSONNode Item { get; set; }
        public override SimpleJSON.JSONNode Item { get; set; }
        public override int Count { get; }
        public override System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> Childs { get; }
        
        // Methods
        public override SimpleJSON.JSONNode get_Item(string aKey)
        {
            if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    if(this.m_Dict != null)
            {
                    return this.m_Dict.Item[aKey];
            }
            
                return this.m_Dict.Item[aKey];
            }
            
            .m_Node = this;
            .m_Key = aKey;
            return (SimpleJSON.JSONNode)new SimpleJSON.JSONLazyCreator();
        }
        public override void set_Item(string aKey, SimpleJSON.JSONNode value)
        {
            bool val_1 = this.m_Dict.ContainsKey(key:  aKey);
            if(this.m_Dict == null)
            {
                goto label_2;
            }
            
            if(val_1 == false)
            {
                goto label_3;
            }
            
            label_4:
            this.m_Dict.set_Item(key:  aKey, value:  value);
            return;
            label_2:
            if(val_1 == true)
            {
                goto label_4;
            }
            
            label_3:
            this.m_Dict.Add(key:  aKey, value:  value);
        }
        public override SimpleJSON.JSONNode get_Item(int aIndex)
        {
            var val_3;
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_Dict.Count > aIndex)
            {
                    System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.JSONNode> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.JSONNode>>(source:  this.m_Dict, index:  aIndex);
                val_3;
                return (SimpleJSON.JSONNode)val_3;
            }
            
            }
            
            val_3 = 0;
            return (SimpleJSON.JSONNode)val_3;
        }
        public override void set_Item(int aIndex, SimpleJSON.JSONNode value)
        {
            int val_4 = aIndex;
            if((val_4 & 2147483648) != 0)
            {
                    return;
            }
            
            if(this.m_Dict.Count <= val_4)
            {
                    return;
            }
            
            System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.JSONNode> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.JSONNode>>(source:  this.m_Dict, index:  val_4 = aIndex);
            val_4 = this.m_Dict;
            val_4.set_Item(key:  val_2.Value.InitialType, value:  value);
        }
        public override int get_Count()
        {
            if(this.m_Dict != null)
            {
                    return this.m_Dict.Count;
            }
            
            return this.m_Dict.Count;
        }
        public override void Add(string aKey, SimpleJSON.JSONNode aItem)
        {
            string val_4;
            System.Collections.Generic.Dictionary<System.String, SimpleJSON.JSONNode> val_5;
            val_4 = aKey;
            val_5 = this.m_Dict;
            if((System.String.IsNullOrEmpty(value:  val_4)) == false)
            {
                goto label_1;
            }
            
            System.Guid val_2 = System.Guid.NewGuid();
            val_4 = ;
            if(val_5 != null)
            {
                goto label_8;
            }
            
            goto label_8;
            label_1:
            bool val_3 = val_5.ContainsKey(key:  val_4);
            val_5 = this.m_Dict;
            if(val_5 == null)
            {
                goto label_7;
            }
            
            if(val_3 == false)
            {
                goto label_8;
            }
            
            label_10:
            val_5.set_Item(key:  val_4, value:  aItem);
            return;
            label_7:
            if(val_3 == true)
            {
                goto label_10;
            }
            
            label_8:
            val_5.Add(key:  val_4, value:  aItem);
        }
        public override SimpleJSON.JSONNode Remove(string aKey)
        {
            var val_4;
            if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    val_4 = this.m_Dict.Item[aKey];
                bool val_3 = this.m_Dict.Remove(key:  aKey);
                return (SimpleJSON.JSONNode)val_4;
            }
            
            val_4 = 0;
            return (SimpleJSON.JSONNode)val_4;
        }
        public override SimpleJSON.JSONNode Remove(int aIndex)
        {
            System.Collections.Generic.Dictionary<System.String, SimpleJSON.JSONNode> val_5;
            var val_6;
            val_5 = this;
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_Dict.Count > aIndex)
            {
                    System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.JSONNode> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.JSONNode>>(source:  this.m_Dict, index:  aIndex);
                val_5 = this.m_Dict;
                bool val_4 = val_5.Remove(key:  val_2.Value.InitialType);
                val_6;
                return (SimpleJSON.JSONNode)val_6;
            }
            
            }
            
            val_6 = 0;
            return (SimpleJSON.JSONNode)val_6;
        }
        public override SimpleJSON.JSONNode Remove(SimpleJSON.JSONNode aNode)
        {
            .aNode = aNode;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.JSONNode>, System.Boolean> val_2 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.JSONNode>, System.Boolean>(object:  new JSONClass.<>c__DisplayClass12_0(), method:  System.Boolean JSONClass.<>c__DisplayClass12_0::<Remove>b__0(System.Collections.Generic.KeyValuePair<string, SimpleJSON.JSONNode> k));
            System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.JSONNode> val_4 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.JSONNode>>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.JSONNode>>(source:  this.m_Dict, predicate:  null));
            bool val_6 = this.m_Dict.Remove(key:  val_4.Value.InitialType);
            return (SimpleJSON.JSONNode)(JSONClass.<>c__DisplayClass12_0)[1152921525925968544].aNode;
        }
        public override System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> get_Childs()
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            .<>4__this = this;
            return (System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>)new JSONClass.<get_Childs>d__14();
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new JSONClass.<GetEnumerator>d__15();
        }
        public override string ToString()
        {
            var val_4;
            string val_13;
            string val_14;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.m_Dict.GetEnumerator();
            label_23:
            if(((-155349200) & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Playables.PlayableHandle val_5 = val_4.GetHandle();
            if(Length < 3)
            {
                    val_13 = "{";
            }
            else
            {
                    val_13 = "{" + ", ";
            }
            
            string[] val_8 = new string[5];
            val_8[0] = val_13;
            val_8[1] = "\"";
            val_8[2] = SimpleJSON.JSONNode.Escape(aText:  val_5.m_Handle.ToInt64());
            val_8[3] = "\":";
            val_8[4] = ;
            string val_11 = +val_8;
            goto label_23;
            label_2:
            val_4.Add(driver:  public System.Void Dictionary.Enumerator<System.String, SimpleJSON.JSONNode>::Dispose(), rectTransform:  null, drivenProperties:  null);
            val_14 = "{";
            return (string) + "}";
        }
        public override string ToString(string aPrefix)
        {
            var val_4;
            string val_15;
            string val_16;
            string val_17;
            string val_18;
            string val_19;
            val_15 = aPrefix;
            val_16 = "{ ";
            Dictionary.Enumerator<TKey, TValue> val_1 = this.m_Dict.GetEnumerator();
            val_17 = "\n";
            label_22:
            if(((-155175504) & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Playables.PlayableHandle val_5 = val_4.GetHandle();
            if(Length >= 4)
            {
                    val_18 = val_16 + ", ";
            }
            
            string[] val_9 = new string[5];
            val_9[0] = val_18 + "\n" + val_15 + "   ";
            val_9[1] = "\"";
            val_9[2] = SimpleJSON.JSONNode.Escape(aText:  val_5.m_Handle.ToInt64());
            val_9[3] = "\" : ";
            string val_12 = val_15 + "   ";
            val_9[4] = ;
            string val_13 = +val_9;
            goto label_22;
            label_2:
            val_4.Add(driver:  public System.Void Dictionary.Enumerator<System.String, SimpleJSON.JSONNode>::Dispose(), rectTransform:  null, drivenProperties:  null);
            val_19 = val_16;
            return (string) + val_17 + val_15 + "}";
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            int val_1 = this.m_Dict.Count;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = this.m_Dict.Keys.GetEnumerator();
            label_8:
            if(((-154992760) & 1) == 0)
            {
                goto label_5;
            }
            
            if(this.m_Dict.Item[0.InitialType] != null)
            {
                goto label_8;
            }
            
            goto label_8;
            label_5:
            0.Add(driver:  public System.Void Dictionary.KeyCollection.Enumerator<System.String, SimpleJSON.JSONNode>::Dispose(), rectTransform:  typeof(System.IO.BinaryWriter).__il2cppRuntimeField_250, drivenProperties:  null);
        }
        public JSONClass()
        {
            this.m_Dict = new System.Collections.Generic.Dictionary<System.String, SimpleJSON.JSONNode>();
            this = new System.Object();
        }
    
    }

}
