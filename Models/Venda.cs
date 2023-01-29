using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio_bootcamp_Pottencial_dotnet.Models
{
    public class Venda
    {
        public int Id { get; set; } 
        public int IntensVendidos { get; set; }

        public Funcionario Vendedor { get; set; }
        public DateTime Data { get; set; }
    }
}