using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NumberSystemsCalculator.Model
{
    class MainModel
    {
        public static void TransformNumber(string value, int inTheNumberSystem)
        {
            string result = string.Empty;
            if (int.TryParse(value, out int IsNeedTransform) && IsNeedTransform > 0 && inTheNumberSystem > 0)
            {
                do
                {
                    result = "0123456789ABCDEF"[IsNeedTransform % inTheNumberSystem] + result;
                    IsNeedTransform /= inTheNumberSystem;
                }
                while (IsNeedTransform > 0);
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Could not convert number");
            }
        }
    }
}
