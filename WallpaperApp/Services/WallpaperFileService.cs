using WallpaperApp.Core;
using WallpaperApp.Services.Interfaces;

namespace WallpaperApp.Services
{
    public class WallpaperFileService : IWallpaperFileService
    {
        string WallpaperFolderPath = "D:\\WallpaperAppPicture";
        public List<Wallpaper> GetWallpapers()
        {
            List<string> files = Directory.GetFiles(WallpaperFolderPath, "*.jpg").ToList();
            return null;
        }
    }
}
