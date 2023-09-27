using UnityEngine;
public class Scene_IkaSelection : MonoBehaviour
{
    // Fields
    private int rightCounter;
    private int leftCounter;
    public UnityEngine.GameObject[] testimages;
    public UnityEngine.UI.Image middleIka;
    public UnityEngine.UI.Image leftIka;
    public UnityEngine.UI.Image rightIka;
    public UnityEngine.UI.Image rollTargetLeft;
    public UnityEngine.UI.Image rollTargetRight;
    private int middleCounter;
    public UnityEngine.GameObject nextButton;
    public UnityEngine.GameObject imageName;
    public UnityEngine.GameObject imageStats;
    public UnityEngine.GameObject iconHolder;
    public UnityEngine.Transform imageNameSource;
    public UnityEngine.Transform imageStatsSource;
    public UnityEngine.Transform iconHolderSource;
    public UnityEngine.Transform imageNameTarget;
    public UnityEngine.Transform imageStatsTarget;
    public UnityEngine.Transform iconHolderTarget;
    public UnityEngine.GameObject lockedImage;
    public UnityEngine.GameObject buyButtons;
    public UnityEngine.GameObject[] swipeButtons;
    public UnityEngine.GameObject backButton;
    private UnityEngine.Vector3 leftPostion;
    private UnityEngine.Vector3 middlePostion;
    private UnityEngine.Vector3 rightPostion;
    
