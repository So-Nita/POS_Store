using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace POSDesignDemo.Test;

/*public partial class CustomMessageBox : Form
{
    private readonly Timer timer;
    private int durationInSeconds = 3;
    public CustomMessageBox(string message, Color txtColor, string base64Image)
    {
        InitializeComponent();

        panelMessage.Text = "";
        panelMessage.BorderStyle = BorderStyle.None;

        PictureBox pictureBox = new PictureBox();
        pictureBox.Size = new Size(200, 155);
        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

        byte[] imageBytes = Convert.FromBase64String(base64Image);

        using (MemoryStream stream = new MemoryStream(imageBytes))
        {
            Image image = Image.FromStream(stream);
            pictureBox.Image = image;
        }

        panelImage.Controls.Add(pictureBox);
        label.Text = message;
        label.ForeColor = txtColor;
        label.Dock = DockStyle.Fill;
        label.TextAlign = ContentAlignment.MiddleCenter;
        label.Font = new Font("Segoe UI", 12, FontStyle.Regular);

        timer = new Timer
        {
            Interval = durationInSeconds * 1000,
            Enabled = true
        };
        timer.Tick += Timer_Tick;
    }
    private void Timer_Tick(object sender, EventArgs e)
    {
        Close();
    }

    public static void ShowMessageBox(string message, Color txtColor, string base64Image, int durationInSeconds)
    {
        using (var form = new CustomMessageBox(message, txtColor, base64Image))
        {
            form.ShowDialog();
        }
    }
}*/


public partial class CustomMessageBox : Form
{
    private readonly Timer timer;
    private readonly Panel shadowPanel;
    public CustomMessageBox(string message, Color txtColor, int durationInSeconds)
    {
        InitializeComponent();

        Text = "";
        Size = new Size(240, 150);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        StartPosition = FormStartPosition.CenterScreen;
        ControlBox = false;
        var label = new Label
        {
            Text = message,
            ForeColor = txtColor,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 12, FontStyle.Regular)
        };
        PictureBox pictureBox = new PictureBox();
        pictureBox.Size = new Size(200, 155);
        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

        label.Text = message;
        label.ForeColor = txtColor;
        label.Dock = DockStyle.Fill;
        label.TextAlign = ContentAlignment.MiddleCenter;
        label.Font = new Font("Segoe UI", 12, FontStyle.Regular);

        Controls.Add(label);

        timer = new Timer
        {
            Interval = durationInSeconds * 1000,
            Enabled = true
        };
        timer.Tick += Timer_Tick;
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        Close();
    }

    public static void ShowMessageBox(string message, Color txtColor, int durationInSeconds)
    {
        using (var form = new CustomMessageBox(message, txtColor, durationInSeconds))
        {
            form.ShowDialog();
        }
    }
}
