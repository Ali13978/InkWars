using UnityEngine;
public class TwitterFollowButton : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<UnityEngine.UI.Button> twitterButtons;
    public UnityEngine.GameObject pinGroup;
    public UnityEngine.UI.Button pinConfirmButton;
    public UnityEngine.UI.InputField pinInputField;
    public System.Collections.Generic.List<UnityEngine.GameObject> enableOnSuccess;
    public System.Collections.Generic.List<UnityEngine.GameObject> disableOnSuccess;
    public System.Collections.Generic.List<UnityEngine.GameObject> enableOnFail;
    public System.Collections.Generic.List<UnityEngine.GameObject> disableOnFail;
    public UnityEngine.Events.UnityEvent OnTwitterFollowSuccess;
    public UnityEngine.Events.UnityEvent OnErrorHappens;
    private string pin;
    private const string CONSUMER_KEY = "172,uYi2Jdhsn3aLeFGuHXSlgMFuYDpxOpTkeob+KOQEOcJlDnbdbsH6ksL7+KQa3Yj63c6sHnh/vWWMKhuzz4zoI2ge45GZcbN8MuDV0quxlbazswgzF+s8pBjuMg4E8g3URohFMxkyi21Jn8HCrE3hjGYoEKc/1BezFvgrwkyN4ZA=W4LyYMQO17cu22549on1geUA77Z+/9xcEtQwxXDcIJM=";
    private const string CONSUMER_SECRET = "172,buYfGs6dJ34Wuw7KA8X6Qa42gtUO3ce8WGMa1jZuhU3VqRrfzBxB+C0AmIGGC1X3vS2r/rQTp8dq1XJbMm3IkCosCVUjtx00WFBVf/89hzLPXBHEwbSqAYSVQkqJkkh36fo/Mz4M0HE6Nbqr0CzVwY7VMZQvYkkEz5SeXcVMT2U=11owx1OsWv6IzEE0wBErxDeEnJoD75vMdVr1dnQvWhLEzvpIK7D01xDg5vwKoy5A4bJmZFtKgdbCR6FYULfXoQ==";
    private const string FOLLOW_API = "172,mTS9FlfzEeVcewSaSk2afb1n5GN/bXfNEIs/FFygHz0V2jGqSaPAmSZWVUtefoNs73MmNXnVcTocpQRmYjTDvJZ1pc7sbJA0f88OkcL7y6ZWKQUwiflQphO0OcPm1pJNhVgBmxpIcFgIoWjRy71YQxFxsH+Mt6c5g++ASFwUPxA=oc5vfrbWXE3pZu/QB8+0wyaJV76oozs0fGp3D5Ow20o=";
    private const string INKWARS_TWITTER_ID = "172,uUFtx9KRGPo1JuKQFPa2RDqZNYnJgQhAiiWcRg8xWWeAKyghVY4/iaYW5mTB2YXlAv+RJCwKwQ6ey1XNuhNrXA4kB/nwXUjac3UfOXkrySvVlZEL5bVxxRM94apQoVXhFG5ckZKRTdohUhjA/uKzDSEdp8aSx/5M9s5rjVCL2RY=7bNn7c6ZER8r2jX2uKc5vQ==";
    private Twitter.RequestTokenResponse m_RequestTokenResponse;
    private Twitter.AccessTokenResponse m_AccessTokenResponse;
    
    // Methods
    public void RefreshButtonCallbacks()
    {
        object val_9;
        var val_10;
        val_9 = this;
        val_10 = null;
        val_10 = null;
        if((TwitterFollowButton.<>c.<>9__17_0) == null)
        {
            goto label_3;
        }
        
        label_15:
        int val_1 = this.twitterButtons.RemoveAll(match:  TwitterFollowButton.<>c.<>9__17_0);
        List.Enumerator<T> val_2 = this.twitterButtons.GetEnumerator();
        label_11:
        if(((-1557049480) & 1) == 0)
        {
            goto label_6;
        }
        
        System.Type val_3 = 0.InitialType;
        new UnityEngine.Events.UnityAction() = new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void TwitterFollowButton::OnFollowButtonClick());
        val_3.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction());
        new UnityEngine.Events.UnityAction() = new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void TwitterFollowButton::OnFollowButtonClick());
        val_3.onClick.AddListener(call:  new UnityEngine.Events.UnityAction());
        goto label_11;
        label_3:
        TwitterFollowButton.<>c.<>9__17_0 = new System.Predicate<UnityEngine.UI.Button>(object:  TwitterFollowButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean TwitterFollowButton.<>c::<RefreshButtonCallbacks>b__17_0(UnityEngine.UI.Button x));
        if(this.twitterButtons != null)
        {
            goto label_15;
        }
        
        goto label_15;
        label_6:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Button>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<UnityEngine.UI.Button>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
    }
    private void Awake()
    {
        var val_11 = null;
        if((TwitterFollowButton.<>c.<>9__18_0) == null)
        {
            goto label_3;
        }
        
        label_13:
        int val_1 = this.twitterButtons.RemoveAll(match:  TwitterFollowButton.<>c.<>9__18_0);
        List.Enumerator<T> val_2 = this.twitterButtons.GetEnumerator();
        label_9:
        if(((-1556852488) & 1) == 0)
        {
            goto label_6;
        }
        
        new UnityEngine.Events.UnityAction() = new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void TwitterFollowButton::OnFollowButtonClick());
        0.InitialType.onClick.AddListener(call:  new UnityEngine.Events.UnityAction());
        goto label_9;
        label_3:
        TwitterFollowButton.<>c.<>9__18_0 = new System.Predicate<UnityEngine.UI.Button>(object:  TwitterFollowButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean TwitterFollowButton.<>c::<Awake>b__18_0(UnityEngine.UI.Button x));
        if(this.twitterButtons != null)
        {
            goto label_13;
        }
        
        goto label_13;
        label_6:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Button>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<UnityEngine.UI.Button>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
        this.pinConfirmButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void TwitterFollowButton::OnPinConfirmButtonClick()));
        this.pinInputField.onEndEdit.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void TwitterFollowButton::<Awake>b__18_1(string text)));
    }
    private void OnEnable()
    {
        this.Reset();
    }
    private void OnDisable()
    {
        object val_7;
        var val_8;
        val_7 = this;
        val_8 = null;
        val_8 = null;
        if((TwitterFollowButton.<>c.<>9__20_0) == null)
        {
            goto label_3;
        }
        
        label_13:
        int val_1 = this.twitterButtons.RemoveAll(match:  TwitterFollowButton.<>c.<>9__20_0);
        List.Enumerator<T> val_2 = this.twitterButtons.GetEnumerator();
        label_9:
        if(((-1556553736) & 1) == 0)
        {
            goto label_6;
        }
        
        new UnityEngine.Events.UnityAction() = new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void TwitterFollowButton::OnFollowButtonClick());
        0.InitialType.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction());
        goto label_9;
        label_3:
        TwitterFollowButton.<>c.<>9__20_0 = new System.Predicate<UnityEngine.UI.Button>(object:  TwitterFollowButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean TwitterFollowButton.<>c::<OnDisable>b__20_0(UnityEngine.UI.Button x));
        if(this.twitterButtons != null)
        {
            goto label_13;
        }
        
        goto label_13;
        label_6:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Button>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<UnityEngine.UI.Button>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
    }
    private void Reset()
    {
        var val_5 = null;
        if((TwitterFollowButton.<>c.<>9__21_0) == null)
        {
            goto label_3;
        }
        
        label_12:
        int val_1 = this.twitterButtons.RemoveAll(match:  TwitterFollowButton.<>c.<>9__21_0);
        List.Enumerator<T> val_2 = this.twitterButtons.GetEnumerator();
        label_8:
        if(((-1556383352) & 1) == 0)
        {
            goto label_6;
        }
        
        0.InitialType.interactable = true;
        goto label_8;
        label_3:
        TwitterFollowButton.<>c.<>9__21_0 = new System.Predicate<UnityEngine.UI.Button>(object:  TwitterFollowButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean TwitterFollowButton.<>c::<Reset>b__21_0(UnityEngine.UI.Button x));
        if(this.twitterButtons != null)
        {
            goto label_12;
        }
        
        goto label_12;
        label_6:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Button>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<UnityEngine.UI.Button>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
        this.pinGroup.SetActive(value:  false);
        this.pinConfirmButton.interactable = true;
        this.pinInputField.interactable = true;
        this.pinInputField.text = 0;
        this.RefreshButtonCallbacks();
    }
    public void OnFollowButtonClick()
    {
        var val_9 = null;
        if((TwitterFollowButton.<>c.<>9__22_0) == null)
        {
            goto label_3;
        }
        
        label_12:
        int val_1 = this.twitterButtons.RemoveAll(match:  TwitterFollowButton.<>c.<>9__22_0);
        List.Enumerator<T> val_2 = this.twitterButtons.GetEnumerator();
        label_8:
        if(((-1556195064) & 1) == 0)
        {
            goto label_6;
        }
        
        0.InitialType.interactable = false;
        goto label_8;
        label_3:
        TwitterFollowButton.<>c.<>9__22_0 = new System.Predicate<UnityEngine.UI.Button>(object:  TwitterFollowButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean TwitterFollowButton.<>c::<OnFollowButtonClick>b__22_0(UnityEngine.UI.Button x));
        if(this.twitterButtons != null)
        {
            goto label_12;
        }
        
        goto label_12;
        label_6:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Button>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<UnityEngine.UI.Button>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
        string val_5 = CMS.IO.ReadOnlyDataFile.GetReadOnlyString(source:  "172,uYi2Jdhsn3aLeFGuHXSlgMFuYDpxOpTkeob+KOQEOcJlDnbdbsH6ksL7+KQa3Yj63c6sHnh/vWWMKhuzz4zoI2ge45GZcbN8MuDV0quxlbazswgzF+s8pBjuMg4E8g3URohFMxkyi21Jn8HCrE3hjGYoEKc/1BezFvgrwkyN4ZA=W4LyYMQO17cu22549on1geUA77Z+/9xcEtQwxXDcIJM=");
        mem[1152921528820524384] = this;
        mem[1152921528820524392] = System.Void TwitterFollowButton::OnRequestTokenCallback(bool success, Twitter.RequestTokenResponse response);
        mem[1152921528820524368] = System.Void TwitterFollowButton::OnRequestTokenCallback(bool success, Twitter.RequestTokenResponse response);
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  Twitter.API.GetRequestToken(consumerKey:  val_5, consumerSecret:  val_5.GetConsumerSecret(), callback:  new Twitter.RequestTokenCallback()));
        this.pinGroup.SetActive(value:  true);
    }
    private void OnRequestTokenCallback(bool success, Twitter.RequestTokenResponse response)
    {
        if(success != false)
        {
                this.m_RequestTokenResponse = response;
            Twitter.API.OpenAuthorizationPage(requestToken:  response.<Token>k__BackingField);
            return;
        }
        
        UnityEngine.MonoBehaviour.print(message:  "OnRequestTokenCallback - failed.");
        this.Reset();
        this.SetObjectsEnable(list:  this.enableOnFail, enable:  true);
        this.SetObjectsEnable(list:  this.disableOnFail, enable:  false);
        this.OnErrorHappens.Invoke();
        DialogPanel val_4 = DialogManager.Show(title:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Title"), message:  LanguageManager.GetText(key:  "LK.Twitter.AuthorizeFailed1"), cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close"), onCancelCallback:  0);
    }
    public void OnPinConfirmButtonClick()
    {
        this.pinInputField.interactable = false;
        this.pinConfirmButton.interactable = false;
        string val_1 = CMS.IO.ReadOnlyDataFile.GetReadOnlyString(source:  "172,uYi2Jdhsn3aLeFGuHXSlgMFuYDpxOpTkeob+KOQEOcJlDnbdbsH6ksL7+KQa3Yj63c6sHnh/vWWMKhuzz4zoI2ge45GZcbN8MuDV0quxlbazswgzF+s8pBjuMg4E8g3URohFMxkyi21Jn8HCrE3hjGYoEKc/1BezFvgrwkyN4ZA=W4LyYMQO17cu22549on1geUA77Z+/9xcEtQwxXDcIJM=");
        mem[1152921528820913520] = this;
        mem[1152921528820913528] = System.Void TwitterFollowButton::OnAccessTokenCallback(bool success, Twitter.AccessTokenResponse response);
        mem[1152921528820913504] = System.Void TwitterFollowButton::OnAccessTokenCallback(bool success, Twitter.AccessTokenResponse response);
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  Twitter.API.GetAccessToken(consumerKey:  val_1, consumerSecret:  val_1.GetConsumerSecret(), requestToken:  this.m_RequestTokenResponse.<Token>k__BackingField, pin:  this.pin, callback:  new Twitter.AccessTokenCallback()));
        this.pinGroup.SetActive(value:  true);
    }
    private void OnAccessTokenCallback(bool success, Twitter.AccessTokenResponse response)
    {
        var val_12;
        if(success == false)
        {
            goto label_1;
        }
        
        this.m_AccessTokenResponse = response;
        val_12 = null;
        Twitter.Oauth.<accessToken>k__BackingField = response.<Token>k__BackingField;
        val_12 = null;
        Twitter.Oauth.<accessTokenSecret>k__BackingField = response.<TokenSecret>k__BackingField;
        Twitter.Oauth.<consumerKey>k__BackingField = CMS.IO.ReadOnlyDataFile.GetReadOnlyString(source:  "172,uYi2Jdhsn3aLeFGuHXSlgMFuYDpxOpTkeob+KOQEOcJlDnbdbsH6ksL7+KQa3Yj63c6sHnh/vWWMKhuzz4zoI2ge45GZcbN8MuDV0quxlbazswgzF+s8pBjuMg4E8g3URohFMxkyi21Jn8HCrE3hjGYoEKc/1BezFvgrwkyN4ZA=W4LyYMQO17cu22549on1geUA77Z+/9xcEtQwxXDcIJM=");
        Twitter.Oauth.<consumerSecret>k__BackingField = this.GetConsumerSecret();
        System.Collections.Generic.Dictionary<System.String, System.String> val_3 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        string val_4 = CMS.IO.ReadOnlyDataFile.GetReadOnlyString(source:  "172,uUFtx9KRGPo1JuKQFPa2RDqZNYnJgQhAiiWcRg8xWWeAKyghVY4/iaYW5mTB2YXlAv+RJCwKwQ6ey1XNuhNrXA4kB/nwXUjac3UfOXkrySvVlZEL5bVxxRM94apQoVXhFG5ckZKRTdohUhjA/uKzDSEdp8aSx/5M9s5rjVCL2RY=7bNn7c6ZER8r2jX2uKc5vQ==");
        if(val_3 == null)
        {
            goto label_7;
        }
        
        val_3.Add(key:  "user_id", value:  val_4);
        goto label_8;
        label_1:
        UnityEngine.MonoBehaviour.print(message:  "OnAccessTokenCallback - failed.");
        this.Reset();
        this.SetObjectsEnable(list:  this.enableOnFail, enable:  true);
        this.SetObjectsEnable(list:  this.disableOnFail, enable:  false);
        this.OnErrorHappens.Invoke();
        DialogPanel val_8 = DialogManager.Show(title:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Title"), message:  LanguageManager.GetText(key:  "LK.Twitter.AuthorizeFailed2"), cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close"), onCancelCallback:  0);
        return;
        label_7:
        val_3.Add(key:  "user_id", value:  val_4);
        label_8:
        val_3.Add(key:  "follow", value:  "false");
        mem[1152921528821179536] = this;
        mem[1152921528821179544] = System.Void TwitterFollowButton::Callback(bool success, string response);
        mem[1152921528821179520] = System.Void TwitterFollowButton::Callback(bool success, string response);
        UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  Twitter.Client.Post(APIPath:  CMS.IO.ReadOnlyDataFile.GetReadOnlyString(source:  "172,mTS9FlfzEeVcewSaSk2afb1n5GN/bXfNEIs/FFygHz0V2jGqSaPAmSZWVUtefoNs73MmNXnVcTocpQRmYjTDvJZ1pc7sbJA0f88OkcL7y6ZWKQUwiflQphO0OcPm1pJNhVgBmxpIcFgIoWjRy71YQxFxsH+Mt6c5g++ASFwUPxA=oc5vfrbWXE3pZu/QB8+0wyaJV76oozs0fGp3D5Ow20o="), APIParams:  val_3, callback:  new Twitter.TwitterCallback()));
    }
    private void Callback(bool success, string response)
    {
        var val_6;
        UnityEngine.Events.UnityEvent val_7;
        UnityEngine.Debug.Log(message:  success);
        UnityEngine.Debug.Log(message:  response);
        if(success != false)
        {
                val_6 = null;
            val_6 = null;
            DataStructs.UserDataDictionary.Items.SetCharacterUnlock(id:  1, unlocked:  true, displayAvatarUnlockPopup:  true);
            GameAudio.PlayPurchaseSound();
            this.SetObjectsEnable(list:  this.enableOnSuccess, enable:  true);
            this.SetObjectsEnable(list:  this.disableOnSuccess, enable:  false);
            val_7 = this.OnTwitterFollowSuccess;
            val_7.Invoke();
            return;
        }
        
        this.Reset();
        this.SetObjectsEnable(list:  this.enableOnFail, enable:  true);
        this.SetObjectsEnable(list:  this.disableOnFail, enable:  false);
        this.OnErrorHappens.Invoke();
        val_7 = LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Title");
        DialogPanel val_5 = DialogManager.Show(title:  val_7, message:  LanguageManager.GetText(key:  "LK.Twitter.AuthorizeFailed2"), cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close"), onCancelCallback:  0);
    }
    private void SetObjectsEnable(System.Collections.Generic.List<UnityEngine.GameObject> list, bool enable)
    {
        var val_6;
        bool val_7;
        var val_8;
        System.Predicate<UnityEngine.GameObject> val_10;
        val_7 = enable;
        if(list == null)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_10 = TwitterFollowButton.<>c.<>9__27_0;
        if(val_10 == null)
        {
                System.Predicate<UnityEngine.GameObject> val_1 = null;
            val_10 = val_1;
            val_1 = new System.Predicate<UnityEngine.GameObject>(object:  TwitterFollowButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean TwitterFollowButton.<>c::<SetObjectsEnable>b__27_0(UnityEngine.GameObject x));
            TwitterFollowButton.<>c.<>9__27_0 = val_10;
        }
        
        int val_2 = list.RemoveAll(match:  val_1);
        List.Enumerator<T> val_3 = list.GetEnumerator();
        val_6 = 1152921528222554640;
        val_7 = val_7;
        label_9:
        if(((-1555167432) & 1) == 0)
        {
            goto label_7;
        }
        
        0.InitialType.SetActive(value:  val_7);
        goto label_9;
        label_7:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.GameObject>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<UnityEngine.GameObject>::RemoveAll(System.Predicate<T> match), drivenProperties:  public System.Void System.Predicate<UnityEngine.GameObject>::.ctor(object object, IntPtr method));
    }
    private string GetConsumerSecret()
    {
        return CMS.IO.ReadOnlyDataFile.GetReadOnlyString(source:  "172,buYfGs6dJ34Wuw7KA8X6Qa42gtUO3ce8WGMa1jZuhU3VqRrfzBxB+C0AmIGGC1X3vS2r/rQTp8dq1XJbMm3IkCosCVUjtx00WFBVf/89hzLPXBHEwbSqAYSVQkqJkkh36fo/Mz4M0HE6Nbqr0CzVwY7VMZQvYkkEz5SeXcVMT2U=11owx1OsWv6IzEE0wBErxDeEnJoD75vMdVr1dnQvWhLEzvpIK7D01xDg5vwKoy5A4bJmZFtKgdbCR6FYULfXoQ==");
    }
    public TwitterFollowButton()
    {
        this.OnTwitterFollowSuccess = new UnityEngine.Events.UnityEvent();
        this.OnErrorHappens = new UnityEngine.Events.UnityEvent();
    }
    private void <Awake>b__18_1(string text)
    {
        this.pin = text;
    }

}
