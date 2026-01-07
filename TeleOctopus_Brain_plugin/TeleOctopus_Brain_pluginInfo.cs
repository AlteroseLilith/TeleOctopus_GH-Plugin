using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace TeleOctopus_Brain_plugin
{
    public class TeleOctopus_Brain_pluginInfo : GH_AssemblyInfo
    {
        public override string Name => "TeleOctopus";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("9490b10f-10ba-4a12-8b4e-527ee4e8a695");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";

        //Return a string representing the version.  This returns the same version as the assembly.
        public override string AssemblyVersion => GetType().Assembly.GetName().Version.ToString();
    }
}