using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using ClassLibrary1;

namespace BilbasenKonsol
{
    internal class Program
    {

        public static List<Car> cars = new List<Car>
            {
                new Car("Ford", "Mustang", 1963, "Red", 430, 6),
                new Car("Toyota", "Camry", 2020, "Blue", 200, 6),
                new Car("Chevrolet", "Corvette", 2022, "Silver", 650, 6),
                new Car("Honda", "Civic", 2008, "White", 140, 4),
                new Car("BMW", "X5", 2015, "Black", 300, 6),
                new Car("Audi", "A3", 2019, "Gray", 190, 4),
                new Car("Mercedes-Benz", "E-Class", 2018, "Silver", 350, 6),
                new Car("Volkswagen", "Golf", 2017, "Blue", 170, 4),
                new Car("Tesla", "Model S", 2021, "White", 670, 0),
                new Car("Hyundai", "Elantra", 2016, "Red", 150, 4),
                new Car("Ford", "F-150", 2019, "Black", 450, 8),
                new Car("Toyota", "Corolla", 2014, "Silver", 132, 4),
                new Car("Chevrolet", "Silverado", 2018, "Blue", 355, 8),
                new Car("Honda", "Accord", 2017, "Gray", 192, 4),
                new Car("BMW", "3 Series", 2020, "White", 255, 4),
                new Car("Audi", "A4", 2016, "Black", 252, 4),
                new Car("Mercedes-Benz", "C-Class", 2015, "Silver", 241, 4),
                new Car("Volkswagen", "Jetta", 2018, "Red", 147, 4),
                new Car("Tesla", "Model 3", 2019, "Blue", 283, 0),
                new Car("Hyundai", "Sonata", 2013, "Gray", 198, 4),
                new Car("Ford", "Focus", 2017, "White", 160, 4),
                new Car("Toyota", "Rav4", 2020, "Red", 203, 4),
                new Car("Chevrolet", "Equinox", 2019, "Silver", 170, 4),
                new Car("Honda", "Pilot", 2016, "Blue", 280, 6),
                new Car("BMW", "5 Series", 2014, "Black", 315, 6),
                new Car("Audi", "Q5", 2018, "Gray", 248, 4),
                new Car("Mercedes-Benz", "GLC", 2017, "White", 241, 4),
                new Car("Volkswagen", "Tiguan", 2019, "Red", 184, 4),
                new Car("Tesla", "Model X", 2018, "Blue", 503, 0),
                new Car("Hyundai", "Tucson", 2015, "Silver", 164, 4),
                new Car("Ford", "Escape", 2021, "White", 181, 4),
                new Car("Toyota", "Highlander", 2019, "Red", 295, 6),
                new Car("Chevrolet", "Traverse", 2017, "Blue", 310, 6),
                new Car("Honda", "Odyssey", 2020, "Gray", 280, 6),
                new Car("BMW", "7 Series", 2016, "Black", 444, 8),
                new Car("Audi", "A6", 2018, "Silver", 335, 6),
                new Car("Mercedes-Benz", "GLE", 2019, "White", 362, 6),
                new Car("Volkswagen", "Atlas", 2021, "Red", 276, 6),
                new Car("Tesla", "Model Y", 2022, "Blue", 394, 0),
                new Car("Hyundai", "Santa Fe", 2018, "Silver", 235, 4),
                new Car("Ford", "Explorer", 2017, "White", 290, 6),
                new Car("Toyota", "Tacoma", 2020, "Red", 278, 6),
                new Car("Chevrolet", "Colorado", 2019, "Blue", 200, 4),
                new Car("Honda", "CR-V", 2015, "Gray", 185, 4),
                new Car("BMW", "X3", 2018, "Black", 248, 4),
                new Car("Audi", "Q7", 2017, "Silver", 329, 6),
                new Car("Mercedes-Benz", "GLA", 2016, "White", 208, 4),
                new Car("Volkswagen", "Passat", 2020, "Red", 174, 4),
                new Car("Tesla", "Cybertruck", 2023, "Gray", 800, 0),
                new Car("Hyundai", "Kona", 2019, "Silver", 147, 4),
                new Car("Ford", "Ranger", 2016, "White", 270, 4),
                new Car("Toyota", "Sienna", 2021, "Red", 296, 6),
                new Car("Chevrolet", "Blazer", 2020, "Blue", 308, 6),
                new Car("Honda", "Fit", 2018, "Gray", 130, 4),
                new Car("BMW", "4 Series", 2017, "Black", 248, 4),
                new Car("Audi", "A5", 2015, "Silver", 220, 4),
                new Car("Mercedes-Benz", "GLB", 2019, "White", 221, 4),
                new Car("Volkswagen", "Arteon", 2022, "Red", 268, 4),
                new Car("Tesla", "Roadster", 2024, "Blue", 1000, 0),
                new Car("Hyundai", "Venue", 2020, "Silver", 121, 4),
                new Car("Ford", "Expedition", 2019, "White", 375, 6),
                new Car("Toyota", "Tundra", 2017, "Red", 381, 8),
                new Car("Chevrolet", "Tahoe", 2018, "Blue", 355, 8),
                new Car("Honda", "Ridgeline", 2016, "Gray", 280, 6),
                new Car("BMW", "X7", 2021, "Black", 523, 8),
                new Car("Audi", "Q8", 2020, "Silver", 335, 6),
                new Car("Mercedes-Benz", "GLS", 2023, "White", 429, 6),
                new Car("Volkswagen", "ID.4", 2022, "Red", 201, 0),
                new Car("Tesla", "Model S Plaid", 2022, "Blue", 1100, 0),
                new Car("Hyundai", "Palisade", 2021, "Silver", 291, 6),
                new Car("Ford", "Bronco", 2021, "White", 310, 6),
                new Car("Toyota", "4Runner", 2020, "Red", 270, 6),
                new Car("Chevrolet", "Suburban", 2019, "Blue", 355, 8),
                new Car("Honda", "HR-V", 2017, "Gray", 141, 4),
                new Car("BMW", "X6", 2016, "Black", 445, 6),
                new Car("Audi", "SQ5", 2018, "Silver", 349, 6),
                new Car("Mercedes-Benz", "GLE Coupe", 2015, "White", 362, 6),
                new Car("Volkswagen", "Touareg", 2018, "Red", 335, 6),
                new Car("Tesla", "Model Y Performance", 2023, "Blue", 450, 0),
                new Car("Hyundai", "Ioniq", 2020, "Silver", 134, 4),
                new Car("Ford", "Mustang Mach-E", 2021, "White", 480, 0),
                new Car("Toyota", "Prius", 2019, "Red", 121, 4),
                new Car("Chevrolet", "Spark", 2017, "Blue", 98, 4),
                new Car("Honda", "Insight", 2018, "Gray", 151, 4),
                new Car("BMW", "i3", 2016, "Black", 170, 0),
                new Car("Audi", "e-tron", 2020, "Silver", 355, 0),
                new Car("Mercedes-Benz", "EQC", 2021, "White", 402, 0),
                new Car("Volkswagen", "e-Golf", 2019, "Red", 134, 0),
                new Car("Tesla", "Model 3 Long Range", 2022, "Blue", 353, 0),
                new Car("Hyundai", "Nexo", 2021, "Silver", 161, 0),
                new Car("Ford", "Transit", 2020, "White", 275, 6),
                new Car("Toyota", "Sienna Hybrid", 2021, "Red", 245, 4),
                new Car("Chevrolet", "Express", 2018, "Blue", 276, 8),
                new Car("Honda", "Odyssey Hybrid", 2020, "Gray", 280, 6),
                new Car("BMW", "X7 M50i", 2021, "Black", 523, 8),
                new Car("Audi", "Q7 TFSI e", 2020, "Silver", 335, 6),
                new Car("Mercedes-Benz", "GLS 600", 2023, "White", 429, 6),
                new Car("Volkswagen", "ID. Buzz", 2024, "Red", 201, 0),
                new Car("Tesla", "Model S Plaid+", 2022, "Blue", 1100, 0),
                new Car("Hyundai", "IONIQ 5", 2022, "Silver", 320, 0)
            };

