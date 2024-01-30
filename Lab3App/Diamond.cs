using System;
namespace Lab3App
{
    public class Diamond : Treasure {
        public Diamond(string description, int score) : base(description, score){

        }

        public override void Display(){

            Console.WriteLine($"Diamond {Description} is displayed.");
        } 
       

	} // end of class Diamond
} // end of namespace Lab3App

