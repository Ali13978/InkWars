using UnityEngine;
public class modeScaling : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject puzzle;
    public UnityEngine.GameObject vsCpu;
    public UnityEngine.GameObject futureCpu;
    public UnityEngine.GameObject vsCpuBoss;
    public UnityEngine.GameObject exBattleBoss;
    private int counterPong;
    
    // Methods
    private void Start()
    {
        object[] val_1 = new object[14];
        val_1[0] = "x";
        val_1[1] = 0.56;
        val_1[2] = "y";
        val_1[3] = 0.56;
        val_1[4] = "time";
        val_1[5] = 0.5;
        val_1[6] = "easetype";
        val_1[7] = 5;
        val_1[8] = "looptype";
        val_1[9] = 2;
        val_1[10] = "oncomplete";
        val_1[11] = "startCpu";
        val_1[12] = "oncompletetarget";
        val_1[13] = this.gameObject;
        iTween.ScaleTo(target:  this.puzzle, args:  iTween.Hash(args:  val_1));
        object[] val_4 = new object[14];
        val_4[0] = "x";
        val_4[1] = 0.56;
        val_4[2] = "y";
        val_4[3] = 0.56;
        val_4[4] = "time";
        val_4[5] = 0.5;
        val_4[6] = "easetype";
        val_4[7] = 5;
        val_4[8] = "looptype";
        val_4[9] = 2;
        val_4[10] = "oncomplete";
        val_4[11] = "startExBoss";
        val_4[12] = "oncompletetarget";
        val_4[13] = this.gameObject;
        iTween.ScaleTo(target:  this.vsCpuBoss, args:  iTween.Hash(args:  val_4));
    }
    private void startPuzzle()
    {
        int val_4 = this.counterPong;
        val_4 = val_4 + 1;
        this.counterPong = val_4;
        if((val_4 & 1) != 0)
        {
                return;
        }
        
        object[] val_1 = new object[14];
        val_1[0] = "x";
        val_1[1] = 0.56;
        val_1[2] = "y";
        val_1[3] = 0.56;
        val_1[4] = "time";
        val_1[5] = 0.5;
        val_1[6] = "easetype";
        val_1[7] = 5;
        val_1[8] = "looptype";
        val_1[9] = 2;
        val_1[10] = "oncomplete";
        val_1[11] = "startCpu";
        val_1[12] = "oncompletetarget";
        val_1[13] = this.gameObject;
        iTween.ScaleTo(target:  this.puzzle, args:  iTween.Hash(args:  val_1));
        iTween.Stop(target:  this.futureCpu);
        iTween.Stop(target:  this.vsCpu);
        this.counterPong = 0;
    }
    private void startCpu()
    {
        if((this.vsCpu.GetComponent<UnityEngine.UI.Button>().interactable) != false)
        {
                int val_6 = this.counterPong;
            val_6 = val_6 + 1;
            this.counterPong = val_6;
            if((val_6 & 1) != 0)
        {
                return;
        }
        
            object[] val_3 = new object[14];
            val_3[0] = "x";
            val_3[1] = 0.56;
            val_3[2] = "y";
            val_3[3] = 0.56;
            val_3[4] = "time";
            val_3[5] = 0.5;
            val_3[6] = "easetype";
            val_3[7] = 5;
            val_3[8] = "looptype";
            val_3[9] = 2;
            val_3[10] = "oncomplete";
            val_3[11] = "startFuture";
            val_3[12] = "oncompletetarget";
            val_3[13] = this.gameObject;
            iTween.ScaleTo(target:  this.vsCpu, args:  iTween.Hash(args:  val_3));
            iTween.Stop(target:  this.puzzle);
            this.counterPong = 0;
            return;
        }
        
        this.startPuzzle();
    }
    private void startCpuBoss()
    {
        int val_4 = this.counterPong;
        val_4 = val_4 + 1;
        this.counterPong = val_4;
        if((val_4 & 1) != 0)
        {
                return;
        }
        
        object[] val_1 = new object[14];
        val_1[0] = "x";
        val_1[1] = 0.56;
        val_1[2] = "y";
        val_1[3] = 0.56;
        val_1[4] = "time";
        val_1[5] = 0.5;
        val_1[6] = "easetype";
        val_1[7] = 5;
        val_1[8] = "looptype";
        val_1[9] = 2;
        val_1[10] = "oncomplete";
        val_1[11] = "startExBoss";
        val_1[12] = "oncompletetarget";
        val_1[13] = this.gameObject;
        iTween.ScaleTo(target:  this.vsCpuBoss, args:  iTween.Hash(args:  val_1));
        iTween.Stop(target:  this.exBattleBoss);
        this.counterPong = 0;
    }
    private void startFuture()
    {
        if((this.futureCpu.GetComponent<UnityEngine.UI.Button>().interactable) != false)
        {
                int val_6 = this.counterPong;
            val_6 = val_6 + 1;
            this.counterPong = val_6;
            if((val_6 & 1) != 0)
        {
                return;
        }
        
            object[] val_3 = new object[14];
            val_3[0] = "x";
            val_3[1] = 0.56;
            val_3[2] = "y";
            val_3[3] = 0.56;
            val_3[4] = "time";
            val_3[5] = 0.5;
            val_3[6] = "easetype";
            val_3[7] = 5;
            val_3[8] = "looptype";
            val_3[9] = 2;
            val_3[10] = "oncomplete";
            val_3[11] = "startPuzzle";
            val_3[12] = "oncompletetarget";
            val_3[13] = this.gameObject;
            iTween.ScaleTo(target:  this.futureCpu, args:  iTween.Hash(args:  val_3));
            iTween.Stop(target:  this.vsCpu);
            this.counterPong = 0;
            return;
        }
        
        this.startPuzzle();
    }
    private void startExBoss()
    {
        if((this.exBattleBoss.GetComponent<UnityEngine.UI.Button>().interactable) != false)
        {
                int val_6 = this.counterPong;
            val_6 = val_6 + 1;
            this.counterPong = val_6;
            if((val_6 & 1) != 0)
        {
                return;
        }
        
            object[] val_3 = new object[14];
            val_3[0] = "x";
            val_3[1] = 0.56;
            val_3[2] = "y";
            val_3[3] = 0.56;
            val_3[4] = "time";
            val_3[5] = 0.5;
            val_3[6] = "easetype";
            val_3[7] = 5;
            val_3[8] = "looptype";
            val_3[9] = 2;
            val_3[10] = "oncomplete";
            val_3[11] = "startCpuBoss";
            val_3[12] = "oncompletetarget";
            val_3[13] = this.gameObject;
            iTween.ScaleTo(target:  this.exBattleBoss, args:  iTween.Hash(args:  val_3));
            iTween.Stop(target:  this.vsCpuBoss);
            this.counterPong = 0;
            return;
        }
        
        this.startCpuBoss();
    }
    public modeScaling()
    {
    
    }

}
