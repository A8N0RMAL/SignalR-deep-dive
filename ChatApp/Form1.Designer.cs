namespace ChatApp
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
            lb_messages = new ListBox();
            txt_name = new TextBox();
            txt_message = new TextBox();
            txt_group = new TextBox();
            btn_send = new Button();
            btn_sendgroup = new Button();
            btn_join = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lb_messages
            // 
            lb_messages.FormattingEnabled = true;
            lb_messages.Location = new Point(126, 263);
            lb_messages.Name = "lb_messages";
            lb_messages.Size = new Size(362, 204);
            lb_messages.TabIndex = 0;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(126, 25);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 27);
            txt_name.TabIndex = 1;
            // 
            // txt_message
            // 
            txt_message.Location = new Point(126, 83);
            txt_message.Name = "txt_message";
            txt_message.Size = new Size(125, 27);
            txt_message.TabIndex = 2;
            // 
            // txt_group
            // 
            txt_group.Location = new Point(126, 142);
            txt_group.Name = "txt_group";
            txt_group.Size = new Size(125, 27);
            txt_group.TabIndex = 3;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(278, 81);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(94, 29);
            btn_send.TabIndex = 4;
            btn_send.Text = "send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // btn_sendgroup
            // 
            btn_sendgroup.Location = new Point(126, 199);
            btn_sendgroup.Name = "btn_sendgroup";
            btn_sendgroup.Size = new Size(135, 29);
            btn_sendgroup.TabIndex = 5;
            btn_sendgroup.Text = "send to group";
            btn_sendgroup.UseVisualStyleBackColor = true;
            // 
            // btn_join
            // 
            btn_join.Location = new Point(278, 140);
            btn_join.Name = "btn_join";
            btn_join.Size = new Size(94, 29);
            btn_join.TabIndex = 6;
            btn_join.Text = "join";
            btn_join.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 34);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 7;
            label1.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 92);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 8;
            label2.Text = "message";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 149);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 9;
            label3.Text = "group";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 633);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_join);
            Controls.Add(btn_sendgroup);
            Controls.Add(btn_send);
            Controls.Add(txt_group);
            Controls.Add(txt_message);
            Controls.Add(txt_name);
            Controls.Add(lb_messages);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lb_messages;
        private TextBox txt_name;
        private TextBox txt_message;
        private TextBox txt_group;
        private Button btn_send;
        private Button btn_sendgroup;
        private Button btn_join;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
