using System;

namespace CoveredLibrary
{
    public class BusinessLogicClass
    {
        public void Execute()
        {
            Sequence();
            IfExecuted();
            IfUnexecuted();
            IfTrueBranchExecuted();
            IfFalseBranchExecuted();
            ForExecutedPartially();
            ForExecutedTotally();
            CaseBranchExecuted();
        }

        private void Sequence()
        {
            Console.WriteLine("Executed");
        }

        private void IfExecuted()
        {
            var i = 1;
            if (i == 1)
            {
                Console.WriteLine("Executed");
            }
        }

        private void IfUnexecuted()
        {
            var i = 0;
            if (i == 1)
            {
                Console.WriteLine("Non-executed");
            }
        }

        private void IfTrueBranchExecuted()
        {
            var i = 1;
            if (i == 1)
            {
                Console.WriteLine("Executed");
            }
            else
            {
                Console.WriteLine("Non-executed");
            }
        }

        private void IfFalseBranchExecuted()
        {
            var i = 0;
            if (i == 1)
            {
                Console.WriteLine("Executed");
            }
            else
            {
                Console.WriteLine("Non-executed");
            }
        }

        private void ForExecutedPartially()
        {
            for (var i = 0; i < 2; ++i)
            {
                Console.WriteLine("Executed");
                return;
            }
        }

        private void ForExecutedTotally()
        {
            for (var i = 0; i < 2; ++i)
            {
                Console.WriteLine("Executed");
            }
        }

        private void CaseBranchExecuted()
        {
            var i = 1;
            switch (i % 3)
            {
                case 0:
                    Console.WriteLine("Non-executed");
                    break;

                case 1:
                    Console.WriteLine("Executed");
                    break;

                case 2:
                    Console.WriteLine("Non-executed");
                    break;
            }
        }
    }
}
