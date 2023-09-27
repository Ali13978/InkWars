using UnityEngine;
public class LoginCtrl : MonoBehaviour
{
    // Fields
    public static bool isLogin;
    public UnityEngine.GameObject signUpInstruction;
    public UnityEngine.GameObject loginPanel;
    public UnityEngine.GameObject signUpPanel;
    
    // Methods
    private void Start()
    {
        null = null;
        if(LoginCtrl.isLogin == false)
        {
            goto label_3;
        }
        
        if(this.loginPanel != null)
        {
            goto label_5;
        }
        
        label_6:
        label_5:
        this.loginPanel.SetActive(value:  true);
        return;
        label_3:
        if(this.signUpInstruction != null)
        {
            goto label_5;
        }
        
        goto label_6;
    }
    public LoginCtrl()
    {
    
    }
    private static LoginCtrl()
    {
    
    }

}
