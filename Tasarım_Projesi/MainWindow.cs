using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasarım_Projesi
{
    class elektroskob:Form
    {

        Timer timer;
        Elektroskop elektroskop;
        private TextBox textBox_cubuk;
        private TextBox textBox_elek;
        private Label label_cubuk;
        private Label label_elektroskop;
        Stick stick;
        string cubuk;
        private Button sifirla;
        string elek;


        public elektroskob()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer|ControlStyles.AllPaintingInWmPaint| ControlStyles.UserPaint , true);
            //SetBounds(0,0,Width+300,Height+200);

            InitializeComponent();
           
            Button yaklastir = new Button();
            yaklastir.Width = 80;
            yaklastir.Left = 394;
            yaklastir.Top = 80;
            yaklastir.Text = "Yaklaştır";
            this.Controls.Add(yaklastir);
            yaklastir.Click += yaklastir_Click;
                    
            Paint +=MainWindow_Paint;
            //KeyDown += MainWindow_KeyDown;           

            elektroskop = new Elektroskop();
            stick = new Stick();
        }

        void yaklastir_Click(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Tick += timer_Tick;
            timer.Interval = 20;
            cubuk = textBox_cubuk.Text.ToString();
            elek = textBox_elek.Text.ToString();

            if (cubuk == "+" && elek == "-" || cubuk == "-" && elek == "+")
            {
                timer.Start();
            }
            
        }

        void tim_Tick(object sender, EventArgs e)
        {

            if (elektroskop.x2 == 165 && elektroskop.x3 == 135)

            {
                timer.Stop();
             //   stick.charge(1);
                
            }     
      
            elektroskop.x2 += 1;
            elektroskop.x3 -= 1;  
           
        }


        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            //(new Ball()).move(e.Graphics);
            //e.Graphics.FillEllipse(Brushes.Red, x, 0, 50, 50);
            elektroskop.draw(e.Graphics);
            stick.draw(e.Graphics);
                  
        }


        void timer_Tick(object sender, EventArgs e)
        {
            
            if (stick.s1==80)
            {
                /* MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(this, "canan", "caption", buttons);*/        
                timer.Stop();             
                timer.Tick += tim_Tick;
                timer.Interval = 35;
                timer.Start();  
                                                         
            }

            stick.s1 += 1;
            Invalidate();
   
        }
        private void sifirla_Click(object sender, EventArgs e)

        {
            stick.s1 = 30;
            elektroskop.x2 = 155;
            elektroskop.x3 = 145;

           /* DialogResult secenek = MessageBox.Show("Yükler sıfırlansın mı?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                stick.s1 = 30;
                elektroskop.x2 = 155;
                elektroskop.x3 = 145;
            }
            else if (secenek == DialogResult.No)
            {
                //Hayır seçeneğine tıklandığında çalıştırılacak kodlar
            }*/

        }

        private void InitializeComponent()
        {
            this.textBox_cubuk = new System.Windows.Forms.TextBox();
            this.textBox_elek = new System.Windows.Forms.TextBox();
            this.label_cubuk = new System.Windows.Forms.Label();
            this.label_elektroskop = new System.Windows.Forms.Label();
            this.sifirla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_cubuk
            // 
            this.textBox_cubuk.Location = new System.Drawing.Point(440, 122);
            this.textBox_cubuk.Name = "textBox_cubuk";
            this.textBox_cubuk.Size = new System.Drawing.Size(34, 20);
            this.textBox_cubuk.TabIndex = 4;
            // 
            // textBox_elek
            // 
            this.textBox_elek.Location = new System.Drawing.Point(440, 160);
            this.textBox_elek.Name = "textBox_elek";
            this.textBox_elek.Size = new System.Drawing.Size(34, 20);
            this.textBox_elek.TabIndex = 5;
            // 
            // label_cubuk
            // 
            this.label_cubuk.AutoSize = true;
            this.label_cubuk.Location = new System.Drawing.Point(330, 129);
            this.label_cubuk.Name = "label_cubuk";
            this.label_cubuk.Size = new System.Drawing.Size(79, 13);
            this.label_cubuk.TabIndex = 6;
            this.label_cubuk.Text = "Çubuğun yükü:";
            this.label_cubuk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_elektroskop
            // 
            this.label_elektroskop.AutoSize = true;
            this.label_elektroskop.Location = new System.Drawing.Point(330, 167);
            this.label_elektroskop.Name = "label_elektroskop";
            this.label_elektroskop.Size = new System.Drawing.Size(104, 13);
            this.label_elektroskop.TabIndex = 7;
            this.label_elektroskop.Text = "Elektrsokobun yükü:";
            // 
            // sifirla
            // 
            this.sifirla.Location = new System.Drawing.Point(387, 227);
            this.sifirla.Name = "sifirla";
            this.sifirla.Size = new System.Drawing.Size(75, 23);
            this.sifirla.TabIndex = 8;
            this.sifirla.Text = "Sıfırla";
            this.sifirla.UseVisualStyleBackColor = true;
            this.sifirla.Click += new System.EventHandler(this.sifirla_Click);
            // 
            // elektroskob
            // 
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.sifirla);
            this.Controls.Add(this.label_elektroskop);
            this.Controls.Add(this.label_cubuk);
            this.Controls.Add(this.textBox_elek);
            this.Controls.Add(this.textBox_cubuk);
            this.Name = "elektroskob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            // elektroskop.charge(e.KeyValue);

            /*if (e.KeyValue == (int)Keys.Left)
            {
                ball.x -= 7;
            }
            if (e.KeyValue == (int)Keys.Right)
            {
                ball.y -= 7;
            }*/

        }   
       
    }
}