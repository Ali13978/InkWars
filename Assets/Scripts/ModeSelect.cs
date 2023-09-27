using UnityEngine;
public class ModeSelect : MonoBehaviour
{
    // Fields
    private const float MIDDLE_BUTTON_SCALE = 1;
    private const float SIDE_BUTTON_SCALE = 0.8;
    private const float HIDE_BUTTON_SCALE = 0;
    private const int LEFT = 0;
    private const int MIDDLE = 1;
    private const int RIGHT = 2;
    public UnityEngine.GameObject LoadingScreen;
    private UnityEngine.Vector2 startPos;
    private UnityEngine.Vector2 endPos;
    private UnityEngine.Vector2 diff;
    public float sensitivity;
    private float distance;
    public System.Collections.Generic.List<UnityEngine.GameObject> testimages;
    public int initCounter;
    private UnityEngine.Vector2 rightPosition;
    private UnityEngine.Vector2 leftPosition;
    private UnityEngine.Vector2 middlePosition;
    public UnityEngine.RectTransform middleStage;
    public UnityEngine.RectTransform leftStage;
    public UnityEngine.RectTransform rightStage;
    public UnityEngine.GameObject outOfLives;
    public UnityEngine.GameObject outOfShells;
    public UnityEngine.UI.Text ShellText;
    public UnityEngine.UI.Text lifeTimer1;
    public UnityEngine.UI.Text livesRemaining1;
    public UnityEngine.UI.Text lifeTimerOutOfLivesScreen;
    public UnityEngine.UI.Text livesRemainingOutOfLivesScreen;
    public UnityEngine.UI.Text pearlCount;
    public UnityEngine.UI.Text shellCount;
    public UnityEngine.UI.Image BackGround;
    private UnityEngine.Color lerpedColor;
    public UnityEngine.Color BGColor1;
    public UnityEngine.Color BGColor2;
    public bool ColorSwitcher;
    public float ColorTimer;
    public UnityEngine.GameObject backButton;
    public bool enableSwipe;
    private bool touchbool;
    
    // Methods
    private void Start()
    {
        var val_7;
        var val_29 = null;
        if((ModeSelect.<>c.<>9__37_0) == null)
        {
            goto label_3;
        }
        
        label_52:
        int val_1 = this.testimages.RemoveAll(match:  ModeSelect.<>c.<>9__37_0);
        UnityEngine.Vector2 val_2 = this.leftStage.anchoredPosition;
        this.leftPosition = val_2;
        mem[1152921528538816840] = val_2.y;
        UnityEngine.Vector2 val_3 = this.middleStage.anchoredPosition;
        this.middlePosition = val_3;
        mem[1152921528538816848] = val_3.y;
        UnityEngine.Vector2 val_4 = this.rightStage.anchoredPosition;
        this.rightPosition = val_4;
        mem[1152921528538816832] = val_4.y;
        List.Enumerator<T> val_5 = this.testimages.GetEnumerator();
        label_48:
        if(((-1837846176) & 1) == 0)
        {
            goto label_9;
        }
        
        System.Type val_8 = val_7.InitialType;
        UnityEngine.UI.Button val_9 = val_8.GetComponent<UnityEngine.UI.Button>();
        if(0 == val_9)
        {
            goto label_48;
        }
        
        UnityEngine.Object val_29 = val_8;
        val_29 = UnityEngine.Object.op_Equality(x:  this.testimages.Item[1], y:  val_29);
        val_9.interactable = val_29;
        UnityEngine.RectTransform val_13 = val_8.GetComponent<UnityEngine.RectTransform>();
        if(this.testimages.Item[0] != val_8)
        {
            goto label_20;
        }
        
        val_13.anchoredPosition = new UnityEngine.Vector2() {x = this.leftPosition, y = V11.16B};
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  0.8f);
        val_13.localScale = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        goto label_48;
        label_20:
        if(this.testimages.Item[1] != val_8)
        {
            goto label_29;
        }
        
