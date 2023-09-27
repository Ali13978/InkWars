using UnityEngine;
private sealed class LineControllerAI.<PostAttackSequence>d__68 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineControllerAI <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerAI.<PostAttackSequence>d__68(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        LineControllerAI val_7;
        CharacterClan val_8;
        CharacterClan val_9;
        int val_10;
        System.Single[] val_11;
        int val_12;
        val_7 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        if((this.<>4__this.modeName) != 4)
        {
            goto label_4;
        }
        
        val_8 = this.<>4__this.characterType;
        goto label_5;
        label_1:
        this.<>1__state = 0;
        if(val_7 != null)
        {
            goto label_7;
        }
        
        goto label_7;
        label_3:
        if(48980544 != 4)
        {
            goto label_8;
        }
        
        val_8 = 48980544;
        label_5:
        if(val_8 == 0)
        {
            goto label_9;
        }
        
        val_9 = 1;
        val_10 = this.<>4__this.stageNumber;
        goto label_12;
        label_4:
        val_11 = this.<>4__this.characterSpeedInSecondsStageWise;
        goto label_13;
        label_8:
        val_11 = 65536;
        label_13:
        var val_1 = val_11 + ((this.<>4__this.stageNumber) << 2);
        float val_7 = (val_11 + (this.<>4__this.stageNumber) << 2) + 32;
        val_7 = val_7 + (-0.4f);
        goto label_16;
        label_9:
        val_10 = this.<>4__this.stageNumber;
        val_9 = 0;
        label_12:
        label_16:
        this.<>4__this.reloadTime = CharacterHelper.GetAttackSpeed(cid:  CharacterHelper.GetStageCPUCharacterId(levelId0to11:  val_10, CPUClan:  val_9));
        label_7:
        if((this.<>4__this.animController.attackAnimEnded) == false)
        {
            goto label_20;
        }
        
        this.<>4__this.animController.attackAnimEnded = false;
        if((this.<>4__this.modeName) != 3)
        {
                this.<>4__this.shake = this.<>4__this.reloadTime;
            this.<>4__this.animController.pause = true;
            val_7.InvokeRepeating(methodName:  "ShakeSequenceAnimationCPU", time:  0f, repeatRate:  0.02f);
        }
        
        UnityEngine.Coroutine val_5 = val_7.StartCoroutine(routine:  val_7.FinishAttack());
        label_2:
        val_12 = 0;
        return (bool)val_12;
        label_20:
        float val_8 = this.<>4__this.reloadTime;
        val_8 = val_8 + (-0.02f);
        this.<>4__this.reloadTime = val_8;
        UnityEngine.WaitForSeconds val_6 = null;
        val_7 = val_6;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  0.02f);
        val_12 = 1;
        this.<>2__current = val_7;
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
