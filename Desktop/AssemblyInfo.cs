using Game;
using System.Reflection;

[assembly: AssemblyTitle(AppInfo.Title)]
[assembly: AssemblyProduct(AppInfo.Title)]
[assembly: AssemblyDescription(AppInfo.Description)]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCompany(AppInfo.Developer)]
[assembly: AssemblyCopyright("Copyright © " + AppInfo.Developer + " " + AppInfo.CopyrightYear)]
[assembly: AssemblyVersion(AppInfo.Version)]