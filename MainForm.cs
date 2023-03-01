using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public string act;
        public bool flag;
        public string tempParametr;
        public double result = 0;
        public MainForm()
        {
            InitializeComponent();
        }
        private void Numbers_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            int tempNumber;
            bool isNum = int.TryParse(numButton.Text, out tempNumber);
            if (flag)
            {
                flag = false;
                Label.Text = "0";
            }
            if (isNum && Label.Text != "0")
                Label.Text = Label.Text + numButton.Text;
            else
                Label.Text = numButton.Text;
            }
        private void CE_Click(object sender, EventArgs e)
        {
            Label.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (Label.Text != "")
                Label.Text = Label.Text.Substring(0, Label.Text.Length - 1);
            else
                CE_Click(sender, e);
        }
        private void Percent_Click(object sender, EventArgs e)
        {
            Button buttonAct = (Button)sender;
            act = buttonAct.Text;
            tempParametr = Label.Text;
            flag = true;
        }
        private void Equality_Click(object sender, EventArgs e)
        {
            double firstVar, secondVar;
            Double.TryParse(tempParametr, out firstVar);
            Double.TryParse(Label.Text, out secondVar);
            if (act == "+")
                result = firstVar + secondVar;
            if (act == "-")
                result = firstVar - secondVar;
            if (act == "×")
                result = firstVar * secondVar;
            if (act == "÷")
                result = firstVar / secondVar;
            if (act == "%")
                result = (firstVar / secondVar) * 100;
            Label.Text = result.ToString();
            flag = true;
        }
        private void Point_Click(object sender, EventArgs e)
        {
            if (!Label.Text.Contains(","))
                Label.Text = Label.Text + ",";
        }
        private void LightBackground_Click(object sender, EventArgs e)
        {
            LightBackground.Checked = true;
            DarkBackground.Checked = false;
             if(!DarkBackground.Checked)
            {
                Label.BackColor = MainForm.DefaultBackColor;
                Label.ForeColor = MainForm.DefaultForeColor;
                Panel.BackColor = MainForm.DefaultBackColor;
                Panel2.BackColor = MainForm.DefaultBackColor;
                DarkBackground.ForeColor = MainForm.DefaultForeColor;
                LightBackground.ForeColor = MainForm.DefaultForeColor;
                ZeroButton.BackColor = MainForm.DefaultBackColor;
                OneButton.BackColor = MainForm.DefaultBackColor;
                TwoButton.BackColor = MainForm.DefaultBackColor;
                ThreeButton.BackColor = MainForm.DefaultBackColor;
                FourButton.BackColor = MainForm.DefaultBackColor;
                FiveButton.BackColor = MainForm.DefaultBackColor;
                SixButton.BackColor = MainForm.DefaultBackColor;
                SevenButton.BackColor = MainForm.DefaultBackColor;
                EightButton.BackColor = MainForm.DefaultBackColor;
                NineButton.BackColor = MainForm.DefaultBackColor;
                Clear.BackColor = MainForm.DefaultBackColor;
                CE.BackColor = MainForm.DefaultBackColor;
                Addition.BackColor = MainForm.DefaultBackColor;
                Subtraction.BackColor = MainForm.DefaultBackColor;
                Multiplication.BackColor = MainForm.DefaultBackColor;
                Division.BackColor = MainForm.DefaultBackColor;
                Percent.BackColor = MainForm.DefaultBackColor;
                Equality.BackColor = MainForm.DefaultBackColor;
                Point.BackColor = MainForm.DefaultBackColor;
            }
        }
        private void DarkBackground_Click(object sender, EventArgs e)
        {
            LightBackground.Checked = false;
            DarkBackground.Checked = true;
            if (DarkBackground.Checked)
            {
                Label.BackColor = Color.DimGray;
                Label.ForeColor = Color.White;
                Panel.BackColor = Color.FromArgb(49, 54, 56);
                Panel2.BackColor = Color.DimGray;
                DarkBackground.ForeColor = Color.White;
                LightBackground.ForeColor = Color.White;
                ZeroButton.BackColor = Color.DimGray;
                OneButton.BackColor = Color.DimGray;
                TwoButton.BackColor = Color.DimGray;
                ThreeButton.BackColor = Color.DimGray;
                FourButton.BackColor = Color.DimGray;
                FiveButton.BackColor = Color.DimGray;
                SixButton.BackColor = Color.DimGray;
                SevenButton.BackColor = Color.DimGray;
                EightButton.BackColor = Color.DimGray;
                NineButton.BackColor = Color.DimGray;
                Point.BackColor = Color.DimGray;
                Clear.BackColor = Color.Gray;
                CE.BackColor = Color.Gray;
                Percent.BackColor = Color.Gray;
                Addition.BackColor = Color.FromArgb(217, 145, 78);
                Subtraction.BackColor = Color.FromArgb(217, 145, 78);
                Multiplication.BackColor = Color.FromArgb(217, 145, 78);
                Division.BackColor = Color.FromArgb(217, 145, 78);
                Equality.BackColor = Color.FromArgb(217, 145, 78);
            }
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
                Clipboard.SetText(label.Text, TextDataFormat.UnicodeText);        
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(Label, "Copy");
        }
    }
}