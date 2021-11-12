using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public abstract class Animal
    {
        //BAseclass icerisinde sleep metodu hamisinda eyni isi goren
        //ekrana animal sleeps yazisini cixart
        //metod animal sound
        public void Sleep()
        {
            Console.WriteLine("heyvan yatir");
        }
        public abstract void AnimalSound()  ;
    }
}
