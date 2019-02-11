namespace ConnectFourFormApp
{
    partial class ConnectFourApp
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtBxPlayer = new System.Windows.Forms.TextBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lbl00 = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.lbl03 = new System.Windows.Forms.Label();
            this.lbl04 = new System.Windows.Forms.Label();
            this.lbl05 = new System.Windows.Forms.Label();
            this.lbl06 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl13 = new System.Windows.Forms.Label();
            this.lbl14 = new System.Windows.Forms.Label();
            this.lbl15 = new System.Windows.Forms.Label();
            this.lbl16 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lbl21 = new System.Windows.Forms.Label();
            this.lbl22 = new System.Windows.Forms.Label();
            this.lbl23 = new System.Windows.Forms.Label();
            this.lbl24 = new System.Windows.Forms.Label();
            this.lbl25 = new System.Windows.Forms.Label();
            this.lbl26 = new System.Windows.Forms.Label();
            this.lbl30 = new System.Windows.Forms.Label();
            this.lbl31 = new System.Windows.Forms.Label();
            this.lbl32 = new System.Windows.Forms.Label();
            this.lbl33 = new System.Windows.Forms.Label();
            this.lbl34 = new System.Windows.Forms.Label();
            this.lbl35 = new System.Windows.Forms.Label();
            this.lbl36 = new System.Windows.Forms.Label();
            this.lbl40 = new System.Windows.Forms.Label();
            this.lbl41 = new System.Windows.Forms.Label();
            this.lbl42 = new System.Windows.Forms.Label();
            this.lbl43 = new System.Windows.Forms.Label();
            this.lbl44 = new System.Windows.Forms.Label();
            this.lbl45 = new System.Windows.Forms.Label();
            this.lbl46 = new System.Windows.Forms.Label();
            this.lbl50 = new System.Windows.Forms.Label();
            this.lbl51 = new System.Windows.Forms.Label();
            this.lbl52 = new System.Windows.Forms.Label();
            this.lbl53 = new System.Windows.Forms.Label();
            this.lbl54 = new System.Windows.Forms.Label();
            this.lbl55 = new System.Windows.Forms.Label();
            this.lbl56 = new System.Windows.Forms.Label();
            this.txtBxColNum = new System.Windows.Forms.TextBox();
            this.lblColNum = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(73, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(272, 36);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "CONNECT FOUR";
            // 
            // btnPlace
            // 
            this.btnPlace.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlace.Location = new System.Drawing.Point(79, 322);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(103, 47);
            this.btnPlace.TabIndex = 5;
            this.btnPlace.Text = "PLACE CHECKER";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Visible = false;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(91, 384);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 49);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(248, 390);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 36);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtBxPlayer
            // 
            this.txtBxPlayer.Location = new System.Drawing.Point(234, 349);
            this.txtBxPlayer.Name = "txtBxPlayer";
            this.txtBxPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtBxPlayer.TabIndex = 8;
            this.txtBxPlayer.Visible = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.Lime;
            this.lblPlayer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(230, 322);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(114, 24);
            this.lblPlayer.TabIndex = 9;
            this.lblPlayer.Text = "Player Turn";
            this.lblPlayer.Visible = false;
            // 
            // lbl00
            // 
            this.lbl00.BackColor = System.Drawing.Color.White;
            this.lbl00.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl00.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl00.Location = new System.Drawing.Point(79, 108);
            this.lbl00.Name = "lbl00";
            this.lbl00.Size = new System.Drawing.Size(20, 20);
            this.lbl00.TabIndex = 3;
            this.lbl00.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl01
            // 
            this.lbl01.BackColor = System.Drawing.Color.White;
            this.lbl01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl01.Location = new System.Drawing.Point(118, 108);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(20, 20);
            this.lbl01.TabIndex = 4;
            // 
            // lbl02
            // 
            this.lbl02.BackColor = System.Drawing.Color.White;
            this.lbl02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl02.Location = new System.Drawing.Point(155, 108);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(20, 20);
            this.lbl02.TabIndex = 5;
            // 
            // lbl03
            // 
            this.lbl03.BackColor = System.Drawing.Color.White;
            this.lbl03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl03.Location = new System.Drawing.Point(192, 108);
            this.lbl03.Name = "lbl03";
            this.lbl03.Size = new System.Drawing.Size(20, 20);
            this.lbl03.TabIndex = 6;
            // 
            // lbl04
            // 
            this.lbl04.BackColor = System.Drawing.Color.White;
            this.lbl04.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl04.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl04.Location = new System.Drawing.Point(229, 108);
            this.lbl04.Name = "lbl04";
            this.lbl04.Size = new System.Drawing.Size(20, 20);
            this.lbl04.TabIndex = 5;
            // 
            // lbl05
            // 
            this.lbl05.BackColor = System.Drawing.Color.White;
            this.lbl05.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl05.Location = new System.Drawing.Point(266, 108);
            this.lbl05.Name = "lbl05";
            this.lbl05.Size = new System.Drawing.Size(20, 20);
            this.lbl05.TabIndex = 5;
            // 
            // lbl06
            // 
            this.lbl06.BackColor = System.Drawing.Color.White;
            this.lbl06.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl06.Location = new System.Drawing.Point(303, 108);
            this.lbl06.Name = "lbl06";
            this.lbl06.Size = new System.Drawing.Size(20, 20);
            this.lbl06.TabIndex = 5;
            // 
            // lbl10
            // 
            this.lbl10.BackColor = System.Drawing.Color.White;
            this.lbl10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl10.Location = new System.Drawing.Point(79, 144);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(20, 20);
            this.lbl10.TabIndex = 5;
            // 
            // lbl11
            // 
            this.lbl11.BackColor = System.Drawing.Color.White;
            this.lbl11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl11.Location = new System.Drawing.Point(118, 144);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(20, 20);
            this.lbl11.TabIndex = 5;
            // 
            // lbl12
            // 
            this.lbl12.BackColor = System.Drawing.Color.White;
            this.lbl12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl12.Location = new System.Drawing.Point(155, 144);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(20, 20);
            this.lbl12.TabIndex = 5;
            // 
            // lbl13
            // 
            this.lbl13.BackColor = System.Drawing.Color.White;
            this.lbl13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl13.Location = new System.Drawing.Point(192, 144);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(20, 20);
            this.lbl13.TabIndex = 5;
            // 
            // lbl14
            // 
            this.lbl14.BackColor = System.Drawing.Color.White;
            this.lbl14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl14.Location = new System.Drawing.Point(229, 144);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(20, 20);
            this.lbl14.TabIndex = 5;
            // 
            // lbl15
            // 
            this.lbl15.BackColor = System.Drawing.Color.White;
            this.lbl15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl15.Location = new System.Drawing.Point(266, 144);
            this.lbl15.Name = "lbl15";
            this.lbl15.Size = new System.Drawing.Size(20, 20);
            this.lbl15.TabIndex = 5;
            // 
            // lbl16
            // 
            this.lbl16.BackColor = System.Drawing.Color.White;
            this.lbl16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl16.Location = new System.Drawing.Point(303, 144);
            this.lbl16.Name = "lbl16";
            this.lbl16.Size = new System.Drawing.Size(20, 20);
            this.lbl16.TabIndex = 5;
            // 
            // lbl20
            // 
            this.lbl20.BackColor = System.Drawing.Color.White;
            this.lbl20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl20.Location = new System.Drawing.Point(79, 177);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(20, 20);
            this.lbl20.TabIndex = 5;
            // 
            // lbl21
            // 
            this.lbl21.BackColor = System.Drawing.Color.White;
            this.lbl21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl21.Location = new System.Drawing.Point(118, 177);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new System.Drawing.Size(20, 20);
            this.lbl21.TabIndex = 5;
            // 
            // lbl22
            // 
            this.lbl22.BackColor = System.Drawing.Color.White;
            this.lbl22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl22.Location = new System.Drawing.Point(155, 177);
            this.lbl22.Name = "lbl22";
            this.lbl22.Size = new System.Drawing.Size(20, 20);
            this.lbl22.TabIndex = 5;
            // 
            // lbl23
            // 
            this.lbl23.BackColor = System.Drawing.Color.White;
            this.lbl23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl23.Location = new System.Drawing.Point(192, 177);
            this.lbl23.Name = "lbl23";
            this.lbl23.Size = new System.Drawing.Size(20, 20);
            this.lbl23.TabIndex = 5;
            // 
            // lbl24
            // 
            this.lbl24.BackColor = System.Drawing.Color.White;
            this.lbl24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl24.Location = new System.Drawing.Point(229, 177);
            this.lbl24.Name = "lbl24";
            this.lbl24.Size = new System.Drawing.Size(20, 20);
            this.lbl24.TabIndex = 5;
            // 
            // lbl25
            // 
            this.lbl25.BackColor = System.Drawing.Color.White;
            this.lbl25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl25.Location = new System.Drawing.Point(266, 177);
            this.lbl25.Name = "lbl25";
            this.lbl25.Size = new System.Drawing.Size(20, 20);
            this.lbl25.TabIndex = 5;
            // 
            // lbl26
            // 
            this.lbl26.BackColor = System.Drawing.Color.White;
            this.lbl26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl26.Location = new System.Drawing.Point(303, 177);
            this.lbl26.Name = "lbl26";
            this.lbl26.Size = new System.Drawing.Size(20, 20);
            this.lbl26.TabIndex = 5;
            // 
            // lbl30
            // 
            this.lbl30.BackColor = System.Drawing.Color.White;
            this.lbl30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl30.Location = new System.Drawing.Point(79, 211);
            this.lbl30.Name = "lbl30";
            this.lbl30.Size = new System.Drawing.Size(20, 20);
            this.lbl30.TabIndex = 7;
            // 
            // lbl31
            // 
            this.lbl31.BackColor = System.Drawing.Color.White;
            this.lbl31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl31.Location = new System.Drawing.Point(118, 211);
            this.lbl31.Name = "lbl31";
            this.lbl31.Size = new System.Drawing.Size(20, 20);
            this.lbl31.TabIndex = 8;
            // 
            // lbl32
            // 
            this.lbl32.BackColor = System.Drawing.Color.White;
            this.lbl32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl32.Location = new System.Drawing.Point(155, 211);
            this.lbl32.Name = "lbl32";
            this.lbl32.Size = new System.Drawing.Size(20, 20);
            this.lbl32.TabIndex = 9;
            // 
            // lbl33
            // 
            this.lbl33.BackColor = System.Drawing.Color.White;
            this.lbl33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl33.Location = new System.Drawing.Point(192, 211);
            this.lbl33.Name = "lbl33";
            this.lbl33.Size = new System.Drawing.Size(20, 20);
            this.lbl33.TabIndex = 10;
            // 
            // lbl34
            // 
            this.lbl34.BackColor = System.Drawing.Color.White;
            this.lbl34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl34.Location = new System.Drawing.Point(229, 211);
            this.lbl34.Name = "lbl34";
            this.lbl34.Size = new System.Drawing.Size(20, 20);
            this.lbl34.TabIndex = 11;
            // 
            // lbl35
            // 
            this.lbl35.BackColor = System.Drawing.Color.White;
            this.lbl35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl35.Location = new System.Drawing.Point(266, 211);
            this.lbl35.Name = "lbl35";
            this.lbl35.Size = new System.Drawing.Size(20, 20);
            this.lbl35.TabIndex = 12;
            // 
            // lbl36
            // 
            this.lbl36.BackColor = System.Drawing.Color.White;
            this.lbl36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl36.Location = new System.Drawing.Point(303, 211);
            this.lbl36.Name = "lbl36";
            this.lbl36.Size = new System.Drawing.Size(20, 20);
            this.lbl36.TabIndex = 13;
            // 
            // lbl40
            // 
            this.lbl40.BackColor = System.Drawing.Color.White;
            this.lbl40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40.Location = new System.Drawing.Point(79, 245);
            this.lbl40.Name = "lbl40";
            this.lbl40.Size = new System.Drawing.Size(20, 20);
            this.lbl40.TabIndex = 14;
            // 
            // lbl41
            // 
            this.lbl41.BackColor = System.Drawing.Color.White;
            this.lbl41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl41.Location = new System.Drawing.Point(118, 245);
            this.lbl41.Name = "lbl41";
            this.lbl41.Size = new System.Drawing.Size(20, 20);
            this.lbl41.TabIndex = 15;
            // 
            // lbl42
            // 
            this.lbl42.BackColor = System.Drawing.Color.White;
            this.lbl42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl42.Location = new System.Drawing.Point(155, 245);
            this.lbl42.Name = "lbl42";
            this.lbl42.Size = new System.Drawing.Size(20, 20);
            this.lbl42.TabIndex = 16;
            // 
            // lbl43
            // 
            this.lbl43.BackColor = System.Drawing.Color.White;
            this.lbl43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl43.Location = new System.Drawing.Point(192, 245);
            this.lbl43.Name = "lbl43";
            this.lbl43.Size = new System.Drawing.Size(20, 20);
            this.lbl43.TabIndex = 17;
            // 
            // lbl44
            // 
            this.lbl44.BackColor = System.Drawing.Color.White;
            this.lbl44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl44.Location = new System.Drawing.Point(229, 245);
            this.lbl44.Name = "lbl44";
            this.lbl44.Size = new System.Drawing.Size(20, 20);
            this.lbl44.TabIndex = 18;
            // 
            // lbl45
            // 
            this.lbl45.BackColor = System.Drawing.Color.White;
            this.lbl45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl45.Location = new System.Drawing.Point(266, 245);
            this.lbl45.Name = "lbl45";
            this.lbl45.Size = new System.Drawing.Size(20, 20);
            this.lbl45.TabIndex = 19;
            // 
            // lbl46
            // 
            this.lbl46.BackColor = System.Drawing.Color.White;
            this.lbl46.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl46.Location = new System.Drawing.Point(303, 245);
            this.lbl46.Name = "lbl46";
            this.lbl46.Size = new System.Drawing.Size(20, 20);
            this.lbl46.TabIndex = 20;
            // 
            // lbl50
            // 
            this.lbl50.BackColor = System.Drawing.Color.White;
            this.lbl50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl50.Location = new System.Drawing.Point(79, 277);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(20, 20);
            this.lbl50.TabIndex = 21;
            // 
            // lbl51
            // 
            this.lbl51.BackColor = System.Drawing.Color.White;
            this.lbl51.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl51.Location = new System.Drawing.Point(118, 277);
            this.lbl51.Name = "lbl51";
            this.lbl51.Size = new System.Drawing.Size(20, 20);
            this.lbl51.TabIndex = 22;
            // 
            // lbl52
            // 
            this.lbl52.BackColor = System.Drawing.Color.White;
            this.lbl52.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl52.Location = new System.Drawing.Point(155, 277);
            this.lbl52.Name = "lbl52";
            this.lbl52.Size = new System.Drawing.Size(20, 20);
            this.lbl52.TabIndex = 23;
            // 
            // lbl53
            // 
            this.lbl53.BackColor = System.Drawing.Color.White;
            this.lbl53.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl53.Location = new System.Drawing.Point(192, 277);
            this.lbl53.Name = "lbl53";
            this.lbl53.Size = new System.Drawing.Size(20, 20);
            this.lbl53.TabIndex = 24;
            // 
            // lbl54
            // 
            this.lbl54.BackColor = System.Drawing.Color.White;
            this.lbl54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl54.Location = new System.Drawing.Point(229, 277);
            this.lbl54.Name = "lbl54";
            this.lbl54.Size = new System.Drawing.Size(20, 20);
            this.lbl54.TabIndex = 25;
            // 
            // lbl55
            // 
            this.lbl55.BackColor = System.Drawing.Color.White;
            this.lbl55.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl55.Location = new System.Drawing.Point(266, 277);
            this.lbl55.Name = "lbl55";
            this.lbl55.Size = new System.Drawing.Size(20, 20);
            this.lbl55.TabIndex = 26;
            // 
            // lbl56
            // 
            this.lbl56.BackColor = System.Drawing.Color.White;
            this.lbl56.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl56.Location = new System.Drawing.Point(303, 277);
            this.lbl56.Name = "lbl56";
            this.lbl56.Size = new System.Drawing.Size(20, 20);
            this.lbl56.TabIndex = 27;
            // 
            // txtBxColNum
            // 
            this.txtBxColNum.Location = new System.Drawing.Point(223, 67);
            this.txtBxColNum.Name = "txtBxColNum";
            this.txtBxColNum.Size = new System.Drawing.Size(100, 20);
            this.txtBxColNum.TabIndex = 28;
            // 
            // lblColNum
            // 
            this.lblColNum.AutoSize = true;
            this.lblColNum.BackColor = System.Drawing.Color.Lime;
            this.lblColNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColNum.Location = new System.Drawing.Point(138, 66);
            this.lblColNum.Name = "lblColNum";
            this.lblColNum.Size = new System.Drawing.Size(74, 21);
            this.lblColNum.TabIndex = 29;
            this.lblColNum.Text = "Column #";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(433, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ConnectFourApp
            // 
            this.AcceptButton = this.btnPlace;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(433, 442);
            this.Controls.Add(this.lblColNum);
            this.Controls.Add(this.txtBxColNum);
            this.Controls.Add(this.lbl56);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lbl55);
            this.Controls.Add(this.txtBxPlayer);
            this.Controls.Add(this.lbl54);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbl53);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbl52);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.lbl51);
            this.Controls.Add(this.lbl50);
            this.Controls.Add(this.lbl46);
            this.Controls.Add(this.lbl45);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lbl44);
            this.Controls.Add(this.lbl00);
            this.Controls.Add(this.lbl43);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.lbl42);
            this.Controls.Add(this.lbl02);
            this.Controls.Add(this.lbl41);
            this.Controls.Add(this.lbl03);
            this.Controls.Add(this.lbl40);
            this.Controls.Add(this.lbl04);
            this.Controls.Add(this.lbl36);
            this.Controls.Add(this.lbl05);
            this.Controls.Add(this.lbl35);
            this.Controls.Add(this.lbl06);
            this.Controls.Add(this.lbl34);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl33);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.lbl32);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.lbl31);
            this.Controls.Add(this.lbl13);
            this.Controls.Add(this.lbl30);
            this.Controls.Add(this.lbl14);
            this.Controls.Add(this.lbl26);
            this.Controls.Add(this.lbl15);
            this.Controls.Add(this.lbl25);
            this.Controls.Add(this.lbl16);
            this.Controls.Add(this.lbl24);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.lbl23);
            this.Controls.Add(this.lbl21);
            this.Controls.Add(this.lbl22);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConnectFourApp";
            this.Text = "Connect Four App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectFourApp_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtBxPlayer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lbl00;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.Label lbl03;
        private System.Windows.Forms.Label lbl04;
        private System.Windows.Forms.Label lbl05;
        private System.Windows.Forms.Label lbl06;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.Label lbl15;
        private System.Windows.Forms.Label lbl16;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lbl21;
        private System.Windows.Forms.Label lbl22;
        private System.Windows.Forms.Label lbl23;
        private System.Windows.Forms.Label lbl24;
        private System.Windows.Forms.Label lbl25;
        private System.Windows.Forms.Label lbl26;
        private System.Windows.Forms.Label lbl30;
        private System.Windows.Forms.Label lbl31;
        private System.Windows.Forms.Label lbl32;
        private System.Windows.Forms.Label lbl33;
        private System.Windows.Forms.Label lbl34;
        private System.Windows.Forms.Label lbl35;
        private System.Windows.Forms.Label lbl36;
        private System.Windows.Forms.Label lbl40;
        private System.Windows.Forms.Label lbl41;
        private System.Windows.Forms.Label lbl42;
        private System.Windows.Forms.Label lbl43;
        private System.Windows.Forms.Label lbl44;
        private System.Windows.Forms.Label lbl45;
        private System.Windows.Forms.Label lbl46;
        private System.Windows.Forms.Label lbl50;
        private System.Windows.Forms.Label lbl51;
        private System.Windows.Forms.Label lbl52;
        private System.Windows.Forms.Label lbl53;
        private System.Windows.Forms.Label lbl54;
        private System.Windows.Forms.Label lbl55;
        private System.Windows.Forms.Label lbl56;
        private System.Windows.Forms.TextBox txtBxColNum;
        private System.Windows.Forms.Label lblColNum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

