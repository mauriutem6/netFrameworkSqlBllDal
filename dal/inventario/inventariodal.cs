using inventarioapi.utiles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace inventarioapi.dal
{
    public sealed class inventariodal
    {
        public string get_usuarios()
        {
            string sql = "";
            sql = "select * from [inventario].[dbo].[usuario]";
            try
            {
                DataTable lista = ssql.runSelect(sql);
                var listax = DataSetExtensions.ToDictionaryList(lista);
                return JsonConvert.SerializeObject(new { mensaje = "", error = "0", data = lista });
            }
            catch (Exception e)
            {
                return JsonConvert.SerializeObject(new { mensaje = e.Message, error = "1", data = "" });
            }
        }


    }
}
