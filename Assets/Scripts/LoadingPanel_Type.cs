using UnityEngine;
public class LoadingPanel_Type : MonoBehaviour
{
    // Fields
    private const float LOADING_SCREEN_SWITCH_INTERVAL = 8;
    public System.Collections.Generic.List<LoadingPanelTypeData> typeDataList;
    public UnityEngine.UI.Image typeTagImage;
    public TMPro.TextMeshProUGUI infoTxt;
    public TMPro.TextMeshProUGUI strategyTxt;
    public System.Collections.Generic.List<UnityEngine.UI.Image> characterImageList;
    public System.Collections.Generic.List<UnityEngine.UI.Image> skillLvImageList;
    public LoadingPanelPoseLoader poseLoader;
    private LoadingPanelTypeData currentData;
    private int currentTypeTagId;
    private bool init;
    
    // Methods
    public void Setup(LoadingPanelTypeData data)
    {
        this.SetupTypeInfo(data:  data);
        this.SetupCharacters(data:  data);
    }
    private void SetupTypeInfo(LoadingPanelTypeData data)
    {
        var val_12;
        var val_13;
        float val_14;
        var val_15;
        float val_17;
        float val_18;
        float val_19;
        val_13 = data;
        if(val_13 == null)
        {
            goto label_1;
        }
        
        this.infoTxt.text = data.info;
        this.strategyTxt.text = data.strategy;
        UnityEngine.Debug.Log(message:  "Reset Panel Images");
        UnityEngine.Color val_1 = UnityEngine.Color.clear;
        val_14 = val_1.b;
        this.typeTagImage.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_14, a = val_1.a};
        if(data.typeTagList != null)
        {
                if(data.typeTagList.Count >= 1)
        {
                this.typeTagImage.sprite = data.typeTagList.Item[UnityEngine.Random.Range(min:  0, max:  data.typeTagList.Count)];
            UnityEngine.Color val_6 = UnityEngine.Color.white;
            val_14 = val_6.b;
            this.typeTagImage.color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_14, a = val_6.a};
        }
        
        }
        
        UnityEngine.Debug.Log(message:  "Reset level images");
        val_15 = null;
        val_15 = null;
        if((LoadingPanel_Type.<>c.<>9__12_0) == null)
        {
            goto label_17;
        }
        
        label_33:
        int val_7 = this.skillLvImageList.RemoveAll(match:  LoadingPanel_Type.<>c.<>9__12_0);
        List.Enumerator<T> val_8 = this.skillLvImageList.GetEnumerator();
        val_12 = 1;
        goto label_20;
        label_25:
        System.Type val_9 = 0.InitialType;
        if(data.skillLevel >= val_12)
        {
            goto label_21;
        }
        
        val_14 = 0f;
        val_17 = 0f;
        val_18 = 0f;
        val_19 = 0f;
        if(val_9 != null)
        {
            goto label_24;
        }
        
        goto label_23;
        label_21:
        UnityEngine.Color val_10 = UnityEngine.Color.white;
        val_14 = val_10.r;
        val_17 = val_10.g;
        val_18 = val_10.b;
        val_19 = val_10.a;
        if(val_9 != null)
        {
            goto label_24;
        }
        
        label_23:
        label_24:
        val_12 = 2;
        label_20:
        if(((-1411500616) & 1) != 0)
        {
            goto label_25;
        }
        
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Image>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<UnityEngine.UI.Image>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
        return;
        label_1:
        UnityEngine.Debug.LogError(message:  "Data is null");
        return;
        label_17:
        LoadingPanel_Type.<>c.<>9__12_0 = new System.Predicate<UnityEngine.UI.Image>(object:  LoadingPanel_Type.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LoadingPanel_Type.<>c::<SetupTypeInfo>b__12_0(UnityEngine.UI.Image x));
        if(this.skillLvImageList != null)
        {
            goto label_33;
        }
        
        goto label_33;
    }
    private void SetupCharacters(LoadingPanelTypeData data)
    {
        var val_3;
        var val_14;
        var val_15;
        System.Collections.Generic.List<UnityEngine.UI.Image> val_16;
        var val_17;
        if(data == null)
        {
            goto label_1;
        }
        
        UnityEngine.Debug.Log(message:  "reset images");
        List.Enumerator<T> val_1 = this.characterImageList.GetEnumerator();
        label_7:
        if(((-1411273488) & 1) == 0)
        {
            goto label_5;
        }
        
        UnityEngine.Color val_5 = UnityEngine.Color.clear;
        val_3.InitialType.sprite = 0;
        goto label_7;
        label_1:
        UnityEngine.Debug.LogError(message:  " data is null, setup characters fail.");
        return;
        label_5:
        val_3.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Image>::Dispose(), rectTransform:  null, drivenProperties:  null);
        UnityEngine.Debug.Log(message:  "Set char images");
        val_15 = 1152921525119624656;
        if(data.characterImageList.Count > this.characterImageList.Count)
        {
                val_16 = this.characterImageList;
            val_17 = public System.Int32 System.Collections.Generic.List<UnityEngine.UI.Image>::get_Count();
        }
        else
        {
                val_16 = data.characterImageList;
            val_17 = public System.Int32 System.Collections.Generic.List<UnityEngine.Sprite>::get_Count();
        }
        
        val_14 = val_16.Count;
        if(val_14 >= 1)
        {
                var val_13 = 0;
            do
        {
            this.characterImageList.Item[0].sprite = data.characterImageList.Item[0];
            val_15 = this.characterImageList.Item[0];
            UnityEngine.Color val_12 = UnityEngine.Color.white;
            val_15.color = new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a};
            val_13 = val_13 + 1;
        }
        while(val_14 != val_13);
        
        }
        
        UnityEngine.Debug.Log(message:  "set images done");
    }
    private void OnEnable()
    {
        if(this.init == false)
        {
                return;
        }
        
        UnityEngine.RectTransform val_1 = this.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        val_1.anchoredPosition = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        val_1.offsetMax = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        val_1.offsetMin = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        this.InvokeRepeating(methodName:  "ShowRandom", time:  0f, repeatRate:  8f);
    }
    private void OnDisable()
    {
        System.Collections.Generic.List<UnityEngine.UI.Image> val_4;
        this.CancelInvoke(methodName:  "ShowRandom");
        val_4 = this.characterImageList;
        List.Enumerator<T> val_1 = val_4.GetEnumerator();
        label_4:
        if(((-1410979704) & 1) == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Color val_3 = UnityEngine.Color.clear;
        0.InitialType.sprite = 0;
        goto label_4;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Image>::Dispose(), rectTransform:  0, drivenProperties:  null);
    }
    private void ShowRandom()
    {
        UnityEngine.Debug.Log(message:  this.currentData);
        this.SetupTypeInfo(data:  this.currentData);
        this.SetupCharacters(data:  this.currentData);
        this.currentData = this.GetNextData();
        UnityEngine.Debug.Log(message:  "preload images");
        UnityEngine.Coroutine val_3 = this.poseLoader.StartCoroutine(routine:  this.poseLoader.LoadImages(typeList:  this.currentData.typeList, target:  this));
        UnityEngine.Debug.Log(message:  "Preload Images done");
    }
    private LoadingPanelTypeData GetNextData()
    {
        System.Collections.Generic.List<LoadingPanelTypeData> val_9;
        var val_11;
        val_9 = this.typeDataList;
        LoadingPanelTypeData val_3 = val_9.Item[UnityEngine.Random.Range(min:  0, max:  this.typeDataList.Count)];
        val_11 = 20;
        goto label_3;
        label_8:
        val_9 = UnityEngine.Random.Range(min:  0, max:  this.typeDataList.Count);
        LoadingPanelTypeData val_6 = this.typeDataList.Item[val_9];
        val_11 = 19;
        label_3:
        if(val_6 == null)
        {
            goto label_8;
        }
        
        var val_8 = (this.currentData != val_6) ? 1 : 0;
        val_8 = val_8 | ((this.currentData == 0) ? 1 : 0);
        if((val_11 > 0) || (val_8 == 0))
        {
            goto label_8;
        }
        
        return val_6;
    }
    private void Awake()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.Init());
    }
    private System.Collections.IEnumerator Init()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LoadingPanel_Type.<Init>d__19();
    }
    public void SetImages(System.Collections.Generic.List<UnityEngine.Sprite> imageList)
    {
        this.currentData.characterImageList = imageList;
    }
    public LoadingPanel_Type()
    {
        this.typeDataList = new System.Collections.Generic.List<LoadingPanelTypeData>();
        this.characterImageList = new System.Collections.Generic.List<UnityEngine.UI.Image>();
        this.skillLvImageList = new System.Collections.Generic.List<UnityEngine.UI.Image>();
    }

}
