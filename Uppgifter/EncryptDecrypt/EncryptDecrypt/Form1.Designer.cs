namespace EncryptDecrypt
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.check_Decrypt = new System.Windows.Forms.CheckBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.group_Input = new System.Windows.Forms.GroupBox();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.label_key = new System.Windows.Forms.Label();
            this.group_Output = new System.Windows.Forms.GroupBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.group_Input.SuspendLayout();
            this.group_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(18, 19);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(292, 155);
            this.textBox_input.TabIndex = 0;
            // 
            // check_Decrypt
            // 
            this.check_Decrypt.AutoSize = true;
            this.check_Decrypt.Location = new System.Drawing.Point(241, 184);
            this.check_Decrypt.Name = "check_Decrypt";
            this.check_Decrypt.Size = new System.Drawing.Size(69, 17);
            this.check_Decrypt.TabIndex = 1;
            this.check_Decrypt.Text = "Decrypt?";
            this.check_Decrypt.UseVisualStyleBackColor = true;
            this.check_Decrypt.CheckedChanged += new System.EventHandler(this.check_Decrypt_CheckedChanged);
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(18, 207);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(292, 23);
            this.button_Submit.TabIndex = 2;
            this.button_Submit.Text = "Encrypt!";
            this.button_Submit.UseVisualStyleBackColor = true;
            // 
            // group_Input
            // 
            this.group_Input.Controls.Add(this.label_key);
            this.group_Input.Controls.Add(this.textBox_key);
            this.group_Input.Controls.Add(this.textBox_input);
            this.group_Input.Controls.Add(this.button_Submit);
            this.group_Input.Controls.Add(this.check_Decrypt);
            this.group_Input.Location = new System.Drawing.Point(16, 12);
            this.group_Input.Name = "group_Input";
            this.group_Input.Size = new System.Drawing.Size(326, 246);
            this.group_Input.TabIndex = 3;
            this.group_Input.TabStop = false;
            this.group_Input.Text = "Input";
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(45, 182);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(190, 20);
            this.textBox_key.TabIndex = 3;
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Location = new System.Drawing.Point(18, 184);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(28, 13);
            this.label_key.TabIndex = 4;
            this.label_key.Text = "Key:";
            // 
            // group_Output
            // 
            this.group_Output.Controls.Add(this.textBox_output);
            this.group_Output.Location = new System.Drawing.Point(381, 12);
            this.group_Output.Name = "group_Output";
            this.group_Output.Size = new System.Drawing.Size(313, 246);
            this.group_Output.TabIndex = 4;
            this.group_Output.TabStop = false;
            this.group_Output.Text = "Output";
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(18, 20);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ReadOnly = true;
            this.textBox_output.Size = new System.Drawing.Size(277, 210);
            this.textBox_output.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 282);
            this.Controls.Add(this.group_Output);
            this.Controls.Add(this.group_Input);
            this.Name = "Form1";
            this.Text = "Encrypt or decrypt";
            this.group_Input.ResumeLayout(false);
            this.group_Input.PerformLayout();
            this.group_Output.ResumeLayout(false);
            this.group_Output.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.CheckBox check_Decrypt;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.GroupBox group_Input;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.GroupBox group_Output;
        private System.Windows.Forms.TextBox textBox_output;
    }
}

