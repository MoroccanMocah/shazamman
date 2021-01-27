using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamMan
{
    enum ActivityType
    {
    calm,
    moderate,
    strenuous,
    meditation,
    study,
    sad,
    hype,
    driving,
    InMyFeelings,
    InMyShower
    }

    class Activity
    {
        public string ActivityName;
        public ActivityType thisActivityType;

    }
}