    // Methods
    private void Start()
    {
        this.swipeButtons[0].SetActive(value:  false);
        this.swipeButtons[1].SetActive(value:  false);
        this.backButton.SetActive(value:  false);
        this.lockedImage.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.iconHolder.SetActive(value:  false);
        this.imageStats.SetActive(value:  false);
        this.imageName.SetActive(value:  false);
        UnityEngine.Vector3 val_3 = this.leftIka.transform.position;
        this.leftPostion = val_3;
        mem[1152921528761232908] = val_3.y;
        mem[1152921528761232912] = val_3.z;
        UnityEngine.Vector3 val_5 = this.middleIka.transform.position;
        this.middlePostion = val_5;
        mem[1152921528761232920] = val_5.y;
        mem[1152921528761232924] = val_5.z;
        UnityEngine.Vector3 val_7 = this.rightIka.transform.position;
        this.rightPostion = val_7;
        mem[1152921528761232932] = val_7.y;
        mem[1152921528761232936] = val_7.z;
        this.testimages[this.leftCounter].transform.position = new UnityEngine.Vector3() {x = this.leftPostion, y = V9.16B, z = V10.16B};
        this.testimages[this.middleCounter].transform.position = new UnityEngine.Vector3() {x = this.middlePostion, y = V9.16B, z = V10.16B};
        this.testimages[this.middleCounter].transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.testimages[this.leftCounter].transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.testimages[this.rightCounter].transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.nextButton.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.testimages[this.rightCounter].transform.position = new UnityEngine.Vector3() {x = this.rightPostion, y = V9.16B, z = V10.16B};
    }
    public void DarkenAtStart()
    {
        this.swipeButtons[0].SetActive(value:  true);
        this.swipeButtons[1].SetActive(value:  true);
        this.backButton.SetActive(value:  true);
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
                int val_3 = ((this.rightCounter + 1) == 14) ? 0 : (this.rightCounter + 1);
            this.testimages[(long)this.leftCounter].SetActive(value:  false);
            this.testimages[(long)val_3].SetActive(value:  true);
            object[] val_4 = new object[4];
            val_33 = "x";
            val_4[0] = "x";
            val_34 = 1152921504623566848;
            val_4[1] = this.rightPostion;
            val_4[2] = "time";
            val_4[3] = 0;
            iTween.MoveTo(target:  this.testimages[(long)val_3], args:  iTween.Hash(args:  val_4));
            object[] val_6 = new object[4];
            val_6[0] = "x";
            val_6[1] = this.leftPostion;
            val_6[2] = "time";
            val_6[3] = 0.5f;
            iTween.MoveTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_6));
            object[] val_8 = new object[4];
            val_8[0] = "x";
            val_8[1] = this.middlePostion;
            val_8[2] = "time";
            val_8[3] = 0.5f;
            iTween.MoveTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_8));
            this.rightCounter = val_3;
            this.leftCounter = this.middleCounter;
            this.middleCounter = this.rightCounter;
            object[] val_10 = new object[6];
            val_10[0] = "x";
            val_10[1] = 0.15f;
            val_35 = "y";
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
        
        int val_18 = (this.leftCounter == 0) ? 13 : (this.leftCounter - 1);
        this.testimages[(long)this.rightCounter].SetActive(value:  false);
        this.testimages[(long)val_18].SetActive(value:  true);
        object[] val_19 = new object[4];
        val_33 = "x";
        val_19[0] = "x";
        val_34 = 1152921504623566848;
        val_19[1] = this.leftPostion;
        val_19[2] = "time";
        val_19[3] = 0;
        iTween.MoveTo(target:  this.testimages[(long)val_18], args:  iTween.Hash(args:  val_19));
        object[] val_21 = new object[4];
        val_21[0] = "x";
        val_21[1] = this.middlePostion;
        val_21[2] = "time";
        val_21[3] = 0.5f;
        iTween.MoveTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_21));
        object[] val_23 = new object[4];
        val_23[0] = "x";
        val_23[1] = this.rightPostion;
        val_23[2] = "time";
        val_23[3] = 0.5f;
        iTween.MoveTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_23));
        this.rightCounter = this.middleCounter;
        this.leftCounter = val_18;
        this.middleCounter = this.leftCounter;
        object[] val_25 = new object[6];
        val_25[0] = "x";
        val_25[1] = 0.15f;
        val_35 = "y";
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
        float val_95;
        float val_96;
        UnityEngine.Color val_3 = this.testimages[this.middleCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_3.r != 1f)
        {
            goto label_6;
        }
        
        object[] val_4 = new object[4];
        val_4[0] = "position";
        UnityEngine.Vector3 val_5 = this.imageNameTarget.position;
        val_4[1] = val_5;
        val_4[2] = "time";
        val_4[3] = 0.2f;
        iTween.MoveTo(target:  this.imageName, args:  iTween.Hash(args:  val_4));
        object[] val_7 = new object[4];
        val_7[0] = "position";
        UnityEngine.Vector3 val_8 = this.imageStatsTarget.position;
        val_7[1] = val_8;
        val_7[2] = "time";
        val_7[3] = 0.2f;
        iTween.MoveTo(target:  this.imageStats, args:  iTween.Hash(args:  val_7));
        object[] val_10 = new object[4];
        val_10[0] = "position";
        UnityEngine.Vector3 val_11 = this.iconHolderTarget.position;
        val_10[1] = val_11;
        val_10[2] = "time";
        val_10[3] = 0.2f;
        iTween.MoveTo(target:  this.iconHolder, args:  iTween.Hash(args:  val_10));
        object[] val_13 = new object[6];
        val_13[0] = "x";
        val_13[1] = 0f;
        val_13[2] = "y";
        val_13[3] = 0f;
        val_13[4] = "time";
        val_13[5] = 0.05f;
        iTween.ScaleTo(target:  this.nextButton, args:  iTween.Hash(args:  val_13));
        UnityEngine.Color val_17 = this.testimages[this.rightCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_17.r != 0.8f)
        {
            goto label_75;
        }
        
        object[] val_18 = new object[8];
        val_18[0] = "position";
        UnityEngine.Vector3 val_19 = this.imageNameSource.position;
        val_18[1] = val_19;
        val_18[2] = "easeType";
        val_18[3] = 24;
        val_18[4] = "delay";
        val_18[5] = 0.3f;
        val_18[6] = "time";
        val_18[7] = 0.3f;
        iTween.MoveTo(target:  this.imageName, args:  iTween.Hash(args:  val_18));
        object[] val_21 = new object[8];
        val_21[0] = "position";
        UnityEngine.Vector3 val_22 = this.imageStatsSource.position;
        val_21[1] = val_22;
        val_21[2] = "easeType";
        val_21[3] = 24;
        val_21[4] = "delay";
        val_21[5] = 0.3f;
        val_21[6] = "time";
        val_21[7] = 0.3f;
        iTween.MoveTo(target:  this.imageStats, args:  iTween.Hash(args:  val_21));
        object[] val_24 = new object[8];
        val_24[0] = "position";
        UnityEngine.Vector3 val_25 = this.iconHolderSource.position;
        val_24[1] = val_25;
        val_24[2] = "easeType";
        val_24[3] = 24;
        val_24[4] = "delay";
        val_24[5] = 0.3f;
        val_24[6] = "time";
        val_24[7] = 0.3f;
        iTween.MoveTo(target:  this.iconHolder, args:  iTween.Hash(args:  val_24));
        object[] val_27 = new object[10];
        val_27[0] = "x";
        val_27[1] = 1f;
        val_27[2] = "y";
        val_27[3] = 1f;
        val_27[4] = "easeType";
        val_27[5] = 24;
        val_27[6] = "delay";
        val_27[7] = 0.4f;
        val_27[8] = "time";
        val_27[9] = 0.2f;
        iTween.ScaleTo(target:  this.nextButton, args:  iTween.Hash(args:  val_27));
        object[] val_29 = new object[6];
        val_29[0] = "x";
        val_29[1] = 0f;
        val_29[2] = "y";
        val_29[3] = 0f;
        val_29[4] = "time";
        val_29[5] = 0.2f;
        goto label_206;
        label_6:
        object[] val_30 = new object[6];
        val_30[0] = "x";
        val_30[1] = 0f;
        val_30[2] = "y";
        val_30[3] = 0f;
        val_30[4] = "time";
        val_30[5] = 0.2f;
        iTween.ScaleTo(target:  this.lockedImage, args:  iTween.Hash(args:  val_30));
        this.buyButtons.transform.GetChild(index:  this.middleCounter).gameObject.SetActive(value:  false);
        UnityEngine.Color val_37 = this.testimages[this.rightCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_37.r != 0.8f)
        {
            goto label_237;
        }
        
        object[] val_38 = new object[8];
        val_38[0] = "position";
        UnityEngine.Vector3 val_39 = this.imageNameSource.position;
        val_38[1] = val_39;
        val_38[2] = "easeType";
        val_38[3] = 24;
        val_38[4] = "delay";
        val_38[5] = 0.3f;
        val_38[6] = "time";
        val_38[7] = 0.3f;
        iTween.MoveTo(target:  this.imageName, args:  iTween.Hash(args:  val_38));
        object[] val_41 = new object[8];
        val_41[0] = "position";
        UnityEngine.Vector3 val_42 = this.imageStatsSource.position;
        val_41[1] = val_42;
        val_41[2] = "easeType";
        val_41[3] = 24;
        val_41[4] = "delay";
        val_41[5] = 0.3f;
        val_41[6] = "time";
        val_41[7] = 0.3f;
        iTween.MoveTo(target:  this.imageStats, args:  iTween.Hash(args:  val_41));
        object[] val_44 = new object[8];
        val_44[0] = "position";
        UnityEngine.Vector3 val_45 = this.iconHolderSource.position;
        val_44[1] = val_45;
        val_44[2] = "easeType";
        val_44[3] = 24;
        val_44[4] = "delay";
        val_44[5] = 0.3f;
        val_44[6] = "time";
        val_44[7] = 0.3f;
        iTween.MoveTo(target:  this.iconHolder, args:  iTween.Hash(args:  val_44));
        object[] val_47 = new object[10];
        val_47[0] = "x";
        val_47[1] = 1f;
        val_47[2] = "y";
        val_47[3] = 1f;
        val_47[4] = "easeType";
        val_47[5] = 24;
        val_47[6] = "delay";
        val_47[7] = 0.4f;
        val_47[8] = "time";
        val_47[9] = 0.2f;
        label_206:
        iTween.ScaleTo(target:  this.nextButton, args:  iTween.Hash(args:  val_47));
        goto label_349;
        label_75:
        this.lockedImage.transform.SetAsLastSibling();
        object[] val_50 = new object[10];
        val_50[0] = "x";
        val_50[1] = 1f;
        val_50[2] = "y";
        val_50[3] = 1f;
        val_50[4] = "easeType";
        val_50[5] = 24;
        val_50[6] = "delay";
        val_50[7] = 0.4f;
        val_50[8] = "time";
        val_50[9] = 0.2f;
        goto label_383;
        label_237:
        this.lockedImage.transform.SetAsLastSibling();
        object[] val_52 = new object[10];
        val_52[0] = "x";
        val_52[1] = 1f;
        val_52[2] = "y";
        val_52[3] = 1f;
        val_52[4] = "easeType";
        val_52[5] = 24;
        val_52[6] = "delay";
        val_52[7] = 0.4f;
        val_52[8] = "time";
        val_52[9] = 0.2f;
        label_383:
        iTween.ScaleTo(target:  this.lockedImage, args:  iTween.Hash(args:  val_52));
        this.buyButtons.transform.GetChild(index:  this.rightCounter).gameObject.SetActive(value:  true);
        label_349:
        var val_58 = ((this.rightCounter + 1) == 14) ? 0 : (this.rightCounter + 1);
        UnityEngine.Vector2 val_60 = new UnityEngine.Vector2(x:  this.leftPostion, y:  0.8f);
        UnityEngine.Vector3 val_61 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_60.x, y = val_60.y});
        this.testimages[(long)val_58].transform.position = new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z};
        UnityEngine.Vector2 val_63 = new UnityEngine.Vector2(x:  0.2f, y:  0.2f);
        UnityEngine.Vector3 val_64 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_63.x, y = val_63.y});
        val_95 = val_64.x;
        val_96 = val_64.z;
        this.testimages[(long)val_58].transform.localScale = new UnityEngine.Vector3() {x = val_95, y = val_64.y, z = val_96};
        this.testimages[this.leftCounter].SetActive(value:  false);
        this.testimages[(long)val_58].SetActive(value:  true);
        object[] val_65 = new object[6];
        val_65[0] = "x";
        val_65[1] = this.rightPostion;
        val_65[2] = "y";
        val_65[3] = val_65.Length;
        val_65[4] = "time";
        val_65[5] = 0.4f;
        iTween.MoveTo(target:  this.testimages[(long)val_58], args:  iTween.Hash(args:  val_65));
        object[] val_67 = new object[6];
        val_67[0] = "x";
        val_67[1] = this.leftPostion;
        val_67[2] = "y";
        val_67[3] = val_67.Length;
        val_67[4] = "time";
        val_67[5] = 0.4f;
        iTween.MoveTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_67));
        object[] val_69 = new object[6];
        val_69[0] = "x";
        val_69[1] = this.middlePostion;
        val_69[2] = "y";
        val_69[3] = val_69.Length;
        val_69[4] = "time";
        val_69[5] = 0.4f;
        iTween.MoveTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_69));
        this.leftCounter = this.middleCounter;
        this.middleCounter = this.rightCounter;
        mem2[0] = val_58;
        UnityEngine.Color val_73 = this.testimages[this.middleCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_73.r == 1f)
        {
                UnityEngine.Color val_76 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_95 = val_76.r;
            val_96 = val_76.b;
            this.testimages[this.leftCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_95, g = val_76.g, b = val_96, a = val_76.a};
        }
        
        UnityEngine.Color val_79 = this.testimages[this.middleCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_79.r == 0.8f)
        {
                UnityEngine.Color val_82 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_95 = val_82.r;
            val_96 = val_82.b;
            this.testimages[this.middleCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_95, g = val_82.g, b = val_96, a = val_82.a};
        }
        
        object[] val_83 = new object[8];
        val_83[0] = "x";
        val_83[1] = 0.19f;
        val_83[2] = "y";
        val_83[3] = 0.19f;
        val_83[4] = "easeType";
        val_83[5] = 21;
        val_83[6] = "time";
        val_83[7] = 0.3f;
        iTween.ScaleTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_83));
        object[] val_85 = new object[10];
        val_85[0] = "x";
        val_85[1] = 0.15f;
        val_85[2] = "y";
        val_85[3] = 0.15f;
        val_85[4] = "easeType";
        val_85[5] = 24;
        val_85[6] = "delay";
        val_85[7] = 0.3f;
        val_85[8] = "time";
        val_85[9] = 0.4f;
        iTween.ScaleTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_85));
        object[] val_87 = new object[8];
        val_87[0] = "x";
        val_87[1] = 0.19f;
        val_87[2] = "y";
        val_87[3] = 0.19f;
        val_87[4] = "easeType";
        val_87[5] = 21;
        val_87[6] = "time";
        val_87[7] = 0.3f;
        iTween.ScaleTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_87));
        object[] val_89 = new object[10];
        val_89[0] = "x";
        val_89[1] = 0.15f;
        val_89[2] = "y";
        val_89[3] = 0.15f;
        val_89[4] = "easeType";
        val_89[5] = 24;
        val_89[6] = "delay";
        val_89[7] = 0.3f;
        val_89[8] = "time";
        val_89[9] = 0.4f;
        iTween.ScaleTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_89));
        object[] val_91 = new object[8];
        val_91[0] = "x";
        val_91[1] = 0.23f;
        val_91[2] = "y";
        val_91[3] = 0.23f;
        val_91[4] = "easeType";
        val_91[5] = 21;
        val_91[6] = "time";
        val_91[7] = 0.3f;
        iTween.ScaleTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_91));
        object[] val_93 = new object[10];
        val_93[0] = "x";
        val_93[1] = 0.3f;
        val_93[2] = "y";
        val_93[3] = 0.3f;
        val_93[4] = "easeType";
        val_93[5] = 24;
        val_93[6] = "delay";
        val_93[7] = 0.3f;
        val_93[8] = "time";
        val_93[9] = 0.4f;
        iTween.ScaleTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_93));
    }
    public void rightSwipe()
    {
        float val_95;
        float val_96;
        UnityEngine.Color val_3 = this.testimages[this.middleCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_3.r != 1f)
        {
            goto label_6;
        }
        
        object[] val_4 = new object[4];
        val_4[0] = "position";
        UnityEngine.Vector3 val_5 = this.imageNameTarget.position;
        val_4[1] = val_5;
        val_4[2] = "time";
        val_4[3] = 0.2f;
        iTween.MoveTo(target:  this.imageName, args:  iTween.Hash(args:  val_4));
        object[] val_7 = new object[4];
        val_7[0] = "position";
        UnityEngine.Vector3 val_8 = this.imageStatsTarget.position;
        val_7[1] = val_8;
        val_7[2] = "time";
        val_7[3] = 0.2f;
        iTween.MoveTo(target:  this.imageStats, args:  iTween.Hash(args:  val_7));
        object[] val_10 = new object[4];
        val_10[0] = "position";
        UnityEngine.Vector3 val_11 = this.iconHolderTarget.position;
        val_10[1] = val_11;
        val_10[2] = "time";
        val_10[3] = 0.2f;
        iTween.MoveTo(target:  this.iconHolder, args:  iTween.Hash(args:  val_10));
        object[] val_13 = new object[6];
        val_13[0] = "x";
        val_13[1] = 0f;
        val_13[2] = "y";
        val_13[3] = 0f;
        val_13[4] = "time";
        val_13[5] = 0.05f;
        iTween.ScaleTo(target:  this.nextButton, args:  iTween.Hash(args:  val_13));
        UnityEngine.Color val_17 = this.testimages[this.leftCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_17.r != 0.8f)
        {
            goto label_75;
        }
        
        object[] val_18 = new object[8];
        val_18[0] = "position";
        UnityEngine.Vector3 val_19 = this.imageNameSource.position;
        val_18[1] = val_19;
        val_18[2] = "easeType";
        val_18[3] = 24;
        val_18[4] = "delay";
        val_18[5] = 0.3f;
        val_18[6] = "time";
        val_18[7] = 0.3f;
        iTween.MoveTo(target:  this.imageName, args:  iTween.Hash(args:  val_18));
        object[] val_21 = new object[8];
        val_21[0] = "position";
        UnityEngine.Vector3 val_22 = this.imageStatsSource.position;
        val_21[1] = val_22;
        val_21[2] = "easeType";
        val_21[3] = 24;
        val_21[4] = "delay";
        val_21[5] = 0.3f;
        val_21[6] = "time";
        val_21[7] = 0.3f;
        iTween.MoveTo(target:  this.imageStats, args:  iTween.Hash(args:  val_21));
        object[] val_24 = new object[8];
        val_24[0] = "position";
        UnityEngine.Vector3 val_25 = this.iconHolderSource.position;
        val_24[1] = val_25;
        val_24[2] = "easeType";
        val_24[3] = 24;
        val_24[4] = "delay";
        val_24[5] = 0.3f;
        val_24[6] = "time";
        val_24[7] = 0.3f;
        iTween.MoveTo(target:  this.iconHolder, args:  iTween.Hash(args:  val_24));
        object[] val_27 = new object[10];
        val_27[0] = "x";
        val_27[1] = 1f;
        val_27[2] = "y";
        val_27[3] = 1f;
        val_27[4] = "easeType";
        val_27[5] = 24;
        val_27[6] = "delay";
        val_27[7] = 0.4f;
        val_27[8] = "time";
        val_27[9] = 0.2f;
        iTween.ScaleTo(target:  this.nextButton, args:  iTween.Hash(args:  val_27));
        object[] val_29 = new object[6];
        val_29[0] = "x";
        val_29[1] = 0f;
        val_29[2] = "y";
        val_29[3] = 0f;
        val_29[4] = "time";
        val_29[5] = 0.2f;
        goto label_206;
        label_6:
        object[] val_30 = new object[6];
        val_30[0] = "x";
        val_30[1] = 0f;
        val_30[2] = "y";
        val_30[3] = 0f;
        val_30[4] = "time";
        val_30[5] = 0.2f;
        iTween.ScaleTo(target:  this.lockedImage, args:  iTween.Hash(args:  val_30));
        this.buyButtons.transform.GetChild(index:  this.middleCounter).gameObject.SetActive(value:  false);
        UnityEngine.Color val_37 = this.testimages[this.leftCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_37.r != 0.8f)
        {
            goto label_237;
        }
        
        object[] val_38 = new object[8];
        val_38[0] = "position";
        UnityEngine.Vector3 val_39 = this.imageNameSource.position;
        val_38[1] = val_39;
        val_38[2] = "easeType";
        val_38[3] = 24;
        val_38[4] = "delay";
        val_38[5] = 0.3f;
        val_38[6] = "time";
        val_38[7] = 0.3f;
        iTween.MoveTo(target:  this.imageName, args:  iTween.Hash(args:  val_38));
        object[] val_41 = new object[8];
        val_41[0] = "position";
        UnityEngine.Vector3 val_42 = this.imageStatsSource.position;
        val_41[1] = val_42;
        val_41[2] = "easeType";
        val_41[3] = 24;
        val_41[4] = "delay";
        val_41[5] = 0.3f;
        val_41[6] = "time";
        val_41[7] = 0.3f;
        iTween.MoveTo(target:  this.imageStats, args:  iTween.Hash(args:  val_41));
        object[] val_44 = new object[8];
        val_44[0] = "position";
        UnityEngine.Vector3 val_45 = this.iconHolderSource.position;
        val_44[1] = val_45;
        val_44[2] = "easeType";
        val_44[3] = 24;
        val_44[4] = "delay";
        val_44[5] = 0.3f;
        val_44[6] = "time";
        val_44[7] = 0.3f;
        iTween.MoveTo(target:  this.iconHolder, args:  iTween.Hash(args:  val_44));
        object[] val_47 = new object[10];
        val_47[0] = "x";
        val_47[1] = 1f;
        val_47[2] = "y";
        val_47[3] = 1f;
        val_47[4] = "easeType";
        val_47[5] = 24;
        val_47[6] = "delay";
        val_47[7] = 0.4f;
        val_47[8] = "time";
        val_47[9] = 0.2f;
        label_206:
        iTween.ScaleTo(target:  this.nextButton, args:  iTween.Hash(args:  val_47));
        goto label_349;
        label_75:
        this.lockedImage.transform.SetAsLastSibling();
        object[] val_50 = new object[10];
        val_50[0] = "x";
        val_50[1] = 1f;
        val_50[2] = "y";
        val_50[3] = 1f;
        val_50[4] = "easeType";
        val_50[5] = 24;
        val_50[6] = "delay";
        val_50[7] = 0.4f;
        val_50[8] = "time";
        goto label_380;
        label_237:
        this.lockedImage.transform.SetAsLastSibling();
        object[] val_52 = new object[10];
        val_52[0] = "x";
        val_52[1] = 1f;
        val_52[2] = "y";
        val_52[3] = 1f;
        val_52[4] = "easeType";
        val_52[5] = 24;
        val_52[6] = "delay";
        val_52[7] = 0.4f;
        val_52[8] = "time";
        label_380:
        val_52[9] = 0.2f;
        iTween.ScaleTo(target:  this.lockedImage, args:  iTween.Hash(args:  val_52));
        this.buyButtons.transform.GetChild(index:  this.leftCounter).gameObject.SetActive(value:  true);
        label_349:
        var val_58 = (this.leftCounter == 0) ? 13 : (this.leftCounter - 1);
        UnityEngine.Vector2 val_60 = new UnityEngine.Vector2(x:  this.rightPostion, y:  0.8f);
        UnityEngine.Vector3 val_61 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_60.x, y = val_60.y});
        this.testimages[(long)val_58].transform.position = new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z};
        UnityEngine.Vector2 val_63 = new UnityEngine.Vector2(x:  0.2f, y:  0.2f);
        UnityEngine.Vector3 val_64 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_63.x, y = val_63.y});
        val_95 = val_64.x;
        val_96 = val_64.z;
        this.testimages[(long)val_58].transform.localScale = new UnityEngine.Vector3() {x = val_95, y = val_64.y, z = val_96};
        this.testimages[this.rightCounter].SetActive(value:  false);
        this.testimages[(long)val_58].SetActive(value:  true);
        object[] val_65 = new object[6];
        val_65[0] = "x";
        val_65[1] = this.leftPostion;
        val_65[2] = "y";
        val_65[3] = val_65.Length;
        val_65[4] = "time";
        val_65[5] = 0.4f;
        iTween.MoveTo(target:  this.testimages[(long)val_58], args:  iTween.Hash(args:  val_65));
        object[] val_67 = new object[6];
        val_67[0] = "x";
        val_67[1] = this.middlePostion;
        val_67[2] = "y";
        val_67[3] = val_67.Length;
        val_67[4] = "time";
        val_67[5] = 0.4f;
        iTween.MoveTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_67));
        object[] val_69 = new object[6];
        val_69[0] = "x";
        val_69[1] = this.rightPostion;
        val_69[2] = "y";
        val_69[3] = val_69.Length;
        val_69[4] = "time";
        val_69[5] = 0.4f;
        iTween.MoveTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_69));
        this.rightCounter = this.middleCounter;
        this.middleCounter = this.leftCounter;
        mem2[0] = val_58;
        UnityEngine.Color val_73 = this.testimages[this.middleCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_73.r == 1f)
        {
                UnityEngine.Color val_76 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_95 = val_76.r;
            val_96 = val_76.b;
            this.testimages[this.rightCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_95, g = val_76.g, b = val_96, a = val_76.a};
        }
        
        UnityEngine.Color val_79 = this.testimages[this.middleCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color;
        if(val_79.r == 0.8f)
        {
                UnityEngine.Color val_82 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_95 = val_82.r;
            val_96 = val_82.b;
            this.testimages[this.middleCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_95, g = val_82.g, b = val_96, a = val_82.a};
        }
        
        object[] val_83 = new object[8];
        val_83[0] = "x";
        val_83[1] = 0.19f;
        val_83[2] = "y";
        val_83[3] = 0.19f;
        val_83[4] = "easeType";
        val_83[5] = 21;
        val_83[6] = "time";
        val_83[7] = 0.3f;
        iTween.ScaleTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_83));
        object[] val_85 = new object[10];
        val_85[0] = "x";
        val_85[1] = 0.15f;
        val_85[2] = "y";
        val_85[3] = 0.15f;
        val_85[4] = "easeType";
        val_85[5] = 24;
        val_85[6] = "delay";
        val_85[7] = 0.3f;
        val_85[8] = "time";
        val_85[9] = 0.4f;
        iTween.ScaleTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_85));
        object[] val_87 = new object[8];
        val_87[0] = "x";
        val_87[1] = 0.19f;
        val_87[2] = "y";
        val_87[3] = 0.19f;
        val_87[4] = "easeType";
        val_87[5] = 21;
        val_87[6] = "time";
        val_87[7] = 0.3f;
        iTween.ScaleTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_87));
        object[] val_89 = new object[10];
        val_89[0] = "x";
        val_89[1] = 0.15f;
        val_89[2] = "y";
        val_89[3] = 0.15f;
        val_89[4] = "easeType";
        val_89[5] = 24;
        val_89[6] = "delay";
        val_89[7] = 0.3f;
        val_89[8] = "time";
        val_89[9] = 0.4f;
        iTween.ScaleTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_89));
        object[] val_91 = new object[8];
        val_91[0] = "x";
        val_91[1] = 0.23f;
        val_91[2] = "y";
        val_91[3] = 0.23f;
        val_91[4] = "easeType";
        val_91[5] = 21;
        val_91[6] = "time";
        val_91[7] = 0.3f;
        iTween.ScaleTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_91));
        object[] val_93 = new object[10];
        val_93[0] = "x";
        val_93[1] = 0.3f;
        val_93[2] = "y";
        val_93[3] = 0.3f;
        val_93[4] = "easeType";
        val_93[5] = 24;
        val_93[6] = "delay";
        val_93[7] = 0.3f;
        val_93[8] = "time";
        val_93[9] = 0.4f;
        iTween.ScaleTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_93));
    }
    public void UnlockCharacter()
    {
        UnityEngine.Color val_3 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.testimages[this.middleCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        object[] val_4 = new object[6];
        val_4[0] = "x";
        val_4[1] = 0f;
        val_4[2] = "y";
        val_4[3] = 0f;
        val_4[4] = "time";
        val_4[5] = 0.2f;
        iTween.ScaleTo(target:  this.lockedImage, args:  iTween.Hash(args:  val_4));
        this.buyButtons.transform.GetChild(index:  this.middleCounter).gameObject.SetActive(value:  false);
        object[] val_9 = new object[10];
        val_9[0] = "x";
        val_9[1] = 1f;
        val_9[2] = "y";
        val_9[3] = 1f;
        val_9[4] = "easeType";
        val_9[5] = 24;
        val_9[6] = "delay";
        val_9[7] = 0.4f;
        val_9[8] = "time";
        val_9[9] = 0.2f;
        iTween.ScaleTo(target:  this.nextButton, args:  iTween.Hash(args:  val_9));
    }
    private void rollTemp()
    {
    
    }
    public void StartRoll(float rollTime)
    {
        float val_51;
        UnityEngine.GameObject val_52;
        var val_53;
        var val_54;
        var val_55;
        System.Object[] val_56;
        val_51 = rollTime;
        val_52 = this;
        int val_2 = ((this.rightCounter + 1) == 14) ? 0 : (this.rightCounter + 1);
        this.testimages[(long)val_2].transform.position = new UnityEngine.Vector3() {x = this.leftPostion, y = V10.16B, z = V11.16B};
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  0.14f, y:  0.14f);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
        this.testimages[(long)val_2].transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        this.testimages[this.leftCounter].SetActive(value:  false);
        this.testimages[(long)val_2].SetActive(value:  true);
        this.testimages[this.rightCounter].transform.SetAsLastSibling();
        UnityEngine.GameObject val_56 = this.testimages[(long)val_2];
        object[] val_8 = new object[8];
        val_8[0] = "x";
        if(val_2 == 1)
        {
                val_54 = 1152921504623566848;
            val_53 = "x";
            val_8[1] = this.rightPostion;
            val_55 = "y";
            val_8[2] = "y";
            val_8[3] = val_8.Length;
            val_8[4] = "easeType";
            val_8[5] = 21;
            val_8[6] = "time";
            val_8[7] = val_51;
            iTween.MoveTo(target:  val_56, args:  iTween.Hash(args:  val_8));
            object[] val_10 = new object[8];
            val_10[0] = "x";
            val_10[1] = this.leftPostion;
            val_10[2] = "y";
            val_10[3] = val_10.Length;
            val_10[4] = "easeType";
            val_10[5] = 21;
            val_10[6] = "time";
            val_10[7] = val_51;
            iTween.MoveTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_10));
            object[] val_12 = new object[8];
            val_12[0] = "x";
            val_12[1] = this.middlePostion;
            val_12[2] = "y";
            val_12[3] = val_12.Length;
            val_12[4] = "easeType";
            val_12[5] = 21;
            val_12[6] = "time";
            val_12[7] = val_51;
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
            float val_15 = val_51 * 0.5f;
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
            val_19[7] = val_51;
            iTween.ScaleTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_19));
            object[] val_21 = new object[8];
            val_21[0] = "x";
            val_21[1] = 0.22f;
            val_21[2] = "y";
            val_21[3] = 0.22f;
            val_21[4] = "easeType";
            val_21[5] = 21;
            val_21[6] = "time";
            val_21[7] = val_51;
            iTween.ScaleTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_21));
            object[] val_23 = new object[10];
            val_23[0] = "x";
            val_23[1] = 0.15f;
            val_23[2] = "y";
            val_23[3] = 0.15f;
            val_23[4] = "easeType";
            val_23[5] = 21;
            val_23[6] = "delay";
            val_51 = val_51 + 0.2f;
            val_23[7] = val_51;
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
            val_25[7] = val_51;
            val_25[8] = "time";
            val_25[9] = 0.2f;
            iTween.ScaleTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_25));
            object[] val_27 = new object[10];
            val_27[0] = "x";
            val_27[1] = 0.3f;
            val_27[2] = "y";
            val_27[3] = 0.3f;
            val_27[4] = "easeType";
            val_27[5] = 21;
            val_27[6] = "delay";
            val_27[7] = val_51;
            val_27[8] = "time";
            val_27[9] = 0.2f;
            iTween.ScaleTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_27));
            object[] val_29 = new object[10];
            val_56 = val_29;
            val_56[0] = "x";
            val_56[1] = 1f;
            val_56[2] = "y";
            val_56[3] = 1f;
            val_56[4] = "easeType";
            val_56[5] = 21;
            val_56[6] = "delay";
            val_56[7] = val_51;
            val_56[8] = "time";
            val_56[9] = 0.2f;
            iTween.ScaleTo(target:  this.nextButton, args:  iTween.Hash(args:  val_29));
            UnityEngine.Coroutine val_32 = this.StartCoroutine(routine:  this.ActivateForRoll());
            return;
        }
        
        UnityEngine.Vector3 val_34 = this.rollTargetRight.transform.position;
        val_54 = 1152921504623566848;
        val_8[1] = val_34.x;
        val_8[2] = "y";
        val_8[3] = val_8.Length;
        val_55 = "easeType";
        val_8[4] = "easeType";
        val_8[5] = 21;
        val_8[6] = "time";
        val_8[7] = val_51;
        iTween.MoveTo(target:  val_56, args:  iTween.Hash(args:  val_8));
        object[] val_36 = new object[8];
        val_36[0] = "x";
        UnityEngine.Vector3 val_38 = this.rollTargetLeft.transform.position;
        val_36[1] = val_38.x;
        val_36[2] = "y";
        val_36[3] = val_36.Length;
        val_36[4] = "easeType";
        val_36[5] = 21;
        val_36[6] = "time";
        val_36[7] = val_51;
        iTween.MoveTo(target:  this.testimages[this.middleCounter], args:  iTween.Hash(args:  val_36));
        object[] val_40 = new object[8];
        val_40[0] = "x";
        val_40[1] = this.middlePostion;
        val_40[2] = "y";
        val_40[3] = val_40.Length;
        val_40[4] = "easeType";
        val_40[5] = 21;
        val_40[6] = "time";
        val_40[7] = val_51;
        iTween.MoveTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_40));
        this.rightCounter = val_2;
        this.leftCounter = this.middleCounter;
        this.middleCounter = this.rightCounter;
        object[] val_42 = new object[8];
        val_42[0] = "x";
        val_42[1] = 0.08f;
        val_42[2] = "y";
        val_42[3] = 0.08f;
        val_42[4] = "easeType";
        val_42[5] = 21;
        val_42[6] = "time";
        float val_43 = val_51 * 0.5f;
        val_42[7] = val_43;
        iTween.ScaleTo(target:  this.testimages[(long)val_2], args:  iTween.Hash(args:  val_42));
        object[] val_45 = new object[10];
        val_45[0] = "x";
        val_45[1] = 0.14f;
        val_45[2] = "y";
        val_45[3] = 0.14f;
        val_45[4] = "easeType";
        val_45[5] = 21;
        val_45[6] = "delay";
        val_45[7] = val_43;
        val_45[8] = "time";
        val_45[9] = val_43;
        iTween.ScaleTo(target:  this.testimages[this.rightCounter], args:  iTween.Hash(args:  val_45));
        object[] val_47 = new object[8];
        val_47[0] = "x";
        val_47[1] = 0.14f;
        val_47[2] = "y";
        val_47[3] = 0.14f;
        val_47[4] = "easeType";
        val_47[5] = 21;
        val_47[6] = "time";
        val_47[7] = val_51;
        iTween.ScaleTo(target:  this.testimages[this.leftCounter], args:  iTween.Hash(args:  val_47));
        val_52 = this.testimages[this.middleCounter];
        object[] val_49 = new object[8];
        val_49[0] = "x";
        val_49[1] = 0.22f;
        val_49[2] = "y";
        val_49[3] = 0.22f;
        val_49[4] = "easeType";
        val_49[5] = 21;
        val_49[6] = "time";
        val_56 = val_51;
        val_49[7] = val_56;
        iTween.ScaleTo(target:  val_52, args:  iTween.Hash(args:  val_49));
    }
    private System.Collections.IEnumerator ActivateForRoll()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new Scene_IkaSelection.<ActivateForRoll>d__34();
    }
    public void ActiveNameTag()
    {
        this.iconHolder.SetActive(value:  true);
        this.imageStats.SetActive(value:  true);
        this.imageName.SetActive(value:  true);
    }
    public void BuyButtonClick(int index)
    {
        GGPPurchasingManager.instance.BuyProductID(skuIndex:  index);
    }
    public void OnFacebookLikeButtonClick()
    {
    
    }
    public Scene_IkaSelection()
    {
        this.rightCounter = 1;
        this.leftCounter = 13;
    }

}
