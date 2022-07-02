using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MathApplication
{
    public class JsonFileCreation
    {
        public string SaveFile(List<IShape> ShapesData)
        {
            try
            {
                var fileInfo = System.IO.Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + AppConstants.FilePath + AppConstants.FileName + ".json";
                string jsonString = JsonSerializer.Serialize(ShapesData);
                File.WriteAllText(fileInfo, jsonString);
                return "File saved successfully in path : " + fileInfo ;
            }
            catch (Exception err)
            {
                return "File not saved";
            }
        }
    }
}
