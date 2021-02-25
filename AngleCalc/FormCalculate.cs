using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace Test_Application
{
    public partial class FormCalculate : Form
    {
        string inputData = null;
        string databaseName = "Calculate log";
   
        double convertInputData = 0;
        bool[] radioState = new bool[3];
        private double radianData = 0;
        private double smallDivideAngleData = 0;
        private double degriesData = 0;
        private double distanceData = 0;
      //  private double heightData = 0;
        private double angleFieldData =0;

        private string sdaOutputData = null;
        private string radOutputData = null;
        private string degOutputData = null;
        private string legOutputData = null;
        private string heightOutputData = null;
             
        private double convertDistInputData;
        private double convertHeightInputData;

        private string inputDistData = "0";
        private string inputHeightData = "0";
        private string angleFieldOutputData;

        Calculate calculate = new Calculate();


        public FormCalculate()
        {
            InitializeComponent();
            Text = "Калькулятор углов";
            this.BackColor = Color.GhostWhite;
            this.ForeColor = Color.Black;
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
            this.BackgroundImage = AngleCalc.Properties.Resources.Wind_coolers;                  
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

       
        private void FormCalculate_Load(object sender, EventArgs e)
        {
      
        }

        private void RadiansLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 Радиан = 180/Пи, Град.");
        }

        private void Degries_Label_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 градус = Пи/180, Радиан");
        }
        private void SmallDivideAngleLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 мду = 0,06, Град.");
        }


        /// <summary>
        /// Поле ввода данных для Радиан.
        /// </summary>

        private void RadianBox_TextChanged(object sender, EventArgs e)
        {
            inputData = radianBox.Text;

            if(radianRadio.Checked)
            {
                Calculator(inputData, radianRadio);
                degriesBox.Text = degOutputData;
                smallDivideAngleBox.Text = sdaOutputData;
            }
            
        }

        /// <summary>
        /// Поле ввода данных для Градусов.
        /// </summary>

        private void DegriesBox_TextChanged(object sender, EventArgs e)
        {

            inputData =  degriesBox.Text;
            
            if (degriesRadio.Checked)
            {
                Calculator(inputData, degriesRadio);
                smallDivideAngleBox.Text = sdaOutputData;
                radianBox.Text = radOutputData;
                legBox.Text = legOutputData;
               
            }                      
        }

        /// <summary>
        /// Поле ввода данных для малых делений угломера.
        /// </summary>
        /// 
        private void SmallDivideAngleBox_TextChanged(object sender, EventArgs e)
        {
            inputData = smallDivideAngleBox.Text;
            
            if (smallDivideAngelRadio.Checked)
            {
                Calculator(inputData, smallDivideAngelRadio);
                degriesBox.Text = degOutputData;
                radianBox.Text = radOutputData;
            }                       
        }

        /// <summary>
        /// Поле ввода данных для дистанции при расчёте катета.
        /// </summary>
        /// 
        private void DistanceBox_TextChanged(object sender, EventArgs e)
        {
            inputDistData = distanceBox.Text;
            DegriesBox_TextChanged(sender, e);
            HeightBox_TextChanged(sender, e);
            legBox.Text = legOutputData;
        }
        
        /// <summary>
        /// Поле ввода данных для высоты при расчёте пространственного угла.
        /// </summary>
        ///        
        private void HeightBox_TextChanged(object sender, EventArgs e)
        {
            inputHeightData = ((TextBox)sender).Text;
            Calculator(inputHeightData, degriesRadio);
            angleBox.Text = angleFieldOutputData;
        }


        private void DegriesRadioBtn_CheckedChanged(object sender, EventArgs e)
        {                 
            if (degriesRadio.Checked)
            {
                smallDivideAngleBox.Enabled = false;
                degriesBox.Enabled = true;
                radianBox.Enabled = false;
                logBox.Items.Add("Выбраны Градусы.");
            }
           
        }

        private void SmallDevideAngleBox_CheckedChanged(object sender, EventArgs e)
        {

            if (smallDivideAngelRadio.Checked)
            {
                smallDivideAngleBox.Enabled = true;
                degriesBox.Enabled = false;
                radianBox.Enabled = false;
                logBox.Items.Add("Выбраны МДУ.");
            }               
        }
        
        private void radianRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (radianRadio.Checked)
            {
                smallDivideAngleBox.Enabled = false;
                degriesBox.Enabled = false;
                radianBox.Enabled = true;
                logBox.Items.Add("Выбраны Радианы.");
            }

        }


        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void logBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] logData = new string[logBox.Items.Count];
            
            DirectoryInfo logDirectory = new DirectoryInfo(@".");
            logDirectory.CreateSubdirectory("Logs");
            FileInfo logFile = new FileInfo(logDirectory + @"\Logs\log.txt");                     
           
            for(int i = 0; i<logBox.Items.Count; i++)
            {
                logData[i] = logBox.Items[i].ToString();
            }

            File.WriteAllLines(logFile.FullName, logData);

            MessageBox.Show("Файл сохранен: " + logFile.FullName );            
        }

        private void Calculator(string inputData, RadioButton mode)
        {
            try
            { 
                if (inputData != "" && inputData != null) 
                {
                    inputData = inputData.Replace('.', ',');                                                       
                    convertInputData = Double.Parse(inputData);
                }

                if (inputDistData != null && inputDistData != "")
                {
                    convertDistInputData = Double.Parse(inputDistData);
                }


                if (inputHeightData != null && inputHeightData != "")
                {
                    convertHeightInputData = Double.Parse(inputHeightData);
                }


                switch (mode.Name)
                {
                    case "smallDivideAngelRadio":
                        smallDivideAngleData = convertInputData;
                        degriesData = calculate.MduToDeg(convertInputData);
                        radianData = calculate.DegToRad(degriesData);                        
                        break;

                    case "degriesRadio":
                        degriesData = convertInputData;
                        radianData = calculate.DegToRad(degriesData);
                        smallDivideAngleData = calculate.DegToMdu(convertInputData);
                        break;

                    case "radianRadio":
                        radianData = convertInputData;
                        degriesData = calculate.RadToDeg(convertInputData);
                        smallDivideAngleData = calculate.DegToMdu(degriesData);
                        break;

                }

                distanceData = calculate.LegLength(convertDistInputData, degriesData);
                angleFieldData = calculate.AngleOnField(convertDistInputData, convertHeightInputData);

                heightOutputData = String.Format("{0:N3}", convertHeightInputData);
                angleFieldOutputData = String.Format("{0:N3}", angleFieldData);
                legOutputData = String.Format("{0:N3}", distanceData);
                degOutputData = String.Format("{0:N3}", degriesData);
                radOutputData = String.Format("{0:N3}", radianData);
                sdaOutputData = String.Format("{0:N3}", smallDivideAngleData);

                logBox.Items.Add("Дистанция: " + convertDistInputData + "; Катет: " + legOutputData + "; Высота: " + heightOutputData);

                
                logBox.Items.Add("Рад: " + radOutputData + ";" +
                                 "Мду: " + sdaOutputData + ";" +
                                 "Град: " + degOutputData + ".");             

            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message);
            }           
        }

        private void LegLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Катет противолежащего угла.\n" +
                            "Отражет информацию о ширине ДН в метрах.");
        }

        private void AngleFieldLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Катет противолежащего угла.\n" +
                "Отражет информацию о ширине ДН в метрах.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(File.Exists(databaseName))
                {
                    SQLiteConnection.CreateFile(databaseName);
                }
                else
                {
                    MessageBox.Show("База данных уже существует.");
                }
            }
            catch (Exception message)
            {

                MessageBox.Show(message.Message);
            }
        }
    }
}
