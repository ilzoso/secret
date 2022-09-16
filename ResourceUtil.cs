using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace secret
{
    internal class ResourceUtil
    {

        public static string GetEmbeddedResourceContent(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            using (Stream stream = asm.GetManifestResourceStream(resourceName))
            {
                using (StreamReader source = new StreamReader(stream))
                {
                    string fileContent = source.ReadToEnd();
                    return fileContent;
                }
            }
        }
    }
}
