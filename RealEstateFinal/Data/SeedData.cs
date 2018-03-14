using RealEstateFinal.Models;
using System;
using System.Linq;
using RealEstateFinal.Data;
using Microsoft.Extensions.DependencyInjection;


namespace RealEstateFinal.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider services)
        {
            ApplicationDbContext context = services.GetRequiredService<ApplicationDbContext>();
            context.Database.EnsureCreated();
            if (!context.Listings.Any())
            {
                //Image image = new Image { ImageID = 1, URL = "~/images/home1.jpg" }; 
                //context.Images.Add(image);
                //context.SaveChanges();      
                Listing listing = new Listing {ImgURL = "/images/home1.jpg", Baths = 1.5, Beds = 2, AvailableNow = true, Body = "This place hardly hasn't had no murders in it.", Rent = 1300.00m, Title="Awesome Bungalow in Detroit" };
                context.Listings.Add(listing);
                Listing listing2 = new Listing { ImgURL = "/images/home2.jpg", Baths = 1, Beds = 5, AvailableNow = false, Body = "Only 10 visits from the police this month", Rent = 800.00m, Title = "Sweet Diggs in a Not So Great Area" };
                context.Listings.Add(listing2);
                Listing listing3 = new Listing { ImgURL = "/images/home3.jpg", Baths = 1, Beds = 2, AvailableNow = true, Body = "Sadly this is the best part of town", Rent = 900.00m, Title = "The Best in the West" };
                context.Listings.Add(listing3);
                Listing listing4 = new Listing { ImgURL = "/images/home4.jpg", Baths = 2, Beds = 2, AvailableNow = false, Body = "We accept felons!", Rent = 2000.00m, Title = "This One Has Most of its Floorboards" };
                context.Listings.Add(listing4);
                Listing listing5 = new Listing { ImgURL = "/images/home5.jpg", Baths = 6, Beds = 2, AvailableNow = true, Body = "Why are you even still considering renting from us?", Rent = 1100.00m, Title = "Needs Some Paint" };
                context.Listings.Add(listing5);
             
                //Listing listing2 = new Listing { Body = "A beautiful place to get away from law enforcement.", Rent = 1100.00m, Title = "Another Awesome House" };
                // context.Listings.Add(listing2);



                //image.Listings.Add(listing);




                context.SaveChanges(); // save the last addition
            }
        }
    }
}

