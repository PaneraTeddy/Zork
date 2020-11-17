namespace ZorkBuilder.Winforms.Controls
{
    partial class NeighborsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.directionTextBox = new System.Windows.Forms.TextBox();
            this.neighborsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // directionTextBox
            // 
            this.directionTextBox.Location = new System.Drawing.Point(0, 0);
            this.directionTextBox.Name = "directionTextBox";
            this.directionTextBox.ReadOnly = true;
            this.directionTextBox.Size = new System.Drawing.Size(121, 20);
            this.directionTextBox.TabIndex = 0;
            this.directionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // neighborsComboBox
            // 
            this.neighborsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.neighborsComboBox.FormattingEnabled = true;
            this.neighborsComboBox.Location = new System.Drawing.Point(0, 26);
            this.neighborsComboBox.Name = "neighborsComboBox";
            this.neighborsComboBox.Size = new System.Drawing.Size(121, 21);
            this.neighborsComboBox.TabIndex = 1;
            this.neighborsComboBox.SelectedIndexChanged += new System.EventHandler(this.NeighborsComboBox_SelectedIndexChanged);
            // 
            // NeighborsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.neighborsComboBox);
            this.Controls.Add(this.directionTextBox);
            this.Name = "NeighborsControl";
            this.Size = new System.Drawing.Size(121, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox directionTextBox;
        private System.Windows.Forms.ComboBox neighborsComboBox;
    }
}
