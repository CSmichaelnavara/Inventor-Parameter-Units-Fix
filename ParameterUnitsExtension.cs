// Autodesk.Inventor.Interop.dll must be referenced
using System.Reflection;

namespace Inventor
{
    /// <summary>
    /// Gets/(Sets) the units of the parameter. Note that the units is always retrieved as a string, but may be set using a constant from UnitsTypeEnum. 'Set' may not be allowed on some parameter types."
    /// </summary>
    public static class ParameterUnitsExtension
    {
        // Types derived from Inventor.Parameter
        // DerivedParameter - Set is not allowed
        // ModelParameter
        // ReferenceParameter
        // TableParameter - Set is not allowed
        // UserParameter
        
        /// <summary>
        /// Gets the units of the parameter. Note that the units is always retrieved as a string
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string Units(this Parameter p) => GetUnits(p);

        /// <summary>
        /// Gets the units of the parameter. Note that the units is always retrieved as a string
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string Units(this DerivedParameter p) => GetUnits(p as Parameter);

        /// <summary>
        /// Gets the units of the parameter. Note that the units is always retrieved as a string
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string Units(this ModelParameter p) => GetUnits(p as Parameter);

        /// <summary>
        /// Gets the units of the parameter. Note that the units is always retrieved as a string
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string Units(this ReferenceParameter p) => GetUnits(p as Parameter);

        /// <summary>
        /// Gets the units of the parameter. Note that the units is always retrieved as a string
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string Units(this TableParameter p) => GetUnits(p as Parameter);

        /// <summary>
        /// Gets the units of the parameter. Note that the units is always retrieved as a string
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string Units(this UserParameter p) => GetUnits(p as Parameter);

        /// <summary>
        /// Sets the units of the parameter. Expected is string representing valid units specifier (mm, mm*mm, etc.)
        /// </summary>
        /// <param name="p"></param>
        /// <param name="units"></param>
        public static void Units(this Parameter p, string units) => SetUnits(p, units);

        /// <summary>
        /// Sets the units of the parameter. Expected is string representing valid units specifier (mm, mm*mm, etc.)
        /// </summary>
        /// <param name="p"></param>
        /// <param name="units"></param>
        public static void Units(this ModelParameter p, string units) => SetUnits(p as Parameter, units);

        /// <summary>
        /// Sets the units of the parameter. Expected is string representing valid units specifier (mm, mm*mm, etc.)
        /// </summary>
        /// <param name="p"></param>
        /// <param name="units"></param>
        public static void Units(this ReferenceParameter p, string units) => SetUnits(p as Parameter, units);

        /// <summary>
        /// Sets the units of the parameter. Expected is string representing valid units specifier (mm, mm*mm, etc.)
        /// </summary>
        /// <param name="p"></param>
        /// <param name="units"></param>
        public static void Units(this UserParameter p, string units) => SetUnits(p as Parameter, units);


        /// <summary>
        /// Sets the units of the parameter.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="units"></param>
        public static void Units(this Parameter p, UnitsTypeEnum units) => SetUnits(p, units);

        /// <summary>
        /// Sets the units of the parameter.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="units"></param>
        public static void Units(this ModelParameter p, UnitsTypeEnum units) => SetUnits(p as Parameter, units);

        /// <summary>
        /// Sets the units of the parameter.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="units"></param>
        public static void Units(this ReferenceParameter p, UnitsTypeEnum units) => SetUnits(p as Parameter, units);

        /// <summary>
        /// Sets the units of the parameter.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="units"></param>
        public static void Units(this UserParameter p, UnitsTypeEnum units) => SetUnits(p as Parameter, units);


        private static string GetUnits(Parameter p) =>
            typeof(Parameter).InvokeMember("Units", BindingFlags.GetProperty, null, p, null).ToString();

        private static void SetUnits(Parameter p, object value) =>
            typeof(Parameter).InvokeMember("Units", BindingFlags.SetProperty, null, p, new[] {value});
    }
}