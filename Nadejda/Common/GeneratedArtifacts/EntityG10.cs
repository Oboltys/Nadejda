﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    public sealed partial class Решение_СудаItem : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Решение_СудаItem entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Решение_СудаItem()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Решение_СудаItem(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Решение_СудаItem> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Решение_СудаItem.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Решение_СудаItem_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Решение_СудаItem_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Cдела
        {
            get
            {
                return global::LightSwitchApplication.Решение_СудаItem.DetailsClass.GetValue(this, global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties.Cдела);
            }
            set
            {
                global::LightSwitchApplication.Решение_СудаItem.DetailsClass.SetValue(this, global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties.Cдела, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Cдела_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Cдела_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Cдела_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Nullable<global::System.DateTime> Дата_решения_суда
        {
            get
            {
                return global::LightSwitchApplication.Решение_СудаItem.DetailsClass.GetValue(this, global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties.Дата_решения_суда);
            }
            set
            {
                global::LightSwitchApplication.Решение_СудаItem.DetailsClass.SetValue(this, global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties.Дата_решения_суда, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Дата_решения_суда_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Дата_решения_суда_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Дата_решения_суда_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Постановление
        {
            get
            {
                return global::LightSwitchApplication.Решение_СудаItem.DetailsClass.GetValue(this, global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties.Постановление);
            }
            set
            {
                global::LightSwitchApplication.Решение_СудаItem.DetailsClass.SetValue(this, global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties.Постановление, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Постановление_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Постановление_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Постановление_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Nullable<global::System.DateTime> Дата_постановления
        {
            get
            {
                return global::LightSwitchApplication.Решение_СудаItem.DetailsClass.GetValue(this, global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties.Дата_постановления);
            }
            set
            {
                global::LightSwitchApplication.Решение_СудаItem.DetailsClass.SetValue(this, global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties.Дата_постановления, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Дата_постановления_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Дата_постановления_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Дата_постановления_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Nullable<int> Номер_постановления
        {
            get
            {
                return global::LightSwitchApplication.Решение_СудаItem.DetailsClass.GetValue(this, global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties.Номер_постановления);
            }
            set
            {
                global::LightSwitchApplication.Решение_СудаItem.DetailsClass.SetValue(this, global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties.Номер_постановления, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Номер_постановления_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Номер_постановления_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Номер_постановления_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Решение_СудаItem,
                global::LightSwitchApplication.Решение_СудаItem.DetailsClass,
                global::LightSwitchApplication.Решение_СудаItem.DetailsClass.IImplementation,
                global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties.Cдела;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass>.Entry
                __Решение_СудаItemEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass>.Entry(
                    global::LightSwitchApplication.Решение_СудаItem.DetailsClass.__Решение_СудаItem_CreateNew,
                    global::LightSwitchApplication.Решение_СудаItem.DetailsClass.__Решение_СудаItem_Created,
                    global::LightSwitchApplication.Решение_СудаItem.DetailsClass.__Решение_СудаItem_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Решение_СудаItem __Решение_СудаItem_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Решение_СудаItem> es)
            {
                return new global::LightSwitchApplication.Решение_СудаItem(es);
            }
            private static void __Решение_СудаItem_Created(global::LightSwitchApplication.Решение_СудаItem e)
            {
                e.Решение_СудаItem_Created();
            }
            private static bool __Решение_СудаItem_AllowSaveWithErrors(global::LightSwitchApplication.Решение_СудаItem e)
            {
                bool result = false;
                e.Решение_СудаItem_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, int> Cдела
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties.Cдела) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<global::System.DateTime>> Дата_решения_суда
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties.Дата_решения_суда) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<global::System.DateTime>>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, string> Постановление
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties.Постановление) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<global::System.DateTime>> Дата_постановления
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties.Дата_постановления) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<global::System.DateTime>>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<int>> Номер_постановления
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties.Номер_постановления) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<int>>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Cдела { get; set; }
                new global::System.Nullable<global::System.DateTime> Дата_решения_суда { get; set; }
                new string Постановление { get; set; }
                new global::System.Nullable<global::System.DateTime> Дата_постановления { get; set; }
                new global::System.Nullable<int> Номер_постановления { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, int>.Entry
                    Cдела = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, int>.Entry(
                        "Cдела",
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Cдела_Stub,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Cдела_ComputeIsReadOnly,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Cдела_Validate,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Cдела_GetImplementationValue,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Cдела_SetImplementationValue,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Cдела_OnValueChanged);
                private static void _Cдела_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, int>.Data> c, global::LightSwitchApplication.Решение_СудаItem.DetailsClass d, object sf)
                {
                    c(d, ref d._Cдела, sf);
                }
                private static bool _Cдела_ComputeIsReadOnly(global::LightSwitchApplication.Решение_СудаItem e)
                {
                    bool result = false;
                    e.Cдела_IsReadOnly(ref result);
                    return result;
                }
                private static void _Cдела_Validate(global::LightSwitchApplication.Решение_СудаItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Cдела_Validate(r);
                }
                private static int _Cдела_GetImplementationValue(global::LightSwitchApplication.Решение_СудаItem.DetailsClass d)
                {
                    return d.ImplementationEntity.Cдела;
                }
                private static void _Cдела_SetImplementationValue(global::LightSwitchApplication.Решение_СудаItem.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Cдела = v;
                }
                private static void _Cдела_OnValueChanged(global::LightSwitchApplication.Решение_СудаItem e)
                {
                    e.Cдела_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<global::System.DateTime>>.Entry
                    Дата_решения_суда = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<global::System.DateTime>>.Entry(
                        "Дата_решения_суда",
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Дата_решения_суда_Stub,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Дата_решения_суда_ComputeIsReadOnly,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Дата_решения_суда_Validate,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Дата_решения_суда_GetImplementationValue,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Дата_решения_суда_SetImplementationValue,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Дата_решения_суда_OnValueChanged);
                private static void _Дата_решения_суда_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<global::System.DateTime>>.Data> c, global::LightSwitchApplication.Решение_СудаItem.DetailsClass d, object sf)
                {
                    c(d, ref d._Дата_решения_суда, sf);
                }
                private static bool _Дата_решения_суда_ComputeIsReadOnly(global::LightSwitchApplication.Решение_СудаItem e)
                {
                    bool result = false;
                    e.Дата_решения_суда_IsReadOnly(ref result);
                    return result;
                }
                private static void _Дата_решения_суда_Validate(global::LightSwitchApplication.Решение_СудаItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Дата_решения_суда_Validate(r);
                }
                private static global::System.Nullable<global::System.DateTime> _Дата_решения_суда_GetImplementationValue(global::LightSwitchApplication.Решение_СудаItem.DetailsClass d)
                {
                    return d.ImplementationEntity.Дата_решения_суда;
                }
                private static void _Дата_решения_суда_SetImplementationValue(global::LightSwitchApplication.Решение_СудаItem.DetailsClass d, global::System.Nullable<global::System.DateTime> v)
                {
                    d.ImplementationEntity.Дата_решения_суда = global::LightSwitchApplication.Решение_СудаItem.DetailsClass.ClearDateTimeKind(v);
                }
                private static void _Дата_решения_суда_OnValueChanged(global::LightSwitchApplication.Решение_СудаItem e)
                {
                    e.Дата_решения_суда_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, string>.Entry
                    Постановление = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, string>.Entry(
                        "Постановление",
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Постановление_Stub,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Постановление_ComputeIsReadOnly,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Постановление_Validate,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Постановление_GetImplementationValue,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Постановление_SetImplementationValue,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Постановление_OnValueChanged);
                private static void _Постановление_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, string>.Data> c, global::LightSwitchApplication.Решение_СудаItem.DetailsClass d, object sf)
                {
                    c(d, ref d._Постановление, sf);
                }
                private static bool _Постановление_ComputeIsReadOnly(global::LightSwitchApplication.Решение_СудаItem e)
                {
                    bool result = false;
                    e.Постановление_IsReadOnly(ref result);
                    return result;
                }
                private static void _Постановление_Validate(global::LightSwitchApplication.Решение_СудаItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Постановление_Validate(r);
                }
                private static string _Постановление_GetImplementationValue(global::LightSwitchApplication.Решение_СудаItem.DetailsClass d)
                {
                    return d.ImplementationEntity.Постановление;
                }
                private static void _Постановление_SetImplementationValue(global::LightSwitchApplication.Решение_СудаItem.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Постановление = v;
                }
                private static void _Постановление_OnValueChanged(global::LightSwitchApplication.Решение_СудаItem e)
                {
                    e.Постановление_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<global::System.DateTime>>.Entry
                    Дата_постановления = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<global::System.DateTime>>.Entry(
                        "Дата_постановления",
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Дата_постановления_Stub,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Дата_постановления_ComputeIsReadOnly,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Дата_постановления_Validate,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Дата_постановления_GetImplementationValue,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Дата_постановления_SetImplementationValue,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Дата_постановления_OnValueChanged);
                private static void _Дата_постановления_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<global::System.DateTime>>.Data> c, global::LightSwitchApplication.Решение_СудаItem.DetailsClass d, object sf)
                {
                    c(d, ref d._Дата_постановления, sf);
                }
                private static bool _Дата_постановления_ComputeIsReadOnly(global::LightSwitchApplication.Решение_СудаItem e)
                {
                    bool result = false;
                    e.Дата_постановления_IsReadOnly(ref result);
                    return result;
                }
                private static void _Дата_постановления_Validate(global::LightSwitchApplication.Решение_СудаItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Дата_постановления_Validate(r);
                }
                private static global::System.Nullable<global::System.DateTime> _Дата_постановления_GetImplementationValue(global::LightSwitchApplication.Решение_СудаItem.DetailsClass d)
                {
                    return d.ImplementationEntity.Дата_постановления;
                }
                private static void _Дата_постановления_SetImplementationValue(global::LightSwitchApplication.Решение_СудаItem.DetailsClass d, global::System.Nullable<global::System.DateTime> v)
                {
                    d.ImplementationEntity.Дата_постановления = global::LightSwitchApplication.Решение_СудаItem.DetailsClass.ClearDateTimeKind(v);
                }
                private static void _Дата_постановления_OnValueChanged(global::LightSwitchApplication.Решение_СудаItem e)
                {
                    e.Дата_постановления_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<int>>.Entry
                    Номер_постановления = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<int>>.Entry(
                        "Номер_постановления",
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Номер_постановления_Stub,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Номер_постановления_ComputeIsReadOnly,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Номер_постановления_Validate,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Номер_постановления_GetImplementationValue,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Номер_постановления_SetImplementationValue,
                        global::LightSwitchApplication.Решение_СудаItem.DetailsClass.PropertySetProperties._Номер_постановления_OnValueChanged);
                private static void _Номер_постановления_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<int>>.Data> c, global::LightSwitchApplication.Решение_СудаItem.DetailsClass d, object sf)
                {
                    c(d, ref d._Номер_постановления, sf);
                }
                private static bool _Номер_постановления_ComputeIsReadOnly(global::LightSwitchApplication.Решение_СудаItem e)
                {
                    bool result = false;
                    e.Номер_постановления_IsReadOnly(ref result);
                    return result;
                }
                private static void _Номер_постановления_Validate(global::LightSwitchApplication.Решение_СудаItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Номер_постановления_Validate(r);
                }
                private static global::System.Nullable<int> _Номер_постановления_GetImplementationValue(global::LightSwitchApplication.Решение_СудаItem.DetailsClass d)
                {
                    return d.ImplementationEntity.Номер_постановления;
                }
                private static void _Номер_постановления_SetImplementationValue(global::LightSwitchApplication.Решение_СудаItem.DetailsClass d, global::System.Nullable<int> v)
                {
                    d.ImplementationEntity.Номер_постановления = v;
                }
                private static void _Номер_постановления_OnValueChanged(global::LightSwitchApplication.Решение_СудаItem e)
                {
                    e.Номер_постановления_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, int>.Data _Cдела;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<global::System.DateTime>>.Data _Дата_решения_суда;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, string>.Data _Постановление;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<global::System.DateTime>>.Data _Дата_постановления;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Решение_СудаItem, global::LightSwitchApplication.Решение_СудаItem.DetailsClass, global::System.Nullable<int>>.Data _Номер_постановления;
            
        }
    
        #endregion
    }
    
    #endregion
}
