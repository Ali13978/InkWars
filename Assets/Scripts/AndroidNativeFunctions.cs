using UnityEngine;
public class AndroidNativeFunctions : MonoBehaviour
{
    // Fields
    private static bool immersiveMode;
    private static AndroidNativeFunctions instance;
    private static UnityEngine.AndroidJavaObject vibrator;
    private static UnityEngine.AndroidJavaObject progressDialog;
    
    // Properties
    private static UnityEngine.AndroidJavaObject currentActivity { get; }
    
    // Methods
    private static UnityEngine.AndroidJavaObject get_currentActivity()
    {
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        if(val_1 != null)
        {
                return val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        }
        
        return val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
    }
    private static void CreateGO()
    {
        AndroidNativeFunctions val_4 = AndroidNativeFunctions.instance;
        if(val_4 != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = null;
        val_4 = val_2;
        val_2 = new UnityEngine.GameObject(name:  "AndroidNativeFunctions");
        AndroidNativeFunctions.instance = val_2.AddComponent<AndroidNativeFunctions>();
    }
    private void OnApplicationFocus(bool focusStatus)
    {
        if(AndroidNativeFunctions.immersiveMode == false)
        {
                return;
        }
        
        if(focusStatus == false)
        {
                return;
        }
        
        AndroidNativeFunctions.ImmersiveMode();
    }
    public static void StartApp(string packageName, bool isExitThisApp)
    {
        System.Object[] val_9;
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        object[] val_5 = new object[1];
        val_5[0] = packageName;
        object[] val_8 = new object[1];
        val_9 = val_8;
        val_9[0] = AndroidNativeFunctions.currentActivity.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  System.Array.Empty<System.Object>()).Call<UnityEngine.AndroidJavaObject>(methodName:  "getLaunchIntentForPackage", args:  val_5);
        AndroidNativeFunctions.currentActivity.Call(methodName:  "startActivity", args:  val_8);
        if(isExitThisApp == false)
        {
                return;
        }
        
        UnityEngine.Application.Quit();
    }
    public static System.Collections.Generic.List<PackageInfo> GetInstalledApps()
    {
        var val_20;
        if(UnityEngine.Application.platform != 11)
        {
                return (System.Collections.Generic.List<PackageInfo>)0;
        }
        
        object[] val_5 = new object[1];
        val_5[0] = 0;
        val_20 = AndroidNativeFunctions.currentActivity.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  System.Array.Empty<System.Object>()).Call<UnityEngine.AndroidJavaObject>(methodName:  "getInstalledPackages", args:  val_5);
        int val_8 = val_20.Call<System.Int32>(methodName:  "size", args:  System.Array.Empty<System.Object>());
        System.Collections.Generic.List<PackageInfo> val_9 = null;
        0 = val_9;
        val_9 = new System.Collections.Generic.List<PackageInfo>();
        if(val_8 < 1)
        {
                return (System.Collections.Generic.List<PackageInfo>)0;
        }
        
        object val_20 = 0;
        label_24:
        object[] val_10 = new object[1];
        if(val_10 == null)
        {
            goto label_10;
        }
        
        if(val_20 != 0)
        {
            goto label_11;
        }
        
        goto label_14;
        label_10:
        if(val_20 == 0)
        {
            goto label_14;
        }
        
