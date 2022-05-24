/*
 * 
 *      Purpose: Create a program that adds product to a list and display the products in the list.
 * 
 * 
 *      Author: Youngjae Lee
 *      
 *      
 *      Last modified date: 2021 Mar 28
 *      
 *      
 */

using System;
using System.Collections.Generic;

namespace CPSC1012_Exercise07_Youngjae_Lee
{
    class Program
    {
            //add product method
            static int AddProduct(List<Product> products)
            {
                //variable to control the while loop
                char userChoice = 'y';

                //storing the number of products added
                int numberOfProductsAdded = 0;

                //while loop declaration
                while (userChoice != 'n')
                {

                    //asking the user for the name of the product
                    Console.Write("Enter name of a product: ");

                    //storing the name
                    string name = Console.ReadLine();

                    //asking the user for the description of the product
                    Console.Write("Product's Description: ");

                    //storing the description
                    string description = Console.ReadLine();

                    //asking the user for the product's price and storing the user-input
                    double price = GetSafeDouble("Product's price: ");

                    //adding a line
                    Console.WriteLine();

                    //creating a new product instance based on what the user had entered
                    Product productObject = new Product(name, description, price);
                    
                    //adding the productObject to the list
                    products.Add(productObject);

                    //incrementing the number of products added by 1
                    numberOfProductsAdded++;

                    //asking the user to add anohter product
                    userChoice = GetSafeChar("Add another product (y/n): ");
                }

                //returning the number of products added
                return numberOfProductsAdded;

            }

           //display product method
            static void DisplayProducts(List<Product> products)
            {
                    
                    Console.WriteLine("Products");
                    Console.WriteLine("========");
                    Console.WriteLine("{0,-10} {1,-20} {2,20}","Name","Description","Price");
        

                    //using foreach loop to display each element's name, description, and price
                    foreach (Product product in products)
                    {
                        Console.WriteLine("{0,-10} {1,-20} {2,20}", $"{product.Name}", $"{product.Description}", $"${product.Price}");
                    }
            }

            //getting the user-input(double) method
            static double GetSafeDouble(string message)
            {
                double doubleValue = 0;
                bool validInput = false;

                while (!validInput)
                {
                    Console.Write(message);
                    validInput = double.TryParse(Console.ReadLine(), out doubleValue);
                    if (!validInput)
                    {
                        Console.WriteLine("Invalid input! You must enter a double value for the answer");
                    }
                }

                return Math.Round(doubleValue, 2);
            }

            //getting the user-input(char) method
            static char GetSafeChar(string message)
            {
                char charValue = '0';
                bool validInput = false;

                while (!validInput)
                {
                    Console.Write(message);
                    validInput = char.TryParse(Console.ReadLine(), out charValue);
                    if (!validInput)
                    {
                        Console.WriteLine("Invalid input! You must enter a char value for the answer");
                    }
                }

                return charValue;
            }

            static void Main(string[] args)
            {
                //creating a new list to store the products
                List<Product> products = new List<Product>();

                //calling the AddProduct method to start adding the products
                AddProduct(products);

                //calling the DisplayProducts method to display the products in the list
                DisplayProducts(products);
            }
    }
}