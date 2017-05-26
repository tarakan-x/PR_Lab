using System;

namespace PR_Lab3_Sample
{
     partial class Form1
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
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.searchRichTextBox = new System.Windows.Forms.RichTextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.searchBtn = new System.Windows.Forms.Button();
               this.methodsRichTextBox = new System.Windows.Forms.RichTextBox();
               this.post_btn = new System.Windows.Forms.Button();
               this.get_btn = new System.Windows.Forms.Button();
               this.textBox2 = new System.Windows.Forms.TextBox();
               this.Head = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(12, 31);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(358, 20);
               this.textBox1.TabIndex = 0;
               this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
               // 
               // searchRichTextBox
               // 
               this.searchRichTextBox.Location = new System.Drawing.Point(3, 98);
               this.searchRichTextBox.Name = "searchRichTextBox";
               this.searchRichTextBox.Size = new System.Drawing.Size(367, 412);
               this.searchRichTextBox.TabIndex = 1;
               this.searchRichTextBox.Text = "";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(12, 9);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(101, 13);
               this.label1.TabIndex = 2;
               this.label1.Text = "Input the URL here:";
               // 
               // searchBtn
               // 
               this.searchBtn.Location = new System.Drawing.Point(144, 66);
               this.searchBtn.Name = "searchBtn";
               this.searchBtn.Size = new System.Drawing.Size(87, 23);
               this.searchBtn.TabIndex = 3;
               this.searchBtn.Text = "Search links";
               this.searchBtn.UseVisualStyleBackColor = true;
               this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
               // 
               // methodsRichTextBox
               // 
               this.methodsRichTextBox.Location = new System.Drawing.Point(387, 98);
               this.methodsRichTextBox.Name = "methodsRichTextBox";
               this.methodsRichTextBox.Size = new System.Drawing.Size(369, 412);
               this.methodsRichTextBox.TabIndex = 4;
               this.methodsRichTextBox.Text = "";
               // 
               // post_btn
               // 
               this.post_btn.Location = new System.Drawing.Point(538, 66);
               this.post_btn.Name = "post_btn";
               this.post_btn.Size = new System.Drawing.Size(83, 23);
               this.post_btn.TabIndex = 5;
               this.post_btn.Text = "PostRequest";
               this.post_btn.UseVisualStyleBackColor = true;
               this.post_btn.Click += new System.EventHandler(this.post_btn_Click);
               // 
               // get_btn
               // 
               this.get_btn.Location = new System.Drawing.Point(431, 66);
               this.get_btn.Name = "get_btn";
               this.get_btn.Size = new System.Drawing.Size(75, 23);
               this.get_btn.TabIndex = 6;
               this.get_btn.Text = "GetRequest";
               this.get_btn.UseVisualStyleBackColor = true;
               this.get_btn.Click += new System.EventHandler(this.get_btn_Click);
               // 
               // textBox2
               // 
               this.textBox2.Location = new System.Drawing.Point(387, 31);
               this.textBox2.Name = "textBox2";
               this.textBox2.Size = new System.Drawing.Size(358, 20);
               this.textBox2.TabIndex = 7;
               // 
               // Head
               // 
               this.Head.Location = new System.Drawing.Point(638, 66);
               this.Head.Name = "Head";
               this.Head.Size = new System.Drawing.Size(83, 23);
               this.Head.TabIndex = 8;
               this.Head.Text = "Head";
               this.Head.UseVisualStyleBackColor = true;
               this.Head.Click += new System.EventHandler(this.Head_Click);
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
               this.ClientSize = new System.Drawing.Size(768, 535);
               this.Controls.Add(this.Head);
               this.Controls.Add(this.textBox2);
               this.Controls.Add(this.get_btn);
               this.Controls.Add(this.post_btn);
               this.Controls.Add(this.methodsRichTextBox);
               this.Controls.Add(this.searchBtn);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.searchRichTextBox);
               this.Controls.Add(this.textBox1);
               this.DoubleBuffered = true;
               this.Name = "Form1";
               this.Text = "HTTP Client";
               this.Load += new System.EventHandler(this.Form1_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

      

          #endregion

          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.RichTextBox searchRichTextBox;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Button searchBtn;
          private System.Windows.Forms.RichTextBox methodsRichTextBox;
          private System.Windows.Forms.Button post_btn;
          private System.Windows.Forms.Button get_btn;
          private System.Windows.Forms.TextBox textBox2;
          private System.Windows.Forms.Button Head;
     }
}

