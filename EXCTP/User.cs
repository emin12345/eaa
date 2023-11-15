using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCTP
{
    public class User 
    {
        private int _id;
        public int Id { get; }
        public string Fullname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }



public User(string email, string password)
    {
          Email = email;
            Password = password;

            Id=_id;
            _id++;

    }

        public bool PasswordChecker(string Password)
        {
            

            bool upperChar = false;
            bool lowerChar = false;
            bool isNum=false;

            for(int i = 0; i < Password.Length; i++)
            {

                if (char.IsUpper(Password[i]))
                {
                    upperChar = true;
                    
                }
                else
                {
                    lowerChar= true;
                        
                }
            }
           for(int i = 0;i < Password.Length; i++)
            {
                if (char.IsNumber(Password[i]))
                {
                    isNum = true;
                    break;

                }
            }
           if(Password.Length>8 && upperChar && lowerChar && isNum)
            {
                return true;

            }

        }

        public void ShowInfo()
        {

            Console.WriteLine($"{Id}=Id {Fullname}=Fullname {Email}=Email");
        }

    }

    


    
}
