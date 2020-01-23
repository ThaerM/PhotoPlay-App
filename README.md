# Movies View-App
Application to view the last view from database 

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

## Prepare the API
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
For any question please let me know 
Thaer.mosa13@gmail.com
```
