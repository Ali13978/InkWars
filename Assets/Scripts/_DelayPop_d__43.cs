using UnityEngine;
private sealed class View_Bubble.<DelayPop>d__43 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View_Bubble <>4__this;
    public InkWars.Model.BubbleTypes type;
    private float <ViewPopDelay>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public View_Bubble.<DelayPop>d__43(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_15;
        InkWars.Model.Model_Bubble val_16;
        float val_17;
        int val_18;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        val_15 = this;
        this.<ViewPopDelay>5__2 = 0f;
        this.<>1__state = 0;
        if((this.<>4__this.modelBubble) == null)
        {
            goto label_6;
        }
        
        mem[1152921528336199356] = this.<>4__this.modelBubble.PopDelay;
        val_16 = this.<>4__this.modelBubble;
        int val_2 = val_16.Score;
        goto label_6;
        label_1:
        val_15 = this.<ViewPopDelay>5__2;
        this.<>1__state = 0;
        label_6:
        val_17 = mem[this.<ViewPopDelay>5__2];
        val_17 = val_15;
        if(val_17 > 0f)
        {
            goto label_7;
        }
        
        UnityEngine.AudioSource val_5 = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.popSounds.Get(aNewKey:  this.type), volume:  1f);
        val_16 = this.<>4__this.modelBubble.customPopType;
        this.<>4__this.CreatePopAnim(type:  this.type, customPopType:  val_16, sortingOrder:  this.<>4__this.spriteRenderer.sortingOrder);
        this.<>4__this.modelBubble.Trashed = false;
        if(((this.<>4__this._bubbleType) == 8) && ((this.<>4__this.modelBubble.m_isCrossBubbleHit) != true))
        {
                View_Objects val_9 = View_Core.Instance.GetOpponentViewObjectsByPlayerId_Flip(aNewPlayerId:  this.<>4__this.modelBubble.GetPlayerID());
            val_16 = val_9.CenterPoint;
            UnityEngine.Vector3 val_10 = val_16.position;
            val_17 = val_10.x;
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
            UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.template_PopAnim_StunEffect, position:  new UnityEngine.Vector3() {x = val_17, y = val_10.y, z = val_10.z}, rotation:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w}).GetComponent<UnityEngine.SpriteRenderer>().sortingOrder = 10;
        }
        
        this.<>4__this.CreateScorePopUp();
        this.<>4__this.ResetBubble();
        label_2:
        val_18 = 0;
        return (bool)val_18;
        label_7:
        float val_14 = UnityEngine.Time.deltaTime;
        val_14 = val_17 - val_14;
        val_18 = 1;
        mem2[0] = val_14;
        this.<>2__current = 0;
        this.<>1__state = val_18;
        return (bool)val_18;
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
