using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdmissionCommittee.Views;

namespace AdmissionCommittee
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            homeButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Home.png"));
            requestButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Request.png"));
            ratingButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Rating.png"));
            requestButton1.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Request1.png"));
            requestButton2.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Request2.png"));
            ratingButton1.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Rating1.png"));
            ratingButton2.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Rating2.png"));
            ratingButton3.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Rating3.png"));
            rebootButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Reboot.png"));
            contentPanel.SendToBack();
        }
        private void requestButton_MouseEnter(object sender, EventArgs e)
        {
            requestButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "RequestLight.png"));
        }
        private void requestButton_MouseLeave(object sender, EventArgs e)
        {
            requestButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Request.png"));
        }
        private void ratingButton_MouseEnter(object sender, EventArgs e)
        {
            ratingButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "RatingLight.png"));
        }
        private void ratingButton_MouseLeave(object sender, EventArgs e)
        {
            ratingButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Rating.png"));
        }
        private void homeButton_MouseEnter(object sender, EventArgs e)
        {
            homeButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "HomeLight.png"));
        }
        private void homeButton_MouseLeave(object sender, EventArgs e)
        {
            homeButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Home.png"));
        }
        private void requestButton1_MouseEnter(object sender, EventArgs e)
        {
            requestButton1.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Request1Light.png"));
        }
        private void requestButton1_MouseLeave(object sender, EventArgs e)
        {
            requestButton1.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Request1.png"));
        }
        private void requestButton2_MouseEnter(object sender, EventArgs e)
        {
            requestButton2.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Request2Light.png"));
        }
        private void requestButton2_MouseLeave(object sender, EventArgs e)
        {
            requestButton2.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Request2.png"));
        }
        private void ratingButton1_MouseEnter(object sender, EventArgs e)
        {
            ratingButton1.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Rating1Light.png"));
        }
        private void ratingButton1_MouseLeave(object sender, EventArgs e)
        {
            ratingButton1.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Rating1.png"));
        }
        private void ratingButton2_MouseEnter(object sender, EventArgs e)
        {
            ratingButton2.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Rating2Light.png"));
        }
        private void ratingButton2_MouseLeave(object sender, EventArgs e)
        {
            ratingButton2.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Rating2.png"));
        }
        private void ratingButton3_MouseEnter(object sender, EventArgs e)
        {
            ratingButton3.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Rating3Light.png"));
        }
        private void ratingButton3_MouseLeave(object sender, EventArgs e)
        {
            ratingButton3.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Rating3.png"));
        }
        private void rebootButton_MouseEnter(object sender, EventArgs e)
        {
            rebootButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "RebootLight.png"));
        }
        private void rebootButton_MouseLeave(object sender, EventArgs e)
        {
            rebootButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Reboot.png"));
        }
        private void homeButton_MouseDown(object sender, MouseEventArgs e)
        {
            homeButton.Location = new Point(homeButton.Location.X, homeButton.Location.Y + 1);
        }
        private void homeButton_MouseUp(object sender, MouseEventArgs e)
        {
            homeButton.Location = new Point(homeButton.Location.X, homeButton.Location.Y - 1);
            var control = new HomeUserControl();
            control.LoadStatistics();
            LoadUserControl(control);
        }
        private void requestButton_MouseDown(object sender, MouseEventArgs e)
        {
            requestButton.Location = new Point(requestButton.Location.X, requestButton.Location.Y + 1);
        }
        private void requestButton_MouseUp(object sender, MouseEventArgs e)
        {
            requestPanel.Visible = !requestPanel.Visible;
            requestButton.Location = new Point(requestButton.Location.X, requestButton.Location.Y - 1);
        }
        private void requestButton1_MouseDown(object sender, MouseEventArgs e)
        {
            requestButton1.Location = new Point(requestButton1.Location.X, requestButton1.Location.Y + 1);
        }
        private void requestButton1_MouseUp(object sender, MouseEventArgs e)
        {
            requestPanel.Visible = !requestPanel.Visible;
            requestButton1.Location = new Point(requestButton1.Location.X, requestButton1.Location.Y - 1);
            LoadUserControl(new Request1UserControl());
        }
        private void requestButton2_MouseDown(object sender, MouseEventArgs e)
        {
            requestButton2.Location = new Point(requestButton2.Location.X, requestButton2.Location.Y + 1);
        }
        private void requestButton2_MouseUp(object sender, MouseEventArgs e)
        {
            requestPanel.Visible = !requestPanel.Visible;
            requestButton2.Location = new Point(requestButton2.Location.X, requestButton2.Location.Y - 1);
            var control = new Request2UserControl();
            control.LoadRequests();
            LoadUserControl(control);
        }
        private void ratingButton_MouseDown(object sender, MouseEventArgs e)
        {
            ratingButton.Location = new Point(ratingButton.Location.X, ratingButton.Location.Y + 1);
        }
        private void ratingButton_MouseUp(object sender, MouseEventArgs e)
        {
            ratingPanel.Visible = !ratingPanel.Visible;
            ratingButton.Location = new Point(ratingButton.Location.X, ratingButton.Location.Y - 1);
        }
        private void ratingButton1_MouseDown(object sender, MouseEventArgs e)
        {
            ratingButton1.Location = new Point(ratingButton1.Location.X, ratingButton1.Location.Y + 1);
        }
        private void ratingButton1_MouseUp(object sender, MouseEventArgs e)
        {
            ratingPanel.Visible = !ratingPanel.Visible;
            ratingButton1.Location = new Point(ratingButton1.Location.X, ratingButton1.Location.Y - 1);
            var control = new Rating1UserControl();
            control.LoadRatingData1();
            LoadUserControl(control);
        }
        private void ratingButton2_MouseDown(object sender, MouseEventArgs e)
        {
            ratingButton2.Location = new Point(ratingButton2.Location.X, ratingButton2.Location.Y + 1);
        }
        private void ratingButton2_MouseUp(object sender, MouseEventArgs e)
        {
            ratingPanel.Visible = !ratingPanel.Visible;
            ratingButton2.Location = new Point(ratingButton2.Location.X, ratingButton2.Location.Y - 1);
            var control = new Rating2UserControl();
            control.LoadRatingData2();
            LoadUserControl(control);
        }
        private void ratingButton3_MouseDown(object sender, MouseEventArgs e)
        {
            ratingButton3.Location = new Point(ratingButton3.Location.X, ratingButton3.Location.Y + 1);
        }
        private void ratingButton3_MouseUp(object sender, MouseEventArgs e)
        {
            ratingPanel.Visible = !ratingPanel.Visible;
            ratingButton3.Location = new Point(ratingButton3.Location.X, ratingButton3.Location.Y - 1);
            var control = new Rating3UserControl();
            control.LoadRatingData3();
            LoadUserControl(control);
        }
        private void rebootButton_MouseDown(object sender, MouseEventArgs e)
        {
            rebootButton.Location = new Point(rebootButton.Location.X, rebootButton.Location.Y + 1);
        }
        private void rebootButton_MouseUp(object sender, MouseEventArgs e)
        {
            rebootButton.Location = new Point(rebootButton.Location.X, rebootButton.Location.Y - 1);
            foreach (Control control in contentPanel.Controls)
            {
                if (control is Request2UserControl reqControl)
                {
                    reqControl.LoadRequests();
                }
                else if (control is Rating1UserControl ratingControl1)
                {
                    ratingControl1.LoadRatingData1();
                }
                else if (control is Rating2UserControl ratingControl2)
                {
                    ratingControl2.LoadRatingData2();
                }
                else if (control is Rating3UserControl ratingControl3)
                {
                    ratingControl3.LoadRatingData3();
                }
                else if (control is HomeUserControl homeControl)
                {
                    homeControl.LoadStatistics();
                }
            }
        }
        private void LoadUserControl(UserControl control)
        {
            if (contentPanel.Controls.Count > 0 && 
                contentPanel.Controls[0].GetType() == control.GetType())
            {
                return;
            }

            contentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(control);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUserControl(new HomeUserControl());
        }
    }
}