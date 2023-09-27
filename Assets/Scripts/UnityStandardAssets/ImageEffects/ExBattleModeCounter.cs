using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
    public class ExBattleModeCounter : MonoBehaviour
    {
        // Fields
        public UnityEngine.Texture2D sepia;
        public UnityEngine.Texture2D aquaBlue;
        
        // Methods
        private void Start()
        {
            var val_9;
            GameMode val_10;
            var val_11;
            val_9 = null;
            val_9 = null;
            val_10 = Character_GlobalInfo.gameMode;
            if(val_10 == 4)
            {
                    val_11 = 1152921529327236544;
                UnityStandardAssets.ImageEffects.ScreenOverlay val_2 = this.gameObject.GetComponent<UnityStandardAssets.ImageEffects.ScreenOverlay>();
                val_2.texture = this.sepia;
            }
            else
            {
                    val_10 = Character_GlobalInfo.gameMode;
                if(val_10 != 3)
            {
                    return;
            }
            
                val_11 = 1152921529327236544;
                UnityStandardAssets.ImageEffects.ScreenOverlay val_4 = this.gameObject.GetComponent<UnityStandardAssets.ImageEffects.ScreenOverlay>();
                val_4.texture = this.aquaBlue;
                UnityStandardAssets.ImageEffects.ScreenOverlay val_6 = this.gameObject.GetComponent<UnityStandardAssets.ImageEffects.ScreenOverlay>();
                val_6.intensity = 0.5f;
            }
            
            this.gameObject.GetComponent<UnityStandardAssets.ImageEffects.ScreenOverlay>().enabled = true;
        }
        public ExBattleModeCounter()
        {
        
        }
    
    }

}
