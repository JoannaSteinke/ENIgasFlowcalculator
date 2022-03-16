//------------------------------------------------------------------------//
//                                                                        //
//               BH Poland Sp. z o.o. - Baker Hughes Company              //
//                         110/114 Aleja Krakowska                        //
//                          02-256 Warsaw, Poland                         //
//                                                                        //
//------------------------------------------------------------------------//
//------------------------------------------------------------------------//
//                                                                        //
//     Gas Flow Calculator                                                //
//                                                                        //
//     Version    : 0.6                                                   //
//     Date       : 15-Mar-2022                                           //
//                                                                        //
//     Description: I-Release, Issued for FAT                             //
//     ePIMS      : ALS-33000-04-350                                      //
//                                                                        //
//     External library: Advosol OPCSD.NET                                //
//                                                                        //                                
//------------------------------------------------------------------------//
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using OPC;
using OPCDA;
using OPCDA.NET;
using System.Threading;
using System.Windows.Forms;

namespace GFC
{
    public partial class MainForm : Form
    {
        #region Attributes - General
        //Program attributes for general purpose

        private static string swVersion = "Version: 0.6\n" +
                                          "Date: 15-Mar-2022\n" + " I-Release, issued for FAT only";

        private static string companyDetails = "BH Poland Sp. z o.o.\n" +
                                               "Baker Hughes Company\n" +
                                               "110/114 Aleja Krakowska\n" +
                                               "02-256 Warsaw, Poland";

        private static string configFile = "ConfigGFC.txt";
        private static string configFileDirectory = @"C:\ENI1506\GFC\";
        private static string configFileContent = String.Empty;
        private static string computerName;
        private static string APCAName = null;
        private static string APCBName = null;
        private bool programCycleCmd = false;
        private static int programCycleRefreshRate = 1000; //[ms]
        delegate void updateLblProgramCycleCallback();
        private static bool forceMemoryGarbageCollector = false;
        private static int garbageCollectorCounter = 0;
        private static int garbageCollectorCounterLimit = 3600;
        #endregion

        #region Attributes - Calculation
        //Program attributes for actual flow calculation algorithm
        private static double dischargeCoefficient = 1;
        private static double densityMultiplier = 1;
        private static string PVT_fileName = string.Empty;
        private static double[] PVT_PT = new double[100];              // Presure Upstream DPTT-2 - PT
        private static double[] PVT_TM = new double[100];              // Temperature Upstream DPTT-2 - TM
        private static double[,] PVT_ROG = new double[100, 100];       // Gas density, acquired from PVT table (function of pressure and temperature) - ROG
        private static double[,] PVT_DROGDP = new double[100, 100];    // Pressure derivative of gas density, acquired from PVT table (function of pressure and temperature) - DROGDP
        private static double[,] PVT_DROGDT = new double[100, 100];    // Temperature derivative of gas density, acquired from PVT table (function of pressure and temperature) - DROGDT
        private static double[,] PVT_CPG = new double[100, 100];       // Specific heat capacity at constant pressure, acquired from PVT table (function of pressure and temperature) - CPG
        private static string CV_fileName = string.Empty;
        private static double CV = -1;
        private static bool CVTableOK = false;
        private static bool CVTableValueOK = false;
        private static double[] chokeCurve = new double[101];
        private static double chokeOpen = -1;
        private static double pressureP1 = -1;
        private static double pressureP2 = -1;
        private static double temperatureT = -1;
        private static bool chokeOpenValueOK = false;
        private static bool pressureP1ValueOK = false;
        private static bool pressureP2ValueOK = false;
        private static bool temperatureTValueOK = false;
        private static double ROG = -1;
        private static double DROGDP = -1;
        private static double DROGDT = -1;
        private static double CPG = -1;
        private static double calculatedFlow = -1;
        private static int calculatedFlowErr = -1;
        private static int calculatedFlowOutput = -1;
        private static string calculatedFlowErrComment = "";
        private static string calculatedFlowComment = "";
        private static bool PVTTableOK = false;
        private static bool PVTTableROGValueOK = false;
        private static bool PVTTableDROGDPValueOK = false;
        private static bool PVTTableDROGDTValueOK = false;
        private static bool PVTTableCPGValueOK = false;
        private static bool configurationOK = false;
        #endregion

        #region Attributes - OPC Client
        //Program attributes for OPC Connection algorithms
        private static bool connectOPCServerCmd = false;
        private static bool firstConnectOPCServer = true;
        private static bool autoConnectOPCServer = true;
        private static int autoConnectOPCServerCounter = 0;
        private static int autoConnectOPCServerCounterLimit = 30;     //autoConnect OPC Server time
        private static bool autoReConnectOPCServer = true;
        private static int autoReConnectOPCServerCounter = 0;
        private static int autoReConnectOPCServerCounterLimit = 60;   //autoDisconnect OPC Server time
        private static bool autoReConnectOPCServerCmd = false;
        private static bool OPCServerManualDisconnected = false;
        private static bool OPCItemPathOK = false;
        private static bool OPCServerConnectionStatus = false;
        private static string OPCServerConnectionLastStatus = String.Empty;
        private static string OPCServerName = null;
        private static string OPCItemsFileContent = String.Empty;
        private static int OPCItemsRefreshRate = 10000; //[ms]        //default OPC Server refresh rate
        private static string[] GFCVariableLabels = new string[] { "Choke Opening", "P1", "P2", "T", "Calc Flow APCA", "Calc Flow APCB", "Status GFC APCA", "Status GFC APCB" };
        private static string[] OPCItemPaths = new string[8];
        private static string[] OPCItemTimeStamps = new string[8];
        private static string[] OPCItemValues = new string[8];
        private static string[] OPCItemQualities = new string[8];
        private static string[] OPCItemErrors = new string[8];
        OpcServer OPCServer = null;
        SyncIOGroup readWriteGroup;
        ItemDef[] itemData = new ItemDef[8];
        private bool pullOPCDataCmd = false;
        private bool heartBitFlag = false;
        delegate void updateMainFormOPCItemListViewCallback();
        #endregion

        #region Attributes - MainForm
        //Program attributes for HMI screens values update
        private static string lblProgramCycleProgressBarText = String.Empty;
        private static string lblGarbageCollectorActiveText = String.Empty;
        private static string lblConnectOPCServerCommentText = String.Empty;
        private static string lblConnectOPCServerCommentForeColor = String.Empty;
        private static string lblConnectionStatusText = String.Empty;
        private static string lblConnectionStatusForeColor = String.Empty;
        private static string lblConnectionStatusTimeText = String.Empty;
        private static bool btnConnectOPCServerEnabled = true;
        private static bool btnDisconnectOPCServerEnabled = false;
        private static bool connectToolStripMenuItemEnabled = true;
        private static bool disconnectToolStripMenuItemEnabled = false;
        private static bool loadDefaultConfigurationToolStripMenuItemEnabled = true;
        private static bool loadOPCIthemPathsToolStripMenuItemEnabled = true;
        private static bool loadPVTFileToolStripMenuItemEnabled = true;
        private static bool loadChokeFlowCurveFileToolStripMenuItemEnabled = true;
        private static bool cmbNewOPCServerNameEnabled = true;
        private static bool btnSetOPCServerNameEnabled = true;
        private static bool btnSelectOPCItemsFileEnabled = true;
        private static bool btnLoadPVTFileEnabled = true;
        private static bool btnSetCustomCVValuesEnabled = true;
        private static bool btnLoadCVDataFileEnabled = true;
        private static bool btnSetDischargeCoefficientEnabled = true;
        private static bool txtDischargeCoefficientEnabled = true;
        private static bool btnSetDensityMultiplierEnabled = true;
        private static bool txtDensityMultiplierEnabled = true;
        private static bool rdoPVTFileEnabled = true;
        private static bool rdoROGChecked = false;
        private static string rtxPVTText = String.Empty;
        private static int prgOPCServerStatusValue = 0;
        private static string lblOPCConnectionOKText = String.Empty;
        private static string lblOPCConnectionOKForeColor = String.Empty;
        private static string lblOPCRefreshText = String.Empty;
        private static string lblCalculationRunningText = String.Empty;
        private static string lblCalculatedFlowValueText = String.Empty;
        private static string lblCalculatedStatusText = String.Empty;
        private static string lblCalculatedStatus2Text = String.Empty;
        private static bool lblCalculatedFlowValueVisible = false;
        private static string lblCalculatedFlowValue2Text = String.Empty;
        private static bool lblCalculatedFlowValue2Visible = false;
        private static string lblCalculationCommentText = String.Empty;
        private static bool lblCalculatedStatusVisible = false;
        private static bool lblCalculatedStatusLabelVisible = false;
        private static bool lblCalculatedStatus2Visible = false;
        private static bool lblCalculatedStatus2LabelVisible = false;
        private static string lblCalculationErrorCodeDescriptionText = String.Empty;
        private static bool lblCalculationErrorCodeDescriptionVisible = false;
        private static bool lblCalculationCommentVisible = false;
        private static string lblReadingWritingOPCItemStatusText = String.Empty;
        private static string lblChokeOpenValueText = String.Empty;
        private static bool lblChokeOpenValueVisible = false;
        private static string lblChokeOpenStatusText = String.Empty;
        private static string lblChokeOpenStatusForeColor = String.Empty;
        private static bool lblChokeOpenStatusVisible = false;
        private static string lblPressureP1ValueText = String.Empty;
        private static bool lblPressureP1ValueVisible = false;
        private static string lblPressureP1StatusText = String.Empty;
        private static string lblPressureP1StatusForeColor = String.Empty;
        private static bool lblPressureP1StatusVisible = false;
        private static string lblPressureP2ValueText = String.Empty;
        private static bool lblPressureP2ValueVisible = false;
        private static string lblPressureP2StatusText = String.Empty;
        private static string lblPressureP2StatusForeColor = String.Empty;
        private static bool lblPressureP2StatusVisible = false;
        private static string lblTemperatureTValueText = String.Empty;
        private static bool lblTemperatureTValueVisible = false;
        private static string lblTemperatureTStatusText = String.Empty;
        private static string lblTemperatureTStatusForeColor = String.Empty;
        private static bool lblTemperatureTStatusVisible = false;
        private static string lblCVTableValueText = String.Empty;
        private static bool lblCVTableValueVisible = false;
        private static string lblCVTableValueStatusText = String.Empty;
        private static string lblCVTableValueStatusForeColor = String.Empty;
        private static bool lblCVTableValueStatusVisible = false;
        private static string lblPVTTableROGValueText = String.Empty;
        private static bool lblPVTTableROGValueVisible = false;
        private static string lblPVTTableDROGDPValueText = String.Empty;
        private static bool lblPVTTableDROGDPValueVisible = false;
        private static string lblPVTTableDROGDTValueText = String.Empty;
        private static bool lblPVTTableDROGDTValueVisible = false;
        private static string lblPVTTableCPGValueText = String.Empty;
        private static bool lblPVTTableCPGValueVisible = false;        
        private static string lblPVTTableROGValueStatusText = String.Empty;
        private static string lblPVTTableROGValueStatusForeColor = String.Empty;
        private static bool lblPVTTableROGValueStatusVisible = false;
        private static string lblPVTTableDROGDPValueStatusText = String.Empty;
        private static string lblPVTTableDROGDPValueStatusForeColor = String.Empty;
        private static bool lblPVTTableDROGDPValueStatusVisible = false;
        private static string lblPVTTableDROGDTValueStatusText = String.Empty;
        private static string lblPVTTableDROGDTValueStatusForeColor = String.Empty;
        private static bool lblPVTTableDROGDTValueStatusVisible = false;
        private static string lblPVTTableCPGValueStatusText = String.Empty;
        private static string lblPVTTableCPGValueStatusForeColor = String.Empty;
        private static bool lblPVTTableCPGValueStatusVisible = false;
        #endregion

        #region Class Constructor
        public MainForm()
        //The main GFC application program
        {
            InitializeComponent();
            setInitialData();
            loadDefaultConfiguration();
            memoryGarbageCollector();
            programCycleCmd = true;
            startProgramCycleThread();  //start the main program cycle
        }
        #endregion

        #region Methods - General
        private void setInitialData()
        //This method sets the initial values for program attributes (executed only once - before starting the main program cycle tread)
        {
            lblVersion.Text = swVersion;
            computerName = Environment.MachineName;
            lblComputerName.Text = computerName;
            lblConnectionStatusText = "Disconnected";
            lblConnectionStatusForeColor = "Red";
            lblConnectionStatusTimeText = "";
            lblOPCConnectionOKText = "Disconnected";
            lblOPCConnectionOKForeColor = "Red";
            txtDischargeCoefficient.Text = dischargeCoefficient.ToString();
            txtDischargeCoefficient.BackColor = Color.White;                                               
            txtDensityMultiplier.Text = densityMultiplier.ToString();
            txtDensityMultiplier.BackColor = Color.White;
            lblCalculationRunningText = "";
            lblCalculatedFlowValueText = "";
            lblCalculatedFlowValue2Text = "";
            lblCalculatedStatusVisible = false;
            lblCalculatedStatusLabelVisible = false;
            lblCalculatedStatus2Visible = false;
            lblCalculatedStatus2LabelVisible = false;
            lblCalculationErrorCodeDescriptionText = "";
            getOPCServersList(); 
            cmbNewOPCServerName.BackColor = Color.White;
            lblHeartBit.Text = "";
            lblConnectOPCServerCommentText = "";
            autoConnectOPCServerCounter = autoConnectOPCServerCounterLimit;
            autoReConnectOPCServerCounter = autoReConnectOPCServerCounterLimit;
            
        }

