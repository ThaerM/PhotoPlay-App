using MoviesProject.Controls.RatingControls;
using MoviesProject.Models;
using MoviesProject.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MoviesProject.ViewModels
{
    public class MoviesComingSoonViewModel : BaseViewModel
    {
        private bool _IsLoad;
        public bool IsLoad
        {
            get => _IsLoad;
            set => SetProperty(ref _IsLoad, value);
        }

        private ObservableCollection<MoviesComingSoonDB> _MoviesCollection;
        public ObservableCollection<MoviesComingSoonDB> MoviesCollection
        {
            get => _MoviesCollection;
            set => SetProperty(ref _MoviesCollection, value);
        }
        readonly ServiceClient service;
        private string _NameSelection;

        private string _PosterURLSelection;
        public string NameSelection { get => _NameSelection; set => SetProperty(ref _NameSelection, value); }

        public string PosterURLSelection { get => _PosterURLSelection; set => SetProperty(ref _PosterURLSelection, value); }

        private int? _Rating;
        public int? Rating { get => _Rating; set => SetProperty(ref _Rating, value); }

        public MoviesComingSoonViewModel()
        {
            service = new ServiceClient();
            IsLoad = false;
            MoviesCollection = new ObservableCollection<MoviesComingSoonDB>();
            LoadData();
        }

        private async void LoadData()
        {
            IsLoad = true;
            var result = await service.GetAsync<List<MoviesComingSoonDB>>(AppConstent.GET_MoviesComingSoon);
            if (result != null)
            {
                MoviesCollection = new ObservableCollection<MoviesComingSoonDB>(result);
                SelectionItem(MoviesCollection[0]);
            }
            else
            {
                LoadFakeData();
            }
            IsLoad = false;
        }

        private void LoadFakeData()
        {
            MoviesCollection = new ObservableCollection<MoviesComingSoonDB>(){
                new MoviesComingSoonDB()
                {
                    id = 1,
                    title = "Game Night",
                    year = 2018,
                    genres = "Action",
                    ratings = "3",
                    poster = "MV5BMjQxMDE5NDg0NV5BMl5BanBnXkFtZTgwNTA5MDE2NDM@._V1_SY500_CR0,0,337,500_AL_.jpg",
                    contentRating = "11",
                    duration = "PT100M",
                    releaseDate = "2018-02-28",
                    averageRating = 0,
                    originalTitle = "",
                    storyline = "A group of friends who meet regularly for game nights find themselves trying to solve a murder mystery.",
                    actors = "Rachel McAdams",
                    imdbRating = 0,
                    posterurl = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjQxMDE5NDg0NV5BMl5BanBnXkFtZTgwNTA5MDE2NDM@._V1_SY500_CR0,0,337,500_AL_.jpg"
                },
                new MoviesComingSoonDB()
                {
                    id = 2,
                    title = "Area X: Annihilation",
                    year = 2018,
                    genres = "Adventure,Drama,Fantasy",
                    ratings = "4",
                    poster = "MV5BMTk2Mjc2NzYxNl5BMl5BanBnXkFtZTgwMTA2OTA1NDM@._V1_SY500_CR0,0,320,500_AL_.jpg",
                    contentRating = "R",
                    duration = "",
                    releaseDate = "2018 - 02 - 23",
                    averageRating = 0,
                    originalTitle = "Annihilation",
                    storyline = "A biologist's husband disappears. She puts her name forward for an expedition into an environmental disaster zone,but does not find what she's expecting.The expedition team is made up of the biologist, an anthropologist, a psychologist, a surveyor, and a linguist.",
                    actors = "Tessa Thompson",
                    imdbRating = 0,
                    posterurl = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTk2Mjc2NzYxNl5BMl5BanBnXkFtZTgwMTA2OTA1NDM@._V1_SY500_CR0,0,320,500_AL_.jpg"
                },
                new MoviesComingSoonDB()
                {
                    id = 3,
                    title = "Hannah",
                    year = 2017,
                    genres = "Drama",
                    ratings = "3",
                    poster = "MV5BNWJmMWIxMjQtZTk0Mi00YTE0LTkyNzAtYzQxYjcwYjE4ZDk2XkEyXkFqcGdeQXVyMTc4MzI2NQ@@._V1_SY500_SX350_AL_.jpg",
                    contentRating = "",
                    duration = "PT95M",
                    releaseDate = "2018 - 01 - 24",
                    averageRating = 0,
                    originalTitle = "",
                    storyline = "Intimate portrait of a woman drifting between reality and denial when she is left alone to grapple with the consequences of her husband's imprisonment.",
                    actors = "Charlotte Rampling",
                    imdbRating = 6.5,
                    posterurl = "https://images-na.ssl-images-amazon.com/images/M/MV5BNWJmMWIxMjQtZTk0Mi00YTE0LTkyNzAtYzQxYjcwYjE4ZDk2XkEyXkFqcGdeQXVyMTc4MzI2NQ@@._V1_SY500_SX350_AL_.jpg"
                },
                new MoviesComingSoonDB()
                {
                    id = 4,
                    title = "The Lodgers",
                    year = 2017,
                    genres = "Drama, Horror,                Romance",
                    ratings = "3",
                    poster = "MV5BM2FhM2E1MTktMDYwZi00ODA1LWI0YTYtN2NjZjM3ODFjYmU5XkEyXkFqcGdeQXVyMjY1ODQ3NTA@._V1_SY500_CR0,0,337,500_AL_.jpg",
                    contentRating = "R",
                    duration = "PT92M",
                    releaseDate = "2018 - 03 - 09",
                    averageRating = 0,
                    originalTitle = "",
                    storyline = "1920, rural Ireland.Anglo Irish twins Rachel and Edward share a strange existence in their crumbling family estate.Each night,                the property becomes the domain of a sinister presence(The Lodgers) which enforces three rules upon the twins: they must be in bed by midnight; they may not permit an outsider past the threshold; if one attempts to escape,the life of the other is placed in jeopardy.When troubled war veteran Sean returns to the nearby village, he is immediately drawn to the mysterious Rachel, who in turn begins to break the rules set out by The Lodgers.The consequences pull Rachel into a deadly confrontation with her brother - and with the curse that haunts them.",
                    actors = "Charlotte Vega",
                    imdbRating = 5.8,
                    posterurl = "https://images-na.ssl-images-amazon.com/images/M/MV5BM2FhM2E1MTktMDYwZi00ODA1LWI0YTYtN2NjZjM3ODFjYmU5XkEyXkFqcGdeQXVyMjY1ODQ3NTA@._V1_SY500_CR0,0,337,500_AL_.jpg"
                },
                new MoviesComingSoonDB()
                {
                    id = 5,
                    title = "Beast of Burden",
                    year = 2018,
                    genres = "Action,Crime,Drama",
                    ratings = "5",
                    poster = "MV5BMjEyNTM3MDQ2NV5BMl5BanBnXkFtZTgwMDI5Nzk1NDM@._V1_SY500_CR0,0,336,500_AL_.jpg",
                    contentRating = "R",
                    duration = "",
                    releaseDate = "2018 - 02",
                    averageRating = 0,
                    originalTitle = "",
                    storyline = "Sean Haggerty only has an hour to deliver his illegal cargo.An hour to reassure a drug cartel,a hitman, and the DEA that nothing is wrong.An hour to make sure his wife survives. And he must do it all from the cockpit of his Cessna.",
                    actors = "Daniel Radcliffe",
                    imdbRating = 0,
                    posterurl = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjEyNTM3MDQ2NV5BMl5BanBnXkFtZTgwMDI5Nzk1NDM@._V1_SY500_CR0,0,336,500_AL_.jpg"
                },
                new MoviesComingSoonDB()
                {
                    id = 6,
                    title = "The Chamber",
                    year = 2016,
                    genres = "Horror ,Thriller",
                    ratings = "3",
                    poster = "MV5BNTVlODgwMjgtZGUzMy00ZTY1LWIyMDEtYTI2Y2JlYzVjZTNkXkEyXkFqcGdeQXVyNTg0MDM1MzY@._V1_SY500_CR0,0,337,500_AL_.jpg",
                    contentRating = "",
                    duration = "PT88M",
                    releaseDate = "2017 - 03 - 10",
                    averageRating = 0,
                    originalTitle = "",
                    storyline = "A claustrophobic survival thriller set beneath the Yellow Sea off the coast of North Korea where the pilot of a small submersible craft and a three man Special Ops team on a secret recovery mission become trapped underwater in a fight for survival.",
                    actors = "Johannes Kuhnke",
                    imdbRating = 4.4,
                    posterurl = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTVlODgwMjgtZGUzMy00ZTY1LWIyMDEtYTI2Y2JlYzVjZTNkXkEyXkFqcGdeQXVyNTg0MDM1MzY@._V1_SY500_CR0,0,337,500_AL_.jpg"
                },
                new MoviesComingSoonDB()
                {
                    id = 7,
                    title = "Survivors Guide to Prison",
                    year = 2018,
                    genres = "Documentary",
                    ratings = "4",
                    poster = "MV5BNzhmNmI5MDMtZDEyOC00ODkyLTkwODItODQzODAzY2QyZjVlXkEyXkFqcGdeQXVyMzQwMTY2Nzk@._V1_SY500_CR0,0,357,500_AL_.jpg",
                    contentRating = "",
                    duration = "PT102M",
                    releaseDate = "2018 - 02 - 23",
                    averageRating = 0,
                    originalTitle = "",
                    storyline = "Following the stories of Bruce Lisker and Reggie Cole who spent year after year in prison for murders they didn't commit - audiences get a harrowing look at how barbaric the US justice system is. The film ultimately asks how we can survive the prison model at all,and looks at better solutions for conflict resolution,harm reduction,crime and more. Hosted by filmmaker Matthew Cooke and guest hosting representatives from the massive range of Americans joining forces to change this broken system. Written by\nanonymous",
                    actors = "Susan Sarandon",
                    imdbRating = 0,
                    posterurl = "https://images-na.ssl-images-amazon.com/images/M/MV5BNzhmNmI5MDMtZDEyOC00ODkyLTkwODItODQzODAzY2QyZjVlXkEyXkFqcGdeQXVyMzQwMTY2Nzk@._V1_SY500_CR0,0,357,500_AL_.jpg"
                },
                new MoviesComingSoonDB()
                {
                    id = 8,
                    title = "Red Sparrow",
                    year = 2018,
                    genres = "Mystery,Thriller",
                    ratings = "5",
                    poster = "MV5BMTA3MDkxOTc4NDdeQTJeQWpwZ15BbWU4MDAxNzgyNTQz._V1_SY500_CR0,0,337,500_AL_.jpg",
                    contentRating = "R",
                    duration = "PT139M",
                    releaseDate = "2018 - 03 - 02",
                    averageRating = 0,
                    originalTitle = "",
                    storyline = "A young Russian intelligence officer is assigned to seduce a first - tour CIA agent who handles the CIA's most sensitive penetration of Russian intelligence. The two young officers collide in a charged atmosphere of trade-craft,deception,and inevitably forbidden passion that threatens not just their lives but the lives of others as well.",
                    actors = "Jennifer Lawrence",
                    imdbRating = 0,
                    posterurl = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTA3MDkxOTc4NDdeQTJeQWpwZ15BbWU4MDAxNzgyNTQz._V1_SY500_CR0,0,337,500_AL_.jpg"
                }
                ,new MoviesComingSoonDB()
                {
                    id = 9,
                    title = "Death Wish",
                    year = 2018,
                    genres = "Action,Crime,Drama",
                    ratings = "2",
                    poster = "MV5BMTkzNjU3MjE0MF5BMl5BanBnXkFtZTgwNTIyNDk0NDM@._V1_SY400_SX270_AL_.jpg",
                    contentRating = "R",
                    duration = "PT108M",
                    releaseDate = "2018 - 04 - 13",
                    averageRating = 0,
                    originalTitle = "",
                    storyline = "Dr.Paul Kersey(Bruce Willis) is a surgeon who only sees the aftermath of his city's violence as it's rushed into his ER - until his wife(Elisabeth Shue) and college-age daughter(Camila Morrone) are viciously attacked in their suburban home.With the police overloaded with crimes, Paul, burning for revenge, hunts for his family's assailants to deliver justice. As the anonymous slayings of criminals grabs the media's attention, the city wonders if this deadly avenger is a guardian angel...or a grim reaper. Fury and fate collide in the intense action - thriller Death Wish. Written by\nMGM",
                    actors = "Bruce Willis",
                    imdbRating = 0,
                    posterurl = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTkzNjU3MjE0MF5BMl5BanBnXkFtZTgwNTIyNDk0NDM@._V1_SY400_SX270_AL_.jpg"
                }
                ,new MoviesComingSoonDB()
                {
                    id = 10,
                    title = "Foxtrot",
                    year = 2017,
                    genres = "Drama",
                    ratings = "3",
                    poster = "MV5BOGUyZTJhZWEtNGIwZi00YjUwLTljMGMtNjliMzM1NDMxYjJmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_SY500_CR0,0,353,500_AL_.jpg",
                    contentRating = "R",
                    duration = "PT108M",
                    releaseDate = "2017 - 09 - 21",
                    averageRating = 0,
                    originalTitle = "",
                    storyline = "A troubled family face the facts when something goes terribly wrong at their son's desolate military post.",
                    actors = "Lior Ashkenazi",
                    imdbRating = 7.4,
                    posterurl = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTkzNjU3MjE0MF5BMl5BanBnXkFtZTgwNTIyNDk0NDM@._V1_SY400_SX270_AL_.jpg"
                }
            };
            SelectionItem(MoviesCollection[0]);
        }

        public void SelectionItem(MoviesComingSoonDB movieData)
        {
            NameSelection = movieData.title;
            Rating = int.Parse(movieData.ratings);
            PosterURLSelection = movieData.posterurl;
        }

    }
}