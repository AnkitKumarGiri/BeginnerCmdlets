using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using System.Threading;

namespace BeginnerCmdlets
{
    [Cmdlet(VerbsCommon.Get, "RandomName")]
    public class GetRandomName : Cmdlet
    {
        [Parameter(Position = 1, Mandatory = true, ValueFromPipeline = true)]
        public string Name { get; set; }

        protected override void ProcessRecord()
        {
            Console.WriteLine("In ProcessRecord: {0} (Len {1})", Name, Name.Length);
            Thread.Sleep(2000);
        }

        protected override void BeginProcessing()
        {
            Console.WriteLine("In BeginProcessing");
        }

        protected override void EndProcessing()
        {
            Console.WriteLine("In EndProcessing");
        }

        protected override void StopProcessing()
        {
            Console.WriteLine("In StopProcessing");
        }
    }
}
