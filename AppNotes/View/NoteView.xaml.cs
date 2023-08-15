namespace AppNotes.View;

public partial class NoteView : ContentView
{
	public NoteView()
	{
		InitializeComponent();
		BindingContext = new ViewModel.NoteViewModel();
	}
}