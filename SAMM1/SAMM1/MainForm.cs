using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Core.Histogram;
using Core.Random;

namespace SAMM1
{
    public partial class MainForm : Form
    {
        private const string RANDOM_SERIES_NAME = "RandomSeries";

        public MainForm()
        {
            InitializeComponent();
            RandomSeries = chart.Series.FindByName(RANDOM_SERIES_NAME);
            RandomChanged(this, EventArgs.Empty);
        }

        private Series RandomSeries { get; }

        private void RandomChanged(object sender, EventArgs e)
        {
            try
            {
                var random = GetRandom();
                UpdateRandomInfo(random);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private IRandom GetRandom()
        {
            var a = long.Parse(lehmerAInput.Text);
            var m = long.Parse(lehmerMInput.Text);
            var r = BigInteger.Parse(lehmerRInput.Text);
            return new LehmerRandom(a, m, r);
        }

        private void UpdateRandomInfo(IRandom random)
        {
            var maxCount = decimal.ToInt32(lehmerCountInput.Value);
            if (maxCount == 0)
                return;

            var numbers = new List<double>(maxCount);

            UpdateChart(RandomSeries, numbers);
            periodValueLabel.Text = "...";
            aperiodicValueLabel.Text = "...";
            uniformityValueLabel.Text = "...";

            for (int i = 0; i < maxCount; i++)
            {
                var number = random.Next();
                numbers.Add(number);
            }

            var periodEnd = numbers.Count - 1;
            var lastNumber = numbers[periodEnd];
            var periodStart = numbers.LastIndexOf(lastNumber, periodEnd - 1);
            var period = periodEnd - periodStart;
            var aperiodicLength = numbers.IndexOf(lastNumber) + 1;
            var uniform = CalculateUniform(numbers);

            UpdateChart(RandomSeries, numbers);
            periodValueLabel.Text = period.ToString();
            aperiodicValueLabel.Text = aperiodicLength.ToString();
            uniformityValueLabel.Text = uniform.ToString();
        }

        private void UpdateChart(Series series, IList<double> numbers)
        {
            var histogram = Histogram.BuildHistogram(numbers);
            if (histogram is null)
                return;
            series.Points.Clear();
            for (int i = 0; i < histogram.Length; i++)
            {
                series.Points.AddXY(i + 1, histogram[i]);
            }
            chart.ResetAutoValues();
        }

        private int CalculateUniform(IList<double> numbers)
        {
            int k = 0;
            for (int i = 0; i + 1 < numbers.Count; i += 2)
            {
                var a = numbers[i];
                var b = numbers[i + 1];
                if (a * a + b * b <= 1)
                {
                    k++;
                }
            }
            return k;
        }
    }
}
