using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Decanat
    {
        public string disciplina;
        public string tip;
        public int credite;
        
        
        
        public decanat(string dis, string t, int c)
        {
            diciplina = dis;
            tip = t;
            credite = c;
        }
        
        public void print()
        {
            Console.writeline("Nume disciplina: " + disciplina );
            Console.writeline("Tip evaluare: " +tip );
            Console.writeline("Numar credite: " + credite );
        }
        
        
    }
    class Profesor
    {
        
        
    }
    
    class Student
    {
        
    }
    class Facultate
    {
        public static void main (string[] args)
        {
            Console.Writeline();
            decanat disciplina = new decanat("Algebra ", "Examen", 5);
            
            disciplina.print();
                
            
        }
    }
}
