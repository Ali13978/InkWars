using UnityEngine;
public class ActiveCanvasController : MonoBehaviour
{
    // Fields
    private bool isCryptoMode;
    private UnityEngine.Transform parent;
    public bool isCryptoPublicLobby;
    private static ActiveCanvasController _instance;
    public ActiveCanvasController.CanvasName[] m_canvasMap;
    public static string m_activeCanvasName;
    
    // Properties
    public static ActiveCanvasController Instance { get; }
    public static string ActiveCanvas { get; set; }
    
    // Methods
    public static ActiveCanvasController get_Instance()
    {
        null = null;
        return (ActiveCanvasController)ActiveCanvasController._instance;
    }
    public static string get_ActiveCanvas()
    {
        null = null;
        return (string)ActiveCanvasController.m_activeCanvasName;
    }
    public static void set_ActiveCanvas(string value)
    {
        null = null;
        ActiveCanvasController.m_activeCanvasName = value;
    }
    public static UnityEngine.GameObject GetCanvasByName(string name)
    {
        string val_4;
        CanvasName val_5;
        val_4 = name;
        ActiveCanvasController val_1 = ActiveCanvasController.Instance;
        var val_5 = 0;
        label_7:
        if(val_5 >= val_1.m_canvasMap.Length)
        {
            goto label_5;
        }
        
        val_5 = val_1.m_canvasMap[0];
        val_5 = val_5 + 1;
        if((System.String.op_Equality(a:  val_4, b:  val_1.m_canvasMap[0])) == false)
        {
            goto label_7;
        }
        
        return (UnityEngine.GameObject)val_5;
        label_5:
        ActiveCanvasController val_3 = ActiveCanvasController.Instance;
        val_4 = val_3.m_canvasMap;
        val_5 = val_4[1];
        return (UnityEngine.GameObject)val_5;
    }
    private void Awake()
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_13 = null;
        val_13 = null;
        if(ActiveCanvasController._instance == 0)
        {
            goto label_10;
        }
        
        val_14 = null;
        val_14 = null;
        if(ActiveCanvasController._instance == this)
        {
            goto label_10;
        }
        
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        goto label_13;
        label_10:
        val_15 = null;
        val_15 = null;
        ActiveCanvasController._instance = this;
        label_13:
        val_16 = "LobbyMain";
        if("LobbyMain" == null)
        {
                val_16 = "LobbyMain";
        }
        
        if(((ActiveCanvasController.ActiveCanvas.IndexOfAny(anyOf:  ToCharArray())) & 2147483648) == 0)
        {
                this.ShowLobby();
            return;
        }
        
        val_17 = "Public";
        if("Public" == null)
        {
                val_17 = "Public";
        }
        
        if(((ActiveCanvasController.ActiveCanvas.IndexOfAny(anyOf:  ToCharArray())) & 2147483648) == 0)
        {
                this.ShowPublicLobby();
            return;
        }
        
        val_18 = "Private";
        if("Private" == null)
        {
                val_18 = "Private";
        }
        
        if(((ActiveCanvasController.ActiveCanvas.IndexOfAny(anyOf:  ToCharArray())) & 2147483648) != 0)
        {
                return;
        }
        
        this.ShowPrivateLobby();
    }
    public void ShowLobby()
    {
        ActiveCanvasController val_1 = ActiveCanvasController.Instance;
        if(val_1.isCryptoMode != false)
        {
                NetworkLobbySuponic.Show(parent:  this.parent);
            return;
        }
        
        ActiveCanvasController.GetCanvasByName(name:  "LobbyMainUI").gameObject.SetActive(value:  true);
    }
    public void ShowPublicLobby()
    {
        ActiveCanvasController val_1 = ActiveCanvasController.Instance;
        if(val_1.isCryptoPublicLobby != false)
        {
                PublicLobbySuponic.Show(parent:  this.parent);
            return;
        }
        
        ActiveCanvasController.GetCanvasByName(name:  "PublicLobby").gameObject.SetActive(value:  true);
    }
    public void ShowPrivateLobby()
    {
        ActiveCanvasController val_1 = ActiveCanvasController.Instance;
        if(val_1.isCryptoPublicLobby != false)
        {
                PrivateLobbyGGP.Show(parent:  this.parent);
            return;
        }
        
        ActiveCanvasController.GetCanvasByName(name:  "PrivateLobby").gameObject.SetActive(value:  true);
    }
    public ActiveCanvasController()
    {
    
    }
    private static ActiveCanvasController()
    {
        ActiveCanvasController.m_activeCanvasName = "LobbyMainUI";
    }

}
