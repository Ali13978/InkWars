using UnityEngine;
private sealed class LineControllerP2.<PostAttackSequence>d__112 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineControllerP2 <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerP2.<PostAttackSequence>d__112(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        CharacterNameID val_2;
        LineControllerP2 val_8;
        int val_9;
        val_8 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        CharacterInfo val_1 = Character_GlobalInfo.GetOpponentPlayer();
        float val_8 = 0.2f;
        val_8 = (CharacterHelper.GetAttackSpeed(cid:  val_2)) + val_8;
        this.<>4__this.reloadTime = val_8;
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
                val_2 = this.<>4__this.reloadTime;
            UnityEngine.Debug.Log(message:  "Player2Reload = "("Player2Reload = ") + val_2);
            mem2[0] = this.<>4__this.characterPos;
            mem2[0] = UnityEngine.Debug.__il2cppRuntimeField_cctor_finished;
            this.<>4__this.shake = this.<>4__this.reloadTime;
            this.<>4__this.animController.pause = true;
            val_8.InvokeRepeating(methodName:  "ShakeSequenceAnimationPlayer", time:  0f, repeatRate:  0.02f);
        }
        
        UnityEngine.Coroutine val_6 = val_8.StartCoroutine(routine:  val_8.FinishAttack());
        label_2:
        val_9 = 0;
        return (bool)val_9;
        label_11:
        float val_9 = this.<>4__this.reloadTime;
        val_9 = val_9 + (-0.02f);
        this.<>4__this.reloadTime = val_9;
        UnityEngine.WaitForSeconds val_7 = null;
        val_8 = val_7;
        val_7 = new UnityEngine.WaitForSeconds(seconds:  0.02f);
        val_9 = 1;
        this.<>2__current = val_8;
        this.<>1__state = val_9;
        return (bool)val_9;
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
