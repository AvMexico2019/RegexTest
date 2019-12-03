namespace RegexTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxRegex = new System.Windows.Forms.TextBox();
            this.Found = new System.Windows.Forms.TextBox();
            this.ButtonApplyRegex = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.textBoxINFO = new System.Windows.Forms.TextBox();
            this.comboBoxStoreProcedures = new System.Windows.Forms.ComboBox();
            this.richTextBoxStoreProcedureDefinition = new System.Windows.Forms.RichTextBox();
            this.buttonInsertRegex = new System.Windows.Forms.Button();
            this.comboBoxRegexDef = new System.Windows.Forms.ComboBox();
            this.buttonDeleteRegex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonHEX = new System.Windows.Forms.Button();
            this.textBoxASCIITable = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.Location = new System.Drawing.Point(14, 42);
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(877, 20);
            this.textBoxRegex.TabIndex = 0;
            // 
            // Found
            // 
            this.Found.Location = new System.Drawing.Point(14, 397);
            this.Found.Multiline = true;
            this.Found.Name = "Found";
            this.Found.Size = new System.Drawing.Size(879, 69);
            this.Found.TabIndex = 2;
            // 
            // ButtonApplyRegex
            // 
            this.ButtonApplyRegex.Location = new System.Drawing.Point(14, 13);
            this.ButtonApplyRegex.Name = "ButtonApplyRegex";
            this.ButtonApplyRegex.Size = new System.Drawing.Size(92, 23);
            this.ButtonApplyRegex.TabIndex = 3;
            this.ButtonApplyRegex.Text = "Apply SRegex";
            this.ButtonApplyRegex.UseVisualStyleBackColor = true;
            this.ButtonApplyRegex.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(816, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // textBoxINFO
            // 
            this.textBoxINFO.Location = new System.Drawing.Point(546, 12);
            this.textBoxINFO.Name = "textBoxINFO";
            this.textBoxINFO.Size = new System.Drawing.Size(264, 20);
            this.textBoxINFO.TabIndex = 5;
            // 
            // comboBoxStoreProcedures
            // 
            this.comboBoxStoreProcedures.FormattingEnabled = true;
            this.comboBoxStoreProcedures.Location = new System.Drawing.Point(670, 87);
            this.comboBoxStoreProcedures.Name = "comboBoxStoreProcedures";
            this.comboBoxStoreProcedures.Size = new System.Drawing.Size(290, 21);
            this.comboBoxStoreProcedures.TabIndex = 6;
            this.comboBoxStoreProcedures.SelectedIndexChanged += new System.EventHandler(this.comboBoxStoreProcedures_SelectedIndexChanged);
            // 
            // richTextBoxStoreProcedureDefinition
            // 
            this.richTextBoxStoreProcedureDefinition.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxStoreProcedureDefinition.Location = new System.Drawing.Point(14, 68);
            this.richTextBoxStoreProcedureDefinition.Name = "richTextBoxStoreProcedureDefinition";
            this.richTextBoxStoreProcedureDefinition.Size = new System.Drawing.Size(647, 323);
            this.richTextBoxStoreProcedureDefinition.TabIndex = 7;
            this.richTextBoxStoreProcedureDefinition.Text = "";
            // 
            // buttonInsertRegex
            // 
            this.buttonInsertRegex.Location = new System.Drawing.Point(112, 13);
            this.buttonInsertRegex.Name = "buttonInsertRegex";
            this.buttonInsertRegex.Size = new System.Drawing.Size(88, 23);
            this.buttonInsertRegex.TabIndex = 8;
            this.buttonInsertRegex.Text = "Insert SRegex";
            this.buttonInsertRegex.UseVisualStyleBackColor = true;
            this.buttonInsertRegex.Click += new System.EventHandler(this.buttonInsertRegex_Click);
            // 
            // comboBoxRegexDef
            // 
            this.comboBoxRegexDef.FormattingEnabled = true;
            this.comboBoxRegexDef.Location = new System.Drawing.Point(670, 156);
            this.comboBoxRegexDef.Name = "comboBoxRegexDef";
            this.comboBoxRegexDef.Size = new System.Drawing.Size(292, 21);
            this.comboBoxRegexDef.TabIndex = 9;
            this.comboBoxRegexDef.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegexDef_SelectedIndexChanged);
            // 
            // buttonDeleteRegex
            // 
            this.buttonDeleteRegex.Location = new System.Drawing.Point(206, 13);
            this.buttonDeleteRegex.Name = "buttonDeleteRegex";
            this.buttonDeleteRegex.Size = new System.Drawing.Size(92, 23);
            this.buttonDeleteRegex.TabIndex = 10;
            this.buttonDeleteRegex.Text = "Delete SRegex";
            this.buttonDeleteRegex.UseVisualStyleBackColor = true;
            this.buttonDeleteRegex.Click += new System.EventHandler(this.buttonDeleteRegex_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Store procedure list";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Defined Regex";
            // 
            // buttonHEX
            // 
            this.buttonHEX.Location = new System.Drawing.Point(670, 114);
            this.buttonHEX.Name = "buttonHEX";
            this.buttonHEX.Size = new System.Drawing.Size(75, 23);
            this.buttonHEX.TabIndex = 13;
            this.buttonHEX.Text = "ASCII";
            this.buttonHEX.UseVisualStyleBackColor = true;
            this.buttonHEX.Click += new System.EventHandler(this.buttonHEX_Click);
            // 
            // textBoxASCIITable
            // 
            this.textBoxASCIITable.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxASCIITable.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxASCIITable.Location = new System.Drawing.Point(670, 196);
            this.textBoxASCIITable.Multiline = true;
            this.textBoxASCIITable.Name = "textBoxASCIITable";
            this.textBoxASCIITable.Size = new System.Drawing.Size(252, 195);
            this.textBoxASCIITable.TabIndex = 14;
            this.textBoxASCIITable.Text = resources.GetString("textBoxASCIITable.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "ASCII Table";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 480);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxASCIITable);
            this.Controls.Add(this.buttonHEX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteRegex);
            this.Controls.Add(this.comboBoxRegexDef);
            this.Controls.Add(this.buttonInsertRegex);
            this.Controls.Add(this.richTextBoxStoreProcedureDefinition);
            this.Controls.Add(this.comboBoxStoreProcedures);
            this.Controls.Add(this.textBoxINFO);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ButtonApplyRegex);
            this.Controls.Add(this.Found);
            this.Controls.Add(this.textBoxRegex);
            this.Name = "Form1";
            this.Text = "Regex Analisys ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRegex;
        private System.Windows.Forms.TextBox Found;
        private System.Windows.Forms.Button ButtonApplyRegex;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox textBoxINFO;
        private System.Windows.Forms.ComboBox comboBoxStoreProcedures;
        private System.Windows.Forms.RichTextBox richTextBoxStoreProcedureDefinition;
        private System.Windows.Forms.Button buttonInsertRegex;
        private System.Windows.Forms.ComboBox comboBoxRegexDef;
        private System.Windows.Forms.Button buttonDeleteRegex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonHEX;
        private System.Windows.Forms.TextBox textBoxASCIITable;
        private System.Windows.Forms.Label label3;
    }
}

