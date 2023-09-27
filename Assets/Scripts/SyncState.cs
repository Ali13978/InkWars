using UnityEngine;
[Serializable]
public class SyncState
{
    // Fields
    public float CountdownTime;
    public SyncState.SyncBallData[] outerRingBalls;
    public SyncState.SyncBallData[] middleRingBalls;
    public SyncState.SyncBallData[] innerRingBalls;
    public SyncState.SyncBallData[] playerOuterRingBalls;
    public SyncState.SyncBallData[] playerMiddleRingBalls;
    public SyncState.SyncBallData[] playerInnerRingBalls;
    private static int[] outerRingBallsMismatch;
    private static int[] middleRingBallsMismatch;
    private static int[] innerRingBallsMismatch;
    private static int[] playerOuterRingBallsMismatch;
    private static int[] playerMiddleRingBallsMismatch;
    private static int[] playerInnerRingBallsMismatch;
    
    // Methods
    public static void ResetMismatchCounts()
    {
        var val_7 = null;
        SyncState.outerRingBallsMismatch = new int[17];
        SyncState.middleRingBallsMismatch = new int[13];
        SyncState.innerRingBallsMismatch = new int[9];
        SyncState.playerOuterRingBallsMismatch = new int[17];
        SyncState.playerMiddleRingBallsMismatch = new int[13];
        SyncState.playerInnerRingBallsMismatch = new int[9];
    }
    public static string SendStringState()
    {
        var val_2;
        var val_3;
        SyncState val_1 = new SyncState();
        val_2 = null;
        val_2 = null;
        if(val_1 != null)
        {
                .CountdownTime = LineController.instance.gameTime;
        }
        else
        {
                mem[16] = LineController.instance.gameTime;
        }
        
        val_3 = null;
        val_3 = null;
        SyncState.SerializeRing(dataRef:  (SyncState)[1152921528229423680].outerRingBalls, ringRef:  InstanceAnimator.outerRingBalls);
        SyncState.SerializeRing(dataRef:  (SyncState)[1152921528229423680].middleRingBalls, ringRef:  InstanceAnimator.middleRingBalls);
        SyncState.SerializeRing(dataRef:  (SyncState)[1152921528229423680].innerRingBalls, ringRef:  InstanceAnimator.innerRingBalls);
        SyncState.SerializeRing(dataRef:  (SyncState)[1152921528229423680].playerOuterRingBalls, ringRef:  InstanceAnimator.playerOuterRingBalls);
        SyncState.SerializeRing(dataRef:  (SyncState)[1152921528229423680].playerMiddleRingBalls, ringRef:  InstanceAnimator.playerMiddleRingBalls);
        SyncState.SerializeRing(dataRef:  (SyncState)[1152921528229423680].playerInnerRingBalls, ringRef:  InstanceAnimator.playerInnerRingBalls);
        return UnityEngine.JsonUtility.ToJson(obj:  val_1);
    }
    public static void ReceiveStringState(string json)
    {
        var val_2;
        var val_3;
        object val_4;
        var val_5;
        var val_6;
        var val_7;
        val_2 = null;
        val_2 = null;
        if(InstanceAnimator.areBallsInstantiated == false)
        {
            goto label_3;
        }
        
        val_3 = null;
        val_3 = null;
        if(LineController.InkingSequence == false)
        {
            goto label_6;
        }
        
        val_4 = "REJECTING SYNC STATE - INKING";
        goto label_7;
        label_3:
        val_4 = "REJECTING SYNC STATE";
        label_7:
        UnityEngine.MonoBehaviour.print(message:  val_4);
        return;
        label_6:
        SyncState val_1 = UnityEngine.JsonUtility.FromJson<SyncState>(json:  json);
        val_5 = null;
        val_5 = null;
        val_6 = null;
        val_6 = null;
        SyncState.DeserializeRing(dataRef:  val_1.outerRingBalls, ringRef:  InstanceAnimator.playerOuterRingBalls, mismatchCount:  SyncState.playerOuterRingBallsMismatch);
        SyncState.DeserializeRing(dataRef:  val_1.middleRingBalls, ringRef:  InstanceAnimator.playerMiddleRingBalls, mismatchCount:  SyncState.playerMiddleRingBallsMismatch);
        SyncState.DeserializeRing(dataRef:  val_1.innerRingBalls, ringRef:  InstanceAnimator.playerInnerRingBalls, mismatchCount:  SyncState.playerInnerRingBallsMismatch);
        SyncState.DeserializeRing(dataRef:  val_1.playerOuterRingBalls, ringRef:  InstanceAnimator.outerRingBalls, mismatchCount:  SyncState.outerRingBallsMismatch);
        SyncState.DeserializeRing(dataRef:  val_1.playerMiddleRingBalls, ringRef:  InstanceAnimator.middleRingBalls, mismatchCount:  SyncState.middleRingBallsMismatch);
        SyncState.DeserializeRing(dataRef:  val_1.playerInnerRingBalls, ringRef:  InstanceAnimator.innerRingBalls, mismatchCount:  SyncState.innerRingBallsMismatch);
        val_7 = null;
        val_7 = null;
        LineController.instance.gameTime = val_1.CountdownTime;
    }
    private static void DeserializeRing(SyncState.SyncBallData[] dataRef, UnityEngine.GameObject[] ringRef, int[] mismatchCount)
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_13 = 0;
        goto label_1;
        label_67:
        val_14 = 0;
        SyncBallData val_13 = dataRef[val_14];
        UnityEngine.Vector3 val_15 = dataRef[0x0][0].v;
        val_15 = null;
        val_15 = null;
        val_15 = val_15 * (float)InstanceAnimator.cpuNegateX;
        if((UnityEngine.Object.op_Implicit(exists:  ringRef[val_14])) != false)
        {
                UnityEngine.Vector3 val_3 = ringRef[0x0] + 32.transform.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_15, y = V8.16B, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            var val_5 = (val_4.x > 0.01f) ? 1 : 0;
        }
        else
        {
                val_16 = 0;
        }
        
