# ilrepack_npgsql_issue

1. Restore nuget packages and compile.
2. Test run application. Should show a blank, white window.
3. Update ilrepack.cmd to point to ilrepack.exe
4. Run ilrepack.cmd to overwrite output assembly. This was just a hack around not being able to find MainWindow.xaml otherwise.
5. Run updated, merged exe. Should show error message in messagebox with error "Derived method 'Read' in type 'Npgsql.TypeHandling.NpgsqlSimpleTypeHandler`1' from assembly '*merged assembly name*, Version=*version*, Culture=neutral, PublicKeyToken=null' cannot reduce access."

In my real scenario this isn't an exe but a plugin dll for autodesk revit, and the typediscovery/IOC logic is way more complex and not trivial to write around.

This relates to https://github.com/gluck/il-repack/issues/219 and/or https://github.com/gluck/il-repack/pull/278
