using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INV01.DO.DATA;
using INV01.UI.Clases;

namespace INV01.UI.Modelo
{
    public class Producto
    {

        #region Constantes Privados
        #endregion

        #region Atributos Privados

        private inv01_producto dbModel;        

        #endregion

        #region Propiedades Publicas

        public decimal productoId
        {
            get { return dbModel.idproducto; }
            set { dbModel.idproducto = value; }
        }

        public string codigoBarra
        {
            get { return dbModel.codigo_barra; }
            set { dbModel.codigo_barra = value; }
        }

        public decimal? categoriaId
        {
            get { return dbModel.idcategoria; }
            set { dbModel.idcategoria = value; }
        }

        public string Descripcion
        {
            get { return dbModel.descripcion; }
            set { dbModel.descripcion = value; }
        }

        public decimal? precioCosto
        {
            get { return dbModel.precio_costo; }
            set { dbModel.precio_costo = value; }
        }

        public byte[] Imagen
        {
            get { return dbModel.imagen; }
            set { dbModel.imagen = value; }
        }

        public string estadoRegistro
        {
            get { return dbModel.estado_registro; }
            set { dbModel.estado_registro = value; }
        }

        public string usuarioCreacion
        {
            get { return dbModel.usuario_creacion; }
            set { dbModel.usuario_creacion = value; }
        }

        public DateTime? fechaCreacion
        {
            get { return dbModel.fecha_creacion; }
            set { dbModel.fecha_creacion = value; }
        }

        public string usuarioModificacion
        {
            get { return dbModel.usuario_modificacion; }
            set { dbModel.usuario_modificacion = value; }
        }

        public DateTime? fechaModificacion
        {
            get { return dbModel.fecha_modificacion; }
            set { dbModel.fecha_modificacion = value; }
        }

        public string usuarioAnulacion
        {
            get { return dbModel.usuario_anulacion; }
            set { dbModel.usuario_anulacion = value; }
        }

        public DateTime? fechaAnulacion
        {
            get { return dbModel.fecha_nulacion; }
            set { dbModel.fecha_nulacion = value; }
        }

        #endregion

        #region Constructores

        public Producto()
        {
            dbModel = new inv01_producto();
        }

        public Producto(inv01_producto data)
        {
            dbModel = data;
        }

        #endregion

        #region Metodos Publicos



        #endregion

        #region Metodos Privados
        #endregion
    }
}
