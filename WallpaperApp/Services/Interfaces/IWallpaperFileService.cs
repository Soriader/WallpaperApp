using WallpaperApp.Core;

namespace WallpaperApp.Services.Interfaces
{
    public interface IWallpaperFileService
    {
        Task<string> GetWallpaperFolderPath();
        Task<List<Wallpaper>> GetWallpapers();
    }
}
