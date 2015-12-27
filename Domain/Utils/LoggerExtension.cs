using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace Domain.Utils
{
    //public class Main             //Extension Method!!!
    //{
    //    void Main()
    //    {
    //        string filename = "C:\\log.txt";
    //        filename.WriteToConsole();

    //        FileExtension.WriteToConsole(filename);
    //        filename.WriteToConsole();

    //        "test".WriteToConsole();
    //    }
    //}

    //public static class FileExtension                 //eine static class(kann nur static methods beinhalten) wird hier erzeugt, und hier wird eine extension method erstellt
    //{
    //    public static void WriteToConsole(this string filename)
    //    {
    //        Console.WriteLine(File.ReadAllText(filename));
    //    }
    //}


    //Extension Methods müssen in public static Klassen sein und selbst auch public static sein
    

    public static class LoggerExtension
    {
        public static Logger GetLogger(this object obj)         //mit dem this parameter wird auf ein object verwiesen in welchem dann die GetLogger Methode zur Laufzeit drinsteht als wenn diese in dem Objekt schon vorhanden wäre(gekennzeichnet mit einem blauen pfeil
        {                                                        //z.b.: wenn die klasse string als object genommen wird und eine variable davon instanziert wird können mit dieser variable die zusätzlichen string methoden wie trim verwendet werden und natürlich die erstellte extension method GetLogger()...ausgezeichnet.
            return new Logger(obj.GetType());        
        }


    }


}
