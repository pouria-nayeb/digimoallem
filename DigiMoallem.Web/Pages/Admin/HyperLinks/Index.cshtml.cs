using DigiMoallem.BLL.DTOs.HyperLink;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigiMoallem.Web.Pages.Admin.HyperLinks
{
    public class IndexModel : PageModel
    {

        private readonly IHyperLinkService _hyperLinkService;

        public IndexModel(IHyperLinkService hyperLinkService)
        {
            _hyperLinkService = hyperLinkService;
        }

        public HyperLinkViewModel HyperLinkVM { get; private set; }

        public void OnGet(int pageNumber = 1, int pageSize = 32)
        {
            HyperLinkVM = _hyperLinkService.GetHyperLinks(pageNumber, pageSize);
        }
    }
}