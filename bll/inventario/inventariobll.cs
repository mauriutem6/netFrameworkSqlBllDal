using inventarioapi.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace inventarioapi.bll
{
    public sealed class inventariobll
    {
        inventariodal objeto_dal = new inventariodal();
        public string get_usuarios()
        {
            return objeto_dal.get_usuarios();


        }

        
    }
}
