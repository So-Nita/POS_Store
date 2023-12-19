using POSDesignDemo.Constant;

namespace POSDesignDemo;

public partial class TouchScrollHorizontalForm : Form
{
    private CustomTouchScroll touchScroll;

    private int YOffSet = 0;

    public TouchScrollHorizontalForm()
    {
        InitializeComponent();
        touchScroll = new CustomTouchScroll(flowLayoutPanel1, ConstantScrollDirection.Horizontal);

        // Get the horizontal scrollbar of flowLayoutPanel1
        HScrollBar horizontalScrollBar = GetHorizontalScrollBar(flowLayoutPanel1);

        InitBtn();
    }

    private HScrollBar GetHorizontalScrollBar(Control control)
    {
        if (control is HScrollBar horizontalScrollBar)
        {
            return horizontalScrollBar;
        }

        foreach (Control childControl in control.Controls)
        {
            HScrollBar childScrollBar = GetHorizontalScrollBar(childControl);
            if (childScrollBar != null)
            {
                return childScrollBar;
            }
        }
        return null;
    }

    private void InitBtn()
    {
        var list = new List<string>()
        {
            "Button-01",
            "Button-02",
            "Button-03",
            "Button-04",
            "Button-05",
            "Button-06",
            "Button-07",
            "Button-08",
            "Button-09",
            "Button-010",
        };

        foreach (var text in list)
        {
            CreateBtn(text);
        }
    }

    private void CreateBtn(string text)
    {
        var btnCategory = new Button();
        btnCategory.BackColor = Color.FromArgb(128, 128, 255);
        btnCategory.Size = new Size(100, 50);
        btnCategory.Text = text;
        btnCategory.UseVisualStyleBackColor = false;
        btnCategory.Location = new Point(YOffSet, 7);
        btnCategory.Margin = new Padding(0, 4, 0, 0);
        flowLayoutPanel1.Controls.Add(btnCategory);
        YOffSet += 120;

        // Assign scrolling events to the dynamically created button
        touchScroll.AssignScrollEvent(btnCategory);
    }
}
