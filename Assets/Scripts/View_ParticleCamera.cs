using UnityEngine;
public class View_ParticleCamera : MonoBehaviour
{
    // Fields
    public UnityEngine.Camera mainCam;
    public UnityEngine.Material OutputMaterial;
    private UnityEngine.Camera particleCam;
    private UnityEngine.RenderTexture renderTarget;
    
    // Methods
    private void Start()
    {
        this.particleCam = this.gameObject.GetComponent<UnityEngine.Camera>();
        UnityEngine.RenderTexture val_5 = new UnityEngine.RenderTexture(width:  this.mainCam.pixelWidth, height:  this.mainCam.pixelHeight, depth:  24, format:  0);
        this.renderTarget = val_5;
        bool val_6 = val_5.Create();
        this.particleCam.targetTexture = this.renderTarget;
        this.OutputMaterial.mainTexture = this.renderTarget;
    }
    private void Update()
    {
        this.particleCam.orthographicSize = this.mainCam.orthographicSize;
    }
    public View_ParticleCamera()
    {
    
    }

}
