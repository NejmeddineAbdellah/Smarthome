using GestionBibFormGhoudan.Db;
using MySqlConnector;
using p2.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace p2
{
    public partial class Form1 : Form
    {
        HomeService homeService = new HomeService();

        Panel myControle;
        Panel b;

        private Control activeControle;
        private Point previousPoint;
        public static Panel panelbg;
        List<Panel> panels = new List<Panel>();
        private static int panelN = 1;
        private CheckBox check;
        private List<home> homeList;
        private static int x = 0;
        private static int y = 0;
        private static int xhome = 1000;
        private static int yhome = 1500;
        private static int xzone = 1;
        private static int yzone = 1;





        public Form1()
        {
            InitializeComponent();
            initExitSwitch();
            initCapt();
            //add_Zone1.Hide();

        }



        private void initCapt()
        {
            homeList = homeService.afficher();
            foreach (home item in homeList)
            {
                myControle = new Panel();
                myControle.Location = new Point(item.X, item.Y);
                myControle.Size = new Size(64, 64);
                myControle.Text = (panelN).ToString();
                myControle.Name = item.Name;
                myControle.BackColor = Color.Transparent;
                myControle.Click += b_Click;
                changeIcon(myControle, item.Status);
                myControle.BackgroundImageLayout = ImageLayout.Stretch;
                myControle.MouseDown += new MouseEventHandler(myContrl_MouseDown);
                myControle.MouseMove += new MouseEventHandler(myContrl_MouseMove);
                myControle.MouseUp += new MouseEventHandler(myContrl_MMouseUp);
                panel3.Controls.Add(myControle);
                panelN++;
            }

        }
        private void initFridge()
        {
            myControle = new Panel();
            myControle.Location = new Point(530, 500);
            myControle.Size = new Size(64, 64);
            myControle.Text = (panelN).ToString();
            myControle.Name = string.Format("Fridge1");
            myControle.BackColor = Color.Transparent;
            myControle.Click += b_Click;
            myControle.BackgroundImage = Properties.Resources.fridge;
            myControle.BackgroundImageLayout = ImageLayout.Stretch;
            myControle.MouseDown += new MouseEventHandler(myContrl_MouseDown);
            myControle.MouseMove += new MouseEventHandler(myContrl_MouseMove);
            myControle.MouseUp += new MouseEventHandler(myContrl_MMouseUp);
            panel3.Controls.Add(myControle);

        }
        private void initExitSwitch()
        {
            panel7.Click += ExitSwitch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelN++;
            myControle = new Panel();
            /*    if (checkBox1.Checked)
                {
                    check = checkBox1;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                    checkBox7.Checked = false;
                    checkBox8.Checked = false;
                    checkBox9.Checked = false;
                    myControle.Name = string.Format("door {0}", panelN);
                }
                else if (checkBox2.Checked)
                {
                    check = checkBox2;
                    checkBox1.Checked = false;
                    checkBox4.Checked = false;
                    checkBox7.Checked = false;
                    checkBox8.Checked = false;
                    checkBox9.Checked = false;
                    myControle.Name = string.Format("frigde {0}", panelN);
                }
                else if (checkBox4.Checked)
                {
                    check = checkBox4;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox7.Checked = false;
                    checkBox8.Checked = false;
                    checkBox9.Checked = false;
                    myControle.Name = string.Format("lamp {0}", panelN);
                }
                else if (checkBox7.Checked)
                {
                    check = checkBox7;
                    checkBox1.Checked = false;
                    checkBox4.Checked = false;
                    checkBox2.Checked = false;
                    checkBox8.Checked = false;
                    checkBox9.Checked = false;
                    myControle.Name = string.Format("ac {0}", panelN);
                }
                else if (checkBox8.Checked)
                {
                    check = checkBox8;
                    checkBox1.Checked = false;
                    checkBox4.Checked = false;
                    checkBox7.Checked = false;
                    checkBox2.Checked = false;
                    checkBox9.Checked = false;
                    myControle.Name = string.Format("router {0}", panelN);
                }
                else if (checkBox9.Checked)
                {
                    check = checkBox9;
                    checkBox1.Checked = false;
                    checkBox4.Checked = false;
                    checkBox7.Checked = false;
                    checkBox8.Checked = false;
                    checkBox9.Checked = false;
                    myControle.Name = string.Format("tv {0}", panelN);
                }*/
            myControle.Location = new Point(300, 200);
            myControle.Size = new Size(64, 64);
            myControle.Text = (panelN).ToString();
            myControle.Click += b_Click;
            myControle.BackgroundImage = check.Image;
            myControle.BackgroundImageLayout = ImageLayout.Stretch;
            myControle.BackColor = Color.Transparent;
            myControle.MouseDown += new MouseEventHandler(myContrl_MouseDown);
            myControle.MouseMove += new MouseEventHandler(myContrl_MouseMove);
            myControle.MouseUp += new MouseEventHandler(myContrl_MMouseUp);
            panel3.Controls.Add(myControle);
            panels.Add(myControle);
            myControle.BringToFront();
            //removeButton.Enabled = true;

        }

        void b_Click(object sender, EventArgs e)
        {
            b = sender as Panel;
            if (b != null)
            {
                bool exist = homeService.AfficherParIndex(int.Parse(b.Text));
                /* if (exist == false)
                     //panel6.Visible = true;
                 else
                     checkStatus(b);*/
            }
        }

        private void checkStatus(Panel b)
        {
            /*if (homeService.AfficherStatus(int.Parse(b.Text)).Contains("E"))
            {
                deconnect.Enabled = true;
                allumer.Enabled = true;
                Eteindre.Enabled = false;
                connect.Enabled = false;
            }
            else if (homeService.AfficherStatus(int.Parse(b.Text)).Contains("A"))
            {
                Eteindre.Enabled = true;
                deconnect.Enabled = true;
                allumer.Enabled = false;
                connect.Enabled = false;
            }
            else if (homeService.AfficherStatus(int.Parse(b.Text)).Contains("D"))
            {
                Eteindre.Enabled = false;
                allumer.Enabled = false;
                deconnect.Enabled = false;
                connect.Enabled = true;
            }
            else if (homeService.AfficherStatus(int.Parse(b.Text)).Contains("C"))
            {
                Eteindre.Enabled = false;
                allumer.Enabled = true;
                connect.Enabled = false;
                deconnect.Enabled = true;
            }*/
        }

        private void myContrl_MMouseUp(object sender, MouseEventArgs e)
        {
            activeControle = null;
            ActiveControl = null;
            Cursor = Cursors.Default;
        }

        private void myContrl_MouseMove(object sender, MouseEventArgs e)
        {
            if (activeControle == null || activeControle != sender)
            {
                return;
            }
            var location = activeControle.Location;
            location.Offset(e.Location.X - previousPoint.X, e.Location.Y - previousPoint.Y);
            activeControle.Location = location;
        }

        private void myContrl_MouseDown(object sender, MouseEventArgs e)
        {
            activeControle = sender as Control;
            previousPoint = e.Location;
            Cursor = Cursors.Hand;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (homeService.AfficherParIndex(panelN) == true) homeService.delete(panelN);
            // if (panel3.Controls.Count == (homeList.Count() + 3)) removeButton.Enabled = false;
            panel3.Controls.Remove(panels.Last());
            panels.RemoveAt(panelN - (homeList.Count() + 2));
            panelN--;
            //panel6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String n = "";
            Point locationOnForm = myControle.FindForm().PointToClient(myControle.Parent.PointToScreen(myControle.Location));

            DialogResult dialogClose = MessageBox.Show("Voullez-vous ajouter " + myControle.Name, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dialogClose == DialogResult.OK)
            {
                MySqlCommand cmd = Connection.getMySqlCommand();
                cmd.CommandText = "select * from zone";
                /* MySqlDataReader rdr = cmd.ExecuteReader();

                 while (rdr.Read())
                 {
                     if (locationOnForm.X > Convert.ToInt32(rdr["x_zone"]) && locationOnForm.X < Convert.ToInt32(rdr["x_zone"]) && locationOnForm.Y < Convert.ToInt32(rdr["y_zone"]))
                     {
                         n = Convert.ToString(rdr["nom_zone"]);
                         break;
                     }
                 }*/

                homeService.Ajouter(new home(myControle.Name, n, "E", panelN, locationOnForm.X - 1, locationOnForm.Y - 1));
                // panel6.Visible = false;
            }
            else if (dialogClose == DialogResult.Cancel)
            {
                panel3.Controls.Remove(panels.Last());
                panels.RemoveAt(panelN - 2);
                panelN--;
                //panel6.Visible = false;
            }
        }

        private void allumer_Click(object sender, EventArgs e)
        {

            DialogResult dialogClose = MessageBox.Show("Voullez-vous allumer !!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogClose == DialogResult.OK)
            {
                /*Eteindre.Enabled = true;
                allumer.Enabled = false;*/
                homeService.Modifier(int.Parse(b.Text), "A");
                changeIcon(b, "A");
            }

        }

        private void Eteindre_Click(object sender, EventArgs e)
        {
            DialogResult dialogClose = MessageBox.Show("Voullez-vous eteindre !!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogClose == DialogResult.OK)
            {
                /*Eteindre.Enabled = false;
                allumer.Enabled = true;*/
                homeService.Modifier(int.Parse(b.Text), "E");
                changeIcon(b, "E");
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            DialogResult dialogClose = MessageBox.Show("Do you Want To Connect This !!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogClose == DialogResult.OK)
            {
                /*    connect.Enabled = false;
                    deconnect.Enabled = true;
                    allumer.Enabled = true;
                    Eteindre.Enabled = false;*/
                homeService.Modifier(int.Parse(b.Text), "C");
                changeIcon(b, "C");
            }

        }

        private void deconnect_Click(object sender, EventArgs e)
        {
            DialogResult dialogClose = MessageBox.Show("Do you Want To Deconnect This !!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogClose == DialogResult.OK)
            {
                /*    connect.Enabled = true;
                    deconnect.Enabled = false;
                    allumer.Enabled = false;
                    Eteindre.Enabled = false;*/
                homeService.Modifier(int.Parse(b.Text), "D");
                changeIcon(b, "D");
            }
        }
        private void changeIcon(Panel b, String valeur)
        {
            if (valeur.Contains("A"))
            {
                if (b.Name.Contains("tv")) b.BackgroundImage = Properties.Resources.smart_tv;
                else if (b.Name.Contains("door")) b.BackgroundImage = Properties.Resources.door__1_;
                else if (b.Name.Contains("lamp")) b.BackgroundImage = Properties.Resources.light_bulb;
                else if (b.Name.Contains("router")) b.BackgroundImage = Properties.Resources.wireless_router;
                else if (b.Name.Contains("ac")) b.BackgroundImage = Properties.Resources.ac__1_;
            }
            else
            {

                if (b.Name.Contains("tv")) b.BackgroundImage = Properties.Resources.smart_tv__1_;
                else if (b.Name.Contains("door")) b.BackgroundImage = Properties.Resources.door;
                else if (b.Name.Contains("lamp")) b.BackgroundImage = Properties.Resources.light_bulb__2_;
                else if (b.Name.Contains("router")) b.BackgroundImage = Properties.Resources.wireless_router__1_;
                else if (b.Name.Contains("ac")) b.BackgroundImage = Properties.Resources.ac;
            }
        }
        /*
                private void checkBox9_CheckedChanged(object sender, EventArgs e)
                {
                    checkBox1.Checked = false;
                    checkBox4.Checked = false;
                    checkBox7.Checked = false;
                    checkBox8.Checked = false;
                }

                private void checkBox2_CheckedChanged(object sender, EventArgs e)
                {
                    checkBox1.Checked = false;
                    checkBox4.Checked = false;
                    checkBox7.Checked = false;
                    checkBox8.Checked = false;
                    checkBox9.Checked = false;
                }

                private void checkBox1_CheckedChanged(object sender, EventArgs e)
                {
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                    checkBox7.Checked = false;
                    checkBox8.Checked = false;
                    checkBox9.Checked = false;

                }

                private void checkBox4_CheckedChanged(object sender, EventArgs e)
                {
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox7.Checked = false;
                    checkBox8.Checked = false;
                    checkBox9.Checked = false;

                }

                private void checkBox8_CheckedChanged(object sender, EventArgs e)
                {
                    checkBox1.Checked = false;
                    checkBox4.Checked = false;
                    checkBox7.Checked = false;
                    checkBox2.Checked = false;
                    checkBox9.Checked = false;
                }

                private void checkBox7_CheckedChanged(object sender, EventArgs e)
                {
                    checkBox1.Checked = false;
                    checkBox4.Checked = false;
                    checkBox2.Checked = false;
                    checkBox8.Checked = false;
                    checkBox9.Checked = false;
                }
                */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* if (homeService.checkZoneAllu(comboBox1.Text) == 1)
             {
                 connect.Enabled = false; deconnect.Enabled = true;
                 Eteindre.Enabled = true; allumer.Enabled = true;
             }
             else if (homeService.checkZoneAllu(comboBox1.Text) == 0)
             {
                 MessageBox.Show("Zone Vide");
                 connect.Enabled = false; deconnect.Enabled = false;
                 Eteindre.Enabled = false; allumer.Enabled = false;
             }
             else if (homeService.checkZoneAllu(comboBox1.Text) == -1)
             {
                 connect.Enabled = true; deconnect.Enabled = true;
                 Eteindre.Enabled = true; allumer.Enabled = true;
             }*/
        }
        void ExitSwitch(object sender, EventArgs e)
        {
            Panel b = (Panel)sender;
            DialogResult dialogClose = MessageBox.Show("voullez-vous vraiment effacer les objets!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogClose == DialogResult.OK)
            {
                b.BackgroundImage = Properties.Resources.exit__1_;

                panel3.Controls.Clear();
                panels.Clear();
                //if (homeService.killSwitch())
                // this.Close();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

           /* PictureBox p1 = new PictureBox();
            p1.Padding = new Padding(5, 5, 5, 5);
            //  string zone_name =Convert.ToString(comboBox2.Text);
            /*  switch (zone_name)
              {

                  case "Bedroom":
                      p1.Image = Image.FromFile("C:/Users/Nejm/source/repos/p2-master/icons/Bedroom.jpg");
                      break;
                  case "Kitchen":
                      p1.Image = Image.FromFile("C:/Users/Nejm/source/repos/p2-master/icons/Kitchen.jpg");
                      break;
                  case "LivingRoom":
                      p1.Image = Image.FromFile("C:/Users/Nejm/source/repos/p2-master/icons/LivingRoom.jpg");
                      break;
                  case "Bathroom":
                      p1.Image = Image.FromFile("C:/Users/Nejm/source/repos/p2-master/icons/Bathroom.jpg");
                      break;


                  default:
                      break;
              }*/

            //p1.SizeMode = PictureBoxSizeMode.StretchImage;
            /*    p1.Width = Convert.ToInt32(textBox2.Text);
                p1.Height = Convert.ToInt32(textBox1.Text);*/

           /* if (xzone < xhome && yzone < yhome)
            {
                if (x + p1.Width > panel3.Width)
                {
                    y += p1.Height;
                    yzone += p1.Height;
                    x = 0;
                }

                p1.Location = new Point(x, y);
                x += p1.Width;
                xzone += p1.Width;
            }
            else
            {
                MessageBox.Show("vous avez depasser la surface limit");
            }



            panel3.Controls.Add(p1);
            p1.SendToBack();

            panel3.AutoScroll = true;

            MySqlCommand cmd = Connection.getMySqlCommand();
            cmd.CommandText = "INSERT INTO zone (nom_zone,x_zone,y_zone)" +
                "VALUES(@nom_zone, @x_zone,@y_zone)";
            //  cmd.Parameters.AddWithValue("@nom_zone", comboBox2.Text);
            cmd.Parameters.AddWithValue("@x_zone", x);
            cmd.Parameters.AddWithValue("@y_zone", y);
            cmd.ExecuteNonQuery();

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            /*
                        PictureBox p1 = new PictureBox();
                        p1.Padding = new Padding(5, 5, 5, 5);
                        string zone_name = zonename;
                        switch (zone_name)
                        {

                            case "Bedroom":
                                p1.Image = Image.FromFile("C:/Users/Nejm/source/repos/p2-master/icons/Bedroom.jpg");
                                break;
                            case "Kitchen":
                                p1.Image = Image.FromFile("C:/Users/Nejm/source/repos/p2-master/icons/Kitchen.jpg");
                                break;
                            case "LivingRoom":
                                p1.Image = Image.FromFile("C:/Users/Nejm/source/repos/p2-master/icons/LivingRoom.jpg");
                                break;
                            case "Bathroom":
                                p1.Image = Image.FromFile("C:/Users/Nejm/source/repos/p2-master/icons/Bathroom.jpg");
                                break;
                            default:
                                break;
                        }

                        p1.SizeMode = PictureBoxSizeMode.StretchImage;
                        p1.Width = zonew;
                        p1.Height = zoneh;

                        if (xzone < xhome && yzone < yhome)
                        {
                            if (x + p1.Width > panel3.Width)
                            {
                                y += p1.Height;
                                yzone += p1.Height;
                                x = 0;
                            }

                            p1.Location = new Point(x, y);
                            x += p1.Width;
                            xzone += p1.Width;
                        }
                        else
                        {
                            MessageBox.Show("vous avez depasser la surface limit");
                        }

                        panelbg.Controls.Add(p1);
                       // panel3.Controls.Add(p1);
                        panel3.AutoScroll = true;
                        p1.SendToBack();
                        panel3.BackgroundImage = panelbg.BackgroundImage;



                        MySqlCommand cmd = Connection.getMySqlCommand();
                        cmd.CommandText = "INSERT INTO zone (nom_zone,x_zone,y_zone)" +
                            "VALUES(@nom_zone, @x_zone,@y_zone)";
                        cmd.Parameters.AddWithValue("@nom_zone", zonename);
                        cmd.Parameters.AddWithValue("@x_zone", x);
                        cmd.Parameters.AddWithValue("@y_zone", y);
                        cmd.ExecuteNonQuery();*/

        }

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            guna2Panel1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        public void getZone()
        {
             if (yzone > 0 && xzone > 0 && comboBox2.Text != "")
             {

                 PictureBox p1 = new PictureBox();
                 p1.Padding = new Padding(5, 5, 5, 5);
                 string zone_name = comboBox2.Text;
                 switch (zone_name)
                 {

                     case "Bedroom":
                         p1.Image = Image.FromFile("C:/Users/Nejm/source/repos/p2-master/icons/Bedroom.jpg");
                         break;
                     case "Kitchen":
                         p1.Image = Image.FromFile("C:/Users/Nejm/source/repos/p2-master/icons/Kitchen.jpg");
                         break;
                     case "LivingRoom":
                         p1.Image = Image.FromFile("C:/Users/Nejm/source/repos/p2-master/icons/LivingRoom.jpg");
                         break;
                     case "Bathroom":
                         p1.Image = Image.FromFile("C:/Users/Nejm/source/repos/p2-master/icons/Bathroom.jpg");
                         break;
                     default:
                         break;
                 }

                 p1.SizeMode = PictureBoxSizeMode.StretchImage;
                 p1.Width =Convert.ToInt32(textBox2.Text);
                 p1.Height = Convert.ToInt32(textBox1.Text);

                 if (xzone < xhome && yzone < yhome)
                 {
                     if (x + p1.Width > panel3.Width)
                     {
                         y += p1.Height;
                         yzone += p1.Height;
                         x = 0;
                     }
                     p1.Location = new Point(x, y);
                     x += p1.Width;
                     xzone += p1.Width;
                 }
                 else
                 {
                     MessageBox.Show("vous avez depasser la surface limit");
                 }
                 panel3.Controls.Add(p1);
                 panel3.AutoScroll = true;
                 
 /*
                 MySqlCommand cmd = Connection.getMySqlCommand();
                 cmd.CommandText = "INSERT INTO zone (nom_zone,x_zone,y_zone)" +
                     "VALUES(@nom_zone, @x_zone,@y_zone)";
                 cmd.Parameters.AddWithValue("@nom_zone", comboBox2.Text);
                 cmd.Parameters.AddWithValue("@x_zone", xzone);
                 cmd.Parameters.AddWithValue("@y_zone", yzone);
                 cmd.ExecuteNonQuery();*/

            }
        }

        private void guna2CirclePictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            guna2CirclePictureBox2.BackColor = Color.Transparent;

            guna2CirclePictureBox2.DoDragDrop(guna2CirclePictureBox2.Image, DragDropEffects.Copy);
        }
        private void guna2CirclePictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            guna2CirclePictureBox6.DoDragDrop(guna2CirclePictureBox6.Image, DragDropEffects.Copy);

        }
        private void guna2CirclePictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            guna2CirclePictureBox5.DoDragDrop(guna2CirclePictureBox5.Image, DragDropEffects.Copy);

        }

        private void guna2CirclePictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            guna2CirclePictureBox4.DoDragDrop(guna2CirclePictureBox4.Image, DragDropEffects.Copy);

        }

        private void guna2CirclePictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            guna2CirclePictureBox3.BackColor = Color.Transparent;
            guna2CirclePictureBox3.DoDragDrop(guna2CirclePictureBox3.Image, DragDropEffects.Copy);

        }

        private void guna2CirclePictureBox12_MouseDown(object sender, MouseEventArgs e)
        {
            guna2CirclePictureBox12.DoDragDrop(guna2CirclePictureBox12.Image, DragDropEffects.Copy);

        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;

            }
        }

        private void panel3_DragDrop(object sender, DragEventArgs e)
        {
            panelN++;
            myControle = new Panel();
            Image getpic = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

            myControle.Location = new Point(300, 200);
            myControle.Size = new Size(64, 64);
            myControle.Text = (panelN).ToString();
            myControle.Click += b_Click;
            myControle.BackgroundImage = getpic;
            myControle.BackgroundImageLayout = ImageLayout.Zoom;
            myControle.BackColor = Color.Transparent;
            myControle.ForeColor = Color.Transparent;
            myControle.MouseDown += new MouseEventHandler(myContrl_MouseDown);
            myControle.MouseMove += new MouseEventHandler(myContrl_MouseMove);
            myControle.MouseUp += new MouseEventHandler(myContrl_MMouseUp);
            panel3.Controls.Add(myControle);
            panels.Add(myControle);
            myControle.BringToFront();


            // panel3.BackgroundImage = getpic;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
            getZone();
            guna2Panel1.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
        }

     /*   private void panel3_MouseDown_1(object sender, MouseEventArgs e)
        {
            Panel pp = (Panel)sender;
            pp.Select();
            pp.DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);

        }*/
    }
}
