using UnityEngine;

namespace Twitter
{
    public class Coordinate
    {
        // Fields
        private float <lng>k__BackingField;
        private float <lat>k__BackingField;
        
        // Properties
        public float lng { get; set; }
        public float lat { get; set; }
        
        // Methods
        public float get_lng()
        {
            return (float)this.<lng>k__BackingField;
        }
        public void set_lng(float value)
        {
            this.<lng>k__BackingField = value;
        }
        public float get_lat()
        {
            return (float)this.<lat>k__BackingField;
        }
        public void set_lat(float value)
        {
            this.<lat>k__BackingField = value;
        }
        public Coordinate(float lng, float lat)
        {
            this.<lng>k__BackingField = lng;
            this.<lat>k__BackingField = lat;
        }
    
    }

}
