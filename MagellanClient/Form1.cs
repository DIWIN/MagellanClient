using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;

namespace MagellanClient
{
    public partial class Form1 : Form
    {
        #region Members

        Magellan2.IOleMagellan _iMagellan;
        //RdrOleDll4.IOleReaderServer _iReaderServer;
        dynamic _iReaderServer;
        //RdrOleDll4.IOleInstrument _iInstrument;
        dynamic _iInstrument;
        Magellan2.IOleWorkspace _iWorkspace;
        string _DeviceName = "Sunrise"; //"Infinite Series" // "ConnectDotNet:NAME=SPARK10M_(LUM_ENH):Instrument1";
        string _Language = "";
        bool _StopFlag = false;

        #endregion

        public Form1()
        {
            InitializeComponent();
            comboBox_DeviceName.SelectedIndex = 0;
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            _iMagellan = new Magellan2.Application();
            Debug.Assert(_iMagellan != null);
            richTextBox_Output.AppendText("iMagellan: " + _iMagellan + "\n");
            richTextBox_Output.AppendText("iMagellan Version: " + _iMagellan.ServerVersion + "\n");
            _Language = _iMagellan.Language;
            richTextBox_Output.AppendText("iMagellan Language: " + _Language + "\n");
            richTextBox_Output.AppendText("Set Language to english\n");
            _iMagellan.Language = "enu";
            richTextBox_Output.AppendText("iMagellan Language: " + _iMagellan.Language + "\n");

            bool loginOk = _iMagellan.Login(textBox_Login.Text, textBox_Pwd.Text, 1);
            richTextBox_Output.AppendText("iMagellan Login successful? " + (loginOk ? "Yes" : "No (or user amdinistration not enabled)") + "\n");

            _iReaderServer = _iMagellan.CreateRdrOleObject();
            Debug.Assert((_iReaderServer as Object) != null);
            richTextBox_Output.AppendText("iReaderServer: " + _iReaderServer + "\n");
            richTextBox_Output.AppendText("iReaderServer: ServerVersion = " + _iReaderServer.ServerVersion + "\n");
        }

        private void button_Name_Click(object sender, EventArgs e)
        {
            _DeviceName = comboBox_DeviceName.Text;
            richTextBox_Output.AppendText("Device Name = " + _DeviceName + "\n");
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            _iReaderServer.InstrumentName = _DeviceName;    //"Sunrise"; //"Infinite Series";
            _iReaderServer.CommType = 1; // 1 == Simulate
            _iInstrument = _iReaderServer.CreateInstrumentObject();
            Debug.Assert((_iInstrument as Object) != null);
            _iMagellan.InstrumentObject = _iInstrument;
            richTextBox_Output.AppendText("iInstrument: " + _iInstrument + "\n");
            richTextBox_Output.AppendText("iInstrument: InstrumentName = " + _iInstrument.InstrumentName + "\n");
            _iInstrument.PlateInOut = "Out";
            richTextBox_Output.AppendText("iInstrument: Plate=" + _iInstrument.PlateInOut + "\n");
            _iWorkspace = _iMagellan.CreateWorkspaceObject();
            Debug.Assert(_iWorkspace != null);
            richTextBox_Output.AppendText("iWorkspace: " + _iWorkspace + "\n");
            richTextBox_Output.AppendText("iWorkspace: DocumentVersion = " + _iWorkspace.DocumentVersion + "\n");
            textBox_Filename.Text = "C:\\Temp\\Test\\test-pre-run-2_.wsp";

            //RdrOleDll4.OleInstrument instr = _iMagellan.InstrumentObject;
            //instr.DialogLampControl();
            //instr.DialogMovements();
            //instr.DialogOptions();
            //instr.DialogTemperatureControl();
            //instr.DialogDefineFilters();
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            comboBox_Methods.Items.Clear();
            richTextBox_Output.Clear();
            richTextBox_Output.AppendText("Set back to Language: " + _Language + "\n");
            _iMagellan.Language = _Language;
            _iMagellan = null;
            GC.Collect();
        }

        private void button_AvailableMethods_Click(object sender, EventArgs e)
        {
            string sMethods = _iMagellan.AvailableMethodFiles(_iInstrument.InstrumentName);
            string [] sMethodsArray = sMethods.Split('\t');
            richTextBox_Output.AppendText("Available Methods = ");
            comboBox_Methods.Items.Clear();
            foreach (string s in sMethodsArray)
            {
                comboBox_Methods.Items.Add(s);
                richTextBox_Output.AppendText(s + ", ");
            }
            if (comboBox_Methods.Items.Count > 0)
            {
                comboBox_Methods.SelectedIndex = 0;
            }
            richTextBox_Output.AppendText("\n");
        }

