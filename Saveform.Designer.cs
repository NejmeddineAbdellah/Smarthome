namespace p2
{
    partial class Saveform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.push = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.allumer = new System.Windows.Forms.Button();
            this.Eteindre = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.deconnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.SuspendLayout();
            // 
            // push
            // 
            this.push.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.push.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.push.ForeColor = System.Drawing.Color.White;
            this.push.Location = new System.Drawing.Point(171, 118);
            this.push.Margin = new System.Windows.Forms.Padding(2);
            this.push.Name = "push";
            this.push.Size = new System.Drawing.Size(109, 32);
            this.push.TabIndex = 17;
            this.push.Text = "Enregistrer";
            this.push.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Type Zone";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Bedroom",
            "Kitchen",
            "LivingRoom",
            "Bathroom"});
            this.comboBox2.Location = new System.Drawing.Point(132, 220);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(111, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Height";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Add Zone";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // allumer
            // 
            this.allumer.BackColor = System.Drawing.Color.White;
            this.allumer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.allumer.Enabled = false;
            this.allumer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allumer.ForeColor = System.Drawing.Color.White;
            this.allumer.Image = global::p2.Properties.Resources.switch_on;
            this.allumer.Location = new System.Drawing.Point(357, 286);
            this.allumer.Margin = new System.Windows.Forms.Padding(2);
            this.allumer.Name = "allumer";
            this.allumer.Size = new System.Drawing.Size(81, 46);
            this.allumer.TabIndex = 6;
            this.allumer.UseVisualStyleBackColor = false;
            // 
            // Eteindre
            // 
            this.Eteindre.BackColor = System.Drawing.Color.White;
            this.Eteindre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eteindre.Enabled = false;
            this.Eteindre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eteindre.ForeColor = System.Drawing.Color.White;
            this.Eteindre.Image = global::p2.Properties.Resources.switch_off;
            this.Eteindre.Location = new System.Drawing.Point(358, 236);
            this.Eteindre.Margin = new System.Windows.Forms.Padding(2);
            this.Eteindre.Name = "Eteindre";
            this.Eteindre.Size = new System.Drawing.Size(80, 46);
            this.Eteindre.TabIndex = 7;
            this.Eteindre.UseVisualStyleBackColor = false;
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.White;
            this.connect.Enabled = false;
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect.ForeColor = System.Drawing.Color.White;
            this.connect.Image = global::p2.Properties.Resources.connect;
            this.connect.Location = new System.Drawing.Point(359, 177);
            this.connect.Margin = new System.Windows.Forms.Padding(2);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(79, 55);
            this.connect.TabIndex = 4;
            this.connect.UseVisualStyleBackColor = false;
            // 
            // deconnect
            // 
            this.deconnect.BackColor = System.Drawing.Color.White;
            this.deconnect.Enabled = false;
            this.deconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deconnect.ForeColor = System.Drawing.Color.White;
            this.deconnect.Image = global::p2.Properties.Resources.unplugged;
            this.deconnect.Location = new System.Drawing.Point(363, 118);
            this.deconnect.Margin = new System.Windows.Forms.Padding(2);
            this.deconnect.Name = "deconnect";
            this.deconnect.Size = new System.Drawing.Size(80, 55);
            this.deconnect.TabIndex = 5;
            this.deconnect.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::p2.Properties.Resources.switch_on;
            this.button1.Location = new System.Drawing.Point(487, 301);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 46);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::p2.Properties.Resources.switch_off;
            this.button3.Location = new System.Drawing.Point(488, 251);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 46);
            this.button3.TabIndex = 28;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::p2.Properties.Resources.connect;
            this.button4.Location = new System.Drawing.Point(489, 192);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 55);
            this.button4.TabIndex = 25;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::p2.Properties.Resources.unplugged;
            this.button5.Location = new System.Drawing.Point(493, 133);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 55);
            this.button5.TabIndex = 26;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(659, 121);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 28);
            this.button6.TabIndex = 30;
            this.button6.Text = "New";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(659, 89);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(85, 28);
            this.removeButton.TabIndex = 29;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // Saveform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.push);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.allumer);
            this.Controls.Add(this.Eteindre);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.deconnect);
            this.Name = "Saveform";
            this.Text = "Saveform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button allumer;
        private System.Windows.Forms.Button Eteindre;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button deconnect;
        private System.Windows.Forms.Button push;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button removeButton;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
    }
}