using Graphics.Entities;
using Graphics.Entities.Interfaces;
using Graphics.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graphics
{
    public partial class Graphic : Form
    {
        int i;
        List<IPoint> figure;

        public Graphic()
        {
            InitializeComponent();

            figure = new List<IPoint>();

            dataGridView.RowCount = 1;
            //chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.Crossing = 0;//Ось X
            chart.ChartAreas[0].AxisY.Crossing = 0;//Ось Y
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            dataGridView.RowCount = Convert.ToInt32(numericUpDown.Value);
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            figure.Clear();
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (!String.IsNullOrEmpty(dataGridView[0, i].Value.ToString()) && !String.IsNullOrEmpty(dataGridView[1, i].Value.ToString()))
                    figure.Add(new Point(Convert.ToDouble(dataGridView[0, i].Value), Convert.ToDouble(dataGridView[1, i].Value)));
                else
                {
                    MessageBox.Show("Матрица не заполнена");
                    return;
                }
            }

            if (radioButtonDefault.Checked)
            {
                DrawFigure(figure);
            }
            else if (radioButtonReflect.Checked)
            {
                if (!String.IsNullOrEmpty(maskedTextBoxCoefficient.Text) && maskedTextBoxCoefficient.Text != "    ,")
                {
                    List<IPoint> fig = new List<IPoint>();
                    if (radioButtonOX.Checked)
                    {
                        fig = Reflect.OX(figure, Convert.ToDouble(maskedTextBoxCoefficient.Text));
                        DrawFigure(fig);
                    }
                    else if (radioButtonOY.Checked)
                    {
                        fig = Reflect.OY(figure, Convert.ToDouble(maskedTextBoxCoefficient.Text));
                        DrawFigure(fig);
                    }
                    else //if (radioButtonXY.Checked)
                    {
                        fig = Reflect.XY(figure, Convert.ToDouble(maskedTextBoxCoefficient.Text));
                        if (fig != null)
                        {
                            DrawFigure(fig);
                        }
                        else
                        {
                            MessageBox.Show("Невозможно выполнить отражение по XY/-XY, так как фигура находится в нескольких четвертях");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Введите коэффициент!");
                }
            }
            else //if (radioButtonRotate.Checked)
            {
                if (!String.IsNullOrEmpty(maskedTextBoxGradus.Text) && maskedTextBoxGradus.Text != "    ,")
                {
                    List<IPoint> fig = Rotate.PerGraduses(figure, Convert.ToDouble(maskedTextBoxGradus.Text));
                    DrawFigure(fig);
                }
                else
                {
                    MessageBox.Show("Введите градус поворота!");
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
            i = -1;
        }

        private void DrawFigure(List<IPoint> figure)
        {
            i++;
            chart.Series.Add(new Series(i.ToString()));
            foreach (IPoint point in figure)
            {
                chart.Series[i].Points.AddXY(point.X, point.Y);
                chart.Series[i].ChartType = SeriesChartType.Line;
                chart.Series[i].BorderWidth = 2;
                chart.Series[i].XValueType = ChartValueType.String;
                chart.Series[i].IsValueShownAsLabel = true;
            }
        }

        private void radioButtonDefault_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Enabled = true;
        }

        private void radioButtonReflect_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Enabled = false;
        }

        private void radioButtonRotate_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Enabled = false;
        }
    }
}
