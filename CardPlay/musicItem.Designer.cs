namespace CardPlay
{
  partial class musicItem
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musicItem));
      trackArea = new TableLayoutPanel();
      trackSong = new Label();
      trackArtist = new Label();
      tableLayoutPanel1 = new TableLayoutPanel();
      trackImage = new PictureBox();
      trackArea.SuspendLayout();
      tableLayoutPanel1.SuspendLayout();
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
      trackArea.Controls.Add(tableLayoutPanel1, 0, 0);
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
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.BackColor = Color.FromArgb(74, 94, 63);
      tableLayoutPanel1.ColumnCount = 1;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.Controls.Add(trackImage, 0, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new Point(13, 13);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.Padding = new Padding(2);
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.Size = new Size(154, 154);
      tableLayoutPanel1.TabIndex = 5;
      // 
      // trackImage
      // 
      trackImage.BackColor = Color.FromArgb(50, 50, 50);
      trackImage.Dock = DockStyle.Fill;
      trackImage.Image = (Image)resources.GetObject("trackImage.Image");
      trackImage.Location = new Point(2, 2);
      trackImage.Margin = new Padding(0);
      trackImage.Name = "trackImage";
      trackImage.Size = new Size(150, 150);
      trackImage.SizeMode = PictureBoxSizeMode.StretchImage;
      trackImage.TabIndex = 4;
      trackImage.TabStop = false;
      // 
      // musicItem
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.FromArgb(50, 50, 50);
      Controls.Add(trackArea);
      Margin = new Padding(10);
      Name = "musicItem";
      Size = new Size(180, 250);
      Load += musicItem_Load;
      trackArea.ResumeLayout(false);
      trackArea.PerformLayout();
      tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)trackImage).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel trackArea;
    private Label trackSong;
    private Label trackArtist;
    private TableLayoutPanel tableLayoutPanel1;
    private PictureBox trackImage;
  }
}
