using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ohhell.ContainerClasses
{
    public class User
    {
        private string userName;
        private string password;
        private int totalScore;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int TotalScore { get => totalScore; set => totalScore = value; }
    }
}
