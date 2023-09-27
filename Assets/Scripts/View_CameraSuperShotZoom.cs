using UnityEngine;
public class View_CameraSuperShotZoom : MonoBehaviour
{
    // Fields
    private float inDuration;
    private float outDuration;
    private DG.Tweening.Ease inEase;
    private DG.Tweening.Ease outEase;
    private float zoomOrthographicSize;
    private float offsetX;
    private float offsetXDuration;
    private UnityEngine.Camera camera;
    private UnityEngine.Vector3 originPos;
    private float originOrthographicSize;
    private DG.Tweening.Sequence anim;
    
    // Methods
    private void Awake()
    {
        this.camera = this.GetComponent<UnityEngine.Camera>();
        this.SaveCameraOriginal();
    }
    private void Start()
    {
        MainThreadDispatcher.Invoke(action:  new System.Action(object:  this, method:  System.Void View_CameraSuperShotZoom::SaveCameraOriginal()), delay:  2f);
    }
    private void SaveCameraOriginal()
    {
        UnityEngine.Vector3 val_2 = this.camera.transform.position;
        this.originPos = val_2;
        mem[1152921528341023172] = val_2.y;
        mem[1152921528341023176] = val_2.z;
        this.originOrthographicSize = this.camera.orthographicSize;
    }
    private void OnEnable()
    {
        InkWars.Model.Model_Events.Instance.add_OnRevengeSuper(value:  new Model_Events.OnRevengeSuperDelegate(object:  this, method:  System.Void View_CameraSuperShotZoom::OnRevengeSuper(InkWars.Model.Player id, InkWars.Model.BubbleTypes revengeSuperType, InkWars.Model.RevengeSuperEventState state)));
    }
    private void OnDisable()
    {
        if(InkWars.Model.Model_Events.Instance == 0)
        {
                return;
        }
        
        InkWars.Model.Model_Events.Instance.remove_OnRevengeSuper(value:  new Model_Events.OnRevengeSuperDelegate(object:  this, method:  System.Void View_CameraSuperShotZoom::OnRevengeSuper(InkWars.Model.Player id, InkWars.Model.BubbleTypes revengeSuperType, InkWars.Model.RevengeSuperEventState state)));
    }
    private void OnRevengeSuper(InkWars.Model.Player id, InkWars.Model.BubbleTypes revengeSuperType, InkWars.Model.RevengeSuperEventState state)
    {
        DG.Tweening.Ease val_4;
        if(state != 4)
        {
                if(state != 3)
        {
                return;
        }
        
            UnityEngine.Vector3 val_1 = this.GetPlayerPosFromID(id:  id, ignoreZ:  true);
            float val_4 = this.originOrthographicSize;
            val_4 = this.inEase;
            float val_3 = (this.GetPlayerDirFromID(id:  id)) * this.offsetX;
            val_4 = val_4 + this.zoomOrthographicSize;
        }
        else
        {
                val_4 = this.outEase;
        }
        
        this.PlayAnim(pos:  new UnityEngine.Vector3() {x = this.originPos}, offsetPosX:  0f, orthograhpicSize:  this.originOrthographicSize, duration:  this.outDuration, ease:  val_4);
    }
    private void ResetCamera()
    {
        this.camera.transform.position = new UnityEngine.Vector3() {x = this.originPos, y = V9.16B, z = V10.16B};
        this.camera.orthographicSize = this.originOrthographicSize;
    }
    private UnityEngine.Vector3 GetPlayerPosFromID(InkWars.Model.Player id, bool ignoreZ = True)
    {
        View_Objects val_2 = View_Core.Instance.GetViewObjectsByPlayerId_Flip(aNewPlayerId:  id);
        UnityEngine.Vector3 val_3 = val_2.CenterPoint.position;
        if(ignoreZ == false)
        {
                return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_5.z};
        }
        
        this = this.camera.transform;
        UnityEngine.Vector3 val_5 = this.position;
        return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_5.z};
    }
    private float GetPlayerDirFromID(InkWars.Model.Player id)
    {
        View_Core val_3 = View_Core.Instance;
        return (float)((View_Core.Instance.GetViewObjectsByPlayerId_Flip(aNewPlayerId:  id)) != val_3.LeftPlayer) ? 1f : -1f;
    }
    private void PlayAnim(UnityEngine.Vector3 pos, float offsetPosX, float orthograhpicSize, float duration = 0.5, DG.Tweening.Ease ease = 1)
    {
        if(this.anim != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.anim, complete:  false);
        }
        
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        this.anim = val_1;
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.camera.transform, endValue:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, duration:  duration, snapping:  false), ease:  ease));
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.anim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOOrthoSize(target:  this.camera, endValue:  orthograhpicSize, duration:  duration), ease:  ease));
        if(offsetPosX == 0f)
        {
                return;
        }
        
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.anim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMoveX(target:  this.camera.transform, endValue:  pos.x + offsetPosX, duration:  this.offsetXDuration, snapping:  false), ease:  1));
    }
    public View_CameraSuperShotZoom()
    {
        this.inDuration = 0.5f;
        this.outDuration = 7.346868E-41f;
        this.inEase = 26;
        this.zoomOrthographicSize = -2f;
        this.offsetX = 7.346868E-41f;
        this.offsetXDuration = 2f;
    }

}