        private void button_SetEmpty_Click(object sender, EventArgs e)
        {
            _iWorkspace.Empty = true;
        }

        private void button_InsertMethod_Click(object sender, EventArgs e)
        {
            _iWorkspace.LoadedMethod = "";
            string sMethod = comboBox_Methods.SelectedItem.ToString();
            //sMethod = @"\\DESKTOP-DD8N3LI\Test\Method1_.mth";
            if (!string.IsNullOrEmpty(sMethod))
            {
                bool bOk = _iWorkspace.InsertMethod(sMethod);
                richTextBox_Output.AppendText("iWorkspace: InsertMethod (" + sMethod + ") = " + bOk + "\n");
            }
            //richTextBox_Output.AppendText("iWorkspace: InsertedMethod (" + _iWorkspace.LoadedMethod + ")\n");
        }

        private void button_ResetLastError_Click(object sender, EventArgs e)
        {
            _iInstrument.ResetLastError();
        }

        private void button_GetLastError_Click(object sender, EventArgs e)
        {
            richTextBox_Output.AppendText("Last error = " + _iInstrument.GetLastError() + "\n");
        }

        private void button_PlateOut_Click(object sender, EventArgs e)
        {
            richTextBox_Output.AppendText("Send plate out\n");
            _iMagellan.InstrumentObject.PlateInOut = "Out";
            Debug.WriteLine("Plate is: " + (_iInstrument.PlateInOut as string));
        }

        private void button_PlateIn_Click(object sender, EventArgs e)
        {
            richTextBox_Output.AppendText("Send plate in\n");
            _iInstrument.PlateInOut = "In";
        }

        private void button_SetFileName_Click(object sender, EventArgs e)
        {
            _iWorkspace.FileName = textBox_Filename.Text;
            richTextBox_Output.AppendText("iWorkspace: Filename = " + _iWorkspace.FileName + "\n");
        }

        private void button_StartRun_Click(object sender, EventArgs e)
        {
            richTextBox_Output.AppendText("iWorkspace: Start Run\n");

            _iWorkspace.ErrorProtocol = null;
            string sMethod = _iWorkspace.LoadedMethod;
            richTextBox_Output.AppendText("iWorkspace: Method = " + sMethod + "\n");
            string sFileName = _iWorkspace.FileName;
            richTextBox_Output.AppendText("iWorkspace: FileName = " + sFileName + "\n");

            //int nRuntime = _iWorkspace.ExpectedRunTime;
            //_iWorkspace.MovePlateOutAfterMeasurement = 1;
            bool bOk = _iWorkspace.StartRun();
            richTextBox_Output.AppendText("iWorkspace: Start Run = " + bOk + "\n");
            try
            {
                while (!_StopFlag && _iWorkspace.Status < 1)
                {
                    richTextBox_Output.AppendText(".");
                    Thread.Sleep(100);
                    Application.DoEvents();
                }
                if (!_StopFlag)
                {
                    richTextBox_Output.AppendText("iWorkspace: Run finished with status: " + _iWorkspace.Status + "\n");
                    richTextBox_Output.AppendText("iWorkspace: Run status = " + GetRunStatusAsText(_iWorkspace.Status) + "\n");
                    richTextBox_Output.AppendText("iWorkspace: Run error protocol = " + _iWorkspace.ErrorProtocol + "\n");
                }
                else
                {
                    richTextBox_Output.AppendText("iWorkspace: Run stopped!\n");
                }
            }
            catch (COMException ex)
            {
                richTextBox_Output.AppendText("iWorkspace: Run exception = " + ex.Message);
            }
            catch (System.Reflection.TargetInvocationException ex2)
            {
                richTextBox_Output.AppendText("iWorkspace: Run exception = " + ex2.Message);
            }
        }

