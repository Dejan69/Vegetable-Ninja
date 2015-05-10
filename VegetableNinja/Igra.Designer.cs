namespace VegetableNinja
{
    partial class Igra
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Igra));
            this.progress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.vreme = new System.Windows.Forms.Timer(this.components);
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.SpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.ReduceSpeed = new System.Windows.Forms.Timer(this.components);
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.canvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 386);
            this.progress.Maximum = 60;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(624, 23);
            this.progress.Step = 1;
            this.progress.TabIndex = 4;
            this.progress.Value = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(644, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Преостанати животи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(644, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Време:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Поени:";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(735, 131);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(29, 20);
            this.lbTime.TabIndex = 8;
            this.lbTime.Text = "60";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(745, 184);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(19, 20);
            this.lbScore.TabIndex = 9;
            this.lbScore.Text = "0";
            // 
            // vreme
            // 
            this.vreme.Interval = 1000;
            this.vreme.Tick += new System.EventHandler(this.vreme_Tick);
            // 
            // MoveTimer
            // 
            this.MoveTimer.Interval = 20;
            this.MoveTimer.Tick += new System.EventHandler(this.MoveTimer_Tick);
            // 
            // SpawnTimer
            // 
            this.SpawnTimer.Interval = 20;
            this.SpawnTimer.Tick += new System.EventHandler(this.SpawnTimer_Tick);
            // 
            // ReduceSpeed
            // 
            this.ReduceSpeed.Tick += new System.EventHandler(this.ReduceSpeed_Tick);
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(758, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(50, 50);
            this.pb1.TabIndex = 3;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(702, 12);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(50, 50);
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = global::VegetableNinja.Properties.Resources.X;
            this.pb3.Location = new System.Drawing.Point(646, 12);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(50, 50);
            this.pb3.TabIndex = 1;
            this.pb3.TabStop = false;
            // 
            // canvas
            // 
            this.canvas.Image = global::VegetableNinja.Properties.Resources.Board;
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(624, 368);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // Igra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 436);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.canvas);
            this.MaximumSize = new System.Drawing.Size(830, 475);
            this.MinimumSize = new System.Drawing.Size(830, 475);
            this.Name = "Igra";
            this.Text = "Vegetable Ninja";
            this.Load += new System.EventHandler(this.Igra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer vreme;
        private System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.Timer SpawnTimer;
        private System.Windows.Forms.Timer ReduceSpeed;
    }
}

