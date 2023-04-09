namespace UmlDiagramme
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
            pictureBoxDiagram = new PictureBox();
            listBoxUmlTypes = new ListBox();
            btnConfirm = new Button();
            lblTitle = new Label();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDiagram).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxDiagram
            // 
            pictureBoxDiagram.Location = new Point(30, 120);
            pictureBoxDiagram.Margin = new Padding(6);
            pictureBoxDiagram.Name = "pictureBoxDiagram";
            pictureBoxDiagram.Size = new Size(829, 538);
            pictureBoxDiagram.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDiagram.TabIndex = 0;
            pictureBoxDiagram.TabStop = false;
            // 
            // listBoxUmlTypes
            // 
            listBoxUmlTypes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listBoxUmlTypes.BackColor = Color.FromArgb(45, 45, 48);
            listBoxUmlTypes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxUmlTypes.ForeColor = Color.FromArgb(241, 241, 241);
            listBoxUmlTypes.FormattingEnabled = true;
            listBoxUmlTypes.ItemHeight = 21;
            listBoxUmlTypes.Location = new Point(1050, 66);
            listBoxUmlTypes.Margin = new Padding(6);
            listBoxUmlTypes.Name = "listBoxUmlTypes";
            listBoxUmlTypes.Size = new Size(300, 697);
            listBoxUmlTypes.TabIndex = 1;
            listBoxUmlTypes.SelectedIndexChanged += listBoxUmlTypes_SelectedIndexChanged;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnConfirm.BackColor = Color.FromArgb(63, 81, 181);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(1050, 810);
            btnConfirm.Margin = new Padding(6);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(300, 50);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Bestätigen";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(154, 106, 255);
            lblTitle.Location = new Point(30, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(350, 45);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "UML Ultimate Teacher";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(1050, 870);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 25);
            lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 38);
            ClientSize = new Size(1434, 928);
            Controls.Add(btnConfirm);
            Controls.Add(listBoxUmlTypes);
            Controls.Add(pictureBoxDiagram);
            Controls.Add(lblResult);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "UML-Diagramm-Quiz";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDiagram).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private PictureBox pictureBoxDiagram;
        private ListBox listBoxUmlTypes;
        private Button btnConfirm;
        private Label lblTitle;
        private Label lblResult;
    }
}