
namespace SMSystem.Gui.Reports
{
    partial class ReceiptUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptUserControl));
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            TextBoxDateTimeLowerEmp = new System.Windows.Forms.TextBox();
            TextBoxLowEmpTitle = new System.Windows.Forms.TextBox();
            TextBoxDateTimeHigherEmp = new System.Windows.Forms.TextBox();
            TextBoxHighEmpTitle = new System.Windows.Forms.TextBox();
            TextBoxLowEmpName = new System.Windows.Forms.TextBox();
            TextBoxHighEmpName = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            LabelDateTime = new System.Windows.Forms.Label();
            PanelHeader = new System.Windows.Forms.Panel();
            labelCompanyName = new System.Windows.Forms.Label();
            pictureBoxCompanyLogo = new System.Windows.Forms.PictureBox();
            LabelId = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            LabelOutComeNo = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            LabelOutComeDate = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            LabelCustomer = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            LabelTotalPrice = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            TextBoxReciveDate = new System.Windows.Forms.TextBox();
            dataGridView = new System.Windows.Forms.DataGridView();
            printdoc1 = new System.Drawing.Printing.PrintDocument();
            flowLayoutPanelNavBar = new System.Windows.Forms.FlowLayoutPanel();
            ButtonPreview = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ButtonPageSetup = new System.Windows.Forms.Button();
            printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            printDialog1 = new System.Windows.Forms.PrintDialog();
            pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label2 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompanyLogo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            flowLayoutPanelNavBar.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(LabelDateTime);
            panel1.Controls.Add(PanelHeader);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(dataGridView);
            panel1.Location = new System.Drawing.Point(23, 105);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1041, 1367);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(TextBoxDateTimeLowerEmp);
            panel2.Controls.Add(TextBoxLowEmpTitle);
            panel2.Controls.Add(TextBoxDateTimeHigherEmp);
            panel2.Controls.Add(TextBoxHighEmpTitle);
            panel2.Controls.Add(TextBoxLowEmpName);
            panel2.Controls.Add(TextBoxHighEmpName);
            panel2.Location = new System.Drawing.Point(87, 1067);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(813, 152);
            panel2.TabIndex = 14;
            // 
            // TextBoxDateTimeLowerEmp
            // 
            TextBoxDateTimeLowerEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TextBoxDateTimeLowerEmp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBoxDateTimeLowerEmp.Location = new System.Drawing.Point(537, 102);
            TextBoxDateTimeLowerEmp.Name = "TextBoxDateTimeLowerEmp";
            TextBoxDateTimeLowerEmp.Size = new System.Drawing.Size(270, 32);
            TextBoxDateTimeLowerEmp.TabIndex = 14;
            TextBoxDateTimeLowerEmp.Text = "2022 /     /    ";
            TextBoxDateTimeLowerEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            TextBoxDateTimeLowerEmp.TextChanged += TextBoxDateTimeLowerEmp_TextChanged;
            // 
            // TextBoxLowEmpTitle
            // 
            TextBoxLowEmpTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TextBoxLowEmpTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBoxLowEmpTitle.Location = new System.Drawing.Point(537, 57);
            TextBoxLowEmpTitle.Name = "TextBoxLowEmpTitle";
            TextBoxLowEmpTitle.Size = new System.Drawing.Size(270, 32);
            TextBoxLowEmpTitle.TabIndex = 14;
            TextBoxLowEmpTitle.Text = "الوظيفة";
            TextBoxLowEmpTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            TextBoxLowEmpTitle.TextChanged += TextBoxLowEmpTitle_TextChanged;
            // 
            // TextBoxDateTimeHigherEmp
            // 
            TextBoxDateTimeHigherEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TextBoxDateTimeHigherEmp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBoxDateTimeHigherEmp.Location = new System.Drawing.Point(2, 108);
            TextBoxDateTimeHigherEmp.Name = "TextBoxDateTimeHigherEmp";
            TextBoxDateTimeHigherEmp.Size = new System.Drawing.Size(270, 32);
            TextBoxDateTimeHigherEmp.TabIndex = 14;
            TextBoxDateTimeHigherEmp.Text = "2022 /     /    ";
            TextBoxDateTimeHigherEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            TextBoxDateTimeHigherEmp.TextChanged += TextBoxDateTimeHigherEmp_TextChanged;
            // 
            // TextBoxHighEmpTitle
            // 
            TextBoxHighEmpTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TextBoxHighEmpTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBoxHighEmpTitle.Location = new System.Drawing.Point(2, 63);
            TextBoxHighEmpTitle.Name = "TextBoxHighEmpTitle";
            TextBoxHighEmpTitle.Size = new System.Drawing.Size(270, 32);
            TextBoxHighEmpTitle.TabIndex = 14;
            TextBoxHighEmpTitle.Text = "الوظيفة";
            TextBoxHighEmpTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            TextBoxHighEmpTitle.TextChanged += TextBoxHighEmpTitle_TextChanged;
            // 
            // TextBoxLowEmpName
            // 
            TextBoxLowEmpName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TextBoxLowEmpName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBoxLowEmpName.Location = new System.Drawing.Point(537, 12);
            TextBoxLowEmpName.Name = "TextBoxLowEmpName";
            TextBoxLowEmpName.Size = new System.Drawing.Size(270, 32);
            TextBoxLowEmpName.TabIndex = 14;
            TextBoxLowEmpName.Text = "اكتب هنا اسم الجهة الدنيا";
            TextBoxLowEmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            TextBoxLowEmpName.TextChanged += TextBoxLowEmpName_TextChanged;
            // 
            // TextBoxHighEmpName
            // 
            TextBoxHighEmpName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TextBoxHighEmpName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBoxHighEmpName.Location = new System.Drawing.Point(2, 18);
            TextBoxHighEmpName.Name = "TextBoxHighEmpName";
            TextBoxHighEmpName.Size = new System.Drawing.Size(270, 32);
            TextBoxHighEmpName.TabIndex = 14;
            TextBoxHighEmpName.Text = "اكتب هنا اسم الجهة العليا";
            TextBoxHighEmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            TextBoxHighEmpName.TextChanged += TextBoxHighEmpName_TextChanged;
            // 
            // label11
            // 
            label11.Font = new System.Drawing.Font("Cairo", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(117, 1291);
            label11.Name = "label11";
            label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label11.Size = new System.Drawing.Size(712, 45);
            label11.TabIndex = 13;
            label11.Text = "تم توليد هذه التقرير من خلال برنامج مخزن \r\nDesign by. Safaa J. Kaheed";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label11.Click += label11_Click;
            // 
            // LabelDateTime
            // 
            LabelDateTime.Font = new System.Drawing.Font("Cairo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelDateTime.Location = new System.Drawing.Point(95, 1260);
            LabelDateTime.Name = "LabelDateTime";
            LabelDateTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            LabelDateTime.Size = new System.Drawing.Size(771, 32);
            LabelDateTime.TabIndex = 13;
            LabelDateTime.Text = "1/1/1999";
            LabelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelHeader
            // 
            PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PanelHeader.Controls.Add(labelCompanyName);
            PanelHeader.Controls.Add(pictureBoxCompanyLogo);
            PanelHeader.Controls.Add(LabelId);
            PanelHeader.Controls.Add(label1);
            PanelHeader.Location = new System.Drawing.Point(81, 58);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new System.Drawing.Size(835, 173);
            PanelHeader.TabIndex = 0;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCompanyName.Location = new System.Drawing.Point(3, 17);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new System.Drawing.Size(334, 135);
            labelCompanyName.TabIndex = 8;
            labelCompanyName.Text = "اسم الشركة هنا";
            labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxCompanyLogo
            // 
            pictureBoxCompanyLogo.Image = Properties.Resources._2022_09_08_1237341;
            pictureBoxCompanyLogo.Location = new System.Drawing.Point(335, 31);
            pictureBoxCompanyLogo.Name = "pictureBoxCompanyLogo";
            pictureBoxCompanyLogo.Size = new System.Drawing.Size(147, 121);
            pictureBoxCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxCompanyLogo.TabIndex = 0;
            pictureBoxCompanyLogo.TabStop = false;
            // 
            // LabelId
            // 
            LabelId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            LabelId.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelId.Location = new System.Drawing.Point(509, 76);
            LabelId.Name = "LabelId";
            LabelId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            LabelId.Size = new System.Drawing.Size(307, 63);
            LabelId.TabIndex = 11;
            LabelId.Text = "123456789";
            LabelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(646, 31);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label1.Size = new System.Drawing.Size(164, 45);
            label1.TabIndex = 11;
            label1.Text = "معرف العملية:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.35883F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.64117F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 274F));
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(LabelOutComeNo, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(LabelOutComeDate, 1, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 2);
            tableLayoutPanel1.Controls.Add(LabelCustomer, 1, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 3);
            tableLayoutPanel1.Controls.Add(LabelTotalPrice, 1, 3);
            tableLayoutPanel1.Controls.Add(label10, 2, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 3, 2);
            tableLayoutPanel1.Controls.Add(label12, 2, 1);
            tableLayoutPanel1.Controls.Add(label4, 2, 3);
            tableLayoutPanel1.Controls.Add(TextBoxReciveDate, 3, 3);
            tableLayoutPanel1.Location = new System.Drawing.Point(81, 271);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.84615F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.15385F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(820, 230);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(643, 10);
            label3.Name = "label3";
            label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label3.Size = new System.Drawing.Size(164, 37);
            label3.TabIndex = 11;
            label3.Text = "رقم مستند الاخراج:";
            // 
            // LabelOutComeNo
            // 
            LabelOutComeNo.AutoSize = true;
            LabelOutComeNo.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelOutComeNo.Location = new System.Drawing.Point(534, 10);
            LabelOutComeNo.Name = "LabelOutComeNo";
            LabelOutComeNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            LabelOutComeNo.Size = new System.Drawing.Size(72, 37);
            LabelOutComeNo.TabIndex = 11;
            LabelOutComeNo.Text = "13254";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(637, 69);
            label5.Name = "label5";
            label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label5.Size = new System.Drawing.Size(170, 37);
            label5.TabIndex = 11;
            label5.Text = "تاريخ مستند الاخراج:";
            // 
            // LabelOutComeDate
            // 
            LabelOutComeDate.AutoSize = true;
            LabelOutComeDate.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelOutComeDate.Location = new System.Drawing.Point(496, 69);
            LabelOutComeDate.Name = "LabelOutComeDate";
            LabelOutComeDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            LabelOutComeDate.Size = new System.Drawing.Size(110, 37);
            LabelOutComeDate.TabIndex = 11;
            LabelOutComeDate.Text = "11/5/2022";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(690, 119);
            label7.Name = "label7";
            label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label7.Size = new System.Drawing.Size(117, 37);
            label7.TabIndex = 11;
            label7.Text = "اسم الوحدة:";
            // 
            // LabelCustomer
            // 
            LabelCustomer.AutoSize = true;
            LabelCustomer.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelCustomer.Location = new System.Drawing.Point(467, 119);
            LabelCustomer.Name = "LabelCustomer";
            LabelCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            LabelCustomer.Size = new System.Drawing.Size(139, 37);
            LabelCustomer.TabIndex = 11;
            LabelCustomer.Text = "وحدة الحسابات";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(663, 169);
            label9.Name = "label9";
            label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label9.Size = new System.Drawing.Size(144, 37);
            label9.TabIndex = 11;
            label9.Text = "المجموع الكلي:";
            // 
            // LabelTotalPrice
            // 
            LabelTotalPrice.AutoSize = true;
            LabelTotalPrice.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelTotalPrice.Location = new System.Drawing.Point(461, 169);
            LabelTotalPrice.Name = "LabelTotalPrice";
            LabelTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            LabelTotalPrice.Size = new System.Drawing.Size(145, 37);
            LabelTotalPrice.TabIndex = 11;
            LabelTotalPrice.Text = "126548524 د.ع";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(295, 119);
            label10.Name = "label10";
            label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label10.Size = new System.Drawing.Size(88, 37);
            label10.TabIndex = 11;
            label10.Text = "المستلم:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(47, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(235, 32);
            textBox1.TabIndex = 12;
            textBox1.Text = "اسم المستلم هنا";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(302, 69);
            label12.Name = "label12";
            label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label12.Size = new System.Drawing.Size(81, 37);
            label12.TabIndex = 11;
            label12.Text = "التوقيع:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(314, 169);
            label4.Name = "label4";
            label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label4.Size = new System.Drawing.Size(69, 37);
            label4.TabIndex = 11;
            label4.Text = "التاريخ:";
            // 
            // TextBoxReciveDate
            // 
            TextBoxReciveDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TextBoxReciveDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBoxReciveDate.Location = new System.Drawing.Point(47, 172);
            TextBoxReciveDate.Name = "TextBoxReciveDate";
            TextBoxReciveDate.Size = new System.Drawing.Size(235, 32);
            TextBoxReciveDate.TabIndex = 12;
            TextBoxReciveDate.Text = "/     /   2022";
            TextBoxReciveDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            TextBoxReciveDate.TextChanged += TextBoxReciveDate_TextChanged;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 29;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.Enabled = false;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new System.Drawing.Point(84, 507);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = "لا بيانات";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new System.Drawing.Size(832, 544);
            dataGridView.TabIndex = 6;
            // 
            // printdoc1
            // 
            printdoc1.PrintPage += printdoc1_PrintPage;
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.BackColor = System.Drawing.SystemColors.Control;
            flowLayoutPanelNavBar.Controls.Add(ButtonPreview);
            flowLayoutPanelNavBar.Controls.Add(button1);
            flowLayoutPanelNavBar.Controls.Add(ButtonPageSetup);
            flowLayoutPanelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanelNavBar.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanelNavBar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Padding = new System.Windows.Forms.Padding(5);
            flowLayoutPanelNavBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            flowLayoutPanelNavBar.Size = new System.Drawing.Size(1093, 74);
            flowLayoutPanelNavBar.TabIndex = 2;
            // 
            // ButtonPreview
            // 
            ButtonPreview.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ButtonPreview.Image = Properties.Resources.print_32px;
            ButtonPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ButtonPreview.Location = new System.Drawing.Point(879, 11);
            ButtonPreview.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            ButtonPreview.Name = "ButtonPreview";
            ButtonPreview.Size = new System.Drawing.Size(200, 54);
            ButtonPreview.TabIndex = 5;
            ButtonPreview.Text = "طباعة";
            ButtonPreview.UseVisualStyleBackColor = true;
            ButtonPreview.Click += ButtonPreview_Click;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Image = Properties.Resources.print_32px;
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.Location = new System.Drawing.Point(671, 11);
            button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(200, 54);
            button1.TabIndex = 7;
            button1.Text = "مشاهدة";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ButtonPageSetup
            // 
            ButtonPageSetup.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ButtonPageSetup.Image = Properties.Resources.print_32px;
            ButtonPageSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ButtonPageSetup.Location = new System.Drawing.Point(352, 11);
            ButtonPageSetup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            ButtonPageSetup.Name = "ButtonPageSetup";
            ButtonPageSetup.Size = new System.Drawing.Size(311, 54);
            ButtonPageSetup.TabIndex = 6;
            ButtonPageSetup.Text = "ضبط اعدادات الطباعة";
            ButtonPageSetup.UseVisualStyleBackColor = true;
            ButtonPageSetup.Click += ButtonPageSetup_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            printPreviewDialog1.Document = printdoc1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (System.Drawing.Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.Document = printdoc1;
            printDialog1.UseEXDialog = true;
            // 
            // pageSetupDialog1
            // 
            pageSetupDialog1.Document = printdoc1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.35883F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.64117F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label2.Size = new System.Drawing.Size(1, 37);
            label2.TabIndex = 11;
            label2.Text = "رقم مستند الاخراج:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(-63, 0);
            label8.Name = "label8";
            label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label8.Size = new System.Drawing.Size(1, 37);
            label8.TabIndex = 11;
            label8.Text = "13254";
            // 
            // ReceiptUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1114, 1055);
            Controls.Add(flowLayoutPanelNavBar);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReceiptUserControl";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Activated += ReceiptUserControl_Activated;
            Load += ReceiptUserControl_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompanyLogo).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            flowLayoutPanelNavBar.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Drawing.Printing.PrintDocument printdoc1;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.PictureBox pictureBoxCompanyLogo;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelOutComeNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelOutComeDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LabelCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabelTotalPrice;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNavBar;
        private System.Windows.Forms.Button ButtonPreview;
        private System.Windows.Forms.Button ButtonPageSetup;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelDateTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TextBoxLowEmpTitle;
        private System.Windows.Forms.TextBox TextBoxHighEmpTitle;
        private System.Windows.Forms.TextBox TextBoxLowEmpName;
        private System.Windows.Forms.TextBox TextBoxHighEmpName;
        private System.Windows.Forms.TextBox TextBoxDateTimeLowerEmp;
        private System.Windows.Forms.TextBox TextBoxDateTimeHigherEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxReciveDate;
    }
}
