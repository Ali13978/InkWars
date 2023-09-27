using UnityEngine;
public class Reporter : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<Reporter.Sample> samples;
    private System.Collections.Generic.List<Reporter.Log> logs;
    private System.Collections.Generic.List<Reporter.Log> collapsedLogs;
    private System.Collections.Generic.List<Reporter.Log> currentLog;
    private MultiKeyDictionary<string, string, Reporter.Log> logsDic;
    private System.Collections.Generic.Dictionary<string, string> cachedString;
    public bool show;
    private bool collapse;
    private bool clearOnNewSceneLoaded;
    private bool showTime;
    private bool showScene;
    private bool showMemory;
    private bool showFps;
    private bool showGraph;
    private bool showLog;
    private bool showWarning;
    private bool showError;
    private int numOfLogs;
    private int numOfLogsWarning;
    private int numOfLogsError;
    private int numOfCollapsedLogs;
    private int numOfCollapsedLogsWarning;
    private int numOfCollapsedLogsError;
    private bool showClearOnNewSceneLoadedButton;
    private bool showTimeButton;
    private bool showSceneButton;
    private bool showMemButton;
    private bool showFpsButton;
    private bool showSearchText;
    private bool showCopyButton;
    private bool showSaveButton;
    private string buildDate;
    private string logDate;
    private float logsMemUsage;
    private float graphMemUsage;
    private float gcTotalMemory;
    public string UserData;
    public float fps;
    public string fpsText;
    private Reporter.ReportView currentView;
    private static bool created;
    public Images images;
    private UnityEngine.GUIContent clearContent;
    private UnityEngine.GUIContent collapseContent;
    private UnityEngine.GUIContent clearOnNewSceneContent;
    private UnityEngine.GUIContent showTimeContent;
    private UnityEngine.GUIContent showSceneContent;
    private UnityEngine.GUIContent userContent;
    private UnityEngine.GUIContent showMemoryContent;
    private UnityEngine.GUIContent softwareContent;
    private UnityEngine.GUIContent dateContent;
    private UnityEngine.GUIContent showFpsContent;
    private UnityEngine.GUIContent infoContent;
    private UnityEngine.GUIContent saveLogsContent;
    private UnityEngine.GUIContent searchContent;
    private UnityEngine.GUIContent copyContent;
    private UnityEngine.GUIContent closeContent;
    private UnityEngine.GUIContent buildFromContent;
    private UnityEngine.GUIContent systemInfoContent;
    private UnityEngine.GUIContent graphicsInfoContent;
    private UnityEngine.GUIContent backContent;
    private UnityEngine.GUIContent logContent;
    private UnityEngine.GUIContent warningContent;
    private UnityEngine.GUIContent errorContent;
    private UnityEngine.GUIStyle barStyle;
    private UnityEngine.GUIStyle buttonActiveStyle;
    private UnityEngine.GUIStyle nonStyle;
    private UnityEngine.GUIStyle lowerLeftFontStyle;
    private UnityEngine.GUIStyle backStyle;
    private UnityEngine.GUIStyle evenLogStyle;
    private UnityEngine.GUIStyle oddLogStyle;
    private UnityEngine.GUIStyle logButtonStyle;
    private UnityEngine.GUIStyle selectedLogStyle;
    private UnityEngine.GUIStyle selectedLogFontStyle;
    private UnityEngine.GUIStyle stackLabelStyle;
    private UnityEngine.GUIStyle scrollerStyle;
    private UnityEngine.GUIStyle searchStyle;
    private UnityEngine.GUIStyle sliderBackStyle;
    private UnityEngine.GUIStyle sliderThumbStyle;
    private UnityEngine.GUISkin toolbarScrollerSkin;
    private UnityEngine.GUISkin logScrollerSkin;
    private UnityEngine.GUISkin graphScrollerSkin;
    public UnityEngine.Vector2 size;
    public float maxSize;
    public int numOfCircleToShow;
    private static string[] scenes;
    private string currentScene;
    private string filterText;
    private string deviceModel;
    private string deviceType;
    private string deviceName;
    private string graphicsMemorySize;
    private string maxTextureSize;
    private string systemMemorySize;
    public bool Initialized;
    private UnityEngine.Rect screenRect;
    private UnityEngine.Rect toolBarRect;
    private UnityEngine.Rect logsRect;
    private UnityEngine.Rect stackRect;
    private UnityEngine.Rect graphRect;
    private UnityEngine.Rect graphMinRect;
    private UnityEngine.Rect graphMaxRect;
    private UnityEngine.Rect buttomRect;
    private UnityEngine.Vector2 stackRectTopLeft;
    private UnityEngine.Rect detailRect;
    private UnityEngine.Vector2 scrollPosition;
    private UnityEngine.Vector2 scrollPosition2;
    private UnityEngine.Vector2 toolbarScrollPosition;
    private Reporter.Log selectedLog;
    private float toolbarOldDrag;
    private float oldDrag;
    private float oldDrag2;
    private float oldDrag3;
    private int startIndex;
    private UnityEngine.Rect countRect;
    private UnityEngine.Rect timeRect;
    private UnityEngine.Rect timeLabelRect;
    private UnityEngine.Rect sceneRect;
    private UnityEngine.Rect sceneLabelRect;
    private UnityEngine.Rect memoryRect;
    private UnityEngine.Rect memoryLabelRect;
    private UnityEngine.Rect fpsRect;
    private UnityEngine.Rect fpsLabelRect;
    private UnityEngine.GUIContent tempContent;
    private UnityEngine.Vector2 infoScrollPosition;
    private UnityEngine.Vector2 oldInfoDrag;
    private UnityEngine.Rect tempRect;
    private float graphSize;
    private int startFrame;
    private int currentFrame;
    private UnityEngine.Vector3 tempVector1;
    private UnityEngine.Vector3 tempVector2;
    private UnityEngine.Vector2 graphScrollerPos;
    private float maxFpsValue;
    private float minFpsValue;
    private float maxMemoryValue;
    private float minMemoryValue;
    private System.Collections.Generic.List<UnityEngine.Vector2> gestureDetector;
    private UnityEngine.Vector2 gestureSum;
    private float gestureLength;
    private int gestureCount;
    private float lastClickTime;
    private UnityEngine.Vector2 startPos;
    private UnityEngine.Vector2 downPos;
    private UnityEngine.Vector2 mousePosition;
    private int frames;
    private bool firstTime;
    private float lastUpdate;
    private const int requiredFrames = 10;
    private const float updateInterval = 0.25;
    private System.Collections.Generic.List<Reporter.Log> threadedLogs;
    
    // Properties
    public float TotalMemUsage { get; }
    
    // Methods
    public float get_TotalMemUsage()
    {
        float val_1 = this.logsMemUsage;
        val_1 = val_1 + this.graphMemUsage;
        return (float)val_1;
    }
    private void Awake()
    {
        if(this.Initialized != true)
        {
                this.Initialize();
        }
        
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void Reporter::_OnLevelWasLoaded(UnityEngine.SceneManagement.Scene _null1, UnityEngine.SceneManagement.LoadSceneMode _null2)));
    }
    private void OnDestroy()
    {
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void Reporter::_OnLevelWasLoaded(UnityEngine.SceneManagement.Scene _null1, UnityEngine.SceneManagement.LoadSceneMode _null2)));
    }
    private void OnEnable()
    {
        if(this.logs.Count != 0)
        {
                return;
        }
        
        this.clear();
    }
    private void OnDisable()
    {
    
    }
    private void addSample()
    {
        string val_7;
        Reporter.Sample val_1 = new Reporter.Sample();
        if(val_1 != null)
        {
                .fps = this.fps;
            val_7 = this.fpsText;
        }
        else
        {
                .fps = this.fps;
            val_7 = this.fpsText;
        }
        
        .fpsText = val_7;
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        .loadedScene = val_2.m_Handle.buildIndex;
        .time = UnityEngine.Time.realtimeSinceStartup;
        .memory = this.gcTotalMemory;
        this.samples.Add(item:  val_1);
        float val_6 = Reporter.Sample.MemSize();
        val_6 = val_6 * (float)this.samples.Count;
        val_6 = val_6 * 0.0009765625f;
        val_6 = val_6 * 0.0009765625f;
        this.graphMemUsage = val_6;
    }
    public void Initialize()
    {
        UnityEngine.Object val_82;
        var val_83;
        var val_84;
        val_82 = this;
        val_83 = null;
        val_83 = null;
        if(Reporter.updateInterval != 0)
        {
                UnityEngine.Debug.LogWarning(message:  "tow manager is exists delete the second");
            val_82 = this.gameObject;
            UnityEngine.Object.DestroyImmediate(obj:  val_82, allowDestroyingAssets:  true);
            return;
        }
        
        this.gameObject.SendMessage(methodName:  "OnPreStart");
        int val_3 = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
        val_84 = null;
        val_84 = null;
        Reporter.scenes = new string[0];
        UnityEngine.SceneManagement.Scene val_5 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        this.currentScene = val_5.m_Handle.name;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        UnityEngine.Application.add_logMessageReceivedThreaded(value:  new Application.LogCallback(object:  this, method:  System.Void Reporter::CaptureLogThread(string condition, string stacktrace, UnityEngine.LogType type)));
        Reporter.updateInterval = 1.401298E-45f;
        this.clearContent = new UnityEngine.GUIContent(text:  "", image:  this.images.clearImage, tooltip:  "Clear logs");
        this.collapseContent = new UnityEngine.GUIContent(text:  "", image:  this.images.collapseImage, tooltip:  "Collapse logs");
        this.clearOnNewSceneContent = new UnityEngine.GUIContent(text:  "", image:  this.images.clearOnNewSceneImage, tooltip:  "Clear logs on new scene loaded");
        this.showTimeContent = new UnityEngine.GUIContent(text:  "", image:  this.images.showTimeImage, tooltip:  "Show Hide Time");
        this.showSceneContent = new UnityEngine.GUIContent(text:  "", image:  this.images.showSceneImage, tooltip:  "Show Hide Scene");
        this.showMemoryContent = new UnityEngine.GUIContent(text:  "", image:  this.images.showMemoryImage, tooltip:  "Show Hide Memory");
        this.softwareContent = new UnityEngine.GUIContent(text:  "", image:  this.images.softwareImage, tooltip:  "Software");
        this.dateContent = new UnityEngine.GUIContent(text:  "", image:  this.images.dateImage, tooltip:  "Date");
        this.showFpsContent = new UnityEngine.GUIContent(text:  "", image:  this.images.showFpsImage, tooltip:  "Show Hide fps");
        this.infoContent = new UnityEngine.GUIContent(text:  "", image:  this.images.infoImage, tooltip:  "Information about application");
        this.saveLogsContent = new UnityEngine.GUIContent(text:  "", image:  this.images.saveLogsImage, tooltip:  "Save logs to device");
        this.searchContent = new UnityEngine.GUIContent(text:  "", image:  this.images.searchImage, tooltip:  "Search for logs");
        this.copyContent = new UnityEngine.GUIContent(text:  "", image:  this.images.copyImage, tooltip:  "Copy log to clipboard");
        this.closeContent = new UnityEngine.GUIContent(text:  "", image:  this.images.closeImage, tooltip:  "Hide logs");
        this.userContent = new UnityEngine.GUIContent(text:  "", image:  this.images.userImage, tooltip:  "User");
        this.buildFromContent = new UnityEngine.GUIContent(text:  "", image:  this.images.buildFromImage, tooltip:  "Build From");
        this.systemInfoContent = new UnityEngine.GUIContent(text:  "", image:  this.images.systemInfoImage, tooltip:  "System Info");
        this.graphicsInfoContent = new UnityEngine.GUIContent(text:  "", image:  this.images.graphicsInfoImage, tooltip:  "Graphics Info");
        this.backContent = new UnityEngine.GUIContent(text:  "", image:  this.images.backImage, tooltip:  "Back");
        this.logContent = new UnityEngine.GUIContent(text:  "", image:  this.images.logImage, tooltip:  "show or hide logs");
        this.warningContent = new UnityEngine.GUIContent(text:  "", image:  this.images.warningImage, tooltip:  "show or hide warnings");
        this.errorContent = new UnityEngine.GUIContent(text:  "", image:  this.images.errorImage, tooltip:  "show or hide errors");
        this.currentView = UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_currentView", defaultValue:  1);
        this.show = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_show")) == 1) ? 1 : 0;
        this.collapse = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_collapse")) == 1) ? 1 : 0;
        this.clearOnNewSceneLoaded = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_clearOnNewSceneLoaded")) == 1) ? 1 : 0;
        this.showTime = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showTime")) == 1) ? 1 : 0;
        this.showScene = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showScene")) == 1) ? 1 : 0;
        this.showMemory = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showMemory")) == 1) ? 1 : 0;
        this.showFps = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showFps")) == 1) ? 1 : 0;
        this.showGraph = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showGraph")) == 1) ? 1 : 0;
        this.showLog = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showLog", defaultValue:  1)) == 1) ? 1 : 0;
        this.showWarning = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showWarning", defaultValue:  1)) == 1) ? 1 : 0;
        this.showError = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showError", defaultValue:  1)) == 1) ? 1 : 0;
        this.filterText = UnityEngine.PlayerPrefs.GetString(key:  "Reporter_filterText");
        float val_55 = UnityEngine.PlayerPrefs.GetFloat(key:  "Reporter_size", defaultValue:  32f);
        mem[1152921529106099972] = val_55;
        this.size = val_55;
        this.showClearOnNewSceneLoadedButton = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showClearOnNewSceneLoadedButton", defaultValue:  1)) == 1) ? 1 : 0;
        this.showTimeButton = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showTimeButton", defaultValue:  1)) == 1) ? 1 : 0;
        this.showSceneButton = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showSceneButton", defaultValue:  1)) == 1) ? 1 : 0;
        this.showMemButton = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showMemButton", defaultValue:  1)) == 1) ? 1 : 0;
        this.showFpsButton = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showFpsButton", defaultValue:  1)) == 1) ? 1 : 0;
        this.showSearchText = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showSearchText", defaultValue:  1)) == 1) ? 1 : 0;
        this.showCopyButton = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showCopyButton", defaultValue:  1)) == 1) ? 1 : 0;
        this.showSaveButton = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showSaveButton", defaultValue:  1)) == 1) ? 1 : 0;
        this.initializeStyle();
        this.Initialized = true;
        if(this.show != false)
        {
                this.doShow();
        }
        
        this.deviceModel = UnityEngine.SystemInfo.deviceModel;
        UnityEngine.DeviceType val_73 = UnityEngine.SystemInfo.deviceType;
        val_73.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  "show or hide errors");
        this.deviceType = val_73.ToString();
        this.deviceName = UnityEngine.SystemInfo.deviceName;
        this.graphicsMemorySize = UnityEngine.SystemInfo.graphicsMemorySize.ToString();
        this.maxTextureSize = UnityEngine.SystemInfo.maxTextureSize.ToString();
        this.systemMemorySize = UnityEngine.SystemInfo.systemMemorySize.ToString();
    }
    private void initializeStyle()
    {
        UnityEngine.Vector2 val_75 = this.size;
        UnityEngine.GUIStyle val_1 = new UnityEngine.GUIStyle();
        this.nonStyle = val_1;
        val_1.clipping = 1;
        this.nonStyle.border = new UnityEngine.RectOffset(left:  0, right:  0, top:  0, bottom:  0);
        this.nonStyle.normal.background = 0;
        this.nonStyle.fontSize = (int)S8 * 0.5f;
        this.nonStyle.alignment = 4;
        UnityEngine.GUIStyle val_5 = new UnityEngine.GUIStyle();
        this.lowerLeftFontStyle = val_5;
        val_5.clipping = 1;
        this.lowerLeftFontStyle.border = new UnityEngine.RectOffset(left:  0, right:  0, top:  0, bottom:  0);
        this.lowerLeftFontStyle.normal.background = 0;
        this.lowerLeftFontStyle.fontSize = (int)S8 * 0.5f;
        this.lowerLeftFontStyle.fontStyle = 1;
        this.lowerLeftFontStyle.alignment = 6;
        UnityEngine.GUIStyle val_9 = new UnityEngine.GUIStyle();
        this.barStyle = val_9;
        val_9.border = new UnityEngine.RectOffset(left:  1, right:  1, top:  1, bottom:  1);
        this.barStyle.normal.background = this.images.barImage;
        this.barStyle.active.background = this.images.button_activeImage;
        this.barStyle.alignment = 4;
        this.barStyle.margin = new UnityEngine.RectOffset(left:  1, right:  1, top:  1, bottom:  1);
        this.barStyle.clipping = 1;
        this.barStyle.fontSize = (int)S8 * 0.5f;
        UnityEngine.GUIStyle val_15 = new UnityEngine.GUIStyle();
        this.buttonActiveStyle = val_15;
        val_15.border = new UnityEngine.RectOffset(left:  1, right:  1, top:  1, bottom:  1);
        this.buttonActiveStyle.normal.background = this.images.button_activeImage;
        this.buttonActiveStyle.alignment = 4;
        this.buttonActiveStyle.margin = new UnityEngine.RectOffset(left:  1, right:  1, top:  1, bottom:  1);
        this.buttonActiveStyle.fontSize = (int)S8 * 0.5f;
        UnityEngine.GUIStyle val_20 = new UnityEngine.GUIStyle();
        this.backStyle = val_20;
        val_20.normal.background = this.images.even_logImage;
        this.backStyle.clipping = 1;
        this.backStyle.fontSize = (int)S8 * 0.5f;
        UnityEngine.GUIStyle val_23 = new UnityEngine.GUIStyle();
        this.evenLogStyle = val_23;
        val_23.normal.background = this.images.even_logImage;
        this.evenLogStyle.fixedHeight = V8.16B;
        this.evenLogStyle.clipping = 1;
        this.evenLogStyle.alignment = 0;
        this.evenLogStyle.imagePosition = 0;
        this.evenLogStyle.fontSize = (int)S8 * 0.5f;
        UnityEngine.GUIStyle val_26 = new UnityEngine.GUIStyle();
        this.oddLogStyle = val_26;
        val_26.normal.background = this.images.odd_logImage;
        this.oddLogStyle.fixedHeight = V8.16B;
        this.oddLogStyle.clipping = 1;
        this.oddLogStyle.alignment = 0;
        this.oddLogStyle.imagePosition = 0;
        this.oddLogStyle.fontSize = (int)S8 * 0.5f;
        UnityEngine.GUIStyle val_29 = new UnityEngine.GUIStyle();
        this.logButtonStyle = val_29;
        val_75 = val_75 * 0.2f;
        val_29.fixedHeight = V8.16B;
        this.logButtonStyle.clipping = 1;
        this.logButtonStyle.alignment = 0;
        this.logButtonStyle.fontSize = (int)S8 * 0.5f;
        this.logButtonStyle.padding = new UnityEngine.RectOffset(left:  (int)val_75, right:  (int)val_75, top:  (int)S10 * 0.2f, bottom:  (int)S10 * 0.2f);
        UnityEngine.GUIStyle val_33 = new UnityEngine.GUIStyle();
        this.selectedLogStyle = val_33;
        val_33.normal.background = this.images.selectedImage;
        this.selectedLogStyle.fixedHeight = V8.16B;
        this.selectedLogStyle.clipping = 1;
        this.selectedLogStyle.alignment = 0;
        UnityEngine.Color val_36 = UnityEngine.Color.white;
        this.selectedLogStyle.normal.textColor = new UnityEngine.Color() {r = val_36.r, g = val_36.g, b = val_36.b, a = val_36.a};
        this.selectedLogStyle.fontSize = (int)val_36.r * 0.5f;
        UnityEngine.GUIStyle val_38 = new UnityEngine.GUIStyle();
        this.selectedLogFontStyle = val_38;
        val_38.normal.background = this.images.selectedImage;
        this.selectedLogFontStyle.fixedHeight = val_36.r;
        this.selectedLogFontStyle.clipping = 1;
        this.selectedLogFontStyle.alignment = 0;
        UnityEngine.Color val_41 = UnityEngine.Color.white;
        this.selectedLogFontStyle.normal.textColor = new UnityEngine.Color() {r = val_41.r, g = val_41.g, b = val_41.b, a = val_41.a};
        this.selectedLogFontStyle.fontSize = (int)val_41.r * 0.5f;
        this.selectedLogFontStyle.padding = new UnityEngine.RectOffset(left:  (int)val_75, right:  (int)val_75, top:  (int)S10 * 0.2f, bottom:  (int)S10 * 0.2f);
        UnityEngine.GUIStyle val_44 = new UnityEngine.GUIStyle();
        this.stackLabelStyle = val_44;
        val_44.wordWrap = true;
        this.stackLabelStyle.fontSize = (int)val_41.r * 0.5f;
        this.stackLabelStyle.padding = new UnityEngine.RectOffset(left:  (int)val_75, right:  (int)val_75, top:  (int)S10 * 0.2f, bottom:  (int)S10 * 0.2f);
        UnityEngine.GUIStyle val_47 = new UnityEngine.GUIStyle();
        this.scrollerStyle = val_47;
        val_47.normal.background = this.images.barImage;
        UnityEngine.GUIStyle val_49 = new UnityEngine.GUIStyle();
        this.searchStyle = val_49;
        val_49.clipping = 1;
        this.searchStyle.alignment = 7;
        this.searchStyle.fontSize = (int)val_41.r * 0.5f;
        this.searchStyle.wordWrap = true;
        UnityEngine.GUIStyle val_51 = new UnityEngine.GUIStyle();
        this.sliderBackStyle = val_51;
        val_51.normal.background = this.images.barImage;
        this.sliderBackStyle.fixedHeight = val_41.r;
        this.sliderBackStyle.border = new UnityEngine.RectOffset(left:  1, right:  1, top:  1, bottom:  1);
        UnityEngine.GUIStyle val_54 = new UnityEngine.GUIStyle();
        this.sliderThumbStyle = val_54;
        val_54.normal.background = this.images.selectedImage;
        this.sliderThumbStyle.fixedWidth = this.size;
        UnityEngine.GUISkin val_56 = UnityEngine.Object.Instantiate<UnityEngine.GUISkin>(original:  this.images.reporterScrollerSkin);
        this.toolbarScrollerSkin = val_56;
        val_56.verticalScrollbar.fixedWidth = 0f;
        this.toolbarScrollerSkin.horizontalScrollbar.fixedHeight = 0f;
        this.toolbarScrollerSkin.verticalScrollbarThumb.fixedWidth = 0f;
        this.toolbarScrollerSkin.horizontalScrollbarThumb.fixedHeight = 0f;
        UnityEngine.GUISkin val_61 = UnityEngine.Object.Instantiate<UnityEngine.GUISkin>(original:  this.images.reporterScrollerSkin);
        this.logScrollerSkin = val_61;
        val_61.verticalScrollbar.fixedWidth = this.size + this.size;
        this.logScrollerSkin.horizontalScrollbar.fixedHeight = 0f;
        this.logScrollerSkin.verticalScrollbarThumb.fixedWidth = this.size + this.size;
        this.logScrollerSkin.horizontalScrollbarThumb.fixedHeight = 0f;
        UnityEngine.GUISkin val_68 = UnityEngine.Object.Instantiate<UnityEngine.GUISkin>(original:  this.images.reporterScrollerSkin);
        this.graphScrollerSkin = val_68;
        val_68.verticalScrollbar.fixedWidth = 0f;
        this.graphScrollerSkin.horizontalScrollbar.fixedHeight = this.size + this.size;
        this.graphScrollerSkin.verticalScrollbarThumb.fixedWidth = 0f;
        this.graphScrollerSkin.horizontalScrollbarThumb.fixedHeight = this.size + this.size;
    }
    private void Start()
    {
        System.DateTime val_1 = System.DateTime.Now;
        this.logDate = val_1.dateData;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(methodName:  "readInfo");
    }
    private void clear()
    {
        this.logs.Clear();
        this.collapsedLogs.Clear();
        this.currentLog.Clear();
        this.logsDic.Clear();
        this.selectedLog = 0;
        this.logsMemUsage = 0f;
        this.graphMemUsage = 0f;
        this.numOfCollapsedLogsWarning = 0;
        this.numOfCollapsedLogsError = 0;
        this.numOfLogsError = 0;
        this.numOfCollapsedLogs = 0;
        this.numOfLogs = 0;
        this.numOfLogsWarning = 0;
        this.samples.Clear();
        System.GC.Collect();
        this.selectedLog = 0;
    }
    private void calculateCurrentLog()
    {
        string val_16;
        var val_17;
        var val_18;
        var val_19;
        System.Collections.Generic.List<Log> val_20;
        var val_21;
        var val_22;
        bool val_1 = System.String.IsNullOrEmpty(value:  this.filterText);
        if(val_1 != false)
        {
                val_16 = "";
        }
        else
        {
                val_16 = this.filterText.ToLower();
        }
        
        this.currentLog.Clear();
        if(this.collapse == false)
        {
            goto label_5;
        }
        
        val_17 = 1152921529105353600;
        val_18 = 1152921529108089248;
        val_19 = 0;
        goto label_16;
        label_22:
        if(val_3.logType > 4)
        {
            goto label_19;
        }
        
        var val_16 = 40824700 + (val_3.logType) << 2;
        val_16 = val_16 + 40824700;
        goto (40824700 + (val_3.logType) << 2 + 40824700);
        label_19:
        if(val_1 != true)
        {
                if((val_3.condition.ToLower().Contains(value:  val_16)) == false)
        {
            goto label_20;
        }
        
        }
        
        this.currentLog.Add(item:  this.collapsedLogs.Item[0]);
        label_20:
        val_19 = 1;
        label_16:
        val_20 = this.collapsedLogs;
        if(val_19 < val_20.Count)
        {
            goto label_22;
        }
        
        goto label_23;
        label_5:
        val_17 = 1152921529105353600;
        val_18 = 1152921529108089248;
        val_21 = 0;
        goto label_34;
        label_40:
        if(val_7.logType > 4)
        {
            goto label_37;
        }
        
        var val_17 = 40824720 + (val_7.logType) << 2;
        val_17 = val_17 + 40824720;
        goto (40824720 + (val_7.logType) << 2 + 40824720);
        label_37:
        if(val_1 != true)
        {
                if((val_7.condition.ToLower().Contains(value:  val_16)) == false)
        {
            goto label_38;
        }
        
        }
        
        this.currentLog.Add(item:  this.logs.Item[0]);
        label_38:
        val_21 = 1;
        label_34:
        val_20 = this.logs;
        if(val_21 < val_20.Count)
        {
            goto label_40;
        }
        
        label_23:
        if(this.selectedLog == null)
        {
                return;
        }
        
        val_16 = this.currentLog;
        val_22 = val_16;
        if((val_22.IndexOf(item:  this.selectedLog)) == 1)
        {
                val_16 = this.currentLog;
            val_22 = val_16;
            int val_14 = val_22.IndexOf(item:  this.logsDic.Item[this.selectedLog.condition].Item[this.selectedLog.stacktrace]);
            if(val_14 == 1)
        {
                return;
        }
        
        }
        
        mem[1152921529108216400] = S0 * (float)val_14;
    }
    private void DrawInfo()
    {
        UnityEngine.Vector2 val_125;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.screenRect}, style:  this.backStyle);
        UnityEngine.Vector2 val_1 = this.getDrag();
        if(val_1.x != 0f)
        {
                val_125 = this.downPos;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_125, y = V11.16B}, rhs:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y})) != false)
        {
                UnityEngine.Vector2 val_125 = this.oldInfoDrag;
            val_125 = val_1.x - val_125;
            val_125 = this.infoScrollPosition - val_125;
            this.infoScrollPosition = val_125;
        }
        
        }
        
        if(val_1.y != 0f)
        {
                val_125 = this.downPos;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            float val_126 = val_125;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_126, y = V11.16B}, rhs:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y})) != false)
        {
                val_126 = val_1.y - val_126;
            val_126 = V11.16B + val_126;
            mem[1152921529109677636] = val_126;
        }
        
        }
        
        this.oldInfoDrag = val_1;
        mem[1152921529109677644] = val_1.y;
        UnityEngine.GUI.skin = this.toolbarScrollerSkin;
        UnityEngine.Vector2 val_7 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = this.infoScrollPosition, y = val_1.y}, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        this.infoScrollPosition = val_7;
        mem[1152921529109677636] = val_7.y;
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_9 = new UnityEngine.GUILayoutOption[2];
        val_9[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_9[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.buildFromContent, style:  this.nonStyle, options:  val_9);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_12 = new UnityEngine.GUILayoutOption[1];
        val_12[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.buildDate, style:  this.nonStyle, options:  val_12);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_15 = new UnityEngine.GUILayoutOption[2];
        val_15[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_15[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.systemInfoContent, style:  this.nonStyle, options:  val_15);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_18 = new UnityEngine.GUILayoutOption[1];
        val_18[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.deviceModel, style:  this.nonStyle, options:  val_18);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_20 = new UnityEngine.GUILayoutOption[1];
        val_20[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.deviceType, style:  this.nonStyle, options:  val_20);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_22 = new UnityEngine.GUILayoutOption[1];
        val_22[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.deviceName, style:  this.nonStyle, options:  val_22);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_25 = new UnityEngine.GUILayoutOption[2];
        val_25[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_25[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.graphicsInfoContent, style:  this.nonStyle, options:  val_25);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_29 = new UnityEngine.GUILayoutOption[1];
        val_29[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  UnityEngine.SystemInfo.graphicsDeviceName, style:  this.nonStyle, options:  val_29);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_31 = new UnityEngine.GUILayoutOption[1];
        val_31[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.graphicsMemorySize, style:  this.nonStyle, options:  val_31);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_33 = new UnityEngine.GUILayoutOption[1];
        val_33[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.maxTextureSize, style:  this.nonStyle, options:  val_33);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_38 = new UnityEngine.GUILayoutOption[1];
        val_38[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  "Screen Width " + UnityEngine.Screen.width, style:  this.nonStyle, options:  val_38);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_42 = new UnityEngine.GUILayoutOption[1];
        val_42[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  "Screen Height " + UnityEngine.Screen.height, style:  this.nonStyle, options:  val_42);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_45 = new UnityEngine.GUILayoutOption[2];
        val_45[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_45[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.showMemoryContent, style:  this.nonStyle, options:  val_45);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_49 = new UnityEngine.GUILayoutOption[1];
        val_49[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.systemMemorySize + " mb", style:  this.nonStyle, options:  val_49);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_54 = new UnityEngine.GUILayoutOption[1];
        val_54[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  "Mem Usage Of Logs " + this.logsMemUsage.ToString(format:  "0.000")(this.logsMemUsage.ToString(format:  "0.000")) + " mb", style:  this.nonStyle, options:  val_54);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_58 = new UnityEngine.GUILayoutOption[1];
        val_58[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  "GC Memory " + this.gcTotalMemory.ToString(format:  "0.000")(this.gcTotalMemory.ToString(format:  "0.000")) + " mb", style:  this.nonStyle, options:  val_58);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_61 = new UnityEngine.GUILayoutOption[2];
        val_61[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_61[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.softwareContent, style:  this.nonStyle, options:  val_61);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_65 = new UnityEngine.GUILayoutOption[1];
        val_65[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  UnityEngine.SystemInfo.operatingSystem, style:  this.nonStyle, options:  val_65);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_68 = new UnityEngine.GUILayoutOption[2];
        val_68[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_68[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.dateContent, style:  this.nonStyle, options:  val_68);
        UnityEngine.GUILayout.Space(pixels:  this.size.x);
        System.DateTime val_71 = System.DateTime.Now;
        UnityEngine.GUILayoutOption[] val_72 = new UnityEngine.GUILayoutOption[1];
        val_72[0] = UnityEngine.GUILayout.Height(height:  this.size.x);
        UnityEngine.GUILayout.Label(text:  val_71.dateData, style:  this.nonStyle, options:  val_72);
        UnityEngine.GUILayoutOption[] val_75 = new UnityEngine.GUILayoutOption[1];
        val_75[0] = UnityEngine.GUILayout.Height(height:  this.size.x);
        UnityEngine.GUILayout.Label(text:  " - Application Started At "(" - Application Started At ") + this.logDate, style:  this.nonStyle, options:  val_75);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_78 = new UnityEngine.GUILayoutOption[2];
        val_78[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_78[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.showTimeContent, style:  this.nonStyle, options:  val_78);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        float val_81 = UnityEngine.Time.realtimeSinceStartup;
        UnityEngine.GUILayoutOption[] val_83 = new UnityEngine.GUILayoutOption[1];
        val_83[0] = UnityEngine.GUILayout.Height(height:  val_81);
        UnityEngine.GUILayout.Label(text:  val_81.ToString(format:  "000"), style:  this.nonStyle, options:  val_83);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_86 = new UnityEngine.GUILayoutOption[2];
        val_86[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_86[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.showFpsContent, style:  this.nonStyle, options:  val_86);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_89 = new UnityEngine.GUILayoutOption[1];
        val_89[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.fpsText, style:  this.nonStyle, options:  val_89);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_92 = new UnityEngine.GUILayoutOption[2];
        val_92[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_92[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.userContent, style:  this.nonStyle, options:  val_92);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_95 = new UnityEngine.GUILayoutOption[1];
        val_95[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.UserData, style:  this.nonStyle, options:  val_95);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_98 = new UnityEngine.GUILayoutOption[2];
        val_98[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_98[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.showSceneContent, style:  this.nonStyle, options:  val_98);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_101 = new UnityEngine.GUILayoutOption[1];
        val_101[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.currentScene, style:  this.nonStyle, options:  val_101);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_104 = new UnityEngine.GUILayoutOption[2];
        val_104[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_104[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.showSceneContent, style:  this.nonStyle, options:  val_104);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_109 = new UnityEngine.GUILayoutOption[1];
        val_109[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  "Unity Version = "("Unity Version = ") + UnityEngine.Application.unityVersion, style:  this.nonStyle, options:  val_109);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        this.drawInfo_enableDisableToolBarButtons();
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_114 = new UnityEngine.GUILayoutOption[1];
        val_114[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  "Size = "("Size = ") + this.size.ToString(format:  "0.0")(this.size.ToString(format:  "0.0")), style:  this.nonStyle, options:  val_114);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_116 = new UnityEngine.GUILayoutOption[1];
        float val_127 = (float)UnityEngine.Screen.width;
        val_127 = val_127 * 0.5f;
        val_116[0] = UnityEngine.GUILayout.Width(width:  val_127);
        float val_119 = UnityEngine.GUILayout.HorizontalSlider(value:  this.size, leftValue:  16f, rightValue:  64f, slider:  this.sliderBackStyle, thumb:  this.sliderThumbStyle, options:  val_116);
        if(this.size.x != val_119)
        {
                mem[1152921529109677188] = val_119;
            this.size = val_119;
            this.initializeStyle();
        }
        
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_121 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_128 = this.size;
        val_128 = val_128 + val_128;
        val_121[0] = UnityEngine.GUILayout.Width(width:  val_128);
        val_128 = val_128 + val_128;
        val_121[1] = UnityEngine.GUILayout.Height(height:  val_128);
        if((UnityEngine.GUILayout.Button(content:  this.backContent, style:  this.barStyle, options:  val_121)) != false)
        {
                this.currentView = 1;
        }
        
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.EndScrollView();
        UnityEngine.GUILayout.EndArea();
    }
    private void drawInfo_enableDisableToolBarButtons()
    {
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_2 = new UnityEngine.GUILayoutOption[1];
        UnityEngine.GUILayoutOption val_3 = UnityEngine.GUILayout.Height(height:  this.size);
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(val_3 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_3 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = val_3;
        UnityEngine.GUILayout.Label(text:  "Hide or Show tool bar buttons", style:  this.nonStyle, options:  val_2);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_6 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_54 = this.size;
        val_54 = val_54 + val_54;
        UnityEngine.GUILayoutOption val_7 = UnityEngine.GUILayout.Width(width:  val_54);
        if(val_6 == null)
        {
            goto label_7;
        }
        
        if(val_7 != null)
        {
            goto label_8;
        }
        
        goto label_11;
        label_7:
        if(val_7 == null)
        {
            goto label_11;
        }
        
        label_8:
        label_11:
        val_6[0] = val_7;
        val_54 = val_54 + val_54;
        val_6[1] = UnityEngine.GUILayout.Height(height:  val_54);
        if((UnityEngine.GUILayout.Button(content:  this.clearOnNewSceneContent, style:  (this.showClearOnNewSceneLoadedButton == true) ? this.buttonActiveStyle : this.barStyle, options:  val_6)) != false)
        {
                bool val_55 = this.showClearOnNewSceneLoadedButton;
            val_55 = val_55 ^ 1;
            this.showClearOnNewSceneLoadedButton = val_55;
        }
        
        UnityEngine.GUILayoutOption[] val_11 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_56 = this.size;
        val_56 = val_56 + val_56;
        UnityEngine.GUILayoutOption val_12 = UnityEngine.GUILayout.Width(width:  val_56);
        if(val_11 == null)
        {
            goto label_17;
        }
        
        if(val_12 != null)
        {
            goto label_18;
        }
        
        goto label_21;
        label_17:
        if(val_12 == null)
        {
            goto label_21;
        }
        
        label_18:
        label_21:
        val_11[0] = val_12;
        val_56 = val_56 + val_56;
        val_11[1] = UnityEngine.GUILayout.Height(height:  val_56);
        if((UnityEngine.GUILayout.Button(content:  this.showTimeContent, style:  (this.showTimeButton == true) ? this.buttonActiveStyle : this.barStyle, options:  val_11)) != false)
        {
                bool val_57 = this.showTimeButton;
            val_57 = val_57 ^ 1;
            this.showTimeButton = val_57;
        }
        
        UnityEngine.Rect val_15 = UnityEngine.GUILayoutUtility.GetLastRect();
        this.tempRect = val_15;
        mem[1152921529111285508] = val_15.m_YMin;
        mem[1152921529111285512] = val_15.m_Width;
        mem[1152921529111285516] = val_15.m_Height;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_15.m_XMin, m_YMin = val_15.m_YMin, m_Width = val_15.m_Width, m_Height = val_15.m_Height}, text:  UnityEngine.Time.realtimeSinceStartup.ToString(format:  "0.0"), style:  this.lowerLeftFontStyle);
        UnityEngine.GUILayoutOption[] val_19 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_58 = this.size;
        val_58 = val_58 + val_58;
        UnityEngine.GUILayoutOption val_20 = UnityEngine.GUILayout.Width(width:  val_58);
        if(val_19 == null)
        {
            goto label_31;
        }
        
        if(val_20 != null)
        {
            goto label_32;
        }
        
        goto label_35;
        label_31:
        if(val_20 == null)
        {
            goto label_35;
        }
        
        label_32:
        label_35:
        val_19[0] = val_20;
        val_58 = val_58 + val_58;
        val_19[1] = UnityEngine.GUILayout.Height(height:  val_58);
        if((UnityEngine.GUILayout.Button(content:  this.showSceneContent, style:  (this.showSceneButton == true) ? this.buttonActiveStyle : this.barStyle, options:  val_19)) != false)
        {
                bool val_59 = this.showSceneButton;
            val_59 = val_59 ^ 1;
            this.showSceneButton = val_59;
        }
        
        UnityEngine.Rect val_23 = UnityEngine.GUILayoutUtility.GetLastRect();
        this.tempRect = val_23;
        mem[1152921529111285508] = val_23.m_YMin;
        mem[1152921529111285512] = val_23.m_Width;
        mem[1152921529111285516] = val_23.m_Height;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_23.m_XMin, m_YMin = val_23.m_YMin, m_Width = val_23.m_Width, m_Height = val_23.m_Height}, text:  this.currentScene, style:  this.lowerLeftFontStyle);
        UnityEngine.GUILayoutOption[] val_25 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_60 = this.size;
        val_60 = val_60 + val_60;
        UnityEngine.GUILayoutOption val_26 = UnityEngine.GUILayout.Width(width:  val_60);
        if(val_25 == null)
        {
            goto label_45;
        }
        
        if(val_26 != null)
        {
            goto label_46;
        }
        
        goto label_49;
        label_45:
        if(val_26 == null)
        {
            goto label_49;
        }
        
        label_46:
        label_49:
        val_25[0] = val_26;
        val_60 = val_60 + val_60;
        val_25[1] = UnityEngine.GUILayout.Height(height:  val_60);
        if((UnityEngine.GUILayout.Button(content:  this.showMemoryContent, style:  (this.showMemButton == true) ? this.buttonActiveStyle : this.barStyle, options:  val_25)) != false)
        {
                bool val_61 = this.showMemButton;
            val_61 = val_61 ^ 1;
            this.showMemButton = val_61;
        }
        
        UnityEngine.Rect val_29 = UnityEngine.GUILayoutUtility.GetLastRect();
        this.tempRect = val_29;
        mem[1152921529111285508] = val_29.m_YMin;
        mem[1152921529111285512] = val_29.m_Width;
        mem[1152921529111285516] = val_29.m_Height;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_29.m_XMin, m_YMin = val_29.m_YMin, m_Width = val_29.m_Width, m_Height = val_29.m_Height}, text:  this.gcTotalMemory.ToString(format:  "0.0"), style:  this.lowerLeftFontStyle);
        UnityEngine.GUILayoutOption[] val_32 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_62 = this.size;
        val_62 = val_62 + val_62;
        UnityEngine.GUILayoutOption val_33 = UnityEngine.GUILayout.Width(width:  val_62);
        if(val_32 == null)
        {
            goto label_59;
        }
        
        if(val_33 != null)
        {
            goto label_60;
        }
        
        goto label_63;
        label_59:
        if(val_33 == null)
        {
            goto label_63;
        }
        
        label_60:
        label_63:
        val_32[0] = val_33;
        val_62 = val_62 + val_62;
        val_32[1] = UnityEngine.GUILayout.Height(height:  val_62);
        if((UnityEngine.GUILayout.Button(content:  this.showFpsContent, style:  (this.showFpsButton == true) ? this.buttonActiveStyle : this.barStyle, options:  val_32)) != false)
        {
                bool val_63 = this.showFpsButton;
            val_63 = val_63 ^ 1;
            this.showFpsButton = val_63;
        }
        
        UnityEngine.Rect val_36 = UnityEngine.GUILayoutUtility.GetLastRect();
        this.tempRect = val_36;
        mem[1152921529111285508] = val_36.m_YMin;
        mem[1152921529111285512] = val_36.m_Width;
        mem[1152921529111285516] = val_36.m_Height;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_36.m_XMin, m_YMin = val_36.m_YMin, m_Width = val_36.m_Width, m_Height = val_36.m_Height}, text:  this.fpsText, style:  this.lowerLeftFontStyle);
        UnityEngine.GUILayoutOption[] val_38 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_64 = this.size;
        val_64 = val_64 + val_64;
        UnityEngine.GUILayoutOption val_39 = UnityEngine.GUILayout.Width(width:  val_64);
        if(val_38 == null)
        {
            goto label_73;
        }
        
        if(val_39 != null)
        {
            goto label_74;
        }
        
        goto label_77;
        label_73:
        if(val_39 == null)
        {
            goto label_77;
        }
        
        label_74:
        label_77:
        val_38[0] = val_39;
        val_64 = val_64 + val_64;
        val_38[1] = UnityEngine.GUILayout.Height(height:  val_64);
        if((UnityEngine.GUILayout.Button(content:  this.searchContent, style:  (this.showSearchText == true) ? this.buttonActiveStyle : this.barStyle, options:  val_38)) != false)
        {
                bool val_65 = this.showSearchText;
            val_65 = val_65 ^ 1;
            this.showSearchText = val_65;
        }
        
        UnityEngine.GUILayoutOption[] val_43 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_66 = this.size;
        val_66 = val_66 + val_66;
        UnityEngine.GUILayoutOption val_44 = UnityEngine.GUILayout.Width(width:  val_66);
        if(val_43 == null)
        {
            goto label_83;
        }
        
        if(val_44 != null)
        {
            goto label_84;
        }
        
        goto label_87;
        label_83:
        if(val_44 == null)
        {
            goto label_87;
        }
        
        label_84:
        label_87:
        val_43[0] = val_44;
        val_66 = val_66 + val_66;
        val_43[1] = UnityEngine.GUILayout.Height(height:  val_66);
        if((UnityEngine.GUILayout.Button(content:  this.copyContent, style:  (this.showCopyButton == true) ? this.buttonActiveStyle : this.barStyle, options:  val_43)) != false)
        {
                bool val_67 = this.showCopyButton;
            val_67 = val_67 ^ 1;
            this.showCopyButton = val_67;
        }
        
        UnityEngine.GUILayoutOption[] val_48 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_68 = this.size;
        val_68 = val_68 + val_68;
        UnityEngine.GUILayoutOption val_49 = UnityEngine.GUILayout.Width(width:  val_68);
        if(val_48 == null)
        {
            goto label_93;
        }
        
        if(val_49 != null)
        {
            goto label_94;
        }
        
        goto label_97;
        label_93:
        if(val_49 == null)
        {
            goto label_97;
        }
        
        label_94:
        label_97:
        val_48[0] = val_49;
        val_68 = val_68 + val_68;
        val_48[1] = UnityEngine.GUILayout.Height(height:  val_68);
        if((UnityEngine.GUILayout.Button(content:  this.saveLogsContent, style:  (this.showSaveButton == true) ? this.buttonActiveStyle : this.barStyle, options:  val_48)) != false)
        {
                bool val_69 = this.showSaveButton;
            val_69 = val_69 ^ 1;
            this.showSaveButton = val_69;
        }
        
        UnityEngine.Rect val_52 = UnityEngine.GUILayoutUtility.GetLastRect();
        this.tempRect = val_52;
        mem[1152921529111285508] = val_52.m_YMin;
        mem[1152921529111285512] = val_52.m_Width;
        mem[1152921529111285516] = val_52.m_Height;
        string val_53 = UnityEngine.GUI.TextField(position:  new UnityEngine.Rect() {m_XMin = val_52.m_XMin, m_YMin = val_52.m_YMin, m_Width = val_52.m_Width, m_Height = val_52.m_Height}, text:  this.filterText, style:  this.searchStyle);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
    }
    private void DrawReport()
    {
        this.screenRect.x = 0f;
        int val_1 = UnityEngine.Screen.width;
        int val_2 = UnityEngine.Screen.height;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.screenRect}, style:  this.backStyle);
        UnityEngine.GUILayout.BeginVertical(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayoutOption[] val_5 = new UnityEngine.GUILayoutOption[1];
        UnityEngine.GUILayoutOption val_6 = UnityEngine.GUILayout.Height(height:  this.screenRect);
        if(val_5 == null)
        {
            goto label_1;
        }
        
        if(val_6 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_6 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_5[0] = val_6;
        UnityEngine.GUILayout.Label(text:  "Select Photo", style:  this.nonStyle, options:  val_5);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayoutOption[] val_8 = new UnityEngine.GUILayoutOption[1];
        UnityEngine.GUILayoutOption val_9 = UnityEngine.GUILayout.Height(height:  this.screenRect);
        if(val_8 == null)
        {
            goto label_7;
        }
        
        if(val_9 != null)
        {
            goto label_8;
        }
        
        goto label_11;
        label_7:
        if(val_9 == null)
        {
            goto label_11;
        }
        
        label_8:
        label_11:
        val_8[0] = val_9;
        UnityEngine.GUILayout.Label(text:  "Coming Soon", style:  this.nonStyle, options:  val_8);
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayoutOption[] val_11 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.GUILayoutOption val_12 = UnityEngine.GUILayout.Width(width:  this.size);
        if(val_11 == null)
        {
            goto label_13;
        }
        
        if(val_12 != null)
        {
            goto label_14;
        }
        
        goto label_17;
        label_13:
        if(val_12 == null)
        {
            goto label_17;
        }
        
        label_14:
        label_17:
        val_11[0] = val_12;
        val_11[1] = UnityEngine.GUILayout.Height(height:  this.size);
        if((UnityEngine.GUILayout.Button(content:  this.backContent, style:  this.barStyle, options:  val_11)) != false)
        {
                this.currentView = 1;
        }
        
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndVertical();
        UnityEngine.GUILayout.EndArea();
    }
    private void drawToolBar()
    {
        var val_111;
        float val_112;
        UnityEngine.Vector2 val_113;
        int val_115;
        int val_116;
        int val_117;
        val_111 = this;
        this.toolBarRect.x = 0f;
        float val_111 = (float)UnityEngine.Screen.width;
        val_111 = val_111 + val_111;
        UnityEngine.GUI.skin = this.toolbarScrollerSkin;
        UnityEngine.Vector2 val_2 = this.getDrag();
        if(val_2.x != 0f)
        {
                UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            UnityEngine.Vector2 val_112 = this.downPos;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_112, y = V10.16B}, rhs:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y})) != false)
        {
                val_112 = val_112 * (-2f);
            val_112 = (float)UnityEngine.Screen.height + val_112;
            if(this.downPos > val_112)
        {
                float val_113 = this.toolbarOldDrag;
            val_113 = val_2.x - val_113;
            val_113 = this.toolbarScrollPosition - val_113;
            this.toolbarScrollPosition = val_113;
        }
        
        }
        
        }
        
        this.toolbarOldDrag = val_2.x;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.toolBarRect, m_YMin = this.toolbarScrollPosition, m_Width = -2f, m_Height = val_3.y});
        val_113 = this.toolbarScrollPosition;
        UnityEngine.Vector2 val_7 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = val_113, y = this.downPos}, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        this.toolbarScrollPosition = val_7;
        mem[1152921529112805584] = val_7.y;
        UnityEngine.GUILayout.BeginHorizontal(style:  this.barStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayoutOption[] val_9 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_114 = this.size;
        val_114 = val_114 + val_114;
        val_9[0] = UnityEngine.GUILayout.Width(width:  val_114);
        val_114 = val_114 + val_114;
        val_9[1] = UnityEngine.GUILayout.Height(height:  val_114);
        if((UnityEngine.GUILayout.Button(content:  this.clearContent, style:  this.barStyle, options:  val_9)) != false)
        {
                this.clear();
        }
        
        UnityEngine.GUILayoutOption[] val_14 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_115 = this.size;
        val_115 = val_115 + val_115;
        val_14[0] = UnityEngine.GUILayout.Width(width:  val_115);
        val_115 = val_115 + val_115;
        val_14[1] = UnityEngine.GUILayout.Height(height:  val_115);
        if((UnityEngine.GUILayout.Button(content:  this.collapseContent, style:  (this.collapse == true) ? this.buttonActiveStyle : this.barStyle, options:  val_14)) != false)
        {
                bool val_116 = this.collapse;
            val_116 = val_116 ^ 1;
            this.collapse = val_116;
            this.calculateCurrentLog();
        }
        
        if(this.showClearOnNewSceneLoadedButton != false)
        {
                UnityEngine.GUILayoutOption[] val_19 = new UnityEngine.GUILayoutOption[2];
            UnityEngine.Vector2 val_117 = this.size;
            val_117 = val_117 + val_117;
            val_19[0] = UnityEngine.GUILayout.Width(width:  val_117);
            val_117 = val_117 + val_117;
            val_19[1] = UnityEngine.GUILayout.Height(height:  val_117);
            if((UnityEngine.GUILayout.Button(content:  this.clearOnNewSceneContent, style:  (this.clearOnNewSceneLoaded == true) ? this.buttonActiveStyle : this.barStyle, options:  val_19)) != false)
        {
                bool val_118 = this.clearOnNewSceneLoaded;
            val_118 = val_118 ^ 1;
            this.clearOnNewSceneLoaded = val_118;
        }
        
        }
        
        if(this.showTimeButton != false)
        {
                UnityEngine.GUILayoutOption[] val_24 = new UnityEngine.GUILayoutOption[2];
            UnityEngine.Vector2 val_119 = this.size;
            val_119 = val_119 + val_119;
            val_24[0] = UnityEngine.GUILayout.Width(width:  val_119);
            val_119 = val_119 + val_119;
            val_24[1] = UnityEngine.GUILayout.Height(height:  val_119);
            if((UnityEngine.GUILayout.Button(content:  this.showTimeContent, style:  (this.showTime == true) ? this.buttonActiveStyle : this.barStyle, options:  val_24)) != false)
        {
                bool val_120 = this.showTime;
            val_120 = val_120 ^ 1;
            this.showTime = val_120;
        }
        
        }
        
        if(this.showSceneButton != false)
        {
                UnityEngine.Rect val_28 = UnityEngine.GUILayoutUtility.GetLastRect();
            this.tempRect = val_28;
            mem[1152921529112805796] = val_28.m_YMin;
            mem[1152921529112805800] = val_28.m_Width;
            mem[1152921529112805804] = val_28.m_Height;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_28.m_XMin, m_YMin = val_28.m_YMin, m_Width = val_28.m_Width, m_Height = val_28.m_Height}, text:  UnityEngine.Time.realtimeSinceStartup.ToString(format:  "0.0"), style:  this.lowerLeftFontStyle);
            UnityEngine.GUILayoutOption[] val_32 = new UnityEngine.GUILayoutOption[2];
            UnityEngine.Vector2 val_121 = this.size;
            val_121 = val_121 + val_121;
            val_32[0] = UnityEngine.GUILayout.Width(width:  val_121);
            val_121 = val_121 + val_121;
            val_32[1] = UnityEngine.GUILayout.Height(height:  val_121);
            if((UnityEngine.GUILayout.Button(content:  this.showSceneContent, style:  (this.showScene == true) ? this.buttonActiveStyle : this.barStyle, options:  val_32)) != false)
        {
                bool val_122 = this.showScene;
            val_122 = val_122 ^ 1;
            this.showScene = val_122;
        }
        
            UnityEngine.Rect val_36 = UnityEngine.GUILayoutUtility.GetLastRect();
            val_113 = val_36.m_XMin;
            val_112 = val_36.m_Width;
            this.tempRect = val_36;
            mem[1152921529112805796] = val_36.m_YMin;
            mem[1152921529112805800] = val_112;
            mem[1152921529112805804] = val_36.m_Height;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_113, m_YMin = val_36.m_YMin, m_Width = val_112, m_Height = val_36.m_Height}, text:  this.currentScene, style:  this.lowerLeftFontStyle);
        }
        
        if(this.showMemButton != false)
        {
                UnityEngine.GUILayoutOption[] val_38 = new UnityEngine.GUILayoutOption[2];
            UnityEngine.Vector2 val_123 = this.size;
            val_123 = val_123 + val_123;
            val_38[0] = UnityEngine.GUILayout.Width(width:  val_123);
            val_123 = val_123 + val_123;
            val_38[1] = UnityEngine.GUILayout.Height(height:  val_123);
            if((UnityEngine.GUILayout.Button(content:  this.showMemoryContent, style:  (this.showMemory == true) ? this.buttonActiveStyle : this.barStyle, options:  val_38)) != false)
        {
                bool val_124 = this.showMemory;
            val_124 = val_124 ^ 1;
            this.showMemory = val_124;
        }
        
            UnityEngine.Rect val_42 = UnityEngine.GUILayoutUtility.GetLastRect();
            val_113 = val_42.m_XMin;
            val_112 = val_42.m_Width;
            this.tempRect = val_42;
            mem[1152921529112805796] = val_42.m_YMin;
            mem[1152921529112805800] = val_112;
            mem[1152921529112805804] = val_42.m_Height;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_113, m_YMin = val_42.m_YMin, m_Width = val_112, m_Height = val_42.m_Height}, text:  this.gcTotalMemory.ToString(format:  "0.0"), style:  this.lowerLeftFontStyle);
        }
        
        if(this.showFpsButton != false)
        {
                UnityEngine.GUILayoutOption[] val_45 = new UnityEngine.GUILayoutOption[2];
            UnityEngine.Vector2 val_125 = this.size;
            val_125 = val_125 + val_125;
            val_45[0] = UnityEngine.GUILayout.Width(width:  val_125);
            val_125 = val_125 + val_125;
            val_45[1] = UnityEngine.GUILayout.Height(height:  val_125);
            if((UnityEngine.GUILayout.Button(content:  this.showFpsContent, style:  (this.showFps == true) ? this.buttonActiveStyle : this.barStyle, options:  val_45)) != false)
        {
                bool val_126 = this.showFps;
            val_126 = val_126 ^ 1;
            this.showFps = val_126;
        }
        
            UnityEngine.Rect val_49 = UnityEngine.GUILayoutUtility.GetLastRect();
            val_113 = val_49.m_XMin;
            val_112 = val_49.m_Width;
            this.tempRect = val_49;
            mem[1152921529112805796] = val_49.m_YMin;
            mem[1152921529112805800] = val_112;
            mem[1152921529112805804] = val_49.m_Height;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_113, m_YMin = val_49.m_YMin, m_Width = val_112, m_Height = val_49.m_Height}, text:  this.fpsText, style:  this.lowerLeftFontStyle);
        }
        
        if(this.showSearchText != false)
        {
                UnityEngine.GUILayoutOption[] val_50 = new UnityEngine.GUILayoutOption[2];
            UnityEngine.Vector2 val_127 = this.size;
            val_127 = val_127 + val_127;
            val_50[0] = UnityEngine.GUILayout.Width(width:  val_127);
            val_127 = val_127 + val_127;
            val_50[1] = UnityEngine.GUILayout.Height(height:  val_127);
            UnityEngine.GUILayout.Box(content:  this.searchContent, style:  this.barStyle, options:  val_50);
            UnityEngine.Rect val_53 = UnityEngine.GUILayoutUtility.GetLastRect();
            val_113 = val_53.m_XMin;
            val_112 = val_53.m_Width;
            this.tempRect = val_53;
            mem[1152921529112805796] = val_53.m_YMin;
            mem[1152921529112805800] = val_112;
            mem[1152921529112805804] = val_53.m_Height;
            string val_54 = UnityEngine.GUI.TextField(position:  new UnityEngine.Rect() {m_XMin = val_113, m_YMin = val_53.m_YMin, m_Width = val_112, m_Height = val_53.m_Height}, text:  this.filterText, style:  this.searchStyle);
            if((System.String.op_Inequality(a:  val_54, b:  this.filterText)) != false)
        {
                this.filterText = val_54;
            this.calculateCurrentLog();
        }
        
        }
        
        if(this.showCopyButton != false)
        {
                UnityEngine.GUILayoutOption[] val_56 = new UnityEngine.GUILayoutOption[2];
            UnityEngine.Vector2 val_128 = this.size;
            val_128 = val_128 + val_128;
            val_56[0] = UnityEngine.GUILayout.Width(width:  val_128);
            val_128 = val_128 + val_128;
            val_56[1] = UnityEngine.GUILayout.Height(height:  val_128);
            if((UnityEngine.GUILayout.Button(content:  this.copyContent, style:  this.barStyle, options:  val_56)) != false)
        {
                if(this.selectedLog != null)
        {
                string val_62 = this.selectedLog.condition + System.Environment.NewLine + System.Environment.NewLine + this.selectedLog.stacktrace;
        }
        
            UnityEngine.GUIUtility.systemCopyBuffer = "No log selected";
        }
        
        }
        
        if(this.showSaveButton != false)
        {
                UnityEngine.GUILayoutOption[] val_63 = new UnityEngine.GUILayoutOption[2];
            UnityEngine.Vector2 val_129 = this.size;
            val_129 = val_129 + val_129;
            val_63[0] = UnityEngine.GUILayout.Width(width:  val_129);
            val_129 = val_129 + val_129;
            val_63[1] = UnityEngine.GUILayout.Height(height:  val_129);
            if((UnityEngine.GUILayout.Button(content:  this.saveLogsContent, style:  this.barStyle, options:  val_63)) != false)
        {
                this.SaveLogsToDevice();
        }
        
        }
        
        UnityEngine.GUILayoutOption[] val_67 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_130 = this.size;
        val_130 = val_130 + val_130;
        val_67[0] = UnityEngine.GUILayout.Width(width:  val_130);
        val_130 = val_130 + val_130;
        val_67[1] = UnityEngine.GUILayout.Height(height:  val_130);
        if((UnityEngine.GUILayout.Button(content:  this.infoContent, style:  this.barStyle, options:  val_67)) != false)
        {
                this.currentView = 2;
        }
        
        UnityEngine.GUILayout.FlexibleSpace();
        if(this.collapse != false)
        {
                val_115 = this.numOfCollapsedLogs;
        }
        else
        {
                val_115 = this.numOfLogs;
        }
        
        if(this.collapse != false)
        {
                val_116 = this.numOfCollapsedLogsWarning;
        }
        else
        {
                val_116 = this.numOfLogsWarning;
        }
        
        if(this.collapse != false)
        {
                val_117 = this.numOfCollapsedLogsError;
        }
        else
        {
                val_117 = this.numOfLogsError;
        }
        
        UnityEngine.GUILayout.BeginHorizontal(style:  (this.showLog == true) ? this.buttonActiveStyle : this.barStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayoutOption[] val_76 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_131 = this.size;
        val_131 = val_131 + val_131;
        val_76[0] = UnityEngine.GUILayout.Width(width:  val_131);
        val_131 = val_131 + val_131;
        val_76[1] = UnityEngine.GUILayout.Height(height:  val_131);
        if((UnityEngine.GUILayout.Button(content:  this.logContent, style:  this.nonStyle, options:  val_76)) != false)
        {
                bool val_132 = this.showLog;
            val_132 = val_132 ^ 1;
            this.showLog = val_132;
            this.calculateCurrentLog();
        }
        
        UnityEngine.GUILayoutOption[] val_80 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_133 = this.size;
        val_133 = val_133 + val_133;
        val_80[0] = UnityEngine.GUILayout.Width(width:  val_133);
        val_133 = val_133 + val_133;
        val_80[1] = UnityEngine.GUILayout.Height(height:  val_133);
        if((UnityEngine.GUILayout.Button(text:  " " + val_115, style:  this.nonStyle, options:  val_80)) != false)
        {
                bool val_134 = this.showLog;
            val_134 = val_134 ^ 1;
            this.showLog = val_134;
            this.calculateCurrentLog();
        }
        
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(style:  (this.showWarning == true) ? this.buttonActiveStyle : this.barStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayoutOption[] val_86 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_135 = this.size;
        val_135 = val_135 + val_135;
        val_86[0] = UnityEngine.GUILayout.Width(width:  val_135);
        val_135 = val_135 + val_135;
        val_86[1] = UnityEngine.GUILayout.Height(height:  val_135);
        if((UnityEngine.GUILayout.Button(content:  this.warningContent, style:  this.nonStyle, options:  val_86)) != false)
        {
                bool val_136 = this.showWarning;
            val_136 = val_136 ^ 1;
            this.showWarning = val_136;
            this.calculateCurrentLog();
        }
        
        UnityEngine.GUILayoutOption[] val_90 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_137 = this.size;
        val_137 = val_137 + val_137;
        val_90[0] = UnityEngine.GUILayout.Width(width:  val_137);
        val_137 = val_137 + val_137;
        val_90[1] = UnityEngine.GUILayout.Height(height:  val_137);
        if((UnityEngine.GUILayout.Button(text:  " " + val_116, style:  this.nonStyle, options:  val_90)) != false)
        {
                bool val_138 = this.showWarning;
            val_138 = val_138 ^ 1;
            this.showWarning = val_138;
            this.calculateCurrentLog();
        }
        
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(style:  (this.showError == true) ? this.buttonActiveStyle : this.nonStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayoutOption[] val_96 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_139 = this.size;
        val_139 = val_139 + val_139;
        val_96[0] = UnityEngine.GUILayout.Width(width:  val_139);
        val_139 = val_139 + val_139;
        val_96[1] = UnityEngine.GUILayout.Height(height:  val_139);
        if((UnityEngine.GUILayout.Button(content:  this.errorContent, style:  this.nonStyle, options:  val_96)) != false)
        {
                bool val_140 = this.showError;
            val_140 = val_140 ^ 1;
            this.showError = val_140;
            this.calculateCurrentLog();
        }
        
        UnityEngine.GUILayoutOption[] val_100 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_141 = this.size;
        val_141 = val_141 + val_141;
        val_100[0] = UnityEngine.GUILayout.Width(width:  val_141);
        val_141 = val_141 + val_141;
        val_100[1] = UnityEngine.GUILayout.Height(height:  val_141);
        if((UnityEngine.GUILayout.Button(text:  " " + val_117, style:  this.nonStyle, options:  val_100)) != false)
        {
                bool val_142 = this.showError;
            val_142 = val_142 ^ 1;
            this.showError = val_142;
            this.calculateCurrentLog();
        }
        
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayoutOption[] val_104 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_143 = this.size;
        val_143 = val_143 + val_143;
        val_104[0] = UnityEngine.GUILayout.Width(width:  val_143);
        val_143 = val_143 + val_143;
        val_104[1] = UnityEngine.GUILayout.Height(height:  val_143);
        if((UnityEngine.GUILayout.Button(content:  this.closeContent, style:  this.barStyle, options:  val_104)) != false)
        {
                this.show = false;
            UnityEngine.Object.DestroyImmediate(obj:  this.gameObject.GetComponent<ReporterGUI>());
            val_111 = this.gameObject;
            val_111.SendMessage(methodName:  "OnHideReporter");
        }
        
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.EndScrollView();
        UnityEngine.GUILayout.EndArea();
    }
    private void DrawLogs()
    {
        float val_70;
        var val_72;
        int val_75;
        int val_76;
        int val_77;
        var val_78;
        var val_79;
        var val_80;
        int val_81;
        int val_82;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.logsRect}, style:  this.backStyle);
        UnityEngine.GUI.skin = this.logScrollerSkin;
        UnityEngine.Vector2 val_1 = this.getDrag();
        val_70 = val_1.y;
        if(val_70 != 0f)
        {
                float val_65 = (float)UnityEngine.Screen.height;
            val_65 = val_65 - val_1.x;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  this.downPos, y:  val_65);
            if((this.logsRect & 1) != 0)
        {
                float val_66 = this.oldDrag;
            val_66 = val_70 - val_66;
            val_66 = val_3.y + val_66;
            mem[1152921529113979872] = val_66;
        }
        
        }
        
        val_72 = 1152921525908610224;
        UnityEngine.Vector2 val_5 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = this.scrollPosition, y = V10.16B}, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        this.scrollPosition = val_5;
        mem[1152921529113979872] = val_5.y;
        this.oldDrag = val_70;
        float val_67 = (float)UnityEngine.Screen.height;
        val_67 = val_67 * 0.75f;
        val_5.x = val_67 / val_5.x;
        val_75 = this.currentLog.Count;
        val_76 = UnityEngine.Mathf.Min(a:  (int)val_5.x, b:  val_75 - this.startIndex);
        val_5.x = val_5.x * (float)this.startIndex;
        if((int)val_5.x >= (1.401298E-45f))
        {
                UnityEngine.GUILayoutOption[] val_10 = new UnityEngine.GUILayoutOption[1];
            val_10[0] = UnityEngine.GUILayout.Height(height:  (float)(int)val_5.x);
            UnityEngine.GUILayout.BeginHorizontal(options:  val_10);
            UnityEngine.GUILayout.Label(text:  "---", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.EndHorizontal();
        }
        
        int val_14 = UnityEngine.Mathf.Clamp(value:  this.startIndex + val_76, min:  0, max:  val_75);
        val_77 = this.startIndex;
        if(val_77 >= val_14)
        {
            goto label_15;
        }
        
        val_78 = 0;
        label_84:
        if(val_77 >= this.currentLog.Count)
        {
            goto label_28;
        }
        
        Log val_16 = this.currentLog.Item[val_77];
        if(val_16.logType != 3)
        {
            goto label_23;
        }
        
        if(this.showLog == true)
        {
            goto label_24;
        }
        
        goto label_27;
        label_23:
        if(val_16.logType > 4)
        {
            goto label_26;
        }
        
        var val_68 = 40824740 + (val_16.logType) << 2;
        val_68 = val_68 + 40824740;
        goto (40824740 + (val_16.logType) << 2 + 40824740);
        label_24:
        label_26:
        if(val_78 >= val_76)
        {
            goto label_28;
        }
        
        var val_17 = (0 != 0) ? this.warningContent : this.errorContent;
        UnityEngine.GUIContent val_18 = (val_16.logType == 3) ? this.logContent : (val_17);
        UnityEngine.GUIStyle val_21 = (this.selectedLog == val_16) ? this.selectedLogStyle : ((((this.startIndex + val_78) & 1) != 0) ? this.evenLogStyle : this.oddLogStyle);
        this.tempContent.text = val_16.count.ToString();
        if(this.collapse != false)
        {
                UnityEngine.Vector2 val_23 = this.barStyle.CalcSize(content:  this.tempContent);
            val_70 = val_23.x + 3f;
        }
        else
        {
                val_70 = 0f;
        }
        
        float val_69 = (float)UnityEngine.Screen.width;
        val_69 = val_69 - val_70;
        this.countRect.x = val_69;
        val_69 = val_69 * (float)val_77;
        if((int)val_5.x >= (1.401298E-45f))
        {
                val_69 = val_69 + 8f;
        }
        
        if(val_75 > val_76)
        {
                float val_25 = this.countRect.x;
            UnityEngine.Vector2 val_70 = this.size;
            val_70 = val_70 * (-2f);
            val_25 = val_25 + val_70;
            this.countRect.x = val_25;
        }
        
        Sample val_26 = this.samples.Item[val_16.sampleId];
        this.fpsRect = this.countRect;
        mem[1152921529113980040] = this.selectedLogStyle;
        mem[1152921529113980044] = this.selectedLog;
        mem[1152921529113980048] = val_17;
        if(this.showFps != false)
        {
                this.tempContent.text = val_26.fpsText;
            UnityEngine.Vector2 val_27 = val_21.CalcSize(content:  this.tempContent);
            val_70 = val_27.x + this.size;
            float val_28 = this.fpsRect.x;
            val_28 = val_28 - val_70;
            this.fpsRect.x = val_28;
            mem2[0] = this.fpsRect.m_XMin;
            float val_29 = this.fpsLabelRect.x;
            val_29 = val_29 + this.size;
            this.fpsLabelRect.x = val_29;
            UnityEngine.Vector2 val_71 = this.size;
            val_71 = val_70 - val_71;
        }
        
        this.memoryRect = this.fpsRect;
        mem[1152921529113980008] = this.selectedLogStyle;
        mem[1152921529113980012] = this.selectedLog;
        mem[1152921529113980016] = val_17;
        if(this.showMemory != false)
        {
                this.tempContent.text = val_26 + 24.ToString(format:  "0.000");
            UnityEngine.Vector2 val_32 = val_21.CalcSize(content:  this.tempContent);
            val_70 = val_32.x + this.size;
            float val_33 = this.memoryRect.x;
            val_33 = val_33 - val_70;
            this.memoryRect.x = val_33;
            mem2[0] = this.memoryRect.m_XMin;
            float val_34 = this.memoryLabelRect.x;
            val_34 = val_34 + this.size;
            this.memoryLabelRect.x = val_34;
            UnityEngine.Vector2 val_72 = this.size;
            val_72 = val_70 - val_72;
        }
        
        this.sceneRect = this.memoryRect;
        mem[1152921529113979976] = this.selectedLogStyle;
        mem[1152921529113979980] = this.selectedLog;
        mem[1152921529113979984] = val_17;
        if(this.showScene != false)
        {
                this.tempContent.text = val_26.GetSceneName();
            UnityEngine.Vector2 val_36 = val_21.CalcSize(content:  this.tempContent);
            val_70 = val_36.x + this.size;
            float val_37 = this.sceneRect.x;
            val_37 = val_37 - val_70;
            this.sceneRect.x = val_37;
            mem2[0] = this.sceneRect.m_XMin;
            float val_38 = this.sceneLabelRect.x;
            val_38 = val_38 + this.size;
            this.sceneLabelRect.x = val_38;
            UnityEngine.Vector2 val_73 = this.size;
            val_73 = val_70 - val_73;
        }
        
        this.timeRect = this.sceneRect;
        mem[1152921529113979944] = this.selectedLogStyle;
        mem[1152921529113979948] = this.selectedLog;
        mem[1152921529113979952] = val_17;
        if(this.showTime != false)
        {
                this.tempContent.text = val_26 + 16.ToString(format:  "0.000");
            UnityEngine.Vector2 val_41 = val_21.CalcSize(content:  this.tempContent);
            val_70 = val_41.x + this.size;
            float val_42 = this.timeRect.x;
            val_42 = val_42 - val_70;
            this.timeRect.x = val_42;
            mem2[0] = this.timeRect.m_XMin;
            float val_43 = this.timeLabelRect.x;
            val_43 = val_43 + this.size;
            this.timeLabelRect.x = val_43;
            UnityEngine.Vector2 val_74 = this.size;
            val_74 = val_70 - val_74;
        }
        
        UnityEngine.GUILayout.BeginHorizontal(style:  val_21, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayoutOption[] val_45 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.GUILayoutOption val_46 = UnityEngine.GUILayout.Width(width:  this.size);
        if(val_45 == null)
        {
            goto label_52;
        }
        
        if(val_46 != null)
        {
            goto label_53;
        }
        
        goto label_56;
        label_52:
        if(val_46 == null)
        {
            goto label_56;
        }
        
        label_53:
        label_56:
        val_45[0] = val_46;
        val_45[1] = UnityEngine.GUILayout.Height(height:  this.size);
        if(this.selectedLog != val_16)
        {
                val_72 = val_72;
            if((UnityEngine.GUILayout.Button(content:  val_18, style:  this.nonStyle, options:  val_45)) != false)
        {
                this.selectedLog = val_16;
        }
        
            val_75 = val_75;
            if((UnityEngine.GUILayout.Button(text:  val_16.condition, style:  this.logButtonStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
        {
                this.selectedLog = val_16;
        }
        
            val_79 = 1152921504869679104;
        }
        else
        {
                UnityEngine.GUILayout.Box(content:  val_18, style:  this.nonStyle, options:  val_45);
            val_72 = val_72;
            UnityEngine.GUILayout.Label(text:  val_16.condition, style:  this.selectedLogFontStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            val_79 = 1152921504869679104;
            val_75 = val_75;
        }
        
        val_80 = val_77;
        if(this.showTime != false)
        {
                UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = this.timeRect, m_YMin = V11.16B, m_Width = V10.16B, m_Height = this.scrollPosition}, content:  this.showTimeContent, style:  val_21);
            val_70 = this.timeLabelRect;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_70, m_YMin = this.scrollPosition, m_Width = V10.16B, m_Height = V11.16B}, text:  val_26 + 16.ToString(format:  "0.000"), style:  val_21);
        }
        
        if(this.showScene != false)
        {
                UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = this.sceneRect, m_YMin = V11.16B, m_Width = V10.16B, m_Height = this.scrollPosition}, content:  this.showSceneContent, style:  val_21);
            val_70 = this.sceneLabelRect;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_70, m_YMin = this.scrollPosition, m_Width = V10.16B, m_Height = V11.16B}, text:  val_26.GetSceneName(), style:  val_21);
        }
        
        if(this.showMemory != false)
        {
                UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = this.memoryRect, m_YMin = V11.16B, m_Width = V10.16B, m_Height = this.scrollPosition}, content:  this.showMemoryContent, style:  val_21);
            val_70 = this.memoryLabelRect;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_70, m_YMin = this.scrollPosition, m_Width = V10.16B, m_Height = V11.16B}, text:  val_26 + 24.ToString(format:  "0.000")(val_26 + 24.ToString(format:  "0.000")) + " mb", style:  val_21);
        }
        
        if(this.showFps != false)
        {
                UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = this.fpsRect, m_YMin = V11.16B, m_Width = V10.16B, m_Height = this.scrollPosition}, content:  this.showFpsContent, style:  val_21);
            val_70 = this.fpsLabelRect;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_70, m_YMin = this.scrollPosition, m_Width = V10.16B, m_Height = V11.16B}, text:  val_26 + 32, style:  val_21);
        }
        
        val_76 = val_76;
        if(this.collapse != false)
        {
                val_70 = this.countRect;
            float val_76 = val_70;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_76, m_YMin = this.scrollPosition, m_Width = V10.16B, m_Height = V11.16B}, text:  val_16.count.ToString(), style:  this.barStyle);
        }
        
        UnityEngine.GUILayout.EndHorizontal();
        val_78 = 1;
        label_27:
        int val_75 = this.startIndex;
        val_80 = val_80 + 1;
        val_75 = val_75 + val_78;
        if(val_75 < val_14)
        {
            goto label_84;
        }
        
        label_28:
        val_81 = this.startIndex;
        label_15:
        int val_59 = val_75 - val_76;
        val_59 = val_59 - val_81;
        val_76 = val_76 * (float)val_59;
        val_82 = (int)val_76;
        if(val_82 >= (1.401298E-45f))
        {
                UnityEngine.GUILayoutOption[] val_60 = new UnityEngine.GUILayoutOption[1];
            val_82 = UnityEngine.GUILayout.Height(height:  (float)val_82);
            val_60[0] = val_82;
            UnityEngine.GUILayout.BeginHorizontal(options:  val_60);
            UnityEngine.GUILayout.Label(text:  " ", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.EndHorizontal();
        }
        
        UnityEngine.GUILayout.EndScrollView();
        UnityEngine.GUILayout.EndArea();
        float val_77 = 0f;
        this.buttomRect.x = val_77;
        val_77 = (float)UnityEngine.Screen.height - val_77;
        int val_64 = UnityEngine.Screen.width;
        if(this.showGraph != false)
        {
                this.drawGraph();
            return;
        }
        
        this.drawStack();
    }
    private void drawGraph()
    {
        float val_67;
        float val_68;
        float val_69;
        float val_70;
        var val_71;
        this.graphRect = this.stackRect;
        mem[1152921529115238856] = ???;
        mem[1152921529115238864] = ???;
        float val_65 = (float)UnityEngine.Screen.height;
        val_65 = val_65 * 0.25f;
        UnityEngine.GUI.skin = this.graphScrollerSkin;
        UnityEngine.Vector2 val_2 = this.getDrag();
        float val_66 = (float)UnityEngine.Screen.height;
        val_66 = val_66 - val_2.x;
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  this.downPos, y:  val_66);
        val_67 = val_4.x;
        val_68 = val_4.y;
        if((this.graphRect & 1) != 0)
        {
                if(val_2.x != 0f)
        {
                float val_67 = this.oldDrag3;
            val_67 = val_2.x - val_67;
            float val_5 = this.graphScrollerPos - val_67;
            this.graphScrollerPos = val_5;
            val_67 = 0f;
            val_68 = val_5;
            this.graphScrollerPos = UnityEngine.Mathf.Max(a:  val_67, b:  val_68);
        }
        
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = this.downPos, y = V10.16B}, rhs:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y})) != false)
        {
                float val_68 = this.graphSize;
            int val_69 = this.startFrame;
            val_68 = this.downPos / val_68;
            val_69 = val_69 + (int)val_68;
            this.currentFrame = val_69;
        }
        
        }
        
        this.oldDrag3 = val_2.x;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.graphRect, m_YMin = V10.16B, m_Width = val_7.x, m_Height = val_7.y}, style:  this.backStyle);
        UnityEngine.Vector2 val_10 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = this.graphScrollerPos, y = this.downPos}, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        float val_70 = this.graphSize;
        this.graphScrollerPos = val_10;
        mem[1152921529115239224] = val_10.y;
        val_70 = val_10.x / val_70;
        this.startFrame = (int)val_70;
        float val_71 = (float)this.samples.Count;
        val_71 = this.graphSize * val_71;
        val_71 = val_71 - (float)UnityEngine.Screen.width;
        if(val_10.x >= val_71)
        {
                UnityEngine.Vector2 val_72 = this.graphScrollerPos;
            val_72 = val_72 + this.graphSize;
            this.graphScrollerPos = val_72;
        }
        
        UnityEngine.GUILayoutOption[] val_13 = new UnityEngine.GUILayoutOption[1];
        float val_73 = this.graphSize;
        val_73 = val_73 * (float)this.samples.Count;
        val_13[0] = UnityEngine.GUILayout.Width(width:  val_73);
        UnityEngine.GUILayout.Label(text:  " ", options:  val_13);
        UnityEngine.GUILayout.EndScrollView();
        UnityEngine.GUILayout.EndArea();
        mem2[0] = ;
        float val_74 = this.graphSize;
        val_74 = (float)UnityEngine.Screen.width / val_74;
        if(val_74 <= 0f)
        {
            goto label_19;
        }
        
        var val_76 = 1;
        label_26:
        int val_75 = this.startFrame;
        val_75 = val_76 + val_75;
        int val_17 = val_75 - 1;
        if(val_17 >= this.samples.Count)
        {
            goto label_19;
        }
        
        Sample val_19 = this.samples.Item[val_17];
        val_69 = val_19.fps;
        if(this.maxFpsValue < 0)
        {
                mem2[0] = val_69;
            val_69 = val_19.fps;
        }
        
        if(this.minFpsValue > val_69)
        {
                mem2[0] = val_69;
        }
        
        val_70 = val_19.memory;
        if(this.maxMemoryValue < 0)
        {
                mem2[0] = val_70;
            val_70 = val_19.memory;
        }
        
        if(this.minMemoryValue > val_70)
        {
                mem2[0] = val_70;
        }
        
        float val_77 = this.graphSize;
        val_76 = val_76 + 1;
        val_77 = (float)UnityEngine.Screen.width / val_77;
        if(val_77 > 1f)
        {
            goto label_26;
        }
        
        label_19:
        val_71 = 1152921525908610224;
        if(this.currentFrame != 1)
        {
                if(this.currentFrame < this.samples.Count)
        {
                UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.buttomRect, m_YMin = 1f, m_Width = (float)UnityEngine.Screen.width, m_Height = val_7.y}, style:  this.backStyle);
            UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayoutOption[] val_24 = new UnityEngine.GUILayoutOption[2];
            val_24[0] = UnityEngine.GUILayout.Width(width:  this.size);
            val_24[1] = UnityEngine.GUILayout.Height(height:  this.size);
            UnityEngine.GUILayout.Box(content:  this.showTimeContent, style:  this.nonStyle, options:  val_24);
            UnityEngine.GUILayout.Label(text:  val_22.time.ToString(format:  "0.0"), style:  this.nonStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.Space(pixels:  this.size);
            UnityEngine.GUILayoutOption[] val_29 = new UnityEngine.GUILayoutOption[2];
            val_29[0] = UnityEngine.GUILayout.Width(width:  this.size);
            val_29[1] = UnityEngine.GUILayout.Height(height:  this.size);
            UnityEngine.GUILayout.Box(content:  this.showSceneContent, style:  this.nonStyle, options:  val_29);
            UnityEngine.GUILayout.Label(text:  this.samples.Item[this.currentFrame].GetSceneName(), style:  this.nonStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.Space(pixels:  this.size);
            UnityEngine.GUILayoutOption[] val_34 = new UnityEngine.GUILayoutOption[2];
            val_34[0] = UnityEngine.GUILayout.Width(width:  this.size);
            val_34[1] = UnityEngine.GUILayout.Height(height:  this.size);
            UnityEngine.GUILayout.Box(content:  this.showMemoryContent, style:  this.nonStyle, options:  val_34);
            UnityEngine.GUILayout.Label(text:  val_22.memory.ToString(format:  "0.000"), style:  this.nonStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.Space(pixels:  this.size);
            UnityEngine.GUILayoutOption[] val_39 = new UnityEngine.GUILayoutOption[2];
            val_39[0] = UnityEngine.GUILayout.Width(width:  this.size);
            val_39[1] = UnityEngine.GUILayout.Height(height:  this.size);
            UnityEngine.GUILayout.Box(content:  this.showFpsContent, style:  this.nonStyle, options:  val_39);
            val_71 = 1152921525908610224;
            UnityEngine.GUILayout.Label(text:  val_22.fpsText, style:  this.nonStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.Space(pixels:  this.size);
            UnityEngine.GUILayout.FlexibleSpace();
            UnityEngine.GUILayout.EndHorizontal();
            UnityEngine.GUILayout.EndArea();
        }
        
        }
        
        this.graphMaxRect = this.stackRect;
        mem[1152921529115238888] = (int)val_68;
        mem[1152921529115238896] = ???;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.graphMaxRect, m_YMin = 1f, m_Width = (float)UnityEngine.Screen.width, m_Height = val_7.y});
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayoutOption[] val_44 = new UnityEngine.GUILayoutOption[2];
        val_44[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_44[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.showMemoryContent, style:  this.nonStyle, options:  val_44);
        UnityEngine.GUILayout.Label(text:  this.maxMemoryValue.ToString(format:  "0.000"), style:  this.nonStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayoutOption[] val_49 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_78 = this.size;
        val_49[0] = UnityEngine.GUILayout.Width(width:  val_78);
        val_49[1] = UnityEngine.GUILayout.Height(height:  val_78);
        UnityEngine.GUILayout.Box(content:  this.showFpsContent, style:  this.nonStyle, options:  val_49);
        UnityEngine.GUILayout.Label(text:  this.maxFpsValue.ToString(format:  "0.000"), style:  this.nonStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.EndArea();
        this.graphMinRect = this.stackRect;
        mem[1152921529115238872] = (int)val_68;
        mem[1152921529115238880] = ???;
        val_78 = val_78 + val_78;
        val_78 = val_78 - 1f;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.graphMinRect, m_YMin = 1f, m_Width = (float)UnityEngine.Screen.width, m_Height = val_7.y});
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayoutOption[] val_55 = new UnityEngine.GUILayoutOption[2];
        val_55[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_55[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.showMemoryContent, style:  this.nonStyle, options:  val_55);
        UnityEngine.GUILayout.Label(text:  this.minMemoryValue.ToString(format:  "0.000"), style:  this.nonStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayoutOption[] val_60 = new UnityEngine.GUILayoutOption[2];
        val_60[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_60[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.showFpsContent, style:  this.nonStyle, options:  val_60);
        UnityEngine.GUILayout.Label(text:  this.minFpsValue.ToString(format:  "0.000"), style:  this.nonStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.EndArea();
    }
    private void drawStack()
    {
        if(this.selectedLog != null)
        {
                UnityEngine.Vector2 val_1 = this.getDrag();
            if(val_1.y != 0f)
        {
                float val_31 = (float)UnityEngine.Screen.height;
            val_31 = val_31 - val_1.x;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  this.downPos, y:  val_31);
            if((this.stackRect & 1) != 0)
        {
                float val_32 = this.oldDrag2;
            val_32 = val_1.y - val_32;
            val_32 = val_3.y + val_32;
            mem[1152921529116616824] = val_32;
        }
        
        }
        
            this.oldDrag2 = val_1.y;
            UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.stackRect, m_YMin = val_3.y}, style:  this.backStyle);
            UnityEngine.Vector2 val_5 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = this.scrollPosition2, y = this.downPos}, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            this.scrollPosition2 = val_5;
            mem[1152921529116616824] = val_5.y;
            UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.Label(text:  this.selectedLog.condition, style:  this.stackLabelStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.EndHorizontal();
            val_5.x = val_5.x * 0.25f;
            UnityEngine.GUILayout.Space(pixels:  val_5.x);
            UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.Label(text:  this.selectedLog.stacktrace, style:  this.stackLabelStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.EndHorizontal();
            UnityEngine.GUILayout.Space(pixels:  val_5.x);
            UnityEngine.GUILayout.EndScrollView();
            UnityEngine.GUILayout.EndArea();
            UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.buttomRect, m_YMin = 0.25f}, style:  this.backStyle);
            UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayoutOption[] val_12 = new UnityEngine.GUILayoutOption[2];
            val_12[0] = UnityEngine.GUILayout.Width(width:  this.size);
            val_12[1] = UnityEngine.GUILayout.Height(height:  this.size);
            UnityEngine.GUILayout.Box(content:  this.showTimeContent, style:  this.nonStyle, options:  val_12);
            UnityEngine.GUILayout.Label(text:  val_6.time.ToString(format:  "0.000"), style:  this.nonStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.Space(pixels:  this.size);
            UnityEngine.GUILayoutOption[] val_17 = new UnityEngine.GUILayoutOption[2];
            val_17[0] = UnityEngine.GUILayout.Width(width:  this.size);
            val_17[1] = UnityEngine.GUILayout.Height(height:  this.size);
            UnityEngine.GUILayout.Box(content:  this.showSceneContent, style:  this.nonStyle, options:  val_17);
            UnityEngine.GUILayout.Label(text:  this.samples.Item[this.selectedLog.sampleId].GetSceneName(), style:  this.nonStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.Space(pixels:  this.size);
            UnityEngine.GUILayoutOption[] val_22 = new UnityEngine.GUILayoutOption[2];
            val_22[0] = UnityEngine.GUILayout.Width(width:  this.size);
            val_22[1] = UnityEngine.GUILayout.Height(height:  this.size);
            UnityEngine.GUILayout.Box(content:  this.showMemoryContent, style:  this.nonStyle, options:  val_22);
            UnityEngine.GUILayout.Label(text:  val_6.memory.ToString(format:  "0.000"), style:  this.nonStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.Space(pixels:  this.size);
            UnityEngine.GUILayoutOption[] val_27 = new UnityEngine.GUILayoutOption[2];
            val_27[0] = UnityEngine.GUILayout.Width(width:  this.size);
            val_27[1] = UnityEngine.GUILayout.Height(height:  this.size);
            UnityEngine.GUILayout.Box(content:  this.showFpsContent, style:  this.nonStyle, options:  val_27);
            UnityEngine.GUILayout.Label(text:  val_6.fpsText, style:  this.nonStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.FlexibleSpace();
            UnityEngine.GUILayout.EndHorizontal();
            UnityEngine.GUILayout.EndArea();
            return;
        }
        
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.stackRect}, style:  this.backStyle);
        UnityEngine.GUILayout.EndArea();
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.buttomRect}, style:  this.backStyle);
        UnityEngine.GUILayout.EndArea();
    }
    public void OnGUIDraw()
    {
        if(this.show == false)
        {
                return;
        }
        
        this.screenRect.x = 0f;
        int val_1 = UnityEngine.Screen.width;
        int val_2 = UnityEngine.Screen.height;
        UnityEngine.Vector2 val_3 = this.getDownPos();
        float val_12 = 0f;
        this.logsRect.x = val_12;
        val_12 = val_12 + val_12;
        float val_14 = (float)UnityEngine.Screen.width;
        float val_13 = (float)UnityEngine.Screen.height;
        val_13 = val_13 * 0.75f;
        val_14 = val_14 + val_14;
        val_14 = val_13 - val_14;
        this.stackRectTopLeft = 0;
        this.stackRect.x = 0f;
        float val_15 = (float)UnityEngine.Screen.height;
        val_15 = val_15 * 0.75f;
        mem[1152921529117273624] = val_15;
        float val_16 = (float)UnityEngine.Screen.height;
        val_16 = val_16 * 0.75f;
        float val_18 = (float)UnityEngine.Screen.width;
        float val_17 = (float)UnityEngine.Screen.height;
        val_17 = val_17 * 0.25f;
        val_18 = val_17 - val_18;
        float val_19 = 0f;
        this.detailRect.x = val_19;
        val_19 = val_19 * 3f;
        val_19 = (float)UnityEngine.Screen.height - val_19;
        float val_20 = (float)UnityEngine.Screen.width;
        val_20 = val_20 * 3f;
        if(this.currentView != 1)
        {
                if(this.currentView != 2)
        {
                return;
        }
        
            this.DrawInfo();
            return;
        }
        
        this.drawToolBar();
        this.DrawLogs();
    }
    private bool isGestureDone()
    {
        float val_45;
        var val_46;
        var val_47;
        var val_50;
        var val_51;
        if(UnityEngine.Application.platform != 11)
        {
                if(UnityEngine.Application.platform != 8)
        {
            goto label_2;
        }
        
        }
        
        UnityEngine.Touch[] val_3 = UnityEngine.Input.touches;
        if(val_3.Length != 1)
        {
            goto label_4;
        }
        
        if(UnityEngine.Input.touches[32].Seconds == 4)
        {
            goto label_7;
        }
        
        if(UnityEngine.Input.touches[32].Seconds != 3)
        {
            goto label_10;
        }
        
        label_7:
        this.gestureDetector.Clear();
        goto label_55;
        label_2:
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
        {
            goto label_13;
        }
        
        label_4:
        this.gestureDetector.Clear();
        this.gestureCount = 0;
        label_55:
        if(this.gestureDetector.Count < 10)
        {
            goto label_28;
        }
        
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.zero;
        this.gestureSum = val_10;
        mem[1152921529117644012] = val_10.y;
        this.gestureLength = 0f;
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.zero;
        val_45 = val_11.x;
        val_46 = 0;
        goto label_19;
        label_26:
        int val_45 = 1;
        UnityEngine.Vector2 val_12 = this.gestureDetector.Item[1];
        val_45 = val_45 - 1;
        UnityEngine.Vector2 val_13 = this.gestureDetector.Item[val_45];
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, b:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
        UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = this.gestureSum, y = val_14.y}, b:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
        this.gestureSum = val_15;
        mem[1152921529117644012] = val_15.y;
        this.gestureLength = val_14.x + this.gestureLength;
        if((UnityEngine.Vector2.Dot(lhs:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y}, rhs:  new UnityEngine.Vector2() {x = val_45, y = val_11.y})) < 0)
        {
            goto label_24;
        }
        
        val_45 = val_14.x;
        val_46 = val_45 + 1;
        label_19:
        if(val_46 < (this.gestureDetector.Count - 2))
        {
            goto label_26;
        }
        
        var val_46 = UnityEngine.Screen.width;
        val_46 = UnityEngine.Screen.height + val_46;
        var val_23 = (val_46 < 0) ? (val_46 + 3) : (val_46);
        val_23 = val_23 >> 2;
        if(this.gestureLength > (float)val_23)
        {
                var val_25 = (val_46 < 0) ? (val_46 + 7) : (val_46);
            val_25 = val_25 >> 3;
            if(this.gestureLength < 0)
        {
                this.gestureDetector.Clear();
            int val_47 = this.gestureCount;
            val_47 = val_47 + 1;
            this.gestureCount = val_47;
            if(val_47 >= this.numOfCircleToShow)
        {
                return (bool)val_47;
        }
        
        }
        
        }
        
        label_28:
        val_47 = 0;
        return (bool)val_47;
        label_24:
        this.gestureDetector.Clear();
        val_47 = 0;
        this.gestureCount = 0;
        return (bool)val_47;
        label_13:
        if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
        {
            goto label_55;
        }
        
        UnityEngine.Vector3 val_27 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_28 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector2 val_29 = new UnityEngine.Vector2(x:  val_27.x, y:  val_28.y);
        if(this.gestureDetector.Count == 0)
        {
            goto label_35;
        }
        
        if(this.gestureDetector == null)
        {
            goto label_36;
        }
        
        val_50 = this.gestureDetector.Count;
        goto label_37;
        label_10:
        if(UnityEngine.Input.touches[32].Seconds != 1)
        {
            goto label_55;
        }
        
        if(this.gestureDetector.Count == 0)
        {
            goto label_44;
        }
        
        if(this.gestureDetector == null)
        {
            goto label_45;
        }
        
        val_51 = this.gestureDetector.Count;
        goto label_46;
        label_36:
        val_50 = 0.Count;
        label_37:
        UnityEngine.Vector2 val_39 = this.gestureDetector.Item[val_50 - 1];
        UnityEngine.Vector2 val_40 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y}, b:  new UnityEngine.Vector2() {x = val_39.x, y = val_39.y});
        if(val_40.x <= 10f)
        {
            goto label_55;
        }
        
        label_35:
        if(this.gestureDetector != null)
        {
            goto label_56;
        }
        
        label_57:
        label_56:
        this.gestureDetector.Add(item:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y});
        goto label_55;
        label_45:
        val_51 = 0.Count;
        label_46:
        UnityEngine.Vector2 val_43 = this.gestureDetector.Item[val_51 - 1];
        UnityEngine.Vector2 val_44 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B}, b:  new UnityEngine.Vector2() {x = val_43.x, y = val_43.y});
        if(val_44.x <= 10f)
        {
            goto label_55;
        }
        
        label_44:
        if(this.gestureDetector != null)
        {
            goto label_56;
        }
        
        goto label_57;
    }
    private bool isDoubleClickDone()
    {
        var val_9;
        if(UnityEngine.Application.platform != 11)
        {
                if(UnityEngine.Application.platform != 8)
        {
            goto label_1;
        }
        
        }
        
        UnityEngine.Touch[] val_3 = UnityEngine.Input.touches;
        if(val_3.Length != 1)
        {
            goto label_3;
        }
        
        if(UnityEngine.Input.touches[32].Seconds == 0)
        {
            goto label_6;
        }
        
        val_9 = 0;
        return (bool)val_9;
        label_3:
        val_9 = 0;
        this.lastClickTime = -1f;
        return (bool)val_9;
        label_1:
        val_9 = 0;
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
                return (bool)val_9;
        }
        
        label_6:
        float val_7 = UnityEngine.Time.realtimeSinceStartup;
        if(this.lastClickTime != (-1f))
        {
                val_7 = val_7 - this.lastClickTime;
            if(val_7 < 0)
        {
                this.lastClickTime = -1f;
            val_9 = 1;
            return (bool)val_9;
        }
        
        }
        
        val_9 = 0;
        this.lastClickTime = UnityEngine.Time.realtimeSinceStartup;
        return (bool)val_9;
    }
    private UnityEngine.Vector2 getDownPos()
    {
        if(UnityEngine.Application.platform != 11)
        {
                if(UnityEngine.Application.platform != 8)
        {
            goto label_2;
        }
        
        }
        
        UnityEngine.Touch[] val_3 = UnityEngine.Input.touches;
        if(val_3.Length != 1)
        {
            goto label_11;
        }
        
        if(UnityEngine.Input.touches[32].Seconds != 0)
        {
            goto label_11;
        }
        
        this.downPos = new UnityEngine.Vector2();
        mem[1152921529118400520] = ???;
        return new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
        label_2:
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
        {
                UnityEngine.Vector3 val_8 = UnityEngine.Input.mousePosition;
            this.downPos = val_8.x;
            UnityEngine.Vector3 val_9 = UnityEngine.Input.mousePosition;
            mem[1152921529118400520] = val_9.y;
            return new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
        }
        
        label_11:
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.zero;
        return new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
    }
    private UnityEngine.Vector2 getDrag()
    {
        UnityEngine.Vector2 val_8;
        float val_9;
        if(UnityEngine.Application.platform != 11)
        {
                if(UnityEngine.Application.platform != 8)
        {
            goto label_2;
        }
        
        }
        
        UnityEngine.Touch[] val_3 = UnityEngine.Input.touches;
        if(val_3.Length != 1)
        {
                return UnityEngine.Vector2.zero;
        }
        
        val_8 = this.downPos;
        val_9 = V0.16B;
        return UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, b:  new UnityEngine.Vector2() {x = this.downPos});
        label_2:
        if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
        {
                return UnityEngine.Vector2.zero;
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Input.mousePosition;
        val_9 = val_6.x;
        val_8 = val_6.z;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9, y = val_6.y, z = val_8});
        this.mousePosition = val_7;
        mem[1152921529118713232] = val_7.y;
        return UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, b:  new UnityEngine.Vector2() {x = this.downPos});
    }
    private void calculateStartIndex()
    {
        this.startIndex = (int)S0 / S1;
        this.startIndex = UnityEngine.Mathf.Clamp(value:  (int)S0 / S1, min:  0, max:  this.currentLog.Count);
    }
    private void doShow()
    {
        this.show = true;
        this.currentView = true;
        ReporterGUI val_2 = this.gameObject.AddComponent<ReporterGUI>();
        this.gameObject.SendMessage(methodName:  "OnShowReporter");
    }
    private void Update()
    {
        var val_19;
        var val_20;
        System.String[] val_21;
        var val_22;
        var val_23;
        string val_24;
        this.fpsText = this.fps.ToString(format:  "0.000");
        float val_20 = 0.0009765625f;
        float val_19 = (float)System.GC.GetTotalMemory(forceFullCollection:  false);
        val_19 = val_19 * val_20;
        val_20 = val_19 * val_20;
        this.gcTotalMemory = val_20;
        val_19 = 1152921504864088064;
        UnityEngine.SceneManagement.Scene val_3 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if(val_3.m_Handle.buildIndex != 1)
        {
                val_20 = null;
            val_20 = null;
            val_21 = Reporter.scenes;
            System.String[] val_5 = val_21 + (((long)(int)(val_4)) << 3);
            if((System.String.IsNullOrEmpty(value:  (Reporter.scenes + ((long)(int)(val_4)) << 3) + 32)) != false)
        {
                val_22 = null;
            val_22 = null;
            UnityEngine.SceneManagement.Scene val_7 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            UnityEngine.SceneManagement.Scene val_9 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            val_19 = (long)val_7.m_Handle.buildIndex;
            System.String[] val_11 = Reporter.scenes + (((long)(int)(val_8)) << 3);
            (Reporter.scenes + ((long)(int)(val_8)) << 3).__unknownFiledOffset_20 = val_9.m_Handle.name;
        }
        
        }
        
        this.calculateStartIndex();
        if(this.show != true)
        {
                if(this.isGestureDone() != false)
        {
                this.doShow();
        }
        
        }
        
        if(this.threadedLogs.Count < 1)
        {
            goto label_40;
        }
        
        bool val_14 = false;
        System.Threading.Monitor.Enter(obj:  this.threadedLogs, lockTaken: ref  val_14);
        val_23 = 0;
        goto label_23;
        label_28:
        if(Reporter.scenes.Item[0] != null)
        {
                val_21 = val_15.condition;
            val_24 = val_15.stacktrace;
        }
        else
        {
                val_21 = 10260432;
            val_24 = 64;
        }
        
        this.AddLog(condition:  val_21, stacktrace:  val_24, type:  val_15.logType);
        val_23 = 1;
        label_23:
        if(val_23 < this.threadedLogs.Count)
        {
            goto label_28;
        }
        
        this.threadedLogs.Clear();
        val_19 = 0;
        if(val_14 != 0)
        {
                System.Threading.Monitor.Exit(obj:  this.threadedLogs);
        }
        
        label_40:
        if(this.firstTime == false)
        {
            goto label_41;
        }
        
        this.firstTime = false;
        label_45:
        this.lastUpdate = UnityEngine.Time.realtimeSinceStartup;
        this.frames = 0;
        return;
        label_41:
        int val_21 = this.frames;
        val_21 = val_21 + 1;
        this.frames = val_21;
        float val_18 = UnityEngine.Time.realtimeSinceStartup;
        val_18 = val_18 - this.lastUpdate;
        if(val_18 <= 0.25f)
        {
                return;
        }
        
        if(this.frames < 11)
        {
                return;
        }
        
        val_18 = (float)this.frames / val_18;
        this.fps = val_18;
        goto label_45;
    }
    private void CaptureLog(string condition, string stacktrace, UnityEngine.LogType type)
    {
        this.AddLog(condition:  condition, stacktrace:  stacktrace, type:  type);
    }
    private void AddLog(string condition, string stacktrace, UnityEngine.LogType type)
    {
        Reporter._LogType val_30;
        string val_31;
        float val_32;
        var val_33;
        float val_34;
        string val_35;
        var val_36;
        var val_37;
        var val_38;
        object val_39;
        var val_40;
        int val_41;
        var val_42;
        val_30 = type;
        val_31 = condition;
        bool val_1 = this.cachedString.ContainsKey(key:  val_31);
        if(this.cachedString == null)
        {
            goto label_2;
        }
        
        if(val_1 == false)
        {
            goto label_3;
        }
        
        label_5:
        val_31 = this.cachedString.Item[val_31];
        val_32 = 0f;
        goto label_4;
        label_2:
        if(val_1 == true)
        {
            goto label_5;
        }
        
        label_3:
        this.cachedString.Add(key:  val_31, value:  val_31);
        if((System.String.IsNullOrEmpty(value:  val_31)) != false)
        {
                val_33 = 0;
        }
        else
        {
                val_33 = val_31.Length << 1;
        }
        
        val_34 = (float)System.IntPtr.Size;
        val_32 = (float)val_33 + val_34;
        label_4:
        bool val_6 = this.cachedString.ContainsKey(key:  stacktrace);
        if(this.cachedString == null)
        {
            goto label_10;
        }
        
        if(val_6 == false)
        {
            goto label_11;
        }
        
        label_13:
        val_35 = this.cachedString.Item[stacktrace];
        goto label_12;
        label_10:
        if(val_6 == true)
        {
            goto label_13;
        }
        
        label_11:
        this.cachedString.Add(key:  stacktrace, value:  stacktrace);
        if((System.String.IsNullOrEmpty(value:  stacktrace)) != false)
        {
                val_36 = 0;
        }
        else
        {
                val_36 = stacktrace.Length << 1;
        }
        
        val_32 = val_32 + (float)val_36;
        val_34 = (float)System.IntPtr.Size;
        val_32 = val_32 + val_34;
        val_35 = stacktrace;
        label_12:
        this.addSample();
        Reporter.Log val_11 = new Reporter.Log();
        if(val_11 != null)
        {
                val_37 = val_11;
            .logType = val_30;
            val_38 = 1152921529119680356;
            mem[1152921529119680360] = val_31;
        }
        else
        {
                val_37 = val_11;
            .logType = val_30;
            val_38 = 24;
            mem[24] = val_31;
        }
        
        .stacktrace = val_35;
        .sampleId = this.samples.Count - 1;
        float val_14 = val_11.GetMemoryUsage();
        float val_28 = 0.0009765625f;
        val_14 = val_32 + val_14;
        val_14 = val_14 * val_28;
        val_14 = val_14 * val_28;
        val_14 = this.logsMemUsage + val_14;
        val_28 = this.graphMemUsage + val_14;
        this.logsMemUsage = val_14;
        if(val_28 > this.maxSize)
        {
                this.clear();
            val_39 = "Memory Usage Reach" + this.maxSize + " mb So It is Cleared";
            UnityEngine.Debug.Log(message:  val_39);
            return;
        }
        
        if((this.logsDic.ContainsKey(key1:  val_31, key2:  stacktrace)) == false)
        {
            goto label_25;
        }
        
        val_40 = this.logsDic.Item[val_31].Item[stacktrace];
        if(val_40 == null)
        {
            goto label_28;
        }
        
        val_41 = val_18.count;
        val_42 = 0;
        goto label_36;
        label_25:
        this.collapsedLogs.Add(item:  val_11);
        this.logsDic.Item[val_31].set_Item(key:  stacktrace, value:  val_11);
        if(val_30 == 2)
        {
            goto label_33;
        }
        
        if(val_30 != 3)
        {
            goto label_34;
        }
        
        int val_29 = this.numOfCollapsedLogs;
        val_42 = 1;
        val_29 = val_29 + 1;
        this.numOfCollapsedLogs = val_29;
        goto label_35;
        label_28:
        val_40 = 16;
        val_41 = 11993091;
        val_42 = 0;
        goto label_36;
        label_33:
        int val_30 = this.numOfCollapsedLogsWarning;
        val_42 = 1;
        val_30 = val_30 + 1;
        this.numOfCollapsedLogsWarning = val_30;
        goto label_38;
        label_34:
        val_40 = this;
        val_41 = this.numOfCollapsedLogsError;
        val_42 = 1;
        label_36:
        this.numOfCollapsedLogsError = val_41 + 1;
        if(val_30 == 2)
        {
            goto label_38;
        }
        
        if(val_30 != 3)
        {
            goto label_39;
        }
        
        label_35:
        int val_31 = this.numOfLogs;
        val_31 = val_31 + 1;
        this.numOfLogs = val_31;
        goto label_41;
        label_38:
        int val_32 = this.numOfLogsWarning;
        val_32 = val_32 + 1;
        this.numOfLogsWarning = val_32;
        goto label_41;
        label_39:
        int val_33 = this.numOfLogsError;
        val_33 = val_33 + 1;
        this.numOfLogsError = val_33;
        label_41:
        val_30 = this.logs;
        val_31 = 1152921529108089248;
        val_30.Add(item:  val_11);
        bool val_34 = this.collapse;
        val_34 = val_34 ^ 1;
        val_34 = val_34 & 255;
        val_34 = val_42 | val_34;
        if(val_34 == false)
        {
            goto label_57;
        }
        
        if(.logType > 4)
        {
            goto label_47;
        }
        
        var val_35 = 40824784 + (type) << 2;
        val_35 = val_35 + 40824784;
        goto (40824784 + (type) << 2 + 40824784);
        label_47:
        if((System.String.IsNullOrEmpty(value:  this.filterText)) == true)
        {
            goto label_50;
        }
        
        val_30 = val_38.ToLower();
        if((val_30.Contains(value:  this.filterText.ToLower())) == false)
        {
            goto label_57;
        }
        
        label_50:
        this.currentLog.Add(item:  val_11);
        this.calculateStartIndex();
        val_30 = this.currentLog.Count;
        float val_36 = (float)UnityEngine.Screen.height;
        val_36 = val_36 * 0.75f;
        val_36 = val_36 / val_14;
        int val_37 = (int)val_36;
        val_37 = val_30 - val_37;
        if(this.startIndex >= val_37)
        {
                val_14 = val_14 + val_36;
            mem[1152921529119612224] = val_14;
        }
        
        label_57:
        val_39 = this.gameObject;
        val_39.SendMessage(methodName:  "OnLog", value:  val_11);
    }
    private void CaptureLogThread(string condition, string stacktrace, UnityEngine.LogType type)
    {
        Reporter.Log val_1 = new Reporter.Log();
        if(val_1 != null)
        {
                .condition = condition;
            .stacktrace = stacktrace;
        }
        else
        {
                mem[24] = condition;
            mem[32] = stacktrace;
        }
        
        .logType = type;
        bool val_2 = false;
        System.Threading.Monitor.Enter(obj:  this.threadedLogs, lockTaken: ref  val_2);
        this.threadedLogs.Add(item:  val_1);
        if(val_2 != 0)
        {
                System.Threading.Monitor.Exit(obj:  this.threadedLogs);
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    private void _OnLevelWasLoaded(UnityEngine.SceneManagement.Scene _null1, UnityEngine.SceneManagement.LoadSceneMode _null2)
    {
        if(this.clearOnNewSceneLoaded != false)
        {
                this.clear();
        }
        
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        this.currentScene = val_1.m_Handle.name;
        UnityEngine.SceneManagement.Scene val_3 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        UnityEngine.Debug.Log(message:  "Scene " + val_3.m_Handle.name + " is loaded");
    }
    private void OnApplicationQuit()
    {
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_currentView", value:  this.currentView);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_show", value:  this.show);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_collapse", value:  this.collapse);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_clearOnNewSceneLoaded", value:  this.clearOnNewSceneLoaded);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showTime", value:  this.showTime);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showScene", value:  this.showScene);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showMemory", value:  this.showMemory);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showFps", value:  this.showFps);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showGraph", value:  this.showGraph);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showLog", value:  this.showLog);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showWarning", value:  this.showWarning);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showError", value:  this.showError);
        UnityEngine.PlayerPrefs.SetString(key:  "Reporter_filterText", value:  this.filterText);
        UnityEngine.PlayerPrefs.SetFloat(key:  "Reporter_size", value:  this.size);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showClearOnNewSceneLoadedButton", value:  this.showClearOnNewSceneLoadedButton);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showTimeButton", value:  this.showTimeButton);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showSceneButton", value:  this.showSceneButton);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showMemButton", value:  this.showMemButton);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showFpsButton", value:  this.showFpsButton);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showSearchText", value:  this.showSearchText);
        UnityEngine.PlayerPrefs.Save();
    }
    private System.Collections.IEnumerator readInfo()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new Reporter.<readInfo>d__188(<>1__state:  0);
    }
    private void SaveLogsToDevice()
    {
        var val_12;
        string val_2 = UnityEngine.Application.persistentDataPath + "/logs.txt"("/logs.txt");
        System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>();
        UnityEngine.Debug.Log(message:  "Saving logs to " + val_2);
        System.IO.File.Delete(path:  val_2);
        val_12 = 0;
        goto label_3;
        label_30:
        object[] val_5 = new object[5];
        Log val_6 = this.logs.Item[0];
        if(val_5 == null)
        {
            goto label_6;
        }
        
        if(val_6.logType != 0)
        {
            goto label_7;
        }
        
        goto label_10;
        label_6:
        if(val_6.logType == 0)
        {
            goto label_10;
        }
        
        label_7:
        label_10:
        val_5[0] = val_6.logType;
        val_5[1] = "\n";
        Log val_7 = this.logs.Item[0];
        val_5[2] = val_7.condition;
        val_5[3] = "\n";
        Log val_8 = this.logs.Item[0];
        val_5[4] = val_8.stacktrace;
        val_3.Add(item:  +val_5);
        val_12 = 1;
        label_3:
        if(val_12 < this.logs.Count)
        {
            goto label_30;
        }
        
        System.IO.File.WriteAllLines(path:  val_2, contents:  val_3.ToArray());
    }
    public Reporter()
    {
        this.samples = new System.Collections.Generic.List<Sample>();
        this.logs = new System.Collections.Generic.List<Log>();
        this.collapsedLogs = new System.Collections.Generic.List<Log>();
        this.currentLog = new System.Collections.Generic.List<Log>();
        this.logsDic = new MultiKeyDictionary<System.String, System.String, Log>();
        this.cachedString = new System.Collections.Generic.Dictionary<System.String, System.String>();
        this.showLog = true;
        this.showWarning = true;
        this.showError = true;
        this.showClearOnNewSceneLoadedButton = true;
        this.showTimeButton = true;
        this.showSceneButton = true;
        this.showMemButton = true;
        this.showFpsButton = true;
        this.showSearchText = true;
        this.showCopyButton = true;
        this.showSaveButton = true;
        this.currentView = true;
        this.UserData = "";
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  32f, y:  32f);
        this.maxSize = 20f;
        this.numOfCircleToShow = 1;
        this.size = val_7.x;
        mem[1152921529120759604] = val_7.y;
        this.filterText = "";
        UnityEngine.Rect val_8 = UnityEngine.Rect.zero;
        this.screenRect = val_8;
        mem[1152921529120759688] = val_8.m_YMin;
        mem[1152921529120759692] = val_8.m_Width;
        mem[1152921529120759696] = val_8.m_Height;
        UnityEngine.Rect val_9 = UnityEngine.Rect.zero;
        this.toolBarRect = val_9;
        mem[1152921529120759704] = val_9.m_YMin;
        mem[1152921529120759708] = val_9.m_Width;
        mem[1152921529120759712] = val_9.m_Height;
        UnityEngine.Rect val_10 = UnityEngine.Rect.zero;
        this.logsRect = val_10;
        mem[1152921529120759720] = val_10.m_YMin;
        mem[1152921529120759724] = val_10.m_Width;
        mem[1152921529120759728] = val_10.m_Height;
        UnityEngine.Rect val_11 = UnityEngine.Rect.zero;
        this.stackRect = val_11;
        mem[1152921529120759736] = val_11.m_YMin;
        mem[1152921529120759740] = val_11.m_Width;
        mem[1152921529120759744] = val_11.m_Height;
        UnityEngine.Rect val_12 = UnityEngine.Rect.zero;
        this.graphRect = val_12;
        mem[1152921529120759752] = val_12.m_YMin;
        mem[1152921529120759756] = val_12.m_Width;
        mem[1152921529120759760] = val_12.m_Height;
        UnityEngine.Rect val_13 = UnityEngine.Rect.zero;
        this.graphMinRect = val_13;
        mem[1152921529120759768] = val_13.m_YMin;
        mem[1152921529120759772] = val_13.m_Width;
        mem[1152921529120759776] = val_13.m_Height;
        UnityEngine.Rect val_14 = UnityEngine.Rect.zero;
        this.graphMaxRect = val_14;
        mem[1152921529120759784] = val_14.m_YMin;
        mem[1152921529120759788] = val_14.m_Width;
        mem[1152921529120759792] = val_14.m_Height;
        UnityEngine.Rect val_15 = UnityEngine.Rect.zero;
        this.buttomRect = val_15;
        mem[1152921529120759800] = val_15.m_YMin;
        mem[1152921529120759804] = val_15.m_Width;
        mem[1152921529120759808] = val_15.m_Height;
        UnityEngine.Rect val_16 = UnityEngine.Rect.zero;
        this.detailRect = val_16;
        mem[1152921529120759824] = val_16.m_YMin;
        mem[1152921529120759828] = val_16.m_Width;
        mem[1152921529120759832] = val_16.m_Height;
        UnityEngine.Rect val_17 = UnityEngine.Rect.zero;
        this.countRect = val_17;
        mem[1152921529120759896] = val_17.m_YMin;
        mem[1152921529120759900] = val_17.m_Width;
        mem[1152921529120759904] = val_17.m_Height;
        UnityEngine.Rect val_18 = UnityEngine.Rect.zero;
        this.timeRect = val_18;
        mem[1152921529120759912] = val_18.m_YMin;
        mem[1152921529120759916] = val_18.m_Width;
        mem[1152921529120759920] = val_18.m_Height;
        UnityEngine.Rect val_19 = UnityEngine.Rect.zero;
        this.timeLabelRect = val_19;
        mem[1152921529120759928] = val_19.m_YMin;
        mem[1152921529120759932] = val_19.m_Width;
        mem[1152921529120759936] = val_19.m_Height;
        UnityEngine.Rect val_20 = UnityEngine.Rect.zero;
        this.sceneRect = val_20;
        mem[1152921529120759944] = val_20.m_YMin;
        mem[1152921529120759948] = val_20.m_Width;
        mem[1152921529120759952] = val_20.m_Height;
        UnityEngine.Rect val_21 = UnityEngine.Rect.zero;
        this.sceneLabelRect = val_21;
        mem[1152921529120759960] = val_21.m_YMin;
        mem[1152921529120759964] = val_21.m_Width;
        mem[1152921529120759968] = val_21.m_Height;
        UnityEngine.Rect val_22 = UnityEngine.Rect.zero;
        this.memoryRect = val_22;
        mem[1152921529120759976] = val_22.m_YMin;
        mem[1152921529120759980] = val_22.m_Width;
        mem[1152921529120759984] = val_22.m_Height;
        UnityEngine.Rect val_23 = UnityEngine.Rect.zero;
        this.memoryLabelRect = val_23;
        mem[1152921529120759992] = val_23.m_YMin;
        mem[1152921529120759996] = val_23.m_Width;
        mem[1152921529120760000] = val_23.m_Height;
        UnityEngine.Rect val_24 = UnityEngine.Rect.zero;
        this.fpsRect = val_24;
        mem[1152921529120760008] = val_24.m_YMin;
        mem[1152921529120760012] = val_24.m_Width;
        mem[1152921529120760016] = val_24.m_Height;
        UnityEngine.Rect val_25 = UnityEngine.Rect.zero;
        this.fpsLabelRect = val_25;
        mem[1152921529120760024] = val_25.m_YMin;
        mem[1152921529120760028] = val_25.m_Width;
        mem[1152921529120760032] = val_25.m_Height;
        this.tempContent = new UnityEngine.GUIContent();
        this.graphSize = 4f;
        this.gestureDetector = new System.Collections.Generic.List<UnityEngine.Vector2>();
        UnityEngine.Vector2 val_28 = UnityEngine.Vector2.zero;
        this.gestureSum = val_28;
        mem[1152921529120760156] = val_28.y;
        this.lastClickTime = -1f;
        this.firstTime = true;
        this.threadedLogs = new System.Collections.Generic.List<Log>();
    }
    private static Reporter()
    {
    
    }

}
