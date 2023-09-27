using UnityEngine;
public class SelectStageController : MonoBehaviour
{
    // Fields
    private int rightCounter;
    private int leftCounter;
    public UnityEngine.GameObject[] testimages;
    public UnityEngine.UI.Image middleStage;
    public UnityEngine.UI.Image leftStage;
    public UnityEngine.UI.Image rightStage;
    public UnityEngine.UI.Image rollTargetLeft;
    public UnityEngine.UI.Image rollTargetRight;
    public int middleCounter;
    public UnityEngine.GameObject iconHolder;
    public UnityEngine.Transform imageNameSource;
    public UnityEngine.Transform imageStatsSource;
    public UnityEngine.Transform iconHolderSource;
    public UnityEngine.Transform imageNameTarget;
    public UnityEngine.Transform imageStatsTarget;
    public UnityEngine.Transform iconHolderTarget;
    public UnityEngine.UI.Text stagePriceText;
    private UnityEngine.UI.Button ConfirmMapButton;
    private UnityEngine.GameObject StageNameText;
    private UnityEngine.Vector3 leftPostion;
    private UnityEngine.Vector3 middlePostion;
    private UnityEngine.Vector3 rightPostion;
    
    // Methods
    private void OnEnable()
    {
        null = null;
        GGPPurchasingManager.OnPurchaseSuccess.AddListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void SelectStageController::OnPurchaseSuccess(IAPItemIds id)));
    }
    private void OnDisable()
    {
        null = null;
        GGPPurchasingManager.OnPurchaseSuccess.RemoveListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void SelectStageController::OnPurchaseSuccess(IAPItemIds id)));
    }
    private void Start()
    {
        this.iconHolder.SetActive(value:  false);
        UnityEngine.Vector3 val_2 = this.leftStage.transform.position;
        this.leftPostion = val_2;
        mem[1152921528798551852] = val_2.y;
        mem[1152921528798551856] = val_2.z;
        UnityEngine.Vector3 val_4 = this.middleStage.transform.position;
        this.middlePostion = val_4;
        mem[1152921528798551864] = val_4.y;
        mem[1152921528798551868] = val_4.z;
        UnityEngine.Vector3 val_6 = this.rightStage.transform.position;
        this.rightPostion = val_6;
        mem[1152921528798551876] = val_6.y;
        mem[1152921528798551880] = val_6.z;
        this.testimages[this.leftCounter].transform.position = new UnityEngine.Vector3() {x = this.leftPostion, y = V9.16B, z = V10.16B};
        this.testimages[this.middleCounter].transform.position = new UnityEngine.Vector3() {x = this.middlePostion, y = V9.16B, z = V10.16B};
        this.testimages[this.middleCounter].transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.testimages[this.leftCounter].transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.testimages[this.rightCounter].transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.testimages[this.rightCounter].transform.position = new UnityEngine.Vector3() {x = this.rightPostion, y = V9.16B, z = V10.16B};
        this.middleStage.transform.GetChild(index:  0).gameObject.SetActive(value:  false);
        this.middleStage.transform.GetChild(index:  1).gameObject.SetActive(value:  false);
    }
    public void DarkenAtStart()
    {
        UnityEngine.Color val_3 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.testimages[this.middleCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
    }
    private void Update()
    {
        UnityEngine.GameObject val_31;
        bool val_32;
        var val_33;
        var val_34;
        var val_35;
        System.Object[] val_36;
        val_31 = this;
        val_32 = swipeika.touchBoolIka;
        if(val_32 == false)
        {
                return;
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  20)) != false)
        {
                int val_3 = ((this.rightCounter + 1) == 12) ? 0 : (this.rightCounter + 1);
            this.testimages[(long)this.leftCounter].SetActive(value:  false);
            this.testimages[(long)val_3].SetActive(value:  true);
            object[] val_4 = new object[6];
            val_4[0] = "x";
            val_34 = 1152921504623566848;
            val_4[1] = this.rightPostion;
            val_4[2] = "z";
            val_4[3] = 10;
            val_35 = "time";
            val_4[4] = "time";
            val_4[5] = 0;
            iTween.MoveTo(target:  this.testimages[(long)val_3], args:  iTween.Hash(args:  val_4));
            object[] val_6 = new object[6];
            val_6[0] = "x";
            val_6[1] = this.leftPostion;
            val_6[2] = "z";
            val_6[3] = 10;
            val_6[4] = "time";
            val_6[5] = 0.5f;
            iTween.MoveTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_6));
            object[] val_8 = new object[6];
            val_8[0] = "x";
            val_8[1] = this.middlePostion;
            val_8[2] = "z";
            val_8[3] = 10;
            val_8[4] = "time";
            val_8[5] = 0.5f;
            iTween.MoveTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_8));
            this.rightCounter = val_3;
            this.leftCounter = this.middleCounter;
            this.middleCounter = this.rightCounter;
            object[] val_10 = new object[6];
            val_10[0] = "x";
            val_10[1] = 0.15f;
            val_10[2] = "y";
            val_10[3] = 0.15f;
            val_10[4] = "time";
            val_10[5] = 0.5f;
            iTween.ScaleTo(target:  this.testimages[(long)val_3], args:  iTween.Hash(args:  val_10));
            object[] val_12 = new object[6];
            val_12[0] = "x";
            val_12[1] = 0.15f;
            val_12[2] = "y";
            val_12[3] = 0.15f;
            val_12[4] = "time";
            val_12[5] = 0.5f;
            iTween.ScaleTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_12));
            object[] val_14 = new object[6];
            val_36 = val_14;
            val_36[0] = "x";
            val_36[1] = 0.3f;
            val_36[2] = "y";
            val_36[3] = 0.3f;
            val_36[4] = "time";
            val_32 = val_14.Length;
            val_36[5] = 0.5f;
            iTween.ScaleTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_14));
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  19)) == false)
        {
                return;
        }
        
        int val_18 = (this.leftCounter == 0) ? 11 : (this.leftCounter - 1);
        this.testimages[(long)this.rightCounter].SetActive(value:  false);
        this.testimages[(long)val_18].SetActive(value:  true);
        object[] val_19 = new object[6];
        val_19[0] = "x";
        val_34 = 1152921504623566848;
        val_19[1] = this.leftPostion;
        val_19[2] = "z";
        val_19[3] = 10;
        val_35 = "time";
        val_19[4] = "time";
        val_19[5] = 0;
        iTween.MoveTo(target:  this.testimages[(long)val_18], args:  iTween.Hash(args:  val_19));
        object[] val_21 = new object[6];
        val_21[0] = "x";
        val_21[1] = this.middlePostion;
        val_21[2] = "z";
        val_21[3] = 10;
        val_21[4] = "time";
        val_21[5] = 0.5f;
        iTween.MoveTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_21));
        object[] val_23 = new object[6];
        val_23[0] = "x";
        val_23[1] = this.rightPostion;
        val_23[2] = "z";
        val_23[3] = 10;
        val_23[4] = "time";
        val_23[5] = 0.5f;
        iTween.MoveTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_23));
        this.rightCounter = this.middleCounter;
        this.leftCounter = val_18;
        this.middleCounter = this.leftCounter;
        object[] val_25 = new object[6];
        val_25[0] = "x";
        val_25[1] = 0.15f;
        val_33 = "y";
        val_25[2] = "y";
        val_25[3] = 0.15f;
        val_25[4] = "time";
        val_25[5] = 0.5f;
        iTween.ScaleTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_25));
        object[] val_27 = new object[6];
        val_27[0] = "x";
        val_27[1] = 0.15f;
        val_27[2] = "y";
        val_27[3] = 0.15f;
        val_27[4] = "time";
        val_27[5] = 0.5f;
        iTween.ScaleTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_27));
        val_31 = this.testimages[this.middleCounter];
        object[] val_29 = new object[6];
        val_29[0] = "x";
        val_29[1] = 0.3f;
        val_29[2] = "y";
        val_29[3] = 0.3f;
        val_29[4] = "time";
        val_36 = 0.5f;
        val_29[5] = val_36;
        iTween.ScaleTo(target:  val_31, args:  iTween.Hash(args:  val_29));
    }
    public void leftSwipe()
    {
        var val_74;
        float val_75;
        float val_76;
        UnityEngine.Color val_3 = this.testimages[this.middleCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_3.r != 1f)
        {
            goto label_6;
        }
        
        object[] val_4 = new object[4];
        val_4[0] = "position";
        UnityEngine.Vector3 val_5 = this.iconHolderTarget.position;
        val_4[1] = val_5;
        val_4[2] = "time";
        val_4[3] = 0.2f;
        iTween.MoveTo(target:  this.iconHolder, args:  iTween.Hash(args:  val_4));
        val_74 = this;
        UnityEngine.Color val_9 = this.testimages[this.rightCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_9.r != 0.8f)
        {
            goto label_61;
        }
        
        object[] val_10 = new object[8];
        val_10[0] = "position";
        UnityEngine.Vector3 val_11 = this.iconHolderSource.position;
        val_10[1] = val_11;
        val_10[2] = "easeType";
        val_10[3] = 24;
        val_10[4] = "delay";
        val_10[5] = 0.3f;
        val_10[6] = "time";
        val_10[7] = 0.3f;
        goto label_55;
        label_6:
        val_74 = this;
        UnityEngine.Color val_14 = this.testimages[this.rightCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_14.r != 0.8f)
        {
            goto label_61;
        }
        
        object[] val_15 = new object[8];
        val_15[0] = "position";
        UnityEngine.Vector3 val_16 = this.iconHolderSource.position;
        val_15[1] = val_16;
        val_15[2] = "easeType";
        val_15[3] = 24;
        val_15[4] = "delay";
        val_15[5] = 0.3f;
        val_15[6] = "time";
        val_15[7] = 0.3f;
        label_55:
        iTween.MoveTo(target:  this.iconHolder, args:  iTween.Hash(args:  val_15));
        label_61:
        int val_19 = ((this.rightCounter + 1) == 12) ? 0 : (this.rightCounter + 1);
        UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  this.leftPostion, y:  val_16.y);
        UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
        this.testimages[(long)val_19].transform.position = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
        UnityEngine.Vector2 val_24 = new UnityEngine.Vector2(x:  0.2f, y:  0.2f);
        UnityEngine.Vector3 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y});
        val_75 = val_25.x;
        val_76 = val_25.z;
        this.testimages[(long)val_19].transform.localScale = new UnityEngine.Vector3() {x = val_75, y = val_25.y, z = val_76};
        this.testimages[this.leftCounter].SetActive(value:  false);
        this.testimages[(long)val_19].SetActive(value:  true);
        object[] val_26 = new object[8];
        val_26[0] = "x";
        val_26[1] = this.rightPostion;
        val_26[2] = "y";
        val_26[3] = val_26.Length;
        val_26[4] = "z";
        val_26[5] = 10;
        val_26[6] = "time";
        val_26[7] = 0.4f;
        iTween.MoveTo(target:  this.testimages[(long)val_19], args:  iTween.Hash(args:  val_26));
        object[] val_28 = new object[8];
        val_28[0] = "x";
        val_28[1] = this.leftPostion;
        val_28[2] = "y";
        val_28[3] = val_28.Length;
        val_28[4] = "z";
        val_28[5] = 10;
        val_28[6] = "time";
        val_28[7] = 0.4f;
        iTween.MoveTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_28));
        object[] val_30 = new object[8];
        val_30[0] = "x";
        val_30[1] = this.middlePostion;
        val_30[2] = "y";
        val_30[3] = val_30.Length;
        val_30[4] = "z";
        val_30[5] = 10;
        val_30[6] = "time";
        val_30[7] = 0.4f;
        iTween.MoveTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_30));
        this.leftCounter = this.middleCounter;
        this.middleCounter = this.rightCounter;
        this.rightCounter = val_19;
        this.middleStage.transform.GetChild(index:  0).gameObject.SetActive(value:  false);
        this.middleStage.transform.GetChild(index:  1).gameObject.SetActive(value:  false);
        int val_39 = GameInfo.stage.GetAllUniqueIds().Item[this.middleCounter];
        string val_42 = GGPPurchasingManager.instance.GetPrice(id:  GameInfo.stage.GetIAPItemIds(uniqueId:  val_39));
        int val_84 = val_39;
        val_84 = DataStructs.UserDataDictionary.Items.IsStageUnlock(id:  val_84);
        UnityEngine.Coroutine val_45 = this.StartCoroutine(routine:  this.LockStatus(isStageBought:  val_84));
        UnityEngine.Color val_48 = this.testimages[this.leftCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_48.r == 1f)
        {
                UnityEngine.Color val_51 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_75 = val_51.r;
            val_76 = val_51.b;
            this.testimages[this.leftCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_75, g = val_51.g, b = val_76, a = val_51.a};
        }
        
        UnityEngine.Color val_54 = this.testimages[this.middleCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_54.r == 0.8f)
        {
                UnityEngine.Color val_57 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_75 = val_57.r;
            val_76 = val_57.b;
            this.testimages[this.middleCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_75, g = val_57.g, b = val_76, a = val_57.a};
        }
        
        object[] val_58 = new object[8];
        val_58[0] = "x";
        val_58[1] = 0.27f;
        val_58[2] = "y";
        val_58[3] = 0.27f;
        val_58[4] = "easeType";
        val_58[5] = 21;
        val_58[6] = "time";
        val_58[7] = 0.3f;
        iTween.ScaleTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_58));
        object[] val_60 = new object[10];
        val_60[0] = "x";
        val_60[1] = 0.23f;
        val_60[2] = "y";
        val_60[3] = 0.23f;
        val_60[4] = "easeType";
        val_60[5] = 24;
        val_60[6] = "delay";
        val_60[7] = 0.3f;
        val_60[8] = "time";
        val_60[9] = 0.4f;
        iTween.ScaleTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_60));
        object[] val_62 = new object[8];
        val_62[0] = "x";
        val_62[1] = 0.27f;
        val_62[2] = "y";
        val_62[3] = 0.27f;
        val_62[4] = "easeType";
        val_62[5] = 21;
        val_62[6] = "time";
        val_62[7] = 0.3f;
        iTween.ScaleTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_62));
        object[] val_64 = new object[10];
        val_64[0] = "x";
        val_64[1] = 0.23f;
        val_64[2] = "y";
        val_64[3] = 0.23f;
        val_64[4] = "easeType";
        val_64[5] = 24;
        val_64[6] = "delay";
        val_64[7] = 0.3f;
        val_64[8] = "time";
        val_64[9] = 0.4f;
        iTween.ScaleTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_64));
        object[] val_66 = new object[8];
        val_66[0] = "x";
        val_66[1] = 0.32f;
        val_66[2] = "y";
        val_66[3] = 0.32f;
        val_66[4] = "easeType";
        val_66[5] = 21;
        val_66[6] = "time";
        val_66[7] = 0.4f;
        iTween.ScaleTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_66));
        this.testimages[this.middleCounter].transform.SetAsLastSibling();
        this.StopCoroutine(methodName:  "Fade");
        this.StopCoroutine(routine:  this.StageFade());
        this.StopCoroutine(methodName:  "Fade");
        this.StopCoroutine(routine:  this.StageFade());
        this.StopCoroutine(methodName:  "Fade");
        this.StopCoroutine(routine:  this.StageFade());
        UnityEngine.Coroutine val_73 = this.StartCoroutine(routine:  this.StageFade());
    }
    private System.Collections.IEnumerator LockStatus(bool isStageBought)
    {
        SelectStageController.<LockStatus>d__28 val_1 = new SelectStageController.<LockStatus>d__28();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .isStageBought = isStageBought;
        return (System.Collections.IEnumerator)val_1;
    }
    public void rightSwipe()
    {
        var val_74;
        float val_75;
        float val_76;
        UnityEngine.Color val_3 = this.testimages[this.middleCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_3.r != 1f)
        {
            goto label_6;
        }
        
        object[] val_4 = new object[4];
        val_4[0] = "position";
        UnityEngine.Vector3 val_5 = this.iconHolderTarget.position;
        val_4[1] = val_5;
        val_4[2] = "time";
        val_4[3] = 0.2f;
        iTween.MoveTo(target:  this.iconHolder, args:  iTween.Hash(args:  val_4));
        UnityEngine.Color val_9 = this.testimages[this.leftCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_9.r != 0.8f)
        {
            goto label_28;
        }
        
        object[] val_10 = new object[8];
        val_10[0] = "position";
        val_74 = 1152921528805047084;
        UnityEngine.Vector3 val_11 = this.iconHolderSource.position;
        val_10[1] = val_11;
        val_10[2] = "easeType";
        val_10[3] = 24;
        val_10[4] = "delay";
        val_10[5] = 0.3f;
        val_10[6] = "time";
        val_10[7] = 0.3f;
        goto label_55;
        label_6:
        val_74 = this;
        UnityEngine.Color val_14 = this.testimages[this.leftCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_14.r != 0.8f)
        {
            goto label_90;
        }
        
        object[] val_15 = new object[8];
        val_15[0] = "position";
        UnityEngine.Vector3 val_16 = this.iconHolderSource.position;
        val_15[1] = val_16;
        val_15[2] = "easeType";
        val_15[3] = 24;
        val_15[4] = "delay";
        val_15[5] = 0.3f;
        val_15[6] = "time";
        val_15[7] = 0.3f;
        label_55:
        iTween.MoveTo(target:  this.iconHolder, args:  iTween.Hash(args:  val_15));
        goto label_90;
        label_28:
        val_74 = 1152921528805047084;
        label_90:
        int val_19 = (this.leftCounter == 0) ? 11 : (this.leftCounter - 1);
        UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  this.rightPostion, y:  0.8f);
        UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
        this.testimages[(long)val_19].transform.position = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
        UnityEngine.Vector2 val_24 = new UnityEngine.Vector2(x:  0.2f, y:  0.2f);
        UnityEngine.Vector3 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y});
        val_75 = val_25.x;
        val_76 = val_25.z;
        this.testimages[(long)val_19].transform.localScale = new UnityEngine.Vector3() {x = val_75, y = val_25.y, z = val_76};
        this.testimages[this.rightCounter].SetActive(value:  false);
        this.testimages[(long)val_19].SetActive(value:  true);
        object[] val_26 = new object[8];
        val_26[0] = "x";
        val_26[1] = this.leftPostion;
        val_26[2] = "y";
        val_26[3] = val_26.Length;
        val_26[4] = "z";
        val_26[5] = 10;
        val_26[6] = "time";
        val_26[7] = 0.4f;
        iTween.MoveTo(target:  this.testimages[(long)val_19], args:  iTween.Hash(args:  val_26));
        object[] val_28 = new object[8];
        val_28[0] = "x";
        val_28[1] = this.middlePostion;
        val_28[2] = "y";
        val_28[3] = val_28.Length;
        val_28[4] = "z";
        val_28[5] = 10;
        val_28[6] = "time";
        val_28[7] = 0.4f;
        iTween.MoveTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_28));
        object[] val_30 = new object[8];
        val_30[0] = "x";
        val_30[1] = this.rightPostion;
        val_30[2] = "y";
        val_30[3] = val_30.Length;
        val_30[4] = "z";
        val_30[5] = 10;
        val_30[6] = "time";
        val_30[7] = 0.4f;
        iTween.MoveTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_30));
        this.rightCounter = this.middleCounter;
        this.middleCounter = this.leftCounter;
        this.leftCounter = val_19;
        this.middleStage.transform.GetChild(index:  0).gameObject.SetActive(value:  false);
        this.middleStage.transform.GetChild(index:  1).gameObject.SetActive(value:  false);
        int val_39 = GameInfo.stage.GetAllUniqueIds().Item[this.middleCounter];
        string val_42 = GGPPurchasingManager.instance.GetPrice(id:  GameInfo.stage.GetIAPItemIds(uniqueId:  val_39));
        int val_84 = val_39;
        val_84 = DataStructs.UserDataDictionary.Items.IsStageUnlock(id:  val_84);
        UnityEngine.Coroutine val_45 = this.StartCoroutine(routine:  this.LockStatus(isStageBought:  val_84));
        UnityEngine.Color val_48 = this.testimages[this.rightCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_48.r == 1f)
        {
                UnityEngine.Color val_51 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_75 = val_51.r;
            val_76 = val_51.b;
            this.testimages[this.rightCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_75, g = val_51.g, b = val_76, a = val_51.a};
        }
        
        UnityEngine.Color val_54 = this.testimages[this.middleCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_54.r == 0.8f)
        {
                UnityEngine.Color val_57 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_75 = val_57.r;
            val_76 = val_57.b;
            this.testimages[this.middleCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_75, g = val_57.g, b = val_76, a = val_57.a};
        }
        
        object[] val_58 = new object[8];
        val_58[0] = "x";
        val_58[1] = 0.27f;
        val_58[2] = "y";
        val_58[3] = 0.27f;
        val_58[4] = "easeType";
        val_58[5] = 21;
        val_58[6] = "time";
        val_58[7] = 0.3f;
        iTween.ScaleTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_58));
        object[] val_60 = new object[10];
        val_60[0] = "x";
        val_60[1] = 0.23f;
        val_60[2] = "y";
        val_60[3] = 0.23f;
        val_60[4] = "easeType";
        val_60[5] = 24;
        val_60[6] = "delay";
        val_60[7] = 0.3f;
        val_60[8] = "time";
        val_60[9] = 0.4f;
        iTween.ScaleTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_60));
        object[] val_62 = new object[8];
        val_62[0] = "x";
        val_62[1] = 0.27f;
        val_62[2] = "y";
        val_62[3] = 0.27f;
        val_62[4] = "easeType";
        val_62[5] = 21;
        val_62[6] = "time";
        val_62[7] = 0.3f;
        iTween.ScaleTo(target:  this.testimages[val_74], args:  iTween.Hash(args:  val_62));
        object[] val_64 = new object[10];
        val_64[0] = "x";
        val_64[1] = 0.23f;
        val_64[2] = "y";
        val_64[3] = 0.23f;
        val_64[4] = "easeType";
        val_64[5] = ;
        val_64[6] = "delay";
        val_64[7] = 0.3f;
        val_64[8] = "time";
        val_64[9] = 0.4f;
        iTween.ScaleTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_64));
        object[] val_66 = new object[8];
        val_66[0] = "x";
        val_66[1] = 0.32f;
        val_66[2] = "y";
        val_66[3] = 0.32f;
        val_66[4] = "easeType";
        val_66[5] = 21;
        val_66[6] = "time";
        val_66[7] = 0.4f;
        iTween.ScaleTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_66));
        this.testimages[this.middleCounter].transform.SetAsLastSibling();
        this.StopCoroutine(methodName:  "Fade");
        this.StopCoroutine(routine:  this.StageFade());
        this.StopCoroutine(methodName:  "Fade");
        this.StopCoroutine(routine:  this.StageFade());
        this.StopCoroutine(methodName:  "Fade");
        this.StopCoroutine(routine:  this.StageFade());
        UnityEngine.Coroutine val_73 = this.StartCoroutine(routine:  this.StageFade());
    }
    private System.Collections.IEnumerator StageFade()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new SelectStageController.<StageFade>d__30();
    }
    private System.Collections.IEnumerator Fade(UnityEngine.UI.Image mat, float duration, UnityEngine.Color startColor, UnityEngine.Color endColor)
    {
        var val_2;
        var val_3;
        SelectStageController.<Fade>d__31 val_1 = new SelectStageController.<Fade>d__31();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .mat = mat;
            .duration = duration;
        }
        else
        {
                mem[40] = mat;
            mem[32] = duration;
        }
        
        .startColor = startColor;
        mem[1152921528806536708] = startColor.g;
        mem[1152921528806536712] = startColor.b;
        mem[1152921528806536716] = startColor.a;
        .endColor = endColor;
        mem[1152921528806536724] = val_3;
        mem[1152921528806536728] = endColor.g;
        mem[1152921528806536732] = val_2;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator UnlockButton()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new SelectStageController.<UnlockButton>d__32();
    }
    private void rollTemp()
    {
    
    }
    public void StartRoll(float rollTime)
    {
        float val_49;
        UnityEngine.GameObject val_50;
        var val_51;
        var val_52;
        var val_53;
        System.Object[] val_54;
        val_49 = rollTime;
        val_50 = this;
        int val_2 = ((this.rightCounter + 1) == 12) ? 0 : (this.rightCounter + 1);
        this.testimages[(long)val_2].transform.position = new UnityEngine.Vector3() {x = this.leftPostion, y = V10.16B, z = V11.16B};
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  0.14f, y:  0.14f);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
        this.testimages[(long)val_2].transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        this.testimages[this.leftCounter].SetActive(value:  false);
        this.testimages[(long)val_2].SetActive(value:  true);
        this.testimages[this.rightCounter].transform.SetAsLastSibling();
        UnityEngine.GameObject val_54 = this.testimages[(long)val_2];
        object[] val_8 = new object[10];
        val_8[0] = "x";
        if(val_2 == 1)
        {
                val_51 = 1152921504623566848;
            val_8[1] = this.rightPostion;
            val_8[2] = "y";
            val_8[3] = val_8.Length;
            val_8[4] = "z";
            val_8[5] = 10;
            val_8[6] = "easeType";
            val_8[7] = 21;
            val_52 = "time";
            val_8[8] = "time";
            val_8[9] = val_49;
            iTween.MoveTo(target:  val_54, args:  iTween.Hash(args:  val_8));
            object[] val_10 = new object[10];
            val_10[0] = "x";
            val_10[1] = this.leftPostion;
            val_10[2] = "y";
            val_10[3] = val_10.Length;
            val_10[4] = "z";
            val_10[5] = 10;
            val_10[6] = "easeType";
            val_10[7] = 21;
            val_10[8] = "time";
            val_10[9] = val_49;
            iTween.MoveTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_10));
            object[] val_12 = new object[10];
            val_12[0] = "x";
            val_12[1] = this.middlePostion;
            val_12[2] = "y";
            val_12[3] = val_12.Length;
            val_12[4] = "z";
            val_53 = "x";
            val_12[5] = 10;
            val_12[6] = "easeType";
            val_12[7] = 21;
            val_12[8] = "time";
            val_12[9] = val_49;
            iTween.MoveTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_12));
            this.rightCounter = 1;
            this.leftCounter = this.middleCounter;
            this.middleCounter = this.rightCounter;
            object[] val_14 = new object[8];
            val_14[0] = "x";
            val_14[1] = 0.1f;
            val_14[2] = "y";
            val_14[3] = 0.1f;
            val_14[4] = "easeType";
            val_14[5] = 21;
            val_14[6] = "time";
            float val_15 = val_49 * 0.5f;
            val_14[7] = val_15;
            iTween.ScaleTo(target:  this.testimages[(long)val_2], args:  iTween.Hash(args:  val_14));
            object[] val_17 = new object[10];
            val_17[0] = "x";
            val_17[1] = 0.18f;
            val_17[2] = "y";
            val_17[3] = 0.18f;
            val_17[4] = "easeType";
            val_17[5] = 21;
            val_17[6] = "delay";
            val_17[7] = val_15;
            val_17[8] = "time";
            val_17[9] = val_15;
            iTween.ScaleTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_17));
            object[] val_19 = new object[8];
            val_19[0] = "x";
            val_19[1] = 0.18f;
            val_19[2] = "y";
            val_19[3] = 0.18f;
            val_19[4] = "easeType";
            val_19[5] = 21;
            val_19[6] = "time";
            val_19[7] = val_49;
            iTween.ScaleTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_19));
            object[] val_21 = new object[8];
            val_21[0] = "x";
            val_21[1] = 0.22f;
            val_21[2] = "y";
            val_21[3] = 0.22f;
            val_21[4] = "easeType";
            val_21[5] = 21;
            val_21[6] = "time";
            val_21[7] = val_49;
            iTween.ScaleTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_21));
            object[] val_23 = new object[10];
            val_23[0] = "x";
            val_23[1] = 0.15f;
            val_23[2] = "y";
            val_23[3] = 0.15f;
            val_23[4] = "easeType";
            val_23[5] = 21;
            val_23[6] = "delay";
            val_49 = val_49 + 0.2f;
            val_23[7] = val_49;
            val_23[8] = "time";
            val_23[9] = 0.2f;
            iTween.ScaleTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_23));
            object[] val_25 = new object[10];
            val_25[0] = "x";
            val_25[1] = 0.15f;
            val_25[2] = "y";
            val_25[3] = 0.15f;
            val_25[4] = "easeType";
            val_25[5] = 21;
            val_25[6] = "delay";
            val_25[7] = val_49;
            val_25[8] = "time";
            val_25[9] = 0.2f;
            iTween.ScaleTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_25));
            object[] val_27 = new object[10];
            val_54 = val_27;
            val_54[0] = "x";
            val_54[1] = 0.3f;
            val_54[2] = "y";
            val_54[3] = 0.3f;
            val_54[4] = "easeType";
            val_54[5] = 21;
            val_54[6] = "delay";
            val_54[7] = val_49;
            val_54[8] = "time";
            val_54[9] = 0.2f;
            iTween.ScaleTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_27));
            UnityEngine.Coroutine val_30 = this.StartCoroutine(routine:  this.ActivateForRoll());
            return;
        }
        
        UnityEngine.Vector3 val_32 = this.rollTargetRight.transform.position;
        val_51 = 1152921504623566848;
        val_8[1] = val_32.x;
        val_8[2] = "y";
        val_8[3] = val_8.Length;
        val_8[4] = "z";
        val_8[5] = 10;
        val_8[6] = "easeType";
        val_8[7] = 21;
        val_8[8] = "time";
        val_8[9] = val_49;
        iTween.MoveTo(target:  val_54, args:  iTween.Hash(args:  val_8));
        object[] val_34 = new object[10];
        val_34[0] = "x";
        UnityEngine.Vector3 val_36 = this.rollTargetLeft.transform.position;
        val_34[1] = val_36.x;
        val_34[2] = "y";
        val_34[3] = val_34.Length;
        val_34[4] = "z";
        val_34[5] = 10;
        val_34[6] = "easeType";
        val_34[7] = 21;
        val_34[8] = "time";
        val_34[9] = val_49;
        iTween.MoveTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_34));
        object[] val_38 = new object[10];
        val_38[0] = "x";
        val_38[1] = this.middlePostion;
        val_38[2] = "y";
        val_38[3] = val_38.Length;
        val_38[4] = "z";
        val_52 = "easeType";
        val_38[5] = 10;
        val_38[6] = "easeType";
        val_38[7] = 21;
        val_38[8] = "time";
        val_38[9] = val_49;
        iTween.MoveTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_38));
        this.rightCounter = val_2;
        this.leftCounter = this.middleCounter;
        this.middleCounter = this.rightCounter;
        object[] val_40 = new object[8];
        val_53 = "x";
        val_40[0] = "x";
        val_40[1] = 0.08f;
        val_40[2] = "y";
        val_40[3] = 0.08f;
        val_40[4] = "easeType";
        val_40[5] = 21;
        val_40[6] = "time";
        float val_41 = val_49 * 0.5f;
        val_40[7] = val_41;
        iTween.ScaleTo(target:  this.testimages[(long)val_2], args:  iTween.Hash(args:  val_40));
        object[] val_43 = new object[10];
        val_43[0] = "x";
        val_43[1] = 0.14f;
        val_43[2] = "y";
        val_43[3] = 0.14f;
        val_43[4] = "easeType";
        val_43[5] = 21;
        val_43[6] = "delay";
        val_43[7] = val_41;
        val_43[8] = "time";
        val_43[9] = val_41;
        iTween.ScaleTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_43));
        object[] val_45 = new object[8];
        val_45[0] = "x";
        val_45[1] = 0.14f;
        val_45[2] = "y";
        val_45[3] = 0.14f;
        val_45[4] = "easeType";
        val_45[5] = 21;
        val_45[6] = "time";
        val_45[7] = val_49;
        iTween.ScaleTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_45));
        val_50 = this.testimages[this.middleCounter];
        object[] val_47 = new object[8];
        val_47[0] = "x";
        val_47[1] = 0.22f;
        val_47[2] = "y";
        val_47[3] = 0.22f;
        val_47[4] = "easeType";
        val_47[5] = 21;
        val_47[6] = "time";
        val_54 = val_49;
        val_47[7] = val_54;
        iTween.ScaleTo(target:  val_50, args:  iTween.Hash(args:  val_47));
    }
    private System.Collections.IEnumerator ActivateForRoll()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new SelectStageController.<ActivateForRoll>d__35();
    }
    public void BuyButtonClicked()
    {
        var val_8;
        var val_9;
        val_8 = null;
        val_8 = null;
        int val_2 = GameInfo.stage.GetAllUniqueIds().Item[this.middleCounter];
        IAPItemIds val_3 = GameInfo.stage.GetIAPItemIds(uniqueId:  val_2);
        if(val_3 == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        UnityEngine.Debug.Log(message:  "Buy " + CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  GameInfo.stage.GetItemDataById(uniqueId:  val_2))(CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  GameInfo.stage.GetItemDataById(uniqueId:  val_2))));
        GGPPurchasingManager.instance.BuyProductID(iapItemIds:  val_3, callback:  0);
    }
    private StageShopIcon GetShopIconByNumberId(int id)
    {
        return (StageShopIcon)this.testimages[(long)id].GetComponent<StageShopIcon>();
    }
    private void OnPurchaseSuccess(IAPItemIds id)
    {
        var val_8;
        var val_9;
        id.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        UnityEngine.Debug.Log(message:  "OnPurchaseSuccess" + id.ToString());
        val_8 = null;
        val_8 = null;
        val_9 = null;
        val_9 = null;
        int val_8 = GameInfo.stage.GetAllUniqueIds().Item[this.middleCounter];
        val_8 = DataStructs.UserDataDictionary.Items.IsStageUnlock(id:  val_8);
        UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.LockStatus(isStageBought:  val_8));
    }
    public SelectStageController()
    {
        this.leftCounter = 10;
    }

}
