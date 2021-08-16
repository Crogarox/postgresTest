
namespace postgresTest
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
            this.btnSQL = new System.Windows.Forms.Button();
            this.txConnection = new System.Windows.Forms.TextBox();
            this.rtbSqlOutput = new System.Windows.Forms.RichTextBox();
            this.txSqlQuery = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(12, 415);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(75, 23);
            this.btnSQL.TabIndex = 0;
            this.btnSQL.Text = "Connect";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // txConnection
            // 
            this.txConnection.Location = new System.Drawing.Point(12, 12);
            this.txConnection.Name = "txConnection";
            this.txConnection.Size = new System.Drawing.Size(776, 20);
            this.txConnection.TabIndex = 1;
            this.txConnection.Text = "Host=localhost;Username=postgres;Password=s$cret;Database=testdb";
            // 
            // rtbSqlOutput
            // 
            this.rtbSqlOutput.Location = new System.Drawing.Point(363, 64);
            this.rtbSqlOutput.Name = "rtbSqlOutput";
            this.rtbSqlOutput.Size = new System.Drawing.Size(425, 374);
            this.rtbSqlOutput.TabIndex = 2;
            this.rtbSqlOutput.Text = "";
            // 
            // txSqlQuery
            // 
            this.txSqlQuery.Location = new System.Drawing.Point(12, 38);
            this.txSqlQuery.Name = "txSqlQuery";
            this.txSqlQuery.Size = new System.Drawing.Size(776, 20);
            this.txSqlQuery.TabIndex = 3;
            this.txSqlQuery.Text = "SELECT version()";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txSqlQuery);
            this.Controls.Add(this.rtbSqlOutput);
            this.Controls.Add(this.txConnection);
            this.Controls.Add(this.btnSQL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.TextBox txConnection;
        private System.Windows.Forms.RichTextBox rtbSqlOutput;
        private System.Windows.Forms.TextBox txSqlQuery;
    }
}

