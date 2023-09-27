using UnityEngine;
public class ContainerTemplate : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image image;
    private UnityEngine.UI.Image checkedImage;
    public BubblesCollection.BubblesData data;
    public SwitcherCollection.SwitcherData datas;
    public BattleGridCollection.BGData datab;
    
    // Methods
    public void SetImage(UnityEngine.Sprite sprite)
    {
        this.image.sprite = sprite;
    }
    public void SetActive(bool set)
    {
        this.checkedImage.gameObject.SetActive(value:  set);
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    public ContainerTemplate()
    {
    
    }

}
