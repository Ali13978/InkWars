using UnityEngine;
public static class AnimToScene
{
    // Methods
    public static bool ScaleOutThenLoad(string sceneName, UnityEngine.Transform[] objectListToScaleOut, DG.Tweening.Ease ease = 26, float duration = 0.5, System.Action beforeSceneActive)
    {
        System.Action val_18;
        DG.Tweening.Ease val_19;
        var val_20;
        var val_21;
        System.Predicate<UnityEngine.Transform> val_23;
        UnityEngine.RectTransform val_24;
        val_18 = beforeSceneActive;
        val_19 = ease;
        .beforeSceneActive = val_18;
        if((System.String.IsNullOrEmpty(value:  sceneName)) != false)
        {
                val_20 = 0;
            return (bool)val_20;
        }
        
        UnityEngine.AsyncOperation val_3 = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  sceneName);
        .task = val_3;
        val_3.allowSceneActivation = false;
        DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
        if(objectListToScaleOut == null)
        {
            goto label_29;
        }
        
        System.Collections.Generic.List<UnityEngine.Transform> val_5 = new System.Collections.Generic.List<UnityEngine.Transform>();
        val_5.AddRange(collection:  objectListToScaleOut);
        val_21 = null;
        val_21 = null;
        val_23 = AnimToScene.<>c.<>9__0_1;
        if(val_23 == null)
        {
            goto label_13;
        }
        
        if(val_5 == null)
        {
            goto label_14;
        }
        
        label_18:
        val_24 = public System.Int32 System.Collections.Generic.List<UnityEngine.Transform>::RemoveAll(System.Predicate<T> match);
        int val_6 = val_5.RemoveAll(match:  val_23);
        goto label_15;
        label_13:
        System.Predicate<UnityEngine.Transform> val_7 = null;
        val_23 = val_7;
        val_7 = new System.Predicate<UnityEngine.Transform>(object:  AnimToScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AnimToScene.<>c::<ScaleOutThenLoad>b__0_1(UnityEngine.Transform x));
        AnimToScene.<>c.<>9__0_1 = val_23;
        if(val_5 != null)
        {
            goto label_18;
        }
        
        label_14:
        val_24 = public System.Int32 System.Collections.Generic.List<UnityEngine.Transform>::RemoveAll(System.Predicate<T> match);
        int val_8 = 0.RemoveAll(match:  val_7);
        label_15:
        List.Enumerator<T> val_9 = val_5.GetEnumerator();
        val_18 = 1152921528493495728;
        label_22:
        if(((-1883109352) & 1) == 0)
        {
            goto label_19;
        }
        
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  0.InitialType, endValue:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, duration:  duration), ease:  val_19));
        goto label_22;
        label_19:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.Transform>::Dispose(), rectTransform:  val_24, drivenProperties:  public System.Void System.Predicate<UnityEngine.Transform>::.ctor(object object, IntPtr method));
        label_29:
        DG.Tweening.TweenCallback val_15 = null;
        val_19 = val_15;
        val_15 = new DG.Tweening.TweenCallback(object:  new AnimToScene.<>c__DisplayClass0_0(), method:  System.Void AnimToScene.<>c__DisplayClass0_0::<ScaleOutThenLoad>b__0());
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_4, callback:  val_15);
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<DG.Tweening.Sequence>(t:  val_4);
        val_20 = 1;
        return (bool)val_20;
    }

}
