namespace Rosemary
{
  partial class MusicPlaylist
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlaylist));
      playlistArea = new TableLayoutPanel();
      title = new Label();
      image = new PictureBox();
      playlistArea.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)image).BeginInit();
      SuspendLayout();
      // 
      // playlistArea
      // 
      playlistArea.BackColor = Color.Transparent;
      playlistArea.ColumnCount = 2;
      playlistArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
      playlistArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      playlistArea.Controls.Add(title, 0, 0);
      playlistArea.Controls.Add(image, 0, 0);
      playlistArea.Dock = DockStyle.Fill;
      playlistArea.Location = new Point(5, 5);
      playlistArea.Margin = new Padding(0);
      playlistArea.Name = "playlistArea";
      playlistArea.RowCount = 1;
      playlistArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      playlistArea.Size = new Size(180, 100);
      playlistArea.TabIndex = 0;
      // 
      // title
      // 
      title.AutoSize = true;
      title.BackColor = Color.Transparent;
      title.Dock = DockStyle.Fill;
      title.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
      title.ForeColor = Color.FromArgb(230, 230, 230);
      title.Location = new Point(75, 5);
      title.Margin = new Padding(5);
      title.Name = "title";
      title.Size = new Size(100, 90);
      title.TabIndex = 2;
      title.Text = "То, что Вам нравится";
      title.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // image
      // 
      image.BackColor = Color.Transparent;
      image.Dock = DockStyle.Fill;
      image.Image = (Image)resources.GetObject("image.Image");
      image.Location = new Point(0, 0);
      image.Margin = new Padding(0);
      image.Name = "image";
      image.Padding = new Padding(5, 20, 5, 20);
      image.Size = new Size(70, 100);
      image.SizeMode = PictureBoxSizeMode.StretchImage;
      image.TabIndex = 0;
      image.TabStop = false;
      // 
      // MusicPlaylist
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.FromArgb(30, 30, 30);
      Controls.Add(playlistArea);
      Cursor = Cursors.Hand;
      Margin = new Padding(5);
      Name = "MusicPlaylist";
      Padding = new Padding(5);
      Size = new Size(190, 110);
      playlistArea.ResumeLayout(false);
      playlistArea.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)image).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel playlistArea;
    private PictureBox image;
    private Label title;
  }
}
