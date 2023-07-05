namespace MissionPlanner
{
    partial class Imagef
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.waypoints = new System.Windows.Forms.Button();
            this.nxtbut = new System.Windows.Forms.Button();
            this.prvbut = new System.Windows.Forms.Button();
            this.rembut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.98206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.01794F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 259F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 27);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.56772F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.43228F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(955, 427);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // waypoints
            // 
            this.waypoints.BackColor = System.Drawing.Color.YellowGreen;
            this.waypoints.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.waypoints.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waypoints.Location = new System.Drawing.Point(37, 484);
            this.waypoints.Margin = new System.Windows.Forms.Padding(4);
            this.waypoints.Name = "waypoints";
            this.waypoints.Size = new System.Drawing.Size(176, 46);
            this.waypoints.TabIndex = 6;
            this.waypoints.Text = "Waypoints";
            this.waypoints.UseVisualStyleBackColor = false;
            this.waypoints.Click += new System.EventHandler(this.waypoints_Click);
            // 
            // nxtbut
            // 
            this.nxtbut.BackColor = System.Drawing.Color.YellowGreen;
            this.nxtbut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nxtbut.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxtbut.Location = new System.Drawing.Point(803, 484);
            this.nxtbut.Margin = new System.Windows.Forms.Padding(4);
            this.nxtbut.Name = "nxtbut";
            this.nxtbut.Size = new System.Drawing.Size(176, 46);
            this.nxtbut.TabIndex = 7;
            this.nxtbut.Text = "Next";
            this.nxtbut.UseVisualStyleBackColor = false;
            this.nxtbut.Click += new System.EventHandler(this.nxtbut_Click);
            // 
            // prvbut
            // 
            this.prvbut.BackColor = System.Drawing.Color.YellowGreen;
            this.prvbut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prvbut.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prvbut.Location = new System.Drawing.Point(610, 484);
            this.prvbut.Margin = new System.Windows.Forms.Padding(4);
            this.prvbut.Name = "prvbut";
            this.prvbut.Size = new System.Drawing.Size(176, 46);
            this.prvbut.TabIndex = 8;
            this.prvbut.Text = "Previous";
            this.prvbut.UseVisualStyleBackColor = false;
            this.prvbut.Click += new System.EventHandler(this.prvbut_Click);
            // 
            // rembut
            // 
            this.rembut.BackColor = System.Drawing.Color.YellowGreen;
            this.rembut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rembut.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rembut.Location = new System.Drawing.Point(416, 484);
            this.rembut.Margin = new System.Windows.Forms.Padding(4);
            this.rembut.Name = "rembut";
            this.rembut.Size = new System.Drawing.Size(176, 46);
            this.rembut.TabIndex = 9;
            this.rembut.Text = "Remove";
            this.rembut.UseVisualStyleBackColor = false;
            this.rembut.Visible = false;
            this.rembut.Click += new System.EventHandler(this.rembut_Click);
            // 
            // Imagef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1004, 552);
            this.Controls.Add(this.rembut);
            this.Controls.Add(this.prvbut);
            this.Controls.Add(this.nxtbut);
            this.Controls.Add(this.waypoints);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Imagef";
            this.Text = "Thumbnails";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button waypoints;
        private System.Windows.Forms.Button nxtbut;
        private System.Windows.Forms.Button prvbut;
        private System.Windows.Forms.Button rembut;
    }
}