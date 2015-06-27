using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DemoCleanCode
{
    public class JsonSerializer
    {
        /// <summary>
        /// Serializa una entidad
        /// </summary>
        /// <typeparam name="T">Tipo de entidad</typeparam>
        /// <param name="entity">Entidad a serializar</param>
        /// <returns>Entidad serializada</returns>
        public static string SerializeToJson<T>(T entity)
        {
            return JsonConvert.SerializeObject(entity);
        }

        /// <summary>
        /// Des-serializa una entidad
        /// </summary>
        /// <typeparam name="T">Tipo de entidad</typeparam>
        /// <param name="jsonEntity">Definición de la entidad en json</param>
        /// <returns>Entidad tipada</returns>
        public static T DeserializeFromJson<T>(string jsonEntity)
        {
            return JsonConvert.DeserializeObject<T>(jsonEntity);
        }
    }
}
