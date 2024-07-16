namespace pictureApp.Services;
public class PicturesService
{
    private readonly PicturesRepository _picturesRepository;

    public PicturesService(PicturesRepository picturesRepository)
    {
        _picturesRepository = picturesRepository;
    }
}