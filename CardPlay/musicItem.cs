using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardPlay
{
  public partial class musicItem : UserControl
  {
    bool isNameCut = false;
    string fullName = "";
    public musicItem()
    {
      InitializeComponent();
      trackArea.MouseEnter += TrackArea_MouseEnter;
      trackArea.MouseLeave += TrackArea_MouseLeave;
      HoverRecursive(trackArea);
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

    private void musicItem_Load(object sender, EventArgs e)
    {
      if (song.Length > 19)
      {
        fullName = song;
        song = song.Substring(0, 17) + "...";
        isNameCut = true;
      }
    }

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
    #endregion
  }
}
