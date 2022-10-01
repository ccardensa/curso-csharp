using CL.Curso.Facturas.Infraestructure.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CL.Curso.Facturas.Domain
{
    public class Operations
    {
        /// <summary>
        /// Eliminación Fisica retornando el estado de la entidad
        /// </summary>
        /// <param name="Factura"></param>
        public bool EliminarFiscamenteConRetorno(DocumentoElectronico Factura)
        {
            using (var context = new WebFacturacionContext())
            {
                var entity = context.DocumentoElectronicos.Where(x=> x.Id == Factura.Id && x.IdTipoDocumento == 1).FirstOrDefault();
                context.DocumentoElectronicos.Remove(entity);
                return context.SaveChanges() == 1 ? true : false;
               
            }
        }

        /// <summary>
        /// Eliminación Fisica 
        /// </summary>
        /// <param name="Factura"></param>
        public void EliminarFisica(DocumentoElectronico Factura)
        {
            using (var context = new WebFacturacionContext())
            {
                var entity = context.DocumentoElectronicos.Where(x => x.Id == Factura.Id && x.IdTipoDocumento == 1).FirstOrDefault();
                context.DocumentoElectronicos.Remove(entity);
                context.SaveChanges();

            }
        }

        public IList<DocumentoElectronico> LeerDocumentosTributarios()
        {
            //var lstEntitys = new List<DocumentoElectronico>();

            using (var context = new WebFacturacionContext())
            {
                var entitys = context.DocumentoElectronicos.ToList();

                //foreach (var item in entitys)
                //{
                //    lstEntitys.Add(item);
                //}

                return entitys;
            }
        }
    }
}
