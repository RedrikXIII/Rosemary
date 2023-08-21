namespace CardPlay
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      musicItemArea = new FlowLayoutPanel();
      musicItemAreaOutter = new TableLayoutPanel();
      musicBar = new Rosemary.MusicBar();
      musicPlaylistArea = new FlowLayoutPanel();
      playlistHolder = new TableLayoutPanel();
      label1 = new Label();
      musicItemAreaOutter.SuspendLayout();
      playlistHolder.SuspendLayout();
      SuspendLayout();
      // 
      // musicItemArea
      // 
      musicItemArea.AutoScroll = true;
      musicItemArea.BackColor = Color.FromArgb(30, 30, 30);
      musicItemArea.Dock = DockStyle.Fill;
      musicItemArea.Location = new Point(5, 5);
      musicItemArea.Margin = new Padding(0);
      musicItemArea.Name = "musicItemArea";
      musicItemArea.Size = new Size(623, 361);
      musicItemArea.TabIndex = 0;
      // 
      // musicItemAreaOutter
      // 
      musicItemAreaOutter.BackColor = Color.FromArgb(53, 63, 47);
      musicItemAreaOutter.ColumnCount = 1;
      musicItemAreaOutter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      musicItemAreaOutter.Controls.Add(musicItemArea, 0, 0);
      musicItemAreaOutter.Dock = DockStyle.Right;
      musicItemAreaOutter.Location = new Point(232, 0);
      musicItemAreaOutter.Margin = new Padding(0);
      musicItemAreaOutter.Name = "musicItemAreaOutter";
      musicItemAreaOutter.Padding = new Padding(5, 5, 5, 0);
      musicItemAreaOutter.RowCount = 1;
      musicItemAreaOutter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      musicItemAreaOutter.Size = new Size(633, 366);
      musicItemAreaOutter.TabIndex = 1;
      // 
      // musicBar
      // 
      musicBar.BackColor = Color.FromArgb(20, 20, 20);
      musicBar.Dock = DockStyle.Bottom;
      musicBar.isFirstTrack = false;
      musicBar.isNextButtonVisible = true;
      musicBar.Location = new Point(0, 366);
      musicBar.Margin = new Padding(0);
      musicBar.Name = "musicBar";
      musicBar.Size = new Size(865, 70);
      musicBar.TabIndex = 2;
      // 
      // musicPlaylistArea
      // 
      musicPlaylistArea.AutoScroll = true;
      musicPlaylistArea.BackColor = Color.FromArgb(25, 25, 25);
      musicPlaylistArea.Dock = DockStyle.Fill;
      musicPlaylistArea.Location = new Point(0, 48);
      musicPlaylistArea.Margin = new Padding(0);
      musicPlaylistArea.Name = "musicPlaylistArea";
      musicPlaylistArea.Size = new Size(234, 318);
      musicPlaylistArea.TabIndex = 3;
      // 
      // playlistHolder
      // 
      playlistHolder.BackColor = Color.FromArgb(43, 53, 37);
      playlistHolder.ColumnCount = 1;
      playlistHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      playlistHolder.Controls.Add(musicPlaylistArea, 0, 1);
      playlistHolder.Controls.Add(label1, 0, 0);
      playlistHolder.Dock = DockStyle.Left;
      playlistHolder.Location = new Point(0, 0);
      playlistHolder.Name = "playlistHolder";
      playlistHolder.RowCount = 2;
      playlistHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
      playlistHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      playlistHolder.Size = new Size(234, 366);
      playlistHolder.TabIndex = 4;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.BackColor = Color.FromArgb(30, 30, 30);
      label1.Dock = DockStyle.Fill;
      label1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
      label1.ForeColor = Color.FromArgb(230, 230, 230);
      label1.Location = new Point(4, 4);
      label1.Margin = new Padding(4);
      label1.Name = "label1";
      label1.Size = new Size(226, 40);
      label1.TabIndex = 4;
      label1.Text = "Медиатека";
      label1.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(865, 436);
      Controls.Add(playlistHolder);
      Controls.Add(musicItemAreaOutter);
      Controls.Add(musicBar);
      MinimumSize = new Size(750, 380);
      Name = "Form1";
      Text = "Rosemary";
      musicItemAreaOutter.ResumeLayout(false);
      playlistHolder.ResumeLayout(false);
      playlistHolder.PerformLayout();
      ResumeLayout(false);
    }

    #endregion
    private TableLayoutPanel musicItemAreaOutter;
    private Rosemary.MusicBar musicBar;
    private FlowLayoutPanel musicItemArea;
    private FlowLayoutPanel musicPlaylistArea;
    private TableLayoutPanel playlistHolder;
    private Label label1;
  }
}