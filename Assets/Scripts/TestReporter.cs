using UnityEngine;
public class TestReporter : MonoBehaviour
{
    // Fields
    public int logTestCount;
    public int threadLogTestCount;
    public bool logEverySecond;
    private int currentLogTestCount;
    private Reporter reporter;
    private UnityEngine.GUIStyle style;
    private UnityEngine.Rect rect1;
    private UnityEngine.Rect rect2;
    private UnityEngine.Rect rect3;
    private UnityEngine.Rect rect4;
    private UnityEngine.Rect rect5;
    private UnityEngine.Rect rect6;
    private System.Threading.Thread thread;
    private float elapsed;
    
    // Methods
    private void Start()
    {
        var val_38;
        UnityEngine.Application.runInBackground = true;
        UnityEngine.Object val_2 = UnityEngine.Object.FindObjectOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_38 = 0;
        this.reporter = ;
        UnityEngine.Debug.Log(message:  "test long text sdf asdfg asdfg sdfgsdfg sdfg sfgsdfgsdfg sdfg sdf gsdfg sfdg sf gsdfg sdfg asdfg sdfgsdfg sdfg sdf gsdfg sfdg sf gsdfg sdfg asdfg sdfgsdfg sdfg sdf gsdfg sfdg sf gsdfg sdfg asdfg sdfgsdfg sdfg sdf gsdfg sfdg sf gsdfg sdfg asdfg sdfgsdfg sdfg sdf gsdfg sfdg sf gsdfg sdfg asdfg ssssssssssssssssssssssasdf asdf asdf asdf adsf \n dfgsdfg sdfg sdf gsdfg sfdg sf gsdfg sdfg asdfasdf asdf asdf asdf adsf \n dfgsdfg sdfg sdf gsdfg sfdg sf gsdfg sdfg asdfasdf asdf asdf asdf adsf \n dfgsdfg sdfg sdf gsdfg sfdg sf gsdfg sdfg asdfasdf asdf asdf asdf adsf \n dfgsdfg sdfg sdf gsdfg sfdg sf gsdfg sdfg asdfasdf asdf asdf asdf adsf \n dfgsdfg sdfg sdf gsdfg sfdg sf gsdfg sdfg asdf");
        UnityEngine.GUIStyle val_4 = new UnityEngine.GUIStyle();
        this.style = val_4;
        val_4.alignment = 4;
        UnityEngine.Color val_6 = UnityEngine.Color.white;
        this.style.normal.textColor = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
        this.style.wordWrap = true;
        do
        {
            UnityEngine.Debug.Log(message:  "Test Collapsed log");
            UnityEngine.Debug.LogWarning(message:  "Test Collapsed Warning");
            UnityEngine.Debug.LogError(message:  "Test Collapsed Error");
        }
        while((10 - 1) != 0);
        
        do
        {
            UnityEngine.Debug.Log(message:  "Test Collapsed log");
            UnityEngine.Debug.LogWarning(message:  "Test Collapsed Warning");
            UnityEngine.Debug.LogError(message:  "Test Collapsed Error");
        }
        while((10 - 1) != 0);
        
        int val_9 = UnityEngine.Screen.width;
        int val_10 = UnityEngine.Screen.height;
        var val_11 = (val_9 < 0) ? (val_9 + 1) : (val_9);
        val_11 = val_11 >> 1;
        var val_12 = (val_10 < 0) ? (val_10 + 1) : (val_10);
        val_11 = val_11 - 120;
        val_12 = val_12 >> 1;
        var val_13 = val_12 - 225;
        this.rect1 = 0;
        mem[1152921529124016524] = 0;
        mem[1152921529124016532] = 0;
        int val_14 = UnityEngine.Screen.width;
        int val_15 = UnityEngine.Screen.height;
        var val_16 = (val_14 < 0) ? (val_14 + 1) : (val_14);
        val_16 = val_16 >> 1;
        var val_17 = (val_15 < 0) ? (val_15 + 1) : (val_15);
        val_16 = val_16 - 120;
        val_17 = val_17 >> 1;
        var val_18 = val_17 - 175;
        this.rect2 = 0;
        mem[1152921529124016540] = 0;
        mem[1152921529124016548] = 0;
        int val_19 = UnityEngine.Screen.width;
        int val_20 = UnityEngine.Screen.height;
        var val_21 = (val_19 < 0) ? (val_19 + 1) : (val_19);
        val_21 = val_21 >> 1;
        var val_22 = (val_20 < 0) ? (val_20 + 1) : (val_20);
        val_21 = val_21 - 120;
        val_22 = val_22 >> 1;
        var val_23 = val_22 - 50;
        this.rect3 = 0;
        mem[1152921529124016556] = 0;
        mem[1152921529124016564] = 0;
        int val_24 = UnityEngine.Screen.width;
        int val_25 = UnityEngine.Screen.height;
        var val_26 = (val_24 < 0) ? (val_24 + 1) : (val_24);
        val_26 = val_26 >> 1;
        var val_27 = (val_25 < 0) ? (val_25 + 1) : (val_25);
        val_26 = val_26 - 120;
        val_27 = val_27 >> 1;
        this.rect4 = 0;
        mem[1152921529124016572] = 0;
        mem[1152921529124016580] = 0;
        int val_28 = UnityEngine.Screen.width;
        int val_29 = UnityEngine.Screen.height;
        var val_30 = (val_28 < 0) ? (val_28 + 1) : (val_28);
        val_30 = val_30 >> 1;
        var val_31 = (val_29 < 0) ? (val_29 + 1) : (val_29);
        val_30 = val_30 - 120;
        val_31 = val_31 >> 1;
        var val_32 = val_31 + 50;
        this.rect5 = 0;
        mem[1152921529124016588] = 0;
        mem[1152921529124016596] = 0;
        int val_33 = UnityEngine.Screen.width;
        int val_34 = UnityEngine.Screen.height;
        var val_35 = (val_33 < 0) ? (val_33 + 1) : (val_33);
        val_35 = val_35 >> 1;
        var val_36 = (val_34 < 0) ? (val_34 + 1) : (val_34);
        val_35 = val_35 - 120;
        val_36 = val_36 >> 1;
        var val_37 = val_36 + 100;
        this.rect6 = 0;
        mem[1152921529124016604] = 0;
        mem[1152921529124016612] = 0;
        System.Threading.Thread val_39 = new System.Threading.Thread(start:  new System.Threading.ThreadStart(object:  this, method:  System.Void TestReporter::threadLogTest()));
        this.thread = val_39;
        val_39.Start();
    }
    private void OnDestroy()
    {
        this.thread.Abort();
    }
    private void threadLogTest()
    {
        if(this.threadLogTestCount < 1)
        {
                return;
        }
        
        var val_1 = 0;
        do
        {
            UnityEngine.Debug.Log(message:  "Test Log from Thread");
            UnityEngine.Debug.LogWarning(message:  "Test Warning from Thread");
            UnityEngine.Debug.LogError(message:  "Test Error from Thread");
            val_1 = val_1 + 1;
        }
        while(val_1 < this.threadLogTestCount);
    
    }
    private void Update()
    {
        var val_5;
        if(this.currentLogTestCount >= this.logTestCount)
        {
            goto label_4;
        }
        
        val_5 = 0;
        label_5:
        UnityEngine.Debug.Log(message:  "Test Log " + this.currentLogTestCount);
        UnityEngine.Debug.LogError(message:  "Test LogError " + this.currentLogTestCount);
        UnityEngine.Debug.LogWarning(message:  "Test LogWarning " + this.currentLogTestCount);
        int val_5 = this.currentLogTestCount;
        val_5 = val_5 + 1;
        this.currentLogTestCount = val_5;
        if(val_5 > 8)
        {
            goto label_4;
        }
        
        val_5 = val_5 + 1;
        if(val_5 < this.logTestCount)
        {
            goto label_5;
        }
        
        label_4:
        float val_4 = UnityEngine.Time.deltaTime;
        val_4 = this.elapsed + val_4;
        this.elapsed = val_4;
        if(val_4 < 1f)
        {
                return;
        }
        
        this.elapsed = 0f;
        UnityEngine.Debug.Log(message:  "One Second Passed");
    }
    private void OnGUI()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.reporter)) == false)
        {
                return;
        }
        
        if(this.reporter.show != false)
        {
                return;
        }
        
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = this.rect1, m_YMin = V10.16B, m_Width = V9.16B, m_Height = V8.16B}, text:  "Draw circle on screen to show logs", style:  this.style);
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = this.rect2, m_YMin = V10.16B, m_Width = V9.16B, m_Height = V8.16B}, text:  "To use Reporter just create reporter from reporter menu at first scene your game start", style:  this.style);
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = this.rect3, m_YMin = V10.16B, m_Width = V9.16B, m_Height = V8.16B}, text:  "Load ReporterScene")) != false)
        {
                UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "ReporterScene");
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = this.rect4, m_YMin = V10.16B, m_Width = V9.16B, m_Height = V8.16B}, text:  "Load test1")) != false)
        {
                UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "test1");
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = this.rect5, m_YMin = V10.16B, m_Width = V9.16B, m_Height = V8.16B}, text:  "Load test2")) != false)
        {
                UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "test2");
        }
        
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = this.rect6, m_YMin = V9.16B, m_Width = this.rect5, m_Height = V10.16B}, text:  "fps : "("fps : ") + this.reporter.fps.ToString(format:  "0.0")(this.reporter.fps.ToString(format:  "0.0")), style:  this.style);
    }
    public TestReporter()
    {
        this.logTestCount = 100;
        this.threadLogTestCount = 100;
        this.logEverySecond = true;
    }

}
