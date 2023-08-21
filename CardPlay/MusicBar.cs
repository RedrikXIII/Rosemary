using CardPlay;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosemary
{
  public partial class MusicBar : UserControl
  {
    WaveOut? wave;
    AudioFileReader? track;
    bool isPlaying = false;
    bool isFirst;
    MusicItem? curItem;

    #region Events
    EventHandler? nextTrack;
    public event EventHandler NextTrack
    {
      add
      {
        nextTrack += value;
      }
      remove
      {
        nextTrack -= value;
      }
    }

    EventHandler? previousTrack;
    public event EventHandler PreviousTrack
    {
      add
      {
        previousTrack += value;
      }
      remove
      {
        previousTrack -= value;
      }
    }
    #endregion
    #region Public Variables
    public bool isFirstTrack
    {
      get
      {
        return isFirst;
      }
      set
      {
        isFirst = value;
      }
    }

    public bool isNextButtonVisible
    {
      get
      {
        return nextTrackButton.Visible;
      }
      set
      {
        nextTrackButton.Visible = value;
      }
    }
    #endregion

    public MusicBar()
    {
      InitializeComponent();
      MouseUpDownRecursive(progressBarArea);
      trackImage.Image = null;
      trackTitle.Text = "";
      trackArtist.Text = "";
      currentTime.Cursor = Cursors.Arrow;
      totalTime.Cursor = Cursors.Arrow;
      previousTrackButton.MouseUp += previousTrackButton_MouseUp;
      nextTrackButton.MouseUp += nextTrackButton_MouseUp;
    }

    #region Next/Previous Buttons Handling
    private void nextTrackButton_MouseUp(object? sender, MouseEventArgs e)
    {
      if (wave != null)
      {
        nextTrack?.Invoke(curItem, EventArgs.Empty);
      }
    }

    private void previousTrackButton_MouseUp(object? sender, MouseEventArgs e)
    {
      if (wave != null)
      {
        if (track?.CurrentTime.TotalSeconds > 5)
        {
          PlayTrack(curItem!);
        }
        else
        {
          previousTrack?.Invoke(curItem, EventArgs.Empty);
        }
      }
    }
    #endregion

    private void playPauseButton_Click(object sender, EventArgs e)
    {
      isPlaying = !isPlaying;
      if (isPlaying)
      {
        if (wave != null)
        {
          wave.Play();
          playPauseButton.Text = "❚❚";
        }
      }
      else
      {
        if (wave != null)
        {
          wave.Pause();
          playPauseButton.Text = "▶";
        }
      }
    }

    public void PlayTrack(MusicItem item)
    {
      curItem = item;
      if (wave != null)
      {
        wave.Dispose();
        track?.Dispose();
      }
      wave = new WaveOut();
      track = new AudioFileReader(item.file);
      TimeSpan tot = track.TotalTime;
      totalTime.Text = $"{tot:mm}:{tot:ss}";
      playTimer.Start();
      wave.Init(track);
      isPlaying = true;
      playPauseButton.Text = "❚❚";
      trackTitle.Text = item.song;
      trackArtist.Text = item.artist;
      trackImage.Image = item.image;

      wave.Play();
    }

    #region Progress Bar Scrolling
    private void progressBarArea_MouseClick(object sender, MouseEventArgs e)
    {
      Point cursorPos = progressBarArea.PointToClient(Cursor.Position);
      if (cursorPos.X > 45 && cursorPos.X < totalTime.Location.X && wave != null)
      {
        wave!.Pause();
        float curPosX = cursorPos.X - 45;
        float totalLength = progressBarArea.Width - 90;
        double percent = curPosX / totalLength * 100;
        progressBarArea.ColumnStyles[1].Width = (float)percent;
        progressBarArea.ColumnStyles[2].Width = (float)(100 - percent);
        double curSec = percent / 100 * track!.TotalTime.TotalSeconds;
        track!.CurrentTime = new TimeSpan(0, (int)(curSec / 60 % 60), (int)(curSec % 60));
      }
    }

    private void progressBarArea_MouseUp(object sender, MouseEventArgs e)
    {
      if (wave != null)
      {
        if (isPlaying)
        {
          wave!.Play();
        }
      }
    }

    void MouseUpDownRecursive(Control element)
    {
      element.MouseDown += progressBarArea_MouseClick!;
      element.MouseUp += progressBarArea_MouseUp!;
      for (int i = 0; i < element.Controls.Count; i++)
      {
        MouseUpDownRecursive(element.Controls[i]);
      }
    }
    #endregion

    private void playTimer_Tick(object sender, EventArgs e)
    {
      TimeSpan cur = track!.CurrentTime;
      currentTime.Text = $"{cur:mm}:{cur:ss}";
      float percent = (float)(cur / track.TotalTime * 100);
      progressBarArea.ColumnStyles[1].Width = (int)(percent);
      progressBarArea.ColumnStyles[2]!.Width = (int)(100 - percent);
      if (isPlaying && wave != null && (int)track!.CurrentTime.TotalSeconds == (int)track.TotalTime.TotalSeconds)
      {
        if (isNextButtonVisible)
        {
          nextTrack?.Invoke(curItem, EventArgs.Empty);
        }
        else
        {
          wave.Pause();
          playPauseButton.Text = "▶";
          isPlaying = false;
          track!.CurrentTime = TimeSpan.Zero;
        }
      }
      if (track!.CurrentTime.TotalSeconds > 5 || !isFirst)
      {
        previousTrackButton.Visible = true;
      }
      else
      {
        previousTrackButton.Visible = false;
      }
    }
  }
}
