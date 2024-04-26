namespace airport
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FlightButton = new System.Windows.Forms.ToolStripMenuItem();
            this.addFlightButton = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьРейсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientButton = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FlightButton,
            this.ClientsButton,
            this.reportsButton,
            this.settingsButton,
            this.logoutButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FlightButton
            // 
            this.FlightButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFlightButton,
            this.изменитьРейсToolStripMenuItem});
            this.FlightButton.Name = "FlightButton";
            this.FlightButton.Size = new System.Drawing.Size(66, 24);
            this.FlightButton.Text = "Рейсы";
            this.FlightButton.Click += new System.EventHandler(this.FlightButton_Click);
            // 
            // addFlightButton
            // 
            this.addFlightButton.Name = "addFlightButton";
            this.addFlightButton.Size = new System.Drawing.Size(224, 26);
            this.addFlightButton.Text = "Добавить Рейс";
            // 
            // изменитьРейсToolStripMenuItem
            // 
            this.изменитьРейсToolStripMenuItem.Name = "изменитьРейсToolStripMenuItem";
            this.изменитьРейсToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.изменитьРейсToolStripMenuItem.Text = "Изменить Рейс";
            // 
            // ClientsButton
            // 
            this.ClientsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientButton});
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(83, 24);
            this.ClientsButton.Text = "Клиенты";
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // addClientButton
            // 
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(224, 26);
            this.addClientButton.Text = "Добавить клиента";
            // 
            // reportsButton
            // 
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(73, 24);
            this.reportsButton.Text = "Отчеты";
            // 
            // settingsButton
            // 
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(98, 24);
            this.settingsButton.Text = "Настройки";
            // 
            // logoutButton
            // 
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(67, 24);
            this.logoutButton.Text = "Выход";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1168, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FlightButton;
        private System.Windows.Forms.ToolStripMenuItem ClientsButton;
        private System.Windows.Forms.ToolStripMenuItem reportsButton;
        private System.Windows.Forms.ToolStripMenuItem settingsButton;
        private System.Windows.Forms.ToolStripMenuItem logoutButton;
        private System.Windows.Forms.ToolStripMenuItem addFlightButton;
        private System.Windows.Forms.ToolStripMenuItem изменитьРейсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientButton;
    }
}

