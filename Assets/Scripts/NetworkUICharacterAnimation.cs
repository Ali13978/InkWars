using UnityEngine;
public class NetworkUICharacterAnimation : MonoBehaviour
{
    // Fields
    public bool useDatabasePosition;
    private NetworkUICharacterAnimationDB m_Database;
    private NetworkUICharacterAnimationDB.DatabaseType m_DatabaseType;
    private InkBrushCharacterAnimationSerializableData m_Character1Data;
    private CharacterAnimationData m_Character1;
    private InkBrushCharacterAnimationSerializableData m_Character2Data;
    private CharacterAnimationData m_Character2;
    private bool m_PlayEndAnimation;
    private bool m_HoverOnAnimationEnd;
    public bool useCustomPath;
    private System.Collections.Generic.List<UnityEngine.RectTransform> customPath;
    private DG.Tweening.Ease m_Ease;
    private float m_Duration;
    private DG.Tweening.Sequence m_AnimationSequence;
    private DG.Tweening.Sequence m_HoverSequence;
    private float hoverLength;
    private DG.Tweening.Ease hoverEase;
    private float hoverOffsetInPixels;
    private float xC1;
    private float yC1;
    private float xC2;
    private float yC2;
    private DG.Tweening.Tweener c1xTw;
    private DG.Tweening.Tweener c1yTw;
    private DG.Tweening.Tweener c2xTw;
    private DG.Tweening.Tweener c2yTw;
    
    // Properties
    public CharacterAnimationData Character1 { get; }
    public CharacterAnimationData Character2 { get; }
    
    // Methods
    public CharacterAnimationData get_Character1()
    {
        return (CharacterAnimationData)this.m_Character1;
    }
    public CharacterAnimationData get_Character2()
    {
        return (CharacterAnimationData)this.m_Character2;
    }
    private void Awake()
    {
        if(0 == this.m_Database)
        {
                NetworkUICharacterAnimationDB val_2 = UnityEngine.Object.FindObjectOfType<NetworkUICharacterAnimationDB>();
            this.m_Database = val_2;
            if(0 == val_2)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        
        }
        
        this.Initialize();
    }
    public void Initialize()
    {
        UnityEngine.UI.Image val_15;
        float val_16;
        UnityEngine.UI.Image val_17;
        if(this.m_AnimationSequence != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.m_AnimationSequence, complete:  false);
        }
        
        this.KillHoverAnimations();
        if(this.m_DatabaseType <= 3)
        {
                var val_14 = 40825692 + (this.m_DatabaseType) << 2;
            val_14 = val_14 + 40825692;
        }
        else
        {
                if((this.m_Character1.IsNull != true) && (0 != this.m_Character1Data))
        {
                this.m_Character1.Image.sprite = this.m_Character1Data.Sprite;
            val_15 = this.m_Character1.Image;
            val_15.raycastTarget = false;
            if(this.useDatabasePosition != false)
        {
                this.m_Character1.InitialLocation = new UnityEngine.Vector2() {x = this.m_Character1Data.InitialLocation, y = V9.16B};
            this.m_Character1.MiddleLocation = new UnityEngine.Vector2() {x = this.m_Character1Data.MiddleLocation, y = V9.16B};
            val_15 = this.m_Character1;
            val_15.FinalLocation = new UnityEngine.Vector2() {x = this.m_Character1Data.FinalLocation, y = V9.16B};
        }
        
            this.m_Character1.Position = new UnityEngine.Vector2() {x = this.m_Character1Data.InitialLocation, y = V9.16B};
            UnityEngine.Vector3 val_9 = this.m_Character1Data.GetScale;
            val_16 = val_9.y;
            this.m_Character1.Transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_16, z = val_9.z};
        }
        
            if(this.m_Character2.IsNull == true)
        {
                return;
        }
        
            if(0 == this.m_Character2Data)
        {
                return;
        }
        
            this.m_Character2.Image.sprite = this.m_Character2Data.Sprite;
            val_17 = this.m_Character2.Image;
            val_17.raycastTarget = false;
            if(this.useDatabasePosition != false)
        {
                this.m_Character2.InitialLocation = new UnityEngine.Vector2() {x = this.m_Character2Data.InitialLocation, y = val_16};
            this.m_Character2.MiddleLocation = new UnityEngine.Vector2() {x = this.m_Character2Data.MiddleLocation, y = val_16};
            val_17 = this.m_Character2;
            val_17.FinalLocation = new UnityEngine.Vector2() {x = this.m_Character2Data.FinalLocation, y = val_16};
        }
        
