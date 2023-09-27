using UnityEngine;

namespace AppAdvisory.SharingSystem
{
    public class VSSHARE : MonoBehaviour
    {
        // Fields
        public bool withText;
        public string fileName;
        public bool isAmazon;
        public bool showButtonShareWhenSceneRestartIfScreenshotAvailable;
        public UnityEngine.GameObject[] ToHideOnTheScreenshot;
        public UnityEngine.GameObject[] ToDisplayOnTheScreenshot;
        private string screenshotPath;
        private string shareTextBeforeUrl;
        private string shareTextAfterUrl;
        public string iD_iOS;
        public string bundleIdAndroid;
        public string amazonID;
        private bool m_isAnimating;
        private bool takeFullScreen;
        private ButtonShareState m_state;
        private UnityEngine.GameObject _spriteGO;
        private static AppAdvisory.SharingSystem.VSSHARE self;
        public UnityEngine.UI.Button buttonOpenOrShareScreenshot;
        public UnityEngine.UI.Button buttonClose;
        public UnityEngine.AudioClip photoSound;
        private UnityEngine.AudioSource audioSource;
        public AppAdvisory.SharingSystem.ScreenshotElement shareElement;
        public UnityEngine.UI.Image flash;
        private UnityEngine.Vector2 VSSHARE_START_POSITION;
        private static AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsClosedHandler OnButtonShareIsClosed;
        private static AppAdvisory.SharingSystem.VSSHARE.OnButtonShareisIconHandler OnButtonShareisIcon;
        private static AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsShareWindowHandler OnButtonShareIsShareWindow;
        private static AppAdvisory.SharingSystem.VSSHARE.OnScreenshotTakenHandler OnScreenshotTaken;
        private static AppAdvisory.SharingSystem.VSSHARE.OnNativeShareWindowOpenedHandler OnNativeShareWindowOpened;
        public bool AndroidForceSDCardPermission;
        
        // Properties
        public string url_ios { get; }
        public string url_android { get; }
        public string url_amazon { get; }
        public string URL_STORE { get; }
        private string ShareText { get; }
        private float width { get; }
        private float height { get; }
        private bool isPortrait { get; }
        private bool isAnimating { get; set; }
        private ButtonShareState state { get; set; }
        public static bool haveScreenshotAvailable { get; }
        private UnityEngine.GameObject spriteGO { get; }
        private UnityEngine.Texture2D screenshot { get; }
        private string FilePath { get; }
        
