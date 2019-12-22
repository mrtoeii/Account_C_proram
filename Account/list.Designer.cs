namespace Account
{
    partial class list
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sub_llist_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lists_View = new System.Windows.Forms.ListView();
            this.column_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_lists = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.sub_llist_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 79);
            this.panel1.TabIndex = 0;
            // 
            // sub_llist_panel
            // 
            this.sub_llist_panel.BackColor = System.Drawing.SystemColors.Control;
            this.sub_llist_panel.Controls.Add(this.lists_View);
            this.sub_llist_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sub_llist_panel.Location = new System.Drawing.Point(0, 79);
            this.sub_llist_panel.Name = "sub_llist_panel";
            this.sub_llist_panel.Size = new System.Drawing.Size(995, 611);
            this.sub_llist_panel.TabIndex = 1;
            this.sub_llist_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sub_llist_panel_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(922, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lists_View
            // 
            this.lists_View.AutoArrange = false;
            this.lists_View.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_date,
            this.column_lists,
            this.column_amount,
            this.column_description,
            this.column_type});
            this.lists_View.GridLines = true;
            this.lists_View.HideSelection = false;
            this.lists_View.Location = new System.Drawing.Point(18, 22);
            this.lists_View.Name = "lists_View";
            this.lists_View.Size = new System.Drawing.Size(957, 568);
            this.lists_View.TabIndex = 0;
            this.lists_View.UseCompatibleStateImageBehavior = false;
            this.lists_View.View = System.Windows.Forms.View.Details;
            this.lists_View.SelectedIndexChanged += new System.EventHandler(this.list_Load);
            // 
            // column_date
            // 
            this.column_date.Text = "Date";
            this.column_date.Width = 176;
            // 
            // column_lists
            // 
            this.column_lists.Text = "List";
            this.column_lists.Width = 144;
            // 
            // column_amount
            // 
            this.column_amount.Text = "Amount";
            this.column_amount.Width = 112;
            // 
            // column_description
            // 
            this.column_description.Text = "Description\t";
            this.column_description.Width = 113;
            // 
            // column_type
            // 
            this.column_type.Text = "Type";
            this.column_type.Width = 268;
            // 
            // list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.sub_llist_panel);
            this.Controls.Add(this.panel1);
            this.Name = "list";
            this.Size = new System.Drawing.Size(995, 690);
            this.Load += new System.EventHandler(this.list_Load);
            this.panel1.ResumeLayout(false);
            this.sub_llist_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel sub_llist_panel;
        private System.Windows.Forms.ListView lists_View;
        private System.Windows.Forms.ColumnHeader column_date;
        private System.Windows.Forms.ColumnHeader column_lists;
        private System.Windows.Forms.ColumnHeader column_amount;
        private System.Windows.Forms.ColumnHeader column_description;
        private System.Windows.Forms.ColumnHeader column_type;
    }
}
