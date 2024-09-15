using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace lab3
{
    public partial class Graph : Form
    {
        private ZedGraphControl graphControl;
        private LineItem[] curves;
        private PointPairList[] points;
        public long[,] elapsedMS;

        public Graph()
        {
            InitializeComponent();
            InitializeGraph();
            PlotGraph();
        }

        public void InitializeGraph()
        {
            graphControl = new ZedGraphControl
            {
                Dock = DockStyle.Fill,
            };
            this.Controls.Add(graphControl);
            GraphPane pane = graphControl.GraphPane;
            pane.Title.Text = "Производительность сортировок";
            pane.XAxis.Title.Text = "Размер массива";
            pane.YAxis.Title.Text = "Прошедшее время (мс)";

            Main mainForm = new Main();
            elapsedMS = mainForm.Group1Test1();

            int[] arraySizes = { 10, 100, 1000, 10000 };
            points = new PointPairList[5];
            curves = new LineItem[5];
            string[] sortNames = { "BubbleSort", "InsertionSort", "SelectionSort", "ShakerSort", "GnomeSort" };

            for (int i = 0; i < 5; i++)
            {
                points[i] = new PointPairList();
                curves[i] = pane.AddCurve(sortNames[i], points[i], GetColor(i), SymbolType.None);
            }

            pane.XAxis.Scale.Min = arraySizes[0] - 10;
            pane.XAxis.Scale.Max = arraySizes[arraySizes.Length - 1] + 10;
            pane.YAxis.Scale.Min = MinMaxValue(elapsedMS).Item1;
            pane.YAxis.Scale.Max = MinMaxValue(elapsedMS).Item2;

            pane.XAxis.Scale.MajorStep = 1000;
            pane.XAxis.Scale.MinorStep = 100;

            graphControl.IsEnableVPan = true;
            graphControl.IsEnableVZoom = true;
            graphControl.IsEnableHPan = true;
            graphControl.IsEnableHZoom = true;
        }

        private void PlotGraph()
        {
            int[] arraySizes = { 10, 100, 1000, 10000 };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    points[i].Add(arraySizes[j], elapsedMS[i, j]);
                }
            }

            graphControl.AxisChange();
            graphControl.Invalidate();
        }

        private System.Drawing.Color GetColor(int index)
        {
            switch (index)
            {
                case 0: return System.Drawing.Color.Blue;
                case 1: return System.Drawing.Color.Red;
                case 2: return System.Drawing.Color.Green;
                case 3: return System.Drawing.Color.Purple;
                case 4: return System.Drawing.Color.Orange;
                default: return System.Drawing.Color.Black;
            }
        }

        private static Tuple<long, long> MinMaxValue(long[,] mat)
        {
            long min = long.MaxValue;
            long max = long.MinValue;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] < min)
                    {
                        min = mat[i, j];
                    }
                    if (mat[i, j] > max)
                    {
                        max = mat[i, j];
                    }
                }
            }

            return Tuple.Create(min, max);
        }
    }
}