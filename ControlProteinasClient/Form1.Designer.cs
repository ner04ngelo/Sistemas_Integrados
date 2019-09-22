namespace ControlProteinasClient
{
    partial class ControlProteinasForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addUser = new System.Windows.Forms.Button();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbuser = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addProtein = new System.Windows.Forms.Button();
            this.txtProtein = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addUser);
            this.groupBox1.Controls.Add(this.txtGoal);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Nuevo Usuario";
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(70, 111);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(75, 24);
            this.addUser.TabIndex = 3;
            this.addUser.Text = "Agregar";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // txtGoal
            // 
            this.txtGoal.Location = new System.Drawing.Point(70, 78);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(100, 22);
            this.txtGoal.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(70, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Meta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione un usuario";
            // 
            // cmbuser
            // 
            this.cmbuser.FormattingEnabled = true;
            this.cmbuser.Location = new System.Drawing.Point(12, 51);
            this.cmbuser.Name = "cmbuser";
            this.cmbuser.Size = new System.Drawing.Size(150, 21);
            this.cmbuser.TabIndex = 2;
            this.cmbuser.SelectedIndexChanged += new System.EventHandler(this.OnUserChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblGoal);
            this.groupBox2.Controls.Add(this.lbltotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.addProtein);
            this.groupBox2.Controls.Add(this.txtProtein);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(414, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 184);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suma Proteina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Meta :";
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Location = new System.Drawing.Point(100, 141);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(15, 16);
            this.lblGoal.TabIndex = 3;
            this.lblGoal.Text = "0";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(100, 108);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(15, 16);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total :";
            // 
            // addProtein
            // 
            this.addProtein.Location = new System.Drawing.Point(37, 62);
            this.addProtein.Name = "addProtein";
            this.addProtein.Size = new System.Drawing.Size(75, 29);
            this.addProtein.TabIndex = 2;
            this.addProtein.Text = "Agregar";
            this.addProtein.UseVisualStyleBackColor = true;
            this.addProtein.Click += new System.EventHandler(this.AddProtein_Click);
            // 
            // txtProtein
            // 
            this.txtProtein.Location = new System.Drawing.Point(73, 30);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(100, 22);
            this.txtProtein.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Agregar ";
            // 
            // ControlProteinasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 268);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ControlProteinasForm";
            this.Text = "ControlProteinasForm";
            this.Load += new System.EventHandler(this.Onload);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbuser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addProtein;
        private System.Windows.Forms.TextBox txtProtein;
    }
}

