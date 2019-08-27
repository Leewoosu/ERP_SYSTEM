namespace MES
{
    partial class Detailperform
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblProcessValue = new System.Windows.Forms.Label();
            this.lblPerformDate = new System.Windows.Forms.Label();
            this.lblManageNum = new System.Windows.Forms.Label();
            this.lblWorkNumValue = new System.Windows.Forms.Label();
            this.lblShop = new System.Windows.Forms.Label();
            this.lblProductionNum = new System.Windows.Forms.Label();
            this.lblEmployeeNum = new System.Windows.Forms.Label();
            this.btnExpandCommend = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.lblTilde2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProcess
            // 
            this.lblProcess.BackColor = System.Drawing.Color.Gray;
            this.lblProcess.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProcess.ForeColor = System.Drawing.Color.White;
            this.lblProcess.Location = new System.Drawing.Point(743, 15);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(107, 26);
            this.lblProcess.TabIndex = 51;
            this.lblProcess.Text = "공정";
            this.lblProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcessValue
            // 
            this.lblProcessValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProcessValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProcessValue.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProcessValue.Location = new System.Drawing.Point(851, 15);
            this.lblProcessValue.Name = "lblProcessValue";
            this.lblProcessValue.Size = new System.Drawing.Size(197, 26);
            this.lblProcessValue.TabIndex = 50;
            this.lblProcessValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerformDate
            // 
            this.lblPerformDate.BackColor = System.Drawing.Color.Gray;
            this.lblPerformDate.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPerformDate.ForeColor = System.Drawing.Color.White;
            this.lblPerformDate.Location = new System.Drawing.Point(1, 104);
            this.lblPerformDate.Name = "lblPerformDate";
            this.lblPerformDate.Size = new System.Drawing.Size(97, 32);
            this.lblPerformDate.TabIndex = 35;
            this.lblPerformDate.Text = "실 적 일";
            this.lblPerformDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManageNum
            // 
            this.lblManageNum.BackColor = System.Drawing.Color.Gray;
            this.lblManageNum.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblManageNum.ForeColor = System.Drawing.Color.White;
            this.lblManageNum.Location = new System.Drawing.Point(378, 39);
            this.lblManageNum.Name = "lblManageNum";
            this.lblManageNum.Size = new System.Drawing.Size(108, 32);
            this.lblManageNum.TabIndex = 34;
            this.lblManageNum.Text = "관리번호";
            this.lblManageNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWorkNumValue
            // 
            this.lblWorkNumValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWorkNumValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWorkNumValue.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWorkNumValue.Location = new System.Drawing.Point(99, 40);
            this.lblWorkNumValue.Name = "lblWorkNumValue";
            this.lblWorkNumValue.Size = new System.Drawing.Size(273, 32);
            this.lblWorkNumValue.TabIndex = 33;
            this.lblWorkNumValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShop
            // 
            this.lblShop.BackColor = System.Drawing.Color.Gray;
            this.lblShop.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblShop.ForeColor = System.Drawing.Color.White;
            this.lblShop.Location = new System.Drawing.Point(1, 40);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(97, 32);
            this.lblShop.TabIndex = 32;
            this.lblShop.Text = "SHOP";
            this.lblShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductionNum
            // 
            this.lblProductionNum.BackColor = System.Drawing.Color.Gray;
            this.lblProductionNum.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProductionNum.ForeColor = System.Drawing.Color.White;
            this.lblProductionNum.Location = new System.Drawing.Point(1, 72);
            this.lblProductionNum.Name = "lblProductionNum";
            this.lblProductionNum.Size = new System.Drawing.Size(97, 32);
            this.lblProductionNum.TabIndex = 57;
            this.lblProductionNum.Text = "품번";
            this.lblProductionNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeNum
            // 
            this.lblEmployeeNum.BackColor = System.Drawing.Color.Gray;
            this.lblEmployeeNum.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEmployeeNum.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeNum.Location = new System.Drawing.Point(378, 72);
            this.lblEmployeeNum.Name = "lblEmployeeNum";
            this.lblEmployeeNum.Size = new System.Drawing.Size(108, 32);
            this.lblEmployeeNum.TabIndex = 60;
            this.lblEmployeeNum.Text = "사원번호";
            this.lblEmployeeNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExpandCommend
            // 
            this.btnExpandCommend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.btnExpandCommend.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExpandCommend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExpandCommend.Highlight = true;
            this.btnExpandCommend.Location = new System.Drawing.Point(938, 52);
            this.btnExpandCommend.Name = "btnExpandCommend";
            this.btnExpandCommend.Size = new System.Drawing.Size(118, 84);
            this.btnExpandCommend.TabIndex = 66;
            this.btnExpandCommend.Text = "조회";
            this.btnExpandCommend.UseCustomBackColor = true;
            this.btnExpandCommend.UseCustomForeColor = true;
            this.btnExpandCommend.UseSelectable = true;
            this.btnExpandCommend.UseStyleColors = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("함초롬돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 67;
            this.label1.Text = "상세실적조회";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(487, 45);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(197, 23);
            this.metroTextBox1.TabIndex = 68;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(99, 79);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(233, 23);
            this.metroTextBox2.TabIndex = 69;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(487, 78);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(198, 23);
            this.metroTextBox4.TabIndex = 71;
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 142);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 23;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1094, 406);
            this.metroGrid1.TabIndex = 73;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(104, 107);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(187, 29);
            this.metroDateTime1.TabIndex = 74;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(350, 107);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(187, 29);
            this.metroDateTime2.TabIndex = 75;
            // 
            // lblTilde2
            // 
            this.lblTilde2.AutoSize = true;
            this.lblTilde2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTilde2.Location = new System.Drawing.Point(310, 113);
            this.lblTilde2.Name = "lblTilde2";
            this.lblTilde2.Size = new System.Drawing.Size(20, 16);
            this.lblTilde2.TabIndex = 93;
            this.lblTilde2.Text = "~";
            // 
            // Detailperform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblTilde2);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroTextBox4);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExpandCommend);
            this.Controls.Add(this.lblEmployeeNum);
            this.Controls.Add(this.lblProductionNum);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.lblProcessValue);
            this.Controls.Add(this.lblPerformDate);
            this.Controls.Add(this.lblManageNum);
            this.Controls.Add(this.lblWorkNumValue);
            this.Controls.Add(this.lblShop);
            this.Name = "Detailperform";
            this.Size = new System.Drawing.Size(1100, 551);
            this.Load += new System.EventHandler(this.Detailperform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblProcessValue;
        private System.Windows.Forms.Label lblPerformDate;
        private System.Windows.Forms.Label lblManageNum;
        private System.Windows.Forms.Label lblWorkNumValue;
        private System.Windows.Forms.Label lblShop;
        private System.Windows.Forms.Label lblProductionNum;
        private System.Windows.Forms.Label lblEmployeeNum;
        private MetroFramework.Controls.MetroButton btnExpandCommend;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private System.Windows.Forms.Label lblTilde2;
    }
}