        val_13.anchoredPosition = new UnityEngine.Vector2() {x = this.middlePosition, y = V11.16B};
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, d:  1f);
        val_13.localScale = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
        goto label_48;
        label_29:
        if(this.testimages.Item[2] != val_8)
        {
            goto label_38;
        }
        
        val_13.anchoredPosition = new UnityEngine.Vector2() {x = this.rightPosition, y = V11.16B};
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, d:  0.8f);
        val_13.localScale = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
        goto label_48;
        label_38:
        val_13.anchoredPosition = new UnityEngine.Vector2() {x = this.middlePosition, y = V11.16B};
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, d:  0f);
        val_13.localScale = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
        goto label_48;
        label_3:
        ModeSelect.<>c.<>9__37_0 = new System.Predicate<UnityEngine.GameObject>(object:  ModeSelect.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ModeSelect.<>c::<Start>b__37_0(UnityEngine.GameObject x));
        if(this.testimages != null)
        {
            goto label_52;
        }
        
        goto label_52;
        label_9:
        val_7.Add(driver:  public System.Void List.Enumerator<UnityEngine.GameObject>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<UnityEngine.GameObject>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
        this.InvokeRepeating(methodName:  "LifeTimer", time:  0f, repeatRate:  0.1f);
    }
    private void LifeTimer()
    {
        UnityEngine.UI.Text val_1 = this.lifeTimer1.GetComponent<UnityEngine.UI.Text>();
        string val_2 = MVC_MusselTracker.GetTimeTilNextMussel();
        UnityEngine.UI.Text val_3 = this.lifeTimerOutOfLivesScreen.GetComponent<UnityEngine.UI.Text>();
        string val_4 = MVC_MusselTracker.GetTimeTilNextMussel();
        UnityEngine.UI.Text val_5 = this.livesRemaining1.GetComponent<UnityEngine.UI.Text>();
        string val_7 = MVC_MusselTracker.GetMusselCount().ToString();
        UnityEngine.UI.Text val_8 = this.livesRemainingOutOfLivesScreen.GetComponent<UnityEngine.UI.Text>();
        string val_10 = MVC_MusselTracker.GetMusselCount().ToString();
        string val_12 = PlayerPrefsManager.GetShellString(shells:  PlayerPrefsManager.Shells);
        if(this.shellCount != null)
        {
                return;
        }
    
    }
    private void Update()
    {
        var val_34;
        float val_39;
        float val_40;
        float val_41;
        var val_42;
        float val_43;
        float val_44;
        float val_45;
        float val_46;
        val_34 = null;
        if(MVC_MusselTracker.GetMusselCount() >= 2)
        {
                this.outOfLives.gameObject.SetActive(value:  false);
        }
        
        if(UnityEngine.Time.timeScale == 0f)
        {
                UnityEngine.UI.Text val_4 = this.lifeTimer1.GetComponent<UnityEngine.UI.Text>();
            string val_5 = MVC_MusselTracker.GetTimeTilNextMussel();
            UnityEngine.UI.Text val_6 = this.lifeTimerOutOfLivesScreen.GetComponent<UnityEngine.UI.Text>();
            string val_7 = MVC_MusselTracker.GetTimeTilNextMussel();
            UnityEngine.UI.Text val_8 = this.livesRemaining1.GetComponent<UnityEngine.UI.Text>();
            string val_10 = MVC_MusselTracker.GetMusselCount().ToString();
            UnityEngine.UI.Text val_11 = this.livesRemainingOutOfLivesScreen.GetComponent<UnityEngine.UI.Text>();
            string val_13 = MVC_MusselTracker.GetMusselCount().ToString();
        }
        
        string val_15 = PlayerPrefsManager.Pearls.ToString();
        float val_16 = UnityEngine.Time.deltaTime;
        val_16 = val_16 * 0.125f;
        float val_17 = this.ColorTimer + val_16;
        this.ColorTimer = val_17;
        if(this.ColorSwitcher == false)
        {
            goto label_18;
        }
        
        UnityEngine.Color val_18 = UnityEngine.Color.LerpUnclamped(a:  new UnityEngine.Color() {r = this.BGColor1, g = 0.125f}, b:  new UnityEngine.Color() {r = this.BGColor2}, t:  val_17);
        val_39 = val_18.r;
        val_40 = val_18.g;
        val_41 = val_18.b;
        val_42 = 1152921528539319500;
        this.lerpedColor = val_18;
        mem[1152921528539319492] = val_40;
        mem[1152921528539319496] = val_41;
        mem[1152921528539319500] = val_18.a;
        if(this.ColorTimer < 1f)
        {
            goto label_21;
        }
        
        this.ColorTimer = 0f;
        this.ColorSwitcher = false;
        goto label_21;
        label_18:
        UnityEngine.Color val_19 = UnityEngine.Color.LerpUnclamped(a:  new UnityEngine.Color() {r = this.BGColor2, g = 0.125f}, b:  new UnityEngine.Color() {r = this.BGColor1}, t:  val_17);
        val_39 = val_19.r;
        val_40 = val_19.g;
        val_41 = val_19.b;
        val_42 = 1152921528539319500;
        this.lerpedColor = val_19;
        mem[1152921528539319492] = val_40;
        mem[1152921528539319496] = val_41;
        mem[1152921528539319500] = val_19.a;
        if(this.ColorTimer >= 1f)
        {
                this.ColorTimer = 0f;
            this.ColorSwitcher = true;
        }
        
        label_21:
        mem[1152921528539319500] = 1056964608;
        val_43 = val_39;
        val_44 = val_40;
        val_45 = val_41;
        this.BackGround.color = new UnityEngine.Color() {r = val_43, g = val_44, b = val_45, a = 0.5f};
        if(this.outOfLives.activeInHierarchy == true)
        {
                return;
        }
        
        if(this.outOfShells.activeInHierarchy == true)
        {
                return;
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  20)) != false)
        {
                this.LeftSwipe();
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  19)) != false)
        {
                this.RightSwipe();
        }
        
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
        {
                UnityEngine.Vector3 val_25 = UnityEngine.Input.mousePosition;
            val_39 = val_25.x;
            val_43 = val_39;
            val_44 = val_25.y;
            val_45 = val_25.z;
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_43, y = val_44, z = val_45});
            this.startPos = val_26;
            mem[1152921528539319316] = val_26.y;
            this.touchbool = true;
        }
        
        if(((UnityEngine.Input.GetMouseButton(button:  0)) != false) && (this.touchbool != false))
        {
                UnityEngine.Vector3 val_28 = UnityEngine.Input.mousePosition;
            val_46 = val_28.y;
            UnityEngine.Vector2 val_29 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_28.x, y = val_46, z = val_28.z});
            this.endPos = val_29;
            mem[1152921528539319324] = val_29.y;
            UnityEngine.Vector2 val_30 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y}, b:  new UnityEngine.Vector2() {x = this.startPos, y = 0.5f});
            this.diff = val_30;
            mem[1152921528539319332] = val_30.y;
            val_30.x = val_30.x * val_30.x;
            val_30.y = val_30.y * val_30.y;
            val_30.x = val_30.x + val_30.y;
            if(val_30.x >= _TYPE_MAX_)
        {
                val_39 = val_30.x;
        }
        
            this.distance = val_39;
            val_44 = (float)UnityEngine.Screen.width;
            val_43 = val_44 / this.sensitivity;
            if(val_39 < 0)
        {
                return;
        }
        
            this.touchbool = false;
            this.FindSwipeDirection();
        }
        
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
        {
                return;
        }
        
        this.touchbool = false;
        UnityEngine.Vector2 val_33 = UnityEngine.Vector2.zero;
        this.diff = val_33;
        mem[1152921528539319332] = val_33.y;
        this.endPos = val_33;
        mem[1152921528539319324] = val_33.y;
        this.startPos = val_33;
        mem[1152921528539319316] = val_33.y;
    }
    private void FindSwipeDirection()
    {
        UnityEngine.Vector2 val_2 = this.diff;
        val_2 = this.diff;
        float val_2 = System.Math.Abs(S1 / val_2);
        if((val_2 < 0) && (val_2 > 1f))
        {
                this.RightSwipe();
            return;
        }
        
        if(val_2 >= 0)
        {
                return;
        }
        
        if(val_2 >= 0)
        {
                return;
        }
        
        this.LeftSwipe();
    }
    public void RightSwipe()
    {
        if(this.enableSwipe == false)
        {
                return;
        }
        
        this.testimages.Item[1].GetComponent<UnityEngine.UI.Button>().interactable = false;
        this.testimages.RemoveAt(index:  0);
        this.testimages.Add(item:  this.testimages.Item[0]);
        this.testimages.Item[2].GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = this.leftPosition, y = V9.16B};
        this.testimages.Item[1].transform.SetAsLastSibling();
        this.UpdateSwipeMovement();
    }
    private void DelayMiddleInteractable()
    {
        this.testimages.Item[1].GetComponent<UnityEngine.UI.Button>().interactable = true;
    }
    private int GetRangedCounter(int newCounter)
    {
        int val_8;
        System.Collections.Generic.List<UnityEngine.GameObject> val_9;
        val_8 = newCounter;
        val_9 = this.testimages;
        if(val_9.Count > val_8)
        {
                if((val_8 & 2147483648) == 0)
        {
                return (int)val_8;
        }
        
            val_9 = this.testimages.Count;
            int val_3 = UnityEngine.Mathf.Abs(value:  val_8);
            int val_4 = this.testimages.Count;
            int val_5 = val_3 / val_4;
            val_5 = val_3 - (val_5 * val_4);
            val_8 = val_9 - val_5;
            return (int)val_8;
        }
        
        int val_6 = this.testimages.Count;
        val_8 = val_8 - ((val_8 / val_6) * val_6);
        return (int)val_8;
    }
    public void LeftSwipe()
    {
        var val_14;
        var val_15;
        if(this.enableSwipe == false)
        {
                return;
        }
        
        this.testimages.Item[1].GetComponent<UnityEngine.UI.Button>().interactable = false;
        if(this.testimages != null)
        {
                val_14 = this.testimages.Count;
        }
        else
        {
                val_14 = 0.Count;
        }
        
        if(this.testimages != null)
        {
                val_15 = this.testimages.Count;
        }
        else
        {
                val_15 = 0.Count;
        }
        
        this.testimages.RemoveAt(index:  val_15 - 1);
        this.testimages.Insert(index:  0, item:  this.testimages.Item[val_14 - 1]);
        this.testimages.Item[0].GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = this.rightPosition, y = V9.16B};
        this.testimages.Item[1].transform.SetAsLastSibling();
        this.UpdateSwipeMovement();
    }
    private void UpdateSwipeMovement()
    {
        var val_36;
        this.testimages.Item[0].SetActive(value:  true);
        this.testimages.Item[1].SetActive(value:  true);
        this.testimages.Item[2].SetActive(value:  true);
        object[] val_5 = new object[10];
        val_5[0] = "from";
        UnityEngine.Vector2 val_8 = this.testimages.Item[0].GetComponent<UnityEngine.RectTransform>().anchoredPosition;
        val_5[1] = val_8;
        val_5[2] = "to";
        val_5[3] = this.leftPosition;
        val_5[4] = "time";
        val_5[5] = 0.5f;
        val_5[6] = "onupdatetarget";
        val_5[7] = this.gameObject;
        val_5[8] = "onupdate";
        val_5[9] = "MoveLeftCounter";
        iTween.ValueTo(target:  this.testimages.Item[0], args:  iTween.Hash(args:  val_5));
        object[] val_12 = new object[10];
        val_12[0] = "from";
        UnityEngine.Vector2 val_15 = this.testimages.Item[2].GetComponent<UnityEngine.RectTransform>().anchoredPosition;
        val_12[1] = val_15;
        val_12[2] = "to";
        val_12[3] = this.rightPosition;
        val_12[4] = "time";
        val_12[5] = 0.5f;
        val_12[6] = "onupdatetarget";
        val_12[7] = this.gameObject;
        val_12[8] = "onupdate";
        val_12[9] = "MoveRightCounter";
        iTween.ValueTo(target:  this.testimages.Item[0], args:  iTween.Hash(args:  val_12));
        object[] val_19 = new object[10];
        val_19[0] = "from";
        UnityEngine.Vector2 val_22 = this.testimages.Item[1].GetComponent<UnityEngine.RectTransform>().anchoredPosition;
        val_19[1] = val_22;
        val_19[2] = "to";
        val_19[3] = this.middlePosition;
        val_19[4] = "time";
        val_19[5] = 0.5f;
        val_19[6] = "onupdatetarget";
        val_19[7] = this.gameObject;
        val_19[8] = "onupdate";
        val_19[9] = "MoveMiddleCounter";
        iTween.ValueTo(target:  this.testimages.Item[0], args:  iTween.Hash(args:  val_19));
        object[] val_26 = new object[6];
        val_26[0] = "x";
        val_26[1] = 0.8f;
        val_26[2] = "y";
        val_26[3] = 0.8f;
        val_26[4] = "time";
        val_26[5] = 0.5f;
        iTween.ScaleTo(target:  this.testimages.Item[2], args:  iTween.Hash(args:  val_26));
        object[] val_29 = new object[6];
        val_29[0] = "x";
        val_29[1] = 0.8f;
        val_29[2] = "y";
        val_29[3] = 0.8f;
        val_29[4] = "time";
        val_29[5] = 0.5f;
        iTween.ScaleTo(target:  this.testimages.Item[0], args:  iTween.Hash(args:  val_29));
        object[] val_32 = new object[6];
        val_32[0] = "x";
        val_32[1] = 1f;
        val_32[2] = "y";
        val_32[3] = 1f;
        val_32[4] = "time";
        val_32[5] = 0.5f;
        iTween.ScaleTo(target:  this.testimages.Item[1], args:  iTween.Hash(args:  val_32));
        this.Invoke(methodName:  "DelayMiddleInteractable", time:  0.3f);
        val_36 = 3;
        goto label_174;
        label_178:
        this.testimages.Item[3].SetActive(value:  false);
        val_36 = 4;
        label_174:
        if(val_36 < this.testimages.Count)
        {
            goto label_178;
        }
    
    }
    private void MoveLeftCounter(UnityEngine.Vector2 position)
    {
        this.testimages.Item[0].GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = position.x, y = position.y};
    }
    private void MoveRightCounter(UnityEngine.Vector2 position)
    {
        this.testimages.Item[2].GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = position.x, y = position.y};
    }
    private void MoveMiddleCounter(UnityEngine.Vector2 position)
    {
        this.testimages.Item[1].GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = position.x, y = position.y};
    }
    public void VersusClicked()
    {
        var val_4;
        var val_5;
        val_4 = null;
        if(MVC_MusselTracker.GetMusselCount() <= 1)
        {
                this.outOfLives.gameObject.SetActive(value:  true);
            return;
        }
        
        GameAudio.PlayButtonSound();
        PlayerPrefsManager.OnlinePVPTime = PlayerPrefsManager.LocalPVPTime;
        val_5 = null;
        val_5 = null;
        Character_GlobalInfo.gameMode = 5;
        this.backButton.SetActive(value:  false);
        this.backButton.WaitForFourFrames(scene:  "CharacterSelect", autoHideLoadingScreen:  true);
    }
    public void NetworkLobbyClicked()
    {
        UnityEngine.Debug.LogFormat(format:  "NETWORK LOBBY CLICKED", args:  System.Array.Empty<System.Object>());
        GameAudio.PlayButtonSound();
        this.backButton.SetActive(value:  false);
        this.backButton.WaitForFourFrames(scene:  "NetworkReset", autoHideLoadingScreen:  false);
    }
    public void InterNetLobbyClicked()
    {
        UnityEngine.Debug.LogFormat(format:  "INTERNET LOBBY CLICKED", args:  System.Array.Empty<System.Object>());
        GameAudio.PlayButtonSound();
        this.backButton.SetActive(value:  false);
        this.backButton.WaitForFourFrames(scene:  "NetworkLobbyNew", autoHideLoadingScreen:  true);
    }
    private void WaitForFourFrames(string scene, bool autoHideLoadingScreen = True)
    {
        var val_3;
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  scene, minimumDelayInSeconds:  1f, autoHideLoadingScreen:  autoHideLoadingScreen);
        val_3 = null;
        val_3 = null;
        UnityEngine.Object.Destroy(obj:  MainTitleBackMusicHandler.instance.gameObject);
    }
    public void AdventureClicked()
    {
        var val_4;
        var val_5;
        var val_6;
        GameAudio.PlayButtonSound();
        val_4 = null;
        if(MVC_MusselTracker.GetMusselCount() > 0)
        {
                val_5 = null;
            val_5 = null;
            UnityEngine.Object.Destroy(obj:  MainTitleBackMusicHandler.instance.gameObject);
            val_6 = null;
            val_6 = null;
            Character_GlobalInfo.gameMode = 1;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_PlayerChoose");
            return;
        }
        
        this.outOfLives.gameObject.SetActive(value:  true);
    }
    public void BackButtonClicked()
    {
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu_Title_Screen");
    }
    public void onPurchaseButtonClick(string sku)
    {
    
    }
    public ModeSelect()
    {
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  0f, y:  0f);
        mem[1152921528542440276] = val_1.y;
        this.sensitivity = 5f;
        this.diff = val_1.x;
        this.testimages = new System.Collections.Generic.List<UnityEngine.GameObject>();
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        this.lerpedColor = val_3;
        mem[1152921528542440436] = val_3.g;
        mem[1152921528542440440] = val_3.b;
        mem[1152921528542440444] = val_3.a;
        UnityEngine.Color val_4 = UnityEngine.Color.white;
        this.BGColor1 = val_4;
        mem[1152921528542440452] = val_4.g;
        mem[1152921528542440456] = val_4.b;
        mem[1152921528542440460] = val_4.a;
        UnityEngine.Color val_5 = UnityEngine.Color.white;
        this.BGColor2 = val_5;
        mem[1152921528542440468] = val_5.g;
        mem[1152921528542440472] = val_5.b;
        mem[1152921528542440476] = val_5.a;
        this.ColorSwitcher = true;
        this.enableSwipe = true;
    }

}
