//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fabio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class USUARIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIOS()
        {
            this.MODULO_USUARIO = new HashSet<MODULO_USUARIO>();
        }
    
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string contraseña { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string sector { get; set; }
        public string acceso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MODULO_USUARIO> MODULO_USUARIO { get; set; }
    }
}
