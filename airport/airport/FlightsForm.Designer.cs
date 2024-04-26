namespace airport
{
    partial class FlightsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.member_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.member_id,
            this.data_time,
            this.from_to,
            this.passengers});
            this.dataGridView1.Location = new System.Drawing.Point(49, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(765, 156);
            this.dataGridView1.TabIndex = 0;
            // 
            // member_id
            // 
            this.member_id.HeaderText = "Номер рейса";
            this.member_id.MinimumWidth = 6;
            this.member_id.Name = "member_id";
            this.member_id.Width = 125;
            // 
            // data_time
            // 
            this.data_time.HeaderText = "Дата и время вылета";
            this.data_time.MinimumWidth = 6;
            this.data_time.Name = "data_time";
            this.data_time.Width = 125;
            // 
            // from_to
            // 
            this.from_to.HeaderText = "откуда и куда";
            this.from_to.MinimumWidth = 6;
            this.from_to.Name = "from_to";
            this.from_to.Width = 125;
            // 
            // passengers
            // 
            this.passengers.HeaderText = "Количество пассажиров";
            this.passengers.MinimumWidth = 6;
            this.passengers.Name = "passengers";
            this.passengers.Width = 125;
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 531);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FlightsForm";
            this.Text = "FlightsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn from_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengers;
    }
}