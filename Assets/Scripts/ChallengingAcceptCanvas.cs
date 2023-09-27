using UnityEngine;
public class ChallengingAcceptCanvas : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text m_userName;
    private TMPro.TextMeshProUGUI m_PPCount;
    private TMPro.TextMeshProUGUI m_roomPin;
    private TMPro.TextMeshProUGUI m_wager;
    private UnityEngine.UI.Button m_acceptButton;
    private UnityEngine.UI.Button m_declineButton;
    private UnityEngine.AudioClip sounds;
    private System.Action m_onAccept;
    private System.Action m_onDecline;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    private void OnEnable()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.m_acceptButton)) != false)
        {
                this.m_acceptButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ChallengingAcceptCanvas::OnAcceptClicked()));
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.m_declineButton)) == false)
        {
                return;
        }
        
        this.m_declineButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ChallengingAcceptCanvas::OnDeclineClicked()));
    }
    private void OnDisable()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.m_acceptButton)) != false)
        {
                this.m_acceptButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ChallengingAcceptCanvas::OnAcceptClicked()));
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.m_declineButton)) == false)
        {
                return;
        }
        
        this.m_declineButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ChallengingAcceptCanvas::OnDeclineClicked()));
    }
    public void OnUserFound(string userName, string ppCount, System.Action OnAccept, System.Action onDecline, float wager = 0)
    {
        TMPro.TextMeshProUGUI val_7;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.m_userName, y:  0);
        val_7 = this.m_PPCount;
        if(val_7 != 0)
        {
                val_7 = this.m_PPCount;
            val_7.text = ppCount;
        }
        
        if(this.m_wager != 0)
        {
                val_7 = wager.ToString();
            this.m_wager.text = val_7;
        }
        
        this.m_onAccept = OnAccept;
        this.m_onDecline = onDecline;
        GameAudio.PlayMusicOneShot(clip:  this.sounds);
        this.GetComponent<UnityEngine.Canvas>().gameObject.SetActive(value:  true);
    }
    private void OnAcceptClicked()
    {
        if(this.m_onAccept == null)
        {
                return;
        }
        
        this.m_onAccept.Invoke();
    }
    private void OnDeclineClicked()
    {
        if(this.m_onDecline == null)
        {
                return;
        }
        
        this.m_onDecline.Invoke();
    }
    public ChallengingAcceptCanvas()
    {
    
    }

}
