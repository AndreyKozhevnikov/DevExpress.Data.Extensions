﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevExpress.Data.Extensions.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DevExpress.Data.Extensions.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на The array can be initialized only with constant values. The provided expression is not a constant: {0}.
        /// </summary>
        internal static string ArrayInitRequiresConstantException {
            get {
                return ResourceManager.GetString("ArrayInitRequiresConstantException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Collection property is absent in the expression:
        ///{0}.
        /// </summary>
        internal static string CollectionPropertyAbsentException {
            get {
                return ResourceManager.GetString("CollectionPropertyAbsentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Cannot obtain the collection argument for the Contains method: {0}.
        /// </summary>
        internal static string ContainsRequiresArrayException {
            get {
                return ResourceManager.GetString("ContainsRequiresArrayException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на The conversion operation is not supported between types {0} and {1}..
        /// </summary>
        internal static string ConversionNotSupportedException {
            get {
                return ResourceManager.GetString("ConversionNotSupportedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на The {0} expression is not supported..
        /// </summary>
        internal static string ExpressionNotSupportedException {
            get {
                return ResourceManager.GetString("ExpressionNotSupportedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Access to member {0} requires specific expression. Expected: ([EndDate].Date - [StartDate].Date), actual: {1}..
        /// </summary>
        internal static string MemberAccessRequiredExpressionException {
            get {
                return ResourceManager.GetString("MemberAccessRequiredExpressionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на The {0} method is not supported..
        /// </summary>
        internal static string MethodNotSupportedException {
            get {
                return ResourceManager.GetString("MethodNotSupportedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Cannot evaluate expression: {0}.
        /// </summary>
        internal static string NewNotSupported {
            get {
                return ResourceManager.GetString("NewNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на The Trim method with arguments is not supported..
        /// </summary>
        internal static string TrimMethodNotSupportedException {
            get {
                return ResourceManager.GetString("TrimMethodNotSupportedException", resourceCulture);
            }
        }
    }
}