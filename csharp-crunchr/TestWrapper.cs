using System;
using System.Threading.Tasks;

namespace pi_cruncher
{
    static class TestWrapper
    {
        public static double Matrixer(int dummy)
        {
            return 0.0 + TestImplementations.MatrixMultiplier(150);
        }
        public static double LoremChars(int dummy)
        {
            return 0.0 + TestImplementations.CharacterCount(Program.LoremIpsum);
        }
        
        public static double PiCrunch(int dummy)
        {
            return 0.0 + TestImplementations.PiDigits(100);
        }
        public static double FibonacciCrunch(int dummy)
        {
            return 0.0 + TestImplementations.FibonacciDigits(250000);
        }
        public static double PrimeCrunch(int dummy)
        {
            return 0.0 + TestImplementations.Primes(50000);
        }
        public static double PiCrunchParallel(int dummy)
        {
            Parallel.For(0, Environment.ProcessorCount, i => TestImplementations.PiDigits(100));
            return 0.0;
        }
        public static double PrimeCrunchParallel(int dummy)
        {
            Parallel.For(0, Environment.ProcessorCount, i => TestImplementations.Primes(25000));
            return 0.0;
        }
        public static double FibonacciCrunchParallel(int dummy)
        {
            Parallel.For(0, Environment.ProcessorCount, i => TestImplementations.FibonacciDigits(500000));
            return 0.0;
        }
    }
}