        // Methods
        public string get_url_ios()
        {
            return "https://itunes.apple.com/us/app/id"("https://itunes.apple.com/us/app/id") + this.iD_iOS;
        }
        public string get_url_android()
        {
            return "https://play.google.com/store/apps/details?id="("https://play.google.com/store/apps/details?id=") + this.bundleIdAndroid;
        }
        public string get_url_amazon()
        {
            return "https://www.amazon.fr/dp/"("https://www.amazon.fr/dp/") + this.amazonID;
        }
        public string get_URL_STORE()
        {
            return "www.inkwarsgame.com";
        }
        private string get_ShareText()
        {
            return this.shareTextBeforeUrl + "www.inkwarsgame.com" + this.shareTextAfterUrl;
        }
        private float get_width()
        {
            return (float)(float)UnityEngine.Screen.width;
        }
        private float get_height()
        {
            return (float)(float)UnityEngine.Screen.height;
        }
        private bool get_isPortrait()
        {
            return (bool)(UnityEngine.Screen.width < UnityEngine.Screen.height) ? 1 : 0;
        }
        private bool get_isAnimating()
        {
            return (bool)this.m_isAnimating;
        }
        private void set_isAnimating(bool value)
        {
            this.m_isAnimating = value;
            value = (~value) & 1;
            this.buttonOpenOrShareScreenshot.enabled = value;
        }
        private ButtonShareState get_state()
        {
            return (ButtonShareState)this.m_state;
        }
        private void set_state(ButtonShareState value)
        {
            if(value == 2)
            {
                goto label_1;
            }
            
            if(value == 1)
            {
                goto label_2;
            }
            
            if((value != 0) || (AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsClosed == null))
            {
                goto label_8;
            }
            
            AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsClosed.Invoke();
            goto label_8;
            label_1:
            if(AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsShareWindow == null)
            {
                goto label_8;
            }
            
            AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsShareWindow.Invoke();
            goto label_8;
            label_2:
            if(AppAdvisory.SharingSystem.VSSHARE.OnButtonShareisIcon != null)
            {
                    AppAdvisory.SharingSystem.VSSHARE.OnButtonShareisIcon.Invoke();
            }
            
            label_8:
            this.m_state = value;
        }
        public static bool get_haveScreenshotAvailable()
        {
            return UnityEngine.Object.op_Inequality(x:  AppAdvisory.SharingSystem.VSSHARE.self.spriteGO, y:  0);
        }
        private UnityEngine.GameObject get_spriteGO()
        {
            UnityEngine.GameObject val_3;
            if(this._spriteGO == 0)
            {
                    this._spriteGO = UnityEngine.GameObject.Find(name:  "__screenshot__");
                return val_3;
            }
            
            val_3 = this._spriteGO;
            return val_3;
        }
        private UnityEngine.Texture2D get_screenshot()
        {
            if((this.spriteGO.GetComponent<TextureContainer>()) != null)
            {
                    return (UnityEngine.Texture2D)val_2.texture;
            }
            
            return (UnityEngine.Texture2D)val_2.texture;
        }
        public static void add_OnButtonShareIsClosed(AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsClosedHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsClosed, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsClosed != 1152921505145880584);
        
        }
        public static void remove_OnButtonShareIsClosed(AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsClosedHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsClosed, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsClosed != 1152921505145880584);
        
        }
        public static void add_OnButtonShareisIcon(AppAdvisory.SharingSystem.VSSHARE.OnButtonShareisIconHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  AppAdvisory.SharingSystem.VSSHARE.OnButtonShareisIcon, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(AppAdvisory.SharingSystem.VSSHARE.OnButtonShareisIcon != 1152921505145880592);
        
        }
        public static void remove_OnButtonShareisIcon(AppAdvisory.SharingSystem.VSSHARE.OnButtonShareisIconHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  AppAdvisory.SharingSystem.VSSHARE.OnButtonShareisIcon, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(AppAdvisory.SharingSystem.VSSHARE.OnButtonShareisIcon != 1152921505145880592);
        
        }
        public static void add_OnButtonShareIsShareWindow(AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsShareWindowHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsShareWindow, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsShareWindow != 1152921505145880600);
        
        }
        public static void remove_OnButtonShareIsShareWindow(AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsShareWindowHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsShareWindow, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(AppAdvisory.SharingSystem.VSSHARE.OnButtonShareIsShareWindow != 1152921505145880600);
        
        }
        public static void add_OnScreenshotTaken(AppAdvisory.SharingSystem.VSSHARE.OnScreenshotTakenHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  AppAdvisory.SharingSystem.VSSHARE.OnScreenshotTaken, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(AppAdvisory.SharingSystem.VSSHARE.OnScreenshotTaken != 1152921505145880608);
        
        }
        public static void remove_OnScreenshotTaken(AppAdvisory.SharingSystem.VSSHARE.OnScreenshotTakenHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  AppAdvisory.SharingSystem.VSSHARE.OnScreenshotTaken, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(AppAdvisory.SharingSystem.VSSHARE.OnScreenshotTaken != 1152921505145880608);
        
        }
        public static void add_OnNativeShareWindowOpened(AppAdvisory.SharingSystem.VSSHARE.OnNativeShareWindowOpenedHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  AppAdvisory.SharingSystem.VSSHARE.OnNativeShareWindowOpened, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(AppAdvisory.SharingSystem.VSSHARE.OnNativeShareWindowOpened != 1152921505145880616);
        
        }
        public static void remove_OnNativeShareWindowOpened(AppAdvisory.SharingSystem.VSSHARE.OnNativeShareWindowOpenedHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  AppAdvisory.SharingSystem.VSSHARE.OnNativeShareWindowOpened, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(AppAdvisory.SharingSystem.VSSHARE.OnNativeShareWindowOpened != 1152921505145880616);
        
        }
        private void SetVisibilityToHideOnScreenshot(bool _isVisible)
        {
            goto label_1;
            label_8:
            UnityEngine.GameObject val_3 = this.ToHideOnTheScreenshot[0];
            if(val_3 != 0)
            {
                    val_3.SetActive(value:  _isVisible);
            }
            
            0 = 1;
            label_1:
            if(0 < this.ToHideOnTheScreenshot.Length)
            {
                goto label_8;
            }
        
        }
        private void SetVisibilityToShowOnScreenshot(bool _isVisible)
        {
            goto label_1;
            label_8:
            UnityEngine.GameObject val_3 = this.ToDisplayOnTheScreenshot[0];
            if(val_3 != 0)
            {
                    val_3.SetActive(value:  _isVisible);
            }
            
            0 = 1;
            label_1:
            if(0 < this.ToDisplayOnTheScreenshot.Length)
            {
                goto label_8;
            }
        
        }
        public bool DoAnimOpenScreenshotAsAButton()
        {
            object val_14;
            UnityEngine.RectTransform val_15;
            var val_16;
            val_14 = this;
            bool val_1 = AppAdvisory.SharingSystem.VSSHARE.haveScreenshotAvailable;
            val_15 = this.shareElement.gameObject;
            if(val_15 == null)
            {
                goto label_2;
            }
            
            if(val_1 == false)
            {
                goto label_3;
            }
            
            label_15:
            val_15.SetActive(value:  true);
            this.SetImage(im:  this.shareElement.image, tex:  this.screenshot);
            this.shareElement.rect.gameObject.SetActive(value:  true);
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            this.shareElement.rect.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            val_15 = this.shareElement.rect;
            System.Action val_11 = new System.Action(object:  this, method:  System.Void AppAdvisory.SharingSystem.VSSHARE::<DoAnimOpenScreenshotAsAButton>b__74_1());
            val_14 = val_11.LerpScale(rect:  val_15, _from:  0f, _to:  1f, time:  0.3f, OnUpdate:  new System.Action(object:  this, method:  System.Void AppAdvisory.SharingSystem.VSSHARE::<DoAnimOpenScreenshotAsAButton>b__74_0()), OnCompleted:  val_11);
            UnityEngine.Coroutine val_13 = AppAdvisory.SharingSystem.VSSHARE.self.StartCoroutine(routine:  val_14);
            val_16 = 1;
            return (bool)val_16;
            label_2:
            if(val_1 == true)
            {
                goto label_15;
            }
            
            label_3:
            val_15.SetActive(value:  false);
            this.state = 0;
            val_16 = 0;
            return (bool)val_16;
        }
        private void ResetFlash()
        {
            UnityEngine.Color val_1 = this.flash.color;
            this.flash.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = 1f};
            this.flash.gameObject.SetActive(value:  false);
        }
        private void DoFlash(System.Action callback)
        {
            System.Collections.IEnumerator val_10;
            VSSHARE.<>c__DisplayClass76_0 val_1 = new VSSHARE.<>c__DisplayClass76_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .callback = callback;
            this.ResetFlash();
            this.flash.gameObject.SetActive(value:  true);
            UnityEngine.AudioSource val_4 = GameAudio.sound.PlayOneShot(clip:  this.photoSound, volume:  1f);
            System.Action val_5 = new System.Action(object:  val_1, method:  System.Void VSSHARE.<>c__DisplayClass76_0::<DoFlash>b__0());
            System.Action val_6 = new System.Action(object:  val_1, method:  System.Void VSSHARE.<>c__DisplayClass76_0::<DoFlash>b__1());
            if(AppAdvisory.SharingSystem.VSSHARE.self != null)
            {
                    val_10 = val_6.DOFade(im:  this.flash, _from:  1f, _to:  0f, time:  0.3f, delay:  0.1f, OnUpdate:  val_5, OnCompleted:  val_6);
            }
            else
            {
                    val_10 = this.DOFade(im:  this.flash, _from:  1f, _to:  0f, time:  0.3f, delay:  0.1f, OnUpdate:  val_5, OnCompleted:  val_6);
            }
            
            UnityEngine.Coroutine val_9 = AppAdvisory.SharingSystem.VSSHARE.self.StartCoroutine(routine:  val_10);
        }
        private void ActivateButtonClose(bool _activate)
        {
            UnityEngine.UI.Image val_12;
            AppAdvisory.SharingSystem.VSSHARE val_13;
            System.Collections.IEnumerator val_14;
            val_12 = _activate;
            if(val_12 != false)
            {
                    if(this.buttonClose == 0)
            {
                    return;
            }
            
                gameObject.SetActive(value:  true);
                enabled = true;
                interactable = true;
                val_13 = AppAdvisory.SharingSystem.VSSHARE.self;
                UnityEngine.UI.Image val_3 = image;
                val_14 = val_3.DOFade(im:  val_3, _from:  0f, _to:  0.7f, time:  0.2f, delay:  0f, OnUpdate:  0, OnCompleted:  0);
            }
            else
            {
                    if(this.buttonClose == 0)
            {
                    return;
            }
            
                this.buttonClose.gameObject.SetActive(value:  true);
                this.buttonClose.enabled = true;
                this.buttonClose.interactable = true;
                val_12 = this.buttonClose.image;
                System.Action val_8 = new System.Action(object:  this, method:  System.Void AppAdvisory.SharingSystem.VSSHARE::<ActivateButtonClose>b__77_0());
                if(AppAdvisory.SharingSystem.VSSHARE.self != null)
            {
                    val_13 = val_8.DOFade(im:  val_12, _from:  0.7f, _to:  0f, time:  0.2f, delay:  0f, OnUpdate:  0, OnCompleted:  val_8);
            }
            else
            {
                    val_13 = this.DOFade(im:  val_12, _from:  0.7f, _to:  0f, time:  0.2f, delay:  0f, OnUpdate:  0, OnCompleted:  val_8);
            }
            
                val_14 = val_13;
            }
            
            UnityEngine.Coroutine val_11 = AppAdvisory.SharingSystem.VSSHARE.self.StartCoroutine(routine:  val_14);
        }
        public void OnClickedHideScreenshotIcon()
        {
            System.Action val_3 = new System.Action(object:  this, method:  System.Void AppAdvisory.SharingSystem.VSSHARE::<OnClickedHideScreenshotIcon>b__78_1());
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  val_3.LerpScale(rect:  this.shareElement.rect, _from:  1f, _to:  0f, time:  0.3f, OnUpdate:  new System.Action(object:  this, method:  System.Void AppAdvisory.SharingSystem.VSSHARE::<OnClickedHideScreenshotIcon>b__78_0()), OnCompleted:  val_3));
        }
        public void OnClickedOnIconScreenshot()
        {
            if(this.m_isAnimating != false)
            {
                    return;
            }
            
            if(this.m_state != 1)
            {
                    if(this.m_state != 2)
            {
                    return;
            }
            
                this.ShareScreenshot(text:  this.ShareText);
                return;
            }
            
            this.ActivateButtonClose(_activate:  true);
            this.AnimIconToWindow();
        }
        private void AnimIconToWindow()
        {
            float val_55;
            float val_56;
            float val_57;
            float val_58;
            var val_59;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            int val_2 = UnityEngine.Screen.width;
            if(this.takeFullScreen == false)
            {
                goto label_3;
            }
            
            float val_52 = (float)val_2;
            float val_4 = UnityEngine.Mathf.Min(a:  val_52, b:  (float)UnityEngine.Screen.height);
            val_52 = val_4 * 0.3f;
            float val_53 = (float)UnityEngine.Screen.height;
            val_4 = (float)UnityEngine.Screen.width - val_52;
            val_53 = val_53 - val_52;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_4, y:  val_53);
            val_55 = val_7.x;
            val_56 = val_7.y;
            val_57 = 2f;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_55, y = val_56}, d:  val_57);
            if((this.GetComponentInParent<UnityEngine.Canvas>().renderMode) != 1)
            {
                goto label_9;
            }
            
            val_55 = (float)UnityEngine.Screen.width - val_52;
            val_56 = (float)UnityEngine.Screen.height - val_52;
            goto label_10;
            label_3:
            if(val_2 < UnityEngine.Screen.height)
            {
                    val_58 = (float)UnityEngine.Screen.width;
                val_59 = 0;
                int val_15 = UnityEngine.Screen.width;
            }
            else
            {
                    val_58 = (float)UnityEngine.Screen.height;
                val_59 = 0;
            }
            
            val_57 = (float)UnityEngine.Screen.height;
            val_55 = val_58 * 0.6f;
            val_56 = val_57 * 0.8f;
            label_10:
            UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  val_55, y:  val_56);
            label_9:
            UnityEngine.Quaternion val_21 = this.shareElement.rect.rotation;
            UnityEngine.Quaternion val_22 = UnityEngine.Quaternion.identity;
            UnityEngine.Coroutine val_24 = AppAdvisory.SharingSystem.VSSHARE.self.StartCoroutine(routine:  this.DORotate(rect:  this.shareElement.rect, _quaternionStart:  new UnityEngine.Quaternion() {x = val_21.x, y = val_21.y, z = val_21.z, w = val_21.w}, _quaternionEnd:  new UnityEngine.Quaternion() {x = val_22.x, y = val_22.y, z = val_22.z, w = val_22.w}, time:  0.3f));
            UnityEngine.Vector3 val_26 = this.shareElement.rect.localPosition;
            UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
            this.shareElement.defaultPosition = val_27;
            mem2[0] = val_27.y;
            float val_54 = (float)UnityEngine.Screen.width;
            float val_55 = 0.5f;
            val_54 = val_54 * val_55;
            val_55 = (float)UnityEngine.Screen.height * val_55;
            UnityEngine.Coroutine val_33 = AppAdvisory.SharingSystem.VSSHARE.self.StartCoroutine(routine:  new UnityEngine.Vector2(x:  val_54, y:  val_55).DOMove(rect:  this.shareElement.rect, _start:  new UnityEngine.Vector2() {x = this.shareElement.defaultPosition, y = val_26.z}, _end:  new UnityEngine.Vector2() {x = val_31.x, y = val_31.y}, time:  0.3f));
            UnityEngine.Vector3 val_35 = this.GetComponent<UnityEngine.RectTransform>().localPosition;
            UnityEngine.Vector2 val_36 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z});
            this.VSSHARE_START_POSITION = val_36;
            mem[1152921529134172020] = val_36.y;
            UnityEngine.Vector2 val_38 = UnityEngine.Vector2.zero;
            UnityEngine.Coroutine val_40 = AppAdvisory.SharingSystem.VSSHARE.self.StartCoroutine(routine:  this.DOMove(rect:  this.GetComponent<UnityEngine.RectTransform>(), _start:  new UnityEngine.Vector2() {x = this.VSSHARE_START_POSITION, y = val_26.z}, _end:  new UnityEngine.Vector2() {x = val_38.x, y = val_38.y}, time:  0.3f));
            UnityEngine.Vector2 val_42 = UnityEngine.Vector2.zero;
            UnityEngine.Vector3 val_43 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_42.x, y = val_42.y});
            this.GetComponent<UnityEngine.RectTransform>().localPosition = new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z};
            UnityEngine.Vector2 val_46 = this.shareElement.rect.sizeDelta;
            UnityEngine.Vector2 val_47 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y}, d:  0.5f);
            System.Action val_49 = new System.Action(object:  this, method:  System.Void AppAdvisory.SharingSystem.VSSHARE::<AnimIconToWindow>b__80_1());
            UnityEngine.Coroutine val_51 = AppAdvisory.SharingSystem.VSSHARE.self.StartCoroutine(routine:  val_49.DOSizeDelta(rect:  this.shareElement.rect, _start:  new UnityEngine.Vector2() {x = val_46.x, y = val_46.y}, _end:  new UnityEngine.Vector2() {x = val_47.x, y = val_47.y}, time:  0.3f, onUpdate:  new System.Action(object:  this, method:  System.Void AppAdvisory.SharingSystem.VSSHARE::<AnimIconToWindow>b__80_0()), callback:  val_49));
        }
        public void ShareScreenshot(string text)
        {
            if(this.withText != false)
            {
                    this.OpenShareImageMobileNativeDialog(shareText:  text);
                return;
            }
            
            this.OpenShareImageOnlyMobileNativeDialog();
        }
        public void OnClickedButtonCloseShareWindow()
        {
            if(this.m_isAnimating == true)
            {
                    return;
            }
            
            this.ActivateButtonClose(_activate:  false);
            UnityEngine.Quaternion val_3 = this.shareElement.rect.rotation;
            UnityEngine.Coroutine val_5 = AppAdvisory.SharingSystem.VSSHARE.self.StartCoroutine(routine:  this.DORotate(rect:  this.shareElement.rect, _quaternionStart:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, _quaternionEnd:  new UnityEngine.Quaternion() {x = this.shareElement.defaultRotation, y = V13.16B, z = V14.16B, w = V15.16B}, time:  0.3f));
            float val_23 = (float)UnityEngine.Screen.width;
            float val_24 = 0.5f;
            val_23 = val_23 * val_24;
            val_24 = (float)UnityEngine.Screen.height * val_24;
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_23, y:  val_24);
            UnityEngine.Coroutine val_11 = AppAdvisory.SharingSystem.VSSHARE.self.StartCoroutine(routine:  this.DOMove(rect:  this.shareElement.rect, _start:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, _end:  new UnityEngine.Vector2() {x = this.shareElement.defaultPosition, y = val_3.z}, time:  0.3f));
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.zero;
            UnityEngine.Coroutine val_15 = AppAdvisory.SharingSystem.VSSHARE.self.StartCoroutine(routine:  this.DOMove(rect:  this.GetComponent<UnityEngine.RectTransform>(), _start:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y}, _end:  new UnityEngine.Vector2() {x = this.VSSHARE_START_POSITION, y = val_3.w}, time:  0.3f));
            UnityEngine.Vector2 val_18 = this.shareElement.rect.sizeDelta;
            this = this.DOSizeDelta(rect:  this.shareElement.rect, _start:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y}, _end:  new UnityEngine.Vector2() {x = this.shareElement.defaultSizeDelta, y = val_13.y}, time:  0.3f, onUpdate:  new System.Action(object:  this, method:  System.Void AppAdvisory.SharingSystem.VSSHARE::<OnClickedButtonCloseShareWindow>b__82_0()), callback:  new System.Action(object:  this, method:  System.Void AppAdvisory.SharingSystem.VSSHARE::<OnClickedButtonCloseShareWindow>b__82_1()));
            UnityEngine.Coroutine val_22 = AppAdvisory.SharingSystem.VSSHARE.self.StartCoroutine(routine:  this);
        }
        public static void DOOnclickedOnIconScreenshot()
        {
            AppAdvisory.SharingSystem.VSSHARE.self.OnClickedOnIconScreenshot();
        }
        public static ButtonShareState GetButtonShareState()
        {
            if(AppAdvisory.SharingSystem.VSSHARE.self != null)
            {
                    return (ButtonShareState)AppAdvisory.SharingSystem.VSSHARE.self.m_state;
            }
            
            return (ButtonShareState)AppAdvisory.SharingSystem.VSSHARE.self.m_state;
        }
        public static bool DOOpenScreenshotButton()
        {
            if(AppAdvisory.SharingSystem.VSSHARE.self != null)
            {
                    return AppAdvisory.SharingSystem.VSSHARE.self.DoAnimOpenScreenshotAsAButton();
            }
            
            return AppAdvisory.SharingSystem.VSSHARE.self.DoAnimOpenScreenshotAsAButton();
        }
        public static void DOHideScreenshotIcon()
        {
            AppAdvisory.SharingSystem.VSSHARE.self.OnClickedHideScreenshotIcon();
        }
        public static void DOShareScreenshot(string text)
        {
            AppAdvisory.SharingSystem.VSSHARE.self.ShareScreenshot(text:  text);
        }
        public static void DOCloseShareWindow()
        {
            AppAdvisory.SharingSystem.VSSHARE.self.OnClickedButtonCloseShareWindow();
        }
        public static void DODesactivate()
        {
            gameObject.SetActive(value:  false);
        }
        public static void DOTakeScreenShot()
        {
            this.TakeScreenshot();
        }
        private System.Collections.IEnumerator LerpScale(UnityEngine.RectTransform rect, float _from, float _to, float time, System.Action OnUpdate, System.Action OnCompleted)
        {
            VSSHARE.<LerpScale>d__91 val_1 = new VSSHARE.<LerpScale>d__91();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .rect = rect;
                ._from = _from;
                ._to = _to;
                .time = time;
                .OnUpdate = OnUpdate;
            }
            else
            {
                    mem[56] = rect;
                mem[40] = _from;
                ._to = _to;
                mem[48] = time;
                mem[32] = OnUpdate;
            }
            
            .OnCompleted = OnCompleted;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator DORotate(UnityEngine.RectTransform rect, UnityEngine.Quaternion _quaternionStart, UnityEngine.Quaternion _quaternionEnd, float time)
        {
            VSSHARE.<DORotate>d__92 val_1 = new VSSHARE.<DORotate>d__92();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .rect = rect;
            }
            else
            {
                    mem[32] = rect;
            }
            
            ._quaternionStart = _quaternionStart;
            mem[1152921529135930860] = _quaternionStart.y;
            mem[1152921529135930864] = _quaternionStart.z;
            mem[1152921529135930868] = _quaternionStart.w;
            ._quaternionEnd = _quaternionEnd;
            mem[1152921529135930876] = _quaternionEnd.y;
            mem[1152921529135930880] = _quaternionEnd.z;
            mem[1152921529135930884] = _quaternionEnd.w;
            .time = time;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator DOMove(UnityEngine.RectTransform rect, UnityEngine.Vector2 _start, UnityEngine.Vector2 _end, float time)
        {
            VSSHARE.<DOMove>d__93 val_1 = new VSSHARE.<DOMove>d__93();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .rect = rect;
                ._start = _start;
                mem[1152921529136059244] = _start.y;
                ._end = _end;
                mem[1152921529136059252] = _end.y;
            }
            else
            {
                    mem[32] = rect;
                mem[40] = _start.x;
                mem[1152921529136059244] = _start.y;
                mem[48] = _end.x;
                mem[1152921529136059252] = _end.y;
            }
            
            .time = time;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator DOSizeDelta(UnityEngine.RectTransform rect, UnityEngine.Vector2 _start, UnityEngine.Vector2 _end, float time, System.Action onUpdate, System.Action callback)
        {
            VSSHARE.<DOSizeDelta>d__94 val_1 = new VSSHARE.<DOSizeDelta>d__94();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .rect = rect;
                ._start = _start;
                mem[1152921529136204012] = _start.y;
                ._end = _end;
                mem[1152921529136204020] = _end.y;
                .time = time;
                .onUpdate = onUpdate;
            }
            else
            {
                    mem[32] = rect;
                mem[40] = _start.x;
                mem[1152921529136204012] = _start.y;
                mem[48] = _end.x;
                mem[1152921529136204020] = _end.y;
                mem[56] = time;
                mem[64] = onUpdate;
            }
            
            .callback = callback;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator DOFade(UnityEngine.UI.Image im, float _from, float _to, float time, float delay, System.Action OnUpdate, System.Action OnCompleted)
        {
            VSSHARE.<DOFade>d__95 val_1 = new VSSHARE.<DOFade>d__95();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .OnUpdate = OnUpdate;
                .im = im;
                ._to = _to;
                ._from = _from;
                .time = time;
                .delay = delay;
            }
            else
            {
                    mem[40] = im;
                mem[64] = _from;
                mem[48] = _to;
                .time = time;
                mem[72] = delay;
                mem[32] = OnUpdate;
            }
            
            .OnCompleted = OnCompleted;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator getScreenshot()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new VSSHARE.<getScreenshot>d__96();
        }
        private string TakeScreenshotNew()
        {
            UnityEngine.Texture2D val_3 = new UnityEngine.Texture2D(width:  UnityEngine.Screen.width, height:  UnityEngine.Screen.height, textureFormat:  3, mipChain:  false);
            int val_4 = UnityEngine.Screen.width;
            int val_5 = UnityEngine.Screen.height;
            val_3.ReadPixels(source:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, destX:  0, destY:  0);
            val_3.Apply();
            System.IO.File.WriteAllBytes(path:  this.FilePath, bytes:  UnityEngine.ImageConversion.EncodeToPNG(tex:  val_3));
            UnityEngine.Object.Destroy(obj:  val_3);
            return (string)this.FilePath;
        }
        private System.Collections.IEnumerator DelayAndShare()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new VSSHARE.<DelayAndShare>d__98();
        }
        private string get_FilePath()
        {
            return System.IO.Path.Combine(path1:  UnityEngine.Application.temporaryCachePath, path2:  this.fileName);
        }
        private void Awake()
        {
            this.audioSource = this.GetComponent<UnityEngine.AudioSource>();
            this.ResetFlash();
            this.shareElement.gameObject.SetActive(value:  false);
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            this.shareElement.GetComponent<UnityEngine.RectTransform>().localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            if(this.buttonClose != 0)
            {
                    this.buttonClose.gameObject.SetActive(value:  false);
            }
            
            this.state = 0;
            this.SetVisibilityToShowOnScreenshot(_isVisible:  false);
        }
        private void Start()
        {
            AppAdvisory.SharingSystem.VSSHARE.self = this;
            UnityEngine.Vector3 val_2 = this.GetComponent<UnityEngine.RectTransform>().position;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            this.VSSHARE_START_POSITION = val_3;
            mem[1152921529137214196] = val_3.y;
            UnityEngine.AndroidJNIHelper.debug = true;
            if(AppAdvisory.SharingSystem.VSSHARE.haveScreenshotAvailable == false)
            {
                    return;
            }
            
            this.shareElement.gameObject.SetActive(value:  true);
            this.SetImage(im:  this.shareElement.image, tex:  this.screenshot);
            if(this.showButtonShareWhenSceneRestartIfScreenshotAvailable == false)
            {
                    return;
            }
            
            bool val_7 = this.DoAnimOpenScreenshotAsAButton();
        }
        private void SetImage(UnityEngine.UI.Image im, UnityEngine.Texture2D tex)
        {
            float val_9;
            var val_10;
            im.sprite = 0;
            int val_1 = UnityEngine.Screen.width;
            if(this.takeFullScreen == false)
            {
                goto label_1;
            }
            
            val_9 = (float)val_1;
            goto label_2;
            label_1:
            if(val_1 >= UnityEngine.Screen.height)
            {
                goto label_3;
            }
            
            val_9 = (float)UnityEngine.Screen.width;
            val_10 = 0;
            int val_4 = UnityEngine.Screen.width;
            goto label_4;
            label_3:
            val_9 = (float)UnityEngine.Screen.height;
            label_2:
            val_10 = 0;
            int val_6 = UnityEngine.Screen.height;
            label_4:
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  0.5f, y:  0.5f);
            im.sprite = UnityEngine.Sprite.Create(texture:  tex, rect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, pivot:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, pixelsPerUnit:  100f);
        }
        public void TakeScreenshot()
        {
            System.Collections.IEnumerator val_4;
            if(AppAdvisory.SharingSystem.VSSHARE.self != null)
            {
                    val_4 = AppAdvisory.SharingSystem.VSSHARE.self.getScreenshot();
            }
            else
            {
                    val_4 = this.getScreenshot();
            }
            
            UnityEngine.Coroutine val_3 = AppAdvisory.SharingSystem.VSSHARE.self.StartCoroutine(routine:  val_4);
        }
        public void ShareScreenshot()
        {
            if(this.withText != false)
            {
                    AppAdvisory.SharingSystem.VSSHARE.self.OpenShareImageMobileNativeDialog(shareText:  this.ShareText);
                return;
            }
            
            AppAdvisory.SharingSystem.VSSHARE.self.OpenShareImageOnlyMobileNativeDialog();
        }
        private void OpenShareImageOnlyMobileNativeDialog()
        {
            this.OpenShareImageMobileNativeDialog(shareText:  "");
        }
        private void OpenShareImageMobileNativeDialog(string shareText)
        {
            if(UnityEngine.Application.isEditor != false)
            {
                    UnityEngine.Debug.LogWarning(message:  "********** Very Simple Share doesn\'t work in the editor. **********");
                return;
            }
            
            UnityEngine.AndroidJavaClass val_3 = new UnityEngine.AndroidJavaClass(className:  "android.content.Intent");
            UnityEngine.AndroidJavaObject val_5 = new UnityEngine.AndroidJavaObject(className:  "android.content.Intent", args:  System.Array.Empty<System.Object>());
            object[] val_6 = new object[1];
            val_6[0] = val_3.GetStatic<System.String>(fieldName:  "ACTION_SEND");
            UnityEngine.AndroidJavaObject val_8 = val_5.Call<UnityEngine.AndroidJavaObject>(methodName:  "setAction", args:  val_6);
            object[] val_10 = new object[1];
            val_10[0] = "file://"("file://") + this.FilePath;
            object[] val_13 = new object[2];
            val_13[0] = val_3.GetStatic<System.String>(fieldName:  "EXTRA_STREAM");
            val_13[1] = new UnityEngine.AndroidJavaClass(className:  "android.net.Uri").CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "parse", args:  val_10);
            UnityEngine.AndroidJavaObject val_15 = val_5.Call<UnityEngine.AndroidJavaObject>(methodName:  "putExtra", args:  val_13);
            object[] val_16 = new object[1];
            val_16[0] = "image/png";
            UnityEngine.AndroidJavaObject val_17 = val_5.Call<UnityEngine.AndroidJavaObject>(methodName:  "setType", args:  val_16);
            object[] val_18 = new object[2];
            val_18[0] = val_3.GetStatic<System.String>(fieldName:  "EXTRA_TEXT");
            val_18[1] = shareText;
            UnityEngine.AndroidJavaObject val_20 = val_5.Call<UnityEngine.AndroidJavaObject>(methodName:  "putExtra", args:  val_18);
            object[] val_23 = new object[2];
            val_23[0] = val_5;
            val_23[1] = "Share";
            object[] val_25 = new object[1];
            val_25[0] = val_3.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "createChooser", args:  val_23);
            new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity").Call(methodName:  "startActivity", args:  val_25);
        }
        public VSSHARE()
        {
            this.withText = true;
            this.fileName = "InkWarsScreenShot.png";
            this.showButtonShareWhenSceneRestartIfScreenshotAvailable = true;
            this.shareTextBeforeUrl = "That\'s my new record! Come and play InkWars with me!\r\nCheck out more InkWars news at ";
            this.shareTextAfterUrl = "";
            this.iD_iOS = "1134939249";
            this.bundleIdAndroid = "com.appadvisory.ab2";
            this.takeFullScreen = true;
            this.AndroidForceSDCardPermission = true;
            this.amazonID = "B01DPBSF2A";
        }
        private void <DoAnimOpenScreenshotAsAButton>b__74_0()
        {
            this.isAnimating = true;
        }
        private void <DoAnimOpenScreenshotAsAButton>b__74_1()
        {
            this.isAnimating = false;
            this.state = 1;
        }
        private void <ActivateButtonClose>b__77_0()
        {
            this.buttonClose.gameObject.SetActive(value:  false);
            this.buttonClose.enabled = false;
            this.buttonClose.interactable = false;
        }
        private void <OnClickedHideScreenshotIcon>b__78_0()
        {
            this.isAnimating = true;
        }
        private void <OnClickedHideScreenshotIcon>b__78_1()
        {
            this.isAnimating = false;
            this.state = 0;
            this.shareElement.gameObject.SetActive(value:  false);
        }
        private void <AnimIconToWindow>b__80_0()
        {
            this.isAnimating = true;
        }
        private void <AnimIconToWindow>b__80_1()
        {
            this.isAnimating = false;
            this.state = 2;
        }
        private void <OnClickedButtonCloseShareWindow>b__82_0()
        {
            this.isAnimating = true;
        }
        private void <OnClickedButtonCloseShareWindow>b__82_1()
        {
            this.isAnimating = false;
            this.state = 1;
        }
        private void <getScreenshot>b__96_0()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.DelayAndShare());
        }
    
    }

}
