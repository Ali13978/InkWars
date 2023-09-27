using UnityEngine;
public class TutorialDataManager : MonoBehaviour
{
    // Fields
    public static bool ForceBasicTutorial;
    public static bool ForceAdvancedTutorial;
    public static string NextSceneForInteractiveTutorial;
    private static TutorialDataManager _instance;
    public UnityEngine.AudioClip[] PopClip;
    public UnityEngine.Sprite iconInactiveTako;
    public UnityEngine.Sprite[] iconsActiveTako;
    public UnityEngine.Sprite iconInactiveIka;
    public UnityEngine.Sprite[] iconsActiveIka;
    public UnityEngine.Sprite[] switcherSprites;
    public UnityEngine.Sprite BattleGridTako;
    public UnityEngine.Sprite BattleGridIka;
    public UnityEngine.Sprite TakoBar;
    public UnityEngine.Sprite IkaBar;
    public TutorialDataManager.PlayerData Gypsy;
    public TutorialDataManager.PlayerData Hippy;
    public TutorialDataManager.PlayerData Wrestler;
    public TutorialDataManager.PlayerData Commando;
    public TutorialDataManager.PlayerData Butcher;
    public TutorialDataManager.PlayerData Salesman;
    
    // Properties
    public static TutorialDataManager Instance { get; }
    
    // Methods
    public static void LoadBasicTutorial(string nextScene = "Menu_Title_Screen", bool showLoadingScreen = True, bool selectionHand = False, bool preload = False)
    {
        null = null;
        preload = preload;
        DemoManager.enableShowHandSection = selectionHand;
        TutorialDataManager.LoadTutorial(advanced:  false, nextScene:  nextScene, showLoadingScreen:  showLoadingScreen, preload:  preload);
    }
    public static void LoadTutorial(bool advanced, string nextScene = "Menu_Title_Screen", bool showLoadingScreen = True, bool preload = False)
    {
        TutorialDataManager.NextSceneForInteractiveTutorial = nextScene;
        bool val_4 = ~advanced;
        val_4 = val_4 & 1;
        TutorialDataManager.ForceBasicTutorial = val_4;
        TutorialDataManager.ForceAdvancedTutorial = advanced;
        if(NetworkManager_Custom.IsNetwork != false)
        {
                NetworkLobby_EndGameReset.SwitchTo(nextScene:  "InteractiveTutorialAdvanced");
            return;
        }
        
        if(preload != false)
        {
                AsyncSceneLoader.PreloadScene(sceneName:  "InteractiveTutorialAdvanced");
            return;
        }
        
        bool val_3 = showLoadingScreen;
        AsyncSceneLoader.Load(sceneName:  "InteractiveTutorialAdvanced", minimumDelayInSeconds:  0f, showLoadingScreen:  val_3, autoHideLoadingScreen:  val_3);
    }
    public static TutorialDataManager get_Instance()
    {
        var val_3;
        if(TutorialDataManager._instance == 0)
        {
                val_3 = null;
            TutorialDataManager._instance = UnityEngine.Object.FindObjectOfType<TutorialDataManager>();
            return (TutorialDataManager)TutorialDataManager._instance;
        }
        
        val_3 = null;
        return (TutorialDataManager)TutorialDataManager._instance;
    }
    public static void SetBall(UnityEngine.GameObject gameObject, TutorialDataManager.BallColors color)
    {
        UnityEngine.Sprite val_16;
        UnityEngine.Sprite val_17;
        var val_18;
        var val_19;
        string val_20;
        UnityEngine.UI.Image val_1 = gameObject.GetComponent<UnityEngine.UI.Image>();
        string val_2 = color.ToString();
        color.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        if(color != 6)
        {
            goto label_4;
        }
        
        System.Type val_16 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_4 = UnityEngine.Resources.Load(path:  val_2, systemTypeInstance:  val_16);
        if(val_1 == null)
        {
            goto label_7;
        }
        
        if(val_4 == null)
        {
            goto label_8;
        }
        
        label_16:
        val_16 = (null == null) ? (val_4) : 0;
        goto label_9;
        label_4:
        System.Type val_17 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_7 = UnityEngine.Resources.Load(path:  val_2.Substring(startIndex:  0, length:  1), systemTypeInstance:  val_17);
        if(val_1 == null)
        {
            goto label_13;
        }
        
        if(val_7 == null)
        {
            goto label_14;
        }
        
        label_21:
        val_17 = (null == null) ? (val_7) : 0;
        goto label_15;
        label_7:
        if(val_4 != null)
        {
            goto label_16;
        }
        
        label_8:
        val_16 = 0;
        label_9:
        val_1.sprite = val_16;
        string val_8 = null.ToString();
        null.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
        if(gameObject == null)
        {
            goto label_19;
        }
        
        gameObject.tag = val_8;
        goto label_20;
        label_13:
        if(val_7 != null)
        {
            goto label_21;
        }
        
        label_14:
        val_17 = 0;
        label_15:
        val_1.sprite = val_17;
        val_18 = null;
        string val_9 = null.ToString();
        null.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  0);
        if(gameObject == null)
        {
            goto label_24;
        }
        
