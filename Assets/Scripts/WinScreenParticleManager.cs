using UnityEngine;
public class WinScreenParticleManager : MonoBehaviour
{
    // Fields
    public static WinScreenParticleManager instance;
    public UnityEngine.GameObject[] winStars;
    public UnityEngine.GameObject coinBurst;
    public bool isWinScreenShown;
    public int starsEarned;
    
    // Methods
    private void Awake()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        if(WinScreenParticleManager.instance != 0)
        {
                val_5 = null;
            val_5 = null;
            if(WinScreenParticleManager.instance != this)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        
        }
        
        val_6 = null;
        val_6 = null;
        WinScreenParticleManager.instance = this;
    }
    private void Start()
    {
        float val_14;
        this.winStars[0].SetActive(value:  false);
        this.winStars[1].SetActive(value:  false);
        this.winStars[2].SetActive(value:  false);
        this.coinBurst.SetActive(value:  false);
        if((double)UnityEngine.Camera.main.aspect >= 1.7)
        {
            goto label_11;
        }
        
        UnityEngine.Transform val_5 = this.winStars[0].transform;
        if(UnityEngine.Camera.main.aspect >= 1.5f)
        {
            goto label_16;
        }
        
        val_14 = 2.03f;
        val_5.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.winStars[1].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Transform val_7 = this.winStars[2].transform;
        goto label_37;
        label_11:
        val_14 = 1.47f;
        this.winStars[0].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.winStars[1].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Transform val_10 = this.winStars[2].transform;
        goto label_37;
        label_16:
        val_14 = 1.83f;
        val_5.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.winStars[1].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_37:
        this.winStars[2].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public WinScreenParticleManager()
    {
    
    }
    private static WinScreenParticleManager()
    {
    
    }

}
