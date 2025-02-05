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
			this.buttonUp.Location = new System.Drawing.Point(745, 141);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(57, 46);
			this.buttonUp.TabIndex = 1;
			this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.GameCanvas);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1264, 430);
			((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private Wisej.Web.PictureBox GameCanvas;
		private Wisej.Web.Button buttonUp;
	}
}

