using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double value1, value2, value3;

            // Попытка преобразовать введенные значения
            if (double.TryParse(textBox1.Text, out value1) &&
                double.TryParse(textBox2.Text, out value2) &&
                double.TryParse(textBox3.Text, out value3))
            {
                // Проверка на существование треугольника, если заданы три стороны
                if (IsTriangle(value1, value2, value3))
                {
                    // Здесь можно добавить логику для вычисления углов, высот и т.д.
                    double angleA = CalculateAngle(value2, value3, value1);
                    double angleB = CalculateAngle(value1, value3, value2);
                    double angleC = 180 - angleA - angleB;

                    double heightA = CalculateHeight(value1, angleA);
                    double heightB = CalculateHeight(value2, angleB);
                    double heightC = CalculateHeight(value3, angleC);

                    label4.Text = $"Углы:\nA: {angleA:F2}°\nB: {angleB:F2}°\nC: {angleC:F2}°\n\n" +
                                   $"Высоты:\nhA: {heightA:F2}\nhB: {heightB:F2}\nhC: {heightC:F2}";
                }
                else
                {
                    label4.Text = "Треугольник не существует!";
                }
            }
            else
            {
                label4.Text = "Введите корректные значения!";
            }
        }

        // Метод для проверки, существует ли треугольник
        private bool IsTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        // Метод для вычисления угла по теореме косинусов
        private double CalculateAngle(double a, double b, double c)
        {
            return Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * (180 / Math.PI);
        }

        // Метод для вычисления высоты
        private double CalculateHeight(double side, double angle)
        {
            return side * Math.Sin(angle * (Math.PI / 180));
        }
    }
    }
}
