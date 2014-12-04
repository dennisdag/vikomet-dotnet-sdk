using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.UserManagement
{
    public enum Scope
    {

        //TODO: Mudar para acoes e nao nomes das rotas

        api_client = 1,
        user_logon = 2,
        backoffice_logon = 3,
        api_pvt_account_user_get_id = 4,
        api_pvt_account_user_get_id_extendedproperty_name=5,
        api_pvt_account_user_put_id_extendedproperty_name = 6,
        api_pvt_account_user_post_update=7,
        api_pvt_account_user_post_changepassword = 8
    }
}
