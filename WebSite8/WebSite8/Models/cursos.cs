//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSite8.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class cursos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cursos()
        {
            this.instrutor = new HashSet<instrutor>();
        }
    
        public int cursoID { get; set; }
        public string descricao { get; set; }
        public Nullable<int> creditos { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<instrutor> instrutor { get; set; }
    }
}