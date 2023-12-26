using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace DataScience_ИК
{
    public partial class MainForm : Form
    {
        GraphPane gp { get; set; }

        double[] X { get; set; }

        double[] Y { get; set; }

        double[] Y_Line { get; set; }

        string Type { get; set; }

        double[] LinearCoeffs { get; set; }

        double[] QuadraticCoeffs{ get; set; }

        public MainForm()
        {
            InitializeComponent();
            gp = zedGraphControl1.GraphPane;
            gp.Title.Text = "График";
            SetColors(gp);
        }

        static double Determinant(double[,] matrix)
        {
            int size = matrix.GetLength(0);

            if (size == 2)
            {
                return
                    matrix[0, 0] * matrix[1, 1] -
                    matrix[0, 1] * matrix[1, 0];
            }

            if (size == 3)
            {
                return
                    matrix[0, 0] * matrix[1, 1] * matrix[2, 2] +
                    matrix[0, 1] * matrix[1, 2] * matrix[2, 0] +
                    matrix[1, 0] * matrix[2, 1] * matrix[0, 2] -
                    matrix[0, 2] * matrix[1, 1] * matrix[2, 0] -
                    matrix[2, 1] * matrix[1, 2] * matrix[0, 0] -
                    matrix[1, 0] * matrix[0, 1] * matrix[2, 2];
            }

            else throw new ArgumentException("Размерность матрицы либо велика, либо заданна некорректно");
        }

        static double[] SystemOfEquations2X2(double[,] matrix)
        {
            double[] ab = new double[2];

            double delta = Determinant(
                new double[,]
                {
                { matrix[0, 0], matrix[0, 1] },
                { matrix[1, 0], matrix[1, 1] }
                });

            if (delta == 0) throw new Exception(
                "Система не может быть решена данным методом так как детерминант матрицы равен нулю");

            double delta1 = Determinant(
                new double[,]
                {
                { matrix[0, 2], matrix[0, 1] },
                { matrix[1, 2], matrix[1, 1] }
                });

            double delta2 = Determinant(
                new double[,]
                {
                { matrix[0, 0], matrix[0, 2]},
                { matrix[1, 0], matrix[1, 2]}
                });

            ab[1] = delta1 / delta;
            ab[0] = delta2 / delta;

            return ab;
        }

        static double[] TextToArray(string text)
        {
            string[] substrings = text.Split(' ');
            double[] result = new double[substrings.Length];

            for (int i = 0; i < substrings.Length; i++)
            {
                if (double.TryParse(substrings[i], out _))
                    result[i] = Convert.ToDouble(substrings[i]);

                else throw new ArgumentException(
                    "Один или несколько элементов массива были введены в неверном формате");
            }

            return result;
        }

        static double[] SystemOfEquations3X3(double[,] matrix)
        {
            double[] abc = new double[3];
            double delta, delta1, delta2, delta3;

            delta = Determinant(
                new double[,]
                {
                { matrix[0, 0], matrix[0, 1], matrix[0, 2]},
                { matrix[1, 0], matrix[1, 1], matrix[1, 2]},
                { matrix[2, 0], matrix[2, 1], matrix[2, 2]}
                });

            if (delta == 0) throw new Exception(
                "Система не может быть решена данным методом так как детерминант матрицы равен нулю");

            delta1 = Determinant(
                new double[,]
                {
                { matrix[0, 3], matrix[0, 1], matrix[0, 2]},
                { matrix[1, 3], matrix[1, 1], matrix[1, 2]},
                { matrix[2, 3], matrix[2, 1], matrix[2, 2]}
                });

            delta2 = Determinant(
                new double[,]
                {
                { matrix[0, 0], matrix[0, 3], matrix[0, 2]},
                { matrix[1, 0], matrix[1, 3], matrix[1, 2]},
                { matrix[2, 0], matrix[2, 3], matrix[2, 2]}
                });

            delta3 = Determinant(
                new double[,]
                {
                { matrix[0, 0], matrix[0, 1], matrix[0, 3]},
                { matrix[1, 0], matrix[1, 1], matrix[1, 3]},
                { matrix[2, 0], matrix[2, 1], matrix[2, 3]}
                });

            abc[0] = delta1 / delta;
            abc[1] = delta2 / delta;
            abc[2] = delta3 / delta;

            return abc;
        }

        static bool SameSize(double[] x, double[] y)
        {
            if (x.Length == y.Length) return true;
            else return false;
        }

        internal double LinearDependence_F_X(double x, double[] coeffs)
        {
            return coeffs[0] * x + coeffs[1];
        }

        internal double QuadraticDependence_F_X(double x, double[] coeffs)
        {
            return coeffs[0] * Math.Pow(x, 2) + coeffs[1] * x + coeffs[2];
        }

        private void LinearDependenceBt_Click_1(object sender, EventArgs e)
        {
            Type = "Line";
            X = TextToArray(XTb.Text);
            Y = TextToArray(YTb.Text);

            if (!SameSize(X, Y)) MessageBox.Show("Длины массивов не совпадают");

            int n = X.Length;
            double x_square_amount = 0, x_amount = 0, y_amount = 0, y_x_amount = 0;

            for (int i = 0; i < X.Length; i++)
            {
                x_amount += X[i];
                y_x_amount += X[i] * Y[i];
                x_square_amount += Math.Pow(X[i], 2);
                y_amount += Y[i];
            }

            double[,] matrix = new double[,]
            {
                { n, x_amount, y_amount},
                { x_amount, x_square_amount, y_x_amount}
            };

            LinearCoeffs = SystemOfEquations2X2(matrix);

            Y_Line = new double[X.Length];

            for (int i = 0; i < X.Length; i++)
                Y_Line[i] = LinearCoeffs[0] * X[i] + LinearCoeffs[1];

            if (LinearCoeffs[1] >= 0)
                ResultLbl.Text = $"Ответ: Y = {LinearCoeffs[0]} * X + {LinearCoeffs[1]}";

            else ResultLbl.Text = $"Ответ: Y = {LinearCoeffs[0]} * X - {-1 * LinearCoeffs[1]}";
        }

        private void QuadraticDependenceBt_Click_1(object sender, EventArgs e)
        {
            Type = "Spline";
            X = TextToArray(XTb.Text);
            Y = TextToArray(YTb.Text);

            if (!SameSize(X, Y)) MessageBox.Show("Длины массивов не совпадают");

            int n = X.Length;

            double
                x_p4_amount = 0,
                x_p3_amount = 0,
                x_p2_amount = 0,
                x_amount = 0,
                x_p2_y_amount = 0,
                x_y_amount = 0,
                y_amount = 0;

            for (int i = 0; i < n; i++)
            {
                x_p4_amount += Math.Pow(X[i], 4);
                x_p3_amount += Math.Pow(X[i], 3);
                x_p2_amount += Math.Pow(X[i], 2);
                x_amount += X[i];
                x_p2_y_amount += Math.Pow(X[i], 2) * Y[i];
                x_y_amount += X[i] * Y[i];
                y_amount += Y[i];
            }

            double[,] matrix = new double[,]
            {
                { x_p4_amount, x_p3_amount, x_p2_amount, x_p2_y_amount},
                { x_p3_amount, x_p2_amount, x_amount, x_y_amount },
                { x_p2_amount, x_amount, n, y_amount }
            };

            QuadraticCoeffs = SystemOfEquations3X3(matrix);

            Y_Line = new double[X.Length];

            for (int i = 0; i < X.Length; i++)
                Y_Line[i] = QuadraticCoeffs[0] * Math.Pow(X[i], 2) + QuadraticCoeffs[1] * X[i] + QuadraticCoeffs[2];

            if (QuadraticCoeffs[1] >= 0 && QuadraticCoeffs[2] >= 0)
                ResultLbl.Text = $"Ответ: Y = {QuadraticCoeffs[0]} * X^2 + {QuadraticCoeffs[1]} * X + {QuadraticCoeffs[2]}";

            else if (QuadraticCoeffs[1] < 0 && QuadraticCoeffs[2] >= 0)
                ResultLbl.Text = $"Ответ: Y = {QuadraticCoeffs[0]} * X^2 - {-1 * QuadraticCoeffs[1]} * X + {QuadraticCoeffs[2]}";

            else if (QuadraticCoeffs[1] >= 0 && QuadraticCoeffs[2] < 0)
                ResultLbl.Text = $"Ответ: Y = {QuadraticCoeffs[0]} * X^2 + {QuadraticCoeffs[1]} * X - {-1 * QuadraticCoeffs[2]}";

            else
                ResultLbl.Text = $"Ответ: Y = {QuadraticCoeffs[0]} * X^2 - {-1 * QuadraticCoeffs[1]} * X - {-1 * QuadraticCoeffs[2]}";
        }

        private void ScheduleBt_Click_1(object sender, EventArgs e)
        {
            gp.CurveList.Clear();

            PointPairList line_points = new PointPairList();
            PointPairList pts = new PointPairList();

            if (Type == "Line")
            {
                for (int i = 0; i < X.Length; i++)
                    pts.Add(X[i], Y[i]);

                for(double i = X.Min(); i < X.Max(); i += 0.01)
                    line_points.Add(i, LinearDependence_F_X(i, LinearCoeffs));
            }

            else
            {
                for (double i = X.Min(); i < X.Max(); i += 0.01)
                    line_points.Add(i, QuadraticDependence_F_X(i, QuadraticCoeffs));

                for (int i = 0; i < X.Length; i++)
                    pts.Add(X[i], Y[i]);
            }

            LineItem line = gp.AddCurve("Sinc", line_points, Color.DeepPink, SymbolType.None);
            LineItem points = gp.AddCurve("Points", pts, Color.Yellow, SymbolType.Circle);
            points.Line.IsVisible = false;
            points.Symbol.Fill.Type = FillType.Solid;
            points.Symbol.Size = 10;

            if (Type == "Line")
                gp.Title.Text = "Линейная зависимость";
            else
                gp.Title.Text = "Квадратичная зависимость";

            gp.CurveList.Add(line);
            gp.CurveList.Add(points);

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void ClearBt_Click(object sender, EventArgs e)
        {
            XTb.Text = "";
            YTb.Text = "";
        }

        private void SimplexBt_Click(object sender, EventArgs e)
        {
            SimplexMethodForm form = new SimplexMethodForm();
            form.ShowDialog();
        }

        private void SetColors(GraphPane gp)
        {
            gp.Chart.Border.Color = Color.Silver;
            gp.Fill.Type = FillType.Solid;
            gp.Fill.Color = Color.Black;
            gp.Chart.Fill.Type = FillType.Solid;
            gp.Chart.Fill.Color = Color.Black;
            gp.XAxis.MajorGrid.IsZeroLine = true;
            gp.YAxis.MajorGrid.IsZeroLine = true;
            gp.XAxis.Color = Color.GreenYellow;
            gp.YAxis.Color = Color.GreenYellow;
            gp.XAxis.MajorGrid.IsVisible = true;
            gp.YAxis.MajorGrid.IsVisible = true;
            gp.XAxis.MajorGrid.Color = Color.White;
            gp.YAxis.MajorGrid.Color = Color.White;
            gp.XAxis.Scale.FontSpec.FontColor = Color.GreenYellow;
            gp.YAxis.Scale.FontSpec.FontColor = Color.GreenYellow;
            gp.XAxis.MajorGrid.DashOn = 2;
            gp.XAxis.MajorGrid.DashOff = 2;
            gp.YAxis.MajorGrid.DashOn = 2;
            gp.YAxis.MajorGrid.DashOff = 2;
            gp.XAxis.MinorGrid.DashOn = 2;
            gp.XAxis.MinorGrid.DashOff = 2;
            gp.YAxis.MinorGrid.DashOn = 2;
            gp.YAxis.MinorGrid.DashOff = 2;
            gp.Legend.IsVisible = false;
        }
    }
}
