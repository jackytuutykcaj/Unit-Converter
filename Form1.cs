using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        System.Object[] lengthItems = {"meters", "inches", "feet"};
        System.Object[] massItems = { "kilograms", "pounds", "grams" };
        System.Object[] temperatureItems = { "celcius", "fahrenheit", "kelvin" };
        string convertTo = "", convertFrom = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonLength_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxConvertFrom.Items.Clear();
            comboBoxConvertTo.Items.Clear();
            reset();
            comboBoxConvertFrom.Items.AddRange(lengthItems);
            comboBoxConvertTo.Items.AddRange(lengthItems);
        }

        private void radioButtonMass_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxConvertFrom.Items.Clear();
            comboBoxConvertTo.Items.Clear();
            reset();
            comboBoxConvertFrom.Items.AddRange(massItems);
            comboBoxConvertTo.Items.AddRange(massItems);
        }

        private void radioButtonTemp_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxConvertFrom.Items.Clear();
            comboBoxConvertTo.Items.Clear();
            reset();
            comboBoxConvertFrom.Items.AddRange(temperatureItems);
            comboBoxConvertTo.Items.AddRange(temperatureItems);
        }

        private void comboBoxConvertFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            convertFrom = comboBoxConvertFrom.SelectedItem.ToString();
            if (convertTo != "")
            {
                if (radioButtonLength.Checked) { calculateLength(); }
                if (radioButtonMass.Checked) { calculateMass(); }
                if (radioButtonTemp.Checked) { calculateTemp(); }
            }
        }

        private void comboBoxConvertTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            convertTo = comboBoxConvertTo.SelectedItem.ToString();
            if(convertFrom != "" && textBoxConvertFrom.Text !=  "")
            {
                if (radioButtonLength.Checked) { calculateLength(); }
                if (radioButtonMass.Checked) { calculateMass(); }
                if (radioButtonTemp.Checked) { calculateTemp(); }
            }
        }

        private void textBoxConvertFrom_TextChanged(object sender, EventArgs e)
        {
            if (convertFrom != "" && convertTo != "")
            {
                if(textBoxConvertFrom.Text != "")
                {
                    if (radioButtonLength.Checked) { calculateLength(); }
                    if (radioButtonMass.Checked) { calculateMass(); }
                    if (radioButtonTemp.Checked) { calculateTemp(); }
                }
                else
                {
                    textBoxConvertTo.Text = "";
                }
            }
        }

        private void menuItemReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void reset()
        {
            comboBoxConvertFrom.ResetText();
            comboBoxConvertTo.ResetText();
            textBoxConvertFrom.ResetText();
            textBoxConvertTo.ResetText();
            textBoxConvertFrom.Focus();
            convertFrom = "";
            convertTo = "";
        }

        void calculateLength()
        {
            double result;
            Double.TryParse(textBoxConvertFrom.Text.ToString(), out result);
            switch (convertFrom)
            {
                case "meters":
                    if (convertTo == "inches") { result = Convert.ToDouble(textBoxConvertFrom.Text.ToString()) * 39.37; }
                    if (convertTo == "feet") { result = Convert.ToDouble(textBoxConvertFrom.Text.ToString()) * 3.281; }
                    break;
                case "inches":
                    if (convertTo == "meters") { result = Convert.ToDouble(textBoxConvertFrom.Text.ToString()) / 39.37; }
                    if (convertTo == "feet") { result = Convert.ToDouble(textBoxConvertFrom.Text.ToString()) /12; }
                    break;
                case "feet":
                    if (convertTo == "meters") { result = Convert.ToDouble(textBoxConvertFrom.Text.ToString()) / 3.218; }
                    if (convertTo == "inches") { result = Convert.ToDouble(textBoxConvertFrom.Text.ToString()) * 12; }
                    break;
            }
            textBoxConvertTo.Text = Convert.ToString(Math.Round(result, 3));
        }

        void calculateMass()
        {
            double result;
            Double.TryParse(textBoxConvertFrom.Text.ToString(), out result);
            switch (convertFrom)
            {
                case "kilograms":
                    if (convertTo == "pounds") { result = Convert.ToDouble(textBoxConvertFrom.Text.ToString()) * 2.205; }
                    if (convertTo == "grams") { result = Convert.ToDouble(textBoxConvertFrom.Text.ToString()) * 1000; }
                    break;
                case "pounds":
                    if (convertTo == "kilograms") { result = Convert.ToDouble(textBoxConvertFrom.Text.ToString()) / 2.205; }
                    if (convertTo == "grams") { result = Convert.ToDouble(textBoxConvertFrom.Text.ToString()) * 453.6; }
                    break;
                case "grams":
                    if (convertTo == "kilograms") { result = Convert.ToDouble(textBoxConvertFrom.Text.ToString()) / 1000; }
                    if (convertTo == "pounds") { result = Convert.ToDouble(textBoxConvertFrom.Text.ToString()) / 453.6; }
                    break;
            }
            textBoxConvertTo.Text = Convert.ToString(Math.Round(result, 3));
        }

        void calculateTemp()
        {
            double result;
            Double.TryParse(textBoxConvertFrom.Text.ToString(), out result);
            switch (convertFrom)
            {
                case "celcius":
                    if (convertTo == "fahrenheit") { result = (Convert.ToDouble(textBoxConvertFrom.Text.ToString()) * 9/5) + 32; }
                    if (convertTo == "kelvin") { result = Convert.ToDouble(textBoxConvertFrom.Text.ToString()) + 273.15; }
                    break;
                case "fahrenheit":
                    if (convertTo == "celcius") { result = (Convert.ToDouble(textBoxConvertFrom.Text.ToString()) - 32) * 5/9; }
                    if (convertTo == "kelvin") { result = (Convert.ToDouble(textBoxConvertFrom.Text.ToString()) - 32) * 5/9 + 273.15; }
                    break;
                case "kelvin":
                    if (convertTo == "celcius") { result = Convert.ToDouble(textBoxConvertFrom.Text.ToString()) - 273.15; }
                    if (convertTo == "fahrenheit") { result = ((Convert.ToDouble(textBoxConvertFrom.Text.ToString()) - 273.15) * 9/5) + 32; }
                    break;
            }
            textBoxConvertTo.Text = Convert.ToString(Math.Round(result, 3));
        }
    }
}