        private async void button_StopRun_Click(object sender, EventArgs e)
        {
            //RdrOleDll4.IOleInstrument inst = _iMagellan.InstrumentObject;
            //RdrOleDll4.IOleReaderServer reader = _iMagellan.RdrOleObject;
            //dynamic x = inst.CreateMeasurementObject();
            //x.StopMeasurement();
            //_iInstrument.CreateMeasurementObject().StopMeasurement();
            _StopFlag = true;
            richTextBox_Output.AppendText("iWorkspace: StopRun\n");
            int n = 10;
            while (n > 0)
            {
                Application.DoEvents();
                Thread.Sleep(100);
                n--;
            }
            //RdrOleDll4.IOleReaderServer _iReaderServer2 = _iReaderServer;
            //RdrOleDll4.IOleInstrument _iInstrument2 = _iInstrument;

            //_iWorkspace = null;
            //_iInstrument = null;
            //_iReaderServer = null;

            _iMagellan = null; // Release Magellan application object
            richTextBox_Output.AppendText("iWorkspace: StopRun --> objects destroyed\n");
            // Wait 5 seconds for COM-object to be released
            // Ok, the following method of "waiting" is ugly, but you can do better :-)
            n = 50;
            while (n > 0)
            {
                Application.DoEvents();
                Thread.Sleep(100);
                n--;
            }
            GC.Collect(); // Collect the pieces and clean the memory
            richTextBox_Output.AppendText("iWorkspace: StopRun --> create new magellan\n");
            // Create everything new ...
            _iMagellan = new Magellan2.Application();
            // bool loginOk = _iMagellan.Login(textBox_Login.Text, textBox_Pwd.Text, 1);
            _iReaderServer = _iMagellan.CreateRdrOleObject();
            _iReaderServer.InstrumentName = _DeviceName;
            _iReaderServer.CommType = 1; // 1 == Simulate
            _iInstrument = _iReaderServer.CreateInstrumentObject();
            _iMagellan.InstrumentObject = _iInstrument;
            _iWorkspace = _iMagellan.CreateWorkspaceObject();
            // Ok, ready to proceed
            richTextBox_Output.AppendText("iWorkspace: StopRun --> Finished\n");

            _StopFlag = false;
        }

        private string GetRunStatusAsText(int nStatus)
        {
            string sStatus = "Run is active";
            switch (nStatus)
            {
                case 1:
                    sStatus = "Run finished successfully";
                    break;
                case 2:
                    sStatus = "Run finished not successfully";
                    break;
                case 3:
                    sStatus = "No raw data available";
                    break;
                case 4:
                    sStatus = "Validation failed";
                    break;
                case 5:
                    sStatus = "Not monotone standard curve";
                    break;
                case 6:
                    sStatus = "Validation failed and not monotone standard curve";
                    break;
                case 7:
                    sStatus = "Control moved";
                    break;
                case 8:
                    sStatus = "Control moved and validation failed";
                    break;
                case 9:
                    sStatus = "Control moved and standard curve not monotone";
                    break;
                case 10:
                    sStatus = "Control moved and validation failed and standard curve not monotone";
                    break;
                default:
                    sStatus = "Unknown";
                    break;
            }
            return sStatus;
        }

        private void button_DataExport_Click(object sender, EventArgs e)
        {
            bool bOk = _iWorkspace.AutomatedDataHandling();
            richTextBox_Output.AppendText("iWorkspace: Automated Data Handling = " + bOk + "\n");

            string sMp = _iWorkspace.GetMeasurementParameters(0);
            string coll = _iWorkspace.CollectionNames;
            string measParam = _iWorkspace.DataAsCollection("Measurement parameters");
        }

        private void button_SaveWorkspace_Click(object sender, EventArgs e)
        {
            bool bOk = _iWorkspace.DoSerialization(1);
            richTextBox_Output.AppendText("iWorkspace: Save Workspace = " + bOk + "\n");
            richTextBox_Output.AppendText("iWorkspace: Save Workspace error protocol = " + _iWorkspace.ErrorProtocol + "\n");
        }

        private void button_DataNames_Click(object sender, EventArgs e)
        {
            string sNames = _iWorkspace.DataNames;
            richTextBox_Output.AppendText("iWorkspace: Data names = " + sNames + "\n");
            string[] sDataArray = sNames.Split('\t');
            richTextBox_Output.AppendText("Available output names = ");
            comboBox_DataNames.Items.Clear();
            foreach (string s in sDataArray)
            {
                comboBox_DataNames.Items.Add(s);
                richTextBox_Output.AppendText(s + ", ");
            }
            if (comboBox_DataNames.Items.Count > 0)
            {
                comboBox_DataNames.SelectedIndex = 0;
            }
            richTextBox_Output.AppendText("\n");

        }

        private void button_DataAsTable_Click(object sender, EventArgs e)
        {
            string sDataAsTable = _iWorkspace.DataAsTable(comboBox_DataNames.Text, 0);
            richTextBox_Output.AppendText(sDataAsTable + "\n");
        }

