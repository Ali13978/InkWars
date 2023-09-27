using UnityEngine;
public class View_AspectRatioManager : MonoBehaviour
{
    // Fields
    public View_AspectRatioManager.AspectRatio[] AspectRatios;
    public View_AspectRatioManager.AspectRatio ThisAspectRatio;
    private View_AspectRatioManager.AspectRatio lastAspectRatio;
    
    // Methods
    private void Start()
    {
        this.RefreshAspectRatios();
    }
    private void Update()
    {
        this.RefreshAspectRatios();
    }
    private void RefreshAspectRatios()
    {
        var val_27;
        AspectRatio val_28;
        float val_29;
        var val_28 = -4294967296;
        val_28 = val_28 + ((this.AspectRatios.Length) << 32);
        this.ThisAspectRatio = this.AspectRatios[val_28 >> 32].Clone();
        float val_5 = (float)UnityEngine.Screen.width / (float)UnityEngine.Screen.height;
        val_27 = 1;
        goto label_4;
        label_17:
        if(val_5 >= this.AspectRatios[(long)(int)(W22)][0].Aspect)
        {
            goto label_8;
        }
        
        int val_31 = this.AspectRatios.Length;
        val_31 = val_31 - 1;
        if((W22 >= val_31) || (val_5 >= 0))
        {
            goto label_11;
        }
        
        AspectRatio val_32 = this.AspectRatios[1];
        if(val_5 > this.AspectRatios[0x1][0].Aspect)
        {
            goto label_15;
        }
        
        label_11:
        val_27 = 2;
        label_4:
        if((val_27 - 1) < this.AspectRatios.Length)
        {
            goto label_17;
        }
        
        goto label_18;
        label_8:
        label_60:
        this.ThisAspectRatio = this.AspectRatios[(long)(long)(int)(W22)].Clone();
        label_18:
        if((this.lastAspectRatio != null) && (this.lastAspectRatio.BattleGridSpacing == this.ThisAspectRatio.BattleGridSpacing))
        {
                val_28 = this.ThisAspectRatio;
            val_29 = this.lastAspectRatio.OrthographicSize;
            if(val_29 == this.ThisAspectRatio.OrthographicSize)
        {
                return;
        }
        
        }
        
        UnityEngine.Camera.main.orthographicSize = this.ThisAspectRatio.OrthographicSize;
        View_Core val_9 = View_Core.Instance;
        val_9.LeftPlayer.Grid.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        View_Core val_11 = View_Core.Instance;
        val_11.RightPlayer.Grid.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        View_Core val_13 = View_Core.Instance;
        View_Core val_16 = View_Core.Instance;
        val_28 = val_16.RightPlayer.ActiveBase.transform.parent;
        val_28.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_29 = 0f;
        val_13.LeftPlayer.ActiveBase.transform.parent.localScale = new UnityEngine.Vector3() {x = val_29, y = 0f, z = 0f};
        View_Core val_19 = View_Core.Instance;
        val_19.LeftPlayer.GenerateSplines();
        View_Core val_20 = View_Core.Instance;
        val_20.RightPlayer.GenerateSplines();
        this.lastAspectRatio = this.ThisAspectRatio;
        return;
        label_15:
        float val_21 = UnityEngine.Mathf.InverseLerp(a:  this.AspectRatios[(long)(int)(W22)][0].Aspect, b:  this.AspectRatios[0x1][0].Aspect, value:  val_5);
        .XAspect = (float)UnityEngine.Screen.width;
        int val_24 = UnityEngine.Screen.height;
        if(new View_AspectRatioManager.AspectRatio() != null)
        {
                .YAspect = (float)val_24;
        }
        else
        {
                .YAspect = (float)val_24;
        }
        
        .Aspect = val_5;
        .OrthographicSize = UnityEngine.Mathf.Lerp(a:  this.AspectRatios[(long)(int)(W22)][0].OrthographicSize, b:  this.AspectRatios[0x1][0].OrthographicSize, t:  val_21);
        .BattleGridSpacing = UnityEngine.Mathf.Lerp(a:  this.AspectRatios[(long)(int)(W22)][0].BattleGridSpacing, b:  this.AspectRatios[0x1][0].BattleGridSpacing, t:  val_21);
        .IconScaler_Size = UnityEngine.Mathf.Lerp(a:  this.AspectRatios[(long)(int)(W22)][0].IconScaler_Size, b:  this.AspectRatios[0x1][0].IconScaler_Size, t:  val_21);
        goto label_60;
    }
    public View_AspectRatioManager()
    {
    
    }

}
