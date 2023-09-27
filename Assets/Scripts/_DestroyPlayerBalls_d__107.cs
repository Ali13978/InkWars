using UnityEngine;
private sealed class LineControllerP2.<DestroyPlayerBalls>d__107 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.GameObject[] ringArray;
    public int length;
    public LineControllerP2 <>4__this;
    public bool ifWin;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerP2.<DestroyPlayerBalls>d__107(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_26;
        var val_27;
        UnityEngine.AudioClip val_28;
        int val_29;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_22;
        }
        
        this.<>1__state = 0;
        TargetBallVs.scoreCounter = 200;
        if(this.length >= 1)
        {
                val_26 = 1152921526116444176;
            do
        {
            val_27 = 0;
            if(this.ringArray[val_27] != 0)
        {
                this.ringArray[val_27].gameObject.GetComponent<InkingSequenceBubbleAnim>().DestroyAnim(winnerScore:  "Score2");
        }
        
            val_28 = 0 + 1;
        }
        while(val_28 < this.length);
        
        }
        
        val_29 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_29;
        return (bool)val_29;
        label_1:
        this.<>1__state = 0;
        val_28 = this.<>4__this.popClip[5];
        UnityEngine.AudioSource val_6 = GameAudio.sound.PlayOneShot(clip:  val_28, volume:  1f);
        if(this.length >= 1)
        {
                val_27 = 1152921526267734816;
            do
        {
            if(this.ringArray[0] != 0)
        {
                if(((this.<>4__this.modeName) != 3) && (this.ifWin != false))
        {
                UnityEngine.Vector3 val_11 = this.ringArray[0].gameObject.gameObject.transform.position;
            UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_13 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, rotation:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w});
            this.<>4__this.popText = val_13;
            val_13.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
            UnityEngine.Vector3 val_21 = this.ringArray[0].gameObject.gameObject.transform.position;
            this.<>4__this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
            popScoreScript val_22 = this.<>4__this.popText.GetComponent<popScoreScript>();
            val_28 = TargetBallVs.scoreCounter;
            val_22.scoreCounter = val_28;
            UnityEngine.PlayerPrefs.SetInt(key:  "Score2", value:  TargetBallVs.scoreCounter + (UnityEngine.PlayerPrefs.GetInt(key:  "Score2")));
        }
        
            UnityEngine.Object.Destroy(obj:  this.ringArray[0].gameObject);
        }
        
            val_26 = 0 + 1;
        }
        while(val_26 < this.length);
        
        }
        
        label_22:
        val_29 = 0;
        return (bool)val_29;
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
