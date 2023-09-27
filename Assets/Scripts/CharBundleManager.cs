using UnityEngine;
public class CharBundleManager : MonoBehaviour
{
    // Fields
    public static CharBundleManager instance;
    private static UnityEngine.AssetBundle[] charBundles;
    private static bool[] loading;
    private static System.Collections.Generic.List<CharacterAssetLoader>[] loaderReferences;
    private static System.DateTime lastReleaseTime;
    
    // Properties
    public static string assetBundleDirectory { get; }
    
    // Methods
    public static string get_assetBundleDirectory()
    {
        return UnityEngine.Application.streamingAssetsPath + "/AssetBundles"("/AssetBundles");
    }
    public static CharacterAssetLoader GetOrCreateLoader(CharacterNameID id)
    {
        var val_10;
        UnityEngine.Object val_12;
        CharBundleManager val_1 = CharBundleManager.GetInstance();
        System.Collections.Generic.List<CharacterAssetLoader>[] val_2 = CharBundleManager.loaderReferences + (((long)(int)(id)) << 3);
        val_10 = null;
        val_10 = null;
        if((CharBundleManager.<>c.<>9__7_0) == null)
        {
            goto label_5;
        }
        
        label_16:
        val_12 = (CharBundleManager.loaderReferences + ((long)(int)(id)) << 3) + 32.Find(match:  CharBundleManager.<>c.<>9__7_0);
        if(0 != val_12)
        {
                return (CharacterAssetLoader)val_12;
        }
        
        id.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
        val_12 = new UnityEngine.GameObject(name:  id.ToString() + "_Asset_Loader").AddComponent<CharacterAssetLoader>();
        return (CharacterAssetLoader)val_12;
        label_5:
        CharBundleManager.<>c.<>9__7_0 = new System.Predicate<CharacterAssetLoader>(object:  CharBundleManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CharBundleManager.<>c::<GetOrCreateLoader>b__7_0(CharacterAssetLoader x));
        if(((CharBundleManager.loaderReferences + ((long)(int)(id)) << 3) + 32) != 0)
        {
            goto label_16;
        }
        
        goto label_16;
    }
    public static void RemoveAssetLoader(CharacterAssetLoader loader)
    {
        if(0 == loader)
        {
                return;
        }
        
        CharBundleManager val_2 = CharBundleManager.GetInstance();
        System.Collections.Generic.List<CharacterAssetLoader>[] val_3 = CharBundleManager.loaderReferences + ((loader.charID) << 3);
        if(((CharBundleManager.loaderReferences + (loader.charID) << 3) + 32) == 0)
        {
                return;
        }
        
        bool val_4 = (CharBundleManager.loaderReferences + (loader.charID) << 3) + 32.Remove(item:  loader);
    }
    public static CharBundleManager GetInstance()
    {
        CharBundleManager val_18;
        var val_19;
        var val_20;
        var val_21;
        val_18 = CharBundleManager.instance;
        if(val_18 != 0)
        {
            goto label_3;
        }
        
        CharBundleManager.instance = new UnityEngine.GameObject().AddComponent<CharBundleManager>();
        UnityEngine.Object.DontDestroyOnLoad(target:  CharBundleManager.instance);
        int val_6 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).Length;
        System.Collections.Generic.List<CharacterAssetLoader>[] val_7 = new System.Collections.Generic.List<CharacterAssetLoader>[0];
        val_19 = null;
        CharBundleManager.loaderReferences = val_7;
        if(val_6 < 1)
        {
            goto label_12;
        }
        
        val_20 = 0;
        goto label_13;
        label_20:
        val_19 = null;
        val_20 = 1;
        label_13:
        System.Collections.Generic.List<CharacterAssetLoader> val_9 = new System.Collections.Generic.List<CharacterAssetLoader>();
        if(CharBundleManager.loaderReferences == null)
        {
            goto label_14;
        }
        
        if(val_9 != null)
        {
            goto label_15;
        }
        
        goto label_18;
        label_14:
        if(val_9 == null)
        {
            goto label_18;
        }
        
        label_15:
        System.Collections.Generic.List<CharacterAssetLoader> val_18 = val_7[4];
        label_18:
        mem2[0] = val_9;
        if((val_6 - 1) != val_20)
        {
            goto label_20;
        }
        
