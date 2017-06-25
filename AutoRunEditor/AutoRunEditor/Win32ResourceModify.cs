using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vestris.ResourceLib;
namespace AutoRunEditor
{
    public class Win32ResourceModify
    {
        string file;
        public Win32ResourceModify(string f)
        {
            if (!System.IO.File.Exists(f))
                throw new Exception("404");
            file = f;
        }
        public bool UpdateString(ushort id, string data)
        {
            StringResource sr = new StringResource();
            sr.Language = 1033;
            sr.Name = new ResourceId(StringResource.GetBlockId(id));

            //load the data that was already in file
            ResourceInfo ri = new ResourceInfo();
            ri.Load(file);
            foreach (StringResource rc in ri[Kernel32.ResourceTypes.RT_STRING])
            {
                foreach (KeyValuePair<ushort,string> key in rc.Strings)
                    sr[key.Key] = key.Value;
            }
                
            ri.Unload();
            sr[id] = data;
            sr.SaveTo(file);
            return true;
        }
        public string GetString(ushort id)
        {
            StringResource sr = new StringResource();
            sr.Name = new ResourceId(StringResource.GetBlockId(id));
            sr.LoadFrom(file);
            return sr[id];
        }
        public bool UpdateImage(string iconPath)
        {
            if (!System.IO.File.Exists(iconPath))
                return false;

            IconFile iconFile = new IconFile(iconPath);
            IconDirectoryResource iconDirectoryResource = new IconDirectoryResource(iconFile);
            iconDirectoryResource.SaveTo(file);

            return true;
        }
        private UInt16 GetBlockId(int stringId)
        {
            return (UInt16)((stringId / 16) + 1);
        }
    }
}
