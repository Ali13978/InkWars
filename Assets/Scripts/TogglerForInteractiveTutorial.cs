using UnityEngine;
public class TogglerForInteractiveTutorial : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject tabGrid;
    public UnityEngine.GameObject phoneGrid;
    public UnityEngine.GameObject tabInstanceAnimator;
    public UnityEngine.GameObject phoneInstanceAnimator;
    public UnityEngine.GameObject tabLineController;
    public UnityEngine.GameObject phoneLineController;
    public UnityEngine.GameObject demoCanvas;
    public UnityEngine.GameObject fadeEffect;
    public UnityEngine.GameObject DemoSceneHolder;
    public UnityEngine.GameObject managerPhone;
    public UnityEngine.GameObject managerTab;
    public UnityEngine.GameObject phoneCanvasScene;
    public UnityEngine.GameObject tabCanvasScene;
    public UnityEngine.GameObject panelTab;
    public UnityEngine.GameObject panelPhone;
    public UnityEngine.GameObject leftHandPhone;
    public UnityEngine.GameObject lefthandTab;
    public UnityEngine.GameObject rightHandPhone;
    public UnityEngine.GameObject rightHandTab;
    public UnityEngine.Camera mainCam;
    public UnityEngine.GameObject canvasFlipperTab;
    public UnityEngine.GameObject canvasFlipperPhone;
    public UnityEngine.GameObject sceneFlipper;
    public UnityEngine.GameObject[] textsToBeFlipped;
    
    // Methods
    private void Awake()
    {
        var val_5;
        UnityEngine.Camera val_6;
        InstanceAnimator.RefreshUniversalX();
        if(InstanceAnimator.UniversalX == 4.46f)
        {
                this.phoneGrid.SetActive(value:  true);
            this.phoneInstanceAnimator.SetActive(value:  true);
            this.phoneLineController.SetActive(value:  true);
            this.managerPhone.SetActive(value:  true);
            this.phoneCanvasScene.SetActive(value:  true);
            this.panelPhone.SetActive(value:  true);
            this.leftHandPhone.SetActive(value:  true);
            this.rightHandPhone.SetActive(value:  true);
            this.tabGrid.SetActive(value:  false);
            this.tabInstanceAnimator.SetActive(value:  false);
            this.tabLineController.SetActive(value:  false);
            this.managerTab.SetActive(value:  false);
            this.tabCanvasScene.SetActive(value:  false);
            this.panelTab.SetActive(value:  false);
            this.lefthandTab.SetActive(value:  false);
            val_5 = 0;
        }
        else
        {
                this.phoneGrid.SetActive(value:  false);
            this.phoneInstanceAnimator.SetActive(value:  false);
            this.phoneLineController.SetActive(value:  false);
            this.managerPhone.SetActive(value:  false);
            this.phoneCanvasScene.SetActive(value:  false);
            this.panelPhone.SetActive(value:  false);
            this.leftHandPhone.SetActive(value:  false);
            this.rightHandPhone.SetActive(value:  false);
            this.tabGrid.SetActive(value:  true);
            this.tabInstanceAnimator.SetActive(value:  true);
            this.tabLineController.SetActive(value:  true);
            this.managerTab.SetActive(value:  true);
            this.tabCanvasScene.SetActive(value:  true);
            this.panelTab.SetActive(value:  true);
            this.lefthandTab.SetActive(value:  true);
            val_5 = 1;
        }
        
        this.rightHandTab.SetActive(value:  true);
        float val_5 = (float)UnityEngine.Screen.height;
        if((float)UnityEngine.Screen.width <= val_5)
        {
            goto label_36;
        }
        
        val_5 = (float)UnityEngine.Screen.width / val_5;
        if(val_5 <= 1.4f)
        {
            goto label_40;
        }
        
        if(val_5 > 1.52f)
        {
                return;
        }
        
        goto label_41;
        label_36:
        float val_6 = (float)UnityEngine.Screen.width;
        val_6 = (float)UnityEngine.Screen.height / val_6;
        if(val_6 <= 1.4f)
        {
            goto label_40;
        }
        
        if(val_6 <= 1.52f)
        {
            goto label_41;
        }
        
        if(val_6 <= 1.59f)
        {
            goto label_42;
        }
        
        return;
        label_40:
        val_6 = this.mainCam;
        if(val_6 != null)
        {
            goto label_47;
        }
        
        goto label_47;
        label_41:
        val_6 = this.mainCam;
        label_47:
        val_6.orthographicSize = 5.3f;
        return;
        label_42:
        if(this.mainCam != null)
        {
            goto label_47;
        }
        
        goto label_47;
    }
    public void onFlip()
    {
        float val_13;
        var val_14;
        UnityEngine.Vector3 val_2 = this.canvasFlipperTab.transform.localScale;
        this.canvasFlipperTab.transform.localScale = new UnityEngine.Vector3() {x = -val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_5 = this.canvasFlipperPhone.transform.localScale;
        this.canvasFlipperPhone.transform.localScale = new UnityEngine.Vector3() {x = -val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Vector3 val_8 = this.sceneFlipper.transform.localScale;
        val_13 = val_8.y;
        this.sceneFlipper.transform.localScale = new UnityEngine.Vector3() {x = -val_8.x, y = val_13, z = val_8.z};
        val_14 = 0;
        goto label_12;
        label_22:
        UnityEngine.Vector3 val_11 = this.textsToBeFlipped[0].transform.localScale;
        val_13 = val_11.y;
        this.textsToBeFlipped[0].transform.localScale = new UnityEngine.Vector3() {x = -val_11.x, y = val_13, z = val_11.z};
        val_14 = 1;
        label_12:
        if(val_14 < this.textsToBeFlipped.Length)
        {
            goto label_22;
        }
    
    }
    public TogglerForInteractiveTutorial()
    {
    
    }

}
