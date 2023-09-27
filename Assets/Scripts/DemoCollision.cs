using UnityEngine;
public class DemoCollision : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject lineRenderer;
    public UnityEngine.Rigidbody2D[] playerBalls;
    private UnityEngine.Rigidbody2D playerBall;
    public UnityEngine.GameObject popPrefab;
    public UnityEngine.GameObject popPrefab1;
    public UnityEngine.GameObject popPrefab2;
    public UnityEngine.GameObject popPrefab3;
    public UnityEngine.GameObject popPrefab4;
    public UnityEngine.GameObject popPrefab5;
    private float angle1;
    private float angle2;
    private float angle3;
    private float angle11;
    private float angle22;
    private float angle33;
    public UnityEngine.Sprite red;
    
    // Methods
    private void Start()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.DestroyAll());
    }
    private System.Collections.IEnumerator DestroyAll()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DemoCollision.<DestroyAll>d__17();
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        UnityEngine.Object.Destroy(obj:  other.gameObject);
    }
    public DemoCollision()
    {
    
    }

}
