namespace Rosemary
{
  partial class ProgressBar
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
      musicBarArea = new TableLayoutPanel();
      progressBarArea = new TableLayoutPanel();
      leftLine = new Label();
      rightLine = new Label();
      musicBarArea.SuspendLayout();
      progressBarArea.SuspendLayout();
      SuspendLayout();
      // 
      // musicBarArea
      // 
      musicBarArea.BackColor = Color.Transparent;
      musicBarArea.ColumnCount = 1;
      musicBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      musicBarArea.Controls.Add(progressBarArea, 0, 1);
      musicBarArea.Dock = DockStyle.Fill;
      musicBarArea.Location = new Point(0, 0);
      musicBarArea.Name = "musicBarArea";
      musicBarArea.RowCount = 3;
      musicBarArea.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      musicBarArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 4F));
      musicBarArea.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      musicBarArea.Size = new Size(657, 24);
      musicBarArea.TabIndex = 0;
      // 
      // progressBarArea
      // 
      progressBarArea.ColumnCount = 2;
      progressBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.369863F));
      progressBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.6301346F));
      progressBarArea.Controls.Add(leftLine, 0, 0);
      progressBarArea.Controls.Add(rightLine, 1, 0);
      progressBarArea.Dock = DockStyle.Fill;
      progressBarArea.Location = new Point(0, 10);
      progressBarArea.Margin = new Padding(0);
      progressBarArea.Name = "progressBarArea";
      progressBarArea.RowCount = 1;
      progressBarArea.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      progressBarArea.Size = new Size(657, 4);
      progressBarArea.TabIndex = 0;
      // 
      // leftLine
      // 
      leftLine.AutoSize = true;
      leftLine.BackColor = Color.WhiteSmoke;
      leftLine.Dock = DockStyle.Fill;
      leftLine.Location = new Point(0, 0);
      leftLine.Margin = new Padding(0);
      leftLine.Name = "leftLine";
      leftLine.Size = new Size(9, 4);
      leftLine.TabIndex = 0;
      // 
      // rightLine
      // 
      rightLine.AutoSize = true;
      rightLine.BackColor = Color.FromArgb(80, 80, 80);
      rightLine.Dock = DockStyle.Fill;
      rightLine.Location = new Point(9, 0);
      rightLine.Margin = new Padding(0);
      rightLine.Name = "rightLine";
      rightLine.Size = new Size(648, 4);
      rightLine.TabIndex = 1;
      // 
      // ProgressBar
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.FromArgb(20, 20, 20);
      Controls.Add(musicBarArea);
      Margin = new Padding(0);
      Name = "ProgressBar";
      Size = new Size(657, 24);
      musicBarArea.ResumeLayout(false);
      progressBarArea.ResumeLayout(false);
      progressBarArea.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel music;
    private TableLayoutPanel progressBarArea;
    private TableLayoutPanel musicBarArea;
    private Label leftLine;
    private Label rightLine;
  }
}
