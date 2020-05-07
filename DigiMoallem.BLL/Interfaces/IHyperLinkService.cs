using DigiMoallem.BLL.DTOs.HyperLink;
using DigiMoallem.DAL.Entities.General;
using Microsoft.AspNetCore.Http;
using System;

namespace DigiMoallem.BLL.Interfaces
{
    public interface IHyperLinkService : IDisposable
    {
        HyperLinkViewModel GetHyperLinks(int pageNumber, int pageSize);

        UploadLink GetHyperLinkById(int UploadLinkId);

        UploadLink AddHyperLink(UploadLink uploadLink, IFormFile uploadFile);

        void RemoveHyperLink(int uploadLinkId);
    }
}
