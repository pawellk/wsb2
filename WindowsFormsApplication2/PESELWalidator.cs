using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walidator
{
    public class PESELWalidator
    {
        protected int[] weight = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        protected int[] pesel;

        public PESELWalidator(String pesel)
        {
            LoadPesel(pesel);    
        }

        public void LoadPesel(String pesel)
        {
            this.pesel = new int[pesel.Length];
            char[] peselChar = pesel.ToCharArray();
            for(int i=0; i<peselChar.Length; i++)
            {
                this.pesel[i] = int.Parse(peselChar[i].ToString());
            }

        }

        public int ControlSum()
        {
            
            int sum = 0;
            for (int i = 0; i < this.weight.Length; i++)
            {
                sum += this.weight[i] * this.pesel[i];
            }

            int ControlNum = sum % 10;
            if (ControlNum != 0)
            {
                ControlNum = 10 - ControlNum;
            }

            return ControlNum;
        }

        public String DateOfBirth()
        {
            if (pesel == null)
            {
                return null;
            }
                      
            int month = (10*this.pesel[2]) + this.pesel[3];
            int year = 0;
            if(month >= 81 && month <= 92)
            {
                year = 1800;
                month -= 80;
            }else if(month >= 21 && month <=32)
            {
                year = 2000;
                month -= 20;
            } else if(month >= 1 && month <= 12)
            {
                year = 1900;
            }
            year += (this.pesel[0] * 10) + this.pesel[1];
            int day = (10 * this.pesel[4]) + this.pesel[5];
            
            StringBuilder data = new StringBuilder();
            if(day < 10)
            {
                data.Append("0");
            }
            data.Append(day.ToString());
            data.Append(".");
            if(month < 10)
            {
                data.Append("0");
            }
            data.Append(month.ToString());
            data.Append(".");
            data.Append(year.ToString());

            return data.ToString();
        }

        public String Sex()
        {
            if(pesel == null)
            {
                return null;
            }
            String sex = null;
            if(this.pesel[9] % 2 != 0)
            {
                sex = "Man";
            } else
            {
                sex = "Woman";
            }
            return sex;
        }

        public Boolean CheckPesel()
        {
            if (this.pesel == null || this.pesel.Length!= 11)
            {
                return false;
            }

            int Controlsum = ControlSum();
            Boolean poprawny = Controlsum == this.pesel[10];
            return poprawny;
        }

    }

}
