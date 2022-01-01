
namespace bookme.pk
{
    partial class ParticularHotel
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
            this.labelHotel = new System.Windows.Forms.Label();
            this.labelBeds = new System.Windows.Forms.Label();
            this.labelNoBeds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRooms = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDays = new System.Windows.Forms.Label();
            this.buttonBooking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHotel
            // 
            this.labelHotel.AutoSize = true;
            this.labelHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotel.ForeColor = System.Drawing.Color.Navy;
            this.labelHotel.Location = new System.Drawing.Point(640, 74);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(106, 40);
            this.labelHotel.TabIndex = 0;
            this.labelHotel.Text = "Hotel";
            // 
            // labelBeds
            // 
            this.labelBeds.AutoSize = true;
            this.labelBeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeds.Location = new System.Drawing.Point(526, 184);
            this.labelBeds.Name = "labelBeds";
            this.labelBeds.Size = new System.Drawing.Size(93, 32);
            this.labelBeds.TabIndex = 1;
            this.labelBeds.Text = "Beds:";
            // 
            // labelNoBeds
            // 
            this.labelNoBeds.AutoSize = true;
            this.labelNoBeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoBeds.Location = new System.Drawing.Point(641, 184);
            this.labelNoBeds.Name = "labelNoBeds";
            this.labelNoBeds.Size = new System.Drawing.Size(0, 32);
            this.labelNoBeds.TabIndex = 2;
            this.labelNoBeds.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rooms:";
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRooms.Location = new System.Drawing.Point(641, 274);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(0, 32);
            this.labelRooms.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(526, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Days:";
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDays.Location = new System.Drawing.Point(641, 361);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(0, 32);
            this.labelDays.TabIndex = 6;
            // 
            // buttonBooking
            // 
            this.buttonBooking.BackColor = System.Drawing.Color.Navy;
            this.buttonBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooking.ForeColor = System.Drawing.Color.White;
            this.buttonBooking.Location = new System.Drawing.Point(596, 467);
            this.buttonBooking.Name = "buttonBooking";
            this.buttonBooking.Size = new System.Drawing.Size(183, 53);
            this.buttonBooking.TabIndex = 10;
            this.buttonBooking.Text = "BOOK ME";
            this.buttonBooking.UseVisualStyleBackColor = false;
            // 
            // ParticularHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 640);
            this.Controls.Add(this.buttonBooking);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelRooms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNoBeds);
            this.Controls.Add(this.labelBeds);
            this.Controls.Add(this.labelHotel);
            this.Name = "ParticularHotel";
            this.Text = "ParticularHotel";
            this.Load += new System.EventHandler(this.ParticularHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.Label labelBeds;
        private System.Windows.Forms.Label labelNoBeds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Button buttonBooking;
    }
}