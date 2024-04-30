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

            List<Wallpaper> wallpapers = new List<Wallpaper>();

            foreach (var file in files)
            {
                wallpapers.Add(new Wallpaper());

			}

            return null;
        }
    }
}
