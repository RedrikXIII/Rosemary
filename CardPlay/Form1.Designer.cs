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
      musicItemAreaOutter.SuspendLayout();
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
      musicItemArea.Size = new Size(693, 400);
      musicItemArea.TabIndex = 0;
      // 
      // musicItemAreaOutter
      // 
      musicItemAreaOutter.BackColor = Color.FromArgb(53, 63, 47);
      musicItemAreaOutter.ColumnCount = 1;
      musicItemAreaOutter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      musicItemAreaOutter.Controls.Add(musicItemArea, 0, 0);
      musicItemAreaOutter.Location = new Point(119, 45);
      musicItemAreaOutter.Margin = new Padding(0);
      musicItemAreaOutter.Name = "musicItemAreaOutter";
      musicItemAreaOutter.Padding = new Padding(5, 5, 0, 0);
      musicItemAreaOutter.RowCount = 1;
      musicItemAreaOutter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      musicItemAreaOutter.Size = new Size(698, 405);
      musicItemAreaOutter.TabIndex = 1;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(817, 450);
      Controls.Add(musicItemAreaOutter);
      Name = "Form1";
      Text = "Rosemary";
      musicItemAreaOutter.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion
    private FlowLayoutPanel musicItemArea;
    private TableLayoutPanel musicItemAreaOutter;
  }
}