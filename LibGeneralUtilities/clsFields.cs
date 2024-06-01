using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using LibStructure;
using LibGeneralUtilities;

public class clsFields
{
    //private static List<clsField> fields = null;
    public List<clsField> LstFields = new List<clsField>();
    //{
    //    get
    //    {
    //        if (fields == null)
    //        {
    //            string ErrorMessage = string.Empty;
    //            clsFields fildsobj = GetFields(ref ErrorMessage);
    //            fields = fildsobj.Fields ;
    //        }
    //        else
    //        {
    //            fields = new List<clsField>();
    //        }
    //        return fields;
    //    }
    //    set
    //    {
    //        fields = value;
    //    }
    //}

    public void SetFields()
    {
        try
        {
            string SettingsFilePath = ModPathes.GetFieldsSettingsFilePath();
            var serializer = new XmlSerializer(this.GetType());
            using (var writer = XmlWriter.Create(SettingsFilePath))
            {
                serializer.Serialize(writer, this);
            }
        }
        catch (Exception ex)
        {
            //ErrorMessage = ex.Message;
        }
    }

    public static clsFields GetFields()
    {
        clsFields? Fields = new clsFields();
        try
        {
            string FilePath = ModPathes.GetFieldsSettingsFilePath();
            if (!File.Exists(FilePath))
            {
                //ErrorMessage = ModResoucres.cnst_FieldsFileISNotExist;
                return Fields;
            }
            var serializer = new XmlSerializer(typeof(clsFields));
            using (var reader = XmlReader.Create(FilePath))
            {
                Fields = serializer.Deserialize(reader) as clsFields;
            }
        }
        catch (Exception ex)
        {
            //ErrorMessage = ex.Message;
        }
        return Fields;
    }
}