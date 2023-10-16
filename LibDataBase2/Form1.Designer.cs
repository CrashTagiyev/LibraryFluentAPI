namespace LibDataBase2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button3 = new Button();
            AuthorsListView = new ListView();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(3, 150);
            button2.Name = "button2";
            button2.Size = new Size(87, 48);
            button2.TabIndex = 17;
            button2.Text = "Add Fake Authors";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(196, 180);
            button3.Name = "button3";
            button3.Size = new Size(87, 48);
            button3.TabIndex = 18;
            button3.Text = "Show the Authors";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AuthorsListView
            // 
            AuthorsListView.AllowColumnReorder = true;
            AuthorsListView.AllowDrop = true;
            AuthorsListView.FullRowSelect = true;
            AuthorsListView.Location = new Point(310, 96);
            AuthorsListView.Name = "AuthorsListView";
            AuthorsListView.Size = new Size(185, 297);
            AuthorsListView.Sorting = SortOrder.Ascending;
            AuthorsListView.TabIndex = 20;
            AuthorsListView.UseCompatibleStateImageBehavior = false;
            AuthorsListView.View = View.Tile;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AuthorsListView);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private ListView AuthorsListView;
    }
}