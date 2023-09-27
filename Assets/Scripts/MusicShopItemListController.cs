using UnityEngine;
public class MusicShopItemListController : MonoBehaviour
{
    // Fields
    public MusicShopItemController template;
    
    // Methods
    private void Awake()
    {
        var val_8;
        var val_18;
        var val_19;
        var val_20;
        System.Func<MusicData, System.Int32> val_22;
        val_18 = this;
        if(0 == this.template)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        val_20 = null;
        val_20 = null;
        val_22 = MusicShopItemListController.<>c.<>9__1_0;
        if(val_22 == null)
        {
                System.Func<MusicData, System.Int32> val_3 = null;
            val_22 = val_3;
            val_3 = new System.Func<MusicData, System.Int32>(object:  MusicShopItemListController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 MusicShopItemListController.<>c::<Awake>b__1_0(MusicData x));
            MusicShopItemListController.<>c.<>9__1_0 = val_22;
        }
        
        List.Enumerator<T> val_6 = System.Linq.Enumerable.ToList<MusicData>(source:  System.Linq.Enumerable.OrderByDescending<MusicData, System.Int32>(source:  GameInfo.music.GetAllPurchaseableItemData(), keySelector:  val_3)).GetEnumerator();
        label_26:
        if(((-1354908016) & 1) == 0)
        {
            goto label_13;
        }
        
        MusicShopItemController val_10 = UnityEngine.Object.Instantiate<MusicShopItemController>(original:  this.template);
        val_10.SetupMusic(data:  val_8.InitialType);
        val_10.transform.parent = this.transform;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
        val_10.transform.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        val_10.gameObject.SetActive(value:  true);
        UnityEngine.Object.Destroy(obj:  val_10.GetComponent<UnityEngine.UI.LayoutElement>());
        goto label_26;
        label_13:
        val_8.Add(driver:  public System.Void List.Enumerator<MusicData>::Dispose(), rectTransform:  public static System.Linq.IOrderedEnumerable<TSource> System.Linq.Enumerable::OrderByDescending<MusicData, System.Int32>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector), drivenProperties:  public System.Void System.Func<MusicData, System.Int32>::.ctor(object object, IntPtr method));
    }
    public MusicShopItemListController()
    {
    
    }

}
