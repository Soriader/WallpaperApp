using WallpaperApp.Core;
using WallpaperApp.Services.Interfaces;

namespace WallpaperApp.Services
{
    public class WallpaperFileService : IWallpaperFileService
    {
        string WallpaperFolderPath = "D:\\WallpaperAppPicture";
        public List<Wallpaper> GetWallpapers()
        {
            List<string> files;
			List<Wallpaper> wallpapers = new List<Wallpaper>();

			try
            {
				files = Directory.GetFiles(WallpaperFolderPath, "*.jpg").ToList();
				foreach (var file in files)
				{
					wallpapers.Add(new Wallpaper(Path.GetFileName(file), file));
				}
			}
            catch(Exception ex)
            {
				throw new ApplicationException("An exception has been thrown during retrieval of wallpapers.", ex);
			}

			if (!wallpapers.Any())
            {
                throw new ApplicationException("No files has been found in the provided directory.");
            }

            return wallpapers;
        }
    }
}
