using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using BankAppCore.Interfaces;
using Newtonsoft.Json;

namespace BankAppCore.Helper
{
    public class ReadWriteToJson : IReadWriteToJson
    {
       // db is the directory where the jsons are saved. 
        private readonly string db = Path.Combine(Environment.CurrentDirectory, @"db\");

        public async Task<bool> WriteJson<T>(T model, string jsonFile)
        {

            try
            {
                string json = JsonConvert.SerializeObject(model) + Environment.NewLine;
                // Concatenates the path directory(db) with the require json file as the first parameter
                await File.AppendAllTextAsync(db + jsonFile, json);
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<List<T>> ReadJson<T>(string jsonFile)
        {
            try
            {
                var readText = await File.ReadAllTextAsync(db + jsonFile);

                var objects = new List<T>();

                var serializer = new JsonSerializer();

                using (var stringReader = new StringReader(readText))
                using (var jsonReader = new JsonTextReader(stringReader))
                {
                    jsonReader.SupportMultipleContent = true;

                    while (jsonReader.Read())
                    {
                        T json = serializer.Deserialize<T>(jsonReader);

                        objects.Add(json);
                    }
                }

                return objects;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<bool> UpdateJson<T>(List<T> model, string jsonFile)
        {
            try
            {
                string json = string.Empty;

                foreach (var item in model)
                {
                    json += JsonConvert.SerializeObject(item) + Environment.NewLine;
                }
                await File.WriteAllTextAsync(db + jsonFile, json);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
