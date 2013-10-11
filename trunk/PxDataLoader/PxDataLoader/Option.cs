using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;


namespace PxDataLoader
{
    public class Option
    {
        public string Code { get; set; }
        public string Text { get; set; }

        public static List<Option> GetOptions(string name)
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            XDocument op = XDocument.Load(System.IO.Path.Combine(path, "Options\\" + name + ".xml"));
            var options = from ops in op.Root.Elements()
                          select new Option() { Code = ops.Attribute("code").Value, Text = ops.Value };

            return options.ToList();
        }

        public static List<Option> GetThemeOptions()
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();

            var themes = from theme in context.MenuSelections
                         where theme.LevelNo == "1"
                         select new Option() { Code = theme.Selection, Text = theme.PresText };

            return themes.ToList();

        }

        public static List<Option> GetTimeScaleOptions()
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();
            var timeScales = from ts in context.TimeScales
                             select new Option() { Code = ts.TimeScale1, Text = ts.PresText };
            return timeScales.ToList();
        }

        public static List<Option> GetPresMissingLineOptions()
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();
            var timeScales = from ts in context.SpecialCharacter 
                             select new Option() { Code = ts.CharacterType, Text = ts.PresText };

            List<Option> l =timeScales.ToList();
            l.Insert(0, new Option() { Code="", Text = ""});
            return l;
        }

    }
}
