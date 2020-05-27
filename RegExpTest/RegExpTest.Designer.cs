namespace RegExpTest
{
    partial class RegExpTest
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonReplace = new System.Windows.Forms.RadioButton();
            this.radioButtonIsMatch = new System.Windows.Forms.RadioButton();
            this.checkBoxIgnoreCase = new System.Windows.Forms.CheckBox();
            this.textBoxRegExp = new System.Windows.Forms.TextBox();
            this.textBoxInputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResultText = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTextError = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelUpperTextError = new System.Windows.Forms.Label();
            this.labelForReplace = new System.Windows.Forms.Label();
            this.textBoxReplacementText = new System.Windows.Forms.TextBox();
            this.checkBoxInputTextAsOneString = new System.Windows.Forms.CheckBox();
            this.radioButtonMatches = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonReplace
            // 
            this.radioButtonReplace.AutoSize = true;
            this.radioButtonReplace.Location = new System.Drawing.Point(76, 11);
            this.radioButtonReplace.Name = "radioButtonReplace";
            this.radioButtonReplace.Size = new System.Drawing.Size(65, 17);
            this.radioButtonReplace.TabIndex = 0;
            this.radioButtonReplace.Text = "Replace";
            this.radioButtonReplace.UseVisualStyleBackColor = true;
            this.radioButtonReplace.CheckedChanged += new System.EventHandler(this.RegExpMainEvent);
            // 
            // radioButtonIsMatch
            // 
            this.radioButtonIsMatch.AutoSize = true;
            this.radioButtonIsMatch.Checked = true;
            this.radioButtonIsMatch.Location = new System.Drawing.Point(7, 11);
            this.radioButtonIsMatch.Name = "radioButtonIsMatch";
            this.radioButtonIsMatch.Size = new System.Drawing.Size(63, 17);
            this.radioButtonIsMatch.TabIndex = 1;
            this.radioButtonIsMatch.TabStop = true;
            this.radioButtonIsMatch.Text = "IsMatch";
            this.radioButtonIsMatch.UseVisualStyleBackColor = true;
            this.radioButtonIsMatch.CheckedChanged += new System.EventHandler(this.RegExpMainEvent);
            // 
            // checkBoxIgnoreCase
            // 
            this.checkBoxIgnoreCase.AutoSize = true;
            this.checkBoxIgnoreCase.Location = new System.Drawing.Point(508, 12);
            this.checkBoxIgnoreCase.Name = "checkBoxIgnoreCase";
            this.checkBoxIgnoreCase.Size = new System.Drawing.Size(124, 17);
            this.checkBoxIgnoreCase.TabIndex = 2;
            this.checkBoxIgnoreCase.Text = "Без учёта регистра";
            this.checkBoxIgnoreCase.UseVisualStyleBackColor = true;
            this.checkBoxIgnoreCase.CheckedChanged += new System.EventHandler(this.RegExpMainEvent);
            // 
            // textBoxRegExp
            // 
            this.textBoxRegExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRegExp.Location = new System.Drawing.Point(94, 40);
            this.textBoxRegExp.Name = "textBoxRegExp";
            this.textBoxRegExp.Size = new System.Drawing.Size(593, 26);
            this.textBoxRegExp.TabIndex = 3;
            this.textBoxRegExp.TextChanged += new System.EventHandler(this.RegExpMainEvent);
            // 
            // textBoxInputText
            // 
            this.textBoxInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInputText.Location = new System.Drawing.Point(94, 88);
            this.textBoxInputText.Multiline = true;
            this.textBoxInputText.Name = "textBoxInputText";
            this.textBoxInputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInputText.Size = new System.Drawing.Size(594, 86);
            this.textBoxInputText.TabIndex = 4;
            this.textBoxInputText.TextChanged += new System.EventHandler(this.RegExpMainEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Рег. выражение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Входной текст";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Результат";
            // 
            // textBoxResultText
            // 
            this.textBoxResultText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResultText.Location = new System.Drawing.Point(94, 178);
            this.textBoxResultText.Multiline = true;
            this.textBoxResultText.Name = "textBoxResultText";
            this.textBoxResultText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultText.Size = new System.Drawing.Size(594, 86);
            this.textBoxResultText.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTextError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 274);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(699, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTextError
            // 
            this.toolStripStatusLabelTextError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabelTextError.Name = "toolStripStatusLabelTextError";
            this.toolStripStatusLabelTextError.Size = new System.Drawing.Size(156, 17);
            this.toolStripStatusLabelTextError.Text = "toolStripStatusLabelTextError";
            // 
            // labelUpperTextError
            // 
            this.labelUpperTextError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUpperTextError.AutoSize = true;
            this.labelUpperTextError.ForeColor = System.Drawing.Color.Red;
            this.labelUpperTextError.Location = new System.Drawing.Point(5, 257);
            this.labelUpperTextError.Name = "labelUpperTextError";
            this.labelUpperTextError.Size = new System.Drawing.Size(64, 13);
            this.labelUpperTextError.TabIndex = 9;
            this.labelUpperTextError.Text = "UpTextError";
            // 
            // labelForReplace
            // 
            this.labelForReplace.AutoSize = true;
            this.labelForReplace.Location = new System.Drawing.Point(4, 66);
            this.labelForReplace.Name = "labelForReplace";
            this.labelForReplace.Size = new System.Drawing.Size(75, 13);
            this.labelForReplace.TabIndex = 10;
            this.labelForReplace.Text = "Заменить на:";
            // 
            // textBoxReplacementText
            // 
            this.textBoxReplacementText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReplacementText.Enabled = false;
            this.textBoxReplacementText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxReplacementText.Location = new System.Drawing.Point(94, 64);
            this.textBoxReplacementText.Name = "textBoxReplacementText";
            this.textBoxReplacementText.Size = new System.Drawing.Size(594, 26);
            this.textBoxReplacementText.TabIndex = 11;
            this.textBoxReplacementText.TextChanged += new System.EventHandler(this.RegExpMainEvent);
            // 
            // checkBoxInputTextAsOneString
            // 
            this.checkBoxInputTextAsOneString.AutoSize = true;
            this.checkBoxInputTextAsOneString.Location = new System.Drawing.Point(326, 12);
            this.checkBoxInputTextAsOneString.Name = "checkBoxInputTextAsOneString";
            this.checkBoxInputTextAsOneString.Size = new System.Drawing.Size(176, 17);
            this.checkBoxInputTextAsOneString.TabIndex = 12;
            this.checkBoxInputTextAsOneString.Text = "Входной текст одной строкой";
            this.checkBoxInputTextAsOneString.UseVisualStyleBackColor = true;
            this.checkBoxInputTextAsOneString.CheckedChanged += new System.EventHandler(this.RegExpMainEvent);
            // 
            // radioButtonMatches
            // 
            this.radioButtonMatches.AutoSize = true;
            this.radioButtonMatches.Location = new System.Drawing.Point(147, 11);
            this.radioButtonMatches.Name = "radioButtonMatches";
            this.radioButtonMatches.Size = new System.Drawing.Size(66, 17);
            this.radioButtonMatches.TabIndex = 13;
            this.radioButtonMatches.Text = "Matches";
            this.radioButtonMatches.UseVisualStyleBackColor = true;
            // 
            // RegExpTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 296);
            this.Controls.Add(this.radioButtonMatches);
            this.Controls.Add(this.checkBoxInputTextAsOneString);
            this.Controls.Add(this.textBoxReplacementText);
            this.Controls.Add(this.labelForReplace);
            this.Controls.Add(this.labelUpperTextError);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResultText);
            this.Controls.Add(this.textBoxInputText);
            this.Controls.Add(this.textBoxRegExp);
            this.Controls.Add(this.checkBoxIgnoreCase);
            this.Controls.Add(this.radioButtonIsMatch);
            this.Controls.Add(this.radioButtonReplace);
            this.MinimumSize = new System.Drawing.Size(546, 285);
            this.Name = "RegExpTest";
            this.Text = "RegExpTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegExpTest_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonReplace;
        private System.Windows.Forms.RadioButton radioButtonIsMatch;
        private System.Windows.Forms.CheckBox checkBoxIgnoreCase;
        private System.Windows.Forms.TextBox textBoxRegExp;
        private System.Windows.Forms.TextBox textBoxInputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResultText;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTextError;
        public System.Windows.Forms.Label labelForReplace;
        public System.Windows.Forms.TextBox textBoxReplacementText;
        public System.Windows.Forms.Label labelUpperTextError;
        private System.Windows.Forms.CheckBox checkBoxInputTextAsOneString;
        private System.Windows.Forms.RadioButton radioButtonMatches;
    }
}

