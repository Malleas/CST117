using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class CalorieCalculator
    {
        double fat;
        double carbs;
        double caloriesFromFat;
        double caloriesFromCarbs;

        public CalorieCalculator() { }

        public CalorieCalculator(double fat, double carbs) {
            this.fat = fat;
            this.carbs = carbs;

        }

        private void FatCalories(double fat)
        {
            caloriesFromFat = fat * 9;
        }

        private void CarbCalories(double carbs)
        {
            caloriesFromCarbs = carbs * 4;
        }

        public void setFat(double fat)
        {
            this.fat = fat;
        }

        public double getFat()
        {
            return fat;
        }
        public void setCarbs(double carbs)
        {
            this.carbs = carbs;
        }

        public double getCarbs()
        {
            return carbs;
        }



    }
}
