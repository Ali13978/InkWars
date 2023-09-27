using UnityEngine;
public class Shock_Wave : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject target;
    private UnityEngine.RaycastHit rayInfo;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        float val_6;
        float val_7;
        UnityEngine.GameObject val_12;
        float val_13;
        val_12 = this;
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
        val_13 = val_3.x;
        UnityEngine.Vector3 val_4 = UnityEngine.Input.mousePosition;
        UnityEngine.Ray val_5 = UnityEngine.Camera.main.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}, m_Direction = new UnityEngine.Vector3() {x = val_7, y = val_6, z = val_6}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = this.rayInfo, y = this.rayInfo, z = this.rayInfo}, m_Normal = new UnityEngine.Vector3() {x = this.rayInfo, y = this.rayInfo, z = this.rayInfo}, m_FaceID = this.rayInfo, m_Distance = this.rayInfo, m_UV = new UnityEngine.Vector2() {x = this.rayInfo, y = this.rayInfo}, m_Collider = this.rayInfo})) == false)
        {
                return;
        }
        
        val_12 = this.target;
        val_13 = val_7;
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_10 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_12, position:  new UnityEngine.Vector3() {x = val_13, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w});
    }
    public Shock_Wave()
    {
    
    }

}
