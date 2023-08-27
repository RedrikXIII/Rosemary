namespace Rosemary
{
  partial class ButtonElement
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
      image = new PictureBox();
      timer = new System.Windows.Forms.Timer(components);
      ((System.ComponentModel.ISupportInitialize)image).BeginInit();
      SuspendLayout();
      // 
      // image
      // 
      image.BackColor = Color.Transparent;
      image.Dock = DockStyle.Fill;
      image.Image = Properties.Resources.playIconPrcsd;
      image.Location = new Point(10, 10);
      image.Margin = new Padding(0);
      image.Name = "image";
      image.Size = new Size(130, 130);
      image.SizeMode = PictureBoxSizeMode.StretchImage;
      image.TabIndex = 0;
      image.TabStop = false;
      // 
      // timer
      // 
      timer.Tick += timer_Tick;
      // 
      // ButtonElement
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.Black;
      Controls.Add(image);
      Name = "ButtonElement";
      Padding = new Padding(10);
      ((System.ComponentModel.ISupportInitialize)image).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private PictureBox image;
    private System.Windows.Forms.Timer timer;
  }
}
