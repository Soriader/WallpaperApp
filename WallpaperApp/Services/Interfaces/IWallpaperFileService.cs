using WallpaperApp.Core;

namespace WallpaperApp.Services.Interfaces
{
    public interface IWallpaperFileService
    {
        Task<List<Wallpaper>> GetWallpapers();
    }
}
