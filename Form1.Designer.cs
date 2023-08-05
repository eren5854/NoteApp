namespace NoteApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlNavi = new Panel();
            label1 = new Label();
            btnMinus = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            txtUserName = new TextBox();
            loginBox = new GroupBox();
            btnLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            panel1 = new Panel();
            panel8 = new Panel();
            btnLogout = new Button();
            btnDelete = new Button();
            btnLstClear = new Button();
            panel10 = new Panel();
            btnExport = new Button();
            btnList = new Button();
            btnSave = new Button();
            panel11 = new Panel();
            btnGithub = new Button();
            btnLinkedin = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            lstNote = new ListBox();
            panel7 = new Panel();
            txtNote = new TextBox();
            panel5 = new Panel();
            label4 = new Label();
            panel6 = new Panel();
            panel9 = new Panel();
            pnlNavi.SuspendLayout();
            loginBox.SuspendLayout();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel11.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNavi
            // 
            pnlNavi.BackColor = Color.FromArgb(101, 40, 247);
            pnlNavi.Controls.Add(label1);
            pnlNavi.Controls.Add(btnMinus);
            pnlNavi.Controls.Add(btnMaximize);
            pnlNavi.Controls.Add(btnClose);
            pnlNavi.Dock = DockStyle.Top;
            pnlNavi.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pnlNavi.Location = new Point(0, 0);
            pnlNavi.Name = "pnlNavi";
            pnlNavi.Size = new Size(600, 35);
            pnlNavi.TabIndex = 0;
            pnlNavi.Paint += pnlNavi_Paint;
            pnlNavi.MouseDown += pnlNavi_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(237, 228, 255);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(232, 27);
            label1.TabIndex = 2;
            label1.Text = "Not Defteri Uygulaması";
            // 
            // btnMinus
            // 
            btnMinus.BackgroundImage = (Image)resources.GetObject("btnMinus.BackgroundImage");
            btnMinus.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinus.Dock = DockStyle.Right;
            btnMinus.FlatAppearance.BorderSize = 0;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Location = new Point(495, 0);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(35, 35);
            btnMinus.TabIndex = 1;
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.BackgroundImage = (Image)resources.GetObject("btnMaximize.BackgroundImage");
            btnMaximize.BackgroundImageLayout = ImageLayout.Stretch;
            btnMaximize.Dock = DockStyle.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Location = new Point(530, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(35, 35);
            btnMaximize.TabIndex = 1;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(565, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(122, 22);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(136, 29);
            txtUserName.TabIndex = 1;
            // 
            // loginBox
            // 
            loginBox.Controls.Add(btnLogin);
            loginBox.Controls.Add(label2);
            loginBox.Controls.Add(label3);
            loginBox.Controls.Add(txtPassword);
            loginBox.Controls.Add(txtUserName);
            loginBox.Dock = DockStyle.Left;
            loginBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginBox.ForeColor = Color.FromArgb(55, 208, 238);
            loginBox.Location = new Point(0, 0);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(264, 129);
            loginBox.TabIndex = 2;
            loginBox.TabStop = false;
            loginBox.Text = "Giriş";
            // 
            // btnLogin
            // 
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(147, 92);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(81, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Giriş ";
            btnLogin.TextAlign = ContentAlignment.MiddleRight;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(55, 208, 238);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(6, 25);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 2;
            label2.Text = "    Kullanıcı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(55, 208, 238);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(6, 60);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 4;
            label3.Text = "    Şifre:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(122, 57);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(136, 29);
            txtPassword.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(160, 118, 249);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel11);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 365);
            panel1.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnLogout);
            panel8.Controls.Add(btnDelete);
            panel8.Controls.Add(btnLstClear);
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(btnExport);
            panel8.Controls.Add(btnList);
            panel8.Controls.Add(btnSave);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(50, 249);
            panel8.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(12, 211);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(32, 32);
            btnLogout.TabIndex = 11;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(12, 173);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(32, 32);
            btnDelete.TabIndex = 10;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLstClear
            // 
            btnLstClear.BackgroundImage = (Image)resources.GetObject("btnLstClear.BackgroundImage");
            btnLstClear.BackgroundImageLayout = ImageLayout.Stretch;
            btnLstClear.FlatAppearance.BorderSize = 0;
            btnLstClear.FlatStyle = FlatStyle.Flat;
            btnLstClear.Location = new Point(12, 135);
            btnLstClear.Name = "btnLstClear";
            btnLstClear.Size = new Size(32, 32);
            btnLstClear.TabIndex = 9;
            btnLstClear.UseVisualStyleBackColor = true;
            btnLstClear.Click += btnLstClear_Click;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(50, 15);
            panel10.TabIndex = 8;
            // 
            // btnExport
            // 
            btnExport.BackgroundImage = (Image)resources.GetObject("btnExport.BackgroundImage");
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.ForeColor = Color.FromArgb(160, 118, 249);
            btnExport.Location = new Point(12, 97);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(32, 32);
            btnExport.TabIndex = 7;
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            btnList.BackgroundImage = (Image)resources.GetObject("btnList.BackgroundImage");
            btnList.BackgroundImageLayout = ImageLayout.Stretch;
            btnList.FlatAppearance.BorderSize = 0;
            btnList.FlatStyle = FlatStyle.Flat;
            btnList.ForeColor = Color.FromArgb(160, 118, 249);
            btnList.Location = new Point(12, 59);
            btnList.Name = "btnList";
            btnList.Size = new Size(32, 32);
            btnList.TabIndex = 6;
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.FlatAppearance.BorderColor = Color.Black;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.FromArgb(160, 118, 249);
            btnSave.Location = new Point(12, 21);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(32, 32);
            btnSave.TabIndex = 5;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnGithub);
            panel11.Controls.Add(btnLinkedin);
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(0, 255);
            panel11.Name = "panel11";
            panel11.Size = new Size(50, 110);
            panel11.TabIndex = 13;
            // 
            // btnGithub
            // 
            btnGithub.BackgroundImage = (Image)resources.GetObject("btnGithub.BackgroundImage");
            btnGithub.BackgroundImageLayout = ImageLayout.Stretch;
            btnGithub.FlatAppearance.BorderSize = 0;
            btnGithub.FlatStyle = FlatStyle.Flat;
            btnGithub.Location = new Point(12, 28);
            btnGithub.Name = "btnGithub";
            btnGithub.Size = new Size(32, 32);
            btnGithub.TabIndex = 11;
            btnGithub.UseVisualStyleBackColor = true;
            btnGithub.Click += btnGithub_Click;
            // 
            // btnLinkedin
            // 
            btnLinkedin.BackgroundImage = (Image)resources.GetObject("btnLinkedin.BackgroundImage");
            btnLinkedin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLinkedin.FlatAppearance.BorderSize = 0;
            btnLinkedin.FlatStyle = FlatStyle.Flat;
            btnLinkedin.Location = new Point(12, 66);
            btnLinkedin.Name = "btnLinkedin";
            btnLinkedin.Size = new Size(32, 32);
            btnLinkedin.TabIndex = 12;
            btnLinkedin.UseVisualStyleBackColor = true;
            btnLinkedin.Click += btnLinkedin_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(loginBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(60, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 129);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(50, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 365);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(lstNote);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(txtNote);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(60, 164);
            panel4.Name = "panel4";
            panel4.Size = new Size(530, 336);
            panel4.TabIndex = 6;
            // 
            // lstNote
            // 
            lstNote.Dock = DockStyle.Top;
            lstNote.FormattingEnabled = true;
            lstNote.ItemHeight = 15;
            lstNote.Location = new Point(0, 78);
            lstNote.Name = "lstNote";
            lstNote.Size = new Size(530, 244);
            lstNote.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 68);
            panel7.Name = "panel7";
            panel7.Size = new Size(530, 10);
            panel7.TabIndex = 4;
            // 
            // txtNote
            // 
            txtNote.Dock = DockStyle.Top;
            txtNote.Location = new Point(0, 45);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(530, 23);
            txtNote.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 35);
            panel5.Name = "panel5";
            panel5.Size = new Size(530, 10);
            panel5.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(101, 84, 175);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(0, 10);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 2;
            label4.Text = "      Not:";
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(530, 10);
            panel6.TabIndex = 4;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Right;
            panel9.Location = new Point(590, 164);
            panel9.Name = "panel9";
            panel9.Size = new Size(10, 236);
            panel9.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 39, 48);
            ClientSize = new Size(600, 400);
            Controls.Add(panel4);
            Controls.Add(panel9);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pnlNavi);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            pnlNavi.ResumeLayout(false);
            pnlNavi.PerformLayout();
            loginBox.ResumeLayout(false);
            loginBox.PerformLayout();
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNavi;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinus;
        private Label label1;
        private TextBox txtUserName;
        private GroupBox loginBox;
        private Label label3;
        private TextBox txtPassword;
        private Label label2;
        private Panel panel1;
        private Button btnLogin;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private TextBox txtNote;
        private ListBox lstNote;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Button btnExport;
        private Button btnList;
        private Button btnSave;
        private Button btnDelete;
        private Button btnLstClear;
        private Button btnLinkedin;
        private Button btnGithub;
        private Panel panel11;
        private Button btnLogout;
    }
}