using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "4";
            }
            else
            {
                textbox1.Text = textbox1.Text + "4";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "2";
            }
            else
            {
                textbox1.Text = textbox1.Text + "2";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "3";
            }
            else
            {
                textbox1.Text = textbox1.Text + "3";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adityaPranavBhuvanapalliToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "0";
            }
            else
            {
                textbox1.Text = textbox1.Text + "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "1";
            }
            else
            {
                textbox1.Text = textbox1.Text + "1";
            }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "5";
            }
            else
            {
                textbox1.Text = textbox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "6";
            }
            else
            {
                textbox1.Text = textbox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "7";
            }
            else
            {
                textbox1.Text = textbox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "8";
            }
            else
            {
                textbox1.Text = textbox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "9";
            }
            else
            {
                textbox1.Text = textbox1.Text + "9";
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "(";
            }
            else
            {
                textbox1.Text = textbox1.Text + "(";
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = ")";
            }
            else
            {
                textbox1.Text = textbox1.Text + ")";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "+";
            }
            else
            {
                textbox1.Text = textbox1.Text + "+";
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "-";
            }
            else
            {
                textbox1.Text = textbox1.Text + "-";
            }
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "*";
            }
            else
            {
                textbox1.Text = textbox1.Text + "*";
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "/";
            }
            else
            {
                textbox1.Text = textbox1.Text + "/";
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "";
            }
            else
            {
                textbox1.Text = textbox1.Text + ".";
            }
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            textbox1.Text = "0";
        }
       

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            decimal d;
            if (MathsEvaluator.TryParse(textbox1.Text, out d))
            {
                textbox1.Text = d.ToString();
            }
            else
            {
                textbox1.Text = "0";

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adityaPranavBhuvanapalliToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        public static class MathsEvaluator
        {
            public static decimal Parse(string expression)
            {
                decimal d;
                if (decimal.TryParse(expression, out d))
                {
                    return d;
                }
                else
                {
                    return CalculateValue(expression);
                }
            }

            public static bool TryParse(string expression, out decimal value)
            {
                if (IsExpression(expression))
                {
                    try
                    {
                        value = Parse(expression);
                        return true;
                    }
                    catch
                    {
                        value = 0;
                        return false;
                    }
                }
                else
                {
                    value = 0;
                    return false;
                }
            }

            public static bool IsExpression(string s)
            {
                Regex RgxUrl = new Regex("^[0-9+*-/^()., ]+$");
                return RgxUrl.IsMatch(s);
            }
            
            private static List<string> TokenizeExpression(string expression, Dictionary<char, int> operators)
            {
                List<string> elements = new List<string>();
                string currentElement = string.Empty;

                int state = 0;
                int bracketCount = 0;
                for (int i = 0; i < expression.Length; i++)
                {
                    switch (state)
                    {
                        case 0:
                            if (expression[i] == '(')
                            {
                                state = 1;
                                bracketCount = 0;
                                if (currentElement != string.Empty)
                                {
                                    elements.Add(currentElement);
                                    elements.Add("*");
                                    currentElement = string.Empty;
                                }
                            }
                            else if (operators.Keys.Contains(expression[i]))
                            {
                                elements.Add(currentElement);
                                elements.Add(expression[i].ToString());
                                currentElement = string.Empty;
                            }
                            else if (expression[i] != ' ')
                            {
                                currentElement += expression[i];
                            }
                            break;
                        case 1:
                            if (expression[i] == '(')
                            {
                                bracketCount++;
                                currentElement += expression[i];
                            }
                            else if (expression[i] == ')')
                            {
                                if (bracketCount == 0)
                                {
                                    state = 2;
                                }
                                else
                                {
                                    bracketCount--;
                                    currentElement += expression[i];
                                }
                            }
                            else if (expression[i] != ' ')
                            {
                                currentElement += expression[i];
                            }
                            break;
                        case 2:
                            if (operators.Keys.Contains(expression[i]))
                            {
                                state = 0;
                                elements.Add(currentElement);
                                currentElement = string.Empty;
                                elements.Add(expression[i].ToString());
                            }
                            else if (expression[i] != ' ')
                            {
                                elements.Add(currentElement);
                                elements.Add("*");
                                currentElement = string.Empty;


                                if (expression[i] == '(')
                                {
                                    state = 1;
                                    bracketCount = 0;
                                }
                                else
                                {
                                    currentElement += expression[i];
                                    state = 0;
                                }
                            }
                            break;
                    }
                }
                
                if (currentElement.Length > 0)
                {
                    elements.Add(currentElement);
                }

                return elements;
            }
            
            private static decimal CalculateValue(string expression)
            {
                Dictionary<char, int> operators = new Dictionary<char, int>
                {
                    {'+', 1}, {'-', 1}, {'*', 2}, {'/', 2}, {'^', 3}
                };
                
                List<string> elements = TokenizeExpression(expression, operators);
                
                decimal value = 0;

                for (int i = operators.Values.Max(); i >= operators.Values.Min(); i--)
                {
                    while (elements.Count >= 3
                        && elements.Any(element => element.Length == 1 &&
                            operators.Where(op => op.Value == i)
                            .Select(op => op.Key).Contains(element[0])))
                    {
                        int pos = elements
                            .FindIndex(element => element.Length == 1 &&
                            operators.Where(op => op.Value == i)
                            .Select(op => op.Key).Contains(element[0]));
                        
                        value = EvaluateOperation(elements[pos], elements[pos - 1], elements[pos + 1]);
                        elements[pos - 1] = value.ToString();
                        elements.RemoveRange(pos, 2);
                    }
                }

                return value;
            }

            private static decimal EvaluateOperation(string oper, string operand1, string operand2)
            {
                if (oper.Length == 1)
                {
                    decimal op1 = Parse(operand1);
                    decimal op2 = Parse(operand2);

                    decimal value = 0;
                    switch (oper[0])
                    {
                        case '+':
                            value = op1 + op2;
                            break;
                        case '-':
                            value = op1 - op2;
                            break;
                        case '*':
                            value = op1 * op2;
                            break;
                        case '/':
                            value = op1 / op2;
                            break;
                        default:
                            throw new ArgumentException("Unsupported operator");
                    }
                    return value;
                }
                else
                {
                    throw new ArgumentException("Unsupported operator");
                }
            }
        }

        private void viewHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe","about.txt");
        }

        private void adityaPranavBhuvanapalliToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "Aditya Pranav Bhuvanapalli.txt");
        }
    }
}
