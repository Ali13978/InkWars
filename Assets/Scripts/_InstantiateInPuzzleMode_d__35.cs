using UnityEngine;
private sealed class BallSwipeVs.<InstantiateInPuzzleMode>d__35 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public BallSwipeVs <>4__this;
    private int <counter>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BallSwipeVs.<InstantiateInPuzzleMode>d__35(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_36;
        int val_37;
        System.String[] val_38;
        var val_39;
        var val_40;
        string val_41;
        UnityEngine.Sprite val_42;
        UnityEngine.Sprite val_43;
        var val_44;
        System.String[] val_45;
        System.String[] val_46;
        var val_47;
        var val_48;
        var val_49;
        val_36 = this;
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
        val_37 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  2f);
        this.<>1__state = val_37;
        return (bool)val_37;
        label_1:
        this.<>1__state = 0;
        val_38 = 1152921505075376128;
        val_39 = 0;
        this.<>4__this.uniqueColorCounter = 0;
        goto label_6;
        label_42:
        var val_36 = this.<>4__this + 128;
        val_36 = val_36 + 1;
        mem2[0] = val_36;
        val_40 = null;
        val_40 = null;
        System.String[] val_2 = InstanceAnimator.presentColors + ((X22) << 3);
        this.<>4__this.ballTagColor = (InstanceAnimator.presentColors + (X22) << 3) + 32;
        val_41 = "Blue";
        if((System.String.op_Equality(a:  (InstanceAnimator.presentColors + (X22) << 3) + 32, b:  "B")) == true)
        {
            goto label_15;
        }
        
        val_41 = "Green";
        if((System.String.op_Equality(a:  (InstanceAnimator.presentColors + (X22) << 3) + 32, b:  "G")) == true)
        {
            goto label_15;
        }
        
        val_41 = "Red";
        if((System.String.op_Equality(a:  (InstanceAnimator.presentColors + (X22) << 3) + 32, b:  "R")) == true)
        {
            goto label_15;
        }
        
        val_41 = "Yellow";
        if((System.String.op_Equality(a:  (InstanceAnimator.presentColors + (X22) << 3) + 32, b:  "Y")) == true)
        {
            goto label_15;
        }
        
        val_41 = "Orange";
        if((System.String.op_Equality(a:  (InstanceAnimator.presentColors + (X22) << 3) + 32, b:  "O")) == true)
        {
            goto label_15;
        }
        
        val_41 = "Purple";
        if((System.String.op_Equality(a:  (InstanceAnimator.presentColors + (X22) << 3) + 32, b:  "P")) == false)
        {
            goto label_16;
        }
        
        label_15:
        this.<>4__this.ballTag = val_41;
        label_16:
        System.Type val_38 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_13 = UnityEngine.Resources.Load(path:  this.<>4__this.ballTagColor, systemTypeInstance:  val_38);
        if(val_13 != null)
        {
                val_38 = (null == null) ? (val_13) : 0;
        }
        else
        {
                val_42 = 0;
        }
        
        this.<>4__this.puzzleBalls[(long)0 + (this.<counter>5__2)].gameObject.GetComponent<UnityEngine.UI.Image>().sprite = val_42;
        UnityEngine.UI.Image val_16 = this.<>4__this.puzzleBallImages[(long)0 + (this.<counter>5__2)].gameObject.GetComponent<UnityEngine.UI.Image>();
        System.Type val_40 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_18 = UnityEngine.Resources.Load(path:  this.<>4__this.ballTagColor, systemTypeInstance:  val_40);
        if(val_16 == null)
        {
            goto label_30;
        }
        
        if(val_18 == null)
        {
            goto label_31;
        }
        
        label_33:
        val_40 = (null == null) ? (val_18) : 0;
        goto label_32;
        label_30:
        if(val_18 != null)
        {
            goto label_33;
        }
        
        label_31:
        val_43 = 0;
        label_32:
        val_16.sprite = val_43;
        this.<>4__this.puzzleBalls[(long)0 + (this.<counter>5__2)].gameObject.tag = this.<>4__this.ballTag;
        val_39 = 1;
        label_6:
        val_44 = null;
        val_44 = null;
        val_45 = InstanceAnimator.presentColors;
        if((InstanceAnimator.presentColors.Length + 32) != 0)
        {
            goto label_42;
        }
        
        this.<>4__this.puzzleBallHolder.gameObject.GetComponent<UnityEngine.Animator>().enabled = true;
        this.<>4__this.puzzleBallHolder.gameObject.GetComponent<UnityEngine.Animator>().Play(stateName:  this.<>4__this + 128.ToString()(this.<>4__this + 128.ToString()) + "Balls", layer:  0, normalizedTime:  0f);
        val_46 = (long)(this.<>4__this.uniqueColorCounter) - 1;
        val_36 = this.<>4__this.puzzleBalls[val_46].gameObject.GetComponent<UnityEngine.UI.Toggle>();
        val_36.isOn = true;
        this.<>4__this.OnToggleClick(i:  (this.<>4__this.uniqueColorCounter) - 1);
        label_3:
        val_37 = 0;
        return (bool)val_37;
        label_2:
        this.<>1__state = 0;
        string[] val_31 = new string[6];
        val_31[0] = "R";
        val_31[1] = "B";
        val_31[2] = "Y";
        val_31[3] = "P";
        val_31[4] = "G";
        val_31[5] = "O";
        this.<counter>5__2 = 0;
        label_102:
        val_39 = 0;
        goto label_74;
        label_86:
        val_39 = 1;
        label_74:
        val_47 = null;
        val_47 = null;
        val_46 = InstanceAnimator.presentColors;
        if((InstanceAnimator.presentColors.Length + 32) == 0)
        {
            goto label_79;
        }
        
        val_48 = null;
        val_48 = null;
        if((System.String.op_Equality(a:  1152921505168370512, b:  InstanceAnimator.presentColors.Length + 32)) == false)
        {
            goto label_86;
        }
        
        val_49 = null;
        val_49 = null;
        System.String[] val_33 = InstanceAnimator.presentColors + ((this.<counter>5__2) << 3);
        val_46 = mem[(InstanceAnimator.presentColors + (this.<counter>5__2) << 3) + 32];
        val_46 = (InstanceAnimator.presentColors + (this.<counter>5__2) << 3) + 32;
        val_38 = InstanceAnimator.presentColors;
        System.String[] val_34 = val_38 + ((this.<counter>5__2) << 3);
        (InstanceAnimator.presentColors + (this.<counter>5__2) << 3).__unknownFiledOffset_20 = InstanceAnimator.presentColors.Length + 32;
        if(InstanceAnimator.presentColors == null)
        {
            goto label_96;
        }
        
        if(val_46 != 0)
        {
            goto label_97;
        }
        
        goto label_100;
        label_96:
        if(val_46 == 0)
        {
            goto label_100;
        }
        
        label_97:
        label_100:
        mem2[0] = val_46;
        int val_43 = this.<counter>5__2;
        val_43 = val_43 + 1;
        this.<counter>5__2 = val_43;
        label_79:
        val_45 = 0 + 1;
        if(val_45 != 6)
        {
            goto label_102;
        }
        
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0f);
        this.<>1__state = 2;
        val_37 = 1;
        return (bool)val_37;
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
