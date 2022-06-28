using System;
using System.Collections.Generic;
using System.Text;

namespace ReizTechHomework.BranchTask
{
    class MainProgram
    {

        public static Branch InitDummyBranch()
        {
            // same as seen in homework task

            // depth 1
            Branch root = new Branch();

            // depth 2
            Branch temp = new Branch();
            root.Branches.Add(temp);

            temp = new Branch();
            root.Branches.Add(temp);

            // depth 3
            temp = new Branch();
            root.Branches[0].Branches.Add(temp);

            temp = new Branch();
            root.Branches[1].Branches.Add(temp);

            temp = new Branch();
            root.Branches[1].Branches.Add(temp);

            temp = new Branch();
            root.Branches[1].Branches.Add(temp);

            // depth 4
            temp = new Branch();
            root.Branches[1].Branches[0].Branches.Add(temp);

            temp = new Branch();
            root.Branches[1].Branches[1].Branches.Add(temp);

            temp = new Branch();
            root.Branches[1].Branches[1].Branches.Add(temp);

            // depth 5
            temp = new Branch();
            root.Branches[1].Branches[1].Branches[0].Branches.Add(temp);

            return root;
        }

        public static void Run()
        {
            Console.WriteLine("Initializing structure ...");
            int depth = BranchUtil.CalcDepth(MainProgram.InitDummyBranch());
            Console.WriteLine($"Calculated depth of structure: {depth}");
        }
    }
}
