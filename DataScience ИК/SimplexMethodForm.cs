using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DataScience_ИК
{
    public partial class SimplexMethodForm : Form
    {
        public SimplexMethodForm()
        {
            InitializeComponent();
            FillFields(functionTb, matrixRTb, variablesTb, iterationsTb, limitationsTb);
            resultRTb.ForeColor = Color.GreenYellow;
            BackColor = Color.Black;
            groupBox1.BackColor = Color.Black;
            groupBox1.ForeColor = Color.White;
            resultRTb.BackColor = Color.Black;
            CalculateBt.ForeColor = Color.Black;
        }

        

        private void CalculateBt_Click(object sender, EventArgs e)
        {
            resultRTb.Text = "";
            double[,] table = FillTable(functionTb.Text, matrixRTb.Text, limitationsTb.Text, variablesTb.Text);

            PrintTable(table, resultRTb);

            int counter = Convert.ToInt32(iterationsTb.Text);

            while (!IsOptimal(table) && counter > 0)
            {
                TableRecalculation(table);
                PrintTable(table, resultRTb);
                resultRTb.Text += "\n\n";
                counter--;
            }

            if (!IsOptimal(table))
                resultRTb.Text += "     Не имеет решения";

            else
            {
                (int, double)[] variables = GetVariables(table);
                string fContent = "";
                for (int i = 0; i < variables.Length; i++)
                {
                    fContent += Math.Round(variables[i].Item2, 3);
                    if (i != variables.Length - 1) fContent += "; ";
                }


                for (int i = 0; i < variables.Length; i++)
                    resultRTb.Text += $"    x{variables[i].Item1 + 1} = {variables[i].Item2}\n";

                resultRTb.Text += $"    F max = F({fContent}) = {Math.Round(GetFunctionMaximumValue(table), 2)}\n\n\n";
            }
        }

        static string Margins(double value)
        {
            switch (value.ToString().Length)
            {
                case 1:
                    return "|        " + value;

                case 2:
                    return "|       " + value;

                case 3:
                    return "|     " + value;

                case 4:
                    return "|   " + value;

                case 5:
                    return "|  " + value;

                default:
                    return "|" + value;
            }
        }

        static void PrintTable(double[,] table, RichTextBox resultRTb)
        {
            resultRTb.Text += "\n";
            if (IsOptimal(table))
            {
                resultRTb.Text += "-----------------------------------" +
                    "-------------------------------------------------" +
                    "------------------------------------\n";
                resultRTb.Text += $"     Итоговая таблица ↓\n";
            }

            for (int i = 0; i < table.GetLength(0); i++)
            {
                if (IsOptimal(table))
                    for (int j = 0; j < table.GetLength(1) - 1; j++)
                        resultRTb.Text += "     " + Margins(Math.Round(table[i, j], 3));

                else
                    for (int j = 0; j < table.GetLength(1); j++)
                        resultRTb.Text += "     " + Margins(Math.Round(table[i, j], 3));

                resultRTb.Text += "|\n";
            }

            resultRTb.Text += "\n";
        }

        static (int,double)[] GetVariables(double[,] table)
        {
            List<(int,double)> variables = new List<(int, double)>();

            for(int j = 0; j < table.GetLength(1) - 2; j++)
            {
                for (int i = 0; i < table.GetLength(0); i++)
                    if (IsBasis(table, j) && table[i, j] != 0)
                        variables.Add((j ,table[i, table.GetLength(1) - 2] / table[i, j]));
            }

            return variables.ToArray();
        }

        static double GetFunctionMaximumValue(double[,] table)
        {
            return table[table.GetLength(0) - 1, table.GetLength(1) - 2];
        }

        static bool IsBasis(double[,] tables, int columnIndex)
        {
            bool isBasis = false;
            int notZeroCount = 0;

            for (int i = 0; i < tables.GetLength(0); i++)
            {
                if (tables[i, columnIndex] != 0)
                    notZeroCount += 1;
            }

            if (notZeroCount == 1)
                isBasis = true;

            return isBasis;
        }

        static int GetOptimalRow(double[,] table)
        {
            int rows = table.GetLength(0);
            int column = table.GetLength(1) - 1;
            double minVal = double.MaxValue;
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                if (table[i, column] < minVal && table[i, column] > 0)
                {
                    minVal = table[i, column];
                    index = i;
                }
            }

            return index;
        }

        static int GetOptimalColumn(double[,] table)
        {
            int rows = table.GetLength(0) - 1;
            int columns = table.GetLength(1) - 2;
            double minVal = int.MaxValue;
            int index = 0;

            for (int j = 0; j < columns; j++)
            {
                if (table[rows, j] < minVal)
                {
                    minVal = table[rows, j];
                    index = j;
                }
            }

            return index;
        }

        static double[,] FillTable(string function_str, string matrix_str, string rows, string columns)
        {
            double[,] table = new double[Convert.ToInt32(rows) + 1, Convert.ToInt32(columns) + 2];

            string[] rowList = matrix_str.Split('\n');

            string[] funcList = function_str.Split(' ');

            for (int i = 0; i < rowList.Length; i++)
            {
                string[] cols = rowList[i].Split(' ');

                for (int j = 0; j < cols.Length; j++)
                    table[i, j] = Convert.ToDouble(cols[j]);
            }

            for (int i = 0; i < funcList.Length; i++)
                table[table.GetLength(0) - 1, i] = Convert.ToDouble(funcList[i]);

            int optimal_column_index = GetOptimalColumn(table);

            for (int i = 0; i < table.GetLength(0) - 1; i++)
                table[i, table.GetLength(1) - 1] = table[i, table.GetLength(1) - 2] / table[i, optimal_column_index];

            return table;
        }

        static void TableRecalculation(double[,] table)
        {
            int optimalRowIndex = GetOptimalRow(table);
            int optimalColumnIndex = GetOptimalColumn(table);
            double optimalValue = table[optimalRowIndex, optimalColumnIndex];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                double factor = table[i, optimalColumnIndex] / optimalValue * -1;

                for (int j = 0; j < table.GetLength(1) - 1; j++)
                    if (i != optimalRowIndex)
                        table[i, j] += Math.Round(factor * table[optimalRowIndex, j], 2);
            }

            if (!IsOptimal(table))
            {
                optimalColumnIndex = GetOptimalColumn(table);

                for (int i = 0; i < table.GetLength(0) - 1; i++)
                    table[i, table.GetLength(1) - 1] = table[i, table.GetLength(1) - 2] / table[i, optimalColumnIndex];
            }
        }

        static bool IsOptimal(double[,] table)
        {
            int i = table.GetLength(0) - 1;

            for (int j = 0; j < table.GetLength(1) - 2; j++)
                if (table[i, j] < 0)
                    return false;

            return true;
        }

        static void FillFields(TextBox functionTb, RichTextBox matrixRTb, TextBox variablesTb, TextBox iterationsTb, TextBox limitationsTb)
        {
            //Correct
            //functionTb.Text = "-3 -4 0 0 0";
            //variablesTb.Text = "4";
            //limitationsTb.Text = "2";
            //iterationsTb.Text = "6";
            //matrixRTb.Text = "4 1 1 0 8\n-1 1 0 1 3";


            //Correct
            //functionTb.Text = "-2 -3 0 1";
            //variablesTb.Text = "6";
            //limitationsTb.Text = "3";
            //iterationsTb.Text = "6";
            //matrixRTb.Text = "2 -1 0 -2 1 0 16\n3 2 1 -3 0 0 18\n-1 3 0 4 0 1 24";


            //Correct
            //functionTb.Text = "3 -1 -4 0 0";
            //variablesTb.Text = "5";
            //limitationsTb.Text = "3";
            //iterationsTb.Text = "6";
            //matrixRTb.Text = "0 -1 1 1 0 1\n-5 1 1 0 0 2\n-8 1 2 0 -1 3";


            //Has no solution
            //functionTb.Text = "2 1 -2 0 0 0";
            //variablesTb.Text = "6";
            //limitationsTb.Text = "3";
            //iterationsTb.Text = "6";
            //matrixRTb.Text = "1 1 -1 -1 0 0 8\n1 -1 2 0 -1 0 2\n-2 -8 3 0 0 -1 1";


            functionTb.Text = "1 2 -1 1";
            variablesTb.Text = "4";
            limitationsTb.Text = "2";
            iterationsTb.Text = "6";
            matrixRTb.Text = "1 1 -2 3 1\n2 -1 -1 3 2";
        }
    }
}
