namespace Mini_gallery
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
            this.components = new System.ComponentModel.Container();
            this.picture_box_0 = new System.Windows.Forms.PictureBox();
            this.picture_box_1 = new System.Windows.Forms.PictureBox();
            this.picture_box_2 = new System.Windows.Forms.PictureBox();
            this.picture_box_3 = new System.Windows.Forms.PictureBox();
            this.image_name_textbox = new System.Windows.Forms.TextBox();
            this.image_name_label = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.random_btn = new System.Windows.Forms.Button();
            this.log_textbox = new System.Windows.Forms.TextBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.generation_btn = new System.Windows.Forms.Button();
            this.image_list = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_3)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_box_0
            // 
            this.picture_box_0.Location = new System.Drawing.Point(74, 61);
            this.picture_box_0.Name = "picture_box_0";
            this.picture_box_0.Size = new System.Drawing.Size(100, 100);
            this.picture_box_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_box_0.TabIndex = 0;
            this.picture_box_0.TabStop = false;
            // 
            // picture_box_1
            // 
            this.picture_box_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_box_1.Location = new System.Drawing.Point(180, 61);
            this.picture_box_1.Name = "picture_box_1";
            this.picture_box_1.Size = new System.Drawing.Size(100, 100);
            this.picture_box_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_box_1.TabIndex = 1;
            this.picture_box_1.TabStop = false;
            // 
            // picture_box_2
            // 
            this.picture_box_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_box_2.Location = new System.Drawing.Point(74, 167);
            this.picture_box_2.Name = "picture_box_2";
            this.picture_box_2.Size = new System.Drawing.Size(100, 100);
            this.picture_box_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_box_2.TabIndex = 2;
            this.picture_box_2.TabStop = false;
            // 
            // picture_box_3
            // 
            this.picture_box_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_box_3.Location = new System.Drawing.Point(180, 167);
            this.picture_box_3.Name = "picture_box_3";
            this.picture_box_3.Size = new System.Drawing.Size(100, 100);
            this.picture_box_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_box_3.TabIndex = 3;
            this.picture_box_3.TabStop = false;
            // 
            // image_name_textbox
            // 
            this.image_name_textbox.Location = new System.Drawing.Point(341, 61);
            this.image_name_textbox.Name = "image_name_textbox";
            this.image_name_textbox.Size = new System.Drawing.Size(100, 22);
            this.image_name_textbox.TabIndex = 4;
            // 
            // image_name_label
            // 
            this.image_name_label.AutoSize = true;
            this.image_name_label.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.image_name_label.Location = new System.Drawing.Point(338, 33);
            this.image_name_label.Name = "image_name_label";
            this.image_name_label.Size = new System.Drawing.Size(120, 16);
            this.image_name_label.TabIndex = 5;
            this.image_name_label.Text = "input image name";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(473, 59);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // random_btn
            // 
            this.random_btn.Location = new System.Drawing.Point(341, 89);
            this.random_btn.Name = "random_btn";
            this.random_btn.Size = new System.Drawing.Size(75, 23);
            this.random_btn.TabIndex = 7;
            this.random_btn.Text = "random";
            this.random_btn.UseVisualStyleBackColor = true;
            this.random_btn.Click += new System.EventHandler(this.random_btn_Click);
            // 
            // log_textbox
            // 
            this.log_textbox.Location = new System.Drawing.Point(341, 118);
            this.log_textbox.Multiline = true;
            this.log_textbox.Name = "log_textbox";
            this.log_textbox.ReadOnly = true;
            this.log_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log_textbox.Size = new System.Drawing.Size(207, 149);
            this.log_textbox.TabIndex = 8;
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(473, 282);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 9;
            this.clear_btn.Text = "clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // generation_btn
            // 
            this.generation_btn.Location = new System.Drawing.Point(473, 320);
            this.generation_btn.Name = "generation_btn";
            this.generation_btn.Size = new System.Drawing.Size(75, 23);
            this.generation_btn.TabIndex = 10;
            this.generation_btn.Text = "generate";
            this.generation_btn.UseVisualStyleBackColor = true;
            this.generation_btn.Click += new System.EventHandler(this.generate_btn_Click);
            // 
            // image_list
            // 
            this.image_list.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.image_list.ImageSize = new System.Drawing.Size(256, 256);
            this.image_list.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 390);
            this.Controls.Add(this.generation_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.log_textbox);
            this.Controls.Add(this.random_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.image_name_label);
            this.Controls.Add(this.image_name_textbox);
            this.Controls.Add(this.picture_box_3);
            this.Controls.Add(this.picture_box_2);
            this.Controls.Add(this.picture_box_1);
            this.Controls.Add(this.picture_box_0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_box_0;
        private System.Windows.Forms.PictureBox picture_box_1;
        private System.Windows.Forms.PictureBox picture_box_2;
        private System.Windows.Forms.PictureBox picture_box_3;
        private System.Windows.Forms.TextBox image_name_textbox;
        private System.Windows.Forms.Label image_name_label;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button random_btn;
        private System.Windows.Forms.TextBox log_textbox;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button generation_btn;
        private System.Windows.Forms.ImageList image_list;
    }
}

