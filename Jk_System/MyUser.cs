using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFirebase
{
    public class MyUser
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Cargo { get; set; }
        public string Fullname { get; set; }
        public string NICno { get; set; }

        private static string error= "USUARIO INEXISTENTE";

        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }

        public static bool IsEqual(MyUser user1, MyUser user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.Nome != user2.Nome)
            {
                error = "USUARIO INEXISTENTE!";
                return false;
            }

            else if (user1.Senha != user2.Senha)
            {
                error = "NOME OU SENHA NAO CORRESPONDEM!";
                return false;
            }

            return true;
        }
    }
}
