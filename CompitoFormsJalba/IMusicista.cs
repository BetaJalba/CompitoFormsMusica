using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompitoFormsJalba
{
    public interface IMusicista
    {
        string getName();
        void setName(string nome);
        bool isPlaying();
        int getSkillLevel();
    }
}
