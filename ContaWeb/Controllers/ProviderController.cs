
namespace ContaWeb.Controllers
{
    using ContaWeb.Data.Repositories;
    using ContaWeb.Helpers;
    using Microsoft.AspNetCore.Mvc;

    public class ProviderController: Controller
    {
        private readonly IProviderRepository providerRepository;
        private readonly IUserHelper userHelper;

        public ProviderController(IProviderRepository providerRepository, IUserHelper userHelper)
        {
            this.providerRepository = providerRepository;
            this.userHelper = userHelper;
        }
        // GET: Providers
        public IActionResult Index()
        {
            return View(this.providerRepository.GetAll());
        }

    }
}