        private void button_ModifyLayout_Click(object sender, EventArgs e)
        {
            //string s1 = "NC1\tA1\tneg1\t0\nNC1\tA2\tneg2\t0\n";
            //string s2 = "PC1\tB1\tpos1\t0\nPC1\tB2\tpos2\t0\n";
            //string s3 = "SM1_1\tC1\tsm11\t0\nSM1_1\tC2\tsm12\t0\nSM1_1\tD1\tsm13\t0\nSM1_1\tD2\tsm14\t0\n";
            //string s4 = "SM1_2\tE1\tsm21\t0\nSM1_2\tE2\tsm22\t0\nSM1_2\tF1\tsm23\t0\nSM1_2\tF2\tsm24\t0\n";
            //string s5 = "SM1_3\tG1\tsm31\t0\nSM1_3\tG2\tsm32\t0\nSM1_3\tH1\tsm33\t0\nSM1_3\tH2\tsm34\t0\n";
            //string sNewLayout = s1 + s2 + s3 + s4 + s5;
            string sNewLayout = "";
            StreamReader reader = File.OpenText("Layout.txt");
            sNewLayout = reader.ReadToEnd();

            bool bOk = _iWorkspace.ModifyLayout(sNewLayout);
            richTextBox_Output.AppendText("iWorkspace: ModifyLayout = " + bOk + "\n");
            richTextBox_Output.AppendText("iWorkspace: ModifyLayouts error protocol = " + _iWorkspace.ErrorProtocol + "\n");
        }

        private void button_Samples_Click(object sender, EventArgs e)
        {
            bool bOk = _iWorkspace.InsertSampleIDs(@"C:\Temp\Test.tpl", 1);
            richTextBox_Output.AppendText("iWorkspace: Insert Sample ID´s = " + bOk + "\n");
            richTextBox_Output.AppendText("iWorkspace: Insert Sample ID´s error protocol = " + _iWorkspace.ErrorProtocol + "\n");
        }

        private void button_SaveStandards_Click(object sender, EventArgs e)
        {
            string sReturn = "iWorkspace: SaveStandards returned -> ";
            string sFileName = textBox_FilePath.Text;
            string sFileRemark = textBox_FileRemark.Text;
            string sAuditTrailComment = textBox_AuditTrailComment.Text;
            short nExpGrp = (short)numericUpDown_ExpGrp.Value;
            int iResult = -10;
            iResult = _iWorkspace.SaveStandardsToFile(nExpGrp, sFileName, sFileRemark, sAuditTrailComment);
            switch (iResult)
            {
                case 1:
                    sReturn += "Ok";
                    break;
                case -1:
                    sReturn += "Path string must not contain #";
                    break;
                case -2:
                    sReturn += "Unsufficient Magellan user rights";
                    break;
                case -3:
                    sReturn += "No curve points available";
                    break;
                case -4:
                    sReturn += "Experimental group out of range";
                    break;
                case -5:
                    sReturn += "CurveFitOle object is null";
                    break;
                case -6:
                    sReturn += "Exception occured -->";
                    sReturn += _iWorkspace.ErrorProtocol;
                    break;
                case -7:
                    sReturn += "Filename must not be empty";
                    break;
                default:
                    sReturn = "Unknown";
                    break;
            }
            richTextBox_Output.AppendText(sReturn + "\n");
        }

        private void button_StandardFileLocation_Click(object sender, EventArgs e)
        {
            string sInitialPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            sInitialPath = Path.Combine(sInitialPath, "Tecan", "Magellan", "wsp");
            saveFileDialogStandards.InitialDirectory = sInitialPath;
            DialogResult result = saveFileDialogStandards.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string sPath = saveFileDialogStandards.FileName;
                textBox_FilePath.Text = sPath;
            }
        }

        private void label_ExpGrp_Click(object sender, EventArgs e)
        {

        }

        private void button_TestForEVO_Click(object sender, EventArgs e)
        {
            string sMethod = comboBox_Methods.Text;
            string sWsp = "NotFound";
            if (!string.IsNullOrEmpty(sMethod))
            {
                sWsp = sMethod.Substring(0, sMethod.LastIndexOf('.'));
            }
            _iWorkspace.FileName = sWsp;
            bool bOk = _iWorkspace.DoSerialization(0);
            richTextBox_Output.AppendText("Workspace loaded (" + sWsp + ") = " + bOk + "\n");
        }

        private void button_OpenLastWorkspace_Click(object sender, EventArgs e)
        {
            string[,] arr1 = PrintRawData();
 
            string sName = _iWorkspace.FileName;
            bool bOk = _iWorkspace.DoSerialization(0);
            richTextBox_Output.AppendText("Workspace loaded (" + sName + ") = " + bOk + "\n");

            //string[,] arr2 = PrintRawData();
            //PrintDifferences(arr1, arr2);

            _iWorkspace.SetComment(0, "Das ist die Überschrift\tund das ist der Text vom ersten Kommentar");
            _iWorkspace.SetComment(1, "Das ist die nächste Überschrift\tund das ist der Text vom zweiten Kommentar");

            button_SaveWorkspace_Click(sender, e);
        }
       
