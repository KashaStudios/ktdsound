namespace DeepSound
{
    public static class AppSettings
    {
        //Main Settings >>>>>
        public static string Cert = "NFYnA2qriwLLUe74dlNM96SrVvtvb5awCQo2qxD7iZhHUUrbI5ZTfVixH5ZlwQUq+hHW6rkwmgJvXbFpT0KwfqAP4YQoZn+1rLxznXrUjp+KzzupJ/LtvFvs3cIVkalzPN9vQqM9JB2TKxdS8eanqU2PXLXPFnaHa/c5CrQTR9P0jldqnNyUVRi9tLcvpPnBGfrEb9hkGpYO9ZG7y6+TLJC2UE/+vIUnEsTFOi/QcRq9qBCLkwupfgdUUpOWdqWDMkNeQUVz3wiDySOOw4MYwg==";
        //*********************************************************

        public static string ApplicationName = "DeepSound";
        public static string Version = "1.3";

        //Main Colors >>
        //*********************************************************
        public static string MainColor = "#ffa142";

        //Language Settings >> http://www.lingoes.net/en/translator/langcode.htm
        //*********************************************************
        public static bool FlowDirectionRightToLeft = false;
        public static string Lang = ""; //Default language ar_AE
         
        //Error Report Mode
        //*********************************************************
        public static bool SetApisReportMode = true;//#New
         
        //Notification Settings >>
        //*********************************************************
        public static readonly string OneSignalAppId = "";

        public static bool ShowNotification = true;
        public static int RefreshGetNotification = 60000; // 1 minute

        //ADMOB >> Please add the code ads in the Here and analytic.xml 
        //*********************************************************
        public static bool ShowAdmobBanner = true;
        public static bool ShowAdmobInterstitial = true;
        public static bool ShowAdmobRewardVideo = true;

        public static string AdAppKey = "ca-app-pub-5135691635931982~1995780558";
        public static string AdInterstitialKey = "ca-app-pub-5135691635931982/5807300922";
        public static string AdRewardVideoKey = "ca-app-pub-5135691635931982/9993834236";

        //Three times after entering the ad is displayed
        public static int ShowAdmobInterstitialCount = 3;
        public static int ShowAdmobRewardedVideoCount = 3;
          
        //*********************************************************

        //Social Logins >>
        //If you want login with facebook or google you should change id key in the String.xml file or AndroidManifest.xml
        //Facebook >> ../values/Strings.xml .. line 15 - 16 
        //Google >> ../Properties/AndroidManifest.xml .. line 49
        //*********************************************************
        public static bool ShowFacebookLogin = true;
        public static bool ShowGoogleLogin = true;

        //*********************************************************
        public static bool AllowProSystem = false;// >> Next Version


        public static bool ShowPrice = true;//#New

        //Set Theme Full Screen App
        //*********************************************************
        public static bool EnableFullScreenApp = false;

        //Set Theme Full Screen App
        //*********************************************************
        public static bool EnableBlurBackgroundComment = true;

        //Set the radius of the Blur. Supported range 0 < radius <= 25
        public static readonly float BlurRadiusComment = 25f;
         
        //Import && Upload Videos >>  
        //*********************************************************
        public static bool ShowButtonUploadSingleSong { get; set; } = true;
        public static bool ShowButtonUploadAlbum { get; set; } = false;// >> Next Version
        

        //Offline Sound >>  
        //*********************************************************
        public static bool AllowOfflineDownload = true;

        /// <summary>
        /// true :  use Download Manager you can see file song in folder app  
        /// false :  default used normal download and you can see i folder "Dcim"
        /// </summary>
        public static bool SetDownloadManager = true;//#New



        //Set Theme App >> Color - Tab
        //*********************************************************
        public static bool SetTabLightTheme = true;
        public static bool SetTabColoredTheme = false;
        public static bool SetTabDarkTheme = false;
        public static string TabColoredColor = MainColor;
         
        public static bool SetTabIsTitledWithText = true;

        //Bypass Web Erros 
        ///*********************************************************
        public static bool TurnTrustFailureOnWebException = true;
        public static bool TurnSecurityProtocolType3072On = true;

        //*********************************************************
        public static bool RenderPriorityFastPostLoad = true;
    }
}
