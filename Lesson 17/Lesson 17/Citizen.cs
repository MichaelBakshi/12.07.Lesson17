using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17
{
    class Citizen
    {
        public string _name;
        public Citizen[] children;
        public readonly int _fatherID;
        public readonly int _id;
        public static int _numberOfCurrentCitizens;
        public const int _maximunNumberOfCitizens = 0;

        public Citizen(string _name, int _fatherID, int _id)
        {
            this._name = _name;
            this._fatherID = _fatherID;
            this._id = _id;
        }

        public static void PrintNumberOfCitizens()
        {
            Console.WriteLine(_numberOfCurrentCitizens);
        }

        public static bool ReachedHalfOfMaximumSize()
        {
            if (_numberOfCurrentCitizens >= _maximunNumberOfCitizens / 2)
                return true;
            else
                return false;
        }

        public void PrintID()
        {
            Console.WriteLine(_id);
        }

        public void PrintGapBetweenMyIDAndFather()
        {
            Console.WriteLine(Math.Abs(_fatherID - _id));
        }

        public void SetChildren(Citizen[] citizens)
        {
            children = citizens;
        }

        public override string ToString()
        {
            return base.ToString();
        }





       
    }
}
