using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jasonChallangePrimNumbers
{
    public partial class Defualt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }       

        protected void checkPrimeButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            CheckIfNumberIsPrime();
           
        }      
        
        private void CheckIfNumberIsPrime ()
        {            
            int number = 1;
            //Validate that a number is entered
            if (!int.TryParse(numberTextBox.Text.Trim(), out number)) resultLabel.Text = "Please enter a valid number ";
            //check if the number entered is a positive number
            else if (number < 0) resultLabel.Text = "Please enter a positive number";
            //Start count and print results
            else
            {                
                number = int.Parse(numberTextBox.Text.Trim());
                for (int i = 1; i <= number; i++)
                {
                    bool prime = IsPrime(i);
                    //UL/LI bold and red font 
                    if (prime) resultLabel.Text += String.Format("<span style=\"color:red;\"><b><ul><li> {0} is Prime</li></ul></b></span>", i);
                    //standard font 
                    else resultLabel.Text += String.Format("<ul><li> {0} </li></ul>", i);
                }
            }
            
            
        }
        //chek to see all numbers from 1 to the number entered that are prime 
        private bool IsPrime(int numbers)
        {
            if ((numbers & 1) ==0)
            {
                if (numbers == 2) return true;
                else return false;
            }
            for (int i = 3; (i * i) <= numbers; i += 2)
            {
                if ((numbers % i) == 0) return false;
            }
            return numbers != 1;
        }
    }
    
}