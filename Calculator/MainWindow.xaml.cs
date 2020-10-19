using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static double number1 = 0;
        public static double number2 = 0;
        public static string operatorSign = "thing";
        public static int funnyMakeSure = 0;
        public static int funnyMakeSure2 = 0;
        //public static int howManyEquationRuns = 0;
           
        public MainWindow()
        {
            InitializeComponent();
            
        }
        //Number Buttons
        private void CalcNumberButton1_Click(object sender, RoutedEventArgs e)
        {
            if (funnyMakeSure == 1)
            {
                Answer_Box.Text = "0";
                funnyMakeSure = 0;
                number2 = 0;
            }
            if (Answer_Box.Text.Contains("."))
            {
                Answer_Box.Text = Answer_Box.Text + "1";

            }
            else
            {
                Answer_Box.Text = Convert.ToString((Convert.ToDouble(Answer_Box.Text) * 10) + 1);
            }
        }

        private void CalcNumberButton2_Click(object sender, RoutedEventArgs e)
        {
            if (funnyMakeSure == 1)
            {
                Answer_Box.Text = "0";
                funnyMakeSure = 0;
                number2 = 0;
            }
            if (Answer_Box.Text.Contains("."))
            {
                Answer_Box.Text = Answer_Box.Text + "2";

            }
            else
            {
                Answer_Box.Text = Convert.ToString((Convert.ToDouble(Answer_Box.Text) * 10) + 2);
            }
        }

        private void CalcNumberButton3_Click(object sender, RoutedEventArgs e)
        {
            if (funnyMakeSure == 1)
            {
                Answer_Box.Text = "0";
                funnyMakeSure = 0;
                number2 = 0;
            }
            if (Answer_Box.Text.Contains("."))
            {
                Answer_Box.Text = Answer_Box.Text + "3";

            }
            else
            {
                Answer_Box.Text = Convert.ToString((Convert.ToDouble(Answer_Box.Text) * 10) + 3);
            }
        }

        private void CalcNumberButton4_Click(object sender, RoutedEventArgs e)
        {
            if (funnyMakeSure == 1)
            {
                Answer_Box.Text = "0";
                funnyMakeSure = 0;
                number2 = 0;
            }
            if (Answer_Box.Text.Contains("."))
            {
                Answer_Box.Text = Answer_Box.Text + "4";

            }
            else
            {
                Answer_Box.Text = Convert.ToString((Convert.ToDouble(Answer_Box.Text) * 10) + 4);
            }
        }

        private void CalcNumberButton5_Click(object sender, RoutedEventArgs e)
        {
            if (funnyMakeSure == 1)
            {
                Answer_Box.Text = "0";
                funnyMakeSure = 0;
                number2 = 0;
            }
            if (Answer_Box.Text.Contains("."))
            {
                Answer_Box.Text = Answer_Box.Text + "5";

            }
            else
            {
                Answer_Box.Text = Convert.ToString((Convert.ToDouble(Answer_Box.Text) * 10) + 5);
            }
        }

        private void CalcNumberButton6_Click(object sender, RoutedEventArgs e)
        {
            if (funnyMakeSure == 1)
            {
                Answer_Box.Text = "0";
                funnyMakeSure = 0;
                number2 = 0;
            }
            if (Answer_Box.Text.Contains("."))
            {
                Answer_Box.Text = Answer_Box.Text + "6";

            }
            else
            {
                Answer_Box.Text = Convert.ToString((Convert.ToDouble(Answer_Box.Text) * 10) + 6);
            }
        }

        private void CalcNumberButton7_Click(object sender, RoutedEventArgs e)
        {
            if (funnyMakeSure == 1)
            {
                Answer_Box.Text = "0";
                funnyMakeSure = 0;
                number2 = 0;
            }
            if (Answer_Box.Text.Contains("."))
            {
                Answer_Box.Text = Answer_Box.Text + "7";

            }
            else
            {
                Answer_Box.Text = Convert.ToString((Convert.ToDouble(Answer_Box.Text) * 10) + 7);
            }
        }

        private void CalcNumberButton8_Click(object sender, RoutedEventArgs e)
        {
            if (funnyMakeSure == 1)
            {
                Answer_Box.Text = "0";
                funnyMakeSure = 0;
                number2 = 0;
            }
            if (Answer_Box.Text.Contains("."))
            {
                Answer_Box.Text = Answer_Box.Text + "8";

            }
            else
            {
                Answer_Box.Text = Convert.ToString((Convert.ToDouble(Answer_Box.Text) * 10) + 8);
            }
        }

        private void CalcNumberButton9_Click(object sender, RoutedEventArgs e)
        {
            if (funnyMakeSure == 1)
            {
                Answer_Box.Text = "0";
                funnyMakeSure = 0;
                number2 = 0;
            }
            if (Answer_Box.Text.Contains("."))
            {
                Answer_Box.Text = Answer_Box.Text + "9";

            }
            else
            {
                Answer_Box.Text = Convert.ToString((Convert.ToDouble(Answer_Box.Text) * 10) + 9);
            }
        }

        private void CalcNumberButton0_Click(object sender, RoutedEventArgs e)
        {
            if (funnyMakeSure == 1)
            {
                Answer_Box.Text = "0";
                funnyMakeSure = 0;
                number2 = 0;
            }
            if (Answer_Box.Text.Contains("."))
            {
                Answer_Box.Text = Answer_Box.Text + "0";

            }
            else
            {
                Answer_Box.Text = Convert.ToString((Convert.ToDouble(Answer_Box.Text) * 10));
            }
        }
        //Clear All
        private void CalcMiscClearAll_Click(object sender, RoutedEventArgs e)
        {
            Answer_Box.Text = "0";
            number1 = 0;
            number2 = 0;
            operatorSign = "thing";
        }
        //Common Operators
        private void CalcOperatorAdd_Click(object sender, RoutedEventArgs e)
        {
            if (number1 != 0)
            {
                number2 = Convert.ToDouble(Answer_Box.Text);
            }
            if (number2 == 0)
            {
                
                if (operatorSign != "thing" && number2 == 0)
                {
                    
                    operatorSign = "+";
                    Answer_Box.Text = Convert.ToString(number1);

                    
                }
                else
                {
                    operatorSign = "+";
                    number1 = Convert.ToDouble(Answer_Box.Text);
                    Answer_Box.Text = "0";
                }
                
            }
            if (number2 != 0)
            {
                solveEquation();
                number1 = Convert.ToDouble(Answer_Box.Text);
                if (operatorSign != "thing")
                {

                    operatorSign = "+";
                    Answer_Box.Text = Convert.ToString(number1);

                }
            }
        }
       
        private void CalcOperatorSubtract_Click(object sender, RoutedEventArgs e)
        {
            
                if (number1 != 0)
                {
                    number2 = Convert.ToDouble(Answer_Box.Text);
                }
                if (number2 == 0)
                {

                    if (operatorSign != "thing" && number2 == 0)
                    {

                        operatorSign = "-";
                        Answer_Box.Text = Convert.ToString(number1);


                    }
                    else
                    {
                        operatorSign = "-";
                        number1 = Convert.ToDouble(Answer_Box.Text);
                        Answer_Box.Text = "0";
                    }

                }
                if (number2 != 0)
                {
                    solveEquation();
                    number1 = Convert.ToDouble(Answer_Box.Text);
                    if (operatorSign != "thing")
                    {

                        operatorSign = "-";
                        Answer_Box.Text = Convert.ToString(number1);

                    }
                }
            
        }

        private void CalcOperatorMultiply_Click(object sender, RoutedEventArgs e)
        {
            
                if (number1 != 0)
                {
                    number2 = Convert.ToDouble(Answer_Box.Text);
                }
                if (number2 == 0)
                {

                    if (operatorSign != "thing" && number2 == 0)
                    {

                        operatorSign = "*";
                        Answer_Box.Text = Convert.ToString(number1);


                    }
                    else
                    {
                        operatorSign = "*";
                        number1 = Convert.ToDouble(Answer_Box.Text);
                        Answer_Box.Text = "0";
                    }

                }
                if (number2 != 0)
                {
                    solveEquation();
                    number1 = Convert.ToDouble(Answer_Box.Text);
                    if (operatorSign != "thing")
                    {

                        operatorSign = "*";
                        Answer_Box.Text = Convert.ToString(number1);

                    }
                }
            
        }

        private void CalcOperatorDivide_Click(object sender, RoutedEventArgs e)
        {
            
                if (number1 != 0)
                {
                    number2 = Convert.ToDouble(Answer_Box.Text);
                }
                if (number2 == 0)
                {

                    if (operatorSign != "thing" && number2 == 0)
                    {

                        operatorSign = "/";
                        Answer_Box.Text = Convert.ToString(number1);


                    }
                    else
                    {
                        operatorSign = "/";
                        number1 = Convert.ToDouble(Answer_Box.Text);
                        Answer_Box.Text = "0";
                    }

                }
                if (number2 != 0)
                {
                    solveEquation();
                    number1 = Convert.ToDouble(Answer_Box.Text);
                    if (operatorSign != "thing")
                    {

                        operatorSign = "/";
                        Answer_Box.Text = Convert.ToString(number1);

                    }
                }
            
        }
        //Misc Buttons
        private void CalcMiscSquareRoot_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(Answer_Box.Text);
            number1 = Convert.ToDouble(Math.Sqrt(number1));
            Answer_Box.Text = Convert.ToString(number1);
            number1 = 0;
        }

        private void CalcMiscSquare_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(Answer_Box.Text);
            number1 = number1 * number1;
            Answer_Box.Text = Convert.ToString(number1);
            number1 = 0;
        }

        private void CalcMiscExponents_Click(object sender, RoutedEventArgs e)
        {
            if (number1 != 0)
            {
                number2 = Convert.ToDouble(Answer_Box.Text);
            }
            if (number2 == 0)
            {

                if (operatorSign != "thing" && number2 == 0)
                {

                    operatorSign = "^";
                    Answer_Box.Text = Convert.ToString(number1);


                }
                else
                {
                    operatorSign = "^";
                    number1 = Convert.ToDouble(Answer_Box.Text);
                    Answer_Box.Text = "0";
                }

            }
            if (number2 != 0)
            {
                solveEquation();
                number1 = Convert.ToDouble(Answer_Box.Text);
                if (operatorSign != "thing")
                {

                    operatorSign = "^";
                    Answer_Box.Text = Convert.ToString(number1);

                }
            }
        }
    

        private void CalcMiscNegative_Click(object sender, RoutedEventArgs e)
        {
            Answer_Box.Text = Convert.ToString(Convert.ToDouble(Answer_Box.Text) * -1);
        }
        private void CalcMiscDecimal_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(Answer_Box.Text) % 1 == 0)
            {
                Answer_Box.Text = Answer_Box.Text + ".";

            }
        }
        //Equal Sign
        private void CalcEqualSign_Click(object sender, RoutedEventArgs e)
        {
            if (number1 != 0 && operatorSign == "thing")
            {
                Answer_Box.Text = Convert.ToString(number1);
                ClearVariablesExceptAnswerBox();


            }
            else if (operatorSign != "thing")
            {
                number2 = Convert.ToDouble(Answer_Box.Text);
                if (operatorSign == "+")
                {
                    Answer_Box.Text = Convert.ToString(number1 + number2);
                    ClearVariablesExceptAnswerBox();
                }
                else if (operatorSign == "-")
                {
                    Answer_Box.Text = Convert.ToString(number1 - number2);
                    ClearVariablesExceptAnswerBox();
                }
                else if (operatorSign == "*")
                {
                    Answer_Box.Text = Convert.ToString(number1 * number2);
                    ClearVariablesExceptAnswerBox();
                }
                else if (operatorSign == "/")
                {
                    Answer_Box.Text = Convert.ToString(number1 / number2);
                    ClearVariablesExceptAnswerBox();
                }
                else if (operatorSign == "^")
                {
                    Answer_Box.Text = Convert.ToString(Math.Pow(number1, number2));
                    ClearVariablesExceptAnswerBox();
                }
            }
            funnyMakeSure = 1;
            funnyMakeSure2 = 1;
            //howManyEquationRuns++;
        }
        public void solveEquation()
        {
            
            if (number1 != 0 && operatorSign == "thing")
            {
                Answer_Box.Text = Convert.ToString(number1);
                ClearVariablesExceptAnswerBox();


            }
            else if (operatorSign != "thing")
            {
                number2 = Convert.ToDouble(Answer_Box.Text);
                if (operatorSign == "+")
                {
                    Answer_Box.Text = Convert.ToString(number1 + number2);
                    ClearVariablesExceptAnswerBox();
                }
                else if(operatorSign == "-")
                {
                    Answer_Box.Text = Convert.ToString(number1 - number2);
                    ClearVariablesExceptAnswerBox();
                }
                else if (operatorSign == "*")
                {
                    Answer_Box.Text = Convert.ToString(number1 * number2);
                    ClearVariablesExceptAnswerBox();
                }
                else if (operatorSign == "/")
                {
                    Answer_Box.Text = Convert.ToString(number1 / number2);
                    ClearVariablesExceptAnswerBox();
                }
                else if (operatorSign == "^")
                {
                    Answer_Box.Text = Convert.ToString(Math.Pow(number1, number2));
                    ClearVariablesExceptAnswerBox();
                }
            }
            funnyMakeSure = 1;
            funnyMakeSure2 = 1;
            //howManyEquationRuns ++;
        }
        public void ClearVariables()
        {
            Answer_Box.Text = "0";
            number1 = 0;
            number2 = 0;
            operatorSign = "thing";
            //howManyEquationRuns++;
        }
        public void ClearVariablesExceptAnswerBox()
        {
            number1 = 0;
            number2 = 0;
            operatorSign = "thing";
            
        }
        
    }
}
