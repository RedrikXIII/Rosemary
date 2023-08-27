using NAudio.Wave;
using Rosemary;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CardPlay
{
  public partial class Form1 : Form
  {
    //WaveOut wave = new WaveOut();
    public Form1()
    {
      InitializeComponent();
      LoadPlaylists();
      musicBar.NextTrack += Bar_NextTrack;
      musicBar.PreviousTrack += Bar_PreviousTrack;
      musicBar.StartOver += MusicBar_StartOver;
    }

    private void MusicBar_StartOver(object? sender, EventArgs e)
    {
      MusicItem firstItem = (MusicItem)musicItemArea.Controls[0];
      Track_PlayMusic(firstItem, EventArgs.Empty);
    }

    void LoadSongs(MusicPlaylist playlist)
    {
      musicItemArea.Controls.Clear();
      string[] musicFiles = Directory.GetFiles("Music Playlists\\" + playlist.playlistName, "*.mp3");
      for (int i = 0; i < musicFiles.Length; i++)
      {
        string buffer = "";
        FileInfo fileInfo = new FileInfo(musicFiles[i]);
        MusicItem track = new MusicItem();
        string[] musicImages = Directory.GetFiles("Music Images", "*.png");
        buffer = "Music Images\\" + TakeFromFileName(fileInfo.Name, 1) +
          "#" + TakeFromFileName(fileInfo.Name, 2) + ".png";

        track.file = musicFiles[i];
        if (IsValueInArray(buffer, musicImages))
        {
          track.image = Image.FromFile(buffer);
        }
        else
        {
          continue;
        }
        track.song = TakeFromFileName(fileInfo.Name, 0);
        track.artist = TakeFromFileName(fileInfo.Name, 2);
        track.PlayMusic += Track_PlayMusic;
        musicItemArea.Controls.Add(track);
      }
    }

    void LoadPlaylists()
    {
      string[] musicPlaylists = Directory.GetDirectories("Music Playlists");
      for (int i = 0; i < musicPlaylists.Length; i++)
      {
        FileInfo fileInfo = new FileInfo(musicPlaylists[i]);
        MusicPlaylist playlist = new MusicPlaylist(fileInfo, i);
        playlist.PlaylistSelected += PlaylistArea_DeselectAll;
        playlist.PlaylistSelected += PlaylistArea_PlaylistSelected;
        musicPlaylistArea.Controls.Add(playlist);
      }
    }

    private void PlaylistArea_DeselectAll(object? sender, EventArgs e)
    {
      for (int i = 0; i < musicPlaylistArea.Controls.Count; i++)
      {
        MusicPlaylist playlist = (MusicPlaylist)musicPlaylistArea.Controls[i];
        playlist.PlaylistArea_Deselect();
      }
    }

    private void PlaylistArea_PlaylistSelected(object? sender, EventArgs e)
    {
      MusicPlaylist playlist = (MusicPlaylist)sender!;
      LoadSongs(playlist);
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

    private void Track_PlayMusic(object? sender, EventArgs e)
    {
      MusicItem item = (MusicItem)sender!;
      MusicItem lastItem = (MusicItem)musicItemArea.Controls[musicItemArea.Controls.Count - 1];
      MusicItem firstItem = (MusicItem)musicItemArea.Controls[0];
      musicBar.PlayTrack(item);
      if (item.file == firstItem.file)
      {
        musicBar.isFirst = true;
      }
      else
      {
        musicBar.isFirst = false;
      }
      if (item.file == lastItem.file)
      {
        musicBar.isLast = true;
      }
      else
      {
        musicBar.isLast = false;
      }
    }

    private void Bar_NextTrack(object? sender, EventArgs e)
    {
      MusicItem item = (MusicItem)sender!;
      for (int i = 0; i < musicItemArea.Controls.Count; i++)
      {
        MusicItem item2 = (MusicItem)musicItemArea.Controls[i];
        if (item.file == item2.file)
        {
          if (i != musicItemArea.Controls.Count - 1)
          {
            Track_PlayMusic(musicItemArea.Controls[i + 1], EventArgs.Empty);
            break;
          }
          else
          {
            Track_PlayMusic(musicItemArea.Controls[0], EventArgs.Empty);
          }
        }
      }
    }

    private void Bar_PreviousTrack(object? sender, EventArgs e)
    {
      MusicItem item = (MusicItem)sender!;
      for (int i = musicItemArea.Controls.Count - 1; i > 0; i--)
      {
        MusicItem item2 = (MusicItem)musicItemArea.Controls[i];
        if (item.file == item2.file)
        {
          Track_PlayMusic(musicItemArea.Controls[i - 1], EventArgs.Empty);
          break;
        }
      }
    }
  }
}