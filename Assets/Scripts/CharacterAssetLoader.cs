using UnityEngine;
public class CharacterAssetLoader : MonoBehaviour
{
    // Fields
    public bool ready;
    public CharacterNameID charID;
    private UnityEngine.AssetBundle bundle;
    
    // Methods
    public static void Get(CharacterNameID id, UnityEngine.Events.UnityAction<CharacterAssetLoader> callback)
    {
        var val_14;
        System.Collections.IEnumerator val_15;
        val_14 = 0;
        goto label_3;
        label_9:
        if((val_1[0x0][0] + 28) == id)
        {
                if((val_1[0x0][0] + 24) != 0)
        {
            goto label_7;
        }
        
        }
        
        val_14 = 1;
        label_3:
        if(val_14 < val_1.Length)
        {
            goto label_9;
        }
        
        UnityEngine.GameObject val_2 = new UnityEngine.GameObject();
        id.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
        val_2.name = "CharacterAssetLoader-"("CharacterAssetLoader-") + id.ToString();
        if(0 != Instance_Manager.Instance)
        {
                val_2.transform.SetParent(p:  Instance_Manager.Instance.transform);
        }
        
        CharacterAssetLoader val_10 = val_2.AddComponent<CharacterAssetLoader>();
        if(val_10 == null)
        {
            goto label_20;
        }
        
        val_15 = val_10.RetrieveBundle(inputCharID:  null, callback:  callback);
        goto label_21;
        label_7:
        if(callback == null)
        {
                return;
        }
        
        callback.Invoke(arg0:  UnityEngine.Object.FindObjectsOfType<CharacterAssetLoader>()[0]);
        return;
        label_20:
        val_15 = val_10.RetrieveBundle(inputCharID:  null, callback:  callback);
        label_21:
        UnityEngine.Coroutine val_13 = val_10.StartCoroutine(routine:  val_15);
    }
    public System.Collections.IEnumerator RetrieveBundle(CharacterNameID inputCharID, UnityEngine.Events.UnityAction<CharacterAssetLoader> callback)
    {
        CharacterAssetLoader.<RetrieveBundle>d__4 val_1 = new CharacterAssetLoader.<RetrieveBundle>d__4();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .inputCharID = inputCharID;
        }
        else
        {
                mem[32] = this;
            mem[40] = inputCharID;
        }
        
