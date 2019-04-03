drop table if exists INV01_USUARIO_CORRELATIVO;
drop table if exists INV01_USUARIO_ROL;
drop table if exists INV01_USUARIO;
drop table if exists INV01_ROL;
drop table if exists INV01_INVENTARIO_MOVIMIENTO;
drop table if exists INV01_PRODUCTO_DESECHO;
drop table if exists INV01_ENVIO_DETALLE;
drop table if exists INV01_ENVIO_ENCABEZADO;
drop table if exists INV01_MOVIMIENTO;
drop table if exists INV01_TIPO_PAGO;
drop table if exists INV01_TIPO_MOVIMIENTO;
drop table if exists INV01_CLIENTE;
drop table if exists INV01_TIPO_MOV_INVENTARIO;
drop table if exists INV01_INVENTARIO;
drop table if exists INV01_BITACORA_PRODUCTO;
drop table if exists INV01_PRODUCTO;
drop table if exists INV01_CATEGORIA;
drop table if exists INV01_EMPRESA;


create table INV01_USUARIO(
usuario varchar(25),
nombre varchar(100),
password varchar(150),
estado_registro char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
usuario_modificacion varchar(25),
fecha_modificacion timestamp,
usuario_anulacion varchar(25),
fecha_nulacion timestamp,
constraint pk_us primary key (usuario)
);


create table INV01_ROL(
rol varchar(50),
nombre varchar(100),
estado_registro char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
usuario_modificacion varchar(25),
fecha_modificacion timestamp,
usuario_anulacion varchar(25),
fecha_nulacion timestamp,
constraint pk_rol primary key(rol)
);


create table INV01_USUARIO_ROL(
usuario varchar(25),
rol varchar(50),
estado_registro char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
usuario_modificacion varchar(25),
fecha_modificacion timestamp,
usuario_anulacion varchar(25),
fecha_nulacion timestamp,
constraint pk_us_rol primary key(usuario,rol),
constraint fk_ur_us foreign key(usuario) references INV01_USUARIO(usuario),
constraint fk_ur_rol foreign key(rol) references INV01_ROL(rol)
);

create table INV01_EMPRESA(
idempresa numeric,
nombre varchar(250),
logo bytea,
nit varchar(25),
telefono varchar(25),
estado_registro char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
usuario_modificacion varchar(25),
fecha_modificacion timestamp,
usuario_anulacion varchar(25),
fecha_nulacion timestamp,
constraint pk_emp primary key(idempresa)
);

create table INV01_USUARIO_CORRELATIVO(
idcorrelativo numeric,
idempresa numeric,
usuario varchar(25),
descripcion varchar(100),
correlativo_actual numeric,
estado_registro char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
usuario_modificacion varchar(25),
fecha_modificacion timestamp,
usuario_anulacion varchar(25),
fecha_nulacion timestamp,
constraint pk_cor primary key(idcorrelativo),
constraint fk_uc_us foreign key(usuario) references INV01_USUARIO(usuario),
constraint fk_uc_em foreign key(idempresa) references INV01_EMPRESA(idempresa)
);

create table INV01_CATEGORIA(
idcategoria numeric,
idempresa numeric,
descripcion varchar(100),
estado_registro char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
usuario_modificacion varchar(25),
fecha_modificacion timestamp,
usuario_anulacion varchar(25),
fecha_nulacion timestamp,
constraint pk_ct primary key (idcategoria),
constraint fk_ct_em foreign key(idempresa) references INV01_EMPRESA(idempresa)
);

create table INV01_PRODUCTO(
idproducto numeric,
idempresa numeric,
codigo_barra varchar(100),
idcategoria numeric,
descripcion varchar(250),
precio_costo numeric,
imagen bytea,
estado_registro char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
usuario_modificacion varchar(25),
fecha_modificacion timestamp,
usuario_anulacion varchar(25),
fecha_nulacion timestamp,
constraint pk_pd primary key (idproducto),
constraint fk_pd_ct foreign key (idcategoria) references INV01_CATEGORIA(idcategoria),
constraint fk_pd_em foreign key(idempresa) references INV01_EMPRESA(idempresa)
);

create table INV01_BITACORA_PRODUCTO(
idbitacora numeric,
idempresa numeric,
idproducto numeric,
descripcion_anterior varchar(250),
descripcion_actual varchar(250),
precio_costo_anterior numeric,
precio_costo_actual numeric,
imagen_anterior bytea,
imagen_actual bytea,
estado_registro_anterior char,
estado_registro_actual char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
constraint pk_bt_pr primary key (idbitacora),
constraint fk_bt_em foreign key(idempresa) references INV01_EMPRESA(idempresa)
);

create table INV01_INVENTARIO(
idinventario numeric,
idempresa numeric,
idproducto numeric,
factura_proveedor varchar(100),
precio_actual numeric,
existencia numeric,
estado_registro char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
usuario_modificacion varchar(25),
fecha_modificacion timestamp,
usuario_anulacion varchar(25),
fecha_nulacion timestamp,
constraint pk_inv primary key (idinventario),
constraint fk_inv_pr foreign key (idproducto) references INV01_PRODUCTO(idproducto),
constraint fk_inv_em foreign key(idempresa) references INV01_EMPRESA(idempresa)
);