        private void PrintDifferences(string[,] arr1, string[,] arr2)
        {
            richTextBox_Output.AppendText("Differences:\n");
            for (int k = 0; k < 8; k++)
            {
                for (int l = 0; l < 12; l++)
                {
                    string eins = arr1[k, l];
                    string zwei = arr2[k, l];
                    if (eins != zwei)
                    {
                        richTextBox_Output.AppendText((k+1) + ":" + (l + 1).ToString("D2") + "\t" + "Vorher:" + eins + "\tNachher:" + zwei + "\n");
                    }
                }
            }
        }

        private string[,] PrintRawData()
        {
            string sDataAsTable = _iWorkspace.DataAsTable("Raw data", 0);
            //richTextBox_Output.AppendText(sDataAsTable + "\n");

            string[,] arr = new string[8, 12];
            string[] lines = sDataAsTable.Split('\r');
            for (int i = 0; i < lines.Length; i++)
            {
                if (i > 0)
                {
                    string[] elems = lines[i].Split('\t');
                    for (int j = 0; j < elems.Length; j++)
                    {
                        if (j > 0)
                        {
                            string neu = elems[j].Replace('~', ' ');
                            neu = neu.Trim();
                            arr[i - 1, j - 1] = neu;
                        }
                    }
                }
            }
            for (int k = 0; k < 8; k++)
            {
                for (int l = 0; l < 12; l++)
                {
                    richTextBox_Output.AppendText(arr[k, l] + "\t");
                }
                richTextBox_Output.AppendText("\n");
            }
            return arr;
        }

        private void button_StdEx_Click(object sender, EventArgs e)
        {
            // Available in Magellan Pro 7.4 (will cause exception when used with earlier versions)
            string pathandfilename = textBox_Filename.Text;
            string dir = Path.GetDirectoryName(pathandfilename);
            dynamic work = _iWorkspace;
            // Set dir to "" to use magellan standard folder (e.g.: C:\Users\Public\Documents\Tecan\Magellan Pro\std)
            int result = work.SaveStandardsToFileEx("");// dir);
            richTextBox_Output.AppendText("Result SaveStandardsToFileEx: " + result + "\n");
            // Result-Codes:
            // 1 == Good
            // -1 == No standards in layout
            // -2 == NOT USED
            // -3 == Given directory non-existent
            // -4 == NOT USED
            // -5 == No curve fit defined
            // -6 == Exception saving standard curve data to file (.std)
            // -7 == Exception saving bitmap file (.bmp)
            // -8 == NOT USED
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Available in Magellan Pro 7.4 (will cause exception when used with earlier versions)
            string pathandfilename = textBox_Filename.Text;
            string dir = Path.GetDirectoryName(pathandfilename);
            dynamic work = _iWorkspace;
            // Set dir to "" to use magellan standard folder (e.g.: C:\Users\Public\Documents\Tecan\Magellan Pro\std)
            int result = work.UpdateStandardsFromFileEx("");// dir);
            richTextBox_Output.AppendText("Result UpdateStandardsFromFileEx: " + result + "\n");
            // Result-Codes:
            //  1 == All Good
            //  2 == Layout already has standards defined
            // -1 == More than one experimental group defined, only one supported
            // -2 == NOT USED
            // -3 == No external standard curve defined in method
            // -4 == Given directory non-existent
            // -5 == The requested file does not exist in the given directory
            // -6 == Instrument not supported (F500, M1000)
            // -7 == Instrument serial numbers different
            // -8 == Invalid hardware Id (HUID), file from another computer
            // -9 == Exception while reading standard file (.std)
            // -10== Multilabel measurements not supported
            // -11== Measurement mode not supported (lumi, FP)
            // -12== Filter mismatch (type, wavelength, bandwidth)
            // -13== Target meas. params must not have optimal gain or ZPos
            // -14== NOT USED
            // -15== Mirror type not equal
            // -16== Reading Mode (Top, Bottom) not equal

            // Additionally update export settings and use Tecan-defaults
            result = work.UpdateExportFormat("");
            //  1 == All Good
            // -1 == Unable to set new export settings
            richTextBox_Output.AppendText("Result UpdateExportFormat: " + result + "\n");
        }
    }
}