namespace lab4_3D
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonEgg = new System.Windows.Forms.Button();
            this.elementHostEggBox = new System.Windows.Forms.Integration.ElementHost();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSin = new System.Windows.Forms.Button();
            this.elementHostSin = new System.Windows.Forms.Integration.ElementHost();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonVolcano = new System.Windows.Forms.Button();
            this.elementHostVolcano = new System.Windows.Forms.Integration.ElementHost();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonOrchid = new System.Windows.Forms.Button();
            this.elementHostOrchid = new System.Windows.Forms.Integration.ElementHost();
            this.timerColor = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 498);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonEgg);
            this.tabPage1.Controls.Add(this.elementHostEggBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(882, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "EggBox";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonEgg
            // 
            this.buttonEgg.Location = new System.Drawing.Point(777, 6);
            this.buttonEgg.Name = "buttonEgg";
            this.buttonEgg.Size = new System.Drawing.Size(87, 23);
            this.buttonEgg.TabIndex = 1;
            this.buttonEgg.Text = "button1";
            this.buttonEgg.UseVisualStyleBackColor = true;
            this.buttonEgg.Click += new System.EventHandler(this.buttonEgg_Click);
            // 
            // elementHostEggBox
            // 
            this.elementHostEggBox.AutoSize = true;
            this.elementHostEggBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHostEggBox.Location = new System.Drawing.Point(3, 3);
            this.elementHostEggBox.Name = "elementHostEggBox";
            this.elementHostEggBox.Size = new System.Drawing.Size(876, 463);
            this.elementHostEggBox.TabIndex = 0;
            this.elementHostEggBox.Text = "elementHost1";
            this.elementHostEggBox.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHostEggBox_ChildChanged);
            this.elementHostEggBox.Child = null;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonSin);
            this.tabPage2.Controls.Add(this.elementHostSin);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(882, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sinus";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSin
            // 
            this.buttonSin.Location = new System.Drawing.Point(770, 7);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(75, 23);
            this.buttonSin.TabIndex = 1;
            this.buttonSin.Text = "button1";
            this.buttonSin.UseVisualStyleBackColor = true;
            this.buttonSin.Click += new System.EventHandler(this.buttonSin_Click);
            // 
            // elementHostSin
            // 
            this.elementHostSin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHostSin.Location = new System.Drawing.Point(3, 3);
            this.elementHostSin.Name = "elementHostSin";
            this.elementHostSin.Size = new System.Drawing.Size(876, 463);
            this.elementHostSin.TabIndex = 0;
            this.elementHostSin.Text = "elementHost2";
            this.elementHostSin.Child = null;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonVolcano);
            this.tabPage3.Controls.Add(this.elementHostVolcano);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(882, 469);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Volcano";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonVolcano
            // 
            this.buttonVolcano.Location = new System.Drawing.Point(783, 4);
            this.buttonVolcano.Name = "buttonVolcano";
            this.buttonVolcano.Size = new System.Drawing.Size(75, 23);
            this.buttonVolcano.TabIndex = 1;
            this.buttonVolcano.Text = "button1";
            this.buttonVolcano.UseVisualStyleBackColor = true;
            this.buttonVolcano.Click += new System.EventHandler(this.buttonVolcano_Click);
            // 
            // elementHostVolcano
            // 
            this.elementHostVolcano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHostVolcano.Location = new System.Drawing.Point(0, 0);
            this.elementHostVolcano.Name = "elementHostVolcano";
            this.elementHostVolcano.Size = new System.Drawing.Size(882, 469);
            this.elementHostVolcano.TabIndex = 0;
            this.elementHostVolcano.Text = "elementHost3";
            this.elementHostVolcano.Child = null;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonOrchid);
            this.tabPage4.Controls.Add(this.elementHostOrchid);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(882, 469);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Orchid";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonOrchid
            // 
            this.buttonOrchid.Location = new System.Drawing.Point(778, 4);
            this.buttonOrchid.Name = "buttonOrchid";
            this.buttonOrchid.Size = new System.Drawing.Size(75, 23);
            this.buttonOrchid.TabIndex = 1;
            this.buttonOrchid.Text = "button1";
            this.buttonOrchid.UseVisualStyleBackColor = true;
            this.buttonOrchid.Click += new System.EventHandler(this.buttonOrchid_Click);
            // 
            // elementHostOrchid
            // 
            this.elementHostOrchid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHostOrchid.Location = new System.Drawing.Point(0, 0);
            this.elementHostOrchid.Name = "elementHostOrchid";
            this.elementHostOrchid.Size = new System.Drawing.Size(882, 469);
            this.elementHostOrchid.TabIndex = 0;
            this.elementHostOrchid.Text = "elementHost1";
            this.elementHostOrchid.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHostOrchid_ChildChanged);
            this.elementHostOrchid.Child = null;
            // 
            // timerColor
            // 
            this.timerColor.Tick += new System.EventHandler(this.timerColor_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Integration.ElementHost elementHostEggBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Integration.ElementHost elementHostSin;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Integration.ElementHost elementHostVolcano;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Integration.ElementHost elementHostOrchid;
        private System.Windows.Forms.Button buttonEgg;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonVolcano;
        private System.Windows.Forms.Button buttonOrchid;
        private System.Windows.Forms.Timer timerColor;
    }
}

