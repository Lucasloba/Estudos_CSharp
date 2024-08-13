using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank_MaoNaMassa_
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public int CPF 
        {
            get
            {
                return CPF;
            }
            set
            {
                if(value == 40028922) 
                {
                    CPF = 0;
                }
                else
                {
                    CPF = value;
                }
               
            }
        }


    }
}
