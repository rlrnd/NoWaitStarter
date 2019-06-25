using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoWaitStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var compiler = new Process())
            {
                compiler.StartInfo.FileName = args.First();
                compiler.StartInfo.Arguments = String.Join(" ", args.Skip(1));
                compiler.StartInfo.UseShellExecute = true;
                compiler.Start();
            }
        }
    }
}
