using UnityEngine;

namespace Twitter
{
    public class FilterFollow
    {
        // Fields
        private System.Collections.Generic.List<string> screen_names;
        private System.Collections.Generic.List<long> ids;
        
        // Methods
        public FilterFollow(System.Collections.Generic.List<string> screen_names)
        {
            this.screen_names = screen_names;
        }
        public FilterFollow(System.Collections.Generic.List<long> ids)
        {
            this.ids = ids;
        }
        public FilterFollow(long id)
        {
            System.Collections.Generic.List<System.Int64> val_1 = new System.Collections.Generic.List<System.Int64>();
            this.ids = val_1;
            val_1.Add(item:  id);
        }
        public void AddId(long id)
        {
            this.ids.Add(item:  id);
        }
        public void AddIds(System.Collections.Generic.List<long> ids)
        {
            var val_3;
            var val_5 = this;
            List.Enumerator<T> val_1 = ids.GetEnumerator();
            label_4:
            if(((-1199879200) & 1) == 0)
            {
                goto label_2;
            }
            
            this.ids.Add(item:  val_3.InitialType);
            goto label_4;
            label_2:
            val_3.Add(driver:  public System.Void List.Enumerator<System.Int64>::Dispose(), rectTransform:  null, drivenProperties:  null);
        }
        public string GetKey()
        {
            return "follow";
        }
        public string GetValue()
        {
            var val_5;
            System.Collections.Generic.List<System.Int64> val_19;
            var val_20;
            int val_21;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            if(this.ids.Count < 1)
            {
                goto label_13;
            }
            
            val_19 = this.ids;
            List.Enumerator<T> val_3 = val_19.GetEnumerator();
            val_20 = 1152921529176749408;
            label_6:
            if(((-1199596832) & 1) == 0)
            {
                goto label_4;
            }
            
            System.Text.StringBuilder val_9 = val_1.Append(value:  val_5.InitialType.ToString() + ",");
            goto label_6;
            label_4:
            val_5.Add(driver:  public System.Void List.Enumerator<System.Int64>::Dispose(), rectTransform:  null, drivenProperties:  null);
            if(val_1 != null)
            {
                goto label_18;
            }
            
            goto label_24;
            label_13:
            List.Enumerator<T> val_10 = this.screen_names.GetEnumerator();
            val_19 = 1152921519703868304;
            val_20 = ",";
            label_17:
            if(((-1199596864) & 1) == 0)
            {
                goto label_15;
            }
            
            System.Text.StringBuilder val_13 = val_1.Append(value:  0.InitialType + ",");
            goto label_17;
            label_15:
            0.Add(driver:  public System.Void List.Enumerator<System.String>::Dispose(), rectTransform:  0, drivenProperties:  null);
            if(val_1 != null)
            {
                goto label_18;
            }
            
            goto label_24;
            label_18:
            val_21 = val_1.Length - 1;
            val_1.Length = val_21;
            return (string)val_1;
            label_24:
            val_21 = val_1.Length - 1;
            val_1.Length = val_21;
            return (string)val_1;
        }
    
    }

}
