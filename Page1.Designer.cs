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
			// 
			// buttonLeft
			// 
			this.buttonLeft.ImageSource = "icon-first";
			this.buttonLeft.Location = new System.Drawing.Point(688, 197);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(50, 50);
			this.buttonLeft.TabIndex = 5;
			// 
			// buttonDown
			// 
			this.buttonDown.ImageSource = "scrollbar-arrow-down";
			this.buttonDown.Location = new System.Drawing.Point(738, 253);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(50, 50);
			this.buttonDown.TabIndex = 6;
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonLeft);
			this.Controls.Add(this.buttonRight);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.GameCanvas);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1230, 430);
			((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private Wisej.Web.PictureBox GameCanvas;
		private Wisej.Web.Button buttonUp;
		private Wisej.Web.Button buttonRight;
		private Wisej.Web.Button buttonLeft;
		private Wisej.Web.Button buttonDown;
	}
}

