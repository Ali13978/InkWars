using UnityEngine;

namespace Twitter
{
    public class FilterLocations
    {
        // Fields
        private System.Collections.Generic.List<Twitter.Coordinate> locations;
        
        // Methods
        public FilterLocations()
        {
            System.Collections.Generic.List<Twitter.Coordinate> val_1 = new System.Collections.Generic.List<Twitter.Coordinate>();
            this.locations = val_1;
            .<lng>k__BackingField = -180f;
            .<lat>k__BackingField = -90f;
            val_1.Add(item:  new Twitter.Coordinate());
            .<lng>k__BackingField = 180f;
            .<lat>k__BackingField = 90f;
            this.locations.Add(item:  new Twitter.Coordinate());
        }
        public FilterLocations(Twitter.Coordinate southwest, Twitter.Coordinate northeast)
        {
            val_1 = new System.Object();
            System.Collections.Generic.List<Twitter.Coordinate> val_2 = new System.Collections.Generic.List<Twitter.Coordinate>();
            this.locations = val_2;
            val_2.Add(item:  southwest);
            this.locations.Add(item:  Twitter.Coordinate val_1 = northeast);
        }
        public void AddLocation(Twitter.Coordinate southwest, Twitter.Coordinate northeast)
        {
            this.locations.Add(item:  southwest);
            this.locations.Add(item:  northeast);
        }
        public string GetKey()
        {
            return "locations";
        }
        public string GetValue()
        {
            int val_12;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            List.Enumerator<T> val_2 = this.locations.GetEnumerator();
            label_5:
            if(((-1201079080) & 1) == 0)
            {
                goto label_2;
            }
            
            System.Type val_3 = 0.InitialType;
            System.Text.StringBuilder val_7 = val_1.Append(value:  val_3._impl.ToString(format:  "F1")(val_3._impl.ToString(format:  "F1")) + "," + val_3._impl.ToString(format:  "F1")(val_3._impl.ToString(format:  "F1")) + ",");
            goto label_5;
            label_2:
            0.Add(driver:  public System.Void List.Enumerator<Twitter.Coordinate>::Dispose(), rectTransform:  null, drivenProperties:  null);
            if(val_1 == null)
            {
                
            }
            else
            {
                    val_12 = val_1.Length - 1;
                val_1.Length = val_12;
                return (string)val_1;
            }
            
            val_12 = val_1.Length - 1;
            val_1.Length = val_12;
            return (string)val_1;
        }
    
    }

}
