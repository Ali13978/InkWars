using UnityEngine;
private sealed class LineController.<PostAttackSequence>d__208 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineController.<PostAttackSequence>d__208(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        CharacterNameID val_2;
        object val_6;
        LineController val_11;
        int val_12;
        val_11 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
        float val_11 = 0.2f;
        val_11 = (CharacterHelper.GetAttackSpeed(cid:  val_2)) + val_11;
        this.<>4__this.reloadTime = val_11;
        goto label_9;
        label_1:
        this.<>1__state = 0;
        label_9:
        if((this.<>4__this.animController.attackAnimEnded) == false)
        {
            goto label_11;
        }
        
        this.<>4__this.animController.attackAnimEnded = false;
        if((this.<>4__this.modeName) != 3)
        {
                UnityEngine.Debug.Log(message:  "Player1Reload = "("Player1Reload = ") + this.<>4__this.reloadTime(this.<>4__this.reloadTime));
            CharacterInfo val_5 = Character_GlobalInfo.GetMainPlayer();
            UnityEngine.Debug.Log(message:  "Player1 = "("Player1 = ") + val_6);
            mem2[0] = this.<>4__this.characterPos;
            mem2[0] = 1152921504621490176;
            this.<>4__this.shake = this.<>4__this.reloadTime;
            this.<>4__this.animController.pause = true;
            val_11.InvokeRepeating(methodName:  "ShakeSequenceAnimationPlayer", time:  0f, repeatRate:  0.02f);
        }
        
        UnityEngine.Coroutine val_9 = val_11.StartCoroutine(routine:  val_11.FinishAttack());
        label_2:
        val_12 = 0;
        return (bool)val_12;
        label_11:
        float val_12 = this.<>4__this.reloadTime;
        val_12 = val_12 + (-0.02f);
        this.<>4__this.reloadTime = val_12;
        UnityEngine.WaitForSeconds val_10 = null;
        val_11 = val_10;
        val_10 = new UnityEngine.WaitForSeconds(seconds:  0.02f);
        val_12 = 1;
        this.<>2__current = val_11;
        this.<>1__state = val_12;
        return (bool)val_12;
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
