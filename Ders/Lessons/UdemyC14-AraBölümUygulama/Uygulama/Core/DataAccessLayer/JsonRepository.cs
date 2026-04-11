using System;
using System.Collections.Generic;
using System.Text;
using Uygulama.Entities;

namespace Uygulama.Core.DataAccessLayer
{
    internal class JsonRepository<T> where T : BaseEntity
    {
        string _filepath;

        public JsonRepository(string filePath)
        {
            _filepath = filePath;
            if (!File.Exists(_filepath))
            {
                File.WriteAllText(_filepath, "[]");
            }
        }

        internal List<T> GetAll()
        {
            var json = File.ReadAllText(_filepath);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);
        }

        internal void Save(List<T> list)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(list);
            File.WriteAllText(_filepath, json);
        }
    }
}
