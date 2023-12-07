namespace _20222263_손어진
{
    partial class Form2
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
            this.bt_delete = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.PlusButton = new System.Windows.Forms.Button();
            this.thirdGrade = new System.Windows.Forms.ComboBox();
            this.secondGrade = new System.Windows.Forms.ComboBox();
            this.fourthGrade = new System.Windows.Forms.ComboBox();
            this.firstGrade = new System.Windows.Forms.ComboBox();
            this.grade = new System.Windows.Forms.ComboBox();
            this.TimeTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(480, 729);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(106, 21);
            this.bt_delete.TabIndex = 23;
            this.bt_delete.Text = "삭제";
            this.bt_delete.UseVisualStyleBackColor = true;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(358, 702);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(116, 21);
            this.TextBox.TabIndex = 22;
            this.TextBox.Text = "입력";
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(480, 702);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(106, 21);
            this.PlusButton.TabIndex = 21;
            this.PlusButton.Text = "추가";
            this.PlusButton.UseVisualStyleBackColor = true;
            // 
            // thirdGrade
            // 
            this.thirdGrade.FormattingEnabled = true;
            this.thirdGrade.Items.AddRange(new object[] {
            "안전 및 조직관례사례연구",
            "데이터베이스",
            "정보보안",
            "기업연계 프로젝트",
            "빅데이터",
            "스마트 디바이스",
            "컴퓨터 네트워크",
            "데이터베이스",
            "영상처리",
            "정보보안",
            "스마트 디바이스"});
            this.thirdGrade.Location = new System.Drawing.Point(134, 702);
            this.thirdGrade.Name = "thirdGrade";
            this.thirdGrade.Size = new System.Drawing.Size(202, 20);
            this.thirdGrade.TabIndex = 20;
            this.thirdGrade.Visible = false;
            // 
            // secondGrade
            // 
            this.secondGrade.FormattingEnabled = true;
            this.secondGrade.Items.AddRange(new object[] {
            "데이터 구조",
            "웹 프로그래밍",
            "이산수학",
            "JAVA와 객체지향 프로그래밍",
            "대학생을 위한 기본수학",
            "컴퓨터활용1",
            "컴퓨터 조직",
            "프로그래밍 언어론",
            "알고리즘",
            "오픈소스 SW응용",
            "통계분석의 이해",
            "윈도우 프로그래밍"});
            this.secondGrade.Location = new System.Drawing.Point(134, 702);
            this.secondGrade.Name = "secondGrade";
            this.secondGrade.Size = new System.Drawing.Size(202, 20);
            this.secondGrade.TabIndex = 19;
            this.secondGrade.Visible = false;
            // 
            // fourthGrade
            // 
            this.fourthGrade.FormattingEnabled = true;
            this.fourthGrade.Items.AddRange(new object[] {
            "사물 인터넷 응용",
            "졸업 논문",
            "분산 시스템",
            "산학 옴니버스 강좌",
            "지능 정보 시스템",
            "빅데이터 시스템"});
            this.fourthGrade.Location = new System.Drawing.Point(134, 701);
            this.fourthGrade.Name = "fourthGrade";
            this.fourthGrade.Size = new System.Drawing.Size(202, 20);
            this.fourthGrade.TabIndex = 18;
            this.fourthGrade.Visible = false;
            // 
            // firstGrade
            // 
            this.firstGrade.FormattingEnabled = true;
            this.firstGrade.Items.AddRange(new object[] {
            "종교와 원불교",
            "대학생활과 자기혁신",
            "컴퓨팅적 사고력",
            "C언어 및 실습",
            "컴퓨터 개론",
            "문학과 문화 콘텐츠",
            "실무 원어민 영어1",
            "실무 원어민 영어2",
            "IT융합기술 및 이해",
            "파이썬 프로그래밍",
            "고급 프로그래밍 언어 및 실습"});
            this.firstGrade.Location = new System.Drawing.Point(134, 701);
            this.firstGrade.Name = "firstGrade";
            this.firstGrade.Size = new System.Drawing.Size(202, 20);
            this.firstGrade.TabIndex = 17;
            this.firstGrade.Visible = false;
            // 
            // grade
            // 
            this.grade.FormattingEnabled = true;
            this.grade.Items.AddRange(new object[] {
            "1학년",
            "2학년",
            "3학년",
            "4학년"});
            this.grade.Location = new System.Drawing.Point(23, 702);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(90, 20);
            this.grade.TabIndex = 16;
            // 
            // TimeTable
            // 
            this.TimeTable.ColumnHeadersHeight = 46;
            this.TimeTable.Location = new System.Drawing.Point(18, 31);
            this.TimeTable.Name = "TimeTable";
            this.TimeTable.RowHeadersWidth = 82;
            this.TimeTable.RowTemplate.Height = 23;
            this.TimeTable.Size = new System.Drawing.Size(674, 665);
            this.TimeTable.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 780);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.thirdGrade);
            this.Controls.Add(this.secondGrade);
            this.Controls.Add(this.fourthGrade);
            this.Controls.Add(this.firstGrade);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.TimeTable);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.TimeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.ComboBox thirdGrade;
        private System.Windows.Forms.ComboBox secondGrade;
        private System.Windows.Forms.ComboBox fourthGrade;
        private System.Windows.Forms.ComboBox firstGrade;
        private System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.DataGridView TimeTable;
    }
}