        public static List<Car> filteredCars = new List<Car>();


        public static void Main(string[] args)
        {



            //Det er vigtigt at I finder en god datatype til at opbevare jeres biler / Objekter!
            Search();

            Console.WriteLine($"\nWould you filter? 1) Yes, 2) no");
            string varFilterConformation = Console.ReadLine().ToLower();





            if (varFilterConformation == "yes" || varFilterConformation == "1")
            {
                Filter();
            }
            else if (varFilterConformation == "no" || varFilterConformation == "2")
            {
            }


        }

        public static void Search()
        {
            Console.WriteLine("Enter Brand: ");
            string varSearch = Console.ReadLine();
            DisplayVechicle(varSearch);
        }

        public static void Filter()
        {
            Console.WriteLine($"\n-------------------------------------------------------------");
            Console.WriteLine($"\nWhat to filter? 1) Year, 2) Color, 3) HorsePower ");
            string filterOptions = Console.ReadLine().ToLower();


            if (filterOptions == "1" || filterOptions == "year")
            {
                Console.WriteLine("Enter start year: ");
                if (int.TryParse(Console.ReadLine(), out int minYear))
                {
                    Console.WriteLine("Enter end year: ");
                    if (int.TryParse(Console.ReadLine(), out int maxYear))
                    {
                        DisplayVechicleYear(minYear, maxYear);

                    }
                }


            }
            else if (filterOptions == "2" || filterOptions == "color")
            {
                Console.WriteLine("Enter color: ");
                string filterColor = Console.ReadLine();


                DisplayVechicleColor(filterColor);


            }
            else if (filterOptions == "3" || filterOptions == "horsepower")
            {
                Console.WriteLine("Enter min. HP: ");
                if (int.TryParse(Console.ReadLine(), out int minHP))
                {
                    Console.WriteLine("Enter max. HP: ");
                    if (int.TryParse(Console.ReadLine(), out int maxHP))
                    {
                        DisplayVechicleHP(minHP, maxHP);

                    }
                }


            }
        }

