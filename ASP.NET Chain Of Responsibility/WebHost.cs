using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_Chain_Of_Responsibility{
    public class WebHost {

        // Private Fields

        private int _port;
        private HttpListener _listener;

        // Constructor

        public WebHost(int port) { 
            _port = port;
        }

        // Functions

        public void Run() {

            _listener = new HttpListener();
            _listener.Prefixes.Add($"http://localhost:{_port}/");
            _listener.Start();
            Console.WriteLine($"Http Server Started on {$"http://localhost:{_port}/"} ...");

            while (true) {

                var context = _listener.GetContext();

                Task.Run(() => {
                    HandleRequest(context);
                });
            }
        }

        private void HandleRequest(HttpListenerContext? context) { 
            var request = context?.Request;
            var response = context?.Response;
            var writer = new StreamWriter(response!.OutputStream);
            var str = request?.RawUrl;
            var path = str.Substring(1);

            if (!Path.HasExtension(path))
                path += ".html";

            var filename = "../../../views/" + path;

            try {
                if (File.Exists(filename)) {
                    response!.StatusCode = 200;
                    response!.ContentType = "text/html";
                    var text = File.ReadAllText(filename);
                    writer.Write(text);
                }
                else {
                    response!.StatusCode = 404;
                    var text = File.ReadAllText("../../../views/notfound.html");
                    writer.Write(text);
                }
            }
            catch (Exception error) {
                Console.WriteLine(error.Message);
                response!.StatusCode = 500;
                writer.Write(error.Message);
            }
            finally {
                response?.Close();
                writer?.Dispose();
            }
        }
    }
}
