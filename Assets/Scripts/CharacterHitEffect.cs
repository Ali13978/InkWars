using UnityEngine;
public class CharacterHitEffect : MonoBehaviour
{
    // Fields
    public bool isLeft;
    private System.Collections.Generic.List<UnityEngine.ParticleSystem> particles;
    
    // Methods
    private void Awake()
    {
        this.particles.AddRange(collection:  this.GetComponents<UnityEngine.ParticleSystem>());
        this.particles.AddRange(collection:  this.GetComponentsInChildren<UnityEngine.ParticleSystem>(includeInactive:  true));
        this.SetupSortingLayerOrder();
    }
    private void OnEnable()
    {
        InkWars.Model.Model_Events.Instance.add_OnComboPop(value:  new Model_Events.OnPlayerMessageDelegate(object:  this, method:  System.Void CharacterHitEffect::OnPlayerMessage(PlayerMessage message)));
    }
    private void OnDisable()
    {
        InkWars.Model.Model_Events.Instance.remove_OnComboPop(value:  new Model_Events.OnPlayerMessageDelegate(object:  this, method:  System.Void CharacterHitEffect::OnPlayerMessage(PlayerMessage message)));
    }
    private void OnPlayerMessage(PlayerMessage message)
    {
        InkWars.Model.Model_Manager val_1 = InkWars.Model.Model_Manager.Instance;
        if(val_1.Model == null)
        {
            goto label_1;
        }
        
        if(this.isLeft == false)
        {
            goto label_2;
        }
        
        label_4:
        InkWars.Model.Model_Player val_2 = val_1.Model.LeftPlayer;
        goto label_3;
        label_1:
        if(this.isLeft == true)
        {
            goto label_4;
        }
        
        label_2:
        InkWars.Model.Model_Player val_3 = val_1.Model.RightPlayer;
        label_3:
        if(message.PlayerID == val_3.ID)
        {
                return;
        }
        
        if(message.HitCount < 3)
        {
                return;
        }
        
        this.PlayAnimation();
    }
    private void PlayAnimation()
    {
        List.Enumerator<T> val_1 = this.particles.GetEnumerator();
        label_4:
        if(((-38443592) & 1) == 0)
        {
            goto label_2;
        }
        
        0.InitialType.Play();
        goto label_4;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.ParticleSystem>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    private void SetupSortingLayerOrder()
    {
        List.Enumerator<T> val_1 = this.particles.GetEnumerator();
        label_9:
        if(((-38306008) & 1) == 0)
        {
            goto label_2;
        }
        
        System.Type val_2 = 0.InitialType;
        if(0 == (val_2.GetComponent<UnityEngine.ParticleSystemRenderer>()))
        {
            goto label_9;
        }
        
        val_2.GetComponent<UnityEngine.ParticleSystemRenderer>().sortingOrder = 10;
        goto label_9;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.ParticleSystem>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    public CharacterHitEffect()
    {
        this.particles = new System.Collections.Generic.List<UnityEngine.ParticleSystem>();
    }

}
