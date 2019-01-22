using FoodDelivery.Data.Entities.Foods;
using FoodDelivery.Data.Entities.Restaurants;
using FoodDelivery.Data.Entities.Reviews;
using FoodDelivery.Data.Entities.ShoppingCarts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
        ) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<FoodType>().HasData(
                new FoodType
                {
                    Id = 1,
                    Name = "Asian Foods",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new FoodType
                {
                    Id = 2,
                    Name = "Burgers",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new FoodType
                {
                    Id = 3,
                    Name = "Appetizers",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new FoodType
                {
                    Id = 4,
                    Name = "Desserts",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new FoodType
                {
                    Id = 5,
                    Name = "Breakfast",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new FoodType
                {
                    Id = 6,
                    Name = "Pizzas",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new FoodType
                {
                    Id = 7,
                    Name = "Roast",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                }
            );

            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    Id = 1,
                    Name = "Authentic Asian Food Restaurant",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new Restaurant
                {
                    Id = 2,
                    Name = "Western Food Restaurant",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                }
            );

            modelBuilder.Entity<Food>().HasData(
                new 
                {
                    Id = 1L,
                    Name = "Kimchi Fried Rice With Egg",
                    FoodTypeId = 1L,
                    Price = 7.00m,
                    ShortDescription = "Spicy fragnance kimchi fried rice together with an egg good enough for a simple meal!",
                    RestaurantId = 1L,
                    ImageUrl = "egg-food-fried-rice-53121 (1).jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 2L,
                    Name = "Healthy Breakfast Wrap",
                    FoodTypeId = 5L,
                    Price = 8.00m,
                    ShortDescription = "A healthy simple breakfast for wrap lover!",
                    RestaurantId = 2L,
                    ImageUrl = "appetizer-bowl-breakfast-280018.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 3L,
                    Name = "Chicken Dipper",
                    FoodTypeId = 3L,
                    Price = 4.00m,
                    ShortDescription = "Delicious snack fried chicken dipper with mayonnaise sauce",
                    LongDescription = "Something you cannot miss as an appetizer",
                    RestaurantId = 2L,
                    ImageUrl = "appetizer-chicken-chicken-dippers-1059943.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 4L,
                    Name = "Vegetables Salad",
                    FoodTypeId = 3L,
                    Price = 5.00m,
                    ShortDescription = "Only vegetables",
                    LongDescription = "Good for vegan",
                    RestaurantId = 2L,
                    ImageUrl = "appetizer-close-up-cucumber-406152.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 5L,
                    Name = "Prawn Noodle",
                    FoodTypeId = 1L,
                    Price = 6.00m,
                    ShortDescription = "Fresh prawn and ingredients",
                    LongDescription = "We use only fresh big prawns and ingredients to cook the best prawn noodle in the town.",
                    RestaurantId = 1L,
                    ImageUrl = "asian-food-bowl-cuisine-699953.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 6L,
                    Name = "Blueberry Chocolate Cake",
                    FoodTypeId = 4L,
                    Price = 30.00m,
                    ShortDescription = "Baked with love!",
                    LongDescription = "Delicious blueberry chocolate cake for birthday and any party occassions.",
                    RestaurantId = 2L,
                    ImageUrl = "bakery-baking-blueberries-291528.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 7L,
                    Name = "Skewed Meat",
                    FoodTypeId = 1L,
                    Price = 7.00m,
                    ShortDescription = "Juicy skewed meat with secret sauce",
                    LongDescription = "",
                    RestaurantId = 1L,
                    ImageUrl = "barbecue-bbq-cooking-111131.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 8L,
                    Name = "Tomato Prawn Spaghetti",
                    FoodTypeId = 3L,
                    Price = 13.00m,
                    ShortDescription = "Spaghetti with tomato sauce and prawns",
                    LongDescription = "",
                    RestaurantId = 2L,
                    ImageUrl = "basil-close-up-cooking-725997.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 9L,
                    Name = "Big beef cheeseburger",
                    FoodTypeId = 2L,
                    Price = 15.00m,
                    ShortDescription = "A full big beef cheeseburger for dinner",
                    LongDescription = "",
                    RestaurantId = 2L,
                    ImageUrl = "beef-bread-burger-156114.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 10L,
                    Name = "Pancake",
                    FoodTypeId = 5L,
                    Price = 4.00m,
                    ShortDescription = "Just a pancake",
                    LongDescription = "",
                    RestaurantId = 2L,
                    ImageUrl = "blur-breakfast-close-up-376464.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 11L,
                    Name = "Chasiu Noodle",
                    FoodTypeId = 1L,
                    Price = 5.00m,
                    ShortDescription = "A normal Chasiu Noodle",
                    LongDescription = "",
                    RestaurantId = 1L,
                    ImageUrl = "bowl-cooking-cuisine-698549.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 12L,
                    Name = "Ham Sandwich",
                    FoodTypeId = 5L,
                    Price = 7.00m,
                    ShortDescription = "Ham Sandwich",
                    LongDescription = "",
                    RestaurantId = 2L,
                    ImageUrl = "bread-breakfast-bun-461382.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 13L,
                    Name = "Crepe",
                    FoodTypeId = 5L,
                    Price = 7.00m,
                    ShortDescription = "Colorful Crepe for breakfast",
                    LongDescription = "",
                    RestaurantId = 2L,
                    ImageUrl = "breakfast-chocolate-cream-264727.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 14L,
                    Name = "Buritto Chicken",
                    FoodTypeId = 5L,
                    Price = 6.00m,
                    ShortDescription = "Buritto Chicken",
                    LongDescription = "",
                    RestaurantId = 2L,
                    ImageUrl = "burrito-chicken-close-up-461198.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 15L,
                    Name = "Pizza",
                    FoodTypeId = 6L,
                    Price = 13.00m,
                    ShortDescription = "Pizza lover",
                    LongDescription = "",
                    RestaurantId = 2L,
                    ImageUrl = "cheese-close-up-crust-1146760.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 16L,
                    Name = "Chicken & Chips",
                    FoodTypeId = 3L,
                    Price = 5.00m,
                    ShortDescription = "Chicken & Chips",
                    LongDescription = "",
                    RestaurantId = 2L,
                    ImageUrl = "chicken-chips-delicious-7782.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 17L,
                    Name = "Crispy Fried Chicken",
                    FoodTypeId = 1L,
                    Price = 5.00m,
                    ShortDescription = "Crispy Fried Chicken",
                    LongDescription = "",
                    RestaurantId = 1L,
                    ImageUrl = "chicken-close-up-crispy-60616.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 18L,
                    Name = "Roast Chicken with Potatoes",
                    FoodTypeId = 7L,
                    Price = 12.00m,
                    ShortDescription = "Roast Chicken with Potatoes",
                    LongDescription = "",
                    RestaurantId = 2L,
                    ImageUrl = "chicken-dinner-dish-236781.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 19L,
                    Name = "Pad Thai",
                    FoodTypeId = 1L,
                    Price = 5.00m,
                    ShortDescription = "Pad Thai",
                    LongDescription = "",
                    RestaurantId = 1L,
                    ImageUrl = "chopsticks-cuisine-dinner-46247.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 20L,
                    Name = "Baked Salmon",
                    FoodTypeId = 7L,
                    Price = 9.00m,
                    ShortDescription = "Baked Salmon",
                    LongDescription = "",
                    RestaurantId = 2L,
                    ImageUrl = "close-up-cooking-dinner-46239.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                },
                new
                {
                    Id = 21L,
                    Name = "Strawberry Yogurt",
                    FoodTypeId = 4L,
                    Price = 8.00m,
                    ShortDescription = "Strawberry Yogurt",
                    LongDescription = "",
                    RestaurantId = 2L,
                    ImageUrl = "cream-dessert-glass-8382.jpg",
                    CreatedBy = "seed",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "seed",
                    UpdatedDate = DateTime.Now,
                }
            );
        }

        public DbSet<Food> Foods { get; set; }

        public DbSet<FoodType> FoodTypes { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    }
}
