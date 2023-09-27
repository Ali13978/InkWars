using UnityEngine;

namespace CMS.Security
{
    [Serializable]
    public class ReadOnlyData<T> : MonoBehaviour
    {
        // Fields
        public string path;
        public bool loadAtAwake;
        public T data;
        
        // Methods
        protected virtual void Awake()
        {
            if(W8 == 0)
            {
                    return;
            }
            
            goto __RuntimeMethodHiddenParam + 24 + 192;
        }
        public void Load()
        {
            mem[1152921529367553304] = CMS.IO.ReadOnlyDataFile.Load(path:  this, type:  1);
        }
        public ReadOnlyData<T>()
        {
            mem[1152921529367669392] = 1;
            if(this != null)
            {
                    return;
            }
        
        }
    
    }

}
