using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameMaker
{
    public interface I_DrawableCard
    {
        string WhenToDraw { get; set; }
        string WhenToDiscard { get; set; }

        void Draw(string ThisHappens);
    }
}
