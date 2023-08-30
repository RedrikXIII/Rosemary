using CardPlay;
using NAudio.Wave;
using Rosemary.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rosemary
{
  public partial class MusicBar : UserControl
  {
    WaveOut? wave;
    AudioFileReader? track;
    bool isPlaying = false;
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

    EventHandler? startOver;
    public event EventHandler StartOver
    {
      add
      {
        startOver += value;
      }
      remove
      {
        startOver -= value;
      }
    }
    #endregion
    #region Public Variables
    public bool isFirst { get; set; }

    public bool isLast { get; set; }
    #endregion

    public MusicBar()
    {
      InitializeComponent();
      trackImage.Image = null;
      trackTitle.Text = "";
      trackArtist.Text = "";
      currentTime.Cursor = Cursors.Arrow;
      totalTime.Cursor = Cursors.Arrow;
      previousTrackButton.MousePress += previousTrackButton_MouseUp;
      nextTrackButton.MousePress += nextTrackButton_MousePress;
      progressBar.MouseUp += progressBar_MouseUp!;
      progressBar.MouseDown += progressBar_MouseDown!;
      progressBar.ValueChanged += progressBar_ValueChanged;
      playPauseButton.MousePress += playPauseButton_Click!;
      volumeBar.ValueChanged += VolumeBar_ValueChanged;
      volumeBar.progressValue = 100;
      volumeBar.MouseWheel += VolumeBar_MouseWheel;
    }

    private void VolumeBar_MouseWheel(object? sender, MouseEventArgs e)
    {
      if (e.Delta > 0)
      {
        volumeBar.progressValue = Math.Min(volumeBar.progressValue * 100 + 2, 100);
      }
      else
      {
        volumeBar.progressValue = Math.Max(volumeBar.progressValue * 100 - 2, 0);
      }
      VolumeBar_ValueChanged(volumeBar.progressValue, EventArgs.Empty);
    }

    private void VolumeBar_ValueChanged(object? sender, EventArgs e)
    {
      if (wave != null)
      {
        double newValue = (double)sender!;
        volumeBar.progressValue = newValue * 100;
        if (volumeBar.progressValue <= 0.05)
        {
          track!.Volume = 0f;
        }
        else
        {
          track!.Volume = (float)volumeBar.progressValue;
        }

        if (track!.Volume == 0)
        {
          volumeImage.Image = Resources.volumeMutePrcsd;
        }
        else if (track!.Volume < 0.33)
        {
          volumeImage.Image = Resources.volumeLowPrcsd;
        }
        else if (track!.Volume < 0.66)
        {
          volumeImage.Image = Resources.volumeMediumPrcsd;
        }
        else
        {
          volumeImage.Image = Resources.volumeHighPrcsd;
        }
      }
    }

    #region Next/Previous Buttons Handling
    private void nextTrackButton_MousePress(object? sender, EventArgs e)
    {
      if (wave != null)
      {
        bool wasLast = isLast;
        nextTrack?.Invoke(curItem, EventArgs.Empty);
        if (wasLast)
        {
          wave.Pause();
          playPauseButton.buttonImage = Resources.playIconPrcsd;
          isPlaying = false;
        }
      }
    }

    private void previousTrackButton_MouseUp(object? sender, EventArgs e)
    {
      if (wave != null)
      {
        if (track?.CurrentTime.TotalSeconds > 5 || isFirst)
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
          playPauseButton.buttonImage = Resources.pauseIconPrcsd;
        }
      }
      else
      {
        if (wave != null)
        {
          wave.Pause();
          playPauseButton.buttonImage = Resources.playIconPrcsd;
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
      playPauseButton.buttonImage = Resources.pauseIconPrcsd;
      trackTitle.Text = item.song;
      trackArtist.Text = item.artist;
      trackImage.Image = item.image;

      wave.Play();
    }

    #region Progress Bar Scrolling
    private void progressBar_ValueChanged(object? sender, EventArgs e)
    {
      if (wave != null)
      {
        double newValue = (double)sender!;
        progressBar.progressValue = newValue * 100;
        double curSec = newValue * track!.TotalTime.TotalSeconds;
        track!.CurrentTime = new TimeSpan(0, (int)(curSec / 60 % 60), (int)(curSec % 60));
      }
    }
    private void progressBar_MouseDown(object sender, MouseEventArgs e)
    {
      wave!.Pause();
    }

    private void progressBar_MouseUp(object sender, MouseEventArgs e)
    {
      if (wave != null)
      {
        if (isPlaying)
        {
          wave!.Play();
        }
      }
    }
    #endregion

    private void playTimer_Tick(object sender, EventArgs e)
    {
      TimeSpan cur = track!.CurrentTime;
      currentTime.Text = $"{cur:mm}:{cur:ss}";
      float percent = (float)(cur / track.TotalTime * 100);
      progressBar.progressValue = percent;
      if (isPlaying && wave != null && (int)track!.CurrentTime.TotalSeconds == (int)track.TotalTime.TotalSeconds)
      {
        if (!isLast)
        {
          nextTrack?.Invoke(curItem, EventArgs.Empty);
        }
        else
        {
          startOver?.Invoke(curItem, EventArgs.Empty);
          wave.Pause();
          playPauseButton.buttonImage = Resources.playIconPrcsd;
          isPlaying = false;
        }
      }
    }
  }
}
