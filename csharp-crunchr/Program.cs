using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace pi_cruncher
{
    class Program
    {
        private const int MinRunningTimeNs = 250 * 1000000;
        private const int Iterations = 10;
        internal const string LoremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas lorem nisi, sagittis sed luctus facilisis, varius non quam. Nullam nec commodo ipsum. Cras ex augue, porttitor sit amet feugiat quis, porta sollicitudin libero. Nam varius, lacus vitae ultrices mollis, neque lorem consequat massa, et tristique augue nulla eget nibh. Vivamus at elit neque. Integer facilisis laoreet est, quis euismod ligula tristique vel. Suspendisse potenti. Aliquam at sem sit amet justo porta accumsan. Phasellus rutrum id odio sit amet volutpat. Donec eu mi mollis, posuere erat eget, feugiat justo. Curabitur ullamcorper nisl eget ligula lacinia, ut maximus purus sodales. Sed augue eros, vehicula at turpis ac, malesuada feugiat purus. Curabitur eget ante sed diam dictum tempus. Vivamus sit amet porta est, eu tempus ligula. Quisque suscipit consectetur quam et posuere. Vivamus pharetra tortor at mauris laoreet tincidunt. Aenean quis dui at quam ultricies pulvinar in non enim. Nulla vestibulum risus ligula, eu commodo dolor tempus nec. Proin rhoncus ex at dignissim feugiat. Fusce a est sed odio interdum accumsan. Nulla facilisi. Ut felis elit, gravida ut consectetur in, porta eu nisl. Phasellus tempor posuere nunc, ac pellentesque purus hendrerit at. Donec lectus tortor, malesuada eget libero quis, hendrerit hendrerit dolor. Praesent quis suscipit ipsum. Etiam dictum purus vitae nunc viverra, ac posuere leo euismod. Sed posuere ac nibh ultricies egestas. Phasellus vitae orci eget justo laoreet posuere sit amet ut lacus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Donec id libero ac dolor accumsan mollis in id urna. Duis ac velit arcu. Maecenas felis dui, tincidunt eget suscipit et, elementum at risus. Nullam blandit faucibus velit, vel malesuada risus pharetra eget. Proin eget aliquet nunc, suscipit dignissim urna. Vestibulum et quam id tellus placerat eleifend. Mauris sit amet aliquam diam, ut fermentum ligula. Nulla eget mauris augue. Morbi a felis at tortor faucibus mollis in et elit. Etiam nec placerat dolor. Etiam tincidunt turpis id nisi semper, at maximus nunc ullamcorper. Phasellus feugiat rutrum magna nec vulputate. Ut aliquet odio quis ultrices vestibulum. Fusce dui magna, finibus vitae porttitor sed, elementum in tortor. Cras lectus nisi, cursus vel finibus et, vestibulum in enim. Suspendisse id finibus lacus. Sed sit amet velit id augue interdum tincidunt vitae nec nunc. Suspendisse ligula diam, bibendum nec diam ut, luctus porta arcu. Nulla luctus ac diam quis cursus. Proin sit amet sapien consequat, fringilla nulla sed, rhoncus ligula. Sed ultrices elit in mauris tincidunt scelerisque. Quisque dictum mollis ex, quis tempus turpis eleifend sit amet. Vivamus vitae eros eros. Nunc augue risus, efficitur sit amet metus non, egestas laoreet velit. Nam id bibendum nisl. Nulla non semper mauris, faucibus malesuada est. Nulla tincidunt feugiat ligula id vulputate. Nulla vitae neque sit amet mi consequat imperdiet. Donec facilisis justo turpis, eget laoreet justo aliquam et. Proin facilisis, dui vel consectetur lacinia, velit est sollicitudin sapien, sit amet suscipit velit lacus eget justo. In odio turpis, aliquet laoreet nulla placerat, ullamcorper egestas augue. Suspendisse ut ultrices velit. Fusce pulvinar neque at tortor egestas vulputate. Sed malesuada commodo ante, nec tristique risus finibus quis. Vivamus hendrerit a magna ac ultricies. Aliquam dictum leo at est consectetur, in aliquet urna sodales. Proin imperdiet risus justo, in volutpat massa iaculis nec. Cras vitae turpis eget velit elementum vestibulum in vel felis. Proin sit amet magna eu neque ultricies mattis vitae non ligula. Curabitur quis erat metus. Donec vestibulum eros at consequat bibendum. Nullam eget placerat turpis, vitae faucibus velit. Donec viverra augue a risus dictum aliquet. Nam non aliquet libero, nec convallis massa. Nulla pharetra tellus at lobortis hendrerit. Aliquam vitae quam varius, bibendum eros rutrum, porta tellus. Donec sem arcu, ullamcorper et fermentum eu, viverra dignissim nibh. Donec accumsan non leo vel scelerisque. Aenean posuere eros ac hendrerit finibus. Nulla tempor velit laoreet dolor feugiat dignissim. Maecenas eu ligula at mi molestie feugiat sit amet eu arcu. Mauris eu metus non odio iaculis ultricies. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Morbi sed sem at massa pellentesque malesuada id ac sapien. Sed ut enim pretium, ullamcorper eros eget, dapibus ex. Nam ultricies felis nec magna fermentum, sed vulputate dui sollicitudin. Etiam vel blandit felis. Duis maximus est sit amet egestas dignissim. Ut sed tortor sit amet augue porttitor sodales porta pretium neque. Morbi sollicitudin, nunc ut vulputate elementum, eros nibh tempus massa, id vehicula tellus sem ut felis. Pellentesque venenatis ac arcu eu lobortis. Aenean consequat massa nulla, id fermentum lorem accumsan sit amet. Proin vel tellus sed diam pharetra elementum quis eu magna. Aenean turpis quam, fermentum in tristique quis, viverra ac nisl. Morbi ultricies dolor ligula, sollicitudin gravida elit sollicitudin ut. Cras odio massa, malesuada non elit et, bibendum tincidunt nisl. Donec malesuada dolor leo, et placerat augue auctor vitae. Fusce feugiat, augue sed ultricies laoreet, neque nunc vehicula nisl, eu auctor neque elit eu turpis. In rutrum nisl vel lacus hendrerit, imperdiet venenatis tortor posuere. Nunc ex neque, sagittis sed sem ac, aliquam feugiat nisi. Sed sed libero non orci gravida lacinia. Nullam venenatis sed justo vel pretium. Curabitur tellus est, consectetur porttitor vehicula eu, ullamcorper id ipsum. Cras euismod mauris id nulla sodales congue. Sed porttitor ornare risus et interdum. Suspendisse potenti. Vestibulum placerat, nisi ac imperdiet finibus, eros nibh efficitur libero, eget interdum urna velit sed magna. Nulla vestibulum placerat lacus eget consectetur. Curabitur mollis laoreet leo at mattis. Nulla facilisi. Pellentesque viverra pellentesque velit et pulvinar. Integer blandit in neque vel fringilla.";
        
        static async Task Main(string[] args)
        {
            Console.WriteLine("Test name\tMean\tStd. dev.\tCount");
            var sequentialScore = 0.0;
            sequentialScore += Mark8("matrixer   ", TestWrapper.Matrixer, Iterations, MinRunningTimeNs);
            sequentialScore += Mark8("lorem chars", TestWrapper.LoremChars, Iterations, MinRunningTimeNs);
            sequentialScore += Mark8("primes     ", TestWrapper.PrimeCrunch, Iterations, MinRunningTimeNs);
            sequentialScore += Mark8("π-crunchr  ", TestWrapper.PiCrunch, Iterations, MinRunningTimeNs);
            sequentialScore += Mark8("fibonacci  ", TestWrapper.FibonacciCrunch, Iterations, MinRunningTimeNs);
            Console.WriteLine($"\n-- Your computers single-core score is {Math.Pow(Math.Floor(sequentialScore), -1) * 1000000000:F0} --\n\n");

            return;
            
            var parallelScore = 0.0;
            parallelScore += Mark8("primes-parallel   ", TestWrapper.PrimeCrunchParallel, Iterations, MinRunningTimeNs) / Environment.ProcessorCount;
            parallelScore += Mark8("π-crunchr-parallel", TestWrapper.PiCrunchParallel, Iterations, MinRunningTimeNs) / Environment.ProcessorCount;
            parallelScore += Mark8("fibonacci-parallel", TestWrapper.FibonacciCrunchParallel, Iterations, MinRunningTimeNs) / Environment.ProcessorCount;

            Console.WriteLine($"\n\n-- Your computers multi-core score is {Math.Pow(Math.Floor(parallelScore), -1) * 1000000000:F0} --");
        }

        
        public static double Mark8(string msg, Func<int, double> fun, int iterations, double minTime)
        {
            var sw = new Stopwatch();
            int count = 1, totalCount = 0;
            double dummy = 0.0, runningTime = 0.0, deltaTime = 0.0, deltaTimeSquared = 0.0;
            do
            {
                count *= 2;
                deltaTime = 0.0;
                deltaTimeSquared = 0.0;
                for (var j = 0; j < iterations; j++)
                {
                    sw.Restart();
                    for (var i = 0; i < count; i++)
                    {
                        dummy += fun(i);
                    }
                    sw.Stop();
                    runningTime = sw.Elapsed.Ticks * 100.0;
                    var time = runningTime / count;
                    deltaTime += time;
                    deltaTimeSquared += time * time;
                    totalCount += count;
                }
            } while (runningTime < minTime && count < Int32.MaxValue / 2);

            double mean = deltaTime / iterations,
                standardDeviation = Math.Sqrt((deltaTimeSquared - mean * mean * iterations) / (iterations - 1));
            Console.WriteLine($"{msg}\t{mean:F0}\t{standardDeviation:F0}\t\t{count}");
            return mean;
        }
    }
}