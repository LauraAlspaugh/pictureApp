namespace pictureApp.Repositories;
public class PicturesRepository
{
    private readonly IDbConnection _db;

    public PicturesRepository(IDbConnection db)
    {
        _db = db;
    }
}