using UnityEngine;
private sealed class TargetBallVs.<BridgeThroughOuterRing>d__32 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TargetBallVs <>4__this;
    public UnityEngine.GameObject[] outerRingBalls;
    public int incrementCounter;
    private bool <upperFlag>5__2;
    private bool <lowerFlag>5__3;
    private int <j>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TargetBallVs.<BridgeThroughOuterRing>d__32(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_80;
        int val_81;
        int val_82;
        int val_83;
        string val_84;
        var val_85;
        float val_86;
        float val_87;
        float val_88;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        val_80 = null;
        val_80 = null;
        int val_79 = LineController.BridgeStunP1;
        val_79 = val_79 + 1;
        LineController.BridgeStunP1 = val_79;
        this.<upperFlag>5__2 = true;
        this.<lowerFlag>5__3 = true;
        val_81 = 8;
        val_82 = this;
        this.<>4__this.isOuterBridgeRunning = true;
        this.<j>5__4 = val_81;
        if((val_81 & 2147483648) == 0)
        {
            goto label_7;
        }
        
        goto label_137;
        label_1:
        this.<>1__state = 0;
        val_82 = this.<j>5__4;
        int val_80 = this.incrementCounter;
        val_80 = val_80 + TargetBallVs.scoreCounter;
        TargetBallVs.scoreCounter = val_80;
        goto label_9;
        label_2:
        this.<>1__state = 0;
        val_82 = this.<j>5__4;
        int val_81 = this.incrementCounter;
        val_81 = val_81 + TargetBallVs.scoreCounter;
        TargetBallVs.scoreCounter = val_81;
        goto label_10;
        label_3:
        val_83 = 0;
        return (bool)val_83;
        label_139:
        val_84 = this.<>4__this.popBallTag;
        TargetBallVs.popTag = val_84 + "Extended";
        val_85 = 1152921504858337280;
        val_81 = this.outerRingBalls[X23];
        if(val_81 == 0)
        {
            goto label_18;
        }
        
        val_81 = this.outerRingBalls[X23].gameObject;
        if((val_81.CompareTag(tag:  this.<>4__this.gameObject.tag)) == true)
        {
            goto label_24;
        }
        
        label_18:
        if(X23 == 0)
        {
            goto label_140;
        }
        
        val_81 = this.outerRingBalls[(long)17 - X23];
        if(val_81 == 0)
        {
            goto label_140;
        }
        
        val_81 = this.outerRingBalls[(long)17 - X23].gameObject;
        if((val_81.CompareTag(tag:  this.<>4__this.gameObject.tag)) == false)
        {
            goto label_140;
        }
        
        label_24:
        if(this.outerRingBalls[X23] != 0)
        {
                if(((this.outerRingBalls[X23].gameObject.CompareTag(tag:  this.<>4__this.gameObject.tag)) != false) && ((this.<upperFlag>5__2) != false))
        {
                if(X23 == 7)
        {
                mem2[0] = 1;
        }
        
            UnityEngine.AudioSource val_20 = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.popClip[0], volume:  1f);
            UnityEngine.Vector3 val_23 = this.outerRingBalls[X23].gameObject.transform.position;
            UnityEngine.Quaternion val_24 = UnityEngine.Quaternion.identity;
            val_86 = val_24.y;
            UnityEngine.GameObject val_25 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.popAnimation, position:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, rotation:  new UnityEngine.Quaternion() {x = val_24.x, y = val_86, z = val_24.z, w = val_24.w});
            UnityEngine.Vector3 val_28 = this.outerRingBalls[X23].gameObject.transform.position;
            UnityEngine.Quaternion val_29 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_30 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, rotation:  new UnityEngine.Quaternion() {x = val_29.x, y = val_29.y, z = val_29.z, w = val_29.w});
            this.<>4__this.popText = val_30;
            val_30.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
            val_85 = mem[X23];
            val_85 = X23;
            UnityEngine.Vector3 val_37 = this.outerRingBalls[val_85].gameObject.transform.position;
            val_87 = val_37.z;
            this.<>4__this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_87};
            popScoreScript val_38 = this.<>4__this.popText.GetComponent<popScoreScript>();
            val_38.scoreCounter = TargetBallVs.scoreCounter;
            UnityEngine.Object.Destroy(obj:  this.outerRingBalls[X23].gameObject);
            mem2[0] = this.outerRingBalls[X23][1];
            int val_91 = TargetBallVs.scoreCounter;
            val_91 = val_91 + (this.<>4__this.chainScore);
            this.<>4__this.chainScore = val_91;
            val_81 = "Score2";
            UnityEngine.PlayerPrefs.SetInt(key:  "Score2", value:  TargetBallVs.scoreCounter + (UnityEngine.PlayerPrefs.GetInt(key:  "Score2")));
            val_88 = this.<>4__this.destroyLag;
            UnityEngine.WaitForSeconds val_42 = null;
            float val_92 = 0.5f;
            val_92 = val_88 * val_92;
            val_42 = new UnityEngine.WaitForSeconds(seconds:  val_92);
            val_83 = 1;
            this.<>2__current = val_42;
            this.<>1__state = val_83;
            return (bool)val_83;
        }
        
        }
        
        this.<upperFlag>5__2 = false;
        label_10:
        if(X23 != 0)
        {
                if((this.outerRingBalls[(long)17 - X23]) != 0)
        {
                if(((System.String.op_Equality(a:  this.outerRingBalls[(long)17 - X23].gameObject.tag, b:  this.<>4__this.gameObject.tag)) != false) && ((this.<lowerFlag>5__3) != false))
        {
                if(X23 == 8)
        {
                mem2[0] = 1;
        }
        
            UnityEngine.AudioSource val_52 = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.popClip[0], volume:  1f);
            UnityEngine.Vector3 val_56 = this.outerRingBalls[(long)17 - X23].gameObject.transform.position;
            UnityEngine.Quaternion val_57 = UnityEngine.Quaternion.identity;
            val_86 = val_57.y;
            UnityEngine.GameObject val_58 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.popAnimation, position:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z}, rotation:  new UnityEngine.Quaternion() {x = val_57.x, y = val_86, z = val_57.z, w = val_57.w});
            val_85 = (long)17 - X23;
            UnityEngine.Vector3 val_62 = this.outerRingBalls[val_85].gameObject.transform.position;
            UnityEngine.Quaternion val_63 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_64 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_62.x, y = val_62.y, z = val_62.z}, rotation:  new UnityEngine.Quaternion() {x = val_63.x, y = val_63.y, z = val_63.z, w = val_63.w});
            this.<>4__this.popText = val_64;
            val_64.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
            UnityEngine.Vector3 val_72 = this.outerRingBalls[(long)17 - X23].gameObject.transform.position;
            val_87 = val_72.z;
            this.<>4__this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_72.x, y = val_72.y, z = val_87};
            popScoreScript val_73 = this.<>4__this.popText.GetComponent<popScoreScript>();
            val_73.scoreCounter = TargetBallVs.scoreCounter;
            val_82 = (long)17 - X23;
            UnityEngine.Object.Destroy(obj:  this.outerRingBalls[val_82].gameObject);
            mem2[0] = this.outerRingBalls[val_82][1];
            int val_100 = TargetBallVs.scoreCounter;
            val_100 = val_100 + (this.<>4__this.chainScore);
            this.<>4__this.chainScore = val_100;
            val_81 = "Score2";
            UnityEngine.PlayerPrefs.SetInt(key:  "Score2", value:  TargetBallVs.scoreCounter + (UnityEngine.PlayerPrefs.GetInt(key:  "Score2")));
            val_88 = this.<>4__this.destroyLag;
            UnityEngine.WaitForSeconds val_78 = null;
            float val_101 = 0.5f;
            val_101 = val_88 * val_101;
            val_78 = new UnityEngine.WaitForSeconds(seconds:  val_101);
            this.<>2__current = val_78;
            this.<>1__state = 2;
            val_83 = 1;
            return (bool)val_83;
        }
        
        }
        
        }
        
        this.<lowerFlag>5__3 = false;
        label_9:
        val_81 = X23 - 1;
        mem2[0] = val_81;
        if((val_81 & 2147483648) != 0)
        {
            goto label_137;
        }
        
        label_7:
        if(((this.<upperFlag>5__2) == true) || ((this.<lowerFlag>5__3) == true))
        {
            goto label_139;
        }
        
        label_137:
        label_140:
        val_83 = 0;
        this.<>4__this.isOuterBridgeRunning = false;
        return (bool)val_83;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
