using UnityEngine;
public class Credits : MonoBehaviour
{
    // Fields
    public static string nextScene;
    public UnityEngine.AudioClip Audio_BGM;
    public UnityEngine.Canvas Canvas_Credits;
    public UnityEngine.UI.Image Image_InkWars;
    public UnityEngine.GameObject Template_Heading;
    public UnityEngine.GameObject Template_Normal;
    public UnityEngine.GameObject Template_Extra;
    public UnityEngine.GameObject Template_Image;
    public UnityEngine.Sprite[] Sprite_Images;
    private Credits.CreditRef[] CreditsText;
    private float spacing_Heading;
    private float spacing_Normal;
    private float spacing_ExtraComment;
    private float OffsetX;
    private float IndentY;
    
    // Methods
    private void CreateCreditText()
    {
        CreditRef[] val_1 = new CreditRef[93];
        Credits.CreditRef val_3 = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading1");
        .Style = 0;
        if(val_1 == null)
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
        val_1[0] = val_3;
        .Text = "Steven “TakoGG” Wu";
        .Style = 1;
        val_1[1] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading2");
        .Style = 0;
        val_1[2] = new Credits.CreditRef();
        .Text = "Steven “TakoGG” Wu";
        .Style = 1;
        val_1[3] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading3");
        .Style = 0;
        val_1[4] = new Credits.CreditRef();
        .Text = "Steven “TakoGG” Wu";
        .Style = 1;
        val_1[5] = new Credits.CreditRef();
        .Text = "YiDing Liu (Co-manager)";
        .Style = 1;
        val_1[6] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading4");
        .Style = 0;
        val_1[7] = new Credits.CreditRef();
        .Text = "YiDing Liu";
        .Style = 1;
        val_1[8] = new Credits.CreditRef();
        .Text = "Erik Hogan";
        .Style = 1;
        val_1[9] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading5");
        .Style = 0;
        val_1[10] = new Credits.CreditRef();
        .Text = "Callan Moore";
        .Style = 1;
        val_1[11] = new Credits.CreditRef();
        .Text = "Juan Rodriguez";
        .Style = 1;
        val_1[12] = new Credits.CreditRef();
        .Text = "Damith Nishshanka";
        .Style = 1;
        val_1[13] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading6");
        .Style = 0;
        val_1[14] = new Credits.CreditRef();
        .Text = "Sean Zeng";
        .Style = 1;
        val_1[15] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading7");
        .Style = 0;
        val_1[16] = new Credits.CreditRef();
        .Text = "Steven “TakoGG” Wu";
        .Style = 1;
        val_1[17] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading8");
        .Style = 0;
        val_1[18] = new Credits.CreditRef();
        .Text = "Simon Adams";
        .Style = 1;
        val_1[19] = new Credits.CreditRef();
        .Text = "Akari Wu";
        .Style = 1;
        val_1[20] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading9");
        .Style = 0;
        val_1[21] = new Credits.CreditRef();
        .Text = "Simon Adams (Original characters)";
        .Style = 1;
        val_1[22] = new Credits.CreditRef();
        .Text = "Momoko Taylor (Celebrity guest characters)";
        .Style = 1;
        val_1[23] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading10");
        .Style = 0;
        val_1[24] = new Credits.CreditRef();
        .Text = "Momoko Taylor";
        .Style = 1;
        val_1[25] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading11");
        .Style = 0;
        val_1[26] = new Credits.CreditRef();
        .Text = "Barry Davis ";
        .Style = 1;
        val_1[27] = new Credits.CreditRef();
        .Text = "Cynthia Zhao";
        .Style = 1;
        val_1[28] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading12");
        .Style = 0;
        val_1[29] = new Credits.CreditRef();
        .Text = "Barry Davis ";
        .Style = 1;
        val_1[30] = new Credits.CreditRef();
        .Text = "Cynthia Zhao";
        .Style = 1;
        val_1[31] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading13");
        .Style = 0;
        val_1[32] = new Credits.CreditRef();
        .Text = "Juane Gray-Higgins";
        .Style = 1;
        val_1[33] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading14");
        .Style = 0;
        val_1[34] = new Credits.CreditRef();
        .Text = "Eachen Chen";
        .Style = 1;
        val_1[35] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading15");
        .Style = 0;
        val_1[36] = new Credits.CreditRef();
        .Text = "Barry Davis";
        .Style = 1;
        val_1[37] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading16");
        .Style = 0;
        val_1[38] = new Credits.CreditRef();
        .Text = "Steven “TakoGG” Wu";
        .Style = 1;
        val_1[39] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading17");
        .Style = 0;
        val_1[40] = new Credits.CreditRef();
        .Text = "Steven “TakoGG” Wu";
        .Style = 1;
        val_1[41] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading18");
        .Style = 0;
        val_1[42] = new Credits.CreditRef();
        .Text = "Joshua Taylor";
        .Style = 1;
        val_1[43] = new Credits.CreditRef();
        .Text = "Amy Taylor";
        .Style = 1;
        val_1[44] = new Credits.CreditRef();
        .Text = "Anton Kumar";
        .Style = 1;
        val_1[45] = new Credits.CreditRef();
        .Text = "Thomas Williams";
        .Style = 1;
        val_1[46] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading19");
        .Style = 0;
        val_1[47] = new Credits.CreditRef();
        .Text = "France “Senya” Audon";
        .Style = 1;
        val_1[48] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading20");
        .Style = 0;
        val_1[49] = new Credits.CreditRef();
        .Text = "Masato Sugane";
        .Style = 1;
        val_1[50] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading21");
        .Style = 0;
        val_1[51] = new Credits.CreditRef();
        .Text = "Mystical Night";
        .Style = 1;
        val_1[52] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading22");
        .Style = 0;
        val_1[53] = new Credits.CreditRef();
        .Text = "Simon Adams";
        .Style = 1;
        val_1[54] = new Credits.CreditRef();
        .Text = "Barry Davis";
        .Style = 1;
        val_1[55] = new Credits.CreditRef();
        .Text = "Steven “TakoGG” Wu";
        .Style = 1;
        val_1[56] = new Credits.CreditRef();
        .Text = "Akari Wu";
        .Style = 1;
        val_1[57] = new Credits.CreditRef();
        .Text = "Amy Taylor";
        .Style = 1;
        val_1[58] = new Credits.CreditRef();
        .Text = "Shane Taylor";
        .Style = 1;
        val_1[59] = new Credits.CreditRef();
        .Text = "Simon So";
        .Style = 1;
        val_1[60] = new Credits.CreditRef();
        .Text = "Hungwei Chuang";
        .Style = 1;
        val_1[61] = new Credits.CreditRef();
        .Text = "Corey Mohammed ";
        .Style = 1;
        val_1[62] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading23");
        .Style = 1;
        val_1[63] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading24");
        .Style = 0;
        val_1[64] = new Credits.CreditRef();
        .Text = "Justin Wong";
        .Style = 1;
        val_1[65] = new Credits.CreditRef();
        .Text = "Mark “Super Samoan” Hunt";
        .Style = 1;
        val_1[66] = new Credits.CreditRef();
        .Text = "Bryant “Smug” Huggins";
        .Style = 1;
        val_1[67] = new Credits.CreditRef();
        .Text = "Martin “MaRN” Phan";
        .Style = 1;
        val_1[68] = new Credits.CreditRef();
        .Text = "Leah “Gllty” Hayes";
        .Style = 1;
        val_1[69] = new Credits.CreditRef();
        .Text = "Ryan Joseph Hart";
        .Style = 1;
        val_1[70] = new Credits.CreditRef();
        .Text = "Lorien “Loriipops” Gugich";
        .Style = 1;
        val_1[71] = new Credits.CreditRef();
        .Text = "S J “Get Vindictive” Valenz";
        .Style = 1;
        val_1[72] = new Credits.CreditRef();
        .Text = "Leahviathan";
        .Style = 1;
        val_1[73] = new Credits.CreditRef();
        .Text = "Monica “Nixia” Carolina";
        .Style = 1;
        val_1[74] = new Credits.CreditRef();
        .Text = "Jamie Curry";
        .Style = 1;
        val_1[75] = new Credits.CreditRef();
        .Text = "Brandee Anthony";
        .Style = 1;
        val_1[76] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading25");
        .Style = 0;
        val_1[77] = new Credits.CreditRef();
        .Text = "Steven “TakoGG” Wu";
        .Style = 1;
        val_1[78] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading26");
        .Style = 0;
        val_1[79] = new Credits.CreditRef();
        .Text = "Shelley Robertson";
        .Style = 1;
        val_1[80] = new Credits.CreditRef();
        .Text = "Yahya Almasri";
        .Style = 1;
        val_1[81] = new Credits.CreditRef();
        .Text = "Feras Musmar";
        .Style = 1;
        val_1[82] = new Credits.CreditRef();
        .Text = "Lill Beate ";
        .Style = 1;
        val_1[83] = new Credits.CreditRef();
        .Text = "Francis Kolbjornsen";
        .Style = 1;
        val_1[84] = new Credits.CreditRef();
        .Text = "Stephen Knightly";
        .Style = 1;
        val_1[85] = new Credits.CreditRef();
        .Text = "Seong Oh";
        .Style = 1;
        val_1[86] = new Credits.CreditRef();
        .Text = "Kingston Harrop";
        .Style = 1;
        val_1[87] = new Credits.CreditRef();
        .Text = "Ethan Byrne";
        .Style = 1;
        val_1[88] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading27");
        .Style = 2;
        val_1[89] = new Credits.CreditRef();
        .Text = "INK WARS";
        .Style = 2;
        val_1[90] = new Credits.CreditRef();
        .Text = LanguageManager.GetText(key:  "LK.Credits.Heading28");
        .Style = 2;
        val_1[91] = new Credits.CreditRef();
        .Text = "www.inkwarsgame.com";
        .Style = 2;
        val_1[92] = new Credits.CreditRef();
        this.CreditsText = val_1;
    }
    private void Start()
    {
        float val_33;
        var val_34;
        float val_35;
        float val_36;
        UnityEngine.GameObject val_37;
        var val_38;
        var val_40;
        float val_41;
        float val_42;
        float val_43;
        float val_45;
        this.CreateCreditText();
        GameAudio.SwitchMusicOneShot(clip:  this.Audio_BGM, forcePlay:  false);
        UnityEngine.Rect val_2 = this.GetComponent<UnityEngine.RectTransform>().rect;
        val_33 = -0.5f;
        float val_3 = val_2.m_XMin * val_33;
        val_34 = 0;
        val_35 = val_3;
        goto label_4;
        label_21:
        CreditRef val_32 = this.CreditsText[0];
        if(this.CreditsText[0x0][0].Style == 2)
        {
            goto label_7;
        }
        
        if(this.CreditsText[0x0][0].Style != 0)
        {
            goto label_8;
        }
        
        val_36 = this.spacing_Heading;
        val_37 = this.Template_Heading;
        goto label_10;
        label_7:
        val_36 = this.spacing_ExtraComment;
        val_37 = this.Template_Extra;
        goto label_10;
        label_8:
        val_36 = this.spacing_Normal;
        val_37 = this.Template_Normal;
        label_10:
        val_35 = val_35 - val_36;
        UnityEngine.GameObject val_6 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_37, parent:  this.transform).gameObject;
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_33 = val_8.y;
        val_6.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_8.x, y = val_33};
        val_38 = val_6.GetComponent<TMPro.TextMeshProUGUI>();
        val_38.text = this.CreditsText[0x0][0].Text;
        val_34 = 1;
        label_4:
        if(val_34 < this.CreditsText.Length)
        {
            goto label_21;
        }
        
        UnityEngine.Vector2 val_11 = this.Canvas_Credits.GetComponent<UnityEngine.RectTransform>().sizeDelta;
        float val_12 = val_11.y * 0.5f;
        val_12 = val_12 - val_35;
        float val_33 = System.Math.Abs(val_35);
        val_35 = val_12 + 100f;
        float val_34 = -2f;
        val_34 = this.IndentY * val_34;
        val_34 = val_33 + val_34;
        val_40 = 0;
        val_33 = val_34 / ((float)UnityEngine.Mathf.Max(a:  this.Sprite_Images.Length, b:  1));
        val_41 = val_3 - this.IndentY;
        goto label_27;
        label_47:
        UnityEngine.GameObject val_15 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.Template_Image, parent:  this.transform);
        if(val_15 != null)
        {
                val_15.SetActive(value:  true);
        }
        else
        {
                val_15.SetActive(value:  true);
        }
        
        val_15.GetComponent<UnityEngine.UI.Image>().sprite = this.Sprite_Images[0];
        val_38 = val_15.GetComponent<UnityEngine.RectTransform>();
        if((val_40 & 1) == 0)
        {
            goto label_35;
        }
        
        UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  0f, y:  0.5f);
        if(val_38 == null)
        {
            goto label_36;
        }
        
        val_38.anchorMin = new UnityEngine.Vector2() {x = val_18.x, y = val_18.y};
        val_42 = 0.5f;
        UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  0f, y:  val_42);
        goto label_37;
        label_35:
        UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  1f, y:  0.5f);
        if(val_38 == null)
        {
            goto label_38;
        }
        
        val_38.anchorMin = new UnityEngine.Vector2() {x = val_20.x, y = val_20.y};
        val_43 = 0.5f;
        UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  1f, y:  val_43);
        goto label_39;
        label_36:
        val_38.anchorMin = new UnityEngine.Vector2() {x = val_20.x, y = val_20.y};
        val_42 = 0.5f;
        UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  0f, y:  val_42);
        label_37:
        val_38.anchorMax = new UnityEngine.Vector2() {x = val_22.x, y = val_22.y};
        goto label_40;
        label_38:
        val_38.anchorMin = new UnityEngine.Vector2() {x = val_20.x, y = val_20.y};
        val_43 = 0.5f;
        UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  1f, y:  val_43);
        label_39:
        val_38.anchorMax = new UnityEngine.Vector2() {x = val_23.x, y = val_23.y};
        UnityEngine.Vector2 val_24;
        label_40:
        val_24 = new UnityEngine.Vector2(x:  1f, y:  0.5f);
        val_38.pivot = new UnityEngine.Vector2() {x = val_24.x, y = val_24.y};
        if(val_38 != null)
        {
                UnityEngine.Vector2 val_25 = val_38.anchoredPosition;
            val_45 = val_41;
            UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  val_25.x, y:  val_45);
        }
        else
        {
                UnityEngine.Vector2 val_27 = val_38.anchoredPosition;
            val_45 = val_41;
            UnityEngine.Vector2 val_28 = new UnityEngine.Vector2(x:  val_27.x, y:  val_45);
        }
        
        val_38.anchoredPosition = new UnityEngine.Vector2() {x = val_28.x, y = val_28.y};
        val_41 = val_41 - val_33;
        val_15.transform.SetAsFirstSibling();
        val_40 = 1;
        label_27:
        if(val_40 < this.Sprite_Images.Length)
        {
            goto label_47;
        }
        
        UnityEngine.Coroutine val_31 = this.StartCoroutine(routine:  this.Scroll(PanelHeight:  val_35));
    }
    private System.Collections.IEnumerator Scroll(float PanelHeight)
    {
        Credits.<Scroll>d__19 val_1 = new Credits.<Scroll>d__19();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .PanelHeight = PanelHeight;
        return (System.Collections.IEnumerator)val_1;
    }
    public void Button_ReturnToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu_Title_Screen");
    }
    public Credits()
    {
        this.IndentY = 300f;
        this.spacing_Heading = ;
        this.spacing_Normal = ;
        this.spacing_ExtraComment = 100f;
        this.OffsetX = 500f;
    }

}