create table INV01_TIPO_MOV_INVENTARIO(
idtipo_mov_inv numeric,
descripcion varchar(50),
estado_registro char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
usuario_modificacion varchar(25),
fecha_modificacion timestamp,
usuario_anulacion varchar(25),
fecha_nulacion timestamp,
constraint pk_tm_inv primary key (idtipo_mov_inv)
);


create table INV01_INVENTARIO_MOVIMIENTO(
idmovimiento numeric,
idempresa numeric,
idproducto numeric,
descripcion_producto varchar(250),
idtipo_mov_inv numeric,
descripcion varchar(150),
numero_envio numeric,
habia numeric,
hay numeric,
existencia numeric,
estado_registro char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
usuario_modificacion varchar(25),
fecha_modificacion timestamp,
usuario_anulacion varchar(25),
fecha_nulacion timestamp,
constraint pk_mov_inv primary key (idmovimiento),
constraint fk_mi_pr foreign key (idproducto) references INV01_PRODUCTO(idproducto),
constraint fk_mi_tmi foreign key (idtipo_mov_inv) references INV01_TIPO_MOV_INVENTARIO(idtipo_mov_inv),
constraint fk_mi_em foreign key(idempresa) references INV01_EMPRESA(idempresa)
);


create table INV01_PRODUCTO_DESECHO(
iddesecho numeric,
idempresa numeric,
idproducto numeric,
descripcion varchar(250),
cantidad numeric,
precio_costo numeric,
imagen bytea,
estado_registro char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
usuario_modificacion varchar(25),
fecha_modificacion timestamp,
usuario_anulacion varchar(25),
fecha_nulacion timestamp,
constraint pk_pd_pr primary key(iddesecho),
constraint fk_pd_pr foreign key(idproducto) references INV01_PRODUCTO(idproducto),
constraint fk_pd_em foreign key(idempresa) references INV01_EMPRESA(idempresa)
);


create table INV01_CLIENTE(
idcliente numeric,
nit varchar(25),
nombre varchar(100),
apellido varchar(100),
nombre_completo varchar(200),
direccion varchar(150),
telefono varchar(25),
estado_registro char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
usuario_modificacion varchar(25),
fecha_modificacion timestamp,
usuario_anulacion varchar(25),
fecha_nulacion timestamp,
constraint pk_cl primary key(idcliente)
);


create table INV01_TIPO_MOVIMIENTO(
idtipo_mov varchar(5),
descripcion varchar(50),
estado_registro char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
usuario_modificacion varchar(25),
fecha_modificacion timestamp,
usuario_anulacion varchar(25),
fecha_nulacion timestamp,
constraint pk_tm primary key(idtipo_mov)
);

create table INV01_TIPO_PAGO(
idtipo_pago numeric,
descripcion varchar(50),
estado_registro char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
usuario_modificacion varchar(25),
fecha_modificacion timestamp,
usuario_anulacion varchar(25),
fecha_nulacion timestamp,
constraint pk_tp primary key(idtipo_pago)
);

create table INV01_MOVIMIENTO(
idmovimiento numeric,
idempresa numeric,
idtipo_mov varchar(5),
idtipo_pago numeric,
cantidad numeric,
cantidad_letras varchar(300),
estado_registro char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
usuario_modificacion varchar(25),
fecha_modificacion timestamp,
usuario_anulacion varchar(25),
fecha_nulacion timestamp,
constraint pk_mov primary key(idmovimiento),
constraint fk_mov_tm foreign key (idtipo_mov) references INV01_TIPO_MOVIMIENTO(idtipo_mov),
constraint fk_mov_tp foreign key (idtipo_pago) references INV01_TIPO_PAGO(idtipo_pago),
constraint fk_mov_em foreign key(idempresa) references INV01_EMPRESA(idempresa)
);


create table INV01_ENVIO_ENCABEZADO(
idenvio numeric,
idempresa numeric,
envio numeric,
idmovimiento numeric,
idcliente numeric,
total numeric,
total_letras varchar(300),
estado_registro char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
usuario_modificacion varchar(25),
fecha_modificacion timestamp,
usuario_anulacion varchar(25),
fecha_nulacion timestamp,
constraint pk_en_enc primary key(idenvio),
constraint fk_ee_mov foreign key(idmovimiento) references INV01_MOVIMIENTO(idmovimiento),
constraint fk_ee_cl foreign key(idcliente) references INV01_CLIENTE(idcliente),
constraint fk_ee_em foreign key(idempresa) references INV01_EMPRESA(idempresa)
);


create table INV01_ENVIO_DETALLE(
iddetalle numeric,
idenvio numeric,
idproducto numeric,
descripcion varchar(250),
cantidad numeric,
precio_unitario numeric,
valor numeric,
estado_registro char,
usuario_creacion varchar(25),
fecha_creacion timestamp,
usuario_modificacion varchar(25),
fecha_modificacion timestamp,
usuario_anulacion varchar(25),
fecha_nulacion timestamp,
constraint pk_en_det primary key(iddetalle),
constraint fk_ed_en foreign key(idenvio) references INV01_ENVIO_ENCABEZADO(idenvio),
constraint fk_ed_pr foreign key(idproducto) references INV01_MOVIMIENTO(idmovimiento)
);

