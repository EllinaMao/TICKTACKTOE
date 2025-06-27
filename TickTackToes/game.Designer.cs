namespace TickTackToes
{
    partial class TickTackToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TickTackToe));
            tableLayoutPanel2 = new TableLayoutPanel();
            button5 = new Button();
            button8 = new Button();
            button9 = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            panel1 = new Panel();
            exit = new Button();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(button5, 1, 1);
            tableLayoutPanel2.Controls.Add(button8, 1, 2);
            tableLayoutPanel2.Controls.Add(button9, 2, 2);
            tableLayoutPanel2.Controls.Add(button3, 2, 0);
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Controls.Add(button4, 0, 1);
            tableLayoutPanel2.Controls.Add(button6, 2, 1);
            tableLayoutPanel2.Controls.Add(button7, 0, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            resources.ApplyResources(button5, "button5");
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += MyButton_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            resources.ApplyResources(button8, "button8");
            button8.Name = "button8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += MyButton_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            resources.ApplyResources(button9, "button9");
            button9.Name = "button9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += MyButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += MyButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += MyButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += MyButton_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += MyButton_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            resources.ApplyResources(button6, "button6");
            button6.Name = "button6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += MyButton_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            resources.ApplyResources(button7, "button7");
            button7.Name = "button7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += MyButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(exit);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // exit
            // 
            exit.BackColor = Color.Red;
            resources.ApplyResources(exit, "exit");
            exit.ForeColor = SystemColors.ControlLightLight;
            exit.Name = "exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += ExitButton_Click;
            // 
            // TickTackToe
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel2);
            Name = "TickTackToe";
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        
        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button button5;
        private Button button8;
        private Button button9;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button6;
        private Button button7;
        private Panel panel1;
        private Button exit;
    }
}
