using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace AutoRest.CSharp.V3.PipelineModels
{
    internal static class Deserializer2
    {
        public static CodeModel CreateCodeModel(string yaml)
        {
            //var db = new DeserializerBuilder();
            //db.

            //var serializer = new Serializer(SerializerSettings);
            //return serializer.Deserialize<CodeModel>(yaml);

            // convert string/file to YAML object
            yaml = Regex.Replace(yaml, @"!<!\w*> ", String.Empty);
            var r = new StringReader(yaml);
            
            //var deserializer = CodeModelDeserializer.DeserializerBuilder.Build();
            var deserializer = new DeserializerBuilder().Build();
            var yamlObject = deserializer.Deserialize(r);

            // now convert the object to JSON. Simple!
            var builder = new SerializerBuilder().JsonCompatible().DisableAliases();
            var js = builder.Build();

            var w = new StringWriter();
            js.Serialize(w, yamlObject);
            string jsonText = w.ToString();
            var codeModel = JsonSerializer.Deserialize<CodeModel>(jsonText);
            return codeModel;
        }
    }
}
