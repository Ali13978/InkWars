using UnityEngine;
public class DialogManager : MonoBehaviour
{
    // Fields
    private static DialogManager _inst;
    public DialogPanel template;
    public UnityEngine.GameObject loadingPanel;
    
    // Properties
    private static DialogManager instance { get; }
    
    // Methods
    private static DialogManager get_instance()
    {
        DialogManager val_5 = DialogManager._inst;
        if(0 != val_5)
        {
                return (DialogManager)DialogManager._inst;
        }
        
        DialogManager._inst = UnityEngine.Object.Instantiate<DialogManager>(original:  UnityEngine.Resources.Load<DialogManager>(path:  "DynamicUI/DialogManagerCanvas"));
        val_5 = DialogManager._inst;
        UnityEngine.Object.DontDestroyOnLoad(target:  val_5.gameObject);
        return (DialogManager)DialogManager._inst;
    }
    public static DialogPanel Show(string title, string message, string cancelButtonTitle, UnityEngine.Events.UnityAction onCancelCallback)
    {
        DialogManager val_1 = DialogManager.instance;
        DialogPanel val_4 = UnityEngine.Object.Instantiate<DialogPanel>(original:  val_1.template, parent:  DialogManager.instance.transform);
        if(val_4 != null)
        {
                return val_4.Show(title:  title, message:  message, cancelButtonTitle:  cancelButtonTitle, onCancelCallback:  onCancelCallback);
        }
        
        return val_4.Show(title:  title, message:  message, cancelButtonTitle:  cancelButtonTitle, onCancelCallback:  onCancelCallback);
    }
    public static DialogPanel ShowConfirmDialog(string title, string message, string confirmButtonTitle, string cancelButtonTitle, UnityEngine.Events.UnityAction onConfirmCallback, UnityEngine.Events.UnityAction onCancelCallback)
    {
        DialogManager val_1 = DialogManager.instance;
        DialogPanel val_4 = UnityEngine.Object.Instantiate<DialogPanel>(original:  val_1.template, parent:  DialogManager.instance.transform);
        if(val_4 != null)
        {
                return val_4.ShowWithConfirmButton(title:  title, message:  message, confirmButtonTitle:  confirmButtonTitle, cancelButtonTitle:  cancelButtonTitle, onConfirmCallback:  onConfirmCallback, onCancelCallback:  onCancelCallback);
        }
        
        return val_4.ShowWithConfirmButton(title:  title, message:  message, confirmButtonTitle:  confirmButtonTitle, cancelButtonTitle:  cancelButtonTitle, onConfirmCallback:  onConfirmCallback, onCancelCallback:  onCancelCallback);
    }
    public static void ShowLoading()
    {
        var val_2;
        System.Action val_4;
        val_2 = null;
        val_2 = null;
        val_4 = DialogManager.<>c.<>9__7_0;
        if(val_4 == null)
        {
                System.Action val_1 = null;
            val_4 = val_1;
            val_1 = new System.Action(object:  DialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DialogManager.<>c::<ShowLoading>b__7_0());
            DialogManager.<>c.<>9__7_0 = val_4;
        }
        
        MainThreadDispatcher.Invoke(action:  val_1, delay:  0f);
    }
    public static void HideLoading()
    {
        var val_2;
        System.Action val_4;
        val_2 = null;
        val_2 = null;
        val_4 = DialogManager.<>c.<>9__8_0;
        if(val_4 == null)
        {
                System.Action val_1 = null;
            val_4 = val_1;
            val_1 = new System.Action(object:  DialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DialogManager.<>c::<HideLoading>b__8_0());
            DialogManager.<>c.<>9__8_0 = val_4;
        }
        
        MainThreadDispatcher.Invoke(action:  val_1, delay:  0f);
    }
    public static void ShowCustomDialog(UnityEngine.RectTransform dialog)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        DialogManager.ShowCustomDialog(dialog:  dialog, scale:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
    }
    public static void ShowCustomDialog(UnityEngine.RectTransform dialog, UnityEngine.Vector3 scale)
    {
        var val_11;
        if(0 == dialog)
        {
                return;
        }
        
        UnityEngine.Transform val_4 = DialogManager.instance.gameObject.transform;
        if(dialog != null)
        {
                dialog.SetParent(p:  val_4);
            val_11 = dialog;
        }
        else
        {
                0.SetParent(p:  val_4);
            val_11 = 0;
        }
        
        val_11.localScale = new UnityEngine.Vector3() {x = scale.x, y = scale.y, z = scale.z};
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
        dialog.anchoredPosition = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.one;
        dialog.anchorMax = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
        dialog.anchorMin = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.zero;
        dialog.offsetMax = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.zero;
        if(dialog != null)
        {
                dialog.offsetMin = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
            val_11.SetAsLastSibling();
        }
        else
        {
                0.offsetMin = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
            val_11.SetAsLastSibling();
        }
        
        dialog.gameObject.SetActive(value:  true);
    }
    public static bool HasDialog(UnityEngine.RectTransform dialogRectTransform)
    {
        if(0 == dialogRectTransform)
        {
                return false;
        }
        
        if(dialogRectTransform != null)
        {
                return dialogRectTransform.IsChildOf(parent:  DialogManager.instance.transform);
        }
        
        return dialogRectTransform.IsChildOf(parent:  DialogManager.instance.transform);
    }
    public DialogManager()
    {
    
    }

}
