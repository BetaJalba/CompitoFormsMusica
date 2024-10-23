using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompitoFormsJalba
{
    public class CBatterista : CStrumento, IMusicista
    {
        string? name; //"stampi i nomi (se sono settati) presuppongo possano essere null)
        int skillLevel;
        bool _isPlaying;

        public CBatterista(string? name, int skillLevel, bool isPlaying) : base("BAM") 
        {
            this.name = name;
            this.skillLevel = skillLevel;
            this._isPlaying = isPlaying;
        }

        public string getName() 
        {
            return name;
        }

        public void setName(string name) 
        {
            this.name = name;
        }

        public bool isPlaying() 
        {
            return this._isPlaying;
        }

        public int getSkillLevel() 
        {
            return skillLevel;
        }

        public override string makeSound()
        {
            if (name != null)
                return name + skillLevel.ToString();
            return skillLevel.ToString();
        }

        public override string play() 
        {
            if (name != null)
                return name + sound + skillLevel.ToString();
            return sound + skillLevel.ToString();
        }

        public override string toString()
        {
            if (name != null)
                return $"Batterista: {name}, volume {volume}.";
            else
                return $"Batterista: anonimo, volume {volume}.";
        }
    }
}
