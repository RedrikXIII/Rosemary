namespace Rosemary
{
  partial class MusicBar
  {
    /// <summary> 
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором компонентов

    /// <summary> 
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicBar));
      musicBarArea = new TableLayoutPanel();
      barButtonsAndProgress = new TableLayoutPanel();
      progressBarArea = new TableLayoutPanel();
      currentTime = new Label();
      rightBar = new Label();
      leftBar = new Label();
      totalTime = new Label();
      barButtonsArea = new TableLayoutPanel();
      playPauseButton = new Button();
      previousTrackButton = new Button();
      nextTrackButton = new Button();
      trackInfoArea = new TableLayoutPanel();
      trackImage = new PictureBox();
      trackTextArea = new TableLayoutPanel();
      trackArtist = new Label();
      trackTitle = new Label();
      playTimer = new System.Windows.Forms.Timer(components);
      musicBarArea.SuspendLayout();
      barButtonsAndProgress.SuspendLayout();
      progressBarArea.SuspendLayout();
      barButtonsArea.SuspendLayout();
      trackInfoArea.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)trackImage).BeginInit();
      trackTextArea.SuspendLayout();
      SuspendLayout();
      // 
      // musicBarArea
      // 
      musicBarArea.BackColor = Color.FromArgb(20, 20, 20);
      musicBarArea.ColumnCount = 3;
      musicBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      musicBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
      musicBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      musicBarArea.Controls.Add(barButtonsAndProgress, 1, 0);
      musicBarArea.Controls.Add(trackInfoArea, 0, 0);
      musicBarArea.Dock = DockStyle.Fill;
      musicBarArea.Location = new Point(0, 0);
      musicBarArea.Margin = new Padding(5);
      musicBarArea.Name = "musicBarArea";
      musicBarArea.RowCount = 1;
      musicBarArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      musicBarArea.Size = new Size(829, 70);
      musicBarArea.TabIndex = 0;
      // 
      // barButtonsAndProgress
      // 
      barButtonsAndProgress.ColumnCount = 1;
      barButtonsAndProgress.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      barButtonsAndProgress.Controls.Add(progressBarArea, 0, 1);
      barButtonsAndProgress.Controls.Add(barButtonsArea, 0, 0);
      barButtonsAndProgress.Dock = DockStyle.Fill;
      barButtonsAndProgress.Location = new Point(214, 0);
      barButtonsAndProgress.Margin = new Padding(0);
      barButtonsAndProgress.Name = "barButtonsAndProgress";
      barButtonsAndProgress.RowCount = 2;
      barButtonsAndProgress.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      barButtonsAndProgress.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
      barButtonsAndProgress.Size = new Size(400, 70);
      barButtonsAndProgress.TabIndex = 0;
      // 
      // progressBarArea
      // 
      progressBarArea.ColumnCount = 4;
      progressBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
      progressBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.640264F));
      progressBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 97.35973F));
      progressBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
      progressBarArea.Controls.Add(currentTime, 0, 0);
      progressBarArea.Controls.Add(rightBar, 1, 0);
      progressBarArea.Controls.Add(leftBar, 2, 0);
      progressBarArea.Controls.Add(totalTime, 3, 0);
      progressBarArea.Cursor = Cursors.Hand;
      progressBarArea.Dock = DockStyle.Fill;
      progressBarArea.Location = new Point(3, 43);
      progressBarArea.Name = "progressBarArea";
      progressBarArea.RowCount = 1;
      progressBarArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      progressBarArea.Size = new Size(394, 24);
      progressBarArea.TabIndex = 0;
      progressBarArea.MouseUp += progressBarArea_MouseUp;
      // 
      // currentTime
      // 
      currentTime.AutoSize = true;
      currentTime.Dock = DockStyle.Fill;
      currentTime.ForeColor = Color.FromArgb(190, 190, 190);
      currentTime.Location = new Point(0, 0);
      currentTime.Margin = new Padding(0);
      currentTime.Name = "currentTime";
      currentTime.Size = new Size(45, 24);
      currentTime.TabIndex = 3;
      currentTime.Text = "00:00";
      currentTime.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // rightBar
      // 
      rightBar.AutoSize = true;
      rightBar.BackColor = Color.WhiteSmoke;
      rightBar.Cursor = Cursors.Hand;
      rightBar.Dock = DockStyle.Fill;
      rightBar.Location = new Point(45, 10);
      rightBar.Margin = new Padding(0, 10, 0, 10);
      rightBar.Name = "rightBar";
      rightBar.Size = new Size(8, 4);
      rightBar.TabIndex = 0;
      // 
      // leftBar
      // 
      leftBar.AutoSize = true;
      leftBar.BackColor = Color.FromArgb(80, 80, 80);
      leftBar.Cursor = Cursors.Hand;
      leftBar.Dock = DockStyle.Fill;
      leftBar.Location = new Point(53, 10);
      leftBar.Margin = new Padding(0, 10, 0, 10);
      leftBar.Name = "leftBar";
      leftBar.Size = new Size(295, 4);
      leftBar.TabIndex = 1;
      // 
      // totalTime
      // 
      totalTime.AutoSize = true;
      totalTime.Dock = DockStyle.Fill;
      totalTime.ForeColor = Color.FromArgb(190, 190, 190);
      totalTime.Location = new Point(348, 0);
      totalTime.Margin = new Padding(0);
      totalTime.Name = "totalTime";
      totalTime.Size = new Size(46, 24);
      totalTime.TabIndex = 2;
      totalTime.Text = "00:00";
      totalTime.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // barButtonsArea
      // 
      barButtonsArea.ColumnCount = 5;
      barButtonsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      barButtonsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
      barButtonsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
      barButtonsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
      barButtonsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      barButtonsArea.Controls.Add(playPauseButton, 2, 0);
      barButtonsArea.Controls.Add(previousTrackButton, 1, 0);
      barButtonsArea.Controls.Add(nextTrackButton, 3, 0);
      barButtonsArea.Dock = DockStyle.Fill;
      barButtonsArea.Location = new Point(0, 0);
      barButtonsArea.Margin = new Padding(0);
      barButtonsArea.Name = "barButtonsArea";
      barButtonsArea.RowCount = 1;
      barButtonsArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      barButtonsArea.Size = new Size(400, 40);
      barButtonsArea.TabIndex = 1;
      // 
      // playPauseButton
      // 
      playPauseButton.BackColor = Color.WhiteSmoke;
      playPauseButton.Cursor = Cursors.Hand;
      playPauseButton.Dock = DockStyle.Fill;
      playPauseButton.FlatAppearance.BorderSize = 0;
      playPauseButton.FlatAppearance.MouseDownBackColor = Color.LightGray;
      playPauseButton.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
      playPauseButton.FlatStyle = FlatStyle.Flat;
      playPauseButton.Location = new Point(185, 5);
      playPauseButton.Margin = new Padding(5);
      playPauseButton.Name = "playPauseButton";
      playPauseButton.Size = new Size(30, 30);
      playPauseButton.TabIndex = 0;
      playPauseButton.Text = "▶";
      playPauseButton.UseVisualStyleBackColor = false;
      playPauseButton.Click += playPauseButton_Click;
      // 
      // previousTrackButton
      // 
      previousTrackButton.BackColor = Color.WhiteSmoke;
      previousTrackButton.Cursor = Cursors.Hand;
      previousTrackButton.Dock = DockStyle.Fill;
      previousTrackButton.FlatAppearance.BorderSize = 0;
      previousTrackButton.FlatAppearance.MouseDownBackColor = Color.LightGray;
      previousTrackButton.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
      previousTrackButton.FlatStyle = FlatStyle.Flat;
      previousTrackButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
      previousTrackButton.Location = new Point(145, 5);
      previousTrackButton.Margin = new Padding(5);
      previousTrackButton.Name = "previousTrackButton";
      previousTrackButton.Size = new Size(30, 30);
      previousTrackButton.TabIndex = 1;
      previousTrackButton.Text = "❚◀";
      previousTrackButton.UseVisualStyleBackColor = false;
      // 
      // nextTrackButton
      // 
      nextTrackButton.BackColor = Color.WhiteSmoke;
      nextTrackButton.Cursor = Cursors.Hand;
      nextTrackButton.Dock = DockStyle.Fill;
      nextTrackButton.FlatAppearance.BorderSize = 0;
      nextTrackButton.FlatAppearance.MouseDownBackColor = Color.LightGray;
      nextTrackButton.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
      nextTrackButton.FlatStyle = FlatStyle.Flat;
      nextTrackButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
      nextTrackButton.Location = new Point(225, 5);
      nextTrackButton.Margin = new Padding(5);
      nextTrackButton.Name = "nextTrackButton";
      nextTrackButton.Size = new Size(30, 30);
      nextTrackButton.TabIndex = 2;
      nextTrackButton.Text = "▶❚";
      nextTrackButton.UseVisualStyleBackColor = false;
      // 
      // trackInfoArea
      // 
      trackInfoArea.ColumnCount = 2;
      trackInfoArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
      trackInfoArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      trackInfoArea.Controls.Add(trackImage, 0, 0);
      trackInfoArea.Controls.Add(trackTextArea, 1, 0);
      trackInfoArea.Dock = DockStyle.Fill;
      trackInfoArea.Location = new Point(0, 0);
      trackInfoArea.Margin = new Padding(0);
      trackInfoArea.Name = "trackInfoArea";
      trackInfoArea.RowCount = 1;
      trackInfoArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      trackInfoArea.Size = new Size(214, 70);
      trackInfoArea.TabIndex = 1;
      // 
      // trackImage
      // 
      trackImage.Dock = DockStyle.Fill;
      trackImage.Image = (Image)resources.GetObject("trackImage.Image");
      trackImage.Location = new Point(0, 0);
      trackImage.Margin = new Padding(0);
      trackImage.Name = "trackImage";
      trackImage.Padding = new Padding(6);
      trackImage.Size = new Size(70, 70);
      trackImage.SizeMode = PictureBoxSizeMode.StretchImage;
      trackImage.TabIndex = 0;
      trackImage.TabStop = false;
      // 
      // trackTextArea
      // 
      trackTextArea.ColumnCount = 1;
      trackTextArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      trackTextArea.Controls.Add(trackArtist, 0, 1);
      trackTextArea.Controls.Add(trackTitle, 0, 0);
      trackTextArea.Dock = DockStyle.Fill;
      trackTextArea.Location = new Point(73, 3);
      trackTextArea.Name = "trackTextArea";
      trackTextArea.RowCount = 2;
      trackTextArea.RowStyles.Add(new RowStyle(SizeType.Percent, 64.0625F));
      trackTextArea.RowStyles.Add(new RowStyle(SizeType.Percent, 35.9375F));
      trackTextArea.Size = new Size(138, 64);
      trackTextArea.TabIndex = 1;
      // 
      // trackArtist
      // 
      trackArtist.AutoSize = true;
      trackArtist.Dock = DockStyle.Fill;
      trackArtist.Font = new Font("Candara", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
      trackArtist.ForeColor = SystemColors.ScrollBar;
      trackArtist.Location = new Point(3, 44);
      trackArtist.Margin = new Padding(3);
      trackArtist.Name = "trackArtist";
      trackArtist.Size = new Size(132, 17);
      trackArtist.TabIndex = 0;
      trackArtist.Text = "Jamiroquai";
      // 
      // trackTitle
      // 
      trackTitle.AutoSize = true;
      trackTitle.Dock = DockStyle.Fill;
      trackTitle.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
      trackTitle.ForeColor = Color.FromArgb(230, 230, 230);
      trackTitle.Location = new Point(3, 3);
      trackTitle.Margin = new Padding(3);
      trackTitle.Name = "trackTitle";
      trackTitle.Size = new Size(132, 35);
      trackTitle.TabIndex = 1;
      trackTitle.Text = "Too Young To Die";
      trackTitle.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // playTimer
      // 
      playTimer.Tick += playTimer_Tick;
      // 
      // MusicBar
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.FromArgb(20, 20, 20);
      Controls.Add(musicBarArea);
      Name = "MusicBar";
      Size = new Size(829, 70);
      musicBarArea.ResumeLayout(false);
      barButtonsAndProgress.ResumeLayout(false);
      progressBarArea.ResumeLayout(false);
      progressBarArea.PerformLayout();
      barButtonsArea.ResumeLayout(false);
      trackInfoArea.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)trackImage).EndInit();
      trackTextArea.ResumeLayout(false);
      trackTextArea.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel musicBarArea;
    private TableLayoutPanel barButtonsAndProgress;
    private TableLayoutPanel progressBarArea;
    private Label rightBar;
    private Label leftBar;
    private Label totalTime;
    private Label currentTime;
    private TableLayoutPanel barButtonsArea;
    private System.Windows.Forms.Timer playTimer;
    private Button playPauseButton;
    private TableLayoutPanel trackInfoArea;
    private PictureBox trackImage;
    private TableLayoutPanel trackTextArea;
    private Label trackArtist;
    private Label trackTitle;
    private Button previousTrackButton;
    private Button nextTrackButton;
  }
}
