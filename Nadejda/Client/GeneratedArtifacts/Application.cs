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
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    public sealed partial class Application
        : global::Microsoft.LightSwitch.Framework.Client.ClientApplication<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass, global::LightSwitchApplication.DataWorkspace>
    {
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Application(global::Microsoft.LightSwitch.Model.IApplicationDefinition applicationDefinition) : base(applicationDefinition)
        {
            global::LightSwitchApplication.Application.DetailsClass.Initialize(this);
        }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Application_Initialize();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Application_LoggedIn();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static new global::LightSwitchApplication.Application Current
        {
            get
            {
                return (global::LightSwitchApplication.Application)global::Microsoft.LightSwitch.Framework.Client.ClientApplication<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Current;
            }
        }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Персональные_данныеItemDetail_CanRun(ref bool result, int Персональные_данныеItemЛичный_номер);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Персональные_данныеItemDetail_Run(ref bool handled, int Персональные_данныеItemЛичный_номер);
    
        /// <summary>
        /// Opens the ShowПерсональные_данныеItemDetail screen.  If the screen is already opened, it is activated and shown.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void ShowПерсональные_данныеItemDetail(int Персональные_данныеItemЛичный_номер)
        {
            ((global::Microsoft.LightSwitch.Details.Client.IClientApplicationDetails)this.Details).InvokeMethod(this.Details.Methods.ShowПерсональные_данныеItemDetail, Персональные_данныеItemЛичный_номер);
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Персональные_данныеListDetail_CanRun(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Персональные_данныеListDetail_Run(ref bool handled);
    
        /// <summary>
        /// Opens the ShowПерсональные_данныеListDetail screen.  If the screen is already opened, it is activated and shown.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void ShowПерсональные_данныеListDetail()
        {
            ((global::Microsoft.LightSwitch.Details.Client.IClientApplicationDetails)this.Details).InvokeMethod(this.Details.Methods.ShowПерсональные_данныеListDetail);
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CreateNewПерсональные_данныеItem_CanRun(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CreateNewПерсональные_данныеItem_Run(ref bool handled);
    
        /// <summary>
        /// Opens a new instance of the ShowCreateNewПерсональные_данныеItem screen.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void ShowCreateNewПерсональные_данныеItem()
        {
            ((global::Microsoft.LightSwitch.Details.Client.IClientApplicationDetails)this.Details).InvokeMethod(this.Details.Methods.ShowCreateNewПерсональные_данныеItem);
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass
            : global::Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationDetails<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass, global::LightSwitchApplication.Application.DetailsClass.PropertySet, global::LightSwitchApplication.Application.DetailsClass.CommandSet, global::LightSwitchApplication.Application.DetailsClass.MethodSet>
        {

            static DetailsClass()
            {
                var initializeCommandEntry = global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties.ShowПерсональные_данныеListDetail;
                var initializeMethodEntry = global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties.ShowПерсональные_данныеItemDetail;
            }

            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationDetails<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                __ApplicationEntry = new global::Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationDetails<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                    global::LightSwitchApplication.Application.DetailsClass.__Application_Initialized,
                    global::LightSwitchApplication.Application.DetailsClass.__Application_LoggedIn);
            private static void __Application_Initialized(global::LightSwitchApplication.Application a)
            {
                a.Application_Initialize();
            }
            private static void __Application_LoggedIn(global::LightSwitchApplication.Application a)
            {
                a.Application_LoggedIn();
            }

            public DetailsClass() : base()
            {
            }

            public new global::LightSwitchApplication.Application.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }

            public new global::LightSwitchApplication.Application.DetailsClass.CommandSet Commands
            {
                get
                {
                    return base.Commands;
                }
            }

            public new global::LightSwitchApplication.Application.DetailsClass.MethodSet Methods
            {
                get
                {
                    return base.Methods;
                }
            }

            protected override global::Microsoft.LightSwitch.Client.IScreenObject CreateScreen(string screenName, params object[] args)
            {
                switch (screenName)
                {
                    case "Персональные_данныеItemDetail":
                        return global::LightSwitchApplication.Персональные_данныеItemDetail.CreateInstance((int)args[0]);
                    case "Персональные_данныеListDetail":
                        return global::LightSwitchApplication.Персональные_данныеListDetail.CreateInstance();
                    case "CreateNewПерсональные_данныеItem":
                        return global::LightSwitchApplication.CreateNewПерсональные_данныеItem.CreateInstance();
                }
            
                return base.CreateScreen(screenName, args);
            }
            
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationPropertySet<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>
            {

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class CommandSet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationCommandSet<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>
            {

                public global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass> ShowПерсональные_данныеListDetail
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>)
                               base.GetItem(global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties.ShowПерсональные_данныеListDetail);
                    }
                }

                public global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass> ShowCreateNewПерсональные_данныеItem
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>)
                               base.GetItem(global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties.ShowCreateNewПерсональные_данныеItem);
                    }
                }

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class MethodSet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationMethodSet<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>
            {

                public global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass> ShowПерсональные_данныеItemDetail
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>)
                               base.GetItem(global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties.ShowПерсональные_данныеItemDetail);
                    }
                }

                public global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass> ShowПерсональные_данныеListDetail
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>)
                               base.GetItem(global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties.ShowПерсональные_данныеListDetail);
                    }
                }

                public global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass> ShowCreateNewПерсональные_данныеItem
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>)
                               base.GetItem(global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties.ShowCreateNewПерсональные_данныеItem);
                    }
                }

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class PropertySetProperties
            {

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class CommandSetProperties
            {

                public static readonly global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                    ShowПерсональные_данныеListDetail = new global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                        "ShowПерсональные_данныеListDetail",
                        global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowПерсональные_данныеListDetail_Stub,
                        global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowПерсональные_данныеListDetail_CreateExecutableObject);
                private static void _ShowПерсональные_данныеListDetail_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Application.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data> c, global::LightSwitchApplication.Application.DetailsClass d, object sf)
                {
                    c(d, ref d._ShowПерсональные_данныеListDetailCommand, sf);
                }
                private static global::Microsoft.LightSwitch.IExecutable _ShowПерсональные_данныеListDetail_CreateExecutableObject(global::LightSwitchApplication.Application.DetailsClass d)
                {
                    return ((global::LightSwitchApplication.Application.DetailsClass)d).Methods.ShowПерсональные_данныеListDetail.CreateInvocation(new object[0]);
                }

                public static readonly global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                    ShowCreateNewПерсональные_данныеItem = new global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                        "ShowCreateNewПерсональные_данныеItem",
                        global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowCreateNewПерсональные_данныеItem_Stub,
                        global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowCreateNewПерсональные_данныеItem_CreateExecutableObject);
                private static void _ShowCreateNewПерсональные_данныеItem_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Application.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data> c, global::LightSwitchApplication.Application.DetailsClass d, object sf)
                {
                    c(d, ref d._ShowCreateNewПерсональные_данныеItemCommand, sf);
                }
                private static global::Microsoft.LightSwitch.IExecutable _ShowCreateNewПерсональные_данныеItem_CreateExecutableObject(global::LightSwitchApplication.Application.DetailsClass d)
                {
                    return ((global::LightSwitchApplication.Application.DetailsClass)d).Methods.ShowCreateNewПерсональные_данныеItem.CreateInvocation(new object[0]);
                }

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class MethodSetProperties
            {

                public static readonly global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                    ShowПерсональные_данныеItemDetail = new global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                        "ShowПерсональные_данныеItemDetail",
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowПерсональные_данныеItemDetail_Stub,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowПерсональные_данныеItemDetail_CanInvoke,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowПерсональные_данныеItemDetail_InvokeMethod);
                private static void _ShowПерсональные_данныеItemDetail_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Application.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data> c, global::LightSwitchApplication.Application.DetailsClass d, object sf)
                {
                    c(d, ref d._ShowПерсональные_данныеItemDetailMethod, sf);
                }
                private static global::System.Exception _ShowПерсональные_данныеItemDetail_CanInvoke(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args, global::System.Exception ex)
                {
                    bool result = true;
                    d.Application.Персональные_данныеItemDetail_CanRun(ref result, (int)args[0]);
                    return result ? null : ex;
                }
                private static void _ShowПерсональные_данныеItemDetail_InvokeMethod(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args)
                {
                    bool handled = false;
                    d.Application.Персональные_данныеItemDetail_Run(ref handled, (int)args[0]);
                    if (!handled)
                    {
                        d.ShowScreen("LightSwitchApplication:Персональные_данныеItemDetail", () => global::LightSwitchApplication.Персональные_данныеItemDetail.CreateInstance((int)args[0]), args);
                    }
                }
 
                public static readonly global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                    ShowПерсональные_данныеListDetail = new global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                        "ShowПерсональные_данныеListDetail",
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowПерсональные_данныеListDetail_Stub,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowПерсональные_данныеListDetail_CanInvoke,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowПерсональные_данныеListDetail_InvokeMethod);
                private static void _ShowПерсональные_данныеListDetail_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Application.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data> c, global::LightSwitchApplication.Application.DetailsClass d, object sf)
                {
                    c(d, ref d._ShowПерсональные_данныеListDetailMethod, sf);
                }
                private static global::System.Exception _ShowПерсональные_данныеListDetail_CanInvoke(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args, global::System.Exception ex)
                {
                    bool result = true;
                    d.Application.Персональные_данныеListDetail_CanRun(ref result);
                    return result ? null : ex;
                }
                private static void _ShowПерсональные_данныеListDetail_InvokeMethod(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args)
                {
                    bool handled = false;
                    d.Application.Персональные_данныеListDetail_Run(ref handled);
                    if (!handled)
                    {
                        d.ShowScreen("LightSwitchApplication:Персональные_данныеListDetail", () => global::LightSwitchApplication.Персональные_данныеListDetail.CreateInstance(), args);
                    }
                }
 
                public static readonly global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                    ShowCreateNewПерсональные_данныеItem = new global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                        "ShowCreateNewПерсональные_данныеItem",
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowCreateNewПерсональные_данныеItem_Stub,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowCreateNewПерсональные_данныеItem_CanInvoke,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowCreateNewПерсональные_данныеItem_InvokeMethod);
                private static void _ShowCreateNewПерсональные_данныеItem_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Application.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data> c, global::LightSwitchApplication.Application.DetailsClass d, object sf)
                {
                    c(d, ref d._ShowCreateNewПерсональные_данныеItemMethod, sf);
                }
                private static global::System.Exception _ShowCreateNewПерсональные_данныеItem_CanInvoke(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args, global::System.Exception ex)
                {
                    bool result = true;
                    d.Application.CreateNewПерсональные_данныеItem_CanRun(ref result);
                    return result ? null : ex;
                }
                private static void _ShowCreateNewПерсональные_данныеItem_InvokeMethod(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args)
                {
                    bool handled = false;
                    d.Application.CreateNewПерсональные_данныеItem_Run(ref handled);
                    if (!handled)
                    {
                        d.ShowScreen("LightSwitchApplication:CreateNewПерсональные_данныеItem", () => global::LightSwitchApplication.CreateNewПерсональные_данныеItem.CreateInstance(), args);
                    }
                }
 
            }

            private global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data _ShowПерсональные_данныеItemDetailMethod;

            private global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data _ShowПерсональные_данныеListDetailMethod;

            private global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data _ShowCreateNewПерсональные_данныеItemMethod;

            private global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data _ShowПерсональные_данныеListDetailCommand;

            private global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data _ShowCreateNewПерсональные_данныеItemCommand;

        }
    }
}
namespace LightSwitchApplication
{
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Model.IModuleDefinitionLoader))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Microsoft.LightSwitch.Model.ModuleDefinitionLoader("LightSwitchApplication")]
    public class ClientModuleLoader : global::Microsoft.LightSwitch.Model.IModuleDefinitionLoader
    {
        public global::System.Resources.ResourceManager GetModelResourceManager()
        {
            return null;
        }

        public global::System.Collections.Generic.IEnumerable<global::System.IO.Stream> LoadModelFragments()
        {
            global::System.Reflection.Assembly assembly = global::System.Reflection.Assembly.GetExecutingAssembly();
            global::System.Collections.Generic.List<global::System.IO.Stream> streams = new global::System.Collections.Generic.List<global::System.IO.Stream>();

            foreach (string resourceName in assembly.GetManifestResourceNames())
            {
                if (resourceName.EndsWith(".lsml", global::System.StringComparison.OrdinalIgnoreCase))
                {
                    streams.Add(assembly.GetManifestResourceStream(resourceName));
                }
            }

            return streams;
        }
    }
}
