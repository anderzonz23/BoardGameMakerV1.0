using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameMaker
{
    public interface I_HoldableCard
    {
        string WhenToDiscard { get; set; }
        string WhenToUse { get; set; }

        void UseCard(string ThisHappens);

    }
}
