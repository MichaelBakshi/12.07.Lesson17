using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen father = new Citizen("Father", 11111, 11112);

            Citizen firstChild = new Citizen("Avraham", 11112, 11113);
            Citizen secondChild = new Citizen("Yitzhak", 11112, 11114);
            Citizen thirdChild = new Citizen("Yaakov", 11112, 11115);

            Citizen[] childrenOfFather = new Citizen[3];
            childrenOfFather[0] = firstChild;
            childrenOfFather[1] = secondChild;
            childrenOfFather[2] = thirdChild;
            father.SetChildren(childrenOfFather);

            Console.WriteLine(HasChildren(father));
            Console.WriteLine(CheckValidity(father));
        }

         static bool HasChildren(Citizen citizen)
        {
            return citizen.children != null && citizen.children.Length > 0;
        }

         static bool CheckValidity (Citizen citizen)
        {
            if (HasChildren(citizen)) 
            {
             
                for (int i = 0; i < citizen.children.Length; i++)
                {                    
                    if (citizen.children[i]._id != citizen.children[i]._fatherID)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            return false;
        }
    }
}
