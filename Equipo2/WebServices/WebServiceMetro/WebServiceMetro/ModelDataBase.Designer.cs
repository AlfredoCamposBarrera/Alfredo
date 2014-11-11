﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace WebServiceMetro
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class equipo2Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new equipo2Entities object using the connection string found in the 'equipo2Entities' section of the application configuration file.
        /// </summary>
        public equipo2Entities() : base("name=equipo2Entities", "equipo2Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new equipo2Entities object.
        /// </summary>
        public equipo2Entities(string connectionString) : base(connectionString, "equipo2Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new equipo2Entities object.
        /// </summary>
        public equipo2Entities(EntityConnection connection) : base(connection, "equipo2Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Horario> Horario
        {
            get
            {
                if ((_Horario == null))
                {
                    _Horario = base.CreateObjectSet<Horario>("Horario");
                }
                return _Horario;
            }
        }
        private ObjectSet<Horario> _Horario;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Ruta> Ruta
        {
            get
            {
                if ((_Ruta == null))
                {
                    _Ruta = base.CreateObjectSet<Ruta>("Ruta");
                }
                return _Ruta;
            }
        }
        private ObjectSet<Ruta> _Ruta;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Horario EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToHorario(Horario horario)
        {
            base.AddObject("Horario", horario);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Ruta EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRuta(Ruta ruta)
        {
            base.AddObject("Ruta", ruta);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="equipo2Model", Name="Horario")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Horario : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Horario object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Horario CreateHorario(global::System.Int32 id)
        {
            Horario horario = new Horario();
            horario.Id = id;
            return horario;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Dia
        {
            get
            {
                return _Dia;
            }
            set
            {
                OnDiaChanging(value);
                ReportPropertyChanging("Dia");
                _Dia = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Dia");
                OnDiaChanged();
            }
        }
        private global::System.String _Dia;
        partial void OnDiaChanging(global::System.String value);
        partial void OnDiaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Inicio
        {
            get
            {
                return _Inicio;
            }
            set
            {
                OnInicioChanging(value);
                ReportPropertyChanging("Inicio");
                _Inicio = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Inicio");
                OnInicioChanged();
            }
        }
        private global::System.String _Inicio;
        partial void OnInicioChanging(global::System.String value);
        partial void OnInicioChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Llegada
        {
            get
            {
                return _Llegada;
            }
            set
            {
                OnLlegadaChanging(value);
                ReportPropertyChanging("Llegada");
                _Llegada = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Llegada");
                OnLlegadaChanged();
            }
        }
        private global::System.String _Llegada;
        partial void OnLlegadaChanging(global::System.String value);
        partial void OnLlegadaChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="equipo2Model", Name="Ruta")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Ruta : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Ruta object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Ruta CreateRuta(global::System.Int32 id)
        {
            Ruta ruta = new Ruta();
            ruta.Id = id;
            return ruta;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Numero
        {
            get
            {
                return _Numero;
            }
            set
            {
                OnNumeroChanging(value);
                ReportPropertyChanging("Numero");
                _Numero = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Numero");
                OnNumeroChanged();
            }
        }
        private Nullable<global::System.Int32> _Numero;
        partial void OnNumeroChanging(Nullable<global::System.Int32> value);
        partial void OnNumeroChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Linea
        {
            get
            {
                return _Linea;
            }
            set
            {
                OnLineaChanging(value);
                ReportPropertyChanging("Linea");
                _Linea = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Linea");
                OnLineaChanged();
            }
        }
        private Nullable<global::System.Int32> _Linea;
        partial void OnLineaChanging(Nullable<global::System.Int32> value);
        partial void OnLineaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                OnNombreChanging(value);
                ReportPropertyChanging("Nombre");
                _Nombre = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Nombre");
                OnNombreChanged();
            }
        }
        private global::System.String _Nombre;
        partial void OnNombreChanging(global::System.String value);
        partial void OnNombreChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Latitud
        {
            get
            {
                return _Latitud;
            }
            set
            {
                OnLatitudChanging(value);
                ReportPropertyChanging("Latitud");
                _Latitud = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Latitud");
                OnLatitudChanged();
            }
        }
        private global::System.String _Latitud;
        partial void OnLatitudChanging(global::System.String value);
        partial void OnLatitudChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Longitud
        {
            get
            {
                return _Longitud;
            }
            set
            {
                OnLongitudChanging(value);
                ReportPropertyChanging("Longitud");
                _Longitud = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Longitud");
                OnLongitudChanged();
            }
        }
        private global::System.String _Longitud;
        partial void OnLongitudChanging(global::System.String value);
        partial void OnLongitudChanged();

        #endregion

    
    }

    #endregion

    
}