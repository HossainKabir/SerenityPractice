using Serenity.Navigation;
using MyPages = PracticeProject.Setup.Pages;

[assembly: NavigationLink(int.MaxValue, "Setup/Country", typeof(MyPages.CountryController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Setup/City", typeof(MyPages.CityController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Setup/District", typeof(MyPages.DistrictController), icon: null)]