﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* BMI_Calculator App
 * Author: Mushfika Farzana
 * ID# 301051702
 * Last Modified: July 25, 2019
 * Description: Takes user's height and weight and calculates BMI condition
 * Last Modified: July 25, 2019
 */
namespace COMP123_S2019_BMI_Calculator
{
    static class Program
    {
        public static SplashForm splashScreen;
        public static BMICalculatorForm BMIcalculatorForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            splashScreen = new SplashForm();
            BMIcalculatorForm = new BMICalculatorForm();
            Application.Run(new SplashForm());
        }
    }
}
