using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MovieBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBrowser.Data
{
    public class AppDbInitializer
    {
        public static void Fill(IApplicationBuilder applicationBuilder)
        {
            using (var scope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Actors.Any())
                {
                    context.AddRange(new List<Actor>()
                    {
                        new Actor
                        {
                            ProfilePictureURL = "test",
                            FullName = "Actor 1",
                            Biography = "test"
                        },
                        new Actor
                        {
                            ProfilePictureURL = "test",
                            FullName = "Actor 2",
                            Biography = "test"
                        },
                        new Actor
                        {
                            ProfilePictureURL = "test",
                            FullName = "Actor 3",
                            Biography = "test"
                        },
                        new Actor
                        {
                            ProfilePictureURL = "test",
                            FullName = "Actor 4",
                            Biography = "test"
                        },
                        new Actor
                        {
                            ProfilePictureURL = "test",
                            FullName = "Actor 5",
                            Biography = "test"
                        },
                        new Actor
                        {
                            ProfilePictureURL = "test",
                            FullName = "Actor 6",
                            Biography = "test"
                        }
                    });
                    context.SaveChanges();

                }
                if (!context.Producers.Any())
                {
                    context.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Biography = "test",
                            ProfilePicture = "test"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Biography = "test",
                            ProfilePicture = "test"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Biography = "test",
                            ProfilePicture = "test"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Biography = "test",
                            ProfilePicture = "test"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Biography = "test",
                            ProfilePicture = "test"
                        },
                        new Producer()
                        {
                            FullName = "Producer 6",
                            Biography = "test",
                            ProfilePicture = "test"
                        }

                    });
                    context.SaveChanges();

                }
                if (!context.Theaters.Any())
                {
                    context.AddRange(new List<Theater>() {
                        new Theater()
                    {
                        Name = "Theater 1",
                        Picture = "test",
                        Description = "Test Description"
                    },
                    new Theater()
                    {
                        Name = "Theater 2",
                        Picture = "test",
                        Description = "Test Description"
                    },
                    new Theater()
                    {
                        Name = "Theater 3",
                        Picture = "test",
                        Description = "Test Description"
                    },
                    new Theater()
                    {
                        Name = "Theater 4",
                        Picture = "test",
                        Description = "Test Description"
                    },
                    new Theater()
                    {
                        Name = "Theater 5",
                        Picture = "test",
                        Description = "Test Description"
                    },
                    new Theater()
                    {
                        Name = "Theater 6",
                        Picture = "test",
                        Description = "Test Description"
                    }
                    });
                    context.SaveChanges();

                }
                if (!context.Movie.Any())
                {
                    context.AddRange(new List<Movie>()
                    {
                        new Movie
                        {
                            Name = "Movie 1",
                            Description = "test",
                            ImageURL = "test",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(5),
                            TheaterId = 1,
                            ProducerId = 1,
                            Category = MovieCategory.Action
                        },
                        new Movie
                        {
                            Name = "Movie 2",
                            Description = "test",
                            ImageURL = "test",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            TheaterId = 2,
                            ProducerId = 2,
                            Category = MovieCategory.Adventure
                        },
                        new Movie
                        {
                            Name = "Movie 3",
                            Description = "test",
                            ImageURL = "test",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(9),
                            TheaterId = 3,
                            ProducerId = 3,
                            Category = MovieCategory.Comedy
                        },
                        new Movie
                        {
                            Name = "Movie 4",
                            Description = "test",
                            ImageURL = "test",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(8),
                            TheaterId = 6,
                            ProducerId = 6,
                            Category = MovieCategory.Romance
                        },
                        new Movie
                        {
                            Name = "Movie 5",
                            Description = "test",
                            ImageURL = "test",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            TheaterId = 4,
                            ProducerId = 4,
                            Category = MovieCategory.Thriller
                        },
                        new Movie
                        {
                            Name = "Movie 6",
                            Description = "test",
                            ImageURL = "test",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(6),
                            TheaterId = 5,
                            ProducerId = 5,
                            Category = MovieCategory.Horror
                        },
                    });
                    context.SaveChanges();

                }
                if (!context.Producers.Any())
                {
                    context.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Biography = "test",
                            ProfilePicture = "test"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Biography = "test",
                            ProfilePicture = "test"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Biography = "test",
                            ProfilePicture = "test"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Biography = "test",
                            ProfilePicture = "test"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Biography = "test",
                            ProfilePicture = "test"
                        },
                        new Producer()
                        {
                            FullName = "Producer 6",
                            Biography = "test",
                            ProfilePicture = "test"
                        }

                    });
                    context.SaveChanges();

                }
                if (!context.Theaters.Any())
                {
                    context.AddRange(new List<Theater>() {
                        new Theater()
                    {
                        Name = "Theater 1",
                        Picture = "test",
                        Description = "Test Description"
                    },
                    new Theater()
                    {
                        Name = "Theater 2",
                        Picture = "test",
                        Description = "Test Description"
                    },
                    new Theater()
                    {
                        Name = "Theater 3",
                        Picture = "test",
                        Description = "Test Description"
                    },
                    new Theater()
                    {
                        Name = "Theater 4",
                        Picture = "test",
                        Description = "Test Description"
                    },
                    new Theater()
                    {
                        Name = "Theater 5",
                        Picture = "test",
                        Description = "Test Description"
                    },
                    new Theater()
                    {
                        Name = "Theater 6",
                        Picture = "test",
                        Description = "Test Description"
                    }
                    });
                    context.SaveChanges();

                }
                if (!context.Actor_Movies.Any())
                {
                    context.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();

                }

            }
        }
    }
}
