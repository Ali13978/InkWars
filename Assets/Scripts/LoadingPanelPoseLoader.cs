using UnityEngine;
public class LoadingPanelPoseLoader : MonoBehaviour
{
    // Methods
    public void CancelAllPreload()
    {
        this.StopAllCoroutines();
    }
    public void PreloadImages(System.Collections.Generic.List<CharacterStatType> typeList, LoadingPanel_Type target)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.LoadImages(typeList:  typeList, target:  target));
    }
    private System.Collections.IEnumerator LoadImages(System.Collections.Generic.List<CharacterStatType> typeList, LoadingPanel_Type target)
    {
        LoadingPanelPoseLoader.<LoadImages>d__2 val_1 = new LoadingPanelPoseLoader.<LoadImages>d__2();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .typeList = typeList;
        }
        else
        {
                mem[48] = this;
            mem[32] = typeList;
        }
        
        .target = target;
        return (System.Collections.IEnumerator)val_1;
    }
    public LoadingPanelPoseLoader()
    {
    
    }

}
