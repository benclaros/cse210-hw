using System;

class Program
{
    static void Main(string[] args)
    {
        //Set Lecture
        Address addressLecture = new Address("Calle de Los Pincheiras 876, Maitencillo, Santiago, Chile");
        Lecture lecture = new Lecture("Condorito", "Reading the most famous chilean comic", "06/08/2024", "17:30", addressLecture);

        //Display Lecture
        lecture.StandardDetails();
        lecture.FullDetails();
        lecture.ShortDetails();

        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine();

        //Set Reception
        Address addressReception = new Address("Henrique Dominguez 683, Antofagasta, Tocopilla, Chile");
        Reception reception = new Reception("How to overcome problems", "Course to be successfull", "25/09/2024", "09:00", addressReception);

        //Display Reception
        reception.StandardDetails();
        reception.FullDetails();
        reception.ShortDetails();

        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine();

        //Set Gathering
        Address addressGathering = new Address("4 poniente 678, Valparaiso, Viña del Mar, Chile");
        Gathering gathering = new Gathering("Game spot", "Game exposition, Cosplay and Meeting", "01/10/24", "14:00", addressGathering);

        //Display Gathering
        gathering.StandardDetails();
        gathering.FullDetails();
        gathering.ShortDetails();
    }
}