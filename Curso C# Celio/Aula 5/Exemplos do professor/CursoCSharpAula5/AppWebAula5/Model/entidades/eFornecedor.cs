using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppWebAula5.Model.helpers;

namespace AppWebAula5.Model.entidades
{
    public class eFornecedor : ePessoa
    {
        Enums.TipoPessoa TipoPessoa { get; set; }
    }
}