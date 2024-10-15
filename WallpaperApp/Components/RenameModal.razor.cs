namespace WallpaperApp.Components
{
	public partial class RenameModal
	{
		private Modal modal { get; set; }
		private string File { get; set; }
		private string NewName { get; set; }

		public async void Open(string file)
		{
			File = file;
			modal.Open();
			StateHasChanged();
		}

		async void Submit()
		{

		}

	}

}
