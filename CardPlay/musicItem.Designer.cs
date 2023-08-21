namespace CardPlay
{
  partial class MusicItem
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicItem));
      trackArea = new TableLayoutPanel();
      trackSong = new Label();
      trackArtist = new Label();
      imageOutter = new TableLayoutPanel();
      trackImage = new PictureBox();
      trackArea.SuspendLayout();
      imageOutter.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)trackImage).BeginInit();
      SuspendLayout();
      // 
      // trackArea
      // 
      trackArea.BackColor = Color.FromArgb(50, 50, 50);
      trackArea.ColumnCount = 1;
      trackArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      trackArea.Controls.Add(trackSong, 0, 1);
      trackArea.Controls.Add(trackArtist, 0, 2);
      trackArea.Controls.Add(imageOutter, 0, 0);
      trackArea.Location = new Point(0, 0);
      trackArea.Margin = new Padding(0);
      trackArea.Name = "trackArea";
      trackArea.Padding = new Padding(10);
      trackArea.RowCount = 3;
      trackArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      trackArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
      trackArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
      trackArea.Size = new Size(180, 250);
      trackArea.TabIndex = 0;
      // 
      // trackSong
      // 
      trackSong.AutoSize = true;
      trackSong.BackColor = Color.Transparent;
      trackSong.Dock = DockStyle.Fill;
      trackSong.Font = new Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
      trackSong.ForeColor = Color.FromArgb(230, 230, 230);
      trackSong.Location = new Point(10, 170);
      trackSong.Margin = new Padding(0);
      trackSong.Name = "trackSong";
      trackSong.Size = new Size(160, 50);
      trackSong.TabIndex = 1;
      trackSong.Text = "You Give Me Something";
      trackSong.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // trackArtist
      // 
      trackArtist.AutoSize = true;
      trackArtist.Dock = DockStyle.Fill;
      trackArtist.Font = new Font("Candara", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
      trackArtist.ForeColor = SystemColors.ScrollBar;
      trackArtist.Location = new Point(13, 220);
      trackArtist.Name = "trackArtist";
      trackArtist.Size = new Size(154, 20);
      trackArtist.TabIndex = 4;
      trackArtist.Text = "Jamiroquai";
      trackArtist.TextAlign = ContentAlignment.BottomCenter;
      // 
      // imageOutter
      // 
      imageOutter.BackColor = Color.FromArgb(74, 94, 63);
      imageOutter.ColumnCount = 1;
      imageOutter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      imageOutter.Controls.Add(trackImage, 0, 0);
      imageOutter.Dock = DockStyle.Fill;
      imageOutter.Location = new Point(13, 13);
      imageOutter.Name = "imageOutter";
      imageOutter.Padding = new Padding(3);
      imageOutter.RowCount = 1;
      imageOutter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      imageOutter.Size = new Size(154, 154);
      imageOutter.TabIndex = 5;
      // 
      // trackImage
      // 
      trackImage.BackColor = Color.FromArgb(50, 50, 50);
      trackImage.Dock = DockStyle.Fill;
      trackImage.Image = (Image)resources.GetObject("trackImage.Image");
      trackImage.Location = new Point(3, 3);
      trackImage.Margin = new Padding(0);
      trackImage.Name = "trackImage";
      trackImage.Padding = new Padding(4);
      trackImage.Size = new Size(148, 148);
      trackImage.SizeMode = PictureBoxSizeMode.StretchImage;
      trackImage.TabIndex = 4;
      trackImage.TabStop = false;
      // 
      // MusicItem
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.FromArgb(50, 50, 50);
      Controls.Add(trackArea);
      Cursor = Cursors.Hand;
      Margin = new Padding(10);
      Name = "MusicItem";
      Size = new Size(180, 250);
      Load += musicItem_Load;
      trackArea.ResumeLayout(false);
      trackArea.PerformLayout();
      imageOutter.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)trackImage).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel trackArea;
    private Label trackSong;
    private Label trackArtist;
    private TableLayoutPanel imageOutter;
    private PictureBox trackImage;
  }
}
