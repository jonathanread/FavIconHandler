﻿using System.Reflection;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using FavIconHandler;
using FavIconHandler.Sitefinity;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("FavIconHandler")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("FavIconHandler")]
[assembly: AssemblyCopyright("Copyright ©  2015")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Registers FavIconHandlerInstaller.PreApplicationStart() to be executed prior to the application start
[assembly: PreApplicationStartMethod(typeof(FavIconHandlerInstaller), "PreApplicationStart")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("25d047fc-8078-4c5d-a7aa-b1d7bbf82629")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.1.0.0")]
[assembly: AssemblyFileVersion("1.1.0.0")]
