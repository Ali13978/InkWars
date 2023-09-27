using UnityEngine;
private sealed class TargetBallVs.<BridgeThroughInnerRing>d__31 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TargetBallVs <>4__this;
    public UnityEngine.GameObject[] innerRingBalls;
    public int incrementCounter;
    private bool <upperFlag>5__2;
    private bool <lowerFlag>5__3;
    private int <j>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TargetBallVs.<BridgeThroughInnerRing>d__31(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_79;
        int val_80;
        int val_81;
        int val_82;
        string val_83;
        var val_84;
        float val_85;
        float val_86;
        float val_87;
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
        val_79 = null;
        val_79 = null;
        int val_78 = LineController.BridgeStunP1;
        val_78 = val_78 + 1;
        LineController.BridgeStunP1 = val_78;
        this.<upperFlag>5__2 = true;
        this.<lowerFlag>5__3 = true;
        val_80 = 4;
        val_81 = this;
        this.<>4__this.isInnerBridgeRunning = true;
        this.<j>5__4 = val_80;
        if((val_80 & 2147483648) == 0)
        {
            goto label_7;
        }
        
        goto label_137;
        label_1:
        this.<>1__state = 0;
        val_81 = this.<j>5__4;
        int val_79 = this.incrementCounter;
        val_79 = val_79 + TargetBallVs.scoreCounter;
        TargetBallVs.scoreCounter = val_79;
        goto label_9;
        label_2:
        this.<>1__state = 0;
        val_81 = this.<j>5__4;
        int val_80 = this.incrementCounter;
        val_80 = val_80 + TargetBallVs.scoreCounter;
        TargetBallVs.scoreCounter = val_80;
        goto label_10;
        label_3:
        val_82 = 0;
        return (bool)val_82;
        label_139:
        val_83 = this.<>4__this.popBallTag;
        TargetBallVs.popTag = val_83 + "Extended";
        val_84 = 1152921504858337280;
        val_80 = this.innerRingBalls[X23];
        if(val_80 == 0)
        {
            goto label_18;
        }
        
        val_80 = this.innerRingBalls[X23].gameObject;
        if((val_80.CompareTag(tag:  this.<>4__this.gameObject.tag)) == true)
        {
            goto label_24;
        }
        
        label_18:
        if(X23 == 0)
        {
            goto label_140;
        }
        
        val_80 = this.innerRingBalls[(long)9 - X23];
        if(val_80 == 0)
        {
            goto label_140;
        }
        
        val_80 = this.innerRingBalls[(long)9 - X23].gameObject;
        if((val_80.CompareTag(tag:  this.<>4__this.gameObject.tag)) == false)
        {
            goto label_140;
        }
        
        label_24:
        if(this.innerRingBalls[X23] != 0)
        {
                if(((this.innerRingBalls[X23].gameObject.CompareTag(tag:  this.<>4__this.gameObject.tag)) != false) && ((this.<upperFlag>5__2) != false))
        {
                if(X23 == 3)
        {
                mem2[0] = 1;
        }
        
            UnityEngine.AudioSource val_20 = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.popClip[0], volume:  1f);
            UnityEngine.Vector3 val_23 = this.innerRingBalls[X23].gameObject.transform.position;
            UnityEngine.Quaternion val_24 = UnityEngine.Quaternion.identity;
            val_85 = val_24.y;
            UnityEngine.GameObject val_25 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.popAnimation, position:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, rotation:  new UnityEngine.Quaternion() {x = val_24.x, y = val_85, z = val_24.z, w = val_24.w});
            UnityEngine.Vector3 val_28 = this.innerRingBalls[X23].gameObject.transform.position;
            UnityEngine.Quaternion val_29 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_30 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, rotation:  new UnityEngine.Quaternion() {x = val_29.x, y = val_29.y, z = val_29.z, w = val_29.w});
            this.<>4__this.popText = val_30;
            val_30.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
            val_84 = mem[X23];
            val_84 = X23;
            UnityEngine.Vector3 val_37 = this.innerRingBalls[val_84].gameObject.transform.position;
            val_86 = val_37.z;
            this.<>4__this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_86};
            popScoreScript val_38 = this.<>4__this.popText.GetComponent<popScoreScript>();
            val_38.scoreCounter = TargetBallVs.scoreCounter;
            UnityEngine.Object.Destroy(obj:  this.innerRingBalls[X23].gameObject);
            mem2[0] = this.innerRingBalls[X23][1];
            int val_90 = TargetBallVs.scoreCounter;
            val_90 = val_90 + (this.<>4__this.chainScore);
            this.<>4__this.chainScore = val_90;
            val_80 = "Score2";
            UnityEngine.PlayerPrefs.SetInt(key:  "Score2", value:  TargetBallVs.scoreCounter + (UnityEngine.PlayerPrefs.GetInt(key:  "Score2")));
            val_87 = this.<>4__this.destroyLag;
            UnityEngine.WaitForSeconds val_42 = null;
            float val_91 = 0.5f;
            val_91 = val_87 * val_91;
            val_42 = new UnityEngine.WaitForSeconds(seconds:  val_91);
            val_82 = 1;
            this.<>2__current = val_42;
            this.<>1__state = val_82;
            return (bool)val_82;
        }
        
        }
        
        this.<upperFlag>5__2 = false;
        label_10:
        if(X23 != 0)
        {
                if((this.innerRingBalls[(long)9 - X23]) != 0)
        {
                if(((this.innerRingBalls[(long)9 - X23].gameObject.CompareTag(tag:  this.<>4__this.gameObject.tag)) != false) && ((this.<lowerFlag>5__3) != false))
        {
                if(X23 == 2)
        {
                mem2[0] = 1;
        }
        
            UnityEngine.AudioSource val_51 = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.popClip[0], volume:  1f);
            UnityEngine.Vector3 val_55 = this.innerRingBalls[(long)9 - X23].gameObject.transform.position;
            UnityEngine.Quaternion val_56 = UnityEngine.Quaternion.identity;
            val_85 = val_56.y;
            UnityEngine.GameObject val_57 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.popAnimation, position:  new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z}, rotation:  new UnityEngine.Quaternion() {x = val_56.x, y = val_85, z = val_56.z, w = val_56.w});
            val_84 = (long)9 - X23;
            UnityEngine.Vector3 val_61 = this.innerRingBalls[val_84].gameObject.transform.position;
            UnityEngine.Quaternion val_62 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_63 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z}, rotation:  new UnityEngine.Quaternion() {x = val_62.x, y = val_62.y, z = val_62.z, w = val_62.w});
            this.<>4__this.popText = val_63;
            val_63.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
            UnityEngine.Vector3 val_71 = this.innerRingBalls[(long)9 - X23].gameObject.transform.position;
            val_86 = val_71.z;
            this.<>4__this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_71.x, y = val_71.y, z = val_86};
            popScoreScript val_72 = this.<>4__this.popText.GetComponent<popScoreScript>();
            val_72.scoreCounter = TargetBallVs.scoreCounter;
            val_81 = (long)9 - X23;
            UnityEngine.Object.Destroy(obj:  this.innerRingBalls[val_81].gameObject);
            mem2[0] = this.innerRingBalls[val_81][1];
            int val_99 = TargetBallVs.scoreCounter;
            val_99 = val_99 + (this.<>4__this.chainScore);
            this.<>4__this.chainScore = val_99;
            val_80 = "Score2";
            UnityEngine.PlayerPrefs.SetInt(key:  "Score2", value:  TargetBallVs.scoreCounter + (UnityEngine.PlayerPrefs.GetInt(key:  "Score2")));
            val_87 = this.<>4__this.destroyLag;
            UnityEngine.WaitForSeconds val_77 = null;
            float val_100 = 0.5f;
            val_100 = val_87 * val_100;
            val_77 = new UnityEngine.WaitForSeconds(seconds:  val_100);
            this.<>2__current = val_77;
            this.<>1__state = 2;
            val_82 = 1;
            return (bool)val_82;
        }
        
        }
        
        }
        
        this.<lowerFlag>5__3 = false;
        label_9:
        val_80 = X23 - 1;
        mem2[0] = val_80;
        if((val_80 & 2147483648) != 0)
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
        val_82 = 0;
        this.<>4__this.isInnerBridgeRunning = false;
        return (bool)val_82;
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
