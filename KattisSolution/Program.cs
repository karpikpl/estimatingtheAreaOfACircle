using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using KattisSolution.IO;

namespace KattisSolution
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Solve(Console.OpenStandardInput(), Console.OpenStandardOutput());
        }

        public static void Solve(Stream stdin, Stream stdout)
        {
            IScanner scanner = new OptimizedPositiveIntReader(stdin);
            // uncomment when you need more advanced reader
            scanner = new Scanner(stdin);
            // scanner = new LineReader(stdin);
            var writer = new BufferedStdoutWriter(stdout);

            // radius
            float r;
            // marked
            int m;
            // circle
            int c;

            while (true)
            {
                r = scanner.NextFloat();
                m = scanner.NextInt();
                c = scanner.NextInt();

                if (m == 0 && c == 0)
                    break;

                var circleSize = Math.PI * r * r;

                var estimatedSize = (c * 2 * r * 2 * r) / (float)m;

                writer.Write(circleSize.ToString(CultureInfo.InvariantCulture));
                //                writer.Write(circleSize.ToString(CultureInfo.InvariantCulture));
                writer.Write(" ");
                writer.Write(estimatedSize.ToString(CultureInfo.InvariantCulture));
                //                writer.Write(estimatedSize.ToString(CultureInfo.InvariantCulture));
                writer.Write("\n");
            }

            writer.Flush();
        }
    }
}