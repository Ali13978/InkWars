using UnityEngine;
public class BPAmplifierLoader : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button m_bpAmplifierButton;
    
    // Methods
    private void OnEnable()
    {
        if(this.m_bpAmplifierButton == 0)
        {
                return;
        }
        
        this.m_bpAmplifierButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BPAmplifierLoader::LoadBPAmplifier()));
    }
    private void OnDisable()
    {
        if(this.m_bpAmplifierButton == 0)
        {
                return;
        }
        
        this.m_bpAmplifierButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BPAmplifierLoader::LoadBPAmplifier()));
    }
    private void LoadBPAmplifier()
    {
        BPAmplifier.Show();
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    public BPAmplifierLoader()
    {
    
    }

}
