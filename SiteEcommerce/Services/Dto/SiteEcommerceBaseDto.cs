using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dto
{
    public class SiteEcommerceBaseDto
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public bool Situacao { get; set; }
        public string Imagem { get; set; }
    }
}
