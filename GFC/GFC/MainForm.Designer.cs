namespace GFC
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.lblProgramCycleProgressBar = new System.Windows.Forms.Label();
            this.lblAPCBName = new System.Windows.Forms.Label();
            this.lblAPCAName = new System.Windows.Forms.Label();
            this.lblAPCBNameLabel = new System.Windows.Forms.Label();
            this.lblAPCANameLabel = new System.Windows.Forms.Label();
            this.lblComputerName = new System.Windows.Forms.Label();
            this.lblComputerNameLabel = new System.Windows.Forms.Label();
            this.lblCalculatedStatus2 = new System.Windows.Forms.Label();
            this.lblCalculatedStatus2Label = new System.Windows.Forms.Label();
            this.lblOPCConnectionOK = new System.Windows.Forms.Label();
            this.lblOPCConnectionOKLabel = new System.Windows.Forms.Label();
            this.lblConfigurationOK = new System.Windows.Forms.Label();
            this.lblConfigurationOKLabel = new System.Windows.Forms.Label();
            this.lblCalculatedFlowValue2 = new System.Windows.Forms.Label();
            this.lblCalculatedFlowLabel2 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.lblGasFlowCalculator = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblBakerHughesLabel = new System.Windows.Forms.Label();
            this.tabCalculation = new System.Windows.Forms.TabPage();
            this.lblCalculationComment = new System.Windows.Forms.Label();
            this.lblCalculationErrorCodeDescription = new System.Windows.Forms.Label();
            this.lblCalculatedStatus = new System.Windows.Forms.Label();
            this.lblCalculatedStatusLabel = new System.Windows.Forms.Label();
            this.lblCalculationRunning = new System.Windows.Forms.Label();
            this.lblCalculatedFlowValue = new System.Windows.Forms.Label();
            this.lblCalculatedFlowLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetDensityMultiplier = new System.Windows.Forms.Button();
            this.btnSetDischargeCoefficient = new System.Windows.Forms.Button();
            this.txtDensityMultiplier = new System.Windows.Forms.TextBox();
            this.txtDischargeCoefficient = new System.Windows.Forms.TextBox();
            this.lblDensityMultiplierLabel = new System.Windows.Forms.Label();
            this.lblDischargeCoefficientLabel = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.pnlChokeValues = new System.Windows.Forms.Panel();
            this.lblCVUnit = new System.Windows.Forms.Label();
            this.lblSelectedChokeCVValueStatus = new System.Windows.Forms.Label();
            this.lblSelectedChokeCVValueValue = new System.Windows.Forms.Label();
            this.lblCVTableValueStatus = new System.Windows.Forms.Label();
            this.lblCVTableValue = new System.Windows.Forms.Label();
            this.lblCV = new System.Windows.Forms.Label();
            this.lblSelectedChokeCVValue = new System.Windows.Forms.Label();
            this.pnlSelecedPVTValues = new System.Windows.Forms.Panel();
            this.lblCPGUnit = new System.Windows.Forms.Label();
            this.lblROGUnit = new System.Windows.Forms.Label();
            this.lblPVTTableCPGValueStatus = new System.Windows.Forms.Label();
            this.lblPVTTableCPGValue = new System.Windows.Forms.Label();
            this.lblPVTTableDROGDTValueStatus = new System.Windows.Forms.Label();
            this.lblPVTTableDROGDTValue = new System.Windows.Forms.Label();
            this.lblPVTTableDROGDPValueStatus = new System.Windows.Forms.Label();
            this.lblPVTTableDROGDPValue = new System.Windows.Forms.Label();
            this.lblSelectedPVTValuesStatus = new System.Windows.Forms.Label();
            this.lblSelectedPVTValuesValue = new System.Windows.Forms.Label();
            this.lblPVTTableROGValueStatus = new System.Windows.Forms.Label();
            this.lblPVTTableROGValue = new System.Windows.Forms.Label();
            this.lblCPG = new System.Windows.Forms.Label();
            this.lblDROGDT = new System.Windows.Forms.Label();
            this.lblDROGDP = new System.Windows.Forms.Label();
            this.lblROG = new System.Windows.Forms.Label();
            this.lblSelectedPVTValues = new System.Windows.Forms.Label();
            this.pnlActualValues = new System.Windows.Forms.Panel();
            this.lblTemperatureTStatus = new System.Windows.Forms.Label();
            this.lblTemperatureTValue = new System.Windows.Forms.Label();
            this.lblPressureP2Status = new System.Windows.Forms.Label();
            this.lblPressureP2Value = new System.Windows.Forms.Label();
            this.lblPressureP1Status = new System.Windows.Forms.Label();
            this.lblPressureP1Value = new System.Windows.Forms.Label();
            this.lblActualProcesValuesStatus = new System.Windows.Forms.Label();
            this.lblActualProcesValuesValue = new System.Windows.Forms.Label();
            this.lblChokeOpenStatus = new System.Windows.Forms.Label();
            this.lblChokeOpenValue = new System.Windows.Forms.Label();
            this.lblTemperatureTUnit = new System.Windows.Forms.Label();
            this.lblPressureP2Unit = new System.Windows.Forms.Label();
            this.lblPressureP1Unit = new System.Windows.Forms.Label();
            this.lblChokeOpenUnit = new System.Windows.Forms.Label();
            this.lblTemperatureT = new System.Windows.Forms.Label();
            this.lblPressureP2 = new System.Windows.Forms.Label();
            this.lblPressureP1 = new System.Windows.Forms.Label();
            this.lblChokeOpen = new System.Windows.Forms.Label();
            this.lblActualValues = new System.Windows.Forms.Label();
            this.tabOPC = new System.Windows.Forms.TabPage();
            this.lblConnectOPCServerComment = new System.Windows.Forms.Label();
            this.lblMemoryGarbageCollector = new System.Windows.Forms.Label();
            this.lblOPCAutoReConnect = new System.Windows.Forms.Label();
            this.lblOPCAutoConnect = new System.Windows.Forms.Label();
            this.lblMemoryGarbageCollectorLabel = new System.Windows.Forms.Label();
            this.lblOPCAutoReConnectLabel = new System.Windows.Forms.Label();
            this.lblOPCAutoConnectLabel = new System.Windows.Forms.Label();
            this.lblGarbageCollectorActive = new System.Windows.Forms.Label();
            this.lblReadingWritingOPCItemStatus = new System.Windows.Forms.Label();
            this.lblConnectionStatusTime = new System.Windows.Forms.Label();
            this.lblHeartBit = new System.Windows.Forms.Label();
            this.lblHeartBitLabel = new System.Windows.Forms.Label();
            this.lblOPCItemPathStatus = new System.Windows.Forms.Label();
            this.cmbNewOPCServerName = new System.Windows.Forms.ComboBox();
            this.lblOPCRefresh = new System.Windows.Forms.Label();
            this.btnSetOPCServerName = new System.Windows.Forms.Button();
            this.lblNewOPCServerNameLabel = new System.Windows.Forms.Label();
            this.btnSelectOPCItemsFile = new System.Windows.Forms.Button();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnDisconnectOPCServer = new System.Windows.Forms.Button();
            this.btnConnectOPCServer = new System.Windows.Forms.Button();
            this.lblActiveOPCServer = new System.Windows.Forms.Label();
            this.prgOPCServerStatus = new System.Windows.Forms.ProgressBar();
            this.lblActiveOPCServerLabel = new System.Windows.Forms.Label();
            this.lvwOPCItems = new System.Windows.Forms.ListView();
            this.GFC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeStamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Error = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPVT = new System.Windows.Forms.TabPage();
            this.lblPVTTableOKStatus = new System.Windows.Forms.Label();
            this.btnLoadPVTFile = new System.Windows.Forms.Button();
            this.grpViewSelection = new System.Windows.Forms.GroupBox();
            this.rdoCPG = new System.Windows.Forms.RadioButton();
            this.rdoDROGDT = new System.Windows.Forms.RadioButton();
            this.rdoDROGDP = new System.Windows.Forms.RadioButton();
            this.rdoROG = new System.Windows.Forms.RadioButton();
            this.rdoPVTFile = new System.Windows.Forms.RadioButton();
            this.rtxPVT = new System.Windows.Forms.RichTextBox();
            this.tabChoke = new System.Windows.Forms.TabPage();
            this.lblCVLabel90 = new System.Windows.Forms.Label();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.btnSetCustomCVValues = new System.Windows.Forms.Button();
            this.lblCVTableOKStatus = new System.Windows.Forms.Label();
            this.btnLoadCVDataFile = new System.Windows.Forms.Button();
            this.lblCVLabel81 = new System.Windows.Forms.Label();
            this.lblCVLabel61 = new System.Windows.Forms.Label();
            this.lblCVLabel41 = new System.Windows.Forms.Label();
            this.lblCVLabel21 = new System.Windows.Forms.Label();
            this.lblCVLabel100 = new System.Windows.Forms.Label();
            this.txtCV_100 = new System.Windows.Forms.TextBox();
            this.txtCV_99 = new System.Windows.Forms.TextBox();
            this.txtCV_98 = new System.Windows.Forms.TextBox();
            this.txtCV_97 = new System.Windows.Forms.TextBox();
            this.txtCV_96 = new System.Windows.Forms.TextBox();
            this.txtCV_95 = new System.Windows.Forms.TextBox();
            this.txtCV_94 = new System.Windows.Forms.TextBox();
            this.txtCV_93 = new System.Windows.Forms.TextBox();
            this.txtCV_92 = new System.Windows.Forms.TextBox();
            this.txtCV_91 = new System.Windows.Forms.TextBox();
            this.txtCV_90 = new System.Windows.Forms.TextBox();
            this.txtCV_89 = new System.Windows.Forms.TextBox();
            this.txtCV_88 = new System.Windows.Forms.TextBox();
            this.txtCV_87 = new System.Windows.Forms.TextBox();
            this.txtCV_86 = new System.Windows.Forms.TextBox();
            this.txtCV_85 = new System.Windows.Forms.TextBox();
            this.txtCV_84 = new System.Windows.Forms.TextBox();
            this.txtCV_83 = new System.Windows.Forms.TextBox();
            this.txtCV_82 = new System.Windows.Forms.TextBox();
            this.txtCV_81 = new System.Windows.Forms.TextBox();
            this.txtCV_80 = new System.Windows.Forms.TextBox();
            this.txtCV_79 = new System.Windows.Forms.TextBox();
            this.txtCV_78 = new System.Windows.Forms.TextBox();
            this.txtCV_77 = new System.Windows.Forms.TextBox();
            this.txtCV_76 = new System.Windows.Forms.TextBox();
            this.txtCV_75 = new System.Windows.Forms.TextBox();
            this.txtCV_74 = new System.Windows.Forms.TextBox();
            this.txtCV_73 = new System.Windows.Forms.TextBox();
            this.txtCV_72 = new System.Windows.Forms.TextBox();
            this.txtCV_71 = new System.Windows.Forms.TextBox();
            this.txtCV_70 = new System.Windows.Forms.TextBox();
            this.txtCV_69 = new System.Windows.Forms.TextBox();
            this.txtCV_68 = new System.Windows.Forms.TextBox();
            this.txtCV_67 = new System.Windows.Forms.TextBox();
            this.txtCV_66 = new System.Windows.Forms.TextBox();
            this.txtCV_65 = new System.Windows.Forms.TextBox();
            this.txtCV_64 = new System.Windows.Forms.TextBox();
            this.txtCV_63 = new System.Windows.Forms.TextBox();
            this.txtCV_62 = new System.Windows.Forms.TextBox();
            this.txtCV_61 = new System.Windows.Forms.TextBox();
            this.txtCV_60 = new System.Windows.Forms.TextBox();
            this.txtCV_59 = new System.Windows.Forms.TextBox();
            this.txtCV_58 = new System.Windows.Forms.TextBox();
            this.txtCV_57 = new System.Windows.Forms.TextBox();
            this.txtCV_56 = new System.Windows.Forms.TextBox();
            this.txtCV_55 = new System.Windows.Forms.TextBox();
            this.txtCV_54 = new System.Windows.Forms.TextBox();
            this.txtCV_53 = new System.Windows.Forms.TextBox();
            this.txtCV_52 = new System.Windows.Forms.TextBox();
            this.txtCV_51 = new System.Windows.Forms.TextBox();
            this.txtCV_50 = new System.Windows.Forms.TextBox();
            this.txtCV_49 = new System.Windows.Forms.TextBox();
            this.txtCV_48 = new System.Windows.Forms.TextBox();
            this.txtCV_47 = new System.Windows.Forms.TextBox();
            this.txtCV_46 = new System.Windows.Forms.TextBox();
            this.txtCV_45 = new System.Windows.Forms.TextBox();
            this.txtCV_44 = new System.Windows.Forms.TextBox();
            this.txtCV_43 = new System.Windows.Forms.TextBox();
            this.txtCV_42 = new System.Windows.Forms.TextBox();
            this.txtCV_41 = new System.Windows.Forms.TextBox();
            this.txtCV_40 = new System.Windows.Forms.TextBox();
            this.txtCV_39 = new System.Windows.Forms.TextBox();
            this.txtCV_38 = new System.Windows.Forms.TextBox();
            this.txtCV_37 = new System.Windows.Forms.TextBox();
            this.txtCV_36 = new System.Windows.Forms.TextBox();
            this.txtCV_35 = new System.Windows.Forms.TextBox();
            this.txtCV_34 = new System.Windows.Forms.TextBox();
            this.txtCV_33 = new System.Windows.Forms.TextBox();
            this.txtCV_32 = new System.Windows.Forms.TextBox();
            this.txtCV_31 = new System.Windows.Forms.TextBox();
            this.txtCV_30 = new System.Windows.Forms.TextBox();
            this.txtCV_29 = new System.Windows.Forms.TextBox();
            this.txtCV_28 = new System.Windows.Forms.TextBox();
            this.txtCV_27 = new System.Windows.Forms.TextBox();
            this.txtCV_26 = new System.Windows.Forms.TextBox();
            this.txtCV_25 = new System.Windows.Forms.TextBox();
            this.txtCV_24 = new System.Windows.Forms.TextBox();
            this.txtCV_23 = new System.Windows.Forms.TextBox();
            this.txtCV_22 = new System.Windows.Forms.TextBox();
            this.txtCV_21 = new System.Windows.Forms.TextBox();
            this.lblCVLabel20 = new System.Windows.Forms.Label();
            this.lblCVLabel10 = new System.Windows.Forms.Label();
            this.txtCV_20 = new System.Windows.Forms.TextBox();
            this.txtCV_19 = new System.Windows.Forms.TextBox();
            this.txtCV_18 = new System.Windows.Forms.TextBox();
            this.txtCV_17 = new System.Windows.Forms.TextBox();
            this.txtCV_16 = new System.Windows.Forms.TextBox();
            this.txtCV_15 = new System.Windows.Forms.TextBox();
            this.txtCV_14 = new System.Windows.Forms.TextBox();
            this.txtCV_13 = new System.Windows.Forms.TextBox();
            this.txtCV_12 = new System.Windows.Forms.TextBox();
            this.txtCV_11 = new System.Windows.Forms.TextBox();
            this.txtCV_10 = new System.Windows.Forms.TextBox();
            this.txtCV_9 = new System.Windows.Forms.TextBox();
            this.txtCV_8 = new System.Windows.Forms.TextBox();
            this.txtCV_7 = new System.Windows.Forms.TextBox();
            this.txtCV_6 = new System.Windows.Forms.TextBox();
            this.txtCV_5 = new System.Windows.Forms.TextBox();
            this.txtCV_4 = new System.Windows.Forms.TextBox();
            this.txtCV_3 = new System.Windows.Forms.TextBox();
            this.txtCV_2 = new System.Windows.Forms.TextBox();
            this.txtCV_1 = new System.Windows.Forms.TextBox();
            this.lblCVLabel1 = new System.Windows.Forms.Label();
            this.chrChokeFlowCurve = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mnsMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDefaultConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadOPCIthemPathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPVTFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadChokeFlowCurveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tabOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabCalculation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlChokeValues.SuspendLayout();
            this.pnlSelecedPVTValues.SuspendLayout();
            this.pnlActualValues.SuspendLayout();
            this.tabOPC.SuspendLayout();
            this.tabPVT.SuspendLayout();
            this.grpViewSelection.SuspendLayout();
            this.tabChoke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrChokeFlowCurve)).BeginInit();
            this.mnsMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabOverview);
            this.tabControl.Controls.Add(this.tabCalculation);
            this.tabControl.Controls.Add(this.tabOPC);
            this.tabControl.Controls.Add(this.tabPVT);
            this.tabControl.Controls.Add(this.tabChoke);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.Location = new System.Drawing.Point(11, 30);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(989, 715);
            this.tabControl.TabIndex = 0;
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.lblProgramCycleProgressBar);
            this.tabOverview.Controls.Add(this.lblAPCBName);
            this.tabOverview.Controls.Add(this.lblAPCAName);
            this.tabOverview.Controls.Add(this.lblAPCBNameLabel);
            this.tabOverview.Controls.Add(this.lblAPCANameLabel);
            this.tabOverview.Controls.Add(this.lblComputerName);
            this.tabOverview.Controls.Add(this.lblComputerNameLabel);
            this.tabOverview.Controls.Add(this.lblCalculatedStatus2);
            this.tabOverview.Controls.Add(this.lblCalculatedStatus2Label);
            this.tabOverview.Controls.Add(this.lblOPCConnectionOK);
            this.tabOverview.Controls.Add(this.lblOPCConnectionOKLabel);
            this.tabOverview.Controls.Add(this.lblConfigurationOK);
            this.tabOverview.Controls.Add(this.lblConfigurationOKLabel);
            this.tabOverview.Controls.Add(this.lblCalculatedFlowValue2);
            this.tabOverview.Controls.Add(this.lblCalculatedFlowLabel2);
            this.tabOverview.Controls.Add(this.lblVersion);
            this.tabOverview.Controls.Add(this.lblCopyRight);
            this.tabOverview.Controls.Add(this.lblGasFlowCalculator);
            this.tabOverview.Controls.Add(this.picLogo);
            this.tabOverview.Controls.Add(this.lblBakerHughesLabel);
            this.tabOverview.Location = new System.Drawing.Point(4, 27);
            this.tabOverview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabOverview.Size = new System.Drawing.Size(981, 684);
            this.tabOverview.TabIndex = 0;
            this.tabOverview.Text = "Overview";
            this.tabOverview.UseVisualStyleBackColor = true;
            // 
            // lblProgramCycleProgressBar
            // 
            this.lblProgramCycleProgressBar.AutoSize = true;
            this.lblProgramCycleProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProgramCycleProgressBar.ForeColor = System.Drawing.Color.Black;
            this.lblProgramCycleProgressBar.Location = new System.Drawing.Point(45, 645);
            this.lblProgramCycleProgressBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgramCycleProgressBar.Name = "lblProgramCycleProgressBar";
            this.lblProgramCycleProgressBar.Size = new System.Drawing.Size(164, 18);
            this.lblProgramCycleProgressBar.TabIndex = 21;
            this.lblProgramCycleProgressBar.Text = "Program cycle indicator";
            // 
            // lblAPCBName
            // 
            this.lblAPCBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAPCBName.Location = new System.Drawing.Point(848, 576);
            this.lblAPCBName.Name = "lblAPCBName";
            this.lblAPCBName.Size = new System.Drawing.Size(120, 20);
            this.lblAPCBName.TabIndex = 20;
            this.lblAPCBName.Text = "NaN";
            this.lblAPCBName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAPCAName
            // 
            this.lblAPCAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAPCAName.Location = new System.Drawing.Point(848, 551);
            this.lblAPCAName.Name = "lblAPCAName";
            this.lblAPCAName.Size = new System.Drawing.Size(120, 20);
            this.lblAPCAName.TabIndex = 19;
            this.lblAPCAName.Text = "NaN";
            this.lblAPCAName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAPCBNameLabel
            // 
            this.lblAPCBNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAPCBNameLabel.Location = new System.Drawing.Point(643, 576);
            this.lblAPCBNameLabel.Name = "lblAPCBNameLabel";
            this.lblAPCBNameLabel.Size = new System.Drawing.Size(200, 20);
            this.lblAPCBNameLabel.TabIndex = 18;
            this.lblAPCBNameLabel.Text = "APCB Name:";
            this.lblAPCBNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAPCANameLabel
            // 
            this.lblAPCANameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAPCANameLabel.Location = new System.Drawing.Point(643, 551);
            this.lblAPCANameLabel.Name = "lblAPCANameLabel";
            this.lblAPCANameLabel.Size = new System.Drawing.Size(200, 20);
            this.lblAPCANameLabel.TabIndex = 17;
            this.lblAPCANameLabel.Text = "APCA Name:";
            this.lblAPCANameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblComputerName
            // 
            this.lblComputerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblComputerName.Location = new System.Drawing.Point(848, 527);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(120, 20);
            this.lblComputerName.TabIndex = 16;
            this.lblComputerName.Text = "NaN";
            this.lblComputerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComputerNameLabel
            // 
            this.lblComputerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblComputerNameLabel.Location = new System.Drawing.Point(643, 527);
            this.lblComputerNameLabel.Name = "lblComputerNameLabel";
            this.lblComputerNameLabel.Size = new System.Drawing.Size(200, 20);
            this.lblComputerNameLabel.TabIndex = 15;
            this.lblComputerNameLabel.Text = "This computer name:";
            this.lblComputerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCalculatedStatus2
            // 
            this.lblCalculatedStatus2.AutoSize = true;
            this.lblCalculatedStatus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCalculatedStatus2.ForeColor = System.Drawing.Color.Red;
            this.lblCalculatedStatus2.Location = new System.Drawing.Point(464, 377);
            this.lblCalculatedStatus2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculatedStatus2.Name = "lblCalculatedStatus2";
            this.lblCalculatedStatus2.Size = new System.Drawing.Size(54, 25);
            this.lblCalculatedStatus2.TabIndex = 14;
            this.lblCalculatedStatus2.Text = "NaN";
            // 
            // lblCalculatedStatus2Label
            // 
            this.lblCalculatedStatus2Label.AutoSize = true;
            this.lblCalculatedStatus2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCalculatedStatus2Label.ForeColor = System.Drawing.Color.Red;
            this.lblCalculatedStatus2Label.Location = new System.Drawing.Point(325, 377);
            this.lblCalculatedStatus2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculatedStatus2Label.Name = "lblCalculatedStatus2Label";
            this.lblCalculatedStatus2Label.Size = new System.Drawing.Size(124, 25);
            this.lblCalculatedStatus2Label.TabIndex = 13;
            this.lblCalculatedStatus2Label.Text = "Error Code:";
            // 
            // lblOPCConnectionOK
            // 
            this.lblOPCConnectionOK.AutoSize = true;
            this.lblOPCConnectionOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOPCConnectionOK.Location = new System.Drawing.Point(221, 560);
            this.lblOPCConnectionOK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOPCConnectionOK.Name = "lblOPCConnectionOK";
            this.lblOPCConnectionOK.Size = new System.Drawing.Size(54, 25);
            this.lblOPCConnectionOK.TabIndex = 11;
            this.lblOPCConnectionOK.Text = "NaN";
            // 
            // lblOPCConnectionOKLabel
            // 
            this.lblOPCConnectionOKLabel.AutoSize = true;
            this.lblOPCConnectionOKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOPCConnectionOKLabel.Location = new System.Drawing.Point(45, 560);
            this.lblOPCConnectionOKLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOPCConnectionOKLabel.Name = "lblOPCConnectionOKLabel";
            this.lblOPCConnectionOKLabel.Size = new System.Drawing.Size(167, 25);
            this.lblOPCConnectionOKLabel.TabIndex = 10;
            this.lblOPCConnectionOKLabel.Text = "OPC Connection:";
            // 
            // lblConfigurationOK
            // 
            this.lblConfigurationOK.AutoSize = true;
            this.lblConfigurationOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblConfigurationOK.Location = new System.Drawing.Point(221, 526);
            this.lblConfigurationOK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfigurationOK.Name = "lblConfigurationOK";
            this.lblConfigurationOK.Size = new System.Drawing.Size(54, 25);
            this.lblConfigurationOK.TabIndex = 9;
            this.lblConfigurationOK.Text = "NaN";
            // 
            // lblConfigurationOKLabel
            // 
            this.lblConfigurationOKLabel.AutoSize = true;
            this.lblConfigurationOKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblConfigurationOKLabel.Location = new System.Drawing.Point(77, 526);
            this.lblConfigurationOKLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfigurationOKLabel.Name = "lblConfigurationOKLabel";
            this.lblConfigurationOKLabel.Size = new System.Drawing.Size(134, 25);
            this.lblConfigurationOKLabel.TabIndex = 8;
            this.lblConfigurationOKLabel.Text = "Configuration:";
            // 
            // lblCalculatedFlowValue2
            // 
            this.lblCalculatedFlowValue2.AutoSize = true;
            this.lblCalculatedFlowValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCalculatedFlowValue2.Location = new System.Drawing.Point(597, 325);
            this.lblCalculatedFlowValue2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculatedFlowValue2.Name = "lblCalculatedFlowValue2";
            this.lblCalculatedFlowValue2.Size = new System.Drawing.Size(78, 36);
            this.lblCalculatedFlowValue2.TabIndex = 7;
            this.lblCalculatedFlowValue2.Text = "NaN";
            this.lblCalculatedFlowValue2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCalculatedFlowLabel2
            // 
            this.lblCalculatedFlowLabel2.AutoSize = true;
            this.lblCalculatedFlowLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCalculatedFlowLabel2.Location = new System.Drawing.Point(229, 325);
            this.lblCalculatedFlowLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculatedFlowLabel2.Name = "lblCalculatedFlowLabel2";
            this.lblCalculatedFlowLabel2.Size = new System.Drawing.Size(329, 36);
            this.lblCalculatedFlowLabel2.TabIndex = 6;
            this.lblCalculatedFlowLabel2.Text = "Calculated flow [kg/h]:";
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVersion.Location = new System.Drawing.Point(475, 135);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(240, 60);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "NaN";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(528, 645);
            this.lblCopyRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(401, 18);
            this.lblCopyRight.TabIndex = 3;
            this.lblCopyRight.Text = "Copyright 2022 Baker Hughes Company. All rights reserved.";
            this.lblCopyRight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGasFlowCalculator
            // 
            this.lblGasFlowCalculator.AutoSize = true;
            this.lblGasFlowCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGasFlowCalculator.Location = new System.Drawing.Point(420, 89);
            this.lblGasFlowCalculator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGasFlowCalculator.Name = "lblGasFlowCalculator";
            this.lblGasFlowCalculator.Size = new System.Drawing.Size(343, 39);
            this.lblGasFlowCalculator.TabIndex = 2;
            this.lblGasFlowCalculator.Text = "Gas Flow Calculator";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::GFC.Properties.Resources.BKR;
            this.picLogo.Location = new System.Drawing.Point(75, 49);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(133, 123);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblBakerHughesLabel
            // 
            this.lblBakerHughesLabel.AutoSize = true;
            this.lblBakerHughesLabel.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBakerHughesLabel.Location = new System.Drawing.Point(33, 177);
            this.lblBakerHughesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBakerHughesLabel.Name = "lblBakerHughesLabel";
            this.lblBakerHughesLabel.Size = new System.Drawing.Size(210, 48);
            this.lblBakerHughesLabel.TabIndex = 0;
            this.lblBakerHughesLabel.Text = "Baker Hughes";
            // 
            // tabCalculation
            // 
            this.tabCalculation.Controls.Add(this.lblCalculationComment);
            this.tabCalculation.Controls.Add(this.lblCalculationErrorCodeDescription);
            this.tabCalculation.Controls.Add(this.lblCalculatedStatus);
            this.tabCalculation.Controls.Add(this.lblCalculatedStatusLabel);
            this.tabCalculation.Controls.Add(this.lblCalculationRunning);
            this.tabCalculation.Controls.Add(this.lblCalculatedFlowValue);
            this.tabCalculation.Controls.Add(this.lblCalculatedFlowLabel);
            this.tabCalculation.Controls.Add(this.panel1);
            this.tabCalculation.Controls.Add(this.pnlChokeValues);
            this.tabCalculation.Controls.Add(this.pnlSelecedPVTValues);
            this.tabCalculation.Controls.Add(this.pnlActualValues);
            this.tabCalculation.Location = new System.Drawing.Point(4, 27);
            this.tabCalculation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCalculation.Name = "tabCalculation";
            this.tabCalculation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCalculation.Size = new System.Drawing.Size(981, 684);
            this.tabCalculation.TabIndex = 1;
            this.tabCalculation.Text = "Calculation";
            this.tabCalculation.UseVisualStyleBackColor = true;
            // 
            // lblCalculationComment
            // 
            this.lblCalculationComment.AutoSize = true;
            this.lblCalculationComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCalculationComment.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCalculationComment.Location = new System.Drawing.Point(48, 571);
            this.lblCalculationComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculationComment.Name = "lblCalculationComment";
            this.lblCalculationComment.Size = new System.Drawing.Size(178, 20);
            this.lblCalculationComment.TabIndex = 11;
            this.lblCalculationComment.Text = "Calculation Comments";
            this.lblCalculationComment.Visible = false;
            // 
            // lblCalculationErrorCodeDescription
            // 
            this.lblCalculationErrorCodeDescription.AutoSize = true;
            this.lblCalculationErrorCodeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCalculationErrorCodeDescription.ForeColor = System.Drawing.Color.Red;
            this.lblCalculationErrorCodeDescription.Location = new System.Drawing.Point(520, 537);
            this.lblCalculationErrorCodeDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculationErrorCodeDescription.Name = "lblCalculationErrorCodeDescription";
            this.lblCalculationErrorCodeDescription.Size = new System.Drawing.Size(187, 20);
            this.lblCalculationErrorCodeDescription.TabIndex = 10;
            this.lblCalculationErrorCodeDescription.Text = "Error Codes description";
            // 
            // lblCalculatedStatus
            // 
            this.lblCalculatedStatus.AutoSize = true;
            this.lblCalculatedStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCalculatedStatus.ForeColor = System.Drawing.Color.Red;
            this.lblCalculatedStatus.Location = new System.Drawing.Point(212, 572);
            this.lblCalculatedStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculatedStatus.Name = "lblCalculatedStatus";
            this.lblCalculatedStatus.Size = new System.Drawing.Size(45, 20);
            this.lblCalculatedStatus.TabIndex = 9;
            this.lblCalculatedStatus.Text = "NaN";
            this.lblCalculatedStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCalculatedStatusLabel
            // 
            this.lblCalculatedStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCalculatedStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.lblCalculatedStatusLabel.Location = new System.Drawing.Point(83, 572);
            this.lblCalculatedStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculatedStatusLabel.Name = "lblCalculatedStatusLabel";
            this.lblCalculatedStatusLabel.Size = new System.Drawing.Size(123, 20);
            this.lblCalculatedStatusLabel.TabIndex = 8;
            this.lblCalculatedStatusLabel.Text = "Error Code:";
            this.lblCalculatedStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCalculationRunning
            // 
            this.lblCalculationRunning.AutoSize = true;
            this.lblCalculationRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCalculationRunning.Location = new System.Drawing.Point(45, 645);
            this.lblCalculationRunning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculationRunning.Name = "lblCalculationRunning";
            this.lblCalculationRunning.Size = new System.Drawing.Size(91, 18);
            this.lblCalculationRunning.TabIndex = 7;
            this.lblCalculationRunning.Text = "CalcHeartBit";
            // 
            // lblCalculatedFlowValue
            // 
            this.lblCalculatedFlowValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCalculatedFlowValue.Location = new System.Drawing.Point(337, 530);
            this.lblCalculatedFlowValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculatedFlowValue.Name = "lblCalculatedFlowValue";
            this.lblCalculatedFlowValue.Size = new System.Drawing.Size(133, 30);
            this.lblCalculatedFlowValue.TabIndex = 6;
            this.lblCalculatedFlowValue.Text = "NaN";
            this.lblCalculatedFlowValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCalculatedFlowLabel
            // 
            this.lblCalculatedFlowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCalculatedFlowLabel.Location = new System.Drawing.Point(37, 530);
            this.lblCalculatedFlowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculatedFlowLabel.Name = "lblCalculatedFlowLabel";
            this.lblCalculatedFlowLabel.Size = new System.Drawing.Size(293, 30);
            this.lblCalculatedFlowLabel.TabIndex = 5;
            this.lblCalculatedFlowLabel.Text = "Calculated flow [kg/h]:";
            this.lblCalculatedFlowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSetDensityMultiplier);
            this.panel1.Controls.Add(this.btnSetDischargeCoefficient);
            this.panel1.Controls.Add(this.txtDensityMultiplier);
            this.panel1.Controls.Add(this.txtDischargeCoefficient);
            this.panel1.Controls.Add(this.lblDensityMultiplierLabel);
            this.panel1.Controls.Add(this.lblDischargeCoefficientLabel);
            this.panel1.Controls.Add(this.lblSettings);
            this.panel1.Location = new System.Drawing.Point(507, 363);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 147);
            this.panel1.TabIndex = 4;
            // 
            // btnSetDensityMultiplier
            // 
            this.btnSetDensityMultiplier.Location = new System.Drawing.Point(327, 82);
            this.btnSetDensityMultiplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetDensityMultiplier.Name = "btnSetDensityMultiplier";
            this.btnSetDensityMultiplier.Size = new System.Drawing.Size(80, 28);
            this.btnSetDensityMultiplier.TabIndex = 16;
            this.btnSetDensityMultiplier.Text = "Set";
            this.btnSetDensityMultiplier.UseVisualStyleBackColor = true;
            this.btnSetDensityMultiplier.Click += new System.EventHandler(this.btnSetDensityMultiplier_Click);
            // 
            // btnSetDischargeCoefficient
            // 
            this.btnSetDischargeCoefficient.Location = new System.Drawing.Point(327, 46);
            this.btnSetDischargeCoefficient.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetDischargeCoefficient.Name = "btnSetDischargeCoefficient";
            this.btnSetDischargeCoefficient.Size = new System.Drawing.Size(80, 28);
            this.btnSetDischargeCoefficient.TabIndex = 15;
            this.btnSetDischargeCoefficient.Text = "Set";
            this.btnSetDischargeCoefficient.UseVisualStyleBackColor = true;
            this.btnSetDischargeCoefficient.Click += new System.EventHandler(this.btnSetDischargeCoefficient_Click);
            // 
            // txtDensityMultiplier
            // 
            this.txtDensityMultiplier.Location = new System.Drawing.Point(257, 84);
            this.txtDensityMultiplier.Margin = new System.Windows.Forms.Padding(4);
            this.txtDensityMultiplier.Name = "txtDensityMultiplier";
            this.txtDensityMultiplier.Size = new System.Drawing.Size(45, 24);
            this.txtDensityMultiplier.TabIndex = 14;
            this.txtDensityMultiplier.Text = "NaN";
            this.txtDensityMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDensityMultiplier.TextChanged += new System.EventHandler(this.txtDensityMultiplier_TextChanged);
            // 
            // txtDischargeCoefficient
            // 
            this.txtDischargeCoefficient.Location = new System.Drawing.Point(257, 47);
            this.txtDischargeCoefficient.Margin = new System.Windows.Forms.Padding(4);
            this.txtDischargeCoefficient.Name = "txtDischargeCoefficient";
            this.txtDischargeCoefficient.Size = new System.Drawing.Size(45, 24);
            this.txtDischargeCoefficient.TabIndex = 13;
            this.txtDischargeCoefficient.Text = "NaN";
            this.txtDischargeCoefficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDischargeCoefficient.TextChanged += new System.EventHandler(this.txtDischargeCoefficient_TextChanged);
            // 
            // lblDensityMultiplierLabel
            // 
            this.lblDensityMultiplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDensityMultiplierLabel.Location = new System.Drawing.Point(40, 81);
            this.lblDensityMultiplierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDensityMultiplierLabel.Name = "lblDensityMultiplierLabel";
            this.lblDensityMultiplierLabel.Size = new System.Drawing.Size(200, 25);
            this.lblDensityMultiplierLabel.TabIndex = 12;
            this.lblDensityMultiplierLabel.Text = "Density Multiplier";
            this.lblDensityMultiplierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDischargeCoefficientLabel
            // 
            this.lblDischargeCoefficientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDischargeCoefficientLabel.Location = new System.Drawing.Point(40, 52);
            this.lblDischargeCoefficientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDischargeCoefficientLabel.Name = "lblDischargeCoefficientLabel";
            this.lblDischargeCoefficientLabel.Size = new System.Drawing.Size(200, 18);
            this.lblDischargeCoefficientLabel.TabIndex = 11;
            this.lblDischargeCoefficientLabel.Text = "Discharge Coefficient";
            this.lblDischargeCoefficientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSettings.Location = new System.Drawing.Point(13, 12);
            this.lblSettings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(84, 20);
            this.lblSettings.TabIndex = 0;
            this.lblSettings.Text = "Settings:";
            // 
            // pnlChokeValues
            // 
            this.pnlChokeValues.BackColor = System.Drawing.Color.Transparent;
            this.pnlChokeValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChokeValues.Controls.Add(this.lblCVUnit);
            this.pnlChokeValues.Controls.Add(this.lblSelectedChokeCVValueStatus);
            this.pnlChokeValues.Controls.Add(this.lblSelectedChokeCVValueValue);
            this.pnlChokeValues.Controls.Add(this.lblCVTableValueStatus);
            this.pnlChokeValues.Controls.Add(this.lblCVTableValue);
            this.pnlChokeValues.Controls.Add(this.lblCV);
            this.pnlChokeValues.Controls.Add(this.lblSelectedChokeCVValue);
            this.pnlChokeValues.Location = new System.Drawing.Point(33, 363);
            this.pnlChokeValues.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChokeValues.Name = "pnlChokeValues";
            this.pnlChokeValues.Size = new System.Drawing.Size(453, 147);
            this.pnlChokeValues.TabIndex = 3;
            // 
            // lblCVUnit
            // 
            this.lblCVUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCVUnit.Location = new System.Drawing.Point(273, 55);
            this.lblCVUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCVUnit.Name = "lblCVUnit";
            this.lblCVUnit.Size = new System.Drawing.Size(173, 18);
            this.lblCVUnit.TabIndex = 23;
            this.lblCVUnit.Text = "[Gallons/min/sqrt(psi)]";
            this.lblCVUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedChokeCVValueStatus
            // 
            this.lblSelectedChokeCVValueStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSelectedChokeCVValueStatus.Location = new System.Drawing.Point(180, 111);
            this.lblSelectedChokeCVValueStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedChokeCVValueStatus.Name = "lblSelectedChokeCVValueStatus";
            this.lblSelectedChokeCVValueStatus.Size = new System.Drawing.Size(107, 18);
            this.lblSelectedChokeCVValueStatus.TabIndex = 12;
            this.lblSelectedChokeCVValueStatus.Text = "Status:";
            this.lblSelectedChokeCVValueStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSelectedChokeCVValueValue
            // 
            this.lblSelectedChokeCVValueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSelectedChokeCVValueValue.Location = new System.Drawing.Point(180, 86);
            this.lblSelectedChokeCVValueValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedChokeCVValueValue.Name = "lblSelectedChokeCVValueValue";
            this.lblSelectedChokeCVValueValue.Size = new System.Drawing.Size(107, 18);
            this.lblSelectedChokeCVValueValue.TabIndex = 11;
            this.lblSelectedChokeCVValueValue.Text = "Value:";
            this.lblSelectedChokeCVValueValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCVTableValueStatus
            // 
            this.lblCVTableValueStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCVTableValueStatus.Location = new System.Drawing.Point(287, 111);
            this.lblCVTableValueStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCVTableValueStatus.Name = "lblCVTableValueStatus";
            this.lblCVTableValueStatus.Size = new System.Drawing.Size(147, 18);
            this.lblCVTableValueStatus.TabIndex = 10;
            this.lblCVTableValueStatus.Text = "NaN";
            this.lblCVTableValueStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCVTableValue
            // 
            this.lblCVTableValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCVTableValue.Location = new System.Drawing.Point(287, 86);
            this.lblCVTableValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCVTableValue.Name = "lblCVTableValue";
            this.lblCVTableValue.Size = new System.Drawing.Size(147, 18);
            this.lblCVTableValue.TabIndex = 9;
            this.lblCVTableValue.Text = "NaN";
            this.lblCVTableValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCV
            // 
            this.lblCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCV.Location = new System.Drawing.Point(287, 31);
            this.lblCV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(147, 18);
            this.lblCV.TabIndex = 1;
            this.lblCV.Text = "CV";
            this.lblCV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedChokeCVValue
            // 
            this.lblSelectedChokeCVValue.AutoSize = true;
            this.lblSelectedChokeCVValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSelectedChokeCVValue.Location = new System.Drawing.Point(13, 12);
            this.lblSelectedChokeCVValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedChokeCVValue.Name = "lblSelectedChokeCVValue";
            this.lblSelectedChokeCVValue.Size = new System.Drawing.Size(230, 20);
            this.lblSelectedChokeCVValue.TabIndex = 0;
            this.lblSelectedChokeCVValue.Text = "Selected Choke CV Value:";
            // 
            // pnlSelecedPVTValues
            // 
            this.pnlSelecedPVTValues.BackColor = System.Drawing.Color.Transparent;
            this.pnlSelecedPVTValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelecedPVTValues.Controls.Add(this.lblCPGUnit);
            this.pnlSelecedPVTValues.Controls.Add(this.lblROGUnit);
            this.pnlSelecedPVTValues.Controls.Add(this.lblPVTTableCPGValueStatus);
            this.pnlSelecedPVTValues.Controls.Add(this.lblPVTTableCPGValue);
            this.pnlSelecedPVTValues.Controls.Add(this.lblPVTTableDROGDTValueStatus);
            this.pnlSelecedPVTValues.Controls.Add(this.lblPVTTableDROGDTValue);
            this.pnlSelecedPVTValues.Controls.Add(this.lblPVTTableDROGDPValueStatus);
            this.pnlSelecedPVTValues.Controls.Add(this.lblPVTTableDROGDPValue);
            this.pnlSelecedPVTValues.Controls.Add(this.lblSelectedPVTValuesStatus);
            this.pnlSelecedPVTValues.Controls.Add(this.lblSelectedPVTValuesValue);
            this.pnlSelecedPVTValues.Controls.Add(this.lblPVTTableROGValueStatus);
            this.pnlSelecedPVTValues.Controls.Add(this.lblPVTTableROGValue);
            this.pnlSelecedPVTValues.Controls.Add(this.lblCPG);
            this.pnlSelecedPVTValues.Controls.Add(this.lblDROGDT);
            this.pnlSelecedPVTValues.Controls.Add(this.lblDROGDP);
            this.pnlSelecedPVTValues.Controls.Add(this.lblROG);
            this.pnlSelecedPVTValues.Controls.Add(this.lblSelectedPVTValues);
            this.pnlSelecedPVTValues.Location = new System.Drawing.Point(33, 197);
            this.pnlSelecedPVTValues.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSelecedPVTValues.Name = "pnlSelecedPVTValues";
            this.pnlSelecedPVTValues.Size = new System.Drawing.Size(913, 147);
            this.pnlSelecedPVTValues.TabIndex = 2;
            // 
            // lblCPGUnit
            // 
            this.lblCPGUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCPGUnit.Location = new System.Drawing.Point(727, 55);
            this.lblCPGUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPGUnit.Name = "lblCPGUnit";
            this.lblCPGUnit.Size = new System.Drawing.Size(147, 18);
            this.lblCPGUnit.TabIndex = 22;
            this.lblCPGUnit.Text = "[J/kg/K]";
            this.lblCPGUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblROGUnit
            // 
            this.lblROGUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblROGUnit.Location = new System.Drawing.Point(287, 55);
            this.lblROGUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblROGUnit.Name = "lblROGUnit";
            this.lblROGUnit.Size = new System.Drawing.Size(147, 18);
            this.lblROGUnit.TabIndex = 19;
            this.lblROGUnit.Text = "[kg/m3]";
            this.lblROGUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPVTTableCPGValueStatus
            // 
            this.lblPVTTableCPGValueStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPVTTableCPGValueStatus.Location = new System.Drawing.Point(727, 111);
            this.lblPVTTableCPGValueStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPVTTableCPGValueStatus.Name = "lblPVTTableCPGValueStatus";
            this.lblPVTTableCPGValueStatus.Size = new System.Drawing.Size(147, 18);
            this.lblPVTTableCPGValueStatus.TabIndex = 18;
            this.lblPVTTableCPGValueStatus.Text = "NaN";
            this.lblPVTTableCPGValueStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPVTTableCPGValue
            // 
            this.lblPVTTableCPGValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPVTTableCPGValue.Location = new System.Drawing.Point(727, 86);
            this.lblPVTTableCPGValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPVTTableCPGValue.Name = "lblPVTTableCPGValue";
            this.lblPVTTableCPGValue.Size = new System.Drawing.Size(147, 18);
            this.lblPVTTableCPGValue.TabIndex = 17;
            this.lblPVTTableCPGValue.Text = "NaN";
            this.lblPVTTableCPGValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPVTTableDROGDTValueStatus
            // 
            this.lblPVTTableDROGDTValueStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPVTTableDROGDTValueStatus.Location = new System.Drawing.Point(580, 111);
            this.lblPVTTableDROGDTValueStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPVTTableDROGDTValueStatus.Name = "lblPVTTableDROGDTValueStatus";
            this.lblPVTTableDROGDTValueStatus.Size = new System.Drawing.Size(147, 22);
            this.lblPVTTableDROGDTValueStatus.TabIndex = 16;
            this.lblPVTTableDROGDTValueStatus.Text = "NaN";
            this.lblPVTTableDROGDTValueStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPVTTableDROGDTValue
            // 
            this.lblPVTTableDROGDTValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPVTTableDROGDTValue.Location = new System.Drawing.Point(580, 86);
            this.lblPVTTableDROGDTValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPVTTableDROGDTValue.Name = "lblPVTTableDROGDTValue";
            this.lblPVTTableDROGDTValue.Size = new System.Drawing.Size(147, 18);
            this.lblPVTTableDROGDTValue.TabIndex = 15;
            this.lblPVTTableDROGDTValue.Text = "NaN";
            this.lblPVTTableDROGDTValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPVTTableDROGDPValueStatus
            // 
            this.lblPVTTableDROGDPValueStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPVTTableDROGDPValueStatus.Location = new System.Drawing.Point(433, 111);
            this.lblPVTTableDROGDPValueStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPVTTableDROGDPValueStatus.Name = "lblPVTTableDROGDPValueStatus";
            this.lblPVTTableDROGDPValueStatus.Size = new System.Drawing.Size(147, 18);
            this.lblPVTTableDROGDPValueStatus.TabIndex = 14;
            this.lblPVTTableDROGDPValueStatus.Text = "NaN";
            this.lblPVTTableDROGDPValueStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPVTTableDROGDPValue
            // 
            this.lblPVTTableDROGDPValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPVTTableDROGDPValue.Location = new System.Drawing.Point(433, 86);
            this.lblPVTTableDROGDPValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPVTTableDROGDPValue.Name = "lblPVTTableDROGDPValue";
            this.lblPVTTableDROGDPValue.Size = new System.Drawing.Size(147, 18);
            this.lblPVTTableDROGDPValue.TabIndex = 13;
            this.lblPVTTableDROGDPValue.Text = "NaN";
            this.lblPVTTableDROGDPValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedPVTValuesStatus
            // 
            this.lblSelectedPVTValuesStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSelectedPVTValuesStatus.Location = new System.Drawing.Point(180, 111);
            this.lblSelectedPVTValuesStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedPVTValuesStatus.Name = "lblSelectedPVTValuesStatus";
            this.lblSelectedPVTValuesStatus.Size = new System.Drawing.Size(107, 18);
            this.lblSelectedPVTValuesStatus.TabIndex = 12;
            this.lblSelectedPVTValuesStatus.Text = "Status:";
            this.lblSelectedPVTValuesStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSelectedPVTValuesValue
            // 
            this.lblSelectedPVTValuesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSelectedPVTValuesValue.Location = new System.Drawing.Point(180, 86);
            this.lblSelectedPVTValuesValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedPVTValuesValue.Name = "lblSelectedPVTValuesValue";
            this.lblSelectedPVTValuesValue.Size = new System.Drawing.Size(107, 18);
            this.lblSelectedPVTValuesValue.TabIndex = 11;
            this.lblSelectedPVTValuesValue.Text = "Value:";
            this.lblSelectedPVTValuesValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPVTTableROGValueStatus
            // 
            this.lblPVTTableROGValueStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPVTTableROGValueStatus.Location = new System.Drawing.Point(287, 111);
            this.lblPVTTableROGValueStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPVTTableROGValueStatus.Name = "lblPVTTableROGValueStatus";
            this.lblPVTTableROGValueStatus.Size = new System.Drawing.Size(147, 18);
            this.lblPVTTableROGValueStatus.TabIndex = 10;
            this.lblPVTTableROGValueStatus.Text = "NaN";
            this.lblPVTTableROGValueStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPVTTableROGValue
            // 
            this.lblPVTTableROGValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPVTTableROGValue.Location = new System.Drawing.Point(287, 86);
            this.lblPVTTableROGValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPVTTableROGValue.Name = "lblPVTTableROGValue";
            this.lblPVTTableROGValue.Size = new System.Drawing.Size(147, 18);
            this.lblPVTTableROGValue.TabIndex = 9;
            this.lblPVTTableROGValue.Text = "NaN";
            this.lblPVTTableROGValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCPG
            // 
            this.lblCPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCPG.Location = new System.Drawing.Point(727, 31);
            this.lblCPG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPG.Name = "lblCPG";
            this.lblCPG.Size = new System.Drawing.Size(147, 18);
            this.lblCPG.TabIndex = 4;
            this.lblCPG.Text = "CPG";
            this.lblCPG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDROGDT
            // 
            this.lblDROGDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDROGDT.Location = new System.Drawing.Point(580, 31);
            this.lblDROGDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDROGDT.Name = "lblDROGDT";
            this.lblDROGDT.Size = new System.Drawing.Size(147, 18);
            this.lblDROGDT.TabIndex = 3;
            this.lblDROGDT.Text = "DROGDT";
            this.lblDROGDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDROGDP
            // 
            this.lblDROGDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDROGDP.Location = new System.Drawing.Point(433, 31);
            this.lblDROGDP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDROGDP.Name = "lblDROGDP";
            this.lblDROGDP.Size = new System.Drawing.Size(147, 18);
            this.lblDROGDP.TabIndex = 2;
            this.lblDROGDP.Text = "DROGDP";
            this.lblDROGDP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblROG
            // 
            this.lblROG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblROG.Location = new System.Drawing.Point(287, 31);
            this.lblROG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblROG.Name = "lblROG";
            this.lblROG.Size = new System.Drawing.Size(147, 18);
            this.lblROG.TabIndex = 1;
            this.lblROG.Text = "ROG";
            this.lblROG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedPVTValues
            // 
            this.lblSelectedPVTValues.AutoSize = true;
            this.lblSelectedPVTValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSelectedPVTValues.Location = new System.Drawing.Point(13, 12);
            this.lblSelectedPVTValues.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedPVTValues.Name = "lblSelectedPVTValues";
            this.lblSelectedPVTValues.Size = new System.Drawing.Size(192, 20);
            this.lblSelectedPVTValues.TabIndex = 0;
            this.lblSelectedPVTValues.Text = "Selected PVT Values:";
            // 
            // pnlActualValues
            // 
            this.pnlActualValues.BackColor = System.Drawing.Color.Transparent;
            this.pnlActualValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActualValues.Controls.Add(this.lblTemperatureTStatus);
            this.pnlActualValues.Controls.Add(this.lblTemperatureTValue);
            this.pnlActualValues.Controls.Add(this.lblPressureP2Status);
            this.pnlActualValues.Controls.Add(this.lblPressureP2Value);
            this.pnlActualValues.Controls.Add(this.lblPressureP1Status);
            this.pnlActualValues.Controls.Add(this.lblPressureP1Value);
            this.pnlActualValues.Controls.Add(this.lblActualProcesValuesStatus);
            this.pnlActualValues.Controls.Add(this.lblActualProcesValuesValue);
            this.pnlActualValues.Controls.Add(this.lblChokeOpenStatus);
            this.pnlActualValues.Controls.Add(this.lblChokeOpenValue);
            this.pnlActualValues.Controls.Add(this.lblTemperatureTUnit);
            this.pnlActualValues.Controls.Add(this.lblPressureP2Unit);
            this.pnlActualValues.Controls.Add(this.lblPressureP1Unit);
            this.pnlActualValues.Controls.Add(this.lblChokeOpenUnit);
            this.pnlActualValues.Controls.Add(this.lblTemperatureT);
            this.pnlActualValues.Controls.Add(this.lblPressureP2);
            this.pnlActualValues.Controls.Add(this.lblPressureP1);
            this.pnlActualValues.Controls.Add(this.lblChokeOpen);
            this.pnlActualValues.Controls.Add(this.lblActualValues);
            this.pnlActualValues.Location = new System.Drawing.Point(33, 31);
            this.pnlActualValues.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActualValues.Name = "pnlActualValues";
            this.pnlActualValues.Size = new System.Drawing.Size(913, 147);
            this.pnlActualValues.TabIndex = 1;
            // 
            // lblTemperatureTStatus
            // 
            this.lblTemperatureTStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemperatureTStatus.Location = new System.Drawing.Point(727, 111);
            this.lblTemperatureTStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperatureTStatus.Name = "lblTemperatureTStatus";
            this.lblTemperatureTStatus.Size = new System.Drawing.Size(147, 18);
            this.lblTemperatureTStatus.TabIndex = 18;
            this.lblTemperatureTStatus.Text = "NaN";
            this.lblTemperatureTStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemperatureTValue
            // 
            this.lblTemperatureTValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemperatureTValue.Location = new System.Drawing.Point(727, 86);
            this.lblTemperatureTValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperatureTValue.Name = "lblTemperatureTValue";
            this.lblTemperatureTValue.Size = new System.Drawing.Size(147, 18);
            this.lblTemperatureTValue.TabIndex = 17;
            this.lblTemperatureTValue.Text = "NaN";
            this.lblTemperatureTValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPressureP2Status
            // 
            this.lblPressureP2Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPressureP2Status.Location = new System.Drawing.Point(580, 111);
            this.lblPressureP2Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPressureP2Status.Name = "lblPressureP2Status";
            this.lblPressureP2Status.Size = new System.Drawing.Size(147, 22);
            this.lblPressureP2Status.TabIndex = 16;
            this.lblPressureP2Status.Text = "NaN";
            this.lblPressureP2Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPressureP2Value
            // 
            this.lblPressureP2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPressureP2Value.Location = new System.Drawing.Point(580, 86);
            this.lblPressureP2Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPressureP2Value.Name = "lblPressureP2Value";
            this.lblPressureP2Value.Size = new System.Drawing.Size(147, 18);
            this.lblPressureP2Value.TabIndex = 15;
            this.lblPressureP2Value.Text = "NaN";
            this.lblPressureP2Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPressureP1Status
            // 
            this.lblPressureP1Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPressureP1Status.Location = new System.Drawing.Point(433, 111);
            this.lblPressureP1Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPressureP1Status.Name = "lblPressureP1Status";
            this.lblPressureP1Status.Size = new System.Drawing.Size(147, 18);
            this.lblPressureP1Status.TabIndex = 14;
            this.lblPressureP1Status.Text = "NaN";
            this.lblPressureP1Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPressureP1Value
            // 
            this.lblPressureP1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPressureP1Value.Location = new System.Drawing.Point(433, 86);
            this.lblPressureP1Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPressureP1Value.Name = "lblPressureP1Value";
            this.lblPressureP1Value.Size = new System.Drawing.Size(147, 18);
            this.lblPressureP1Value.TabIndex = 13;
            this.lblPressureP1Value.Text = "NaN";
            this.lblPressureP1Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActualProcesValuesStatus
            // 
            this.lblActualProcesValuesStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActualProcesValuesStatus.Location = new System.Drawing.Point(180, 111);
            this.lblActualProcesValuesStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActualProcesValuesStatus.Name = "lblActualProcesValuesStatus";
            this.lblActualProcesValuesStatus.Size = new System.Drawing.Size(107, 18);
            this.lblActualProcesValuesStatus.TabIndex = 12;
            this.lblActualProcesValuesStatus.Text = "Status:";
            this.lblActualProcesValuesStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActualProcesValuesValue
            // 
            this.lblActualProcesValuesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActualProcesValuesValue.Location = new System.Drawing.Point(180, 86);
            this.lblActualProcesValuesValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActualProcesValuesValue.Name = "lblActualProcesValuesValue";
            this.lblActualProcesValuesValue.Size = new System.Drawing.Size(107, 18);
            this.lblActualProcesValuesValue.TabIndex = 11;
            this.lblActualProcesValuesValue.Text = "Value:";
            this.lblActualProcesValuesValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChokeOpenStatus
            // 
            this.lblChokeOpenStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblChokeOpenStatus.Location = new System.Drawing.Point(287, 111);
            this.lblChokeOpenStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChokeOpenStatus.Name = "lblChokeOpenStatus";
            this.lblChokeOpenStatus.Size = new System.Drawing.Size(147, 18);
            this.lblChokeOpenStatus.TabIndex = 10;
            this.lblChokeOpenStatus.Text = "NaN";
            this.lblChokeOpenStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChokeOpenValue
            // 
            this.lblChokeOpenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblChokeOpenValue.Location = new System.Drawing.Point(287, 86);
            this.lblChokeOpenValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChokeOpenValue.Name = "lblChokeOpenValue";
            this.lblChokeOpenValue.Size = new System.Drawing.Size(147, 18);
            this.lblChokeOpenValue.TabIndex = 9;
            this.lblChokeOpenValue.Text = "NaN";
            this.lblChokeOpenValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemperatureTUnit
            // 
            this.lblTemperatureTUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemperatureTUnit.Location = new System.Drawing.Point(727, 55);
            this.lblTemperatureTUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperatureTUnit.Name = "lblTemperatureTUnit";
            this.lblTemperatureTUnit.Size = new System.Drawing.Size(147, 18);
            this.lblTemperatureTUnit.TabIndex = 8;
            this.lblTemperatureTUnit.Text = "[decC]";
            this.lblTemperatureTUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPressureP2Unit
            // 
            this.lblPressureP2Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPressureP2Unit.Location = new System.Drawing.Point(580, 55);
            this.lblPressureP2Unit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPressureP2Unit.Name = "lblPressureP2Unit";
            this.lblPressureP2Unit.Size = new System.Drawing.Size(147, 18);
            this.lblPressureP2Unit.TabIndex = 7;
            this.lblPressureP2Unit.Text = "[bar]";
            this.lblPressureP2Unit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPressureP1Unit
            // 
            this.lblPressureP1Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPressureP1Unit.Location = new System.Drawing.Point(433, 55);
            this.lblPressureP1Unit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPressureP1Unit.Name = "lblPressureP1Unit";
            this.lblPressureP1Unit.Size = new System.Drawing.Size(147, 18);
            this.lblPressureP1Unit.TabIndex = 6;
            this.lblPressureP1Unit.Text = "[bar]";
            this.lblPressureP1Unit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChokeOpenUnit
            // 
            this.lblChokeOpenUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblChokeOpenUnit.Location = new System.Drawing.Point(287, 55);
            this.lblChokeOpenUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChokeOpenUnit.Name = "lblChokeOpenUnit";
            this.lblChokeOpenUnit.Size = new System.Drawing.Size(147, 18);
            this.lblChokeOpenUnit.TabIndex = 5;
            this.lblChokeOpenUnit.Text = "[%]";
            this.lblChokeOpenUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemperatureT
            // 
            this.lblTemperatureT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemperatureT.Location = new System.Drawing.Point(727, 31);
            this.lblTemperatureT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperatureT.Name = "lblTemperatureT";
            this.lblTemperatureT.Size = new System.Drawing.Size(147, 18);
            this.lblTemperatureT.TabIndex = 4;
            this.lblTemperatureT.Text = "Temperature T";
            this.lblTemperatureT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPressureP2
            // 
            this.lblPressureP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPressureP2.Location = new System.Drawing.Point(580, 31);
            this.lblPressureP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPressureP2.Name = "lblPressureP2";
            this.lblPressureP2.Size = new System.Drawing.Size(147, 18);
            this.lblPressureP2.TabIndex = 3;
            this.lblPressureP2.Text = "Pressure P2";
            this.lblPressureP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPressureP1
            // 
            this.lblPressureP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPressureP1.Location = new System.Drawing.Point(433, 31);
            this.lblPressureP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPressureP1.Name = "lblPressureP1";
            this.lblPressureP1.Size = new System.Drawing.Size(147, 18);
            this.lblPressureP1.TabIndex = 2;
            this.lblPressureP1.Text = "Pressure P1";
            this.lblPressureP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChokeOpen
            // 
            this.lblChokeOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblChokeOpen.Location = new System.Drawing.Point(287, 31);
            this.lblChokeOpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChokeOpen.Name = "lblChokeOpen";
            this.lblChokeOpen.Size = new System.Drawing.Size(147, 18);
            this.lblChokeOpen.TabIndex = 1;
            this.lblChokeOpen.Text = "Choke opening";
            this.lblChokeOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActualValues
            // 
            this.lblActualValues.AutoSize = true;
            this.lblActualValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActualValues.Location = new System.Drawing.Point(13, 12);
            this.lblActualValues.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActualValues.Name = "lblActualValues";
            this.lblActualValues.Size = new System.Drawing.Size(206, 20);
            this.lblActualValues.TabIndex = 0;
            this.lblActualValues.Text = "Actual Process Values:";
            // 
            // tabOPC
            // 
            this.tabOPC.Controls.Add(this.lblConnectOPCServerComment);
            this.tabOPC.Controls.Add(this.lblMemoryGarbageCollector);
            this.tabOPC.Controls.Add(this.lblOPCAutoReConnect);
            this.tabOPC.Controls.Add(this.lblOPCAutoConnect);
            this.tabOPC.Controls.Add(this.lblMemoryGarbageCollectorLabel);
            this.tabOPC.Controls.Add(this.lblOPCAutoReConnectLabel);
            this.tabOPC.Controls.Add(this.lblOPCAutoConnectLabel);
            this.tabOPC.Controls.Add(this.lblGarbageCollectorActive);
            this.tabOPC.Controls.Add(this.lblReadingWritingOPCItemStatus);
            this.tabOPC.Controls.Add(this.lblConnectionStatusTime);
            this.tabOPC.Controls.Add(this.lblHeartBit);
            this.tabOPC.Controls.Add(this.lblHeartBitLabel);
            this.tabOPC.Controls.Add(this.lblOPCItemPathStatus);
            this.tabOPC.Controls.Add(this.cmbNewOPCServerName);
            this.tabOPC.Controls.Add(this.lblOPCRefresh);
            this.tabOPC.Controls.Add(this.btnSetOPCServerName);
            this.tabOPC.Controls.Add(this.lblNewOPCServerNameLabel);
            this.tabOPC.Controls.Add(this.btnSelectOPCItemsFile);
            this.tabOPC.Controls.Add(this.lblConnectionStatus);
            this.tabOPC.Controls.Add(this.btnDisconnectOPCServer);
            this.tabOPC.Controls.Add(this.btnConnectOPCServer);
            this.tabOPC.Controls.Add(this.lblActiveOPCServer);
            this.tabOPC.Controls.Add(this.prgOPCServerStatus);
            this.tabOPC.Controls.Add(this.lblActiveOPCServerLabel);
            this.tabOPC.Controls.Add(this.lvwOPCItems);
            this.tabOPC.Location = new System.Drawing.Point(4, 27);
            this.tabOPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabOPC.Name = "tabOPC";
            this.tabOPC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabOPC.Size = new System.Drawing.Size(981, 684);
            this.tabOPC.TabIndex = 2;
            this.tabOPC.Text = "OPC Connections";
            this.tabOPC.UseVisualStyleBackColor = true;
            // 
            // lblConnectOPCServerComment
            // 
            this.lblConnectOPCServerComment.AutoSize = true;
            this.lblConnectOPCServerComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblConnectOPCServerComment.Location = new System.Drawing.Point(19, 127);
            this.lblConnectOPCServerComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnectOPCServerComment.Name = "lblConnectOPCServerComment";
            this.lblConnectOPCServerComment.Size = new System.Drawing.Size(199, 16);
            this.lblConnectOPCServerComment.TabIndex = 25;
            this.lblConnectOPCServerComment.Text = "Connect OPCS Server Comment";
            this.lblConnectOPCServerComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMemoryGarbageCollector
            // 
            this.lblMemoryGarbageCollector.AutoSize = true;
            this.lblMemoryGarbageCollector.Location = new System.Drawing.Point(905, 554);
            this.lblMemoryGarbageCollector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemoryGarbageCollector.Name = "lblMemoryGarbageCollector";
            this.lblMemoryGarbageCollector.Size = new System.Drawing.Size(44, 18);
            this.lblMemoryGarbageCollector.TabIndex = 24;
            this.lblMemoryGarbageCollector.Text = "False";
            this.lblMemoryGarbageCollector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMemoryGarbageCollector.Visible = false;
            // 
            // lblOPCAutoReConnect
            // 
            this.lblOPCAutoReConnect.AutoSize = true;
            this.lblOPCAutoReConnect.Location = new System.Drawing.Point(905, 529);
            this.lblOPCAutoReConnect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOPCAutoReConnect.Name = "lblOPCAutoReConnect";
            this.lblOPCAutoReConnect.Size = new System.Drawing.Size(38, 18);
            this.lblOPCAutoReConnect.TabIndex = 23;
            this.lblOPCAutoReConnect.Text = "True";
            this.lblOPCAutoReConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOPCAutoConnect
            // 
            this.lblOPCAutoConnect.AutoSize = true;
            this.lblOPCAutoConnect.Location = new System.Drawing.Point(905, 505);
            this.lblOPCAutoConnect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOPCAutoConnect.Name = "lblOPCAutoConnect";
            this.lblOPCAutoConnect.Size = new System.Drawing.Size(38, 18);
            this.lblOPCAutoConnect.TabIndex = 22;
            this.lblOPCAutoConnect.Text = "True";
            this.lblOPCAutoConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMemoryGarbageCollectorLabel
            // 
            this.lblMemoryGarbageCollectorLabel.AutoSize = true;
            this.lblMemoryGarbageCollectorLabel.Location = new System.Drawing.Point(697, 554);
            this.lblMemoryGarbageCollectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemoryGarbageCollectorLabel.Name = "lblMemoryGarbageCollectorLabel";
            this.lblMemoryGarbageCollectorLabel.Size = new System.Drawing.Size(192, 18);
            this.lblMemoryGarbageCollectorLabel.TabIndex = 21;
            this.lblMemoryGarbageCollectorLabel.Text = "Memory Garbage Collector:";
            this.lblMemoryGarbageCollectorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMemoryGarbageCollectorLabel.Visible = false;
            // 
            // lblOPCAutoReConnectLabel
            // 
            this.lblOPCAutoReConnectLabel.AutoSize = true;
            this.lblOPCAutoReConnectLabel.Location = new System.Drawing.Point(688, 529);
            this.lblOPCAutoReConnectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOPCAutoReConnectLabel.Name = "lblOPCAutoReConnectLabel";
            this.lblOPCAutoReConnectLabel.Size = new System.Drawing.Size(205, 18);
            this.lblOPCAutoReConnectLabel.TabIndex = 20;
            this.lblOPCAutoReConnectLabel.Text = "OPC Server Auto ReConnect:";
            this.lblOPCAutoReConnectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOPCAutoConnectLabel
            // 
            this.lblOPCAutoConnectLabel.AutoSize = true;
            this.lblOPCAutoConnectLabel.Location = new System.Drawing.Point(709, 505);
            this.lblOPCAutoConnectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOPCAutoConnectLabel.Name = "lblOPCAutoConnectLabel";
            this.lblOPCAutoConnectLabel.Size = new System.Drawing.Size(186, 18);
            this.lblOPCAutoConnectLabel.TabIndex = 19;
            this.lblOPCAutoConnectLabel.Text = "OPC Server Auto Connect:";
            this.lblOPCAutoConnectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGarbageCollectorActive
            // 
            this.lblGarbageCollectorActive.Location = new System.Drawing.Point(681, 578);
            this.lblGarbageCollectorActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGarbageCollectorActive.Name = "lblGarbageCollectorActive";
            this.lblGarbageCollectorActive.Size = new System.Drawing.Size(251, 18);
            this.lblGarbageCollectorActive.TabIndex = 18;
            this.lblGarbageCollectorActive.Text = "Memory Garbage Collector Active";
            this.lblGarbageCollectorActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReadingWritingOPCItemStatus
            // 
            this.lblReadingWritingOPCItemStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblReadingWritingOPCItemStatus.ForeColor = System.Drawing.Color.Red;
            this.lblReadingWritingOPCItemStatus.Location = new System.Drawing.Point(239, 420);
            this.lblReadingWritingOPCItemStatus.Name = "lblReadingWritingOPCItemStatus";
            this.lblReadingWritingOPCItemStatus.Size = new System.Drawing.Size(720, 74);
            this.lblReadingWritingOPCItemStatus.TabIndex = 17;
            this.lblReadingWritingOPCItemStatus.Text = "Reading/Writing OPC Items status";
            this.lblReadingWritingOPCItemStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblConnectionStatusTime
            // 
            this.lblConnectionStatusTime.AutoSize = true;
            this.lblConnectionStatusTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblConnectionStatusTime.Location = new System.Drawing.Point(313, 122);
            this.lblConnectionStatusTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnectionStatusTime.Name = "lblConnectionStatusTime";
            this.lblConnectionStatusTime.Size = new System.Drawing.Size(69, 17);
            this.lblConnectionStatusTime.TabIndex = 16;
            this.lblConnectionStatusTime.Text = "DataTime";
            // 
            // lblHeartBit
            // 
            this.lblHeartBit.AutoSize = true;
            this.lblHeartBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeartBit.Location = new System.Drawing.Point(905, 645);
            this.lblHeartBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeartBit.Name = "lblHeartBit";
            this.lblHeartBit.Size = new System.Drawing.Size(42, 18);
            this.lblHeartBit.TabIndex = 15;
            this.lblHeartBit.Text = "True";
            this.lblHeartBit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeartBitLabel
            // 
            this.lblHeartBitLabel.AutoSize = true;
            this.lblHeartBitLabel.Location = new System.Drawing.Point(781, 645);
            this.lblHeartBitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeartBitLabel.Name = "lblHeartBitLabel";
            this.lblHeartBitLabel.Size = new System.Drawing.Size(118, 18);
            this.lblHeartBitLabel.TabIndex = 14;
            this.lblHeartBitLabel.Text = "Heartbit to MCS:";
            this.lblHeartBitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOPCItemPathStatus
            // 
            this.lblOPCItemPathStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOPCItemPathStatus.Location = new System.Drawing.Point(20, 422);
            this.lblOPCItemPathStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOPCItemPathStatus.Name = "lblOPCItemPathStatus";
            this.lblOPCItemPathStatus.Size = new System.Drawing.Size(187, 18);
            this.lblOPCItemPathStatus.TabIndex = 13;
            this.lblOPCItemPathStatus.Text = "OPC Item Path Status";
            this.lblOPCItemPathStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbNewOPCServerName
            // 
            this.cmbNewOPCServerName.FormattingEnabled = true;
            this.cmbNewOPCServerName.Location = new System.Drawing.Point(20, 530);
            this.cmbNewOPCServerName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNewOPCServerName.Name = "cmbNewOPCServerName";
            this.cmbNewOPCServerName.Size = new System.Drawing.Size(399, 26);
            this.cmbNewOPCServerName.TabIndex = 12;
            this.cmbNewOPCServerName.SelectedValueChanged += new System.EventHandler(this.cmbNewOPCServerName_SelectedValueChanged);
            // 
            // lblOPCRefresh
            // 
            this.lblOPCRefresh.AutoSize = true;
            this.lblOPCRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOPCRefresh.Location = new System.Drawing.Point(20, 645);
            this.lblOPCRefresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOPCRefresh.Name = "lblOPCRefresh";
            this.lblOPCRefresh.Size = new System.Drawing.Size(202, 18);
            this.lblOPCRefresh.TabIndex = 11;
            this.lblOPCRefresh.Text = "OPC Item Refresh Rate: NaN";
            this.lblOPCRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSetOPCServerName
            // 
            this.btnSetOPCServerName.Location = new System.Drawing.Point(20, 566);
            this.btnSetOPCServerName.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetOPCServerName.Name = "btnSetOPCServerName";
            this.btnSetOPCServerName.Size = new System.Drawing.Size(187, 30);
            this.btnSetOPCServerName.TabIndex = 10;
            this.btnSetOPCServerName.Text = "Set OPC Server Name";
            this.btnSetOPCServerName.UseVisualStyleBackColor = true;
            this.btnSetOPCServerName.Click += new System.EventHandler(this.btnSetOPCServerName_Click);
            // 
            // lblNewOPCServerNameLabel
            // 
            this.lblNewOPCServerNameLabel.AutoSize = true;
            this.lblNewOPCServerNameLabel.Location = new System.Drawing.Point(20, 505);
            this.lblNewOPCServerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewOPCServerNameLabel.Name = "lblNewOPCServerNameLabel";
            this.lblNewOPCServerNameLabel.Size = new System.Drawing.Size(170, 18);
            this.lblNewOPCServerNameLabel.TabIndex = 8;
            this.lblNewOPCServerNameLabel.Text = "New OPC Server Name:";
            this.lblNewOPCServerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectOPCItemsFile
            // 
            this.btnSelectOPCItemsFile.Location = new System.Drawing.Point(20, 446);
            this.btnSelectOPCItemsFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectOPCItemsFile.Name = "btnSelectOPCItemsFile";
            this.btnSelectOPCItemsFile.Size = new System.Drawing.Size(187, 30);
            this.btnSelectOPCItemsFile.TabIndex = 7;
            this.btnSelectOPCItemsFile.Text = "Select OPC Items File";
            this.btnSelectOPCItemsFile.UseVisualStyleBackColor = true;
            this.btnSelectOPCItemsFile.Click += new System.EventHandler(this.btnSelectOPCItemsFile_Click);
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblConnectionStatus.Location = new System.Drawing.Point(313, 97);
            this.lblConnectionStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(163, 20);
            this.lblConnectionStatus.TabIndex = 6;
            this.lblConnectionStatus.Text = "Connection Status";
            this.lblConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDisconnectOPCServer
            // 
            this.btnDisconnectOPCServer.Enabled = false;
            this.btnDisconnectOPCServer.Location = new System.Drawing.Point(160, 92);
            this.btnDisconnectOPCServer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnectOPCServer.Name = "btnDisconnectOPCServer";
            this.btnDisconnectOPCServer.Size = new System.Drawing.Size(133, 30);
            this.btnDisconnectOPCServer.TabIndex = 5;
            this.btnDisconnectOPCServer.Text = "Disconnect";
            this.btnDisconnectOPCServer.UseVisualStyleBackColor = true;
            this.btnDisconnectOPCServer.Click += new System.EventHandler(this.btnDisconnectOPCServer_Click);
            // 
            // btnConnectOPCServer
            // 
            this.btnConnectOPCServer.Enabled = false;
            this.btnConnectOPCServer.Location = new System.Drawing.Point(20, 92);
            this.btnConnectOPCServer.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnectOPCServer.Name = "btnConnectOPCServer";
            this.btnConnectOPCServer.Size = new System.Drawing.Size(133, 30);
            this.btnConnectOPCServer.TabIndex = 4;
            this.btnConnectOPCServer.Text = "Connect";
            this.btnConnectOPCServer.UseVisualStyleBackColor = true;
            this.btnConnectOPCServer.Click += new System.EventHandler(this.btnConnectOPCServer_Click);
            // 
            // lblActiveOPCServer
            // 
            this.lblActiveOPCServer.AutoSize = true;
            this.lblActiveOPCServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActiveOPCServer.Location = new System.Drawing.Point(47, 55);
            this.lblActiveOPCServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveOPCServer.Name = "lblActiveOPCServer";
            this.lblActiveOPCServer.Size = new System.Drawing.Size(221, 20);
            this.lblActiveOPCServer.TabIndex = 3;
            this.lblActiveOPCServer.Text = "Active OPC Server Name";
            this.lblActiveOPCServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prgOPCServerStatus
            // 
            this.prgOPCServerStatus.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.prgOPCServerStatus.ForeColor = System.Drawing.Color.Lime;
            this.prgOPCServerStatus.Location = new System.Drawing.Point(20, 55);
            this.prgOPCServerStatus.Margin = new System.Windows.Forms.Padding(1);
            this.prgOPCServerStatus.MarqueeAnimationSpeed = 1;
            this.prgOPCServerStatus.Maximum = 1;
            this.prgOPCServerStatus.Name = "prgOPCServerStatus";
            this.prgOPCServerStatus.Size = new System.Drawing.Size(20, 18);
            this.prgOPCServerStatus.TabIndex = 2;
            // 
            // lblActiveOPCServerLabel
            // 
            this.lblActiveOPCServerLabel.AutoSize = true;
            this.lblActiveOPCServerLabel.Location = new System.Drawing.Point(20, 25);
            this.lblActiveOPCServerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveOPCServerLabel.Name = "lblActiveOPCServerLabel";
            this.lblActiveOPCServerLabel.Size = new System.Drawing.Size(176, 18);
            this.lblActiveOPCServerLabel.TabIndex = 1;
            this.lblActiveOPCServerLabel.Text = "Active OPC Server name:";
            this.lblActiveOPCServerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwOPCItems
            // 
            this.lvwOPCItems.AutoArrange = false;
            this.lvwOPCItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GFC,
            this.ItemName,
            this.Value,
            this.Quality,
            this.TimeStamp,
            this.Error});
            this.lvwOPCItems.GridLines = true;
            this.lvwOPCItems.HideSelection = false;
            this.lvwOPCItems.Location = new System.Drawing.Point(20, 171);
            this.lvwOPCItems.Margin = new System.Windows.Forms.Padding(4);
            this.lvwOPCItems.Name = "lvwOPCItems";
            this.lvwOPCItems.Size = new System.Drawing.Size(939, 240);
            this.lvwOPCItems.TabIndex = 0;
            this.lvwOPCItems.UseCompatibleStateImageBehavior = false;
            this.lvwOPCItems.View = System.Windows.Forms.View.Details;
            // 
            // GFC
            // 
            this.GFC.Text = "GFC";
            this.GFC.Width = 110;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 365;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value.Width = 75;
            // 
            // Quality
            // 
            this.Quality.Text = "Quality";
            this.Quality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quality.Width = 55;
            // 
            // TimeStamp
            // 
            this.TimeStamp.Text = "Time Stamp";
            this.TimeStamp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeStamp.Width = 135;
            // 
            // Error
            // 
            this.Error.Text = "Error";
            this.Error.Width = 260;
            // 
            // tabPVT
            // 
            this.tabPVT.Controls.Add(this.lblPVTTableOKStatus);
            this.tabPVT.Controls.Add(this.btnLoadPVTFile);
            this.tabPVT.Controls.Add(this.grpViewSelection);
            this.tabPVT.Controls.Add(this.rtxPVT);
            this.tabPVT.Location = new System.Drawing.Point(4, 27);
            this.tabPVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPVT.Name = "tabPVT";
            this.tabPVT.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPVT.Size = new System.Drawing.Size(981, 684);
            this.tabPVT.TabIndex = 3;
            this.tabPVT.Text = "PVT";
            this.tabPVT.UseVisualStyleBackColor = true;
            // 
            // lblPVTTableOKStatus
            // 
            this.lblPVTTableOKStatus.Location = new System.Drawing.Point(807, 204);
            this.lblPVTTableOKStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPVTTableOKStatus.Name = "lblPVTTableOKStatus";
            this.lblPVTTableOKStatus.Size = new System.Drawing.Size(160, 18);
            this.lblPVTTableOKStatus.TabIndex = 3;
            this.lblPVTTableOKStatus.Text = "PVT Table Status";
            this.lblPVTTableOKStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoadPVTFile
            // 
            this.btnLoadPVTFile.Location = new System.Drawing.Point(807, 228);
            this.btnLoadPVTFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadPVTFile.Name = "btnLoadPVTFile";
            this.btnLoadPVTFile.Size = new System.Drawing.Size(160, 30);
            this.btnLoadPVTFile.TabIndex = 2;
            this.btnLoadPVTFile.Text = "Load PVT File";
            this.btnLoadPVTFile.UseVisualStyleBackColor = true;
            this.btnLoadPVTFile.Click += new System.EventHandler(this.btnLoadPVTFile_Click);
            // 
            // grpViewSelection
            // 
            this.grpViewSelection.Controls.Add(this.rdoCPG);
            this.grpViewSelection.Controls.Add(this.rdoDROGDT);
            this.grpViewSelection.Controls.Add(this.rdoDROGDP);
            this.grpViewSelection.Controls.Add(this.rdoROG);
            this.grpViewSelection.Controls.Add(this.rdoPVTFile);
            this.grpViewSelection.Location = new System.Drawing.Point(807, 6);
            this.grpViewSelection.Margin = new System.Windows.Forms.Padding(4);
            this.grpViewSelection.Name = "grpViewSelection";
            this.grpViewSelection.Padding = new System.Windows.Forms.Padding(4);
            this.grpViewSelection.Size = new System.Drawing.Size(160, 185);
            this.grpViewSelection.TabIndex = 1;
            this.grpViewSelection.TabStop = false;
            this.grpViewSelection.Text = "View selection";
            // 
            // rdoCPG
            // 
            this.rdoCPG.AutoSize = true;
            this.rdoCPG.Location = new System.Drawing.Point(8, 121);
            this.rdoCPG.Margin = new System.Windows.Forms.Padding(4);
            this.rdoCPG.Name = "rdoCPG";
            this.rdoCPG.Size = new System.Drawing.Size(62, 22);
            this.rdoCPG.TabIndex = 6;
            this.rdoCPG.Text = "CPG";
            this.rdoCPG.UseVisualStyleBackColor = true;
            this.rdoCPG.CheckedChanged += new System.EventHandler(this.rdoCPG_CheckedChanged);
            // 
            // rdoDROGDT
            // 
            this.rdoDROGDT.AutoSize = true;
            this.rdoDROGDT.Location = new System.Drawing.Point(8, 89);
            this.rdoDROGDT.Margin = new System.Windows.Forms.Padding(4);
            this.rdoDROGDT.Name = "rdoDROGDT";
            this.rdoDROGDT.Size = new System.Drawing.Size(95, 22);
            this.rdoDROGDT.TabIndex = 5;
            this.rdoDROGDT.Text = "DROGDT";
            this.rdoDROGDT.UseVisualStyleBackColor = true;
            this.rdoDROGDT.CheckedChanged += new System.EventHandler(this.rdoDROGDT_CheckedChanged);
            // 
            // rdoDROGDP
            // 
            this.rdoDROGDP.AutoSize = true;
            this.rdoDROGDP.Location = new System.Drawing.Point(8, 57);
            this.rdoDROGDP.Margin = new System.Windows.Forms.Padding(4);
            this.rdoDROGDP.Name = "rdoDROGDP";
            this.rdoDROGDP.Size = new System.Drawing.Size(96, 22);
            this.rdoDROGDP.TabIndex = 4;
            this.rdoDROGDP.Text = "DROGDP";
            this.rdoDROGDP.UseVisualStyleBackColor = true;
            this.rdoDROGDP.CheckedChanged += new System.EventHandler(this.rdoDROGDP_CheckedChanged);
            // 
            // rdoROG
            // 
            this.rdoROG.AutoSize = true;
            this.rdoROG.Checked = true;
            this.rdoROG.Location = new System.Drawing.Point(8, 25);
            this.rdoROG.Margin = new System.Windows.Forms.Padding(4);
            this.rdoROG.Name = "rdoROG";
            this.rdoROG.Size = new System.Drawing.Size(64, 22);
            this.rdoROG.TabIndex = 3;
            this.rdoROG.TabStop = true;
            this.rdoROG.Text = "ROG";
            this.rdoROG.UseVisualStyleBackColor = true;
            this.rdoROG.CheckedChanged += new System.EventHandler(this.rdoROG_CheckedChanged);
            // 
            // rdoPVTFile
            // 
            this.rdoPVTFile.AutoSize = true;
            this.rdoPVTFile.Location = new System.Drawing.Point(8, 151);
            this.rdoPVTFile.Margin = new System.Windows.Forms.Padding(4);
            this.rdoPVTFile.Name = "rdoPVTFile";
            this.rdoPVTFile.Size = new System.Drawing.Size(84, 22);
            this.rdoPVTFile.TabIndex = 0;
            this.rdoPVTFile.Text = "PVT File";
            this.rdoPVTFile.UseVisualStyleBackColor = true;
            this.rdoPVTFile.CheckedChanged += new System.EventHandler(this.rdoPVTFile_CheckedChanged);
            // 
            // rtxPVT
            // 
            this.rtxPVT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtxPVT.Location = new System.Drawing.Point(13, 12);
            this.rtxPVT.Margin = new System.Windows.Forms.Padding(4);
            this.rtxPVT.MaxLength = 10000;
            this.rtxPVT.Name = "rtxPVT";
            this.rtxPVT.Size = new System.Drawing.Size(779, 658);
            this.rtxPVT.TabIndex = 0;
            this.rtxPVT.Text = "";
            this.rtxPVT.WordWrap = false;
            // 
            // tabChoke
            // 
            this.tabChoke.Controls.Add(this.lblCVLabel90);
            this.tabChoke.Controls.Add(this.lblChartTitle);
            this.tabChoke.Controls.Add(this.btnSetCustomCVValues);
            this.tabChoke.Controls.Add(this.lblCVTableOKStatus);
            this.tabChoke.Controls.Add(this.btnLoadCVDataFile);
            this.tabChoke.Controls.Add(this.lblCVLabel81);
            this.tabChoke.Controls.Add(this.lblCVLabel61);
            this.tabChoke.Controls.Add(this.lblCVLabel41);
            this.tabChoke.Controls.Add(this.lblCVLabel21);
            this.tabChoke.Controls.Add(this.lblCVLabel100);
            this.tabChoke.Controls.Add(this.txtCV_100);
            this.tabChoke.Controls.Add(this.txtCV_99);
            this.tabChoke.Controls.Add(this.txtCV_98);
            this.tabChoke.Controls.Add(this.txtCV_97);
            this.tabChoke.Controls.Add(this.txtCV_96);
            this.tabChoke.Controls.Add(this.txtCV_95);
            this.tabChoke.Controls.Add(this.txtCV_94);
            this.tabChoke.Controls.Add(this.txtCV_93);
            this.tabChoke.Controls.Add(this.txtCV_92);
            this.tabChoke.Controls.Add(this.txtCV_91);
            this.tabChoke.Controls.Add(this.txtCV_90);
            this.tabChoke.Controls.Add(this.txtCV_89);
            this.tabChoke.Controls.Add(this.txtCV_88);
            this.tabChoke.Controls.Add(this.txtCV_87);
            this.tabChoke.Controls.Add(this.txtCV_86);
            this.tabChoke.Controls.Add(this.txtCV_85);
            this.tabChoke.Controls.Add(this.txtCV_84);
            this.tabChoke.Controls.Add(this.txtCV_83);
            this.tabChoke.Controls.Add(this.txtCV_82);
            this.tabChoke.Controls.Add(this.txtCV_81);
            this.tabChoke.Controls.Add(this.txtCV_80);
            this.tabChoke.Controls.Add(this.txtCV_79);
            this.tabChoke.Controls.Add(this.txtCV_78);
            this.tabChoke.Controls.Add(this.txtCV_77);
            this.tabChoke.Controls.Add(this.txtCV_76);
            this.tabChoke.Controls.Add(this.txtCV_75);
            this.tabChoke.Controls.Add(this.txtCV_74);
            this.tabChoke.Controls.Add(this.txtCV_73);
            this.tabChoke.Controls.Add(this.txtCV_72);
            this.tabChoke.Controls.Add(this.txtCV_71);
            this.tabChoke.Controls.Add(this.txtCV_70);
            this.tabChoke.Controls.Add(this.txtCV_69);
            this.tabChoke.Controls.Add(this.txtCV_68);
            this.tabChoke.Controls.Add(this.txtCV_67);
            this.tabChoke.Controls.Add(this.txtCV_66);
            this.tabChoke.Controls.Add(this.txtCV_65);
            this.tabChoke.Controls.Add(this.txtCV_64);
            this.tabChoke.Controls.Add(this.txtCV_63);
            this.tabChoke.Controls.Add(this.txtCV_62);
            this.tabChoke.Controls.Add(this.txtCV_61);
            this.tabChoke.Controls.Add(this.txtCV_60);
            this.tabChoke.Controls.Add(this.txtCV_59);
            this.tabChoke.Controls.Add(this.txtCV_58);
            this.tabChoke.Controls.Add(this.txtCV_57);
            this.tabChoke.Controls.Add(this.txtCV_56);
            this.tabChoke.Controls.Add(this.txtCV_55);
            this.tabChoke.Controls.Add(this.txtCV_54);
            this.tabChoke.Controls.Add(this.txtCV_53);
            this.tabChoke.Controls.Add(this.txtCV_52);
            this.tabChoke.Controls.Add(this.txtCV_51);
            this.tabChoke.Controls.Add(this.txtCV_50);
            this.tabChoke.Controls.Add(this.txtCV_49);
            this.tabChoke.Controls.Add(this.txtCV_48);
            this.tabChoke.Controls.Add(this.txtCV_47);
            this.tabChoke.Controls.Add(this.txtCV_46);
            this.tabChoke.Controls.Add(this.txtCV_45);
            this.tabChoke.Controls.Add(this.txtCV_44);
            this.tabChoke.Controls.Add(this.txtCV_43);
            this.tabChoke.Controls.Add(this.txtCV_42);
            this.tabChoke.Controls.Add(this.txtCV_41);
            this.tabChoke.Controls.Add(this.txtCV_40);
            this.tabChoke.Controls.Add(this.txtCV_39);
            this.tabChoke.Controls.Add(this.txtCV_38);
            this.tabChoke.Controls.Add(this.txtCV_37);
            this.tabChoke.Controls.Add(this.txtCV_36);
            this.tabChoke.Controls.Add(this.txtCV_35);
            this.tabChoke.Controls.Add(this.txtCV_34);
            this.tabChoke.Controls.Add(this.txtCV_33);
            this.tabChoke.Controls.Add(this.txtCV_32);
            this.tabChoke.Controls.Add(this.txtCV_31);
            this.tabChoke.Controls.Add(this.txtCV_30);
            this.tabChoke.Controls.Add(this.txtCV_29);
            this.tabChoke.Controls.Add(this.txtCV_28);
            this.tabChoke.Controls.Add(this.txtCV_27);
            this.tabChoke.Controls.Add(this.txtCV_26);
            this.tabChoke.Controls.Add(this.txtCV_25);
            this.tabChoke.Controls.Add(this.txtCV_24);
            this.tabChoke.Controls.Add(this.txtCV_23);
            this.tabChoke.Controls.Add(this.txtCV_22);
            this.tabChoke.Controls.Add(this.txtCV_21);
            this.tabChoke.Controls.Add(this.lblCVLabel20);
            this.tabChoke.Controls.Add(this.lblCVLabel10);
            this.tabChoke.Controls.Add(this.txtCV_20);
            this.tabChoke.Controls.Add(this.txtCV_19);
            this.tabChoke.Controls.Add(this.txtCV_18);
            this.tabChoke.Controls.Add(this.txtCV_17);
            this.tabChoke.Controls.Add(this.txtCV_16);
            this.tabChoke.Controls.Add(this.txtCV_15);
            this.tabChoke.Controls.Add(this.txtCV_14);
            this.tabChoke.Controls.Add(this.txtCV_13);
            this.tabChoke.Controls.Add(this.txtCV_12);
            this.tabChoke.Controls.Add(this.txtCV_11);
            this.tabChoke.Controls.Add(this.txtCV_10);
            this.tabChoke.Controls.Add(this.txtCV_9);
            this.tabChoke.Controls.Add(this.txtCV_8);
            this.tabChoke.Controls.Add(this.txtCV_7);
            this.tabChoke.Controls.Add(this.txtCV_6);
            this.tabChoke.Controls.Add(this.txtCV_5);
            this.tabChoke.Controls.Add(this.txtCV_4);
            this.tabChoke.Controls.Add(this.txtCV_3);
            this.tabChoke.Controls.Add(this.txtCV_2);
            this.tabChoke.Controls.Add(this.txtCV_1);
            this.tabChoke.Controls.Add(this.lblCVLabel1);
            this.tabChoke.Controls.Add(this.chrChokeFlowCurve);
            this.tabChoke.Location = new System.Drawing.Point(4, 27);
            this.tabChoke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabChoke.Name = "tabChoke";
            this.tabChoke.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabChoke.Size = new System.Drawing.Size(981, 684);
            this.tabChoke.TabIndex = 4;
            this.tabChoke.Text = "Choke Flow Curve";
            this.tabChoke.UseVisualStyleBackColor = true;
            // 
            // lblCVLabel90
            // 
            this.lblCVLabel90.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCVLabel90.Location = new System.Drawing.Point(340, 319);
            this.lblCVLabel90.Name = "lblCVLabel90";
            this.lblCVLabel90.Size = new System.Drawing.Size(33, 18);
            this.lblCVLabel90.TabIndex = 114;
            this.lblCVLabel90.Text = "90";
            this.lblCVLabel90.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.AutoSize = true;
            this.lblChartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblChartTitle.Location = new System.Drawing.Point(508, 39);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Size = new System.Drawing.Size(296, 20);
            this.lblChartTitle.TabIndex = 113;
            this.lblChartTitle.Text = "Valve Opening characteristic - CV";
            // 
            // btnSetCustomCVValues
            // 
            this.btnSetCustomCVValues.Location = new System.Drawing.Point(400, 618);
            this.btnSetCustomCVValues.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetCustomCVValues.Name = "btnSetCustomCVValues";
            this.btnSetCustomCVValues.Size = new System.Drawing.Size(173, 30);
            this.btnSetCustomCVValues.TabIndex = 112;
            this.btnSetCustomCVValues.Text = "Set Custom Values";
            this.btnSetCustomCVValues.UseVisualStyleBackColor = true;
            this.btnSetCustomCVValues.Click += new System.EventHandler(this.btnSetCustomCVValues_Click);
            // 
            // lblCVTableOKStatus
            // 
            this.lblCVTableOKStatus.Location = new System.Drawing.Point(777, 591);
            this.lblCVTableOKStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCVTableOKStatus.Name = "lblCVTableOKStatus";
            this.lblCVTableOKStatus.Size = new System.Drawing.Size(173, 18);
            this.lblCVTableOKStatus.TabIndex = 111;
            this.lblCVTableOKStatus.Text = "Choke Table Status";
            this.lblCVTableOKStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoadCVDataFile
            // 
            this.btnLoadCVDataFile.Location = new System.Drawing.Point(777, 618);
            this.btnLoadCVDataFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadCVDataFile.Name = "btnLoadCVDataFile";
            this.btnLoadCVDataFile.Size = new System.Drawing.Size(173, 30);
            this.btnLoadCVDataFile.TabIndex = 110;
            this.btnLoadCVDataFile.Text = "Load CV Data File";
            this.btnLoadCVDataFile.UseVisualStyleBackColor = true;
            this.btnLoadCVDataFile.Click += new System.EventHandler(this.btnLoadCVDataFile_Click);
            // 
            // lblCVLabel81
            // 
            this.lblCVLabel81.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCVLabel81.Location = new System.Drawing.Point(292, 17);
            this.lblCVLabel81.Name = "lblCVLabel81";
            this.lblCVLabel81.Size = new System.Drawing.Size(40, 18);
            this.lblCVLabel81.TabIndex = 108;
            this.lblCVLabel81.Text = "81";
            this.lblCVLabel81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCVLabel61
            // 
            this.lblCVLabel61.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCVLabel61.Location = new System.Drawing.Point(231, 17);
            this.lblCVLabel61.Name = "lblCVLabel61";
            this.lblCVLabel61.Size = new System.Drawing.Size(40, 18);
            this.lblCVLabel61.TabIndex = 107;
            this.lblCVLabel61.Text = "61";
            this.lblCVLabel61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCVLabel41
            // 
            this.lblCVLabel41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCVLabel41.Location = new System.Drawing.Point(169, 17);
            this.lblCVLabel41.Name = "lblCVLabel41";
            this.lblCVLabel41.Size = new System.Drawing.Size(40, 18);
            this.lblCVLabel41.TabIndex = 106;
            this.lblCVLabel41.Text = "41";
            this.lblCVLabel41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCVLabel21
            // 
            this.lblCVLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCVLabel21.Location = new System.Drawing.Point(108, 17);
            this.lblCVLabel21.Name = "lblCVLabel21";
            this.lblCVLabel21.Size = new System.Drawing.Size(40, 18);
            this.lblCVLabel21.TabIndex = 105;
            this.lblCVLabel21.Text = "21";
            this.lblCVLabel21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCVLabel100
            // 
            this.lblCVLabel100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCVLabel100.Location = new System.Drawing.Point(340, 625);
            this.lblCVLabel100.Name = "lblCVLabel100";
            this.lblCVLabel100.Size = new System.Drawing.Size(33, 18);
            this.lblCVLabel100.TabIndex = 103;
            this.lblCVLabel100.Text = "100";
            this.lblCVLabel100.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCV_100
            // 
            this.txtCV_100.Location = new System.Drawing.Point(285, 622);
            this.txtCV_100.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_100.Name = "txtCV_100";
            this.txtCV_100.Size = new System.Drawing.Size(52, 24);
            this.txtCV_100.TabIndex = 102;
            this.txtCV_100.Text = "NaN";
            this.txtCV_100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_100.TextChanged += new System.EventHandler(this.txtCV_100_TextChanged);
            // 
            // txtCV_99
            // 
            this.txtCV_99.Location = new System.Drawing.Point(285, 591);
            this.txtCV_99.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_99.Name = "txtCV_99";
            this.txtCV_99.Size = new System.Drawing.Size(52, 24);
            this.txtCV_99.TabIndex = 101;
            this.txtCV_99.Text = "NaN";
            this.txtCV_99.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_99.TextChanged += new System.EventHandler(this.txtCV_99_TextChanged);
            // 
            // txtCV_98
            // 
            this.txtCV_98.Location = new System.Drawing.Point(285, 560);
            this.txtCV_98.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_98.Name = "txtCV_98";
            this.txtCV_98.Size = new System.Drawing.Size(52, 24);
            this.txtCV_98.TabIndex = 100;
            this.txtCV_98.Text = "NaN";
            this.txtCV_98.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_98.TextChanged += new System.EventHandler(this.txtCV_98_TextChanged);
            // 
            // txtCV_97
            // 
            this.txtCV_97.Location = new System.Drawing.Point(285, 529);
            this.txtCV_97.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_97.Name = "txtCV_97";
            this.txtCV_97.Size = new System.Drawing.Size(52, 24);
            this.txtCV_97.TabIndex = 99;
            this.txtCV_97.Text = "NaN";
            this.txtCV_97.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_97.TextChanged += new System.EventHandler(this.txtCV_97_TextChanged);
            // 
            // txtCV_96
            // 
            this.txtCV_96.Location = new System.Drawing.Point(285, 498);
            this.txtCV_96.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_96.Name = "txtCV_96";
            this.txtCV_96.Size = new System.Drawing.Size(52, 24);
            this.txtCV_96.TabIndex = 98;
            this.txtCV_96.Text = "NaN";
            this.txtCV_96.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_96.TextChanged += new System.EventHandler(this.txtCV_96_TextChanged);
            // 
            // txtCV_95
            // 
            this.txtCV_95.Location = new System.Drawing.Point(285, 468);
            this.txtCV_95.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_95.Name = "txtCV_95";
            this.txtCV_95.Size = new System.Drawing.Size(52, 24);
            this.txtCV_95.TabIndex = 97;
            this.txtCV_95.Text = "NaN";
            this.txtCV_95.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_95.TextChanged += new System.EventHandler(this.txtCV_95_TextChanged);
            // 
            // txtCV_94
            // 
            this.txtCV_94.Location = new System.Drawing.Point(285, 437);
            this.txtCV_94.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_94.Name = "txtCV_94";
            this.txtCV_94.Size = new System.Drawing.Size(52, 24);
            this.txtCV_94.TabIndex = 96;
            this.txtCV_94.Text = "NaN";
            this.txtCV_94.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_94.TextChanged += new System.EventHandler(this.txtCV_94_TextChanged);
            // 
            // txtCV_93
            // 
            this.txtCV_93.Location = new System.Drawing.Point(285, 406);
            this.txtCV_93.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_93.Name = "txtCV_93";
            this.txtCV_93.Size = new System.Drawing.Size(52, 24);
            this.txtCV_93.TabIndex = 95;
            this.txtCV_93.Text = "NaN";
            this.txtCV_93.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_93.TextChanged += new System.EventHandler(this.txtCV_93_TextChanged);
            // 
            // txtCV_92
            // 
            this.txtCV_92.Location = new System.Drawing.Point(285, 375);
            this.txtCV_92.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_92.Name = "txtCV_92";
            this.txtCV_92.Size = new System.Drawing.Size(52, 24);
            this.txtCV_92.TabIndex = 94;
            this.txtCV_92.Text = "NaN";
            this.txtCV_92.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_92.TextChanged += new System.EventHandler(this.txtCV_92_TextChanged);
            // 
            // txtCV_91
            // 
            this.txtCV_91.Location = new System.Drawing.Point(285, 345);
            this.txtCV_91.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_91.Name = "txtCV_91";
            this.txtCV_91.Size = new System.Drawing.Size(52, 24);
            this.txtCV_91.TabIndex = 93;
            this.txtCV_91.Text = "NaN";
            this.txtCV_91.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_91.TextChanged += new System.EventHandler(this.txtCV_91_TextChanged);
            // 
            // txtCV_90
            // 
            this.txtCV_90.Location = new System.Drawing.Point(285, 314);
            this.txtCV_90.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_90.Name = "txtCV_90";
            this.txtCV_90.Size = new System.Drawing.Size(52, 24);
            this.txtCV_90.TabIndex = 92;
            this.txtCV_90.Text = "NaN";
            this.txtCV_90.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_90.TextChanged += new System.EventHandler(this.txtCV_90_TextChanged);
            // 
            // txtCV_89
            // 
            this.txtCV_89.Location = new System.Drawing.Point(285, 283);
            this.txtCV_89.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_89.Name = "txtCV_89";
            this.txtCV_89.Size = new System.Drawing.Size(52, 24);
            this.txtCV_89.TabIndex = 91;
            this.txtCV_89.Text = "NaN";
            this.txtCV_89.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_89.TextChanged += new System.EventHandler(this.txtCV_89_TextChanged);
            // 
            // txtCV_88
            // 
            this.txtCV_88.Location = new System.Drawing.Point(285, 252);
            this.txtCV_88.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_88.Name = "txtCV_88";
            this.txtCV_88.Size = new System.Drawing.Size(52, 24);
            this.txtCV_88.TabIndex = 90;
            this.txtCV_88.Text = "NaN";
            this.txtCV_88.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_88.TextChanged += new System.EventHandler(this.txtCV_88_TextChanged);
            // 
            // txtCV_87
            // 
            this.txtCV_87.Location = new System.Drawing.Point(285, 222);
            this.txtCV_87.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_87.Name = "txtCV_87";
            this.txtCV_87.Size = new System.Drawing.Size(52, 24);
            this.txtCV_87.TabIndex = 89;
            this.txtCV_87.Text = "NaN";
            this.txtCV_87.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_87.TextChanged += new System.EventHandler(this.txtCV_87_TextChanged);
            // 
            // txtCV_86
            // 
            this.txtCV_86.Location = new System.Drawing.Point(285, 191);
            this.txtCV_86.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_86.Name = "txtCV_86";
            this.txtCV_86.Size = new System.Drawing.Size(52, 24);
            this.txtCV_86.TabIndex = 88;
            this.txtCV_86.Text = "NaN";
            this.txtCV_86.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_86.TextChanged += new System.EventHandler(this.txtCV_86_TextChanged);
            // 
            // txtCV_85
            // 
            this.txtCV_85.Location = new System.Drawing.Point(285, 160);
            this.txtCV_85.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_85.Name = "txtCV_85";
            this.txtCV_85.Size = new System.Drawing.Size(52, 24);
            this.txtCV_85.TabIndex = 87;
            this.txtCV_85.Text = "NaN";
            this.txtCV_85.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_85.TextChanged += new System.EventHandler(this.txtCV_85_TextChanged);
            // 
            // txtCV_84
            // 
            this.txtCV_84.Location = new System.Drawing.Point(285, 129);
            this.txtCV_84.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_84.Name = "txtCV_84";
            this.txtCV_84.Size = new System.Drawing.Size(52, 24);
            this.txtCV_84.TabIndex = 86;
            this.txtCV_84.Text = "NaN";
            this.txtCV_84.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_84.TextChanged += new System.EventHandler(this.txtCV_84_TextChanged);
            // 
            // txtCV_83
            // 
            this.txtCV_83.Location = new System.Drawing.Point(285, 98);
            this.txtCV_83.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_83.Name = "txtCV_83";
            this.txtCV_83.Size = new System.Drawing.Size(52, 24);
            this.txtCV_83.TabIndex = 85;
            this.txtCV_83.Text = "NaN";
            this.txtCV_83.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_83.TextChanged += new System.EventHandler(this.txtCV_83_TextChanged);
            // 
            // txtCV_82
            // 
            this.txtCV_82.Location = new System.Drawing.Point(285, 68);
            this.txtCV_82.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_82.Name = "txtCV_82";
            this.txtCV_82.Size = new System.Drawing.Size(52, 24);
            this.txtCV_82.TabIndex = 84;
            this.txtCV_82.Text = "NaN";
            this.txtCV_82.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_82.TextChanged += new System.EventHandler(this.txtCV_82_TextChanged);
            // 
            // txtCV_81
            // 
            this.txtCV_81.Location = new System.Drawing.Point(285, 37);
            this.txtCV_81.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_81.Name = "txtCV_81";
            this.txtCV_81.Size = new System.Drawing.Size(52, 24);
            this.txtCV_81.TabIndex = 83;
            this.txtCV_81.Text = "NaN";
            this.txtCV_81.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_81.TextChanged += new System.EventHandler(this.txtCV_81_TextChanged);
            // 
            // txtCV_80
            // 
            this.txtCV_80.Location = new System.Drawing.Point(224, 622);
            this.txtCV_80.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_80.Name = "txtCV_80";
            this.txtCV_80.Size = new System.Drawing.Size(52, 24);
            this.txtCV_80.TabIndex = 82;
            this.txtCV_80.Text = "NaN";
            this.txtCV_80.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_80.TextChanged += new System.EventHandler(this.txtCV_80_TextChanged);
            // 
            // txtCV_79
            // 
            this.txtCV_79.Location = new System.Drawing.Point(224, 591);
            this.txtCV_79.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_79.Name = "txtCV_79";
            this.txtCV_79.Size = new System.Drawing.Size(52, 24);
            this.txtCV_79.TabIndex = 81;
            this.txtCV_79.Text = "NaN";
            this.txtCV_79.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_79.TextChanged += new System.EventHandler(this.txtCV_79_TextChanged);
            // 
            // txtCV_78
            // 
            this.txtCV_78.Location = new System.Drawing.Point(224, 560);
            this.txtCV_78.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_78.Name = "txtCV_78";
            this.txtCV_78.Size = new System.Drawing.Size(52, 24);
            this.txtCV_78.TabIndex = 80;
            this.txtCV_78.Text = "NaN";
            this.txtCV_78.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_78.TextChanged += new System.EventHandler(this.txtCV_78_TextChanged);
            // 
            // txtCV_77
            // 
            this.txtCV_77.Location = new System.Drawing.Point(224, 529);
            this.txtCV_77.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_77.Name = "txtCV_77";
            this.txtCV_77.Size = new System.Drawing.Size(52, 24);
            this.txtCV_77.TabIndex = 79;
            this.txtCV_77.Text = "NaN";
            this.txtCV_77.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_77.TextChanged += new System.EventHandler(this.txtCV_77_TextChanged);
            // 
            // txtCV_76
            // 
            this.txtCV_76.Location = new System.Drawing.Point(224, 498);
            this.txtCV_76.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_76.Name = "txtCV_76";
            this.txtCV_76.Size = new System.Drawing.Size(52, 24);
            this.txtCV_76.TabIndex = 78;
            this.txtCV_76.Text = "NaN";
            this.txtCV_76.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_76.TextChanged += new System.EventHandler(this.txtCV_76_TextChanged);
            // 
            // txtCV_75
            // 
            this.txtCV_75.Location = new System.Drawing.Point(224, 468);
            this.txtCV_75.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_75.Name = "txtCV_75";
            this.txtCV_75.Size = new System.Drawing.Size(52, 24);
            this.txtCV_75.TabIndex = 77;
            this.txtCV_75.Text = "NaN";
            this.txtCV_75.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_75.TextChanged += new System.EventHandler(this.txtCV_75_TextChanged);
            // 
            // txtCV_74
            // 
            this.txtCV_74.Location = new System.Drawing.Point(224, 437);
            this.txtCV_74.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_74.Name = "txtCV_74";
            this.txtCV_74.Size = new System.Drawing.Size(52, 24);
            this.txtCV_74.TabIndex = 76;
            this.txtCV_74.Text = "NaN";
            this.txtCV_74.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_74.TextChanged += new System.EventHandler(this.txtCV_74_TextChanged);
            // 
            // txtCV_73
            // 
            this.txtCV_73.Location = new System.Drawing.Point(224, 406);
            this.txtCV_73.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_73.Name = "txtCV_73";
            this.txtCV_73.Size = new System.Drawing.Size(52, 24);
            this.txtCV_73.TabIndex = 75;
            this.txtCV_73.Text = "NaN";
            this.txtCV_73.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_73.TextChanged += new System.EventHandler(this.txtCV_73_TextChanged);
            // 
            // txtCV_72
            // 
            this.txtCV_72.Location = new System.Drawing.Point(224, 375);
            this.txtCV_72.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_72.Name = "txtCV_72";
            this.txtCV_72.Size = new System.Drawing.Size(52, 24);
            this.txtCV_72.TabIndex = 74;
            this.txtCV_72.Text = "NaN";
            this.txtCV_72.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_72.TextChanged += new System.EventHandler(this.txtCV_72_TextChanged);
            // 
            // txtCV_71
            // 
            this.txtCV_71.Location = new System.Drawing.Point(224, 345);
            this.txtCV_71.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_71.Name = "txtCV_71";
            this.txtCV_71.Size = new System.Drawing.Size(52, 24);
            this.txtCV_71.TabIndex = 73;
            this.txtCV_71.Text = "NaN";
            this.txtCV_71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_71.TextChanged += new System.EventHandler(this.txtCV_71_TextChanged);
            // 
            // txtCV_70
            // 
            this.txtCV_70.Location = new System.Drawing.Point(224, 314);
            this.txtCV_70.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_70.Name = "txtCV_70";
            this.txtCV_70.Size = new System.Drawing.Size(52, 24);
            this.txtCV_70.TabIndex = 72;
            this.txtCV_70.Text = "NaN";
            this.txtCV_70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_70.TextChanged += new System.EventHandler(this.txtCV_70_TextChanged);
            // 
            // txtCV_69
            // 
            this.txtCV_69.Location = new System.Drawing.Point(224, 283);
            this.txtCV_69.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_69.Name = "txtCV_69";
            this.txtCV_69.Size = new System.Drawing.Size(52, 24);
            this.txtCV_69.TabIndex = 71;
            this.txtCV_69.Text = "NaN";
            this.txtCV_69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_69.TextChanged += new System.EventHandler(this.txtCV_69_TextChanged);
            // 
            // txtCV_68
            // 
            this.txtCV_68.Location = new System.Drawing.Point(224, 252);
            this.txtCV_68.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_68.Name = "txtCV_68";
            this.txtCV_68.Size = new System.Drawing.Size(52, 24);
            this.txtCV_68.TabIndex = 70;
            this.txtCV_68.Text = "NaN";
            this.txtCV_68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_68.TextChanged += new System.EventHandler(this.txtCV_68_TextChanged);
            // 
            // txtCV_67
            // 
            this.txtCV_67.Location = new System.Drawing.Point(224, 222);
            this.txtCV_67.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_67.Name = "txtCV_67";
            this.txtCV_67.Size = new System.Drawing.Size(52, 24);
            this.txtCV_67.TabIndex = 69;
            this.txtCV_67.Text = "NaN";
            this.txtCV_67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_67.TextChanged += new System.EventHandler(this.txtCV_67_TextChanged);
            // 
            // txtCV_66
            // 
            this.txtCV_66.Location = new System.Drawing.Point(224, 191);
            this.txtCV_66.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_66.Name = "txtCV_66";
            this.txtCV_66.Size = new System.Drawing.Size(52, 24);
            this.txtCV_66.TabIndex = 68;
            this.txtCV_66.Text = "NaN";
            this.txtCV_66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_66.TextChanged += new System.EventHandler(this.txtCV_66_TextChanged);
            // 
            // txtCV_65
            // 
            this.txtCV_65.Location = new System.Drawing.Point(224, 160);
            this.txtCV_65.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_65.Name = "txtCV_65";
            this.txtCV_65.Size = new System.Drawing.Size(52, 24);
            this.txtCV_65.TabIndex = 67;
            this.txtCV_65.Text = "NaN";
            this.txtCV_65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_65.TextChanged += new System.EventHandler(this.txtCV_65_TextChanged);
            // 
            // txtCV_64
            // 
            this.txtCV_64.Location = new System.Drawing.Point(224, 129);
            this.txtCV_64.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_64.Name = "txtCV_64";
            this.txtCV_64.Size = new System.Drawing.Size(52, 24);
            this.txtCV_64.TabIndex = 66;
            this.txtCV_64.Text = "NaN";
            this.txtCV_64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_64.TextChanged += new System.EventHandler(this.txtCV_64_TextChanged);
            // 
            // txtCV_63
            // 
            this.txtCV_63.Location = new System.Drawing.Point(224, 98);
            this.txtCV_63.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_63.Name = "txtCV_63";
            this.txtCV_63.Size = new System.Drawing.Size(52, 24);
            this.txtCV_63.TabIndex = 65;
            this.txtCV_63.Text = "NaN";
            this.txtCV_63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_63.TextChanged += new System.EventHandler(this.txtCV_63_TextChanged);
            // 
            // txtCV_62
            // 
            this.txtCV_62.Location = new System.Drawing.Point(224, 68);
            this.txtCV_62.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_62.Name = "txtCV_62";
            this.txtCV_62.Size = new System.Drawing.Size(52, 24);
            this.txtCV_62.TabIndex = 64;
            this.txtCV_62.Text = "NaN";
            this.txtCV_62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_62.TextChanged += new System.EventHandler(this.txtCV_62_TextChanged);
            // 
            // txtCV_61
            // 
            this.txtCV_61.Location = new System.Drawing.Point(224, 37);
            this.txtCV_61.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_61.Name = "txtCV_61";
            this.txtCV_61.Size = new System.Drawing.Size(52, 24);
            this.txtCV_61.TabIndex = 63;
            this.txtCV_61.Text = "NaN";
            this.txtCV_61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_61.TextChanged += new System.EventHandler(this.txtCV_61_TextChanged);
            // 
            // txtCV_60
            // 
            this.txtCV_60.Location = new System.Drawing.Point(163, 622);
            this.txtCV_60.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_60.Name = "txtCV_60";
            this.txtCV_60.Size = new System.Drawing.Size(52, 24);
            this.txtCV_60.TabIndex = 62;
            this.txtCV_60.Text = "NaN";
            this.txtCV_60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_60.TextChanged += new System.EventHandler(this.txtCV_60_TextChanged);
            // 
            // txtCV_59
            // 
            this.txtCV_59.Location = new System.Drawing.Point(163, 591);
            this.txtCV_59.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_59.Name = "txtCV_59";
            this.txtCV_59.Size = new System.Drawing.Size(52, 24);
            this.txtCV_59.TabIndex = 61;
            this.txtCV_59.Text = "NaN";
            this.txtCV_59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_59.TextChanged += new System.EventHandler(this.txtCV_59_TextChanged);
            // 
            // txtCV_58
            // 
            this.txtCV_58.Location = new System.Drawing.Point(163, 560);
            this.txtCV_58.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_58.Name = "txtCV_58";
            this.txtCV_58.Size = new System.Drawing.Size(52, 24);
            this.txtCV_58.TabIndex = 60;
            this.txtCV_58.Text = "NaN";
            this.txtCV_58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_58.TextChanged += new System.EventHandler(this.txtCV_58_TextChanged);
            // 
            // txtCV_57
            // 
            this.txtCV_57.Location = new System.Drawing.Point(163, 529);
            this.txtCV_57.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_57.Name = "txtCV_57";
            this.txtCV_57.Size = new System.Drawing.Size(52, 24);
            this.txtCV_57.TabIndex = 59;
            this.txtCV_57.Text = "NaN";
            this.txtCV_57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_57.TextChanged += new System.EventHandler(this.txtCV_57_TextChanged);
            // 
            // txtCV_56
            // 
            this.txtCV_56.Location = new System.Drawing.Point(163, 498);
            this.txtCV_56.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_56.Name = "txtCV_56";
            this.txtCV_56.Size = new System.Drawing.Size(52, 24);
            this.txtCV_56.TabIndex = 58;
            this.txtCV_56.Text = "NaN";
            this.txtCV_56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_56.TextChanged += new System.EventHandler(this.txtCV_56_TextChanged);
            // 
            // txtCV_55
            // 
            this.txtCV_55.Location = new System.Drawing.Point(163, 468);
            this.txtCV_55.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_55.Name = "txtCV_55";
            this.txtCV_55.Size = new System.Drawing.Size(52, 24);
            this.txtCV_55.TabIndex = 57;
            this.txtCV_55.Text = "NaN";
            this.txtCV_55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_55.TextChanged += new System.EventHandler(this.txtCV_55_TextChanged);
            // 
            // txtCV_54
            // 
            this.txtCV_54.Location = new System.Drawing.Point(163, 437);
            this.txtCV_54.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_54.Name = "txtCV_54";
            this.txtCV_54.Size = new System.Drawing.Size(52, 24);
            this.txtCV_54.TabIndex = 56;
            this.txtCV_54.Text = "NaN";
            this.txtCV_54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_54.TextChanged += new System.EventHandler(this.txtCV_54_TextChanged);
            // 
            // txtCV_53
            // 
            this.txtCV_53.Location = new System.Drawing.Point(163, 406);
            this.txtCV_53.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_53.Name = "txtCV_53";
            this.txtCV_53.Size = new System.Drawing.Size(52, 24);
            this.txtCV_53.TabIndex = 55;
            this.txtCV_53.Text = "NaN";
            this.txtCV_53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_53.TextChanged += new System.EventHandler(this.txtCV_53_TextChanged);
            // 
            // txtCV_52
            // 
            this.txtCV_52.Location = new System.Drawing.Point(163, 375);
            this.txtCV_52.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_52.Name = "txtCV_52";
            this.txtCV_52.Size = new System.Drawing.Size(52, 24);
            this.txtCV_52.TabIndex = 54;
            this.txtCV_52.Text = "NaN";
            this.txtCV_52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_52.TextChanged += new System.EventHandler(this.txtCV_52_TextChanged);
            // 
            // txtCV_51
            // 
            this.txtCV_51.Location = new System.Drawing.Point(163, 345);
            this.txtCV_51.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_51.Name = "txtCV_51";
            this.txtCV_51.Size = new System.Drawing.Size(52, 24);
            this.txtCV_51.TabIndex = 53;
            this.txtCV_51.Text = "NaN";
            this.txtCV_51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_51.TextChanged += new System.EventHandler(this.txtCV_51_TextChanged);
            // 
            // txtCV_50
            // 
            this.txtCV_50.Location = new System.Drawing.Point(163, 314);
            this.txtCV_50.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_50.Name = "txtCV_50";
            this.txtCV_50.Size = new System.Drawing.Size(52, 24);
            this.txtCV_50.TabIndex = 52;
            this.txtCV_50.Text = "NaN";
            this.txtCV_50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_50.TextChanged += new System.EventHandler(this.txtCV_50_TextChanged);
            // 
            // txtCV_49
            // 
            this.txtCV_49.Location = new System.Drawing.Point(163, 283);
            this.txtCV_49.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_49.Name = "txtCV_49";
            this.txtCV_49.Size = new System.Drawing.Size(52, 24);
            this.txtCV_49.TabIndex = 51;
            this.txtCV_49.Text = "NaN";
            this.txtCV_49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_49.TextChanged += new System.EventHandler(this.txtCV_49_TextChanged);
            // 
            // txtCV_48
            // 
            this.txtCV_48.Location = new System.Drawing.Point(163, 252);
            this.txtCV_48.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_48.Name = "txtCV_48";
            this.txtCV_48.Size = new System.Drawing.Size(52, 24);
            this.txtCV_48.TabIndex = 50;
            this.txtCV_48.Text = "NaN";
            this.txtCV_48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_48.TextChanged += new System.EventHandler(this.txtCV_48_TextChanged);
            // 
            // txtCV_47
            // 
            this.txtCV_47.Location = new System.Drawing.Point(163, 222);
            this.txtCV_47.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_47.Name = "txtCV_47";
            this.txtCV_47.Size = new System.Drawing.Size(52, 24);
            this.txtCV_47.TabIndex = 49;
            this.txtCV_47.Text = "NaN";
            this.txtCV_47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_47.TextChanged += new System.EventHandler(this.txtCV_47_TextChanged);
            // 
            // txtCV_46
            // 
            this.txtCV_46.Location = new System.Drawing.Point(163, 191);
            this.txtCV_46.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_46.Name = "txtCV_46";
            this.txtCV_46.Size = new System.Drawing.Size(52, 24);
            this.txtCV_46.TabIndex = 48;
            this.txtCV_46.Text = "NaN";
            this.txtCV_46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_46.TextChanged += new System.EventHandler(this.txtCV_46_TextChanged);
            // 
            // txtCV_45
            // 
            this.txtCV_45.Location = new System.Drawing.Point(163, 160);
            this.txtCV_45.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_45.Name = "txtCV_45";
            this.txtCV_45.Size = new System.Drawing.Size(52, 24);
            this.txtCV_45.TabIndex = 47;
            this.txtCV_45.Text = "NaN";
            this.txtCV_45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_45.TextChanged += new System.EventHandler(this.txtCV_45_TextChanged);
            // 
            // txtCV_44
            // 
            this.txtCV_44.Location = new System.Drawing.Point(163, 129);
            this.txtCV_44.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_44.Name = "txtCV_44";
            this.txtCV_44.Size = new System.Drawing.Size(52, 24);
            this.txtCV_44.TabIndex = 46;
            this.txtCV_44.Text = "NaN";
            this.txtCV_44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_44.TextChanged += new System.EventHandler(this.txtCV_44_TextChanged);
            // 
            // txtCV_43
            // 
            this.txtCV_43.Location = new System.Drawing.Point(163, 98);
            this.txtCV_43.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_43.Name = "txtCV_43";
            this.txtCV_43.Size = new System.Drawing.Size(52, 24);
            this.txtCV_43.TabIndex = 45;
            this.txtCV_43.Text = "NaN";
            this.txtCV_43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_43.TextChanged += new System.EventHandler(this.txtCV_43_TextChanged);
            // 
            // txtCV_42
            // 
            this.txtCV_42.Location = new System.Drawing.Point(163, 68);
            this.txtCV_42.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_42.Name = "txtCV_42";
            this.txtCV_42.Size = new System.Drawing.Size(52, 24);
            this.txtCV_42.TabIndex = 44;
            this.txtCV_42.Text = "NaN";
            this.txtCV_42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_42.TextChanged += new System.EventHandler(this.txtCV_42_TextChanged);
            // 
            // txtCV_41
            // 
            this.txtCV_41.Location = new System.Drawing.Point(163, 37);
            this.txtCV_41.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_41.Name = "txtCV_41";
            this.txtCV_41.Size = new System.Drawing.Size(52, 24);
            this.txtCV_41.TabIndex = 43;
            this.txtCV_41.Text = "NaN";
            this.txtCV_41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_41.TextChanged += new System.EventHandler(this.txtCV_41_TextChanged);
            // 
            // txtCV_40
            // 
            this.txtCV_40.Location = new System.Drawing.Point(101, 622);
            this.txtCV_40.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_40.Name = "txtCV_40";
            this.txtCV_40.Size = new System.Drawing.Size(52, 24);
            this.txtCV_40.TabIndex = 42;
            this.txtCV_40.Text = "NaN";
            this.txtCV_40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_40.TextChanged += new System.EventHandler(this.txtCV_40_TextChanged);
            // 
            // txtCV_39
            // 
            this.txtCV_39.Location = new System.Drawing.Point(101, 591);
            this.txtCV_39.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_39.Name = "txtCV_39";
            this.txtCV_39.Size = new System.Drawing.Size(52, 24);
            this.txtCV_39.TabIndex = 41;
            this.txtCV_39.Text = "NaN";
            this.txtCV_39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_39.TextChanged += new System.EventHandler(this.txtCV_39_TextChanged);
            // 
            // txtCV_38
            // 
            this.txtCV_38.Location = new System.Drawing.Point(101, 560);
            this.txtCV_38.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_38.Name = "txtCV_38";
            this.txtCV_38.Size = new System.Drawing.Size(52, 24);
            this.txtCV_38.TabIndex = 40;
            this.txtCV_38.Text = "NaN";
            this.txtCV_38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_38.TextChanged += new System.EventHandler(this.txtCV_38_TextChanged);
            // 
            // txtCV_37
            // 
            this.txtCV_37.Location = new System.Drawing.Point(101, 529);
            this.txtCV_37.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_37.Name = "txtCV_37";
            this.txtCV_37.Size = new System.Drawing.Size(52, 24);
            this.txtCV_37.TabIndex = 39;
            this.txtCV_37.Text = "NaN";
            this.txtCV_37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_37.TextChanged += new System.EventHandler(this.txtCV_37_TextChanged);
            // 
            // txtCV_36
            // 
            this.txtCV_36.Location = new System.Drawing.Point(101, 498);
            this.txtCV_36.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_36.Name = "txtCV_36";
            this.txtCV_36.Size = new System.Drawing.Size(52, 24);
            this.txtCV_36.TabIndex = 38;
            this.txtCV_36.Text = "NaN";
            this.txtCV_36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_36.TextChanged += new System.EventHandler(this.txtCV_36_TextChanged);
            // 
            // txtCV_35
            // 
            this.txtCV_35.Location = new System.Drawing.Point(101, 468);
            this.txtCV_35.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_35.Name = "txtCV_35";
            this.txtCV_35.Size = new System.Drawing.Size(52, 24);
            this.txtCV_35.TabIndex = 37;
            this.txtCV_35.Text = "NaN";
            this.txtCV_35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_35.TextChanged += new System.EventHandler(this.txtCV_35_TextChanged);
            // 
            // txtCV_34
            // 
            this.txtCV_34.Location = new System.Drawing.Point(101, 437);
            this.txtCV_34.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_34.Name = "txtCV_34";
            this.txtCV_34.Size = new System.Drawing.Size(52, 24);
            this.txtCV_34.TabIndex = 36;
            this.txtCV_34.Text = "NaN";
            this.txtCV_34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_34.TextChanged += new System.EventHandler(this.txtCV_34_TextChanged);
            // 
            // txtCV_33
            // 
            this.txtCV_33.Location = new System.Drawing.Point(101, 406);
            this.txtCV_33.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_33.Name = "txtCV_33";
            this.txtCV_33.Size = new System.Drawing.Size(52, 24);
            this.txtCV_33.TabIndex = 35;
            this.txtCV_33.Text = "NaN";
            this.txtCV_33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_33.TextChanged += new System.EventHandler(this.txtCV_33_TextChanged);
            // 
            // txtCV_32
            // 
            this.txtCV_32.Location = new System.Drawing.Point(101, 375);
            this.txtCV_32.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_32.Name = "txtCV_32";
            this.txtCV_32.Size = new System.Drawing.Size(52, 24);
            this.txtCV_32.TabIndex = 34;
            this.txtCV_32.Text = "NaN";
            this.txtCV_32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_32.TextChanged += new System.EventHandler(this.txtCV_32_TextChanged);
            // 
            // txtCV_31
            // 
            this.txtCV_31.Location = new System.Drawing.Point(101, 345);
            this.txtCV_31.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_31.Name = "txtCV_31";
            this.txtCV_31.Size = new System.Drawing.Size(52, 24);
            this.txtCV_31.TabIndex = 33;
            this.txtCV_31.Text = "NaN";
            this.txtCV_31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_31.TextChanged += new System.EventHandler(this.txtCV_31_TextChanged);
            // 
            // txtCV_30
            // 
            this.txtCV_30.Location = new System.Drawing.Point(101, 314);
            this.txtCV_30.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_30.Name = "txtCV_30";
            this.txtCV_30.Size = new System.Drawing.Size(52, 24);
            this.txtCV_30.TabIndex = 32;
            this.txtCV_30.Text = "NaN";
            this.txtCV_30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_30.TextChanged += new System.EventHandler(this.txtCV_30_TextChanged);
            // 
            // txtCV_29
            // 
            this.txtCV_29.Location = new System.Drawing.Point(101, 283);
            this.txtCV_29.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_29.Name = "txtCV_29";
            this.txtCV_29.Size = new System.Drawing.Size(52, 24);
            this.txtCV_29.TabIndex = 31;
            this.txtCV_29.Text = "NaN";
            this.txtCV_29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_29.TextChanged += new System.EventHandler(this.txtCV_29_TextChanged);
            // 
            // txtCV_28
            // 
            this.txtCV_28.Location = new System.Drawing.Point(101, 252);
            this.txtCV_28.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_28.Name = "txtCV_28";
            this.txtCV_28.Size = new System.Drawing.Size(52, 24);
            this.txtCV_28.TabIndex = 30;
            this.txtCV_28.Text = "NaN";
            this.txtCV_28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_28.TextChanged += new System.EventHandler(this.txtCV_28_TextChanged);
            // 
            // txtCV_27
            // 
            this.txtCV_27.Location = new System.Drawing.Point(101, 222);
            this.txtCV_27.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_27.Name = "txtCV_27";
            this.txtCV_27.Size = new System.Drawing.Size(52, 24);
            this.txtCV_27.TabIndex = 29;
            this.txtCV_27.Text = "NaN";
            this.txtCV_27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_27.TextChanged += new System.EventHandler(this.txtCV_27_TextChanged);
            // 
            // txtCV_26
            // 
            this.txtCV_26.Location = new System.Drawing.Point(101, 191);
            this.txtCV_26.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_26.Name = "txtCV_26";
            this.txtCV_26.Size = new System.Drawing.Size(52, 24);
            this.txtCV_26.TabIndex = 28;
            this.txtCV_26.Text = "NaN";
            this.txtCV_26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_26.TextChanged += new System.EventHandler(this.txtCV_26_TextChanged);
            // 
            // txtCV_25
            // 
            this.txtCV_25.Location = new System.Drawing.Point(101, 160);
            this.txtCV_25.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_25.Name = "txtCV_25";
            this.txtCV_25.Size = new System.Drawing.Size(52, 24);
            this.txtCV_25.TabIndex = 27;
            this.txtCV_25.Text = "NaN";
            this.txtCV_25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_25.TextChanged += new System.EventHandler(this.txtCV_25_TextChanged);
            // 
            // txtCV_24
            // 
            this.txtCV_24.Location = new System.Drawing.Point(101, 129);
            this.txtCV_24.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_24.Name = "txtCV_24";
            this.txtCV_24.Size = new System.Drawing.Size(52, 24);
            this.txtCV_24.TabIndex = 26;
            this.txtCV_24.Text = "NaN";
            this.txtCV_24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_24.TextChanged += new System.EventHandler(this.txtCV_24_TextChanged);
            // 
            // txtCV_23
            // 
            this.txtCV_23.Location = new System.Drawing.Point(101, 98);
            this.txtCV_23.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_23.Name = "txtCV_23";
            this.txtCV_23.Size = new System.Drawing.Size(52, 24);
            this.txtCV_23.TabIndex = 25;
            this.txtCV_23.Text = "NaN";
            this.txtCV_23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_23.TextChanged += new System.EventHandler(this.txtCV_23_TextChanged);
            // 
            // txtCV_22
            // 
            this.txtCV_22.Location = new System.Drawing.Point(101, 68);
            this.txtCV_22.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_22.Name = "txtCV_22";
            this.txtCV_22.Size = new System.Drawing.Size(52, 24);
            this.txtCV_22.TabIndex = 24;
            this.txtCV_22.Text = "NaN";
            this.txtCV_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_22.TextChanged += new System.EventHandler(this.txtCV_22_TextChanged);
            // 
            // txtCV_21
            // 
            this.txtCV_21.Location = new System.Drawing.Point(101, 37);
            this.txtCV_21.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_21.Name = "txtCV_21";
            this.txtCV_21.Size = new System.Drawing.Size(52, 24);
            this.txtCV_21.TabIndex = 23;
            this.txtCV_21.Text = "NaN";
            this.txtCV_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_21.TextChanged += new System.EventHandler(this.txtCV_21_TextChanged);
            // 
            // lblCVLabel20
            // 
            this.lblCVLabel20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCVLabel20.Location = new System.Drawing.Point(3, 625);
            this.lblCVLabel20.Name = "lblCVLabel20";
            this.lblCVLabel20.Size = new System.Drawing.Size(33, 18);
            this.lblCVLabel20.TabIndex = 22;
            this.lblCVLabel20.Text = "20";
            this.lblCVLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCVLabel10
            // 
            this.lblCVLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCVLabel10.Location = new System.Drawing.Point(3, 319);
            this.lblCVLabel10.Name = "lblCVLabel10";
            this.lblCVLabel10.Size = new System.Drawing.Size(33, 18);
            this.lblCVLabel10.TabIndex = 21;
            this.lblCVLabel10.Text = "10";
            this.lblCVLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCV_20
            // 
            this.txtCV_20.Location = new System.Drawing.Point(40, 622);
            this.txtCV_20.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_20.Name = "txtCV_20";
            this.txtCV_20.Size = new System.Drawing.Size(52, 24);
            this.txtCV_20.TabIndex = 20;
            this.txtCV_20.Text = "NaN";
            this.txtCV_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_20.TextChanged += new System.EventHandler(this.txtCV_20_TextChanged);
            // 
            // txtCV_19
            // 
            this.txtCV_19.Location = new System.Drawing.Point(40, 591);
            this.txtCV_19.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_19.Name = "txtCV_19";
            this.txtCV_19.Size = new System.Drawing.Size(52, 24);
            this.txtCV_19.TabIndex = 19;
            this.txtCV_19.Text = "NaN";
            this.txtCV_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_19.TextChanged += new System.EventHandler(this.txtCV_19_TextChanged);
            // 
            // txtCV_18
            // 
            this.txtCV_18.Location = new System.Drawing.Point(40, 560);
            this.txtCV_18.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_18.Name = "txtCV_18";
            this.txtCV_18.Size = new System.Drawing.Size(52, 24);
            this.txtCV_18.TabIndex = 18;
            this.txtCV_18.Text = "NaN";
            this.txtCV_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_18.TextChanged += new System.EventHandler(this.txtCV_18_TextChanged);
            // 
            // txtCV_17
            // 
            this.txtCV_17.Location = new System.Drawing.Point(40, 529);
            this.txtCV_17.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_17.Name = "txtCV_17";
            this.txtCV_17.Size = new System.Drawing.Size(52, 24);
            this.txtCV_17.TabIndex = 17;
            this.txtCV_17.Text = "NaN";
            this.txtCV_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_17.TextChanged += new System.EventHandler(this.txtCV_17_TextChanged);
            // 
            // txtCV_16
            // 
            this.txtCV_16.Location = new System.Drawing.Point(40, 498);
            this.txtCV_16.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_16.Name = "txtCV_16";
            this.txtCV_16.Size = new System.Drawing.Size(52, 24);
            this.txtCV_16.TabIndex = 16;
            this.txtCV_16.Text = "NaN";
            this.txtCV_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_16.TextChanged += new System.EventHandler(this.txtCV_16_TextChanged);
            // 
            // txtCV_15
            // 
            this.txtCV_15.Location = new System.Drawing.Point(40, 468);
            this.txtCV_15.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_15.Name = "txtCV_15";
            this.txtCV_15.Size = new System.Drawing.Size(52, 24);
            this.txtCV_15.TabIndex = 15;
            this.txtCV_15.Text = "NaN";
            this.txtCV_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_15.TextChanged += new System.EventHandler(this.txtCV_15_TextChanged);
            // 
            // txtCV_14
            // 
            this.txtCV_14.Location = new System.Drawing.Point(40, 437);
            this.txtCV_14.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_14.Name = "txtCV_14";
            this.txtCV_14.Size = new System.Drawing.Size(52, 24);
            this.txtCV_14.TabIndex = 14;
            this.txtCV_14.Text = "NaN";
            this.txtCV_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_14.TextChanged += new System.EventHandler(this.txtCV_14_TextChanged);
            // 
            // txtCV_13
            // 
            this.txtCV_13.Location = new System.Drawing.Point(40, 406);
            this.txtCV_13.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_13.Name = "txtCV_13";
            this.txtCV_13.Size = new System.Drawing.Size(52, 24);
            this.txtCV_13.TabIndex = 13;
            this.txtCV_13.Text = "NaN";
            this.txtCV_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_13.TextChanged += new System.EventHandler(this.txtCV_13_TextChanged);
            // 
            // txtCV_12
            // 
            this.txtCV_12.Location = new System.Drawing.Point(40, 375);
            this.txtCV_12.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_12.Name = "txtCV_12";
            this.txtCV_12.Size = new System.Drawing.Size(52, 24);
            this.txtCV_12.TabIndex = 12;
            this.txtCV_12.Text = "NaN";
            this.txtCV_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_12.TextChanged += new System.EventHandler(this.txtCV_12_TextChanged);
            // 
            // txtCV_11
            // 
            this.txtCV_11.Location = new System.Drawing.Point(40, 345);
            this.txtCV_11.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_11.Name = "txtCV_11";
            this.txtCV_11.Size = new System.Drawing.Size(52, 24);
            this.txtCV_11.TabIndex = 11;
            this.txtCV_11.Text = "NaN";
            this.txtCV_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_11.TextChanged += new System.EventHandler(this.txtCV_11_TextChanged);
            // 
            // txtCV_10
            // 
            this.txtCV_10.Location = new System.Drawing.Point(40, 314);
            this.txtCV_10.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_10.Name = "txtCV_10";
            this.txtCV_10.Size = new System.Drawing.Size(52, 24);
            this.txtCV_10.TabIndex = 10;
            this.txtCV_10.Text = "NaN";
            this.txtCV_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_10.TextChanged += new System.EventHandler(this.txtCV_10_TextChanged);
            // 
            // txtCV_9
            // 
            this.txtCV_9.Location = new System.Drawing.Point(40, 283);
            this.txtCV_9.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_9.Name = "txtCV_9";
            this.txtCV_9.Size = new System.Drawing.Size(52, 24);
            this.txtCV_9.TabIndex = 9;
            this.txtCV_9.Text = "NaN";
            this.txtCV_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_9.TextChanged += new System.EventHandler(this.txtCV_9_TextChanged);
            // 
            // txtCV_8
            // 
            this.txtCV_8.Location = new System.Drawing.Point(40, 252);
            this.txtCV_8.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_8.Name = "txtCV_8";
            this.txtCV_8.Size = new System.Drawing.Size(52, 24);
            this.txtCV_8.TabIndex = 8;
            this.txtCV_8.Text = "NaN";
            this.txtCV_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_8.TextChanged += new System.EventHandler(this.txtCV_8_TextChanged);
            // 
            // txtCV_7
            // 
            this.txtCV_7.Location = new System.Drawing.Point(40, 222);
            this.txtCV_7.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_7.Name = "txtCV_7";
            this.txtCV_7.Size = new System.Drawing.Size(52, 24);
            this.txtCV_7.TabIndex = 7;
            this.txtCV_7.Text = "NaN";
            this.txtCV_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_7.TextChanged += new System.EventHandler(this.txtCV_7_TextChanged);
            // 
            // txtCV_6
            // 
            this.txtCV_6.Location = new System.Drawing.Point(40, 191);
            this.txtCV_6.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_6.Name = "txtCV_6";
            this.txtCV_6.Size = new System.Drawing.Size(52, 24);
            this.txtCV_6.TabIndex = 6;
            this.txtCV_6.Text = "NaN";
            this.txtCV_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_6.TextChanged += new System.EventHandler(this.txtCV_6_TextChanged);
            // 
            // txtCV_5
            // 
            this.txtCV_5.Location = new System.Drawing.Point(40, 160);
            this.txtCV_5.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_5.Name = "txtCV_5";
            this.txtCV_5.Size = new System.Drawing.Size(52, 24);
            this.txtCV_5.TabIndex = 5;
            this.txtCV_5.Text = "NaN";
            this.txtCV_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_5.TextChanged += new System.EventHandler(this.txtCV_5_TextChanged);
            // 
            // txtCV_4
            // 
            this.txtCV_4.Location = new System.Drawing.Point(40, 129);
            this.txtCV_4.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_4.Name = "txtCV_4";
            this.txtCV_4.Size = new System.Drawing.Size(52, 24);
            this.txtCV_4.TabIndex = 4;
            this.txtCV_4.Text = "NaN";
            this.txtCV_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_4.TextChanged += new System.EventHandler(this.txtCV_4_TextChanged);
            // 
            // txtCV_3
            // 
            this.txtCV_3.Location = new System.Drawing.Point(40, 98);
            this.txtCV_3.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_3.Name = "txtCV_3";
            this.txtCV_3.Size = new System.Drawing.Size(52, 24);
            this.txtCV_3.TabIndex = 3;
            this.txtCV_3.Text = "NaN";
            this.txtCV_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_3.TextChanged += new System.EventHandler(this.txtCV_3_TextChanged);
            // 
            // txtCV_2
            // 
            this.txtCV_2.Location = new System.Drawing.Point(40, 68);
            this.txtCV_2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_2.Name = "txtCV_2";
            this.txtCV_2.Size = new System.Drawing.Size(52, 24);
            this.txtCV_2.TabIndex = 2;
            this.txtCV_2.Text = "NaN";
            this.txtCV_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_2.TextChanged += new System.EventHandler(this.txtCV_2_TextChanged);
            // 
            // txtCV_1
            // 
            this.txtCV_1.Location = new System.Drawing.Point(40, 37);
            this.txtCV_1.Margin = new System.Windows.Forms.Padding(4);
            this.txtCV_1.Name = "txtCV_1";
            this.txtCV_1.Size = new System.Drawing.Size(52, 24);
            this.txtCV_1.TabIndex = 1;
            this.txtCV_1.Text = "NaN";
            this.txtCV_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCV_1.TextChanged += new System.EventHandler(this.txtCV_1_TextChanged);
            // 
            // lblCVLabel1
            // 
            this.lblCVLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCVLabel1.Location = new System.Drawing.Point(47, 17);
            this.lblCVLabel1.Name = "lblCVLabel1";
            this.lblCVLabel1.Size = new System.Drawing.Size(40, 18);
            this.lblCVLabel1.TabIndex = 0;
            this.lblCVLabel1.Text = "1";
            this.lblCVLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chrChokeFlowCurve
            // 
            this.chrChokeFlowCurve.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 9;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 8;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.Title = "Step";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 9;
            chartArea1.AxisY.LabelAutoFitMinFontSize = 8;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chrChokeFlowCurve.ChartAreas.Add(chartArea1);
            this.chrChokeFlowCurve.Location = new System.Drawing.Point(357, 69);
            this.chrChokeFlowCurve.Margin = new System.Windows.Forms.Padding(4);
            this.chrChokeFlowCurve.Name = "chrChokeFlowCurve";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.RoyalBlue;
            series1.Legend = "Legend1";
            series1.LegendText = "CV";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerSize = 4;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series1.Name = "Series1";
            this.chrChokeFlowCurve.Series.Add(series1);
            this.chrChokeFlowCurve.Size = new System.Drawing.Size(600, 517);
            this.chrChokeFlowCurve.TabIndex = 109;
            this.chrChokeFlowCurve.Text = "Choke CV";
            // 
            // mnsMainMenu
            // 
            this.mnsMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.oPCToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mnsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMainMenu.Name = "mnsMainMenu";
            this.mnsMainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnsMainMenu.Size = new System.Drawing.Size(1005, 28);
            this.mnsMainMenu.TabIndex = 1;
            this.mnsMainMenu.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDefaultConfigurationToolStripMenuItem,
            this.loadOPCIthemPathsToolStripMenuItem,
            this.loadPVTFileToolStripMenuItem,
            this.loadChokeFlowCurveFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadDefaultConfigurationToolStripMenuItem
            // 
            this.loadDefaultConfigurationToolStripMenuItem.Name = "loadDefaultConfigurationToolStripMenuItem";
            this.loadDefaultConfigurationToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.loadDefaultConfigurationToolStripMenuItem.Text = "Load default configuration";
            this.loadDefaultConfigurationToolStripMenuItem.Click += new System.EventHandler(this.loadDefaultConfigurationToolStripMenuItem_Click);
            // 
            // loadOPCIthemPathsToolStripMenuItem
            // 
            this.loadOPCIthemPathsToolStripMenuItem.Name = "loadOPCIthemPathsToolStripMenuItem";
            this.loadOPCIthemPathsToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.loadOPCIthemPathsToolStripMenuItem.Text = "Load OPC Item Paths";
            this.loadOPCIthemPathsToolStripMenuItem.Click += new System.EventHandler(this.loadOPCIthemPathsToolStripMenuItem_Click);
            // 
            // loadPVTFileToolStripMenuItem
            // 
            this.loadPVTFileToolStripMenuItem.Name = "loadPVTFileToolStripMenuItem";
            this.loadPVTFileToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.loadPVTFileToolStripMenuItem.Text = "Load PVT file";
            this.loadPVTFileToolStripMenuItem.Click += new System.EventHandler(this.loadPVTFileToolStripMenuItem_Click);
            // 
            // loadChokeFlowCurveFileToolStripMenuItem
            // 
            this.loadChokeFlowCurveFileToolStripMenuItem.Name = "loadChokeFlowCurveFileToolStripMenuItem";
            this.loadChokeFlowCurveFileToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.loadChokeFlowCurveFileToolStripMenuItem.Text = "Load Choke Flow Curve file";
            this.loadChokeFlowCurveFileToolStripMenuItem.Click += new System.EventHandler(this.loadChokeFlowCurveFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // oPCToolStripMenuItem
            // 
            this.oPCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.oPCToolStripMenuItem.Name = "oPCToolStripMenuItem";
            this.oPCToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.oPCToolStripMenuItem.Text = "OPC";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1005, 753);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.mnsMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Gas Flow Calculator";
            this.tabControl.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            this.tabOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tabCalculation.ResumeLayout(false);
            this.tabCalculation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlChokeValues.ResumeLayout(false);
            this.pnlChokeValues.PerformLayout();
            this.pnlSelecedPVTValues.ResumeLayout(false);
            this.pnlSelecedPVTValues.PerformLayout();
            this.pnlActualValues.ResumeLayout(false);
            this.pnlActualValues.PerformLayout();
            this.tabOPC.ResumeLayout(false);
            this.tabOPC.PerformLayout();
            this.tabPVT.ResumeLayout(false);
            this.grpViewSelection.ResumeLayout(false);
            this.grpViewSelection.PerformLayout();
            this.tabChoke.ResumeLayout(false);
            this.tabChoke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrChokeFlowCurve)).EndInit();
            this.mnsMainMenu.ResumeLayout(false);
            this.mnsMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.TabPage tabCalculation;
        private System.Windows.Forms.TabPage tabOPC;
        private System.Windows.Forms.TabPage tabPVT;
        private System.Windows.Forms.TabPage tabChoke;
        private System.Windows.Forms.MenuStrip mnsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDefaultConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadOPCIthemPathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPVTFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadChokeFlowCurveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListView lvwOPCItems;
        private System.Windows.Forms.ColumnHeader GFC;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader Quality;
        private System.Windows.Forms.ColumnHeader TimeStamp;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnDisconnectOPCServer;
        private System.Windows.Forms.Button btnConnectOPCServer;
        private System.Windows.Forms.Label lblActiveOPCServer;
        private System.Windows.Forms.ProgressBar prgOPCServerStatus;
        private System.Windows.Forms.Label lblActiveOPCServerLabel;
        private System.Windows.Forms.Button btnSelectOPCItemsFile;
        private System.Windows.Forms.Button btnSetOPCServerName;
        private System.Windows.Forms.Label lblNewOPCServerNameLabel;
        private System.Windows.Forms.Label lblOPCRefresh;
        private System.Windows.Forms.GroupBox grpViewSelection;
        private System.Windows.Forms.RadioButton rdoCPG;
        private System.Windows.Forms.RadioButton rdoDROGDT;
        private System.Windows.Forms.RadioButton rdoDROGDP;
        private System.Windows.Forms.RadioButton rdoROG;
        private System.Windows.Forms.RadioButton rdoPVTFile;
        private System.Windows.Forms.RichTextBox rtxPVT;
        private System.Windows.Forms.Button btnLoadPVTFile;
        private System.Windows.Forms.Label lblPVTTableOKStatus;
        private System.Windows.Forms.ComboBox cmbNewOPCServerName;
        private System.Windows.Forms.Label lblCVLabel1;
        private System.Windows.Forms.Label lblCVLabel81;
        private System.Windows.Forms.Label lblCVLabel61;
        private System.Windows.Forms.Label lblCVLabel41;
        private System.Windows.Forms.Label lblCVLabel21;
        private System.Windows.Forms.Label lblCVLabel100;
        private System.Windows.Forms.TextBox txtCV_100;
        private System.Windows.Forms.TextBox txtCV_99;
        private System.Windows.Forms.TextBox txtCV_98;
        private System.Windows.Forms.TextBox txtCV_97;
        private System.Windows.Forms.TextBox txtCV_96;
        private System.Windows.Forms.TextBox txtCV_95;
        private System.Windows.Forms.TextBox txtCV_94;
        private System.Windows.Forms.TextBox txtCV_93;
        private System.Windows.Forms.TextBox txtCV_92;
        private System.Windows.Forms.TextBox txtCV_91;
        private System.Windows.Forms.TextBox txtCV_90;
        private System.Windows.Forms.TextBox txtCV_89;
        private System.Windows.Forms.TextBox txtCV_88;
        private System.Windows.Forms.TextBox txtCV_87;
        private System.Windows.Forms.TextBox txtCV_86;
        private System.Windows.Forms.TextBox txtCV_85;
        private System.Windows.Forms.TextBox txtCV_84;
        private System.Windows.Forms.TextBox txtCV_83;
        private System.Windows.Forms.TextBox txtCV_82;
        private System.Windows.Forms.TextBox txtCV_81;
        private System.Windows.Forms.TextBox txtCV_80;
        private System.Windows.Forms.TextBox txtCV_79;
        private System.Windows.Forms.TextBox txtCV_78;
        private System.Windows.Forms.TextBox txtCV_77;
        private System.Windows.Forms.TextBox txtCV_76;
        private System.Windows.Forms.TextBox txtCV_75;
        private System.Windows.Forms.TextBox txtCV_74;
        private System.Windows.Forms.TextBox txtCV_73;
        private System.Windows.Forms.TextBox txtCV_72;
        private System.Windows.Forms.TextBox txtCV_71;
        private System.Windows.Forms.TextBox txtCV_70;
        private System.Windows.Forms.TextBox txtCV_69;
        private System.Windows.Forms.TextBox txtCV_68;
        private System.Windows.Forms.TextBox txtCV_67;
        private System.Windows.Forms.TextBox txtCV_66;
        private System.Windows.Forms.TextBox txtCV_65;
        private System.Windows.Forms.TextBox txtCV_64;
        private System.Windows.Forms.TextBox txtCV_63;
        private System.Windows.Forms.TextBox txtCV_62;
        private System.Windows.Forms.TextBox txtCV_61;
        private System.Windows.Forms.TextBox txtCV_60;
        private System.Windows.Forms.TextBox txtCV_59;
        private System.Windows.Forms.TextBox txtCV_58;
        private System.Windows.Forms.TextBox txtCV_57;
        private System.Windows.Forms.TextBox txtCV_56;
        private System.Windows.Forms.TextBox txtCV_55;
        private System.Windows.Forms.TextBox txtCV_54;
        private System.Windows.Forms.TextBox txtCV_53;
        private System.Windows.Forms.TextBox txtCV_52;
        private System.Windows.Forms.TextBox txtCV_51;
        private System.Windows.Forms.TextBox txtCV_50;
        private System.Windows.Forms.TextBox txtCV_49;
        private System.Windows.Forms.TextBox txtCV_48;
        private System.Windows.Forms.TextBox txtCV_47;
        private System.Windows.Forms.TextBox txtCV_46;
        private System.Windows.Forms.TextBox txtCV_45;
        private System.Windows.Forms.TextBox txtCV_44;
        private System.Windows.Forms.TextBox txtCV_43;
        private System.Windows.Forms.TextBox txtCV_42;
        private System.Windows.Forms.TextBox txtCV_41;
        private System.Windows.Forms.TextBox txtCV_40;
        private System.Windows.Forms.TextBox txtCV_39;
        private System.Windows.Forms.TextBox txtCV_38;
        private System.Windows.Forms.TextBox txtCV_37;
        private System.Windows.Forms.TextBox txtCV_36;
        private System.Windows.Forms.TextBox txtCV_35;
        private System.Windows.Forms.TextBox txtCV_34;
        private System.Windows.Forms.TextBox txtCV_33;
        private System.Windows.Forms.TextBox txtCV_32;
        private System.Windows.Forms.TextBox txtCV_31;
        private System.Windows.Forms.TextBox txtCV_30;
        private System.Windows.Forms.TextBox txtCV_29;
        private System.Windows.Forms.TextBox txtCV_28;
        private System.Windows.Forms.TextBox txtCV_27;
        private System.Windows.Forms.TextBox txtCV_26;
        private System.Windows.Forms.TextBox txtCV_25;
        private System.Windows.Forms.TextBox txtCV_24;
        private System.Windows.Forms.TextBox txtCV_23;
        private System.Windows.Forms.TextBox txtCV_22;
        private System.Windows.Forms.TextBox txtCV_21;
        private System.Windows.Forms.Label lblCVLabel20;
        private System.Windows.Forms.Label lblCVLabel10;
        private System.Windows.Forms.TextBox txtCV_20;
        private System.Windows.Forms.TextBox txtCV_19;
        private System.Windows.Forms.TextBox txtCV_18;
        private System.Windows.Forms.TextBox txtCV_17;
        private System.Windows.Forms.TextBox txtCV_16;
        private System.Windows.Forms.TextBox txtCV_15;
        private System.Windows.Forms.TextBox txtCV_14;
        private System.Windows.Forms.TextBox txtCV_13;
        private System.Windows.Forms.TextBox txtCV_12;
        private System.Windows.Forms.TextBox txtCV_11;
        private System.Windows.Forms.TextBox txtCV_10;
        private System.Windows.Forms.TextBox txtCV_9;
        private System.Windows.Forms.TextBox txtCV_8;
        private System.Windows.Forms.TextBox txtCV_7;
        private System.Windows.Forms.TextBox txtCV_6;
        private System.Windows.Forms.TextBox txtCV_5;
        private System.Windows.Forms.TextBox txtCV_4;
        private System.Windows.Forms.TextBox txtCV_3;
        private System.Windows.Forms.TextBox txtCV_2;
        private System.Windows.Forms.TextBox txtCV_1;
        private System.Windows.Forms.Panel pnlActualValues;
        private System.Windows.Forms.Button btnSetCustomCVValues;
        private System.Windows.Forms.Label lblCVTableOKStatus;
        private System.Windows.Forms.Button btnLoadCVDataFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrChokeFlowCurve;
        private System.Windows.Forms.Label lblTemperatureTStatus;
        private System.Windows.Forms.Label lblTemperatureTValue;
        private System.Windows.Forms.Label lblPressureP2Status;
        private System.Windows.Forms.Label lblPressureP2Value;
        private System.Windows.Forms.Label lblPressureP1Status;
        private System.Windows.Forms.Label lblPressureP1Value;
        private System.Windows.Forms.Label lblActualProcesValuesStatus;
        private System.Windows.Forms.Label lblActualProcesValuesValue;
        private System.Windows.Forms.Label lblChokeOpenStatus;
        private System.Windows.Forms.Label lblChokeOpenValue;
        private System.Windows.Forms.Label lblTemperatureTUnit;
        private System.Windows.Forms.Label lblPressureP2Unit;
        private System.Windows.Forms.Label lblPressureP1Unit;
        private System.Windows.Forms.Label lblChokeOpenUnit;
        private System.Windows.Forms.Label lblTemperatureT;
        private System.Windows.Forms.Label lblPressureP2;
        private System.Windows.Forms.Label lblPressureP1;
        private System.Windows.Forms.Label lblChokeOpen;
        private System.Windows.Forms.Label lblActualValues;
        private System.Windows.Forms.Panel pnlSelecedPVTValues;
        private System.Windows.Forms.Label lblPVTTableCPGValueStatus;
        private System.Windows.Forms.Label lblPVTTableCPGValue;
        private System.Windows.Forms.Label lblPVTTableDROGDTValueStatus;
        private System.Windows.Forms.Label lblPVTTableDROGDTValue;
        private System.Windows.Forms.Label lblPVTTableDROGDPValueStatus;
        private System.Windows.Forms.Label lblPVTTableDROGDPValue;
        private System.Windows.Forms.Label lblSelectedPVTValuesStatus;
        private System.Windows.Forms.Label lblSelectedPVTValuesValue;
        private System.Windows.Forms.Label lblPVTTableROGValueStatus;
        private System.Windows.Forms.Label lblPVTTableROGValue;
        private System.Windows.Forms.Label lblCPG;
        private System.Windows.Forms.Label lblDROGDT;
        private System.Windows.Forms.Label lblDROGDP;
        private System.Windows.Forms.Label lblROG;
        private System.Windows.Forms.Label lblSelectedPVTValues;
        private System.Windows.Forms.Panel pnlChokeValues;
        private System.Windows.Forms.Label lblSelectedChokeCVValueStatus;
        private System.Windows.Forms.Label lblSelectedChokeCVValueValue;
        private System.Windows.Forms.Label lblCVTableValueStatus;
        private System.Windows.Forms.Label lblCVTableValue;
        private System.Windows.Forms.Label lblCV;
        private System.Windows.Forms.Label lblSelectedChokeCVValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDensityMultiplierLabel;
        private System.Windows.Forms.Label lblDischargeCoefficientLabel;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblCalculationErrorCodeDescription;
        private System.Windows.Forms.Label lblCalculatedStatus;
        private System.Windows.Forms.Label lblCalculatedStatusLabel;
        private System.Windows.Forms.Label lblCalculationRunning;
        private System.Windows.Forms.Label lblCalculatedFlowValue;
        private System.Windows.Forms.Label lblCalculatedFlowLabel;
        private System.Windows.Forms.Button btnSetDensityMultiplier;
        private System.Windows.Forms.Button btnSetDischargeCoefficient;
        private System.Windows.Forms.TextBox txtDensityMultiplier;
        private System.Windows.Forms.TextBox txtDischargeCoefficient;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblBakerHughesLabel;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.Label lblGasFlowCalculator;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCalculatedFlowLabel2;
        private System.Windows.Forms.Label lblOPCConnectionOK;
        private System.Windows.Forms.Label lblOPCConnectionOKLabel;
        private System.Windows.Forms.Label lblConfigurationOK;
        private System.Windows.Forms.Label lblConfigurationOKLabel;
        private System.Windows.Forms.Label lblCalculatedFlowValue2;
        private System.Windows.Forms.Label lblCalculatedStatus2Label;
        private System.Windows.Forms.Label lblCalculatedStatus2;
        private System.Windows.Forms.Label lblAPCBName;
        private System.Windows.Forms.Label lblAPCAName;
        private System.Windows.Forms.Label lblAPCBNameLabel;
        private System.Windows.Forms.Label lblAPCANameLabel;
        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.Label lblComputerNameLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.Label lblOPCItemPathStatus;
        private System.Windows.Forms.Label lblHeartBit;
        private System.Windows.Forms.Label lblHeartBitLabel;
        private System.Windows.Forms.Label lblConnectionStatusTime;
        private System.Windows.Forms.ToolStripMenuItem oPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.Label lblReadingWritingOPCItemStatus;
        private System.Windows.Forms.ColumnHeader Error;
        private System.Windows.Forms.Label lblCVUnit;
        private System.Windows.Forms.Label lblCPGUnit;
        private System.Windows.Forms.Label lblROGUnit;
        private System.Windows.Forms.Label lblCVLabel90;
        private System.Windows.Forms.Label lblCalculationComment;
        private System.Windows.Forms.Label lblProgramCycleProgressBar;
        private System.Windows.Forms.Label lblGarbageCollectorActive;
        private System.Windows.Forms.Label lblMemoryGarbageCollectorLabel;
        private System.Windows.Forms.Label lblOPCAutoReConnectLabel;
        private System.Windows.Forms.Label lblOPCAutoConnectLabel;
        private System.Windows.Forms.Label lblMemoryGarbageCollector;
        private System.Windows.Forms.Label lblOPCAutoReConnect;
        private System.Windows.Forms.Label lblOPCAutoConnect;
        private System.Windows.Forms.Label lblConnectOPCServerComment;
    }
}

