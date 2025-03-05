namespace Game
{
    partial class Page1
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

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.GameCanvas = new Wisej.Web.PictureBox();
			this.buttonUp = new Wisej.Web.Button();
			this.buttonRight = new Wisej.Web.Button();
			this.buttonLeft = new Wisej.Web.Button();
			this.buttonDown = new Wisej.Web.Button();
			this.label1 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			this.ShootUp = new Wisej.Web.Button();
			this.ShootRight = new Wisej.Web.Button();
			this.ShootLeft = new Wisej.Web.Button();
			this.ShootDown = new Wisej.Web.Button();
			((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).BeginInit();
			this.SuspendLayout();
			// 
			// GameCanvas
			// 
			this.GameCanvas.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.GameCanvas.Location = new System.Drawing.Point(3, 3);
			this.GameCanvas.Name = "GameCanvas";
			this.GameCanvas.Size = new System.Drawing.Size(640, 480);
			this.GameCanvas.Paint += new Wisej.Web.PaintEventHandler(this.GameCanvas_Paint);
			// 
			// buttonUp
			// 
			this.buttonUp.ImageSource = "scrollbar-arrow-up";
			this.buttonUp.Location = new System.Drawing.Point(738, 141);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(50, 50);
			this.buttonUp.TabIndex = 1;
			this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
			// 
			// buttonRight
			// 
			this.buttonRight.ImageSource = "icon-last";
			this.buttonRight.Location = new System.Drawing.Point(787, 197);
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size(50, 50);
			this.buttonRight.TabIndex = 3;
			this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
			// 
			// buttonLeft
			// 
			this.buttonLeft.ImageSource = "icon-first";
			this.buttonLeft.Location = new System.Drawing.Point(688, 197);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(50, 50);
			this.buttonLeft.TabIndex = 5;
			this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
			// 
			// buttonDown
			// 
			this.buttonDown.ImageSource = "scrollbar-arrow-down";
			this.buttonDown.Location = new System.Drawing.Point(738, 253);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(50, 50);
			this.buttonDown.TabIndex = 6;
			this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(738, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 15);
			this.label1.TabIndex = 8;
			this.label1.Text = "Move";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(985, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 15);
			this.label2.TabIndex = 9;
			this.label2.Text = "Shoot";
			// 
			// ShootUp
			// 
			this.ShootUp.ImageSource = "scrollbar-arrow-up";
			this.ShootUp.Location = new System.Drawing.Point(985, 132);
			this.ShootUp.Name = "ShootUp";
			this.ShootUp.Size = new System.Drawing.Size(50, 50);
			this.ShootUp.TabIndex = 10;
			// 
			// ShootRight
			// 
			this.ShootRight.ImageSource = "icon-last";
			this.ShootRight.Location = new System.Drawing.Point(1035, 188);
			this.ShootRight.Name = "ShootRight";
			this.ShootRight.Size = new System.Drawing.Size(50, 50);
			this.ShootRight.TabIndex = 11;
			// 
			// ShootLeft
			// 
			this.ShootLeft.ImageSource = "icon-first";
			this.ShootLeft.Location = new System.Drawing.Point(937, 188);
			this.ShootLeft.Name = "ShootLeft";
			this.ShootLeft.Size = new System.Drawing.Size(50, 50);
			this.ShootLeft.TabIndex = 12;
			// 
			// ShootDown
			// 
			this.ShootDown.ImageSource = "scrollbar-arrow-down";
			this.ShootDown.Location = new System.Drawing.Point(985, 244);
			this.ShootDown.Name = "ShootDown";
			this.ShootDown.Size = new System.Drawing.Size(50, 50);
			this.ShootDown.TabIndex = 13;
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.ShootDown);
			this.Controls.Add(this.ShootLeft);
			this.Controls.Add(this.ShootRight);
			this.Controls.Add(this.ShootUp);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonLeft);
			this.Controls.Add(this.buttonRight);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.GameCanvas);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1154, 594);
			((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Wisej.Web.PictureBox GameCanvas;
		private Wisej.Web.Button buttonUp;
		private Wisej.Web.Button buttonRight;
		private Wisej.Web.Button buttonLeft;
		private Wisej.Web.Button buttonDown;
		private Wisej.Web.Label label1;
		private Wisej.Web.Label label2;
		private Wisej.Web.Button ShootUp;
		private Wisej.Web.Button ShootRight;
		private Wisej.Web.Button ShootLeft;
		private Wisej.Web.Button ShootDown;
	}
}

