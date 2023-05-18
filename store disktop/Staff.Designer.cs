namespace store_disktop
{
    partial class Staff
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bike_StoreDataSet = new store_disktop.Bike_StoreDataSet();
            this.bikeStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffsTableAdapter = new store_disktop.Bike_StoreDataSetTableAdapters.staffsTableAdapter();
            this.staffidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manageridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.active = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.mid = new System.Windows.Forms.Label();
            this.sidt = new System.Windows.Forms.Label();
            this.fnametext = new System.Windows.Forms.TextBox();
            this.midtext = new System.Windows.Forms.TextBox();
            this.sidtext = new System.Windows.Forms.TextBox();
            this.atext = new System.Windows.Forms.TextBox();
            this.ptext = new System.Windows.Forms.TextBox();
            this.etext = new System.Windows.Forms.TextBox();
            this.lnametext = new System.Windows.Forms.TextBox();
            this.idtext = new System.Windows.Forms.TextBox();
            this.sreach = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bike_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.activeDataGridViewTextBoxColumn,
            this.storeidDataGridViewTextBoxColumn,
            this.manageridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // bike_StoreDataSet
            // 
            this.bike_StoreDataSet.DataSetName = "Bike_StoreDataSet";
            this.bike_StoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bikeStoreDataSetBindingSource
            // 
            this.bikeStoreDataSetBindingSource.DataSource = this.bike_StoreDataSet;
            this.bikeStoreDataSetBindingSource.Position = 0;
            // 
            // staffsBindingSource
            // 
            this.staffsBindingSource.DataMember = "staffs";
            this.staffsBindingSource.DataSource = this.bikeStoreDataSetBindingSource;
            // 
            // staffsTableAdapter
            // 
            this.staffsTableAdapter.ClearBeforeFill = true;
            // 
            // staffidDataGridViewTextBoxColumn
            // 
            this.staffidDataGridViewTextBoxColumn.DataPropertyName = "staff_id";
            this.staffidDataGridViewTextBoxColumn.HeaderText = "staff_id";
            this.staffidDataGridViewTextBoxColumn.Name = "staffidDataGridViewTextBoxColumn";
            this.staffidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // activeDataGridViewTextBoxColumn
            // 
            this.activeDataGridViewTextBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewTextBoxColumn.HeaderText = "active";
            this.activeDataGridViewTextBoxColumn.Name = "activeDataGridViewTextBoxColumn";
            // 
            // storeidDataGridViewTextBoxColumn
            // 
            this.storeidDataGridViewTextBoxColumn.DataPropertyName = "store_id";
            this.storeidDataGridViewTextBoxColumn.HeaderText = "store_id";
            this.storeidDataGridViewTextBoxColumn.Name = "storeidDataGridViewTextBoxColumn";
            // 
            // manageridDataGridViewTextBoxColumn
            // 
            this.manageridDataGridViewTextBoxColumn.DataPropertyName = "manager_id";
            this.manageridDataGridViewTextBoxColumn.HeaderText = "manager_id";
            this.manageridDataGridViewTextBoxColumn.Name = "manageridDataGridViewTextBoxColumn";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(24, 26);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(117, 24);
            this.fname.TabIndex = 1;
            this.fname.Text = "Farst Name";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(24, 71);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(108, 24);
            this.lname.TabIndex = 2;
            this.lname.Text = "Last Nmae";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(24, 105);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(62, 24);
            this.email.TabIndex = 3;
            this.email.Text = "Email";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(24, 145);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(71, 24);
            this.phone.TabIndex = 4;
            this.phone.Text = "Phone";
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.active.Location = new System.Drawing.Point(24, 183);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(67, 24);
            this.active.TabIndex = 5;
            this.active.Text = "Active";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(488, 199);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(74, 24);
            this.id.TabIndex = 8;
            this.id.Text = "Staff ID";
            this.id.Click += new System.EventHandler(this.Label6_Click);
            // 
            // mid
            // 
            this.mid.AutoSize = true;
            this.mid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mid.Location = new System.Drawing.Point(488, 66);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(106, 24);
            this.mid.TabIndex = 7;
            this.mid.Text = "Manger ID";
            this.mid.Click += new System.EventHandler(this.Label7_Click);
            // 
            // sidt
            // 
            this.sidt.AutoSize = true;
            this.sidt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidt.Location = new System.Drawing.Point(488, 28);
            this.sidt.Name = "sidt";
            this.sidt.Size = new System.Drawing.Size(84, 24);
            this.sidt.TabIndex = 6;
            this.sidt.Text = "Store ID";
            this.sidt.Click += new System.EventHandler(this.Label8_Click);
            // 
            // fnametext
            // 
            this.fnametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametext.Location = new System.Drawing.Point(176, 23);
            this.fnametext.Name = "fnametext";
            this.fnametext.Size = new System.Drawing.Size(275, 29);
            this.fnametext.TabIndex = 9;
            // 
            // midtext
            // 
            this.midtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midtext.Location = new System.Drawing.Point(612, 59);
            this.midtext.Name = "midtext";
            this.midtext.Size = new System.Drawing.Size(148, 29);
            this.midtext.TabIndex = 10;
            // 
            // sidtext
            // 
            this.sidtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidtext.Location = new System.Drawing.Point(612, 21);
            this.sidtext.Name = "sidtext";
            this.sidtext.Size = new System.Drawing.Size(148, 29);
            this.sidtext.TabIndex = 11;
            // 
            // atext
            // 
            this.atext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atext.Location = new System.Drawing.Point(176, 180);
            this.atext.Name = "atext";
            this.atext.Size = new System.Drawing.Size(275, 29);
            this.atext.TabIndex = 12;
            // 
            // ptext
            // 
            this.ptext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptext.Location = new System.Drawing.Point(176, 138);
            this.ptext.Name = "ptext";
            this.ptext.Size = new System.Drawing.Size(275, 29);
            this.ptext.TabIndex = 13;
            // 
            // etext
            // 
            this.etext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etext.Location = new System.Drawing.Point(176, 98);
            this.etext.Name = "etext";
            this.etext.Size = new System.Drawing.Size(275, 29);
            this.etext.TabIndex = 14;
            // 
            // lnametext
            // 
            this.lnametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnametext.Location = new System.Drawing.Point(176, 64);
            this.lnametext.Name = "lnametext";
            this.lnametext.Size = new System.Drawing.Size(275, 29);
            this.lnametext.TabIndex = 15;
            // 
            // idtext
            // 
            this.idtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtext.Location = new System.Drawing.Point(612, 196);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(148, 29);
            this.idtext.TabIndex = 16;
            // 
            // sreach
            // 
            this.sreach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(114)))), ((int)(((byte)(210)))));
            this.sreach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sreach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sreach.Location = new System.Drawing.Point(492, 119);
            this.sreach.Name = "sreach";
            this.sreach.Size = new System.Drawing.Size(218, 48);
            this.sreach.TabIndex = 17;
            this.sreach.Text = "Search Using Id ";
            this.sreach.UseVisualStyleBackColor = false;
            this.sreach.Click += new System.EventHandler(this.Sreach_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Lime;
            this.addButton.Location = new System.Drawing.Point(76, 226);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 42);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(294, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 42);
            this.button2.TabIndex = 19;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 490);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.sreach);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.lnametext);
            this.Controls.Add(this.etext);
            this.Controls.Add(this.ptext);
            this.Controls.Add(this.atext);
            this.Controls.Add(this.sidtext);
            this.Controls.Add(this.midtext);
            this.Controls.Add(this.fnametext);
            this.Controls.Add(this.id);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.sidt);
            this.Controls.Add(this.active);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bike_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bikeStoreDataSetBindingSource;
        private Bike_StoreDataSet bike_StoreDataSet;
        private System.Windows.Forms.BindingSource staffsBindingSource;
        private Bike_StoreDataSetTableAdapters.staffsTableAdapter staffsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manageridDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label active;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label mid;
        private System.Windows.Forms.Label sidt;
        private System.Windows.Forms.TextBox fnametext;
        private System.Windows.Forms.TextBox midtext;
        private System.Windows.Forms.TextBox sidtext;
        private System.Windows.Forms.TextBox atext;
        private System.Windows.Forms.TextBox ptext;
        private System.Windows.Forms.TextBox etext;
        private System.Windows.Forms.TextBox lnametext;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.Button sreach;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button2;
    }
}