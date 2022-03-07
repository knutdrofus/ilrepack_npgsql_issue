using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace npgsql_ilrepack
{
    internal class TypeDiscoverer
    {
        private List<Type> types = new List<Type>();
        internal TypeDiscoverer(IEnumerable<Assembly> assemblies)
        {
            this.CollectTypes(assemblies);
        }
        private void CollectTypes(IEnumerable<Assembly> assemblies)
        {
            Parallel.ForEach(
                assemblies,
                assembly =>
                {
                    try
                    {
                        var typesInAssembly = assembly.GetTypes();
                        this.types.AddRange(typesInAssembly);
                    }
                    catch (ReflectionTypeLoadException ex)
                    {
                        MessageBox.Show(
                            $"Got {ex.LoaderExceptions.Length} loader exceptions. First message is: {ex.LoaderExceptions.First().Message}");
                    }
                });
        }
    }
}
