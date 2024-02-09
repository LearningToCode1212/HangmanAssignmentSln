using Android.Text;

namespace HangmanAssignment;

public partial class HangmanGamePage : ContentPage
{
	public HangmanGamePage()
	{
		InitializeComponent();
        //Alphabets.AddRange("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        BindingContext = this;
	}

	// List
	List<string> words = new List<string>()
	{
		"coding",
		"tesing",
		"test",
		"code"
	};
	string answer = "";
	private string spotlight = "";
	List<char> guessWords = new List<char>();
	private List<char> letters = new List<char>();
	private string messageDisplayed = "";
	int amountOfErrors = 0;
	int maxErrors = 0;
	private string gameStatus = "";
	private string currentImage = "";
	private bool resetButtonEnabled = false;

	public string Spotlight
	{
		get => spotlight;
		set
		{
			spotlight = value;
			OnPropertyChanged();
		}
	}

	public List<Char> Letters
	{
		get => letters;
		set
		{
			letters = value;
			OnPropertyChanged();
		}
	}

	public string MessageDisplayed
	{
		get => messageDisplayed;
		set
		{
			messageDisplayed = value;
			OnPropertyChanged();
		}
	}

	public string GameStatus
	{
		get => gameStatus;
		set
		{
			gameStatus = value;
			OnPropertyChanged();
		}
	}

	public string CurrentImage
	{
		get => currentImage;
		set
		{
			currentImage = value;
			OnPropertyChanged();
		}
	}

	public bool ResetButtonEnabled
	{
		get => resetButtonEnabled;
		set
		{
			resetButtonEnabled = value;
			OnPropertyChanged();
		}
	}

	// Game logic
	private void RandomWordPicker()
	{

	}
}