        private void loadDefaultConfiguration()
        //This method reads the program configuration files (executed before starting the main program cycle tread or if LoadDefaultConfiguration Command is triggered by User)
        {
            try
            {
                string fileName = configFileDirectory + configFile;
                using (StreamReader reader = new StreamReader(fileName))
                {
                    configFileContent = reader.ReadToEnd();
                }

                //AutoConnect setting, MemoryGarbageCollector, OPCServerScanRate, APCA & APCB names and PVT & CV config file paths   
                using (var reader = new StringReader(configFileContent))
                {
                    for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                    {
                        if (line.Contains("DisableAutoConnectOPCServer:"))
                            if ((line.Remove(0, 28).Trim().ToLower()).Contains("true"))
                            {
                                autoConnectOPCServer = false;
                                lblOPCAutoConnect.Text = "False";
                            }
                        else
                            {
                                autoConnectOPCServer = true;
                                lblOPCAutoConnect.Text = "True";
                            }

                        if (line.Contains("DisableAutoReConnectOPCServer:"))
                            if ((line.Remove(0, 30).Trim().ToLower()).Contains("true"))
                            {
                                autoReConnectOPCServer = false;
                                lblOPCAutoReConnect.Text = "False";
                            }
                        else
                            {
                                autoReConnectOPCServer = true;
                                lblOPCAutoReConnect.Text = "True";
                            }
                        if (line.Contains("DisableMemoryGarbageCollector:"))
                            if ((line.Remove(0, 30).Trim().ToLower()).Contains("true"))
                            {
                                forceMemoryGarbageCollector = false;
                                lblMemoryGarbageCollector.Text = "False";
                                lblMemoryGarbageCollector.Visible = true;
                                lblMemoryGarbageCollectorLabel.Visible = true;
                                garbageCollectorCounter = garbageCollectorCounterLimit;
                                lblGarbageCollectorActive.Visible = false;
                            }
                        else
                            {
                                forceMemoryGarbageCollector = true;
                                lblMemoryGarbageCollector.Text = "True";
                                lblMemoryGarbageCollector.Visible = true;
                                lblMemoryGarbageCollectorLabel.Visible = true;
                                lblGarbageCollectorActive.Visible = true;
                                lblGarbageCollectorActive.Text = "Time to active: " + garbageCollectorCounter.ToString();
                            }

                        if (line.Contains("OPCServerScanRate: "))
                        {
                            string OPCItemsRefreshRateString = line.Remove(0, 18).Trim();
                            if (int.TryParse(OPCItemsRefreshRateString, out int result))
                            {
                                if ((result >= 1) & (result <= 60))
                                {
                                    OPCItemsRefreshRate = result * 1000;
                                }
                            }
                        }
                        lblOPCRefreshText = "OPC Item Refresh Rate: " + (OPCItemsRefreshRate / 1000).ToString() + " sec ";

                        if (line.Contains("PVT: "))
                        {
                            PVT_fileName = line.Remove(0, 4).Trim();
                        }
                        
                        if (line.Contains("CV: "))
                        {
                            CV_fileName = line.Remove(0, 3).Trim();
                        }
                        
                        if (line.Contains("APCA PC Name:"))
                        {
                            APCAName = line.Remove(0, 13).Trim();
                            lblAPCAName.Text = APCAName;
                        }

                        if (line.Contains("APCB PC Name:"))
                        {
                            APCBName = line.Remove(0, 13).Trim();
                            lblAPCBName.Text = APCBName;
                        }
                    }
                }

                //Computer names
                if (string.IsNullOrWhiteSpace(APCAName) | string.IsNullOrWhiteSpace(APCBName))
                {
                    MessageBox.Show("ConfigGFC.txt error" + "\n" + "APCA or APCB PC names are not defined\n(there isn't 'APCA/B PC name:' label or PC name is empty)", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (String.Equals(computerName, APCAName))
                    {
                        lblAPCANameLabel.ForeColor = Color.Green;
                        lblAPCAName.ForeColor = Color.Green;
                        lblAPCBNameLabel.ForeColor = Color.Black;
                        lblAPCBName.ForeColor = Color.Black;
                    }
                    if (String.Equals(computerName, APCBName))
                    {
                        lblAPCBNameLabel.ForeColor = Color.Green;
                        lblAPCBName.ForeColor = Color.Green;
                        lblAPCANameLabel.ForeColor = Color.Black;
                        lblAPCAName.ForeColor = Color.Black;
                    }
                }

                //PVT configuration
                if (string.IsNullOrWhiteSpace(PVT_fileName))
                {
                    MessageBox.Show("ConfigGFC.txt error" + "\n" + "PVT file name is not defined\n(there isn't 'PVT:' label or PVT file name is empty)", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    setPVTTableOKStatus(false);
                }
                else
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader(PVT_fileName))
                        {
                                PVTDataImport(reader.ReadToEnd());
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Default configuration load error - PVT file" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        setPVTTableOKStatus(false);
                    }
                }

                //CV configuration
                if (string.IsNullOrWhiteSpace(CV_fileName))
                {
                    MessageBox.Show("ConfigGFC.txt error" + "\n" + "CV file name is not defined\n(there isn't 'CV:' label or CV file name is empty)", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    setCVTableOKStatus(false);
                }
                else
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader(CV_fileName))
                        {
                            CVDataImport(reader.ReadToEnd());
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Default configuration load error - PVT file" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        setCVTableOKStatus(false);
                    }
                }

                //OPC configuration
                OPCItemsFileContent = configFileContent;
                getOPCItemPaths();
                initOPCItemListView();
                setConfigurationOK();
            }
            catch (Exception ex)
            {
                setConfigurationOK();
                MessageBox.Show("Initial configuration load error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startProgramCycleThread()
        //This method starts the main program cycle thread
        {
            Thread programCycleThread = new Thread(new ThreadStart(programCycle));
            programCycleThread.Start();
        }

        private void programCycle()
        //The main application cycle (executed continiously every 1 sec). The method is used for the following functions:
        // - OPC Server autoConnection
        // - OPC Server autoReConnection
        // - Memory Garbage Collector
        // - Trigger update MainForm values
        {
            while (programCycleCmd)
            {
                //AutoConnect OPC Server (after starting the GFC application or 
                if ((autoConnectOPCServer & !OPCServerManualDisconnected)|
                    (autoReConnectOPCServer & autoReConnectOPCServerCmd))
                {
                    if (!connectOPCServerCmd)
                    {
                        if (autoConnectOPCServerCounter > 0)
                        {
                               autoConnectOPCServerCounter--;
                            if (autoConnectOPCServerCounter < (autoConnectOPCServerCounterLimit - 3))
                            {
                                if (!autoReConnectOPCServerCmd)
                                {
                                    lblConnectOPCServerCommentText = "Automatic connection in: " + autoConnectOPCServerCounter.ToString();
                                    lblConnectOPCServerCommentForeColor = "DarkGrey";
                                }
                                else
                                {
                                    lblConnectOPCServerCommentText = "Automatic reconnection in: " + autoConnectOPCServerCounter.ToString();
                                    lblConnectOPCServerCommentForeColor = "Red";
                                }
                            }
                        }
                        else
                        {
                            if (!autoReConnectOPCServerCmd)
                            {
                                lblConnectOPCServerCommentText = "Connected automatically";
                                lblConnectOPCServerCommentForeColor = "DarkGrey";
                            }
                            else
                            {
                                lblConnectOPCServerCommentText = "Reconnected automatically";
                                lblConnectOPCServerCommentForeColor = "DarkGrey";
                            }
                            intitialiseDASession();
                        }
                    }
                    else
                    {
                        autoConnectOPCServerCounter = autoConnectOPCServerCounterLimit;
                    }
                    
                }
                //AutoDisconnect - reconnect OPC Server if OPCServerConnectionStatus is false
                if (autoReConnectOPCServer)
                {
                    if (connectOPCServerCmd & !OPCServerConnectionStatus)
                    {
                        if (autoReConnectOPCServerCounter > 0)
                        {
                            autoReConnectOPCServerCounter--;
                            if (autoReConnectOPCServerCounter < (autoReConnectOPCServerCounterLimit - 3))
                            {
                                lblConnectOPCServerCommentText = "Automatic disconnection in: " + autoReConnectOPCServerCounter.ToString();
                                lblConnectOPCServerCommentForeColor = "Red";
                            }
                        }
                        else
                        {
                            lblConnectOPCServerCommentText = "Disconnected automatically";
                            lblConnectOPCServerCommentForeColor = "Red";
                            autoReConnectOPCServerCmd = true;
                            terminateDASession();
                        }
                    }
                    else
                    {
                        autoReConnectOPCServerCounter = autoReConnectOPCServerCounterLimit;
                    }
                }

                //Calculation progress bar - display on MainScreen
                if (pullOPCDataCmd)
                {
                    if (lblProgramCycleProgressBarText.Length < 93)
                    {
                        lblProgramCycleProgressBarText += ".";
                    }
                    else
                    {
                        lblProgramCycleProgressBarText = "Calculation is running ............................................................";
                    }
                }
                else
                {
                    if (firstConnectOPCServer)
                    {
                        lblProgramCycleProgressBarText = "Calculation not started";
                    }
                    else
                    {
                        lblProgramCycleProgressBarText = "Calculation stopped";
                    } 

                }

                //Memory Garbage Collector
                if (forceMemoryGarbageCollector)
                {
                    garbageCollectorCounter--;
                    lblGarbageCollectorActiveText = "Time to activate GC: " + garbageCollectorCounter.ToString();
                    if (garbageCollectorCounter <= 0)
                    {
                        lblGarbageCollectorActiveText = "Memory Garbage Colector Active";
                        memoryGarbageCollector();
                    }
                }

                //Trigger update MainForm values
                startUpdateProgramCycleMainForm();
                Thread.Sleep(Convert.ToInt32(MainForm.programCycleRefreshRate));
            }
        }

        public void startUpdateProgramCycleMainForm()
        //The method starts thread for update MainForm screens values
        {
            Thread updateProgramCycleMainFormThread = new Thread(new ThreadStart(this.updateProgramCycleMainForm));
            updateProgramCycleMainFormThread.Start();
        }

        private void updateProgramCycleMainForm()
        //The method updates MainForm screen values - triggered by program Cycle
        {
            if (lblProgramCycleProgressBar.InvokeRequired ||
                lblGarbageCollectorActive.InvokeRequired ||
                lblConnectOPCServerComment.InvokeRequired ||
                lblConnectionStatus.InvokeRequired ||
                lblConnectionStatusTime.InvokeRequired ||
                btnConnectOPCServer.InvokeRequired ||
                btnDisconnectOPCServer.InvokeRequired ||
                tabControl.InvokeRequired ||
                cmbNewOPCServerName.InvokeRequired ||
                btnSetOPCServerName.InvokeRequired ||
                btnSelectOPCItemsFile.InvokeRequired ||
                btnLoadPVTFile.InvokeRequired ||
                btnSetCustomCVValues.InvokeRequired ||
                btnLoadCVDataFile.InvokeRequired ||
                btnSetDischargeCoefficient.InvokeRequired ||
                txtDischargeCoefficient.InvokeRequired ||
                btnSetDensityMultiplier.InvokeRequired ||
                txtDensityMultiplier.InvokeRequired ||
                rdoPVTFile.InvokeRequired ||
                rdoROG.InvokeRequired ||
                rtxPVT.InvokeRequired ||
                prgOPCServerStatus.InvokeRequired ||
                lblOPCConnectionOK.InvokeRequired ||
                lblOPCRefresh.InvokeRequired ||
                lblCalculationRunning.InvokeRequired ||
                lblCalculatedFlowValue.InvokeRequired ||
                lblCalculatedFlowValue2.InvokeRequired ||
                lblCalculatedStatus.InvokeRequired ||
                lblCalculatedStatus2.InvokeRequired ||
                lblCalculationComment.InvokeRequired ||
                lblCalculatedStatusLabel.InvokeRequired ||
                lblCalculatedStatus2Label.InvokeRequired ||
                lblCalculationErrorCodeDescription.InvokeRequired ||
                lblHeartBit.InvokeRequired ||
                lblReadingWritingOPCItemStatus.InvokeRequired ||
                lblChokeOpenValue.InvokeRequired ||
                lblChokeOpenStatus.InvokeRequired ||
                lblPressureP1Value.InvokeRequired ||
                lblPressureP1Status.InvokeRequired ||
                lblPressureP2Value.InvokeRequired ||
                lblPressureP2Status.InvokeRequired ||
                lblTemperatureTValue.InvokeRequired ||
                lblTemperatureTStatus.InvokeRequired ||
                lblCVTableValue.InvokeRequired ||
                lblCVTableValueStatus.InvokeRequired ||
                lblPVTTableROGValue.InvokeRequired ||
                lblPVTTableDROGDPValue.InvokeRequired ||
                lblPVTTableDROGDTValue.InvokeRequired ||
                lblPVTTableCPGValue.InvokeRequired ||
                lblPVTTableROGValueStatus.InvokeRequired ||
                lblPVTTableDROGDPValueStatus.InvokeRequired ||
                lblPVTTableDROGDTValueStatus.InvokeRequired ||
                lblPVTTableCPGValueStatus.InvokeRequired
                )

            {
                updateLblProgramCycleCallback d = new updateLblProgramCycleCallback(updateProgramCycleMainForm);
                this.Invoke(d);
            }
            else
            {
                lblProgramCycleProgressBar.Text = lblProgramCycleProgressBarText;
                lblGarbageCollectorActive.Text = lblGarbageCollectorActiveText;
                lblConnectOPCServerComment.Text = lblConnectOPCServerCommentText;
                switch (lblConnectOPCServerCommentForeColor)
                {
                    case "DarkGrey":
                        lblConnectOPCServerComment.ForeColor = Color.DarkGray;
                        break;
                    case "Red":
                        lblConnectOPCServerComment.ForeColor = Color.Red;
                        break;
                    default:
                        lblConnectOPCServerComment.ForeColor = Color.Black;
                        break;
                }
                lblConnectionStatus.Text = lblConnectionStatusText;
                switch (lblConnectionStatusForeColor)
                {
                    case "Black":
                        lblConnectionStatus.ForeColor = Color.Black;
                        break;
                    case "Red":
                        lblConnectionStatus.ForeColor = Color.Red;
                        break;
                    case "Green":
                        lblConnectionStatus.ForeColor = Color.Green;
                        break;
                    case "Magenta":
                        lblConnectionStatus.ForeColor = Color.Magenta;
                        break;
                    default:
                        lblConnectionStatus.ForeColor = Color.Black;
                        break;
                }
                lblConnectionStatusTime.Text = lblConnectionStatusTimeText;
                btnConnectOPCServer.Enabled = btnConnectOPCServerEnabled;
                connectToolStripMenuItem.Enabled = connectToolStripMenuItemEnabled;
                disconnectToolStripMenuItem.Enabled = disconnectToolStripMenuItemEnabled;
                btnDisconnectOPCServer.Enabled = btnDisconnectOPCServerEnabled;
                loadDefaultConfigurationToolStripMenuItem.Enabled = loadDefaultConfigurationToolStripMenuItemEnabled;
                loadOPCIthemPathsToolStripMenuItem.Enabled = loadOPCIthemPathsToolStripMenuItemEnabled;
                loadPVTFileToolStripMenuItem.Enabled = loadPVTFileToolStripMenuItemEnabled;
                loadChokeFlowCurveFileToolStripMenuItem.Enabled = loadChokeFlowCurveFileToolStripMenuItemEnabled;
                cmbNewOPCServerName.Enabled = cmbNewOPCServerNameEnabled;
                btnSetOPCServerName.Enabled = btnSetOPCServerNameEnabled;
                btnSelectOPCItemsFile.Enabled = btnSelectOPCItemsFileEnabled;
                btnLoadPVTFile.Enabled = btnLoadPVTFileEnabled;
                btnSetCustomCVValues.Enabled = btnSetCustomCVValuesEnabled;
                btnLoadCVDataFile.Enabled = btnLoadCVDataFileEnabled;
                btnSetDischargeCoefficient.Enabled = btnSetDischargeCoefficientEnabled;
                txtDischargeCoefficient.Enabled = txtDischargeCoefficientEnabled;
                btnSetDensityMultiplier.Enabled = btnSetDensityMultiplierEnabled;
                txtDensityMultiplier.Enabled = txtDensityMultiplierEnabled;
                rdoPVTFile.Enabled = rdoPVTFileEnabled;
                rdoROG.Checked = rdoROGChecked;
                if (rtxPVT.Text != rtxPVTText)
                {
                    rtxPVT.Text = rtxPVTText;
                }
                prgOPCServerStatus.Value = prgOPCServerStatusValue;
                lblOPCConnectionOK.Text = lblOPCConnectionOKText;
                switch (lblOPCConnectionOKForeColor)
                {
                    case "Red":
                        lblOPCConnectionOK.ForeColor = Color.Red;
                        break;
                    case "Green":
                        lblOPCConnectionOK.ForeColor = Color.Green;
                        break;
                    default:
                        lblOPCConnectionOK.ForeColor = Color.Black;
                        break;
                }
                lblOPCRefresh.Text = lblOPCRefreshText;
                lblCalculationRunning.Text = lblCalculationRunningText;
                lblCalculatedFlowValue.Text = lblCalculatedFlowValueText;
                lblCalculatedFlowValue.Visible = lblCalculatedFlowValueVisible;
                lblCalculatedFlowValue2.Text = lblCalculatedFlowValue2Text;
                lblCalculatedFlowValue2.Visible = lblCalculatedFlowValue2Visible;
                lblCalculatedStatus.Text = lblCalculatedStatusText;
                lblCalculatedStatus2.Text = lblCalculatedStatus2Text;
                lblCalculationComment.Text = lblCalculationCommentText;
                lblCalculatedStatus.Visible = lblCalculatedStatusVisible;
                lblCalculatedStatusLabel.Visible = lblCalculatedStatusLabelVisible;
                lblCalculatedStatus2.Visible = lblCalculatedStatus2Visible;
                lblCalculatedStatus2Label.Visible = lblCalculatedStatus2LabelVisible;
                lblCalculationErrorCodeDescription.Text = lblCalculationErrorCodeDescriptionText;
                lblCalculationErrorCodeDescription.Visible = lblCalculationErrorCodeDescriptionVisible;
                lblCalculationComment.Visible = lblCalculationCommentVisible;
                lblHeartBit.Text = heartBitFlag.ToString();
                lblReadingWritingOPCItemStatus.Text = lblReadingWritingOPCItemStatusText;
                lblChokeOpenValue.Text = lblChokeOpenValueText;
                lblChokeOpenValue.Visible = lblChokeOpenValueVisible;
                lblChokeOpenStatus.Text = lblChokeOpenStatusText;
                lblChokeOpenStatus.Visible = lblChokeOpenStatusVisible;
                switch (lblChokeOpenStatusForeColor)
                {
                    case "Red":
                        lblChokeOpenStatus.ForeColor = Color.Red;
                        break;
                    case "Green":
                        lblChokeOpenStatus.ForeColor = Color.Green;
                        break;
                    default:
                        lblChokeOpenStatus.ForeColor = Color.Black;
                        break;
                }
                lblPressureP1Value.Text = lblPressureP1ValueText;
                lblPressureP1Value.Visible = lblPressureP1ValueVisible;
                lblPressureP1Status.Text = lblPressureP1StatusText;
                lblPressureP1Status.Visible = lblPressureP1StatusVisible;
                switch (lblPressureP1StatusForeColor)
                {
                    case "Red":
                        lblPressureP1Status.ForeColor = Color.Red;
                        break;
                    case "Green":
                        lblPressureP1Status.ForeColor = Color.Green;
                        break;
                    default:
                        lblPressureP1Status.ForeColor = Color.Black;
                        break;
                }
                lblPressureP2Value.Text = lblPressureP2ValueText;
                lblPressureP2Value.Visible = lblPressureP2ValueVisible;
                lblPressureP2Status.Text = lblPressureP2StatusText;
                lblPressureP2Status.Visible = lblPressureP2StatusVisible;
                switch (lblPressureP2StatusForeColor)
                {
                    case "Red":
                        lblPressureP2Status.ForeColor = Color.Red;
                        break;
                    case "Green":
                        lblPressureP2Status.ForeColor = Color.Green;
                        break;
                    default:
                        lblPressureP2Status.ForeColor = Color.Black;
                        break;
                }
                lblTemperatureTValue.Text = lblTemperatureTValueText;
                lblTemperatureTValue.Visible = lblTemperatureTValueVisible;
                lblTemperatureTStatus.Text = lblTemperatureTStatusText;
                lblTemperatureTStatus.Visible = lblTemperatureTStatusVisible;
                switch (lblTemperatureTStatusForeColor)
                {
                    case "Red":
                        lblTemperatureTStatus.ForeColor = Color.Red;
                        break;
                    case "Green":
                        lblTemperatureTStatus.ForeColor = Color.Green;
                        break;
                    default:
                        lblTemperatureTStatus.ForeColor = Color.Black;
                        break;
                }
                lblCVTableValue.Text = lblCVTableValueText;
                lblCVTableValue.Visible = lblCVTableValueVisible;
                lblCVTableValueStatus.Text = lblCVTableValueStatusText;
                switch (lblCVTableValueStatusForeColor)
                {
                    case "Red":
                        lblCVTableValueStatus.ForeColor = Color.Red;
                        break;
                    case "Green":
                        lblCVTableValueStatus.ForeColor = Color.Green;
                        break;
                    default:
                        lblCVTableValueStatus.ForeColor = Color.Black;
                        break;
                }
                lblCVTableValueStatus.Visible = lblCVTableValueStatusVisible;
                lblPVTTableROGValue.Text = lblPVTTableROGValueText;
                lblPVTTableROGValue.Visible = lblPVTTableROGValueVisible;
                lblPVTTableROGValueStatus.Text = lblPVTTableROGValueStatusText;
                switch (lblPVTTableROGValueStatusForeColor)
                {
                    case "Red":
                        lblPVTTableROGValueStatus.ForeColor = Color.Red;
                        break;
                    case "Green":
                        lblPVTTableROGValueStatus.ForeColor = Color.Green;
                        break;
                    default:
                        lblPVTTableROGValueStatus.ForeColor = Color.Black;
                        break;
                }
                lblPVTTableROGValueStatus.Visible = lblPVTTableROGValueStatusVisible;
                lblPVTTableDROGDPValue.Text = lblPVTTableDROGDPValueText;
                lblPVTTableDROGDPValue.Visible = lblPVTTableDROGDPValueVisible;
                lblPVTTableDROGDPValueStatus.Text = lblPVTTableDROGDPValueStatusText;
                switch (lblPVTTableDROGDPValueStatusForeColor)
                {
                    case "Red":
                        lblPVTTableDROGDPValueStatus.ForeColor = Color.Red;
                        break;
                    case "Green":
                        lblPVTTableDROGDPValueStatus.ForeColor = Color.Green;
                        break;
                    default:
                        lblPVTTableDROGDPValueStatus.ForeColor = Color.Black;
                        break;
                }
                lblPVTTableDROGDPValueStatus.Visible = lblPVTTableDROGDPValueStatusVisible;
                lblPVTTableDROGDTValue.Text = lblPVTTableDROGDTValueText;
                lblPVTTableDROGDTValue.Visible = lblPVTTableDROGDTValueVisible;
                lblPVTTableDROGDTValueStatus.Text = lblPVTTableDROGDTValueStatusText;
                switch (lblPVTTableDROGDTValueStatusForeColor)
                {
                    case "Red":
                        lblPVTTableDROGDTValueStatus.ForeColor = Color.Red;
                        break;
                    case "Green":
                        lblPVTTableDROGDTValueStatus.ForeColor = Color.Green;
                        break;
                    default:
                        lblPVTTableDROGDTValueStatus.ForeColor = Color.Black;
                        break;
                }
                lblPVTTableDROGDTValueStatus.Visible = lblPVTTableDROGDTValueStatusVisible;
                lblPVTTableCPGValue.Text = lblPVTTableCPGValueText;
                lblPVTTableCPGValue.Visible = lblPVTTableCPGValueVisible;
                lblPVTTableCPGValueStatus.Text = lblPVTTableCPGValueStatusText;
                switch (lblPVTTableCPGValueStatusForeColor)
                {
                    case "Red":
                        lblPVTTableCPGValueStatus.ForeColor = Color.Red;
                        break;
                    case "Green":
                        lblPVTTableCPGValueStatus.ForeColor = Color.Green;
                        break;
                    default:
                        lblPVTTableCPGValueStatus.ForeColor = Color.Black;
                        break;
                }
                lblPVTTableCPGValueStatus.Visible = lblPVTTableCPGValueStatusVisible;
            }
        }
        #endregion

        #region Methods - Calculation
        private void loadPVTFile()
        //This method opens and reads the PVT table configuration file - it is used for GFC application initial configuration
        {
            try
            {
                string fileName = string.Empty;
                openFileDialog.InitialDirectory = configFileDirectory;
                openFileDialog.Filter = "PVT files (*.tab)|*.tab|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FileName = PVT_fileName.Remove(0, (PVT_fileName.LastIndexOf(@"\") + 1));
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        PVTDataImport(reader.ReadToEnd());
                    }
                }
                setConfigurationOK();
            }
            catch (Exception ex)
            {
                setPVTTableOKStatus(false);
                setConfigurationOK();
                MessageBox.Show("PVT file load error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PVTDataImport(string PVT_fileContent)
        //This method imports the PVT table data from configuration file into app internal arrays - it is used for GFC application initial configuration
        {
            try
            {
                Boolean firstLineRead = false;
                int fileLineCounter = 0;
                int PT_Index = 0;
                int TM_Index = 0;
                double PVT_PT_Last = 0;
                double PVT_TM_Last = 0;

                using (var reader = new StringReader(PVT_fileContent))
                {
                    for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                    {
                        if (line.Contains("PVTTABLE POINT"))
                        {
                            line = line.Remove(0, 18).TrimEnd(')');
                            string[] PVT_Values = line.Split(',');

                            if (!firstLineRead)
                            {
                                PVT_PT[0] = double.Parse(PVT_Values[0], CultureInfo.CreateSpecificCulture("en-US"));
                                PVT_TM[0] = double.Parse(PVT_Values[1], CultureInfo.CreateSpecificCulture("en-US"));
                                PVT_PT_Last = PVT_PT[0];
                                PVT_TM_Last = PVT_TM[0];
                                PT_Index++;
                                TM_Index++;
                                firstLineRead = true;
                            }

                            //PT array
                            if (double.Parse(PVT_Values[0], CultureInfo.CreateSpecificCulture("en-US")) > PVT_PT_Last)
                            {
                                PVT_PT[PT_Index] = double.Parse(PVT_Values[0], CultureInfo.CreateSpecificCulture("en-US"));
                                PVT_PT_Last = PVT_PT[PT_Index];
                                PT_Index++;
                            }

                            //TM array
                            if (double.Parse(PVT_Values[1], CultureInfo.CreateSpecificCulture("en-US")) > PVT_TM_Last)
                            {
                                PVT_TM[TM_Index] = double.Parse(PVT_Values[1], CultureInfo.CreateSpecificCulture("en-US"));
                                PVT_TM_Last = PVT_TM[TM_Index];
                                TM_Index++;
                            }

                            //PVT arrays
                            int PT_Index2;
                            int TM_Index2;
                            PT_Index2 = Array.IndexOf(PVT_PT, double.Parse(PVT_Values[0], CultureInfo.CreateSpecificCulture("en-US")));
                            TM_Index2 = Array.IndexOf(PVT_TM, double.Parse(PVT_Values[1], CultureInfo.CreateSpecificCulture("en-US")));

                            PVT_ROG[PT_Index2, TM_Index2] = double.Parse(PVT_Values[2], CultureInfo.CreateSpecificCulture("en-US"));
                            PVT_DROGDP[PT_Index2, TM_Index2] = double.Parse(PVT_Values[4], CultureInfo.CreateSpecificCulture("en-US"));
                            PVT_DROGDT[PT_Index2, TM_Index2] = double.Parse(PVT_Values[6], CultureInfo.CreateSpecificCulture("en-US"));
                            PVT_CPG[PT_Index2, TM_Index2] = double.Parse(PVT_Values[11], CultureInfo.CreateSpecificCulture("en-US"));

                            fileLineCounter++;
                        }
                    }
                }
                setPVTTableOKStatus(true);
                rdoROG.Checked = true;
                displayPVT(PVT_ROG, "ROG");
            }
            catch (Exception ex)
            {
                setPVTTableOKStatus(false);
                MessageBox.Show("PVT table data import error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void readPVTTableValues()
        //The method finds PVT data values from internal app arrays for current process pressure and temperature - it is used during actual flow calculation
        {
            try
            {
                if (PVTTableOK & pressureP1ValueOK & temperatureTValueOK)
                {
                    ROG = find2DimArrayValue(pressureP1 * 100000, temperatureT, PVT_PT, PVT_TM, PVT_ROG);
                    DROGDP = find2DimArrayValue(pressureP1 * 100000, temperatureT, PVT_PT, PVT_TM, PVT_DROGDP);
                    DROGDT = find2DimArrayValue(pressureP1 * 100000, temperatureT, PVT_PT, PVT_TM, PVT_DROGDT);
                    CPG = find2DimArrayValue(pressureP1 * 100000, temperatureT, PVT_PT, PVT_TM, PVT_CPG);

                    if ((ROG != -1) & (DROGDP != -1) & (DROGDT != -1) & (CPG != -1))
                    {
                        setPVTTableValues(true);
                    }
                    else
                    {
                        setPVTTableValues(false);
                    }
                }
                else
                {
                    setPVTTableValues(false);
                }
            }
            catch (Exception ex)
            {
                setPVTTableValues(false);
                MessageBox.Show("Read PVT table values error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displayPVT(double[,] dataArray, string dataHeader)
        //The method prepares PVT table data to display on HMI PVT tab screen
        {
            try
            {
                int noElements = 0;
                string textToDisplay = string.Empty;

                switch (dataHeader)
                {
                    case "ROG":
                        rdoROGChecked = true;
                        textToDisplay = "*** ROG  [kg/m3] - Gas density ***\n\n(PT  [bar] - Pressure, TM  [decC] - Temperature)\n\n";
                        break;
                    case "DROGDP":
                        rdoROGChecked = false;
                        textToDisplay = "*** DROGDP - Pressure derivative of gas density ***\n\n(PT  [bar] - Pressure, TM  [decC] - Temperature)\n\n";
                        break;
                    case "DROGDT":
                        rdoROGChecked = false;
                        textToDisplay = "*** DROGDT - Temperature derivative of gas density ***\n\n(PT  [bar] - Pressure, TM  [decC] - Temperature)\n\n";
                        break;
                    case "CPG":
                        rdoROGChecked = false;
                        textToDisplay = "*** CPD  [J/kg/K] - Specific heat capacity at constant pressure ***\n\n(PT  [bar] - Pressure, TM  [decC] - Temperature)\n\n";
                        break;
                    default:
                        rdoROGChecked = false;
                        textToDisplay = "";
                        break;
                }

                textToDisplay += string.Format("{0,-9}", @"PT\TM") + " |";

                foreach (double arrayElement in PVT_TM)
                {
                    textToDisplay += string.Format("{0,-13}", arrayElement.ToString());
                }
                textToDisplay += "\n";

                foreach (double arrayElement in PVT_TM)
                {
                    textToDisplay += "-------------";
                }

                textToDisplay += "\n";

                for (int i = 0; i < dataArray.GetLength(0); i++)
                {
                    textToDisplay += string.Format("{0,-9}", (PVT_PT[i]/100000).ToString()) + " |";
                    for (int j = 0; j < dataArray.GetLength(1); j++)
                    {
                        textToDisplay += string.Format("{0,-13}", dataArray[i, j].ToString());
                        noElements++;
                    }
                    textToDisplay += "\n";
                }

                textToDisplay += "\n" + "*** No elements: " + noElements.ToString() + " ***";
                rtxPVTText = textToDisplay;


            }
            catch (Exception ex)
            {
                MessageBox.Show("PVT display error (2)" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setPVTTableOKStatus(Boolean status)
        //The method is used to set "PVT Table OK/Error" status indicator on HMI PVT tab screen
        {
            PVTTableOK = status;
            if (status)
            {
                lblPVTTableOKStatus.Text = "PVT Table OK";
                lblPVTTableOKStatus.ForeColor = Color.Green;
            }
            else
            {
                lblPVTTableOKStatus.Text = "PVT Table Error";
                lblPVTTableOKStatus.ForeColor = Color.Red;
            }
            setConfigurationOK();
        }

        private void setPVTTableValues(Boolean status, Boolean visible = true)
        //The method sets PVT table parameters (values and statuses) for current process data on HMI Calculation tab screen
        {
            PVTTableROGValueOK = status;
            PVTTableDROGDPValueOK = status;
            PVTTableDROGDTValueOK = status;
            PVTTableCPGValueOK = status;

            lblPVTTableROGValueStatusVisible = visible;
            lblPVTTableDROGDPValueStatusVisible = visible;
            lblPVTTableDROGDTValueStatusVisible = visible;
            lblPVTTableCPGValueStatusVisible = visible;

            lblPVTTableROGValueText = ROG.ToString("F3");
            lblPVTTableDROGDPValueText = DROGDP.ToString("E5");
            lblPVTTableDROGDTValueText = DROGDT.ToString("F5");
            lblPVTTableCPGValueText = CPG.ToString("F2");

            lblPVTTableROGValueVisible = visible;
            lblPVTTableDROGDPValueVisible = visible;
            lblPVTTableDROGDTValueVisible = visible;
            lblPVTTableCPGValueVisible = visible;

            if (status)
            {
                lblPVTTableROGValueStatusText = "OK";
                lblPVTTableDROGDPValueStatusText = "OK";
                lblPVTTableDROGDTValueStatusText = "OK";
                lblPVTTableCPGValueStatusText = "OK";

                lblPVTTableROGValueStatusForeColor = "Green";
                lblPVTTableDROGDPValueStatusForeColor = "Green";
                lblPVTTableDROGDTValueStatusForeColor = "Green";
                lblPVTTableCPGValueStatusForeColor = "Green";
            }
            else
            {
                lblPVTTableROGValueStatusText = "Bad";
                lblPVTTableDROGDPValueStatusText = "Bad";
                lblPVTTableDROGDTValueStatusText = "Bad";
                lblPVTTableCPGValueStatusText = "Bad";

                lblPVTTableROGValueStatusForeColor = "Red";
                lblPVTTableDROGDPValueStatusForeColor = "Red";
                lblPVTTableDROGDTValueStatusForeColor = "Red";
                lblPVTTableCPGValueStatusForeColor = "Red";
            }
        }

        private void loadCVFile()
        //The method reads Choke CV curve from configuration files - it is used for GFC program initial configuration
        {
            try
            {
                string fileName = string.Empty;
                openFileDialog.InitialDirectory = configFileDirectory;
                openFileDialog.Filter = "CV files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FileName = CV_fileName.Remove(0, (CV_fileName.LastIndexOf(@"\") + 1));
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        CVDataImport(reader.ReadToEnd());
                    }
                }
                setConfigurationOK();
            }

            catch (Exception ex)
            {
                setCVTableOKStatus(false);
                setConfigurationOK();
                MessageBox.Show("PVT file error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CVDataImport(string CV_fileContent)
        //The method imports Choke CV curve from configuration file into application internal table
        {
            try
            {
                int lineNumber = -1;
                using (var reader = new StringReader(CV_fileContent))
                {
                    for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                    {
                        if ((lineNumber >= 0) & (lineNumber <= 100))
                        {
                            if (lineNumber == int.Parse(line.Remove(line.IndexOf(",")), CultureInfo.CreateSpecificCulture("en-US")))
                            {
                                chokeCurve[lineNumber] = double.Parse(line.Remove(0, line.IndexOf(",") + 1), CultureInfo.CreateSpecificCulture("en-US"));
                            }
                            else
                            {
                                MessageBox.Show("CV data file error" + "\n" + "Wrong elements (Steps) order", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        if (lineNumber > 100)
                        {
                            MessageBox.Show("CV data file error" + "\n" + "More than 100 elements", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        lineNumber++;
                    }
                }
                foreach (Control controlItem in this.tabChoke.Controls.OfType<TextBox>())
                {
                    if (controlItem is TextBox)
                    {
                        String ControlItemName = controlItem.Name;
                        if (ControlItemName.Contains("txtCV_"))
                        {
                            string CVStepNumberString = ControlItemName.Remove(0, 6);
                            int CVStepNumber;
                            CVStepNumber = int.Parse(CVStepNumberString);
                            controlItem.Text = chokeCurve[(CVStepNumber)].ToString("F2");                            
                        }
                    }
                }
                chrChokeFlowCurve.Series[0].Points.DataBindY(chokeCurve);
                resetTxtCVBackgroundColour();
                setCVTableOKStatus(true);
            }
            catch (Exception ex)
            {
                setCVTableOKStatus(false);
                MessageBox.Show("CV data import error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void readCVTableValue()
        //The method finds the CV value from internal table for actual Choke opening - it is used for actual flow calculation
        {
            try
            {
                if (CVTableOK & chokeOpenValueOK)
                {
                    CV = find1DimArrayValue(Math.Max(chokeOpen,0), chokeCurve);
                    if (CV != -1)
                    {
                        setCVTableValue(true);
                    }
                    else
                    {
                        setCVTableValue(false);
                    }
                }
                else
                {
                    setCVTableValue(false);
                }
            }
            catch (Exception ex)
            {
                setCVTableValue(false);
                MessageBox.Show("Read Choke Capacity value from CV table error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setCVTableOKStatus(Boolean status)
        //The method sets the "CV Table OK/Error" status indicator for HMI Choke Flow Curve screen
        {
            CVTableOK = status;
            if (status)
            {
                lblCVTableOKStatus.Text = "CV Table OK";
                lblCVTableOKStatus.ForeColor = Color.Green;
            }
            else
            {
                lblCVTableOKStatus.Text = "CV Table Error";
                lblCVTableOKStatus.ForeColor = Color.Red;
            }
            setConfigurationOK();
        }

        private void setCVTableValue(Boolean status, Boolean visible = true)
        //The method sets the Choke CV actual value & status indicators for HMI Calculation tab screen
        {
            CVTableValueOK = status;
            lblCVTableValueStatusVisible = visible;
            lblCVTableValueText = CV.ToString("F2");
            lblCVTableValueVisible = visible;

            if (status)
            {
                lblCVTableValueStatusText = "OK";
                lblCVTableValueStatusForeColor = "Green";
            }
            else
            {
                lblCVTableValueStatusText = "Bad";
                lblCVTableValueStatusForeColor = "Red";
            }
        }

        private void resetTxtCVBackgroundColour()
        //The method resets colour background of HMI Choke Flow Curve tab input fields
        {
            txtCV_1.BackColor = Color.White;
            txtCV_2.BackColor = Color.White;
            txtCV_3.BackColor = Color.White;
            txtCV_4.BackColor = Color.White;
            txtCV_5.BackColor = Color.White;
            txtCV_6.BackColor = Color.White;
            txtCV_7.BackColor = Color.White;
            txtCV_8.BackColor = Color.White;
            txtCV_9.BackColor = Color.White;
            txtCV_10.BackColor = Color.White;
            txtCV_11.BackColor = Color.White;
            txtCV_12.BackColor = Color.White;
            txtCV_13.BackColor = Color.White;
            txtCV_14.BackColor = Color.White;
            txtCV_15.BackColor = Color.White;
            txtCV_16.BackColor = Color.White;
            txtCV_17.BackColor = Color.White;
            txtCV_18.BackColor = Color.White;
            txtCV_19.BackColor = Color.White;
            txtCV_20.BackColor = Color.White;
            txtCV_21.BackColor = Color.White;
            txtCV_22.BackColor = Color.White;
            txtCV_23.BackColor = Color.White;
            txtCV_24.BackColor = Color.White;
            txtCV_25.BackColor = Color.White;
            txtCV_26.BackColor = Color.White;
            txtCV_27.BackColor = Color.White;
            txtCV_28.BackColor = Color.White;
            txtCV_29.BackColor = Color.White;
            txtCV_30.BackColor = Color.White;
            txtCV_31.BackColor = Color.White;
            txtCV_32.BackColor = Color.White;
            txtCV_33.BackColor = Color.White;
            txtCV_34.BackColor = Color.White;
            txtCV_35.BackColor = Color.White;
            txtCV_36.BackColor = Color.White;
            txtCV_37.BackColor = Color.White;
            txtCV_38.BackColor = Color.White;
            txtCV_39.BackColor = Color.White;
            txtCV_40.BackColor = Color.White;
            txtCV_41.BackColor = Color.White;
            txtCV_42.BackColor = Color.White;
            txtCV_43.BackColor = Color.White;
            txtCV_44.BackColor = Color.White;
            txtCV_45.BackColor = Color.White;
            txtCV_46.BackColor = Color.White;
            txtCV_47.BackColor = Color.White;
            txtCV_48.BackColor = Color.White;
            txtCV_49.BackColor = Color.White;
            txtCV_50.BackColor = Color.White;
            txtCV_51.BackColor = Color.White;
            txtCV_52.BackColor = Color.White;
            txtCV_53.BackColor = Color.White;
            txtCV_54.BackColor = Color.White;
            txtCV_55.BackColor = Color.White;
            txtCV_56.BackColor = Color.White;
            txtCV_57.BackColor = Color.White;
            txtCV_58.BackColor = Color.White;
            txtCV_59.BackColor = Color.White;
            txtCV_60.BackColor = Color.White;
            txtCV_61.BackColor = Color.White;
            txtCV_62.BackColor = Color.White;
            txtCV_63.BackColor = Color.White;
            txtCV_64.BackColor = Color.White;
            txtCV_65.BackColor = Color.White;
            txtCV_66.BackColor = Color.White;
            txtCV_67.BackColor = Color.White;
            txtCV_68.BackColor = Color.White;
            txtCV_69.BackColor = Color.White;
            txtCV_70.BackColor = Color.White;
            txtCV_71.BackColor = Color.White;
            txtCV_72.BackColor = Color.White;
            txtCV_73.BackColor = Color.White;
            txtCV_74.BackColor = Color.White;
            txtCV_75.BackColor = Color.White;
            txtCV_76.BackColor = Color.White;
            txtCV_77.BackColor = Color.White;
            txtCV_78.BackColor = Color.White;
            txtCV_79.BackColor = Color.White;
            txtCV_80.BackColor = Color.White;
            txtCV_81.BackColor = Color.White;
            txtCV_82.BackColor = Color.White;
            txtCV_83.BackColor = Color.White;
            txtCV_84.BackColor = Color.White;
            txtCV_85.BackColor = Color.White;
            txtCV_86.BackColor = Color.White;
            txtCV_87.BackColor = Color.White;
            txtCV_88.BackColor = Color.White;
            txtCV_89.BackColor = Color.White;
            txtCV_90.BackColor = Color.White;
            txtCV_91.BackColor = Color.White;
            txtCV_92.BackColor = Color.White;
            txtCV_93.BackColor = Color.White;
            txtCV_94.BackColor = Color.White;
            txtCV_95.BackColor = Color.White;
            txtCV_96.BackColor = Color.White;
            txtCV_97.BackColor = Color.White;
            txtCV_98.BackColor = Color.White;
            txtCV_99.BackColor = Color.White;
            txtCV_100.BackColor = Color.White;
        }

        private double linearInterpolation(double x, double x1, double x2, double y1, double y2)
        //The method calculates linear interpolation between two points
        {
            try
            {
                return y1 + ((y2 - y1) / (x2 - x1)) * (x - x1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Linear interpolation type 1" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (-1);
            }
        }

        private double find1DimArrayValue(double x, double[] array)
        //The method finds the value on the one-dimensional characteristic
        {
            try
            {
                double y1 = array[0];
                double y2 = array[0];
                int x1 = 0;
                int x2 = 0;

                if (x > (array.Length - 1))
                {
                    x = array.Length - 1;
                }

                for (int i = 0; i < array.Length; i++)
                {
                    x1 = x2;
                    x2 = i;

                    y1 = y2;
                    y2 = array[i];

                    if (i > x)
                    {
                        i = array.Length;
                    }
                }
                return linearInterpolation(x, x1, x2, y1, y2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("One dimention array find value error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (-1);
            }
        }

        private double find2DimArrayValue(double x, double y, double[] array_x, double[] array_y, double[,] array_Q)
        //The method finds the value on the two-dimensionals characteristic
        {
            try
            {
                int x1_Index = 0;
                int x2_Index = 0;
                int y1_Index = 0;
                int y2_Index = 0;

                Double R1 = 0;
                Double R2 = 0;

                if (x > array_x[array_x.GetLength(0) - 1])
                {
                    x = array_x[array_x.GetLength(0) - 1];
                }
                if (x < array_x[0])
                {
                    x = array_x[0];
                }

                for (int i = 0; i < array_x.Length; i++)
                {
                    x1_Index = x2_Index;
                    x2_Index = i;

                    if (array_x[i] > x)
                    {
                        i = array_x.Length;
                    }
                }


                if (y > array_y[array_y.GetLength(0) - 1])
                {
                    y = array_y[array_y.GetLength(0) - 1];
                }

                if (y < array_y[0])
                {
                    y = array_y[0];
                }

                for (int i = 0; i < array_y.Length; i++)
                {
                    y1_Index = y2_Index;
                    y2_Index = i;

                    if (array_y[i] > y)
                    {
                        i = array_y.Length;
                    }
                }

                R1 = linearInterpolation(x, array_x[x1_Index], array_x[x2_Index], array_Q[x1_Index, y1_Index], array_Q[x2_Index, y1_Index]);
                R2 = linearInterpolation(x, array_x[x1_Index], array_x[x2_Index], array_Q[x1_Index, y2_Index], array_Q[x2_Index, y2_Index]);

                /* MessageBox.Show("x=" + x + "\n" + "x1=" + array_x[x1_Index] + "\n" + "x2=" + array_x[x2_Index] + "\n" + "\n" + 
                                "y=" + y + "\n" + "y1=" + array_y[y1_Index] + "\n" + "y2=" + array_y[y2_Index] + "\n" + "\n" + 
                                "Q11=" + array_Q[x1_Index, y1_Index] + "\n" + "Q21=" + array_Q[x2_Index, y1_Index] + "\n" + "\n" +
                                "Q12=" + array_Q[x1_Index, y2_Index] + "\n" + "Q22=" + array_Q[x2_Index, y2_Index] + "\n" + "\n" +
                                "R1=" + R1 + "\n" + "R2=" + R2);
                */

                return linearInterpolation(y, array_y[y1_Index], array_y[y2_Index], R1, R2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Two dimentions array find value error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (-1);
            }
        }

        private void updateProcessData()
        //The method updates actual process data for Calculation Flow algorithm and HMI Calculation tab screen
        {
            setChokeOpen();
            setPressureP1();
            setPressureP2();
            setTemperatureT();
        }
        
        private void setChokeOpen()
        //The method update actual value & status of Choke Opening for Calculation Flow algorithm and HMI Calculation tab screen
        {
            try
            {
                if (OPCServerConnectionStatus)
                {
                    if (OPCItemQualities[0] == "GOOD")
                    {
                        chokeOpen = double.Parse(OPCItemValues[0]);
                        if ((chokeOpen > -5) && (chokeOpen < 105))
                            chokeOpenValueOK = true;
                        else
                            chokeOpenValueOK = false;
                    }
                    else
                    {
                        chokeOpen = -1;
                        chokeOpenValueOK = false;
                    }

                    lblChokeOpenValueVisible = true;
                    lblChokeOpenStatusVisible = true;
                }
                else
                {
                    chokeOpen = -1;
                    chokeOpenValueOK = false;
                    lblChokeOpenValueVisible = false;
                    lblChokeOpenStatusVisible = false;
                }

                lblChokeOpenValueText = chokeOpen.ToString("F1");

                if (chokeOpenValueOK)
                {
                    lblChokeOpenStatusText = "OK";
                    lblChokeOpenStatusForeColor = "Green";
                }
                else
                {
                    lblChokeOpenStatusText = "Bad";
                    lblChokeOpenStatusForeColor = "Red";
                }
            }
            catch (Exception ex)
            {
                chokeOpen = -1;
                chokeOpenValueOK = false;
                lblChokeOpenValueText = chokeOpen.ToString();
                lblChokeOpenStatusText = "Err";
                lblChokeOpenStatusForeColor = "Red";
                lblChokeOpenValueVisible = true;
                lblChokeOpenStatusVisible = true;
                MessageBox.Show("Choke Open process data update error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setPressureP1()
        //The method update actual value & status of Pressure P1 for Calculation Flow algorithm and HMI Calculation tab screen
        {
            try
            {
                if (OPCServerConnectionStatus)
                {
                    if (OPCItemQualities[1] == "GOOD")
                    {
                        pressureP1 = double.Parse(OPCItemValues[1]);
                        if ((pressureP1 > -1) && (pressureP1 < 691))
                        {
                            pressureP1 = Math.Max(pressureP1, 0);
                            pressureP1ValueOK = true;
                        }
                        else
                            pressureP1ValueOK = false;
                    }
                    else
                    {
                        pressureP1 = -1;
                        pressureP1ValueOK = false;
                    }

                    lblPressureP1ValueVisible = true;
                    lblPressureP1StatusVisible = true;
                }
                else
                {
                    pressureP1 = -1;
                    pressureP1ValueOK = false;
                    lblPressureP1ValueVisible = false;
                    lblPressureP1StatusVisible = false;
                }

                lblPressureP1ValueText = pressureP1.ToString("F1");

                if (pressureP1ValueOK)
                {
                    lblPressureP1StatusText = "OK";
                    lblPressureP1StatusForeColor = "Green";
                }
                else
                {
                    lblPressureP1StatusText = "Bad";
                    lblPressureP1StatusForeColor = "Red";
                }
            }
            catch (Exception ex)
            {
                pressureP1 = -1;
                pressureP1ValueOK = false;
                lblPressureP1ValueText = pressureP1.ToString();
                lblPressureP1StatusText = "Err";
                lblPressureP1StatusForeColor = "Red";
                lblPressureP1ValueVisible = true;
                lblPressureP1StatusVisible = true;
                MessageBox.Show("Pressure P1 process data update error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setPressureP2()
        //The method update actual value & status of Pressure P2 for Calculation Flow algorithm and HMI Calculation tab screen
        {
            try
            {
                if (OPCServerConnectionStatus)
                {
                    if (OPCItemQualities[2] == "GOOD")
                    {
                        pressureP2 = double.Parse(OPCItemValues[2]);
                        if ((pressureP2 > -1) && (pressureP2 < 691))
                        {
                            pressureP2 = Math.Max(pressureP2, 0);
                            pressureP2ValueOK = true;
                        }
                        else
                            pressureP2ValueOK = false;
                    }
                    else
                    {
                        pressureP2 = -1;
                        pressureP2ValueOK = false;
                    }

                    lblPressureP2ValueVisible = true;
                    lblPressureP2StatusVisible = true;
                }
                else
                {
                    pressureP2 = -1;
                    pressureP2ValueOK = false;
                    lblPressureP2ValueVisible = false;
                    lblPressureP2StatusVisible = false;
                }

                lblPressureP2ValueText = pressureP2.ToString("F1");

                if (pressureP2ValueOK)
                {
                    lblPressureP2StatusText = "OK";
                    lblPressureP2StatusForeColor = "Green";
                }
                else
                {
                    lblPressureP2StatusText = "Bad";
                    lblPressureP2StatusForeColor = "Red";
                }
            }
            catch (Exception ex)
            {
                pressureP2 = -1;
                pressureP2ValueOK = false;
                lblPressureP2ValueText = pressureP2.ToString();
                lblPressureP2StatusText = "Err";
                lblPressureP2StatusForeColor = "Red";
                lblPressureP2ValueVisible = true;
                lblPressureP2StatusVisible = true;
                MessageBox.Show("Pressure P2 process data update error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setTemperatureT()
        //The method update actual value & status of Temperature T for Calculation Flow algorithm and HMI Calculation tab screen
        {
            try
            {
                if (OPCServerConnectionStatus)
                {
                    if (OPCItemQualities[3] == "GOOD")
                    {
                        temperatureT = double.Parse(OPCItemValues[3]);
                        if ((temperatureT > -11) && (temperatureT < 126))
                            temperatureTValueOK = true;
                        else
                            temperatureTValueOK = false;
                    }
                    else
                    {
                        temperatureT = -1;
                        temperatureTValueOK = false;
                    }

                    lblTemperatureTValueVisible = true;
                    lblTemperatureTStatusVisible = true;
                }
                else
                {
                    temperatureT = -1;
                    temperatureTValueOK = false;
                    lblTemperatureTValueVisible = false;
                    lblTemperatureTStatusVisible = false;
                }

                lblTemperatureTValueText = temperatureT.ToString("F1");

                if (temperatureTValueOK)
                {
                    lblTemperatureTStatusText = "OK";
                    lblTemperatureTStatusForeColor = "Green";
                }
                else
                {
                    lblTemperatureTStatusText = "Bad";
                    lblTemperatureTStatusForeColor = "Red";
                }
            }
            catch (Exception ex)
            {
                temperatureT = -1;
                temperatureTValueOK = false;
                lblTemperatureTValueText = temperatureT.ToString();
                lblTemperatureTStatusText = "Err";
                lblTemperatureTStatusForeColor = "Red";
                lblTemperatureTValueVisible = true;
                lblTemperatureTStatusVisible = true;
                MessageBox.Show("Temperature T process data update error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calculateFlow()
        //The method calculates the value of actual flow and determines the calculated flow error code
        {
            try
            {
                calculatedFlowErr = 0;
                calculatedFlowErrComment = "Error Code detail description:\n";
                calculatedFlowComment = "";
                if (!OPCServerConnectionStatus ||
                    !CVTableOK ||
                    (!CVTableValueOK & chokeOpenValueOK) ||
                    !PVTTableOK ||
                    (!PVTTableROGValueOK & pressureP1ValueOK & temperatureTValueOK) ||
                    (!PVTTableDROGDPValueOK & pressureP1ValueOK & temperatureTValueOK) ||
                    (!PVTTableDROGDTValueOK & pressureP1ValueOK & temperatureTValueOK) ||
                    (!PVTTableCPGValueOK & pressureP1ValueOK & temperatureTValueOK))
                {
                    calculatedFlow = -1;
                    calculatedFlowErr += 1;
                    calculatedFlowErrComment += "   -  GFC Configuration Err\n";
                }
                if (!chokeOpenValueOK)
                {
                    calculatedFlow = -1;
                    calculatedFlowErr += 4;
                    calculatedFlowErrComment += "   -  Choke ICV Input Err\n";
                }

                if (!pressureP1ValueOK)
                {
                    calculatedFlow = -1;
                    calculatedFlowErr += 8;
                    calculatedFlowErrComment += "   -  P1 (DPTT-2) Input Err\n";
                }

                if (!pressureP2ValueOK)
                {
                    calculatedFlow = -1;
                    calculatedFlowErr += 16;
                    calculatedFlowErrComment += "   -  P2 (DPTT-1) Input Err\n";
                }

                if (!temperatureTValueOK)
                {
                    calculatedFlow = -1;
                    calculatedFlowErr += 32;
                    calculatedFlowErrComment += "   -  T (DPTT-2) Input Err\n";
                }

                if (calculatedFlowErr == 0)
                {
                    const double gallonTom3 = 0.0037854;
                    const double psiToPa = 6894.76;
                    const double waterDensity = 999.1026;
                    double chokeFlowCoefficientConverted;
                    double combinedDensityDownstream;
                    double specificVolumeOfGasPhaseUpstream;
                    double specificVolumeOfGasPhaseDownstream;
                    double specificVolumeOfGasPhaseFactor;
                    double gasRatioOfSpecificHeats;
                    double gasRatioOfSpecificHeatsFactor;
                    double specificHeatCapacityAtConstantVolume;
                    double pressureRatio;
                    double criticalPressureRatio;
                    double polytropicExponent;

                    if ((pressureP1 >= 1) && ((pressureP1 - pressureP2) >= 1))
                    {
                        chokeFlowCoefficientConverted = (CV * gallonTom3 * Math.Sqrt(waterDensity)) / (60 * Math.Sqrt(2 * psiToPa));
                        specificVolumeOfGasPhaseUpstream = Math.Pow((densityMultiplier * ROG), (-1));
                        specificHeatCapacityAtConstantVolume = CPG - ((temperatureT + 273.15) * Math.Pow(DROGDT, 2)) / (Math.Pow((densityMultiplier * ROG), 2) * DROGDP);
                        polytropicExponent = 1 + (CPG - specificHeatCapacityAtConstantVolume) / specificHeatCapacityAtConstantVolume;
                        gasRatioOfSpecificHeats = CPG / specificHeatCapacityAtConstantVolume;
                        gasRatioOfSpecificHeatsFactor = gasRatioOfSpecificHeats / (gasRatioOfSpecificHeats - 1);
                        criticalPressureRatio = Math.Pow((gasRatioOfSpecificHeatsFactor / (gasRatioOfSpecificHeatsFactor + polytropicExponent / 2)), gasRatioOfSpecificHeatsFactor);
                        pressureRatio = pressureP2 / pressureP1;
                        if (pressureRatio <= criticalPressureRatio)
                        {
                            pressureRatio = criticalPressureRatio;
                        }
                        combinedDensityDownstream = Math.Pow((specificVolumeOfGasPhaseUpstream * Math.Pow(pressureRatio, (-1) / gasRatioOfSpecificHeats)), -1);
                        specificVolumeOfGasPhaseDownstream = specificVolumeOfGasPhaseUpstream * Math.Pow(pressureRatio, (-1) / gasRatioOfSpecificHeats);
                        specificVolumeOfGasPhaseFactor = (specificVolumeOfGasPhaseUpstream - pressureRatio * specificVolumeOfGasPhaseDownstream);
                        calculatedFlow = dischargeCoefficient * chokeFlowCoefficientConverted *
                                    Math.Pow((2 * pressureP1 * 100000 * Math.Pow(combinedDensityDownstream, 2) * gasRatioOfSpecificHeatsFactor * specificVolumeOfGasPhaseFactor), 0.5);
                    }
                    else
                    {
                        calculatedFlow = 0;
                        calculatedFlowComment = "-  Inlet Pressure (P1) or Differential Pressure (P1-P2) is < 1 bar\n";
                    }
                    
                    if (CV <= 0) 
                    {
                        calculatedFlowComment += "-  Choke CV is <= 0\n"; 
                    }

                    calculatedFlow *= 3600;  // [kg/s] -> [kg/h] 


                    if (double.IsNaN(calculatedFlow))
                    {
                        calculatedFlow = -1;
                        calculatedFlowErr += 2;
                        calculatedFlowErrComment += "   -  GFC Calculation Err\n";
                    }
                }
                if (chokeOpen >= 99.5 && chokeOpenValueOK)
                {
                    calculatedFlowErr += 64;
                    calculatedFlowErrComment += "   -  Choke Pos 100%\n";
                }

                calculatedFlowOutput = calculatedFlowErr;
                if (heartBitFlag)
                {
                    calculatedFlowOutput += 32768;
                }

                setCalculatedFlow();

                if (lblCalculationRunningText == "")
                {
                    lblCalculationRunningText = "Calculation is running ";
                }
                else
                {
                    lblCalculationRunningText += ".";
                }
                if (lblCalculationRunningText.Length > (23 + 10))
                {
                    lblCalculationRunningText = "Calculation is running .";
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Calculate Flow error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                calculatedFlow = -1;
                calculatedFlowErr += 2;
                calculatedFlowErrComment += "   -  GFC Calculation Err\n";
                if (chokeOpen >= 100 && chokeOpenValueOK)
                {
                    calculatedFlowErr += 64;
                    calculatedFlowErrComment += "   -  Choke Pos 100%\n";
                }
                calculatedFlowOutput = calculatedFlowErr;
                if (heartBitFlag)
                {
                    calculatedFlowOutput += 32768;
                }
                setCalculatedFlow();
            }
        }

        private void setCalculatedFlow(Boolean visible = true)
        //The method sets the value of Calculated Flow and Calculated Flow Error Code for HMI Overview and Calculation tabs screens
        {
            lblCalculatedFlowValueText = calculatedFlow.ToString("F2");
            lblCalculatedFlowValueVisible = visible;
            lblCalculatedFlowValue2Text = calculatedFlow.ToString("F2");
            lblCalculatedFlowValue2Visible = visible;

            lblCalculatedStatusText  = "(" + calculatedFlowErr.ToString() + ") " + Convert.ToString(calculatedFlowErr, 2);
            lblCalculatedStatus2Text = "(" + calculatedFlowErr.ToString() + ") " + Convert.ToString(calculatedFlowErr, 2);

            lblCalculationCommentText = calculatedFlowComment;

            if (calculatedFlowErr == 0)
            {
                lblCalculatedStatusVisible = false;
                lblCalculatedStatusLabelVisible = false;
                lblCalculatedStatus2Visible = false;
                lblCalculatedStatus2LabelVisible = false;
                lblCalculationErrorCodeDescriptionVisible = false;
                lblCalculationCommentVisible = true;
            }
            else
            {
                lblCalculatedStatusVisible = true;
                lblCalculatedStatusLabelVisible = true;
                lblCalculatedStatus2Visible = true;
                lblCalculatedStatus2LabelVisible = true;
                lblCalculationErrorCodeDescriptionVisible = true;
                lblCalculationErrorCodeDescriptionText = calculatedFlowErrComment;
                lblCalculationCommentVisible = false;
            }
        }

        private void setConfigurationOK() 
        //The method sets the "Configuration OK/Error" status indicator for HMI Overview tab screen
        {
            configurationOK = (OPCItemPathOK &&
                               PVTTableOK &&
                               CVTableOK);

            if (configurationOK)
            {
                lblConfigurationOK.Text = "OK";
                lblConfigurationOK.ForeColor = Color.Green;
            }
            else
            {
                lblConfigurationOK.Text = "Error";
                lblConfigurationOK.ForeColor = Color.Red;
            }
        }

        private void memoryGarbageCollector()
        //The method activates Memory Garbage Collector
        {
            garbageCollectorCounter = garbageCollectorCounterLimit;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        #endregion

        #region Methods - OPC Client
        private void getOPCServersList()
        //The method gets the actual servers list from PC (for HMI OPC Connection tab screen)
        {
            OpcServerBrowser OPCServerList = new OpcServerBrowser();
            string[] OPCServers;
            OPCServerList.GetServerList(out OPCServers);
            if (OPCServers != null)
            {
                cmbNewOPCServerName.Items.AddRange(OPCServers);
                cmbNewOPCServerName.SelectedIndex = 0;
            }
        }

        private void intitialiseDASession()
        //The method controls the process of connection to OPC Server
        {
            connectOPCServerCmd = true;
            firstConnectOPCServer = false;
            lblReadingWritingOPCItemStatusText = "";
            int rtc;
            if (OPCServer == null)
            {
                lblConnectionStatusText = "Connecting to OPC server...";
                lblConnectionStatusForeColor = "Black";
                lblConnectionStatusTimeText = DateTime.Now.ToString();
                btnConnectOPCServerEnabled = false;
                btnDisconnectOPCServerEnabled = true;
                disconnectToolStripMenuItemEnabled = true;
                connectToolStripMenuItemEnabled = false;
                cmbNewOPCServerNameEnabled = false;
                btnSetOPCServerNameEnabled = false;
                btnSelectOPCItemsFileEnabled = false;
                btnLoadPVTFileEnabled = false;
                btnSetCustomCVValuesEnabled = false;
                btnLoadCVDataFileEnabled = false;
                btnSetDischargeCoefficientEnabled = false;
                txtDischargeCoefficientEnabled = false;
                btnSetDensityMultiplierEnabled = false;
                txtDensityMultiplierEnabled = false;
                loadDefaultConfigurationToolStripMenuItemEnabled = false;
                loadOPCIthemPathsToolStripMenuItemEnabled = false;
                loadPVTFileToolStripMenuItemEnabled = false;
                loadChokeFlowCurveFileToolStripMenuItemEnabled = false;
                rdoPVTFileEnabled = false;
                autoReConnectOPCServerCounter = autoReConnectOPCServerCounterLimit;
                if (rdoPVTFile.Checked)
                {
                    rdoROGChecked = true;
                    displayPVT(PVT_ROG, "ROG");
                }

                /*
                //Disable Choke Flow Curve modification fields
                foreach (Control controlItem in this.tabChoke.Controls.OfType<TextBox>())
                {
                    if (controlItem is TextBox)
                    {
                        String ControlItemName = controlItem.Name;
                        if (ControlItemName.Contains("txtCV_"))
                        {
                            controlItem.Enabled = false;
                        }
                    }
                }
                */

                memoryGarbageCollector();
                try
                {
                    OPCServer = new OpcServer();
                    rtc = OPCServer.Connect(OPCServerName);
                    if (HRESULTS.Failed(rtc))
                    {
                        OPCServerConnectionStatus = false;
                        prgOPCServerStatusValue = Convert.ToInt32(OPCServerConnectionStatus);
                        lblConnectionStatusText = "Error " + rtc.ToString() + " at connecting to server.";
                        lblConnectionStatusForeColor = "Red";
                        lblConnectionStatusTimeText = DateTime.Now.ToString();
                        lblOPCConnectionOKText = "Error";
                        lblOPCConnectionOKForeColor = "Red";
                        OPCServer = null;
                        return;
                    }
                }
                catch (Exception)
                {
                    OPCServerConnectionStatus = false;
                    prgOPCServerStatusValue = Convert.ToInt32(OPCServerConnectionStatus);
                    lblConnectionStatusText = "Connecting to OPC server error";
                    lblConnectionStatusForeColor = "Red";
                    lblConnectionStatusTimeText = DateTime.Now.ToString();
                    lblOPCConnectionOKText = "Error";
                    lblOPCConnectionOKForeColor = "Red";
                    OPCServer = null;
                    return;
                }
                getOPCServerConnectStatus();
                if (OPCServerConnectionStatus)
                {
                    try
                    {
                        readWriteGroup = new SyncIOGroup(OPCServer);
                        for (int i = 0; i < GFCVariableLabels.Length; i++)
                        {
                            itemData[i] = readWriteGroup.Item(OPCItemPaths[i]);
                            if (itemData[i] == null)
                            {
                                readWriteGroup.Add(OPCItemPaths[i]);
                            }
                            itemData[i] = readWriteGroup.Item(OPCItemPaths[i]);
                        }
                    }
                    catch (Exception ex)
                    {
                        lblReadingWritingOPCItemStatusText = "intitialiseDASession error\n" + ex.Message;
                    }
                    pullOPCDataCmd = true;
                    startPullOPCDataThread();
                    lblProgramCycleProgressBarText = "Calculation is running ";
                }
                else
                {
                    OPCServer = null;
                }
            }
            else
            {
                lblConnectionStatusText = "Error OPCServer object is not null";
                lblConnectionStatusForeColor = "Magenta";
                lblConnectionStatusTimeText = DateTime.Now.ToString();
            }
        }

        private void terminateDASession()
        //The method controls the process of diconection from OPC Server
        {
            connectOPCServerCmd = false;
            pullOPCDataCmd = false;
            OPCServerConnectionStatus = false;
            if (OPCServer != null)
            {
                readWriteGroup.Dispose();
                OPCServer.Disconnect();
                OPCServer = null;
                lblConnectionStatusText = "Disconnected";
                lblConnectionStatusForeColor = "Red";
                lblConnectionStatusTimeText = DateTime.Now.ToString();
            }
            lblOPCConnectionOKText = "Disconnected";
            lblOPCConnectionOKForeColor = "Red";
            prgOPCServerStatusValue = Convert.ToInt32(OPCServerConnectionStatus);
            btnDisconnectOPCServerEnabled = false;
            disconnectToolStripMenuItemEnabled = false;
            btnConnectOPCServerEnabled = true;
            connectToolStripMenuItemEnabled = true;
            cmbNewOPCServerNameEnabled = true;
            btnSetOPCServerNameEnabled= true;
            btnSelectOPCItemsFileEnabled = true;
            btnLoadPVTFileEnabled = true;
            btnSetCustomCVValuesEnabled = true;
            btnLoadCVDataFileEnabled = true;
            btnSetDischargeCoefficientEnabled = true;
            txtDischargeCoefficientEnabled = true;
            btnSetDensityMultiplierEnabled = true;
            txtDensityMultiplierEnabled = true;
            loadDefaultConfigurationToolStripMenuItemEnabled = true;
            loadOPCIthemPathsToolStripMenuItemEnabled = true;
            loadPVTFileToolStripMenuItemEnabled = true;
            loadChokeFlowCurveFileToolStripMenuItemEnabled = true;
            rdoPVTFileEnabled = true;

            /*
            //Enable Choke Flow Curve modification fields
            foreach (Control controlItem in this.tabChoke.Controls.OfType<TextBox>())
            {
                if (controlItem is TextBox)
                {
                    String ControlItemName = controlItem.Name;
                    if (ControlItemName.Contains("txtCV_"))
                    {
                        controlItem.Enabled = true;
                    }
                }
            }

            */
            lblOPCRefreshText = "OPC Item Refresh Rate: " + (OPCItemsRefreshRate / 1000).ToString() + " sec ";
            lblCalculationRunningText = "";
            lblCalculatedFlowValueText = "";
            lblCalculatedFlowValue2Text = "";
            setPVTTableValues(false, false);
            setCVTableValue(false, false);
            calculatedFlowErr = 1;
            calculatedFlowErrComment = "Error Code detail description:\n   -  GFC Configuration Err";
            setCalculatedFlow(false);
            updateProcessData();
            memoryGarbageCollector();
        }

        private void selectOPCItemsFile()
        //The method opens the configuration file with OPC Item Paths
        {
            try
            {
                string fileName = string.Empty;
                openFileDialog.InitialDirectory = configFileDirectory;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FileName = configFile;
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        OPCItemsFileContent = reader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select OPC Items File error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getOPCItemPaths();
            initOPCItemListView();
            cmbNewOPCServerName.BackColor = Color.White;
        }

        private void initOPCItemListView()
        //The method sets the list of OPC Item Paths for HMI OPC Connection tab screen - initialization (only Paths)
        {
            this.lvwOPCItems.Items.Clear();
            try
            {
                this.lvwOPCItems.BeginUpdate();
                for (int i = 0; i < GFCVariableLabels.Length; i++)
                {
                    ListViewItem listViewItem = new ListViewItem(GFCVariableLabels[i]);
                    listViewItem.SubItems.Add(OPCItemPaths[i]);
                    this.lvwOPCItems.Items.Add(listViewItem);
                }
                this.lvwOPCItems.EndUpdate();
                lblActiveOPCServer.Text = OPCServerName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Initialization OPC Item List View error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateOPCItemListView()
        //The method updates the list of OPC Items Paths, Values, Qualities, etc. for HMI OPC Connection tab screen
        {
            try
            {
                this.lvwOPCItems.BeginUpdate();
                if (this.lvwOPCItems.Items.Count != GFCVariableLabels.Length)
                {
                    this.lvwOPCItems.Items.Clear();
                    for (int i = 0; i < GFCVariableLabels.Length; i++)
                    {
                        ListViewItem listViewItem = new ListViewItem(GFCVariableLabels[i]);
                        listViewItem.SubItems.Add(OPCItemPaths[i]);
                        listViewItem.SubItems.Add(OPCItemValues[i]);
                        listViewItem.SubItems.Add(OPCItemQualities[i]);
                        listViewItem.SubItems.Add(OPCItemTimeStamps[i]);
                        listViewItem.SubItems.Add(OPCItemErrors[i]);
                        this.lvwOPCItems.Items.Add(listViewItem);
                    }
                }
                else
                {
                    for (int i = 0; i < GFCVariableLabels.Length; i++)
                    {
                        ListViewItem listViewItem = new ListViewItem(GFCVariableLabels[i]);
                        listViewItem.SubItems.Add(OPCItemPaths[i]);
                        listViewItem.SubItems.Add(OPCItemValues[i]);
                        listViewItem.SubItems.Add(OPCItemQualities[i]);
                        listViewItem.SubItems.Add(OPCItemTimeStamps[i]);
                        listViewItem.SubItems.Add(OPCItemErrors[i]);
                        this.lvwOPCItems.Items[i] = listViewItem;
                    }
                }
                this.lvwOPCItems.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update OPC Item List View error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getOPCItemPaths()
        //The method imports the OPC Item Paths from configuration files
        {
            string[] tmpOPCItemPathsList = new string[8];
            OPCItemPaths = null;
            OPCServerName = "";
            OPCItemPathOK = false;
            try
            {
                using (var reader = new StringReader(OPCItemsFileContent))
                {
                    for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                    {
                        if (line.Contains("OPC Server Name:"))
                        {
                            line = line.Remove(0, line.IndexOf(":") + 1).Trim();
                            OPCServerName = line;
                        }
                        if (line.Contains("OPC Item Path"))
                        {
                            if (line.Contains("OPC Item Path " + GFCVariableLabels[0] +":"))
                            {
                                line = line.Remove(0, line.IndexOf(":") + 1).Trim();
                                tmpOPCItemPathsList[0] = line;
                            }
                            else if (line.Contains("OPC Item Path " + GFCVariableLabels[1] + ":"))
                            {
                                line = line.Remove(0, line.IndexOf(":") + 1).Trim();
                                tmpOPCItemPathsList[1] = line;
                            }
                            else if (line.Contains("OPC Item Path " + GFCVariableLabels[2] + ":"))
                            {
                                line = line.Remove(0, line.IndexOf(":") + 1).Trim();
                                tmpOPCItemPathsList[2] = line;
                            }
                            else if (line.Contains("OPC Item Path " + GFCVariableLabels[3] + ":"))
                            {
                                line = line.Remove(0, line.IndexOf(":") + 1).Trim();
                                tmpOPCItemPathsList[3] = line;
                            }
                            else if (line.Contains("OPC Item Path " + GFCVariableLabels[4] + ":"))
                            {
                                line = line.Remove(0, line.IndexOf(":") + 1).Trim();
                                tmpOPCItemPathsList[4] = line;
                            }
                            else if (line.Contains("OPC Item Path " + GFCVariableLabels[5] + ":"))
                            {
                                line = line.Remove(0, line.IndexOf(":") + 1).Trim();
                                tmpOPCItemPathsList[5] = line;
                            }
                            else if (line.Contains("OPC Item Path " + GFCVariableLabels[6] + ":"))
                            {
                                line = line.Remove(0, line.IndexOf(":") + 1).Trim();
                                tmpOPCItemPathsList[6] = line;
                            }
                            else if (line.Contains("OPC Item Path " + GFCVariableLabels[7] + ":"))
                            {
                                line = line.Remove(0, line.IndexOf(":") + 1).Trim();
                                tmpOPCItemPathsList[7] = line;
                            }
                        }
                    }
                }

                OPCItemPathOK = true;

                if (string.IsNullOrWhiteSpace(OPCServerName))
                {
                    OPCItemPathOK = false;
                    MessageBox.Show("ConfigGFC.txt error" + "\n" + "OPC Server name is not defined\n(there isn't 'OPC Server Name:' label or server name is empty)", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                OPCItemPaths = tmpOPCItemPathsList;

                if (string.IsNullOrWhiteSpace(OPCItemPaths[0]))
                {
                    OPCItemPathOK = false;
                    MessageBox.Show("ConfigGFC.txt error" + "\n" + "OPC Item Path Choke Opening is not defined\n(there isn't 'OPC Item Path Choke Opening:' label or OPC Item Path is empty)", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (string.IsNullOrWhiteSpace(OPCItemPaths[1]))
                {
                    OPCItemPathOK = false;
                    MessageBox.Show("ConfigGFC.txt error" + "\n" + "OPC Item Path P1 is not defined\n(there isn't 'OPC Item Path P1:' label \nor OPC Item Path is empty)", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(OPCItemPaths[2]))
                {
                    OPCItemPathOK = false;
                    MessageBox.Show("ConfigGFC.txt error" + "\n" + "OPC Item Path P2 is not defined\n(there isn't 'OPC Item Path P2:' label \nor OPC Item Path is empty)", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(OPCItemPaths[3]))
                {
                    OPCItemPathOK = false;
                    MessageBox.Show("ConfigGFC.txt error" + "\n" + "OPC Item Path T is not defined\n(there isn't 'OPC Item Path T:' label \nor OPC Item Path is empty)", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(OPCItemPaths[4]))
                {
                    OPCItemPathOK = false;
                    MessageBox.Show("ConfigGFC.txt error" + "\n" + "OPC Item Path Calc Flow APCA is not defined\n(there isn't 'OPC Item Path Calc Flow APCA:' label \nor OPC Item Path is empty)", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(OPCItemPaths[5]))
                {
                    OPCItemPathOK = false;
                    MessageBox.Show("ConfigGFC.txt error" + "\n" + "OPC Item Path Calc Flow APCB is not defined\n(there isn't 'OPC Item Path Calc Flow APCB:' label \nor OPC Item Path is empty)", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(OPCItemPaths[6]))
                {
                    OPCItemPathOK = false;
                    MessageBox.Show("ConfigGFC.txt error" + "\n" + "OPC Item Path Status GFC APCA is not defined\n(there isn't 'OPC Item Path Status GFC APCA:' label \nor OPC Item Path is empty)", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(OPCItemPaths[7]))
                {
                    OPCItemPathOK = false;
                    MessageBox.Show("ConfigGFC.txt error" + "\n" + "OPC Item Path Status GFC APCB is not defined\n(there isn't 'OPC Item Path Status GFC APCB:' label \nor OPC Item Path is empty)", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                setOPCItemPathsOK(OPCItemPathOK);
                setConfigurationOK();
            }
            catch (Exception ex)
            {
                OPCItemPathOK = false;
                setOPCItemPathsOK(OPCItemPathOK);
                setConfigurationOK();
                MessageBox.Show("Get OPC ItemPaths error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setOPCItemPathsOK(Boolean status)
        //The method sets the "OPC Item Paths OK/Error" for HMI OPC Connection tab screen
        {
            CVTableOK = status;
            if (status)
            {
                lblOPCItemPathStatus.Text = "OPC Item Paths OK";
                lblOPCItemPathStatus.ForeColor = Color.Green;
                btnConnectOPCServerEnabled = true;
                connectToolStripMenuItem.Enabled = true;
            }
            else
            {
                lblOPCItemPathStatus.Text = "OPC Item Paths Error";
                lblOPCItemPathStatus.ForeColor = Color.Red;
                btnConnectOPCServer.Enabled = false;
                connectToolStripMenuItem.Enabled = false;
            }
            setConfigurationOK();
        }

        private void startPullOPCDataThread()
        //The method starts OPC read/write and flow calculation cycle thread
        {
            Thread pullOPCDataThread = new Thread(new ThreadStart(pullOPCData));
            pullOPCDataThread.Start();
        }

        private void pullOPCData()
        //OPC read/write and flow calculation cycle thread
        {
            while (pullOPCDataCmd)
            {
                //GFC - PLC Hartbit
                heartBitFlag = !heartBitFlag;
                
                //OPC Connection Refresh Rate status
                if (lblOPCRefreshText.Length > (29 + 10))
                {
                    lblOPCRefreshText = "OPC Item Refresh Rate: " + (OPCItemsRefreshRate / 1000).ToString() + " sec "; ;
                }
                lblOPCRefreshText += ".";
                
                getOPCServerConnectStatus();
                if (OPCServerConnectionStatus)
                {
                    readOPCItems();
                    updateProcessData();
                    readCVTableValue();
                    readPVTTableValues();
                    calculateFlow();
                    writeOPCItems();
                    lblProgramCycleProgressBarText = "Calculation is running ";
                }

                startUpdateMainFormOPCItemListViewThread();
                Thread.Sleep(Convert.ToInt32(MainForm.OPCItemsRefreshRate));
            }
        }

        public void startUpdateMainFormOPCItemListViewThread()
        //The method starts thread update OPC List View for HMI OPC Connection tab screen
        {
            Thread threadUpdateMainFormOPCItemListView = new Thread(new ThreadStart(this.updateMainFormOPCItemListView));
            threadUpdateMainFormOPCItemListView.Start();
        }

        private void updateMainFormOPCItemListView()
        //The method updates OPC List View for HMI OPC Connection tab screen
        {
            if (lvwOPCItems.InvokeRequired)
            {
                updateMainFormOPCItemListViewCallback d = new updateMainFormOPCItemListViewCallback(updateMainFormOPCItemListView);
                this.Invoke(d);
            }
            else
            {
                 if (OPCServerConnectionStatus)
                {
                    updateOPCItemListView();
                }
            }
        }

        private void getOPCServerConnectStatus()
        //The method gets the OPC Server Connection status and sets the "OPC Connection" indicator for HMI Overview tab screen
        {
            try
            {
                OPCServerConnectionLastStatus = lblConnectionStatusText;
                SERVERSTATUS OPCServerStatus;
                int rtc = OPCServer.GetStatus(out OPCServerStatus);
                if (HRESULTS.Succeeded(rtc))
                {
                    OPCServerConnectionStatus = true;
                    prgOPCServerStatusValue = Convert.ToInt32(OPCServerConnectionStatus);
                    lblConnectionStatusText = OPCServerStatus.eServerState.ToString();
                    lblConnectionStatusForeColor = "Green";
                    lblOPCConnectionOKText = "OK";
                    lblOPCConnectionOKForeColor = "Green";
                    if (!string.Equals(OPCServerConnectionLastStatus, lblConnectionStatusText))
                    {
                        lblConnectionStatusTimeText = DateTime.Now.ToString();
                    }
                }
                else
                {
                    OPCServerConnectionStatus = false;
                    prgOPCServerStatusValue = Convert.ToInt32(OPCServerConnectionStatus);
                    lblConnectionStatusText = "Error " + rtc.ToString() + " at GetStatus.";
                    lblConnectionStatusForeColor = "Red";
                    lblOPCConnectionOKText = "Error";
                    lblOPCConnectionOKForeColor = "Red";
                    if (!string.Equals(OPCServerConnectionLastStatus, lblConnectionStatusText))
                    {
                        lblConnectionStatusTimeText = DateTime.Now.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                OPCServerConnectionStatus = false;
                prgOPCServerStatusValue = Convert.ToInt32(OPCServerConnectionStatus);
                lblConnectionStatusText = "Get OPC Server Status Error ";
                lblConnectionStatusForeColor = "Red";
                lblOPCConnectionOKText = "Error";
                lblOPCConnectionOKForeColor = "Red";
                if (!string.Equals(OPCServerConnectionLastStatus, lblConnectionStatusText))
                {
                    lblConnectionStatusTimeText = DateTime.Now.ToString();
                }

                lblReadingWritingOPCItemStatusText = "getOPCServerConnectStatus error\n" + ex.Message;
            }
        }

        private void readOPCItems()
        //The method reads OPC Items
        {
            try
            {
                OPCItemState rslt;
                OPCDATASOURCE dsrc = OPCDATASOURCE.OPC_DS_DEVICE;

                for (int i = 0; i < GFCVariableLabels.Length; i++)
                {
                    int rtc = readWriteGroup.Read(dsrc, itemData[i], out rslt);
                    if (HRESULTS.Succeeded(rtc)) // read from OPC server successful
                    {
                        if (rslt != null)
                        {
                            if (HRESULTS.Succeeded(rslt.Error)) // item read successful
                            {
                                OPCItemValues[i] = rslt.DataValue.ToString();
                                OPCItemErrors[i] = "";
                            }
                            else // the item could not be read
                            {
                                OPCItemValues[i] = "NaN";
                                OPCItemErrors[i] = readWriteGroup.GetErrorString(rslt.Error);
                            }
                            OPCItemQualities[i] = readWriteGroup.GetQualityString(rslt.Quality);
                            DateTime dt = DateTime.FromFileTime(rslt.TimeStamp);
                            OPCItemTimeStamps[i] = dt.ToString();
                        }
                    }
                    else // OPC server read error
                    {
                        OPCItemValues[i] = "-1";      // clear the previously displayed
                        OPCItemQualities[i] = "Read failed";   //     item data
                        OPCItemTimeStamps[i] = "";
                        OPCItemErrors[i] = readWriteGroup.GetErrorString(rtc);
                    }
                }
            }
            catch (Exception ex)
            {
                lblReadingWritingOPCItemStatusText = "Reading OPC Items error\n" + ex.Message;
            }
        }

        private void writeOPCItems()
        //The method writes OPC Items
        {
            try
            {
                int rtc;
                if (String.Equals(MainForm.computerName, MainForm.APCAName))
                {
                    rtc = readWriteGroup.Write(itemData[4], calculatedFlow.ToString("F2"));
                    OPCItemErrors[4] = readWriteGroup.GetErrorString(rtc);

                    rtc = readWriteGroup.Write(itemData[6], calculatedFlowOutput.ToString());
                    OPCItemErrors[6] = readWriteGroup.GetErrorString(rtc);
                }
                if (String.Equals(MainForm.computerName, MainForm.APCBName))
                {
                    rtc = readWriteGroup.Write(itemData[5], calculatedFlow.ToString("F2"));
                    OPCItemErrors[5] = readWriteGroup.GetErrorString(rtc);

                    rtc = readWriteGroup.Write(itemData[7], calculatedFlowOutput.ToString());
                    OPCItemErrors[7] = readWriteGroup.GetErrorString(rtc);
                }

            }
            catch (Exception ex)
            {
                lblReadingWritingOPCItemStatusText = "Writing OPC Items error\n" + ex.Message;
            }
        }

        #endregion

        #region MainForm Events
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to stop gas flow calculation \nand close the GFC application?", "Exit GFC", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                terminateDASession();
            }
        }

        private void loadDefaultConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to load default configuration?", "Default configuration", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                loadDefaultConfiguration();
            }
        }

        private void loadOPCIthemPathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectOPCItemsFile();
        }

        private void loadPVTFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadPVTFile();
        }

        private void loadChokeFlowCurveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadCVFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OPCServerManualDisconnected = false;
            lblConnectOPCServerCommentText = "Connected manually";
            lblConnectOPCServerCommentForeColor = "DarkGrey";
            intitialiseDASession();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OPCServerManualDisconnected = true;
            lblConnectOPCServerCommentText = "Disconnected manually";
            lblConnectOPCServerCommentForeColor = "DarkGrey";
            autoReConnectOPCServerCmd = false;
            terminateDASession();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(companyDetails + "\n\nGas Flow Calculator\n" + swVersion, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void btnSetDischargeCoefficient_Click(object sender, EventArgs e)
        {
            try
            {
                if (Double.Parse(txtDischargeCoefficient.Text) > 0)
                {
                    dischargeCoefficient = Double.Parse(txtDischargeCoefficient.Text);
                    txtDischargeCoefficient.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("Discharge Coefficient value out of range", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDischargeCoefficient.Text = dischargeCoefficient.ToString();
                    txtDischargeCoefficient.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Discharge Coefficient value error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDischargeCoefficient.Text = dischargeCoefficient.ToString();
                txtDischargeCoefficient.BackColor = Color.White;
            }
        }

        private void btnSetDensityMultiplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (Double.Parse(txtDensityMultiplier.Text) > 0)
                {
                    densityMultiplier = Double.Parse(txtDensityMultiplier.Text);
                    txtDensityMultiplier.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("Density Multiplier value out of range", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDensityMultiplier.Text = densityMultiplier.ToString();
                    txtDensityMultiplier.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Density Multiplier value error" + "\n" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDensityMultiplier.Text = densityMultiplier.ToString();
                txtDensityMultiplier.BackColor = Color.White;
            }
        }

        private void btnConnectOPCServer_Click(object sender, EventArgs e)
        {
            OPCServerManualDisconnected = false;
            lblConnectOPCServerCommentText = "Connected manually";
            lblConnectOPCServerCommentForeColor = "DarkGrey";
            intitialiseDASession();
        }

        private void btnDisconnectOPCServer_Click(object sender, EventArgs e)
        {
            OPCServerManualDisconnected = true;
            lblConnectOPCServerCommentText = "Disconnected manually";
            lblConnectOPCServerCommentForeColor = "DarkGrey";
            autoReConnectOPCServerCmd = false;
            terminateDASession();
        }

        private void btnSelectOPCItemsFile_Click(object sender, EventArgs e)
        {
            selectOPCItemsFile();
        }

        private void btnSetOPCServerName_Click(object sender, EventArgs e)
        {
            OPCServerName = cmbNewOPCServerName.Text;
            lblActiveOPCServer.Text = OPCServerName;
            cmbNewOPCServerName.BackColor = Color.White;
        }

        private void rdoROG_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoROG.Checked)
            {
                displayPVT(PVT_ROG, "ROG");
            }
        }

        private void rdoDROGDP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDROGDP.Checked)
            {
                displayPVT(PVT_DROGDP, "DROGDP");
            }
        }

        private void rdoDROGDT_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDROGDT.Checked)
            {
                displayPVT(PVT_DROGDT, "DROGDT");
            }
        }

        private void rdoCPG_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCPG.Checked)
            {
                displayPVT(PVT_CPG, "CPG");
            }
        }

        private void rdoPVTFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPVTFile.Checked)
            {
                rtxPVT.Text = "*** PVT Table ***" + "\n\n";

                using (StreamReader reader = new StreamReader(PVT_fileName))
                {
                    rtxPVT.Text += reader.ReadToEnd();
                }
            }
        }

        private void btnLoadPVTFile_Click(object sender, EventArgs e)
        {
            loadPVTFile();
        }

        private void btnSetCustomCVValues_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control controlItem in this.tabChoke.Controls.OfType<TextBox>())
                {
                    String ControlItemName = controlItem.Name;
                    if (ControlItemName.Contains("txtCV_"))
                    {
                        string CVStepNumberString = ControlItemName.Remove(0, 6);
                        int CVStepNumber;
                        CVStepNumber = int.Parse(CVStepNumberString);
                        chokeCurve[(CVStepNumber - 1)] = double.Parse(controlItem.Text);
                        chrChokeFlowCurve.Series[0].Points.DataBindY(chokeCurve);
                    }
                }
                setCVTableOKStatus(true);
                resetTxtCVBackgroundColour();
            }
            catch (FormatException fEx)
            {
                setCVTableOKStatus(false);
                MessageBox.Show("Not numeric data" + "\n" + fEx, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                setCVTableOKStatus(false);
                MessageBox.Show("Set Custom CV Values error" + "\n" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadCVDataFile_Click(object sender, EventArgs e)
        {
            loadCVFile();
        }

        private void txtDischargeCoefficient_TextChanged(object sender, EventArgs e)
        {
            txtDischargeCoefficient.BackColor = Color.Pink;
        }

        private void txtDensityMultiplier_TextChanged(object sender, EventArgs e)
        {
            txtDensityMultiplier.BackColor = Color.Pink;
        }

        private void cmbNewOPCServerName_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbNewOPCServerName.BackColor = Color.Pink;
        }

        private void txtCV_1_TextChanged(object sender, EventArgs e)
        {
            txtCV_1.BackColor = Color.Pink;
        }

        private void txtCV_2_TextChanged(object sender, EventArgs e)
        {
            txtCV_2.BackColor = Color.Pink;
        }

        private void txtCV_3_TextChanged(object sender, EventArgs e)
        {
            txtCV_3.BackColor = Color.Pink;
        }

        private void txtCV_4_TextChanged(object sender, EventArgs e)
        {
            txtCV_4.BackColor = Color.Pink;
        }

        private void txtCV_5_TextChanged(object sender, EventArgs e)
        {
            txtCV_5.BackColor = Color.Pink;
        }

        private void txtCV_6_TextChanged(object sender, EventArgs e)
        {
            txtCV_6.BackColor = Color.Pink;
        }

        private void txtCV_7_TextChanged(object sender, EventArgs e)
        {
            txtCV_7.BackColor = Color.Pink;
        }

        private void txtCV_8_TextChanged(object sender, EventArgs e)
        {
            txtCV_8.BackColor = Color.Pink;
        }

        private void txtCV_9_TextChanged(object sender, EventArgs e)
        {
            txtCV_9.BackColor = Color.Pink;
        }

        private void txtCV_10_TextChanged(object sender, EventArgs e)
        {
            txtCV_10.BackColor = Color.Pink;
        }

        private void txtCV_11_TextChanged(object sender, EventArgs e)
        {
            txtCV_11.BackColor = Color.Pink;
        }

        private void txtCV_12_TextChanged(object sender, EventArgs e)
        {
            txtCV_12.BackColor = Color.Pink;
        }

        private void txtCV_13_TextChanged(object sender, EventArgs e)
        {
            txtCV_13.BackColor = Color.Pink;
        }

        private void txtCV_14_TextChanged(object sender, EventArgs e)
        {
            txtCV_14.BackColor = Color.Pink;
        }

        private void txtCV_15_TextChanged(object sender, EventArgs e)
        {
            txtCV_15.BackColor = Color.Pink;
        }

        private void txtCV_16_TextChanged(object sender, EventArgs e)
        {
            txtCV_16.BackColor = Color.Pink;
        }

        private void txtCV_17_TextChanged(object sender, EventArgs e)
        {
            txtCV_17.BackColor = Color.Pink;
        }

        private void txtCV_18_TextChanged(object sender, EventArgs e)
        {
            txtCV_18.BackColor = Color.Pink;
        }

        private void txtCV_19_TextChanged(object sender, EventArgs e)
        {
            txtCV_19.BackColor = Color.Pink;
        }

        private void txtCV_20_TextChanged(object sender, EventArgs e)
        {
            txtCV_20.BackColor = Color.Pink;
        }

        private void txtCV_21_TextChanged(object sender, EventArgs e)
        {
            txtCV_21.BackColor = Color.Pink;
        }

        private void txtCV_22_TextChanged(object sender, EventArgs e)
        {
            txtCV_22.BackColor = Color.Pink;
        }

        private void txtCV_23_TextChanged(object sender, EventArgs e)
        {
            txtCV_23.BackColor = Color.Pink;
        }

        private void txtCV_24_TextChanged(object sender, EventArgs e)
        {
            txtCV_24.BackColor = Color.Pink;
        }

        private void txtCV_25_TextChanged(object sender, EventArgs e)
        {
            txtCV_25.BackColor = Color.Pink;
        }

        private void txtCV_26_TextChanged(object sender, EventArgs e)
        {
            txtCV_26.BackColor = Color.Pink;
        }

        private void txtCV_27_TextChanged(object sender, EventArgs e)
        {
            txtCV_27.BackColor = Color.Pink;
        }

        private void txtCV_28_TextChanged(object sender, EventArgs e)
        {
            txtCV_28.BackColor = Color.Pink;
        }

        private void txtCV_29_TextChanged(object sender, EventArgs e)
        {
            txtCV_29.BackColor = Color.Pink;
        }

        private void txtCV_30_TextChanged(object sender, EventArgs e)
        {
            txtCV_30.BackColor = Color.Pink;
        }

        private void txtCV_31_TextChanged(object sender, EventArgs e)
        {
            txtCV_31.BackColor = Color.Pink;
        }

        private void txtCV_32_TextChanged(object sender, EventArgs e)
        {
            txtCV_32.BackColor = Color.Pink;
        }

        private void txtCV_33_TextChanged(object sender, EventArgs e)
        {
            txtCV_33.BackColor = Color.Pink;
        }

        private void txtCV_34_TextChanged(object sender, EventArgs e)
        {
            txtCV_34.BackColor = Color.Pink;
        }

        private void txtCV_35_TextChanged(object sender, EventArgs e)
        {
            txtCV_35.BackColor = Color.Pink;
        }

        private void txtCV_36_TextChanged(object sender, EventArgs e)
        {
            txtCV_36.BackColor = Color.Pink;
        }

        private void txtCV_37_TextChanged(object sender, EventArgs e)
        {
            txtCV_37.BackColor = Color.Pink;
        }

        private void txtCV_38_TextChanged(object sender, EventArgs e)
        {
            txtCV_38.BackColor = Color.Pink;
        }

        private void txtCV_39_TextChanged(object sender, EventArgs e)
        {
            txtCV_39.BackColor = Color.Pink;
        }

        private void txtCV_40_TextChanged(object sender, EventArgs e)
        {
            txtCV_40.BackColor = Color.Pink;
        }

        private void txtCV_41_TextChanged(object sender, EventArgs e)
        {
            txtCV_41.BackColor = Color.Pink;
        }

        private void txtCV_42_TextChanged(object sender, EventArgs e)
        {
            txtCV_42.BackColor = Color.Pink;
        }

        private void txtCV_43_TextChanged(object sender, EventArgs e)
        {
            txtCV_43.BackColor = Color.Pink;
        }

        private void txtCV_44_TextChanged(object sender, EventArgs e)
        {
            txtCV_44.BackColor = Color.Pink;
        }

        private void txtCV_45_TextChanged(object sender, EventArgs e)
        {
            txtCV_45.BackColor = Color.Pink;
        }

        private void txtCV_46_TextChanged(object sender, EventArgs e)
        {
            txtCV_46.BackColor = Color.Pink;
        }

        private void txtCV_47_TextChanged(object sender, EventArgs e)
        {
            txtCV_47.BackColor = Color.Pink;
        }

        private void txtCV_48_TextChanged(object sender, EventArgs e)
        {
            txtCV_48.BackColor = Color.Pink;
        }

        private void txtCV_49_TextChanged(object sender, EventArgs e)
        {
            txtCV_49.BackColor = Color.Pink;
        }

        private void txtCV_50_TextChanged(object sender, EventArgs e)
        {
            txtCV_50.BackColor = Color.Pink;
        }

        private void txtCV_51_TextChanged(object sender, EventArgs e)
        {
            txtCV_51.BackColor = Color.Pink;
        }

        private void txtCV_52_TextChanged(object sender, EventArgs e)
        {
            txtCV_52.BackColor = Color.Pink;
        }

        private void txtCV_53_TextChanged(object sender, EventArgs e)
        {
            txtCV_53.BackColor = Color.Pink;
        }

        private void txtCV_54_TextChanged(object sender, EventArgs e)
        {
            txtCV_54.BackColor = Color.Pink;
        }

        private void txtCV_55_TextChanged(object sender, EventArgs e)
        {
            txtCV_55.BackColor = Color.Pink;
        }

        private void txtCV_56_TextChanged(object sender, EventArgs e)
        {
            txtCV_56.BackColor = Color.Pink;
        }

        private void txtCV_57_TextChanged(object sender, EventArgs e)
        {
            txtCV_57.BackColor = Color.Pink;
        }

        private void txtCV_58_TextChanged(object sender, EventArgs e)
        {
            txtCV_58.BackColor = Color.Pink;
        }

        private void txtCV_59_TextChanged(object sender, EventArgs e)
        {
            txtCV_59.BackColor = Color.Pink;
        }

        private void txtCV_60_TextChanged(object sender, EventArgs e)
        {
            txtCV_60.BackColor = Color.Pink;
        }

        private void txtCV_61_TextChanged(object sender, EventArgs e)
        {
            txtCV_61.BackColor = Color.Pink;
        }

        private void txtCV_62_TextChanged(object sender, EventArgs e)
        {
            txtCV_62.BackColor = Color.Pink;
        }

        private void txtCV_63_TextChanged(object sender, EventArgs e)
        {
            txtCV_63.BackColor = Color.Pink;
        }

        private void txtCV_64_TextChanged(object sender, EventArgs e)
        {
            txtCV_64.BackColor = Color.Pink;
        }

        private void txtCV_65_TextChanged(object sender, EventArgs e)
        {
            txtCV_65.BackColor = Color.Pink;
        }

        private void txtCV_66_TextChanged(object sender, EventArgs e)
        {
            txtCV_66.BackColor = Color.Pink;
        }

        private void txtCV_67_TextChanged(object sender, EventArgs e)
        {
            txtCV_67.BackColor = Color.Pink;
        }

        private void txtCV_68_TextChanged(object sender, EventArgs e)
        {
            txtCV_68.BackColor = Color.Pink;
        }

        private void txtCV_69_TextChanged(object sender, EventArgs e)
        {
            txtCV_69.BackColor = Color.Pink;
        }

        private void txtCV_70_TextChanged(object sender, EventArgs e)
        {
            txtCV_70.BackColor = Color.Pink;
        }

        private void txtCV_71_TextChanged(object sender, EventArgs e)
        {
            txtCV_71.BackColor = Color.Pink;
        }

        private void txtCV_72_TextChanged(object sender, EventArgs e)
        {
            txtCV_72.BackColor = Color.Pink;
        }

        private void txtCV_73_TextChanged(object sender, EventArgs e)
        {
            txtCV_73.BackColor = Color.Pink;
        }

        private void txtCV_74_TextChanged(object sender, EventArgs e)
        {
            txtCV_74.BackColor = Color.Pink;
        }

        private void txtCV_75_TextChanged(object sender, EventArgs e)
        {
            txtCV_75.BackColor = Color.Pink;
        }

        private void txtCV_76_TextChanged(object sender, EventArgs e)
        {
            txtCV_76.BackColor = Color.Pink;
        }

        private void txtCV_77_TextChanged(object sender, EventArgs e)
        {
            txtCV_77.BackColor = Color.Pink;
        }

        private void txtCV_78_TextChanged(object sender, EventArgs e)
        {
            txtCV_78.BackColor = Color.Pink;
        }

        private void txtCV_79_TextChanged(object sender, EventArgs e)
        {
            txtCV_79.BackColor = Color.Pink;
        }

        private void txtCV_80_TextChanged(object sender, EventArgs e)
        {
            txtCV_80.BackColor = Color.Pink;
        }

        private void txtCV_81_TextChanged(object sender, EventArgs e)
        {
            txtCV_81.BackColor = Color.Pink;
        }

        private void txtCV_82_TextChanged(object sender, EventArgs e)
        {
            txtCV_82.BackColor = Color.Pink;
        }

        private void txtCV_83_TextChanged(object sender, EventArgs e)
        {
            txtCV_83.BackColor = Color.Pink;
        }

        private void txtCV_84_TextChanged(object sender, EventArgs e)
        {
            txtCV_84.BackColor = Color.Pink;
        }

        private void txtCV_85_TextChanged(object sender, EventArgs e)
        {
            txtCV_85.BackColor = Color.Pink;
        }

        private void txtCV_86_TextChanged(object sender, EventArgs e)
        {
            txtCV_86.BackColor = Color.Pink;
        }

        private void txtCV_87_TextChanged(object sender, EventArgs e)
        {
            txtCV_87.BackColor = Color.Pink;
        }

        private void txtCV_88_TextChanged(object sender, EventArgs e)
        {
            txtCV_88.BackColor = Color.Pink;
        }

        private void txtCV_89_TextChanged(object sender, EventArgs e)
        {
            txtCV_89.BackColor = Color.Pink;
        }

        private void txtCV_90_TextChanged(object sender, EventArgs e)
        {
            txtCV_90.BackColor = Color.Pink;
        }

        private void txtCV_91_TextChanged(object sender, EventArgs e)
        {
            txtCV_91.BackColor = Color.Pink;
        }

        private void txtCV_92_TextChanged(object sender, EventArgs e)
        {
            txtCV_92.BackColor = Color.Pink;
        }

        private void txtCV_93_TextChanged(object sender, EventArgs e)
        {
            txtCV_93.BackColor = Color.Pink;
        }

        private void txtCV_94_TextChanged(object sender, EventArgs e)
        {
            txtCV_94.BackColor = Color.Pink;
        }

        private void txtCV_95_TextChanged(object sender, EventArgs e)
        {
            txtCV_95.BackColor = Color.Pink;
        }

        private void txtCV_96_TextChanged(object sender, EventArgs e)
        {
            txtCV_96.BackColor = Color.Pink;
        }

        private void txtCV_97_TextChanged(object sender, EventArgs e)
        {
            txtCV_97.BackColor = Color.Pink;
        }

        private void txtCV_98_TextChanged(object sender, EventArgs e)
        {
            txtCV_98.BackColor = Color.Pink;
        }

        private void txtCV_99_TextChanged(object sender, EventArgs e)
        {
            txtCV_99.BackColor = Color.Pink;
        }

        private void txtCV_100_TextChanged(object sender, EventArgs e)
        {
            txtCV_100.BackColor = Color.Pink;
        }
        #endregion

    }


}
