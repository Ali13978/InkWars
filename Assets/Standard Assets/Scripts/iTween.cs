using UnityEngine;
public class iTween : MonoBehaviour
{
    // Fields
    public static System.Collections.Generic.List<System.Collections.Hashtable> tweens;
    public string id;
    public string type;
    public string method;
    public iTween.EaseType easeType;
    public float time;
    public float delay;
    public iTween.LoopType loopType;
    public bool isRunning;
    public bool isPaused;
    public string _name;
    private float runningTime;
    private float percentage;
    private float delayStarted;
    private bool kinematic;
    private bool isLocal;
    private bool loop;
    private bool reverse;
    private bool wasPaused;
    private bool physics;
    private System.Collections.Hashtable tweenArguments;
    private UnityEngine.Space space;
    private iTween.EasingFunction ease;
    private iTween.ApplyTween apply;
    private UnityEngine.AudioSource audioSource;
    private UnityEngine.Vector3[] vector3s;
    private UnityEngine.Vector2[] vector2s;
    private UnityEngine.Color[,] colors;
    private float[] floats;
    private UnityEngine.Rect[] rects;
    private iTween.CRSpline path;
    private UnityEngine.Vector3 preUpdate;
    private UnityEngine.Vector3 postUpdate;
    private iTween.NamedValueColor namedcolorvalue;
    private float lastRealTime;
    private bool useRealTime;
    private UnityEngine.Transform thisTransform;
    
