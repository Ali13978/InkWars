using UnityEngine;
public class main : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Text uri_text;
    public UnityEngine.UI.Text left_text;
    public UnityEngine.UI.Text right_text;
    public UnityEngine.UI.Text string_text;
    public UnityEngine.UI.Image cube;
    private int color_red;
    private int color_green;
    private int color_blue;
    private int intvalue;
    private float floatvalue;
    private string stringvalue;
    private int increment_intvalue;
    private float increment_floatvalue;
    
    // Methods
    private void OnApplicationPause(bool pauseStatus)
    {
        string val_12;
        if(pauseStatus == true)
        {
                return;
        }
        
        this.color_red = AndroidDeepLink.GetValueInInt(name:  "r");
        this.color_green = AndroidDeepLink.GetValueInInt(name:  "g");
        this.color_blue = AndroidDeepLink.GetValueInInt(name:  "b");
        int val_4 = AndroidDeepLink.GetValueInInt(name:  "intval");
        this.intvalue = val_4;
        this.floatvalue = AndroidDeepLink.GetValueInFloat(name:  val_4);
        this.stringvalue = AndroidDeepLink.GetValueInString(name:  "sval");
        this.increment_intvalue = this.intvalue;
        this.increment_floatvalue = this.floatvalue;
        string val_7 = AndroidDeepLink.GetURL();
        object[] val_8 = new object[5];
        val_8[0] = this.color_red;
        val_8[1] = "\n";
        val_8[2] = this.color_green;
        val_8[3] = "\n";
        val_8[4] = this.color_blue;
        string val_9 = +val_8;
        object[] val_10 = new object[7];
        val_10[0] = this.intvalue;
        val_10[1] = "             ";
        val_10[2] = this.increment_intvalue;
        val_10[3] = "\n";
        val_10[4] = this.floatvalue;
        val_10[5] = "          ";
        val_10[6] = this.increment_floatvalue;
        string val_11 = +val_10;
        val_12 = this.stringvalue;
        float val_12 = (float)this.color_red;
        float val_13 = (float)this.color_green;
        float val_14 = (float)this.color_blue;
        val_12 = val_12 / 255f;
        val_13 = val_13 / 255f;
        val_14 = val_14 / 255f;
        this.cube.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    private void Start()
    {
        this.color_red = AndroidDeepLink.GetValueInInt(name:  "r");
        this.color_green = AndroidDeepLink.GetValueInInt(name:  "g");
        this.color_blue = AndroidDeepLink.GetValueInInt(name:  "b");
        this.intvalue = AndroidDeepLink.GetValueInInt(name:  "intval");
        this.floatvalue = AndroidDeepLink.GetValueInFloat(name:  "floatval");
        this.stringvalue = AndroidDeepLink.GetValueInString(name:  "sval");
        this.increment_intvalue = this.intvalue;
        this.increment_floatvalue = this.floatvalue;
        string val_7 = AndroidDeepLink.GetURL();
        object[] val_8 = new object[5];
        if(val_8 == null)
        {
            goto label_2;
        }
        
        if(this.color_red != 0)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(this.color_red == 0)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_8[0] = this.color_red;
        val_8[1] = "\n";
        val_8[2] = this.color_green;
        val_8[3] = "\n";
        val_8[4] = this.color_blue;
        string val_9 = +val_8;
        object[] val_10 = new object[7];
        if(val_10 == null)
        {
            goto label_21;
        }
        
        if(this.intvalue != 0)
        {
            goto label_22;
        }
        
        goto label_25;
        label_21:
        if(this.intvalue == 0)
        {
            goto label_25;
        }
        
        label_22:
        label_25:
        val_10[0] = this.intvalue;
        val_10[1] = "             ";
        val_10[2] = this.increment_intvalue;
        val_10[3] = "\n";
        val_10[4] = this.floatvalue;
        val_10[5] = "          ";
        val_10[6] = this.increment_floatvalue;
        string val_11 = +val_10;
        float val_12 = (float)this.color_red;
        float val_13 = (float)this.color_green;
        float val_14 = (float)this.color_blue;
        val_12 = val_12 / 255f;
        val_13 = val_13 / 255f;
        val_14 = val_14 / 255f;
        this.cube.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    private void Update()
    {
        int val_1 = UnityEngine.Time.frameCount;
        if(0 == 0)
        {
                int val_7 = this.increment_intvalue;
            float val_8 = this.increment_floatvalue;
            val_7 = val_7 + 1;
            this.increment_intvalue = val_7;
            val_8 = val_8 + 0.05f;
            this.increment_floatvalue = val_8;
            object[] val_2 = new object[7];
            val_2[0] = this.intvalue;
            val_2[1] = "                 ";
            val_2[2] = this.increment_intvalue;
            val_2[3] = "\n";
            val_2[4] = this.floatvalue;
            val_2[5] = "              ";
            val_2[6] = this.increment_floatvalue;
            string val_3 = +val_2;
            object[] val_4 = new object[5];
            val_4[0] = this.color_red;
            val_4[1] = "\n";
            val_4[2] = this.color_green;
            val_4[3] = "\n";
            val_4[4] = this.color_blue;
            this = +val_4;
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  27)) == false)
        {
                return;
        }
        
        UnityEngine.Application.Quit();
    }
    public main()
    {
        this.stringvalue = "";
    }

}
