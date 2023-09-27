using UnityEngine;
private sealed class TargetBallVs.<BridgeThroughMiddleRing>d__30 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TargetBallVs <>4__this;
    public UnityEngine.GameObject[] middleRingBalls;
    public int incrementCounter;
    private bool <upperFlag>5__2;
    private bool <lowerFlag>5__3;
    private int <j>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TargetBallVs.<BridgeThroughMiddleRing>d__30(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_82;
        int val_83;
        int val_84;
        int val_85;
        string val_86;
        var val_87;
        float val_88;
        float val_89;
        float val_90;
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
        val_82 = null;
        val_82 = null;
        int val_81 = LineController.BridgeStunP1;
        val_81 = val_81 + 1;
        LineController.BridgeStunP1 = val_81;
        this.<upperFlag>5__2 = true;
        this.<lowerFlag>5__3 = true;
        val_83 = 6;
        val_84 = this;
        this.<>4__this.isMiddleBridgeRunning = true;
        this.<j>5__4 = val_83;
        if((val_83 & 2147483648) == 0)
        {
            goto label_7;
        }
        
        goto label_137;
        label_1:
        this.<>1__state = 0;
        val_84 = this.<j>5__4;
        int val_82 = this.incrementCounter;
        val_82 = val_82 + TargetBallVs.scoreCounter;
        TargetBallVs.scoreCounter = val_82;
        goto label_9;
        label_2:
        this.<>1__state = 0;
        val_84 = this.<j>5__4;
        int val_83 = this.incrementCounter;
        val_83 = val_83 + TargetBallVs.scoreCounter;
        TargetBallVs.scoreCounter = val_83;
        goto label_10;
        label_3:
        val_85 = 0;
        return (bool)val_85;
        label_139:
        val_86 = this.<>4__this.popBallTag;
        TargetBallVs.popTag = val_86 + "Extended";
        val_87 = 1152921504858337280;
        val_83 = this.middleRingBalls[X23];
        if(val_83 == 0)
        {
            goto label_18;
        }
        
        val_83 = this.middleRingBalls[X23].gameObject.tag;
        if((System.String.op_Equality(a:  val_83, b:  this.<>4__this.gameObject.tag)) == true)
        {
            goto label_24;
        }
        
        label_18:
        if(X23 == 0)
        {
            goto label_140;
        }
        
        val_83 = this.middleRingBalls[(long)13 - X23];
        if(val_83 == 0)
        {
            goto label_140;
        }
        
        val_83 = this.middleRingBalls[(long)13 - X23].gameObject.tag;
        if((System.String.op_Equality(a:  val_83, b:  this.<>4__this.gameObject.tag)) == false)
        {
            goto label_140;
        }
        
        label_24:
        if(this.middleRingBalls[X23] != 0)
        {
                if(((System.String.op_Equality(a:  this.middleRingBalls[X23].gameObject.tag, b:  this.<>4__this.gameObject.tag)) != false) && ((this.<upperFlag>5__2) != false))
        {
                if(X23 == 5)
        {
                mem2[0] = 1;
        }
        
            UnityEngine.AudioSource val_23 = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.popClip[0], volume:  1f);
            UnityEngine.Vector3 val_26 = this.middleRingBalls[X23].gameObject.transform.position;
            UnityEngine.Quaternion val_27 = UnityEngine.Quaternion.identity;
            val_88 = val_27.y;
            UnityEngine.GameObject val_28 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.popAnimation, position:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, rotation:  new UnityEngine.Quaternion() {x = val_27.x, y = val_88, z = val_27.z, w = val_27.w});
            UnityEngine.Vector3 val_31 = this.middleRingBalls[X23].gameObject.transform.position;
            UnityEngine.Quaternion val_32 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_33 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, rotation:  new UnityEngine.Quaternion() {x = val_32.x, y = val_32.y, z = val_32.z, w = val_32.w});
            this.<>4__this.popText = val_33;
            val_33.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
            val_87 = mem[X23];
            val_87 = X23;
            UnityEngine.Vector3 val_40 = this.middleRingBalls[val_87].gameObject.transform.position;
            val_89 = val_40.z;
            this.<>4__this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_89};
            popScoreScript val_41 = this.<>4__this.popText.GetComponent<popScoreScript>();
            val_41.scoreCounter = TargetBallVs.scoreCounter;
            UnityEngine.Object.Destroy(obj:  this.middleRingBalls[X23].gameObject);
            mem2[0] = this.middleRingBalls[X23][1];
            int val_93 = TargetBallVs.scoreCounter;
            val_93 = val_93 + (this.<>4__this.chainScore);
            this.<>4__this.chainScore = val_93;
            val_83 = "Score2";
            UnityEngine.PlayerPrefs.SetInt(key:  "Score2", value:  TargetBallVs.scoreCounter + (UnityEngine.PlayerPrefs.GetInt(key:  "Score2")));
            val_90 = this.<>4__this.destroyLag;
            UnityEngine.WaitForSeconds val_45 = null;
            float val_94 = 0.5f;
            val_94 = val_90 * val_94;
            val_45 = new UnityEngine.WaitForSeconds(seconds:  val_94);
            val_85 = 1;
            this.<>2__current = val_45;
            this.<>1__state = val_85;
            return (bool)val_85;
        }
        
        }
        
        this.<upperFlag>5__2 = false;
        label_10:
        if(X23 != 0)
        {
                if((this.middleRingBalls[(long)13 - X23]) != 0)
        {
                if(((this.middleRingBalls[(long)13 - X23].gameObject.CompareTag(tag:  this.<>4__this.gameObject.tag)) != false) && ((this.<lowerFlag>5__3) != false))
        {
                if(X23 == 6)
        {
                mem2[0] = 1;
        }
        
            UnityEngine.AudioSource val_54 = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.popClip[0], volume:  1f);
            UnityEngine.Vector3 val_58 = this.middleRingBalls[(long)13 - X23].gameObject.transform.position;
            UnityEngine.Quaternion val_59 = UnityEngine.Quaternion.identity;
            val_88 = val_59.y;
            UnityEngine.GameObject val_60 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.popAnimation, position:  new UnityEngine.Vector3() {x = val_58.x, y = val_58.y, z = val_58.z}, rotation:  new UnityEngine.Quaternion() {x = val_59.x, y = val_88, z = val_59.z, w = val_59.w});
            val_87 = (long)13 - X23;
            UnityEngine.Vector3 val_64 = this.middleRingBalls[val_87].gameObject.transform.position;
            UnityEngine.Quaternion val_65 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_66 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_64.x, y = val_64.y, z = val_64.z}, rotation:  new UnityEngine.Quaternion() {x = val_65.x, y = val_65.y, z = val_65.z, w = val_65.w});
            this.<>4__this.popText = val_66;
            val_66.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
            UnityEngine.Vector3 val_74 = this.middleRingBalls[(long)13 - X23].gameObject.transform.position;
            val_89 = val_74.z;
            this.<>4__this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_74.x, y = val_74.y, z = val_89};
            popScoreScript val_75 = this.<>4__this.popText.GetComponent<popScoreScript>();
            val_75.scoreCounter = TargetBallVs.scoreCounter;
            val_84 = (long)13 - X23;
            UnityEngine.Object.Destroy(obj:  this.middleRingBalls[val_84].gameObject);
            mem2[0] = this.middleRingBalls[val_84][1];
            int val_102 = TargetBallVs.scoreCounter;
            val_102 = val_102 + (this.<>4__this.chainScore);
            this.<>4__this.chainScore = val_102;
            val_83 = "Score2";
            UnityEngine.PlayerPrefs.SetInt(key:  "Score2", value:  TargetBallVs.scoreCounter + (UnityEngine.PlayerPrefs.GetInt(key:  "Score2")));
            val_90 = this.<>4__this.destroyLag;
            UnityEngine.WaitForSeconds val_80 = null;
            float val_103 = 0.5f;
            val_103 = val_90 * val_103;
            val_80 = new UnityEngine.WaitForSeconds(seconds:  val_103);
            this.<>2__current = val_80;
            this.<>1__state = 2;
            val_85 = 1;
            return (bool)val_85;
        }
        
        }
        
        }
        
        this.<lowerFlag>5__3 = false;
        label_9:
        val_83 = X23 - 1;
        mem2[0] = val_83;
        if((val_83 & 2147483648) != 0)
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
        val_85 = 0;
        this.<>4__this.isMiddleBridgeRunning = false;
        return (bool)val_85;
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
