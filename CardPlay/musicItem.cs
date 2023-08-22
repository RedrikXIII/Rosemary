using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace CardPlay
{
  public partial class MusicItem : UserControl
  {
    bool isNameCut = false;
    string fullName = "";
    string? fileName;

    #region Public Variables
    public string song
    {
      get
      {
        return trackSong.Text;
      }
      set
      {
        trackSong.Text = value;
      }
    }

    public string artist
    {
      get
      {
        return trackArtist.Text;
      }
      set
      {
        trackArtist.Text = value;
      }
    }

    public Image image
    {
      get
      {
        return trackImage.Image;
      }
      set
      {
        trackImage.Image = value;
      }
    }

    public string file
    {
      get
      {
        if (fileName == null)
        {
          return "null";
        }
        return fileName;
      }
      set
      {
        fileName = value;
      }
    }
    #endregion
    #region Events
    EventHandler? playMusic;
    public event EventHandler? PlayMusic
    {
      add
      {
        playMusic += value;
      }
      remove
      {
        playMusic -= value;
      }
    }
    #endregion

    public MusicItem()
    {
      InitializeComponent();
      HoverRecursive(trackArea);
      ClickRecursive(trackArea);
      DoubleClickRecursive(trackArea);
    }


    #region Hover Handling 
    private void TrackArea_MouseEnter(object? sender, EventArgs e)
    {
      trackArea.BackColor = trackImage.BackColor = Color.FromArgb(70, 70, 70);

      if (isNameCut)
      {
        song = fullName;
      }
    }

    private void TrackArea_MouseLeave(object? sender, EventArgs e)
    {
      trackArea.BackColor = trackImage.BackColor = Color.FromArgb(50, 50, 50);
      if (isNameCut)
      {
        song = song.Substring(0, 17) + "...";
      }
    }

    void HoverRecursive(Control element)
    {
      element.MouseEnter += TrackArea_MouseEnter;
      element.MouseLeave += TrackArea_MouseLeave;
      for (int i = 0; i < element.Controls.Count; i++)
      {
        HoverRecursive(element.Controls[i]);
      }
    }

    #endregion
    #region Click Handling
    private void TrackArea_MouseDown(object? sender, MouseEventArgs e)
    {
      trackArea.BackColor = trackImage.BackColor = Color.FromArgb(80, 80, 80);
    }

    private void TrackArea_MouseUp(object? sender, MouseEventArgs e)
    {
      trackArea.BackColor = trackImage.BackColor = Color.FromArgb(70, 70, 70);
    }

    void ClickRecursive(Control element)
    {
      element.MouseDown += TrackArea_MouseDown;
      element.MouseUp += TrackArea_MouseUp;
      for (int i = 0; i < element.Controls.Count; i++)
      {
        ClickRecursive(element.Controls[i]);
      }
    }
    #endregion
    #region Double Click Handling
    private void TrackArea_MouseDoubleClick(object? sender, MouseEventArgs e)
    {
      playMusic?.Invoke(this, EventArgs.Empty);
    }

    void DoubleClickRecursive(Control element)
    {
      element.MouseDoubleClick += TrackArea_MouseDoubleClick;
      for (int i = 0; i < element.Controls.Count; i++)
      {
        DoubleClickRecursive(element.Controls[i]);
      }
    }
    #endregion

    private void musicItem_Load(object sender, EventArgs e)
    {
      if (song.Length > 20)
      {
        fullName = song;
        song = song.Substring(0, 17) + "...";
        isNameCut = true;
      }
    }
  }
}
