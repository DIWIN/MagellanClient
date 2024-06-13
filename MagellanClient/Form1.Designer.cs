namespace MagellanClient
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
            this.groupBox_Connect = new System.Windows.Forms.GroupBox();
            this.button_PlateIn = new System.Windows.Forms.Button();
            this.button_PlateOut = new System.Windows.Forms.Button();
            this.button_GetLastError = new System.Windows.Forms.Button();
            this.button_ResetLastError = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.groupBox_Output = new System.Windows.Forms.GroupBox();
            this.richTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.groupBox_Methods = new System.Windows.Forms.GroupBox();
            this.button_AvailableMethods = new System.Windows.Forms.Button();
            this.groupBox_Workspace = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_StdEx = new System.Windows.Forms.Button();
            this.button_OpenLastWorkspace = new System.Windows.Forms.Button();
            this.button_StopRun = new System.Windows.Forms.Button();
            this.button_TestForEVO = new System.Windows.Forms.Button();
            this.numericUpDown_ExpGrp = new System.Windows.Forms.NumericUpDown();
            this.label_ExpGrp = new System.Windows.Forms.Label();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.button_StandardFileLocation = new System.Windows.Forms.Button();
            this.textBox_AuditTrailComment = new System.Windows.Forms.TextBox();
            this.textBox_FileRemark = new System.Windows.Forms.TextBox();
            this.label_AuditTrail = new System.Windows.Forms.Label();
            this.label_FileRemark = new System.Windows.Forms.Label();
            this.button_SaveStandards = new System.Windows.Forms.Button();
            this.button_SaveWorkspace = new System.Windows.Forms.Button();
            this.button_DataExport = new System.Windows.Forms.Button();
            this.button_StartRun = new System.Windows.Forms.Button();
            this.textBox_Filename = new System.Windows.Forms.TextBox();
            this.button_SetFileName = new System.Windows.Forms.Button();
            this.comboBox_Methods = new System.Windows.Forms.ComboBox();
            this.button_InsertMethod = new System.Windows.Forms.Button();
            this.button_SetEmpty = new System.Windows.Forms.Button();
            this.button_ModifyLyout = new System.Windows.Forms.Button();
            this.groupBox_Data = new System.Windows.Forms.GroupBox();
            this.button_DataAsTable = new System.Windows.Forms.Button();
            this.comboBox_DataNames = new System.Windows.Forms.ComboBox();
            this.button_DataNames = new System.Windows.Forms.Button();
            this.groupBox_Layout = new System.Windows.Forms.GroupBox();
            this.button_Samples = new System.Windows.Forms.Button();
            this.groupBox_Magellan = new System.Windows.Forms.GroupBox();
            this.textBox_Pwd = new System.Windows.Forms.TextBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label_Pwd = new System.Windows.Forms.Label();
            this.label_Login = new System.Windows.Forms.Label();
            this.comboBox_DeviceName = new System.Windows.Forms.ComboBox();
            this.button_Name = new System.Windows.Forms.Button();
            this.button_Create = new System.Windows.Forms.Button();
            this.saveFileDialogStandards = new System.Windows.Forms.SaveFileDialog();
            this.groupBox_Connect.SuspendLayout();
            this.groupBox_Output.SuspendLayout();
            this.groupBox_Methods.SuspendLayout();
            this.groupBox_Workspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ExpGrp)).BeginInit();
            this.groupBox_Data.SuspendLayout();
            this.groupBox_Layout.SuspendLayout();
            this.groupBox_Magellan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Connect
            // 
            this.groupBox_Connect.Controls.Add(this.button_PlateIn);
            this.groupBox_Connect.Controls.Add(this.button_PlateOut);
            this.groupBox_Connect.Controls.Add(this.button_GetLastError);
            this.groupBox_Connect.Controls.Add(this.button_ResetLastError);
            this.groupBox_Connect.Controls.Add(this.button_Disconnect);
            this.groupBox_Connect.Controls.Add(this.button_Connect);
            this.groupBox_Connect.Location = new System.Drawing.Point(20, 180);
            this.groupBox_Connect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Connect.Name = "groupBox_Connect";
            this.groupBox_Connect.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Connect.Size = new System.Drawing.Size(796, 138);
            this.groupBox_Connect.TabIndex = 0;
            this.groupBox_Connect.TabStop = false;
            this.groupBox_Connect.Text = "Instrument Functions";
            // 
            // button_PlateIn
            // 
            this.button_PlateIn.Location = new System.Drawing.Point(366, 75);
            this.button_PlateIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_PlateIn.Name = "button_PlateIn";
            this.button_PlateIn.Size = new System.Drawing.Size(171, 35);
            this.button_PlateIn.TabIndex = 6;
            this.button_PlateIn.Text = "Plate in";
            this.button_PlateIn.UseVisualStyleBackColor = true;
            this.button_PlateIn.Click += new System.EventHandler(this.button_PlateIn_Click);
            // 
            // button_PlateOut
            // 
            this.button_PlateOut.Location = new System.Drawing.Point(366, 29);
            this.button_PlateOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_PlateOut.Name = "button_PlateOut";
            this.button_PlateOut.Size = new System.Drawing.Size(171, 35);
            this.button_PlateOut.TabIndex = 5;
            this.button_PlateOut.Text = "Plate out";
            this.button_PlateOut.UseVisualStyleBackColor = true;
            this.button_PlateOut.Click += new System.EventHandler(this.button_PlateOut_Click);
            // 
            // button_GetLastError
            // 
            this.button_GetLastError.Location = new System.Drawing.Point(189, 77);
            this.button_GetLastError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_GetLastError.Name = "button_GetLastError";
            this.button_GetLastError.Size = new System.Drawing.Size(166, 35);
            this.button_GetLastError.TabIndex = 4;
            this.button_GetLastError.Text = "Get Last Error";
            this.button_GetLastError.UseVisualStyleBackColor = true;
            this.button_GetLastError.Click += new System.EventHandler(this.button_GetLastError_Click);
            // 
            // button_ResetLastError
            // 
            this.button_ResetLastError.Location = new System.Drawing.Point(188, 31);
            this.button_ResetLastError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ResetLastError.Name = "button_ResetLastError";
            this.button_ResetLastError.Size = new System.Drawing.Size(168, 35);
            this.button_ResetLastError.TabIndex = 3;
            this.button_ResetLastError.Text = "ResetLastError";
            this.button_ResetLastError.UseVisualStyleBackColor = true;
            this.button_ResetLastError.Click += new System.EventHandler(this.button_ResetLastError_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Location = new System.Drawing.Point(10, 77);
            this.button_Disconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(168, 35);
            this.button_Disconnect.TabIndex = 1;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(10, 31);
            this.button_Connect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(168, 35);
            this.button_Connect.TabIndex = 0;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // groupBox_Output
            // 
            this.groupBox_Output.Controls.Add(this.richTextBox_Output);
            this.groupBox_Output.Location = new System.Drawing.Point(825, 20);
            this.groupBox_Output.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Output.Name = "groupBox_Output";
            this.groupBox_Output.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Output.Size = new System.Drawing.Size(987, 1089);
            this.groupBox_Output.TabIndex = 1;
            this.groupBox_Output.TabStop = false;
            this.groupBox_Output.Text = "Output";
            // 
            // richTextBox_Output
            // 
            this.richTextBox_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Output.ForeColor = System.Drawing.SystemColors.Highlight;
            this.richTextBox_Output.Location = new System.Drawing.Point(4, 24);
            this.richTextBox_Output.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox_Output.Name = "richTextBox_Output";
            this.richTextBox_Output.Size = new System.Drawing.Size(979, 1060);
            this.richTextBox_Output.TabIndex = 0;
            this.richTextBox_Output.Text = "";
            // 
            // groupBox_Methods
            // 
            this.groupBox_Methods.Controls.Add(this.button_AvailableMethods);
            this.groupBox_Methods.Location = new System.Drawing.Point(20, 329);
            this.groupBox_Methods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Methods.Name = "groupBox_Methods";
            this.groupBox_Methods.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Methods.Size = new System.Drawing.Size(796, 91);
            this.groupBox_Methods.TabIndex = 2;
            this.groupBox_Methods.TabStop = false;
            this.groupBox_Methods.Text = "Methods";
            // 
            // button_AvailableMethods
            // 
            this.button_AvailableMethods.Location = new System.Drawing.Point(10, 31);
            this.button_AvailableMethods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_AvailableMethods.Name = "button_AvailableMethods";
            this.button_AvailableMethods.Size = new System.Drawing.Size(168, 35);
            this.button_AvailableMethods.TabIndex = 0;
            this.button_AvailableMethods.Text = "Available Methods";
            this.button_AvailableMethods.UseVisualStyleBackColor = true;
            this.button_AvailableMethods.Click += new System.EventHandler(this.button_AvailableMethods_Click);
            // 
            // groupBox_Workspace
            // 
            this.groupBox_Workspace.Controls.Add(this.button1);
            this.groupBox_Workspace.Controls.Add(this.button_StdEx);
            this.groupBox_Workspace.Controls.Add(this.button_OpenLastWorkspace);
            this.groupBox_Workspace.Controls.Add(this.button_StopRun);
            this.groupBox_Workspace.Controls.Add(this.button_TestForEVO);
            this.groupBox_Workspace.Controls.Add(this.numericUpDown_ExpGrp);
            this.groupBox_Workspace.Controls.Add(this.label_ExpGrp);
            this.groupBox_Workspace.Controls.Add(this.textBox_FilePath);
            this.groupBox_Workspace.Controls.Add(this.button_StandardFileLocation);
            this.groupBox_Workspace.Controls.Add(this.textBox_AuditTrailComment);
            this.groupBox_Workspace.Controls.Add(this.textBox_FileRemark);
            this.groupBox_Workspace.Controls.Add(this.label_AuditTrail);
            this.groupBox_Workspace.Controls.Add(this.label_FileRemark);
            this.groupBox_Workspace.Controls.Add(this.button_SaveStandards);
            this.groupBox_Workspace.Controls.Add(this.button_SaveWorkspace);
            this.groupBox_Workspace.Controls.Add(this.button_DataExport);
            this.groupBox_Workspace.Controls.Add(this.button_StartRun);
            this.groupBox_Workspace.Controls.Add(this.textBox_Filename);
            this.groupBox_Workspace.Controls.Add(this.button_SetFileName);
            this.groupBox_Workspace.Controls.Add(this.comboBox_Methods);
            this.groupBox_Workspace.Controls.Add(this.button_InsertMethod);
            this.groupBox_Workspace.Controls.Add(this.button_SetEmpty);
            this.groupBox_Workspace.Location = new System.Drawing.Point(20, 434);
            this.groupBox_Workspace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Workspace.Name = "groupBox_Workspace";
            this.groupBox_Workspace.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Workspace.Size = new System.Drawing.Size(796, 452);
            this.groupBox_Workspace.TabIndex = 3;
            this.groupBox_Workspace.TabStop = false;
            this.groupBox_Workspace.Text = "Workspace";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 126);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Update Standards Ex";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_StdEx
            // 
            this.button_StdEx.Location = new System.Drawing.Point(580, 274);
            this.button_StdEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_StdEx.Name = "button_StdEx";
            this.button_StdEx.Size = new System.Drawing.Size(206, 35);
            this.button_StdEx.TabIndex = 19;
            this.button_StdEx.Text = "Save Standards Ex";
            this.button_StdEx.UseVisualStyleBackColor = true;
            this.button_StdEx.Click += new System.EventHandler(this.button_StdEx_Click);
            // 
            // button_OpenLastWorkspace
            // 
            this.button_OpenLastWorkspace.Location = new System.Drawing.Point(426, 183);
            this.button_OpenLastWorkspace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_OpenLastWorkspace.Name = "button_OpenLastWorkspace";
            this.button_OpenLastWorkspace.Size = new System.Drawing.Size(360, 35);
            this.button_OpenLastWorkspace.TabIndex = 18;
            this.button_OpenLastWorkspace.Text = "Open last Workspace";
            this.button_OpenLastWorkspace.UseVisualStyleBackColor = true;
            this.button_OpenLastWorkspace.Click += new System.EventHandler(this.button_OpenLastWorkspace_Click);
            // 
            // button_StopRun
            // 
            this.button_StopRun.Location = new System.Drawing.Point(188, 183);
            this.button_StopRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_StopRun.Name = "button_StopRun";
            this.button_StopRun.Size = new System.Drawing.Size(168, 35);
            this.button_StopRun.TabIndex = 17;
            this.button_StopRun.Text = "Stop Run";
            this.button_StopRun.UseVisualStyleBackColor = true;
            this.button_StopRun.Click += new System.EventHandler(this.button_StopRun_Click);
            // 
            // button_TestForEVO
            // 
            this.button_TestForEVO.Location = new System.Drawing.Point(10, 126);
            this.button_TestForEVO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_TestForEVO.Name = "button_TestForEVO";
            this.button_TestForEVO.Size = new System.Drawing.Size(360, 35);
            this.button_TestForEVO.TabIndex = 16;
            this.button_TestForEVO.Text = "Open Workspace(with same name as method)";
            this.button_TestForEVO.UseVisualStyleBackColor = true;
            this.button_TestForEVO.Click += new System.EventHandler(this.button_TestForEVO_Click);
            // 
            // numericUpDown_ExpGrp
            // 
            this.numericUpDown_ExpGrp.Location = new System.Drawing.Point(405, 278);
            this.numericUpDown_ExpGrp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_ExpGrp.Name = "numericUpDown_ExpGrp";
            this.numericUpDown_ExpGrp.Size = new System.Drawing.Size(76, 26);
            this.numericUpDown_ExpGrp.TabIndex = 10;
            // 
            // label_ExpGrp
            // 
            this.label_ExpGrp.AutoSize = true;
            this.label_ExpGrp.Location = new System.Drawing.Point(202, 282);
            this.label_ExpGrp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ExpGrp.Name = "label_ExpGrp";
            this.label_ExpGrp.Size = new System.Drawing.Size(194, 20);
            this.label_ExpGrp.TabIndex = 15;
            this.label_ExpGrp.Text = "Experimental Group (1...n)";
            this.label_ExpGrp.Click += new System.EventHandler(this.label_ExpGrp_Click);
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Location = new System.Drawing.Point(189, 323);
            this.textBox_FilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_FilePath.Size = new System.Drawing.Size(596, 26);
            this.textBox_FilePath.TabIndex = 14;
            // 
            // button_StandardFileLocation
            // 
            this.button_StandardFileLocation.Location = new System.Drawing.Point(40, 318);
            this.button_StandardFileLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_StandardFileLocation.Name = "button_StandardFileLocation";
            this.button_StandardFileLocation.Size = new System.Drawing.Size(138, 35);
            this.button_StandardFileLocation.TabIndex = 13;
            this.button_StandardFileLocation.Text = "Select File...";
            this.button_StandardFileLocation.UseVisualStyleBackColor = true;
            this.button_StandardFileLocation.Click += new System.EventHandler(this.button_StandardFileLocation_Click);
            // 
            // textBox_AuditTrailComment
            // 
            this.textBox_AuditTrailComment.Location = new System.Drawing.Point(188, 403);
            this.textBox_AuditTrailComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_AuditTrailComment.Name = "textBox_AuditTrailComment";
            this.textBox_AuditTrailComment.Size = new System.Drawing.Size(598, 26);
            this.textBox_AuditTrailComment.TabIndex = 12;
            // 
            // textBox_FileRemark
            // 
            this.textBox_FileRemark.Location = new System.Drawing.Point(188, 363);
            this.textBox_FileRemark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_FileRemark.Name = "textBox_FileRemark";
            this.textBox_FileRemark.Size = new System.Drawing.Size(598, 26);
            this.textBox_FileRemark.TabIndex = 11;
            // 
            // label_AuditTrail
            // 
            this.label_AuditTrail.AutoSize = true;
            this.label_AuditTrail.Location = new System.Drawing.Point(44, 408);
            this.label_AuditTrail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_AuditTrail.Name = "label_AuditTrail";
            this.label_AuditTrail.Size = new System.Drawing.Size(144, 20);
            this.label_AuditTrail.TabIndex = 10;
            this.label_AuditTrail.Text = "AuditTrailComment";
            // 
            // label_FileRemark
            // 
            this.label_FileRemark.AutoSize = true;
            this.label_FileRemark.Location = new System.Drawing.Point(44, 368);
            this.label_FileRemark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FileRemark.Name = "label_FileRemark";
            this.label_FileRemark.Size = new System.Drawing.Size(90, 20);
            this.label_FileRemark.TabIndex = 9;
            this.label_FileRemark.Text = "FileRemark";
            // 
            // button_SaveStandards
            // 
            this.button_SaveStandards.Location = new System.Drawing.Point(10, 274);
            this.button_SaveStandards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_SaveStandards.Name = "button_SaveStandards";
            this.button_SaveStandards.Size = new System.Drawing.Size(168, 35);
            this.button_SaveStandards.TabIndex = 8;
            this.button_SaveStandards.Text = "Save Standards";
            this.button_SaveStandards.UseVisualStyleBackColor = true;
            this.button_SaveStandards.Click += new System.EventHandler(this.button_SaveStandards_Click);
            // 
            // button_SaveWorkspace
            // 
            this.button_SaveWorkspace.Location = new System.Drawing.Point(188, 229);
            this.button_SaveWorkspace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_SaveWorkspace.Name = "button_SaveWorkspace";
            this.button_SaveWorkspace.Size = new System.Drawing.Size(168, 35);
            this.button_SaveWorkspace.TabIndex = 7;
            this.button_SaveWorkspace.Text = "Save Workspace";
            this.button_SaveWorkspace.UseVisualStyleBackColor = true;
            this.button_SaveWorkspace.Click += new System.EventHandler(this.button_SaveWorkspace_Click);
            // 
            // button_DataExport
            // 
            this.button_DataExport.Location = new System.Drawing.Point(10, 229);
            this.button_DataExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_DataExport.Name = "button_DataExport";
            this.button_DataExport.Size = new System.Drawing.Size(168, 35);
            this.button_DataExport.TabIndex = 6;
            this.button_DataExport.Text = "Data Export";
            this.button_DataExport.UseVisualStyleBackColor = true;
            this.button_DataExport.Click += new System.EventHandler(this.button_DataExport_Click);
            // 
            // button_StartRun
            // 
            this.button_StartRun.Location = new System.Drawing.Point(10, 183);
            this.button_StartRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_StartRun.Name = "button_StartRun";
            this.button_StartRun.Size = new System.Drawing.Size(168, 35);
            this.button_StartRun.TabIndex = 5;
            this.button_StartRun.Text = "Start Run";
            this.button_StartRun.UseVisualStyleBackColor = true;
            this.button_StartRun.Click += new System.EventHandler(this.button_StartRun_Click);
            // 
            // textBox_Filename
            // 
            this.textBox_Filename.Location = new System.Drawing.Point(189, 86);
            this.textBox_Filename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Filename.Name = "textBox_Filename";
            this.textBox_Filename.Size = new System.Drawing.Size(595, 26);
            this.textBox_Filename.TabIndex = 4;
            // 
            // button_SetFileName
            // 
            this.button_SetFileName.Location = new System.Drawing.Point(10, 82);
            this.button_SetFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_SetFileName.Name = "button_SetFileName";
            this.button_SetFileName.Size = new System.Drawing.Size(168, 35);
            this.button_SetFileName.TabIndex = 3;
            this.button_SetFileName.Text = "Set Filename";
            this.button_SetFileName.UseVisualStyleBackColor = true;
            this.button_SetFileName.Click += new System.EventHandler(this.button_SetFileName_Click);
            // 
            // comboBox_Methods
            // 
            this.comboBox_Methods.FormattingEnabled = true;
            this.comboBox_Methods.Location = new System.Drawing.Point(366, 38);
            this.comboBox_Methods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Methods.Name = "comboBox_Methods";
            this.comboBox_Methods.Size = new System.Drawing.Size(418, 28);
            this.comboBox_Methods.TabIndex = 2;
            // 
            // button_InsertMethod
            // 
            this.button_InsertMethod.Location = new System.Drawing.Point(189, 35);
            this.button_InsertMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_InsertMethod.Name = "button_InsertMethod";
            this.button_InsertMethod.Size = new System.Drawing.Size(168, 35);
            this.button_InsertMethod.TabIndex = 1;
            this.button_InsertMethod.Text = "Insert Method";
            this.button_InsertMethod.UseVisualStyleBackColor = true;
            this.button_InsertMethod.Click += new System.EventHandler(this.button_InsertMethod_Click);
            // 
            // button_SetEmpty
            // 
            this.button_SetEmpty.Location = new System.Drawing.Point(10, 31);
            this.button_SetEmpty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_SetEmpty.Name = "button_SetEmpty";
            this.button_SetEmpty.Size = new System.Drawing.Size(168, 35);
            this.button_SetEmpty.TabIndex = 0;
            this.button_SetEmpty.Text = "Set Empty";
            this.button_SetEmpty.UseVisualStyleBackColor = true;
            this.button_SetEmpty.Click += new System.EventHandler(this.button_SetEmpty_Click);
            // 
            // button_ModifyLyout
            // 
            this.button_ModifyLyout.Location = new System.Drawing.Point(10, 29);
            this.button_ModifyLyout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ModifyLyout.Name = "button_ModifyLyout";
            this.button_ModifyLyout.Size = new System.Drawing.Size(168, 35);
            this.button_ModifyLyout.TabIndex = 8;
            this.button_ModifyLyout.Text = "Modify Layout";
            this.button_ModifyLyout.UseVisualStyleBackColor = true;
            this.button_ModifyLyout.Click += new System.EventHandler(this.button_ModifyLayout_Click);
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Controls.Add(this.button_DataAsTable);
            this.groupBox_Data.Controls.Add(this.comboBox_DataNames);
            this.groupBox_Data.Controls.Add(this.button_DataNames);
            this.groupBox_Data.Location = new System.Drawing.Point(20, 1002);
            this.groupBox_Data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Data.Name = "groupBox_Data";
            this.groupBox_Data.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Data.Size = new System.Drawing.Size(796, 129);
            this.groupBox_Data.TabIndex = 4;
            this.groupBox_Data.TabStop = false;
            this.groupBox_Data.Text = "Data";
            // 
            // button_DataAsTable
            // 
            this.button_DataAsTable.Location = new System.Drawing.Point(10, 77);
            this.button_DataAsTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_DataAsTable.Name = "button_DataAsTable";
            this.button_DataAsTable.Size = new System.Drawing.Size(168, 35);
            this.button_DataAsTable.TabIndex = 2;
            this.button_DataAsTable.Text = "DataAsTable";
            this.button_DataAsTable.UseVisualStyleBackColor = true;
            this.button_DataAsTable.Click += new System.EventHandler(this.button_DataAsTable_Click);
            // 
            // comboBox_DataNames
            // 
            this.comboBox_DataNames.FormattingEnabled = true;
            this.comboBox_DataNames.Location = new System.Drawing.Point(189, 32);
            this.comboBox_DataNames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_DataNames.Name = "comboBox_DataNames";
            this.comboBox_DataNames.Size = new System.Drawing.Size(596, 28);
            this.comboBox_DataNames.TabIndex = 1;
            // 
            // button_DataNames
            // 
            this.button_DataNames.Location = new System.Drawing.Point(10, 31);
            this.button_DataNames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_DataNames.Name = "button_DataNames";
            this.button_DataNames.Size = new System.Drawing.Size(168, 35);
            this.button_DataNames.TabIndex = 0;
            this.button_DataNames.Text = "Data Names";
            this.button_DataNames.UseVisualStyleBackColor = true;
            this.button_DataNames.Click += new System.EventHandler(this.button_DataNames_Click);
            // 
            // groupBox_Layout
            // 
            this.groupBox_Layout.Controls.Add(this.button_Samples);
            this.groupBox_Layout.Controls.Add(this.button_ModifyLyout);
            this.groupBox_Layout.Location = new System.Drawing.Point(20, 903);
            this.groupBox_Layout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Layout.Name = "groupBox_Layout";
            this.groupBox_Layout.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Layout.Size = new System.Drawing.Size(796, 86);
            this.groupBox_Layout.TabIndex = 5;
            this.groupBox_Layout.TabStop = false;
            this.groupBox_Layout.Text = "Layout and Samples";
            // 
            // button_Samples
            // 
            this.button_Samples.Location = new System.Drawing.Point(189, 29);
            this.button_Samples.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Samples.Name = "button_Samples";
            this.button_Samples.Size = new System.Drawing.Size(168, 35);
            this.button_Samples.TabIndex = 9;
            this.button_Samples.Text = "Insert Sample IDs";
            this.button_Samples.UseVisualStyleBackColor = true;
            this.button_Samples.Click += new System.EventHandler(this.button_Samples_Click);
            // 
            // groupBox_Magellan
            // 
            this.groupBox_Magellan.Controls.Add(this.textBox_Pwd);
            this.groupBox_Magellan.Controls.Add(this.textBox_Login);
            this.groupBox_Magellan.Controls.Add(this.label_Pwd);
            this.groupBox_Magellan.Controls.Add(this.label_Login);
            this.groupBox_Magellan.Controls.Add(this.comboBox_DeviceName);
            this.groupBox_Magellan.Controls.Add(this.button_Name);
            this.groupBox_Magellan.Controls.Add(this.button_Create);
            this.groupBox_Magellan.Location = new System.Drawing.Point(20, 20);
            this.groupBox_Magellan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Magellan.Name = "groupBox_Magellan";
            this.groupBox_Magellan.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Magellan.Size = new System.Drawing.Size(796, 154);
            this.groupBox_Magellan.TabIndex = 6;
            this.groupBox_Magellan.TabStop = false;
            this.groupBox_Magellan.Text = "Magellan";
            // 
            // textBox_Pwd
            // 
            this.textBox_Pwd.Location = new System.Drawing.Point(594, 34);
            this.textBox_Pwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Pwd.Name = "textBox_Pwd";
            this.textBox_Pwd.PasswordChar = '*';
            this.textBox_Pwd.Size = new System.Drawing.Size(148, 26);
            this.textBox_Pwd.TabIndex = 7;
            this.textBox_Pwd.WordWrap = false;
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(324, 34);
            this.textBox_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(148, 26);
            this.textBox_Login.TabIndex = 6;
            this.textBox_Login.WordWrap = false;
            // 
            // label_Pwd
            // 
            this.label_Pwd.AutoSize = true;
            this.label_Pwd.Location = new System.Drawing.Point(501, 38);
            this.label_Pwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Pwd.Name = "label_Pwd";
            this.label_Pwd.Size = new System.Drawing.Size(82, 20);
            this.label_Pwd.TabIndex = 5;
            this.label_Pwd.Text = "Password:";
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(261, 38);
            this.label_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(52, 20);
            this.label_Login.TabIndex = 4;
            this.label_Login.Text = "Login:";
            // 
            // comboBox_DeviceName
            // 
            this.comboBox_DeviceName.FormattingEnabled = true;
            this.comboBox_DeviceName.Items.AddRange(new object[] {
            "Sunrise",
            "Infinite Series",
            "Infinite Series:BIO:BIO_SIM_10000",
            "ConnectDotNet:NAME=SPARK10M:Instrument1"});
            this.comboBox_DeviceName.Location = new System.Drawing.Point(188, 77);
            this.comboBox_DeviceName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_DeviceName.Name = "comboBox_DeviceName";
            this.comboBox_DeviceName.Size = new System.Drawing.Size(396, 28);
            this.comboBox_DeviceName.TabIndex = 3;
            // 
            // button_Name
            // 
            this.button_Name.Location = new System.Drawing.Point(10, 77);
            this.button_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Name.Name = "button_Name";
            this.button_Name.Size = new System.Drawing.Size(168, 35);
            this.button_Name.TabIndex = 1;
            this.button_Name.Text = "Set Device Name";
            this.button_Name.UseVisualStyleBackColor = true;
            this.button_Name.Click += new System.EventHandler(this.button_Name_Click);
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(10, 31);
            this.button_Create.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(168, 35);
            this.button_Create.TabIndex = 0;
            this.button_Create.Text = "Create Magellan";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // saveFileDialogStandards
            // 
            this.saveFileDialogStandards.DefaultExt = "std";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1830, 1140);
            this.Controls.Add(this.groupBox_Magellan);
            this.Controls.Add(this.groupBox_Layout);
            this.Controls.Add(this.groupBox_Data);
            this.Controls.Add(this.groupBox_Workspace);
            this.Controls.Add(this.groupBox_Methods);
            this.Controls.Add(this.groupBox_Output);
            this.Controls.Add(this.groupBox_Connect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Magellan Client App";
            this.groupBox_Connect.ResumeLayout(false);
            this.groupBox_Output.ResumeLayout(false);
            this.groupBox_Methods.ResumeLayout(false);
            this.groupBox_Workspace.ResumeLayout(false);
            this.groupBox_Workspace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ExpGrp)).EndInit();
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Layout.ResumeLayout(false);
            this.groupBox_Magellan.ResumeLayout(false);
            this.groupBox_Magellan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Connect;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.GroupBox groupBox_Output;
        private System.Windows.Forms.RichTextBox richTextBox_Output;
        private System.Windows.Forms.GroupBox groupBox_Methods;
        private System.Windows.Forms.Button button_AvailableMethods;
        private System.Windows.Forms.GroupBox groupBox_Workspace;
        private System.Windows.Forms.Button button_SetEmpty;
        private System.Windows.Forms.ComboBox comboBox_Methods;
        private System.Windows.Forms.Button button_InsertMethod;
        private System.Windows.Forms.Button button_ResetLastError;
        private System.Windows.Forms.Button button_GetLastError;
        private System.Windows.Forms.Button button_PlateOut;
        private System.Windows.Forms.Button button_PlateIn;
        private System.Windows.Forms.TextBox textBox_Filename;
        private System.Windows.Forms.Button button_SetFileName;
        private System.Windows.Forms.Button button_StartRun;
        private System.Windows.Forms.Button button_DataExport;
        private System.Windows.Forms.Button button_SaveWorkspace;
        private System.Windows.Forms.GroupBox groupBox_Data;
        private System.Windows.Forms.Button button_DataNames;
        private System.Windows.Forms.ComboBox comboBox_DataNames;
        private System.Windows.Forms.Button button_DataAsTable;
        private System.Windows.Forms.Button button_ModifyLyout;
        private System.Windows.Forms.GroupBox groupBox_Layout;
        private System.Windows.Forms.Button button_Samples;
        private System.Windows.Forms.GroupBox groupBox_Magellan;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Name;
        private System.Windows.Forms.Button button_SaveStandards;
        private System.Windows.Forms.Label label_FileRemark;
        private System.Windows.Forms.Button button_StandardFileLocation;
        private System.Windows.Forms.TextBox textBox_AuditTrailComment;
        private System.Windows.Forms.TextBox textBox_FileRemark;
        private System.Windows.Forms.Label label_AuditTrail;
        private System.Windows.Forms.SaveFileDialog saveFileDialogStandards;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.Label label_ExpGrp;
        private System.Windows.Forms.NumericUpDown numericUpDown_ExpGrp;
        private System.Windows.Forms.Button button_TestForEVO;
        private System.Windows.Forms.ComboBox comboBox_DeviceName;
        private System.Windows.Forms.Button button_StopRun;
        private System.Windows.Forms.Button button_OpenLastWorkspace;
        private System.Windows.Forms.Button button_StdEx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Pwd;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label label_Pwd;
        private System.Windows.Forms.Label label_Login;
    }
}

