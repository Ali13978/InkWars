using UnityEngine;
public class DoubleTapController : Control_Base<DoubleTapController>
{
    // Fields
    private UnityEngine.UI.Image m_ImageToTap;
    private int TapCount;
    private float m_MaxDoubleTapTime;
    private bool firstTap;
    private bool secondTap;
    private float m_ElapsedTimeSinceFirstTap;
    
    // Methods
    internal override void Awake()
    {
        this.Awake();
        if(0 == this.m_ImageToTap)
        {
                this.m_ImageToTap = this.GetComponent<UnityEngine.UI.Image>();
        }
        
        this.TapCount = 0;
        this.m_ElapsedTimeSinceFirstTap = 0f;
    }
    private void Update()
    {
        var val_7;
        var val_8;
        int val_9;
        float val_10;
        if(this.PlayerModel == null)
        {
                return;
        }
        
        InkWars.Model.Model_Player val_2 = this.PlayerModel;
        if(val_2.ID == 1)
        {
                val_7 = null;
            val_7 = null;
            if(Character_GlobalInfo.gameMode != 5)
        {
                return;
        }
        
        }
        
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
            goto label_7;
        }
        
        if(this.CheckCollisionWithImage() == false)
        {
                return;
        }
        
        val_8 = this;
        val_9 = this.TapCount + 1;
        this.TapCount = val_9;
        if(this.firstTap == false)
        {
            goto label_10;
        }
        
        this.firstTap = false;
        goto label_10;
        label_7:
        val_8 = this;
        val_9 = this.TapCount;
        label_10:
        if(val_9 == 1)
        {
            goto label_11;
        }
        
        if(val_9 != 2)
        {
            goto label_12;
        }
        
        val_10 = this.m_ElapsedTimeSinceFirstTap;
        if(val_10 >= 0)
        {
            goto label_16;
        }
        
        InkWars.Model.Model_Player val_5 = this.PlayerModel;
        val_10 = 0f;
        val_5.TryStunBreak = true;
        this.TapCount = 0;
        this.m_ElapsedTimeSinceFirstTap = 0f;
        this.firstTap = true;
        this.secondTap = false;
        goto label_16;
        label_11:
        val_10 = this.m_ElapsedTimeSinceFirstTap + UnityEngine.Time.deltaTime;
        this.m_ElapsedTimeSinceFirstTap = val_10;
        goto label_16;
        label_12:
        val_10 = this.m_ElapsedTimeSinceFirstTap;
        label_16:
        if(val_10 <= this.m_MaxDoubleTapTime)
        {
                return;
        }
        
        this.TapCount = 0;
        this.m_ElapsedTimeSinceFirstTap = 0f;
        this.firstTap = true;
        this.secondTap = false;
    }
    public bool CheckCollisionWithImage()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_3 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        return UnityEngine.RectTransformUtility.RectangleContainsScreenPoint(rect:  this.m_ImageToTap.rectTransform, screenPoint:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
    }
    private void ResetTapState()
    {
        this.TapCount = 0;
        this.m_ElapsedTimeSinceFirstTap = 0f;
        this.firstTap = true;
        this.secondTap = false;
    }
    public DoubleTapController()
    {
        this.m_MaxDoubleTapTime = 1f;
        this.firstTap = true;
    }

}
