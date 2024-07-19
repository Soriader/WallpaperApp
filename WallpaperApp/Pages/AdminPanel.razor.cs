using Microsoft.AspNetCore.Components.Forms;
using WallpaperApp.Core;

namespace WallpaperApp.Pages
{
    public partial class AdminPanel
    {
        public List<Wallpaper> wallpapers { get; set; }
		protected override async Task OnInitializedAsync()
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
                var path = $"D:\\WallpaperAppPicture\\{item.Name}";
                FileStream fileStream = File.Create(path);
                await stream.CopyToAsync(fileStream);
                stream.Close();
                fileStream.Close();
            }

            this.StateHasChanged();
        }
    }
}
