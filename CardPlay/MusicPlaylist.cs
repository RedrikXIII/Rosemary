﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Rosemary
{
  public partial class MusicPlaylist : UserControl
  {
    int index;

    #region Public Variables
    public int playlistIndex
    {
      get
      {
        return index;
      }
      set
      {
        index = value;
      }
    }
    public string playlistName
    {
      get
      {
        return title.Text;
      }
      set
      {
        title.Text = value;
      }
    }

    public System.Drawing.Image playlistImage
    {
      get
      {
        return image.Image;
      }
      set
      {
        if (value == null)
        {
          image.Image = System.Drawing.Image.FromFile("Music Images\\0.png");
        }
        else
        {
          image.Image = value;
        }
      }
    }
    #endregion
    #region Events
    EventHandler? playlistSelected;
    public event EventHandler PlaylistSelected
    {
      remove
      {
        playlistSelected += value;
      }
      add
      {
        playlistSelected += value;
      }
    }
    #endregion

    public MusicPlaylist()
    {
      InitializeComponent();
      ClickRecursive(playlistArea);
      HoverRecursive(playlistArea);
    }


    #region Hover Handling 
    private void PlaylistArea_MouseEnter(object? sender, EventArgs e)
    {
      if (BackColor != Color.FromArgb(70, 70, 70))
      {
        BackColor = Color.FromArgb(50, 50, 50);
      }
    }

    private void PlaylistArea_MouseLeave(object? sender, EventArgs e)
    {
      if (BackColor != Color.FromArgb(70, 70, 70))
      {
        BackColor = Color.FromArgb(30, 30, 30);
      }
    }

    void HoverRecursive(Control element)
    {
      element.MouseEnter += PlaylistArea_MouseEnter;
      element.MouseLeave += PlaylistArea_MouseLeave;
      for (int i = 0; i < element.Controls.Count; i++)
      {
        HoverRecursive(element.Controls[i]);
      }
    }
    #endregion
    #region Click Handling
    private void PlaylistArea_MouseDown(object? sender, EventArgs e)
    {
      playlistSelected?.Invoke(this, EventArgs.Empty);
      BackColor = Color.FromArgb(70, 70, 70);
    }

    public void PlaylistArea_Deselect()
    {
      BackColor = Color.FromArgb(30, 30, 30);
    }

    void ClickRecursive(Control element)
    {
      element.MouseDown += PlaylistArea_MouseDown;
      for (int i = 0; i < element.Controls.Count; i++)
      {
        ClickRecursive(element.Controls[i]);
      }
    }
    #endregion
  }
}
