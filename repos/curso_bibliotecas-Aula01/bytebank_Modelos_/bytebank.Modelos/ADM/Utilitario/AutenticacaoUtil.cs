﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_Modelos_.bytebank.Modelos.ADM.Utilitario
{
    internal class AutenticacaoUtil
    {
        public bool ValidarSenha(string senhaverdadeira, string senhatentativa)
        {
            return senhaverdadeira.Equals(senhatentativa);
        }
    }
}
