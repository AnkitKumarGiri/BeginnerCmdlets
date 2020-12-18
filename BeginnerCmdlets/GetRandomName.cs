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
            WriteVerbose(Name); 
            var nameCharacters = Name.ToCharArray();
            Array.Reverse(nameCharacters);
            WriteObject(new
                {
                    ReversedName =  new String(nameCharacters),
                    NameLength = Name.Length
                });
        }

        protected override void BeginProcessing()
        {
        }

        protected override void EndProcessing()
        {
        }

        protected override void StopProcessing()
        {
        }
    }
}
