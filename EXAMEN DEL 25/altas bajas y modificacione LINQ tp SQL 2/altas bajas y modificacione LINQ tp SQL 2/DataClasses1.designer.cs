﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace altas_bajas_y_modificacione_LINQ_tp_SQL_2
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="master")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertARTICULOS(ARTICULOS instance);
    partial void UpdateARTICULOS(ARTICULOS instance);
    partial void DeleteARTICULOS(ARTICULOS instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::altas_bajas_y_modificacione_LINQ_tp_SQL_2.Properties.Settings.Default.masterConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ARTICULOS> ARTICULOS
		{
			get
			{
				return this.GetTable<ARTICULOS>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ARTICULOS")]
	public partial class ARTICULOS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Clave_articulo;
		
		private string _Nombre;
		
		private System.Nullable<int> _Precio;
		
		private System.Nullable<int> _Clave_fabricante;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnClave_articuloChanging(int value);
    partial void OnClave_articuloChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnPrecioChanging(System.Nullable<int> value);
    partial void OnPrecioChanged();
    partial void OnClave_fabricanteChanging(System.Nullable<int> value);
    partial void OnClave_fabricanteChanged();
    #endregion
		
		public ARTICULOS()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Clave_articulo", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Clave_articulo
		{
			get
			{
				return this._Clave_articulo;
			}
			set
			{
				if ((this._Clave_articulo != value))
				{
					this.OnClave_articuloChanging(value);
					this.SendPropertyChanging();
					this._Clave_articulo = value;
					this.SendPropertyChanged("Clave_articulo");
					this.OnClave_articuloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(30)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Int")]
		public System.Nullable<int> Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this.OnPrecioChanging(value);
					this.SendPropertyChanging();
					this._Precio = value;
					this.SendPropertyChanged("Precio");
					this.OnPrecioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Clave_fabricante", DbType="Int")]
		public System.Nullable<int> Clave_fabricante
		{
			get
			{
				return this._Clave_fabricante;
			}
			set
			{
				if ((this._Clave_fabricante != value))
				{
					this.OnClave_fabricanteChanging(value);
					this.SendPropertyChanging();
					this._Clave_fabricante = value;
					this.SendPropertyChanged("Clave_fabricante");
					this.OnClave_fabricanteChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591