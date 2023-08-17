namespace CardPlay
{
  public partial class Form1 : Form
  {
    // 46; 94; 25
    public Form1()
    {
      InitializeComponent();
      LoadSongs();
    }

    void LoadSongs()
    {
      string[] musicFiles = Directory.GetFiles("Music Tracks", "*.mp3");
      string[] musicImages = Directory.GetFiles("Music Images", "*.png");
      string buffer = "";
      for (int i = 0; i < musicFiles.Length; i++)
      {
        musicItem item = new musicItem();
        FileInfo file = new FileInfo(musicFiles[i]);
        Image image;

        buffer = "Music Images\\" + TakeFromFileName(file.Name, 1) +
          "#" + TakeFromFileName(file.Name, 2) + ".png";

        if (IsValueInArray(buffer, musicImages))
        {
          image = Image.FromFile(buffer);
        }
        else
        {
          image = Image.FromFile(musicImages[0]);
        }

        item.song = TakeFromFileName(file.Name, 0);
        item.artist = TakeFromFileName(file.Name, 2);
        item.image = image;

        musicItemArea.Controls.Add(item);
      }
    }

    #region Help with Files
    string TakeFromFileName(string fileName, int index)
    {
      int elementIndex = 0;
      string result = "";
      for (int i = 0; i < fileName.Length; i++)
      {
        if (fileName[i] == '.')
        {
          break;
        }
        else if (fileName[i] == '#')
        {
          elementIndex++;
        }
        else if (elementIndex > index)
        {
          break;
        }
        else if (elementIndex == index)
        {
          result += fileName[i];
        }
      }
      return result;
    }

    bool IsValueInArray(string value, string[] array)
    {
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] == value)
        {
          return true;
        }
      }
      return false;
    }
    #endregion


  }
}