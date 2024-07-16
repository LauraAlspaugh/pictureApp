namespace pictureApp.Controllers;
[ApiController]
[Route("api/[controller]")]
public class PictureController : ControllerBase
{
    private readonly PicturesService _picturesService;
    private readonly Auth0Provider _autho0Provider;

    public PictureController(Auth0Provider autho0Provider)
    {
        _autho0Provider = autho0Provider;
        _picturesService = _picturesService;

    }
}
