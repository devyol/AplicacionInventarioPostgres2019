﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntitiesINV01 : DbContext
    {
        public EntitiesINV01()
            : base("name=EntitiesINV01")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<inv01_bitacora_producto> inv01_bitacora_producto { get; set; }
        public DbSet<inv01_categoria> inv01_categoria { get; set; }
        public DbSet<inv01_cliente> inv01_cliente { get; set; }
        public DbSet<inv01_envio_detalle> inv01_envio_detalle { get; set; }
        public DbSet<inv01_envio_encabezado> inv01_envio_encabezado { get; set; }
        public DbSet<inv01_inventario> inv01_inventario { get; set; }
        public DbSet<inv01_inventario_movimiento> inv01_inventario_movimiento { get; set; }
        public DbSet<inv01_movimiento> inv01_movimiento { get; set; }
        public DbSet<inv01_producto> inv01_producto { get; set; }
        public DbSet<inv01_producto_perdida> inv01_producto_perdida { get; set; }
        public DbSet<inv01_rol> inv01_rol { get; set; }
        public DbSet<inv01_tipo_mov_inventario> inv01_tipo_mov_inventario { get; set; }
        public DbSet<inv01_tipo_movimiento> inv01_tipo_movimiento { get; set; }
        public DbSet<inv01_tipo_pago> inv01_tipo_pago { get; set; }
        public DbSet<inv01_usuario> inv01_usuario { get; set; }
        public DbSet<inv01_usuario_correlativo> inv01_usuario_correlativo { get; set; }
        public DbSet<inv01_usuario_rol> inv01_usuario_rol { get; set; }
    }
}
