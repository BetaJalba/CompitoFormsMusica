using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompitoFormsJalba
{
    public abstract class CStrumento
    {
        protected string sound;
        protected int volume;

        public CStrumento(string sound) 
        {
            this.sound = sound;
            volume = 5;
        }

        public abstract string play();
        public virtual string makeSound() 
        {
            return sound + volume.ToString();
        }
        public void increaseVolume(int amount) 
        {
            volume += amount;
            //volume max = 10
            if (volume > 10)
                volume = 10;
        }

        public void decreaseVolume(int amount) 
        {
            volume -= amount;
            //volume min = 0
            if (volume < 0)
                volume = 0;
        }

        public abstract string toString();
    }
}
