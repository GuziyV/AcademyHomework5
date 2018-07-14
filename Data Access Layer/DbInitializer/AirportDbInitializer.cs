using Data_Access_Layer.Contexts;
using Data_Access_Layer.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer.DbInitializer
{
    static class AirportDbInitializer
    {
        static public void Initialize(AirportContext context)
        {
            context.Database.EnsureCreated(); //create db if not exist

            if(context.Flights.Any())
            { 
                return; //already seeded
            }

            List<Pilot> pilots = new List<Pilot>()
            {
                new Pilot(){Name = "PName1", Surname = "PSurname1", Experience = 3},
                new Pilot(){Name = "PName2", Surname = "PSurname2", Experience = 4},
                new Pilot(){Name = "PName3", Surname = "PSurname3", Experience = 9}
            };

            List<Stewardess> stewardesses = new List<Stewardess>()
            {
                new Stewardess(){Name = "SName1", Surname = "SSurname1"},
                new Stewardess(){Name = "SName2", Surname = "SSurname2"},
                new Stewardess(){Name = "SName3", Surname = "SSurname3"},
                new Stewardess(){Name = "SName4", Surname = "SSurname4"},
                new Stewardess(){Name = "SName5", Surname = "SSurname5"}
            };

            context.Pilots.AddRange(pilots);
            context.Stewardesses.AddRange(stewardesses);

            List<Crew> crews = new List<Crew>()
            {
                new Crew()
                {
                    Pilot = pilots[1],
                    Stewardesses = new List<Stewardess>()
                    {
                        stewardesses[1],
                        stewardesses[3]
                    }
                },
                new Crew()
                {
                    Pilot = pilots[0],
                    Stewardesses = new List<Stewardess>()
                    {
                        stewardesses[0],
                        stewardesses[2]
                    }
                },
                new Crew()
                {
                    Pilot = pilots[2],
                    Stewardesses = new List<Stewardess>()
                    {
                        stewardesses[4],
                    }
                }
            };

            crews.AddRange(crews);

            List<PlaneType> planeTypes = new List<PlaneType>()
            {
                new PlaneType()
                {
                    Model = "Model1",
                    NumberOfSeats = 150,
                    LoadCapacity = 1000
                },
                new PlaneType()
                {
                    Model = "Model2",
                    NumberOfSeats = 125,
                    LoadCapacity = 985
                },
                new PlaneType()
                {
                    Model = "Model1",
                    NumberOfSeats = 189,
                    LoadCapacity = 1010
                }
            };

            context.PlaneTypes.AddRange(planeTypes);

            List<Plane> planes = new List<Plane>()
            {
                new Plane()
                {
                    PlaneType = planeTypes[1],
                    ReleaseDate = new DateTime(2008,11,18)
                },
                new Plane()
                {
                    PlaneType = planeTypes[2],
                    ReleaseDate = new DateTime(2012,2,25)
                },
                new Plane()
                {
                    PlaneType = planeTypes[1],
                    ReleaseDate = new DateTime(2011,5,10)
                },
                new Plane()
                {
                    PlaneType = planeTypes[0],
                    ReleaseDate = new DateTime(2010,8,7)
                }
            };

            context.AddRange(planes);


            List<Flight> flights = new List<Flight>()
            {
                new Flight()
                {
                    DepartureFrom = "Kyiv",
                    Destination = "Tokio",
                    ArrivalTime = new DateTime(2018, 02, 03),
                    TimeOfDeparture = new DateTime(2018,02,02),
                },

                new Flight()
                {
                    DepartureFrom = "Dublin",
                    Destination = "Paris",
                    ArrivalTime = new DateTime(2017, 02, 03),
                    TimeOfDeparture = new DateTime(2017,02,02),
                },

                new Flight()
                {
                    DepartureFrom = "Odesa",
                    Destination = "Ternopil",
                    ArrivalTime = new DateTime(2016, 02, 03),
                    TimeOfDeparture = new DateTime(2016,02,02),
                },
            };

            context.Flights.AddRange(flights);

            List<Departure> departures = new List<Departure>()
            {
                new Departure()
                {
                    Crew = crews[1],
                    Flight = flights[1],
                    Plane = planes[2],
                    TimeOfDeparture = new DateTime(2017, 02, 03)
                },
                new Departure()
                {
                    Crew = crews[2],
                    Flight = flights[0],
                    Plane = planes[1],
                    TimeOfDeparture = new DateTime(2018, 02, 03)
                },
                new Departure()
                {
                    Crew = crews[0],
                    Flight = flights[2],
                    Plane = planes[0],
                    TimeOfDeparture = new DateTime(2016, 02, 03)
                }
            };
            context.Departures.AddRange(departures);

            List<Ticket> tickets = new List<Ticket>()
            {
                new Ticket()
                {
                    Flight = flights[1],
                    Price = 250
                },
                new Ticket()
                {
                    Flight = flights[0],
                    Price = 250
                },
                new Ticket()
                {
                    Flight = flights[1],
                    Price = 250
                },
                new Ticket()
                {
                    Flight = flights[2],
                    Price = 250
                }
            };

            tickets.AddRange(tickets);

            context.SaveChanges();

        }
    }
}
