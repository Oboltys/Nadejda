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
    public sealed partial class Улучшение_жильяItem : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Улучшение_жильяItem entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Улучшение_жильяItem()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Улучшение_жильяItem(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Улучшение_жильяItem> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Улучшение_жильяItem_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Улучшение_жильяItem_AllowSaveWithErrors(ref bool result);
    
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
        public int Личный_номер
        {
            get
            {
                return global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.GetValue(this, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties.Личный_номер);
            }
            set
            {
                global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.SetValue(this, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties.Личный_номер, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Личный_номер_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Личный_номер_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Личный_номер_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Nullable<int> C_льготной_очереди_по_улучшению_жилья
        {
            get
            {
                return global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.GetValue(this, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties.C_льготной_очереди_по_улучшению_жилья);
            }
            set
            {
                global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.SetValue(this, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties.C_льготной_очереди_по_улучшению_жилья, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void C_льготной_очереди_по_улучшению_жилья_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void C_льготной_очереди_по_улучшению_жилья_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void C_льготной_очереди_по_улучшению_жилья_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Nullable<global::System.DateTime> Дата_постановки_на_очередь
        {
            get
            {
                return global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.GetValue(this, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties.Дата_постановки_на_очередь);
            }
            set
            {
                global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.SetValue(this, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties.Дата_постановки_на_очередь, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Дата_постановки_на_очередь_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Дата_постановки_на_очередь_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Дата_постановки_на_очередь_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.Персональные_данныеItem Персональные_данныеItem
        {
            get
            {
                return global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.GetValue(this, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties.Персональные_данныеItem);
            }
            set
            {
                global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.SetValue(this, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties.Персональные_данныеItem, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Персональные_данныеItem_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Персональные_данныеItem_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Персональные_данныеItem_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Улучшение_жильяItem,
                global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass,
                global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.IImplementation,
                global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties.Личный_номер;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass>.Entry
                __Улучшение_жильяItemEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass>.Entry(
                    global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.__Улучшение_жильяItem_CreateNew,
                    global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.__Улучшение_жильяItem_Created,
                    global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.__Улучшение_жильяItem_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Улучшение_жильяItem __Улучшение_жильяItem_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Улучшение_жильяItem> es)
            {
                return new global::LightSwitchApplication.Улучшение_жильяItem(es);
            }
            private static void __Улучшение_жильяItem_Created(global::LightSwitchApplication.Улучшение_жильяItem e)
            {
                e.Улучшение_жильяItem_Created();
            }
            private static bool __Улучшение_жильяItem_AllowSaveWithErrors(global::LightSwitchApplication.Улучшение_жильяItem e)
            {
                bool result = false;
                e.Улучшение_жильяItem_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySet Properties
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
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, int> Личный_номер
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties.Личный_номер) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::System.Nullable<int>> C_льготной_очереди_по_улучшению_жилья
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties.C_льготной_очереди_по_улучшению_жилья) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::System.Nullable<int>>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::System.Nullable<global::System.DateTime>> Дата_постановки_на_очередь
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties.Дата_постановки_на_очередь) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::System.Nullable<global::System.DateTime>>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::LightSwitchApplication.Персональные_данныеItem> Персональные_данныеItem
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties.Персональные_данныеItem) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::LightSwitchApplication.Персональные_данныеItem>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Личный_номер { get; set; }
                new global::System.Nullable<int> C_льготной_очереди_по_улучшению_жилья { get; set; }
                new global::System.Nullable<global::System.DateTime> Дата_постановки_на_очередь { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation Персональные_данныеItem { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, int>.Entry
                    Личный_номер = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, int>.Entry(
                        "Личный_номер",
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Личный_номер_Stub,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Личный_номер_ComputeIsReadOnly,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Личный_номер_Validate,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Личный_номер_GetImplementationValue,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Личный_номер_SetImplementationValue,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Личный_номер_OnValueChanged);
                private static void _Личный_номер_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, int>.Data> c, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass d, object sf)
                {
                    c(d, ref d._Личный_номер, sf);
                }
                private static bool _Личный_номер_ComputeIsReadOnly(global::LightSwitchApplication.Улучшение_жильяItem e)
                {
                    bool result = false;
                    e.Личный_номер_IsReadOnly(ref result);
                    return result;
                }
                private static void _Личный_номер_Validate(global::LightSwitchApplication.Улучшение_жильяItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Личный_номер_Validate(r);
                }
                private static int _Личный_номер_GetImplementationValue(global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass d)
                {
                    return d.ImplementationEntity.Личный_номер;
                }
                private static void _Личный_номер_SetImplementationValue(global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Личный_номер = v;
                }
                private static void _Личный_номер_OnValueChanged(global::LightSwitchApplication.Улучшение_жильяItem e)
                {
                    e.Личный_номер_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::System.Nullable<int>>.Entry
                    C_льготной_очереди_по_улучшению_жилья = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::System.Nullable<int>>.Entry(
                        "C_льготной_очереди_по_улучшению_жилья",
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._C_льготной_очереди_по_улучшению_жилья_Stub,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._C_льготной_очереди_по_улучшению_жилья_ComputeIsReadOnly,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._C_льготной_очереди_по_улучшению_жилья_Validate,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._C_льготной_очереди_по_улучшению_жилья_GetImplementationValue,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._C_льготной_очереди_по_улучшению_жилья_SetImplementationValue,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._C_льготной_очереди_по_улучшению_жилья_OnValueChanged);
                private static void _C_льготной_очереди_по_улучшению_жилья_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::System.Nullable<int>>.Data> c, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass d, object sf)
                {
                    c(d, ref d._C_льготной_очереди_по_улучшению_жилья, sf);
                }
                private static bool _C_льготной_очереди_по_улучшению_жилья_ComputeIsReadOnly(global::LightSwitchApplication.Улучшение_жильяItem e)
                {
                    bool result = false;
                    e.C_льготной_очереди_по_улучшению_жилья_IsReadOnly(ref result);
                    return result;
                }
                private static void _C_льготной_очереди_по_улучшению_жилья_Validate(global::LightSwitchApplication.Улучшение_жильяItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.C_льготной_очереди_по_улучшению_жилья_Validate(r);
                }
                private static global::System.Nullable<int> _C_льготной_очереди_по_улучшению_жилья_GetImplementationValue(global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass d)
                {
                    return d.ImplementationEntity.C_льготной_очереди_по_улучшению_жилья;
                }
                private static void _C_льготной_очереди_по_улучшению_жилья_SetImplementationValue(global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass d, global::System.Nullable<int> v)
                {
                    d.ImplementationEntity.C_льготной_очереди_по_улучшению_жилья = v;
                }
                private static void _C_льготной_очереди_по_улучшению_жилья_OnValueChanged(global::LightSwitchApplication.Улучшение_жильяItem e)
                {
                    e.C_льготной_очереди_по_улучшению_жилья_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::System.Nullable<global::System.DateTime>>.Entry
                    Дата_постановки_на_очередь = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::System.Nullable<global::System.DateTime>>.Entry(
                        "Дата_постановки_на_очередь",
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Дата_постановки_на_очередь_Stub,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Дата_постановки_на_очередь_ComputeIsReadOnly,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Дата_постановки_на_очередь_Validate,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Дата_постановки_на_очередь_GetImplementationValue,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Дата_постановки_на_очередь_SetImplementationValue,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Дата_постановки_на_очередь_OnValueChanged);
                private static void _Дата_постановки_на_очередь_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::System.Nullable<global::System.DateTime>>.Data> c, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass d, object sf)
                {
                    c(d, ref d._Дата_постановки_на_очередь, sf);
                }
                private static bool _Дата_постановки_на_очередь_ComputeIsReadOnly(global::LightSwitchApplication.Улучшение_жильяItem e)
                {
                    bool result = false;
                    e.Дата_постановки_на_очередь_IsReadOnly(ref result);
                    return result;
                }
                private static void _Дата_постановки_на_очередь_Validate(global::LightSwitchApplication.Улучшение_жильяItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Дата_постановки_на_очередь_Validate(r);
                }
                private static global::System.Nullable<global::System.DateTime> _Дата_постановки_на_очередь_GetImplementationValue(global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass d)
                {
                    return d.ImplementationEntity.Дата_постановки_на_очередь;
                }
                private static void _Дата_постановки_на_очередь_SetImplementationValue(global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass d, global::System.Nullable<global::System.DateTime> v)
                {
                    d.ImplementationEntity.Дата_постановки_на_очередь = global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.ClearDateTimeKind(v);
                }
                private static void _Дата_постановки_на_очередь_OnValueChanged(global::LightSwitchApplication.Улучшение_жильяItem e)
                {
                    e.Дата_постановки_на_очередь_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::LightSwitchApplication.Персональные_данныеItem>.Entry
                    Персональные_данныеItem = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::LightSwitchApplication.Персональные_данныеItem>.Entry(
                        "Персональные_данныеItem",
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Персональные_данныеItem_Stub,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Персональные_данныеItem_ComputeIsReadOnly,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Персональные_данныеItem_Validate,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Персональные_данныеItem_GetCoreImplementationValue,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Персональные_данныеItem_GetImplementationValue,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Персональные_данныеItem_SetImplementationValue,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Персональные_данныеItem_Refresh,
                        global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties._Персональные_данныеItem_OnValueChanged);
                private static void _Персональные_данныеItem_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::LightSwitchApplication.Персональные_данныеItem>.Data> c, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass d, object sf)
                {
                    c(d, ref d._Персональные_данныеItem, sf);
                }
                private static bool _Персональные_данныеItem_ComputeIsReadOnly(global::LightSwitchApplication.Улучшение_жильяItem e)
                {
                    bool result = false;
                    e.Персональные_данныеItem_IsReadOnly(ref result);
                    return result;
                }
                private static void _Персональные_данныеItem_Validate(global::LightSwitchApplication.Улучшение_жильяItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Персональные_данныеItem_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _Персональные_данныеItem_GetCoreImplementationValue(global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass d)
                {
                    return d.ImplementationEntity.Персональные_данныеItem;
                }
                private static global::LightSwitchApplication.Персональные_данныеItem _Персональные_данныеItem_GetImplementationValue(global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.Персональные_данныеItem, global::LightSwitchApplication.Персональные_данныеItem.DetailsClass>(global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties.Персональные_данныеItem, ref d._Персональные_данныеItem);
                }
                private static void _Персональные_данныеItem_SetImplementationValue(global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass d, global::LightSwitchApplication.Персональные_данныеItem v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties.Персональные_данныеItem, ref d._Персональные_данныеItem, (i, ev) => i.Персональные_данныеItem = ev, v);
                }
                private static void _Персональные_данныеItem_Refresh(global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass.PropertySetProperties.Персональные_данныеItem, ref d._Персональные_данныеItem);
                }
                private static void _Персональные_данныеItem_OnValueChanged(global::LightSwitchApplication.Улучшение_жильяItem e)
                {
                    e.Персональные_данныеItem_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, int>.Data _Личный_номер;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::System.Nullable<int>>.Data _C_льготной_очереди_по_улучшению_жилья;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::System.Nullable<global::System.DateTime>>.Data _Дата_постановки_на_очередь;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Улучшение_жильяItem, global::LightSwitchApplication.Улучшение_жильяItem.DetailsClass, global::LightSwitchApplication.Персональные_данныеItem>.Data _Персональные_данныеItem;
            
        }
    
        #endregion
    }
    
    #endregion
}