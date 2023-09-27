using UnityEngine;
public class Generator : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject m_ParticleSystemPrefab;
    private int m_NumberOfParticles;
    private int m_ParticleIndex;
    private UnityEngine.Vector2 m_RandomSpawnRate;
    private System.Collections.Generic.List<UnityEngine.ParticleSystem> m_PooledParticlesList;
    private System.Collections.Generic.List<UnityEngine.ParticleSystem> m_playingParticlesList;
    private UnityEngine.ParticleSystem currentParticle;
    
    // Methods
    private void Awake()
    {
        System.Collections.Generic.List<UnityEngine.ParticleSystem> val_8;
        System.Collections.Generic.List<UnityEngine.ParticleSystem> val_1 = new System.Collections.Generic.List<UnityEngine.ParticleSystem>();
        this.m_PooledParticlesList = val_1;
        if(this.m_NumberOfParticles >= 1)
        {
                var val_8 = 0;
            do
        {
            UnityEngine.Vector3 val_2 = val_1.GenerateRandomPosition();
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.m_ParticleSystemPrefab, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
            val_4.transform.SetParent(p:  this.transform);
            if(val_4 != null)
        {
                val_4.SetActive(value:  true);
            val_8 = this.m_PooledParticlesList;
        }
        else
        {
                val_4.SetActive(value:  true);
            val_8 = this.m_PooledParticlesList;
        }
        
            val_8.Add(item:  val_4.GetComponent<UnityEngine.ParticleSystem>());
            val_8 = val_8 + 1;
        }
        while(val_8 < this.m_NumberOfParticles);
        
        }
        
        this.m_ParticleIndex = 0;
    }
    private void Start()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.EmitBubbles());
    }
    private System.Collections.IEnumerator EmitBubbles()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new Generator.<EmitBubbles>d__9();
    }
    private System.Collections.IEnumerator EnableBubbles()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new Generator.<EnableBubbles>d__10();
    }
    private UnityEngine.Vector3 GenerateRandomPosition()
    {
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  UnityEngine.Random.Range(min:  -8.66f, max:  8.66f), y:  UnityEngine.Random.Range(min:  -4.98f, max:  4.94f));
        UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    public Generator()
    {
        this.m_NumberOfParticles = 3;
    }

}
