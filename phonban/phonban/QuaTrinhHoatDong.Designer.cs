namespace phonban
{
    partial class QuaTrinhHoatDong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPhongBan = new System.Windows.Forms.TabPage();
            this.groupThaoTac = new System.Windows.Forms.GroupBox();
            this.txtMaNvpb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgayChuyen = new System.Windows.Forms.DateTimePicker();
            this.cobNhanVien = new System.Windows.Forms.ComboBox();
            this.cobPhongBan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupHienThi = new System.Windows.Forms.GroupBox();
            this.dgvNhanVienPhongBan = new System.Windows.Forms.DataGridView();
            this.groupTimKiem = new System.Windows.Forms.GroupBox();
            this.tabChucVu = new System.Windows.Forms.TabPage();
            this.contextPhongBan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.cobTkNhanVien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cobTkPhongBan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPhongBan.SuspendLayout();
            this.groupThaoTac.SuspendLayout();
            this.groupHienThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVienPhongBan)).BeginInit();
            this.groupTimKiem.SuspendLayout();
            this.contextPhongBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPhongBan);
            this.tabControl1.Controls.Add(this.tabChucVu);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 538);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPhongBan
            // 
            this.tabPhongBan.Controls.Add(this.btnQuayLai);
            this.tabPhongBan.Controls.Add(this.groupThaoTac);
            this.tabPhongBan.Controls.Add(this.groupHienThi);
            this.tabPhongBan.Controls.Add(this.groupTimKiem);
            this.tabPhongBan.Location = new System.Drawing.Point(4, 22);
            this.tabPhongBan.Name = "tabPhongBan";
            this.tabPhongBan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhongBan.Size = new System.Drawing.Size(808, 512);
            this.tabPhongBan.TabIndex = 0;
            this.tabPhongBan.Text = "Phòng ban";
            this.tabPhongBan.UseVisualStyleBackColor = true;
            // 
            // groupThaoTac
            // 
            this.groupThaoTac.Controls.Add(this.txtMaNvpb);
            this.groupThaoTac.Controls.Add(this.label4);
            this.groupThaoTac.Controls.Add(this.btnSua);
            this.groupThaoTac.Controls.Add(this.btnThem);
            this.groupThaoTac.Controls.Add(this.dtpNgayChuyen);
            this.groupThaoTac.Controls.Add(this.cobNhanVien);
            this.groupThaoTac.Controls.Add(this.cobPhongBan);
            this.groupThaoTac.Controls.Add(this.label3);
            this.groupThaoTac.Controls.Add(this.label2);
            this.groupThaoTac.Controls.Add(this.label1);
            this.groupThaoTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupThaoTac.Location = new System.Drawing.Point(9, 378);
            this.groupThaoTac.Name = "groupThaoTac";
            this.groupThaoTac.Size = new System.Drawing.Size(694, 115);
            this.groupThaoTac.TabIndex = 2;
            this.groupThaoTac.TabStop = false;
            this.groupThaoTac.Text = "Thao tác";
            // 
            // txtMaNvpb
            // 
            this.txtMaNvpb.Location = new System.Drawing.Point(100, 28);
            this.txtMaNvpb.Name = "txtMaNvpb";
            this.txtMaNvpb.ReadOnly = true;
            this.txtMaNvpb.Size = new System.Drawing.Size(150, 20);
            this.txtMaNvpb.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã thay đổi";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(601, 76);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(601, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpNgayChuyen
            // 
            this.dtpNgayChuyen.Location = new System.Drawing.Point(107, 77);
            this.dtpNgayChuyen.Name = "dtpNgayChuyen";
            this.dtpNgayChuyen.Size = new System.Drawing.Size(143, 20);
            this.dtpNgayChuyen.TabIndex = 6;
            this.dtpNgayChuyen.ValueChanged += new System.EventHandler(this.dtpNgayChuyen_ValueChanged);
            // 
            // cobNhanVien
            // 
            this.cobNhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cobNhanVien.FormattingEnabled = true;
            this.cobNhanVien.Location = new System.Drawing.Point(352, 28);
            this.cobNhanVien.Name = "cobNhanVien";
            this.cobNhanVien.Size = new System.Drawing.Size(215, 21);
            this.cobNhanVien.TabIndex = 5;
            this.cobNhanVien.SelectedIndexChanged += new System.EventHandler(this.cobNhanVien_SelectedIndexChanged);
            // 
            // cobPhongBan
            // 
            this.cobPhongBan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cobPhongBan.FormattingEnabled = true;
            this.cobPhongBan.Location = new System.Drawing.Point(352, 75);
            this.cobPhongBan.Name = "cobPhongBan";
            this.cobPhongBan.Size = new System.Drawing.Size(215, 21);
            this.cobPhongBan.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày chuyển";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupHienThi
            // 
            this.groupHienThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupHienThi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupHienThi.Controls.Add(this.dgvNhanVienPhongBan);
            this.groupHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupHienThi.Location = new System.Drawing.Point(11, 71);
            this.groupHienThi.Name = "groupHienThi";
            this.groupHienThi.Size = new System.Drawing.Size(791, 282);
            this.groupHienThi.TabIndex = 1;
            this.groupHienThi.TabStop = false;
            this.groupHienThi.Text = "Danh sách";
            // 
            // dgvNhanVienPhongBan
            // 
            this.dgvNhanVienPhongBan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVienPhongBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhanVienPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVienPhongBan.ContextMenuStrip = this.contextPhongBan;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVienPhongBan.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNhanVienPhongBan.Location = new System.Drawing.Point(6, 19);
            this.dgvNhanVienPhongBan.Name = "dgvNhanVienPhongBan";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVienPhongBan.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNhanVienPhongBan.Size = new System.Drawing.Size(779, 242);
            this.dgvNhanVienPhongBan.TabIndex = 0;
            // 
            // groupTimKiem
            // 
            this.groupTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupTimKiem.Controls.Add(this.btnTimKiem);
            this.groupTimKiem.Controls.Add(this.cobTkPhongBan);
            this.groupTimKiem.Controls.Add(this.label6);
            this.groupTimKiem.Controls.Add(this.cobTkNhanVien);
            this.groupTimKiem.Controls.Add(this.label5);
            this.groupTimKiem.Location = new System.Drawing.Point(105, 7);
            this.groupTimKiem.Name = "groupTimKiem";
            this.groupTimKiem.Size = new System.Drawing.Size(695, 58);
            this.groupTimKiem.TabIndex = 0;
            this.groupTimKiem.TabStop = false;
            this.groupTimKiem.Text = "Tìm kiếm";
            // 
            // tabChucVu
            // 
            this.tabChucVu.Location = new System.Drawing.Point(4, 22);
            this.tabChucVu.Name = "tabChucVu";
            this.tabChucVu.Padding = new System.Windows.Forms.Padding(3);
            this.tabChucVu.Size = new System.Drawing.Size(808, 512);
            this.tabChucVu.TabIndex = 2;
            this.tabChucVu.Text = "Chức vụ";
            this.tabChucVu.UseVisualStyleBackColor = true;
            // 
            // contextPhongBan
            // 
            this.contextPhongBan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextPhongBan.Name = "contextPhongBan";
            this.contextPhongBan.Size = new System.Drawing.Size(106, 70);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(725, 434);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 59);
            this.btnQuayLai.TabIndex = 3;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // cobTkNhanVien
            // 
            this.cobTkNhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cobTkNhanVien.FormattingEnabled = true;
            this.cobTkNhanVien.Location = new System.Drawing.Point(85, 19);
            this.cobTkNhanVien.Name = "cobTkNhanVien";
            this.cobTkNhanVien.Size = new System.Drawing.Size(185, 21);
            this.cobTkNhanVien.TabIndex = 7;
            this.cobTkNhanVien.Text = "Chọn nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nhân viên";
            // 
            // cobTkPhongBan
            // 
            this.cobTkPhongBan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cobTkPhongBan.FormattingEnabled = true;
            this.cobTkPhongBan.Location = new System.Drawing.Point(378, 19);
            this.cobTkPhongBan.Name = "cobTkPhongBan";
            this.cobTkPhongBan.Size = new System.Drawing.Size(163, 21);
            this.cobTkPhongBan.TabIndex = 12;
            this.cobTkPhongBan.Text = "Chọn phòng ban";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phòng ban";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(580, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // QuaTrinhHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(816, 538);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "QuaTrinhHoatDong";
            this.Text = "QuaTrinhHoatDong";
            this.Load += new System.EventHandler(this.QuaTrinhHoatDong_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPhongBan.ResumeLayout(false);
            this.groupThaoTac.ResumeLayout(false);
            this.groupThaoTac.PerformLayout();
            this.groupHienThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVienPhongBan)).EndInit();
            this.groupTimKiem.ResumeLayout(false);
            this.groupTimKiem.PerformLayout();
            this.contextPhongBan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPhongBan;
        private System.Windows.Forms.TabPage tabChucVu;
        private System.Windows.Forms.GroupBox groupTimKiem;
        private System.Windows.Forms.GroupBox groupThaoTac;
        private System.Windows.Forms.GroupBox groupHienThi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobPhongBan;
        private System.Windows.Forms.ComboBox cobNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayChuyen;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaNvpb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvNhanVienPhongBan;
        private System.Windows.Forms.ContextMenuStrip contextPhongBan;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cobTkPhongBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cobTkNhanVien;
        private System.Windows.Forms.Label label5;
    }
}