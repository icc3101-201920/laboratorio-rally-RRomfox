namespace VistasRally
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
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarParticipanteButton = new System.Windows.Forms.Button();
            this.PilotNameComboBox = new System.Windows.Forms.ComboBox();
            this.NavigatorNameComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RolComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos a Rally Manager";
            // 
            // AgregarParticipanteButton
            // 
            this.AgregarParticipanteButton.Location = new System.Drawing.Point(219, 357);
            this.AgregarParticipanteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AgregarParticipanteButton.Name = "AgregarParticipanteButton";
            this.AgregarParticipanteButton.Size = new System.Drawing.Size(165, 28);
            this.AgregarParticipanteButton.TabIndex = 1;
            this.AgregarParticipanteButton.Text = "Agregar Participante";
            this.AgregarParticipanteButton.UseVisualStyleBackColor = true;
            this.AgregarParticipanteButton.Click += new System.EventHandler(this.AgregarParticipanteButton_Click);
            // 
            // PilotNameComboBox
            // 
            this.PilotNameComboBox.FormattingEnabled = true;
            this.PilotNameComboBox.Location = new System.Drawing.Point(215, 196);
            this.PilotNameComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PilotNameComboBox.Name = "PilotNameComboBox";
            this.PilotNameComboBox.Size = new System.Drawing.Size(597, 24);
            this.PilotNameComboBox.TabIndex = 3;
            // 
            // NavigatorNameComboBox
            // 
            this.NavigatorNameComboBox.FormattingEnabled = true;
            this.NavigatorNameComboBox.Location = new System.Drawing.Point(215, 196);
            this.NavigatorNameComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NavigatorNameComboBox.Name = "NavigatorNameComboBox";
            this.NavigatorNameComboBox.Size = new System.Drawing.Size(597, 24);
            this.NavigatorNameComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rol";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(329, 254);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(483, 22);
            this.NameTextBox.TabIndex = 6;
            // 
            // RolComboBox
            // 
            this.RolComboBox.FormattingEnabled = true;
            this.RolComboBox.Location = new System.Drawing.Point(329, 290);
            this.RolComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RolComboBox.Name = "RolComboBox";
            this.RolComboBox.Size = new System.Drawing.Size(160, 24);
            this.RolComboBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.RolComboBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PilotNameComboBox);
            this.Controls.Add(this.NavigatorNameComboBox);
            this.Controls.Add(this.AgregarParticipanteButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgregarParticipanteButton;
        private System.Windows.Forms.ComboBox PilotNameComboBox;
        private System.Windows.Forms.ComboBox NavigatorNameComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox RolComboBox;
    }
}

