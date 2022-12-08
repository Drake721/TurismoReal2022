using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Objeto
    {
        private int _id_obj;
        private int _codigo_objeto;
        private string _nombre_objeto;
        private int _cant_objeto;
        private int _valor;

        public int Id_obj { get => _id_obj; set => _id_obj = value; }
        public int Codigo_objeto { get => _codigo_objeto; set => _codigo_objeto = value; }
        public string Nombre_objeto { get => _nombre_objeto; set => _nombre_objeto = value; }
        public int Cant_objeto { get => _cant_objeto; set => _cant_objeto = value; }
        public int Valor { get => _valor; set => _valor = value; }
    }
}
