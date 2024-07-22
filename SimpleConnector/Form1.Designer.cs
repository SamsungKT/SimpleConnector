namespace SimpleConnector
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.radioCustom = new System.Windows.Forms.RadioButton();
            this.radio1280 = new System.Windows.Forms.RadioButton();
            this.radio640 = new System.Windows.Forms.RadioButton();
            this.radioFull = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.radioLocal = new System.Windows.Forms.RadioButton();
            this.radioRemote = new System.Windows.Forms.RadioButton();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textRemoteIp = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textHeight);
            this.groupBox1.Controls.Add(this.textWidth);
            this.groupBox1.Controls.Add(this.radioCustom);
            this.groupBox1.Controls.Add(this.radio1280);
            this.groupBox1.Controls.Add(this.radio640);
            this.groupBox1.Controls.Add(this.radioFull);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "화면설정";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "높이";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "넓이";
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(161, 256);
            this.textHeight.Name = "textHeight";
            this.textHeight.ReadOnly = true;
            this.textHeight.Size = new System.Drawing.Size(64, 38);
            this.textHeight.TabIndex = 5;
            this.textHeight.Text = "600";
            this.textHeight.TextChanged += new System.EventHandler(this.textHeight_TextChanged);
            // 
            // textWidth
            // 
            this.textWidth.Location = new System.Drawing.Point(161, 212);
            this.textWidth.Name = "textWidth";
            this.textWidth.ReadOnly = true;
            this.textWidth.Size = new System.Drawing.Size(64, 38);
            this.textWidth.TabIndex = 4;
            this.textWidth.Text = "800";
            this.textWidth.TextChanged += new System.EventHandler(this.textWidth_TextChanged);
            // 
            // radioCustom
            // 
            this.radioCustom.AutoSize = true;
            this.radioCustom.Location = new System.Drawing.Point(44, 160);
            this.radioCustom.Name = "radioCustom";
            this.radioCustom.Size = new System.Drawing.Size(218, 35);
            this.radioCustom.TabIndex = 3;
            this.radioCustom.Text = "창모드(사용자설정)";
            this.radioCustom.UseVisualStyleBackColor = true;
            this.radioCustom.Click += new System.EventHandler(this.radioCustom_Click);
            // 
            // radio1280
            // 
            this.radio1280.AutoSize = true;
            this.radio1280.Location = new System.Drawing.Point(44, 119);
            this.radio1280.Name = "radio1280";
            this.radio1280.Size = new System.Drawing.Size(231, 35);
            this.radio1280.TabIndex = 2;
            this.radio1280.Text = "창모드(1280x960)";
            this.radio1280.UseVisualStyleBackColor = true;
            this.radio1280.Click += new System.EventHandler(this.radio1280_Click);
            // 
            // radio640
            // 
            this.radio640.AutoSize = true;
            this.radio640.Location = new System.Drawing.Point(44, 78);
            this.radio640.Name = "radio640";
            this.radio640.Size = new System.Drawing.Size(216, 35);
            this.radio640.TabIndex = 1;
            this.radio640.Text = "창모드(640x480)";
            this.radio640.UseVisualStyleBackColor = true;
            this.radio640.Click += new System.EventHandler(this.radio640_Click);
            // 
            // radioFull
            // 
            this.radioFull.AutoSize = true;
            this.radioFull.Checked = true;
            this.radioFull.Location = new System.Drawing.Point(44, 37);
            this.radioFull.Name = "radioFull";
            this.radioFull.Size = new System.Drawing.Size(116, 35);
            this.radioFull.TabIndex = 0;
            this.radioFull.TabStop = true;
            this.radioFull.Text = "전체화면";
            this.radioFull.UseVisualStyleBackColor = true;
            this.radioFull.Click += new System.EventHandler(this.radioFull_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textLocalIp);
            this.groupBox2.Controls.Add(this.radioLocal);
            this.groupBox2.Controls.Add(this.radioRemote);
            this.groupBox2.Controls.Add(this.textPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textRemoteIp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(353, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "서버설정";
            // 
            // textLocalIp
            // 
            this.textLocalIp.Location = new System.Drawing.Point(148, 90);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.ReadOnly = true;
            this.textLocalIp.Size = new System.Drawing.Size(236, 38);
            this.textLocalIp.TabIndex = 6;
            this.textLocalIp.Text = "127.0.0.1";
            // 
            // radioLocal
            // 
            this.radioLocal.AutoSize = true;
            this.radioLocal.Location = new System.Drawing.Point(15, 91);
            this.radioLocal.Name = "radioLocal";
            this.radioLocal.Size = new System.Drawing.Size(97, 35);
            this.radioLocal.TabIndex = 5;
            this.radioLocal.Text = "Local";
            this.radioLocal.UseVisualStyleBackColor = true;
            // 
            // radioRemote
            // 
            this.radioRemote.AutoSize = true;
            this.radioRemote.Checked = true;
            this.radioRemote.Location = new System.Drawing.Point(15, 46);
            this.radioRemote.Name = "radioRemote";
            this.radioRemote.Size = new System.Drawing.Size(127, 35);
            this.radioRemote.TabIndex = 4;
            this.radioRemote.TabStop = true;
            this.radioRemote.Text = "Remote";
            this.radioRemote.UseVisualStyleBackColor = true;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(148, 162);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(236, 38);
            this.textPort.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "PORT";
            // 
            // textRemoteIp
            // 
            this.textRemoteIp.Location = new System.Drawing.Point(148, 46);
            this.textRemoteIp.Name = "textRemoteIp";
            this.textRemoteIp.Size = new System.Drawing.Size(236, 38);
            this.textRemoteIp.TabIndex = 0;
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.Location = new System.Drawing.Point(381, 268);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(157, 51);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "서버접속하기";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_home
            // 
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(585, 268);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(152, 51);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "홈페이지가기";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 354);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SimpleConnector 20240722";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.RadioButton radioCustom;
        private System.Windows.Forms.RadioButton radio1280;
        private System.Windows.Forms.RadioButton radio640;
        private System.Windows.Forms.RadioButton radioFull;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textRemoteIp;
        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.RadioButton radioLocal;
        private System.Windows.Forms.RadioButton radioRemote;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_home;
    }
}

