using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.Components
{
    public class Style : Form
    {
        public void AddShadowPanel(Panel targetPanel)
        {
            Panel shadowPanel = new Panel
            {
                BackColor = Color.Gray, 
                Size = new Size(targetPanel.Width + 10, targetPanel.Height + 10),  
                Location = new Point(targetPanel.Left - 5, targetPanel.Top - 5),  
                Visible = true,
            };

            Controls.Add(shadowPanel);
            shadowPanel.SendToBack();
        }
    }
}
