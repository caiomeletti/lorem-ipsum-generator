namespace LoremIpsum.WinForm
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
            nudAmontOf = new NumericUpDown();
            groupBox1 = new GroupBox();
            rdbParagraphs = new RadioButton();
            rdbSentences = new RadioButton();
            rdbWords = new RadioButton();
            textBox1 = new TextBox();
            cmdGenerate = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAmontOf).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nudAmontOf
            // 
            nudAmontOf.Location = new Point(12, 13);
            nudAmontOf.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAmontOf.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAmontOf.Name = "nudAmontOf";
            nudAmontOf.Size = new Size(65, 23);
            nudAmontOf.TabIndex = 1;
            nudAmontOf.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbParagraphs);
            groupBox1.Controls.Add(rdbSentences);
            groupBox1.Controls.Add(rdbWords);
            groupBox1.Location = new Point(12, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(110, 104);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // rdbParagraphs
            // 
            rdbParagraphs.AutoSize = true;
            rdbParagraphs.Location = new Point(6, 75);
            rdbParagraphs.Name = "rdbParagraphs";
            rdbParagraphs.Size = new Size(84, 19);
            rdbParagraphs.TabIndex = 2;
            rdbParagraphs.Text = "&Paragraphs";
            rdbParagraphs.UseVisualStyleBackColor = true;
            // 
            // rdbSentences
            // 
            rdbSentences.AutoSize = true;
            rdbSentences.Location = new Point(6, 47);
            rdbSentences.Name = "rdbSentences";
            rdbSentences.Size = new Size(78, 19);
            rdbSentences.TabIndex = 1;
            rdbSentences.Text = "&Sentences";
            rdbSentences.UseVisualStyleBackColor = true;
            // 
            // rdbWords
            // 
            rdbWords.AutoSize = true;
            rdbWords.Location = new Point(6, 22);
            rdbWords.Name = "rdbWords";
            rdbWords.Size = new Size(59, 19);
            rdbWords.TabIndex = 0;
            rdbWords.Text = "&Words";
            rdbWords.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(417, 189);
            textBox1.TabIndex = 4;
            // 
            // cmdGenerate
            // 
            cmdGenerate.Location = new Point(13, 174);
            cmdGenerate.Name = "cmdGenerate";
            cmdGenerate.Size = new Size(109, 27);
            cmdGenerate.TabIndex = 3;
            cmdGenerate.Text = "&Generate";
            cmdGenerate.UseVisualStyleBackColor = true;
            cmdGenerate.Click += cmdGenerate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 213);
            Controls.Add(cmdGenerate);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(nudAmontOf);
            Name = "Form1";
            Text = "Lorem Ipsum Generator";
            ((System.ComponentModel.ISupportInitialize)nudAmontOf).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudAmontOf;
        private GroupBox groupBox1;
        private RadioButton rdbParagraphs;
        private RadioButton rdbSentences;
        private RadioButton rdbWords;
        private TextBox textBox1;
        private Button cmdGenerate;
    }
}