    // Methods
    public static void Init(UnityEngine.GameObject target)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        iTween.MoveBy(target:  target, amount:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, time:  0f);
    }
    public static void CameraFadeFrom(float amount, float time)
    {
        UnityEngine.Debug.LogWarning(message:  "This feature is no longer supported");
    }
    public static void CameraFadeFrom(System.Collections.Hashtable args)
    {
        UnityEngine.Debug.LogWarning(message:  "This feature is no longer supported");
    }
    public static void CameraFadeTo(float amount, float time)
    {
        UnityEngine.Debug.LogWarning(message:  "This feature is no longer supported");
    }
    public static void CameraFadeTo(System.Collections.Hashtable args)
    {
        UnityEngine.Debug.LogWarning(message:  "This feature is no longer supported");
    }
    public static void ValueTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        var val_17;
        var val_19;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  args);
        if((((val_1 & 1) == 0) || ((val_1 & 1) == 0)) || ((val_1 & 1) == 0))
        {
            goto label_6;
        }
        
        if((System.Type.op_Equality(left:  val_1.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_10;
        }
        
        val_17 = "method";
        val_19 = "vector2";
        goto label_28;
        label_6:
        label_38:
        UnityEngine.Debug.LogError(message:  "iTween Error: ValueTo() requires an \'onupdate\' callback function and a \'from\' and \'to\' property.  The supplied \'onupdate\' callback must accept a single argument that is the same type as the supplied \'from\' and \'to\' properties!");
        return;
        label_10:
        if((System.Type.op_Equality(left:  val_1.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_17;
        }
        
        val_17 = "method";
        val_19 = "vector3";
        goto label_28;
        label_17:
        if((System.Type.op_Equality(left:  val_1.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_22;
        }
        
        val_17 = "method";
        val_19 = "rect";
        goto label_28;
        label_22:
        if((System.Type.op_Equality(left:  val_1.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_27;
        }
        
        val_17 = "method";
        val_19 = "float";
        goto label_28;
        label_27:
        if((System.Type.op_Equality(left:  val_1.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_38;
        }
        
        val_17 = "method";
        val_19 = "color";
        label_28:
        iTween.Launch(target:  target, args:  val_1);
    }
    public static void FadeFrom(UnityEngine.GameObject target, float alpha, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "alpha";
        val_1[1] = alpha;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.FadeFrom(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void FadeFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        iTween.ColorFrom(target:  target, args:  args);
    }
    public static void FadeTo(UnityEngine.GameObject target, float alpha, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "alpha";
        val_1[1] = alpha;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.FadeTo(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void FadeTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        iTween.ColorTo(target:  target, args:  args);
    }
    public static void ColorFrom(UnityEngine.GameObject target, UnityEngine.Color color, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "color";
        val_1[1] = color;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.ColorFrom(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void ColorFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        var val_32;
        var val_33;
        var val_34;
        float val_42;
        float val_43;
        float val_44;
        float val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        UnityEngine.Object val_52;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  args);
        if((val_1 & 1) != 0)
        {
                if(null == null)
        {
            goto label_53;
        }
        
        }
        
        System.Collections.IEnumerator val_3 = target.transform.GetEnumerator();
        label_33:
        var val_32 = 0;
        val_32 = val_32 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_13;
        }
        
        var val_33 = 0;
        val_33 = val_33 + 1;
        val_32 = val_3.Current;
        val_33 = val_1;
        if(val_33 != null)
        {
                val_33 = 0;
        }
        
        if(val_32 != null)
        {
                val_32 = 0;
        }
        
        UnityEngine.GameObject val_14 = val_32.gameObject;
        goto label_33;
        label_13:
        val_34 = 0;
        if(val_3 != null)
        {
                var val_34 = 0;
            val_34 = val_34 + 1;
            val_3.Dispose();
        }
        
        label_53:
        bool val_17 = UnityEngine.Object.op_Implicit(exists:  target.GetComponent<UnityEngine.Renderer>());
        if(target == null)
        {
            goto label_59;
        }
        
        if(val_17 == false)
        {
            goto label_60;
        }
        
        label_64:
        UnityEngine.Color val_20 = target.GetComponent<UnityEngine.Renderer>().material.color;
        goto label_63;
        label_59:
        if(val_17 == true)
        {
            goto label_64;
        }
        
        label_60:
        val_42 = 0f;
        val_43 = 0f;
        val_44 = 0f;
        val_45 = 0f;
        if((UnityEngine.Object.op_Implicit(exists:  target.GetComponent<UnityEngine.Light>())) == false)
        {
            goto label_67;
        }
        
        UnityEngine.Color val_24 = target.GetComponent<UnityEngine.Light>().color;
        label_63:
        val_42 = val_24.r;
        val_43 = val_24.g;
        val_45 = val_24.b;
        val_44 = val_24.a;
        label_67:
        if((val_1 & 1) != 0)
        {
                val_49 = val_1 + 12;
        }
        else
        {
                val_46 = val_42;
            val_47 = val_43;
            val_48 = val_45;
            if((val_1 & 1) != 0)
        {
                val_49 = val_1;
        }
        else
        {
                val_50 = val_44;
        }
        
        }
        
        val_51 = "amount";
        if((val_1 & 1) != 0)
        {
            goto label_77;
        }
        
        val_51 = "alpha";
        if((val_1 & 1) == 0)
        {
            goto label_78;
        }
        
        label_77:
        label_78:
        bool val_26 = UnityEngine.Object.op_Implicit(exists:  target.GetComponent<UnityEngine.Renderer>());
        if(target == null)
        {
            goto label_82;
        }
        
        if(val_26 == false)
        {
            goto label_83;
        }
        
        label_87:
        val_52 = target.GetComponent<UnityEngine.Renderer>().material;
        val_52.color = new UnityEngine.Color() {r = 4.769568E-36f, g = 4.769568E-36f, b = 4.769568E-36f, a = 4.769568E-36f};
        goto label_90;
        label_82:
        if(val_26 == true)
        {
            goto label_87;
        }
        
        label_83:
        val_52 = target.GetComponent<UnityEngine.Light>();
        if((UnityEngine.Object.op_Implicit(exists:  val_52)) != false)
        {
                val_52 = target.GetComponent<UnityEngine.Light>();
            val_52.color = new UnityEngine.Color() {r = 4.769568E-36f, g = 4.769568E-36f, b = 4.769568E-36f, a = 4.769568E-36f};
        }
        
        label_90:
        iTween.Launch(target:  target, args:  val_1);
    }
    public static void ColorTo(UnityEngine.GameObject target, UnityEngine.Color color, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "color";
        val_1[1] = color;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.ColorTo(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void ColorTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        bool val_9;
        var val_16;
        var val_17;
        var val_18;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  args);
        if((val_1 & 1) != 0)
        {
                if(null == null)
        {
            goto label_53;
        }
        
        }
        
        System.Collections.IEnumerator val_3 = target.transform.GetEnumerator();
        label_33:
        var val_16 = 0;
        val_16 = val_16 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_13;
        }
        
        var val_17 = 0;
        val_17 = val_17 + 1;
        val_16 = val_3.Current;
        val_17 = val_1;
        if(val_17 != null)
        {
                val_17 = 0;
        }
        
        val_9 = true;
        if(val_16 != null)
        {
                val_16 = 0;
        }
        
        UnityEngine.GameObject val_14 = val_16.gameObject;
        goto label_33;
        label_13:
        val_18 = 0;
        if(val_3 != null)
        {
                var val_18 = 0;
            val_18 = val_18 + 1;
            val_3.Dispose();
        }
        
        label_53:
        iTween.Launch(target:  target, args:  val_1);
    }
    public static void AudioFrom(UnityEngine.GameObject target, float volume, float pitch, float time)
    {
        object[] val_1 = new object[6];
        val_1[0] = "volume";
        val_1[1] = volume;
        val_1[2] = "pitch";
        val_1[3] = pitch;
        val_1[4] = "time";
        val_1[5] = time;
        iTween.AudioFrom(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void AudioFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        float val_2;
        var val_9;
        float val_10;
        var val_11;
        var val_12;
        var val_13;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  args);
        if((val_1 & 1) == 0)
        {
            goto label_4;
        }
        
        val_9 = val_1;
        if(val_9 == null)
        {
            goto label_13;
        }
        
        if(null == null)
        {
            goto label_6;
        }
        
        val_9 = 0;
        goto label_13;
        label_4:
        if((UnityEngine.Object.op_Implicit(exists:  target.GetComponent<UnityEngine.AudioSource>())) == false)
        {
            goto label_11;
        }
        
        val_9 = target.GetComponent<UnityEngine.AudioSource>();
        if(val_9 == null)
        {
            goto label_13;
        }
        
        label_6:
        val_10 = val_9.volume;
        val_11 = 0;
        goto label_14;
        label_13:
        val_10 = val_9.volume;
        val_11 = 1;
        label_14:
        val_12 = val_10;
        val_13 = val_9.pitch;
        if((val_11 & 1) != 0)
        {
                val_9.volume = 4.769568E-36f;
        }
        else
        {
                val_9.volume = 4.769568E-36f;
        }
        
        val_9.pitch = 4.769568E-36f;
        val_2 = val_10;
        if((val_1 & 1) == 0)
        {
                val_2 = 21;
        }
        
        iTween.Launch(target:  target, args:  val_1);
        return;
        label_11:
        UnityEngine.Debug.LogError(message:  "iTween Error: AudioFrom requires an AudioSource.");
    }
    public static void AudioTo(UnityEngine.GameObject target, float volume, float pitch, float time)
    {
        object[] val_1 = new object[6];
        val_1[0] = "volume";
        val_1[1] = volume;
        val_1[2] = "pitch";
        val_1[3] = pitch;
        val_1[4] = "time";
        val_1[5] = time;
        iTween.AudioTo(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void AudioTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        iTween.Launch(target:  target, args:  iTween.CleanArgs(args:  args));
    }
    public static void Stab(UnityEngine.GameObject target, UnityEngine.AudioClip audioclip, float delay)
    {
        object[] val_1 = new object[4];
        val_1[0] = "audioclip";
        val_1[1] = audioclip;
        val_1[2] = "delay";
        val_1[3] = delay;
        iTween.Stab(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void Stab(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        iTween.Launch(target:  target, args:  iTween.CleanArgs(args:  args));
    }
    public static void LookFrom(UnityEngine.GameObject target, UnityEngine.Vector3 looktarget, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "looktarget";
        val_1[1] = looktarget;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.LookFrom(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void LookFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        float val_8;
        var val_9;
        float val_24;
        var val_25;
        System.Type val_26;
        var val_27;
        var val_28;
        UnityEngine.Transform val_29;
        UnityEngine.Vector3 val_30;
        var val_31;
        var val_32;
        float val_33;
        UnityEngine.Vector3 val_36;
        var val_37;
        var val_38;
        float val_39;
        float val_40;
        float val_41;
        string val_42;
        var val_43;
        float val_44;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  args);
        UnityEngine.Vector3 val_3 = target.transform.eulerAngles;
        val_24 = val_3.y;
        val_25 = "looktarget";
        if((System.Type.op_Equality(left:  val_1.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_9;
        }
        
        val_26 = target.transform;
        val_27 = val_1;
        val_28 = 1152921504865153024;
        val_25;
        val_29 = 0;
        if((val_25 & 1) == 0)
        {
            goto label_16;
        }
        
        if(val_27 != null)
        {
                val_27 = 0;
        }
        
        val_30 = val_9;
        val_31 = val_3.y;
        val_32 = val_3.z;
        val_29 = val_27;
        if(val_26 != null)
        {
            goto label_34;
        }
        
        goto label_21;
        label_9:
        val_26 = val_1.GetType();
        if((System.Type.op_Equality(left:  val_26, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_35;
        }
        
        val_26 = target.transform;
        val_28 = null;
        val_25;
        if((val_25 & 1) == 0)
        {
            goto label_29;
        }
        
        val_33 = val_24;
        val_36 = val_9;
        val_37 = val_3.y;
        val_30 = val_3.z;
        if(val_26 != null)
        {
            goto label_38;
        }
        
        goto label_31;
        label_16:
        val_38 = null;
        val_38 = null;
        val_30 = iTween.Defaults.up;
        if(val_26 != null)
        {
            goto label_34;
        }
        
        label_21:
        label_34:
        val_39 = val_30;
        val_40 = iTween.Defaults.time.__il2cppRuntimeField_4C;
        val_41 = iTween.Defaults.time.__il2cppRuntimeField_50;
        val_26.LookAt(target:  val_29, worldUp:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_41});
        goto label_35;
        label_29:
        val_33 = val_24;
        val_36 = iTween.Defaults.up;
        if(val_26 != null)
        {
            goto label_38;
        }
        
        label_31:
        label_38:
        val_39 = 4.769568E-36f;
        val_40 = V12.16B;
        val_41 = V13.16B;
        val_26.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_41}, worldUp:  new UnityEngine.Vector3() {x = val_36, y = iTween.Defaults.time.__il2cppRuntimeField_4C, z = iTween.Defaults.time.__il2cppRuntimeField_50});
        val_24 = val_33;
        label_35:
        if((val_1 & 1) != 0)
        {
                UnityEngine.Vector3 val_17 = target.transform.eulerAngles;
            val_32 = val_17.y;
            val_42 = val_1;
            if(val_42 != null)
        {
                val_42 = 0;
        }
        
            val_30 = val_3.z;
            val_36 = val_17.x;
            val_33 = val_24;
            if((System.String.op_Equality(a:  val_42, b:  "x")) != true)
        {
                val_30 = val_3.z;
            val_36 = val_3.x;
            val_43 = val_32;
            if((System.String.op_Equality(a:  val_42, b:  "y")) != true)
        {
                bool val_20 = System.String.op_Equality(a:  val_42, b:  "z");
            val_30 = val_17.z;
        }
        
        }
        
            val_26 = target.transform;
            val_26.eulerAngles = new UnityEngine.Vector3() {x = (val_20 != true) ? val_3.x : val_17.x, y = (val_20 != true) ? (val_33) : (val_32), z = val_30};
            val_44 = val_33;
        }
        
        val_8 = val_3.x;
        iTween.Launch(target:  target, args:  val_1);
    }
    public static void LookTo(UnityEngine.GameObject target, UnityEngine.Vector3 looktarget, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "looktarget";
        val_1[1] = looktarget;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.LookTo(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void LookTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        var val_6;
        System.Type val_17;
        var val_18;
        var val_19;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  args);
        if((val_1 & 1) != 0)
        {
                val_17 = val_1.GetType();
            if((System.Type.op_Equality(left:  val_17, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
        {
                UnityEngine.Vector3 val_7 = 0.position;
            UnityEngine.Vector3 val_8 = 0.position;
            val_17 = 0;
            UnityEngine.Vector3 val_9 = val_17.position;
            val_6 = 0;
            if((1 & 1) != 0)
        {
                UnityEngine.Vector3 val_10 = val_17.eulerAngles;
            val_18 = val_10.x;
            UnityEngine.Vector3 val_11 = val_17.eulerAngles;
            val_19 = val_11.y;
        }
        else
        {
                UnityEngine.Vector3 val_12 = val_17.eulerAngles;
            val_18 = val_12.x;
            UnityEngine.Vector3 val_13 = val_17.eulerAngles;
            val_19 = val_13.y;
        }
        
            UnityEngine.Vector3 val_14 = val_17.eulerAngles;
        }
        
        }
        
        iTween.Launch(target:  target, args:  val_1);
    }
    public static void MoveTo(UnityEngine.GameObject target, UnityEngine.Vector3 position, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "position";
        val_1[1] = position;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.MoveTo(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void MoveTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        var val_6;
        System.Type val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  args);
        if((val_1 & 1) != 0)
        {
                val_22 = val_1.GetType();
            if((System.Type.op_Equality(left:  val_22, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
        {
                UnityEngine.Vector3 val_7 = 0.position;
            UnityEngine.Vector3 val_8 = 0.position;
            val_22 = 0;
            UnityEngine.Vector3 val_9 = val_22.position;
            val_6 = 0;
            if((1 & 1) != 0)
        {
                UnityEngine.Vector3 val_10 = val_22.eulerAngles;
            val_23 = val_10.x;
            UnityEngine.Vector3 val_11 = val_22.eulerAngles;
            val_24 = val_11.y;
        }
        else
        {
                UnityEngine.Vector3 val_12 = val_22.eulerAngles;
            val_23 = val_12.x;
            UnityEngine.Vector3 val_13 = val_22.eulerAngles;
            val_24 = val_13.y;
        }
        
            UnityEngine.Vector3 val_14 = val_22.eulerAngles;
            if((1 & 1) != 0)
        {
                UnityEngine.Vector3 val_15 = val_22.localScale;
            val_25 = val_15.x;
            UnityEngine.Vector3 val_16 = val_22.localScale;
            val_26 = val_16.y;
        }
        else
        {
                UnityEngine.Vector3 val_17 = val_22.localScale;
            val_25 = val_17.x;
            UnityEngine.Vector3 val_18 = val_22.localScale;
            val_26 = val_18.y;
        }
        
            UnityEngine.Vector3 val_19 = val_22.localScale;
        }
        
        }
        
        iTween.Launch(target:  target, args:  val_1);
    }
    public static void MoveFrom(UnityEngine.GameObject target, UnityEngine.Vector3 position, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "position";
        val_1[1] = position;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.MoveFrom(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void MoveFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        float val_12;
        var val_36;
        var val_37;
        var val_38;
        System.Array val_39;
        var val_40;
        var val_44;
        var val_45;
        float val_46;
        float val_47;
        var val_48;
        var val_49;
        float val_50;
        float val_51;
        System.Array val_52;
        val_36 = 1152921505059774464;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  args);
        if((val_1 & 1) != 0)
        {
                val_37 = val_1;
        }
        else
        {
                val_38 = null;
            val_38 = null;
            val_37 = 1152921505060098072;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_8;
        }
        
        if((System.Type.op_Equality(left:  val_1.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_12;
        }
        
        if(val_1 == null)
        {
            goto label_13;
        }
        
        val_39 = val_1;
        if(val_39 == null)
        {
            goto label_14;
        }
        
        val_40 = 0;
        goto label_15;
        label_8:
        UnityEngine.Transform val_5 = target.transform;
        if(val_5 == null)
        {
            goto label_17;
        }
        
        if(val_37 == false)
        {
            goto label_18;
        }
        
        label_23:
        UnityEngine.Vector3 val_6 = val_5.localPosition;
        goto label_19;
        label_12:
        if(val_1 == null)
        {
            goto label_20;
        }
        
        val_40 = null;
        val_44 = val_1;
        if(val_44 == null)
        {
            goto label_21;
        }
        
        val_45 = val_44;
        goto label_22;
        label_17:
        if(val_37 == true)
        {
            goto label_23;
        }
        
        label_18:
        UnityEngine.Vector3 val_7 = val_5.position;
        label_19:
        val_40 = "position";
        val_46 = val_7.x;
        val_47 = val_7.z;
        if((val_1 & 1) == 0)
        {
            goto label_24;
        }
        
        val_48 = val_1;
        if((System.Type.op_Equality(left:  val_1.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_28;
        }
        
        if(val_48 == null)
        {
            goto label_29;
        }
        
        val_48 = 0;
        goto label_34;
        label_24:
        val_49 = val_46;
        val_50 = val_7.y;
        if((val_1 & 1) == 0)
        {
            goto label_37;
        }
        
        if(target != null)
        {
            goto label_98;
        }
        
        goto label_99;
        label_28:
        val_51 = val_47;
        val_50 = val_7.y;
        val_49 = val_46;
        if((System.Type.op_Equality(left:  val_48.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_43;
        }
        
        if(target != null)
        {
            goto label_98;
        }
        
        goto label_99;
        label_37:
        val_51 = val_47;
        label_43:
        if(target != null)
        {
            goto label_98;
        }
        
        label_99:
        label_98:
        val_52 = target.transform;
        if(val_37 != false)
        {
                val_52.localPosition = new UnityEngine.Vector3() {x = 4.769568E-36f, y = 4.769568E-36f, z = val_51};
        }
        else
        {
                val_52.position = new UnityEngine.Vector3() {x = 4.769568E-36f, y = 4.769568E-36f, z = val_51};
        }
        
        val_12 = val_46;
        goto label_77;
        label_14:
        label_13:
        val_39 = 0;
        val_40 = 1;
        label_15:
        UnityEngine.Vector3[] val_18 = new UnityEngine.Vector3[10260432];
        val_52 = val_18;
        System.Array.Copy(sourceArray:  val_39, destinationArray:  val_18, length:  10260432);
        goto label_53;
        label_21:
        label_20:
        val_44 = 0;
        val_45 = 0;
        label_22:
        val_52 = new UnityEngine.Vector3[10260432];
        if(10260432 < 1)
        {
            goto label_53;
        }
        
        do
        {
            var val_20 = val_44 + 0;
            val_40 = mem[(val_44 + 0) + 32];
            val_40 = (val_44 + 0) + 32;
            UnityEngine.Vector3 val_21 = val_40.position;
            var val_22 = val_52 + (0 * 12);
            mem2[0] = val_21.x;
            mem2[0] = val_21.y;
            mem2[0] = val_21.z;
        }
        while((0 + 1) < 10260432);
        
        val_36 = 1152921505059774464;
        goto label_60;
        label_53:
        label_60:
        var val_39 = -4294967296;
        val_39 = val_39 + ((val_18.Length) << 32);
        var val_40 = 12;
        val_40 = val_52 + ((val_39 >> 32) * val_40);
        UnityEngine.Vector3 val_26 = target.transform.position;
        val_50 = val_26.y;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = (((-4294967296 + (val_18.Length) << 32) >> 32) * 12) + val_18 + 32, y = (((-4294967296 + (val_18.Length) << 32) >> 32) * 12) + val_18 + 32 + 4, z = (((-4294967296 + (val_18.Length) << 32) >> 32) * 12) + val_18 + 40}, rhs:  new UnityEngine.Vector3() {x = val_26.x, y = val_50, z = val_26.z})) == false)
        {
            goto label_66;
        }
        
        int val_28 = val_18.Length + 1;
        UnityEngine.Vector3[] val_29 = new UnityEngine.Vector3[0];
        System.Array.Copy(sourceArray:  val_18, destinationArray:  val_29, length:  val_18.Length);
        if(val_29 == null)
        {
            goto label_67;
        }
        
        label_86:
        UnityEngine.Transform val_30 = target.transform;
        if(val_30 == null)
        {
            goto label_69;
        }
        
        if(val_37 == false)
        {
            goto label_70;
        }
        
        label_87:
        UnityEngine.Vector3 val_31 = val_30.localPosition;
        var val_41 = -4294967296;
        val_41 = val_41 + ((val_29.Length) << 32);
        var val_42 = 12;
        val_42 = val_29 + ((val_41 >> 32) * val_42);
        mem2[0] = val_31.x;
        mem2[0] = val_31.y;
        mem2[0] = val_31.z;
        val_52 = target.transform;
        val_46 = val_29[0];
        val_47 = val_29[0];
        val_52.localPosition = new UnityEngine.Vector3() {x = val_46, y = val_29[0], z = val_47};
        if(val_1 != null)
        {
            goto label_77;
        }
        
        goto label_77;
        label_66:
        UnityEngine.Transform val_34 = target.transform;
        val_47 = val_52[0];
        UnityEngine.Vector3 val_44 = val_52[0];
        val_46 = val_52[0];
        if(val_34 == null)
        {
            goto label_80;
        }
        
        if(val_37 == false)
        {
            goto label_81;
        }
        
        label_95:
        val_34.localPosition = new UnityEngine.Vector3() {x = val_47, y = val_44, z = val_46};
        if(val_1 != null)
        {
            goto label_96;
        }
        
        label_97:
        label_96:
        label_77:
        iTween.Launch(target:  target, args:  val_1);
        return;
        label_67:
        if(target != null)
        {
            goto label_86;
        }
        
        goto label_86;
        label_69:
        if(val_37 == true)
        {
            goto label_87;
        }
        
        label_70:
        UnityEngine.Vector3 val_35 = val_30.position;
        var val_45 = -4294967296;
        val_45 = val_45 + ((val_29.Length) << 32);
        var val_46 = 12;
        val_46 = val_29 + ((val_45 >> 32) * val_46);
        mem2[0] = val_35.x;
        mem2[0] = val_35.y;
        mem2[0] = val_35.z;
        target.transform.position = new UnityEngine.Vector3() {x = val_29[0], y = val_29[0], z = val_29[0]};
        if(val_1 != null)
        {
            goto label_77;
        }
        
        goto label_77;
        label_80:
        if(val_37 == true)
        {
            goto label_95;
        }
        
        label_81:
        val_34.position = new UnityEngine.Vector3() {x = val_47, y = val_44, z = val_46};
        if(val_1 != null)
        {
            goto label_96;
        }
        
        goto label_97;
        label_29:
        label_34:
        UnityEngine.Vector3 val_38 = val_48.position;
        if(target != null)
        {
            goto label_98;
        }
        
        goto label_99;
    }
    public static void MoveAdd(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "amount";
        val_1[1] = amount;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.MoveAdd(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void MoveAdd(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        iTween.Launch(target:  target, args:  iTween.CleanArgs(args:  args));
    }
    public static void MoveBy(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "amount";
        val_1[1] = amount;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.MoveBy(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void MoveBy(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        iTween.Launch(target:  target, args:  iTween.CleanArgs(args:  args));
    }
    public static void ScaleTo(UnityEngine.GameObject target, UnityEngine.Vector3 scale, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "scale";
        val_1[1] = scale;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.ScaleTo(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void ScaleTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        var val_6;
        System.Type val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  args);
        if((val_1 & 1) != 0)
        {
                val_22 = val_1.GetType();
            if((System.Type.op_Equality(left:  val_22, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
        {
                UnityEngine.Vector3 val_7 = 0.position;
            UnityEngine.Vector3 val_8 = 0.position;
            val_22 = 0;
            UnityEngine.Vector3 val_9 = val_22.position;
            val_6 = 0;
            if((1 & 1) != 0)
        {
                UnityEngine.Vector3 val_10 = val_22.eulerAngles;
            val_23 = val_10.x;
            UnityEngine.Vector3 val_11 = val_22.eulerAngles;
            val_24 = val_11.y;
        }
        else
        {
                UnityEngine.Vector3 val_12 = val_22.eulerAngles;
            val_23 = val_12.x;
            UnityEngine.Vector3 val_13 = val_22.eulerAngles;
            val_24 = val_13.y;
        }
        
            UnityEngine.Vector3 val_14 = val_22.eulerAngles;
            if((1 & 1) != 0)
        {
                UnityEngine.Vector3 val_15 = val_22.localScale;
            val_25 = val_15.x;
            UnityEngine.Vector3 val_16 = val_22.localScale;
            val_26 = val_16.y;
        }
        else
        {
                UnityEngine.Vector3 val_17 = val_22.localScale;
            val_25 = val_17.x;
            UnityEngine.Vector3 val_18 = val_22.localScale;
            val_26 = val_18.y;
        }
        
            UnityEngine.Vector3 val_19 = val_22.localScale;
        }
        
        }
        
        iTween.Launch(target:  target, args:  val_1);
    }
    public static void ScaleFrom(UnityEngine.GameObject target, UnityEngine.Vector3 scale, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "scale";
        val_1[1] = scale;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.ScaleFrom(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void ScaleFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        float val_8;
        var val_15;
        var val_16;
        float val_17;
        float val_18;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  args);
        UnityEngine.Vector3 val_3 = target.transform.localScale;
        if(val_1 == null)
        {
            goto label_6;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_7;
        }
        
        label_18:
        val_15 = val_1;
        if((System.Type.op_Equality(left:  val_1.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_11;
        }
        
        if(val_15 == null)
        {
            goto label_12;
        }
        
        val_15 = 0;
        goto label_17;
        label_6:
        if((val_1 & 1) != 0)
        {
            goto label_18;
        }
        
        label_7:
        val_16 = val_3.x;
        val_17 = val_3.y;
        if((val_1 & 1) == 0)
        {
            goto label_21;
        }
        
        if(target != null)
        {
            goto label_34;
        }
        
        goto label_35;
        label_11:
        bool val_12 = System.Type.op_Equality(left:  val_15.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_18 = val_3.z;
        val_17 = val_3.y;
        val_16 = val_3.x;
        if(target != null)
        {
            goto label_34;
        }
        
        label_35:
        label_34:
        target.transform.localScale = new UnityEngine.Vector3() {x = 4.769568E-36f, y = val_17, z = val_18};
        val_8 = val_3.x;
        iTween.Launch(target:  target, args:  val_1);
        return;
        label_21:
        if(target != null)
        {
            goto label_34;
        }
        
        goto label_35;
        label_12:
        label_17:
        UnityEngine.Vector3 val_14 = val_15.localScale;
        if(target != null)
        {
            goto label_34;
        }
        
        goto label_35;
    }
    public static void ScaleAdd(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "amount";
        val_1[1] = amount;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.ScaleAdd(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void ScaleAdd(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        iTween.Launch(target:  target, args:  iTween.CleanArgs(args:  args));
    }
    public static void ScaleBy(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "amount";
        val_1[1] = amount;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.ScaleBy(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void ScaleBy(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        iTween.Launch(target:  target, args:  iTween.CleanArgs(args:  args));
    }
    public static void RotateTo(UnityEngine.GameObject target, UnityEngine.Vector3 rotation, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "rotation";
        val_1[1] = rotation;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.RotateTo(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void RotateTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        var val_6;
        System.Type val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  args);
        if((val_1 & 1) != 0)
        {
                val_22 = val_1.GetType();
            if((System.Type.op_Equality(left:  val_22, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
        {
                UnityEngine.Vector3 val_7 = 0.position;
            UnityEngine.Vector3 val_8 = 0.position;
            val_22 = 0;
            UnityEngine.Vector3 val_9 = val_22.position;
            val_6 = 0;
            if((1 & 1) != 0)
        {
                UnityEngine.Vector3 val_10 = val_22.eulerAngles;
            val_23 = val_10.x;
            UnityEngine.Vector3 val_11 = val_22.eulerAngles;
            val_24 = val_11.y;
        }
        else
        {
                UnityEngine.Vector3 val_12 = val_22.eulerAngles;
            val_23 = val_12.x;
            UnityEngine.Vector3 val_13 = val_22.eulerAngles;
            val_24 = val_13.y;
        }
        
            UnityEngine.Vector3 val_14 = val_22.eulerAngles;
            if((1 & 1) != 0)
        {
                UnityEngine.Vector3 val_15 = val_22.localScale;
            val_25 = val_15.x;
            UnityEngine.Vector3 val_16 = val_22.localScale;
            val_26 = val_16.y;
        }
        else
        {
                UnityEngine.Vector3 val_17 = val_22.localScale;
            val_25 = val_17.x;
            UnityEngine.Vector3 val_18 = val_22.localScale;
            val_26 = val_18.y;
        }
        
            UnityEngine.Vector3 val_19 = val_22.localScale;
        }
        
        }
        
        iTween.Launch(target:  target, args:  val_1);
    }
    public static void RotateFrom(UnityEngine.GameObject target, UnityEngine.Vector3 rotation, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "rotation";
        val_1[1] = rotation;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.RotateFrom(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void RotateFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        float val_9;
        var val_16;
        var val_17;
        var val_21;
        var val_22;
        float val_23;
        float val_24;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  args);
        if((val_1 & 1) != 0)
        {
                val_16 = val_1;
        }
        else
        {
                val_17 = null;
            val_17 = null;
            val_16 = 1152921505060098072;
        }
        
        UnityEngine.Transform val_2 = target.transform;
        if(val_2 == null)
        {
            goto label_9;
        }
        
        if(val_16 == false)
        {
            goto label_10;
        }
        
        label_12:
        UnityEngine.Vector3 val_3 = val_2.localEulerAngles;
        goto label_11;
        label_9:
        if(val_16 == true)
        {
            goto label_12;
        }
        
        label_10:
        UnityEngine.Vector3 val_4 = val_2.eulerAngles;
        label_11:
        if((val_1 & 1) == 0)
        {
            goto label_13;
        }
        
        val_21 = val_1;
        if((System.Type.op_Equality(left:  val_1.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_17;
        }
        
        if(val_21 == null)
        {
            goto label_18;
        }
        
        val_21 = 0;
        goto label_23;
        label_13:
        val_22 = val_4.x;
        val_23 = val_4.y;
        if((val_1 & 1) == 0)
        {
            goto label_26;
        }
        
        if(target != null)
        {
            goto label_41;
        }
        
        goto label_42;
        label_17:
        bool val_13 = System.Type.op_Equality(left:  val_21.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_24 = val_4.z;
        val_23 = val_4.y;
        val_22 = val_4.x;
        if(target != null)
        {
            goto label_41;
        }
        
        label_42:
        label_41:
        UnityEngine.Transform val_14 = target.transform;
        if(val_16 != false)
        {
                val_14.localEulerAngles = new UnityEngine.Vector3() {x = 4.769568E-36f, y = val_23, z = val_24};
        }
        else
        {
                val_14.eulerAngles = new UnityEngine.Vector3() {x = 4.769568E-36f, y = val_23, z = val_24};
        }
        
        val_9 = val_4.x;
        iTween.Launch(target:  target, args:  val_1);
        return;
        label_26:
        if(target != null)
        {
            goto label_41;
        }
        
        goto label_42;
        label_18:
        label_23:
        UnityEngine.Vector3 val_15 = val_21.eulerAngles;
        if(target != null)
        {
            goto label_41;
        }
        
        goto label_42;
    }
    public static void RotateAdd(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "amount";
        val_1[1] = amount;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.RotateAdd(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void RotateAdd(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        iTween.Launch(target:  target, args:  iTween.CleanArgs(args:  args));
    }
    public static void RotateBy(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "amount";
        val_1[1] = amount;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.RotateBy(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void RotateBy(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        iTween.Launch(target:  target, args:  iTween.CleanArgs(args:  args));
    }
    public static void ShakePosition(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "amount";
        val_1[1] = amount;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.ShakePosition(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void ShakePosition(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        iTween.Launch(target:  target, args:  iTween.CleanArgs(args:  args));
    }
    public static void ShakeScale(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "amount";
        val_1[1] = amount;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.ShakeScale(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void ShakeScale(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        iTween.Launch(target:  target, args:  iTween.CleanArgs(args:  args));
    }
    public static void ShakeRotation(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "amount";
        val_1[1] = amount;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.ShakeRotation(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void ShakeRotation(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        iTween.Launch(target:  target, args:  iTween.CleanArgs(args:  args));
    }
    public static void PunchPosition(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "amount";
        val_1[1] = amount;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.PunchPosition(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void PunchPosition(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        iTween.Launch(target:  target, args:  iTween.CleanArgs(args:  args));
    }
    public static void PunchRotation(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "amount";
        val_1[1] = amount;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.PunchRotation(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void PunchRotation(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        iTween.Launch(target:  target, args:  iTween.CleanArgs(args:  args));
    }
    public static void PunchScale(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "amount";
        val_1[1] = amount;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.PunchScale(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void PunchScale(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        iTween.Launch(target:  target, args:  iTween.CleanArgs(args:  args));
    }
    private void GenerateTargets()
    {
        IntPtr val_37;
        uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  this.type);
        if(val_1 > (-1933610845))
        {
            goto label_1;
        }
        
        if(val_1 > 1031692888)
        {
            goto label_2;
        }
        
        if(val_1 == 407568404)
        {
            goto label_3;
        }
        
        if(val_1 != 1031692888)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.type, b:  "color")) == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.method, b:  "to")) == false)
        {
                return;
        }
        
        this.GenerateColorToTargets();
        val_37 = 1152921525680029168;
        goto label_71;
        label_1:
        if(val_1 > (-1114918155))
        {
            goto label_8;
        }
        
        if(val_1 == (-1510671094))
        {
            goto label_9;
        }
        
        if(val_1 != (-1114918155))
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.type, b:  "shake")) == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.method, b:  "position")) == false)
        {
            goto label_12;
        }
        
        this.GenerateShakePositionTargets();
        val_37 = 1152921525680038384;
        goto label_71;
        label_2:
        if(val_1 == (-2104025999))
        {
            goto label_14;
        }
        
        if(val_1 == (-1933610845))
        {
            goto label_15;
        }
        
        if(val_1 != 1113510858)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.type, b:  "value")) == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.method, b:  "float")) == false)
        {
            goto label_18;
        }
        
        this.GenerateFloatTargets();
        val_37 = 1152921525680047600;
        goto label_71;
        label_8:
        if(val_1 == (-530499175))
        {
            goto label_20;
        }
        
        if(val_1 == (-516208479))
        {
            goto label_21;
        }
        
        if(val_1 != (-420522346))
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.type, b:  "look")) == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.method, b:  "to")) == false)
        {
                return;
        }
        
        this.GenerateLookToTargets();
        val_37 = 1152921525680056816;
        goto label_71;
        label_3:
        if((System.String.op_Equality(a:  this.type, b:  "move")) == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.method, b:  "to")) == false)
        {
            goto label_27;
        }
        
        if((this.tweenArguments & 1) == 0)
        {
            goto label_29;
        }
        
        this.GenerateMoveToPathTargets();
        val_37 = 1152921525680070128;
        goto label_71;
        label_9:
        if((System.String.op_Equality(a:  this.type, b:  "rotate")) == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.method, b:  "to")) == false)
        {
            goto label_32;
        }
        
        this.GenerateRotateToTargets();
        val_37 = 1152921525680079344;
        goto label_71;
        label_14:
        if((System.String.op_Equality(a:  this.type, b:  "scale")) == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.method, b:  "to")) == false)
        {
            goto label_35;
        }
        
        this.GenerateScaleToTargets();
        goto label_53;
        label_15:
        if((System.String.op_Equality(a:  this.type, b:  "punch")) == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.method, b:  "position")) == false)
        {
            goto label_38;
        }
        
        this.GeneratePunchPositionTargets();
        val_37 = 1152921525680092656;
        goto label_71;
        label_20:
        if((System.String.op_Equality(a:  this.type, b:  "audio")) == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.method, b:  "to")) == false)
        {
                return;
        }
        
        this.GenerateAudioToTargets();
        val_37 = 1152921525680101872;
        goto label_71;
        label_21:
        if((System.String.op_Equality(a:  this.type, b:  "stab")) == false)
        {
                return;
        }
        
        this.GenerateStabTargets();
        val_37 = 1152921525680106992;
        goto label_71;
        label_12:
        if((System.String.op_Equality(a:  this.method, b:  "scale")) == false)
        {
            goto label_45;
        }
        
        this.GenerateShakeScaleTargets();
        val_37 = 1152921525680112112;
        goto label_71;
        label_27:
        if((System.String.op_Equality(a:  this.method, b:  "by")) != true)
        {
                if((System.String.op_Equality(a:  this.method, b:  "add")) == false)
        {
                return;
        }
        
        }
        
        this.GenerateMoveByTargets();
        val_37 = 1152921525680117232;
        goto label_71;
        label_32:
        if((System.String.op_Equality(a:  this.method, b:  "add")) == false)
        {
            goto label_50;
        }
        
        this.GenerateRotateAddTargets();
        goto label_51;
        label_35:
        if((System.String.op_Equality(a:  this.method, b:  "by")) == false)
        {
            goto label_52;
        }
        
        this.GenerateScaleByTargets();
        goto label_53;
        label_38:
        if((System.String.op_Equality(a:  this.method, b:  "rotation")) == false)
        {
            goto label_54;
        }
        
        this.GeneratePunchRotationTargets();
        val_37 = 1152921525680122352;
        goto label_71;
        label_18:
        if((System.String.op_Equality(a:  this.method, b:  "vector2")) == false)
        {
            goto label_56;
        }
        
        this.GenerateVector2Targets();
        val_37 = 1152921525680127472;
        goto label_71;
        label_29:
        this.GenerateMoveToTargets();
        val_37 = 1152921525680132592;
        goto label_71;
        label_45:
        if((System.String.op_Equality(a:  this.method, b:  "rotation")) == false)
        {
                return;
        }
        
        this.GenerateShakeRotationTargets();
        val_37 = 1152921525680137712;
        goto label_71;
        label_50:
        if((System.String.op_Equality(a:  this.method, b:  "by")) == false)
        {
                return;
        }
        
        this.GenerateRotateByTargets();
        label_51:
        val_37 = 1152921525680142832;
        goto label_71;
        label_52:
        if((System.String.op_Equality(a:  this.method, b:  "add")) == false)
        {
                return;
        }
        
        this.GenerateScaleAddTargets();
        label_53:
        iTween.ApplyTween val_31 = null;
        val_37 = 1152921525680147952;
        label_71:
        val_31 = new iTween.ApplyTween(object:  this, method:  val_37);
        this.apply = val_31;
        return;
        label_54:
        if((System.String.op_Equality(a:  this.method, b:  "scale")) == false)
        {
                return;
        }
        
        this.GeneratePunchScaleTargets();
        goto label_71;
        label_56:
        if((System.String.op_Equality(a:  this.method, b:  "vector3")) == false)
        {
            goto label_66;
        }
        
        this.GenerateVector3Targets();
        goto label_71;
        label_66:
        if((System.String.op_Equality(a:  this.method, b:  "color")) == false)
        {
            goto label_68;
        }
        
        this.GenerateColorTargets();
        goto label_71;
        label_68:
        if((System.String.op_Equality(a:  this.method, b:  "rect")) == false)
        {
                return;
        }
        
        this.GenerateRectTargets();
        goto label_71;
    }
    private void GenerateRectTargets()
    {
        UnityEngine.Rect[] val_1 = new UnityEngine.Rect[3];
        this.rects = val_1;
        val_1[0] = new UnityEngine.Rect();
        val_1[0] = new UnityEngine.Rect();
        val_1[0] = new UnityEngine.Rect();
        val_1[0] = new UnityEngine.Rect();
        this.rects[1] = new UnityEngine.Rect();
        this.rects[1] = this.tweenArguments;
        this.rects[1] = new UnityEngine.Rect();
        this.rects[1] = 1152921504856313856;
    }
    private void GenerateColorTargets()
    {
        this.colors = null;
        typeof(UnityEngine.Color[,]).__il2cppRuntimeField_20 = null;
        typeof(UnityEngine.Color[,]).__il2cppRuntimeField_24 = this.tweenArguments;
        typeof(UnityEngine.Color[,]).__il2cppRuntimeField_28 = ???;
        typeof(UnityEngine.Color[,]).__il2cppRuntimeField_2C = ???;
        this.colors[1] = new UnityEngine.Color();
        this.colors[1] = this.tweenArguments;
        this.colors[1] = new UnityEngine.Color();
        this.colors[1] = this.tweenArguments;
    }
    private void GenerateVector3Targets()
    {
        UnityEngine.Vector3[] val_4;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[3];
        this.vector3s = val_1;
        val_1[0] = new UnityEngine.Vector3();
        val_1[0] = new UnityEngine.Vector3();
        val_1[0] = new UnityEngine.Vector3();
        this.vector3s[1] = new UnityEngine.Vector3();
        this.vector3s[1] = new UnityEngine.Vector3();
        this.vector3s[1] = this.tweenArguments;
        if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
        val_4 = this.vector3s;
        this.time = (System.Math.Abs(UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_4[0], y = val_4[0], z = val_4[0]}, b:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]}))) / null;
    }
    private void GenerateVector2Targets()
    {
        UnityEngine.Vector2[] val_1 = new UnityEngine.Vector2[3];
        this.vector2s = val_1;
        val_1[0] = new UnityEngine.Vector2();
        val_1[0] = this.tweenArguments;
        this.vector2s[1] = new UnityEngine.Vector2();
        this.vector2s[1] = this.tweenArguments;
        if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
        UnityEngine.Vector2 val_4 = this.vector2s[0];
        UnityEngine.Vector2 val_5 = this.vector2s[0];
        UnityEngine.Vector2 val_6 = this.vector2s[1];
        UnityEngine.Vector2 val_7 = this.vector2s[1];
        this.time = (System.Math.Abs(UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}))) / null;
    }
    private void GenerateFloatTargets()
    {
        float[] val_1 = new float[3];
        this.floats = val_1;
        val_1[0] = null;
        this.floats[1] = null;
        if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
        this.time = (System.Math.Abs(this.floats[0] - this.floats[1])) / null;
    }
    private void GenerateColorToTargets()
    {
        UnityEngine.Color[,] val_26;
        var val_27;
        UnityEngine.RectTransform val_28;
        float val_30;
        UnityEngine.Color val_31;
        var val_34;
        var val_35;
        var val_37;
        var val_39;
        var val_41;
        var val_43;
        var val_45;
        var val_46;
        var val_48;
        if((UnityEngine.Object.op_Implicit(exists:  this.GetComponent<UnityEngine.Renderer>())) == false)
        {
            goto label_3;
        }
        
        UnityEngine.Material[] val_4 = this.GetComponent<UnityEngine.Renderer>().materials;
        this.colors = null;
        val_26 = 0;
        goto label_6;
        label_27:
        val_27 = 0;
        this.namedcolorvalue.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
        mem2[0] = null;
        val_28 = 0;
        UnityEngine.Color val_8 = this.GetComponent<UnityEngine.Renderer>().materials[val_27].GetColor(name:  this.namedcolorvalue.ToString());
        if(val_26 >= )
        {
                val_28 = 0;
        }
        
        if(iTween.NamedValueColor == null)
        {
                val_28 = 0;
        }
        
        this.colors[0] = val_8;
        this.colors[0] = val_8.g;
        this.colors[0] = val_8.b;
        this.colors[0] = val_8.a;
        if(val_26 >= val_10.Length)
        {
                val_28 = 0;
        }
        
        this.namedcolorvalue.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_28, drivenProperties:  null);
        mem2[0] = null;
        UnityEngine.Color val_12 = this.GetComponent<UnityEngine.Renderer>().materials[val_27].GetColor(name:  this.namedcolorvalue.ToString());
        val_30 = val_12.r;
        val_31 = val_12.b;
        val_26 = 1;
        this.colors[0] = val_12;
        this.colors[0] = val_12.g;
        this.colors[0] = val_31;
        this.colors[0] = val_12.a;
        label_6:
        UnityEngine.Material[] val_14 = this.GetComponent<UnityEngine.Renderer>().materials;
        if(val_26 < val_14.Length)
        {
            goto label_27;
        }
        
        goto label_38;
        label_3:
        if((UnityEngine.Object.op_Implicit(exists:  this.GetComponent<UnityEngine.Light>())) != false)
        {
                this.colors = null;
            UnityEngine.Color val_18 = this.GetComponent<UnityEngine.Light>().color;
            val_30 = val_18.r;
            val_31 = val_18.b;
            typeof(UnityEngine.Color[,]).__il2cppRuntimeField_30 = val_30;
            typeof(UnityEngine.Color[,]).__il2cppRuntimeField_34 = val_18.g;
            typeof(UnityEngine.Color[,]).__il2cppRuntimeField_38 = val_31;
            typeof(UnityEngine.Color[,]).__il2cppRuntimeField_3C = val_18.a;
            typeof(UnityEngine.Color[,]).__il2cppRuntimeField_20 = val_30;
            typeof(UnityEngine.Color[,]).__il2cppRuntimeField_24 = val_18.g;
            typeof(UnityEngine.Color[,]).__il2cppRuntimeField_28 = val_31;
            typeof(UnityEngine.Color[,]).__il2cppRuntimeField_2C = val_18.a;
        }
        else
        {
                this.colors = null;
        }
        
        label_38:
        val_34 = "color";
        if((this.tweenArguments & 1) == 0)
        {
            goto label_40;
        }
        
        val_35 = 0;
        goto label_41;
        label_47:
        val_35 = 1;
        this.colors[0] = new UnityEngine.Color();
        this.colors[0] = this.tweenArguments;
        this.colors[0] = new UnityEngine.Color();
        this.colors[0] = new UnityEngine.Color();
        label_41:
        if(val_35 < (this.colors.GetLength(dimension:  0)))
        {
            goto label_47;
        }
        
        goto label_77;
        label_40:
        if((this.tweenArguments & 1) == 0)
        {
            goto label_50;
        }
        
        val_34 = 1152921504623566848;
        val_37 = 0;
        goto label_51;
        label_57:
        val_37 = 1;
        mem2[0] = null;
        label_51:
        if(val_37 < (this.colors.GetLength(dimension:  0)))
        {
            goto label_57;
        }
        
        label_50:
        if((this.tweenArguments & 1) == 0)
        {
            goto label_59;
        }
        
        val_39 = 0;
        val_34 = 1;
        goto label_60;
        label_66:
        val_26 = this.colors;
        val_27 = 0;
        val_39 = 1;
        val_26[1] = new UnityEngine.Color();
        label_60:
        if(val_39 < (this.colors.GetLength(dimension:  0)))
        {
            goto label_66;
        }
        
        label_59:
        if((this.tweenArguments & 1) == 0)
        {
            goto label_68;
        }
        
        val_41 = 0;
        val_34 = 1;
        goto label_69;
        label_75:
        val_26 = this.colors;
        val_27 = 0;
        val_41 = 1;
        val_26[1] = new UnityEngine.Color();
        label_69:
        if(val_41 < (this.colors.GetLength(dimension:  0)))
        {
            goto label_75;
        }
        
        label_68:
        if((this.tweenArguments & 1) == 0)
        {
            goto label_77;
        }
        
        val_43 = 0;
        val_34 = 1;
        goto label_78;
        label_84:
        val_26 = this.colors;
        val_27 = 0;
        val_43 = 1;
        val_26[1] = new UnityEngine.Color();
        label_78:
        if(val_43 < (this.colors.GetLength(dimension:  0)))
        {
            goto label_84;
        }
        
        label_77:
        val_45 = "amount";
        if((this.tweenArguments & 1) == 0)
        {
            goto label_86;
        }
        
        val_46 = 0;
        val_34 = 1;
        goto label_87;
        label_93:
        val_26 = this.colors;
        val_27 = 0;
        val_46 = 1;
        val_26[1] = new UnityEngine.Color();
        label_87:
        if(val_46 < (this.colors.GetLength(dimension:  0)))
        {
            goto label_93;
        }
        
        return;
        label_86:
        val_45 = "alpha";
        if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
        val_48 = 0;
        val_34 = 1;
        goto label_97;
        label_103:
        val_26 = this.colors;
        val_27 = 0;
        val_48 = 1;
        val_26[1] = new UnityEngine.Color();
        label_97:
        if(val_48 < (this.colors.GetLength(dimension:  0)))
        {
            goto label_103;
        }
    
    }
    private void GenerateAudioToTargets()
    {
        var val_2;
        var val_9;
        UnityEngine.AudioSource val_10;
        UnityEngine.AudioSource val_11;
        int val_12;
        val_9 = this;
        this.vector2s = new UnityEngine.Vector2[3];
        if((this.tweenArguments & 1) != 0)
        {
                val_10 = this.tweenArguments;
            if((val_10 != null) && (null != null))
        {
                val_10 = 0;
        }
        
            val_11 = val_9;
            this.audioSource = val_10;
        }
        else
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.GetComponent<UnityEngine.AudioSource>())) != false)
        {
                val_10 = this.GetComponent<UnityEngine.AudioSource>();
            val_11 = this.audioSource;
            this.audioSource = val_10;
        }
        else
        {
                UnityEngine.Debug.LogError(message:  "iTween Error: AudioTo requires an AudioSource.");
            this.Dispose();
            val_11 = val_9;
            val_10 = this.audioSource;
        }
        
        }
        
        val_2 = 0;
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_10.volume, y:  this.audioSource.pitch);
        val_12 = this.vector2s.Length;
        if(val_12 <= 1)
        {
                val_12 = this.vector2s.Length;
        }
        
        this.vector2s[1] = val_8.x;
        this.vector2s[1] = val_8.y;
        this.vector2s[0] = val_8.x;
        this.vector2s[0] = val_8.y;
        if((this.tweenArguments & 1) != 0)
        {
                this.vector2s[1] = new UnityEngine.Vector2();
        }
        
        if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
        val_9 = this.tweenArguments;
        this.vector2s[1] = new UnityEngine.Vector2();
    }
    private void GenerateStabTargets()
    {
        UnityEngine.AudioSource val_11;
        UnityEngine.AudioSource val_12;
        UnityEngine.AudioClip val_13;
        if((this.tweenArguments & 1) != 0)
        {
                val_11 = this.tweenArguments;
            if((val_11 != null) && (null != null))
        {
                val_11 = 0;
        }
        
            val_12 = this;
            this.audioSource = val_11;
        }
        else
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.GetComponent<UnityEngine.AudioSource>())) != false)
        {
                val_11 = this.GetComponent<UnityEngine.AudioSource>();
            val_12 = this.audioSource;
            this.audioSource = val_11;
        }
        else
        {
                UnityEngine.AudioSource val_6 = this.gameObject.AddComponent<UnityEngine.AudioSource>();
            UnityEngine.AudioSource val_7 = this.GetComponent<UnityEngine.AudioSource>();
            val_12 = this.audioSource;
            this.audioSource = val_7;
            val_7.playOnAwake = false;
            val_11 = mem[this.audioSource];
        }
        
        }
        
        val_13 = this.tweenArguments;
        if(val_11 == 0)
        {
            goto label_14;
        }
        
        if(val_13 != null)
        {
            goto label_15;
        }
        
        goto label_18;
        label_14:
        if(val_13 == null)
        {
            goto label_18;
        }
        
        label_15:
        if(null != null)
        {
                val_13 = 0;
        }
        
        label_18:
        val_11.clip = val_13;
        if((this.tweenArguments & 1) != 0)
        {
                val_13 = this.tweenArguments;
            this.audioSource.pitch = 4.769568E-36f;
        }
        
        if((this.tweenArguments & 1) != 0)
        {
                val_13 = this.tweenArguments;
            this.audioSource.volume = 4.769568E-36f;
        }
        
        float val_10 = mem[this.audioSource].pitch;
        val_10 = mem[this.audioSource].clip.length / val_10;
        this.time = val_10;
    }
    private void GenerateLookToTargets()
    {
        var val_6;
        var val_7;
        UnityEngine.Transform val_22;
        var val_23;
        UnityEngine.Vector3 val_24;
        var val_25;
        var val_26;
        UnityEngine.Vector3 val_30;
        UnityEngine.Vector3 val_31;
        var val_32;
        var val_33;
        float val_34;
        float val_35;
        float val_36;
        var val_37;
        string val_38;
        string val_39;
        UnityEngine.Vector3[] val_40;
        UnityEngine.Vector3[] val_41;
        UnityEngine.Vector3[] val_42;
        float val_43;
        UnityEngine.Vector3 val_44;
        UnityEngine.Vector3[] val_45;
        UnityEngine.Vector3[] val_46;
        var val_47;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[3];
        this.vector3s = val_1;
        UnityEngine.Vector3 val_2 = this.thisTransform.eulerAngles;
        val_1[0] = val_2;
        val_1[0] = val_2.y;
        val_1[0] = val_2.z;
        if((this.tweenArguments & 1) == 0)
        {
            goto label_5;
        }
        
        val_22 = 1152921504624791552;
        if((System.Type.op_Equality(left:  this.tweenArguments.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_10;
        }
        
        val_23 = this.tweenArguments;
        val_22 = 0;
        if(( & 1) == 0)
        {
            goto label_18;
        }
        
        if(val_23 != null)
        {
                val_23 = 0;
        }
        
        val_24 = val_7;
        val_25 = val_2.y;
        val_26 = val_2.z;
        val_22 = val_23;
        if(this.thisTransform != null)
        {
            goto label_41;
        }
        
        goto label_23;
        label_5:
        UnityEngine.Debug.LogError(message:  "iTween Error: LookTo needs a \'looktarget\' property!");
        this.Dispose();
        goto label_42;
        label_10:
        if((System.Type.op_Equality(left:  this.tweenArguments.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_42;
        }
        
        val_22 = this.tweenArguments;
        if(( & 1) == 0)
        {
            goto label_36;
        }
        
        val_30 = val_7;
        val_31 = val_2.y;
        val_32 = val_2.z;
        if(this.thisTransform != null)
        {
            goto label_45;
        }
        
        goto label_38;
        label_18:
        val_33 = null;
        val_33 = null;
        val_24 = iTween.Defaults.up;
        if(this.thisTransform != null)
        {
            goto label_41;
        }
        
        label_23:
        label_41:
        val_34 = val_24;
        val_35 = iTween.Defaults.time.__il2cppRuntimeField_4C;
        val_36 = iTween.Defaults.time.__il2cppRuntimeField_50;
        this.thisTransform.LookAt(target:  val_22, worldUp:  new UnityEngine.Vector3() {x = val_34, y = val_35, z = val_36});
        goto label_42;
        label_36:
        val_37 = null;
        val_37 = null;
        val_30 = iTween.Defaults.up;
        if(this.thisTransform != null)
        {
            goto label_45;
        }
        
        label_38:
        label_45:
        val_34 = 4.769568E-36f;
        val_35 = val_2.y;
        val_36 = val_2.z;
        this.thisTransform.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_34, y = val_35, z = val_36}, worldUp:  new UnityEngine.Vector3() {x = val_30, y = iTween.Defaults.time.__il2cppRuntimeField_4C, z = iTween.Defaults.time.__il2cppRuntimeField_50});
        label_42:
        UnityEngine.Vector3 val_13 = this.thisTransform.eulerAngles;
        this.vector3s[1] = val_13;
        this.vector3s[1] = val_13.y;
        this.vector3s[1] = val_13.z;
        this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.vector3s[0], y = this.vector3s[0], z = this.vector3s[0]};
        if((this.tweenArguments & 1) == 0)
        {
            goto label_105;
        }
        
        val_38 = this.tweenArguments;
        if(val_38 != null)
        {
                val_38 = 0;
        }
        
        val_39 = "x";
        if((System.String.op_Equality(a:  val_38, b:  val_39)) == false)
        {
            goto label_57;
        }
        
        val_40 = this.vector3s;
        if(this.vector3s == null)
        {
                val_40 = this.vector3s;
            if(val_40 == null)
        {
            goto label_106;
        }
        
        }
        
        if(this.vector3s.Length == 0)
        {
                val_39 = 0;
        }
        
        if(this.vector3s.Length <= 1)
        {
                val_39 = 0;
        }
        
        this.vector3s[1] = val_40[0];
        goto label_62;
        label_57:
        val_39 = "y";
        if((System.String.op_Equality(a:  val_38, b:  val_39)) == false)
        {
            goto label_63;
        }
        
        val_41 = this.vector3s;
        if(this.vector3s == null)
        {
                val_41 = this.vector3s;
            if(val_41 == null)
        {
            goto label_106;
        }
        
        }
        
        if(this.vector3s.Length == 0)
        {
                val_39 = 0;
        }
        
        if(this.vector3s.Length <= 1)
        {
                val_39 = 0;
        }
        
        this.vector3s[1] = val_41[0];
        label_62:
        val_42 = this.vector3s;
        if(this.vector3s == null)
        {
                val_42 = this.vector3s;
            if(val_42 == null)
        {
            goto label_106;
        }
        
        }
        
        this.vector3s[1] = val_42[0];
        label_105:
        val_43 = this.clerp(start:  this.vector3s[0], end:  this.vector3s[1], value:  1f);
        float val_17 = this.clerp(start:  this.vector3s[0], end:  this.vector3s[1], value:  1f);
        val_44 = this.vector3s[0];
        float val_18 = this.clerp(start:  val_44, end:  this.vector3s[1], value:  1f);
        val_6 = 0;
        this.vector3s[1] = 0;
        this.vector3s[1] = 0;
        this.vector3s[1] = 0;
        if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
        val_44 = this.vector3s[0];
        val_31 = this.vector3s[1];
        val_43 = System.Math.Abs(UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = this.vector3s[0], z = val_44}, b:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = val_31}));
        this.time = val_43 / null;
        return;
        label_63:
        val_39 = "z";
        if((System.String.op_Equality(a:  val_38, b:  val_39)) == false)
        {
            goto label_105;
        }
        
        val_45 = this.vector3s;
        if(this.vector3s == null)
        {
                val_45 = this.vector3s;
            if(val_45 == null)
        {
            goto label_106;
        }
        
        }
        
        if(this.vector3s.Length == 0)
        {
                val_39 = 0;
        }
        
        if(this.vector3s.Length <= 1)
        {
                val_39 = 0;
        }
        
        this.vector3s[1] = val_45[0];
        val_46 = this.vector3s;
        if(this.vector3s == null)
        {
                val_46 = this.vector3s;
            if(val_46 == null)
        {
            goto label_106;
        }
        
        }
        
        this.vector3s[1] = val_46[0];
        goto label_105;
        label_106:
        val_47 = 0;
    }
    private void GenerateMoveToPathTargets()
    {
        System.Array val_34;
        var val_35;
        var val_36;
        var val_37;
        System.Array val_38;
        var val_39;
        float val_43;
        var val_44;
        var val_45;
        UnityEngine.Vector3[] val_46;
        var val_47;
        UnityEngine.Vector3[] val_48;
        UnityEngine.Vector3 val_49;
        int val_50;
        if((System.Type.op_Equality(left:  this.tweenArguments.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_6;
        }
        
        if(this.tweenArguments == null)
        {
            goto label_7;
        }
        
        val_34 = this.tweenArguments;
        if(val_34 != null)
        {
            goto label_8;
        }
        
        label_7:
        val_34 = 0;
        label_8:
        if(10260432 != 1)
        {
            goto label_9;
        }
        
        UnityEngine.Debug.LogError(message:  "iTween Error: Attempting a path movement with MoveTo requires an array of more than 1 entry!");
        this.Dispose();
        val_35 = 10260432;
        goto label_12;
        label_6:
        if(this.tweenArguments == null)
        {
            goto label_13;
        }
        
        val_36 = this.tweenArguments;
        if(val_36 == null)
        {
            goto label_14;
        }
        
        val_37 = val_36;
        goto label_15;
        label_9:
        val_35 = 10260432 & 4294967295;
        label_12:
        UnityEngine.Vector3[] val_5 = new UnityEngine.Vector3[0];
        val_38 = val_5;
        System.Array.Copy(sourceArray:  val_34, destinationArray:  val_5, length:  10260432);
        goto label_21;
        label_14:
        label_13:
        val_36 = 0;
        val_37 = 0;
        label_15:
        if(10260432 == 1)
        {
                UnityEngine.Debug.LogError(message:  "iTween Error: Attempting a path movement with MoveTo requires an array of more than 1 entry!");
            this.Dispose();
            val_39 = 10260432;
        }
        else
        {
                val_39 = 10260432 & 4294967295;
        }
        
        UnityEngine.Vector3[] val_6 = new UnityEngine.Vector3[0];
        val_38 = val_6;
        if(10260432 >= 1)
        {
                do
        {
            var val_7 = val_36 + 0;
            UnityEngine.Vector3 val_8 = (val_36 + 0) + 32.position;
            var val_9 = val_38 + (0 * 12);
            mem2[0] = val_8.x;
            mem2[0] = val_8.y;
            mem2[0] = val_8.z;
        }
        while((0 + 1) < 10260432);
        
        }
        
        label_21:
        UnityEngine.Vector3 val_11 = this.thisTransform.position;
        val_43 = val_11.z;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_43}, rhs:  new UnityEngine.Vector3() {x = val_38[0], y = val_38[0], z = val_38[0]})) == false)
        {
            goto label_32;
        }
        
        if((this.tweenArguments & 1) == 0)
        {
            goto label_34;
        }
        
        var val_13 = (null != 0) ? 1 : 0;
        var val_14 = (null != 0) ? (2 + 1) : 2;
        goto label_37;
        label_32:
        val_44 = 0;
        val_45 = 2;
        goto label_37;
        label_34:
        val_44 = 1;
        val_45 = 3;
        label_37:
        int val_15 = val_6.Length + val_45;
        UnityEngine.Vector3[] val_16 = new UnityEngine.Vector3[0];
        val_46 = val_16;
        this.vector3s = val_46;
        if(val_44 != 0)
        {
                UnityEngine.Vector3 val_17 = this.thisTransform.position;
            val_43 = val_17.z;
            val_46[1] = val_17;
            val_46[1] = val_17.y;
            val_46[1] = val_43;
            val_46 = this.vector3s;
            val_47 = 2;
        }
        else
        {
                val_47 = 1;
        }
        
        System.Array.Copy(sourceArray:  val_6, sourceIndex:  0, destinationArray:  val_16, destinationIndex:  1, length:  val_6.Length);
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]}, b:  new UnityEngine.Vector3() {x = this.vector3s[2], y = this.vector3s[2], z = this.vector3s[2]});
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        this.vector3s[0] = val_19;
        this.vector3s[0] = val_19.y;
        this.vector3s[0] = val_19.z;
        val_48 = this.vector3s;
        if(this.vector3s == null)
        {
                val_48 = this.vector3s;
        }
        
        var val_49 = -8589934592;
        val_49 = val_49 + ((this.vector3s.Length) << 32);
        var val_50 = 12;
        val_50 = val_48 + ((val_49 >> 32) * val_50);
        var val_51 = -8589934592;
        val_51 = val_51 + ((this.vector3s.Length) << 32);
        var val_52 = 12;
        val_52 = this.vector3s + ((val_51 >> 32) * val_52);
        var val_53 = 12;
        val_53 = this.vector3s + ((((-12884901888) + ((this.vector3s.Length) << 32)) >> 32) * val_53);
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (((-8589934592 + (this.vector3s.Length) << 32) >> 32) * 12) + this.vector3s + 32, y = (((-8589934592 + (this.vector3s.Length) << 32) >> 32) * 12) + this.vector3s + 32 + 4, z = (((-8589934592 + (this.vector3s.Length) << 32) >> 32) * 12) + this.vector3s + 40}, b:  new UnityEngine.Vector3() {x = (((-12884901888 + (this.vector3s.Length) << 32) >> 32) * 12) + this.vector3s + 32, y = (((-12884901888 + (this.vector3s.Length) << 32) >> 32) * 12) + this.vector3s + 32 + 4, z = (((-12884901888 + (this.vector3s.Length) << 32) >> 32) * 12) + this.vector3s + 40});
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (((-8589934592 + (this.vector3s.Length) << 32) >> 32) * 12) + this.vector3s + 32, y = (((-8589934592 + (this.vector3s.Length) << 32) >> 32) * 12) + this.vector3s + 32 + 4, z = (((-8589934592 + (this.vector3s.Length) << 32) >> 32) * 12) + this.vector3s + 40}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        var val_54 = -4294967296;
        val_54 = val_54 + ((this.vector3s.Length) << 32);
        var val_55 = 12;
        val_55 = this.vector3s + ((val_54 >> 32) * val_55);
        mem2[0] = val_25.x;
        mem2[0] = val_25.y;
        mem2[0] = val_25.z;
        val_49 = this.vector3s[1];
        var val_58 = -8589934592;
        val_58 = val_58 + ((this.vector3s.Length) << 32);
        var val_59 = 12;
        val_59 = this.vector3s + ((val_58 >> 32) * val_59);
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_49, y = this.vector3s[1], z = this.vector3s[1]}, rhs:  new UnityEngine.Vector3() {x = (((-8589934592 + (this.vector3s.Length) << 32) >> 32) * 12) + this.vector3s + 32, y = (((-8589934592 + (this.vector3s.Length) << 32) >> 32) * 12) + this.vector3s + 32 + 4, z = (((-8589934592 + (this.vector3s.Length) << 32) >> 32) * 12) + this.vector3s + 40})) != false)
        {
                UnityEngine.Vector3[] val_29 = new UnityEngine.Vector3[0];
            System.Array.Copy(sourceArray:  this.vector3s, destinationArray:  val_29, length:  this.vector3s.Length);
            val_50 = val_29.Length;
            if(val_50 <= 2)
        {
                val_50 = val_29.Length;
        }
        
            var val_60 = 12;
            val_60 = val_29 + ((((-12884901888) + ((val_29.Length) << 32)) >> 32) * val_60);
            if(val_50 == 0)
        {
                val_50 = val_29.Length;
        }
        
            val_29[0] = (((-12884901888 + (val_29.Length) << 32) >> 32) * 12) + val_29 + 32;
            val_29[0] = (((-12884901888 + (val_29.Length) << 32) >> 32) * 12) + val_29 + 32 + 4;
            val_29[0] = (((-12884901888 + (val_29.Length) << 32) >> 32) * 12) + val_29 + 40;
            if(val_50 <= 2)
        {
                val_50 = val_29.Length;
        }
        
            var val_64 = -4294967296;
            val_64 = val_64 + ((val_29.Length) << 32);
            var val_65 = 12;
            val_65 = val_29 + ((val_64 >> 32) * val_65);
            mem2[0] = val_29[2];
            mem2[0] = val_29[2];
            mem2[0] = val_29[2];
            UnityEngine.Vector3[] val_33 = new UnityEngine.Vector3[0];
            this.vector3s = val_33;
            System.Array.Copy(sourceArray:  val_29, destinationArray:  val_33, length:  val_29.Length);
        }
        
        this.path = new iTween.CRSpline(pts:  this.vector3s);
        if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
        val_49 = iTween.PathLength(path:  this.vector3s);
        this.time = val_49 / null;
    }
    private void GenerateMoveToTargets()
    {
        UnityEngine.Vector3 val_8;
        float val_18;
        UnityEngine.Vector3 val_19;
        UnityEngine.Vector3 val_20;
        int val_21;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[3];
        this.vector3s = val_1;
        if(this.thisTransform == null)
        {
            goto label_1;
        }
        
        if(this.isLocal == false)
        {
            goto label_2;
        }
        
        label_4:
        UnityEngine.Vector3 val_2 = this.thisTransform.localPosition;
        goto label_3;
        label_1:
        if(this.isLocal == true)
        {
            goto label_4;
        }
        
        label_2:
        UnityEngine.Vector3 val_3 = this.thisTransform.position;
        label_3:
        val_18 = val_3.x;
        val_19 = val_3.y;
        val_20 = val_3.z;
        val_21 = val_1.Length;
        if(val_21 <= 1)
        {
                val_21 = val_1.Length;
        }
        
        val_1[1] = val_3;
        val_1[1] = val_19;
        val_1[1] = val_20;
        val_1[0] = val_3;
        val_1[0] = val_19;
        val_1[0] = val_20;
        if(this.tweenArguments == null)
        {
            goto label_9;
        }
        
        if((this.tweenArguments & 1) == 0)
        {
            goto label_10;
        }
        
        label_22:
        if((System.Type.op_Equality(left:  this.tweenArguments.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_15;
        }
        
        if(this.tweenArguments != null)
        {
            
        }
        
        UnityEngine.Vector3 val_9 = 0.position;
        val_18 = val_9.x;
        val_19 = val_9.y;
        val_20 = val_9.z;
        this.vector3s[1] = val_9;
        this.vector3s[1] = val_19;
        this.vector3s[1] = val_20;
        goto label_41;
        label_9:
        if((this.tweenArguments & 1) != 0)
        {
            goto label_22;
        }
        
        label_10:
        if((this.tweenArguments & 1) != 0)
        {
                this.vector3s[1] = new UnityEngine.Vector3();
        }
        
        if((this.tweenArguments & 1) != 0)
        {
                this.vector3s[1] = new UnityEngine.Vector3();
        }
        
        if((this.tweenArguments & 1) == 0)
        {
            goto label_41;
        }
        
        this.vector3s[1] = new UnityEngine.Vector3();
        goto label_41;
        label_15:
        if((System.Type.op_Equality(left:  this.tweenArguments.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
        {
                this.vector3s[1] = new UnityEngine.Vector3();
            this.vector3s[1] = "position";
            this.vector3s[1] = this.tweenArguments;
        }
        
        label_41:
        if(((this.tweenArguments & 1) != 0) && (null != null))
        {
                UnityEngine.Vector3 val_16 = this.vector3s[1];
            val_8 = this.vector3s[1];
        }
        
        if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
        val_20 = this.vector3s[0];
        val_18 = System.Math.Abs(UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = this.vector3s[0], z = val_20}, b:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]}));
        this.time = val_18 / null;
    }
    private void GenerateMoveByTargets()
    {
        UnityEngine.Vector3 val_13;
        int val_14;
        UnityEngine.Vector3[] val_15;
        UnityEngine.Vector3 val_16;
        UnityEngine.Vector3[] val_17;
        UnityEngine.Vector3[] val_18;
        UnityEngine.Vector3[] val_19;
        UnityEngine.Vector3 val_20;
        UnityEngine.Vector3 val_21;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[6];
        this.vector3s = val_1;
        UnityEngine.Vector3 val_2 = this.thisTransform.eulerAngles;
        val_1[4] = val_2;
        val_1[4] = val_2.y;
        val_1[4] = val_2.z;
        UnityEngine.Vector3 val_3 = this.thisTransform.position;
        val_13 = val_3.y;
        val_14 = this.vector3s.Length;
        if(val_14 <= 3)
        {
                val_14 = this.vector3s.Length;
        }
        
        this.vector3s[3] = val_3;
        this.vector3s[3] = val_13;
        this.vector3s[3] = val_3.z;
        if(val_14 <= 1)
        {
                val_14 = this.vector3s.Length;
        }
        
        this.vector3s[1] = val_3;
        this.vector3s[1] = val_13;
        this.vector3s[1] = val_3.z;
        this.vector3s[0] = val_3;
        this.vector3s[0] = val_13;
        this.vector3s[0] = val_3.z;
        if((this.tweenArguments & 1) == 0)
        {
            goto label_10;
        }
        
        val_15 = this.vector3s;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15[0], y = val_15[0], z = val_15[0]}, b:  new UnityEngine.Vector3() {x = 4.769568E-36f});
        val_13 = val_4.x;
        val_16 = val_4.z;
        val_15[1] = val_4;
        val_15[1] = val_4.y;
        goto label_17;
        label_10:
        if((this.tweenArguments & 1) == 0)
        {
            goto label_19;
        }
        
        val_17 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_20;
        }
        
        val_17 = this.vector3s;
        if(val_17 == null)
        {
            goto label_35;
        }
        
        label_20:
        this.vector3s[1] = val_17[0] + null;
        label_19:
        if((this.tweenArguments & 1) == 0)
        {
            goto label_26;
        }
        
        val_18 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_27;
        }
        
        val_18 = this.vector3s;
        if(val_18 == null)
        {
            goto label_35;
        }
        
        label_27:
        this.vector3s[1] = val_18[0] + null;
        label_26:
        if((this.tweenArguments & 1) == 0)
        {
            goto label_33;
        }
        
        val_15 = this.vector3s;
        val_19 = val_15;
        if(val_15 != null)
        {
            goto label_34;
        }
        
        val_19 = this.vector3s;
        if(val_19 == null)
        {
            goto label_35;
        }
        
        label_34:
        val_16 = val_19[0] + null;
        label_17:
        val_15[1] = val_16;
        label_33:
        this.thisTransform.Translate(translation:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]}, relativeTo:  this.space);
        UnityEngine.Vector3 val_7 = this.thisTransform.position;
        this.vector3s[5] = val_7;
        this.vector3s[5] = val_7.y;
        this.vector3s[5] = val_7.z;
        val_20 = this.vector3s[0];
        val_21 = this.vector3s[0];
        this.thisTransform.position = new UnityEngine.Vector3() {x = val_20, y = this.vector3s[0], z = val_21};
        if(((this.tweenArguments & 1) != 0) && (null != null))
        {
                UnityEngine.Vector3 val_20 = this.vector3s[1];
            UnityEngine.Vector3 val_21 = this.vector3s[1];
        }
        
        if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
        val_21 = this.vector3s[0];
        val_20 = System.Math.Abs(UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = this.vector3s[0], z = val_21}, b:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]}));
        this.time = val_20 / null;
        return;
        label_35:
    }
    private void GenerateScaleToTargets()
    {
        float val_17;
        UnityEngine.Vector3 val_18;
        UnityEngine.Vector3 val_19;
        int val_20;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[3];
        this.vector3s = val_1;
        UnityEngine.Vector3 val_2 = this.thisTransform.localScale;
        val_17 = val_2.x;
        val_18 = val_2.y;
        val_19 = val_2.z;
        val_20 = val_1.Length;
        if(val_20 <= 1)
        {
                val_20 = val_1.Length;
        }
        
        val_1[1] = val_2;
        val_1[1] = val_18;
        val_1[1] = val_19;
        val_1[0] = val_2;
        val_1[0] = val_18;
        val_1[0] = val_19;
        if(this.tweenArguments == null)
        {
            goto label_6;
        }
        
        if((this.tweenArguments & 1) == 0)
        {
            goto label_7;
        }
        
        label_19:
        if((System.Type.op_Equality(left:  this.tweenArguments.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_12;
        }
        
        UnityEngine.Vector3 val_8 = 0.localScale;
        val_17 = val_8.x;
        val_18 = val_8.y;
        val_19 = val_8.z;
        this.vector3s[1] = val_8;
        this.vector3s[1] = val_18;
        this.vector3s[1] = val_19;
        goto label_38;
        label_6:
        if((this.tweenArguments & 1) != 0)
        {
            goto label_19;
        }
        
        label_7:
        if((this.tweenArguments & 1) != 0)
        {
                this.vector3s[1] = new UnityEngine.Vector3();
        }
        
        if((this.tweenArguments & 1) != 0)
        {
                this.vector3s[1] = new UnityEngine.Vector3();
        }
        
        if((this.tweenArguments & 1) == 0)
        {
            goto label_38;
        }
        
        this.vector3s[1] = new UnityEngine.Vector3();
        goto label_38;
        label_12:
        if((System.Type.op_Equality(left:  this.tweenArguments.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
        {
                this.vector3s[1] = new UnityEngine.Vector3();
            this.vector3s[1] = "scale";
            this.vector3s[1] = this.tweenArguments;
        }
        
        label_38:
        if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
        val_19 = this.vector3s[0];
        val_17 = System.Math.Abs(UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = this.vector3s[0], z = val_19}, b:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]}));
        this.time = val_17 / null;
    }
    private void GenerateScaleByTargets()
    {
        UnityEngine.Vector3 val_12;
        UnityEngine.Vector3 val_13;
        UnityEngine.Vector3 val_14;
        int val_15;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[3];
        this.vector3s = val_1;
        UnityEngine.Vector3 val_2 = this.thisTransform.localScale;
        val_12 = val_2.x;
        val_13 = val_2.y;
        val_14 = val_2.z;
        val_15 = val_1.Length;
        if(val_15 <= 1)
        {
                val_15 = val_1.Length;
        }
        
        val_1[1] = val_2;
        val_1[1] = val_13;
        val_1[1] = val_14;
        val_1[0] = val_2;
        val_1[0] = val_13;
        val_1[0] = val_14;
        if((this.tweenArguments & 1) != 0)
        {
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.Scale(a:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]}, b:  new UnityEngine.Vector3() {x = 4.769568E-36f});
            val_12 = val_3.x;
            val_13 = val_3.y;
            val_14 = val_3.z;
            this.vector3s[1] = val_3;
            this.vector3s[1] = val_13;
            this.vector3s[1] = val_14;
        }
        else
        {
                if((this.tweenArguments & 1) != 0)
        {
                val_12 = this.vector3s[1];
            this.vector3s[1] = val_12 * null;
        }
        
            if((this.tweenArguments & 1) != 0)
        {
                val_12 = this.vector3s[1];
            this.vector3s[1] = val_12 * null;
        }
        
            if((this.tweenArguments & 1) != 0)
        {
                val_12 = this.vector3s[1];
            this.vector3s[1] = val_12 * null;
        }
        
        }
        
        if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
        val_14 = this.vector3s[0];
        val_12 = System.Math.Abs(UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = this.vector3s[0], z = val_14}, b:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]}));
        this.time = val_12 / null;
    }
    private void GenerateScaleAddTargets()
    {
        UnityEngine.Vector3 val_12;
        UnityEngine.Vector3 val_13;
        UnityEngine.Vector3 val_14;
        int val_15;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[3];
        this.vector3s = val_1;
        UnityEngine.Vector3 val_2 = this.thisTransform.localScale;
        val_12 = val_2.x;
        val_13 = val_2.y;
        val_14 = val_2.z;
        val_15 = val_1.Length;
        if(val_15 <= 1)
        {
                val_15 = val_1.Length;
        }
        
        val_1[1] = val_2;
        val_1[1] = val_13;
        val_1[1] = val_14;
        val_1[0] = val_2;
        val_1[0] = val_13;
        val_1[0] = val_14;
        if((this.tweenArguments & 1) != 0)
        {
                val_12 = this.vector3s[1];
            val_13 = this.vector3s[1];
            val_14 = this.vector3s[1];
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14}, b:  new UnityEngine.Vector3() {x = 4.769568E-36f});
            this.vector3s[1] = val_3;
            this.vector3s[1] = val_3.y;
            this.vector3s[1] = val_3.z;
        }
        else
        {
                if((this.tweenArguments & 1) != 0)
        {
                val_12 = this.vector3s[1];
            this.vector3s[1] = val_12 + null;
        }
        
            if((this.tweenArguments & 1) != 0)
        {
                val_12 = this.vector3s[1];
            this.vector3s[1] = val_12 + null;
        }
        
            if((this.tweenArguments & 1) != 0)
        {
                val_12 = this.vector3s[1];
            this.vector3s[1] = val_12 + null;
        }
        
        }
        
        if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
        val_14 = this.vector3s[0];
        val_12 = System.Math.Abs(UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = this.vector3s[0], z = val_14}, b:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]}));
        this.time = val_12 / null;
    }
    private void GenerateRotateToTargets()
    {
        var val_8;
        int val_21;
        var val_22;
        float val_23;
        UnityEngine.Vector3 val_24;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[3];
        this.vector3s = val_1;
        if(this.thisTransform == null)
        {
            goto label_1;
        }
        
        if(this.isLocal == false)
        {
            goto label_2;
        }
        
        label_4:
        UnityEngine.Vector3 val_2 = this.thisTransform.localEulerAngles;
        goto label_3;
        label_1:
        if(this.isLocal == true)
        {
            goto label_4;
        }
        
        label_2:
        UnityEngine.Vector3 val_3 = this.thisTransform.eulerAngles;
        label_3:
        val_21 = val_1.Length;
        if(val_21 <= 1)
        {
                val_21 = val_1.Length;
        }
        
        val_1[1] = val_3;
        val_1[1] = val_3.y;
        val_1[1] = val_3.z;
        val_1[0] = val_3;
        val_1[0] = val_3.y;
        val_1[0] = val_3.z;
        if(this.tweenArguments == null)
        {
            goto label_9;
        }
        
        if((this.tweenArguments & 1) == 0)
        {
            goto label_10;
        }
        
        label_22:
        val_22 = 1152921504624791552;
        if((System.Type.op_Equality(left:  this.tweenArguments.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_15;
        }
        
        if(this.tweenArguments != null)
        {
            
        }
        
        UnityEngine.Vector3 val_9 = 0.eulerAngles;
        this.vector3s[1] = val_9;
        this.vector3s[1] = val_9.y;
        this.vector3s[1] = val_9.z;
        goto label_41;
        label_9:
        if((this.tweenArguments & 1) != 0)
        {
            goto label_22;
        }
        
        label_10:
        if((this.tweenArguments & 1) != 0)
        {
                this.vector3s[1] = new UnityEngine.Vector3();
        }
        
        if((this.tweenArguments & 1) != 0)
        {
                this.vector3s[1] = new UnityEngine.Vector3();
        }
        
        if((this.tweenArguments & 1) == 0)
        {
            goto label_41;
        }
        
        this.vector3s[1] = new UnityEngine.Vector3();
        goto label_41;
        label_15:
        if((System.Type.op_Equality(left:  this.tweenArguments.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
        {
                this.vector3s[1] = new UnityEngine.Vector3();
            this.vector3s[1] = "rotation";
            this.vector3s[1] = this.tweenArguments;
        }
        
        label_41:
        val_23 = this.clerp(start:  this.vector3s[0], end:  this.vector3s[1], value:  1f);
        float val_14 = this.clerp(start:  this.vector3s[0], end:  this.vector3s[1], value:  1f);
        val_24 = this.vector3s[0];
        float val_15 = this.clerp(start:  val_24, end:  this.vector3s[1], value:  1f);
        val_8 = 0;
        this.vector3s[1] = 0;
        this.vector3s[1] = 0;
        this.vector3s[1] = 0;
        if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
        val_24 = this.vector3s[0];
        val_23 = System.Math.Abs(UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = this.vector3s[0], z = val_24}, b:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]}));
        this.time = val_23 / null;
    }
    private void GenerateRotateAddTargets()
    {
        UnityEngine.Vector3 val_12;
        UnityEngine.Vector3 val_13;
        UnityEngine.Vector3 val_14;
        int val_15;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[5];
        this.vector3s = val_1;
        UnityEngine.Vector3 val_2 = this.thisTransform.eulerAngles;
        val_12 = val_2.x;
        val_13 = val_2.y;
        val_14 = val_2.z;
        val_15 = val_1.Length;
        if(val_15 <= 3)
        {
                val_15 = val_1.Length;
        }
        
        val_1[3] = val_2;
        val_1[3] = val_13;
        val_1[3] = val_14;
        if(val_15 <= 1)
        {
                val_15 = val_1.Length;
        }
        
        val_1[1] = val_2;
        val_1[1] = val_13;
        val_1[1] = val_14;
        val_1[0] = val_2;
        val_1[0] = val_13;
        val_1[0] = val_14;
        if((this.tweenArguments & 1) != 0)
        {
                val_12 = this.vector3s[1];
            val_13 = this.vector3s[1];
            val_14 = this.vector3s[1];
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14}, b:  new UnityEngine.Vector3() {x = 4.769568E-36f});
            this.vector3s[1] = val_3;
            this.vector3s[1] = val_3.y;
            this.vector3s[1] = val_3.z;
        }
        else
        {
                if((this.tweenArguments & 1) != 0)
        {
                val_12 = this.vector3s[1];
            this.vector3s[1] = val_12 + null;
        }
        
            if((this.tweenArguments & 1) != 0)
        {
                val_12 = this.vector3s[1];
            this.vector3s[1] = val_12 + null;
        }
        
            if((this.tweenArguments & 1) != 0)
        {
                val_12 = this.vector3s[1];
            this.vector3s[1] = val_12 + null;
        }
        
        }
        
        if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
        val_14 = this.vector3s[0];
        val_12 = System.Math.Abs(UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = this.vector3s[0], z = val_14}, b:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]}));
        this.time = val_12 / null;
    }
    private void GenerateRotateByTargets()
    {
        UnityEngine.Vector3 val_13;
        UnityEngine.Vector3 val_14;
        UnityEngine.Vector3 val_15;
        int val_16;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[4];
        this.vector3s = val_1;
        UnityEngine.Vector3 val_2 = this.thisTransform.eulerAngles;
        val_13 = val_2.x;
        val_14 = val_2.y;
        val_15 = val_2.z;
        val_16 = val_1.Length;
        if(val_16 <= 3)
        {
                val_16 = val_1.Length;
        }
        
        val_1[3] = val_2;
        val_1[3] = val_14;
        val_1[3] = val_15;
        if(val_16 <= 1)
        {
                val_16 = val_1.Length;
        }
        
        val_1[1] = val_2;
        val_1[1] = val_14;
        val_1[1] = val_15;
        val_1[0] = val_2;
        val_1[0] = val_14;
        val_1[0] = val_15;
        if((this.tweenArguments & 1) != 0)
        {
                val_13 = this.vector3s[1];
            val_14 = this.vector3s[1];
            val_15 = this.vector3s[1];
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.Scale(a:  new UnityEngine.Vector3() {x = 4.769568E-36f, y = 360f, z = 360f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.vector3s[1] = val_4;
            this.vector3s[1] = val_4.y;
            this.vector3s[1] = val_4.z;
        }
        else
        {
                if((this.tweenArguments & 1) != 0)
        {
                val_13 = this.vector3s[1];
            float val_5 = null * 360f;
            val_5 = val_13 + val_5;
            this.vector3s[1] = val_5;
        }
        
            if((this.tweenArguments & 1) != 0)
        {
                val_13 = this.vector3s[1];
            float val_6 = null * 360f;
            val_6 = val_13 + val_6;
            this.vector3s[1] = val_6;
        }
        
            if((this.tweenArguments & 1) != 0)
        {
                val_13 = this.vector3s[1];
            float val_7 = null * 360f;
            val_7 = val_13 + val_7;
            this.vector3s[1] = val_7;
        }
        
        }
        
        if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
        val_15 = this.vector3s[0];
        val_13 = System.Math.Abs(UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = this.vector3s[0], z = val_15}, b:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]}));
        this.time = val_13 / null;
    }
    private void GenerateShakePositionTargets()
    {
        var val_4;
        UnityEngine.Vector3[] val_5;
        val_4 = this;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[4];
        this.vector3s = val_1;
        UnityEngine.Vector3 val_2 = this.thisTransform.eulerAngles;
        val_1[3] = val_2;
        val_1[3] = val_2.y;
        val_1[3] = val_2.z;
        val_5 = this.vector3s;
        UnityEngine.Vector3 val_3 = this.thisTransform.position;
        val_5[0] = val_3;
        val_5[0] = val_3.y;
        val_5[0] = val_3.z;
        if((this.tweenArguments & 1) != 0)
        {
                val_5 = this.vector3s;
            val_5[1] = new UnityEngine.Vector3();
            val_5[1] = this.tweenArguments;
        }
        else
        {
                if((this.tweenArguments & 1) != 0)
        {
                val_5 = this.vector3s;
            val_5[1] = new UnityEngine.Vector3();
        }
        
            if((this.tweenArguments & 1) != 0)
        {
                val_5 = this.vector3s;
            val_5[1] = new UnityEngine.Vector3();
        }
        
            if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
            val_5 = this.vector3s;
        }
        
        val_5[1] = new UnityEngine.Vector3();
    }
    private void GenerateShakeScaleTargets()
    {
        var val_3;
        UnityEngine.Transform val_4;
        val_3 = this;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[3];
        val_4 = this.thisTransform;
        this.vector3s = val_1;
        UnityEngine.Vector3 val_2 = val_4.localScale;
        val_1[0] = val_2;
        val_1[0] = val_2.y;
        val_1[0] = val_2.z;
        if((this.tweenArguments & 1) != 0)
        {
                val_4 = this.vector3s;
            val_4[1] = new UnityEngine.Vector3();
            val_4[1] = this.tweenArguments;
        }
        else
        {
                if((this.tweenArguments & 1) != 0)
        {
                val_4 = this.vector3s;
            val_4[1] = new UnityEngine.Vector3();
        }
        
            if((this.tweenArguments & 1) != 0)
        {
                val_4 = this.vector3s;
            val_4[1] = new UnityEngine.Vector3();
        }
        
            if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
            val_4 = this.vector3s;
        }
        
        val_4[1] = new UnityEngine.Vector3();
    }
    private void GenerateShakeRotationTargets()
    {
        var val_3;
        UnityEngine.Transform val_4;
        val_3 = this;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[3];
        val_4 = this.thisTransform;
        this.vector3s = val_1;
        UnityEngine.Vector3 val_2 = val_4.eulerAngles;
        val_1[0] = val_2;
        val_1[0] = val_2.y;
        val_1[0] = val_2.z;
        if((this.tweenArguments & 1) != 0)
        {
                val_4 = this.vector3s;
            val_4[1] = new UnityEngine.Vector3();
            val_4[1] = this.tweenArguments;
        }
        else
        {
                if((this.tweenArguments & 1) != 0)
        {
                val_4 = this.vector3s;
            val_4[1] = new UnityEngine.Vector3();
        }
        
            if((this.tweenArguments & 1) != 0)
        {
                val_4 = this.vector3s;
            val_4[1] = new UnityEngine.Vector3();
        }
        
            if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
            val_4 = this.vector3s;
        }
        
        val_4[1] = new UnityEngine.Vector3();
    }
    private void GeneratePunchPositionTargets()
    {
        var val_5;
        int val_6;
        UnityEngine.Vector3[] val_7;
        var val_8;
        val_5 = this;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[5];
        this.vector3s = val_1;
        UnityEngine.Vector3 val_2 = this.thisTransform.eulerAngles;
        val_1[4] = val_2;
        val_1[4] = val_2.y;
        val_1[4] = val_2.z;
        UnityEngine.Vector3 val_3 = this.thisTransform.position;
        this.vector3s[0] = val_3;
        this.vector3s[0] = val_3.y;
        this.vector3s[0] = val_3.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        val_6 = this.vector3s.Length;
        if(val_6 <= 3)
        {
                val_6 = this.vector3s.Length;
        }
        
        this.vector3s[3] = val_4;
        this.vector3s[3] = val_4.y;
        this.vector3s[3] = val_4.z;
        this.vector3s[1] = val_4;
        this.vector3s[1] = val_4.y;
        this.vector3s[1] = val_4.z;
        if((this.tweenArguments & 1) != 0)
        {
                val_7 = this.vector3s;
            val_7[1] = new UnityEngine.Vector3();
            val_7[1] = this.tweenArguments;
        }
        else
        {
                if((this.tweenArguments & 1) != 0)
        {
                this.vector3s[1] = new UnityEngine.Vector3();
        }
        
            if((this.tweenArguments & 1) != 0)
        {
                this.vector3s[1] = new UnityEngine.Vector3();
        }
        
            val_8 = "z";
            if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
            val_7 = this.vector3s;
        }
        
        val_7[1] = new UnityEngine.Vector3();
    }
    private void GeneratePunchRotationTargets()
    {
        var val_4;
        int val_5;
        UnityEngine.Vector3[] val_6;
        var val_7;
        val_4 = this;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[4];
        this.vector3s = val_1;
        UnityEngine.Vector3 val_2 = this.thisTransform.eulerAngles;
        val_1[0] = val_2;
        val_1[0] = val_2.y;
        val_1[0] = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        val_5 = this.vector3s.Length;
        if(val_5 <= 3)
        {
                val_5 = this.vector3s.Length;
        }
        
        this.vector3s[3] = val_3;
        this.vector3s[3] = val_3.y;
        this.vector3s[3] = val_3.z;
        this.vector3s[1] = val_3;
        this.vector3s[1] = val_3.y;
        this.vector3s[1] = val_3.z;
        if((this.tweenArguments & 1) != 0)
        {
                val_6 = this.vector3s;
            val_6[1] = new UnityEngine.Vector3();
            val_6[1] = this.tweenArguments;
        }
        else
        {
                if((this.tweenArguments & 1) != 0)
        {
                this.vector3s[1] = new UnityEngine.Vector3();
        }
        
            if((this.tweenArguments & 1) != 0)
        {
                this.vector3s[1] = new UnityEngine.Vector3();
        }
        
            val_7 = "z";
            if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
            val_6 = this.vector3s;
        }
        
        val_6[1] = new UnityEngine.Vector3();
    }
    private void GeneratePunchScaleTargets()
    {
        var val_4;
        UnityEngine.Transform val_5;
        val_4 = this;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[3];
        val_5 = this.thisTransform;
        this.vector3s = val_1;
        UnityEngine.Vector3 val_2 = val_5.localScale;
        val_1[0] = val_2;
        val_1[0] = val_2.y;
        val_1[0] = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.vector3s[1] = val_3;
        this.vector3s[1] = val_3.y;
        this.vector3s[1] = val_3.z;
        if((this.tweenArguments & 1) != 0)
        {
                val_5 = this.vector3s;
            val_5[1] = new UnityEngine.Vector3();
            val_5[1] = this.tweenArguments;
        }
        else
        {
                if((this.tweenArguments & 1) != 0)
        {
                val_5 = this.vector3s;
            val_5[1] = new UnityEngine.Vector3();
        }
        
            if((this.tweenArguments & 1) != 0)
        {
                val_5 = this.vector3s;
            val_5[1] = new UnityEngine.Vector3();
        }
        
            if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
            val_5 = this.vector3s;
        }
        
        val_5[1] = new UnityEngine.Vector3();
    }
    private void ApplyRectTargets()
    {
        System.Collections.Hashtable val_7;
        UnityEngine.Rect[] val_8;
        UnityEngine.Rect[] val_9;
        UnityEngine.Rect[] val_10;
        UnityEngine.Rect[] val_11;
        val_7 = this;
        val_8 = this.rects;
        if(this.rects != null)
        {
            goto label_1;
        }
        
        val_8 = this.rects;
        if(val_8 == null)
        {
            goto label_23;
        }
        
        label_1:
        float val_3 = this.ease.Invoke(start:  val_8[32].x, end:  this.rects[48].x, Value:  this.percentage);
        this.rects[64].x = val_3;
        val_9 = this.rects;
        if(this.rects != null)
        {
            goto label_8;
        }
        
        val_9 = this.rects;
        if(val_9 == null)
        {
            goto label_23;
        }
        
        label_8:
        float val_4 = this.ease.Invoke(start:  val_3, end:  val_3, Value:  this.percentage);
        val_10 = this.rects;
        if(this.rects != null)
        {
            goto label_15;
        }
        
        val_10 = this.rects;
        if(val_10 == null)
        {
            goto label_23;
        }
        
        label_15:
        float val_5 = this.ease.Invoke(start:  val_4, end:  val_4, Value:  this.percentage);
        val_11 = this.rects;
        if(this.rects != null)
        {
            goto label_22;
        }
        
        val_11 = this.rects;
        if(val_11 == null)
        {
            goto label_23;
        }
        
        label_22:
        float val_6 = this.ease.Invoke(start:  val_5, end:  val_5, Value:  this.percentage);
        UnityEngine.Rect val_7 = this.rects[2];
        if(this.percentage != 1f)
        {
                return;
        }
        
        val_7 = this.tweenArguments;
        UnityEngine.Rect val_8 = this.rects[1];
        return;
        label_23:
    }
    private void ApplyColorTargets()
    {
        this.colors[2] = this.ease.Invoke(start:  this.colors[0], end:  this.colors[1], Value:  this.percentage);
        this.colors[2] = this.ease.Invoke(start:  this.colors[0], end:  this.colors[1], Value:  this.percentage);
        this.colors[2] = this.ease.Invoke(start:  this.colors[0], end:  this.colors[1], Value:  this.percentage);
        this.colors[2] = this.ease.Invoke(start:  this.colors[0], end:  this.colors[1], Value:  this.percentage);
        UnityEngine.Color val_13 = this.colors[2];
        if(this.percentage != 1f)
        {
                return;
        }
        
        this = this.tweenArguments;
        UnityEngine.Color val_14 = this.colors[1];
    }
    private void ApplyVector3Targets()
    {
        System.Collections.Hashtable val_4;
        UnityEngine.Vector3[] val_5;
        UnityEngine.Vector3[] val_6;
        UnityEngine.Vector3[] val_7;
        val_4 = this;
        val_5 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_1;
        }
        
        val_5 = this.vector3s;
        if(val_5 == null)
        {
            goto label_16;
        }
        
        label_1:
        this.vector3s[2] = this.ease.Invoke(start:  val_5[0], end:  this.vector3s[1], Value:  this.percentage);
        val_6 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_8;
        }
        
        val_6 = this.vector3s;
        if(val_6 == null)
        {
            goto label_16;
        }
        
        label_8:
        this.vector3s[2] = this.ease.Invoke(start:  val_6[0], end:  this.vector3s[1], Value:  this.percentage);
        val_7 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_15;
        }
        
        val_7 = this.vector3s;
        if(val_7 == null)
        {
            goto label_16;
        }
        
        label_15:
        this.vector3s[2] = this.ease.Invoke(start:  val_7[0], end:  this.vector3s[1], Value:  this.percentage);
        UnityEngine.Vector3 val_10 = this.vector3s[2];
        UnityEngine.Vector3 val_11 = this.vector3s[2];
        if(this.percentage != 1f)
        {
                return;
        }
        
        val_4 = this.tweenArguments;
        UnityEngine.Vector3 val_12 = this.vector3s[1];
        UnityEngine.Vector3 val_13 = this.vector3s[1];
        return;
        label_16:
    }
    private void ApplyVector2Targets()
    {
        System.Collections.Hashtable val_3;
        UnityEngine.Vector2[] val_4;
        UnityEngine.Vector2[] val_5;
        val_3 = this;
        val_4 = this.vector2s;
        if(this.vector2s != null)
        {
            goto label_1;
        }
        
        val_4 = this.vector2s;
        if(val_4 == null)
        {
            goto label_9;
        }
        
        label_1:
        this.vector2s[2] = this.ease.Invoke(start:  val_4[0], end:  this.vector2s[1], Value:  this.percentage);
        val_5 = this.vector2s;
        if(this.vector2s != null)
        {
            goto label_8;
        }
        
        val_5 = this.vector2s;
        if(val_5 == null)
        {
            goto label_9;
        }
        
        label_8:
        this.vector2s[2] = this.ease.Invoke(start:  val_5[0], end:  this.vector2s[1], Value:  this.percentage);
        UnityEngine.Vector2 val_7 = this.vector2s[2];
        UnityEngine.Vector2 val_8 = this.vector2s[2];
        if(this.percentage != 1f)
        {
                return;
        }
        
        val_3 = this.tweenArguments;
        UnityEngine.Vector2 val_9 = this.vector2s[1];
        UnityEngine.Vector2 val_10 = this.vector2s[1];
        return;
        label_9:
    }
    private void ApplyFloatTargets()
    {
        this.floats[2] = this.ease.Invoke(start:  this.floats[0], end:  this.floats[1], Value:  this.percentage);
        float val_4 = this.floats[2];
        if(this.percentage != 1f)
        {
                return;
        }
        
        this = this.tweenArguments;
        float val_5 = this.floats[1];
    }
    private void ApplyColorToTargets()
    {
        var val_24;
        var val_35;
        UnityEngine.Color val_37;
        var val_39;
        UnityEngine.Color val_40;
        float val_41;
        UnityEngine.Color[,] val_42;
        var val_43;
        UnityEngine.Color val_45;
        UnityEngine.Color[,] val_46;
        val_24 = 0;
        goto label_1;
        label_43:
        var val_34 = 16824064;
        val_34 = 2 + (val_34 * 0);
        this.colors[val_34] = this.ease.Invoke(start:  this.colors[16824064 * 0], end:  this.colors[16824064 * 0], Value:  this.percentage);
        val_34 = 2 + (val_34 * 0);
        this.colors[val_34] = this.ease.Invoke(start:  this.colors[16824064 * 0], end:  this.colors[16824064 * 0], Value:  this.percentage);
        val_34 = 2 + (val_34 * 0);
        this.colors[val_34] = this.ease.Invoke(start:  this.colors[16824064 * 0], end:  this.colors[16824064 * 0], Value:  this.percentage);
        val_37 = this.colors[16824064 * 0];
        val_40 = this.colors[16824064 * 0];
        val_41 = this.percentage;
        val_42 = 2 + (val_34 * 0);
        val_24 = 1;
        this.colors[val_42] = this.ease.Invoke(start:  val_37, end:  val_40, Value:  val_41);
        label_1:
        if(val_24 < (this.colors.GetLength(dimension:  0)))
        {
            goto label_43;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.GetComponent<UnityEngine.Renderer>())) == false)
        {
            goto label_46;
        }
        
        val_39 = 1152921505060040704;
        val_43 = 0;
        goto label_47;
        label_58:
        this.namedcolorvalue.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
        val_42 = this.colors;
        this.namedcolorvalue = null;
        val_37 = val_42[0];
        val_40 = val_42[0];
        val_41 = val_42[0];
        val_45 = val_42[0];
        this.GetComponent<UnityEngine.Renderer>().materials[0].SetColor(name:  this.namedcolorvalue.ToString(), value:  new UnityEngine.Color() {r = val_37, g = val_40, b = val_41, a = val_45});
        val_43 = 1;
        label_47:
        val_46 = this.colors;
        if(val_43 < (val_46.GetLength(dimension:  0)))
        {
            goto label_58;
        }
        
        goto label_62;
        label_46:
        val_46 = 1152921525682369600;
        if((UnityEngine.Object.op_Implicit(exists:  this.GetComponent<UnityEngine.Light>())) != false)
        {
                val_46 = this.colors;
            val_37 = val_46[2];
            val_40 = val_46[2];
            val_41 = val_46[2];
            val_45 = val_46[2];
            this.GetComponent<UnityEngine.Light>().color = new UnityEngine.Color() {r = val_37, g = val_40, b = val_41, a = val_45};
        }
        
        label_62:
        if(this.percentage != 1f)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.GetComponent<UnityEngine.Renderer>())) == false)
        {
            goto label_70;
        }
        
        val_35 = 0;
        goto label_71;
        label_82:
        val_39 = 0;
        this.namedcolorvalue.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
        val_42 = this.colors;
        this.namedcolorvalue = null;
        val_37 = val_42[0];
        val_41 = val_42[0];
        this.GetComponent<UnityEngine.Renderer>().materials[val_39].SetColor(name:  this.namedcolorvalue.ToString(), value:  new UnityEngine.Color() {r = val_37, g = val_42[0], b = val_41, a = val_42[0]});
        val_35 = 1;
        label_71:
        val_46 = this.colors;
        if(val_35 < (val_46.GetLength(dimension:  0)))
        {
            goto label_82;
        }
        
        return;
        label_70:
        val_46 = 1152921525682369600;
        if((UnityEngine.Object.op_Implicit(exists:  this.GetComponent<UnityEngine.Light>())) == false)
        {
                return;
        }
        
        this.GetComponent<UnityEngine.Light>().color = new UnityEngine.Color() {r = this.colors[1], g = this.colors[1], b = this.colors[1], a = this.colors[1]};
    }
    private void ApplyAudioToTargets()
    {
        UnityEngine.Vector2[] val_3;
        UnityEngine.Vector2[] val_4;
        val_3 = this.vector2s;
        if(this.vector2s != null)
        {
            goto label_0;
        }
        
        val_3 = this.vector2s;
        if(val_3 == null)
        {
            goto label_8;
        }
        
        label_0:
        this.vector2s[2] = this.ease.Invoke(start:  val_3[0], end:  this.vector2s[1], Value:  this.percentage);
        val_4 = this.vector2s;
        if(this.vector2s != null)
        {
            goto label_7;
        }
        
        val_4 = this.vector2s;
        if(val_4 == null)
        {
            goto label_8;
        }
        
        label_7:
        this.vector2s[2] = this.ease.Invoke(start:  val_4[0], end:  this.vector2s[1], Value:  this.percentage);
        this.audioSource.volume = this.vector2s[2];
        this.audioSource.pitch = this.vector2s[2];
        if(this.percentage != 1f)
        {
                return;
        }
        
        this.audioSource.volume = this.vector2s[1];
        this.audioSource.pitch = this.vector2s[1];
        return;
        label_8:
    }
    private void ApplyStabTargets()
    {
    
    }
    private void ApplyMoveToPathTargets()
    {
        var val_14;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        float val_22;
        var val_23;
        float val_24;
        var val_25;
        val_14 = this;
        UnityEngine.Vector3 val_1 = this.thisTransform.position;
        this.preUpdate = val_1;
        mem[1152921525869588596] = val_1.y;
        mem[1152921525869588600] = val_1.z;
        float val_2 = this.ease.Invoke(start:  0f, end:  1f, Value:  this.percentage);
        if(this.isLocal != false)
        {
                UnityEngine.Vector3 val_4 = this.path.Interp(t:  UnityEngine.Mathf.Clamp(value:  val_2, min:  0f, max:  1f));
            val_18 = val_4.x;
            val_19 = val_4.y;
            val_20 = val_18;
            val_21 = val_19;
            val_22 = val_4.z;
            this.thisTransform.localPosition = new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22};
        }
        else
        {
                UnityEngine.Vector3 val_6 = this.path.Interp(t:  UnityEngine.Mathf.Clamp(value:  val_2, min:  0f, max:  1f));
            val_18 = val_6.x;
            val_19 = val_6.y;
            val_20 = val_18;
            val_21 = val_19;
            val_22 = val_6.z;
            this.thisTransform.position = new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22};
        }
        
        val_23 = "orienttopath";
        if(((this.tweenArguments & 1) != 0) && (null != null))
        {
                if((this.tweenArguments & 1) != 0)
        {
                val_24 = this.tweenArguments;
        }
        else
        {
                val_25 = null;
            val_25 = null;
            val_24 = 1152921505060098112;
        }
        
            val_19 = 1f;
            val_21 = 0f;
            val_22 = val_19;
            val_18 = UnityEngine.Mathf.Clamp(value:  this.ease.Invoke(start:  0f, end:  val_19, Value:  UnityEngine.Mathf.Min(a:  1f, b:  val_24 + this.percentage)), min:  val_21, max:  val_22);
            val_20 = val_18;
            UnityEngine.Vector3 val_11 = this.path.Interp(t:  val_20);
            val_23 = val_11;
        }
        
        UnityEngine.Vector3 val_12 = this.thisTransform.position;
        this.postUpdate = val_12;
        mem[1152921525869588608] = val_12.y;
        mem[1152921525869588612] = val_12.z;
        if(this.physics == false)
        {
                return;
        }
        
        this.thisTransform.position = new UnityEngine.Vector3() {x = this.preUpdate, y = val_19, z = val_6.z};
        val_18 = this.postUpdate;
        val_14 = this.GetComponent<UnityEngine.Rigidbody>();
        val_14.MovePosition(position:  new UnityEngine.Vector3() {x = val_18, y = val_19, z = val_6.z});
    }
    private void ApplyMoveToTargets()
    {
        UnityEngine.Vector3[] val_7;
        UnityEngine.Vector3[] val_8;
        UnityEngine.Vector3[] val_9;
        bool val_10;
        UnityEngine.Vector3 val_11;
        UnityEngine.Vector3 val_12;
        float val_13;
        float val_14;
        float val_15;
        UnityEngine.Vector3 val_1 = this.thisTransform.position;
        this.preUpdate = val_1;
        mem[1152921525870205428] = val_1.y;
        mem[1152921525870205432] = val_1.z;
        val_7 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_2;
        }
        
        val_7 = this.vector3s;
        if(val_7 == null)
        {
            goto label_17;
        }
        
        label_2:
        this.vector3s[2] = this.ease.Invoke(start:  val_7[0], end:  this.vector3s[1], Value:  this.percentage);
        val_8 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_9;
        }
        
        val_8 = this.vector3s;
        if(val_8 == null)
        {
            goto label_17;
        }
        
        label_9:
        this.vector3s[2] = this.ease.Invoke(start:  val_8[0], end:  this.vector3s[1], Value:  this.percentage);
        val_9 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_16;
        }
        
        val_9 = this.vector3s;
        if(val_9 == null)
        {
            goto label_17;
        }
        
        label_16:
        this.vector3s[2] = this.ease.Invoke(start:  val_9[0], end:  this.vector3s[1], Value:  this.percentage);
        val_10 = this.isLocal;
        UnityEngine.Vector3 val_13 = this.vector3s[2];
        val_11 = this.vector3s[2];
        val_12 = this.vector3s[2];
        if(this.thisTransform == null)
        {
            goto label_25;
        }
        
        if(val_10 == false)
        {
            goto label_26;
        }
        
        label_28:
        val_13 = val_12;
        this.thisTransform.localPosition = new UnityEngine.Vector3() {x = val_13, y = val_11, z = val_13};
        goto label_27;
        label_25:
        if(val_10 == true)
        {
            goto label_28;
        }
        
        label_26:
        val_13 = val_12;
        this.thisTransform.position = new UnityEngine.Vector3() {x = val_13, y = val_11, z = val_13};
        label_27:
        val_14 = this.percentage;
        val_15 = 1f;
        if(val_14 != val_15)
        {
            goto label_34;
        }
        
        val_10 = this.isLocal;
        UnityEngine.Vector3 val_14 = this.vector3s[1];
        val_11 = this.vector3s[1];
        val_12 = this.vector3s[1];
        if(this.thisTransform == null)
        {
            goto label_32;
        }
        
        if(val_10 == false)
        {
            goto label_33;
        }
        
        label_35:
        val_14 = val_14;
        val_15 = val_11;
        val_13 = val_12;
        this.thisTransform.localPosition = new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_13};
        goto label_34;
        label_32:
        if(val_10 == true)
        {
            goto label_35;
        }
        
        label_33:
        val_14 = val_14;
        val_15 = val_11;
        val_13 = val_12;
        this.thisTransform.position = new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_13};
        label_34:
        UnityEngine.Vector3 val_5 = this.thisTransform.position;
        this.postUpdate = val_5;
        mem[1152921525870205440] = val_5.y;
        mem[1152921525870205444] = val_5.z;
        if(this.physics == false)
        {
                return;
        }
        
        this.thisTransform.position = new UnityEngine.Vector3() {x = this.preUpdate, y = val_11, z = val_14};
        this.GetComponent<UnityEngine.Rigidbody>().MovePosition(position:  new UnityEngine.Vector3() {x = this.postUpdate, y = val_11, z = val_14});
        return;
        label_17:
    }
    private void ApplyMoveByTargets()
    {
        UnityEngine.Vector3[] val_12;
        float val_13;
        float val_14;
        var val_15;
        var val_16;
        var val_17;
        float val_18;
        float val_19;
        float val_20;
        var val_21;
        UnityEngine.Vector3 val_1 = this.thisTransform.position;
        this.preUpdate = val_1;
        mem[1152921525870886772] = val_1.y;
        mem[1152921525870886776] = val_1.z;
        if((this.tweenArguments & 1) != 0)
        {
                UnityEngine.Vector3 val_2 = this.thisTransform.eulerAngles;
            val_12 = this;
            val_13 = val_2.x;
            val_14 = val_2.y;
            this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.vector3s[4], y = this.vector3s[4], z = this.vector3s[4]};
        }
        else
        {
                val_12 = this.vector3s;
            val_14 = 0f;
            val_13 = 0f;
        }
        
        val_15 = mem[this.vector3s];
        if(mem[this.vector3s] != 0)
        {
            goto label_9;
        }
        
        val_15 = mem[this.vector3s];
        if(val_15 == 0)
        {
            goto label_24;
        }
        
        label_9:
        mem2[0] = this.ease.Invoke(start:  mem[this.vector3s] + 32, end:  mem[this.vector3s] + 44, Value:  this.percentage);
        val_16 = mem[this.vector3s];
        if(mem[this.vector3s] != 0)
        {
            goto label_16;
        }
        
        val_16 = mem[this.vector3s];
        if(val_16 == 0)
        {
            goto label_24;
        }
        
        label_16:
        mem2[0] = this.ease.Invoke(start:  mem[this.vector3s] + 36, end:  mem[this.vector3s] + 48, Value:  this.percentage);
        val_17 = mem[this.vector3s];
        if(mem[this.vector3s] != 0)
        {
            goto label_23;
        }
        
        val_17 = mem[this.vector3s];
        if(val_17 == 0)
        {
            goto label_24;
        }
        
        label_23:
        mem2[0] = this.ease.Invoke(start:  mem[this.vector3s] + 40, end:  mem[this.vector3s] + 52, Value:  this.percentage);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.vector3s[2], y = this.vector3s[2], z = this.vector3s[2]}, b:  new UnityEngine.Vector3() {x = mem[this.vector3s] + 68, y = mem[this.vector3s] + 68 + 4, z = mem[this.vector3s] + 76});
        val_18 = val_6.x;
        val_19 = val_6.y;
        val_20 = val_6.z;
        this.thisTransform.Translate(translation:  new UnityEngine.Vector3() {x = val_18, y = val_19, z = val_20}, relativeTo:  this.space);
        val_21 = mem[mem[this.vector3s] + 24];
        val_21 = mem[this.vector3s] + 24;
        if(val_21 <= 2)
        {
                val_21 = mem[mem[this.vector3s] + 24];
            val_21 = mem[this.vector3s] + 24;
        }
        
        mem2[0] = mem[this.vector3s] + 56;
        mem2[0] = mem[this.vector3s] + 56 + 4;
        mem2[0] = mem[this.vector3s] + 64;
        if((this.tweenArguments & 1) != 0)
        {
                val_20 = 0f;
            val_18 = val_13;
            val_19 = val_14;
            this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = val_18, y = val_19, z = val_20};
        }
        
        UnityEngine.Vector3 val_7 = this.thisTransform.position;
        this.postUpdate = val_7;
        mem[1152921525870886784] = val_7.y;
        mem[1152921525870886788] = val_7.z;
        if(this.physics == false)
        {
                return;
        }
        
        this.thisTransform.position = new UnityEngine.Vector3() {x = this.preUpdate, y = val_14, z = val_13};
        this.GetComponent<UnityEngine.Rigidbody>().MovePosition(position:  new UnityEngine.Vector3() {x = this.postUpdate, y = val_14, z = val_13});
        return;
        label_24:
    }
    private void ApplyScaleToTargets()
    {
        UnityEngine.Vector3[] val_4;
        UnityEngine.Vector3[] val_5;
        UnityEngine.Vector3[] val_6;
        val_4 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_0;
        }
        
        val_4 = this.vector3s;
        if(val_4 == null)
        {
            goto label_15;
        }
        
        label_0:
        this.vector3s[2] = this.ease.Invoke(start:  val_4[0], end:  this.vector3s[1], Value:  this.percentage);
        val_5 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_7;
        }
        
        val_5 = this.vector3s;
        if(val_5 == null)
        {
            goto label_15;
        }
        
        label_7:
        this.vector3s[2] = this.ease.Invoke(start:  val_5[0], end:  this.vector3s[1], Value:  this.percentage);
        val_6 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_14;
        }
        
        val_6 = this.vector3s;
        if(val_6 == null)
        {
            goto label_15;
        }
        
        label_14:
        this.vector3s[2] = this.ease.Invoke(start:  val_6[0], end:  this.vector3s[1], Value:  this.percentage);
        this.thisTransform.localScale = new UnityEngine.Vector3() {x = this.vector3s[2], y = this.vector3s[2], z = this.vector3s[2]};
        if(this.percentage != 1f)
        {
                return;
        }
        
        this.thisTransform.localScale = new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]};
        return;
        label_15:
    }
    private void ApplyLookToTargets()
    {
        UnityEngine.Vector3[] val_6;
        UnityEngine.Vector3[] val_7;
        UnityEngine.Vector3[] val_8;
        val_6 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_1;
        }
        
        val_6 = this.vector3s;
        if(val_6 == null)
        {
            goto label_16;
        }
        
        label_1:
        this.vector3s[2] = this.ease.Invoke(start:  val_6[0], end:  this.vector3s[1], Value:  this.percentage);
        val_7 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_8;
        }
        
        val_7 = this.vector3s;
        if(val_7 == null)
        {
            goto label_16;
        }
        
        label_8:
        this.vector3s[2] = this.ease.Invoke(start:  val_7[0], end:  this.vector3s[1], Value:  this.percentage);
        val_8 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_15;
        }
        
        val_8 = this.vector3s;
        if(val_8 == null)
        {
            goto label_16;
        }
        
        label_15:
        this.vector3s[2] = this.ease.Invoke(start:  val_8[0], end:  this.vector3s[1], Value:  this.percentage);
        UnityEngine.Vector3 val_12 = this.vector3s[2];
        UnityEngine.Vector3 val_13 = this.vector3s[2];
        UnityEngine.Vector3 val_14 = this.vector3s[2];
        if(this.isLocal != false)
        {
                UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14});
            this.thisTransform.localRotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
            return;
        }
        
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14});
        this.thisTransform.rotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
        return;
        label_16:
    }
    private void ApplyRotateToTargets()
    {
        UnityEngine.Vector3[] val_12;
        UnityEngine.Vector3[] val_13;
        UnityEngine.Vector3[] val_14;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        float val_24;
        UnityEngine.Vector3 val_1 = this.thisTransform.eulerAngles;
        this.preUpdate = val_1;
        mem[1152921525873414132] = val_1.y;
        mem[1152921525873414136] = val_1.z;
        val_12 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_2;
        }
        
        val_12 = this.vector3s;
        if(val_12 == null)
        {
            goto label_17;
        }
        
        label_2:
        this.vector3s[2] = this.ease.Invoke(start:  val_12[0], end:  this.vector3s[1], Value:  this.percentage);
        val_13 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_9;
        }
        
        val_13 = this.vector3s;
        if(val_13 == null)
        {
            goto label_17;
        }
        
        label_9:
        this.vector3s[2] = this.ease.Invoke(start:  val_13[0], end:  this.vector3s[1], Value:  this.percentage);
        val_14 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_16;
        }
        
        val_14 = this.vector3s;
        if(val_14 == null)
        {
            goto label_17;
        }
        
        label_16:
        this.vector3s[2] = this.ease.Invoke(start:  val_14[0], end:  this.vector3s[1], Value:  this.percentage);
        UnityEngine.Vector3 val_18 = this.vector3s[2];
        UnityEngine.Vector3 val_19 = this.vector3s[2];
        UnityEngine.Vector3 val_20 = this.vector3s[2];
        if(this.isLocal != false)
        {
                UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_18, y = val_19, z = val_20});
            val_18 = val_5.x;
            val_19 = val_5.y;
            val_20 = val_5.z;
            val_21 = val_20;
            val_22 = val_5.w;
            this.thisTransform.localRotation = new UnityEngine.Quaternion() {x = val_18, y = val_19, z = val_21, w = val_22};
        }
        else
        {
                UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_18, y = val_19, z = val_20});
            val_18 = val_6.x;
            val_19 = val_6.y;
            val_20 = val_6.z;
            val_21 = val_20;
            val_22 = val_6.w;
            this.thisTransform.rotation = new UnityEngine.Quaternion() {x = val_18, y = val_19, z = val_21, w = val_22};
        }
        
        val_23 = this.percentage;
        val_24 = 1f;
        if(val_23 == val_24)
        {
                UnityEngine.Vector3 val_21 = this.vector3s[1];
            UnityEngine.Vector3 val_22 = this.vector3s[1];
            UnityEngine.Vector3 val_23 = this.vector3s[1];
            if(this.isLocal != false)
        {
                UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23});
            val_18 = val_7.x;
            val_19 = val_7.y;
            val_20 = val_7.z;
            val_23 = val_18;
            val_24 = val_19;
            val_21 = val_20;
            val_22 = val_7.w;
            this.thisTransform.localRotation = new UnityEngine.Quaternion() {x = val_23, y = val_24, z = val_21, w = val_22};
        }
        else
        {
                UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23});
            val_18 = val_8.x;
            val_19 = val_8.y;
            val_20 = val_8.z;
            val_23 = val_18;
            val_24 = val_19;
            val_21 = val_20;
            val_22 = val_8.w;
            this.thisTransform.rotation = new UnityEngine.Quaternion() {x = val_23, y = val_24, z = val_21, w = val_22};
        }
        
        }
        
        UnityEngine.Vector3 val_9 = this.thisTransform.eulerAngles;
        this.postUpdate = val_9;
        mem[1152921525873414144] = val_9.y;
        mem[1152921525873414148] = val_9.z;
        if(this.physics == false)
        {
                return;
        }
        
        this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.preUpdate, y = val_19, z = val_20};
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.postUpdate, y = val_19, z = this.preUpdate});
        this.GetComponent<UnityEngine.Rigidbody>().MoveRotation(rot:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w});
        return;
        label_17:
    }
    private void ApplyRotateAddTargets()
    {
        UnityEngine.Vector3[] val_9;
        UnityEngine.Vector3[] val_10;
        UnityEngine.Vector3[] val_11;
        int val_12;
        UnityEngine.Vector3 val_1 = this.thisTransform.eulerAngles;
        this.preUpdate = val_1;
        mem[1152921525874447732] = val_1.y;
        mem[1152921525874447736] = val_1.z;
        val_9 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_2;
        }
        
        val_9 = this.vector3s;
        if(val_9 == null)
        {
            goto label_17;
        }
        
        label_2:
        this.vector3s[2] = this.ease.Invoke(start:  val_9[0], end:  this.vector3s[1], Value:  this.percentage);
        val_10 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_9;
        }
        
        val_10 = this.vector3s;
        if(val_10 == null)
        {
            goto label_17;
        }
        
        label_9:
        this.vector3s[2] = this.ease.Invoke(start:  val_10[0], end:  this.vector3s[1], Value:  this.percentage);
        val_11 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_16;
        }
        
        val_11 = this.vector3s;
        if(val_11 == null)
        {
            goto label_17;
        }
        
        label_16:
        this.vector3s[2] = this.ease.Invoke(start:  val_11[0], end:  this.vector3s[1], Value:  this.percentage);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.vector3s[2], y = this.vector3s[2], z = this.vector3s[2]}, b:  new UnityEngine.Vector3() {x = this.vector3s[3], y = this.vector3s[3], z = this.vector3s[3]});
        this.thisTransform.Rotate(eulers:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, relativeTo:  this.space);
        val_12 = this.vector3s.Length;
        if(val_12 <= 2)
        {
                val_12 = this.vector3s.Length;
        }
        
        this.vector3s[3] = this.vector3s[2];
        this.vector3s[3] = this.vector3s[2];
        this.vector3s[3] = this.vector3s[2];
        UnityEngine.Vector3 val_6 = this.thisTransform.eulerAngles;
        this.postUpdate = val_6;
        mem[1152921525874447744] = val_6.y;
        mem[1152921525874447748] = val_6.z;
        if(this.physics == false)
        {
                return;
        }
        
        this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.preUpdate, y = val_5.y, z = val_5.z};
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.postUpdate, y = val_5.y, z = this.preUpdate});
        this.GetComponent<UnityEngine.Rigidbody>().MoveRotation(rot:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w});
        return;
        label_17:
    }
    private void ApplyShakePositionTargets()
    {
        float val_19;
        float val_20;
        float val_21;
        UnityEngine.Vector3 val_22;
        UnityEngine.Vector3[] val_23;
        float val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        float val_29;
        float val_30;
        float val_31;
        float val_35;
        float val_36;
        float val_37;
        float val_38;
        if(this.thisTransform == null)
        {
            goto label_1;
        }
        
        if(this.isLocal == false)
        {
            goto label_2;
        }
        
        label_4:
        UnityEngine.Vector3 val_1 = this.thisTransform.localPosition;
        goto label_3;
        label_1:
        if(this.isLocal == true)
        {
            goto label_4;
        }
        
        label_2:
        UnityEngine.Vector3 val_2 = this.thisTransform.position;
        label_3:
        this.preUpdate = val_2;
        mem[1152921525875235572] = val_2.y;
        mem[1152921525875235576] = val_2.z;
        val_19 = 0f;
        val_20 = 0f;
        val_21 = 0f;
        if((this.tweenArguments & 1) != 0)
        {
                UnityEngine.Vector3 val_3 = this.thisTransform.eulerAngles;
            val_21 = val_3.x;
            val_20 = val_3.y;
            val_19 = val_3.z;
            val_22 = this.vector3s[3];
            this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.vector3s[3], y = this.vector3s[3], z = val_22};
        }
        
        if(this.percentage == 0f)
        {
                val_23 = this;
            val_22 = this.vector3s[1];
            this.thisTransform.Translate(translation:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = val_22}, relativeTo:  this.space);
        }
        else
        {
                val_23 = this.vector3s;
        }
        
        UnityEngine.Vector3 val_20 = this.vector3s[0];
        UnityEngine.Vector3 val_21 = this.vector3s[0];
        UnityEngine.Vector3 val_22 = this.vector3s[0];
        if(this.thisTransform == null)
        {
            goto label_18;
        }
        
        if(this.isLocal == false)
        {
            goto label_19;
        }
        
        label_21:
        val_24 = val_22;
        this.thisTransform.localPosition = new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_24};
        goto label_20;
        label_18:
        if(this.isLocal == true)
        {
            goto label_21;
        }
        
        label_19:
        val_24 = val_22;
        this.thisTransform.position = new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_24};
        label_20:
        val_25 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_22;
        }
        
        val_25 = mem[this.vector3s];
        if(val_25 == 0)
        {
            goto label_35;
        }
        
        label_22:
        float val_23 = 1f;
        val_23 = val_23 - this.percentage;
        float val_24 = mem[this.vector3s] + 44;
        val_24 = val_23 * val_24;
        this.vector3s[2] = UnityEngine.Random.Range(min:  -(val_23 * (mem[this.vector3s] + 44)), max:  val_24);
        val_26 = mem[this.vector3s];
        if(mem[this.vector3s] != 0)
        {
            goto label_28;
        }
        
        val_26 = mem[this.vector3s];
        if(val_26 == 0)
        {
            goto label_35;
        }
        
        label_28:
        float val_25 = mem[this.vector3s] + 48;
        val_25 = val_23 * val_25;
        mem2[0] = UnityEngine.Random.Range(min:  -(val_23 * (mem[this.vector3s] + 48)), max:  val_25);
        val_27 = mem[this.vector3s];
        if(mem[this.vector3s] != 0)
        {
            goto label_34;
        }
        
        val_27 = mem[this.vector3s];
        if(val_27 == 0)
        {
            goto label_35;
        }
        
        label_34:
        float val_26 = mem[this.vector3s] + 52;
        val_26 = val_23 * val_26;
        mem2[0] = UnityEngine.Random.Range(min:  -(val_23 * (mem[this.vector3s] + 52)), max:  val_26);
        if(this.isLocal != false)
        {
                UnityEngine.Vector3 val_10 = this.thisTransform.localPosition;
            val_28 = mem[this.vector3s];
            val_29 = val_19;
            val_30 = val_20;
            val_31 = mem[mem[this.vector3s] + 56 + 4];
            val_31 = mem[this.vector3s] + 56 + 4;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = mem[this.vector3s] + 56, y = val_31, z = mem[this.vector3s] + 64});
            val_35 = val_11.z;
            val_36 = val_11.x;
            val_37 = val_11.y;
            val_38 = val_35;
            this.thisTransform.localPosition = new UnityEngine.Vector3() {x = val_36, y = val_37, z = val_38};
        }
        else
        {
                UnityEngine.Vector3 val_12 = this.thisTransform.position;
            val_28 = mem[this.vector3s];
            val_29 = val_19;
            val_30 = val_20;
            val_31 = mem[mem[this.vector3s] + 56 + 4];
            val_31 = mem[this.vector3s] + 56 + 4;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = mem[this.vector3s] + 56, y = val_31, z = mem[this.vector3s] + 64});
            val_35 = val_13.z;
            val_36 = val_13.x;
            val_37 = val_13.y;
            val_38 = val_35;
            this.thisTransform.position = new UnityEngine.Vector3() {x = val_36, y = val_37, z = val_38};
        }
        
        if((this.tweenArguments & 1) != 0)
        {
                val_36 = val_21;
            val_37 = val_30;
            val_38 = val_29;
            this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = val_36, y = val_37, z = val_38};
        }
        
        UnityEngine.Vector3 val_14 = this.thisTransform.position;
        this.postUpdate = val_14;
        mem[1152921525875235584] = val_14.y;
        mem[1152921525875235588] = val_14.z;
        if(this.physics == false)
        {
                return;
        }
        
        this.thisTransform.position = new UnityEngine.Vector3() {x = this.preUpdate, y = val_29, z = val_21};
        this.GetComponent<UnityEngine.Rigidbody>().MovePosition(position:  new UnityEngine.Vector3() {x = this.postUpdate, y = val_29, z = val_21});
        return;
        label_35:
    }
    private void ApplyShakeScaleTargets()
    {
        UnityEngine.Vector3[] val_9;
        var val_10;
        var val_11;
        var val_12;
        if(this.percentage == 0f)
        {
                val_9 = this;
            this.thisTransform.localScale = new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]};
        }
        else
        {
                val_9 = this.vector3s;
        }
        
        this.thisTransform.localScale = new UnityEngine.Vector3() {x = this.vector3s[0], y = this.vector3s[0], z = this.vector3s[0]};
        val_10 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_9;
        }
        
        val_10 = mem[this.vector3s];
        if(val_10 == 0)
        {
            goto label_22;
        }
        
        label_9:
        float val_15 = 1f;
        val_15 = val_15 - this.percentage;
        float val_16 = mem[this.vector3s] + 44;
        val_16 = val_15 * val_16;
        this.vector3s[2] = UnityEngine.Random.Range(min:  -(val_15 * (mem[this.vector3s] + 44)), max:  val_16);
        val_11 = mem[this.vector3s];
        if(mem[this.vector3s] != 0)
        {
            goto label_15;
        }
        
        val_11 = mem[this.vector3s];
        if(val_11 == 0)
        {
            goto label_22;
        }
        
        label_15:
        float val_17 = mem[this.vector3s] + 48;
        val_17 = val_15 * val_17;
        mem2[0] = UnityEngine.Random.Range(min:  -(val_15 * (mem[this.vector3s] + 48)), max:  val_17);
        val_12 = mem[this.vector3s];
        if(mem[this.vector3s] != 0)
        {
            goto label_21;
        }
        
        val_12 = mem[this.vector3s];
        if(val_12 == 0)
        {
            goto label_22;
        }
        
        label_21:
        float val_18 = mem[this.vector3s] + 52;
        val_18 = val_15 * val_18;
        mem2[0] = UnityEngine.Random.Range(min:  -(val_15 * (mem[this.vector3s] + 52)), max:  val_18);
        UnityEngine.Vector3 val_7 = this.thisTransform.localScale;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = mem[this.vector3s] + 56, y = mem[this.vector3s] + 56 + 4, z = mem[this.vector3s] + 64});
        this.thisTransform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        return;
        label_22:
    }
    private void ApplyShakeRotationTargets()
    {
        UnityEngine.Vector3[] val_11;
        var val_12;
        var val_13;
        var val_14;
        UnityEngine.Vector3 val_1 = this.thisTransform.eulerAngles;
        this.preUpdate = val_1;
        mem[1152921525876082164] = val_1.y;
        mem[1152921525876082168] = val_1.z;
        if(this.percentage == 0f)
        {
                val_11 = this;
            this.thisTransform.Rotate(eulers:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]}, relativeTo:  this.space);
        }
        else
        {
                val_11 = this.vector3s;
        }
        
        this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.vector3s[0], y = this.vector3s[0], z = this.vector3s[0]};
        val_12 = this.vector3s;
        if(this.vector3s != null)
        {
            goto label_10;
        }
        
        val_12 = mem[this.vector3s];
        if(val_12 == 0)
        {
            goto label_23;
        }
        
        label_10:
        float val_17 = 1f;
        val_17 = val_17 - this.percentage;
        float val_18 = mem[this.vector3s] + 44;
        val_18 = val_17 * val_18;
        this.vector3s[2] = UnityEngine.Random.Range(min:  -(val_17 * (mem[this.vector3s] + 44)), max:  val_18);
        val_13 = mem[this.vector3s];
        if(mem[this.vector3s] != 0)
        {
            goto label_16;
        }
        
        val_13 = mem[this.vector3s];
        if(val_13 == 0)
        {
            goto label_23;
        }
        
        label_16:
        float val_19 = mem[this.vector3s] + 48;
        val_19 = val_17 * val_19;
        mem2[0] = UnityEngine.Random.Range(min:  -(val_17 * (mem[this.vector3s] + 48)), max:  val_19);
        val_14 = mem[this.vector3s];
        if(mem[this.vector3s] != 0)
        {
            goto label_22;
        }
        
        val_14 = mem[this.vector3s];
        if(val_14 == 0)
        {
            goto label_23;
        }
        
        label_22:
        float val_20 = mem[this.vector3s] + 52;
        val_20 = val_17 * val_20;
        mem2[0] = UnityEngine.Random.Range(min:  -(val_17 * (mem[this.vector3s] + 52)), max:  val_20);
        UnityEngine.Vector3 val_22 = this.vector3s[2];
        UnityEngine.Vector3 val_23 = this.vector3s[2];
        this.thisTransform.Rotate(eulers:  new UnityEngine.Vector3() {x = this.vector3s[2], y = val_22, z = val_23}, relativeTo:  this.space);
        UnityEngine.Vector3 val_8 = this.thisTransform.eulerAngles;
        this.postUpdate = val_8;
        mem[1152921525876082176] = val_8.y;
        mem[1152921525876082180] = val_8.z;
        if(this.physics == false)
        {
                return;
        }
        
        this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.preUpdate, y = val_22, z = val_23};
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.postUpdate, y = val_22, z = this.preUpdate});
        this.GetComponent<UnityEngine.Rigidbody>().MoveRotation(rot:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w});
        return;
        label_23:
    }
    private void ApplyPunchPositionTargets()
    {
        UnityEngine.Vector3[] val_15;
        float val_16;
        float val_17;
        var val_18;
        float val_19;
        var val_20;
        var val_21;
        float val_22;
        var val_23;
        var val_24;
        float val_25;
        var val_26;
        float val_27;
        float val_28;
        float val_29;
        var val_30;
        UnityEngine.Vector3 val_1 = this.thisTransform.position;
        this.preUpdate = val_1;
        mem[1152921525876489076] = val_1.y;
        mem[1152921525876489080] = val_1.z;
        if((this.tweenArguments & 1) != 0)
        {
                UnityEngine.Vector3 val_2 = this.thisTransform.eulerAngles;
            val_15 = this;
            val_16 = val_2.x;
            val_17 = val_2.y;
            this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.vector3s[4], y = this.vector3s[4], z = this.vector3s[4]};
        }
        else
        {
                val_15 = this.vector3s;
            val_17 = 0f;
            val_16 = 0f;
        }
        
        val_18 = mem[this.vector3s];
        if((mem[this.vector3s] + 44) <= 0f)
        {
            goto label_12;
        }
        
        val_19 = this.punch(amplitude:  mem[this.vector3s] + 44, value:  this.percentage);
        if((mem[this.vector3s] + 24) > 2)
        {
            goto label_16;
        }
        
        goto label_16;
        label_12:
        if((mem[this.vector3s] + 44) >= 0)
        {
            goto label_18;
        }
        
        val_18 = mem[this.vector3s];
        val_20 = val_18;
        if(val_18 != 0)
        {
            goto label_19;
        }
        
        val_20 = mem[this.vector3s];
        if(val_20 == 0)
        {
            goto label_52;
        }
        
        label_19:
        val_19 = -(new UnityEngine.Mathf().punch(amplitude:  System.Math.Abs(mem[this.vector3s] + 44), value:  this.percentage));
        label_16:
        mem2[0] = val_19;
        label_18:
        val_21 = mem[this.vector3s];
        if((mem[this.vector3s] + 48) <= 0f)
        {
            goto label_28;
        }
        
        val_22 = this.punch(amplitude:  mem[this.vector3s] + 48, value:  this.percentage);
        if((mem[this.vector3s] + 24) > 2)
        {
            goto label_32;
        }
        
        goto label_32;
        label_28:
        if((mem[this.vector3s] + 48) >= 0)
        {
            goto label_34;
        }
        
        val_21 = mem[this.vector3s];
        val_23 = val_21;
        if(val_21 != 0)
        {
            goto label_35;
        }
        
        val_23 = mem[this.vector3s];
        if(val_23 == 0)
        {
            goto label_52;
        }
        
        label_35:
        val_22 = -(new UnityEngine.Mathf().punch(amplitude:  System.Math.Abs(mem[this.vector3s] + 48), value:  this.percentage));
        label_32:
        mem2[0] = val_22;
        label_34:
        val_24 = mem[this.vector3s];
        if((mem[this.vector3s] + 52) <= 0f)
        {
            goto label_44;
        }
        
        val_25 = this.punch(amplitude:  mem[this.vector3s] + 52, value:  this.percentage);
        if((mem[this.vector3s] + 24) > 2)
        {
            goto label_48;
        }
        
        goto label_48;
        label_44:
        if((mem[this.vector3s] + 52) >= 0)
        {
            goto label_50;
        }
        
        val_24 = mem[this.vector3s];
        val_26 = val_24;
        if(val_24 != 0)
        {
            goto label_51;
        }
        
        val_26 = mem[this.vector3s];
        if(val_26 == 0)
        {
            goto label_52;
        }
        
        label_51:
        val_25 = -(new UnityEngine.Mathf().punch(amplitude:  System.Math.Abs(mem[this.vector3s] + 52), value:  this.percentage));
        label_48:
        mem2[0] = val_25;
        label_50:
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.vector3s[2], y = this.vector3s[2], z = this.vector3s[2]}, b:  new UnityEngine.Vector3() {x = mem[this.vector3s] + 68, y = mem[this.vector3s] + 68 + 4, z = mem[this.vector3s] + 76});
        val_27 = val_9.x;
        val_28 = val_9.y;
        val_29 = val_9.z;
        this.thisTransform.Translate(translation:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29}, relativeTo:  this.space);
        val_30 = mem[mem[this.vector3s] + 24];
        val_30 = mem[this.vector3s] + 24;
        if(val_30 <= 2)
        {
                val_30 = mem[mem[this.vector3s] + 24];
            val_30 = mem[this.vector3s] + 24;
        }
        
        mem2[0] = mem[this.vector3s] + 56;
        mem2[0] = mem[this.vector3s] + 56 + 4;
        mem2[0] = mem[this.vector3s] + 64;
        if((this.tweenArguments & 1) != 0)
        {
                val_29 = 0f;
            val_27 = val_16;
            val_28 = val_17;
            this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29};
        }
        
        UnityEngine.Vector3 val_10 = this.thisTransform.position;
        this.postUpdate = val_10;
        mem[1152921525876489088] = val_10.y;
        mem[1152921525876489092] = val_10.z;
        if(this.physics == false)
        {
                return;
        }
        
        this.thisTransform.position = new UnityEngine.Vector3() {x = this.preUpdate, y = val_17, z = val_16};
        this.GetComponent<UnityEngine.Rigidbody>().MovePosition(position:  new UnityEngine.Vector3() {x = this.postUpdate, y = val_17, z = val_16});
        return;
        label_52:
    }
    private void ApplyPunchRotationTargets()
    {
        UnityEngine.Vector3[] val_13;
        UnityEngine.Vector3 val_14;
        UnityEngine.Vector3[] val_15;
        UnityEngine.Vector3[] val_16;
        UnityEngine.Vector3 val_17;
        UnityEngine.Vector3[] val_18;
        UnityEngine.Vector3[] val_19;
        UnityEngine.Vector3 val_20;
        UnityEngine.Vector3[] val_21;
        int val_22;
        UnityEngine.Vector3 val_1 = this.thisTransform.eulerAngles;
        this.preUpdate = val_1;
        mem[1152921525877403892] = val_1.y;
        mem[1152921525877403896] = val_1.z;
        val_13 = this.vector3s;
        if(this.vector3s[1] <= 0f)
        {
            goto label_5;
        }
        
        val_14 = this.punch(amplitude:  this.vector3s[1], value:  this.percentage);
        if(this.vector3s.Length > 2)
        {
            goto label_9;
        }
        
        goto label_9;
        label_5:
        if(val_13[1] >= 0)
        {
            goto label_11;
        }
        
        val_13 = this.vector3s;
        val_15 = val_13;
        if(val_13 != null)
        {
            goto label_12;
        }
        
        val_15 = this.vector3s;
        if(val_15 == null)
        {
            goto label_45;
        }
        
        label_12:
        val_14 = -(new UnityEngine.Mathf().punch(amplitude:  System.Math.Abs(val_15[1]), value:  this.percentage));
        label_9:
        val_13[2] = val_14;
        label_11:
        val_16 = this.vector3s;
        if(this.vector3s[1] <= 0f)
        {
            goto label_21;
        }
        
        val_17 = this.punch(amplitude:  this.vector3s[1], value:  this.percentage);
        if(this.vector3s.Length > 2)
        {
            goto label_25;
        }
        
        goto label_25;
        label_21:
        if(val_16[1] >= 0)
        {
            goto label_27;
        }
        
        val_16 = this.vector3s;
        val_18 = val_16;
        if(val_16 != null)
        {
            goto label_28;
        }
        
        val_18 = this.vector3s;
        if(val_18 == null)
        {
            goto label_45;
        }
        
        label_28:
        val_17 = -(new UnityEngine.Mathf().punch(amplitude:  System.Math.Abs(val_18[1]), value:  this.percentage));
        label_25:
        val_16[2] = val_17;
        label_27:
        val_19 = this.vector3s;
        if(this.vector3s[1] <= 0f)
        {
            goto label_37;
        }
        
        val_20 = this.punch(amplitude:  this.vector3s[1], value:  this.percentage);
        if(this.vector3s.Length > 2)
        {
            goto label_41;
        }
        
        goto label_41;
        label_37:
        if(val_19[1] >= 0)
        {
            goto label_43;
        }
        
        val_19 = this.vector3s;
        val_21 = val_19;
        if(val_19 != null)
        {
            goto label_44;
        }
        
        val_21 = this.vector3s;
        if(val_21 == null)
        {
            goto label_45;
        }
        
        label_44:
        val_20 = -(new UnityEngine.Mathf().punch(amplitude:  System.Math.Abs(val_21[1]), value:  this.percentage));
        label_41:
        val_19[2] = val_20;
        label_43:
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.vector3s[2], y = this.vector3s[2], z = this.vector3s[2]}, b:  new UnityEngine.Vector3() {x = this.vector3s[3], y = this.vector3s[3], z = this.vector3s[3]});
        this.thisTransform.Rotate(eulers:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, relativeTo:  this.space);
        val_22 = this.vector3s.Length;
        if(val_22 <= 2)
        {
                val_22 = this.vector3s.Length;
        }
        
        this.vector3s[3] = this.vector3s[2];
        this.vector3s[3] = this.vector3s[2];
        this.vector3s[3] = this.vector3s[2];
        UnityEngine.Vector3 val_9 = this.thisTransform.eulerAngles;
        this.postUpdate = val_9;
        mem[1152921525877403904] = val_9.y;
        mem[1152921525877403908] = val_9.z;
        if(this.physics == false)
        {
                return;
        }
        
        this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.preUpdate, y = val_8.y, z = val_8.z};
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.postUpdate, y = val_8.y, z = this.preUpdate});
        this.GetComponent<UnityEngine.Rigidbody>().MoveRotation(rot:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w});
        return;
        label_45:
    }
    private void ApplyPunchScaleTargets()
    {
        UnityEngine.Vector3[] val_8;
        UnityEngine.Vector3 val_10;
        UnityEngine.Vector3[] val_11;
        UnityEngine.Vector3[] val_12;
        UnityEngine.Vector3 val_13;
        UnityEngine.Vector3[] val_14;
        UnityEngine.Vector3[] val_15;
        UnityEngine.Vector3 val_16;
        UnityEngine.Vector3[] val_17;
        val_8 = this.vector3s;
        if(this.vector3s[1] <= 0f)
        {
            goto label_4;
        }
        
        val_10 = this.punch(amplitude:  this.vector3s[1], value:  this.percentage);
        if(this.vector3s.Length > 2)
        {
            goto label_8;
        }
        
        goto label_8;
        label_4:
        if(val_8[1] >= 0)
        {
            goto label_10;
        }
        
        val_8 = this.vector3s;
        val_11 = val_8;
        if(val_8 != null)
        {
            goto label_11;
        }
        
        val_11 = this.vector3s;
        if(val_11 == null)
        {
            goto label_44;
        }
        
        label_11:
        val_10 = -(new UnityEngine.Mathf().punch(amplitude:  System.Math.Abs(val_11[1]), value:  this.percentage));
        label_8:
        val_8[2] = val_10;
        label_10:
        val_12 = this.vector3s;
        if(this.vector3s[1] <= 0f)
        {
            goto label_20;
        }
        
        val_13 = this.punch(amplitude:  this.vector3s[1], value:  this.percentage);
        if(this.vector3s.Length > 2)
        {
            goto label_24;
        }
        
        goto label_24;
        label_20:
        if(val_12[1] >= 0)
        {
            goto label_26;
        }
        
        val_12 = this.vector3s;
        val_14 = val_12;
        if(val_12 != null)
        {
            goto label_27;
        }
        
        val_14 = this.vector3s;
        if(val_14 == null)
        {
            goto label_44;
        }
        
        label_27:
        val_13 = -(new UnityEngine.Mathf().punch(amplitude:  System.Math.Abs(val_14[1]), value:  this.percentage));
        label_24:
        val_12[2] = val_13;
        label_26:
        val_15 = this.vector3s;
        if(this.vector3s[1] <= 0f)
        {
            goto label_36;
        }
        
        val_16 = this.punch(amplitude:  this.vector3s[1], value:  this.percentage);
        if(this.vector3s.Length > 2)
        {
            goto label_40;
        }
        
        goto label_40;
        label_36:
        if(val_15[1] >= 0)
        {
            goto label_42;
        }
        
        val_15 = this.vector3s;
        val_17 = val_15;
        if(val_15 != null)
        {
            goto label_43;
        }
        
        val_17 = this.vector3s;
        if(val_17 == null)
        {
            goto label_44;
        }
        
        label_43:
        val_16 = -(new UnityEngine.Mathf().punch(amplitude:  System.Math.Abs(val_17[1]), value:  this.percentage));
        label_40:
        val_15[2] = val_16;
        label_42:
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = this.vector3s[0], z = this.vector3s[0]}, b:  new UnityEngine.Vector3() {x = this.vector3s[2], y = this.vector3s[2], z = this.vector3s[2]});
        this.thisTransform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        return;
        label_44:
    }
    private System.Collections.IEnumerator TweenDelay()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new iTween.<TweenDelay>d__149(<>1__state:  0);
    }
    private void TweenStart()
    {
        UnityEngine.AudioClip val_11;
        this.CallBack(callbackType:  "onstart");
        if(this.loop != true)
        {
                this.ConflictCheck();
            this.GenerateTargets();
        }
        
        if((System.String.op_Equality(a:  this.type, b:  "stab")) != false)
        {
                if(this.audioSource != null)
        {
                val_11 = this.audioSource.clip;
        }
        else
        {
                val_11 = 0.clip;
        }
        
            this.audioSource.PlayOneShot(clip:  val_11);
        }
        
        if((((((System.String.op_Equality(a:  this.type, b:  "move")) != true) && ((System.String.op_Equality(a:  this.type, b:  "scale")) != true)) && ((System.String.op_Equality(a:  this.type, b:  "rotate")) != true)) && ((System.String.op_Equality(a:  this.type, b:  "punch")) != true)) && ((System.String.op_Equality(a:  this.type, b:  "shake")) != true))
        {
                if((System.String.op_Equality(a:  this.type, b:  "curve")) != true)
        {
                bool val_10 = System.String.op_Equality(a:  this.type, b:  "look");
        }
        
        }
        
        this.isRunning = true;
    }
    private System.Collections.IEnumerator TweenRestart()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new iTween.<TweenRestart>d__151(<>1__state:  0);
    }
    private void TweenUpdate()
    {
        this.apply.Invoke();
        this.CallBack(callbackType:  "onupdate");
        this.UpdatePercentage();
    }
    private void TweenComplete()
    {
        this.isRunning = false;
        this.percentage = (this.percentage > 0.5f) ? 1f : 0f;
        this.apply.Invoke();
        if((System.String.op_Equality(a:  this.type, b:  "value")) != false)
        {
                this.CallBack(callbackType:  "onupdate");
        }
        
        if(this.loopType != 0)
        {
                this.TweenLoop();
        }
        else
        {
                this.Dispose();
        }
        
        this.CallBack(callbackType:  "oncomplete");
    }
    private void TweenLoop()
    {
        if(this.loopType != 2)
        {
                if(this.loopType != 1)
        {
                return;
        }
        
            this.runningTime = 0f;
            this.percentage = 0f;
            this.apply.Invoke();
        }
        else
        {
                bool val_2 = this.reverse;
            this.runningTime = 0f;
            val_2 = val_2 ^ 1;
            this.reverse = val_2;
        }
        
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "TweenRestart");
    }
    public static UnityEngine.Rect RectUpdate(UnityEngine.Rect currentValue, UnityEngine.Rect targetValue, float speed)
    {
        float val_13 = currentValue.m_XMin.System.IConvertible.ToSingle(provider:  0);
        float val_12 = targetValue.m_XMin.System.IConvertible.ToSingle(provider:  0);
        val_12 = val_12 - val_13;
        float val_3 = UnityEngine.Time.deltaTime;
        float val_4 = val_12 * speed;
        val_3 = val_4 * val_3;
        val_13 = val_13 + val_3;
        float val_14 = val_3;
        float val_6 = UnityEngine.Time.deltaTime;
        val_4 = (val_3 - val_14) * speed;
        val_6 = val_6 * val_4;
        val_14 = val_14 + val_6;
        float val_15 = val_6;
        float val_8 = UnityEngine.Time.deltaTime;
        val_4 = (val_6 - val_15) * speed;
        val_8 = val_8 * val_4;
        val_15 = val_15 + val_8;
        float val_10 = UnityEngine.Time.deltaTime;
        val_4 = (val_8 - val_8) * speed;
        val_10 = val_10 * val_4;
        float val_11 = val_8 + val_10;
        return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
    }
    public static UnityEngine.Vector3 Vector3Update(UnityEngine.Vector3 currentValue, UnityEngine.Vector3 targetValue, float speed)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = targetValue.x, y = targetValue.y, z = targetValue.z}, b:  new UnityEngine.Vector3() {x = currentValue.x, y = currentValue.y, z = currentValue.z});
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  speed);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  UnityEngine.Time.deltaTime);
        return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = currentValue.x, y = currentValue.y, z = currentValue.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }
    public static UnityEngine.Vector2 Vector2Update(UnityEngine.Vector2 currentValue, UnityEngine.Vector2 targetValue, float speed)
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = targetValue.x, y = targetValue.y}, b:  new UnityEngine.Vector2() {x = currentValue.x, y = currentValue.y});
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  speed);
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, d:  UnityEngine.Time.deltaTime);
        return UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = currentValue.x, y = currentValue.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
    }
    public static float FloatUpdate(float currentValue, float targetValue, float speed)
    {
        float val_2 = UnityEngine.Time.deltaTime;
        targetValue = (targetValue - currentValue) * speed;
        val_2 = targetValue * val_2;
        val_2 = val_2 + currentValue;
        return (float)val_2;
    }
    public static void FadeUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        iTween.ColorUpdate(target:  target, args:  args);
    }
    public static void FadeUpdate(UnityEngine.GameObject target, float alpha, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "alpha";
        val_1[1] = alpha;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.FadeUpdate(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void ColorUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        UnityEngine.Color val_38;
        var val_41;
        var val_42;
        var val_46;
        float val_47;
        var val_48;
        int val_53;
        int val_55;
        int val_56;
        int val_57;
        int val_58;
        UnityEngine.Color val_59;
        UnityEngine.Color val_60;
        UnityEngine.Object val_61;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  args);
        UnityEngine.Color[] val_2 = new UnityEngine.Color[4];
        if((args & 1) != 0)
        {
                if(null == null)
        {
            goto label_43;
        }
        
        }
        
        System.Collections.IEnumerator val_4 = target.transform.GetEnumerator();
        val_38 = 1152921504687943680;
        label_28:
        var val_39 = 0;
        val_39 = val_39 + 1;
        if(val_4.MoveNext() == false)
        {
            goto label_13;
        }
        
        var val_40 = 0;
        val_40 = val_40 + 1;
        val_41 = val_4.Current;
        if(val_41 != null)
        {
                val_41 = 0;
        }
        
        UnityEngine.GameObject val_13 = val_41.gameObject;
        goto label_28;
        label_13:
        val_42 = 0;
        if(val_4 != null)
        {
                var val_41 = 0;
            val_41 = val_41 + 1;
            val_4.Dispose();
        }
        
        label_43:
        if((args & 1) == 0)
        {
            goto label_45;
        }
        
        val_46 = null;
        val_46 = null;
        val_47 = null * iTween.Defaults.updateTimePercentage;
        if(target != null)
        {
            goto label_52;
        }
        
        goto label_49;
        label_45:
        val_48 = null;
        val_48 = null;
        val_47 = iTween.Defaults.updateTime;
        if(target != null)
        {
            goto label_52;
        }
        
        label_49:
        label_52:
        bool val_16 = UnityEngine.Object.op_Implicit(exists:  target.GetComponent<UnityEngine.Renderer>());
        if(target == null)
        {
            goto label_55;
        }
        
        if(val_16 == false)
        {
            goto label_56;
        }
        
        label_60:
        UnityEngine.Color val_19 = target.GetComponent<UnityEngine.Renderer>().material.color;
        goto label_59;
        label_55:
        if(val_16 == true)
        {
            goto label_60;
        }
        
        label_56:
        val_38 = 1152921525343818672;
        if((UnityEngine.Object.op_Implicit(exists:  target.GetComponent<UnityEngine.Light>())) == false)
        {
            goto label_63;
        }
        
        UnityEngine.Color val_23 = target.GetComponent<UnityEngine.Light>().color;
        label_59:
        val_53 = val_2.Length;
        if(val_53 <= 1)
        {
                val_53 = val_2.Length;
        }
        
        val_2[1] = val_23;
        val_2[1] = val_23.g;
        val_2[1] = val_23.b;
        val_2[1] = val_23.a;
        val_2[0] = val_23;
        val_2[0] = val_23.g;
        val_2[0] = val_23.b;
        val_2[0] = val_23.a;
        label_63:
        if((args & 1) == 0)
        {
            goto label_69;
        }
        
        val_2[1] = new UnityEngine.Color();
        val_2[1] = val_38;
        val_2[1] = 1152921504865153024;
        goto label_72;
        label_69:
        if((args & 1) != 0)
        {
                val_2[1] = new UnityEngine.Color();
        }
        
        if((args & 1) != 0)
        {
                val_2[1] = new UnityEngine.Color();
        }
        
        if((args & 1) != 0)
        {
                val_2[1] = new UnityEngine.Color();
        }
        
        if((args & 1) == 0)
        {
            goto label_82;
        }
        
        label_72:
        mem2[0] = null;
        label_120:
        val_55 = val_2.Length;
        if(val_55 == 0)
        {
                val_55 = val_2.Length;
        }
        
        if(val_55 <= 1)
        {
                val_55 = val_2.Length;
        }
        
        val_56 = val_2.Length;
        if(val_56 <= 3)
        {
                val_56 = val_2.Length;
        }
        
        val_2[3] = UnityEngine.Mathf.SmoothDamp(current:  val_2[0], target:  val_2[1], currentVelocity: ref  val_2[64], smoothTime:  val_47);
        if(val_56 == 0)
        {
                val_56 = val_2.Length;
        }
        
        if(val_56 <= 1)
        {
                val_56 = val_2.Length;
        }
        
        val_57 = val_2.Length;
        if(val_57 <= 3)
        {
                val_57 = val_2.Length;
        }
        
        val_2[3] = UnityEngine.Mathf.SmoothDamp(current:  val_2[0], target:  val_2[1], currentVelocity: ref  val_2[64][4], smoothTime:  val_47);
        if(val_57 == 0)
        {
                val_57 = val_2.Length;
        }
        
        if(val_57 <= 1)
        {
                val_57 = val_2.Length;
        }
        
        val_58 = val_2.Length;
        if(val_58 <= 3)
        {
                val_58 = val_2.Length;
        }
        
        val_2[3] = UnityEngine.Mathf.SmoothDamp(current:  val_2[0], target:  val_2[1], currentVelocity: ref  val_2[72], smoothTime:  val_47);
        if(val_58 == 0)
        {
                val_58 = val_2.Length;
        }
        
        if(val_58 <= 1)
        {
                val_58 = val_2.Length;
        }
        
        val_59 = val_2[1];
        val_60 = UnityEngine.Mathf.SmoothDamp(current:  val_2[0], target:  val_59, currentVelocity: ref  val_2[64][12], smoothTime:  val_47);
        val_2[3] = val_60;
        val_61 = UnityEngine.Object.op_Implicit(exists:  target.GetComponent<UnityEngine.Renderer>());
        if(target == null)
        {
            goto label_106;
        }
        
        if(val_61 == false)
        {
            goto label_107;
        }
        
        label_112:
        val_60 = val_2[3];
        val_59 = val_2[3];
        target.GetComponent<UnityEngine.Renderer>().material.color = new UnityEngine.Color() {r = val_60, g = val_2[3], b = val_59, a = val_2[3]};
        return;
        label_106:
        if(val_61 == true)
        {
            goto label_112;
        }
        
        label_107:
        val_61 = target.GetComponent<UnityEngine.Light>();
        if((UnityEngine.Object.op_Implicit(exists:  val_61)) == false)
        {
                return;
        }
        
        val_60 = val_2[3];
        val_59 = val_2[3];
        target.GetComponent<UnityEngine.Light>().color = new UnityEngine.Color() {r = val_60, g = val_2[3], b = val_59, a = val_2[3]};
        return;
        label_82:
        if(val_2 != null)
        {
            goto label_120;
        }
        
        goto label_120;
    }
    public static void ColorUpdate(UnityEngine.GameObject target, UnityEngine.Color color, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "color";
        val_1[1] = color;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.ColorUpdate(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void AudioUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        var val_3;
        var val_16;
        float val_17;
        var val_18;
        var val_19;
        float val_20;
        var val_21;
        int val_22;
        int val_23;
        int val_24;
        int val_25;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  args);
        UnityEngine.Vector2[] val_2 = new UnityEngine.Vector2[4];
        if((args & 1) != 0)
        {
                val_16 = null;
            val_16 = null;
            val_17 = null * iTween.Defaults.updateTimePercentage;
        }
        else
        {
                val_18 = null;
            val_18 = null;
            val_17 = iTween.Defaults.updateTime;
        }
        
        if((args & 1) == 0)
        {
            goto label_10;
        }
        
        val_19 = args;
        if(val_19 == null)
        {
            goto label_19;
        }
        
        if(null == null)
        {
            goto label_12;
        }
        
        val_19 = 0;
        goto label_19;
        label_10:
        if((UnityEngine.Object.op_Implicit(exists:  target.GetComponent<UnityEngine.AudioSource>())) == false)
        {
            goto label_17;
        }
        
        val_19 = target.GetComponent<UnityEngine.AudioSource>();
        if(val_19 == null)
        {
            goto label_19;
        }
        
        label_12:
        val_20 = val_19.volume;
        val_21 = 0;
        goto label_20;
        label_19:
        val_20 = val_19.volume;
        val_21 = 1;
        label_20:
        val_3 = 0;
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_20, y:  val_19.pitch);
        val_22 = val_2.Length;
        if(val_22 <= 1)
        {
                val_22 = val_2.Length;
        }
        
        val_2[1] = val_10.x;
        val_2[1] = val_10.y;
        val_2[0] = val_10.x;
        val_2[0] = val_10.y;
        if((args & 1) != 0)
        {
                val_2[1] = new UnityEngine.Vector2();
        }
        
        if((args & 1) != 0)
        {
                val_2[1] = new UnityEngine.Vector2();
        }
        
        val_23 = val_2.Length;
        if(val_23 == 0)
        {
                val_23 = val_2.Length;
        }
        
        if(val_23 <= 1)
        {
                val_23 = val_2.Length;
        }
        
        val_24 = val_2.Length;
        if(val_24 <= 3)
        {
                val_24 = val_2.Length;
        }
        
        val_2[3] = UnityEngine.Mathf.SmoothDampAngle(current:  val_2[0], target:  val_2[1], currentVelocity: ref  val_2[48], smoothTime:  val_17);
        if(val_24 == 0)
        {
                val_24 = val_2.Length;
        }
        
        if(val_24 <= 1)
        {
                val_24 = val_2.Length;
        }
        
        val_25 = val_2.Length;
        if(val_25 <= 3)
        {
                val_25 = val_2.Length;
        }
        
        val_2[3] = UnityEngine.Mathf.SmoothDampAngle(current:  val_2[0], target:  val_2[1], currentVelocity: ref  val_2[48][4], smoothTime:  val_17);
        val_19.volume = val_2[3];
        val_19.pitch = val_2[3];
        return;
        label_17:
        UnityEngine.Debug.LogError(message:  "iTween Error: AudioUpdate requires an AudioSource.");
    }
    public static void AudioUpdate(UnityEngine.GameObject target, float volume, float pitch, float time)
    {
        object[] val_1 = new object[6];
        val_1[0] = "volume";
        val_1[1] = volume;
        val_1[2] = "pitch";
        val_1[3] = pitch;
        val_1[4] = "time";
        val_1[5] = time;
        iTween.AudioUpdate(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void RotateUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        var val_32;
        float val_33;
        float val_34;
        var val_35;
        float val_36;
        var val_37;
        var val_38;
        var val_39;
        IntPtr val_43;
        var val_44;
        int val_45;
        int val_46;
        int val_47;
        UnityEngine.Vector3 val_48;
        val_32 = target;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  args);
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[4];
        UnityEngine.Vector3 val_4 = val_32.transform.eulerAngles;
        val_33 = val_4.x;
        val_34 = val_4.z;
        if((args & 1) != 0)
        {
                val_35 = null;
            val_35 = null;
            val_36 = null * iTween.Defaults.updateTimePercentage;
        }
        else
        {
                val_37 = null;
            val_37 = null;
            val_36 = iTween.Defaults.updateTime;
        }
        
        if((args & 1) != 0)
        {
                val_38 = args;
        }
        else
        {
                val_39 = null;
            val_39 = null;
            val_38 = 1152921505060098072;
        }
        
        UnityEngine.Transform val_5 = val_32.transform;
        if(val_5 == null)
        {
            goto label_17;
        }
        
        if(val_38 == false)
        {
            goto label_18;
        }
        
        label_20:
        UnityEngine.Vector3 val_6 = val_5.localEulerAngles;
        goto label_19;
        label_17:
        if(val_38 == true)
        {
            goto label_20;
        }
        
        label_18:
        UnityEngine.Vector3 val_7 = val_5.eulerAngles;
        label_19:
        val_2[0] = val_7;
        val_2[0] = val_7.y;
        val_2[0] = val_7.z;
        if((args & 1) != 0)
        {
                val_43 = System.Type.op_Equality(left:  args.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_44 = args;
            if(val_43 != false)
        {
                val_44 = 0;
            UnityEngine.Vector3 val_13 = val_44.eulerAngles;
            val_2[1] = val_13;
            val_2[1] = val_13.y;
            val_2[1] = val_13.z;
        }
        else
        {
                System.Type val_14 = val_44.GetType();
            val_43 = null;
            if((System.Type.op_Equality(left:  val_14, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_43}))) != false)
        {
                val_2[1] = new UnityEngine.Vector3();
            val_2[1] = val_14;
            val_2[1] = args;
        }
        
        }
        
        }
        
        val_45 = val_2.Length;
        if(val_45 == 0)
        {
                val_45 = val_2.Length;
        }
        
        if(val_45 <= 1)
        {
                val_45 = val_2.Length;
        }
        
        val_46 = val_2.Length;
        if(val_46 <= 3)
        {
                val_46 = val_2.Length;
        }
        
        val_2[3] = UnityEngine.Mathf.SmoothDampAngle(current:  val_2[0], target:  val_2[1], currentVelocity: ref  val_2[56], smoothTime:  val_36);
        if(val_46 == 0)
        {
                val_46 = val_2.Length;
        }
        
        if(val_46 <= 1)
        {
                val_46 = val_2.Length;
        }
        
        val_47 = val_2.Length;
        if(val_47 <= 3)
        {
                val_47 = val_2.Length;
        }
        
        val_2[3] = UnityEngine.Mathf.SmoothDampAngle(current:  val_2[0], target:  val_2[1], currentVelocity: ref  val_2[56][4], smoothTime:  val_36);
        if(val_47 == 0)
        {
                val_47 = val_2.Length;
        }
        
        if(val_47 <= 1)
        {
                val_47 = val_2.Length;
        }
        
        val_2[3] = UnityEngine.Mathf.SmoothDampAngle(current:  val_2[0], target:  val_2[1], currentVelocity: ref  val_2[56][8], smoothTime:  val_36);
        UnityEngine.Transform val_23 = val_32.transform;
        UnityEngine.Vector3 val_37 = val_2[3];
        val_48 = val_2[3];
        UnityEngine.Vector3 val_38 = val_2[3];
        if(val_23 == null)
        {
            goto label_54;
        }
        
        if(val_38 == false)
        {
            goto label_55;
        }
        
        label_68:
        val_23.localEulerAngles = new UnityEngine.Vector3() {x = val_37, y = val_48, z = val_38};
        if(val_32 != null)
        {
            goto label_69;
        }
        
        label_70:
        label_69:
        if((val_32.GetComponent<UnityEngine.Rigidbody>()) == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_27 = val_32.transform.eulerAngles;
        val_48 = val_27.y;
        val_32.transform.eulerAngles = new UnityEngine.Vector3() {x = val_33, y = val_4.y, z = val_34};
        val_32 = val_32.GetComponent<UnityEngine.Rigidbody>();
        UnityEngine.Quaternion val_30 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_27.x, y = val_48, z = val_27.z});
        val_33 = val_30.x;
        val_34 = val_30.z;
        val_32.MoveRotation(rot:  new UnityEngine.Quaternion() {x = val_33, y = val_30.y, z = val_34, w = val_30.w});
        return;
        label_54:
        if(val_38 == true)
        {
            goto label_68;
        }
        
        label_55:
        val_23.eulerAngles = new UnityEngine.Vector3() {x = val_37, y = val_48, z = val_38};
        if(val_32 != null)
        {
            goto label_69;
        }
        
        goto label_70;
    }
    public static void RotateUpdate(UnityEngine.GameObject target, UnityEngine.Vector3 rotation, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "rotation";
        val_1[1] = rotation;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.RotateUpdate(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void ScaleUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        var val_22;
        float val_23;
        var val_24;
        int val_28;
        IntPtr val_29;
        var val_30;
        int val_31;
        int val_32;
        int val_33;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  args);
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[4];
        if((args & 1) == 0)
        {
            goto label_4;
        }
        
        val_22 = null;
        val_22 = null;
        val_23 = null * iTween.Defaults.updateTimePercentage;
        if(target != null)
        {
            goto label_11;
        }
        
        goto label_8;
        label_4:
        val_24 = null;
        val_24 = null;
        val_23 = iTween.Defaults.updateTime;
        if(target != null)
        {
            goto label_11;
        }
        
        label_8:
        label_11:
        UnityEngine.Vector3 val_4 = target.transform.localScale;
        val_28 = val_2.Length;
        if(val_28 <= 1)
        {
                val_28 = val_2.Length;
        }
        
        val_2[1] = val_4;
        val_2[1] = val_4.y;
        val_2[1] = val_4.z;
        val_2[0] = val_4;
        val_2[0] = val_4.y;
        val_2[0] = val_4.z;
        if((args & 1) == 0)
        {
            goto label_16;
        }
        
        val_29 = System.Type.op_Equality(left:  args.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_30 = args;
        if(val_29 == false)
        {
            goto label_20;
        }
        
        val_30 = 0;
        UnityEngine.Vector3 val_10 = val_30.localScale;
        val_2[1] = val_10;
        val_2[1] = val_10.y;
        val_2[1] = val_10.z;
        goto label_36;
        label_16:
        if((args & 1) != 0)
        {
                val_2[1] = new UnityEngine.Vector3();
        }
        
        if((args & 1) != 0)
        {
                val_2[1] = new UnityEngine.Vector3();
        }
        
        if((args & 1) == 0)
        {
            goto label_36;
        }
        
        val_2[1] = new UnityEngine.Vector3();
        goto label_36;
        label_20:
        System.Type val_11 = val_30.GetType();
        val_29 = null;
        if((System.Type.op_Equality(left:  val_11, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_29}))) != false)
        {
                val_2[1] = new UnityEngine.Vector3();
            val_2[1] = val_11;
            val_2[1] = args;
        }
        
        label_36:
        val_31 = val_2.Length;
        if(val_31 == 0)
        {
                val_31 = val_2.Length;
        }
        
        if(val_31 <= 1)
        {
                val_31 = val_2.Length;
        }
        
        val_32 = val_2.Length;
        if(val_32 <= 3)
        {
                val_32 = val_2.Length;
        }
        
        val_2[3] = UnityEngine.Mathf.SmoothDamp(current:  val_2[0], target:  val_2[1], currentVelocity: ref  val_2[56], smoothTime:  val_23);
        if(val_32 == 0)
        {
                val_32 = val_2.Length;
        }
        
        if(val_32 <= 1)
        {
                val_32 = val_2.Length;
        }
        
        val_33 = val_2.Length;
        if(val_33 <= 3)
        {
                val_33 = val_2.Length;
        }
        
        val_2[3] = UnityEngine.Mathf.SmoothDamp(current:  val_2[0], target:  val_2[1], currentVelocity: ref  val_2[56][4], smoothTime:  val_23);
        if(val_33 == 0)
        {
                val_33 = val_2.Length;
        }
        
        if(val_33 <= 1)
        {
                val_33 = val_2.Length;
        }
        
        val_2[3] = UnityEngine.Mathf.SmoothDamp(current:  val_2[0], target:  val_2[1], currentVelocity: ref  val_2[56][8], smoothTime:  val_23);
        target.transform.localScale = new UnityEngine.Vector3() {x = val_2[3], y = val_2[3], z = val_2[3]};
    }
    public static void ScaleUpdate(UnityEngine.GameObject target, UnityEngine.Vector3 scale, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "scale";
        val_1[1] = scale;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.ScaleUpdate(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void MoveUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        UnityEngine.Vector3 val_12;
        UnityEngine.GameObject val_31;
        var val_32;
        float val_33;
        var val_34;
        var val_35;
        var val_36;
        int val_40;
        IntPtr val_41;
        var val_42;
        int val_43;
        int val_44;
        int val_45;
        UnityEngine.Vector3 val_46;
        val_31 = target;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  args);
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[4];
        UnityEngine.Vector3 val_4 = val_31.transform.position;
        if((args & 1) != 0)
        {
                val_32 = null;
            val_32 = null;
            val_33 = null * iTween.Defaults.updateTimePercentage;
        }
        else
        {
                val_34 = null;
            val_34 = null;
            val_33 = iTween.Defaults.updateTime;
        }
        
        if((args & 1) != 0)
        {
                val_35 = args;
        }
        else
        {
                val_36 = null;
            val_36 = null;
            val_35 = 1152921505060098072;
        }
        
        UnityEngine.Transform val_5 = val_31.transform;
        if(val_5 == null)
        {
            goto label_17;
        }
        
        if(val_35 == false)
        {
            goto label_18;
        }
        
        label_20:
        UnityEngine.Vector3 val_6 = val_5.localPosition;
        goto label_19;
        label_17:
        if(val_35 == true)
        {
            goto label_20;
        }
        
        label_18:
        UnityEngine.Vector3 val_7 = val_5.position;
        label_19:
        val_40 = val_2.Length;
        if(val_40 <= 1)
        {
                val_40 = val_2.Length;
        }
        
        val_2[1] = val_7;
        val_2[1] = val_7.y;
        val_2[1] = val_7.z;
        val_2[0] = val_7;
        val_2[0] = val_7.y;
        val_2[0] = val_7.z;
        if((args & 1) == 0)
        {
            goto label_24;
        }
        
        val_41 = System.Type.op_Equality(left:  args.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_42 = args;
        if(val_41 == false)
        {
            goto label_28;
        }
        
        if(val_42 != null)
        {
            
        }
        
        val_42 = 0;
        UnityEngine.Vector3 val_13 = val_42.position;
        val_2[1] = val_13;
        val_2[1] = val_13.y;
        val_2[1] = val_13.z;
        goto label_44;
        label_24:
        if((args & 1) != 0)
        {
                val_2[1] = new UnityEngine.Vector3();
        }
        
        if((args & 1) != 0)
        {
                val_2[1] = new UnityEngine.Vector3();
        }
        
        if((args & 1) == 0)
        {
            goto label_44;
        }
        
        val_2[1] = new UnityEngine.Vector3();
        goto label_44;
        label_28:
        System.Type val_14 = val_42.GetType();
        val_41 = null;
        if((System.Type.op_Equality(left:  val_14, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_41}))) != false)
        {
                val_2[1] = new UnityEngine.Vector3();
            val_2[1] = val_41;
            val_2[1] = val_14;
        }
        
        label_44:
        val_43 = val_2.Length;
        if(val_43 == 0)
        {
                val_43 = val_2.Length;
        }
        
        if(val_43 <= 1)
        {
                val_43 = val_2.Length;
        }
        
        val_44 = val_2.Length;
        if(val_44 <= 3)
        {
                val_44 = val_2.Length;
        }
        
        val_2[3] = UnityEngine.Mathf.SmoothDamp(current:  val_2[0], target:  val_2[1], currentVelocity: ref  val_2[56], smoothTime:  val_33);
        if(val_44 == 0)
        {
                val_44 = val_2.Length;
        }
        
        if(val_44 <= 1)
        {
                val_44 = val_2.Length;
        }
        
        val_45 = val_2.Length;
        if(val_45 <= 3)
        {
                val_45 = val_2.Length;
        }
        
        val_2[3] = UnityEngine.Mathf.SmoothDamp(current:  val_2[0], target:  val_2[1], currentVelocity: ref  val_2[56][4], smoothTime:  val_33);
        if(val_45 == 0)
        {
                val_45 = val_2.Length;
        }
        
        if(val_45 <= 1)
        {
                val_45 = val_2.Length;
        }
        
        val_2[3] = UnityEngine.Mathf.SmoothDamp(current:  val_2[0], target:  val_2[1], currentVelocity: ref  val_2[56][8], smoothTime:  val_33);
        if(((args & 1) != 0) && (null != null))
        {
                UnityEngine.Vector3 val_37 = val_2[3];
            val_12 = val_2[3];
        }
        
        if((args & 1) != 0)
        {
                iTween.LookUpdate(target:  val_31, args:  args);
        }
        
        UnityEngine.Transform val_23 = val_31.transform;
        UnityEngine.Vector3 val_38 = val_2[3];
        val_46 = val_2[3];
        UnityEngine.Vector3 val_39 = val_2[3];
        if(val_23 == null)
        {
            goto label_68;
        }
        
        if(val_35 == false)
        {
            goto label_69;
        }
        
        label_80:
        val_23.localPosition = new UnityEngine.Vector3() {x = val_38, y = val_46, z = val_39};
        if(val_31 != null)
        {
            goto label_81;
        }
        
        label_82:
        label_81:
        if((val_31.GetComponent<UnityEngine.Rigidbody>()) == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_27 = val_31.transform.position;
        val_46 = val_27.y;
        val_31.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        val_31 = val_31.GetComponent<UnityEngine.Rigidbody>();
        val_31.MovePosition(position:  new UnityEngine.Vector3() {x = val_27.x, y = val_46, z = val_27.z});
        return;
        label_68:
        if(val_35 == true)
        {
            goto label_80;
        }
        
        label_69:
        val_23.position = new UnityEngine.Vector3() {x = val_38, y = val_46, z = val_39};
        if(val_31 != null)
        {
            goto label_81;
        }
        
        goto label_82;
    }
    public static void MoveUpdate(UnityEngine.GameObject target, UnityEngine.Vector3 position, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "position";
        val_1[1] = position;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.MoveUpdate(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static void LookUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        var val_10;
        System.Collections.Hashtable val_34;
        var val_35;
        var val_36;
        var val_37;
        float val_38;
        var val_39;
        float val_40;
        float val_41;
        float val_42;
        UnityEngine.Vector3 val_43;
        UnityEngine.Transform val_44;
        var val_45;
        UnityEngine.Vector3 val_46;
        var val_47;
        var val_48;
        var val_49;
        UnityEngine.Vector3 val_53;
        var val_54;
        var val_55;
        var val_56;
        int val_57;
        int val_58;
        int val_59;
        string val_60;
        int val_61;
        int val_62;
        var val_63;
        int val_64;
        val_34 = args;
        val_35 = target;
        System.Collections.Hashtable val_1 = iTween.CleanArgs(args:  val_34);
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[5];
        val_36 = "looktime";
        if(val_34 == null)
        {
            goto label_4;
        }
        
        if((val_34 & 1) == 0)
        {
            goto label_5;
        }
        
        label_8:
        val_37 = 1152921505060093952;
        val_39 = null;
        goto label_11;
        label_4:
        if((val_34 & 1) != 0)
        {
            goto label_8;
        }
        
        label_5:
        if((val_34 & 1) == 0)
        {
            goto label_9;
        }
        
        val_37 = 1152921505060093952;
        val_39 = null;
        val_40 = 0.15f;
        val_38 = null * val_40;
        label_11:
        val_41 = iTween.Defaults.updateTimePercentage;
        val_42 = val_38 * val_41;
        if(val_35 != null)
        {
            goto label_38;
        }
        
        label_39:
        label_38:
        UnityEngine.Vector3 val_4 = val_35.transform.eulerAngles;
        val_43 = val_4.y;
        val_2[0] = val_4;
        val_2[0] = val_43;
        val_2[0] = val_4.z;
        if((val_34 & 1) == 0)
        {
            goto label_16;
        }
        
        val_44 = 1152921504624791552;
        if((System.Type.op_Equality(left:  val_34.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_20;
        }
        
        UnityEngine.Transform val_8 = val_35.transform;
        val_45 = val_34;
        val_44 = 0;
        if(( & 1) == 0)
        {
            goto label_27;
        }
        
        if(val_45 != null)
        {
                val_45 = 0;
        }
        
        val_46 = val_10;
        val_47 = val_4.y;
        val_48 = val_4.z;
        val_44 = val_45;
        if(val_8 != null)
        {
            goto label_52;
        }
        
        goto label_32;
        label_16:
        UnityEngine.Debug.LogError(message:  "iTween Error: LookUpdate needs a \'looktarget\' property!");
        return;
        label_9:
        val_49 = null;
        val_49 = null;
        if(val_35 != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_20:
        if((System.Type.op_Equality(left:  val_34.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_43;
        }
        
        UnityEngine.Transform val_16 = val_35.transform;
        if(( & 1) == 0)
        {
            goto label_47;
        }
        
        val_53 = val_10;
        val_54 = val_4.y;
        val_55 = val_4.z;
        if(val_16 != null)
        {
            goto label_97;
        }
        
        goto label_49;
        label_27:
        val_56 = null;
        val_56 = null;
        val_46 = iTween.Defaults.up;
        if(val_8 != null)
        {
            goto label_52;
        }
        
        label_32:
        label_52:
        val_41 = val_46;
        val_40 = iTween.Defaults.time.__il2cppRuntimeField_4C;
        val_8.LookAt(target:  val_44, worldUp:  new UnityEngine.Vector3() {x = val_41, y = val_40, z = iTween.Defaults.time.__il2cppRuntimeField_50});
        label_43:
        if(val_35 != null)
        {
            goto label_98;
        }
        
        label_99:
        label_98:
        UnityEngine.Vector3 val_18 = val_35.transform.eulerAngles;
        val_2[1] = val_18;
        val_2[1] = val_18.y;
        val_2[1] = val_18.z;
        val_35.transform.eulerAngles = new UnityEngine.Vector3() {x = val_2[0], y = val_2[0], z = val_2[0]};
        val_57 = val_2.Length;
        if(val_57 == 0)
        {
                val_57 = val_2.Length;
        }
        
        if(val_57 <= 1)
        {
                val_57 = val_2.Length;
        }
        
        val_58 = val_2.Length;
        if(val_58 <= 3)
        {
                val_58 = val_2.Length;
        }
        
        val_2[3] = UnityEngine.Mathf.SmoothDampAngle(current:  val_2[0], target:  val_2[1], currentVelocity: ref  val_2[56], smoothTime:  val_42);
        if(val_58 == 0)
        {
                val_58 = val_2.Length;
        }
        
        if(val_58 <= 1)
        {
                val_58 = val_2.Length;
        }
        
        val_59 = val_2.Length;
        if(val_59 <= 3)
        {
                val_59 = val_2.Length;
        }
        
        val_2[3] = UnityEngine.Mathf.SmoothDampAngle(current:  val_2[0], target:  val_2[1], currentVelocity: ref  val_2[56][4], smoothTime:  val_42);
        if(val_59 == 0)
        {
                val_59 = val_2.Length;
        }
        
        if(val_59 <= 1)
        {
                val_59 = val_2.Length;
        }
        
        val_2[3] = UnityEngine.Mathf.SmoothDampAngle(current:  val_2[0], target:  val_2[1], currentVelocity: ref  val_2[56][8], smoothTime:  val_42);
        val_42 = val_2[3];
        val_43 = val_2[3];
        val_35.transform.eulerAngles = new UnityEngine.Vector3() {x = val_42, y = val_2[3], z = val_43};
        val_36 = "axis";
        if((val_34 & 1) == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_28 = val_35.transform.eulerAngles;
        val_2[4] = val_28;
        val_2[4] = val_28.y;
        val_2[4] = val_28.z;
        val_60 = val_34;
        if(val_60 != null)
        {
                val_60 = 0;
        }
        
        if((System.String.op_Equality(a:  val_60, b:  "x")) == false)
        {
            goto label_82;
        }
        
        val_61 = val_2.Length;
        if(val_61 == 0)
        {
                val_61 = val_2.Length;
        }
        
        if(val_61 <= 4)
        {
                val_61 = val_2.Length;
        }
        
        val_2[4] = val_2[0];
        if(val_61 != 0)
        {
            goto label_93;
        }
        
        label_94:
        val_61 = val_2.Length;
        label_93:
        val_34 = val_2[0];
        val_2[4] = val_34;
        label_100:
        if(val_35 != null)
        {
            goto label_105;
        }
        
        label_106:
        label_105:
        val_35 = val_35.transform;
        val_42 = val_2[4];
        val_43 = val_2[4];
        val_35.eulerAngles = new UnityEngine.Vector3() {x = val_42, y = val_2[4], z = val_43};
        return;
        label_82:
        if((System.String.op_Equality(a:  val_60, b:  "y")) == false)
        {
            goto label_90;
        }
        
        val_62 = val_2.Length;
        if(val_62 == 0)
        {
                val_62 = val_2.Length;
        }
        
        if(val_62 <= 4)
        {
                val_62 = val_2.Length;
        }
        
        val_2[4] = val_2[0];
        if(val_62 != 0)
        {
            goto label_93;
        }
        
        goto label_94;
        label_47:
        val_63 = null;
        val_63 = null;
        val_53 = iTween.Defaults.up;
        if(val_16 != null)
        {
            goto label_97;
        }
        
        label_49:
        label_97:
        val_16.LookAt(worldPosition:  new UnityEngine.Vector3() {x = 4.769568E-36f, y = val_43, z = val_4.z}, worldUp:  new UnityEngine.Vector3() {x = val_53, y = iTween.Defaults.time.__il2cppRuntimeField_4C, z = iTween.Defaults.time.__il2cppRuntimeField_50});
        if(val_35 != null)
        {
            goto label_98;
        }
        
        goto label_99;
        label_90:
        if((System.String.op_Equality(a:  val_60, b:  "z")) == false)
        {
            goto label_100;
        }
        
        val_64 = val_2.Length;
        if(val_64 == 0)
        {
                val_64 = val_2.Length;
        }
        
        if(val_64 <= 4)
        {
                val_64 = val_2.Length;
        }
        
        val_2[4] = val_2[0];
        if(val_64 == 0)
        {
                val_64 = val_2.Length;
        }
        
        val_2[4] = val_2[0];
        if(val_35 != null)
        {
            goto label_105;
        }
        
        goto label_106;
    }
    public static void LookUpdate(UnityEngine.GameObject target, UnityEngine.Vector3 looktarget, float time)
    {
        object[] val_1 = new object[4];
        val_1[0] = "looktarget";
        val_1[1] = looktarget;
        val_1[2] = "time";
        val_1[3] = time;
        iTween.LookUpdate(target:  target, args:  iTween.Hash(args:  val_1));
    }
    public static float PathLength(UnityEngine.Transform[] path)
    {
        var val_9;
        float val_11;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[0];
        if(path.Length >= 1)
        {
                do
        {
            UnityEngine.Vector3 val_2 = path[0].position;
            var val_3 = val_1 + (0 * 12);
            mem2[0] = val_2.x;
            mem2[0] = val_2.y;
            mem2[0] = val_2.z;
        }
        while((0 + 1) < path.Length);
        
        }
        
        UnityEngine.Vector3[] val_5 = iTween.PathControlPointGenerator(path:  val_1);
        val_9 = 0f;
        UnityEngine.Vector3 val_6 = iTween.Interp(pts:  val_5, t:  0f);
        int val_13 = path.Length;
        val_11 = val_6.y;
        val_13 = val_13 + (val_13 << 2);
        int val_7 = val_13 << 2;
        if(val_7 < 1)
        {
                return (float)val_9;
        }
        
        var val_14 = 0;
        do
        {
            UnityEngine.Vector3 val_10 = iTween.Interp(pts:  val_5, t:  ((float)val_14 + 1) / (float)val_7);
            val_11 = val_10.y;
            val_14 = val_14 + 1;
            val_9 = 0f + (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_11, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_11, z = val_10.z}));
        }
        while(val_14 < val_7);
        
        return (float)val_9;
    }
    public static float PathLength(UnityEngine.Vector3[] path)
    {
        var val_7;
        float val_9;
        UnityEngine.Vector3[] val_1 = iTween.PathControlPointGenerator(path:  path);
        val_7 = 0f;
        UnityEngine.Vector3 val_2 = iTween.Interp(pts:  val_1, t:  0f);
        val_9 = val_2.y;
        int val_8 = path.Length;
        val_8 = val_8 + (val_8 << 2);
        int val_3 = val_8 << 2;
        if(val_3 < 1)
        {
                return (float)val_7;
        }
        
        var val_9 = 0;
        do
        {
            UnityEngine.Vector3 val_6 = iTween.Interp(pts:  val_1, t:  ((float)val_9 + 1) / (float)val_3);
            val_9 = val_6.y;
            val_9 = val_9 + 1;
            val_7 = 0f + (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_9, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_9, z = val_6.z}));
        }
        while(val_9 < val_3);
        
        return (float)val_7;
    }
    public static UnityEngine.Texture2D CameraTexture(UnityEngine.Color color)
    {
        var val_8;
        UnityEngine.Texture2D val_3 = new UnityEngine.Texture2D(width:  UnityEngine.Screen.width, height:  UnityEngine.Screen.height, textureFormat:  5, mipChain:  false);
        int val_6 = UnityEngine.Screen.height * UnityEngine.Screen.width;
        UnityEngine.Color[] val_7 = new UnityEngine.Color[0];
        val_8 = 0;
        goto label_1;
        label_4:
        val_8 = 1;
        val_7[0] = color;
        val_7[0] = color.g;
        val_7[0] = color.b;
        val_7[0] = color.a;
        label_1:
        if(val_8 < val_7.Length)
        {
            goto label_4;
        }
        
        if(val_3 != null)
        {
                val_3.SetPixels(colors:  val_7);
        }
        else
        {
                val_3.SetPixels(colors:  val_7);
        }
        
        val_3.Apply();
        return val_3;
    }
    public static void PutOnPath(UnityEngine.GameObject target, UnityEngine.Vector3[] path, float percent)
    {
        UnityEngine.Vector3 val_3 = iTween.Interp(pts:  iTween.PathControlPointGenerator(path:  path), t:  percent);
        target.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public static void PutOnPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, float percent)
    {
        UnityEngine.Vector3 val_2 = iTween.Interp(pts:  iTween.PathControlPointGenerator(path:  path), t:  percent);
        target.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    public static void PutOnPath(UnityEngine.GameObject target, UnityEngine.Transform[] path, float percent)
    {
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[0];
        if(path.Length >= 1)
        {
                do
        {
            UnityEngine.Vector3 val_2 = path[0].position;
            var val_3 = val_1 + (0 * 12);
            mem2[0] = val_2.x;
            mem2[0] = val_2.y;
            mem2[0] = val_2.z;
        }
        while((0 + 1) < path.Length);
        
        }
        
        UnityEngine.Vector3 val_7 = iTween.Interp(pts:  iTween.PathControlPointGenerator(path:  val_1), t:  percent);
        target.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    public static void PutOnPath(UnityEngine.Transform target, UnityEngine.Transform[] path, float percent)
    {
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[0];
        if(path.Length >= 1)
        {
                do
        {
            UnityEngine.Vector3 val_2 = path[0].position;
            var val_3 = val_1 + (0 * 12);
            mem2[0] = val_2.x;
            mem2[0] = val_2.y;
            mem2[0] = val_2.z;
        }
        while((0 + 1) < path.Length);
        
        }
        
        UnityEngine.Vector3 val_6 = iTween.Interp(pts:  iTween.PathControlPointGenerator(path:  val_1), t:  percent);
        target.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
    }
    public static UnityEngine.Vector3 PointOnPath(UnityEngine.Transform[] path, float percent)
    {
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[0];
        if(path.Length < 1)
        {
                return iTween.Interp(pts:  iTween.PathControlPointGenerator(path:  val_1), t:  percent);
        }
        
        do
        {
            UnityEngine.Vector3 val_2 = path[0].position;
            var val_3 = val_1 + (0 * 12);
            mem2[0] = val_2.x;
            mem2[0] = val_2.y;
            mem2[0] = val_2.z;
        }
        while((0 + 1) < path.Length);
        
        return iTween.Interp(pts:  iTween.PathControlPointGenerator(path:  val_1), t:  percent);
    }
    public static void DrawLine(UnityEngine.Vector3[] line)
    {
        var val_1;
        if(line.Length == 0)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        iTween.DrawLineHelper(line:  line, color:  new UnityEngine.Color() {r = iTween.Defaults.color, g = iTween.Defaults.time.__il2cppRuntimeField_28, b = iTween.Defaults.time.__il2cppRuntimeField_2C, a = iTween.Defaults.time.__il2cppRuntimeField_30}, method:  "gizmos");
    }
    public static void DrawLine(UnityEngine.Vector3[] line, UnityEngine.Color color)
    {
        if(line.Length == 0)
        {
                return;
        }
        
        iTween.DrawLineHelper(line:  line, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  "gizmos");
    }
    public static void DrawLine(UnityEngine.Transform[] line)
    {
        var val_4;
        if(line.Length == 0)
        {
                return;
        }
        
        int val_1 = line.Length & 4294967295;
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
        if(line.Length >= 1)
        {
                do
        {
            UnityEngine.Vector3 val_3 = line[0].position;
            var val_4 = val_2 + (0 * 12);
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
        }
        while((0 + 1) < line.Length);
        
        }
        
        val_4 = null;
        val_4 = null;
        iTween.DrawLineHelper(line:  val_2, color:  new UnityEngine.Color() {r = iTween.Defaults.color, g = iTween.Defaults.time.__il2cppRuntimeField_28, b = iTween.Defaults.time.__il2cppRuntimeField_2C, a = iTween.Defaults.time.__il2cppRuntimeField_30}, method:  "gizmos");
    }
    public static void DrawLine(UnityEngine.Transform[] line, UnityEngine.Color color)
    {
        if(line.Length == 0)
        {
                return;
        }
        
        int val_1 = line.Length & 4294967295;
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
        if(line.Length >= 1)
        {
                do
        {
            UnityEngine.Vector3 val_3 = line[0].position;
            var val_4 = val_2 + (0 * 12);
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
        }
        while((0 + 1) < line.Length);
        
        }
        
        iTween.DrawLineHelper(line:  val_2, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  "gizmos");
    }
    public static void DrawLineGizmos(UnityEngine.Vector3[] line)
    {
        var val_1;
        if(line.Length == 0)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        iTween.DrawLineHelper(line:  line, color:  new UnityEngine.Color() {r = iTween.Defaults.color, g = iTween.Defaults.time.__il2cppRuntimeField_28, b = iTween.Defaults.time.__il2cppRuntimeField_2C, a = iTween.Defaults.time.__il2cppRuntimeField_30}, method:  "gizmos");
    }
    public static void DrawLineGizmos(UnityEngine.Vector3[] line, UnityEngine.Color color)
    {
        if(line.Length == 0)
        {
                return;
        }
        
        iTween.DrawLineHelper(line:  line, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  "gizmos");
    }
    public static void DrawLineGizmos(UnityEngine.Transform[] line)
    {
        var val_4;
        if(line.Length == 0)
        {
                return;
        }
        
        int val_1 = line.Length & 4294967295;
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
        if(line.Length >= 1)
        {
                do
        {
            UnityEngine.Vector3 val_3 = line[0].position;
            var val_4 = val_2 + (0 * 12);
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
        }
        while((0 + 1) < line.Length);
        
        }
        
        val_4 = null;
        val_4 = null;
        iTween.DrawLineHelper(line:  val_2, color:  new UnityEngine.Color() {r = iTween.Defaults.color, g = iTween.Defaults.time.__il2cppRuntimeField_28, b = iTween.Defaults.time.__il2cppRuntimeField_2C, a = iTween.Defaults.time.__il2cppRuntimeField_30}, method:  "gizmos");
    }
    public static void DrawLineGizmos(UnityEngine.Transform[] line, UnityEngine.Color color)
    {
        if(line.Length == 0)
        {
                return;
        }
        
        int val_1 = line.Length & 4294967295;
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
        if(line.Length >= 1)
        {
                do
        {
            UnityEngine.Vector3 val_3 = line[0].position;
            var val_4 = val_2 + (0 * 12);
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
        }
        while((0 + 1) < line.Length);
        
        }
        
        iTween.DrawLineHelper(line:  val_2, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  "gizmos");
    }
    public static void DrawLineHandles(UnityEngine.Vector3[] line)
    {
        var val_1;
        if(line.Length == 0)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        iTween.DrawLineHelper(line:  line, color:  new UnityEngine.Color() {r = iTween.Defaults.color, g = iTween.Defaults.time.__il2cppRuntimeField_28, b = iTween.Defaults.time.__il2cppRuntimeField_2C, a = iTween.Defaults.time.__il2cppRuntimeField_30}, method:  "handles");
    }
    public static void DrawLineHandles(UnityEngine.Vector3[] line, UnityEngine.Color color)
    {
        if(line.Length == 0)
        {
                return;
        }
        
        iTween.DrawLineHelper(line:  line, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  "handles");
    }
    public static void DrawLineHandles(UnityEngine.Transform[] line)
    {
        var val_4;
        if(line.Length == 0)
        {
                return;
        }
        
        int val_1 = line.Length & 4294967295;
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
        if(line.Length >= 1)
        {
                do
        {
            UnityEngine.Vector3 val_3 = line[0].position;
            var val_4 = val_2 + (0 * 12);
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
        }
        while((0 + 1) < line.Length);
        
        }
        
        val_4 = null;
        val_4 = null;
        iTween.DrawLineHelper(line:  val_2, color:  new UnityEngine.Color() {r = iTween.Defaults.color, g = iTween.Defaults.time.__il2cppRuntimeField_28, b = iTween.Defaults.time.__il2cppRuntimeField_2C, a = iTween.Defaults.time.__il2cppRuntimeField_30}, method:  "handles");
    }
    public static void DrawLineHandles(UnityEngine.Transform[] line, UnityEngine.Color color)
    {
        if(line.Length == 0)
        {
                return;
        }
        
        int val_1 = line.Length & 4294967295;
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
        if(line.Length >= 1)
        {
                do
        {
            UnityEngine.Vector3 val_3 = line[0].position;
            var val_4 = val_2 + (0 * 12);
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
        }
        while((0 + 1) < line.Length);
        
        }
        
        iTween.DrawLineHelper(line:  val_2, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  "handles");
    }
    public static UnityEngine.Vector3 PointOnPath(UnityEngine.Vector3[] path, float percent)
    {
        return iTween.Interp(pts:  iTween.PathControlPointGenerator(path:  path), t:  percent);
    }
    public static void DrawPath(UnityEngine.Vector3[] path)
    {
        var val_1;
        if(path.Length == 0)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        iTween.DrawPathHelper(path:  path, color:  new UnityEngine.Color() {r = iTween.Defaults.color, g = iTween.Defaults.time.__il2cppRuntimeField_28, b = iTween.Defaults.time.__il2cppRuntimeField_2C, a = iTween.Defaults.time.__il2cppRuntimeField_30}, method:  "gizmos");
    }
    public static void DrawPath(UnityEngine.Vector3[] path, UnityEngine.Color color)
    {
        if(path.Length == 0)
        {
                return;
        }
        
        iTween.DrawPathHelper(path:  path, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  "gizmos");
    }
    public static void DrawPath(UnityEngine.Transform[] path)
    {
        var val_4;
        if(path.Length == 0)
        {
                return;
        }
        
        int val_1 = path.Length & 4294967295;
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
        if(path.Length >= 1)
        {
                do
        {
            UnityEngine.Vector3 val_3 = path[0].position;
            var val_4 = val_2 + (0 * 12);
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
        }
        while((0 + 1) < path.Length);
        
        }
        
        val_4 = null;
        val_4 = null;
        iTween.DrawPathHelper(path:  val_2, color:  new UnityEngine.Color() {r = iTween.Defaults.color, g = iTween.Defaults.time.__il2cppRuntimeField_28, b = iTween.Defaults.time.__il2cppRuntimeField_2C, a = iTween.Defaults.time.__il2cppRuntimeField_30}, method:  "gizmos");
    }
    public static void DrawPath(UnityEngine.Transform[] path, UnityEngine.Color color)
    {
        if(path.Length == 0)
        {
                return;
        }
        
        int val_1 = path.Length & 4294967295;
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
        if(path.Length >= 1)
        {
                do
        {
            UnityEngine.Vector3 val_3 = path[0].position;
            var val_4 = val_2 + (0 * 12);
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
        }
        while((0 + 1) < path.Length);
        
        }
        
        iTween.DrawPathHelper(path:  val_2, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  "gizmos");
    }
    public static void DrawPathGizmos(UnityEngine.Vector3[] path)
    {
        var val_1;
        if(path.Length == 0)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        iTween.DrawPathHelper(path:  path, color:  new UnityEngine.Color() {r = iTween.Defaults.color, g = iTween.Defaults.time.__il2cppRuntimeField_28, b = iTween.Defaults.time.__il2cppRuntimeField_2C, a = iTween.Defaults.time.__il2cppRuntimeField_30}, method:  "gizmos");
    }
    public static void DrawPathGizmos(UnityEngine.Vector3[] path, UnityEngine.Color color)
    {
        if(path.Length == 0)
        {
                return;
        }
        
        iTween.DrawPathHelper(path:  path, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  "gizmos");
    }
    public static void DrawPathGizmos(UnityEngine.Transform[] path)
    {
        var val_4;
        if(path.Length == 0)
        {
                return;
        }
        
        int val_1 = path.Length & 4294967295;
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
        if(path.Length >= 1)
        {
                do
        {
            UnityEngine.Vector3 val_3 = path[0].position;
            var val_4 = val_2 + (0 * 12);
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
        }
        while((0 + 1) < path.Length);
        
        }
        
        val_4 = null;
        val_4 = null;
        iTween.DrawPathHelper(path:  val_2, color:  new UnityEngine.Color() {r = iTween.Defaults.color, g = iTween.Defaults.time.__il2cppRuntimeField_28, b = iTween.Defaults.time.__il2cppRuntimeField_2C, a = iTween.Defaults.time.__il2cppRuntimeField_30}, method:  "gizmos");
    }
    public static void DrawPathGizmos(UnityEngine.Transform[] path, UnityEngine.Color color)
    {
        if(path.Length == 0)
        {
                return;
        }
        
        int val_1 = path.Length & 4294967295;
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
        if(path.Length >= 1)
        {
                do
        {
            UnityEngine.Vector3 val_3 = path[0].position;
            var val_4 = val_2 + (0 * 12);
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
        }
        while((0 + 1) < path.Length);
        
        }
        
        iTween.DrawPathHelper(path:  val_2, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  "gizmos");
    }
    public static void DrawPathHandles(UnityEngine.Vector3[] path)
    {
        var val_1;
        if(path.Length == 0)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        iTween.DrawPathHelper(path:  path, color:  new UnityEngine.Color() {r = iTween.Defaults.color, g = iTween.Defaults.time.__il2cppRuntimeField_28, b = iTween.Defaults.time.__il2cppRuntimeField_2C, a = iTween.Defaults.time.__il2cppRuntimeField_30}, method:  "handles");
    }
    public static void DrawPathHandles(UnityEngine.Vector3[] path, UnityEngine.Color color)
    {
        if(path.Length == 0)
        {
                return;
        }
        
        iTween.DrawPathHelper(path:  path, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  "handles");
    }
    public static void DrawPathHandles(UnityEngine.Transform[] path)
    {
        var val_4;
        if(path.Length == 0)
        {
                return;
        }
        
        int val_1 = path.Length & 4294967295;
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
        if(path.Length >= 1)
        {
                do
        {
            UnityEngine.Vector3 val_3 = path[0].position;
            var val_4 = val_2 + (0 * 12);
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
        }
        while((0 + 1) < path.Length);
        
        }
        
        val_4 = null;
        val_4 = null;
        iTween.DrawPathHelper(path:  val_2, color:  new UnityEngine.Color() {r = iTween.Defaults.color, g = iTween.Defaults.time.__il2cppRuntimeField_28, b = iTween.Defaults.time.__il2cppRuntimeField_2C, a = iTween.Defaults.time.__il2cppRuntimeField_30}, method:  "handles");
    }
    public static void DrawPathHandles(UnityEngine.Transform[] path, UnityEngine.Color color)
    {
        if(path.Length == 0)
        {
                return;
        }
        
        int val_1 = path.Length & 4294967295;
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
        if(path.Length >= 1)
        {
                do
        {
            UnityEngine.Vector3 val_3 = path[0].position;
            var val_4 = val_2 + (0 * 12);
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
        }
        while((0 + 1) < path.Length);
        
        }
        
        iTween.DrawPathHelper(path:  val_2, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  "handles");
    }
    public static void CameraFadeDepth(int depth)
    {
        UnityEngine.Debug.LogWarning(message:  "This feature is no longer supported");
    }
    public static void CameraFadeDestroy()
    {
        UnityEngine.Debug.LogWarning(message:  "This feature is no longer supported");
    }
    public static void CameraFadeSwap(UnityEngine.Texture2D texture)
    {
        UnityEngine.Debug.LogWarning(message:  "This feature is no longer supported");
    }
    public static UnityEngine.GameObject CameraFadeAdd(UnityEngine.Texture2D texture, int depth)
    {
        UnityEngine.Debug.LogWarning(message:  "This feature is no longer supported");
        return 0;
    }
    public static UnityEngine.GameObject CameraFadeAdd(UnityEngine.Texture2D texture)
    {
        UnityEngine.Debug.LogWarning(message:  "This feature is no longer supported");
        return 0;
    }
    public static UnityEngine.GameObject CameraFadeAdd()
    {
        UnityEngine.Debug.LogWarning(message:  "This feature is no longer supported");
        return 0;
    }
    public static void Resume(UnityEngine.GameObject target)
    {
        var val_5;
        T val_6;
        val_5 = 0;
        goto label_2;
        label_11:
        val_6 = target.GetComponents<iTween>()[0];
        if(val_6 != 0)
        {
                val_6 = 0;
        }
        
        val_6.enabled = true;
        val_5 = 1;
        label_2:
        if(val_5 < val_1.Length)
        {
            goto label_11;
        }
    
    }
    public static void Resume(UnityEngine.GameObject target, bool includechildren)
    {
        UnityEngine.GameObject val_11;
        var val_12;
        var val_15;
        var val_16;
        val_11 = target;
        val_12 = 1152921505059774464;
        iTween.Resume(target:  val_11);
        if(includechildren == false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_2 = val_11.transform.GetEnumerator();
        label_26:
        var val_13 = 0;
        val_13 = val_13 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_15 = val_2.Current;
        if(val_15 != null)
        {
                val_15 = 0;
        }
        
        UnityEngine.GameObject val_11 = val_15.gameObject;
        goto label_26;
        label_11:
        val_16 = 0;
        val_12 = 1152921504621170688;
        val_11 = val_2;
        if(val_11 != null)
        {
                var val_15 = 0;
            val_15 = val_15 + 1;
            val_11.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public static void Resume(UnityEngine.GameObject target, string type)
    {
        T val_10;
        var val_11;
        var val_12;
        val_11 = 0;
        goto label_2;
        label_13:
        if(val_11 >= 1152921525891062640)
        {
                val_12 = 0;
        }
        
        val_10 = target.GetComponents<iTween>()[0];
        if(val_10 == 0)
        {
            goto label_14;
        }
        
        if((System.String.op_Equality(a:  val_1[0x0][0] + 32(val_1[0x0][0] + 32) + val_1[0x0][0] + 32 + 8(val_1[0x0][0] + 32 + 8).Substring(startIndex:  0, length:  type.Length).ToLower(), b:  type.ToLower())) != false)
        {
                val_10.enabled = true;
        }
        
        val_11 = 1;
        label_2:
        if(val_11 < val_1.Length)
        {
            goto label_13;
        }
        
        return;
        label_14:
    }
    public static void Resume(UnityEngine.GameObject target, string type, bool includechildren)
    {
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        T val_23;
        var val_26;
        var val_27;
        val_19 = includechildren;
        val_20 = type;
        val_21 = 0;
        goto label_2;
        label_13:
        if(val_21 >= 1152921525891062640)
        {
                val_22 = 0;
        }
        
        val_23 = target.GetComponents<iTween>()[0];
        if(val_23 == 0)
        {
            goto label_39;
        }
        
        if((System.String.op_Equality(a:  val_1[0x0][0] + 32(val_1[0x0][0] + 32) + val_1[0x0][0] + 32 + 8(val_1[0x0][0] + 32 + 8).Substring(startIndex:  0, length:  val_20.Length).ToLower(), b:  val_20.ToLower())) != false)
        {
                val_23.enabled = true;
        }
        
        val_21 = 1;
        label_2:
        if(val_21 < val_1.Length)
        {
            goto label_13;
        }
        
        if(val_19 == false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_10 = target.transform.GetEnumerator();
        val_23 = 1152921504865153024;
        label_37:
        var val_21 = 0;
        val_21 = val_21 + 1;
        if(val_10.MoveNext() == false)
        {
            goto label_22;
        }
        
        var val_22 = 0;
        val_22 = val_22 + 1;
        val_26 = val_10.Current;
        if(val_26 != null)
        {
                val_26 = 0;
        }
        
        UnityEngine.GameObject val_19 = val_26.gameObject;
        goto label_37;
        label_22:
        val_20 = 0;
        goto label_38;
        label_39:
        val_27 = 0;
        goto label_48;
        label_38:
        val_19 = 1152921504621170688;
        if(target != null)
        {
                var val_23 = 0;
            val_23 = val_23 + 1;
            target.Dispose();
        }
        
        if( == false)
        {
                return;
        }
        
        return;
        label_48:
    }
    public static void Resume()
    {
        var val_4;
        var val_5;
        UnityEngine.GameObject val_6;
        var val_7;
        val_4 = 0;
        goto label_1;
        label_11:
        val_5 = null;
        val_5 = null;
        val_6 = iTween.tweens.Item[0];
        if((val_6 != null) && (null != null))
        {
                val_6 = 0;
        }
        
        iTween.Resume(target:  val_6);
        val_4 = 1;
        label_1:
        val_7 = null;
        val_7 = null;
        if(val_4 < iTween.tweens.Count)
        {
            goto label_11;
        }
    
    }
    public static void Resume(string type)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        UnityEngine.GameObject val_10;
        System.Collections.ArrayList val_1 = new System.Collections.ArrayList();
        val_5 = 0;
        goto label_1;
        label_13:
        val_6 = null;
        val_6 = null;
        val_7 = iTween.tweens.Item[0];
        if((val_7 != null) && (null != null))
        {
                val_7 = 0;
        }
        
        val_5 = 1;
        label_1:
        val_8 = null;
        val_8 = null;
        if(val_5 < iTween.tweens.Count)
        {
            goto label_13;
        }
        
        val_9 = 0;
        goto label_19;
        label_23:
        val_10 = val_1;
        if(val_10 != null)
        {
                if(null != null)
        {
                val_10 = 0;
        }
        
        }
        
        iTween.Resume(target:  val_10, type:  type);
        val_9 = 1;
        label_19:
        if(val_9 < val_1)
        {
            goto label_23;
        }
    
    }
    public static void Pause(UnityEngine.GameObject target)
    {
        var val_5;
        T val_6;
        val_5 = 0;
        goto label_2;
        label_9:
        val_6 = target.GetComponents<iTween>()[0];
        val_6 = 0;
        if((5.877482E-39f) > 0f)
        {
                float val_4 = UnityEngine.Time.time;
            val_4 = val_4 - 0f;
            val_4 = (5.877482E-39f) - val_4;
            mem[56] = val_4;
            val_6.StopCoroutine(methodName:  "TweenDelay");
        }
        
        mem[65] = 1;
        val_6.enabled = false;
        val_5 = 1;
        label_2:
        if(val_5 < val_1.Length)
        {
            goto label_9;
        }
    
    }
    public static void Pause(UnityEngine.GameObject target, bool includechildren)
    {
        UnityEngine.GameObject val_11;
        var val_12;
        var val_15;
        var val_16;
        val_11 = target;
        val_12 = 1152921505059774464;
        iTween.Pause(target:  val_11);
        if(includechildren == false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_2 = val_11.transform.GetEnumerator();
        label_26:
        var val_13 = 0;
        val_13 = val_13 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_15 = val_2.Current;
        if(val_15 != null)
        {
                val_15 = 0;
        }
        
        UnityEngine.GameObject val_11 = val_15.gameObject;
        goto label_26;
        label_11:
        val_16 = 0;
        val_12 = 1152921504621170688;
        val_11 = val_2;
        if(val_11 != null)
        {
                var val_15 = 0;
            val_15 = val_15 + 1;
            val_11.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public static void Pause(UnityEngine.GameObject target, string type)
    {
        var val_11;
        var val_12 = 0;
        goto label_13;
        label_16:
        T val_11 = target.GetComponents<iTween>()[0];
        val_11 = 0;
        if((System.String.op_Equality(a:  64 + 53212264.Substring(startIndex:  0, length:  type.Length).ToLower(), b:  type.ToLower())) != false)
        {
                if((5.877482E-39f) > 0f)
        {
                float val_10 = UnityEngine.Time.time;
            val_10 = val_10 - 0f;
            val_10 = (5.877482E-39f) - val_10;
            mem[56] = val_10;
            val_11.StopCoroutine(methodName:  "TweenDelay");
        }
        
            mem[65] = 1;
            val_11.enabled = false;
        }
        
        val_12 = 1;
        label_13:
        if(val_12 < val_1.Length)
        {
            goto label_16;
        }
    
    }
    public static void Pause(UnityEngine.GameObject target, string type, bool includechildren)
    {
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_26;
        val_20 = type;
        val_21 = "TweenDelay";
        val_22 = 0;
        goto label_13;
        label_16:
        T val_22 = target.GetComponents<iTween>()[0];
        val_23 = 0;
        if((System.String.op_Equality(a:  64 + 53212264.Substring(startIndex:  0, length:  val_20.Length).ToLower(), b:  val_20.ToLower())) != false)
        {
                if((5.877482E-39f) > 0f)
        {
                float val_10 = UnityEngine.Time.time;
            val_10 = val_10 - 0f;
            val_10 = (5.877482E-39f) - val_10;
            mem[56] = val_10;
            val_23.StopCoroutine(methodName:  "TweenDelay");
        }
        
            mem[65] = 1;
            val_23.enabled = false;
        }
        
        val_22 = 1;
        label_13:
        if(val_22 < val_1.Length)
        {
            goto label_16;
        }
        
        if(includechildren == false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_12 = target.transform.GetEnumerator();
        val_23 = 1152921504865153024;
        label_40:
        var val_23 = 0;
        val_23 = val_23 + 1;
        if(val_12.MoveNext() == false)
        {
            goto label_25;
        }
        
        var val_24 = 0;
        val_24 = val_24 + 1;
        val_26 = val_12.Current;
        if(val_26 != null)
        {
                val_26 = 0;
        }
        
        UnityEngine.GameObject val_20 = val_26.gameObject;
        goto label_40;
        label_25:
        val_20 = 0;
        val_21 = 1152921504621170688;
        if(val_12 != null)
        {
                var val_25 = 0;
            val_25 = val_25 + 1;
            val_12.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public static void Pause()
    {
        var val_4;
        var val_5;
        UnityEngine.GameObject val_6;
        var val_7;
        val_4 = 0;
        goto label_1;
        label_11:
        val_5 = null;
        val_5 = null;
        val_6 = iTween.tweens.Item[0];
        if((val_6 != null) && (null != null))
        {
                val_6 = 0;
        }
        
        iTween.Pause(target:  val_6);
        val_4 = 1;
        label_1:
        val_7 = null;
        val_7 = null;
        if(val_4 < iTween.tweens.Count)
        {
            goto label_11;
        }
    
    }
    public static void Pause(string type)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        UnityEngine.GameObject val_10;
        System.Collections.ArrayList val_1 = new System.Collections.ArrayList();
        val_5 = 0;
        goto label_1;
        label_13:
        val_6 = null;
        val_6 = null;
        val_7 = iTween.tweens.Item[0];
        if((val_7 != null) && (null != null))
        {
                val_7 = 0;
        }
        
        val_5 = 1;
        label_1:
        val_8 = null;
        val_8 = null;
        if(val_5 < iTween.tweens.Count)
        {
            goto label_13;
        }
        
        val_9 = 0;
        goto label_19;
        label_23:
        val_10 = val_1;
        if(val_10 != null)
        {
                if(null != null)
        {
                val_10 = 0;
        }
        
        }
        
        iTween.Pause(target:  val_10, type:  type);
        val_9 = 1;
        label_19:
        if(val_9 < val_1)
        {
            goto label_23;
        }
    
    }
    public static int Count()
    {
        null = null;
        if(iTween.tweens != null)
        {
                return iTween.tweens.Count;
        }
        
        return iTween.tweens.Count;
    }
    public static int Count(string type)
    {
        var val_11;
        var val_12;
        var val_13;
        string val_14;
        var val_15;
        string val_16;
        var val_17;
        val_11 = 0;
        val_12 = 0;
        goto label_1;
        label_18:
        val_13 = null;
        val_13 = null;
        System.Collections.Hashtable val_1 = iTween.tweens.Item[0];
        val_14 = val_1;
        val_15 = static_value_032D1378;
        val_16 = val_1;
        if((val_14 != null) && (null != val_15))
        {
                val_15 = static_value_032D1378;
            val_14 = 0;
        }
        
        if((val_16 != null) && (null != val_15))
        {
                val_16 = 0;
        }
        
        val_12 = val_12 + (System.String.op_Equality(a:  val_14 + val_16.Substring(startIndex:  0, length:  type.Length).ToLower(), b:  type.ToLower()));
        val_11 = 1;
        label_1:
        val_17 = null;
        val_17 = null;
        if(val_11 < iTween.tweens.Count)
        {
            goto label_18;
        }
        
        return (int)val_12;
    }
    public static int Count(UnityEngine.GameObject target)
    {
        if((target.GetComponents<iTween>()) != null)
        {
                return (int)val_1.Length;
        }
        
        return (int)val_1.Length;
    }
    public static int Count(UnityEngine.GameObject target, string type)
    {
        var val_11;
        var val_12;
        var val_13;
        val_11 = 0;
        val_12 = 0;
        goto label_2;
        label_12:
        if(val_11 >= 1152921525891062640)
        {
                val_13 = 0;
        }
        
        if((target.GetComponents<iTween>()[0]) == 0)
        {
            goto label_13;
        }
        
        val_12 = val_12 + (System.String.op_Equality(a:  val_1[0x0][0] + 32(val_1[0x0][0] + 32) + val_1[0x0][0] + 32 + 8(val_1[0x0][0] + 32 + 8).Substring(startIndex:  0, length:  type.Length).ToLower(), b:  type.ToLower()));
        val_11 = 1;
        label_2:
        if(val_11 < val_1.Length)
        {
            goto label_12;
        }
        
        return (int)val_12;
        label_13:
    }
    public static void Stop()
    {
        var val_4;
        UnityEngine.GameObject val_5;
        var val_6;
        var val_7;
        val_4 = 0;
        goto label_1;
        label_11:
        val_5 = iTween.tweens.Item[0];
        if((val_5 != null) && (null != null))
        {
                val_5 = 0;
        }
        
        iTween.Stop(target:  val_5);
        val_4 = 1;
        label_1:
        val_6 = null;
        val_6 = null;
        val_7 = null;
        if(val_4 < iTween.tweens.Count)
        {
            goto label_11;
        }
        
        val_7 = null;
        iTween.tweens.Clear();
    }
    public static void Stop(string type)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        UnityEngine.GameObject val_10;
        System.Collections.ArrayList val_1 = new System.Collections.ArrayList();
        val_5 = 0;
        goto label_1;
        label_13:
        val_6 = null;
        val_6 = null;
        val_7 = iTween.tweens.Item[0];
        if((val_7 != null) && (null != null))
        {
                val_7 = 0;
        }
        
        val_5 = 1;
        label_1:
        val_8 = null;
        val_8 = null;
        if(val_5 < iTween.tweens.Count)
        {
            goto label_13;
        }
        
        val_9 = 0;
        goto label_19;
        label_23:
        val_10 = val_1;
        if(val_10 != null)
        {
                if(null != null)
        {
                val_10 = 0;
        }
        
        }
        
        iTween.Stop(target:  val_10, type:  type);
        val_9 = 1;
        label_19:
        if(val_9 < val_1)
        {
            goto label_23;
        }
    
    }
    public static void StopByName(string name)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        UnityEngine.GameObject val_10;
        System.Collections.ArrayList val_1 = new System.Collections.ArrayList();
        val_5 = 0;
        goto label_1;
        label_13:
        val_6 = null;
        val_6 = null;
        val_7 = iTween.tweens.Item[0];
        if((val_7 != null) && (null != null))
        {
                val_7 = 0;
        }
        
        val_5 = 1;
        label_1:
        val_8 = null;
        val_8 = null;
        if(val_5 < iTween.tweens.Count)
        {
            goto label_13;
        }
        
        val_9 = 0;
        goto label_19;
        label_23:
        val_10 = val_1;
        if(val_10 != null)
        {
                if(null != null)
        {
                val_10 = 0;
        }
        
        }
        
        iTween.StopByName(target:  val_10, name:  name);
        val_9 = 1;
        label_19:
        if(val_9 < val_1)
        {
            goto label_23;
        }
    
    }
    public static void Stop(UnityEngine.GameObject target)
    {
        var val_5;
        T val_6;
        val_5 = 0;
        goto label_2;
        label_11:
        val_6 = target.GetComponents<iTween>()[0];
        if(val_6 != 0)
        {
                val_6 = 0;
        }
        
        val_6.Dispose();
        val_5 = 1;
        label_2:
        if(val_5 < val_1.Length)
        {
            goto label_11;
        }
    
    }
    public static void Stop(UnityEngine.GameObject target, bool includechildren)
    {
        UnityEngine.GameObject val_11;
        var val_12;
        var val_15;
        var val_16;
        val_11 = target;
        val_12 = 1152921505059774464;
        iTween.Stop(target:  val_11);
        if(includechildren == false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_2 = val_11.transform.GetEnumerator();
        label_26:
        var val_13 = 0;
        val_13 = val_13 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_15 = val_2.Current;
        if(val_15 != null)
        {
                val_15 = 0;
        }
        
        UnityEngine.GameObject val_11 = val_15.gameObject;
        goto label_26;
        label_11:
        val_16 = 0;
        val_12 = 1152921504621170688;
        val_11 = val_2;
        if(val_11 != null)
        {
                var val_15 = 0;
            val_15 = val_15 + 1;
            val_11.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public static void Stop(UnityEngine.GameObject target, string type)
    {
        T val_10;
        var val_11;
        var val_12;
        val_11 = 0;
        goto label_2;
        label_13:
        if(val_11 >= 1152921525891062640)
        {
                val_12 = 0;
        }
        
        val_10 = target.GetComponents<iTween>()[0];
        if(val_10 == 0)
        {
            goto label_14;
        }
        
        if((System.String.op_Equality(a:  val_1[0x0][0] + 32(val_1[0x0][0] + 32) + val_1[0x0][0] + 32 + 8(val_1[0x0][0] + 32 + 8).Substring(startIndex:  0, length:  type.Length).ToLower(), b:  type.ToLower())) != false)
        {
                val_10.Dispose();
        }
        
        val_11 = 1;
        label_2:
        if(val_11 < val_1.Length)
        {
            goto label_13;
        }
        
        return;
        label_14:
    }
    public static void StopByName(UnityEngine.GameObject target, string name)
    {
        T val_5;
        var val_6;
        var val_7;
        val_6 = 0;
        goto label_2;
        label_9:
        if(val_6 >= 1152921525891062640)
        {
                val_7 = 0;
        }
        
        val_5 = target.GetComponents<iTween>()[0];
        if(val_5 == 0)
        {
            goto label_10;
        }
        
        if((System.String.op_Equality(a:  val_1[0x0][0] + 72, b:  name)) != false)
        {
                val_5.Dispose();
        }
        
        val_6 = 1;
        label_2:
        if(val_6 < val_1.Length)
        {
            goto label_9;
        }
        
        return;
        label_10:
    }
    public static void Stop(UnityEngine.GameObject target, string type, bool includechildren)
    {
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        T val_23;
        var val_26;
        var val_27;
        val_19 = includechildren;
        val_20 = type;
        val_21 = 0;
        goto label_2;
        label_13:
        if(val_21 >= 1152921525891062640)
        {
                val_22 = 0;
        }
        
        val_23 = target.GetComponents<iTween>()[0];
        if(val_23 == 0)
        {
            goto label_39;
        }
        
        if((System.String.op_Equality(a:  val_1[0x0][0] + 32(val_1[0x0][0] + 32) + val_1[0x0][0] + 32 + 8(val_1[0x0][0] + 32 + 8).Substring(startIndex:  0, length:  val_20.Length).ToLower(), b:  val_20.ToLower())) != false)
        {
                val_23.Dispose();
        }
        
        val_21 = 1;
        label_2:
        if(val_21 < val_1.Length)
        {
            goto label_13;
        }
        
        if(val_19 == false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_10 = target.transform.GetEnumerator();
        val_23 = 1152921504865153024;
        label_37:
        var val_21 = 0;
        val_21 = val_21 + 1;
        if(val_10.MoveNext() == false)
        {
            goto label_22;
        }
        
        var val_22 = 0;
        val_22 = val_22 + 1;
        val_26 = val_10.Current;
        if(val_26 != null)
        {
                val_26 = 0;
        }
        
        UnityEngine.GameObject val_19 = val_26.gameObject;
        goto label_37;
        label_22:
        val_20 = 0;
        goto label_38;
        label_39:
        val_27 = 0;
        goto label_48;
        label_38:
        val_19 = 1152921504621170688;
        if(target != null)
        {
                var val_23 = 0;
            val_23 = val_23 + 1;
            target.Dispose();
        }
        
        if( == false)
        {
                return;
        }
        
        return;
        label_48:
    }
    public static void StopByName(UnityEngine.GameObject target, string name, bool includechildren)
    {
        var val_14;
        string val_15;
        var val_16;
        var val_17;
        T val_18;
        var val_21;
        var val_22;
        val_14 = includechildren;
        val_15 = name;
        val_16 = 0;
        goto label_2;
        label_9:
        if(val_16 >= 1152921525891062640)
        {
                val_17 = 0;
        }
        
        val_18 = target.GetComponents<iTween>()[0];
        if(val_18 == 0)
        {
            goto label_35;
        }
        
        if((System.String.op_Equality(a:  val_1[0x0][0] + 72, b:  val_15)) != false)
        {
                val_18.Dispose();
        }
        
        val_16 = 1;
        label_2:
        if(val_16 < val_1.Length)
        {
            goto label_9;
        }
        
        if(val_14 == false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_5 = target.transform.GetEnumerator();
        val_18 = 1152921504865153024;
        label_33:
        var val_16 = 0;
        val_16 = val_16 + 1;
        if(val_5.MoveNext() == false)
        {
            goto label_18;
        }
        
        var val_17 = 0;
        val_17 = val_17 + 1;
        val_21 = val_5.Current;
        if(val_21 != null)
        {
                val_21 = 0;
        }
        
        UnityEngine.GameObject val_14 = val_21.gameObject;
        goto label_33;
        label_18:
        val_15 = 0;
        goto label_34;
        label_35:
        val_22 = 0;
        goto label_44;
        label_34:
        val_14 = 1152921504621170688;
        if(target != null)
        {
                var val_18 = 0;
            val_18 = val_18 + 1;
            target.Dispose();
        }
        
        if( == false)
        {
                return;
        }
        
        return;
        label_44:
    }
    public static System.Collections.Hashtable Hash(object[] args)
    {
        var val_6;
        int val_7;
        System.Collections.Hashtable val_3 = null;
        val_6 = val_3;
        val_3 = new System.Collections.Hashtable(capacity:  ((args.Length < 0) ? (args.Length + 1) : args.Length) >> 1);
        val_7 = args.Length;
        if((val_7 & 1) == 0)
        {
                if((val_7 - 1) < 1)
        {
                return (System.Collections.Hashtable)val_6;
        }
        
            do
        {
            if(0 >= val_7)
        {
                val_7 = args.Length;
        }
        
            object val_8 = args[0];
            object val_9 = args[(long)0 + 1];
        }
        while((((long)0 + 1) + 1) < (args.Length - 1));
        
            return (System.Collections.Hashtable)val_6;
        }
        
        UnityEngine.Debug.LogError(message:  "Tween Error: Hash requires an even number of arguments!");
        val_6 = 0;
        return (System.Collections.Hashtable)val_6;
    }
    private iTween(System.Collections.Hashtable h)
    {
        this.tweenArguments = h;
    }
    private void Awake()
    {
        this.thisTransform = this.transform;
        this.RetrieveArgs();
        this.lastRealTime = UnityEngine.Time.realtimeSinceStartup;
    }
    private System.Collections.IEnumerator Start()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new iTween.<Start>d__240(<>1__state:  0);
    }
    private void Update()
    {
        if(this.isRunning == false)
        {
                return;
        }
        
        if(this.physics != false)
        {
                return;
        }
        
        if(this.reverse == false)
        {
            goto label_2;
        }
        
        if(this.percentage > 0f)
        {
            goto label_3;
        }
        
        this.TweenComplete();
        return;
        label_2:
        if(this.percentage >= 0)
        {
            goto label_4;
        }
        
        label_3:
        this.TweenUpdate();
        return;
        label_4:
        this.TweenComplete();
    }
    private void FixedUpdate()
    {
        if(this.isRunning == false)
        {
                return;
        }
        
        if(this.physics == false)
        {
                return;
        }
        
        if(this.reverse == false)
        {
            goto label_2;
        }
        
        if(this.percentage > 0f)
        {
            goto label_3;
        }
        
        this.TweenComplete();
        return;
        label_2:
        if(this.percentage >= 0)
        {
            goto label_4;
        }
        
        label_3:
        this.TweenUpdate();
        return;
        label_4:
        this.TweenComplete();
    }
    private void LateUpdate()
    {
        if((this.tweenArguments & 1) == 0)
        {
                return;
        }
        
        if(this.isRunning == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.type, b:  "move")) != true)
        {
                if((System.String.op_Equality(a:  this.type, b:  "shake")) != true)
        {
                if((System.String.op_Equality(a:  this.type, b:  "punch")) == false)
        {
                return;
        }
        
        }
        
        }
        
        iTween.LookUpdate(target:  this.gameObject, args:  this.tweenArguments);
    }
    private void OnEnable()
    {
        if(this.isPaused == false)
        {
                return;
        }
        
        this.isPaused = false;
        if(this.delay <= 0f)
        {
                return;
        }
        
        this.wasPaused = true;
        this.ResumeDelay();
    }
    private void OnDisable()
    {
    
    }
    private static void DrawLineHelper(UnityEngine.Vector3[] line, UnityEngine.Color color, string method)
    {
        float val_4;
        float val_5;
        var val_6;
        int val_7;
        val_4 = color.a;
        val_5 = color.g;
        UnityEngine.Gizmos.color = new UnityEngine.Color() {r = color.r, g = val_5, b = color.b, a = val_4};
        val_6 = 1;
        goto label_1;
        label_10:
        if((System.String.op_Equality(a:  method, b:  "gizmos")) != false)
        {
                val_7 = line.Length;
            if(W27 >= val_7)
        {
                val_7 = line.Length;
        }
        
            var val_2 = line + ((long)(long)(int)(W27) * 12);
            val_4 = mem[((long)(int)(W27) * 12) + line + 32];
            val_4 = ((long)(int)(W27) * 12) + line + 32;
            val_5 = mem[((long)(int)(W27) * 12) + line + 40];
            val_5 = ((long)(int)(W27) * 12) + line + 40;
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_4, y = ((long)(int)(W27) * 12) + line + 32 + 4, z = val_5}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 5.142877E-39f});
        }
        else
        {
                if((System.String.op_Equality(a:  method, b:  "handles")) != false)
        {
                UnityEngine.Debug.LogError(message:  "iTween Error: Drawing a line with Handles is temporarily disabled because of compatability issues with Unity 2.6!");
        }
        
        }
        
        val_6 = 2;
        label_1:
        int val_5 = line.Length;
        val_5 = val_5 - 1;
        if((val_6 - 1) < val_5)
        {
            goto label_10;
        }
    
    }
    private static void DrawPathHelper(UnityEngine.Vector3[] path, UnityEngine.Color color, string method)
    {
        float val_8;
        float val_9;
        float val_10;
        val_8 = color.b;
        UnityEngine.Vector3[] val_1 = iTween.PathControlPointGenerator(path:  path);
        UnityEngine.Vector3 val_2 = iTween.Interp(pts:  val_1, t:  0f);
        val_9 = val_2.x;
        val_10 = val_2.z;
        UnityEngine.Gizmos.color = new UnityEngine.Color() {r = color.r, g = color.g, b = val_8, a = color.a};
        int val_9 = path.Length;
        val_9 = val_9 + (val_9 << 2);
        int val_3 = val_9 << 2;
        if(val_3 < 1)
        {
                return;
        }
        
        var val_10 = 0;
        do
        {
            val_8 = val_2.y;
            UnityEngine.Vector3 val_6 = iTween.Interp(pts:  val_1, t:  ((float)val_10 + 1) / (float)val_3);
            val_9 = val_6.x;
            val_10 = val_6.z;
            if((System.String.op_Equality(a:  method, b:  "gizmos")) != false)
        {
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_9, y = val_6.y, z = val_10}, to:  new UnityEngine.Vector3() {x = val_9, y = val_8, z = val_10});
        }
        else
        {
                if((System.String.op_Equality(a:  method, b:  "handles")) != false)
        {
                UnityEngine.Debug.LogError(message:  "iTween Error: Drawing a path with Handles is temporarily disabled because of compatability issues with Unity 2.6!");
        }
        
        }
        
            val_10 = val_10 + 1;
        }
        while(val_10 < val_3);
    
    }
    private static UnityEngine.Vector3[] PathControlPointGenerator(UnityEngine.Vector3[] path)
    {
        System.Array val_20;
        int val_21;
        UnityEngine.Vector3 val_22;
        UnityEngine.Vector3 val_23;
        UnityEngine.Vector3 val_24;
        int val_25;
        int val_26;
        int val_27;
        int val_1 = path.Length + 2;
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
        val_20 = val_2;
        System.Array.Copy(sourceArray:  path, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  1, length:  path.Length);
        val_21 = val_2.Length;
        if(val_21 <= 1)
        {
                val_21 = val_2.Length;
        }
        
        val_22 = val_20[1];
        UnityEngine.Vector3 val_20 = val_20[1];
        UnityEngine.Vector3 val_21 = val_20[1];
        val_23 = val_20;
        val_24 = val_21;
        if(val_21 <= 1)
        {
                val_22 = val_20[1];
            val_23 = val_20[1];
            val_24 = val_20[1];
            val_21 = val_2.Length;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24}, b:  new UnityEngine.Vector3() {x = val_20[2], y = val_20[2], z = val_20[2]});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22, y = val_20, z = val_21}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        val_25 = val_2.Length;
        if(val_25 == 0)
        {
                val_25 = val_2.Length;
        }
        
        var val_26 = -8589934592;
        val_20[0] = val_4;
        val_20[0] = val_4.y;
        val_20[0] = val_4.z;
        if(val_25 <= 1)
        {
                val_25 = val_2.Length;
        }
        
        var val_25 = 12;
        val_25 = val_20 + (((val_26 + ((val_2.Length) << 32)) >> 32) * val_25);
        val_26 = (val_26 + ((val_2.Length) << 32)) >> 32;
        if(val_25 <= 1)
        {
                val_25 = val_2.Length;
        }
        
        var val_27 = 12;
        val_27 = val_20 + (val_26 * val_27);
        var val_28 = 12;
        val_28 = val_20 + ((((-12884901888) + ((val_2.Length) << 32)) >> 32) * val_28);
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (((-8589934592 + (val_2.Length) << 32) >> 32) * 12) + val_2 + 32, y = (((-8589934592 + (val_2.Length) << 32) >> 32) * 12) + val_2 + 32 + 4, z = (((-8589934592 + (val_2.Length) << 32) >> 32) * 12) + val_2 + 40}, b:  new UnityEngine.Vector3() {x = (((-12884901888 + (val_2.Length) << 32) >> 32) * 12) + val_2 + 32, y = (((-12884901888 + (val_2.Length) << 32) >> 32) * 12) + val_2 + 32 + 4, z = (((-12884901888 + (val_2.Length) << 32) >> 32) * 12) + val_2 + 40});
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (((-8589934592 + (val_2.Length) << 32) >> 32) * 12) + val_2 + 32, y = (((-8589934592 + (val_2.Length) << 32) >> 32) * 12) + val_2 + 32 + 4, z = (((-8589934592 + (val_2.Length) << 32) >> 32) * 12) + val_2 + 40}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        var val_29 = -4294967296;
        val_29 = val_29 + ((val_2.Length) << 32);
        var val_30 = 12;
        val_30 = val_20 + ((val_29 >> 32) * val_30);
        mem2[0] = val_11.x;
        mem2[0] = val_11.y;
        mem2[0] = val_11.z;
        val_26 = val_2.Length;
        if(val_26 <= 1)
        {
                val_26 = val_2.Length;
        }
        
        var val_34 = -8589934592;
        val_34 = val_34 + ((val_2.Length) << 32);
        var val_35 = 12;
        val_35 = val_20 + ((val_34 >> 32) * val_35);
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_20[1], y = val_20[1], z = val_20[1]}, rhs:  new UnityEngine.Vector3() {x = (((-8589934592 + (val_2.Length) << 32) >> 32) * 12) + val_2 + 32, y = (((-8589934592 + (val_2.Length) << 32) >> 32) * 12) + val_2 + 32 + 4, z = (((-8589934592 + (val_2.Length) << 32) >> 32) * 12) + val_2 + 40})) == false)
        {
                return (UnityEngine.Vector3[])val_20;
        }
        
        UnityEngine.Vector3[] val_15 = new UnityEngine.Vector3[0];
        System.Array.Copy(sourceArray:  val_2, destinationArray:  val_15, length:  val_2.Length);
        val_27 = val_15.Length;
        if(val_27 <= 2)
        {
                val_27 = val_15.Length;
        }
        
        var val_36 = 12;
        val_36 = val_15 + ((((-12884901888) + ((val_15.Length) << 32)) >> 32) * val_36);
        if(val_27 == 0)
        {
                val_27 = val_15.Length;
        }
        
        val_15[0] = (((-12884901888 + (val_15.Length) << 32) >> 32) * 12) + val_15 + 32;
        val_15[0] = (((-12884901888 + (val_15.Length) << 32) >> 32) * 12) + val_15 + 32 + 4;
        val_15[0] = (((-12884901888 + (val_15.Length) << 32) >> 32) * 12) + val_15 + 40;
        if(val_27 <= 2)
        {
                val_27 = val_15.Length;
        }
        
        var val_40 = -4294967296;
        val_40 = val_40 + ((val_15.Length) << 32);
        var val_41 = 12;
        val_41 = val_15 + ((val_40 >> 32) * val_41);
        mem2[0] = val_15[2];
        mem2[0] = val_15[2];
        mem2[0] = val_15[2];
        UnityEngine.Vector3[] val_19 = new UnityEngine.Vector3[0];
        val_20 = val_19;
        System.Array.Copy(sourceArray:  val_15, destinationArray:  val_19, length:  val_15.Length);
        return (UnityEngine.Vector3[])val_20;
    }
    private static UnityEngine.Vector3 Interp(UnityEngine.Vector3[] pts, float t)
    {
        int val_32;
        float val_2 = ((float)pts.Length - 3) * t;
        int val_5 = UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.FloorToInt(f:  val_2), b:  pts.Length - 4);
        val_32 = pts.Length;
        if(val_5 >= val_32)
        {
                val_32 = pts.Length;
        }
        
        var val_32 = 12;
        val_32 = pts + ((long)val_5 * val_32);
        var val_6 = (long)val_5 + 1;
        if(val_6 >= val_32)
        {
                val_32 = pts.Length;
        }
        
        var val_33 = 12;
        val_33 = pts + ((long)val_6 * val_33);
        var val_7 = (long)val_5 + 2;
        if(val_7 >= val_32)
        {
                val_32 = pts.Length;
        }
        
        var val_34 = 12;
        val_34 = pts + ((long)val_7 * val_34);
        var val_35 = 12;
        val_35 = pts + (((long)(long)val_5 + 3) * val_35);
        float val_9 = val_2 - (float)val_5;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = ((long)(int)(val_5) * 12) + pts + 32, y = ((long)(int)(val_5) * 12) + pts + 32 + 4, z = ((long)(int)(val_5) * 12) + pts + 40});
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 32, y = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 32 + 4, z = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 40});
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 32, y = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 36, z = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 40});
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + pts + 32, y = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + pts + 36, z = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + pts + 40});
        float val_36 = val_9;
        float val_16 = val_36 * val_36;
        val_36 = val_36 * val_16;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  val_36);
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(d:  2f, a:  new UnityEngine.Vector3() {x = ((long)(int)(val_5) * 12) + pts + 32, y = ((long)(int)(val_5) * 12) + pts + 32 + 4, z = ((long)(int)(val_5) * 12) + pts + 40});
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(d:  5f, a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 32, y = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 32 + 4, z = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 40});
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(d:  4f, a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 32, y = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 36, z = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 40});
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + pts + 32, y = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + pts + 36, z = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + pts + 40});
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  val_16);
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = ((long)(int)(val_5) * 12) + pts + 32, y = ((long)(int)(val_5) * 12) + pts + 32 + 4, z = ((long)(int)(val_5) * 12) + pts + 40});
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 32, y = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 36, z = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 40});
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, d:  val_9);
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(d:  2f, a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 32, y = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 32 + 4, z = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 40});
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, b:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
        return UnityEngine.Vector3.op_Multiply(d:  0.5f, a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
    }
    private static void Launch(UnityEngine.GameObject target, System.Collections.Hashtable args)
    {
        var val_3;
        if((args & 1) == 0)
        {
                string val_1 = iTween.GenerateID();
        }
        
        val_3 = null;
        val_3 = null;
        iTween.tweens.Insert(index:  0, item:  args);
        iTween val_2 = target.AddComponent<iTween>();
    }
    private static System.Collections.Hashtable CleanArgs(System.Collections.Hashtable args)
    {
        var val_30;
        var val_31;
        var val_36;
        var val_37;
        var val_41;
        System.Collections.Hashtable val_1 = new System.Collections.Hashtable(capacity:  args);
        System.Collections.Hashtable val_2 = new System.Collections.Hashtable(capacity:  args);
        label_16:
        var val_34 = 0;
        val_34 = val_34 + 1;
        if(args.MoveNext() == false)
        {
            goto label_9;
        }
        
        var val_35 = 0;
        val_35 = val_35 + 1;
        object val_6 = args.Current;
        System.Type val_7 = null.InitialType;
        if(val_1 != null)
        {
            goto label_16;
        }
        
        goto label_16;
        label_9:
        val_30 = 0;
        val_31 = 0;
        if(args != null)
        {
                var val_36 = 0;
            val_36 = val_36 + 1;
            args.Dispose();
        }
        
        if( == 1)
        {
            goto label_30;
        }
        
        var val_9 = (95 == 95) ? 1 : 0;
        val_9 = (( >= 0) ? 1 : 0) & val_9;
        var val_11 =  - val_9;
        if(val_1 != null)
        {
            goto label_54;
        }
        
        label_55:
        label_54:
        label_53:
        var val_37 = 0;
        val_37 = val_37 + 1;
        if(val_1.MoveNext() == false)
        {
            goto label_37;
        }
        
        var val_38 = 0;
        val_38 = val_38 + 1;
        object val_15 = val_1.Current;
        if((System.Type.op_Equality(left:  null.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
        {
                System.Type val_19 = null.InitialType;
        }
        
        if((System.Type.op_Equality(left:  null.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_53;
        }
        
        System.Type val_23 = null.InitialType;
        if(args != null)
        {
            goto label_53;
        }
        
        goto label_53;
        label_30:
        if(val_1 != null)
        {
            goto label_54;
        }
        
        goto label_55;
        label_37:
        val_11 = (long)val_11 + 1;
        mem2[0] = 281;
        val_36 = 1152921504621170688;
        val_37 = 0;
        if(val_1 != null)
        {
                var val_39 = 0;
            val_39 = val_39 + 1;
            val_1.Dispose();
        }
        
        if(val_11 == 1)
        {
            goto label_81;
        }
        
        var val_25 = ((1152921525897883344 + (((long)(int)((val_30 - (val_30 >= 0x0 ? 1 : 0 & 95 == 0x5F ? 1 : 0))) + 1)) << 2) == 281) ? 1 : 0;
        val_25 = ((val_11 >= 0) ? 1 : 0) & val_25;
        val_25 = val_11 - val_25;
        val_25 = val_25 + 1;
        if(args != null)
        {
            goto label_98;
        }
        
        label_99:
        label_98:
        label_97:
        var val_40 = 0;
        val_40 = val_40 + 1;
        if(args.MoveNext() == false)
        {
            goto label_88;
        }
        
        var val_41 = 0;
        val_41 = val_41 + 1;
        object val_30 = args.Current;
        string val_32 = null.InitialType.ToLower();
        if(val_2 != null)
        {
            goto label_97;
        }
        
        goto label_97;
        label_81:
        if(args != null)
        {
            goto label_98;
        }
        
        goto label_99;
        label_88:
        val_41 = 0;
        mem2[0] = 363;
        if(args != null)
        {
                var val_42 = 0;
            val_42 = val_42 + 1;
            args.Dispose();
        }
        
        if( == false)
        {
                return val_2;
        }
        
        return val_2;
    }
    private static string GenerateID()
    {
        System.Guid val_1 = System.Guid.NewGuid();
        return (string);
    }
    private void RetrieveArgs()
    {
        var val_3;
        var val_33;
        var val_34;
        UnityEngine.Object val_35;
        string val_38;
        string val_39;
        string val_40;
        string val_41;
        var val_42;
        var val_43;
        float val_44;
        var val_45;
        var val_46;
        var val_47;
        iTween.NamedValueColor val_48;
        string val_49;
        var val_50;
        string val_51;
        LoopType val_52;
        EaseType val_57;
        string val_58;
        var val_62;
        UnityEngine.Space val_63;
        string val_64;
        var val_67;
        bool val_68;
        var val_69;
        bool val_70;
        var val_71;
        val_33 = null;
        val_33 = null;
        List.Enumerator<T> val_1 = iTween.tweens.GetEnumerator();
        val_34 = 1152921525898171440;
        label_10:
        if(((-183304416) & 1) == 0)
        {
            goto label_4;
        }
        
        System.Type val_4 = val_3.InitialType;
        val_35 = val_4;
        if((val_35 != null) && (null != null))
        {
                val_35 = 0;
        }
        
        if(val_35 != this.gameObject)
        {
            goto label_10;
        }
        
        this.tweenArguments = val_4;
        label_4:
        val_3.Add(driver:  public System.Void List.Enumerator<System.Collections.Hashtable>::Dispose(), rectTransform:  0, drivenProperties:  null);
        val_38 = this.tweenArguments;
        if(val_38 != null)
        {
                val_38 = 0;
        }
        
        this.id = val_38;
        val_39 = this.tweenArguments;
        if(val_39 != null)
        {
                val_39 = 0;
        }
        
        this.type = val_39;
        val_40 = this.tweenArguments;
        if(val_40 != null)
        {
                val_40 = 0;
        }
        
        this._name = val_40;
        val_41 = this.tweenArguments;
        if(val_41 != null)
        {
                val_41 = 0;
        }
        
        this.method = val_41;
        if((this.tweenArguments & 1) != 0)
        {
                val_42 = this.tweenArguments;
        }
        else
        {
                val_43 = null;
            val_43 = null;
        }
        
        this.time = iTween.Defaults.__il2cppRuntimeField_static_fields;
        if((this.GetComponent<UnityEngine.Rigidbody>()) != 0)
        {
                this.physics = true;
        }
        
        if((this.tweenArguments & 1) != 0)
        {
                val_44 = this.tweenArguments;
        }
        else
        {
                val_45 = null;
            val_45 = null;
            val_44 = 1152921505060098052;
        }
        
        this.delay = val_44;
        if((this.tweenArguments & 1) == 0)
        {
            goto label_47;
        }
        
        val_34 = 1152921504624791552;
        if((System.Type.op_Equality(left:  this.tweenArguments.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_52;
        }
        
        val_46 = this.tweenArguments;
        goto label_54;
        label_47:
        val_47 = null;
        val_47 = null;
        val_48 = iTween.Defaults.namedColorValue;
        goto label_181;
        label_52:
        val_49 = this.tweenArguments;
        if(val_49 != null)
        {
                val_49 = 0;
        }
        
        object val_15 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_49, ignoreCase:  true);
        label_54:
        label_181:
        this.namedcolorvalue = null;
        if((this.tweenArguments & 1) == 0)
        {
            goto label_66;
        }
        
        val_34 = 1152921504624791552;
        if((System.Type.op_Equality(left:  this.tweenArguments.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_71;
        }
        
        val_50 = this.tweenArguments;
        goto label_81;
        label_71:
        val_51 = this.tweenArguments;
        if(val_51 == null)
        {
            goto label_81;
        }
        
        val_51 = 0;
        goto label_81;
        label_66:
        val_52 = 0;
        label_81:
        this.loopType = val_52;
        if((this.tweenArguments & 1) == 0)
        {
            goto label_104;
        }
        
        val_34 = 1152921504624791552;
        if((System.Type.op_Equality(left:  this.tweenArguments.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_109;
        }
        
        val_57 = this.tweenArguments;
        goto label_119;
        label_109:
        val_58 = this.tweenArguments;
        if(val_58 != null)
        {
                val_58 = 0;
        }
        
        object val_26 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_58, ignoreCase:  true);
        goto label_119;
        label_104:
        val_62 = null;
        val_62 = null;
        val_57 = 1152921505060098064;
        label_119:
        this.easeType = val_57;
        if((this.tweenArguments & 1) == 0)
        {
            goto label_134;
        }
        
        val_34 = 1152921504624791552;
        if((System.Type.op_Equality(left:  this.tweenArguments.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_139;
        }
        
        val_63 = this.tweenArguments;
        goto label_149;
        label_139:
        val_64 = this.tweenArguments;
        if(val_64 != null)
        {
                val_64 = 0;
        }
        
        object val_32 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_64, ignoreCase:  true);
        goto label_149;
        label_134:
        val_67 = null;
        val_67 = null;
        val_63 = 1152921505060098076;
        label_149:
        this.space = val_63;
        if((this.tweenArguments & 1) != 0)
        {
                val_68 = this.tweenArguments;
        }
        else
        {
                val_69 = null;
            val_69 = null;
            val_68 = 1152921505060098072;
        }
        
        this.isLocal = val_68;
        if((this.tweenArguments & 1) != 0)
        {
                val_70 = this.tweenArguments;
        }
        else
        {
                val_71 = null;
            val_71 = null;
            val_70 = 1152921505060098116;
        }
        
        this.useRealTime = val_70;
        this.GetEasingFunction();
    }
    private void GetEasingFunction()
    {
        if(this.easeType > 31)
        {
                return;
        }
        
        var val_2 = 40864448 + (this.easeType) << 2;
        val_2 = val_2 + 40864448;
        goto (40864448 + (this.easeType) << 2 + 40864448);
    }
    private void UpdatePercentage()
    {
        if(this.useRealTime != false)
        {
                float val_1 = UnityEngine.Time.realtimeSinceStartup;
            val_1 = val_1 - this.lastRealTime;
        }
        else
        {
                float val_2 = UnityEngine.Time.deltaTime;
        }
        
        float val_4 = this.time;
        val_2 = this.runningTime + val_2;
        float val_5 = 1f;
        val_4 = val_2 / val_4;
        val_5 = val_5 - val_4;
        val_4 = (this.reverse == true) ? (val_5) : (val_4);
        this.runningTime = val_2;
        this.percentage = val_4;
        this.lastRealTime = UnityEngine.Time.realtimeSinceStartup;
    }
    private void CallBack(string callbackType)
    {
        object val_9;
        System.Collections.Hashtable val_10;
        string val_11;
        val_9 = this;
        val_10 = this.tweenArguments;
        if((val_10 & 1) == 0)
        {
                return;
        }
        
        val_10 = this.tweenArguments;
        if((val_10 & 1) != 0)
        {
                return;
        }
        
        string val_1 = callbackType + "target";
        if((this.tweenArguments & 1) == 0)
        {
            goto label_6;
        }
        
        string val_2 = callbackType + "target";
        val_10 = this.tweenArguments;
        if((val_10 == null) || (null == null))
        {
            goto label_10;
        }
        
        val_10 = 0;
        goto label_10;
        label_6:
        val_10 = this.gameObject;
        label_10:
        if((System.Type.op_Equality(left:  this.tweenArguments.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
        {
                val_11 = this.tweenArguments;
            string val_8 = callbackType + "params";
            val_9 = this.tweenArguments;
            if(val_11 != null)
        {
                val_11 = 0;
        }
        
            val_10.SendMessage(methodName:  val_11, value:  val_9, options:  1);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "iTween Error: Callback method references must be passed as a String!");
        UnityEngine.Object.Destroy(obj:  this);
    }
    private void Dispose()
    {
        var val_5;
        var val_6;
        string val_7;
        var val_8;
        System.Collections.Generic.List<System.Collections.Hashtable> val_9;
        var val_10;
        val_5 = 0;
        goto label_1;
        label_12:
        val_6 = null;
        val_6 = null;
        val_7 = iTween.tweens.Item[0];
        if(val_7 != null)
        {
                val_7 = 0;
        }
        
        if((System.String.op_Equality(a:  val_7, b:  this.id)) == true)
        {
            goto label_8;
        }
        
        val_5 = 1;
        label_1:
        val_8 = null;
        val_8 = null;
        val_9 = iTween.tweens;
        if(val_5 < val_9.Count)
        {
            goto label_12;
        }
        
        goto label_13;
        label_8:
        val_10 = null;
        val_10 = null;
        val_9 = iTween.tweens;
        val_9.RemoveAt(index:  0);
        label_13:
        UnityEngine.Object.Destroy(obj:  this);
    }
    private void ConflictCheck()
    {
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        System.Collections.Hashtable val_23;
        System.Collections.Hashtable val_24;
        string val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        val_19 = this;
        val_20 = "value";
        val_21 = 0;
        goto label_1;
        label_65:
        val_22 = 0;
        T val_21 = this.GetComponents<iTween>()[val_22];
        if((System.String.op_Equality(a:  64, b:  "value")) == true)
        {
                return;
        }
        
        if((1 == 0) || ((System.String.op_Equality(a:  64, b:  this.type)) == false))
        {
            goto label_8;
        }
        
        if((System.String.op_Inequality(a:  53212264, b:  this.method)) == true)
        {
                return;
        }
        
        val_23 = this.tweenArguments;
        val_22 = 48980696;
        if(val_22 != val_23)
        {
            goto label_12;
        }
        
        val_24 = this.tweenArguments;
        label_34:
        var val_22 = 0;
        val_22 = val_22 + 1;
        if(val_24.MoveNext() == false)
        {
            goto label_19;
        }
        
        var val_23 = 0;
        val_23 = val_23 + 1;
        object val_10 = val_24.Current;
        val_23 = 48980696;
        if((val_23 & 1) == 0)
        {
            goto label_27;
        }
        
        System.Type val_12 = null.InitialType;
        val_23 = 48980696;
        System.Type val_13 = null.InitialType;
        val_20 = val_20;
        val_19 = val_19;
        val_21 = val_21;
        val_24 = val_24;
        if((val_23 & 1) != 0)
        {
            goto label_34;
        }
        
        if(null.InitialType != null)
        {
                val_27 = 0;
        }
        
        if((System.String.op_Inequality(a:  val_27, b:  "id")) == false)
        {
            goto label_34;
        }
        
        this.Dispose();
        goto label_35;
        label_19:
        val_28 = -182041648;
        val_29 = 0;
        val_30 = 1;
        val_31 = 288;
        goto label_37;
        label_27:
        this.Dispose();
        label_35:
        val_28 = -182041648;
        val_29 = 0;
        val_30 = 0 + 1;
        val_31 = 307;
        label_37:
        mem2[0] = 307;
        val_22 = val_24;
        if(val_22 != null)
        {
                var val_24 = 0;
            val_24 = val_24 + 1;
            val_22.Dispose();
        }
        
        if(val_30 != 1)
        {
                if((-182041648 + ((0 + 1)) << 2) == 307)
        {
                return;
        }
        
            var val_18 = ((-182041648 + ((0 + 1)) << 2) == 288) ? 1 : 0;
            val_18 = ((val_30 >= 0) ? 1 : 0) & val_18;
            val_30 = val_30 - val_18;
        }
        
        this.Dispose();
        label_8:
        val_21 = val_21 + 1;
        label_1:
        if(val_21 < val_1.Length)
        {
            goto label_65;
        }
        
        return;
        label_12:
        this.Dispose();
    }
    private void EnableKinematic()
    {
    
    }
    private void DisableKinematic()
    {
    
    }
    private void ResumeDelay()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "TweenDelay");
    }
    private float linear(float start, float end, float value)
    {
        return UnityEngine.Mathf.Lerp(a:  start, b:  end, t:  value);
    }
    private float clerp(float start, float end, float value)
    {
        float val_1 = end - start;
        if(val_1 < 0)
        {
                float val_1 = 360f;
            val_1 = val_1 - start;
            val_1 = val_1 + end;
        }
        else
        {
                if(val_1 > 180f)
        {
                float val_2 = 360f;
            val_2 = val_2 - end;
            val_2 = val_2 + start;
            val_1 = -val_2;
        }
        
        }
        
        val_1 = val_1 * value;
        val_1 = val_1 + start;
        return (float)val_1;
    }
    private float spring(float start, float end, float value)
    {
        float val_1 = UnityEngine.Mathf.Clamp01(value:  value);
        float val_4 = 2.5f;
        float val_5 = 3.141593f;
        val_4 = val_1 * val_4;
        val_4 = val_1 * val_4;
        val_4 = val_1 * val_4;
        val_5 = val_1 * val_5;
        val_4 = val_4 + 0.2f;
        val_4 = val_5 * val_4;
        float val_2 = 1f - val_1;
        float val_6 = val_2;
        float val_7 = 1.2f;
        val_6 = val_4 * val_6;
        val_6 = val_1 + val_6;
        val_7 = val_2 * val_7;
        val_7 = val_7 + 1f;
        val_6 = val_7 * val_6;
        val_6 = (end - start) * val_6;
        val_6 = val_6 + start;
        return (float)val_6;
    }
    private float easeInQuad(float start, float end, float value)
    {
        end = end - start;
        end = end * value;
        end = end * value;
        start = end + start;
        return (float)start;
    }
    private float easeOutQuad(float start, float end, float value)
    {
        end = end - start;
        end = end * value;
        value = value + (-2f);
        end = end * value;
        start = start - end;
        return (float)start;
    }
    private float easeInOutQuad(float start, float end, float value)
    {
        float val_1;
        value = value + value;
        end = end - start;
        if(value < 0)
        {
                end = end * 0.5f;
            end = end * value;
            val_1 = value * end;
        }
        else
        {
                value = value + (-1f);
            end = end * (-0.5f);
            float val_1 = -2f;
            val_1 = value + val_1;
            value = value * val_1;
            value = value + (-1f);
            val_1 = end * value;
        }
        
        start = val_1 + start;
        return (float)start;
    }
    private float easeInCubic(float start, float end, float value)
    {
        end = end - start;
        end = end * value;
        end = end * value;
        end = end * value;
        start = end + start;
        return (float)start;
    }
    private float easeOutCubic(float start, float end, float value)
    {
        float val_1 = -1f;
        value = value + val_1;
        val_1 = value * value;
        value = value * val_1;
        end = end - start;
        value = value + 1f;
        end = end * value;
        start = end + start;
        return (float)start;
    }
    private float easeInOutCubic(float start, float end, float value)
    {
        float val_1;
        value = value + value;
        end = end - start;
        if(value < 0)
        {
                end = end * 0.5f;
            end = end * value;
            end = value * end;
            val_1 = value * end;
        }
        else
        {
                float val_1 = -2f;
            value = value + val_1;
            val_1 = value * value;
            value = value * val_1;
            end = end * 0.5f;
            value = value + 2f;
            val_1 = end * value;
        }
        
        start = val_1 + start;
        return (float)start;
    }
    private float easeInQuart(float start, float end, float value)
    {
        end = end - start;
        end = end * value;
        end = end * value;
        end = end * value;
        end = end * value;
        start = end + start;
        return (float)start;
    }
    private float easeOutQuart(float start, float end, float value)
    {
        value = value + (-1f);
        float val_1 = value * value;
        val_1 = value * val_1;
        value = value * val_1;
        end = end - start;
        value = value + (-1f);
        end = end * value;
        start = start - end;
        return (float)start;
    }
    private float easeInOutQuart(float start, float end, float value)
    {
        float val_2;
        value = value + value;
        end = end - start;
        if(value < 0)
        {
                end = end * 0.5f;
            end = end * value;
            end = value * end;
            end = value * end;
            val_2 = value * end;
        }
        else
        {
                value = value + (-2f);
            end = end * (-0.5f);
            float val_1 = value * value;
            val_1 = value * val_1;
            value = value * val_1;
            value = value + (-2f);
            val_2 = end * value;
        }
        
        start = val_2 + start;
        return (float)start;
    }
    private float easeInQuint(float start, float end, float value)
    {
        end = end - start;
        end = end * value;
        end = end * value;
        end = end * value;
        end = end * value;
        end = end * value;
        start = end + start;
        return (float)start;
    }
    private float easeOutQuint(float start, float end, float value)
    {
        float val_1 = -1f;
        value = value + val_1;
        val_1 = value * value;
        val_1 = value * val_1;
        val_1 = value * val_1;
        value = value * val_1;
        end = end - start;
        value = value + 1f;
        end = end * value;
        start = end + start;
        return (float)start;
    }
    private float easeInOutQuint(float start, float end, float value)
    {
        float val_1;
        value = value + value;
        end = end - start;
        if(value < 0)
        {
                end = end * 0.5f;
            end = end * value;
            end = value * end;
            end = value * end;
            end = value * end;
            val_1 = value * end;
        }
        else
        {
                float val_1 = -2f;
            value = value + val_1;
            val_1 = value * value;
            val_1 = value * val_1;
            val_1 = value * val_1;
            value = value * val_1;
            end = end * 0.5f;
            value = value + 2f;
            val_1 = end * value;
        }
        
        start = val_1 + start;
        return (float)start;
    }
    private float easeInSine(float start, float end, float value)
    {
        float val_1 = end;
        val_1 = val_1 - start;
        float val_2 = 1.570796f;
        val_2 = value * val_2;
        val_2 = val_1 * val_2;
        val_2 = val_1 - val_2;
        val_2 = val_2 + start;
        return (float)val_2;
    }
    private float easeOutSine(float start, float end, float value)
    {
        float val_1 = end;
        val_1 = val_1 - start;
        float val_2 = 1.570796f;
        val_2 = value * val_2;
        val_2 = val_1 * val_2;
        val_2 = val_2 + start;
        return (float)val_2;
    }
    private float easeInOutSine(float start, float end, float value)
    {
        float val_1 = end;
        val_1 = val_1 - start;
        float val_2 = 3.141593f;
        val_2 = value * val_2;
        float val_3 = -0.5f;
        val_3 = val_1 * val_3;
        val_2 = val_2 + (-1f);
        val_2 = val_3 * val_2;
        val_2 = val_2 + start;
        return (float)val_2;
    }
    private float easeInExpo(float start, float end, float value)
    {
        float val_1 = end;
        val_1 = val_1 - start;
        float val_2 = -1f;
        val_2 = value + val_2;
        val_2 = val_2 * 10f;
        val_2 = val_1 * val_2;
        val_2 = val_2 + start;
        return (float)val_2;
    }
    private float easeOutExpo(float start, float end, float value)
    {
        float val_1 = end;
        val_1 = val_1 - start;
        float val_2 = -10f;
        val_2 = value * val_2;
        val_2 = 1f - val_2;
        val_2 = val_1 * val_2;
        val_2 = val_2 + start;
        return (float)val_2;
    }
    private float easeInOutExpo(float start, float end, float value)
    {
        float val_1;
        float val_2;
        float val_1 = value;
        float val_2 = end;
        val_1 = val_1 + val_1;
        val_2 = val_2 - start;
        if(val_1 < 0)
        {
                float val_3 = -1f;
            val_3 = val_1 + val_3;
            val_1 = val_3 * 10f;
            val_2 = val_2 * 0.5f;
        }
        else
        {
                val_1 = val_1 + (-1f);
            float val_4 = -10f;
            val_4 = val_1 * val_4;
            val_2 = val_2 * 0.5f;
            val_1 = 2f - val_4;
        }
        
        val_1 = val_2 * val_1;
        val_1 = val_1 + start;
        return (float)val_1;
    }
    private float easeInCirc(float start, float end, float value)
    {
        float val_2;
        float val_3 = end;
        float val_1 = value * value;
        float val_2 = 1f;
        val_2 = val_2 - val_1;
        val_3 = val_3 - start;
        if(val_1 >= _TYPE_MAX_)
        {
                val_2 = val_2;
        }
        
        val_2 = val_2 + (-1f);
        val_2 = val_3 * val_2;
        val_2 = start - val_2;
        return (float)val_2;
    }
    private float easeOutCirc(float start, float end, float value)
    {
        float val_1;
        float val_1 = value;
        float val_4 = end;
        float val_2 = -1f;
        val_1 = val_1 + val_2;
        val_2 = val_1 * val_1;
        float val_3 = 1f;
        val_3 = val_3 - val_2;
        val_4 = val_4 - start;
        if(val_2 >= _TYPE_MAX_)
        {
                val_1 = val_3;
        }
        
        val_1 = val_4 * val_1;
        val_1 = val_1 + start;
        return (float)val_1;
    }
    private float easeInOutCirc(float start, float end, float value)
    {
        float val_5;
        float val_6;
        float val_7;
        float val_8;
        float val_4 = end;
        float val_1 = value + value;
        if(val_1 < 0)
        {
                val_5 = val_1 * val_1;
            val_6 = -1f;
            val_7 = -0.5f;
        }
        else
        {
                val_1 = val_1 + (-2f);
            val_5 = val_1 * val_1;
            val_7 = 0.5f;
            val_6 = 1f;
        }
        
        val_4 = val_4 - start;
        if(val_5 >= _TYPE_MAX_)
        {
                val_8 = 1f - val_5;
        }
        
        val_8 = val_6 + val_8;
        val_8 = (val_4 * val_7) * val_8;
        val_8 = val_8 + start;
        return (float)val_8;
    }
    private float easeInBounce(float start, float end, float value)
    {
        float val_1 = end - start;
        value = 1f - value;
        float val_2 = this.easeOutBounce(start:  0f, end:  val_1, value:  value);
        val_2 = val_1 - val_2;
        val_2 = val_2 + start;
        return (float)val_2;
    }
    private float easeOutBounce(float start, float end, float value)
    {
        float val_1;
        end = end - start;
        if(value < 0)
        {
                float val_1 = 7.5625f;
            val_1 = value * val_1;
            val_1 = val_1 * value;
        }
        else
        {
                if(value < 0)
        {
                float val_2 = -0.5454546f;
            value = value + val_2;
            val_2 = value * 7.5625f;
            value = value * val_2;
            val_1 = value + 0.75f;
        }
        else
        {
                if((double)value < 0)
        {
                float val_3 = -0.8181818f;
            value = value + val_3;
            val_3 = value * 7.5625f;
            value = value * val_3;
            val_1 = value + 0.9375f;
        }
        else
        {
                float val_4 = -0.9545454f;
            value = value + val_4;
            val_4 = value * 7.5625f;
            value = value * val_4;
            val_1 = value + 0.984375f;
        }
        
        }
        
        }
        
        end = end * val_1;
        start = end + start;
        return (float)start;
    }
    private float easeInOutBounce(float start, float end, float value)
    {
        float val_7;
        float val_1 = end - start;
        float val_2 = value + value;
        if(value < 0)
        {
                value = 1f - val_2;
            float val_3 = this.easeOutBounce(start:  0f, end:  val_1, value:  value);
            val_3 = val_1 - val_3;
            val_3 = val_3 + 0f;
            val_7 = val_3 * 0.5f;
        }
        else
        {
                value = val_2 + (-1f);
            float val_4 = this.easeOutBounce(start:  0f, end:  val_1, value:  value);
            val_4 = val_4 * 0.5f;
            val_7 = (val_1 * 0.5f) + val_4;
        }
        
        val_7 = val_7 + start;
        return (float)val_7;
    }
    private float easeInBack(float start, float end, float value)
    {
        end = end - start;
        end = end * value;
        end = end * value;
        value = value * 2.70158f;
        value = value + (-1.70158f);
        end = end * value;
        start = end + start;
        return (float)start;
    }
    private float easeOutBack(float start, float end, float value)
    {
        float val_1 = 2.70158f;
        value = value + (-1f);
        float val_2 = 1.70158f;
        val_1 = value * val_1;
        value = value * value;
        end = end - start;
        val_2 = val_1 + val_2;
        value = value * val_2;
        value = value + 1f;
        end = end * value;
        start = end + start;
        return (float)start;
    }
    private float easeInOutBack(float start, float end, float value)
    {
        float val_3;
        float val_4;
        value = value + value;
        end = end - start;
        if(value < 0)
        {
                val_3 = end * 0.5f;
            value = value * 3.594909f;
            value = value + (-2.594909f);
            val_4 = (value * value) * value;
        }
        else
        {
                value = value + (-2f);
            val_3 = end * 0.5f;
            value = value * 3.594909f;
            value = value + 2.594909f;
            value = (value * value) * value;
            val_4 = value + 2f;
        }
        
        val_3 = val_3 * val_4;
        start = val_3 + start;
        return (float)start;
    }
    private float punch(float amplitude, float value)
    {
        if(value == 0f)
        {
                return (float)val_3;
        }
        
        if(value == 1f)
        {
                return (float)val_3;
        }
        
        float val_2 = -10f;
        val_2 = value * val_2;
        float val_3 = 6.283185f;
        val_3 = value * val_3;
        val_3 = val_3 / 0.3f;
        val_3 = (val_2 * amplitude) * val_3;
        return (float)val_3;
    }
    private float easeInElastic(float start, float end, float value)
    {
        float val_3;
        float val_4;
        val_3 = end;
        val_4 = start;
        if(value == 0f)
        {
                return (float)val_4;
        }
        
        val_3 = val_3 - val_4;
        if(value == 1f)
        {
                val_4 = val_3 + val_4;
            return (float)val_4;
        }
        
        float val_1 = value + (-1f);
        float val_3 = 10f;
        val_3 = val_1 * val_3;
        float val_4 = -0.075f;
        val_4 = val_1 + val_4;
        val_4 = val_4 * 6.283185f;
        val_4 = val_4 / 0.3f;
        val_4 = (val_3 * val_3) * val_4;
        val_4 = val_4 - val_4;
        return (float)val_4;
    }
    private float easeOutElastic(float start, float end, float value)
    {
        float val_3;
        float val_4;
        val_3 = end;
        val_4 = start;
        if(value == 0f)
        {
                return (float)val_4;
        }
        
        float val_1 = val_3 - val_4;
        if(value == 1f)
        {
                val_4 = val_1 + val_4;
            return (float)val_4;
        }
        
        float val_3 = -10f;
        val_3 = value * val_3;
        val_3 = val_3;
        float val_4 = -0.075f;
        val_4 = value + val_4;
        val_4 = val_4 * 6.283185f;
        val_4 = val_4 / 0.3f;
        val_4 = (val_1 * val_3) * val_4;
        val_4 = val_1 + val_4;
        val_4 = val_4 + val_4;
        return (float)val_4;
    }
    private float easeInOutElastic(float start, float end, float value)
    {
        float val_6;
        float val_7;
        val_6 = value;
        val_7 = start;
        if(val_6 == 0f)
        {
                return (float)val_7;
        }
        
        float val_1 = val_6 + val_6;
        val_6 = end - val_7;
        if(val_1 == 2f)
        {
                val_7 = val_6 + val_7;
            return (float)val_7;
        }
        
        float val_2 = val_1 + (-1f);
        if(val_1 < 0)
        {
                float val_5 = 10f;
            val_5 = val_2 * val_5;
            float val_6 = -0.075f;
            val_6 = val_2 + val_6;
            val_6 = val_6 * 6.283185f;
            val_6 = val_6 / 0.3f;
            val_6 = (val_6 * val_5) * val_6;
            val_6 = val_6 * (-0.5f);
            val_7 = val_7 + val_6;
            return (float)val_7;
        }
        
        float val_7 = -10f;
        val_7 = val_2 * val_7;
        float val_8 = -0.075f;
        val_8 = val_2 + val_8;
        val_8 = val_8 * 6.283185f;
        val_8 = val_8 / 0.3f;
        val_8 = (val_6 * val_7) * val_8;
        val_8 = val_8 * 0.5f;
        val_8 = val_6 + val_8;
        val_7 = val_8 + val_7;
        return (float)val_7;
    }
    private static iTween()
    {
        iTween.tweens = new System.Collections.Generic.List<System.Collections.Hashtable>();
    }

}
