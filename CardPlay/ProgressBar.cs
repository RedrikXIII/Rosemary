namespace Rosemary
{
  public partial class ProgressBar : UserControl
  {
    EventHandler? valueChanged;
    public event EventHandler ValueChanged
    {
      add { valueChanged += value; }
      remove { valueChanged -= value; }
    }

    #region Public Variables
    public double progressValue
    {
      get
      {
        return (double)leftLine.Width / progressBarArea.Width;
      }
      set
      {
        progressBarArea.ColumnStyles[0].Width = (float)value;
        progressBarArea.ColumnStyles[1].Width = (float)Math.Max(100 - value, 0);
      }
    }
    #endregion

    public ProgressBar()
    {
      InitializeComponent();
      MouseDownRecursive(musicBarArea);
    }

    #region Progress Bar Scrolling
    private void progressBarArea_MouseClick(object sender, MouseEventArgs e)
    {
      Point cursorPos = progressBarArea.PointToClient(Cursor.Position);
      double percent = (double)cursorPos.X / progressBarArea.Width * 100;
      valueChanged?.Invoke(percent / 100, EventArgs.Empty);
    }

    void MouseDownRecursive(Control element)
    {
      element.MouseDown += progressBarArea_MouseClick!;
      for (int i = 0; i < element.Controls.Count; i++)
      {
        MouseDownRecursive(element.Controls[i]);
      }
    }
    #endregion
  }
}
