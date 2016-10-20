using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Facultate
    {
      
        
        class decanat
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
        
        class Profesor : decanat
        {
            public float nota;
            public float nota1;
            public float nota2;
            public float marire;
      
        
            
             public Profesor(string _dis, string _t, int _c)
             {
                diciplina = _dis;
                tip = _t;
                credite = _c;
                
                nota = _nota;
                nota1 = _nota1;
                nota2 = _nota2;
                marire = _marire;
             }
        
        public void print()
            {
                Console.writeline("Nume disciplina: " + disciplina );
                Console.writeline("Tip evaluare: " +tip );
                Console.writeline("Numar credite: " + credite );
                
                Console.writeline("Nota examen: " + nota );
                Console.writeline("Nota distribuita1: " + nota1 );
                Console.writeline("Nota distribuita 2: " + nota2 );
                Console.writeline("Nota dupa marire: " + marire );
            }
        }
       
        
    
  
 
        public static void main (string[] args)
        {
            Console.Writeline();
            decanat disciplina1 = new decanat("Algebra ", "Examen", 5);
            disciplina1.nota=6;
            disciplina1.print();
            Console.Writeline();
            decanat disciplina2 = new decanat("Fizica ", "Examen distribuit", 4);
            disciplina2.nota1=5;
            disciplina2.nota2=7;
            disciplina2.marire=disciplina2.nota1 + 2;
            disciplina2.print();
                
            
        }
    }
    
}
