using UnityEngine;
public class GameModeButtonTitleAdjuster : MonoBehaviour
{
    // Fields
    private bool offsetXToLeft;
    
    // Methods
    private void OnEnable()
    {
        MainThreadDispatcher.Invoke(action:  new System.Action(object:  this, method:  System.Void GameModeButtonTitleAdjuster::UpdateChildSize()), delay:  0.1f);
    }
    private void UpdateChildSize()
    {
        float val_23;
        float val_24;
        UnityEngine.Rect val_4 = this.transform.GetComponent<UnityEngine.UI.Image>().sprite.rect;
        float val_24 = val_4.m_XMin;
        UnityEngine.Rect val_8 = this.transform.GetComponent<UnityEngine.UI.Image>().sprite.rect;
        float val_23 = val_8.m_XMin;
        UnityEngine.RectTransform val_9 = this.GetComponent<UnityEngine.RectTransform>();
        if(val_9 != null)
        {
                UnityEngine.Vector2 val_10 = val_9.sizeDelta;
            val_23 = val_10.x;
        }
        else
        {
                UnityEngine.Vector2 val_11 = val_9.sizeDelta;
            val_23 = val_11.x;
        }
        
        UnityEngine.Vector2 val_12 = val_9.sizeDelta;
        float val_13 = val_24 / val_23;
        float val_14 = val_23 / val_12.y;
        val_23 = (val_14 < 0) ? (val_23) : (val_13 * val_12.y);
        val_24 = (val_14 < 0) ? (val_23 / val_13) : val_12.y;
        UnityEngine.RectTransform val_19 = this.transform.GetChild(index:  0).GetComponent<UnityEngine.RectTransform>();
        float val_25 = 0.7f;
        val_25 = val_23 * val_25;
        UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  val_25, y:  val_24);
        if(val_19 != null)
        {
                val_24 = val_20.y;
            val_19.sizeDelta = new UnityEngine.Vector2() {x = val_20.x, y = val_24};
        }
        else
        {
                val_24 = val_20.y;
            val_19.sizeDelta = new UnityEngine.Vector2() {x = val_20.x, y = val_24};
        }
        
        UnityEngine.Vector2 val_21 = val_19.anchoredPosition;
        float val_26 = 0.07f;
        val_26 = val_23 * val_26;
        val_23 = val_26 * ((this.offsetXToLeft == true) ? -1f : 1f);
        val_19.anchoredPosition = new UnityEngine.Vector2() {x = val_23, y = val_21.y};
    }
    public GameModeButtonTitleAdjuster()
    {
    
    }

}
