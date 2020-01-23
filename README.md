# Movies App
# Project Overview
App uses the Database and API. You can Create your [Database](https://github.com/ThaerM/PhotoPlay-App#prepare-the-database) and [API](https://github.com/ThaerM/PhotoPlay-App/blob/master/README.md#prepare-the-aspnet-core-2-api) in very easy way!. When you get it.

# Why This Project
To become an Xamarin Developer, you must know how to bring particular mobile experiences to life. Specifically, you need to know how to build clean and compelling user interfaces (UIs), fetch data from network services, and optimize the experience for various mobile devices. You will hne these fundamental skills in this project.

By builing this app, you will demonstrate your understanding of the foundational elements of programming for Xamarin Forms, Xamarin Android and IOS.
Your app will communicate with the Internet and provide a responsive and delightful user experience.
I Hope this application help you in your life as developer.

# Light Theme
<img src="/ScreenShot_Movies/1-Splash_Light.png" width="15%"></img> <img src="/ScreenShot_Movies/2-Login_Light.png" width="15%"></img> <img src="/ScreenShot_Movies/3-SignUp_Light.png" width="15%"></img> <img src="/ScreenShot_Movies/4-ForgotPassword_Light.png" width="15%"> <img src="/ScreenShot_Movies/5-Home_Light.png" width="15%"> <img src="/ScreenShot_Movies/6-Cast_light.png" width="15%"> <img src="/ScreenShot_Movies/7-Search_Light.png" width="15%"> <img src="/ScreenShot_Movies/8-Downloads_Light.png" width="15%"> <img src="/ScreenShot_Movies/9-Profile_Light.png" width="15%"> <img src="/ScreenShot_Movies/10-MovieDetails_Light.png" width="15%"> <img src="/ScreenShot_Movies/11-TVShowDetails_Light.png" width="15%"> <img src="/ScreenShot_Movies/" width="15%"> 

# Dark Theme
<img src="/ScreenShot_Movies/1-Splash_Dark.png" width="15%"> <img src="/ScreenShot_Movies/2-Login_Dark.png" width="15%"> <img src="/ScreenShot_Movies/3-SignUp_Dark.png" width="15%"> <img src="/ScreenShot_Movies/4-ForgetPassword_Dark.png" width="15%"> <img src="/ScreenShot_Movies/5-Home_Dark.png" width="15%"> <img src="/ScreenShot_Movies/6-Cast_Dark.png" width="15%"> <img src="/ScreenShot_Movies/7-Search_Dark.png" width="15%"> <img src="/ScreenShot_Movies/8-Downloads_Dark.png" width="15%"> <img src="/ScreenShot_Movies/9-Profile_Dark.png" width="15%"> <img src="/ScreenShot_Movies/10-MovieDetails_Dark.png" width="15%"> <img src="/ScreenShot_Movies/11-TVShowDetails_Dark.png" width="15%"> 

# Features integrated
- Language (Arabic, English).
- Dynamic FlowDirection.
- Dynmaic Stars view.
- Themes (Light Theme, Dark Theme).

# Project uses the follwoing patterns and features:
- XAML UI.
- Converters.
- Custome Controls.
- Data Binding.
- MVVM.
- Styles.
- Animations.

# Third-Party NuGet Pagekages
- [Xamarin.Essentials.](https://www.nuget.org/packages/Xamarin.Essentials/)
- [Newtonesoft.Json.](https://www.nuget.org/packages/Newtonsoft.Json/)
- [Plugin.Multilingual.](https://www.nuget.org/packages/Plugin.Multilingual/)
- [Xam.Plugins.Settings.](https://www.nuget.org/packages/Xam.Plugins.Settings/)
- [Xamarin.FFIageLoading.Forms.](https://www.nuget.org/packages/Xamarin.FFImageLoading.Forms/)

# Requirements to run the sample
- Visual Studio 2019.
- Microsoft SQL Server Management Studio.
- Xamarin add-ons for Visual Studio(avaliable via the Visual Studio installer).
- ASP.NET and web development (avaliable via the Visual Studio installer).

# How to run the project
## Prepare the Database
1. Clone the project.
2. Open Microsoft SQL Server Managerment Studio.
3. Open file [MoviesDB.sql](https://github.com/ThaerM/PhotoPlay-App/blob/master/MoviesDB.sql) to create new database and entities for the test.

## Prepare the ASP.NET Core 2 (API)
1. Open the API soluation [MovieAPI](https://github.com/ThaerM/PhotoPlay-App/tree/master/MoviesAPI).
2. Change the Connection string from [appsettings.json](https://github.com/ThaerM/PhotoPlay-App/blob/master/MoviesAPI/MoviesAPI/appsettings.json).
3. For the check API please check [this](https://github.com/ThaerM/PhotoPlay-App/blob/master/MoviesAPI/APIRequest.txt).

## Prepare the Xamarin Project 
1. Open the [MoviesProject.sln](https://github.com/ThaerM/PhotoPlay-App/blob/master/MoviesProject.sln).
2. Go to MoviesProject/Services/ServiceClient.cs
3. Change the link to new one for the API.
```
 public ServiceClient()
        {
            //Create new instance
            httpClient = new HttpClient(new HttpClientHandler());
            //Sign the base URL on http 
            httpClient.BaseAddress = new Uri("Write the new Link Here", UriKind.Absolute);
            //Type of the request as json
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
```
4. Select any platform you need Androird or IOS and Run :D.


# Special Thanks
Thanks to [Tasun Prasad](https://www.behance.net/tasunprasad) for [free sample app design](https://www.xdguru.com/photoplay-movie-xd-free-ui-kit) and beautiful theme.


# License
``` 
Copyright 2020 Thaer Mosa
You can contact with me on the email for any question
Thaer.mosa13@gmail.com
```
