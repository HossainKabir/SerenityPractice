using PracticeProject.Web.Modules.Reports.MovieDetails;
using Serenity.Navigation;
using MyPages = PracticeProject.Movie.Pages;

[assembly: NavigationLink(int.MaxValue, "Movie Database/Movie List", typeof(MyPages.MovieController), icon: "fa-video-camera")]
[assembly: NavigationLink(int.MaxValue, "Movie Database/Genre", typeof(MyPages.GenreController), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Movie Database/Movie Genres", typeof(MyPages.MovieGenresController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Movie Database/Person", typeof(MyPages.PersonController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Movie Database/Reports/Movie Details", typeof(MovieDetailsController), icon: null)]