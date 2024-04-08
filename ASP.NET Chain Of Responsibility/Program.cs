using System.Net;
using System.Text;
using ASP.NET_Chain_Of_Responsibility;
using ASP.NET_Chain_Of_Responsibility.Models.Abstracts;
using ASP.NET_Chain_Of_Responsibility.Models.Concretes;

#region HttpListener

//HttpListener listener = new HttpListener(); // Http listener assign proccess
//listener.Prefixes.Add("http://localhost:27001/"); // Giving endpoint to listener
//listener.Start(); // Starting our listener

//Console.WriteLine("Listening . . .");

//while (true) { // You have to write while because server couldn't down when it accepts only one requqest

//    var context = listener.GetContext(); // It waits for information request.

//    context.Response.OutputStream.Write(Encoding.UTF8.GetBytes("Hello, World!"));
//    context.Response.Close();
//}

#endregion

#region WebHost
//WebHost Host = new WebHost(27002);
//Host.Run();
#endregion

#region ChainOfResponsibility

CheckerDirector director = new CheckerDirector();
Person user = new User("hesenhttps", "2000Hasan", "hasanabdullazad@gmail.com");

director.MakePersonCheck(user);

#endregion