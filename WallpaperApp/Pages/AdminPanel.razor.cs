using Microsoft.AspNetCore.Components.Forms;
using WallpaperApp.Core;

namespace WallpaperApp.Pages
{
    public partial class AdminPanel
    {
        public string pathOfFolder = $"D:\\WallpaperAppPicture\\";

		public List<Wallpaper> wallpapers { get; set; }
		protected override async Task OnParametersSetAsync()
		{
			wallpapers = await wallpaperFileService.GetWallpapers();
		}

		IReadOnlyList<IBrowserFile> files;
        async void OnInputFileChange(InputFileChangeEventArgs e)
        {
            files = e.GetMultipleFiles();
            this.StateHasChanged();
        }

        async void Submit()
        {
            foreach (var item in files)
            {
                Stream stream = item.OpenReadStream();
                var path = Path.Combine(pathOfFolder, item.Name);
                FileStream fileStream = File.Create(path);
                await stream.CopyToAsync(fileStream);
                stream.Close();
                fileStream.Close();
            }

            this.StateHasChanged();
		}
		async void Delete(string fileName)
        {
			var path = Path.Combine(pathOfFolder, fileName);

            if (File.Exists(path))
            {
                File.Delete(path);
                wallpapers.Remove(wallpapers.First(x => x.FileName == fileName));
			}
			this.StateHasChanged();


		}
	}
}
