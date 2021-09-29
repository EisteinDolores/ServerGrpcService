using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ServerGrpcService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Greeter.GreeterClient Client;
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public string Nombre { get; set; }
        [BindProperty]
        public string Mensaje { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            var url = "https://localhost:5001";
            var canal = GrpcChannel.ForAddress(url);
            Client = new Greeter.GreeterClient(canal);
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public async Task OnPost()
        {
            var helloRequest = new HelloRequest();
            helloRequest.Name = Nombre;

            var resultado = await Client.SayHelloAsync(helloRequest);
            Mensaje = resultado.Message;
        }
    }
}
