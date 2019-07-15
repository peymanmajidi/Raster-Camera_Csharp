using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModbusTCP;
using System.Runtime.InteropServices;
using Dynamsoft.Barcode;
using System.IO;
using System.Globalization;

namespace ProfilerBySSFProject
{
    public class app
    {
        public static string date;
        public static string time;
        public static string ProgramTitle;
        public static string ip_delta = "172.16.1.209";
        public static byte[] data;
        public static bool sen3 = false;
        public static bool sen4 = false;


        public static string WorkingPath = @"d:\Profiler";


        public static double GoldenWeight = 0;
        public static bool Calibrarion = false;

        public static double Weight;

        public static double Height;
        public static double Lenght;
        public static double Width;


        public static string Sensor_number_1; // Proximerty Sensors Trigers
        public static string Sensor_number_2;
        public static string Sensor_number_3;
        public static string Sensor_number_4;

        public static string Camera_LEFT_id;
        public static string Camera_BACK_id;
        public static string Camera_TOP_id;
        public static string Camera_FRONT_id;
        public static string Camera_TOP2_id;
        public static string Camera_RIGHT_id;
        public static string Camera_FARLEFT_id;
        public static string Camera_FARRIGHT_id;

        public static ModbusTCP.Master MBmaster;
        public class JFiles
        {
            public List<string> files;
        }
        public static ushort ReadStartAdr(int start)
        {
            try
            {
                return Convert.ToUInt16(start);
            }
            catch
            {




            }
            return 0;

        }


        public static void Generate(int address, int size = 100)
        {
            try
            {
                app.MBmaster.ReadHoldingRegister(0, 3, (ushort)address, (ushort)size);

            }
            catch { }


        }




        public static void WriteOnRegister(ushort StartAddress, byte data)
        {
            try
            {
                byte[] data2 = { 0, data };
                MBmaster.WriteSingleRegister(3, 0, StartAddress, data2);
                app.data = data2;
                ShowAs();
            }
            catch
            {


            }
        }


        public static string registerValue = null;


        public static void ShowAs()
        {
            try
            {

                //  MessageBox.Show("Test");

                bool[] bits = new bool[1];
                int[] word = new int[1];

                // Convert data to selected data type

                if (data.Length <= 2) return;

                word = new int[data.Length / 2];

                for (int x = 0; x < data.Length; x = x + 2)
                {
                    word[x / 2] = data[x] * 256 + data[x + 1];
                }


                // Width   {----------------------}
                double a = (double)word[2] / 3.11; // 535
                double b = (double)word[4] / 3.11; // 405
                double c = 1220; // عرض کانوایر
                double temp = app.Width;
                double w = ((c - (a + b)) / 10.0)+27;
                if (w < 2) w = 0;
                app.Width = Math.Round(w);

                if (app.Width == 0) app.Width = temp;
                //----------------------------------



                // Height   {----------------------}
                app.Height = word[0];

                app.Height = Math.Round((710 - app.Height) / 10.0);
                if (app.Height < 2) app.Height = 0;

                //----------------------------------



                // Lenght   {----------------------}
                //  if(app.Lenght!=0)
                temp = app.Lenght;
                app.Lenght = Math.Round((word[40] / 19.2));
                if (app.Lenght <= 0)
                    app.Lenght = temp;
                //----------------------------------



                // Weight   {----------------------}
                int sWeight = word[64]; // 880
                app.Weight = sWeight;
                if (app.Weight > 60000) app.Weight = 100;

                // app.Weight = Math.Round( ( double ) ( ( short ) sWeight ) * 10 );
                //---------------------------j-------


                app.Sensor_number_1 = (word[26]).ToString();// 842
                app.Sensor_number_2 = (word[28]).ToString();// 844
                app.Sensor_number_3 = (word[30]).ToString();// 846
                app.Sensor_number_4 = (word[32]).ToString();// 848

                //880


                app.readTime = word[36].ToString();
                app.readTime = word[36].ToString();

                //  Damper();  // sensors

            }
            catch
            {


            }




        }



        public static string dateToDayMonth(string input_date)  // "تابع تبدیل تاریخ به فرمت "روز از هفته و ماه و سال
        {
            try
            {

                string date = input_date;
                string[] today = date.Split('/');
                string Year = today[0];
                string Month = today[1];
                string Day = today[2];




                System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
                DateTime todayDateTime = DateTime.Now;



                System.Globalization.PersianCalendar x = new System.Globalization.PersianCalendar();
                DateTime dt = x.ToDateTime(Convert.ToInt16(Year), Convert.ToInt16(Month), Convert.ToInt16(Day), 0, 0, 0, 0);
                int WeekOfYear = x.GetWeekOfYear(dt, CalendarWeekRule.FirstDay, 0);
                string DayOfWeek1 = x.GetDayOfWeek(dt).ToString();
                string MonthOfYear = x.GetMonth(dt).ToString();

                switch (MonthOfYear)
                {
                    case "1": { MonthOfYear = "فروردین"; }; break;
                    case "2": { MonthOfYear = "اردیبهشت"; }; break;
                    case "3": { MonthOfYear = "خرداد"; }; break;
                    case "4": { MonthOfYear = "تیر"; }; break;
                    case "5": { MonthOfYear = "مرداد"; }; break;
                    case "6": { MonthOfYear = "شهریور"; }; break;
                    case "7": { MonthOfYear = "مهر"; }; break;
                    case "8": { MonthOfYear = "آبان"; }; break;
                    case "9": { MonthOfYear = "آذر"; }; break;
                    case "10": { MonthOfYear = "دی"; }; break;
                    case "11": { MonthOfYear = "بهمن"; }; break;
                    case "12": { MonthOfYear = "اسفند"; }; break;
                }
                switch (DayOfWeek1)
                {
                    case "Saturday": { DayOfWeek1 = "شنبه"; }; break;
                    case "Sunday": { DayOfWeek1 = "یکشنبه"; }; break;
                    case "Monday": { DayOfWeek1 = "دوشنبه"; }; break;
                    case "Tuesday": { DayOfWeek1 = "سه شنبه"; }; break;
                    case "Wednesday": { DayOfWeek1 = "چهارشنبه"; }; break;
                    case "Thursday": { DayOfWeek1 = "پنجشنبه"; }; break;
                    case "Friday": { DayOfWeek1 = "جمعه"; }; break;
                }
                return DayOfWeek1 + "  " + Day + "  " + MonthOfYear + "  " + Year;
            }
            catch { }
            return "[ تاریخ وارد شده نا معتبر ]";
        } // پایان تابع 


