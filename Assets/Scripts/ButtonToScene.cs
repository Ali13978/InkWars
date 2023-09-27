using UnityEngine;
public class ButtonToScene : MonoBehaviour
{
    // Fields
    public string nextScene;
    public System.Collections.Generic.List<UnityEngine.Transform> objectsToScaleOut;
    public bool checkConnetionBeforeAction;
    public bool checkVersionBeforeAction;
    public DG.Tweening.Ease ease;
    public float duration;
    private UnityEngine.UI.Button btn;
    
    // Methods
    private void Awake()
    {
        var val_4;
        this.btn = this.GetComponent<UnityEngine.UI.Button>();
        val_4 = null;
        val_4 = null;
        if((ButtonToScene.<>c.<>9__7_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        int val_2 = this.objectsToScaleOut.RemoveAll(match:  ButtonToScene.<>c.<>9__7_0);
        return;
        label_3:
        ButtonToScene.<>c.<>9__7_0 = new System.Predicate<UnityEngine.Transform>(object:  ButtonToScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ButtonToScene.<>c::<Awake>b__7_0(UnityEngine.Transform x));
        if(this.objectsToScaleOut != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    private void OnEnable()
    {
        this.btn.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ButtonToScene::OnClick()));
    }
    private void OnDisable()
    {
        this.btn.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ButtonToScene::OnClick()));
    }
    private void OnClick()
    {
        GameAudio.PlayButtonSound();
        this.btn.interactable = false;
        if(this.checkConnetionBeforeAction != false)
        {
                ConnectionTester.TestConnection(callback:  new System.Action<System.Boolean, System.String>(object:  this, method:  System.Void ButtonToScene::<OnClick>b__10_0(bool connected, string error)));
            return;
        }
        
        this.CheckVersionOrGoNext();
    }
    private void CheckVersionOrGoNext()
    {
        if(this.checkVersionBeforeAction != false)
        {
                this.btn.interactable = true;
            GameVersionCheck.CheckGameVersion(OnDone:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ButtonToScene::OnMoveToNextScene()), showLoadingWhenProc:  true);
            return;
        }
        
        this.OnMoveToNextScene();
    }
    private void OnMoveToNextScene()
    {
        T[] val_4 = this.objectsToScaleOut.ToArray();
        val_4 = (~(AnimToScene.ScaleOutThenLoad(sceneName:  this.nextScene, objectListToScaleOut:  val_4, ease:  this.ease, duration:  this.duration, beforeSceneActive:  new System.Action(object:  this, method:  System.Void ButtonToScene::<OnMoveToNextScene>b__12_0())))) & 1;
        this.btn.interactable = val_4;
    }
    public ButtonToScene()
    {
        this.objectsToScaleOut = new System.Collections.Generic.List<UnityEngine.Transform>();
        this.ease = 26;
    }
    private void <OnClick>b__10_0(bool connected, string error)
    {
        if(connected != false)
        {
                this.CheckVersionOrGoNext();
            return;
        }
        
        DialogPanel val_1 = DialogManager.Show(title:  "Internet not Connected", message:  "Please connect Internet and try again.", cancelButtonTitle:  0, onCancelCallback:  0);
        this.btn.interactable = true;
    }
    private void <OnMoveToNextScene>b__12_0()
    {
        this.btn.interactable = true;
    }

}
