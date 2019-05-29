namespace MusicPlayer
{
    partial class f_options
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
            this.b_apply = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.cB_Device = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_Skin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // b_apply
            // 
            this.b_apply.Location = new System.Drawing.Point(12, 220);
            this.b_apply.Name = "b_apply";
            this.b_apply.Size = new System.Drawing.Size(75, 30);
            this.b_apply.TabIndex = 0;
            this.b_apply.Text = "Apply";
            this.b_apply.UseVisualStyleBackColor = true;
            this.b_apply.Click += new System.EventHandler(this.b_apply_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(297, 220);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 30);
            this.b_cancel.TabIndex = 1;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // cB_Device
            // 
            this.cB_Device.DisplayMember = "DirectSound";
            this.cB_Device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Device.FormattingEnabled = true;
            this.cB_Device.Items.AddRange(new object[] {
            "DirectSound",
            "WASAPI"});
            this.cB_Device.Location = new System.Drawing.Point(153, 24);
            this.cB_Device.Name = "cB_Device";
            this.cB_Device.Size = new System.Drawing.Size(121, 21);
            this.cB_Device.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Audio device:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Skin color:";
            // 
            // cB_Skin
            // 
            this.cB_Skin.DisplayMember = "White";
            this.cB_Skin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Skin.FormattingEnabled = true;
            this.cB_Skin.Items.AddRange(new object[] {
            "White",
            "Yellow",
            "Red",
            "Blue"});
            this.cB_Skin.Location = new System.Drawing.Point(153, 70);
            this.cB_Skin.Name = "cB_Skin";
            this.cB_Skin.Size = new System.Drawing.Size(121, 21);
            this.cB_Skin.TabIndex = 4;
            // 
            // f_options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cB_Skin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_Device);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_apply);
            this.Name = "f_options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_apply;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cB_Device;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cB_Skin;
    }
}