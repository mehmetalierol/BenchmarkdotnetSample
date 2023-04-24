using BenchmarkDotNet.Attributes;
using System.Text;

namespace TestProject
{
    [MemoryDiagnoser]
    [HtmlExporter] //for html outputs
    [RPlotExporter] //For R plot outputs
    public class StringTester
    {
        private const int StringCount = 10;
        private List<string>? result;

        [GlobalSetup]
        public void GlobalSetup()
        {
            result = new();
            for (int i = 0; i < StringCount; i++)
            {
                result.Add(Guid.NewGuid().ToString());
            }
        }

        [Benchmark]
        public void WithOperator()
        {
            string temp = "";
            foreach (var item in result)
            {
                temp += item;
            }
        }

        [Benchmark]
        public void WithStringIntepolation()
        {
            string temp = "";
            foreach (var item in result)
            {
                temp = $"{temp}{item}";
            }
        }

        [Benchmark]
        public void WithStringFormat()
        {
            string temp = "";
            foreach (var item in result)
            {
                string.Format("{0}{1}", temp, item);
            }
        }

        [Benchmark]
        public void WithStringConcat()
        {
            string temp = "";
            foreach (var item in result)
            {
                string.Concat(temp, item);
            }
        }

        [Benchmark]
        public void WithStringBuilder()
        {
            StringBuilder sb = new();
            foreach (var item in result)
            {
                sb.Append(item);
            }
        }
    }
}