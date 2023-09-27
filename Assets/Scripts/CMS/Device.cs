using UnityEngine;

namespace CMS
{
    public static class Device
    {
        // Properties
        public static string uniqueDeviceId { get; }
        
        // Methods
        public static string get_uniqueDeviceId()
        {
            return AndroidNativeFunctions.GetAndroidID();
        }
    
    }

}
