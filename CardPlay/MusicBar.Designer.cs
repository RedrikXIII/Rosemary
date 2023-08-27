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
      totalTime = new Label();
      progressBar = new ProgressBar();
      barButtonsArea = new TableLayoutPanel();
      nextTrackButton = new ButtonElement();
      playPauseButton = new ButtonElement();
      previousTrackButton = new ButtonElement();
      trackInfoArea = new TableLayoutPanel();
      trackImage = new PictureBox();
      trackTextArea = new TableLayoutPanel();
      trackArtist = new Label();
      trackTitle = new Label();
      tableLayoutPanel1 = new TableLayoutPanel();
      volumeBar = new ProgressBar();
      volumeImage = new PictureBox();
      playTimer = new System.Windows.Forms.Timer(components);
      musicBarArea.SuspendLayout();
      barButtonsAndProgress.SuspendLayout();
      progressBarArea.SuspendLayout();
      barButtonsArea.SuspendLayout();
      trackInfoArea.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)trackImage).BeginInit();
      trackTextArea.SuspendLayout();
      tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)volumeImage).BeginInit();
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
      musicBarArea.Controls.Add(tableLayoutPanel1, 2, 0);
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
      barButtonsAndProgress.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
      barButtonsAndProgress.Size = new Size(400, 70);
      barButtonsAndProgress.TabIndex = 0;
      // 
      // progressBarArea
      // 
      progressBarArea.ColumnCount = 3;
      progressBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
      progressBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      progressBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
      progressBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
      progressBarArea.Controls.Add(currentTime, 0, 0);
      progressBarArea.Controls.Add(totalTime, 2, 0);
      progressBarArea.Controls.Add(progressBar, 1, 0);
      progressBarArea.Cursor = Cursors.Hand;
      progressBarArea.Dock = DockStyle.Fill;
      progressBarArea.Location = new Point(3, 51);
      progressBarArea.Name = "progressBarArea";
      progressBarArea.RowCount = 1;
      progressBarArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      progressBarArea.Size = new Size(394, 16);
      progressBarArea.TabIndex = 0;
      // 
      // currentTime
      // 
      currentTime.AutoSize = true;
      currentTime.Dock = DockStyle.Fill;
      currentTime.ForeColor = Color.FromArgb(190, 190, 190);
      currentTime.Location = new Point(0, 0);
      currentTime.Margin = new Padding(0);
      currentTime.Name = "currentTime";
      currentTime.Size = new Size(45, 16);
      currentTime.TabIndex = 3;
      currentTime.Text = "00:00";
      currentTime.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // totalTime
      // 
      totalTime.AutoSize = true;
      totalTime.Dock = DockStyle.Fill;
      totalTime.ForeColor = Color.FromArgb(190, 190, 190);
      totalTime.Location = new Point(349, 0);
      totalTime.Margin = new Padding(0);
      totalTime.Name = "totalTime";
      totalTime.Size = new Size(45, 16);
      totalTime.TabIndex = 2;
      totalTime.Text = "00:00";
      totalTime.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // progressBar
      // 
      progressBar.BackColor = Color.FromArgb(20, 20, 20);
      progressBar.Location = new Point(45, 0);
      progressBar.Margin = new Padding(0);
      progressBar.Name = "progressBar";
      progressBar.progressValue = 0.0032894736842105261D;
      progressBar.Size = new Size(304, 16);
      progressBar.TabIndex = 4;
      // 
      // barButtonsArea
      // 
      barButtonsArea.ColumnCount = 5;
      barButtonsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      barButtonsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
      barButtonsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
      barButtonsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
      barButtonsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      barButtonsArea.Controls.Add(nextTrackButton, 3, 0);
      barButtonsArea.Controls.Add(playPauseButton, 2, 0);
      barButtonsArea.Controls.Add(previousTrackButton, 1, 0);
      barButtonsArea.Dock = DockStyle.Fill;
      barButtonsArea.Location = new Point(0, 0);
      barButtonsArea.Margin = new Padding(0);
      barButtonsArea.Name = "barButtonsArea";
      barButtonsArea.RowCount = 1;
      barButtonsArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      barButtonsArea.Size = new Size(400, 48);
      barButtonsArea.TabIndex = 1;
      // 
      // nextTrackButton
      // 
      nextTrackButton.backColor = Color.FromArgb(20, 20, 20);
      nextTrackButton.BackColor = Color.FromArgb(20, 20, 20);
      nextTrackButton.buttonImage = Properties.Resources.forwardIconPrcsd;
      nextTrackButton.Cursor = Cursors.Hand;
      nextTrackButton.defaultColor = Color.FromArgb(20, 20, 20);
      nextTrackButton.Dock = DockStyle.Fill;
      nextTrackButton.Location = new Point(224, 0);
      nextTrackButton.Margin = new Padding(0);
      nextTrackButton.mouseDownColor = Color.FromArgb(101, 101, 101);
      nextTrackButton.mouseOverColor = Color.FromArgb(50, 50, 50);
      nextTrackButton.mouseOverPaddingChange = new Point(15, 13);
      nextTrackButton.Name = "nextTrackButton";
      nextTrackButton.Padding = new Padding(15);
      nextTrackButton.Size = new Size(48, 48);
      nextTrackButton.TabIndex = 0;
      // 
      // playPauseButton
      // 
      playPauseButton.backColor = Color.FromArgb(20, 20, 20);
      playPauseButton.BackColor = Color.FromArgb(20, 20, 20);
      playPauseButton.buttonImage = (Image)resources.GetObject("playPauseButton.buttonImage");
      playPauseButton.defaultColor = Color.FromArgb(20, 20, 20);
      playPauseButton.Dock = DockStyle.Fill;
      playPauseButton.Location = new Point(176, 0);
      playPauseButton.Margin = new Padding(0);
      playPauseButton.mouseDownColor = Color.FromArgb(101, 101, 101);
      playPauseButton.mouseOverColor = Color.FromArgb(50, 50, 50);
      playPauseButton.mouseOverPaddingChange = new Point(5, 0);
      playPauseButton.Name = "playPauseButton";
      playPauseButton.Padding = new Padding(5);
      playPauseButton.Size = new Size(48, 48);
      playPauseButton.TabIndex = 2;
      // 
      // previousTrackButton
      // 
      previousTrackButton.backColor = Color.FromArgb(20, 20, 20);
      previousTrackButton.BackColor = Color.FromArgb(20, 20, 20);
      previousTrackButton.buttonImage = Properties.Resources.backIconPrcsd;
      previousTrackButton.defaultColor = Color.FromArgb(20, 20, 20);
      previousTrackButton.Dock = DockStyle.Fill;
      previousTrackButton.Location = new Point(128, 0);
      previousTrackButton.Margin = new Padding(0);
      previousTrackButton.mouseDownColor = Color.FromArgb(101, 101, 101);
      previousTrackButton.mouseOverColor = Color.FromArgb(50, 50, 50);
      previousTrackButton.mouseOverPaddingChange = new Point(15, 13);
      previousTrackButton.Name = "previousTrackButton";
      previousTrackButton.Padding = new Padding(15);
      previousTrackButton.Size = new Size(48, 48);
      previousTrackButton.TabIndex = 3;
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
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 2;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Controls.Add(volumeBar, 1, 0);
      tableLayoutPanel1.Controls.Add(volumeImage, 0, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new Point(654, 15);
      tableLayoutPanel1.Margin = new Padding(40, 15, 40, 15);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Size = new Size(135, 40);
      tableLayoutPanel1.TabIndex = 2;
      // 
      // volumeBar
      // 
      volumeBar.BackColor = Color.FromArgb(20, 20, 20);
      volumeBar.Cursor = Cursors.Hand;
      volumeBar.Dock = DockStyle.Fill;
      volumeBar.Location = new Point(50, 0);
      volumeBar.Margin = new Padding(10, 0, 0, 0);
      volumeBar.Name = "volumeBar";
      volumeBar.progressValue = 0.011764705882352941D;
      volumeBar.Size = new Size(85, 40);
      volumeBar.TabIndex = 0;
      // 
      // volumeImage
      // 
      volumeImage.Dock = DockStyle.Fill;
      volumeImage.Image = Properties.Resources.volumeHighPrcsd;
      volumeImage.Location = new Point(3, 3);
      volumeImage.Name = "volumeImage";
      volumeImage.Size = new Size(34, 34);
      volumeImage.SizeMode = PictureBoxSizeMode.Zoom;
      volumeImage.TabIndex = 1;
      volumeImage.TabStop = false;
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
      tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)volumeImage).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel musicBarArea;
    private TableLayoutPanel barButtonsAndProgress;
    private TableLayoutPanel progressBarArea;
    private Label totalTime;
    private Label currentTime;
    private TableLayoutPanel barButtonsArea;
    private System.Windows.Forms.Timer playTimer;
    private TableLayoutPanel trackInfoArea;
    private PictureBox trackImage;
    private TableLayoutPanel trackTextArea;
    private Label trackArtist;
    private Label trackTitle;
    private ProgressBar progressBar;
    private TableLayoutPanel tableLayoutPanel1;
    private ButtonElement nextTrackButton;
    private ButtonElement playPauseButton;
    private ButtonElement previousTrackButton;
    private ProgressBar volumeBar;
    private PictureBox volumeImage;
  }
}
