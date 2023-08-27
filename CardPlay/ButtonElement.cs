using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosemary
{
  public partial class ButtonElement : UserControl
  {
    bool isHovered = false;
    bool isPressed = false;
    #region Public Variables
    public Image buttonImage
    {
      get
      {
        return image.Image;
      }
      set
      {
        image.Image = value;
      }
    }
    public Color backColor
    {
      get
      {
        return BackColor;
      }
      set
      {
        BackColor = value;
      }
    }
    public Color defaultColor { get; set; }
    public Color mouseOverColor { get; set; }
    public Color mouseDownColor { get; set; }
    // Padding change new Point(FROM,TO)
    Point mouseOverChange;
    public Point mouseOverPaddingChange
    {
      get
      {
        return mouseOverChange;
      }
      set
      {
        mouseOverChange = value;
        Padding = new Padding(mouseOverChange.X);
      }
    }

    #endregion
    EventHandler? mousePress;
    public event EventHandler? MousePress
    {
      add
      {
        mousePress += value;
      }
      remove
      {
        mousePress -= value;
      }
    }
    public ButtonElement()
    {
      InitializeComponent();
      MouseEnterLeaveRecursive(this);
      MouseDownClickRecursive(this);
      timer.Start();
    }
    #region Hover
    private void Element_MouseLeave(object? sender, EventArgs e)
    {
      isHovered = false;
      isPressed = false;
    }
    private void Element_MouseEnter(object? sender, EventArgs e)
    {
      isHovered = true;
    }
    void MouseEnterLeaveRecursive(Control element)
    {
      element.MouseEnter += Element_MouseEnter;
      element.MouseLeave += Element_MouseLeave;
      for (int i = 0; i < element.Controls.Count; i++)
      {
        MouseEnterLeaveRecursive(element.Controls[i]);
      }
    }
    #endregion
    #region Click
    private void Element_MouseDown(object? sender, EventArgs e)
    {
      isPressed = true;
    }
    private void Element_MouseClick(object? sender, EventArgs e)
    {
      mousePress!.Invoke(this, EventArgs.Empty);
      backColor = mouseOverColor;
      isPressed = false;
    }
    void MouseDownClickRecursive(Control element)
    {
      element.MouseDown += Element_MouseDown;
      element.MouseClick += Element_MouseClick;
      for (int i = 0; i < element.Controls.Count; i++)
      {
        MouseDownClickRecursive(element.Controls[i]);
      }
    }
    #endregion

    private void timer_Tick(object sender, EventArgs e)
    {
      if (isHovered)
      {
        backColor = mouseOverColor;
        Padding = new Padding(mouseOverChange.Y);
      }
      else
      {
        backColor = defaultColor;
        Padding = new Padding(mouseOverChange.X);
      }
      if (isPressed)
      {
        backColor = mouseDownColor;
      }
    }
  }
}
