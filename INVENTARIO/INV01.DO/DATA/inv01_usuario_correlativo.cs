//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INV01.DO.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class inv01_usuario_correlativo
    {
        public decimal idcorrelativo { get; set; }
        public string usuario { get; set; }
        public string descripcion { get; set; }
        public Nullable<decimal> correlativo_actual { get; set; }
        public string estado_registro { get; set; }
        public string usuario_creacion { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public string usuario_modificacion { get; set; }
        public Nullable<System.DateTime> fecha_modificacion { get; set; }
        public string usuario_anulacion { get; set; }
        public Nullable<System.DateTime> fecha_nulacion { get; set; }
    
        public virtual inv01_usuario inv01_usuario { get; set; }
    }
}