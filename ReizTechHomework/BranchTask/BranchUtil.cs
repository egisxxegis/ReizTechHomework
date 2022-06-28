using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReizTechHomework.BranchTask
{
    class BranchUtil
    {
        public static int CalcDepth(Branch branch)
        {
            if (branch == null)
            {
                return 0;
            }

            if (branch.Branches == null || branch.Branches.Count == 0)
            {
                return 1;
            }

            List<int> depthList = new List<int>();
            foreach (var child in branch.Branches)
            {
                depthList.Add(CalcDepth(child));
            }

            return depthList.Max() + 1;
        }
    }
}
