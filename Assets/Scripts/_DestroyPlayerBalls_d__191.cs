using UnityEngine;
private sealed class LineController.<DestroyPlayerBalls>d__191 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.GameObject[] ringArray;
    public bool isForTimeOver;
    public int length;
    public LineController <>4__this;
    public bool ifWin;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineController.<DestroyPlayerBalls>d__191(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_39;
        var val_40;
        int val_41;
        int val_42;
        var val_43;
        float val_44;
        float val_45;
        float val_46;
        var val_47;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_17;
        }
        
        this.<>1__state = 0;
        TargetBallScript.scoreCounter = 200;
        if(this.length >= 1)
        {
                val_39 = 1152921526116444176;
            do
        {
            val_40 = 0;
            if((this.ringArray[val_40] != 0) && (this.isForTimeOver != true))
        {
                this.ringArray[val_40].gameObject.GetComponent<InkingSequenceBubbleAnim>().DestroyAnim(winnerScore:  "Score");
        }
        
            val_41 = 0 + 1;
        }
        while(val_41 < this.length);
        
        }
        
        val_42 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_42;
        return (bool)val_42;
        label_1:
        this.<>1__state = 0;
        if(this.length < 1)
        {
            goto label_17;
        }
        
        val_40 = 1152921525089773456;
        label_85:
        if(this.ringArray[0] == 0)
        {
            goto label_22;
        }
        
        if(((this.<>4__this.modeName) == 3) || (this.isForTimeOver == true))
        {
            goto label_54;
        }
        
        if((this.<>4__this.modeName) != 5)
        {
            goto label_29;
        }
        
        val_43 = null;
        val_43 = null;
        if(LineControllerP2.player2Win == false)
        {
            goto label_29;
        }
        
        UnityEngine.Vector3 val_9 = this.ringArray[0].gameObject.gameObject.transform.position;
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
        val_44 = val_10.y;
        UnityEngine.GameObject val_11 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, rotation:  new UnityEngine.Quaternion() {x = val_10.x, y = val_44, z = val_10.z, w = val_10.w});
        this.<>4__this.popText = val_11;
        val_11.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
        UnityEngine.Vector3 val_19 = this.ringArray[0].gameObject.gameObject.transform.position;
        val_45 = val_19.x;
        val_46 = val_19.z;
        this.<>4__this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_45, y = val_19.y, z = val_46};
        popScoreScript val_20 = this.<>4__this.popText.GetComponent<popScoreScript>();
        val_41 = TargetBallScript.scoreCounter;
        val_20.scoreCounter = val_41;
        UnityEngine.PlayerPrefs.SetInt(key:  "Score2", value:  TargetBallScript.scoreCounter + (UnityEngine.PlayerPrefs.GetInt(key:  "Score2")));
        goto label_54;
        label_29:
        if(this.ifWin != false)
        {
                UnityEngine.Vector3 val_26 = this.ringArray[0].gameObject.gameObject.transform.position;
            UnityEngine.Quaternion val_27 = UnityEngine.Quaternion.identity;
            val_44 = val_27.y;
            UnityEngine.GameObject val_28 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, rotation:  new UnityEngine.Quaternion() {x = val_27.x, y = val_44, z = val_27.z, w = val_27.w});
            this.<>4__this.popText = val_28;
            val_28.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
            UnityEngine.Vector3 val_36 = this.ringArray[0].gameObject.gameObject.transform.position;
            val_45 = val_36.x;
            val_46 = val_36.z;
            this.<>4__this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_45, y = val_36.y, z = val_46};
            popScoreScript val_37 = this.<>4__this.popText.GetComponent<popScoreScript>();
            val_41 = TargetBallScript.scoreCounter;
            val_37.scoreCounter = val_41;
            val_47 = null;
            val_47 = null;
            int val_46 = TargetBallScript.scoreCounter;
            val_46 = val_46 + LineController.userScore;
            LineController.userScore = val_46;
        }
        
        label_54:
        UnityEngine.Object.Destroy(obj:  this.ringArray[0].gameObject);
        label_22:
        val_39 = 0 + 1;
        if(val_39 < this.length)
        {
            goto label_85;
        }
        
        label_17:
        val_42 = 0;
        return (bool)val_42;
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
