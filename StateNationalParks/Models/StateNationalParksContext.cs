using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StateNationalParks.Models
{
    public class StateNationalParksContext : DbContext
    {
        public StateNationalParksContext(DbContextOptions<StateNationalParksContext> options)
            : base(options)
        {
        }

        public DbSet<StatePark> StateParks { get; set; }
        public DbSet<NationalPark> NationalParks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // var apiCallTask = ApiHelper.ApiCall();
            // var result = apiCallTask.Result;
            // JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            // List<NationalPark> parkInfoList = JsonConvert.DeserializeObject<List<NationalPark>>(jsonResponse.ToString());
            // builder.Entity<NationalPark>()
            //     .HasData(
            //         foreach(var park in parkInfoList)
            //         {
            //             new NationalPark { Name= park.Name, Address = park.Address};
            //         }
            //     );
            builder.Entity<NationalPark>()
                .HasData(
                    new NationalPark { NationalParkId = 3, Name = "North Cascade National Park", Address = "Washington 98267"},
                    new NationalPark { NationalParkId = 4, Name = "Crater Lake National Park", Address = "Oregon 97604"},
                    new NationalPark { NationalParkId = 5, Name = "Glacire National Park", Address = "Montana 59936"},
                    new NationalPark { NationalParkId = 6, Name = "Yosemite National Park", Address = "California 95389"},
                    new NationalPark { NationalParkId = 7, Name = "Yellowstone National Park", Address = "Wyoming 82190"}                  
                );
            builder.Entity<StatePark>()
            .HasData(
                new StatePark { StateParkId = 3, Name = "Cape Disappointment State Park", Address = "Washington 98624"},
                new StatePark { StateParkId = 4, Name = "Silver Falls State Park", Address = "Oregon 97385"},
                new StatePark { StateParkId = 6, Name = "Pfeiffer Big Sur State Park", Address = "California 93520"}                 
            );
        }
    }
}