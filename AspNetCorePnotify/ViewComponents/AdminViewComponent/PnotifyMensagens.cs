using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Saed.Web.ViewComponents.AdminViewComponent
{
    public class PnotifyMensagens : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            await Task.FromResult<object>(null);
            return View();
        }
    }
}