        UnityEngine.GameObject val_16 = ringRef[0x0] + 32;
        val_16 = val_16 | (((dataRef[0x0] + 32 + 16) != (SyncState.BallToInt(go:  val_16))) ? 1 : 0);
        if((val_16 & 1) == 0)
        {
            goto label_23;
        }
        
        if(mismatchCount[0] == 0)
        {
            goto label_25;
        }
        
        UnityEngine.MonoBehaviour.print(message:  "Mismatch detected!");
        if((dataRef[0x0] + 32 + 16) == 1)
        {
            goto label_29;
        }
        
        if((SyncState.BallToInt(go:  ringRef[0x0] + 32)) != (dataRef[0x0] + 32 + 16))
        {
                UnityEngine.Object.Destroy(obj:  ringRef[0x0] + 32);
            mem2[0] = 0;
        }
        
        if((ringRef[0x0] + 32) == 0)
        {
                val_17 = null;
            val_17 = null;
            UnityEngine.GameObject[] val_10 = InstanceAnimator.instance.balls + ((dataRef[0x0] + 32 + 16) << 3);
            mem2[0] = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  mem[(InstanceAnimator.instance.balls + (dataRef[0x0] + 32 + 16) << 3) + 32]);
        }
        
        ringRef[0x0] + 32.transform.position = new UnityEngine.Vector3() {x = val_15, y = V8.16B, z = V9.16B};
        goto label_58;
        label_23:
        mismatchCount[0] = 0;
        goto label_62;
        label_25:
        mem2[0] = 1;
        goto label_62;
        label_29:
        UnityEngine.Object.Destroy(obj:  ringRef[0x0] + 32);
        label_58:
        mem2[0] = 0;
        label_62:
        val_13 = 1;
        label_1:
        if(val_13 < ringRef.Length)
        {
            goto label_67;
        }
    
    }
    private static void SerializeRing(SyncState.SyncBallData[] dataRef, UnityEngine.GameObject[] ringRef)
    {
        SyncBallData val_2;
        goto label_1;
        label_10:
        SyncState.SyncBallData val_1 = null;
        val_2 = val_1;
        val_1 = new SyncState.SyncBallData(gameObject:  ringRef[0]);
        if(dataRef == null)
        {
            goto label_3;
        }
        
        if(val_2 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_2 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        0 = 1;
        dataRef[0] = val_2;
        label_1:
        if(0 < ringRef.Length)
        {
            goto label_10;
        }
    
    }
    private static int BallToInt(UnityEngine.GameObject go)
    {
        if(go == 0)
        {
                return 0;
        }
        
        string val_2 = go.tag;
        uint val_3 = _PrivateImplementationDetails_.ComputeStringHash(s:  val_2);
        if(val_3 > (-1551951748))
        {
            goto label_5;
        }
        
        if(val_3 == (-1551951748))
        {
            goto label_6;
        }
        
        if(val_3 == 1528554166)
        {
            goto label_7;
        }
        
        if(val_3 != 1920678155)
        {
                return 0;
        }
        
        if((System.String.op_Equality(a:  val_2, b:  "Orange")) == false)
        {
                return 0;
        }
        
        return 0;
        label_5:
        if(val_3 > (-1232946657))
        {
            goto label_11;
        }
        
        if(val_3 == (-1454127268))
        {
            goto label_12;
        }
        
        if(val_3 != (-1232946657))
        {
                return 0;
        }
        
        if((System.String.op_Equality(a:  val_2, b:  "Purple")) == false)
        {
                return 0;
        }
        
        return 0;
        label_11:
        if(val_3 == (-640816023))
        {
            goto label_16;
        }
        
        if(val_3 != (-371384339))
        {
                return 0;
        }
        
        if((System.String.op_Equality(a:  val_2, b:  "Blue")) == false)
        {
                return 0;
        }
        
        return 0;
        label_6:
        if((System.String.op_Equality(a:  val_2, b:  "Red")) == false)
        {
                return 0;
        }
        
        return 0;
        label_7:
        if((System.String.op_Equality(a:  val_2, b:  "SPD")) == false)
        {
                return 0;
        }
        
        return 0;
        label_12:
        if((System.String.op_Equality(a:  val_2, b:  "Green")) == false)
        {
                return 0;
        }
        
        return 0;
        label_16:
        if((System.String.op_Equality(a:  val_2, b:  "Yellow")) == false)
        {
                return 0;
        }
        
        return 0;
    }
    public SyncState()
    {
        this.outerRingBalls = new SyncBallData[17];
        this.middleRingBalls = new SyncBallData[13];
        this.innerRingBalls = new SyncBallData[9];
        this.playerOuterRingBalls = new SyncBallData[17];
        this.playerMiddleRingBalls = new SyncBallData[13];
        this.playerInnerRingBalls = new SyncBallData[9];
    }
    private static SyncState()
    {
        SyncState.outerRingBallsMismatch = new int[17];
        SyncState.middleRingBallsMismatch = new int[13];
        SyncState.innerRingBallsMismatch = new int[9];
        SyncState.playerOuterRingBallsMismatch = new int[17];
        SyncState.playerMiddleRingBallsMismatch = new int[13];
        SyncState.playerInnerRingBallsMismatch = new int[9];
    }

}
