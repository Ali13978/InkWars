using UnityEngine;
[Serializable]
public class View_AspectRatioManager.AspectRatio
{
    // Fields
    public float XAspect;
    public float YAspect;
    public float Aspect;
    public float OrthographicSize;
    public float BattleGridSpacing;
    public float IconScaler_Size;
    
    // Methods
    internal View_AspectRatioManager.AspectRatio Clone()
    {
        float val_2;
        View_AspectRatioManager.AspectRatio val_1 = new View_AspectRatioManager.AspectRatio();
        if(val_1 != null)
        {
                .XAspect = this.XAspect;
            .YAspect = this.YAspect;
            .Aspect = this.Aspect;
            .OrthographicSize = this.OrthographicSize;
            .BattleGridSpacing = this.BattleGridSpacing;
            val_2 = this.IconScaler_Size;
        }
        else
        {
                mem[16] = this.XAspect;
            .YAspect = this.YAspect;
            mem[24] = this.Aspect;
            .OrthographicSize = this.OrthographicSize;
            mem[32] = this.BattleGridSpacing;
            val_2 = this.IconScaler_Size;
        }
        
        .IconScaler_Size = val_2;
        return (AspectRatio)val_1;
    }
    public View_AspectRatioManager.AspectRatio()
    {
    
    }

}