        label_12:
        int val_12 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).Length;
        CharBundleManager.charBundles = new UnityEngine.AssetBundle[0];
        val_18 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        int val_16 = val_18.Length;
        val_21 = null;
        CharBundleManager.loading = new bool[0];
        return (CharBundleManager)CharBundleManager.instance;
        label_3:
        val_21 = null;
        return (CharBundleManager)CharBundleManager.instance;
    }
    public UnityEngine.AssetBundle GetAssetBundle(CharacterNameID charID, CharacterAssetLoader loaderRef, bool firstCall)
    {
        var val_9;
        UnityEngine.Object val_10;
        val_9 = firstCall;
        UnityEngine.AssetBundle[] val_1 = CharBundleManager.charBundles + (((long)(int)(charID)) << 3);
        val_10 = mem[(CharBundleManager.charBundles + ((long)(int)(charID)) << 3) + 32];
        val_10 = (CharBundleManager.charBundles + ((long)(int)(charID)) << 3) + 32;
        if(val_10 != 0)
        {
            goto label_5;
        }
        
        val_10 = CharBundleManager.loading;
        System.Boolean[] val_3 = val_10 + (long)charID;
        if(((CharBundleManager.loading + (long)(int)(charID)) + 32) == 0)
        {
            goto label_8;
        }
        
        label_5:
        if(val_9 == false)
        {
            goto label_18;
        }
        
        label_17:
        System.Collections.Generic.List<CharacterAssetLoader>[] val_4 = CharBundleManager.loaderReferences + (((long)(int)(charID)) << 3);
        val_9 = mem[(CharBundleManager.loaderReferences + ((long)(int)(charID)) << 3) + 32];
        val_9 = (CharBundleManager.loaderReferences + ((long)(int)(charID)) << 3) + 32;
        val_9.Add(item:  loaderRef);
        label_18:
        UnityEngine.AssetBundle[] val_5 = CharBundleManager.charBundles + (((long)(int)(charID)) << 3);
        return (UnityEngine.AssetBundle)(CharBundleManager.charBundles + ((long)(int)(charID)) << 3) + 32;
        label_8:
        System.Boolean[] val_6 = CharBundleManager.loading + (long)charID;
        (CharBundleManager.loading + (long)(int)(charID)).__unknownFiledOffset_20 = 1;
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.LoadAssetBundle(charID:  charID));
        if(val_9 == true)
        {
            goto label_17;
        }
        
        goto label_18;
    }
    public string GetBundlePath(CharacterNameID charID)
    {
        return "" + UnityEngine.Application.streamingAssetsPath + "/AssetBundles/characters/"("/AssetBundles/characters/") + CharNameIDConverter.ToString(enumID:  charID).ToLower()(CharNameIDConverter.ToString(enumID:  charID).ToLower());
    }
    private System.Collections.IEnumerator LoadAssetBundle(CharacterNameID charID)
    {
        CharBundleManager.<LoadAssetBundle>d__12 val_1 = new CharBundleManager.<LoadAssetBundle>d__12();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .charID = charID;
        return (System.Collections.IEnumerator)val_1;
    }
    public void UnloadUnusedAssets(CharacterNameID charID, CharacterAssetLoader loaderRef)
    {
        System.Collections.Generic.List<CharacterAssetLoader>[] val_1 = CharBundleManager.loaderReferences + (((long)(int)(charID)) << 3);
        bool val_2 = (CharBundleManager.loaderReferences + ((long)(int)(charID)) << 3) + 32.Remove(item:  loaderRef);
        CharBundleManager.UnloadUnusedAssets();
    }
    public static void UnloadUnusedAssets()
    {
        System.DateTime val_1 = System.DateTime.Now;
        System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_1.dateData}, d2:  new System.DateTime() {dateData = CharBundleManager.lastReleaseTime});
        if((float)val_2._ticks.TotalSeconds < 0)
        {
                return;
        }
        
        System.DateTime val_4 = System.DateTime.Now;
        CharBundleManager.lastReleaseTime = val_4.dateData;
        UnityEngine.AsyncOperation val_5 = UnityEngine.Resources.UnloadUnusedAssets();
    }
    private void UnloadAll()
    {
        goto label_1;
        label_15:
        mem2[0] = 0;
        if((CharBundleManager.charBundles.Length + 32) != 0)
        {
                CharBundleManager.charBundles.Length + 32.Unload(unloadAllLoadedObjects:  true);
            mem2[0] = 0;
        }
        
        0 = 1;
        label_1:
        if(0 < CharBundleManager.charBundles.Length)
        {
            goto label_15;
        }
    
    }
    private void OnDestroy()
    {
        this.UnloadAll();
    }
    public CharBundleManager()
    {
    
    }

}
