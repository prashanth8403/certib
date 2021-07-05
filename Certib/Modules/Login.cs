/* 
 * -------------------------------------------------------------------------------
 * |    LOGIN MODULE                                                             | 
 * -------------------------------------------------------------------------------
 * 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Web;
using MySql.Data.MySqlClient;

namespace Certib.Modules
{
    public class Login
    {
        /// <summary>
        /// This method validates the specified USERNAME and PASSWORD
        /// <example>
        ///     For example:
        ///     <code>
        ///          Login <instanceoflogin> = new Login()
        ///          if(<instanceoflogin>.validate)
        ///             >>NEXT PHASE
        ///     </code>
        ///     RESULT:
        /// </example>
        /// </summary>
        public bool Validate(string USERNAME, string PASSWORD)
        {
            // connect : Local Instance of Connection String
            MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["CertibConnect"].ConnectionString);
            string Query = "SELECT COUNT(*) FROM usercredentials where EMAIL='" + USERNAME + "' AND PASSWORD='" + PASSWORD + "'";
            connect.Open();
            MySqlCommand LoginProcess = new MySqlCommand(Query, connect);
            bool Flag = Convert.ToBoolean(LoginProcess.ExecuteScalar());
            connect.Close();
            return Flag;
        }
    }
}