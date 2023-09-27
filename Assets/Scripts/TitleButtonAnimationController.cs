using UnityEngine;
public class TitleButtonAnimationController : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform playButton;
    private UnityEngine.RectTransform topButtonGroup;
    private UnityEngine.RectTransform leftButtonGroup;
    private UnityEngine.RectTransform rightButtonGroup;
    private UnityEngine.RectTransform bottomButtonGroup;
    private NetworkUICharacterAnimation characterAnimController;
    private System.Collections.Generic.List<UnityEngine.UI.Image> gameModeButtons;
    private UnityEngine.GameObject gameModePlaceHolder;
    private UnityEngine.Vector3 startPosTop;
    private UnityEngine.Vector3 startPosLeft;
    private UnityEngine.Vector3 startPosRight;
    private UnityEngine.Vector3 startPosBottom;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Vector3 val_1 = this.topButtonGroup.anchoredPosition3D;
        this.startPosTop = val_1;
        mem[1152921528259617580] = val_1.y;
        mem[1152921528259617584] = val_1.z;
        UnityEngine.Vector3 val_2 = this.leftButtonGroup.anchoredPosition3D;
        this.startPosLeft = val_2;
        mem[1152921528259617592] = val_2.y;
        mem[1152921528259617596] = val_2.z;
        UnityEngine.Vector3 val_3 = this.rightButtonGroup.anchoredPosition3D;
        this.startPosRight = val_3;
        mem[1152921528259617604] = val_3.y;
        mem[1152921528259617608] = val_3.z;
        UnityEngine.Vector3 val_4 = this.bottomButtonGroup.anchoredPosition3D;
        this.startPosBottom = val_4;
        mem[1152921528259617616] = val_4.y;
        mem[1152921528259617620] = val_4.z;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        this.playButton.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        CharacterAnimationData val_6 = this.characterAnimController.Character1;
        val_6.Image.gameObject.SetActive(value:  false);
        CharacterAnimationData val_8 = this.characterAnimController.Character2;
        val_8.Image.gameObject.SetActive(value:  false);
    }
    public void Enter(float duration = 0.4, System.Action onDone)
    {
        var val_5;
        var val_14;
        TitleButtonAnimationController.<>c__DisplayClass13_0 val_1 = new TitleButtonAnimationController.<>c__DisplayClass13_0();
        if(val_1 != null)
        {
                .<>4__this = this;
            .duration = duration;
        }
        else
        {
                mem[16] = this;
            mem[24] = duration;
        }
        
        .onDone = onDone;
        val_14 = null;
        val_14 = null;
        if((TitleButtonAnimationController.<>c.<>9__13_0) == null)
        {
            goto label_5;
        }
        
        label_19:
        int val_2 = this.gameModeButtons.RemoveAll(match:  TitleButtonAnimationController.<>c.<>9__13_0);
        this.topButtonGroup.anchoredPosition3D = new UnityEngine.Vector3() {x = this.startPosTop, y = V9.16B, z = V10.16B};
        this.leftButtonGroup.anchoredPosition3D = new UnityEngine.Vector3() {x = this.startPosLeft, y = V9.16B, z = V10.16B};
        this.rightButtonGroup.anchoredPosition3D = new UnityEngine.Vector3() {x = this.startPosRight, y = V9.16B, z = V10.16B};
        this.bottomButtonGroup.anchoredPosition3D = new UnityEngine.Vector3() {x = this.startPosBottom, y = V9.16B, z = V10.16B};
        List.Enumerator<T> val_3 = this.gameModeButtons.GetEnumerator();
        label_15:
        if(((-2116792080) & 1) == 0)
        {
            goto label_12;
        }
        
        val_5.InitialType.GetComponent<UnityEngine.CanvasGroup>().alpha = 0f;
        goto label_15;
        label_5:
        TitleButtonAnimationController.<>c.<>9__13_0 = new System.Predicate<UnityEngine.UI.Image>(object:  TitleButtonAnimationController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean TitleButtonAnimationController.<>c::<Enter>b__13_0(UnityEngine.UI.Image x));
        if(this.gameModeButtons != null)
        {
            goto label_19;
        }
        
        goto label_19;
        label_12:
        val_5.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Image>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<UnityEngine.UI.Image>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
        this.characterAnimController.Animate(onComplate:  new System.Action(object:  val_1, method:  System.Void TitleButtonAnimationController.<>c__DisplayClass13_0::<Enter>b__1()));
        CharacterAnimationData val_10 = this.characterAnimController.Character1;
        val_10.Image.gameObject.SetActive(value:  true);
        CharacterAnimationData val_12 = this.characterAnimController.Character2;
        val_12.Image.gameObject.SetActive(value:  true);
    }
    public TitleButtonAnimationController()
    {
        this.gameModeButtons = new System.Collections.Generic.List<UnityEngine.UI.Image>();
    }

}
