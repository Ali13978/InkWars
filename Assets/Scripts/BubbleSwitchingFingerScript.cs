using UnityEngine;
public class BubbleSwitchingFingerScript : MonoBehaviour
{
    // Fields
    public UnityEngine.Light directionalLight;
    public UnityEngine.GameObject cpuGrid;
    public UnityEngine.GameObject playerBattlegrid;
    public UnityEngine.GameObject entryIndicator;
    public UnityEngine.GameObject demoLineController;
    private bool isStartDone;
    
    // Methods
    public void setDarkInStarting()
    {
        var val_35;
        var val_40;
        var val_41;
        var val_42;
        val_35 = this;
        if(this.isStartDone == true)
        {
                return;
        }
        
        this.isStartDone = true;
        this.directionalLight.intensity = 0.4f;
        UnityEngine.Color val_2 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.cpuGrid.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        UnityEngine.Color val_4 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.playerBattlegrid.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
        UnityEngine.Color val_6 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.entryIndicator.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
        UnityEngine.Color val_9 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        UnityEngine.GameObject.FindWithTag(tag:  "SinkPlug").GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a};
        var val_35 = 0;
        do
        {
            if(val_35 <= 12)
        {
                val_40 = null;
            val_40 = null;
            UnityEngine.Color val_14 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            InstanceAnimator.playerMiddleRingBalls.Length + 32.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_14.r, g = val_14.g, b = val_14.b, a = val_14.a};
            if(val_35 <= 8)
        {
                val_41 = null;
            val_41 = null;
            UnityEngine.Color val_19 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            InstanceAnimator.playerInnerRingBalls.Length + 32.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_19.r, g = val_19.g, b = val_19.b, a = val_19.a};
            UnityEngine.Color val_24 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            InstanceAnimator.innerRingBalls.Length + 32.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_24.r, g = val_24.g, b = val_24.b, a = val_24.a};
        }
        
        }
        
            val_42 = null;
            val_42 = null;
            UnityEngine.Color val_29 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            InstanceAnimator.playerOuterRingBalls.Length + 32.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_29.r, g = val_29.g, b = val_29.b, a = val_29.a};
            val_35 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>();
            UnityEngine.Color val_34 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_35.color = new UnityEngine.Color() {r = val_34.r, g = val_34.g, b = val_34.b, a = val_34.a};
            val_35 = val_35 + 1;
        }
        while(val_35 != 17);
    
    }
    public void onButtonDown()
    {
        var val_42;
        float val_43;
        var val_44;
        var val_45;
        var val_46;
        float val_47;
        float val_48;
        var val_49;
        var val_50;
        var val_55;
        var val_60;
        this.demoLineController.GetComponent<InteractiveTutorialManager>().OnSwipeButtonDown(isCPU:  false, muteSFX:  false);
        val_42 = null;
        val_42 = null;
        UnityEngine.Color val_6 = InstanceAnimator.innerRingBalls + 32.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>().color;
        val_43 = 0.4f;
        if(val_6.r == val_43)
        {
                val_44 = null;
            val_44 = null;
            UnityEngine.Color val_11 = InstanceAnimator.outerRingBalls + 32.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>().color;
            if(val_11.r == val_43)
        {
                val_43 = 1f;
            do
        {
            val_45 = null;
            val_45 = null;
            var val_12 = 4 - 4;
            val_46 = InstanceAnimator.outerRingBalls + 32.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>();
            UnityEngine.Color val_17 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_47 = val_17.g;
            val_48 = val_17.a;
            val_46.color = new UnityEngine.Color() {r = val_17.r, g = val_47, b = val_17.b, a = val_48};
            val_49 = 4 + 1;
        }
        while(val_49 != 21);
        
            return;
        }
        
        }
        
        val_50 = null;
        val_50 = null;
        UnityEngine.Color val_22 = InstanceAnimator.innerRingBalls + 32.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>().color;
        if(val_22.r == val_43)
        {
                do
        {
            if(0 <= 8)
        {
                val_55 = null;
            val_55 = null;
            UnityEngine.Color val_27 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            InstanceAnimator.innerRingBalls + 32.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_27.r, g = val_27.g, b = val_27.b, a = val_27.a};
        }
        
            val_60 = null;
            val_60 = null;
            val_46 = InstanceAnimator.outerRingBalls + 32.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>();
            UnityEngine.Color val_32 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_47 = val_32.r;
            val_48 = val_32.b;
            val_46.color = new UnityEngine.Color() {r = val_47, g = val_32.g, b = val_48, a = val_32.a};
            val_49 = 4 + 1;
        }
        while(val_49 != 21);
        
        }
    
    }
    private void Start()
    {
    
    }
    public void onAnimEnd()
    {
        float val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        UnityEngine.Object val_56;
        var val_57;
        this.directionalLight.intensity = 1f;
        UnityEngine.Color val_2 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.cpuGrid.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        UnityEngine.Color val_4 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.playerBattlegrid.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
        UnityEngine.Color val_6 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_46 = val_6.b;
        this.entryIndicator.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_46, a = val_6.a};
        if((UnityEngine.GameObject.FindWithTag(tag:  "SinkPlug")) != 0)
        {
                UnityEngine.Color val_11 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_46 = val_11.b;
            UnityEngine.GameObject.FindWithTag(tag:  "SinkPlug").GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_46, a = val_11.a};
        }
        
        var val_42 = 0;
        do
        {
            if(val_42 <= 12)
        {
                val_47 = null;
            val_47 = null;
            if((InstanceAnimator.playerMiddleRingBalls.Length + 32) != 0)
        {
                val_48 = null;
            val_48 = null;
            UnityEngine.Color val_17 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_46 = val_17.g;
            InstanceAnimator.playerMiddleRingBalls.Length + 32.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_17.r, g = val_46, b = val_17.b, a = val_17.a};
        }
        
            if(val_42 <= 8)
        {
                val_49 = null;
            val_49 = null;
            if((InstanceAnimator.playerInnerRingBalls.Length + 32) != 0)
        {
                val_50 = null;
            val_50 = null;
            UnityEngine.Color val_23 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_46 = val_23.g;
            InstanceAnimator.playerInnerRingBalls.Length + 32.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_23.r, g = val_46, b = val_23.b, a = val_23.a};
        }
        
            val_51 = null;
            val_51 = null;
            if((InstanceAnimator.innerRingBalls.Length + 32) != 0)
        {
                val_52 = null;
            val_52 = null;
            UnityEngine.Color val_29 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_46 = val_29.g;
            InstanceAnimator.innerRingBalls.Length + 32.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_29.r, g = val_46, b = val_29.b, a = val_29.a};
        }
        
        }
        
        }
        
            val_53 = null;
            val_53 = null;
            if((InstanceAnimator.playerOuterRingBalls.Length + 32) != 0)
        {
                val_54 = null;
            val_54 = null;
            UnityEngine.Color val_35 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_46 = val_35.g;
            InstanceAnimator.playerOuterRingBalls.Length + 32.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_35.r, g = val_46, b = val_35.b, a = val_35.a};
        }
        
            val_55 = null;
            val_55 = null;
            val_56 = mem[InstanceAnimator.outerRingBalls.Length + 32];
            val_56 = InstanceAnimator.outerRingBalls.Length + 32;
            if(val_56 != 0)
        {
                val_57 = null;
            val_57 = null;
            val_56 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.transform.Find(n:  "Bubble").GetComponent<UnityEngine.SpriteRenderer>();
            UnityEngine.Color val_41 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_46 = val_41.g;
            val_56.color = new UnityEngine.Color() {r = val_41.r, g = val_46, b = val_41.b, a = val_41.a};
        }
        
            val_42 = val_42 + 1;
        }
        while(val_42 != 17);
    
    }
    public BubbleSwitchingFingerScript()
    {
    
    }

}
