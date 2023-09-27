using UnityEngine;
public class InkBrushArtAnimationPlayer : MonoBehaviour
{
    // Fields
    private NetworkUICharacterAnimation characterAnimController;
    
    // Methods
    private void OnEnable()
    {
        this.PlayAnimation();
    }
    public void PlayAnimation()
    {
        this.characterAnimController.Animate(onComplate:  0);
    }
    public InkBrushArtAnimationPlayer()
    {
    
    }

}