            this.m_Character2.Position = new UnityEngine.Vector2() {x = this.m_Character2Data.InitialLocation, y = val_16};
            UnityEngine.Vector3 val_13 = this.m_Character2Data.GetScale;
            this.m_Character2.Transform.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        }
    
    }
    public void Animate(System.Action onComplate)
    {
        float val_33;
        float val_36;
        float val_37;
        float val_41;
        NetworkUICharacterAnimation.<>c__DisplayClass28_0 val_1 = new NetworkUICharacterAnimation.<>c__DisplayClass28_0();
        if(val_1 != null)
        {
                .onComplate = onComplate;
        }
        else
        {
                mem[16] = onComplate;
        }
        
        .<>4__this = this;
        if(this.m_AnimationSequence != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.m_AnimationSequence, complete:  false);
        }
        
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.DOTween.Sequence(), isIndependentUpdate:  true);
        val_33 = 0.2f;
        this.m_AnimationSequence = val_3;
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_3, interval:  val_33);
        this.KillHoverAnimations();
        this.m_HoverSequence = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.DOTween.Sequence(), isIndependentUpdate:  true);
        if(this.m_Character1.IsNull != true)
        {
                if(this.m_Character1 != null)
        {
                UnityEngine.Vector2 val_8 = this.m_Character1.InitialLocation;
            val_36 = val_8.x;
            val_37 = val_8.y;
        }
        else
        {
                UnityEngine.Vector2 val_9 = 0.InitialLocation;
            val_36 = val_9.x;
            val_37 = val_9.y;
        }
        
            this.m_Character1.Position = new UnityEngine.Vector2() {x = val_36, y = val_37};
            if(this.useCustomPath != false)
        {
                UnityEngine.Vector3[] val_10 = this.GetCustomPath();
        }
        else
        {
                UnityEngine.Vector3[] val_11 = this.m_Character1.FinalPath;
        }
        
            var val_34 = -4294967296;
            var val_33 = 12;
            val_33 = val_11 + (((val_34 + ((val_11.Length) << 32)) >> 32) * val_33);
            this.xC1 = (((-4294967296 + (val_11.Length) << 32) >> 32) * 12) + val_11 + 32;
            val_34 = (val_34 + ((val_11.Length) << 32)) >> 32;
            var val_35 = 12;
            val_35 = val_11 + (val_34 * val_35);
            this.yC1 = (((-4294967296 + (val_11.Length) << 32) >> 32) * 12) + val_11 + 36;
            val_33 = this.m_Duration;
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.m_AnimationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalPath(target:  this.m_Character1.Transform, path:  val_11, duration:  val_33, pathType:  1, pathMode:  3, resolution:  6, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), ease:  this.m_Ease));
        }
        
        if(this.m_Character2.IsNull != true)
        {
                if(this.m_Character2 != null)
        {
                UnityEngine.Vector2 val_20 = this.m_Character2.InitialLocation;
            val_36 = val_20.x;
            val_41 = val_20.y;
        }
        else
        {
                UnityEngine.Vector2 val_21 = 0.InitialLocation;
            val_36 = val_21.x;
            val_41 = val_21.y;
        }
        
            this.m_Character2.Position = new UnityEngine.Vector2() {x = val_36, y = val_41};
            if(this.useCustomPath != false)
        {
                UnityEngine.Vector3[] val_22 = this.GetCustomPath();
        }
        else
        {
                UnityEngine.Vector3[] val_23 = this.m_Character2.FinalPath;
        }
        
            var val_37 = -4294967296;
            var val_36 = 12;
            val_36 = val_23 + (((val_37 + ((val_23.Length) << 32)) >> 32) * val_36);
            this.xC2 = (((-4294967296 + (val_23.Length) << 32) >> 32) * 12) + val_23 + 32;
            val_37 = (val_37 + ((val_23.Length) << 32)) >> 32;
            var val_38 = 12;
            val_38 = val_23 + (val_37 * val_38);
            this.yC2 = (((-4294967296 + (val_23.Length) << 32) >> 32) * 12) + val_23 + 36;
            DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.m_AnimationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalPath(target:  this.m_Character2.Transform, path:  val_23, duration:  this.m_Duration, pathType:  1, pathMode:  3, resolution:  6, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), ease:  this.m_Ease));
        }
        
        DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.m_AnimationSequence, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void NetworkUICharacterAnimation.<>c__DisplayClass28_0::<Animate>b__0()));
    }
    private UnityEngine.Vector3[] GetCustomPath()
    {
        var val_11;
        var val_13;
        if(this.useCustomPath == false)
        {
            goto label_1;
        }
        
        val_11 = null;
        val_11 = null;
        if((NetworkUICharacterAnimation.<>c.<>9__29_0) == null)
        {
            goto label_4;
        }
        
        label_20:
        int val_1 = this.customPath.RemoveAll(match:  NetworkUICharacterAnimation.<>c.<>9__29_0);
        System.Collections.Generic.List<UnityEngine.Vector3> val_2 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        List.Enumerator<T> val_3 = this.customPath.GetEnumerator();
        label_10:
        if(((-1816235704) & 1) == 0)
        {
            goto label_7;
        }
        
        UnityEngine.Vector3 val_5 = 0.InitialType.localPosition;
        val_2.Add(item:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        goto label_10;
        label_1:
        val_13 = new UnityEngine.Vector3[2];
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        val_13[0] = val_7;
        val_13[0] = val_7.y;
        val_13[0] = val_7.z;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        val_13[1] = val_8;
        val_13[1] = val_8.y;
        val_13[1] = val_8.z;
        return (UnityEngine.Vector3[])val_13;
        label_4:
        NetworkUICharacterAnimation.<>c.<>9__29_0 = new System.Predicate<UnityEngine.RectTransform>(object:  NetworkUICharacterAnimation.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NetworkUICharacterAnimation.<>c::<GetCustomPath>b__29_0(UnityEngine.RectTransform x));
        if(this.customPath != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_7:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.RectTransform>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<UnityEngine.RectTransform>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
        val_13 = val_2.ToArray();
        return (UnityEngine.Vector3[])val_13;
    }
    private void KillHoverAnimations()
    {
        if(this.c1xTw != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.c1xTw, complete:  false);
        }
        
        if(this.c2xTw != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.c2xTw, complete:  false);
        }
        
        if(this.c1yTw != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.c1yTw, complete:  false);
        }
        
        if(this.c2yTw == null)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.c2yTw, complete:  false);
    }
    private void HoverC1x()
    {
        if(this.c1xTw != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.c1xTw, complete:  false);
        }
        
        float val_3 = (((float)UnityEngine.Random.Range(min:  0, max:  2)) == 0f) ? (-this.hoverOffsetInPixels) : this.hoverOffsetInPixels;
        val_3 = this.xC1 + val_3;
        this.c1xTw = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.m_Character1.Transform, endValue:  val_3, duration:  this.hoverLength, snapping:  false), ease:  this.hoverEase), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void NetworkUICharacterAnimation::HoverC1x()));
    }
    private void HoverC1y()
    {
        if(this.c1yTw != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.c1yTw, complete:  false);
        }
        
        float val_7 = this.hoverOffsetInPixels;
        val_7 = ((UnityEngine.Random.Range(min:  0, max:  2)) == 0) ? (-val_7) : (val_7);
        val_7 = this.yC1 + val_7;
        this.c1yTw = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.m_Character1.Transform, endValue:  val_7, duration:  this.hoverLength, snapping:  false), ease:  this.hoverEase), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void NetworkUICharacterAnimation::HoverC1y()));
    }
    private void HoverC2x()
    {
        if(this.c2xTw != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.c2xTw, complete:  false);
        }
        
        float val_3 = (((float)UnityEngine.Random.Range(min:  0, max:  2)) == 0f) ? (-this.hoverOffsetInPixels) : this.hoverOffsetInPixels;
        val_3 = this.xC2 + val_3;
        this.c2xTw = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.m_Character2.Transform, endValue:  val_3, duration:  this.hoverLength, snapping:  false), ease:  this.hoverEase), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void NetworkUICharacterAnimation::HoverC2x()));
    }
    private void HoverC2y()
    {
        if(this.c2yTw != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.c2yTw, complete:  false);
        }
        
        float val_7 = this.hoverOffsetInPixels;
        val_7 = ((UnityEngine.Random.Range(min:  0, max:  2)) == 0) ? (-val_7) : (val_7);
        val_7 = this.yC2 + val_7;
        this.c2yTw = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.m_Character2.Transform, endValue:  val_7, duration:  this.hoverLength, snapping:  false), ease:  this.hoverEase), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void NetworkUICharacterAnimation::HoverC2y()));
    }
    private void OnDrawGizmos()
    {
        if(this.m_Character1.IsNull != true)
        {
                UnityEngine.Color val_2 = UnityEngine.Color.cyan;
            this.m_Character1.DrawGizmos(_gizmosColor:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
        }
        
        if(this.m_Character2.IsNull != false)
        {
                return;
        }
        
        UnityEngine.Color val_4 = UnityEngine.Color.magenta;
        this.m_Character2.DrawGizmos(_gizmosColor:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
    }
    public NetworkUICharacterAnimation()
    {
        this.useDatabasePosition = true;
        this.m_Character1 = new CharacterAnimationData();
        this.m_Character2 = new CharacterAnimationData();
        this.customPath = new System.Collections.Generic.List<UnityEngine.RectTransform>();
        this.hoverLength = 0.75f;
        this.hoverEase = 4;
        this.hoverOffsetInPixels = 15f;
    }

}
