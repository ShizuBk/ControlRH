using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlRH
{
    public partial class Calendario : Form
    {

        private DataTable table = new DataTable();
        
        private int month, year,rows;
        public Calendario()
        {
            InitializeComponent();
            getDB();
            string nrows = table.Rows.Count.ToString();
            rows = Int32.Parse(nrows);
            mostrarDias();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //limpiar contenedor
            dayContainer.Controls.Clear();
            
            //incremento al siguiente mes
            month++;
            if(month > 12)
            {
                month = 1;
                year++;
            }
            string monthname = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            MonthYear.Text = monthname.ToUpper() + " " + year;
            //Primeros días del mes
            DateTime inicioMes = new DateTime(year, month, 1);
            //Conteo de los dias iniciales
            int dias = DateTime.DaysInMonth(year, month);
            //Convesión de los días a entero
            int diasSem = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d")) + 1;

            string dateString = "";
            for (int i = 1; i <= dias; i++)
            {
                string names = "";
                Console.WriteLine("Dia" + i);
                try
                {
                    for (int j = 0; j < rows; j++)
                    {
                        dateString = table.Rows[j]["fecha_nacimiento"].ToString();
                        Console.WriteLine(dateString + " " + table.Rows[j]["nombre"].ToString() + "\n");
                        DateTime empDT = DateTime.Parse(validarFecha(dateString, '-'));
                        int mt = empDT.Month;
                        int day = empDT.Day;
                        if (mt == month)
                        {

                            Console.WriteLine("Yep " + day + "," + i);
                            if (day == i)
                            {
                                Console.WriteLine("Yep");
                                names = names + table.Rows[j]["nombre"].ToString() + "\n";
                                Console.WriteLine(names);
                            }
                        }
                    }

                    Console.WriteLine(names);

                }
                catch
                {

                }

                UserControlDays ucdays = new UserControlDays(names);
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }
        
        private string validarFecha(string fecha, char formato) //Poner formato de fecha
        {
            string ret = "";
            try
            {
                for (int i = 0; i < 10; i++)
                {

                    ret = ret + fecha[i];
                }
                string[] dma = ret.Split('/');
                if (formato == '-')
                {
                    ret = dma[2] + "-" + dma[1] + "-" + dma[0];
                }
                else
                {
                    ret = dma[0] + "/" + dma[1] + "/" + dma[2];
                }
            }
            catch { return ""; }
            return ret;
        }
        private void bntPrev_Click(object sender, EventArgs e)
        {
            //limpiar contenedor
            dayContainer.Controls.Clear();

            //Decremento al mes anterior
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }
            string monthname = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            MonthYear.Text = monthname.ToUpper() + " " + year;
            //Primeros días del mes
            DateTime inicioMes = new DateTime(year, month, 1);
            //Conteo de los dias iniciales
            int dias = DateTime.DaysInMonth(year, month);
            //Convesión de los días a entero
            int diasSem = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < diasSem; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }
            //control de los días

            string dateString = "";
            for (int i = 1; i <= dias; i++)
            {
                string names = "";
                Console.WriteLine("Dia" + i);
                try
                {
                    for (int j = 0; j < rows; j++)
                    {
                        dateString = table.Rows[j]["fecha_nacimiento"].ToString();
                        Console.WriteLine(dateString + " " + table.Rows[j]["nombre"].ToString() + "\n");
                        DateTime empDT = DateTime.Parse(validarFecha(dateString, '-'));
                        int mt = empDT.Month;
                        int day = empDT.Day;
                        if (mt == month)
                        {

                            Console.WriteLine("Yep " + day + "," + i);
                            if (day == i)
                            {
                                Console.WriteLine("Yep");
                                names = names + table.Rows[j]["nombre"].ToString() + "\n";
                                Console.WriteLine(names);
                            }
                        }
                    }

                    Console.WriteLine(names);

                }
                catch
                {

                }

                UserControlDays ucdays = new UserControlDays(names);
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        private void getDB()
        {
            Conexion conexion = new Conexion();
            string sqlStatement = "select nombre, fecha_nacimiento from empleados";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlStatement, conexion.GetConnection());
            adapter.Fill(table);


        }

        private void mostrarDias()
        {
            dayContainer.Controls.Clear();
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;



            string monthname = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            MonthYear.Text = monthname.ToUpper()+" "+year;
            //Primeros días del mes
            DateTime inicioMes = new DateTime(year, month, 1);
            //Conteo de los dias iniciales
            int dias = DateTime.DaysInMonth(year,month);
            //Convesión de los días a entero
            int diasSem = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d"))+1;

            for (int i = 1; i < diasSem; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }
            //control de los días


            string dateString = "";
            for (int i = 1; i <= dias; i++)
            {
                string names = "";
                Console.WriteLine("Dia"+i);
                try
                {
                    for (int j = 0; j < rows; j++)
                    {
                        dateString = table.Rows[j]["fecha_nacimiento"].ToString();
                        Console.WriteLine(dateString + " " + table.Rows[j]["nombre"].ToString() + "\n");
                        DateTime empDT = DateTime.Parse(validarFecha(dateString, '-'));
                        int mt = empDT.Month;
                        int day = empDT.Day;
                        if (mt==month)
                        {


                            if (day==i)
                            {

                                names = names + table.Rows[j]["nombre"].ToString() + "\n";

                            }
                        }
                    }



                }
                catch
                {

                }

                UserControlDays ucdays = new UserControlDays(names);
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }


        }
    }
}
