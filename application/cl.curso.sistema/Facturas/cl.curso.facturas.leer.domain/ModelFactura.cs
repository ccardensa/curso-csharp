using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace cl.curso.facturas.leer.domain
{
    public class ModelFactura
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Empresa")]
        public string Empresa { get; set; }

        [BsonElement("Rut")]
        public string Rut { get; set; }

        public string Description { get; set; }
        public string Image { get; set; }
        public string Discount { get; set; }
        public decimal Precio { get; set; }
    }
}
