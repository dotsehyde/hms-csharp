namespace HMS
{
    partial class MenuItem
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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            paitentToolStripMenuItem1 = new ToolStripMenuItem();
            appointmentToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem1 = new ToolStripMenuItem();
            paitentToolStripMenuItem = new ToolStripMenuItem();
            appointmentsToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem1 = new ToolStripMenuItem();
            dashPanel = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            dashPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, logoutToolStripMenuItem, logoutToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, paitentToolStripMenuItem, appointmentsToolStripMenuItem, inventoryToolStripMenuItem, reportsToolStripMenuItem });
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(96, 24);
            homeToolStripMenuItem.Text = "Dashboard";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { paitentToolStripMenuItem1, appointmentToolStripMenuItem, inventoryToolStripMenuItem1 });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            addToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            addToolStripMenuItem.Size = new Size(224, 26);
            addToolStripMenuItem.Text = "Add";
            // 
            // paitentToolStripMenuItem1
            // 
            paitentToolStripMenuItem1.Name = "paitentToolStripMenuItem1";
            paitentToolStripMenuItem1.Size = new Size(224, 26);
            paitentToolStripMenuItem1.Text = "Paitent";
            // 
            // appointmentToolStripMenuItem
            // 
            appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            appointmentToolStripMenuItem.Size = new Size(224, 26);
            appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // inventoryToolStripMenuItem1
            // 
            inventoryToolStripMenuItem1.Name = "inventoryToolStripMenuItem1";
            inventoryToolStripMenuItem1.Size = new Size(224, 26);
            inventoryToolStripMenuItem1.Text = "Inventory";
            // 
            // paitentToolStripMenuItem
            // 
            paitentToolStripMenuItem.Name = "paitentToolStripMenuItem";
            paitentToolStripMenuItem.Size = new Size(224, 26);
            paitentToolStripMenuItem.Text = "Paitents";
            // 
            // appointmentsToolStripMenuItem
            // 
            appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            appointmentsToolStripMenuItem.Size = new Size(224, 26);
            appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(224, 26);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(224, 26);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(55, 24);
            logoutToolStripMenuItem.Text = "Help";
            // 
            // logoutToolStripMenuItem1
            // 
            logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            logoutToolStripMenuItem1.Size = new Size(70, 24);
            logoutToolStripMenuItem1.Text = "Logout";
            // 
            // dashPanel
            // 
            dashPanel.Controls.Add(label1);
            dashPanel.Location = new Point(46, 50);
            dashPanel.Name = "dashPanel";
            dashPanel.Size = new Size(671, 377);
            dashPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 50);
            label1.Name = "label1";
            label1.Size = new Size(156, 38);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(46, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 377);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(277, 50);
            label2.Name = "label2";
            label2.Size = new Size(117, 38);
            label2.TabIndex = 0;
            label2.Text = "Patients";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(671, 377);
            panel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(277, 50);
            label3.Name = "label3";
            label3.Size = new Size(137, 38);
            label3.TabIndex = 0;
            label3.Text = "Inventory";
            // 
            // MenuItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dashPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuItem";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            dashPanel.ResumeLayout(false);
            dashPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem paitentToolStripMenuItem;
        private ToolStripMenuItem appointmentsToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem paitentToolStripMenuItem1;
        private ToolStripMenuItem inventoryToolStripMenuItem1;
        private ToolStripMenuItem appointmentToolStripMenuItem;
        private Panel dashPanel;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
    }
}