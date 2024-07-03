using StructuralDesignPatterns.Adapter;
using StructuralDesignPatterns.AdapterInterface;
using StructuralDesignPatterns.DownloadsProxy;
using StructuralDesignPatterns.MessageBridge;
using StructuralDesignPatterns.RegisterationFacade;
using StructuralDesignPatterns.RomoteBridge;
using StructuralDesignPatterns.StorageBridge;


//using StructuralDesignPatterns.AreaAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //****Adaper****
            //RoundPig roundPig = new RoundPig(20);
            //RadiusCalculator calculator = new RadiusCalculator();
            //int roundRadius = calculator.calculateRadius(roundPig);
            //Console.WriteLine(roundRadius);

            //SquarePig squarePig = new SquarePig(40);
            //SquarePigAdapter adapter = new SquarePigAdapter();
            //int squareRadius = adapter.calculateRadius(squarePig);
            //Console.WriteLine(squareRadius);


            //****AreaAdapter****
            //Rectangle rectangle = new Rectangle(20,10);
            //AreaCalculator areaCalculator = new AreaCalculator();
            //Console.WriteLine(areaCalculator.getArea(rectangle));

            //Triangle triangle = new Triangle(5,20);
            //CalculatorAdapter adapter = new CalculatorAdapter();
            //Console.WriteLine(adapter.getArea(triangle));


            //****AdapterInterface****
            //IRectangle rectangle = new Rectangle();
            //Console.WriteLine(rectangle.getArea(20, 10));

            //ITriangle adapter = new TriangleAdapter(rectangle);
            //Console.WriteLine(adapter.getArea(5, 10));




            //****RemoteBridge****
            //Tv tv = new Tv();
            //Remote tvRemote = new Remote(tv);
            //tvRemote.volumeUp();

            //Radio radio = new Radio();
            //Remote radioRemote = new Remote(radio);
            //radioRemote.volumeUp();


            //****MessageBridge****
            //Sms sms = new Sms();
            //Message longMessage = new LongMessage(sms);
            //longMessage.sendMessage("From SMS ");

            //Email email = new Email();
            //Message shortMessage = new ShortMessage(email);
            //shortMessage.sendMessage("From Email ");


            //****Storage Bridge****
            //FileStorage file = new FileStorage();
            //BaseRepository repository = new StudentRepository(file);
            //repository.save(); 

            //DatabaseStorage db = new DatabaseStorage();
            //BaseRepository repo = new StudentRepository(db);
            //repo.save();



            //****RegisterationFacade****
            //CustomerRegisterationFacade customerRegisteration = new CustomerRegisterationFacade();
            //customerRegisteration.register();




            //****DownloadsProxy****
            //DownloadProxy download = new DownloadProxy("movie");
            //download.downloadVideo();
            //download.downloadVideo();



            



        }
    }
}
