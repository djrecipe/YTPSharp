using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YTPSharp.Media;

namespace YTPSharp.Analysis
{
    interface IYTPMediaAnalyzer
    {
        YTPMediaAnalysis Analyzie(IYTPMedia media);
    }
}
