create database inventaris
use inventaris

create table inventaris (id_inventaris int identity(1,1) primary key, kode_inventaris varchar(10), nama varchar(100), kondisi varchar(100), keterangan text, jumlah int, id_jenis int, tanggal_register date, id_ruang int, id_petugas int)
create table jenis (id_jenis int identity(1,1) primary key, kode_jenis varchar(10), nama_jenis varchar(100), keterangan text)
create table ruang (id_ruang int identity(1,1) primary key, kode_ruang varchar(10), nama_ruang varchar(100), keterangan text)
create table petugas (id_petugas int identity(1,1) primary key, username varchar(100), password varchar(100), nama_petugas varchar(100), jk varchar(20), ttl date, alamat text, id_level int)
create table level (id_level int identity(1,1) primary key, kode_level varchar(10), nama_level varchar(100))
create table detail_pinjam (id_detail_pinjam int identity(1,1) primary key, id_peminjaman int, kode_peminjaman varchar(10), id_inventaris int, kode_inventaris varchar(10),jumlah int)
create table peminjaman (id_peminjaman int identity(1,1) primary key, kode_peminjaman varchar(10), tanggal_pinjam date, tanggal_kembali date, status_peminjaman varchar(50), id_pegawai int, jumlah_barang int)
create table pegawai (id_pegawai int identity(1,1) primary key, nama_pegawai varchar(100), nip varchar(20), alamat text)
alter table inventaris add foreign key(id_jenis) references jenis(id_jenis)
alter table inventaris add foreign key(id_ruang) references ruang(id_ruang)
alter table inventaris add foreign key(id_petugas) references petugas(id_petugas)
alter table detail_pinjam add foreign key(id_inventaris) references inventaris(id_inventaris)
alter table detail_pinjam add foreign key(id_peminjaman) references peminjaman(id_peminjaman)
alter table peminjaman add foreign key(id_pegawai) references pegawai(id_pegawai)
alter table petugas add foreign key(id_level) references level(id_level)