using UnityEngine;
public class titleBackground : MonoBehaviour
{
    // Fields
    public float waveSpeed;
    
    // Methods
    private void Update()
    {
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  -(UnityEngine.Time.time * this.waveSpeed), y:  0f);
        this.GetComponent<UnityEngine.Renderer>().material.mainTextureOffset = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
    }
    public titleBackground()
    {
    
    }

}