        .callback = callback;
        return (System.Collections.IEnumerator)val_1;
    }
    public CharacterData LoadCharacterData()
    {
        this.charID.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        this.charID = null;
        return this.LoadAssets<CharacterData>(fileName:  this.charID.ToString());
    }
    public CharacterAllAnimations LoadAnimations_All()
    {
        CharacterAllAnimations val_0;
        val_0.loseLead = this.LoadAnimation(animationName:  9);
        val_0.lose = this.LoadAnimation(animationName:  10);
        val_0.postAttack = this.LoadAnimation(animationName:  11);
        val_0.postReceiveDamage = this.LoadAnimation(animationName:  12);
        val_0.receiveDamage = this.LoadAnimation(animationName:  13);
        val_0.receiveDamageLose = this.LoadAnimation(animationName:  14);
        val_0.attack = this.LoadAnimation(animationName:  0);
        val_0.winLead = this.LoadAnimation(animationName:  15);
        val_0.win = this.LoadAnimation(animationName:  16);
        val_0.attackChargeLead = this.LoadAnimation(animationName:  1);
        val_0.attackCharge = this.LoadAnimation(animationName:  2);
        val_0.defence = this.LoadAnimation(animationName:  3);
        val_0.defenceChargeLead = this.LoadAnimation(animationName:  4);
        val_0.defenceCharge = this.LoadAnimation(animationName:  5);
        val_0.drawLead = this.LoadAnimation(animationName:  6);
        val_0.draw = this.LoadAnimation(animationName:  7);
        val_0.idle = this.LoadAnimation(animationName:  8);
        return val_0;
    }
    public AnimationData LoadAnimation(CharacterAnimationName animationName)
    {
        string val_1 = CharNameIDConverter.ToString(enumID:  this.charID);
        if(this.bundle != null)
        {
                return this.bundle.LoadAsset<AnimationData>(name:  AnimConverter.ToString(animName:  animationName).ToUpper());
        }
        
        return this.bundle.LoadAsset<AnimationData>(name:  AnimConverter.ToString(animName:  animationName).ToUpper());
    }
    public UnityEngine.Sprite LoadAvatar_Main()
    {
        return this.LoadSprite(fileName:  CharNameIDConverter.ToString(enumID:  this.charID)(CharNameIDConverter.ToString(enumID:  this.charID)) + "_Avatar");
    }
    public UnityEngine.Sprite LoadAvatar_MainInked()
    {
        return this.LoadSprite(fileName:  CharNameIDConverter.ToString(enumID:  this.charID)(CharNameIDConverter.ToString(enumID:  this.charID)) + "_Inked_Avatar");
    }
    public UnityEngine.Sprite LoadAvatar_Unlocked()
    {
        return this.LoadSprite(fileName:  CharNameIDConverter.ToString(enumID:  this.charID)(CharNameIDConverter.ToString(enumID:  this.charID)) + "_Avatar_Unlocked");
    }
    public UnityEngine.Sprite LoadAvatar_Photo()
    {
        return this.LoadSprite(fileName:  CharNameIDConverter.ToString(enumID:  this.charID)(CharNameIDConverter.ToString(enumID:  this.charID)) + "_Avatar_Photo");
    }
    public UnityEngine.Sprite LoadPose_VS()
    {
        return this.LoadSprite(fileName:  CharNameIDConverter.ToString(enumID:  this.charID)(CharNameIDConverter.ToString(enumID:  this.charID)) + "_Pose_VS");
    }
    public UnityEngine.Sprite LoadPose_Dynamic()
    {
        return this.LoadSprite(fileName:  CharNameIDConverter.ToString(enumID:  this.charID)(CharNameIDConverter.ToString(enumID:  this.charID)) + "_Pose_Dynamic");
    }
    public UnityEngine.Sprite LoadPose_LoseInked()
    {
        return this.LoadSprite(fileName:  CharNameIDConverter.ToString(enumID:  this.charID)(CharNameIDConverter.ToString(enumID:  this.charID)) + "_Pose_Lose_Inked");
    }
    public CharacterPostMatchPoseCollection LoadPoseCollection()
    {
        return this.LoadAssets<CharacterPostMatchPoseCollection>(fileName:  CharNameIDConverter.ToString(enumID:  this.charID)(CharNameIDConverter.ToString(enumID:  this.charID)) + "_Pose_Collection");
    }
    public CharacterAudio LoadAudio_All()
    {
        CharacterAudio val_0;
        System.Collections.Generic.List<UnityEngine.AudioClip> val_1 = this.LoadAudio(audioName:  0);
        System.Collections.Generic.List<UnityEngine.AudioClip> val_2 = this.LoadAudio(audioName:  1);
        System.Collections.Generic.List<UnityEngine.AudioClip> val_3 = this.LoadAudio(audioName:  2);
        System.Collections.Generic.List<UnityEngine.AudioClip> val_4 = this.LoadAudio(audioName:  3);
        System.Collections.Generic.List<UnityEngine.AudioClip> val_5 = this.LoadAudio(audioName:  4);
        System.Collections.Generic.List<UnityEngine.AudioClip> val_6 = this.LoadAudio(audioName:  5);
        System.Collections.Generic.List<UnityEngine.AudioClip> val_7 = this.LoadAudio(audioName:  6);
        System.Collections.Generic.List<UnityEngine.AudioClip> val_8 = this.LoadAudio(audioName:  7);
        System.Collections.Generic.List<UnityEngine.AudioClip> val_9 = this.LoadAudio(audioName:  8);
        System.Collections.Generic.List<UnityEngine.AudioClip> val_10 = this.LoadAudio(audioName:  9);
        System.Collections.Generic.List<UnityEngine.AudioClip> val_11 = this.LoadAudio(audioName:  10);
        System.Collections.Generic.List<UnityEngine.AudioClip> val_12 = this.LoadAudio(audioName:  11);
        System.Collections.Generic.List<UnityEngine.AudioClip> val_13 = this.LoadAudio(audioName:  12);
        System.Collections.Generic.List<UnityEngine.AudioClip> val_14 = this.LoadAudio(audioName:  13);
        System.Collections.Generic.List<UnityEngine.AudioClip> val_15 = this.LoadAudio(audioName:  14);
        System.Collections.Generic.List<UnityEngine.AudioClip> val_16 = this.LoadAudio(audioName:  15);
        System.Collections.Generic.List<UnityEngine.AudioClip> val_17 = this.LoadAudio(audioName:  16);
        return val_0;
    }
    public System.Collections.Generic.List<UnityEngine.AudioClip> LoadAudio(CharacterAnimationName audioName)
    {
        string val_1 = CharNameIDConverter.ToString(enumID:  this.charID);
        return this.LoadList<UnityEngine.AudioClip>(strCharID:  val_1, bundleListName:  val_1 + "_" + AnimConverter.ToString(animName:  audioName)(AnimConverter.ToString(animName:  audioName)) + "_Audio_Bundle.g");
    }
    private void ErrorLog(string error)
    {
    
    }
    private T LoadAssets<T>(string fileName)
    {
        if(this.bundle != 0)
        {
                return (CharacterData)this.bundle;
        }
        
        this.ErrorLog(error:  "Asset could not be found. Filepath: "("Asset could not be found. Filepath: ") + fileName);
        return (CharacterData)this.bundle;
    }
    private UnityEngine.Sprite LoadSprite(string fileName)
    {
        UnityEngine.Sprite val_1 = this.bundle.LoadAsset<UnityEngine.Sprite>(name:  fileName);
        if(val_1 != 0)
        {
                return val_1;
        }
        
        string val_3 = "Sprite could not be found. Filepath: "("Sprite could not be found. Filepath: ") + fileName;
        return val_1;
    }
    private System.Collections.Generic.List<T> LoadList<T>(string strCharID, string bundleListName)
    {
        UnityEngine.AssetBundle val_9;
        var val_10;
        var val_11;
        string val_12;
        val_9 = this.bundle;
        UnityEngine.TextAsset val_1 = val_9.LoadAsset<UnityEngine.TextAsset>(name:  bundleListName);
        if(val_1 == 0)
        {
                return (System.Collections.Generic.List<T>)__RuntimeMethodHiddenParam + 48;
        }
        
        char[] val_3 = new char[1];
        val_9 = val_3;
        val_10 = "\n";
        if("\n" == null)
        {
                val_10 = "\n";
        }
        
        val_9[0] = Chars[0];
        val_11 = 0;
        goto label_11;
        label_24:
        val_12 = val_1.Split(separator:  val_3)[0].Replace(oldValue:  "\r", newValue:  "");
        mem2[0] = val_12;
        if(val_11 >= val_5.Length)
        {
                val_12 = mem[val_5[0x0] + 32];
            val_12 = val_5[0x0] + 32;
        }
        
        val_9 = this.bundle;
        bool val_7 = UnityEngine.Object.op_Implicit(exists:  val_9);
        val_11 = 1;
        label_11:
        if(val_11 < (val_5.Length - 1))
        {
            goto label_24;
        }
        
        return (System.Collections.Generic.List<T>)__RuntimeMethodHiddenParam + 48;
    }
    public static UnityEngine.Sprite LoadResource_CharacterStatType(CharacterNameID charNameID, bool left)
    {
        string val_7;
        var val_8;
        if((Character_GlobalInfo.GetStatType(charNameID:  charNameID)) <= 13)
        {
                var val_7 = 40837280 + (val_1) << 2;
            val_7 = val_7 + 40837280;
        }
        else
        {
                val_7 = "Hero";
            if((UnityEngine.Resources.Load(path:  "Characters/Type/"("Characters/Type/") +  + (left != true) ? "_Left" : "_Right"((left != true) ? "_Left" : "_Right"), systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == null)
        {
                return (UnityEngine.Sprite)val_8;
        }
        
            if(null == null)
        {
                return (UnityEngine.Sprite)val_8;
        }
        
            val_8 = 0;
            return (UnityEngine.Sprite)val_8;
        }
    
    }
    public static UnityEngine.Sprite LoadResource_CharacterStatTypeIcon(CharacterNameID charNameID)
    {
        string val_6;
        var val_7;
        if((Character_GlobalInfo.GetStatType(charNameID:  charNameID)) <= 13)
        {
                var val_6 = 40837336 + (val_1) << 2;
            val_6 = val_6 + 40837336;
        }
        else
        {
                val_6 = "Hero";
            if((UnityEngine.Resources.Load(path:  "Characters/TypeIcons/"("Characters/TypeIcons/") +, systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == null)
        {
                return (UnityEngine.Sprite)val_7;
        }
        
            if(null == null)
        {
                return (UnityEngine.Sprite)val_7;
        }
        
            val_7 = 0;
            return (UnityEngine.Sprite)val_7;
        }
    
    }
    public static UnityEngine.Sprite LoadResource_CharacterStatTypeDetailed(CharacterNameID charNameID)
    {
        string val_6;
        var val_7;
        if((Character_GlobalInfo.GetStatType(charNameID:  charNameID)) <= 12)
        {
                var val_6 = 40837392 + (val_1) << 2;
            val_6 = val_6 + 40837392;
        }
        else
        {
                val_6 = "Hero";
            if((UnityEngine.Resources.Load(path:  "Characters/TypeDetailed/"("Characters/TypeDetailed/") +, systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == null)
        {
                return (UnityEngine.Sprite)val_7;
        }
        
            if(null == null)
        {
                return (UnityEngine.Sprite)val_7;
        }
        
            val_7 = 0;
            return (UnityEngine.Sprite)val_7;
        }
    
    }
    public static UnityEngine.Sprite LoadResource_GalleryBackground(CharacterClan clan)
    {
        var val_7;
        if((UnityEngine.Resources.Load(path:  "Characters/GalleryBackground/"("Characters/GalleryBackground/") + (clan == 0) ? "Background_Gallery_Ika_Small" : ((clan == 1) ? "Background_Gallery_Tako_Small" : "Background_Gallery_Ika_Small")((clan == 0) ? "Background_Gallery_Ika_Small" : ((clan == 1) ? "Background_Gallery_Tako_Small" : "Background_Gallery_Ika_Small")), systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == null)
        {
                return (UnityEngine.Sprite)val_7;
        }
        
        if(null == null)
        {
                return (UnityEngine.Sprite)val_7;
        }
        
        val_7 = 0;
        return (UnityEngine.Sprite)val_7;
    }
    private void OnDestroy()
    {
        if(0 == CharBundleManager.instance)
        {
                return;
        }
        
        0.UnloadUnusedAssets(charID:  this.charID, loaderRef:  this);
    }
    public CharacterAssetLoader()
    {
    
    }

}