        label_11:
        label_14:
        val_10[0] = val_20;
        UnityEngine.AndroidJavaObject val_11 = val_20.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  val_10);
        .firstInstallTime = val_11.Get<System.Int64>(fieldName:  "firstInstallTime");
        if(val_11 != null)
        {
                .packageName = val_11.Get<System.String>(fieldName:  "packageName");
        }
        else
        {
                .packageName = val_11.Get<System.String>(fieldName:  "packageName");
        }
        
        .lastUpdateTime = val_11.Get<System.Int64>(fieldName:  "lastUpdateTime");
        if(val_11 != null)
        {
                .versionCode = val_11.Get<System.Int32>(fieldName:  "versionCode");
        }
        else
        {
                .versionCode = val_11.Get<System.Int32>(fieldName:  "versionCode");
        }
        
        .versionName = val_11.Get<System.String>(fieldName:  "versionName");
        val_9.Add(item:  new PackageInfo());
        val_20 = val_20 + 1;
        if(val_8 != val_20)
        {
            goto label_24;
        }
        
        return (System.Collections.Generic.List<PackageInfo>)0;
    }
    public static PackageInfo GetAppInfo()
    {
        return AndroidNativeFunctions.GetAppInfo(packageName:  AndroidNativeFunctions.currentActivity.Call<System.String>(methodName:  "getPackageName", args:  System.Array.Empty<System.Object>()));
    }
    public static PackageInfo GetAppInfo(string packageName)
    {
        object val_15;
        var val_16;
        val_15 = packageName;
        val_16 = 0;
        if(UnityEngine.Application.platform != 11)
        {
                return (PackageInfo)val_16;
        }
        
        object[] val_5 = new object[2];
        val_5[0] = val_15;
        val_5[1] = 0;
        UnityEngine.AndroidJavaObject val_6 = AndroidNativeFunctions.currentActivity.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  System.Array.Empty<System.Object>()).Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageInfo", args:  val_5);
        PackageInfo val_7 = null;
        val_16 = val_7;
        val_7 = new PackageInfo();
        val_15 = val_6.Get<System.Int64>(fieldName:  "firstInstallTime");
        .firstInstallTime = val_15;
        if(val_6 != null)
        {
                .packageName = val_6.Get<System.String>(fieldName:  "packageName");
        }
        else
        {
                .packageName = val_6.Get<System.String>(fieldName:  "packageName");
        }
        
        .lastUpdateTime = val_6.Get<System.Int64>(fieldName:  "lastUpdateTime");
        if(val_6 != null)
        {
                .versionCode = val_6.Get<System.Int32>(fieldName:  "versionCode");
        }
        else
        {
                .versionCode = val_6.Get<System.Int32>(fieldName:  "versionCode");
        }
        
        .versionName = val_6.Get<System.String>(fieldName:  "versionName");
        return (PackageInfo)val_16;
    }
    public static DeviceInfo GetDeviceInfo()
    {
        var val_9;
        if(UnityEngine.Application.platform != 11)
        {
                return (DeviceInfo)0;
        }
        
        UnityEngine.AndroidJavaClass val_2 = null;
        val_9 = val_2;
        val_2 = new UnityEngine.AndroidJavaClass(className:  "android.os.Build$VERSION");
        DeviceInfo val_3 = null;
        0 = val_3;
        val_3 = new DeviceInfo();
        .CODENAME = val_2.GetStatic<System.String>(fieldName:  "CODENAME");
        if(val_9 != null)
        {
                .INCREMENTAL = val_2.GetStatic<System.String>(fieldName:  "INCREMENTAL");
        }
        else
        {
                .INCREMENTAL = val_2.GetStatic<System.String>(fieldName:  "INCREMENTAL");
        }
        
        .RELEASE = val_2.GetStatic<System.String>(fieldName:  "RELEASE");
        .SDK = val_2.GetStatic<System.Int32>(fieldName:  "SDK_INT");
        return (DeviceInfo)0;
    }
    public static string GetAndroidID()
    {
        var val_8;
        var val_9;
        if(UnityEngine.Application.platform == 11)
        {
                UnityEngine.AndroidJavaClass val_5 = null;
            val_8 = val_5;
            val_5 = new UnityEngine.AndroidJavaClass(className:  "android.provider.Settings$Secure");
            object[] val_6 = new object[2];
            val_6[0] = AndroidNativeFunctions.currentActivity.Call<UnityEngine.AndroidJavaObject>(methodName:  "getContentResolver", args:  System.Array.Empty<System.Object>());
            val_6[1] = "android_id";
            string val_7 = val_5.CallStatic<System.String>(methodName:  "getString", args:  val_6);
            return (string)val_9;
        }
        
        val_9 = "";
        return (string)val_9;
    }
    public static void ShareText(string text, string subject, string chooser)
    {
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        UnityEngine.AndroidJavaObject val_3 = new UnityEngine.AndroidJavaObject(className:  "android.content.Intent", args:  System.Array.Empty<System.Object>());
        object[] val_4 = new object[1];
        val_4[0] = "android.intent.action.SEND";
        UnityEngine.AndroidJavaObject val_5 = val_3.Call<UnityEngine.AndroidJavaObject>(methodName:  "setAction", args:  val_4);
        object[] val_6 = new object[1];
        val_6[0] = "text/plain";
        UnityEngine.AndroidJavaObject val_7 = val_3.Call<UnityEngine.AndroidJavaObject>(methodName:  "setType", args:  val_6);
        object[] val_8 = new object[2];
        val_8[0] = "android.intent.extra.TEXT";
        val_8[1] = text;
        UnityEngine.AndroidJavaObject val_9 = val_3.Call<UnityEngine.AndroidJavaObject>(methodName:  "putExtra", args:  val_8);
        object[] val_10 = new object[2];
        val_10[0] = "android.intent.extra.SUBJECT";
        val_10[1] = subject;
        UnityEngine.AndroidJavaObject val_11 = val_3.Call<UnityEngine.AndroidJavaObject>(methodName:  "putExtra", args:  val_10);
        object[] val_12 = new object[2];
        val_12[0] = val_3;
        val_12[1] = chooser;
        object[] val_15 = new object[1];
        val_15[0] = val_3.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "createChooser", args:  val_12);
        AndroidNativeFunctions.currentActivity.Call(methodName:  "startActivity", args:  val_15);
    }
    public static void ShareImage(string text, string subject, string chooser, UnityEngine.Texture2D picture)
    {
        object[] val_3 = new object[2];
        string val_5 = System.Convert.ToBase64String(inArray:  UnityEngine.ImageConversion.EncodeToPNG(tex:  picture));
        if(val_3 == null)
        {
            goto label_3;
        }
        
        if(val_5 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_5 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_3[0] = val_5;
        val_3[1] = 0;
        System.Byte[] val_6 = new UnityEngine.AndroidJavaObject(className:  "android.util.Base64", args:  System.Array.Empty<System.Object>()).CallStatic<System.Byte[]>(methodName:  "decode", args:  val_3);
        object[] val_9 = new object[3];
        if(val_9 == null)
        {
            goto label_13;
        }
        
        if(val_6 != null)
        {
            goto label_14;
        }
        
        goto label_17;
        label_13:
        if(val_6 == null)
        {
            goto label_17;
        }
        
        label_14:
        label_17:
        val_9[0] = val_6;
        val_9[1] = 0;
        val_9[2] = val_6.Length;
        UnityEngine.AndroidJavaObject val_10 = new UnityEngine.AndroidJavaObject(className:  "android.graphics.BitmapFactory", args:  System.Array.Empty<System.Object>()).CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "decodeByteArray", args:  val_9);
        UnityEngine.AndroidJavaObject val_12 = new UnityEngine.AndroidJavaClass(className:  "android.graphics.Bitmap$CompressFormat").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "JPEG");
        object[] val_13 = new object[3];
        if(val_13 == null)
        {
            goto label_28;
        }
        
        if(val_12 != null)
        {
            goto label_29;
        }
        
        goto label_32;
        label_28:
        if(val_12 == null)
        {
            goto label_32;
        }
        
        label_29:
        label_32:
        val_13[0] = val_12;
        val_13[1] = 100;
        val_13[2] = new UnityEngine.AndroidJavaObject(className:  "java.io.ByteArrayOutputStream", args:  System.Array.Empty<System.Object>());
        bool val_16 = val_10.Call<System.Boolean>(methodName:  "compress", args:  val_13);
        object[] val_18 = new object[4];
        UnityEngine.AndroidJavaObject val_21 = AndroidNativeFunctions.currentActivity.Call<UnityEngine.AndroidJavaObject>(methodName:  "getContentResolver", args:  System.Array.Empty<System.Object>());
        if(val_18 == null)
        {
            goto label_42;
        }
        
        if(val_21 != null)
        {
            goto label_43;
        }
        
        goto label_46;
        label_42:
        if(val_21 == null)
        {
            goto label_46;
        }
        
        label_43:
        label_46:
        val_18[0] = val_21;
        val_18[1] = val_10;
        val_18[2] = picture.name;
        val_18[3] = "";
        object[] val_25 = new object[1];
        val_25[0] = new UnityEngine.AndroidJavaClass(className:  "android.provider.MediaStore$Images$Media").CallStatic<System.String>(methodName:  "insertImage", args:  val_18);
        UnityEngine.AndroidJavaObject val_28 = new UnityEngine.AndroidJavaObject(className:  "android.content.Intent", args:  System.Array.Empty<System.Object>());
        object[] val_29 = new object[1];
        val_29[0] = "android.intent.action.SEND";
        UnityEngine.AndroidJavaObject val_30 = val_28.Call<UnityEngine.AndroidJavaObject>(methodName:  "setAction", args:  val_29);
        object[] val_31 = new object[1];
        val_31[0] = "image/*";
        UnityEngine.AndroidJavaObject val_32 = val_28.Call<UnityEngine.AndroidJavaObject>(methodName:  "setType", args:  val_31);
        object[] val_33 = new object[2];
        val_33[0] = "android.intent.extra.STREAM";
        val_33[1] = new UnityEngine.AndroidJavaClass(className:  "android.net.Uri").CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "parse", args:  val_25);
        UnityEngine.AndroidJavaObject val_34 = val_28.Call<UnityEngine.AndroidJavaObject>(methodName:  "putExtra", args:  val_33);
        object[] val_35 = new object[2];
        val_35[0] = "android.intent.extra.TEXT";
        val_35[1] = text;
        UnityEngine.AndroidJavaObject val_36 = val_28.Call<UnityEngine.AndroidJavaObject>(methodName:  "putExtra", args:  val_35);
        object[] val_37 = new object[2];
        val_37[0] = "android.intent.extra.SUBJECT";
        val_37[1] = subject;
        UnityEngine.AndroidJavaObject val_38 = val_28.Call<UnityEngine.AndroidJavaObject>(methodName:  "putExtra", args:  val_37);
        object[] val_39 = new object[2];
        val_39[0] = val_28;
        val_39[1] = chooser;
        UnityEngine.AndroidJavaObject val_40 = val_28.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "createChooser", args:  val_39);
        object[] val_42 = new object[1];
        if(val_42 == null)
        {
            goto label_106;
        }
        
        if(val_40 != null)
        {
            goto label_107;
        }
        
        goto label_110;
        label_106:
        if(val_40 == null)
        {
            goto label_110;
        }
        
        label_107:
        label_110:
        val_42[0] = val_40;
        AndroidNativeFunctions.currentActivity.Call(methodName:  "startActivity", args:  val_42);
    }
    public static void ShowAlert(string message, string title, string positiveButton, string negativeButton, string neutralButton, UnityEngine.Events.UnityAction<DialogInterface> action)
    {
        AndroidNativeFunctions.<>c__DisplayClass16_0 val_1 = new AndroidNativeFunctions.<>c__DisplayClass16_0();
        if(val_1 != null)
        {
                .message = message;
            .title = title;
            .positiveButton = positiveButton;
            .action = action;
            .negativeButton = negativeButton;
        }
        else
        {
                mem[16] = message;
            mem[24] = title;
            mem[32] = positiveButton;
            mem[40] = action;
            mem[48] = negativeButton;
        }
        
        .neutralButton = neutralButton;
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        object[] val_4 = new object[1];
        val_4[0] = new UnityEngine.AndroidJavaRunnable(object:  val_1, method:  System.Void AndroidNativeFunctions.<>c__DisplayClass16_0::<ShowAlert>b__0());
        AndroidNativeFunctions.currentActivity.Call(methodName:  "runOnUiThread", args:  val_4);
    }
    public static void ShowAlertInput(string text, string message, string title, string positiveButton, string negativeButton, UnityEngine.Events.UnityAction<DialogInterface, string> action)
    {
        AndroidNativeFunctions.<>c__DisplayClass18_0 val_1 = new AndroidNativeFunctions.<>c__DisplayClass18_0();
        if(val_1 != null)
        {
                .text = text;
            .message = message;
            .title = title;
            .positiveButton = positiveButton;
            .action = action;
        }
        else
        {
                mem[16] = text;
            mem[24] = message;
            mem[32] = title;
            mem[40] = positiveButton;
            mem[48] = action;
        }
        
        .negativeButton = negativeButton;
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        object[] val_4 = new object[1];
        val_4[0] = new UnityEngine.AndroidJavaRunnable(object:  val_1, method:  System.Void AndroidNativeFunctions.<>c__DisplayClass18_0::<ShowAlertInput>b__0());
        AndroidNativeFunctions.currentActivity.Call(methodName:  "runOnUiThread", args:  val_4);
    }
    public static void ShowAlertList(string title, string[] list, UnityEngine.Events.UnityAction<string> action)
    {
        AndroidNativeFunctions.<>c__DisplayClass20_0 val_1 = new AndroidNativeFunctions.<>c__DisplayClass20_0();
        if(val_1 != null)
        {
                .title = title;
            .list = list;
        }
        else
        {
                mem[16] = title;
            mem[24] = list;
        }
        
        .action = action;
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        object[] val_4 = new object[1];
        val_4[0] = new UnityEngine.AndroidJavaRunnable(object:  val_1, method:  System.Void AndroidNativeFunctions.<>c__DisplayClass20_0::<ShowAlertList>b__0());
        AndroidNativeFunctions.currentActivity.Call(methodName:  "runOnUiThread", args:  val_4);
    }
    public static void ShowToast(string message)
    {
        AndroidNativeFunctions.ShowToast(message:  message, shortDuration:  true);
    }
    public static void ShowToast(string message, bool shortDuration)
    {
        AndroidNativeFunctions.<>c__DisplayClass23_0 val_1 = new AndroidNativeFunctions.<>c__DisplayClass23_0();
        if(val_1 != null)
        {
                .message = message;
        }
        else
        {
                mem[16] = message;
        }
        
        .shortDuration = shortDuration;
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        object[] val_5 = new object[1];
        val_5[0] = new UnityEngine.AndroidJavaRunnable(object:  val_1, method:  System.Void AndroidNativeFunctions.<>c__DisplayClass23_0::<ShowToast>b__0());
        AndroidNativeFunctions.currentActivity.Call(methodName:  "runOnUiThread", args:  val_5);
    }
    public static void ShowProgressDialog(string message)
    {
        AndroidNativeFunctions.ShowProgressDialog(message:  message, title:  "");
    }
    public static void ShowProgressDialog(string message, string title)
    {
        AndroidNativeFunctions.<>c__DisplayClass25_0 val_1 = new AndroidNativeFunctions.<>c__DisplayClass25_0();
        if(val_1 != null)
        {
                .message = message;
        }
        else
        {
                mem[16] = message;
        }
        
        .title = title;
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        if(AndroidNativeFunctions.progressDialog != null)
        {
                AndroidNativeFunctions.HideProgressDialog();
        }
        
        object[] val_4 = new object[1];
        val_4[0] = new UnityEngine.AndroidJavaRunnable(object:  val_1, method:  System.Void AndroidNativeFunctions.<>c__DisplayClass25_0::<ShowProgressDialog>b__0());
        AndroidNativeFunctions.currentActivity.Call(methodName:  "runOnUiThread", args:  val_4);
    }
    public static void HideProgressDialog()
    {
        var val_4;
        UnityEngine.AndroidJavaRunnable val_6;
        if(AndroidNativeFunctions.progressDialog == null)
        {
                return;
        }
        
        object[] val_2 = new object[1];
        val_4 = null;
        val_4 = null;
        val_6 = AndroidNativeFunctions.<>c.<>9__26_0;
        if(val_6 == null)
        {
            goto label_4;
        }
        
        if(val_2 == null)
        {
            goto label_5;
        }
        
        label_10:
        if(val_6 != null)
        {
            goto label_6;
        }
        
        goto label_12;
        label_4:
        UnityEngine.AndroidJavaRunnable val_3 = null;
        val_6 = val_3;
        val_3 = new UnityEngine.AndroidJavaRunnable(object:  AndroidNativeFunctions.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AndroidNativeFunctions.<>c::<HideProgressDialog>b__26_0());
        AndroidNativeFunctions.<>c.<>9__26_0 = val_6;
        if(val_2 != null)
        {
            goto label_10;
        }
        
        label_5:
        if(val_6 == null)
        {
            goto label_12;
        }
        
        label_6:
        label_12:
        val_2[0] = val_6;
        AndroidNativeFunctions.currentActivity.Call(methodName:  "runOnUiThread", args:  val_2);
    }
    public static void ImmersiveMode()
    {
        var val_7;
        var val_8;
        UnityEngine.AndroidJavaRunnable val_10;
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        UnityEngine.AndroidJavaClass val_2 = null;
        val_7 = val_2;
        val_2 = new UnityEngine.AndroidJavaClass(className:  "android.os.Build$VERSION");
        if((val_2.GetStatic<System.Int32>(fieldName:  "SDK_INT")) < 19)
        {
                return;
        }
        
        AndroidNativeFunctions.CreateGO();
        AndroidNativeFunctions.immersiveMode = true;
        object[] val_5 = new object[1];
        val_8 = null;
        val_8 = null;
        val_10 = AndroidNativeFunctions.<>c.<>9__27_0;
        if(val_10 == null)
        {
            goto label_6;
        }
        
        if(val_5 == null)
        {
            goto label_7;
        }
        
        label_12:
        if(val_10 != null)
        {
            goto label_8;
        }
        
        goto label_14;
        label_6:
        UnityEngine.AndroidJavaRunnable val_6 = null;
        val_10 = val_6;
        val_6 = new UnityEngine.AndroidJavaRunnable(object:  AndroidNativeFunctions.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AndroidNativeFunctions.<>c::<ImmersiveMode>b__27_0());
        AndroidNativeFunctions.<>c.<>9__27_0 = val_10;
        if(val_5 != null)
        {
            goto label_12;
        }
        
        label_7:
        if(val_10 == null)
        {
            goto label_14;
        }
        
        label_8:
        label_14:
        val_5[0] = val_10;
        AndroidNativeFunctions.currentActivity.Call(methodName:  "runOnUiThread", args:  val_5);
    }
    public static void OpenGooglePlay(string packageName)
    {
        string val_3;
        if(UnityEngine.Application.platform == 11)
        {
                val_3 = "market://details?id=";
        }
        else
        {
                val_3 = "https://play.google.com/store/apps/details?id=";
        }
        
        UnityEngine.Application.OpenURL(url:  val_3 + packageName);
    }
    public static bool isDeviceRooted()
    {
        var val_7;
        int val_8;
        var val_9;
        if(UnityEngine.Application.platform != 11)
        {
            goto label_36;
        }
        
        val_7 = new string[9];
        val_7[0] = "/system/app/Superuser.apk";
        val_7[1] = "/sbin/su";
        val_7[2] = "/system/bin/su";
        val_7[3] = "/system/xbin/su";
        val_7[4] = "/data/local/xbin/su";
        val_7[5] = "/data/local/bin/su";
        val_7[6] = "/system/sd/xbin/su";
        val_7[7] = "/system/bin/failsafe/su";
        val_8 = val_2.Length;
        if(val_8 <= 8)
        {
                val_8 = val_2.Length;
        }
        
        val_7[8] = "/data/local/su";
        if(val_8 < 1)
        {
            goto label_30;
        }
        
        label_33:
        if((System.IO.File.Exists(path:  val_7[0])) == true)
        {
            goto label_32;
        }
        
        if((0 + 1) < val_2.Length)
        {
            goto label_33;
        }
        
        label_30:
        UnityEngine.AndroidJavaClass val_5 = null;
        val_7 = val_5;
        val_5 = new UnityEngine.AndroidJavaClass(className:  "android.os.Build");
        string val_6 = val_5.GetStatic<System.String>(fieldName:  "TAGS");
        if((val_6 == null) || ((val_6.Contains(value:  "test-keys")) == false))
        {
            goto label_36;
        }
        
        label_32:
        val_9 = 1;
        return (bool)val_9;
        label_36:
        val_9 = 0;
        return (bool)val_9;
    }
    public static bool isInstalledApp(string packageName)
    {
        var val_7;
        object val_8;
        var val_9;
        val_8 = packageName;
        if(UnityEngine.Application.platform == 11)
        {
                val_7 = AndroidNativeFunctions.currentActivity.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  System.Array.Empty<System.Object>());
            object[] val_5 = new object[2];
            val_5[0] = val_8;
            val_8 = 0;
            val_5[1] = val_8;
            UnityEngine.AndroidJavaObject val_6 = val_7.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageInfo", args:  val_5);
            val_9 = 1;
            return (bool)val_9;
        }
        
        val_9 = 0;
        return (bool)val_9;
    }
    public static void Vibrate(long milliseconds)
    {
        long val_6;
        UnityEngine.AndroidJavaObject val_7;
        val_6 = milliseconds;
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        val_7 = AndroidNativeFunctions.vibrator;
        if(val_7 == null)
        {
                object[] val_3 = new object[1];
            val_3[0] = "vibrator";
            AndroidNativeFunctions.vibrator = AndroidNativeFunctions.currentActivity.Call<UnityEngine.AndroidJavaObject>(methodName:  "getSystemService", args:  val_3);
            val_7 = AndroidNativeFunctions.vibrator;
        }
        
        object[] val_5 = new object[1];
        val_6 = val_6;
        val_5[0] = val_6;
        val_7.Call(methodName:  "vibrate", args:  val_5);
    }
    public static void Vibrate(long[] pattern, int repeat)
    {
        UnityEngine.AndroidJavaObject val_6;
        int val_7 = repeat;
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        val_6 = AndroidNativeFunctions.vibrator;
        if(val_6 == null)
        {
                object[] val_3 = new object[1];
            val_3[0] = "vibrator";
            AndroidNativeFunctions.vibrator = AndroidNativeFunctions.currentActivity.Call<UnityEngine.AndroidJavaObject>(methodName:  "getSystemService", args:  val_3);
            val_6 = AndroidNativeFunctions.vibrator;
        }
        
        object[] val_5 = new object[2];
        val_5[0] = pattern;
        val_7 = val_7;
        val_5[1] = val_7;
        val_6.Call(methodName:  "vibrate", args:  val_5);
    }
    public static void VibrateCancel()
    {
        if(AndroidNativeFunctions.vibrator == null)
        {
                return;
        }
        
        AndroidNativeFunctions.vibrator.Call(methodName:  "cancel", args:  System.Array.Empty<System.Object>());
    }
    public static bool hasVibrator()
    {
        UnityEngine.AndroidJavaObject val_6;
        System.Object[] val_7;
        val_6 = AndroidNativeFunctions.vibrator;
        if(val_6 != null)
        {
                val_7 = System.Array.Empty<System.Object>();
            return val_6.Call<System.Boolean>(methodName:  "hasVibrator", args:  val_7 = System.Array.Empty<System.Object>());
        }
        
        object[] val_3 = new object[1];
        val_3[0] = "vibrator";
        AndroidNativeFunctions.vibrator = AndroidNativeFunctions.currentActivity.Call<UnityEngine.AndroidJavaObject>(methodName:  "getSystemService", args:  val_3);
        val_6 = AndroidNativeFunctions.vibrator;
        if(val_6 != null)
        {
                return val_6.Call<System.Boolean>(methodName:  "hasVibrator", args:  val_7);
        }
        
        return val_6.Call<System.Boolean>(methodName:  "hasVibrator", args:  val_7);
    }
    public static bool isTVDevice()
    {
        var val_8;
        var val_9;
        if(UnityEngine.Application.platform == 11)
        {
                object[] val_3 = new object[1];
            val_3[0] = "uimode";
            val_8 = AndroidNativeFunctions.currentActivity.Call<UnityEngine.AndroidJavaObject>(methodName:  "getSystemService", args:  val_3);
            var val_7 = ((val_8.Call<System.Int32>(methodName:  "getCurrentModeType", args:  System.Array.Empty<System.Object>())) == 4) ? 1 : 0;
            return (bool)val_9;
        }
        
        val_9 = 0;
        return (bool)val_9;
    }
    public static bool isWiredHeadset()
    {
        if(UnityEngine.Application.platform != 11)
        {
                return false;
        }
        
        object[] val_3 = new object[1];
        val_3[0] = "audio";
        UnityEngine.AndroidJavaObject val_4 = AndroidNativeFunctions.currentActivity.Call<UnityEngine.AndroidJavaObject>(methodName:  "getSystemService", args:  val_3);
        if(val_4 != null)
        {
                return val_4.Call<System.Boolean>(methodName:  "isWiredHeadsetOn", args:  System.Array.Empty<System.Object>());
        }
        
        return val_4.Call<System.Boolean>(methodName:  "isWiredHeadsetOn", args:  System.Array.Empty<System.Object>());
    }
    public static void SetTotalVolume(int volumeLevel)
    {
        int val_7 = volumeLevel;
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        object[] val_4 = new object[1];
        val_4[0] = "audio";
        val_7 = AndroidNativeFunctions.currentActivity.Call<UnityEngine.AndroidJavaObject>(methodName:  "getSystemService", args:  val_4);
        object[] val_6 = new object[3];
        val_6[0] = 3;
        val_6[1] = UnityEngine.Mathf.Clamp(value:  val_7 = volumeLevel, min:  0, max:  15);
        val_6[2] = 0;
        val_7.Call(methodName:  "setStreamVolume", args:  val_6);
    }
    public static int GetTotalVolume()
    {
        var val_7;
        var val_8;
        if(UnityEngine.Application.platform == 11)
        {
                object[] val_3 = new object[1];
            val_3[0] = "audio";
            val_7 = AndroidNativeFunctions.currentActivity.Call<UnityEngine.AndroidJavaObject>(methodName:  "getSystemService", args:  val_3);
            object[] val_5 = new object[1];
            val_5[0] = 3;
            val_8 = val_7;
            int val_6 = val_8.Call<System.Int32>(methodName:  "getStreamVolume", args:  val_5);
            return (int)val_8;
        }
        
        val_8 = 0;
        return (int)val_8;
    }
    public static bool isConnectInternet()
    {
        bool val_9;
        var val_10;
        if(UnityEngine.Application.platform != 11)
        {
            goto label_8;
        }
        
        object[] val_3 = new object[1];
        val_3[0] = "connectivity";
        val_9 = AndroidNativeFunctions.currentActivity.Call<UnityEngine.AndroidJavaObject>(methodName:  "getSystemService", args:  val_3).Call<UnityEngine.AndroidJavaObject>(methodName:  "getActiveNetworkInfo", args:  System.Array.Empty<System.Object>());
        if(val_9 == null)
        {
            goto label_8;
        }
        
        val_10 = val_9;
        goto label_9;
        label_8:
        val_10 = 0;
        label_9:
        val_10 = val_10 & 1;
        return (bool)val_10;
    }
    public static bool isConnectWifi()
    {
        bool val_9;
        var val_10;
        if(UnityEngine.Application.platform != 11)
        {
            goto label_12;
        }
        
        object[] val_3 = new object[1];
        val_3[0] = "connectivity";
        object[] val_5 = new object[1];
        val_5[0] = 1;
        val_9 = AndroidNativeFunctions.currentActivity.Call<UnityEngine.AndroidJavaObject>(methodName:  "getSystemService", args:  val_3).Call<UnityEngine.AndroidJavaObject>(methodName:  "getNetworkInfo", args:  val_5);
        if(val_9 == null)
        {
            goto label_12;
        }
        
        val_10 = val_9;
        goto label_13;
        label_12:
        val_10 = 0;
        label_13:
        val_10 = val_10 & 1;
        return (bool)val_10;
    }
    public static int GetBatteryLevel()
    {
        var val_13;
        int val_14;
        if(UnityEngine.Application.platform == 11)
        {
                object[] val_5 = new object[2];
            object[] val_6 = new object[1];
            val_6[0] = "android.intent.action.BATTERY_CHANGED";
            val_5[1] = new UnityEngine.AndroidJavaObject(className:  "android.content.IntentFilter", args:  val_6);
            val_13 = AndroidNativeFunctions.currentActivity.Call<UnityEngine.AndroidJavaObject>(methodName:  "getApplicationContext", args:  System.Array.Empty<System.Object>()).Call<UnityEngine.AndroidJavaObject>(methodName:  "registerReceiver", args:  val_5);
            object[] val_9 = new object[2];
            val_9[0] = "level";
            val_9[1] = 0;
            int val_10 = val_13.Call<System.Int32>(methodName:  "getIntExtra", args:  val_9);
            object[] val_11 = new object[2];
            val_11[0] = "scale";
            val_11[1] = 0;
            int val_12 = val_13.Call<System.Int32>(methodName:  "getIntExtra", args:  val_11);
            val_14 = 0;
            if(val_10 == 1)
        {
                return (int)val_14;
        }
        
            if(val_12 == 1)
        {
                return (int)val_14;
        }
        
            float val_14 = 100f;
            float val_13 = (float)val_10;
            val_13 = val_13 / (float)val_12;
            val_14 = val_13 * val_14;
            val_14 = (int)val_14;
            return (int)val_14;
        }
        
        val_14 = 0;
        return (int)val_14;
    }
    public static void SendEmail(string text, string subject, string email)
    {
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        UnityEngine.AndroidJavaObject val_3 = new UnityEngine.AndroidJavaObject(className:  "android.content.Intent", args:  System.Array.Empty<System.Object>());
        object[] val_4 = new object[1];
        val_4[0] = "android.intent.action.SENDTO";
        UnityEngine.AndroidJavaObject val_5 = val_3.Call<UnityEngine.AndroidJavaObject>(methodName:  "setAction", args:  val_4);
        object[] val_6 = new object[1];
        val_6[0] = "text/plain";
        UnityEngine.AndroidJavaObject val_7 = val_3.Call<UnityEngine.AndroidJavaObject>(methodName:  "setType", args:  val_6);
        object[] val_8 = new object[2];
        val_8[0] = "android.intent.extra.TEXT";
        val_8[1] = text;
        UnityEngine.AndroidJavaObject val_9 = val_3.Call<UnityEngine.AndroidJavaObject>(methodName:  "putExtra", args:  val_8);
        object[] val_10 = new object[2];
        val_10[0] = "android.intent.extra.SUBJECT";
        val_10[1] = subject;
        UnityEngine.AndroidJavaObject val_11 = val_3.Call<UnityEngine.AndroidJavaObject>(methodName:  "putExtra", args:  val_10);
        object[] val_12 = new object[1];
        object[] val_14 = new object[1];
        val_14[0] = "mailto:"("mailto:") + email;
        val_12[0] = new UnityEngine.AndroidJavaClass(className:  "android.net.Uri").CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "parse", args:  val_14);
        UnityEngine.AndroidJavaObject val_17 = val_3.Call<UnityEngine.AndroidJavaObject>(methodName:  "setData", args:  val_12);
        object[] val_19 = new object[1];
        val_19[0] = val_3;
        AndroidNativeFunctions.currentActivity.Call(methodName:  "startActivity", args:  val_19);
    }
    public static bool VerifyGooglePlayPurchase(string purchaseJson, string base64Signature, string publicKey)
    {
        System.Security.Cryptography.RSACryptoServiceProvider val_1 = new System.Security.Cryptography.RSACryptoServiceProvider();
        val_1.FromXmlString(xmlString:  publicKey);
        new System.Security.Cryptography.SHA1Managed() = new System.Security.Cryptography.SHA1Managed();
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_1.Dispose();
        return (bool)val_1.VerifyData(buffer:  System.Text.Encoding.UTF8, halg:  new System.Security.Cryptography.SHA1Managed(), signature:  System.Convert.FromBase64String(s:  base64Signature));
    }
    public AndroidNativeFunctions()
    {
    
    }

}
