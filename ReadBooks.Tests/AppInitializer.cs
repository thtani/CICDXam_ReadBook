using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace ReadBooks.Tests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android
                    //.ApkFile("/Users/GPI-PC0004/source/repos/ReadBooks/ReadBooks/ReadBooks.Android/bin/Debug/com.companyname.readbooks-Signed.apk")
                    .InstalledApp("com.companyname.readbooks")
                    .StartApp();
            }

            return ConfigureApp.iOS
                .AppBundle("/Users/GPI-PC0004/source/repos/ReadBooks/ReadBooks/ReadBooks.iOS/bin/iPhoneSimulator/Debug/ReadBooks.iOS.app")
                .StartApp();
        }
    }
}