        gameObject.tag = val_9;
        goto label_25;
        label_19:
        0.tag = val_8;
        label_20:
        val_18 = 1152921526109146016;
        gameObject.GetComponent<UnityEngine.Animator>().enabled = true;
        if(gameObject == null)
        {
            goto label_27;
        }
        
        val_19 = gameObject.GetComponent<UnityEngine.Animator>();
        goto label_28;
        label_24:
        0.tag = val_9;
        label_25:
        val_20 = gameObject.GetComponent<UnityEngine.Animator>();
        val_20.enabled = false;
        return;
        label_27:
        val_19 = 0.GetComponent<UnityEngine.Animator>();
        label_28:
        val_20 = gameObject.tag + "_Anim";
        val_19.Play(stateName:  val_20);
    }
    public static System.Collections.Generic.HashSet<TutorialDataManager.BallColors>[] GetMatches(UnityEngine.GameObject[][] rings)
    {
        string val_28;
        var val_29;
        var val_30;
        int val_31;
        var val_32;
        System.Collections.Generic.HashSet<BallColors> val_1 = new System.Collections.Generic.HashSet<BallColors>();
        if(val_1 != null)
        {
                val_28 = 1152921528232300256;
            bool val_2 = val_1.Add(item:  0);
            bool val_3 = val_1.Add(item:  1);
            bool val_4 = val_1.Add(item:  2);
            bool val_5 = val_1.Add(item:  3);
            bool val_6 = val_1.Add(item:  4);
        }
        else
        {
                val_28 = 1152921528232300256;
            bool val_7 = val_1.Add(item:  0);
            bool val_8 = val_1.Add(item:  1);
            bool val_9 = val_1.Add(item:  2);
            bool val_10 = val_1.Add(item:  3);
            bool val_11 = val_1.Add(item:  4);
        }
        
        bool val_12 = val_1.Add(item:  5);
        System.Collections.Generic.HashSet<BallColors> val_13 = new System.Collections.Generic.HashSet<BallColors>();
        val_29 = 0;
        goto label_3;
        label_34:
        UnityEngine.GameObject[] val_28 = rings[0];
        val_30 = 0;
        goto label_5;
        label_11:
        val_30 = 1;
        label_5:
        val_31 = rings[0x0][0].Length;
        if(val_30 >= val_31)
        {
            goto label_7;
        }
        
        if(val_28[1] == 0)
        {
            goto label_11;
        }
        
        object val_17 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  rings[0x0][0][0x1] + 32.tag);
        bool val_18 = val_13.Add(item:  1152921504628039680);
        bool val_19 = val_1.Remove(item:  1152921504628039680);
        val_31 = rings[0x0][0].Length;
        label_7:
        label_24:
        val_28 = val_31 - 1;
        if((val_28 & 2147483648) != 0)
        {
            goto label_20;
        }
        
        val_32 = (val_28[val_31 - 1][40]) - 8;
        if(1152921508657404416 == 0)
        {
            goto label_24;
        }
        
        val_28 = 1152921508657404416.tag;
        object val_24 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_28);
        bool val_25 = val_13.Add(item:  1152921504628039680);
        bool val_26 = val_1.Remove(item:  1152921504628039680);
        label_20:
        val_29 = 1;
        label_3:
        if(val_29 < rings.Length)
        {
            goto label_34;
        }
        
        System.Collections.Generic.HashSet<BallColors>[] val_27 = new System.Collections.Generic.HashSet<BallColors>[2];
        if(val_27 == null)
        {
            goto label_35;
        }
        
        if(val_13 != null)
        {
            goto label_36;
        }
        
        goto label_39;
        label_35:
        if(val_13 == null)
        {
            goto label_39;
        }
        
        label_36:
        label_39:
        val_27[0] = val_13;
        val_27[1] = val_1;
        return val_27;
    }
    public static bool IsMatch(string tag, UnityEngine.GameObject[][] rings)
    {
        var val_6;
        if((System.String.op_Equality(a:  tag, b:  "Rainbow_Bubble")) != false)
        {
                val_6 = 1;
            return (bool)val_6;
        }
        
        if((System.String.op_Equality(a:  tag, b:  "Untagged")) != false)
        {
                val_6 = 0;
            return (bool)val_6;
        }
        
        object val_4 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  tag);
        System.Collections.Generic.HashSet<BallColors> val_6 = TutorialDataManager.GetMatches(rings:  rings)[0];
        if(val_6 != null)
        {
                return val_6.Contains(item:  1152921504628039680);
        }
        
        return val_6.Contains(item:  1152921504628039680);
    }
    public static TutorialDataManager.BallColors GetRandomBall(System.Collections.Generic.IEnumerable<TutorialDataManager.BallColors> options)
    {
        System.Collections.Generic.List<BallColors> val_1 = new System.Collections.Generic.List<BallColors>(collection:  options);
        if(val_1 != null)
        {
                return val_1.Item[UnityEngine.Random.Range(min:  0, max:  val_1.Count)];
        }
        
        return val_1.Item[UnityEngine.Random.Range(min:  0, max:  val_1.Count)];
    }
    public TutorialDataManager()
    {
    
    }

}
