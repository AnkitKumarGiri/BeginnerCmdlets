using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;

namespace BeginnerCmdlets
{
    [Cmdlet(VerbsCommon.Get, "RandomName")]
    public class GetRandomName : Cmdlet
    {
        [Parameter]
        public string Name { get; set; }

        protected override void ProcessRecord()
        {
            Console.WriteLine("{0} (Len {1})", Name, Name.Length);
        }
    }
}
