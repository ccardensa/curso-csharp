using System;
using System.Collections.Generic;
using cl.curso.facturas.leer.domain;
using MongoDB.Driver;

namespace cl.curso.facturas.leer.infraestructure
{
    public class MongoConnection
    {
        public IMongoCollection<ModelFactura> Facturas { get; }

        public MongoConnection()
        {
            var client = new MongoClient("mongodb://localhost:27018");
            var db = client.GetDatabase("Facturacion");
            Facturas = db.GetCollection<ModelFactura>("LeerFactura");

            List<ModelFactura> lst = Facturas.Find<ModelFactura>(f => true).ToList<ModelFactura>();


        }
    }
}