        public static void DisplayVechicle(string searchTerm)
        {
            int count = 0;
            string countBrand = "";

            filteredCars.Clear();
            if (searchTerm.ToLower() == "all")
            {
                foreach (Car car in cars)
                {
                    filteredCars.Add(car);
                    Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, HorsePower: {car.HoursePower}, Cylinders: {car.NumberOfCylinders}");
                    count++;
                    countBrand = "all";
                }
                Console.WriteLine($"Total search {countBrand}: {count}");

            }
            else
            {
                foreach (Car car in cars)
                {

                    if (car.Brand.Equals(searchTerm, StringComparison.OrdinalIgnoreCase) || car.Model.Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
                    {
                        filteredCars.Add(car);
                        Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, HorsePower: {car.HoursePower}, Cylinders: {car.NumberOfCylinders}");
                        count++;
                        countBrand += searchTerm;

                    }
                }
                Console.WriteLine($"Total search {countBrand}: {count}");

            }

        }

        public static void DisplayVechicleColor(string searchTerm)
        {
            int countColor = 0;
            string countBrand = "";

            Console.Clear();
            Console.WriteLine();

            foreach (Car car in filteredCars)
            {
                if (car.Color.Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, HorsePower: {car.HoursePower}, Cylinders: {car.NumberOfCylinders}");
                    countColor++;
                }
            }
            countBrand += searchTerm;
            Console.WriteLine($"Total search result: {countColor}");

        }

        public static void DisplayVechicleHP(int minHP, int maxHP)
        {
            int countHP = 0;
            string countBrand = "";

            Console.Clear();
            Console.WriteLine();

            foreach (Car car in filteredCars)
            {
                if (car.HoursePower >= minHP && car.HoursePower <= maxHP)
                {
                    Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, HorsePower: {car.HoursePower}, Cylinders: {car.NumberOfCylinders}");
                    countHP++;

                }
            }
            Console.WriteLine($"Total search result: {countHP}");

        }

        public static void DisplayVechicleYear(int minYear, int maxYear)
        {
            int countYear = 0;
            string countBrand = "";
            Console.Clear();
            Console.WriteLine();
            foreach (Car car in filteredCars)
            {
                if (car.Year >= minYear && car.Year <= maxYear)
                {
                    Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, HorsePower: {car.HoursePower}, Cylinders: {car.NumberOfCylinders}");
                    countYear++;
                    countBrand += car.Brand;
                }
            }
            Console.WriteLine($"Total search result: {countYear}");

        }


    }
}




//using ClassLibrary1;
//using System.Diagnostics.Metrics;
//using System.Security.Cryptography.X509Certificates;

//namespace BilbasenKonsol
//{
//    internal class Program
//    {

//        public static List<Car> cars = new List<Car>
//        {
//            new Car("Ford", "Mustang", 1963, "Red", 430, 6),
//            new Car("Toyota", "Camry", 2020, "Blue", 200, 6),
//            new Car("Chevrolet", "Corvette", 2022, "Silver", 650, 6),
//            new Car("Honda", "Civic", 2008, "White", 140, 4),
//            new Car("BMW", "X5", 2015, "Black", 300, 6),
//            new Car("Audi", "A3", 2019, "Gray", 190, 4),
//            new Car("Mercedes-Benz", "E-Class", 2018, "Silver", 350, 6),
//            new Car("Volkswagen", "Golf", 2017, "Blue", 170, 4),
//            new Car("Tesla", "Model S", 2021, "White", 670, 0),
//            new Car("Hyundai", "Elantra", 2016, "Red", 150, 4),
//            new Car("Ford", "F-150", 2019, "Black", 450, 8),
//            new Car("Toyota", "Corolla", 2014, "Silver", 132, 4),
//            new Car("Chevrolet", "Silverado", 2018, "Blue", 355, 8),
//            new Car("Honda", "Accord", 2017, "Gray", 192, 4),
//            new Car("BMW", "3 Series", 2020, "White", 255, 4),
//            new Car("Audi", "A4", 2016, "Black", 252, 4),
//            new Car("Mercedes-Benz", "C-Class", 2015, "Silver", 241, 4),
//            new Car("Volkswagen", "Jetta", 2018, "Red", 147, 4),
//            new Car("Tesla", "Model 3", 2019, "Blue", 283, 0),
//            new Car("Hyundai", "Sonata", 2013, "Gray", 198, 4),
//            new Car("Ford", "Focus", 2017, "White", 160, 4),
//            new Car("Toyota", "Rav4", 2020, "Red", 203, 4),
//            new Car("Chevrolet", "Equinox", 2019, "Silver", 170, 4),
//            new Car("Honda", "Pilot", 2016, "Blue", 280, 6),
//            new Car("BMW", "5 Series", 2014, "Black", 315, 6),
//            new Car("Audi", "Q5", 2018, "Gray", 248, 4),
//            new Car("Mercedes-Benz", "GLC", 2017, "White", 241, 4),
//            new Car("Volkswagen", "Tiguan", 2019, "Red", 184, 4),
//            new Car("Tesla", "Model X", 2018, "Blue", 503, 0),
//            new Car("Hyundai", "Tucson", 2015, "Silver", 164, 4),
//            new Car("Ford", "Escape", 2021, "White", 181, 4),
//            new Car("Toyota", "Highlander", 2019, "Red", 295, 6),
//            new Car("Chevrolet", "Traverse", 2017, "Blue", 310, 6),
//            new Car("Honda", "Odyssey", 2020, "Gray", 280, 6),
//            new Car("BMW", "7 Series", 2016, "Black", 444, 8),
//            new Car("Audi", "A6", 2018, "Silver", 335, 6),
//            new Car("Mercedes-Benz", "GLE", 2019, "White", 362, 6),
//            new Car("Volkswagen", "Atlas", 2021, "Red", 276, 6),
//            new Car("Tesla", "Model Y", 2022, "Blue", 394, 0),
//            new Car("Hyundai", "Santa Fe", 2018, "Silver", 235, 4),
//            new Car("Ford", "Explorer", 2017, "White", 290, 6),
//            new Car("Toyota", "Tacoma", 2020, "Red", 278, 6),
//            new Car("Chevrolet", "Colorado", 2019, "Blue", 200, 4),
//            new Car("Honda", "CR-V", 2015, "Gray", 185, 4),
//            new Car("BMW", "X3", 2018, "Black", 248, 4),
//            new Car("Audi", "Q7", 2017, "Silver", 329, 6),
//            new Car("Mercedes-Benz", "GLA", 2016, "White", 208, 4),
//            new Car("Volkswagen", "Passat", 2020, "Red", 174, 4),
//            new Car("Tesla", "Cybertruck", 2023, "Gray", 800, 0),
//            new Car("Hyundai", "Kona", 2019, "Silver", 147, 4),
//            new Car("Ford", "Ranger", 2016, "White", 270, 4),
//            new Car("Toyota", "Sienna", 2021, "Red", 296, 6),
//            new Car("Chevrolet", "Blazer", 2020, "Blue", 308, 6),
//            new Car("Honda", "Fit", 2018, "Gray", 130, 4),
//            new Car("BMW", "4 Series", 2017, "Black", 248, 4),
//            new Car("Audi", "A5", 2015, "Silver", 220, 4),
//            new Car("Mercedes-Benz", "GLB", 2019, "White", 221, 4),
//            new Car("Volkswagen", "Arteon", 2022, "Red", 268, 4),
//            new Car("Tesla", "Roadster", 2024, "Blue", 1000, 0),
//            new Car("Hyundai", "Venue", 2020, "Silver", 121, 4),
//            new Car("Ford", "Expedition", 2019, "White", 375, 6),
//            new Car("Toyota", "Tundra", 2017, "Red", 381, 8),
//            new Car("Chevrolet", "Tahoe", 2018, "Blue", 355, 8),
//            new Car("Honda", "Ridgeline", 2016, "Gray", 280, 6),
//            new Car("BMW", "X7", 2021, "Black", 523, 8),
//            new Car("Audi", "Q8", 2020, "Silver", 335, 6),
//            new Car("Mercedes-Benz", "GLS", 2023, "White", 429, 6),
//            new Car("Volkswagen", "ID.4", 2022, "Red", 201, 0),
//            new Car("Tesla", "Model S Plaid", 2022, "Blue", 1100, 0),
//            new Car("Hyundai", "Palisade", 2021, "Silver", 291, 6),
//            new Car("Ford", "Bronco", 2021, "White", 310, 6),
//            new Car("Toyota", "4Runner", 2020, "Red", 270, 6),
//            new Car("Chevrolet", "Suburban", 2019, "Blue", 355, 8),
//            new Car("Honda", "HR-V", 2017, "Gray", 141, 4),
//            new Car("BMW", "X6", 2016, "Black", 445, 6),
//            new Car("Audi", "SQ5", 2018, "Silver", 349, 6),
//            new Car("Mercedes-Benz", "GLE Coupe", 2015, "White", 362, 6),
//            new Car("Volkswagen", "Touareg", 2018, "Red", 335, 6),
//            new Car("Tesla", "Model Y Performance", 2023, "Blue", 450, 0),
//            new Car("Hyundai", "Ioniq", 2020, "Silver", 134, 4),
//            new Car("Ford", "Mustang Mach-E", 2021, "White", 480, 0),
//            new Car("Toyota", "Prius", 2019, "Red", 121, 4),
//            new Car("Chevrolet", "Spark", 2017, "Blue", 98, 4),
//            new Car("Honda", "Insight", 2018, "Gray", 151, 4),
//            new Car("BMW", "i3", 2016, "Black", 170, 0),
//            new Car("Audi", "e-tron", 2020, "Silver", 355, 0),
//            new Car("Mercedes-Benz", "EQC", 2021, "White", 402, 0),
//            new Car("Volkswagen", "e-Golf", 2019, "Red", 134, 0),
//            new Car("Tesla", "Model 3 Long Range", 2022, "Blue", 353, 0),
//            new Car("Hyundai", "Nexo", 2021, "Silver", 161, 0),
//            new Car("Ford", "Transit", 2020, "White", 275, 6),
//            new Car("Toyota", "Sienna Hybrid", 2021, "Red", 245, 4),
//            new Car("Chevrolet", "Express", 2018, "Blue", 276, 8),
//            new Car("Honda", "Odyssey Hybrid", 2020, "Gray", 280, 6),
//            new Car("BMW", "X7 M50i", 2021, "Black", 523, 8),
//            new Car("Audi", "Q7 TFSI e", 2020, "Silver", 335, 6),
//            new Car("Mercedes-Benz", "GLS 600", 2023, "White", 429, 6),
//            new Car("Volkswagen", "ID. Buzz", 2024, "Red", 201, 0),
//            new Car("Tesla", "Model S Plaid+", 2022, "Blue", 1100, 0),
//            new Car("Hyundai", "IONIQ 5", 2022, "Silver", 320, 0)
//        };

//        public static List<Car> searchedCars = new List<Car>();
//        public static void Main(string[] args)
//        {
//            Search();
//            Console.WriteLine("---------------------------------------------");
//            Console.WriteLine("Would you like to filter your search? 1) Yes 2) No");
//            string filterYesOrNo = Console.ReadLine().ToLower();

//            if(filterYesOrNo == "1" || filterYesOrNo == "yes")
//            {
//                Filter();
//            }


//        }

//        //Det er vigtigt at I finder en god datatype til at opbevare jeres biler / Objekter!
//        public static void Search()
//        {

//            Console.WriteLine("What brand would you like to search for?");
//            String Search = Console.ReadLine();
//            DisplayVechicle(Search);
//        }

//        public static void Filter()
//        {
//            Console.WriteLine("How would you like to filter your search? 1)Color 2)HP 3) Year");
//            string filter = Console.ReadLine().ToLower();

//            if( filter == "1" || filter == "color")
//            {
//                Console.WriteLine("Input color?");
//                String filterColor = Console.ReadLine();
//                DisplayVechicleColor(filterColor);

//            }
//            if( filter == "2" || filter == "hp")
//            {
//                Console.WriteLine("Input minimum HP: ");
//                if (int.TryParse(Console.ReadLine(), out int minimumHK))
//                {
//                    Console.WriteLine("Input maksimum HP: ");
//                    if (int.TryParse(Console.ReadLine(),out int maximumHK))
//                    {
//                        DisplayVechicleHP(minimumHK, maximumHK);
//                    }
//                    else
//                    {
//                        Console.WriteLine("Invalid input. Please try again.");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Invalid input. Please try again.");
//                }
//            }
//            else if ( filter == "3" || filter == "year")
//            {
//                Console.WriteLine("Input year from: ");
//                if (int.TryParse(Console.ReadLine(), out int minimumYear))
//                {
//                    Console.WriteLine("Input year till: ");
//                    if (int.TryParse(Console.ReadLine(), out int maximumYear))
//                    {
//                        DisplayVechicleYear(minimumYear, maximumYear);
//                    }
//                    else
//                    {
//                        Console.WriteLine("Invalid input. Please try again.");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Invalid input. Please try again.");
//                }
//            }
//        }

//        public static void DisplayVechicle(string searchterm)
//        {
//            int count = 0;
//            searchedCars.Clear();
//            if (searchterm.ToLower() == "all")
//            {
//                foreach (Car car in cars)
//                {
//                    searchedCars.AddRange(cars);
//                    Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, Horse Power: {car.HoursePower}, Cylinder: {car.NumberOfCylinders}");
//                    count++;
//                }
//                Console.WriteLine($"Total search results: {count}");
//            }
//            else
//            {
//                foreach (Car car in cars)
//                {
//                    if (car.Brand.Equals(searchterm, StringComparison.OrdinalIgnoreCase) || car.Model.Equals(searchterm, StringComparison.OrdinalIgnoreCase))
//                    {
//                        searchedCars.Add(car);

//                        Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, Horse Power: {car.HoursePower}, Cylinder: {car.NumberOfCylinders}");

//                        count++;
//                    }
//                }
//                Console.WriteLine($"Total search results: {count}");
//            }

//        }

//        public static void DisplayVechicleColor(string searchterm)
//        {
//            int countColor = 0;
//            Console.Clear();
//            foreach (Car car in searchedCars) 
//            {
//                if (car.Color.Equals(searchterm, StringComparison.OrdinalIgnoreCase) )
//                {
//                    Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, Horse Power: {car.HoursePower}, Cylinder: {car.NumberOfCylinders}");
//                    countColor++;

//                }
//            }
//            Console.WriteLine($"Total search results: {countColor}");
//        }

//        public static void DisplayVechicleHP( int minimumHK, int maximumHK)
//        {
//            int countHP = 0;
//            Console.Clear();
//            foreach (Car car in searchedCars)
//            {
//                if (car.HoursePower >= minimumHK && car.HoursePower <= maximumHK)
//                {
//                    Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, Horse Power: {car.HoursePower}, Cylinder: {car.NumberOfCylinders}");
//                    countHP++;
//                }
//            }
//            Console.WriteLine($"Total search results: {countHP}");
//        }

//        public static void DisplayVechicleYear(int minimumYear, int maximumYear)
//        {
//            int countYear = 0;
//            Console.Clear();
//            foreach (Car car in searchedCars)
//            {
//                if (car.Year >= minimumYear && car.Year <= maximumYear)
//                {
//                    Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, Horse Power: {car.HoursePower}, Cylinder: {car.NumberOfCylinders}");
//                    countYear++;
//                }
//            }
//            Console.WriteLine($"Total search results: {countYear}");
//        }
//    }
//}