        public static void MBmaster_OnResponseData(ushort ID, byte unit, byte function, byte[] values)
        {
            // MessageBox.Show(ID + " " + unit + function + values.ToString());
            data = values;
            ShowAs();
        }



        public static bool isMAHEX(string result)
        {
            if (result.Length == 12)
            {
                double n;
                try
                {
                    bool isNumeric = Double.TryParse(result.ToString(), out n);

                    return true;


                }
                catch { }
            }
            return false;

        }




        public static string ScanBarcode(string path, bool mahexOnly = false)
        {

            BarcodeReader reader = new BarcodeReader();
            reader.LicenseKeys = "24AB63ECC25BD30EDAFE8339E5C36149";


            try
            {

                BarcodeResult[] results = reader.DecodeFile(path);
                if (results == null)
                {

                    return null;
                }
                string mahex = null;
                string Barcodes = null;

                for (int i = 0; i < results.Length; ++i)
                {
                    ///fakedate();
                    BarcodeResult barcode = results[i];
                    if (barcode.BarcodeText.Length <= 50)
                    {
                        Barcodes += barcode.BarcodeText + "\n";
                        if (isMAHEX(barcode.BarcodeText))
                            mahex = barcode.BarcodeText;
                    }
                    else
                    {
                        Barcodes = "BAR-ERR";
                    }
                }



                if (mahexOnly)
                    return mahex;

                return Barcodes;

            }
            catch
            {

                return null;
            }

        }







        public static bool Delta = false;
        public static string readTime;

        public static void DeltaConnect()
        {
                app.Delta = true;
            return;

            try
            {
                MBmaster = new Master(app.ip_delta, 502);
                MBmaster.OnResponseData += new ModbusTCP.Master.ResponseData(MBmaster_OnResponseData);
                app.WriteOnRegister(6118, 1);

            }
            catch
            {
                app.Delta = false;
                if (MessageBox.Show("Error in Connecting PLC-Delta\n\nContact SSF Groups\n+98 9370047967 P.Majidi", "Fatal Error - PLC", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    DeltaConnect();



            }





        }


        public static void SystemError(string str)
        {
            MessageBox.Show(str, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void StartUp()
        {

            again:
            try
            {
                ProfilerDBDataContext dbTest = new ProfilerDBDataContext();
                app.ProgramTitle = dbTest.SetupTBLs.Select(x => x.title).Single();

            }
            catch
            {
                // app.SystemError("Unable To Read Database.\ncontact SSF Group");
                if (MessageBox.Show("Unable To Read Database.\n\nContact SSF Group\n+98 9370047967 P.Majidi", "Fatal Error - Database", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    app.StartUp();
                Application.Exit();
            }


            ProfilerDBDataContext db = new ProfilerDBDataContext();
            app.ProgramTitle = db.SetupTBLs.Select(x => x.title).Single();
            app.WorkingPath = db.SetupTBLs.Single().path;
            app.Camera_LEFT_id = db.SetupTBLs.Single().camLEFT;
            app.Camera_BACK_id = db.SetupTBLs.Single().camBACK;
            app.Camera_TOP_id = db.SetupTBLs.Single().camTOP;
            app.Camera_FRONT_id = db.SetupTBLs.Single().camFRONT;
            app.Camera_TOP2_id = db.SetupTBLs.Single().camTOP2;
            app.Camera_RIGHT_id = db.SetupTBLs.Single().camRIGHT;
            app.Camera_FARLEFT_id = db.SetupTBLs.Single().camFARLEFT;
            app.Camera_FARRIGHT_id = db.SetupTBLs.Single().camFARRIGHT;


            try
            {
                if (!Directory.Exists(app.WorkingPath))
                {
                    Directory.CreateDirectory(app.WorkingPath);
                }
            }
            catch
            {
                app.SystemError("Invalid Address \"+" + app.WorkingPath + "\"\n\nContact SSF Group");
                Application.Exit();

            }

            app.refreshEverySec();
        }

        public static void refreshEverySec()
        {
            app.time = DateTime.Now.ToString("HH:mm:ss");
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();

            DateTime todayDateTime = DateTime.Now;
            app.date = pc.GetYear(todayDateTime) + "/" + (pc.GetMonth(todayDateTime).ToString().Length == 1 ? "0" : "") + pc.GetMonth(todayDateTime) + "/" + (pc.GetDayOfMonth(todayDateTime).ToString().Length == 1 ? "0" : "") + pc.GetDayOfMonth(todayDateTime);
        }


    }
}
