using UnityEngine;
public class swipe : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector2 startPos;
    private UnityEngine.Vector2 endPos;
    private UnityEngine.Vector2 diff;
    public float sensitivity;
    private float distance;
    private bool isCallOnce;
    public CharacterNameController name_Character;
    public UnityEngine.UI.Image defaultStats;
    public UnityEngine.Sprite[] stats;
    private int nameCounter;
    public UnityEngine.UI.Image puzzleFill;
    public UnityEngine.UI.Image battleFill;
    public UnityEngine.UI.Image exBattleFill;
    public UnityEngine.GameObject iconsHolder;
    public UnityEngine.UI.Button nextButton;
    public UnityEngine.GameObject lockedImage;
    public UnityEngine.GameObject imageNew;
    public swipe.SwipeDirection swipeDir;
    public static swipe instance;
    public UnityEngine.GameObject takoSelection;
    public static bool touchBoolTako;
    private bool touchBool;
    public UnityEngine.GameObject instructionalPanel;
    private Scene_TakoSelection takoSelectionComp;
    
    // Methods
    private void Start()
    {
        this.takoSelectionComp = this.takoSelection.GetComponent<Scene_TakoSelection>();
        this.instructionalPanel.SetActive(value:  false);
        this.touchBool = false;
        swipe.touchBoolTako = false;
        this.imageNew.SetActive(value:  false);
        this.nameCounter = 0;
        UnityEngine.PlayerPrefs.SetInt(key:  "PlayerCharacter", value:  0);
        swipe.instance = this;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(methodName:  "AnimationAtStart");
        UnityEngine.Vector3 val_5 = this.imageNew.GetComponent<UnityEngine.RectTransform>().localScale;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0.75f);
        DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.imageNew.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  1f), ease:  4), loops:  0, loopType:  1);
    }
    private System.Collections.IEnumerator AnimationAtStart()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new swipe.<AnimationAtStart>d__26();
    }
    private System.Collections.IEnumerator CharacterStatus()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new swipe.<CharacterStatus>d__27();
    }
    private void Update()
    {
        float val_13;
        float val_14;
        float val_15;
        float val_16;
        if(swipe.touchBoolTako == false)
        {
                return;
        }
        
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            val_13 = val_2.x;
            val_14 = val_13;
            val_15 = val_2.y;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_2.z});
            this.startPos = val_3;
            mem[1152921528825880876] = val_3.y;
            this.touchBool = true;
        }
        
        if(((UnityEngine.Input.GetMouseButton(button:  0)) != false) && (this.touchBool != false))
        {
                UnityEngine.Vector3 val_5 = UnityEngine.Input.mousePosition;
            val_16 = val_5.y;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_16, z = val_5.z});
            this.endPos = val_6;
            mem[1152921528825880884] = val_6.y;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = this.startPos});
            this.diff = val_7;
            mem[1152921528825880892] = val_7.y;
            val_7.x = val_7.x * val_7.x;
            val_7.y = val_7.y * val_7.y;
            val_7.x = val_7.x + val_7.y;
            if(val_7.x >= _TYPE_MAX_)
        {
                val_13 = val_7.x;
        }
        
            this.distance = val_13;
            val_15 = (float)UnityEngine.Screen.width;
            val_14 = val_15 / this.sensitivity;
            if(val_13 < 0)
        {
                return;
        }
        
            if(this.isCallOnce != true)
        {
                this.FindSwipeDirection();
        }
        
        }
        
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
        {
                return;
        }
        
        swipe.touchBoolTako = false;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.zero;
        this.diff = val_10;
        mem[1152921528825880892] = val_10.y;
        this.endPos = val_10;
        mem[1152921528825880884] = val_10.y;
        this.startPos = val_10;
        mem[1152921528825880876] = val_10.y;
        this.isCallOnce = false;
        this.swipeDir = 0;
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  this.DelayTouch());
    }
    private System.Collections.IEnumerator DelayTouch()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new swipe.<DelayTouch>d__29();
    }
    private void FindSwipeDirection()
    {
        UnityEngine.Vector2 val_12;
        int val_13;
        SwipeDirection val_14;
        int val_15;
        this.isCallOnce = true;
        val_12 = this.diff;
        val_12 = this.diff;
        float val_12 = System.Math.Abs(S1 / val_12);
        if((val_12 >= 0) || (val_12 <= 1f))
        {
            goto label_4;
        }
        
        this.takoSelectionComp.rightbutton();
        int val_13 = this.nameCounter;
        val_13 = val_13 - 1;
        this.nameCounter = (val_13 >= 0) ? (val_13) : 12;
        if(this.takoSelectionComp == null)
        {
                val_13 = this.nameCounter;
        }
        
        UnityEngine.Color val_4 = this.takoSelectionComp.testimages[(long)val_13].GetComponent<UnityEngine.UI.Image>().color;
        if(val_4.r != 1f)
        {
            goto label_11;
        }
        
        this.lockedImage.SetActive(value:  false);
        this.defaultStats.GetComponent<UnityEngine.UI.Image>().sprite = this.stats[this.nameCounter];
        val_14 = 2;
        goto label_39;
        label_4:
        if((val_12 >= 0) || (val_12 >= 0))
        {
            goto label_19;
        }
        
        this.takoSelectionComp.leftbutton();
        this.nameCounter = ((this.nameCounter + 1) >= 13) ? 0 : (this.nameCounter + 1);
        if(this.takoSelectionComp == null)
        {
                val_15 = this.nameCounter;
        }
        
        UnityEngine.Color val_9 = this.takoSelectionComp.testimages[(long)val_15].GetComponent<UnityEngine.UI.Image>().color;
        if(val_9.r != 1f)
        {
            goto label_26;
        }
        
        this.lockedImage.SetActive(value:  false);
        this.defaultStats.GetComponent<UnityEngine.UI.Image>().sprite = this.stats[this.nameCounter];
        val_14 = 1;
        goto label_39;
        label_19:
        if((val_12 <= 1f) || (val_12 <= 1f))
        {
            goto label_34;
        }
        
        val_14 = 3;
        goto label_39;
        label_11:
        this.imageNew.SetActive(value:  false);
        this.lockedImage.SetActive(value:  true);
        val_14 = 2;
        goto label_39;
        label_34:
        var val_11 = (val_12 > 1f) ? 4 : 0;
        goto label_39;
        label_26:
        this.imageNew.SetActive(value:  false);
        val_14 = 1;
        this.lockedImage.SetActive(value:  true);
        label_39:
        this.swipeDir = val_14;
    }
    public void backButton()
    {
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_PlayerChoose");
    }
    public void okClick()
    {
        var val_3;
        var val_4;
        var val_5;
        UnityEngine.PlayerPrefs.SetString(key:  "tako", value:  "yes");
        UnityEngine.PlayerPrefs.SetString(key:  "ika", value:  "no");
        UnityEngine.PlayerPrefs.SetInt(key:  "PlayerCharacter", value:  this.nameCounter);
        GameAudio.PlayButtonSound();
        if(this.nameCounter != 0)
        {
            goto label_3;
        }
        
        val_3 = null;
        val_3 = null;
        if(DataStructs.UserDataDictionary.GameSave.isTakoStoryStartPlayed == false)
        {
            goto label_7;
        }
        
        label_3:
        label_13:
        UnityEngine.Coroutine val_2 = this.StartCoroutine(methodName:  "LoadStageSelect");
        return;
        label_7:
        val_4 = null;
        val_4 = null;
        DataStructs.UserDataDictionary.GameSave.isTakoStoryStartPlayed = true;
        val_5 = null;
        val_5 = null;
        StoryPanelScript.keyForStory = "Tako_Start";
        goto label_13;
    }
    private System.Collections.IEnumerator LoadStoryPanels()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new swipe.<LoadStoryPanels>d__33();
    }
    private System.Collections.IEnumerator LoadStageSelect()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new swipe.<LoadStageSelect>d__34();
    }
    private System.Collections.IEnumerator FillMeter()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new swipe.<FillMeter>d__35();
    }
    private void SetTakoName()
    {
    
    }
    public swipe()
    {
        this.sensitivity = 5f;
    }

}
