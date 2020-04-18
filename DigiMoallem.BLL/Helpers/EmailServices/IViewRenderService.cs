namespace DigiMoallem.BLL.Helpers.EmailServices
{
    public interface IViewRenderService
    {
        string RenderToString(string viewName, object model);
    }
}
