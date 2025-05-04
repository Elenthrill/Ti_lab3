namespace Ti_3
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
            components = new System.ComponentModel.Container();
            tbox_plaintext = new TextBox();
            tbox_ciphertekst = new TextBox();
            tbox_P = new TextBox();
            tbox_K = new TextBox();
            tbox_X = new TextBox();
            tbox_G = new TextBox();
            tbox_ListG = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_Cipher = new Button();
            btn_Decipher = new Button();
            menuStrip1 = new MenuStrip();
            загрузитьФайлToolStripMenuItem = new ToolStripMenuItem();
            label6 = new Label();
            openFileDialog1 = new OpenFileDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btn_find_pervRoots = new Button();
            label7 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbox_plaintext
            // 
            tbox_plaintext.Location = new Point(-3, 377);
            tbox_plaintext.Multiline = true;
            tbox_plaintext.Name = "tbox_plaintext";
            tbox_plaintext.ReadOnly = true;
            tbox_plaintext.ScrollBars = ScrollBars.Horizontal;
            tbox_plaintext.Size = new Size(259, 205);
            tbox_plaintext.TabIndex = 0;
            // 
            // tbox_ciphertekst
            // 
            tbox_ciphertekst.Location = new Point(454, 377);
            tbox_ciphertekst.Multiline = true;
            tbox_ciphertekst.Name = "tbox_ciphertekst";
            tbox_ciphertekst.ReadOnly = true;
            tbox_ciphertekst.ScrollBars = ScrollBars.Horizontal;
            tbox_ciphertekst.Size = new Size(256, 205);
            tbox_ciphertekst.TabIndex = 1;
            // 
            // tbox_P
            // 
            tbox_P.Location = new Point(12, 100);
            tbox_P.Name = "tbox_P";
            tbox_P.Size = new Size(125, 27);
            tbox_P.TabIndex = 2;
            tbox_P.TextChanged += tbox_P_TextChanged;
            // 
            // tbox_K
            // 
            tbox_K.Location = new Point(12, 182);
            tbox_K.Name = "tbox_K";
            tbox_K.Size = new Size(125, 27);
            tbox_K.TabIndex = 3;
            // 
            // tbox_X
            // 
            tbox_X.Location = new Point(12, 248);
            tbox_X.Name = "tbox_X";
            tbox_X.Size = new Size(125, 27);
            tbox_X.TabIndex = 4;
            // 
            // tbox_G
            // 
            tbox_G.Location = new Point(12, 318);
            tbox_G.Name = "tbox_G";
            tbox_G.Size = new Size(125, 27);
            tbox_G.TabIndex = 5;
            // 
            // tbox_ListG
            // 
            tbox_ListG.Location = new Point(409, 248);
            tbox_ListG.Multiline = true;
            tbox_ListG.Name = "tbox_ListG";
            tbox_ListG.ReadOnly = true;
            tbox_ListG.ScrollBars = ScrollBars.Horizontal;
            tbox_ListG.Size = new Size(125, 108);
            tbox_ListG.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 76);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 7;
            label1.Text = "Введите простое число P";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(288, 20);
            label2.TabIndex = 8;
            label2.Text = "Введите чисо k взаимно простое с P - 1 ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 225);
            label3.Name = "label3";
            label3.Size = new Size(286, 20);
            label3.TabIndex = 9;
            label3.Text = "Введите число  X такое что: 1 < X < P - 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 295);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 10;
            label4.Text = "Введите G";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 159);
            label5.Name = "label5";
            label5.Size = new Size(200, 20);
            label5.TabIndex = 11;
            label5.Text = "и в диапозоне от 1 до P - 1 ";
            // 
            // btn_Cipher
            // 
            btn_Cipher.Location = new Point(278, 377);
            btn_Cipher.Name = "btn_Cipher";
            btn_Cipher.Size = new Size(142, 37);
            btn_Cipher.TabIndex = 13;
            btn_Cipher.Text = "Зашифровать";
            btn_Cipher.UseVisualStyleBackColor = true;
            btn_Cipher.Click += btn_Cipher_Click;
            // 
            // btn_Decipher
            // 
            btn_Decipher.Location = new Point(278, 436);
            btn_Decipher.Name = "btn_Decipher";
            btn_Decipher.Size = new Size(142, 37);
            btn_Decipher.TabIndex = 14;
            btn_Decipher.Text = "Расшифровать";
            btn_Decipher.UseVisualStyleBackColor = true;
            btn_Decipher.Click += btn_Decipher_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { загрузитьФайлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(740, 28);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // загрузитьФайлToolStripMenuItem
            // 
            загрузитьФайлToolStripMenuItem.Name = "загрузитьФайлToolStripMenuItem";
            загрузитьФайлToolStripMenuItem.Size = new Size(130, 24);
            загрузитьФайлToolStripMenuItem.Text = "Загрузить файл";
            загрузитьФайлToolStripMenuItem.Click += загрузитьФайлToolStripMenuItem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(395, 182);
            label6.Name = "label6";
            label6.Size = new Size(182, 20);
            label6.TabIndex = 16;
            label6.Text = "Допустимые варианты G";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btn_find_pervRoots
            // 
            btn_find_pervRoots.Location = new Point(395, 215);
            btn_find_pervRoots.Name = "btn_find_pervRoots";
            btn_find_pervRoots.Size = new Size(168, 30);
            btn_find_pervRoots.TabIndex = 17;
            btn_find_pervRoots.Text = "Показать корни";
            btn_find_pervRoots.UseVisualStyleBackColor = true;
            btn_find_pervRoots.Click += btn_find_pervRoots_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(254, 40);
            label7.Name = "label7";
            label7.Size = new Size(166, 20);
            label7.TabIndex = 18;
            label7.Text = "Шифратор Эль Гамаля";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 594);
            Controls.Add(label7);
            Controls.Add(btn_find_pervRoots);
            Controls.Add(label6);
            Controls.Add(btn_Decipher);
            Controls.Add(btn_Cipher);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbox_ListG);
            Controls.Add(tbox_G);
            Controls.Add(tbox_X);
            Controls.Add(tbox_K);
            Controls.Add(tbox_P);
            Controls.Add(tbox_ciphertekst);
            Controls.Add(tbox_plaintext);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Шифр ";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbox_plaintext;
        private TextBox tbox_ciphertekst;
        private TextBox tbox_P;
        private TextBox tbox_K;
        private TextBox tbox_X;
        private TextBox tbox_G;
        private TextBox tbox_ListG;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_Cipher;
        private Button btn_Decipher;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem загрузитьФайлToolStripMenuItem;
        private Label label6;
        private OpenFileDialog openFileDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private Button btn_find_pervRoots;
        private Label label7;
    }
}
