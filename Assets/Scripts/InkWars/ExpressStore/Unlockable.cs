using UnityEngine;

namespace InkWars.ExpressStore
{
    [Serializable]
    public class Unlockable
    {
        // Fields
        public eInkUnlockable unlockable;
        public int quantity;
        public int price;
        public Currency currency;
        
        // Methods
        public void AssignRewards()
        {
            eInkUnlockable val_42 = this.unlockable;
            val_42 = val_42 - 1;
            if(val_42 <= 5)
            {
                    var val_43 = 40826620 + ((this.unlockable - 1)) << 2;
                val_43 = val_43 + 40826620;
            }
            else
            {
                    UnityEngine.Debug.Log(message:  "No rewards set for " + this);
            }
        
        }
        public Unlockable()
        {
            this.quantity = 1;
        }
    
    }

}
